/* file "MusicInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public abstract class MusicInformationNuggetJSON : InformationNuggetJSON
  {
    public enum TypeEntitySpecificationTypeKnownValues
      {
        EntitySpecificationType_Explicit,
        EntitySpecificationType_This,
        EntitySpecificationType_ListPosition,
        EntitySpecificationType_Relative,
        EntitySpecificationType__none
      };
    public struct TypeEntitySpecificationType
      {
        public bool in_known_list;
        public string string_value;
        public TypeEntitySpecificationTypeKnownValues list_value;
      };

    public static TypeEntitySpecificationTypeKnownValues  stringToEntitySpecificationType(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if ((String.Compare(chars, 1, "xplicit", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_Explicit;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "istPosition", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_ListPosition;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "elative", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_Relative;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "his", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_This;
                break;
            default:
                break;
          }
        return TypeEntitySpecificationTypeKnownValues.EntitySpecificationType__none;
      }

    public static string  stringFromEntitySpecificationType(TypeEntitySpecificationTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_Explicit:
                return "Explicit";
            case TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_This:
                return "This";
            case TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_ListPosition:
                return "ListPosition";
            case TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_Relative:
                return "Relative";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasSearchParameters;
    private MusicSearchParametersJSON  storeSearchParameters;
    private bool flagHasAlbumsLabel;
    private string storeAlbumsLabel;
    private bool flagHasAlbums;
    private List< MusicAlbumJSON  > storeAlbums;
    private bool flagHasArtistsLabel;
    private string storeArtistsLabel;
    private bool flagHasArtists;
    private List< MusicArtistJSON  > storeArtists;
    private bool flagHasTracksLabel;
    private string storeTracksLabel;
    private bool flagHasTracks;
    private List< MusicTrackJSON  > storeTracks;
    private bool flagHasSupplementalTrackInfos;
    private List< MusicTrackSupplementalInfoJSON  > storeSupplementalTrackInfos;
    private bool flagHasUserRequestedAll;
    private bool storeUserRequestedAll;
    private bool flagHasArtistSpecified;
    private bool storeArtistSpecified;
    private bool flagHasQueryArtists;
    private List< MusicArtistJSON  > storeQueryArtists;
    private bool flagHasEntitySpecificationType;
    private TypeEntitySpecificationType storeEntitySpecificationType;
    private bool flagHasMusicThirdParty;
    private MusicThirdPartyJSON  storeMusicThirdParty;
    private bool flagHasListPosition;
    private BigInteger storeListPosition;
    private bool flagHasErrors;
    private List< MusicSearchErrorJSON  > storeErrors;


    private JSONValue  extraSearchParametersToJSON()
      {
        JSONValueHandler handler_SearchParameters = new JSONValueHandler();
        storeSearchParameters.write_as_json(handler_SearchParameters);
        return handler_SearchParameters.result;
      }

    private JSONValue  extraAlbumsLabelToJSON()
      {
        JSONStringValue generated_string_AlbumsLabel = new JSONStringValue(storeAlbumsLabel);
        return generated_string_AlbumsLabel;
      }

    private JSONValue  extraAlbumsToJSON()
      {
        JSONArrayValue generated_array_1_Albums = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAlbums.Count; ++num1)
          {
            JSONValueHandler handler_Albums = new JSONValueHandler();
            storeAlbums[num1].write_as_json(handler_Albums);
            generated_array_1_Albums.appendComponent(handler_Albums.result);
          }
        return generated_array_1_Albums;
      }

    private JSONValue  extraArtistsLabelToJSON()
      {
        JSONStringValue generated_string_ArtistsLabel = new JSONStringValue(storeArtistsLabel);
        return generated_string_ArtistsLabel;
      }

    private JSONValue  extraArtistsToJSON()
      {
        JSONArrayValue generated_array_2_Artists = new JSONArrayValue();
        for (int num2 = 0; num2 < storeArtists.Count; ++num2)
          {
            JSONValueHandler handler_Artists = new JSONValueHandler();
            storeArtists[num2].write_as_json(handler_Artists);
            generated_array_2_Artists.appendComponent(handler_Artists.result);
          }
        return generated_array_2_Artists;
      }

    private JSONValue  extraTracksLabelToJSON()
      {
        JSONStringValue generated_string_TracksLabel = new JSONStringValue(storeTracksLabel);
        return generated_string_TracksLabel;
      }

    private JSONValue  extraTracksToJSON()
      {
        JSONArrayValue generated_array_3_Tracks = new JSONArrayValue();
        for (int num3 = 0; num3 < storeTracks.Count; ++num3)
          {
            JSONValueHandler handler_Tracks = new JSONValueHandler();
            storeTracks[num3].write_as_json(handler_Tracks);
            generated_array_3_Tracks.appendComponent(handler_Tracks.result);
          }
        return generated_array_3_Tracks;
      }

    private JSONValue  extraSupplementalTrackInfosToJSON()
      {
        JSONArrayValue generated_array_4_SupplementalTrackInfos = new JSONArrayValue();
        for (int num4 = 0; num4 < storeSupplementalTrackInfos.Count; ++num4)
          {
            JSONValueHandler handler_SupplementalTrackInfos = new JSONValueHandler();
            storeSupplementalTrackInfos[num4].write_as_json(handler_SupplementalTrackInfos);
            generated_array_4_SupplementalTrackInfos.appendComponent(handler_SupplementalTrackInfos.result);
          }
        return generated_array_4_SupplementalTrackInfos;
      }

    private JSONValue  extraUserRequestedAllToJSON()
      {
        JSONValue generated_boolean_UserRequestedAll = (storeUserRequestedAll ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_UserRequestedAll;
      }

    private JSONValue  extraArtistSpecifiedToJSON()
      {
        JSONValue generated_boolean_ArtistSpecified = (storeArtistSpecified ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_ArtistSpecified;
      }

    private JSONValue  extraQueryArtistsToJSON()
      {
        JSONArrayValue generated_array_5_QueryArtists = new JSONArrayValue();
        for (int num5 = 0; num5 < storeQueryArtists.Count; ++num5)
          {
            JSONValueHandler handler_QueryArtists = new JSONValueHandler();
            storeQueryArtists[num5].write_as_json(handler_QueryArtists);
            generated_array_5_QueryArtists.appendComponent(handler_QueryArtists.result);
          }
        return generated_array_5_QueryArtists;
      }

    private JSONValue  extraEntitySpecificationTypeToJSON()
      {
        JSONStringValue generated_string_EntitySpecificationType;
        if (!(storeEntitySpecificationType.in_known_list))
          {
        generated_string_EntitySpecificationType = new JSONStringValue(storeEntitySpecificationType.string_value);
          }
        else
          {
        switch (storeEntitySpecificationType.list_value)
          {
            case TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_Explicit:
                generated_string_EntitySpecificationType = new JSONStringValue("Explicit");
                break;
            case TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_This:
                generated_string_EntitySpecificationType = new JSONStringValue("This");
                break;
            case TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_ListPosition:
                generated_string_EntitySpecificationType = new JSONStringValue("ListPosition");
                break;
            case TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_Relative:
                generated_string_EntitySpecificationType = new JSONStringValue("Relative");
                break;
            default:
                Debug.Assert(false);
                generated_string_EntitySpecificationType = null;
                break;
          }
          }
        return generated_string_EntitySpecificationType;
      }

    private JSONValue  extraMusicThirdPartyToJSON()
      {
        JSONValueHandler handler_MusicThirdParty = new JSONValueHandler();
        storeMusicThirdParty.write_as_json(handler_MusicThirdParty);
        return handler_MusicThirdParty.result;
      }

    private JSONValue  extraListPositionToJSON()
      {
        JSONIntegerValue generated_integer_ListPosition = new JSONIntegerValue(storeListPosition);
        return generated_integer_ListPosition;
      }

    private JSONValue  extraErrorsToJSON()
      {
        JSONArrayValue generated_array_6_Errors = new JSONArrayValue();
        for (int num6 = 0; num6 < storeErrors.Count; ++num6)
          {
            JSONValueHandler handler_Errors = new JSONValueHandler();
            storeErrors[num6].write_as_json(handler_Errors);
            generated_array_6_Errors.appendComponent(handler_Errors.result);
          }
        return generated_array_6_Errors;
      }


    private void  fromJSONSearchParameters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicSearchParametersJSON convert_classy = MusicSearchParametersJSON.from_json(json_value, ignore_extras, true);
        setSearchParameters(convert_classy);
      }


    private void  fromJSONAlbumsLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AlbumsLabel of MusicInformationNuggetJSON is not a string.");
        setAlbumsLabel(json_string.getData());
      }


    private void  fromJSONAlbums(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Albums of MusicInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MusicAlbumJSON  > vector_Albums1 = new List< MusicAlbumJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicAlbumJSON convert_classy = MusicAlbumJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Albums1.Add(convert_classy);
          }
        initAlbums();
        for (int num1 = 0; num1 < vector_Albums1.Count; ++num1)
            appendAlbums(vector_Albums1[num1]);
        for (int num1 = 0; num1 < vector_Albums1.Count; ++num1)
          {
          }
      }


    private void  fromJSONArtistsLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ArtistsLabel of MusicInformationNuggetJSON is not a string.");
        setArtistsLabel(json_string.getData());
      }


    private void  fromJSONArtists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Artists of MusicInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MusicArtistJSON  > vector_Artists1 = new List< MusicArtistJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicArtistJSON convert_classy = MusicArtistJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Artists1.Add(convert_classy);
          }
        initArtists();
        for (int num2 = 0; num2 < vector_Artists1.Count; ++num2)
            appendArtists(vector_Artists1[num2]);
        for (int num1 = 0; num1 < vector_Artists1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTracksLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TracksLabel of MusicInformationNuggetJSON is not a string.");
        setTracksLabel(json_string.getData());
      }


    private void  fromJSONTracks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Tracks of MusicInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MusicTrackJSON  > vector_Tracks1 = new List< MusicTrackJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicTrackJSON convert_classy = MusicTrackJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Tracks1.Add(convert_classy);
          }
        initTracks();
        for (int num3 = 0; num3 < vector_Tracks1.Count; ++num3)
            appendTracks(vector_Tracks1[num3]);
        for (int num1 = 0; num1 < vector_Tracks1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSupplementalTrackInfos(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SupplementalTrackInfos of MusicInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MusicTrackSupplementalInfoJSON  > vector_SupplementalTrackInfos1 = new List< MusicTrackSupplementalInfoJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicTrackSupplementalInfoJSON convert_classy = MusicTrackSupplementalInfoJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_SupplementalTrackInfos1.Add(convert_classy);
          }
        initSupplementalTrackInfos();
        for (int num4 = 0; num4 < vector_SupplementalTrackInfos1.Count; ++num4)
            appendSupplementalTrackInfos(vector_SupplementalTrackInfos1[num4]);
        for (int num1 = 0; num1 < vector_SupplementalTrackInfos1.Count; ++num1)
          {
          }
      }


    private void  fromJSONUserRequestedAll(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field UserRequestedAll of MusicInformationNuggetJSON is not true for false.");
              }
          }
        setUserRequestedAll(the_bool);
      }


    private void  fromJSONArtistSpecified(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field ArtistSpecified of MusicInformationNuggetJSON is not true for false.");
              }
          }
        setArtistSpecified(the_bool);
      }


    private void  fromJSONQueryArtists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueryArtists of MusicInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MusicArtistJSON  > vector_QueryArtists1 = new List< MusicArtistJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicArtistJSON convert_classy = MusicArtistJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_QueryArtists1.Add(convert_classy);
          }
        initQueryArtists();
        for (int num5 = 0; num5 < vector_QueryArtists1.Count; ++num5)
            appendQueryArtists(vector_QueryArtists1[num5]);
        for (int num1 = 0; num1 < vector_QueryArtists1.Count; ++num1)
          {
          }
      }


    private void  fromJSONEntitySpecificationType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EntitySpecificationType of MusicInformationNuggetJSON is not a string.");
        TypeEntitySpecificationType the_open_enum = new TypeEntitySpecificationType();
        switch (json_string.getData()[0])
          {
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "xplicit", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_Explicit;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "istPosition", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_ListPosition;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "elative", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_Relative;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "his", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_This;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setEntitySpecificationType(the_open_enum);
      }


    private void  fromJSONMusicThirdParty(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicThirdPartyJSON convert_classy = MusicThirdPartyJSON.from_json(json_value, ignore_extras, true);
        setMusicThirdParty(convert_classy);
      }


    private void  fromJSONListPosition(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ListPosition of MusicInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ListPosition of MusicInformationNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setListPosition(extracted_integer);
      }


    private void  fromJSONErrors(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Errors of MusicInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Errors of MusicInformationNuggetJSON has too few elements.");
        List< MusicSearchErrorJSON  > vector_Errors1 = new List< MusicSearchErrorJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicSearchErrorJSON convert_classy = MusicSearchErrorJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Errors1.Add(convert_classy);
          }
        Debug.Assert(vector_Errors1.Count >= 1);
        initErrors();
        for (int num6 = 0; num6 < vector_Errors1.Count; ++num6)
            appendErrors(vector_Errors1[num6]);
        for (int num1 = 0; num1 < vector_Errors1.Count; ++num1)
          {
          }
      }


    public MusicInformationNuggetJSON()
      {
        flagHasSearchParameters = false;
        flagHasAlbumsLabel = false;
        flagHasAlbums = false;
        flagHasArtistsLabel = false;
        flagHasArtists = false;
        flagHasTracksLabel = false;
        flagHasTracks = false;
        flagHasSupplementalTrackInfos = false;
        flagHasUserRequestedAll = false;
        flagHasArtistSpecified = false;
        flagHasQueryArtists = false;
        flagHasEntitySpecificationType = false;
        flagHasMusicThirdParty = false;
        flagHasListPosition = false;
        flagHasErrors = false;
        storeAlbums = new List< MusicAlbumJSON  >();
        storeArtists = new List< MusicArtistJSON  >();
        storeTracks = new List< MusicTrackJSON  >();
        storeSupplementalTrackInfos = new List< MusicTrackSupplementalInfoJSON  >();
        storeQueryArtists = new List< MusicArtistJSON  >();
        storeErrors = new List< MusicSearchErrorJSON  >();
      }

    public override string  getNuggetKind()
      {
        return "Music";
      }

    public abstract string getMusicNuggetKind();
    public bool  hasSearchParameters()
      {
        return flagHasSearchParameters;
      }

    public MusicSearchParametersJSON   getSearchParameters()
      {
        Debug.Assert(flagHasSearchParameters);
        return storeSearchParameters;
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

    public MusicAlbumJSON   elementOfAlbums(int element_num)
      {
        Debug.Assert(flagHasAlbums);
        return storeAlbums[element_num];
      }

    public List< MusicAlbumJSON  >  getAlbums()
      {
        Debug.Assert(flagHasAlbums);
        return storeAlbums;
      }

    public bool  hasArtistsLabel()
      {
        return flagHasArtistsLabel;
      }

    public string  getArtistsLabel()
      {
        Debug.Assert(flagHasArtistsLabel);
        return storeArtistsLabel;
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

    public MusicArtistJSON   elementOfArtists(int element_num)
      {
        Debug.Assert(flagHasArtists);
        return storeArtists[element_num];
      }

    public List< MusicArtistJSON  >  getArtists()
      {
        Debug.Assert(flagHasArtists);
        return storeArtists;
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

    public MusicTrackJSON   elementOfTracks(int element_num)
      {
        Debug.Assert(flagHasTracks);
        return storeTracks[element_num];
      }

    public List< MusicTrackJSON  >  getTracks()
      {
        Debug.Assert(flagHasTracks);
        return storeTracks;
      }

    public bool  hasSupplementalTrackInfos()
      {
        return flagHasSupplementalTrackInfos;
      }

    public int  countOfSupplementalTrackInfos()
      {
        Debug.Assert(flagHasSupplementalTrackInfos);
        return storeSupplementalTrackInfos.Count;
      }

    public MusicTrackSupplementalInfoJSON   elementOfSupplementalTrackInfos(int element_num)
      {
        Debug.Assert(flagHasSupplementalTrackInfos);
        return storeSupplementalTrackInfos[element_num];
      }

    public List< MusicTrackSupplementalInfoJSON  >  getSupplementalTrackInfos()
      {
        Debug.Assert(flagHasSupplementalTrackInfos);
        return storeSupplementalTrackInfos;
      }

    public bool  hasUserRequestedAll()
      {
        return flagHasUserRequestedAll;
      }

    public bool  getUserRequestedAll()
      {
        Debug.Assert(flagHasUserRequestedAll);
        return storeUserRequestedAll;
      }

    public bool  hasArtistSpecified()
      {
        return flagHasArtistSpecified;
      }

    public bool  getArtistSpecified()
      {
        Debug.Assert(flagHasArtistSpecified);
        return storeArtistSpecified;
      }

    public bool  hasQueryArtists()
      {
        return flagHasQueryArtists;
      }

    public int  countOfQueryArtists()
      {
        Debug.Assert(flagHasQueryArtists);
        return storeQueryArtists.Count;
      }

    public MusicArtistJSON   elementOfQueryArtists(int element_num)
      {
        Debug.Assert(flagHasQueryArtists);
        return storeQueryArtists[element_num];
      }

    public List< MusicArtistJSON  >  getQueryArtists()
      {
        Debug.Assert(flagHasQueryArtists);
        return storeQueryArtists;
      }

    public bool  hasEntitySpecificationType()
      {
        return flagHasEntitySpecificationType;
      }

    public TypeEntitySpecificationType  getEntitySpecificationType()
      {
        Debug.Assert(flagHasEntitySpecificationType);
        return storeEntitySpecificationType;
      }

    public string  getEntitySpecificationTypeAsString()
      {
        TypeEntitySpecificationType result = getEntitySpecificationType();
        if (result.in_known_list)
            return stringFromEntitySpecificationType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasMusicThirdParty()
      {
        return flagHasMusicThirdParty;
      }

    public MusicThirdPartyJSON   getMusicThirdParty()
      {
        Debug.Assert(flagHasMusicThirdParty);
        return storeMusicThirdParty;
      }

    public bool  hasListPosition()
      {
        return flagHasListPosition;
      }

    public BigInteger  getListPosition()
      {
        Debug.Assert(flagHasListPosition);
        return storeListPosition;
      }

    public bool  hasErrors()
      {
        return flagHasErrors;
      }

    public int  countOfErrors()
      {
        Debug.Assert(flagHasErrors);
        return storeErrors.Count;
      }

    public MusicSearchErrorJSON   elementOfErrors(int element_num)
      {
        Debug.Assert(flagHasErrors);
        return storeErrors[element_num];
      }

    public List< MusicSearchErrorJSON  >  getErrors()
      {
        Debug.Assert(flagHasErrors);
        return storeErrors;
      }


    public abstract int extraMusicInformationNuggetComponentCount();
    public abstract string extraMusicInformationNuggetComponentKey(int component_num);
    public abstract JSONValue extraMusicInformationNuggetComponentValue(int component_num);
    public abstract JSONValue extraMusicInformationNuggetLookup(string field_name);
    public override int extraInformationNuggetComponentCount()
      {
        int result = 1;
        if (flagHasSearchParameters)
            ++result;
        if (flagHasAlbumsLabel)
            ++result;
        if (flagHasAlbums)
            ++result;
        if (flagHasArtistsLabel)
            ++result;
        if (flagHasArtists)
            ++result;
        if (flagHasTracksLabel)
            ++result;
        if (flagHasTracks)
            ++result;
        if (flagHasSupplementalTrackInfos)
            ++result;
        if (flagHasUserRequestedAll)
            ++result;
        if (flagHasArtistSpecified)
            ++result;
        if (flagHasQueryArtists)
            ++result;
        if (flagHasEntitySpecificationType)
            ++result;
        if (flagHasMusicThirdParty)
            ++result;
        if (flagHasListPosition)
            ++result;
        if (flagHasErrors)
            ++result;
        result += extraMusicInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        if (component_num == 0)
            return "MusicNuggetKind";
        int remainder = (component_num - 1);
        if (flagHasSearchParameters)
          {
            if (remainder == 0)
                return "SearchParameters";
            --remainder;
          }
        if (flagHasAlbumsLabel)
          {
            if (remainder == 0)
                return "AlbumsLabel";
            --remainder;
          }
        if (flagHasAlbums)
          {
            if (remainder == 0)
                return "Albums";
            --remainder;
          }
        if (flagHasArtistsLabel)
          {
            if (remainder == 0)
                return "ArtistsLabel";
            --remainder;
          }
        if (flagHasArtists)
          {
            if (remainder == 0)
                return "Artists";
            --remainder;
          }
        if (flagHasTracksLabel)
          {
            if (remainder == 0)
                return "TracksLabel";
            --remainder;
          }
        if (flagHasTracks)
          {
            if (remainder == 0)
                return "Tracks";
            --remainder;
          }
        if (flagHasSupplementalTrackInfos)
          {
            if (remainder == 0)
                return "SupplementalTrackInfos";
            --remainder;
          }
        if (flagHasUserRequestedAll)
          {
            if (remainder == 0)
                return "UserRequestedAll";
            --remainder;
          }
        if (flagHasArtistSpecified)
          {
            if (remainder == 0)
                return "ArtistSpecified";
            --remainder;
          }
        if (flagHasQueryArtists)
          {
            if (remainder == 0)
                return "QueryArtists";
            --remainder;
          }
        if (flagHasEntitySpecificationType)
          {
            if (remainder == 0)
                return "EntitySpecificationType";
            --remainder;
          }
        if (flagHasMusicThirdParty)
          {
            if (remainder == 0)
                return "MusicThirdParty";
            --remainder;
          }
        if (flagHasListPosition)
          {
            if (remainder == 0)
                return "ListPosition";
            --remainder;
          }
        if (flagHasErrors)
          {
            if (remainder == 0)
                return "Errors";
            --remainder;
          }
        return extraMusicInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getMusicNuggetKind());
        int remainder = (component_num - 1);
        if (flagHasSearchParameters)
          {
            if (remainder == 0)
                return extraSearchParametersToJSON();
            --remainder;
          }
        if (flagHasAlbumsLabel)
          {
            if (remainder == 0)
                return extraAlbumsLabelToJSON();
            --remainder;
          }
        if (flagHasAlbums)
          {
            if (remainder == 0)
                return extraAlbumsToJSON();
            --remainder;
          }
        if (flagHasArtistsLabel)
          {
            if (remainder == 0)
                return extraArtistsLabelToJSON();
            --remainder;
          }
        if (flagHasArtists)
          {
            if (remainder == 0)
                return extraArtistsToJSON();
            --remainder;
          }
        if (flagHasTracksLabel)
          {
            if (remainder == 0)
                return extraTracksLabelToJSON();
            --remainder;
          }
        if (flagHasTracks)
          {
            if (remainder == 0)
                return extraTracksToJSON();
            --remainder;
          }
        if (flagHasSupplementalTrackInfos)
          {
            if (remainder == 0)
                return extraSupplementalTrackInfosToJSON();
            --remainder;
          }
        if (flagHasUserRequestedAll)
          {
            if (remainder == 0)
                return extraUserRequestedAllToJSON();
            --remainder;
          }
        if (flagHasArtistSpecified)
          {
            if (remainder == 0)
                return extraArtistSpecifiedToJSON();
            --remainder;
          }
        if (flagHasQueryArtists)
          {
            if (remainder == 0)
                return extraQueryArtistsToJSON();
            --remainder;
          }
        if (flagHasEntitySpecificationType)
          {
            if (remainder == 0)
                return extraEntitySpecificationTypeToJSON();
            --remainder;
          }
        if (flagHasMusicThirdParty)
          {
            if (remainder == 0)
                return extraMusicThirdPartyToJSON();
            --remainder;
          }
        if (flagHasListPosition)
          {
            if (remainder == 0)
                return extraListPositionToJSON();
            --remainder;
          }
        if (flagHasErrors)
          {
            if (remainder == 0)
                return extraErrorsToJSON();
            --remainder;
          }
        return extraMusicInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                switch (field_name[1])
                  {
                    case 'l':
                        if (String.Compare(field_name, 2, "bums", 0, 4, false) == 0)
                          {
                            if (field_name.Length == 6)
                              {
                                return (flagHasAlbums ? extraAlbumsToJSON() : null);
                              }
                            switch (field_name[6])
                              {
                                case 'L':
                                    if ((String.Compare(field_name, 7, "abel", 0, 4, false) == 0) && (field_name.Length == 11))
                                        return (flagHasAlbumsLabel ? extraAlbumsLabelToJSON() : null);
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
                                case 'S':
                                    if ((String.Compare(field_name, 7, "pecified", 0, 8, false) == 0) && (field_name.Length == 15))
                                        return (flagHasArtistSpecified ? extraArtistSpecifiedToJSON() : null);
                                    break;
                                case 's':
                                    if (field_name.Length == 7)
                                      {
                                        return (flagHasArtists ? extraArtistsToJSON() : null);
                                      }
                                    switch (field_name[7])
                                      {
                                        case 'L':
                                            if ((String.Compare(field_name, 8, "abel", 0, 4, false) == 0) && (field_name.Length == 12))
                                                return (flagHasArtistsLabel ? extraArtistsLabelToJSON() : null);
                                            break;
                                        default:
                                            break;
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
            case 'E':
                switch (field_name[1])
                  {
                    case 'n':
                        if ((String.Compare(field_name, 2, "titySpecificationType", 0, 21, false) == 0) && (field_name.Length == 23))
                            return (flagHasEntitySpecificationType ? extraEntitySpecificationTypeToJSON() : null);
                        break;
                    case 'r':
                        if ((String.Compare(field_name, 2, "rors", 0, 4, false) == 0) && (field_name.Length == 6))
                            return (flagHasErrors ? extraErrorsToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "istPosition", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasListPosition ? extraListPositionToJSON() : null);
                break;
            case 'M':
                if (String.Compare(field_name, 1, "usic", 0, 4, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'N':
                            if ((String.Compare(field_name, 6, "uggetKind", 0, 9, false) == 0) && (field_name.Length == 15))
                                return new JSONStringValue(getMusicNuggetKind());
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 6, "hirdParty", 0, 9, false) == 0) && (field_name.Length == 15))
                                return (flagHasMusicThirdParty ? extraMusicThirdPartyToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "ueryArtists", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasQueryArtists ? extraQueryArtistsToJSON() : null);
                break;
            case 'S':
                switch (field_name[1])
                  {
                    case 'e':
                        if ((String.Compare(field_name, 2, "archParameters", 0, 14, false) == 0) && (field_name.Length == 16))
                            return (flagHasSearchParameters ? extraSearchParametersToJSON() : null);
                        break;
                    case 'u':
                        if ((String.Compare(field_name, 2, "pplementalTrackInfos", 0, 20, false) == 0) && (field_name.Length == 22))
                            return (flagHasSupplementalTrackInfos ? extraSupplementalTrackInfosToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if (String.Compare(field_name, 1, "racks", 0, 5, false) == 0)
                  {
                    if (field_name.Length == 6)
                      {
                        return (flagHasTracks ? extraTracksToJSON() : null);
                      }
                    switch (field_name[6])
                      {
                        case 'L':
                            if ((String.Compare(field_name, 7, "abel", 0, 4, false) == 0) && (field_name.Length == 11))
                                return (flagHasTracksLabel ? extraTracksLabelToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "serRequestedAll", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasUserRequestedAll ? extraUserRequestedAllToJSON() : null);
                break;
            default:
                break;
          }
        return extraMusicInformationNuggetLookup(field_name);
      }

    public void setSearchParameters(MusicSearchParametersJSON  new_value)
      {
        if (flagHasSearchParameters)
          {
          }
        flagHasSearchParameters = true;
        storeSearchParameters = new_value;
      }
    public void unsetSearchParameters()
      {
        if (flagHasSearchParameters)
          {
          }
        flagHasSearchParameters = false;
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
    public void appendAlbums(MusicAlbumJSON  to_append)
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
    public void setArtistsLabel(string new_value)
      {
        flagHasArtistsLabel = true;
        storeArtistsLabel = new_value;
      }
    public void unsetArtistsLabel()
      {
        flagHasArtistsLabel = false;
      }
    public void initArtists()
      {
        if (flagHasArtists)
          {
            for (int num3 = 0; num3 < storeArtists.Count; ++num3)
              {
              }
          }
        flagHasArtists = true;
        storeArtists.Clear();
      }
    public void appendArtists(MusicArtistJSON  to_append)
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
            for (int num4 = 0; num4 < storeArtists.Count; ++num4)
              {
              }
          }
        flagHasArtists = false;
        storeArtists.Clear();
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
            for (int num5 = 0; num5 < storeTracks.Count; ++num5)
              {
              }
          }
        flagHasTracks = true;
        storeTracks.Clear();
      }
    public void appendTracks(MusicTrackJSON  to_append)
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
            for (int num6 = 0; num6 < storeTracks.Count; ++num6)
              {
              }
          }
        flagHasTracks = false;
        storeTracks.Clear();
      }
    public void initSupplementalTrackInfos()
      {
        if (flagHasSupplementalTrackInfos)
          {
            for (int num7 = 0; num7 < storeSupplementalTrackInfos.Count; ++num7)
              {
              }
          }
        flagHasSupplementalTrackInfos = true;
        storeSupplementalTrackInfos.Clear();
      }
    public void appendSupplementalTrackInfos(MusicTrackSupplementalInfoJSON  to_append)
      {
        if (!flagHasSupplementalTrackInfos)
          {
            flagHasSupplementalTrackInfos = true;
            storeSupplementalTrackInfos.Clear();
          }
        Debug.Assert(flagHasSupplementalTrackInfos);
        storeSupplementalTrackInfos.Add(to_append);
      }
    public void unsetSupplementalTrackInfos()
      {
        if (flagHasSupplementalTrackInfos)
          {
            for (int num8 = 0; num8 < storeSupplementalTrackInfos.Count; ++num8)
              {
              }
          }
        flagHasSupplementalTrackInfos = false;
        storeSupplementalTrackInfos.Clear();
      }
    public void setUserRequestedAll(bool new_value)
      {
        flagHasUserRequestedAll = true;
        storeUserRequestedAll = new_value;
      }
    public void unsetUserRequestedAll()
      {
        flagHasUserRequestedAll = false;
      }
    public void setArtistSpecified(bool new_value)
      {
        flagHasArtistSpecified = true;
        storeArtistSpecified = new_value;
      }
    public void unsetArtistSpecified()
      {
        flagHasArtistSpecified = false;
      }
    public void initQueryArtists()
      {
        if (flagHasQueryArtists)
          {
            for (int num9 = 0; num9 < storeQueryArtists.Count; ++num9)
              {
              }
          }
        flagHasQueryArtists = true;
        storeQueryArtists.Clear();
      }
    public void appendQueryArtists(MusicArtistJSON  to_append)
      {
        if (!flagHasQueryArtists)
          {
            flagHasQueryArtists = true;
            storeQueryArtists.Clear();
          }
        Debug.Assert(flagHasQueryArtists);
        storeQueryArtists.Add(to_append);
      }
    public void unsetQueryArtists()
      {
        if (flagHasQueryArtists)
          {
            for (int num10 = 0; num10 < storeQueryArtists.Count; ++num10)
              {
              }
          }
        flagHasQueryArtists = false;
        storeQueryArtists.Clear();
      }
    public void setEntitySpecificationType(TypeEntitySpecificationType new_value)
      {
        flagHasEntitySpecificationType = true;
        storeEntitySpecificationType = new_value;
      }
    public void setEntitySpecificationType(string chars)
      {
        TypeEntitySpecificationTypeKnownValues known = stringToEntitySpecificationType(chars);
        TypeEntitySpecificationType new_value = new TypeEntitySpecificationType();
        if (known == TypeEntitySpecificationTypeKnownValues.EntitySpecificationType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setEntitySpecificationType(new_value);
      }
    public void setEntitySpecificationType(TypeEntitySpecificationTypeKnownValues new_value)
      {
        TypeEntitySpecificationType new_full_value = new TypeEntitySpecificationType();
        Debug.Assert(new_value != TypeEntitySpecificationTypeKnownValues.EntitySpecificationType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setEntitySpecificationType(new_full_value);
      }
    public void unsetEntitySpecificationType()
      {
        flagHasEntitySpecificationType = false;
      }
    public void setMusicThirdParty(MusicThirdPartyJSON  new_value)
      {
        if (flagHasMusicThirdParty)
          {
          }
        flagHasMusicThirdParty = true;
        storeMusicThirdParty = new_value;
      }
    public void unsetMusicThirdParty()
      {
        if (flagHasMusicThirdParty)
          {
          }
        flagHasMusicThirdParty = false;
      }
    public void setListPosition(BigInteger new_value)
      {
        flagHasListPosition = true;
        storeListPosition = new_value;
      }
    public void unsetListPosition()
      {
        flagHasListPosition = false;
      }
    public void initErrors()
      {
        if (flagHasErrors)
          {
            for (int num11 = 0; num11 < storeErrors.Count; ++num11)
              {
              }
          }
        flagHasErrors = true;
        storeErrors.Clear();
      }
    public void appendErrors(MusicSearchErrorJSON  to_append)
      {
        if (!flagHasErrors)
          {
            flagHasErrors = true;
            storeErrors.Clear();
          }
        Debug.Assert(flagHasErrors);
        storeErrors.Add(to_append);
      }
    public void unsetErrors()
      {
        if (flagHasErrors)
          {
            for (int num12 = 0; num12 < storeErrors.Count; ++num12)
              {
              }
          }
        flagHasErrors = false;
        storeErrors.Clear();
      }

    public abstract void extraMusicInformationNuggetAppendPair(string key, JSONValue new_component);
    public abstract void extraMusicInformationNuggetSetField(string key, JSONValue new_component);
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'l':
                        if (String.Compare(key, 2, "bums", 0, 4, false) == 0)
                          {
                            if (key.Length == 6)
                              {
                                {
                                fromJSONAlbums(new_component, false);
                                return;
                                }
                              }
                            switch (key[6])
                              {
                                case 'L':
                                    if ((String.Compare(key, 7, "abel", 0, 4, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONAlbumsLabel(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(key, 2, "tist", 0, 4, false) == 0)
                          {
                            switch (key[6])
                              {
                                case 'S':
                                    if ((String.Compare(key, 7, "pecified", 0, 8, false) == 0) && (key.Length == 15))
                                        {
                                        fromJSONArtistSpecified(new_component, false);
                                        return;
                                        }
                                    break;
                                case 's':
                                    if (key.Length == 7)
                                      {
                                        {
                                        fromJSONArtists(new_component, false);
                                        return;
                                        }
                                      }
                                    switch (key[7])
                                      {
                                        case 'L':
                                            if ((String.Compare(key, 8, "abel", 0, 4, false) == 0) && (key.Length == 12))
                                                {
                                                fromJSONArtistsLabel(new_component, false);
                                                return;
                                                }
                                            break;
                                        default:
                                            break;
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
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if ((String.Compare(key, 2, "titySpecificationType", 0, 21, false) == 0) && (key.Length == 23))
                            {
                            fromJSONEntitySpecificationType(new_component, false);
                            return;
                            }
                        break;
                    case 'r':
                        if ((String.Compare(key, 2, "rors", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONErrors(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(key, 1, "istPosition", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONListPosition(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if (String.Compare(key, 1, "usic", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'N':
                            if ((String.Compare(key, 6, "uggetKind", 0, 9, false) == 0) && (key.Length == 15))
                                return;
                            break;
                        case 'T':
                            if ((String.Compare(key, 6, "hirdParty", 0, 9, false) == 0) && (key.Length == 15))
                                {
                                fromJSONMusicThirdParty(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryArtists", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONQueryArtists(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "archParameters", 0, 14, false) == 0) && (key.Length == 16))
                            {
                            fromJSONSearchParameters(new_component, false);
                            return;
                            }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "pplementalTrackInfos", 0, 20, false) == 0) && (key.Length == 22))
                            {
                            fromJSONSupplementalTrackInfos(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if (String.Compare(key, 1, "racks", 0, 5, false) == 0)
                  {
                    if (key.Length == 6)
                      {
                        {
                        fromJSONTracks(new_component, false);
                        return;
                        }
                      }
                    switch (key[6])
                      {
                        case 'L':
                            if ((String.Compare(key, 7, "abel", 0, 4, false) == 0) && (key.Length == 11))
                                {
                                fromJSONTracksLabel(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serRequestedAll", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONUserRequestedAll(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMusicInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'l':
                        if (String.Compare(key, 2, "bums", 0, 4, false) == 0)
                          {
                            if (key.Length == 6)
                              {
                                {
                                fromJSONAlbums(new_component, false);
                                return;
                                }
                              }
                            switch (key[6])
                              {
                                case 'L':
                                    if ((String.Compare(key, 7, "abel", 0, 4, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONAlbumsLabel(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(key, 2, "tist", 0, 4, false) == 0)
                          {
                            switch (key[6])
                              {
                                case 'S':
                                    if ((String.Compare(key, 7, "pecified", 0, 8, false) == 0) && (key.Length == 15))
                                        {
                                        fromJSONArtistSpecified(new_component, false);
                                        return;
                                        }
                                    break;
                                case 's':
                                    if (key.Length == 7)
                                      {
                                        {
                                        fromJSONArtists(new_component, false);
                                        return;
                                        }
                                      }
                                    switch (key[7])
                                      {
                                        case 'L':
                                            if ((String.Compare(key, 8, "abel", 0, 4, false) == 0) && (key.Length == 12))
                                                {
                                                fromJSONArtistsLabel(new_component, false);
                                                return;
                                                }
                                            break;
                                        default:
                                            break;
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
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if ((String.Compare(key, 2, "titySpecificationType", 0, 21, false) == 0) && (key.Length == 23))
                            {
                            fromJSONEntitySpecificationType(new_component, false);
                            return;
                            }
                        break;
                    case 'r':
                        if ((String.Compare(key, 2, "rors", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONErrors(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(key, 1, "istPosition", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONListPosition(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if (String.Compare(key, 1, "usic", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'N':
                            if ((String.Compare(key, 6, "uggetKind", 0, 9, false) == 0) && (key.Length == 15))
                                return;
                            break;
                        case 'T':
                            if ((String.Compare(key, 6, "hirdParty", 0, 9, false) == 0) && (key.Length == 15))
                                {
                                fromJSONMusicThirdParty(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryArtists", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONQueryArtists(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "archParameters", 0, 14, false) == 0) && (key.Length == 16))
                            {
                            fromJSONSearchParameters(new_component, false);
                            return;
                            }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "pplementalTrackInfos", 0, 20, false) == 0) && (key.Length == 22))
                            {
                            fromJSONSupplementalTrackInfos(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if (String.Compare(key, 1, "racks", 0, 5, false) == 0)
                  {
                    if (key.Length == 6)
                      {
                        {
                        fromJSONTracks(new_component, false);
                        return;
                        }
                      }
                    switch (key[6])
                      {
                        case 'L':
                            if ((String.Compare(key, 7, "abel", 0, 4, false) == 0) && (key.Length == 11))
                                {
                                fromJSONTracksLabel(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serRequestedAll", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONUserRequestedAll(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMusicInformationNuggetSetField(key, new_component);
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
        handler.pair("MusicNuggetKind", getMusicNuggetKind());
        if (flagHasSearchParameters)
          {
            handler.start_pair("SearchParameters");
            if (partial_allowed)
                storeSearchParameters.write_partial_as_json(handler);
            else
                storeSearchParameters.write_as_json(handler);
          }
        if (flagHasAlbumsLabel)
          {
            handler.start_pair("AlbumsLabel");
            handler.string_value(storeAlbumsLabel);
          }
        if (flagHasAlbums)
          {
            handler.start_pair("Albums");
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
        if (flagHasArtistsLabel)
          {
            handler.start_pair("ArtistsLabel");
            handler.string_value(storeArtistsLabel);
          }
        if (flagHasArtists)
          {
            handler.start_pair("Artists");
            handler.start_array();
            for (int num2 = 0; num2 < storeArtists.Count; ++num2)
              {
                if (partial_allowed)
                    storeArtists[num2].write_partial_as_json(handler);
                else
                    storeArtists[num2].write_as_json(handler);
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
            handler.start_array();
            for (int num3 = 0; num3 < storeTracks.Count; ++num3)
              {
                if (partial_allowed)
                    storeTracks[num3].write_partial_as_json(handler);
                else
                    storeTracks[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSupplementalTrackInfos)
          {
            handler.start_pair("SupplementalTrackInfos");
            handler.start_array();
            for (int num4 = 0; num4 < storeSupplementalTrackInfos.Count; ++num4)
              {
                if (partial_allowed)
                    storeSupplementalTrackInfos[num4].write_partial_as_json(handler);
                else
                    storeSupplementalTrackInfos[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasUserRequestedAll)
          {
            handler.start_pair("UserRequestedAll");
            handler.boolean_value(storeUserRequestedAll);
          }
        if (flagHasArtistSpecified)
          {
            handler.start_pair("ArtistSpecified");
            handler.boolean_value(storeArtistSpecified);
          }
        if (flagHasQueryArtists)
          {
            handler.start_pair("QueryArtists");
            handler.start_array();
            for (int num5 = 0; num5 < storeQueryArtists.Count; ++num5)
              {
                if (partial_allowed)
                    storeQueryArtists[num5].write_partial_as_json(handler);
                else
                    storeQueryArtists[num5].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasEntitySpecificationType)
          {
            handler.start_pair("EntitySpecificationType");
            if (storeEntitySpecificationType.in_known_list)
              {
                switch (storeEntitySpecificationType.list_value)
                  {
                    case TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_Explicit:
                        handler.string_value("Explicit");
                        break;
                    case TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_This:
                        handler.string_value("This");
                        break;
                    case TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_ListPosition:
                        handler.string_value("ListPosition");
                        break;
                    case TypeEntitySpecificationTypeKnownValues.EntitySpecificationType_Relative:
                        handler.string_value("Relative");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeEntitySpecificationType.string_value);
              }
          }
        if (flagHasMusicThirdParty)
          {
            handler.start_pair("MusicThirdParty");
            if (partial_allowed)
                storeMusicThirdParty.write_partial_as_json(handler);
            else
                storeMusicThirdParty.write_as_json(handler);
          }
        if (flagHasListPosition)
          {
            handler.start_pair("ListPosition");
            handler.number_value(storeListPosition);
          }
        if (flagHasErrors)
          {
            handler.start_pair("Errors");
            Debug.Assert(storeErrors.Count >= 1);
            handler.start_array();
            for (int num6 = 0; num6 < storeErrors.Count; ++num6)
              {
                if (partial_allowed)
                    storeErrors[num6].write_partial_as_json(handler);
                else
                    storeErrors[num6].write_as_json(handler);
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

    public static new MusicInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicInformationNugget", ignore_extras);
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
    public static new MusicInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicInformationNugget", ignore_extras);
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
    public static new MusicInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        MusicInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MusicInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private MusicSearchParametersJSON.HoldingGenerator fieldGeneratorSearchParameters;
        private JSONHoldingStringGenerator fieldGeneratorAlbumsLabel;
        private MusicAlbumJSON.HoldingArrayGenerator fieldGeneratorAlbums;
        private JSONHoldingStringGenerator fieldGeneratorArtistsLabel;
        private MusicArtistJSON.HoldingArrayGenerator fieldGeneratorArtists;
        private JSONHoldingStringGenerator fieldGeneratorTracksLabel;
        private MusicTrackJSON.HoldingArrayGenerator fieldGeneratorTracks;
        private MusicTrackSupplementalInfoJSON.HoldingArrayGenerator fieldGeneratorSupplementalTrackInfos;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedAll;
        private JSONHoldingBooleanGenerator fieldGeneratorArtistSpecified;
        private MusicArtistJSON.HoldingArrayGenerator fieldGeneratorQueryArtists;
    private abstract class FieldGeneratorEntitySpecificationType : JSONStringGenerator
          {
            protected FieldGeneratorEntitySpecificationType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorEntitySpecificationType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeEntitySpecificationTypeKnownValues known = stringToEntitySpecificationType(result);
                TypeEntitySpecificationType new_value = new TypeEntitySpecificationType();
                if (known == TypeEntitySpecificationTypeKnownValues.EntitySpecificationType__none)
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
            protected abstract void handle_result(TypeEntitySpecificationType result);
          };
    private class FieldHoldingGeneratorEntitySpecificationType : FieldGeneratorEntitySpecificationType
  {
    protected override void handle_result(TypeEntitySpecificationType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorEntitySpecificationType(String what)
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
    public TypeEntitySpecificationType value;
  };
    private class FieldHoldingArrayGeneratorEntitySpecificationType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorEntitySpecificationType
      {
        private FieldHoldingArrayGeneratorEntitySpecificationType top;

        protected override void handle_result(TypeEntitySpecificationType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorEntitySpecificationType init_top)
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
    protected virtual void handle_result(List<TypeEntitySpecificationType> result)
      {
      }

    public FieldHoldingArrayGeneratorEntitySpecificationType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeEntitySpecificationType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorEntitySpecificationType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeEntitySpecificationType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeEntitySpecificationType> value;
  };
        private FieldHoldingGeneratorEntitySpecificationType fieldGeneratorEntitySpecificationType;
        private MusicThirdPartyJSON.HoldingGenerator fieldGeneratorMusicThirdParty;
    private class FieldHoldingGeneratorListPosition : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorListPosition(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorListPosition : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorListPosition(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorListPosition fieldGeneratorListPosition;
        private MusicSearchErrorJSON.HoldingArrayGenerator fieldGeneratorErrors;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `MusicNuggetKind' field is missing.");
            if (!(getInformationNuggetJSONKey().Equals("Music")))
                throw new Exception("The key field has a value other than `Music'.");
            MusicInformationNuggetJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getMusicInformationNuggetJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `MusicNuggetKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((MusicInformationNuggetJSON )new_result);
          }
        protected void finish(MusicInformationNuggetJSON result)
          {
            if (fieldGeneratorSearchParameters.have_value)
              {
                result.setSearchParameters(fieldGeneratorSearchParameters.value);
                fieldGeneratorSearchParameters.have_value = false;
              }
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
            if (fieldGeneratorArtistsLabel.have_value)
              {
                result.setArtistsLabel(fieldGeneratorArtistsLabel.value);
                fieldGeneratorArtistsLabel.have_value = false;
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
            if (fieldGeneratorSupplementalTrackInfos.have_value)
              {
                result.initSupplementalTrackInfos();
                int count = fieldGeneratorSupplementalTrackInfos.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSupplementalTrackInfos(fieldGeneratorSupplementalTrackInfos.value[num]);
                  }
                fieldGeneratorSupplementalTrackInfos.value.Clear();
                fieldGeneratorSupplementalTrackInfos.have_value = false;
              }
            if (fieldGeneratorUserRequestedAll.have_value)
              {
                result.setUserRequestedAll(fieldGeneratorUserRequestedAll.value);
                fieldGeneratorUserRequestedAll.have_value = false;
              }
            if (fieldGeneratorArtistSpecified.have_value)
              {
                result.setArtistSpecified(fieldGeneratorArtistSpecified.value);
                fieldGeneratorArtistSpecified.have_value = false;
              }
            if (fieldGeneratorQueryArtists.have_value)
              {
                result.initQueryArtists();
                int count = fieldGeneratorQueryArtists.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendQueryArtists(fieldGeneratorQueryArtists.value[num]);
                  }
                fieldGeneratorQueryArtists.value.Clear();
                fieldGeneratorQueryArtists.have_value = false;
              }
            if (fieldGeneratorEntitySpecificationType.have_value)
              {
                result.setEntitySpecificationType(fieldGeneratorEntitySpecificationType.value);
                fieldGeneratorEntitySpecificationType.have_value = false;
              }
            if (fieldGeneratorMusicThirdParty.have_value)
              {
                result.setMusicThirdParty(fieldGeneratorMusicThirdParty.value);
                fieldGeneratorMusicThirdParty.have_value = false;
              }
            if (fieldGeneratorListPosition.have_value)
              {
                result.setListPosition(fieldGeneratorListPosition.value);
                fieldGeneratorListPosition.have_value = false;
              }
            if (fieldGeneratorErrors.have_value)
              {
                result.initErrors();
                int count = fieldGeneratorErrors.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendErrors(fieldGeneratorErrors.value[num]);
                  }
                fieldGeneratorErrors.value.Clear();
                fieldGeneratorErrors.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MusicInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if (String.Compare(field_name, 2, "bums", 0, 4, false) == 0)
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
                        case 'r':
                            if (String.Compare(field_name, 2, "tist", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'S':
                                        if ((String.Compare(field_name, 7, "pecified", 0, 8, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorArtistSpecified;
                                        break;
                                    case 's':
                                        if (field_name.Length == 7)
                                          {
                                            return fieldGeneratorArtists;
                                          }
                                        switch (field_name[7])
                                          {
                                            case 'L':
                                                if ((String.Compare(field_name, 8, "abel", 0, 4, false) == 0) && (field_name.Length == 12))
                                                    return fieldGeneratorArtistsLabel;
                                                break;
                                            default:
                                                break;
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
                case 'E':
                    switch (field_name[1])
                      {
                        case 'n':
                            if ((String.Compare(field_name, 2, "titySpecificationType", 0, 21, false) == 0) && (field_name.Length == 23))
                                return fieldGeneratorEntitySpecificationType;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "rors", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorErrors;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "istPosition", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorListPosition;
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "usic", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 6, "uggetKind", 0, 9, false) == 0) && (field_name.Length == 15))
                                    {
                                    keyGenerator.reset();
                                    return keyGenerator;
                                    }
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 6, "hirdParty", 0, 9, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorMusicThirdParty;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryArtists", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorQueryArtists;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "archParameters", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorSearchParameters;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "pplementalTrackInfos", 0, 20, false) == 0) && (field_name.Length == 22))
                                return fieldGeneratorSupplementalTrackInfos;
                            break;
                        default:
                            break;
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
                case 'U':
                    if ((String.Compare(field_name, 1, "serRequestedAll", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorUserRequestedAll;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSearchParameters = new MusicSearchParametersJSON.HoldingGenerator("field \"SearchParameters\" of the MusicInformationNugget class", ignore_extras);
            fieldGeneratorAlbumsLabel = new JSONHoldingStringGenerator("field \"AlbumsLabel\" of the MusicInformationNugget class");
            fieldGeneratorAlbums = new MusicAlbumJSON.HoldingArrayGenerator("field \"Albums\" of the MusicInformationNugget class", ignore_extras);
            fieldGeneratorArtistsLabel = new JSONHoldingStringGenerator("field \"ArtistsLabel\" of the MusicInformationNugget class");
            fieldGeneratorArtists = new MusicArtistJSON.HoldingArrayGenerator("field \"Artists\" of the MusicInformationNugget class", ignore_extras);
            fieldGeneratorTracksLabel = new JSONHoldingStringGenerator("field \"TracksLabel\" of the MusicInformationNugget class");
            fieldGeneratorTracks = new MusicTrackJSON.HoldingArrayGenerator("field \"Tracks\" of the MusicInformationNugget class", ignore_extras);
            fieldGeneratorSupplementalTrackInfos = new MusicTrackSupplementalInfoJSON.HoldingArrayGenerator("field \"SupplementalTrackInfos\" of the MusicInformationNugget class", ignore_extras);
            fieldGeneratorUserRequestedAll = new JSONHoldingBooleanGenerator("field \"UserRequestedAll\" of the MusicInformationNugget class");
            fieldGeneratorArtistSpecified = new JSONHoldingBooleanGenerator("field \"ArtistSpecified\" of the MusicInformationNugget class");
            fieldGeneratorQueryArtists = new MusicArtistJSON.HoldingArrayGenerator("field \"QueryArtists\" of the MusicInformationNugget class", ignore_extras);
            fieldGeneratorEntitySpecificationType = new FieldHoldingGeneratorEntitySpecificationType("field \"EntitySpecificationType\" of the MusicInformationNugget class");
            fieldGeneratorMusicThirdParty = new MusicThirdPartyJSON.HoldingGenerator("field \"MusicThirdParty\" of the MusicInformationNugget class", ignore_extras);
            fieldGeneratorListPosition = new FieldHoldingGeneratorListPosition("field \"ListPosition\" of the MusicInformationNugget class");
            fieldGeneratorErrors = new MusicSearchErrorJSON.HoldingArrayGenerator("field \"Errors\" of the MusicInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"MusicNuggetKind\" of the MusicInformationNugget class");
            set_what("the MusicInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSearchParameters = new MusicSearchParametersJSON.HoldingGenerator("field \"SearchParameters\" of the MusicInformationNugget class", false);
            fieldGeneratorAlbumsLabel = new JSONHoldingStringGenerator("field \"AlbumsLabel\" of the MusicInformationNugget class");
            fieldGeneratorAlbums = new MusicAlbumJSON.HoldingArrayGenerator("field \"Albums\" of the MusicInformationNugget class", false);
            fieldGeneratorArtistsLabel = new JSONHoldingStringGenerator("field \"ArtistsLabel\" of the MusicInformationNugget class");
            fieldGeneratorArtists = new MusicArtistJSON.HoldingArrayGenerator("field \"Artists\" of the MusicInformationNugget class", false);
            fieldGeneratorTracksLabel = new JSONHoldingStringGenerator("field \"TracksLabel\" of the MusicInformationNugget class");
            fieldGeneratorTracks = new MusicTrackJSON.HoldingArrayGenerator("field \"Tracks\" of the MusicInformationNugget class", false);
            fieldGeneratorSupplementalTrackInfos = new MusicTrackSupplementalInfoJSON.HoldingArrayGenerator("field \"SupplementalTrackInfos\" of the MusicInformationNugget class", false);
            fieldGeneratorUserRequestedAll = new JSONHoldingBooleanGenerator("field \"UserRequestedAll\" of the MusicInformationNugget class");
            fieldGeneratorArtistSpecified = new JSONHoldingBooleanGenerator("field \"ArtistSpecified\" of the MusicInformationNugget class");
            fieldGeneratorQueryArtists = new MusicArtistJSON.HoldingArrayGenerator("field \"QueryArtists\" of the MusicInformationNugget class", false);
            fieldGeneratorEntitySpecificationType = new FieldHoldingGeneratorEntitySpecificationType("field \"EntitySpecificationType\" of the MusicInformationNugget class");
            fieldGeneratorMusicThirdParty = new MusicThirdPartyJSON.HoldingGenerator("field \"MusicThirdParty\" of the MusicInformationNugget class", false);
            fieldGeneratorListPosition = new FieldHoldingGeneratorListPosition("field \"ListPosition\" of the MusicInformationNugget class");
            fieldGeneratorErrors = new MusicSearchErrorJSON.HoldingArrayGenerator("field \"Errors\" of the MusicInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"MusicNuggetKind\" of the MusicInformationNugget class");
            set_what("the MusicInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorSearchParameters.reset();
            fieldGeneratorAlbumsLabel.reset();
            fieldGeneratorAlbums.reset();
            fieldGeneratorArtistsLabel.reset();
            fieldGeneratorArtists.reset();
            fieldGeneratorTracksLabel.reset();
            fieldGeneratorTracks.reset();
            fieldGeneratorSupplementalTrackInfos.reset();
            fieldGeneratorUserRequestedAll.reset();
            fieldGeneratorArtistSpecified.reset();
            fieldGeneratorQueryArtists.reset();
            fieldGeneratorEntitySpecificationType.reset();
            fieldGeneratorMusicThirdParty.reset();
            fieldGeneratorListPosition.reset();
            fieldGeneratorErrors.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicInformationNuggetJSON  result)
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
        public MusicInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<MusicInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicInformationNuggetJSON>();
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
    public List<MusicInformationNuggetJSON> value;
  };
    class GenericMusicInformationNuggetJSON : MusicInformationNuggetJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericMusicInformationNuggetJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getMusicNuggetKind()  { return key; }
        public override int extraMusicInformationNuggetComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraMusicInformationNuggetComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraMusicInformationNuggetComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraMusicInformationNuggetLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraMusicInformationNuggetAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraMusicInformationNuggetSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraMusicInformationNuggetLookup(key);
            if (old_field == null)
              {
                extraMusicInformationNuggetAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static new MusicInformationNuggetJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "Music", 0, 5, false) == 0)
      {
        switch (key[5])
          {
            case 'C':
                if ((String.Compare(key, 6, "harts", 0, 5, false) == 0) && (key.Length == 11))
                    return new MusicChartsInformationNuggetJSON();
                break;
            case 'S':
                if ((String.Compare(key, 6, "earch", 0, 5, false) == 0) && (key.Length == 11))
                    return new MusicSearchInformationNuggetJSON();
                break;
            default:
                break;
          }
      }

        return new GenericMusicInformationNuggetJSON(key);
      }
  };
