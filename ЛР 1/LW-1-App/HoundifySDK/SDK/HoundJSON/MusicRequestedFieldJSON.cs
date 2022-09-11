/* file "MusicRequestedFieldJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicRequestedFieldJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_ArtistName,
        Value_AlbumName,
        Value_TrackName,
        Value_ArtistAge,
        Value_ArtistBirthDate,
        Value_ArtistBirthday,
        Value_ArtistBirthPlace,
        Value_ArtistDeathDate,
        Value_ArtistDeathPlace,
        Value_ArtistBandMembers,
        Value_ArtistFirstTrack,
        Value_ArtistFirstAlbum,
        Value_ArtistWhenActive,
        Value_ArtistMostRecentAlbum,
        Value_ArtistWhichGroupsPlayedIn,
        Value_ArtistGenre,
        Value_ArtistRelatedArtists,
        Value_ArtistCollaborations,
        Value_AlbumGenre,
        Value_AlbumReleaseDate,
        Value_AlbumBandMembers,
        Value_TrackGenre,
        Value_TrackReleaseDate,
        Value_Artist1InArtist2,
        Value_TopTracks,
        Value_AlbumMostPopularTrack,
        Value_ArtistTopTracks,
        Value_TrackLyricsLookup,
        Value_ArtistImages,
        Value_ArtistBiography,
        Value__none
      };
    public struct TypeValue
      {
        public bool in_known_list;
        public string string_value;
        public TypeValueKnownValues list_value;
      };

    public static TypeValueKnownValues  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'l':
                        if (String.Compare(chars, 2, "bum", 0, 3, false) == 0)
                          {
                            switch (chars[5])
                              {
                                case 'B':
                                    if ((String.Compare(chars, 6, "andMembers", 0, 10, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_AlbumBandMembers;
                                    break;
                                case 'G':
                                    if ((String.Compare(chars, 6, "enre", 0, 4, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_AlbumGenre;
                                    break;
                                case 'M':
                                    if ((String.Compare(chars, 6, "ostPopularTrack", 0, 15, false) == 0) && (chars.Length == 21))
                                        return TypeValueKnownValues.Value_AlbumMostPopularTrack;
                                    break;
                                case 'N':
                                    if ((String.Compare(chars, 6, "ame", 0, 3, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_AlbumName;
                                    break;
                                case 'R':
                                    if ((String.Compare(chars, 6, "eleaseDate", 0, 10, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_AlbumReleaseDate;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(chars, 2, "tist", 0, 4, false) == 0)
                          {
                            switch (chars[6])
                              {
                                case '1':
                                    if ((String.Compare(chars, 7, "InArtist2", 0, 9, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_Artist1InArtist2;
                                    break;
                                case 'A':
                                    if ((String.Compare(chars, 7, "ge", 0, 2, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_ArtistAge;
                                    break;
                                case 'B':
                                    switch (chars[7])
                                      {
                                        case 'a':
                                            if ((String.Compare(chars, 8, "ndMembers", 0, 9, false) == 0) && (chars.Length == 17))
                                                return TypeValueKnownValues.Value_ArtistBandMembers;
                                            break;
                                        case 'i':
                                            switch (chars[8])
                                              {
                                                case 'o':
                                                    if ((String.Compare(chars, 9, "graphy", 0, 6, false) == 0) && (chars.Length == 15))
                                                        return TypeValueKnownValues.Value_ArtistBiography;
                                                    break;
                                                case 'r':
                                                    if (String.Compare(chars, 9, "th", 0, 2, false) == 0)
                                                      {
                                                        switch (chars[11])
                                                          {
                                                            case 'D':
                                                                if ((String.Compare(chars, 12, "ate", 0, 3, false) == 0) && (chars.Length == 15))
                                                                    return TypeValueKnownValues.Value_ArtistBirthDate;
                                                                break;
                                                            case 'P':
                                                                if ((String.Compare(chars, 12, "lace", 0, 4, false) == 0) && (chars.Length == 16))
                                                                    return TypeValueKnownValues.Value_ArtistBirthPlace;
                                                                break;
                                                            case 'd':
                                                                if ((String.Compare(chars, 12, "ay", 0, 2, false) == 0) && (chars.Length == 14))
                                                                    return TypeValueKnownValues.Value_ArtistBirthday;
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
                                        default:
                                            break;
                                      }
                                    break;
                                case 'C':
                                    if ((String.Compare(chars, 7, "ollaborations", 0, 13, false) == 0) && (chars.Length == 20))
                                        return TypeValueKnownValues.Value_ArtistCollaborations;
                                    break;
                                case 'D':
                                    if (String.Compare(chars, 7, "eath", 0, 4, false) == 0)
                                      {
                                        switch (chars[11])
                                          {
                                            case 'D':
                                                if ((String.Compare(chars, 12, "ate", 0, 3, false) == 0) && (chars.Length == 15))
                                                    return TypeValueKnownValues.Value_ArtistDeathDate;
                                                break;
                                            case 'P':
                                                if ((String.Compare(chars, 12, "lace", 0, 4, false) == 0) && (chars.Length == 16))
                                                    return TypeValueKnownValues.Value_ArtistDeathPlace;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'F':
                                    if (String.Compare(chars, 7, "irst", 0, 4, false) == 0)
                                      {
                                        switch (chars[11])
                                          {
                                            case 'A':
                                                if ((String.Compare(chars, 12, "lbum", 0, 4, false) == 0) && (chars.Length == 16))
                                                    return TypeValueKnownValues.Value_ArtistFirstAlbum;
                                                break;
                                            case 'T':
                                                if ((String.Compare(chars, 12, "rack", 0, 4, false) == 0) && (chars.Length == 16))
                                                    return TypeValueKnownValues.Value_ArtistFirstTrack;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'G':
                                    if ((String.Compare(chars, 7, "enre", 0, 4, false) == 0) && (chars.Length == 11))
                                        return TypeValueKnownValues.Value_ArtistGenre;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 7, "mages", 0, 5, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_ArtistImages;
                                    break;
                                case 'M':
                                    if ((String.Compare(chars, 7, "ostRecentAlbum", 0, 14, false) == 0) && (chars.Length == 21))
                                        return TypeValueKnownValues.Value_ArtistMostRecentAlbum;
                                    break;
                                case 'N':
                                    if ((String.Compare(chars, 7, "ame", 0, 3, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_ArtistName;
                                    break;
                                case 'R':
                                    if ((String.Compare(chars, 7, "elatedArtists", 0, 13, false) == 0) && (chars.Length == 20))
                                        return TypeValueKnownValues.Value_ArtistRelatedArtists;
                                    break;
                                case 'T':
                                    if ((String.Compare(chars, 7, "opTracks", 0, 8, false) == 0) && (chars.Length == 15))
                                        return TypeValueKnownValues.Value_ArtistTopTracks;
                                    break;
                                case 'W':
                                    if (String.Compare(chars, 7, "h", 0, 1, false) == 0)
                                      {
                                        switch (chars[8])
                                          {
                                            case 'e':
                                                if ((String.Compare(chars, 9, "nActive", 0, 7, false) == 0) && (chars.Length == 16))
                                                    return TypeValueKnownValues.Value_ArtistWhenActive;
                                                break;
                                            case 'i':
                                                if ((String.Compare(chars, 9, "chGroupsPlayedIn", 0, 16, false) == 0) && (chars.Length == 25))
                                                    return TypeValueKnownValues.Value_ArtistWhichGroupsPlayedIn;
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
                    default:
                        break;
                  }
                break;
            case 'T':
                switch (chars[1])
                  {
                    case 'o':
                        if ((String.Compare(chars, 2, "pTracks", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeValueKnownValues.Value_TopTracks;
                        break;
                    case 'r':
                        if (String.Compare(chars, 2, "ack", 0, 3, false) == 0)
                          {
                            switch (chars[5])
                              {
                                case 'G':
                                    if ((String.Compare(chars, 6, "enre", 0, 4, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_TrackGenre;
                                    break;
                                case 'L':
                                    if ((String.Compare(chars, 6, "yricsLookup", 0, 11, false) == 0) && (chars.Length == 17))
                                        return TypeValueKnownValues.Value_TrackLyricsLookup;
                                    break;
                                case 'N':
                                    if ((String.Compare(chars, 6, "ame", 0, 3, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_TrackName;
                                    break;
                                case 'R':
                                    if ((String.Compare(chars, 6, "eleaseDate", 0, 10, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_TrackReleaseDate;
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
            default:
                break;
          }
        return TypeValueKnownValues.Value__none;
      }

    public static string  stringFromValue(TypeValueKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeValueKnownValues.Value_ArtistName:
                return "ArtistName";
            case TypeValueKnownValues.Value_AlbumName:
                return "AlbumName";
            case TypeValueKnownValues.Value_TrackName:
                return "TrackName";
            case TypeValueKnownValues.Value_ArtistAge:
                return "ArtistAge";
            case TypeValueKnownValues.Value_ArtistBirthDate:
                return "ArtistBirthDate";
            case TypeValueKnownValues.Value_ArtistBirthday:
                return "ArtistBirthday";
            case TypeValueKnownValues.Value_ArtistBirthPlace:
                return "ArtistBirthPlace";
            case TypeValueKnownValues.Value_ArtistDeathDate:
                return "ArtistDeathDate";
            case TypeValueKnownValues.Value_ArtistDeathPlace:
                return "ArtistDeathPlace";
            case TypeValueKnownValues.Value_ArtistBandMembers:
                return "ArtistBandMembers";
            case TypeValueKnownValues.Value_ArtistFirstTrack:
                return "ArtistFirstTrack";
            case TypeValueKnownValues.Value_ArtistFirstAlbum:
                return "ArtistFirstAlbum";
            case TypeValueKnownValues.Value_ArtistWhenActive:
                return "ArtistWhenActive";
            case TypeValueKnownValues.Value_ArtistMostRecentAlbum:
                return "ArtistMostRecentAlbum";
            case TypeValueKnownValues.Value_ArtistWhichGroupsPlayedIn:
                return "ArtistWhichGroupsPlayedIn";
            case TypeValueKnownValues.Value_ArtistGenre:
                return "ArtistGenre";
            case TypeValueKnownValues.Value_ArtistRelatedArtists:
                return "ArtistRelatedArtists";
            case TypeValueKnownValues.Value_ArtistCollaborations:
                return "ArtistCollaborations";
            case TypeValueKnownValues.Value_AlbumGenre:
                return "AlbumGenre";
            case TypeValueKnownValues.Value_AlbumReleaseDate:
                return "AlbumReleaseDate";
            case TypeValueKnownValues.Value_AlbumBandMembers:
                return "AlbumBandMembers";
            case TypeValueKnownValues.Value_TrackGenre:
                return "TrackGenre";
            case TypeValueKnownValues.Value_TrackReleaseDate:
                return "TrackReleaseDate";
            case TypeValueKnownValues.Value_Artist1InArtist2:
                return "Artist1InArtist2";
            case TypeValueKnownValues.Value_TopTracks:
                return "TopTracks";
            case TypeValueKnownValues.Value_AlbumMostPopularTrack:
                return "AlbumMostPopularTrack";
            case TypeValueKnownValues.Value_ArtistTopTracks:
                return "ArtistTopTracks";
            case TypeValueKnownValues.Value_TrackLyricsLookup:
                return "TrackLyricsLookup";
            case TypeValueKnownValues.Value_ArtistImages:
                return "ArtistImages";
            case TypeValueKnownValues.Value_ArtistBiography:
                return "ArtistBiography";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValue;
    private TypeValue storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Value of MusicRequestedFieldJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if (String.Compare(json_string.getData(), 2, "bum", 0, 3, false) == 0)
                          {
                            switch (json_string.getData()[5])
                              {
                                case 'B':
                                    if ((String.Compare(json_string.getData(), 6, "andMembers", 0, 10, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_AlbumBandMembers;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'G':
                                    if ((String.Compare(json_string.getData(), 6, "enre", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_AlbumGenre;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'M':
                                    if ((String.Compare(json_string.getData(), 6, "ostPopularTrack", 0, 15, false) == 0) && (json_string.getData().Length == 21))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_AlbumMostPopularTrack;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'N':
                                    if ((String.Compare(json_string.getData(), 6, "ame", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_AlbumName;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'R':
                                    if ((String.Compare(json_string.getData(), 6, "eleaseDate", 0, 10, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_AlbumReleaseDate;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(json_string.getData(), 2, "tist", 0, 4, false) == 0)
                          {
                            switch (json_string.getData()[6])
                              {
                                case '1':
                                    if ((String.Compare(json_string.getData(), 7, "InArtist2", 0, 9, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Artist1InArtist2;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'A':
                                    if ((String.Compare(json_string.getData(), 7, "ge", 0, 2, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_ArtistAge;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'B':
                                    switch (json_string.getData()[7])
                                      {
                                        case 'a':
                                            if ((String.Compare(json_string.getData(), 8, "ndMembers", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_ArtistBandMembers;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'i':
                                            switch (json_string.getData()[8])
                                              {
                                                case 'o':
                                                    if ((String.Compare(json_string.getData(), 9, "graphy", 0, 6, false) == 0) && (json_string.getData().Length == 15))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_ArtistBiography;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'r':
                                                    if (String.Compare(json_string.getData(), 9, "th", 0, 2, false) == 0)
                                                      {
                                                        switch (json_string.getData()[11])
                                                          {
                                                            case 'D':
                                                                if ((String.Compare(json_string.getData(), 12, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 15))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_ArtistBirthDate;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'P':
                                                                if ((String.Compare(json_string.getData(), 12, "lace", 0, 4, false) == 0) && (json_string.getData().Length == 16))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_ArtistBirthPlace;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'd':
                                                                if ((String.Compare(json_string.getData(), 12, "ay", 0, 2, false) == 0) && (json_string.getData().Length == 14))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeValueKnownValues.Value_ArtistBirthday;
                                                                        goto open_enum_is_done;
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
                                        default:
                                            break;
                                      }
                                    break;
                                case 'C':
                                    if ((String.Compare(json_string.getData(), 7, "ollaborations", 0, 13, false) == 0) && (json_string.getData().Length == 20))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_ArtistCollaborations;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'D':
                                    if (String.Compare(json_string.getData(), 7, "eath", 0, 4, false) == 0)
                                      {
                                        switch (json_string.getData()[11])
                                          {
                                            case 'D':
                                                if ((String.Compare(json_string.getData(), 12, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 15))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_ArtistDeathDate;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'P':
                                                if ((String.Compare(json_string.getData(), 12, "lace", 0, 4, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_ArtistDeathPlace;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'F':
                                    if (String.Compare(json_string.getData(), 7, "irst", 0, 4, false) == 0)
                                      {
                                        switch (json_string.getData()[11])
                                          {
                                            case 'A':
                                                if ((String.Compare(json_string.getData(), 12, "lbum", 0, 4, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_ArtistFirstAlbum;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'T':
                                                if ((String.Compare(json_string.getData(), 12, "rack", 0, 4, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_ArtistFirstTrack;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'G':
                                    if ((String.Compare(json_string.getData(), 7, "enre", 0, 4, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_ArtistGenre;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 7, "mages", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_ArtistImages;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'M':
                                    if ((String.Compare(json_string.getData(), 7, "ostRecentAlbum", 0, 14, false) == 0) && (json_string.getData().Length == 21))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_ArtistMostRecentAlbum;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'N':
                                    if ((String.Compare(json_string.getData(), 7, "ame", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_ArtistName;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'R':
                                    if ((String.Compare(json_string.getData(), 7, "elatedArtists", 0, 13, false) == 0) && (json_string.getData().Length == 20))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_ArtistRelatedArtists;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'T':
                                    if ((String.Compare(json_string.getData(), 7, "opTracks", 0, 8, false) == 0) && (json_string.getData().Length == 15))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_ArtistTopTracks;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'W':
                                    if (String.Compare(json_string.getData(), 7, "h", 0, 1, false) == 0)
                                      {
                                        switch (json_string.getData()[8])
                                          {
                                            case 'e':
                                                if ((String.Compare(json_string.getData(), 9, "nActive", 0, 7, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_ArtistWhenActive;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'i':
                                                if ((String.Compare(json_string.getData(), 9, "chGroupsPlayedIn", 0, 16, false) == 0) && (json_string.getData().Length == 25))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_ArtistWhichGroupsPlayedIn;
                                                        goto open_enum_is_done;
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
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "pTracks", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_TopTracks;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if (String.Compare(json_string.getData(), 2, "ack", 0, 3, false) == 0)
                          {
                            switch (json_string.getData()[5])
                              {
                                case 'G':
                                    if ((String.Compare(json_string.getData(), 6, "enre", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_TrackGenre;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'L':
                                    if ((String.Compare(json_string.getData(), 6, "yricsLookup", 0, 11, false) == 0) && (json_string.getData().Length == 17))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_TrackLyricsLookup;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'N':
                                    if ((String.Compare(json_string.getData(), 6, "ame", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_TrackName;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'R':
                                    if ((String.Compare(json_string.getData(), 6, "eleaseDate", 0, 10, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_TrackReleaseDate;
                                            goto open_enum_is_done;
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
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setValue(the_open_enum);
      }


    public MusicRequestedFieldJSON()
      {
        flagHasValue = false;
      }

    public MusicRequestedFieldJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public MusicRequestedFieldJSON(string init_value)
      {
        flagHasValue = true;
        TypeValueKnownValues known = stringToValue(init_value);
        if (known == TypeValueKnownValues.Value__none)
          {
            storeValue.in_known_list = false;
            storeValue.string_value = init_value;
          }
        else
          {
            storeValue.in_known_list = true;
            storeValue.list_value = known;
          }
      }

    public MusicRequestedFieldJSON(TypeValueKnownValues init_value)
      {
        flagHasValue = true;
        Debug.Assert(init_value != TypeValueKnownValues.Value__none);
        storeValue.in_known_list = true;
        storeValue.list_value = init_value;
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public TypeValue  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public string  getValueAsString()
      {
        TypeValue result = getValue();
        if (result.in_known_list)
            return stringFromValue(result.list_value);
        else
            return result.string_value;
      }



    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void setValue(string chars)
      {
        TypeValueKnownValues known = stringToValue(chars);
        TypeValue new_value = new TypeValue();
        if (known == TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setValue(new_value);
      }
    public void setValue(TypeValueKnownValues new_value)
      {
        TypeValue new_full_value = new TypeValue();
        Debug.Assert(new_value != TypeValueKnownValues.Value__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setValue(new_full_value);
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_ArtistName:
                    handler.string_value("ArtistName");
                    break;
                case TypeValueKnownValues.Value_AlbumName:
                    handler.string_value("AlbumName");
                    break;
                case TypeValueKnownValues.Value_TrackName:
                    handler.string_value("TrackName");
                    break;
                case TypeValueKnownValues.Value_ArtistAge:
                    handler.string_value("ArtistAge");
                    break;
                case TypeValueKnownValues.Value_ArtistBirthDate:
                    handler.string_value("ArtistBirthDate");
                    break;
                case TypeValueKnownValues.Value_ArtistBirthday:
                    handler.string_value("ArtistBirthday");
                    break;
                case TypeValueKnownValues.Value_ArtistBirthPlace:
                    handler.string_value("ArtistBirthPlace");
                    break;
                case TypeValueKnownValues.Value_ArtistDeathDate:
                    handler.string_value("ArtistDeathDate");
                    break;
                case TypeValueKnownValues.Value_ArtistDeathPlace:
                    handler.string_value("ArtistDeathPlace");
                    break;
                case TypeValueKnownValues.Value_ArtistBandMembers:
                    handler.string_value("ArtistBandMembers");
                    break;
                case TypeValueKnownValues.Value_ArtistFirstTrack:
                    handler.string_value("ArtistFirstTrack");
                    break;
                case TypeValueKnownValues.Value_ArtistFirstAlbum:
                    handler.string_value("ArtistFirstAlbum");
                    break;
                case TypeValueKnownValues.Value_ArtistWhenActive:
                    handler.string_value("ArtistWhenActive");
                    break;
                case TypeValueKnownValues.Value_ArtistMostRecentAlbum:
                    handler.string_value("ArtistMostRecentAlbum");
                    break;
                case TypeValueKnownValues.Value_ArtistWhichGroupsPlayedIn:
                    handler.string_value("ArtistWhichGroupsPlayedIn");
                    break;
                case TypeValueKnownValues.Value_ArtistGenre:
                    handler.string_value("ArtistGenre");
                    break;
                case TypeValueKnownValues.Value_ArtistRelatedArtists:
                    handler.string_value("ArtistRelatedArtists");
                    break;
                case TypeValueKnownValues.Value_ArtistCollaborations:
                    handler.string_value("ArtistCollaborations");
                    break;
                case TypeValueKnownValues.Value_AlbumGenre:
                    handler.string_value("AlbumGenre");
                    break;
                case TypeValueKnownValues.Value_AlbumReleaseDate:
                    handler.string_value("AlbumReleaseDate");
                    break;
                case TypeValueKnownValues.Value_AlbumBandMembers:
                    handler.string_value("AlbumBandMembers");
                    break;
                case TypeValueKnownValues.Value_TrackGenre:
                    handler.string_value("TrackGenre");
                    break;
                case TypeValueKnownValues.Value_TrackReleaseDate:
                    handler.string_value("TrackReleaseDate");
                    break;
                case TypeValueKnownValues.Value_Artist1InArtist2:
                    handler.string_value("Artist1InArtist2");
                    break;
                case TypeValueKnownValues.Value_TopTracks:
                    handler.string_value("TopTracks");
                    break;
                case TypeValueKnownValues.Value_AlbumMostPopularTrack:
                    handler.string_value("AlbumMostPopularTrack");
                    break;
                case TypeValueKnownValues.Value_ArtistTopTracks:
                    handler.string_value("ArtistTopTracks");
                    break;
                case TypeValueKnownValues.Value_TrackLyricsLookup:
                    handler.string_value("TrackLyricsLookup");
                    break;
                case TypeValueKnownValues.Value_ArtistImages:
                    handler.string_value("ArtistImages");
                    break;
                case TypeValueKnownValues.Value_ArtistBiography:
                    handler.string_value("ArtistBiography");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_ArtistName:
                    handler.string_value("ArtistName");
                    break;
                case TypeValueKnownValues.Value_AlbumName:
                    handler.string_value("AlbumName");
                    break;
                case TypeValueKnownValues.Value_TrackName:
                    handler.string_value("TrackName");
                    break;
                case TypeValueKnownValues.Value_ArtistAge:
                    handler.string_value("ArtistAge");
                    break;
                case TypeValueKnownValues.Value_ArtistBirthDate:
                    handler.string_value("ArtistBirthDate");
                    break;
                case TypeValueKnownValues.Value_ArtistBirthday:
                    handler.string_value("ArtistBirthday");
                    break;
                case TypeValueKnownValues.Value_ArtistBirthPlace:
                    handler.string_value("ArtistBirthPlace");
                    break;
                case TypeValueKnownValues.Value_ArtistDeathDate:
                    handler.string_value("ArtistDeathDate");
                    break;
                case TypeValueKnownValues.Value_ArtistDeathPlace:
                    handler.string_value("ArtistDeathPlace");
                    break;
                case TypeValueKnownValues.Value_ArtistBandMembers:
                    handler.string_value("ArtistBandMembers");
                    break;
                case TypeValueKnownValues.Value_ArtistFirstTrack:
                    handler.string_value("ArtistFirstTrack");
                    break;
                case TypeValueKnownValues.Value_ArtistFirstAlbum:
                    handler.string_value("ArtistFirstAlbum");
                    break;
                case TypeValueKnownValues.Value_ArtistWhenActive:
                    handler.string_value("ArtistWhenActive");
                    break;
                case TypeValueKnownValues.Value_ArtistMostRecentAlbum:
                    handler.string_value("ArtistMostRecentAlbum");
                    break;
                case TypeValueKnownValues.Value_ArtistWhichGroupsPlayedIn:
                    handler.string_value("ArtistWhichGroupsPlayedIn");
                    break;
                case TypeValueKnownValues.Value_ArtistGenre:
                    handler.string_value("ArtistGenre");
                    break;
                case TypeValueKnownValues.Value_ArtistRelatedArtists:
                    handler.string_value("ArtistRelatedArtists");
                    break;
                case TypeValueKnownValues.Value_ArtistCollaborations:
                    handler.string_value("ArtistCollaborations");
                    break;
                case TypeValueKnownValues.Value_AlbumGenre:
                    handler.string_value("AlbumGenre");
                    break;
                case TypeValueKnownValues.Value_AlbumReleaseDate:
                    handler.string_value("AlbumReleaseDate");
                    break;
                case TypeValueKnownValues.Value_AlbumBandMembers:
                    handler.string_value("AlbumBandMembers");
                    break;
                case TypeValueKnownValues.Value_TrackGenre:
                    handler.string_value("TrackGenre");
                    break;
                case TypeValueKnownValues.Value_TrackReleaseDate:
                    handler.string_value("TrackReleaseDate");
                    break;
                case TypeValueKnownValues.Value_Artist1InArtist2:
                    handler.string_value("Artist1InArtist2");
                    break;
                case TypeValueKnownValues.Value_TopTracks:
                    handler.string_value("TopTracks");
                    break;
                case TypeValueKnownValues.Value_AlbumMostPopularTrack:
                    handler.string_value("AlbumMostPopularTrack");
                    break;
                case TypeValueKnownValues.Value_ArtistTopTracks:
                    handler.string_value("ArtistTopTracks");
                    break;
                case TypeValueKnownValues.Value_TrackLyricsLookup:
                    handler.string_value("TrackLyricsLookup");
                    break;
                case TypeValueKnownValues.Value_ArtistImages:
                    handler.string_value("ArtistImages");
                    break;
                case TypeValueKnownValues.Value_ArtistBiography:
                    handler.string_value("ArtistBiography");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }

    public static MusicRequestedFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicRequestedFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicRequestedField", ignore_extras);
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
    public static MusicRequestedFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicRequestedFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicRequestedFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicRequestedField", ignore_extras);
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
    public static MusicRequestedFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicRequestedFieldJSON from_text(string text, bool ignore_extras)
      {
        MusicRequestedFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicRequestedField", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicRequestedFieldJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicRequestedFieldJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicRequestedFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicRequestedField", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class FieldGeneratorValue : JSONStringGenerator
      {
        protected FieldGeneratorValue(string what)
          {
            set_what(what);
          }
        protected FieldGeneratorValue()
          {
          }
        protected override void handle_result(string result)
          {
            TypeValueKnownValues known = stringToValue(result);
            TypeValue new_value = new TypeValue();
            if (known == TypeValueKnownValues.Value__none)
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
        protected abstract void handle_result(TypeValue result);
      };
    public class FieldHoldingGeneratorValue : FieldGeneratorValue
  {
    protected override void handle_result(TypeValue result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorValue(String what)
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
    public TypeValue value;
  };
    public class FieldHoldingArrayGeneratorValue : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorValue
      {
        private FieldHoldingArrayGeneratorValue top;

        protected override void handle_result(TypeValue result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorValue init_top)
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
    protected virtual void handle_result(List<TypeValue> result)
      {
      }

    public FieldHoldingArrayGeneratorValue(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValue()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeValue> value;
  };
    public abstract class Generator : FieldGeneratorValue
      {
        protected override void handle_result(TypeValue new_value)
          {
            MusicRequestedFieldJSON result = new MusicRequestedFieldJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(MusicRequestedFieldJSON new_result);
        public Generator(bool ignore_extras) : base("Type MusicRequestedField")
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicRequestedFieldJSON  result)
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
        public MusicRequestedFieldJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicRequestedFieldJSON  result)
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
    protected virtual void handle_result(List<MusicRequestedFieldJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicRequestedFieldJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicRequestedFieldJSON>();
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
    public List<MusicRequestedFieldJSON> value;
  };
  };
