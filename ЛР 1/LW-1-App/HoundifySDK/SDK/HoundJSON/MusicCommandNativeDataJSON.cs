/* file "MusicCommandNativeDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public abstract class MusicCommandNativeDataJSON : JSONBase
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

    public enum TypeOrderToDisplayKnownValues
      {
        OrderToDisplay_Album,
        OrderToDisplay_Artist,
        OrderToDisplay_Track,
        OrderToDisplay_Video,
        OrderToDisplay__none
      };
    public struct TypeOrderToDisplay
      {
        public bool in_known_list;
        public string string_value;
        public TypeOrderToDisplayKnownValues list_value;
      };

    public static TypeOrderToDisplayKnownValues  stringToOrderToDisplay(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'l':
                        if ((String.Compare(chars, 2, "bum", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeOrderToDisplayKnownValues.OrderToDisplay_Album;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "tist", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeOrderToDisplayKnownValues.OrderToDisplay_Artist;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(chars, 1, "rack", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeOrderToDisplayKnownValues.OrderToDisplay_Track;
                break;
            case 'V':
                if ((String.Compare(chars, 1, "ideo", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeOrderToDisplayKnownValues.OrderToDisplay_Video;
                break;
            default:
                break;
          }
        return TypeOrderToDisplayKnownValues.OrderToDisplay__none;
      }

    public static string  stringFromOrderToDisplay(TypeOrderToDisplayKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeOrderToDisplayKnownValues.OrderToDisplay_Album:
                return "Album";
            case TypeOrderToDisplayKnownValues.OrderToDisplay_Artist:
                return "Artist";
            case TypeOrderToDisplayKnownValues.OrderToDisplay_Track:
                return "Track";
            case TypeOrderToDisplayKnownValues.OrderToDisplay_Video:
                return "Video";
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
    private bool flagHasUserRequestedAutoPlay;
    private bool storeUserRequestedAutoPlay;
    private bool flagHasUserRequestedAirplay;
    private bool storeUserRequestedAirplay;
    private bool flagHasUserRequestedRepeat;
    private bool storeUserRequestedRepeat;
    private bool flagHasUserRequestedShuffle;
    private bool storeUserRequestedShuffle;
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
    private bool flagHasOrderToDisplay;
    private List< TypeOrderToDisplay > storeOrderToDisplay;


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
            throw new Exception("The value for field AlbumsLabel of MusicCommandNativeDataJSON is not a string.");
        setAlbumsLabel(json_string.getData());
      }


    private void  fromJSONAlbums(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Albums of MusicCommandNativeDataJSON is not an array.");
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
            throw new Exception("The value for field ArtistsLabel of MusicCommandNativeDataJSON is not a string.");
        setArtistsLabel(json_string.getData());
      }


    private void  fromJSONArtists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Artists of MusicCommandNativeDataJSON is not an array.");
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
            throw new Exception("The value for field TracksLabel of MusicCommandNativeDataJSON is not a string.");
        setTracksLabel(json_string.getData());
      }


    private void  fromJSONTracks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Tracks of MusicCommandNativeDataJSON is not an array.");
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
            throw new Exception("The value for field SupplementalTrackInfos of MusicCommandNativeDataJSON is not an array.");
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


    private void  fromJSONUserRequestedAutoPlay(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserRequestedAutoPlay of MusicCommandNativeDataJSON is not true for false.");
              }
          }
        setUserRequestedAutoPlay(the_bool);
      }


    private void  fromJSONUserRequestedAirplay(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserRequestedAirplay of MusicCommandNativeDataJSON is not true for false.");
              }
          }
        setUserRequestedAirplay(the_bool);
      }


    private void  fromJSONUserRequestedRepeat(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserRequestedRepeat of MusicCommandNativeDataJSON is not true for false.");
              }
          }
        setUserRequestedRepeat(the_bool);
      }


    private void  fromJSONUserRequestedShuffle(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserRequestedShuffle of MusicCommandNativeDataJSON is not true for false.");
              }
          }
        setUserRequestedShuffle(the_bool);
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
                throw new Exception("The value for field UserRequestedAll of MusicCommandNativeDataJSON is not true for false.");
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
                throw new Exception("The value for field ArtistSpecified of MusicCommandNativeDataJSON is not true for false.");
              }
          }
        setArtistSpecified(the_bool);
      }


    private void  fromJSONQueryArtists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueryArtists of MusicCommandNativeDataJSON is not an array.");
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
            throw new Exception("The value for field EntitySpecificationType of MusicCommandNativeDataJSON is not a string.");
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
                throw new Exception("The value for field ListPosition of MusicCommandNativeDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ListPosition of MusicCommandNativeDataJSON is not an integer.");
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
            throw new Exception("The value for field Errors of MusicCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Errors of MusicCommandNativeDataJSON has too few elements.");
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


    private void  fromJSONOrderToDisplay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field OrderToDisplay of MusicCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 3)
            throw new Exception("The value for field OrderToDisplay of MusicCommandNativeDataJSON has too few elements.");
        List< TypeOrderToDisplay > vector_OrderToDisplay1 = new List< TypeOrderToDisplay >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field OrderToDisplay of MusicCommandNativeDataJSON is not a string.");
            TypeOrderToDisplay the_open_enum = new TypeOrderToDisplay();
            switch (json_string.getData()[0])
              {
                case 'A':
                    switch (json_string.getData()[1])
                      {
                        case 'l':
                            if ((String.Compare(json_string.getData(), 2, "bum", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeOrderToDisplayKnownValues.OrderToDisplay_Album;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'r':
                            if ((String.Compare(json_string.getData(), 2, "tist", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeOrderToDisplayKnownValues.OrderToDisplay_Artist;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(json_string.getData(), 1, "rack", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeOrderToDisplayKnownValues.OrderToDisplay_Track;
                            goto open_enum_is_done;
                          }
                    break;
                case 'V':
                    if ((String.Compare(json_string.getData(), 1, "ideo", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeOrderToDisplayKnownValues.OrderToDisplay_Video;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            vector_OrderToDisplay1.Add(the_open_enum);
          }
        Debug.Assert(vector_OrderToDisplay1.Count >= 3);
        initOrderToDisplay();
        for (int num7 = 0; num7 < vector_OrderToDisplay1.Count; ++num7)
            appendOrderToDisplay(vector_OrderToDisplay1[num7]);
        for (int num1 = 0; num1 < vector_OrderToDisplay1.Count; ++num1)
          {
          }
      }


    public MusicCommandNativeDataJSON()
      {
        flagHasSearchParameters = false;
        flagHasAlbumsLabel = false;
        flagHasAlbums = false;
        flagHasArtistsLabel = false;
        flagHasArtists = false;
        flagHasTracksLabel = false;
        flagHasTracks = false;
        flagHasSupplementalTrackInfos = false;
        flagHasUserRequestedAutoPlay = false;
        flagHasUserRequestedAirplay = false;
        flagHasUserRequestedRepeat = false;
        flagHasUserRequestedShuffle = false;
        flagHasUserRequestedAll = false;
        flagHasArtistSpecified = false;
        flagHasQueryArtists = false;
        flagHasEntitySpecificationType = false;
        flagHasMusicThirdParty = false;
        flagHasListPosition = false;
        flagHasErrors = false;
        flagHasOrderToDisplay = false;
        storeAlbums = new List< MusicAlbumJSON  >();
        storeArtists = new List< MusicArtistJSON  >();
        storeTracks = new List< MusicTrackJSON  >();
        storeSupplementalTrackInfos = new List< MusicTrackSupplementalInfoJSON  >();
        storeQueryArtists = new List< MusicArtistJSON  >();
        storeErrors = new List< MusicSearchErrorJSON  >();
        storeOrderToDisplay = new List< TypeOrderToDisplay >();
      }

    public abstract string getMusicCommandNativeDataKind();
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

    public bool  hasUserRequestedAutoPlay()
      {
        return flagHasUserRequestedAutoPlay;
      }

    public bool  getUserRequestedAutoPlay()
      {
        Debug.Assert(flagHasUserRequestedAutoPlay);
        return storeUserRequestedAutoPlay;
      }

    public bool  hasUserRequestedAirplay()
      {
        return flagHasUserRequestedAirplay;
      }

    public bool  getUserRequestedAirplay()
      {
        Debug.Assert(flagHasUserRequestedAirplay);
        return storeUserRequestedAirplay;
      }

    public bool  hasUserRequestedRepeat()
      {
        return flagHasUserRequestedRepeat;
      }

    public bool  getUserRequestedRepeat()
      {
        Debug.Assert(flagHasUserRequestedRepeat);
        return storeUserRequestedRepeat;
      }

    public bool  hasUserRequestedShuffle()
      {
        return flagHasUserRequestedShuffle;
      }

    public bool  getUserRequestedShuffle()
      {
        Debug.Assert(flagHasUserRequestedShuffle);
        return storeUserRequestedShuffle;
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

    public bool  hasOrderToDisplay()
      {
        return flagHasOrderToDisplay;
      }

    public int  countOfOrderToDisplay()
      {
        Debug.Assert(flagHasOrderToDisplay);
        return storeOrderToDisplay.Count;
      }

    public TypeOrderToDisplay  elementOfOrderToDisplay(int element_num)
      {
        Debug.Assert(flagHasOrderToDisplay);
        return storeOrderToDisplay[element_num];
      }

    public List< TypeOrderToDisplay >  getOrderToDisplay()
      {
        Debug.Assert(flagHasOrderToDisplay);
        return storeOrderToDisplay;
      }


    public abstract int extraMusicCommandNativeDataComponentCount();
    public abstract string extraMusicCommandNativeDataComponentKey(int component_num);
    public abstract JSONValue extraMusicCommandNativeDataComponentValue(int component_num);
    public abstract JSONValue extraMusicCommandNativeDataLookup(string field_name);

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
    public void setUserRequestedAutoPlay(bool new_value)
      {
        flagHasUserRequestedAutoPlay = true;
        storeUserRequestedAutoPlay = new_value;
      }
    public void unsetUserRequestedAutoPlay()
      {
        flagHasUserRequestedAutoPlay = false;
      }
    public void setUserRequestedAirplay(bool new_value)
      {
        flagHasUserRequestedAirplay = true;
        storeUserRequestedAirplay = new_value;
      }
    public void unsetUserRequestedAirplay()
      {
        flagHasUserRequestedAirplay = false;
      }
    public void setUserRequestedRepeat(bool new_value)
      {
        flagHasUserRequestedRepeat = true;
        storeUserRequestedRepeat = new_value;
      }
    public void unsetUserRequestedRepeat()
      {
        flagHasUserRequestedRepeat = false;
      }
    public void setUserRequestedShuffle(bool new_value)
      {
        flagHasUserRequestedShuffle = true;
        storeUserRequestedShuffle = new_value;
      }
    public void unsetUserRequestedShuffle()
      {
        flagHasUserRequestedShuffle = false;
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
    public void initOrderToDisplay()
      {
        flagHasOrderToDisplay = true;
        storeOrderToDisplay.Clear();
      }
    public void appendOrderToDisplay(TypeOrderToDisplay to_append)
      {
        if (!flagHasOrderToDisplay)
          {
            flagHasOrderToDisplay = true;
            storeOrderToDisplay.Clear();
          }
        Debug.Assert(flagHasOrderToDisplay);
        storeOrderToDisplay.Add(to_append);
      }
    public void appendOrderToDisplay(string chars)
      {
        TypeOrderToDisplayKnownValues known = stringToOrderToDisplay(chars);
        TypeOrderToDisplay new_value = new TypeOrderToDisplay();
        if (known == TypeOrderToDisplayKnownValues.OrderToDisplay__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendOrderToDisplay(new_value);
      }
    public void appendOrderToDisplay(TypeOrderToDisplayKnownValues new_value)
      {
        TypeOrderToDisplay new_full_value = new TypeOrderToDisplay();
        Debug.Assert(new_value != TypeOrderToDisplayKnownValues.OrderToDisplay__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        appendOrderToDisplay(new_full_value);
      }
    public void unsetOrderToDisplay()
      {
        flagHasOrderToDisplay = false;
        storeOrderToDisplay.Clear();
      }

    public abstract void extraMusicCommandNativeDataAppendPair(string key, JSONValue new_component);
    public abstract void extraMusicCommandNativeDataSetField(string key, JSONValue new_component);

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
        handler.pair("MusicCommandNativeDataKind", getMusicCommandNativeDataKind());
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
        if (flagHasUserRequestedAutoPlay)
          {
            handler.start_pair("UserRequestedAutoPlay");
            handler.boolean_value(storeUserRequestedAutoPlay);
          }
        if (flagHasUserRequestedAirplay)
          {
            handler.start_pair("UserRequestedAirplay");
            handler.boolean_value(storeUserRequestedAirplay);
          }
        if (flagHasUserRequestedRepeat)
          {
            handler.start_pair("UserRequestedRepeat");
            handler.boolean_value(storeUserRequestedRepeat);
          }
        if (flagHasUserRequestedShuffle)
          {
            handler.start_pair("UserRequestedShuffle");
            handler.boolean_value(storeUserRequestedShuffle);
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
        if (flagHasOrderToDisplay)
          {
            handler.start_pair("OrderToDisplay");
            Debug.Assert(storeOrderToDisplay.Count >= 3);
            handler.start_array();
            for (int num7 = 0; num7 < storeOrderToDisplay.Count; ++num7)
              {
                if (storeOrderToDisplay[num7].in_known_list)
                  {
                    switch (storeOrderToDisplay[num7].list_value)
                      {
                        case TypeOrderToDisplayKnownValues.OrderToDisplay_Album:
                            handler.string_value("Album");
                            break;
                        case TypeOrderToDisplayKnownValues.OrderToDisplay_Artist:
                            handler.string_value("Artist");
                            break;
                        case TypeOrderToDisplayKnownValues.OrderToDisplay_Track:
                            handler.string_value("Track");
                            break;
                        case TypeOrderToDisplayKnownValues.OrderToDisplay_Video:
                            handler.string_value("Video");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeOrderToDisplay[num7].string_value);
                  }
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static MusicCommandNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicCommandNativeData", ignore_extras);
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
    public static MusicCommandNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicCommandNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicCommandNativeData", ignore_extras);
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
    public static MusicCommandNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicCommandNativeDataJSON from_text(string text, bool ignore_extras)
      {
        MusicCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicCommandNativeData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicCommandNativeDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicCommandNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicCommandNativeData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MusicSearchParametersJSON.HoldingGenerator fieldGeneratorSearchParameters;
        private JSONHoldingStringGenerator fieldGeneratorAlbumsLabel;
        private MusicAlbumJSON.HoldingArrayGenerator fieldGeneratorAlbums;
        private JSONHoldingStringGenerator fieldGeneratorArtistsLabel;
        private MusicArtistJSON.HoldingArrayGenerator fieldGeneratorArtists;
        private JSONHoldingStringGenerator fieldGeneratorTracksLabel;
        private MusicTrackJSON.HoldingArrayGenerator fieldGeneratorTracks;
        private MusicTrackSupplementalInfoJSON.HoldingArrayGenerator fieldGeneratorSupplementalTrackInfos;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedAutoPlay;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedAirplay;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedRepeat;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedShuffle;
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
    private abstract class FieldGeneratorOrderToDisplay : JSONStringGenerator
          {
            protected FieldGeneratorOrderToDisplay(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorOrderToDisplay()
              {
              }
            protected override void handle_result(string result)
              {
                TypeOrderToDisplayKnownValues known = stringToOrderToDisplay(result);
                TypeOrderToDisplay new_value = new TypeOrderToDisplay();
                if (known == TypeOrderToDisplayKnownValues.OrderToDisplay__none)
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
            protected abstract void handle_result(TypeOrderToDisplay result);
          };
    private class FieldHoldingGeneratorOrderToDisplay : FieldGeneratorOrderToDisplay
  {
    protected override void handle_result(TypeOrderToDisplay result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorOrderToDisplay(String what)
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
    public TypeOrderToDisplay value;
  };
    private class FieldHoldingArrayGeneratorOrderToDisplay : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorOrderToDisplay
      {
        private FieldHoldingArrayGeneratorOrderToDisplay top;

        protected override void handle_result(TypeOrderToDisplay result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorOrderToDisplay init_top)
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
    protected virtual void handle_result(List<TypeOrderToDisplay> result)
      {
      }

    public FieldHoldingArrayGeneratorOrderToDisplay(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeOrderToDisplay>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorOrderToDisplay()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeOrderToDisplay>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeOrderToDisplay> value;
  };
        private FieldHoldingArrayGeneratorOrderToDisplay fieldGeneratorOrderToDisplay;
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
            if (!(keyGenerator.have_value))
                throw new Exception("The `MusicCommandNativeDataKind' field is missing.");
            MusicCommandNativeDataJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicCommandNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getMusicCommandNativeDataJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `MusicCommandNativeDataKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(MusicCommandNativeDataJSON result)
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
            if (fieldGeneratorUserRequestedAutoPlay.have_value)
              {
                result.setUserRequestedAutoPlay(fieldGeneratorUserRequestedAutoPlay.value);
                fieldGeneratorUserRequestedAutoPlay.have_value = false;
              }
            if (fieldGeneratorUserRequestedAirplay.have_value)
              {
                result.setUserRequestedAirplay(fieldGeneratorUserRequestedAirplay.value);
                fieldGeneratorUserRequestedAirplay.have_value = false;
              }
            if (fieldGeneratorUserRequestedRepeat.have_value)
              {
                result.setUserRequestedRepeat(fieldGeneratorUserRequestedRepeat.value);
                fieldGeneratorUserRequestedRepeat.have_value = false;
              }
            if (fieldGeneratorUserRequestedShuffle.have_value)
              {
                result.setUserRequestedShuffle(fieldGeneratorUserRequestedShuffle.value);
                fieldGeneratorUserRequestedShuffle.have_value = false;
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
            if (fieldGeneratorOrderToDisplay.have_value)
              {
                result.initOrderToDisplay();
                int count = fieldGeneratorOrderToDisplay.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOrderToDisplay(fieldGeneratorOrderToDisplay.value[num]);
                  }
                fieldGeneratorOrderToDisplay.value.Clear();
                fieldGeneratorOrderToDisplay.have_value = false;
              }
          }
        protected abstract void handle_result(MusicCommandNativeDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
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
                            case 'C':
                                if ((String.Compare(field_name, 6, "ommandNativeDataKind", 0, 20, false) == 0) && (field_name.Length == 26))
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
                case 'O':
                    if ((String.Compare(field_name, 1, "rderToDisplay", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorOrderToDisplay;
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
                    if (String.Compare(field_name, 1, "serRequested", 0, 12, false) == 0)
                      {
                        switch (field_name[13])
                          {
                            case 'A':
                                switch (field_name[14])
                                  {
                                    case 'i':
                                        if ((String.Compare(field_name, 15, "rplay", 0, 5, false) == 0) && (field_name.Length == 20))
                                            return fieldGeneratorUserRequestedAirplay;
                                        break;
                                    case 'l':
                                        if ((String.Compare(field_name, 15, "l", 0, 1, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorUserRequestedAll;
                                        break;
                                    case 'u':
                                        if ((String.Compare(field_name, 15, "toPlay", 0, 6, false) == 0) && (field_name.Length == 21))
                                            return fieldGeneratorUserRequestedAutoPlay;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 14, "epeat", 0, 5, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorUserRequestedRepeat;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 14, "huffle", 0, 6, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorUserRequestedShuffle;
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
            fieldGeneratorSearchParameters = new MusicSearchParametersJSON.HoldingGenerator("field \"SearchParameters\" of the MusicCommandNativeData class", ignore_extras);
            fieldGeneratorAlbumsLabel = new JSONHoldingStringGenerator("field \"AlbumsLabel\" of the MusicCommandNativeData class");
            fieldGeneratorAlbums = new MusicAlbumJSON.HoldingArrayGenerator("field \"Albums\" of the MusicCommandNativeData class", ignore_extras);
            fieldGeneratorArtistsLabel = new JSONHoldingStringGenerator("field \"ArtistsLabel\" of the MusicCommandNativeData class");
            fieldGeneratorArtists = new MusicArtistJSON.HoldingArrayGenerator("field \"Artists\" of the MusicCommandNativeData class", ignore_extras);
            fieldGeneratorTracksLabel = new JSONHoldingStringGenerator("field \"TracksLabel\" of the MusicCommandNativeData class");
            fieldGeneratorTracks = new MusicTrackJSON.HoldingArrayGenerator("field \"Tracks\" of the MusicCommandNativeData class", ignore_extras);
            fieldGeneratorSupplementalTrackInfos = new MusicTrackSupplementalInfoJSON.HoldingArrayGenerator("field \"SupplementalTrackInfos\" of the MusicCommandNativeData class", ignore_extras);
            fieldGeneratorUserRequestedAutoPlay = new JSONHoldingBooleanGenerator("field \"UserRequestedAutoPlay\" of the MusicCommandNativeData class");
            fieldGeneratorUserRequestedAirplay = new JSONHoldingBooleanGenerator("field \"UserRequestedAirplay\" of the MusicCommandNativeData class");
            fieldGeneratorUserRequestedRepeat = new JSONHoldingBooleanGenerator("field \"UserRequestedRepeat\" of the MusicCommandNativeData class");
            fieldGeneratorUserRequestedShuffle = new JSONHoldingBooleanGenerator("field \"UserRequestedShuffle\" of the MusicCommandNativeData class");
            fieldGeneratorUserRequestedAll = new JSONHoldingBooleanGenerator("field \"UserRequestedAll\" of the MusicCommandNativeData class");
            fieldGeneratorArtistSpecified = new JSONHoldingBooleanGenerator("field \"ArtistSpecified\" of the MusicCommandNativeData class");
            fieldGeneratorQueryArtists = new MusicArtistJSON.HoldingArrayGenerator("field \"QueryArtists\" of the MusicCommandNativeData class", ignore_extras);
            fieldGeneratorEntitySpecificationType = new FieldHoldingGeneratorEntitySpecificationType("field \"EntitySpecificationType\" of the MusicCommandNativeData class");
            fieldGeneratorMusicThirdParty = new MusicThirdPartyJSON.HoldingGenerator("field \"MusicThirdParty\" of the MusicCommandNativeData class", ignore_extras);
            fieldGeneratorListPosition = new FieldHoldingGeneratorListPosition("field \"ListPosition\" of the MusicCommandNativeData class");
            fieldGeneratorErrors = new MusicSearchErrorJSON.HoldingArrayGenerator("field \"Errors\" of the MusicCommandNativeData class", ignore_extras);
            fieldGeneratorOrderToDisplay = new FieldHoldingArrayGeneratorOrderToDisplay("field \"OrderToDisplay\" of the MusicCommandNativeData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"MusicCommandNativeDataKind\" of the MusicCommandNativeData class");
            set_what("the MusicCommandNativeData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSearchParameters = new MusicSearchParametersJSON.HoldingGenerator("field \"SearchParameters\" of the MusicCommandNativeData class", false);
            fieldGeneratorAlbumsLabel = new JSONHoldingStringGenerator("field \"AlbumsLabel\" of the MusicCommandNativeData class");
            fieldGeneratorAlbums = new MusicAlbumJSON.HoldingArrayGenerator("field \"Albums\" of the MusicCommandNativeData class", false);
            fieldGeneratorArtistsLabel = new JSONHoldingStringGenerator("field \"ArtistsLabel\" of the MusicCommandNativeData class");
            fieldGeneratorArtists = new MusicArtistJSON.HoldingArrayGenerator("field \"Artists\" of the MusicCommandNativeData class", false);
            fieldGeneratorTracksLabel = new JSONHoldingStringGenerator("field \"TracksLabel\" of the MusicCommandNativeData class");
            fieldGeneratorTracks = new MusicTrackJSON.HoldingArrayGenerator("field \"Tracks\" of the MusicCommandNativeData class", false);
            fieldGeneratorSupplementalTrackInfos = new MusicTrackSupplementalInfoJSON.HoldingArrayGenerator("field \"SupplementalTrackInfos\" of the MusicCommandNativeData class", false);
            fieldGeneratorUserRequestedAutoPlay = new JSONHoldingBooleanGenerator("field \"UserRequestedAutoPlay\" of the MusicCommandNativeData class");
            fieldGeneratorUserRequestedAirplay = new JSONHoldingBooleanGenerator("field \"UserRequestedAirplay\" of the MusicCommandNativeData class");
            fieldGeneratorUserRequestedRepeat = new JSONHoldingBooleanGenerator("field \"UserRequestedRepeat\" of the MusicCommandNativeData class");
            fieldGeneratorUserRequestedShuffle = new JSONHoldingBooleanGenerator("field \"UserRequestedShuffle\" of the MusicCommandNativeData class");
            fieldGeneratorUserRequestedAll = new JSONHoldingBooleanGenerator("field \"UserRequestedAll\" of the MusicCommandNativeData class");
            fieldGeneratorArtistSpecified = new JSONHoldingBooleanGenerator("field \"ArtistSpecified\" of the MusicCommandNativeData class");
            fieldGeneratorQueryArtists = new MusicArtistJSON.HoldingArrayGenerator("field \"QueryArtists\" of the MusicCommandNativeData class", false);
            fieldGeneratorEntitySpecificationType = new FieldHoldingGeneratorEntitySpecificationType("field \"EntitySpecificationType\" of the MusicCommandNativeData class");
            fieldGeneratorMusicThirdParty = new MusicThirdPartyJSON.HoldingGenerator("field \"MusicThirdParty\" of the MusicCommandNativeData class", false);
            fieldGeneratorListPosition = new FieldHoldingGeneratorListPosition("field \"ListPosition\" of the MusicCommandNativeData class");
            fieldGeneratorErrors = new MusicSearchErrorJSON.HoldingArrayGenerator("field \"Errors\" of the MusicCommandNativeData class", false);
            fieldGeneratorOrderToDisplay = new FieldHoldingArrayGeneratorOrderToDisplay("field \"OrderToDisplay\" of the MusicCommandNativeData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"MusicCommandNativeDataKind\" of the MusicCommandNativeData class");
            set_what("the MusicCommandNativeData class");
            allow_incomplete = false;
            allow_unpolished = false;
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
            fieldGeneratorUserRequestedAutoPlay.reset();
            fieldGeneratorUserRequestedAirplay.reset();
            fieldGeneratorUserRequestedRepeat.reset();
            fieldGeneratorUserRequestedShuffle.reset();
            fieldGeneratorUserRequestedAll.reset();
            fieldGeneratorArtistSpecified.reset();
            fieldGeneratorQueryArtists.reset();
            fieldGeneratorEntitySpecificationType.reset();
            fieldGeneratorMusicThirdParty.reset();
            fieldGeneratorListPosition.reset();
            fieldGeneratorErrors.reset();
            fieldGeneratorOrderToDisplay.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSearchParameters.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAlbums.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorArtists.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTracks.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSupplementalTrackInfos.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorQueryArtists.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMusicThirdParty.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorErrors.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSearchParameters.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAlbums.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorArtists.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTracks.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSupplementalTrackInfos.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorQueryArtists.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMusicThirdParty.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorErrors.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicCommandNativeDataJSON  result)
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
        public MusicCommandNativeDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicCommandNativeDataJSON  result)
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
    protected virtual void handle_result(List<MusicCommandNativeDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicCommandNativeDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicCommandNativeDataJSON>();
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
    public List<MusicCommandNativeDataJSON> value;
  };
    class GenericMusicCommandNativeDataJSON : MusicCommandNativeDataJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericMusicCommandNativeDataJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getMusicCommandNativeDataKind()  { return key; }
        public override int extraMusicCommandNativeDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraMusicCommandNativeDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraMusicCommandNativeDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraMusicCommandNativeDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraMusicCommandNativeDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraMusicCommandNativeDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraMusicCommandNativeDataLookup(key);
            if (old_field == null)
              {
                extraMusicCommandNativeDataAppendPair(key, new_component);
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
    public static MusicCommandNativeDataJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "Music", 0, 5, false) == 0)
      {
        switch (key[5])
          {
            case 'C':
                if ((String.Compare(key, 6, "hartsCommandNativeData", 0, 22, false) == 0) && (key.Length == 28))
                    return new MusicChartsCommandNativeDataJSON();
                break;
            case 'S':
                if ((String.Compare(key, 6, "earchCommandNativeData", 0, 22, false) == 0) && (key.Length == 28))
                    return new MusicSearchCommandNativeDataJSON();
                break;
            default:
                break;
          }
      }

        return new GenericMusicCommandNativeDataJSON(key);
      }
  };
