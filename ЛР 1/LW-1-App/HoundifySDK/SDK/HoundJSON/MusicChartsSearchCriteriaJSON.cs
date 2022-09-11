/* file "MusicChartsSearchCriteriaJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MusicChartsSearchCriteriaJSON : JSONBase
  {
    public enum TypeEntityKnownValues
      {
        Entity_Tracks,
        Entity_Artists,
        Entity_Albums,
        Entity_Videos,
        Entity_ArtistsBornOn,
        Entity_Playlist,
        Entity__none
      };
    public struct TypeEntity
      {
        public bool in_known_list;
        public string string_value;
        public TypeEntityKnownValues list_value;
      };

    public static TypeEntityKnownValues  stringToEntity(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'l':
                        if ((String.Compare(chars, 2, "bums", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeEntityKnownValues.Entity_Albums;
                        break;
                    case 'r':
                        if (String.Compare(chars, 2, "tists", 0, 5, false) == 0)
                          {
                            if (chars.Length == 7)
                              {
                                return TypeEntityKnownValues.Entity_Artists;
                              }
                            switch (chars[7])
                              {
                                case 'B':
                                    if ((String.Compare(chars, 8, "ornOn", 0, 5, false) == 0) && (chars.Length == 13))
                                        return TypeEntityKnownValues.Entity_ArtistsBornOn;
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
            case 'P':
                if ((String.Compare(chars, 1, "laylist", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeEntityKnownValues.Entity_Playlist;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "racks", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeEntityKnownValues.Entity_Tracks;
                break;
            case 'V':
                if ((String.Compare(chars, 1, "ideos", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeEntityKnownValues.Entity_Videos;
                break;
            default:
                break;
          }
        return TypeEntityKnownValues.Entity__none;
      }

    public static string  stringFromEntity(TypeEntityKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeEntityKnownValues.Entity_Tracks:
                return "Tracks";
            case TypeEntityKnownValues.Entity_Artists:
                return "Artists";
            case TypeEntityKnownValues.Entity_Albums:
                return "Albums";
            case TypeEntityKnownValues.Entity_Videos:
                return "Videos";
            case TypeEntityKnownValues.Entity_ArtistsBornOn:
                return "ArtistsBornOn";
            case TypeEntityKnownValues.Entity_Playlist:
                return "Playlist";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeModifierKnownValues
      {
        Modifier_Top,
        Modifier_New,
        Modifier__none
      };
    public struct TypeModifier
      {
        public bool in_known_list;
        public string string_value;
        public TypeModifierKnownValues list_value;
      };

    public static TypeModifierKnownValues  stringToModifier(string chars)
      {
        switch (chars[0])
          {
            case 'N':
                if ((String.Compare(chars, 1, "ew", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeModifierKnownValues.Modifier_New;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "op", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeModifierKnownValues.Modifier_Top;
                break;
            default:
                break;
          }
        return TypeModifierKnownValues.Modifier__none;
      }

    public static string  stringFromModifier(TypeModifierKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeModifierKnownValues.Modifier_Top:
                return "Top";
            case TypeModifierKnownValues.Modifier_New:
                return "New";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeTimePeriodTypeKnownValues
      {
        TimePeriodType_Day,
        TimePeriodType_Week,
        TimePeriodType_Month,
        TimePeriodType_Year,
        TimePeriodType_Decade,
        TimePeriodType_Century,
        TimePeriodType_None,
        TimePeriodType__none
      };
    public struct TypeTimePeriodType
      {
        public bool in_known_list;
        public string string_value;
        public TypeTimePeriodTypeKnownValues list_value;
      };

    public static TypeTimePeriodTypeKnownValues  stringToTimePeriodType(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "entury", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeTimePeriodTypeKnownValues.TimePeriodType_Century;
                break;
            case 'D':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "y", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeTimePeriodTypeKnownValues.TimePeriodType_Day;
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "cade", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeTimePeriodTypeKnownValues.TimePeriodType_Decade;
                        break;
                    default:
                        break;
                  }
                break;
            case 'M':
                if ((String.Compare(chars, 1, "onth", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeTimePeriodTypeKnownValues.TimePeriodType_Month;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeTimePeriodTypeKnownValues.TimePeriodType_None;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "eek", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeTimePeriodTypeKnownValues.TimePeriodType_Week;
                break;
            case 'Y':
                if ((String.Compare(chars, 1, "ear", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeTimePeriodTypeKnownValues.TimePeriodType_Year;
                break;
            default:
                break;
          }
        return TypeTimePeriodTypeKnownValues.TimePeriodType__none;
      }

    public static string  stringFromTimePeriodType(TypeTimePeriodTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeTimePeriodTypeKnownValues.TimePeriodType_Day:
                return "Day";
            case TypeTimePeriodTypeKnownValues.TimePeriodType_Week:
                return "Week";
            case TypeTimePeriodTypeKnownValues.TimePeriodType_Month:
                return "Month";
            case TypeTimePeriodTypeKnownValues.TimePeriodType_Year:
                return "Year";
            case TypeTimePeriodTypeKnownValues.TimePeriodType_Decade:
                return "Decade";
            case TypeTimePeriodTypeKnownValues.TimePeriodType_Century:
                return "Century";
            case TypeTimePeriodTypeKnownValues.TimePeriodType_None:
                return "None";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeGenreKnownValues
      {
        Genre_NoGenre,
        Genre_Rock,
        Genre_Pop,
        Genre_Country,
        Genre_Electronic,
        Genre_Urban,
        Genre_Latin,
        Genre_AllGenres,
        Genre_Avant_x20_Garde,
        Genre_Blues,
        Genre_Childs,
        Genre_Classical,
        Genre_Easy,
        Genre_Folk,
        Genre_Gospel,
        Genre_Holiday,
        Genre_Jazz,
        Genre_Movie_x20_Soundtrack,
        Genre_New_x20_Age,
        Genre_Rap,
        Genre_R_x26_B,
        Genre_Reggae,
        Genre_Sound_x20_Effects,
        Genre_Spoken_x20_Word,
        Genre_Vocal,
        Genre_World,
        Genre_AltGenre,
        Genre_AltGenreFrenchFolk,
        Genre_AltGenreWestCoast,
        Genre_AltGenreEastCoast,
        Genre_AltGenreBritishPunk,
        Genre_AltGenreVideoGame,
        Genre_AltGenreTVSoundtrack,
        Genre_AltGenreBossaNova,
        Genre__none
      };
    public struct TypeGenre
      {
        public bool in_known_list;
        public string string_value;
        public TypeGenreKnownValues list_value;
      };

    public static TypeGenreKnownValues  stringToGenre(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'l':
                        switch (chars[2])
                          {
                            case 'l':
                                if ((String.Compare(chars, 3, "Genres", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeGenreKnownValues.Genre_AllGenres;
                                break;
                            case 't':
                                if (String.Compare(chars, 3, "Genre", 0, 5, false) == 0)
                                  {
                                    if (chars.Length == 8)
                                      {
                                        return TypeGenreKnownValues.Genre_AltGenre;
                                      }
                                    switch (chars[8])
                                      {
                                        case 'B':
                                            switch (chars[9])
                                              {
                                                case 'o':
                                                    if ((String.Compare(chars, 10, "ssaNova", 0, 7, false) == 0) && (chars.Length == 17))
                                                        return TypeGenreKnownValues.Genre_AltGenreBossaNova;
                                                    break;
                                                case 'r':
                                                    if ((String.Compare(chars, 10, "itishPunk", 0, 9, false) == 0) && (chars.Length == 19))
                                                        return TypeGenreKnownValues.Genre_AltGenreBritishPunk;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'E':
                                            if ((String.Compare(chars, 9, "astCoast", 0, 8, false) == 0) && (chars.Length == 17))
                                                return TypeGenreKnownValues.Genre_AltGenreEastCoast;
                                            break;
                                        case 'F':
                                            if ((String.Compare(chars, 9, "renchFolk", 0, 9, false) == 0) && (chars.Length == 18))
                                                return TypeGenreKnownValues.Genre_AltGenreFrenchFolk;
                                            break;
                                        case 'T':
                                            if ((String.Compare(chars, 9, "VSoundtrack", 0, 11, false) == 0) && (chars.Length == 20))
                                                return TypeGenreKnownValues.Genre_AltGenreTVSoundtrack;
                                            break;
                                        case 'V':
                                            if ((String.Compare(chars, 9, "ideoGame", 0, 8, false) == 0) && (chars.Length == 17))
                                                return TypeGenreKnownValues.Genre_AltGenreVideoGame;
                                            break;
                                        case 'W':
                                            if ((String.Compare(chars, 9, "estCoast", 0, 8, false) == 0) && (chars.Length == 17))
                                                return TypeGenreKnownValues.Genre_AltGenreWestCoast;
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
                    case 'v':
                        if ((String.Compare(chars, 2, "ant Garde", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeGenreKnownValues.Genre_Avant_x20_Garde;
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                if ((String.Compare(chars, 1, "lues", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeGenreKnownValues.Genre_Blues;
                break;
            case 'C':
                switch (chars[1])
                  {
                    case 'h':
                        if ((String.Compare(chars, 2, "ilds", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeGenreKnownValues.Genre_Childs;
                        break;
                    case 'l':
                        if ((String.Compare(chars, 2, "assical", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeGenreKnownValues.Genre_Classical;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "untry", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeGenreKnownValues.Genre_Country;
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "sy", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeGenreKnownValues.Genre_Easy;
                        break;
                    case 'l':
                        if ((String.Compare(chars, 2, "ectronic", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypeGenreKnownValues.Genre_Electronic;
                        break;
                    default:
                        break;
                  }
                break;
            case 'F':
                if ((String.Compare(chars, 1, "olk", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeGenreKnownValues.Genre_Folk;
                break;
            case 'G':
                if ((String.Compare(chars, 1, "ospel", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeGenreKnownValues.Genre_Gospel;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "oliday", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeGenreKnownValues.Genre_Holiday;
                break;
            case 'J':
                if ((String.Compare(chars, 1, "azz", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeGenreKnownValues.Genre_Jazz;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "atin", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeGenreKnownValues.Genre_Latin;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "ovie Soundtrack", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeGenreKnownValues.Genre_Movie_x20_Soundtrack;
                break;
            case 'N':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "w Age", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeGenreKnownValues.Genre_New_x20_Age;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "Genre", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeGenreKnownValues.Genre_NoGenre;
                        break;
                    default:
                        break;
                  }
                break;
            case 'P':
                if ((String.Compare(chars, 1, "op", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeGenreKnownValues.Genre_Pop;
                break;
            case 'R':
                switch (chars[1])
                  {
                    case '&':
                        if ((String.Compare(chars, 2, "B", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeGenreKnownValues.Genre_R_x26_B;
                        break;
                    case 'a':
                        if ((String.Compare(chars, 2, "p", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeGenreKnownValues.Genre_Rap;
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "ggae", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeGenreKnownValues.Genre_Reggae;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "ck", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeGenreKnownValues.Genre_Rock;
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'o':
                        if ((String.Compare(chars, 2, "und Effects", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypeGenreKnownValues.Genre_Sound_x20_Effects;
                        break;
                    case 'p':
                        if ((String.Compare(chars, 2, "oken Word", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeGenreKnownValues.Genre_Spoken_x20_Word;
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if ((String.Compare(chars, 1, "rban", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeGenreKnownValues.Genre_Urban;
                break;
            case 'V':
                if ((String.Compare(chars, 1, "ocal", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeGenreKnownValues.Genre_Vocal;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "orld", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeGenreKnownValues.Genre_World;
                break;
            default:
                break;
          }
        return TypeGenreKnownValues.Genre__none;
      }

    public static string  stringFromGenre(TypeGenreKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeGenreKnownValues.Genre_NoGenre:
                return "NoGenre";
            case TypeGenreKnownValues.Genre_Rock:
                return "Rock";
            case TypeGenreKnownValues.Genre_Pop:
                return "Pop";
            case TypeGenreKnownValues.Genre_Country:
                return "Country";
            case TypeGenreKnownValues.Genre_Electronic:
                return "Electronic";
            case TypeGenreKnownValues.Genre_Urban:
                return "Urban";
            case TypeGenreKnownValues.Genre_Latin:
                return "Latin";
            case TypeGenreKnownValues.Genre_AllGenres:
                return "AllGenres";
            case TypeGenreKnownValues.Genre_Avant_x20_Garde:
                return "Avant Garde";
            case TypeGenreKnownValues.Genre_Blues:
                return "Blues";
            case TypeGenreKnownValues.Genre_Childs:
                return "Childs";
            case TypeGenreKnownValues.Genre_Classical:
                return "Classical";
            case TypeGenreKnownValues.Genre_Easy:
                return "Easy";
            case TypeGenreKnownValues.Genre_Folk:
                return "Folk";
            case TypeGenreKnownValues.Genre_Gospel:
                return "Gospel";
            case TypeGenreKnownValues.Genre_Holiday:
                return "Holiday";
            case TypeGenreKnownValues.Genre_Jazz:
                return "Jazz";
            case TypeGenreKnownValues.Genre_Movie_x20_Soundtrack:
                return "Movie Soundtrack";
            case TypeGenreKnownValues.Genre_New_x20_Age:
                return "New Age";
            case TypeGenreKnownValues.Genre_Rap:
                return "Rap";
            case TypeGenreKnownValues.Genre_R_x26_B:
                return "R&B";
            case TypeGenreKnownValues.Genre_Reggae:
                return "Reggae";
            case TypeGenreKnownValues.Genre_Sound_x20_Effects:
                return "Sound Effects";
            case TypeGenreKnownValues.Genre_Spoken_x20_Word:
                return "Spoken Word";
            case TypeGenreKnownValues.Genre_Vocal:
                return "Vocal";
            case TypeGenreKnownValues.Genre_World:
                return "World";
            case TypeGenreKnownValues.Genre_AltGenre:
                return "AltGenre";
            case TypeGenreKnownValues.Genre_AltGenreFrenchFolk:
                return "AltGenreFrenchFolk";
            case TypeGenreKnownValues.Genre_AltGenreWestCoast:
                return "AltGenreWestCoast";
            case TypeGenreKnownValues.Genre_AltGenreEastCoast:
                return "AltGenreEastCoast";
            case TypeGenreKnownValues.Genre_AltGenreBritishPunk:
                return "AltGenreBritishPunk";
            case TypeGenreKnownValues.Genre_AltGenreVideoGame:
                return "AltGenreVideoGame";
            case TypeGenreKnownValues.Genre_AltGenreTVSoundtrack:
                return "AltGenreTVSoundtrack";
            case TypeGenreKnownValues.Genre_AltGenreBossaNova:
                return "AltGenreBossaNova";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypePlaylistKnownValues
      {
        Playlist_NoPlaylist,
        Playlist_MemorialDay,
        Playlist_JulyFourth,
        Playlist_SummerHotSongs,
        Playlist_SummerUltimate,
        Playlist_SummerLastSummerHits,
        Playlist_Lollapalooza,
        Playlist_Olympics,
        Playlist_OutsideLands,
        Playlist_VMA,
        Playlist_AppleMusicFestival,
        Playlist_AustinCityLimits,
        Playlist_MTVEuropeAwards,
        Playlist_CMA,
        Playlist_LatinoGrammys,
        Playlist_AMA,
        Playlist_YearInReview,
        Playlist_Holidays,
        Playlist_NewYearsEve,
        Playlist_Halloween,
        Playlist_ValentinesDay,
        Playlist_StPatricksDay,
        Playlist_AprilFoolsDay,
        Playlist_MothersDay,
        Playlist_FathersDay,
        Playlist_BackToSchool,
        Playlist_LaborDay,
        Playlist_Thanksgiving,
        Playlist_BlackFriday,
        Playlist_Christmas,
        Playlist_Spring,
        Playlist_Summer,
        Playlist_Winter,
        Playlist_Fall,
        Playlist__none
      };
    public struct TypePlaylist
      {
        public bool in_known_list;
        public string string_value;
        public TypePlaylistKnownValues list_value;
      };

    public static TypePlaylistKnownValues  stringToPlaylist(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'M':
                        if ((String.Compare(chars, 2, "A", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypePlaylistKnownValues.Playlist_AMA;
                        break;
                    case 'p':
                        switch (chars[2])
                          {
                            case 'p':
                                if ((String.Compare(chars, 3, "leMusicFestival", 0, 15, false) == 0) && (chars.Length == 18))
                                    return TypePlaylistKnownValues.Playlist_AppleMusicFestival;
                                break;
                            case 'r':
                                if ((String.Compare(chars, 3, "ilFoolsDay", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypePlaylistKnownValues.Playlist_AprilFoolsDay;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "stinCityLimits", 0, 14, false) == 0) && (chars.Length == 16))
                            return TypePlaylistKnownValues.Playlist_AustinCityLimits;
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "ckToSchool", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypePlaylistKnownValues.Playlist_BackToSchool;
                        break;
                    case 'l':
                        if ((String.Compare(chars, 2, "ackFriday", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypePlaylistKnownValues.Playlist_BlackFriday;
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (chars[1])
                  {
                    case 'M':
                        if ((String.Compare(chars, 2, "A", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypePlaylistKnownValues.Playlist_CMA;
                        break;
                    case 'h':
                        if ((String.Compare(chars, 2, "ristmas", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypePlaylistKnownValues.Playlist_Christmas;
                        break;
                    default:
                        break;
                  }
                break;
            case 'F':
                if (String.Compare(chars, 1, "a", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'l':
                            if ((String.Compare(chars, 3, "l", 0, 1, false) == 0) && (chars.Length == 4))
                                return TypePlaylistKnownValues.Playlist_Fall;
                            break;
                        case 't':
                            if ((String.Compare(chars, 3, "hersDay", 0, 7, false) == 0) && (chars.Length == 10))
                                return TypePlaylistKnownValues.Playlist_FathersDay;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "lloween", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypePlaylistKnownValues.Playlist_Halloween;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "lidays", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypePlaylistKnownValues.Playlist_Holidays;
                        break;
                    default:
                        break;
                  }
                break;
            case 'J':
                if ((String.Compare(chars, 1, "ulyFourth", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypePlaylistKnownValues.Playlist_JulyFourth;
                break;
            case 'L':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'b':
                                if ((String.Compare(chars, 3, "orDay", 0, 5, false) == 0) && (chars.Length == 8))
                                    return TypePlaylistKnownValues.Playlist_LaborDay;
                                break;
                            case 't':
                                if ((String.Compare(chars, 3, "inoGrammys", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypePlaylistKnownValues.Playlist_LatinoGrammys;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "llapalooza", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypePlaylistKnownValues.Playlist_Lollapalooza;
                        break;
                    default:
                        break;
                  }
                break;
            case 'M':
                switch (chars[1])
                  {
                    case 'T':
                        if ((String.Compare(chars, 2, "VEuropeAwards", 0, 13, false) == 0) && (chars.Length == 15))
                            return TypePlaylistKnownValues.Playlist_MTVEuropeAwards;
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "morialDay", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypePlaylistKnownValues.Playlist_MemorialDay;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "thersDay", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypePlaylistKnownValues.Playlist_MothersDay;
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "wYearsEve", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypePlaylistKnownValues.Playlist_NewYearsEve;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "Playlist", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypePlaylistKnownValues.Playlist_NoPlaylist;
                        break;
                    default:
                        break;
                  }
                break;
            case 'O':
                switch (chars[1])
                  {
                    case 'l':
                        if ((String.Compare(chars, 2, "ympics", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypePlaylistKnownValues.Playlist_Olympics;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "tsideLands", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypePlaylistKnownValues.Playlist_OutsideLands;
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'p':
                        if ((String.Compare(chars, 2, "ring", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypePlaylistKnownValues.Playlist_Spring;
                        break;
                    case 't':
                        if ((String.Compare(chars, 2, "PatricksDay", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypePlaylistKnownValues.Playlist_StPatricksDay;
                        break;
                    case 'u':
                        if (String.Compare(chars, 2, "mmer", 0, 4, false) == 0)
                          {
                            if (chars.Length == 6)
                              {
                                return TypePlaylistKnownValues.Playlist_Summer;
                              }
                            switch (chars[6])
                              {
                                case 'H':
                                    if ((String.Compare(chars, 7, "otSongs", 0, 7, false) == 0) && (chars.Length == 14))
                                        return TypePlaylistKnownValues.Playlist_SummerHotSongs;
                                    break;
                                case 'L':
                                    if ((String.Compare(chars, 7, "astSummerHits", 0, 13, false) == 0) && (chars.Length == 20))
                                        return TypePlaylistKnownValues.Playlist_SummerLastSummerHits;
                                    break;
                                case 'U':
                                    if ((String.Compare(chars, 7, "ltimate", 0, 7, false) == 0) && (chars.Length == 14))
                                        return TypePlaylistKnownValues.Playlist_SummerUltimate;
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
                if ((String.Compare(chars, 1, "hanksgiving", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypePlaylistKnownValues.Playlist_Thanksgiving;
                break;
            case 'V':
                switch (chars[1])
                  {
                    case 'M':
                        if ((String.Compare(chars, 2, "A", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypePlaylistKnownValues.Playlist_VMA;
                        break;
                    case 'a':
                        if ((String.Compare(chars, 2, "lentinesDay", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypePlaylistKnownValues.Playlist_ValentinesDay;
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                if ((String.Compare(chars, 1, "inter", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypePlaylistKnownValues.Playlist_Winter;
                break;
            case 'Y':
                if ((String.Compare(chars, 1, "earInReview", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypePlaylistKnownValues.Playlist_YearInReview;
                break;
            default:
                break;
          }
        return TypePlaylistKnownValues.Playlist__none;
      }

    public static string  stringFromPlaylist(TypePlaylistKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypePlaylistKnownValues.Playlist_NoPlaylist:
                return "NoPlaylist";
            case TypePlaylistKnownValues.Playlist_MemorialDay:
                return "MemorialDay";
            case TypePlaylistKnownValues.Playlist_JulyFourth:
                return "JulyFourth";
            case TypePlaylistKnownValues.Playlist_SummerHotSongs:
                return "SummerHotSongs";
            case TypePlaylistKnownValues.Playlist_SummerUltimate:
                return "SummerUltimate";
            case TypePlaylistKnownValues.Playlist_SummerLastSummerHits:
                return "SummerLastSummerHits";
            case TypePlaylistKnownValues.Playlist_Lollapalooza:
                return "Lollapalooza";
            case TypePlaylistKnownValues.Playlist_Olympics:
                return "Olympics";
            case TypePlaylistKnownValues.Playlist_OutsideLands:
                return "OutsideLands";
            case TypePlaylistKnownValues.Playlist_VMA:
                return "VMA";
            case TypePlaylistKnownValues.Playlist_AppleMusicFestival:
                return "AppleMusicFestival";
            case TypePlaylistKnownValues.Playlist_AustinCityLimits:
                return "AustinCityLimits";
            case TypePlaylistKnownValues.Playlist_MTVEuropeAwards:
                return "MTVEuropeAwards";
            case TypePlaylistKnownValues.Playlist_CMA:
                return "CMA";
            case TypePlaylistKnownValues.Playlist_LatinoGrammys:
                return "LatinoGrammys";
            case TypePlaylistKnownValues.Playlist_AMA:
                return "AMA";
            case TypePlaylistKnownValues.Playlist_YearInReview:
                return "YearInReview";
            case TypePlaylistKnownValues.Playlist_Holidays:
                return "Holidays";
            case TypePlaylistKnownValues.Playlist_NewYearsEve:
                return "NewYearsEve";
            case TypePlaylistKnownValues.Playlist_Halloween:
                return "Halloween";
            case TypePlaylistKnownValues.Playlist_ValentinesDay:
                return "ValentinesDay";
            case TypePlaylistKnownValues.Playlist_StPatricksDay:
                return "StPatricksDay";
            case TypePlaylistKnownValues.Playlist_AprilFoolsDay:
                return "AprilFoolsDay";
            case TypePlaylistKnownValues.Playlist_MothersDay:
                return "MothersDay";
            case TypePlaylistKnownValues.Playlist_FathersDay:
                return "FathersDay";
            case TypePlaylistKnownValues.Playlist_BackToSchool:
                return "BackToSchool";
            case TypePlaylistKnownValues.Playlist_LaborDay:
                return "LaborDay";
            case TypePlaylistKnownValues.Playlist_Thanksgiving:
                return "Thanksgiving";
            case TypePlaylistKnownValues.Playlist_BlackFriday:
                return "BlackFriday";
            case TypePlaylistKnownValues.Playlist_Christmas:
                return "Christmas";
            case TypePlaylistKnownValues.Playlist_Spring:
                return "Spring";
            case TypePlaylistKnownValues.Playlist_Summer:
                return "Summer";
            case TypePlaylistKnownValues.Playlist_Winter:
                return "Winter";
            case TypePlaylistKnownValues.Playlist_Fall:
                return "Fall";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeGeoScopeKnownValues
      {
        GeoScope_Country,
        GeoScope_Continent,
        GeoScope_World,
        GeoScope_None,
        GeoScope__none
      };
    public struct TypeGeoScope
      {
        public bool in_known_list;
        public string string_value;
        public TypeGeoScopeKnownValues list_value;
      };

    public static TypeGeoScopeKnownValues  stringToGeoScope(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if (String.Compare(chars, 1, "o", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'n':
                            if ((String.Compare(chars, 3, "tinent", 0, 6, false) == 0) && (chars.Length == 9))
                                return TypeGeoScopeKnownValues.GeoScope_Continent;
                            break;
                        case 'u':
                            if ((String.Compare(chars, 3, "ntry", 0, 4, false) == 0) && (chars.Length == 7))
                                return TypeGeoScopeKnownValues.GeoScope_Country;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeGeoScopeKnownValues.GeoScope_None;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "orld", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeGeoScopeKnownValues.GeoScope_World;
                break;
            default:
                break;
          }
        return TypeGeoScopeKnownValues.GeoScope__none;
      }

    public static string  stringFromGeoScope(TypeGeoScopeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeGeoScopeKnownValues.GeoScope_Country:
                return "Country";
            case TypeGeoScopeKnownValues.GeoScope_Continent:
                return "Continent";
            case TypeGeoScopeKnownValues.GeoScope_World:
                return "World";
            case TypeGeoScopeKnownValues.GeoScope_None:
                return "None";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCurrentDateAndTime;
    private DateAndOrTimeJSON  storeCurrentDateAndTime;
    private bool flagHasEntity;
    private TypeEntity storeEntity;
    private bool flagHasModifier;
    private TypeModifier storeModifier;
    private bool flagHasTimePeriod;
    private DateTimeRangeSpecJSON  storeTimePeriod;
    private bool flagHasTimePeriodType;
    private TypeTimePeriodType storeTimePeriodType;
    private bool flagHasGenre;
    private TypeGenre storeGenre;
    private bool flagHasRequestedGenre;
    private MusicGenreJSON  storeRequestedGenre;
    private bool flagHasGenreMatch;
    private bool storeGenreMatch;
    private bool flagHasPlaylist;
    private TypePlaylist storePlaylist;
    private bool flagHasBirthday;
    private DateTimeRangeSpecJSON  storeBirthday;
    private bool flagHasLocation;
    private MapLocationJSON  storeLocation;
    private bool flagHasCountryCode;
    private string storeCountryCode;
    private bool flagHasCountryName;
    private string storeCountryName;
    private bool flagHasGeoScope;
    private TypeGeoScope storeGeoScope;
    private bool flagHasPlay;
    private bool storePlay;
    private bool flagHasShuffle;
    private bool storeShuffle;
    private bool flagHasHowMany;
    private bool storeHowMany;
    private bool flagHasRequestedNumberOfResults;
    private BigInteger storeRequestedNumberOfResults;
    private bool flagHasTrackResultSHIDs;
    private List< Double > storeTrackResultSHIDs;
    private bool flagHasAlbumResultSHIDs;
    private List< Double > storeAlbumResultSHIDs;
    private bool flagHasArtistResultSHIDs;
    private List< Double > storeArtistResultSHIDs;
    private bool flagHasVideoResultIDs;
    private List< string > storeVideoResultIDs;


    private void  fromJSONCurrentDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setCurrentDateAndTime(convert_classy);
      }


    private void  fromJSONEntity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Entity of MusicChartsSearchCriteriaJSON is not a string.");
        TypeEntity the_open_enum = new TypeEntity();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "bums", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeEntityKnownValues.Entity_Albums;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if (String.Compare(json_string.getData(), 2, "tists", 0, 5, false) == 0)
                          {
                            if (json_string.getData().Length == 7)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeEntityKnownValues.Entity_Artists;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[7])
                              {
                                case 'B':
                                    if ((String.Compare(json_string.getData(), 8, "ornOn", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeEntityKnownValues.Entity_ArtistsBornOn;
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
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "laylist", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeEntityKnownValues.Entity_Playlist;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "racks", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeEntityKnownValues.Entity_Tracks;
                        goto open_enum_is_done;
                      }
                break;
            case 'V':
                if ((String.Compare(json_string.getData(), 1, "ideos", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeEntityKnownValues.Entity_Videos;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setEntity(the_open_enum);
      }


    private void  fromJSONModifier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Modifier of MusicChartsSearchCriteriaJSON is not a string.");
        TypeModifier the_open_enum = new TypeModifier();
        switch (json_string.getData()[0])
          {
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "ew", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeModifierKnownValues.Modifier_New;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "op", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeModifierKnownValues.Modifier_Top;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setModifier(the_open_enum);
      }


    private void  fromJSONTimePeriod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setTimePeriod(convert_classy);
      }


    private void  fromJSONTimePeriodType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TimePeriodType of MusicChartsSearchCriteriaJSON is not a string.");
        TypeTimePeriodType the_open_enum = new TypeTimePeriodType();
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "entury", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTimePeriodTypeKnownValues.TimePeriodType_Century;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "y", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTimePeriodTypeKnownValues.TimePeriodType_Day;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "cade", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTimePeriodTypeKnownValues.TimePeriodType_Decade;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "onth", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTimePeriodTypeKnownValues.TimePeriodType_Month;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTimePeriodTypeKnownValues.TimePeriodType_None;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "eek", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTimePeriodTypeKnownValues.TimePeriodType_Week;
                        goto open_enum_is_done;
                      }
                break;
            case 'Y':
                if ((String.Compare(json_string.getData(), 1, "ear", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTimePeriodTypeKnownValues.TimePeriodType_Year;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setTimePeriodType(the_open_enum);
      }


    private void  fromJSONGenre(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Genre of MusicChartsSearchCriteriaJSON is not a string.");
        TypeGenre the_open_enum = new TypeGenre();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        switch (json_string.getData()[2])
                          {
                            case 'l':
                                if ((String.Compare(json_string.getData(), 3, "Genres", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeGenreKnownValues.Genre_AllGenres;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 't':
                                if (String.Compare(json_string.getData(), 3, "Genre", 0, 5, false) == 0)
                                  {
                                    if (json_string.getData().Length == 8)
                                      {
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeGenreKnownValues.Genre_AltGenre;
                                            goto open_enum_is_done;
                                          }
                                      }
                                    switch (json_string.getData()[8])
                                      {
                                        case 'B':
                                            switch (json_string.getData()[9])
                                              {
                                                case 'o':
                                                    if ((String.Compare(json_string.getData(), 10, "ssaNova", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeGenreKnownValues.Genre_AltGenreBossaNova;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'r':
                                                    if ((String.Compare(json_string.getData(), 10, "itishPunk", 0, 9, false) == 0) && (json_string.getData().Length == 19))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeGenreKnownValues.Genre_AltGenreBritishPunk;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'E':
                                            if ((String.Compare(json_string.getData(), 9, "astCoast", 0, 8, false) == 0) && (json_string.getData().Length == 17))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeGenreKnownValues.Genre_AltGenreEastCoast;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 9, "renchFolk", 0, 9, false) == 0) && (json_string.getData().Length == 18))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeGenreKnownValues.Genre_AltGenreFrenchFolk;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'T':
                                            if ((String.Compare(json_string.getData(), 9, "VSoundtrack", 0, 11, false) == 0) && (json_string.getData().Length == 20))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeGenreKnownValues.Genre_AltGenreTVSoundtrack;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'V':
                                            if ((String.Compare(json_string.getData(), 9, "ideoGame", 0, 8, false) == 0) && (json_string.getData().Length == 17))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeGenreKnownValues.Genre_AltGenreVideoGame;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'W':
                                            if ((String.Compare(json_string.getData(), 9, "estCoast", 0, 8, false) == 0) && (json_string.getData().Length == 17))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeGenreKnownValues.Genre_AltGenreWestCoast;
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
                    case 'v':
                        if ((String.Compare(json_string.getData(), 2, "ant Garde", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGenreKnownValues.Genre_Avant_x20_Garde;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "lues", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGenreKnownValues.Genre_Blues;
                        goto open_enum_is_done;
                      }
                break;
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'h':
                        if ((String.Compare(json_string.getData(), 2, "ilds", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGenreKnownValues.Genre_Childs;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "assical", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGenreKnownValues.Genre_Classical;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "untry", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGenreKnownValues.Genre_Country;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "sy", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGenreKnownValues.Genre_Easy;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "ectronic", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGenreKnownValues.Genre_Electronic;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "olk", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGenreKnownValues.Genre_Folk;
                        goto open_enum_is_done;
                      }
                break;
            case 'G':
                if ((String.Compare(json_string.getData(), 1, "ospel", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGenreKnownValues.Genre_Gospel;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "oliday", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGenreKnownValues.Genre_Holiday;
                        goto open_enum_is_done;
                      }
                break;
            case 'J':
                if ((String.Compare(json_string.getData(), 1, "azz", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGenreKnownValues.Genre_Jazz;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "atin", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGenreKnownValues.Genre_Latin;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "ovie Soundtrack", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGenreKnownValues.Genre_Movie_x20_Soundtrack;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "w Age", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGenreKnownValues.Genre_New_x20_Age;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "Genre", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGenreKnownValues.Genre_NoGenre;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "op", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGenreKnownValues.Genre_Pop;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                switch (json_string.getData()[1])
                  {
                    case '&':
                        if ((String.Compare(json_string.getData(), 2, "B", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGenreKnownValues.Genre_R_x26_B;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "p", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGenreKnownValues.Genre_Rap;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "ggae", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGenreKnownValues.Genre_Reggae;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "ck", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGenreKnownValues.Genre_Rock;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "und Effects", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGenreKnownValues.Genre_Sound_x20_Effects;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'p':
                        if ((String.Compare(json_string.getData(), 2, "oken Word", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGenreKnownValues.Genre_Spoken_x20_Word;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "rban", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGenreKnownValues.Genre_Urban;
                        goto open_enum_is_done;
                      }
                break;
            case 'V':
                if ((String.Compare(json_string.getData(), 1, "ocal", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGenreKnownValues.Genre_Vocal;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "orld", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGenreKnownValues.Genre_World;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setGenre(the_open_enum);
      }


    private void  fromJSONRequestedGenre(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicGenreJSON convert_classy = MusicGenreJSON.from_json(json_value, ignore_extras, true);
        setRequestedGenre(convert_classy);
      }


    private void  fromJSONGenreMatch(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field GenreMatch of MusicChartsSearchCriteriaJSON is not true for false.");
              }
          }
        setGenreMatch(the_bool);
      }


    private void  fromJSONPlaylist(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Playlist of MusicChartsSearchCriteriaJSON is not a string.");
        TypePlaylist the_open_enum = new TypePlaylist();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'M':
                        if ((String.Compare(json_string.getData(), 2, "A", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_AMA;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'p':
                        switch (json_string.getData()[2])
                          {
                            case 'p':
                                if ((String.Compare(json_string.getData(), 3, "leMusicFestival", 0, 15, false) == 0) && (json_string.getData().Length == 18))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypePlaylistKnownValues.Playlist_AppleMusicFestival;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "ilFoolsDay", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypePlaylistKnownValues.Playlist_AprilFoolsDay;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "stinCityLimits", 0, 14, false) == 0) && (json_string.getData().Length == 16))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_AustinCityLimits;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "ckToSchool", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_BackToSchool;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "ackFriday", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_BlackFriday;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'M':
                        if ((String.Compare(json_string.getData(), 2, "A", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_CMA;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'h':
                        if ((String.Compare(json_string.getData(), 2, "ristmas", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_Christmas;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'F':
                if (String.Compare(json_string.getData(), 1, "a", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'l':
                            if ((String.Compare(json_string.getData(), 3, "l", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypePlaylistKnownValues.Playlist_Fall;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 't':
                            if ((String.Compare(json_string.getData(), 3, "hersDay", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypePlaylistKnownValues.Playlist_FathersDay;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "lloween", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_Halloween;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "lidays", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_Holidays;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'J':
                if ((String.Compare(json_string.getData(), 1, "ulyFourth", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePlaylistKnownValues.Playlist_JulyFourth;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'b':
                                if ((String.Compare(json_string.getData(), 3, "orDay", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypePlaylistKnownValues.Playlist_LaborDay;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 't':
                                if ((String.Compare(json_string.getData(), 3, "inoGrammys", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypePlaylistKnownValues.Playlist_LatinoGrammys;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "llapalooza", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_Lollapalooza;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'M':
                switch (json_string.getData()[1])
                  {
                    case 'T':
                        if ((String.Compare(json_string.getData(), 2, "VEuropeAwards", 0, 13, false) == 0) && (json_string.getData().Length == 15))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_MTVEuropeAwards;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "morialDay", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_MemorialDay;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "thersDay", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_MothersDay;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "wYearsEve", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_NewYearsEve;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "Playlist", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_NoPlaylist;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'O':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "ympics", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_Olympics;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "tsideLands", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_OutsideLands;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'p':
                        if ((String.Compare(json_string.getData(), 2, "ring", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_Spring;
                                goto open_enum_is_done;
                              }
                        break;
                    case 't':
                        if ((String.Compare(json_string.getData(), 2, "PatricksDay", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_StPatricksDay;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if (String.Compare(json_string.getData(), 2, "mmer", 0, 4, false) == 0)
                          {
                            if (json_string.getData().Length == 6)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypePlaylistKnownValues.Playlist_Summer;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[6])
                              {
                                case 'H':
                                    if ((String.Compare(json_string.getData(), 7, "otSongs", 0, 7, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypePlaylistKnownValues.Playlist_SummerHotSongs;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'L':
                                    if ((String.Compare(json_string.getData(), 7, "astSummerHits", 0, 13, false) == 0) && (json_string.getData().Length == 20))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypePlaylistKnownValues.Playlist_SummerLastSummerHits;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'U':
                                    if ((String.Compare(json_string.getData(), 7, "ltimate", 0, 7, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypePlaylistKnownValues.Playlist_SummerUltimate;
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
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "hanksgiving", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePlaylistKnownValues.Playlist_Thanksgiving;
                        goto open_enum_is_done;
                      }
                break;
            case 'V':
                switch (json_string.getData()[1])
                  {
                    case 'M':
                        if ((String.Compare(json_string.getData(), 2, "A", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_VMA;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "lentinesDay", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypePlaylistKnownValues.Playlist_ValentinesDay;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "inter", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePlaylistKnownValues.Playlist_Winter;
                        goto open_enum_is_done;
                      }
                break;
            case 'Y':
                if ((String.Compare(json_string.getData(), 1, "earInReview", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePlaylistKnownValues.Playlist_YearInReview;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setPlaylist(the_open_enum);
      }


    private void  fromJSONBirthday(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setBirthday(convert_classy);
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setLocation(convert_classy);
      }


    private void  fromJSONCountryCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CountryCode of MusicChartsSearchCriteriaJSON is not a string.");
        setCountryCode(json_string.getData());
      }


    private void  fromJSONCountryName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CountryName of MusicChartsSearchCriteriaJSON is not a string.");
        setCountryName(json_string.getData());
      }


    private void  fromJSONGeoScope(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field GeoScope of MusicChartsSearchCriteriaJSON is not a string.");
        TypeGeoScope the_open_enum = new TypeGeoScope();
        switch (json_string.getData()[0])
          {
            case 'C':
                if (String.Compare(json_string.getData(), 1, "o", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'n':
                            if ((String.Compare(json_string.getData(), 3, "tinent", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeGeoScopeKnownValues.GeoScope_Continent;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'u':
                            if ((String.Compare(json_string.getData(), 3, "ntry", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeGeoScopeKnownValues.GeoScope_Country;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGeoScopeKnownValues.GeoScope_None;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "orld", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGeoScopeKnownValues.GeoScope_World;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setGeoScope(the_open_enum);
      }


    private void  fromJSONPlay(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Play of MusicChartsSearchCriteriaJSON is not true for false.");
              }
          }
        setPlay(the_bool);
      }


    private void  fromJSONShuffle(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Shuffle of MusicChartsSearchCriteriaJSON is not true for false.");
              }
          }
        setShuffle(the_bool);
      }


    private void  fromJSONHowMany(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HowMany of MusicChartsSearchCriteriaJSON is not true for false.");
              }
          }
        setHowMany(the_bool);
      }


    private void  fromJSONRequestedNumberOfResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field RequestedNumberOfResults of MusicChartsSearchCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RequestedNumberOfResults of MusicChartsSearchCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRequestedNumberOfResults(extracted_integer);
      }


    private void  fromJSONTrackResultSHIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field TrackResultSHIDs of MusicChartsSearchCriteriaJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Double > vector_TrackResultSHIDs1 = new List< Double >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONRationalValue json_rational = json_array1.component(num1).rational_value();
            double the_double;
            if (json_rational != null)
              {
                the_double = json_rational.getDouble();
              }
            else
              {
                JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
                if (json_integer != null)
                  {
                    the_double = json_integer.getLongInt();
                  }
                else
                  {
                    throw new Exception("The value for an element of field TrackResultSHIDs of MusicChartsSearchCriteriaJSON is not a number.");
                  }
              }
            vector_TrackResultSHIDs1.Add(the_double);
          }
        initTrackResultSHIDs();
        for (int num1 = 0; num1 < vector_TrackResultSHIDs1.Count; ++num1)
            appendTrackResultSHIDs(vector_TrackResultSHIDs1[num1]);
        for (int num1 = 0; num1 < vector_TrackResultSHIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAlbumResultSHIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AlbumResultSHIDs of MusicChartsSearchCriteriaJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Double > vector_AlbumResultSHIDs1 = new List< Double >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONRationalValue json_rational = json_array1.component(num1).rational_value();
            double the_double;
            if (json_rational != null)
              {
                the_double = json_rational.getDouble();
              }
            else
              {
                JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
                if (json_integer != null)
                  {
                    the_double = json_integer.getLongInt();
                  }
                else
                  {
                    throw new Exception("The value for an element of field AlbumResultSHIDs of MusicChartsSearchCriteriaJSON is not a number.");
                  }
              }
            vector_AlbumResultSHIDs1.Add(the_double);
          }
        initAlbumResultSHIDs();
        for (int num2 = 0; num2 < vector_AlbumResultSHIDs1.Count; ++num2)
            appendAlbumResultSHIDs(vector_AlbumResultSHIDs1[num2]);
        for (int num1 = 0; num1 < vector_AlbumResultSHIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONArtistResultSHIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ArtistResultSHIDs of MusicChartsSearchCriteriaJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Double > vector_ArtistResultSHIDs1 = new List< Double >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONRationalValue json_rational = json_array1.component(num1).rational_value();
            double the_double;
            if (json_rational != null)
              {
                the_double = json_rational.getDouble();
              }
            else
              {
                JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
                if (json_integer != null)
                  {
                    the_double = json_integer.getLongInt();
                  }
                else
                  {
                    throw new Exception("The value for an element of field ArtistResultSHIDs of MusicChartsSearchCriteriaJSON is not a number.");
                  }
              }
            vector_ArtistResultSHIDs1.Add(the_double);
          }
        initArtistResultSHIDs();
        for (int num3 = 0; num3 < vector_ArtistResultSHIDs1.Count; ++num3)
            appendArtistResultSHIDs(vector_ArtistResultSHIDs1[num3]);
        for (int num1 = 0; num1 < vector_ArtistResultSHIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONVideoResultIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field VideoResultIDs of MusicChartsSearchCriteriaJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_VideoResultIDs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field VideoResultIDs of MusicChartsSearchCriteriaJSON is not a string.");
            vector_VideoResultIDs1.Add(json_string.getData());
          }
        initVideoResultIDs();
        for (int num4 = 0; num4 < vector_VideoResultIDs1.Count; ++num4)
            appendVideoResultIDs(vector_VideoResultIDs1[num4]);
        for (int num1 = 0; num1 < vector_VideoResultIDs1.Count; ++num1)
          {
          }
      }


    public MusicChartsSearchCriteriaJSON()
      {
        flagHasCurrentDateAndTime = false;
        flagHasEntity = false;
        flagHasModifier = false;
        flagHasTimePeriod = false;
        flagHasTimePeriodType = false;
        flagHasGenre = false;
        flagHasRequestedGenre = false;
        flagHasGenreMatch = false;
        flagHasPlaylist = false;
        flagHasBirthday = false;
        flagHasLocation = false;
        flagHasCountryCode = false;
        flagHasCountryName = false;
        flagHasGeoScope = false;
        flagHasPlay = false;
        flagHasShuffle = false;
        flagHasHowMany = false;
        flagHasRequestedNumberOfResults = false;
        flagHasTrackResultSHIDs = false;
        flagHasAlbumResultSHIDs = false;
        flagHasArtistResultSHIDs = false;
        flagHasVideoResultIDs = false;
        storeTrackResultSHIDs = new List< Double >();
        storeAlbumResultSHIDs = new List< Double >();
        storeArtistResultSHIDs = new List< Double >();
        storeVideoResultIDs = new List< string >();
      }

    public bool  hasCurrentDateAndTime()
      {
        return flagHasCurrentDateAndTime;
      }

    public DateAndOrTimeJSON   getCurrentDateAndTime()
      {
        Debug.Assert(flagHasCurrentDateAndTime);
        return storeCurrentDateAndTime;
      }

    public bool  hasEntity()
      {
        return flagHasEntity;
      }

    public TypeEntity  getEntity()
      {
        Debug.Assert(flagHasEntity);
        return storeEntity;
      }

    public string  getEntityAsString()
      {
        TypeEntity result = getEntity();
        if (result.in_known_list)
            return stringFromEntity(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasModifier()
      {
        return flagHasModifier;
      }

    public TypeModifier  getModifier()
      {
        Debug.Assert(flagHasModifier);
        return storeModifier;
      }

    public string  getModifierAsString()
      {
        TypeModifier result = getModifier();
        if (result.in_known_list)
            return stringFromModifier(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasTimePeriod()
      {
        return flagHasTimePeriod;
      }

    public DateTimeRangeSpecJSON   getTimePeriod()
      {
        Debug.Assert(flagHasTimePeriod);
        return storeTimePeriod;
      }

    public bool  hasTimePeriodType()
      {
        return flagHasTimePeriodType;
      }

    public TypeTimePeriodType  getTimePeriodType()
      {
        Debug.Assert(flagHasTimePeriodType);
        return storeTimePeriodType;
      }

    public string  getTimePeriodTypeAsString()
      {
        TypeTimePeriodType result = getTimePeriodType();
        if (result.in_known_list)
            return stringFromTimePeriodType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasGenre()
      {
        return flagHasGenre;
      }

    public TypeGenre  getGenre()
      {
        Debug.Assert(flagHasGenre);
        return storeGenre;
      }

    public string  getGenreAsString()
      {
        TypeGenre result = getGenre();
        if (result.in_known_list)
            return stringFromGenre(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasRequestedGenre()
      {
        return flagHasRequestedGenre;
      }

    public MusicGenreJSON   getRequestedGenre()
      {
        Debug.Assert(flagHasRequestedGenre);
        return storeRequestedGenre;
      }

    public bool  hasGenreMatch()
      {
        return flagHasGenreMatch;
      }

    public bool  getGenreMatch()
      {
        Debug.Assert(flagHasGenreMatch);
        return storeGenreMatch;
      }

    public bool  hasPlaylist()
      {
        return flagHasPlaylist;
      }

    public TypePlaylist  getPlaylist()
      {
        Debug.Assert(flagHasPlaylist);
        return storePlaylist;
      }

    public string  getPlaylistAsString()
      {
        TypePlaylist result = getPlaylist();
        if (result.in_known_list)
            return stringFromPlaylist(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasBirthday()
      {
        return flagHasBirthday;
      }

    public DateTimeRangeSpecJSON   getBirthday()
      {
        Debug.Assert(flagHasBirthday);
        return storeBirthday;
      }

    public bool  hasLocation()
      {
        return flagHasLocation;
      }

    public MapLocationJSON   getLocation()
      {
        Debug.Assert(flagHasLocation);
        return storeLocation;
      }

    public bool  hasCountryCode()
      {
        return flagHasCountryCode;
      }

    public string  getCountryCode()
      {
        Debug.Assert(flagHasCountryCode);
        return storeCountryCode;
      }

    public bool  hasCountryName()
      {
        return flagHasCountryName;
      }

    public string  getCountryName()
      {
        Debug.Assert(flagHasCountryName);
        return storeCountryName;
      }

    public bool  hasGeoScope()
      {
        return flagHasGeoScope;
      }

    public TypeGeoScope  getGeoScope()
      {
        Debug.Assert(flagHasGeoScope);
        return storeGeoScope;
      }

    public string  getGeoScopeAsString()
      {
        TypeGeoScope result = getGeoScope();
        if (result.in_known_list)
            return stringFromGeoScope(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasPlay()
      {
        return flagHasPlay;
      }

    public bool  getPlay()
      {
        Debug.Assert(flagHasPlay);
        return storePlay;
      }

    public bool  hasShuffle()
      {
        return flagHasShuffle;
      }

    public bool  getShuffle()
      {
        Debug.Assert(flagHasShuffle);
        return storeShuffle;
      }

    public bool  hasHowMany()
      {
        return flagHasHowMany;
      }

    public bool  getHowMany()
      {
        Debug.Assert(flagHasHowMany);
        return storeHowMany;
      }

    public bool  hasRequestedNumberOfResults()
      {
        return flagHasRequestedNumberOfResults;
      }

    public BigInteger  getRequestedNumberOfResults()
      {
        Debug.Assert(flagHasRequestedNumberOfResults);
        return storeRequestedNumberOfResults;
      }

    public bool  hasTrackResultSHIDs()
      {
        return flagHasTrackResultSHIDs;
      }

    public int  countOfTrackResultSHIDs()
      {
        Debug.Assert(flagHasTrackResultSHIDs);
        return storeTrackResultSHIDs.Count;
      }

    public double  elementOfTrackResultSHIDs(int element_num)
      {
        Debug.Assert(flagHasTrackResultSHIDs);
        return storeTrackResultSHIDs[element_num];
      }

    public List< Double >  getTrackResultSHIDs()
      {
        Debug.Assert(flagHasTrackResultSHIDs);
        return storeTrackResultSHIDs;
      }

    public bool  hasAlbumResultSHIDs()
      {
        return flagHasAlbumResultSHIDs;
      }

    public int  countOfAlbumResultSHIDs()
      {
        Debug.Assert(flagHasAlbumResultSHIDs);
        return storeAlbumResultSHIDs.Count;
      }

    public double  elementOfAlbumResultSHIDs(int element_num)
      {
        Debug.Assert(flagHasAlbumResultSHIDs);
        return storeAlbumResultSHIDs[element_num];
      }

    public List< Double >  getAlbumResultSHIDs()
      {
        Debug.Assert(flagHasAlbumResultSHIDs);
        return storeAlbumResultSHIDs;
      }

    public bool  hasArtistResultSHIDs()
      {
        return flagHasArtistResultSHIDs;
      }

    public int  countOfArtistResultSHIDs()
      {
        Debug.Assert(flagHasArtistResultSHIDs);
        return storeArtistResultSHIDs.Count;
      }

    public double  elementOfArtistResultSHIDs(int element_num)
      {
        Debug.Assert(flagHasArtistResultSHIDs);
        return storeArtistResultSHIDs[element_num];
      }

    public List< Double >  getArtistResultSHIDs()
      {
        Debug.Assert(flagHasArtistResultSHIDs);
        return storeArtistResultSHIDs;
      }

    public bool  hasVideoResultIDs()
      {
        return flagHasVideoResultIDs;
      }

    public int  countOfVideoResultIDs()
      {
        Debug.Assert(flagHasVideoResultIDs);
        return storeVideoResultIDs.Count;
      }

    public string  elementOfVideoResultIDs(int element_num)
      {
        Debug.Assert(flagHasVideoResultIDs);
        return storeVideoResultIDs[element_num];
      }

    public List< string >  getVideoResultIDs()
      {
        Debug.Assert(flagHasVideoResultIDs);
        return storeVideoResultIDs;
      }



    public void setCurrentDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasCurrentDateAndTime)
          {
          }
        flagHasCurrentDateAndTime = true;
        storeCurrentDateAndTime = new_value;
      }
    public void unsetCurrentDateAndTime()
      {
        if (flagHasCurrentDateAndTime)
          {
          }
        flagHasCurrentDateAndTime = false;
      }
    public void setEntity(TypeEntity new_value)
      {
        flagHasEntity = true;
        storeEntity = new_value;
      }
    public void setEntity(string chars)
      {
        TypeEntityKnownValues known = stringToEntity(chars);
        TypeEntity new_value = new TypeEntity();
        if (known == TypeEntityKnownValues.Entity__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setEntity(new_value);
      }
    public void setEntity(TypeEntityKnownValues new_value)
      {
        TypeEntity new_full_value = new TypeEntity();
        Debug.Assert(new_value != TypeEntityKnownValues.Entity__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setEntity(new_full_value);
      }
    public void unsetEntity()
      {
        flagHasEntity = false;
      }
    public void setModifier(TypeModifier new_value)
      {
        flagHasModifier = true;
        storeModifier = new_value;
      }
    public void setModifier(string chars)
      {
        TypeModifierKnownValues known = stringToModifier(chars);
        TypeModifier new_value = new TypeModifier();
        if (known == TypeModifierKnownValues.Modifier__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setModifier(new_value);
      }
    public void setModifier(TypeModifierKnownValues new_value)
      {
        TypeModifier new_full_value = new TypeModifier();
        Debug.Assert(new_value != TypeModifierKnownValues.Modifier__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setModifier(new_full_value);
      }
    public void unsetModifier()
      {
        flagHasModifier = false;
      }
    public void setTimePeriod(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasTimePeriod)
          {
          }
        flagHasTimePeriod = true;
        storeTimePeriod = new_value;
      }
    public void unsetTimePeriod()
      {
        if (flagHasTimePeriod)
          {
          }
        flagHasTimePeriod = false;
      }
    public void setTimePeriodType(TypeTimePeriodType new_value)
      {
        flagHasTimePeriodType = true;
        storeTimePeriodType = new_value;
      }
    public void setTimePeriodType(string chars)
      {
        TypeTimePeriodTypeKnownValues known = stringToTimePeriodType(chars);
        TypeTimePeriodType new_value = new TypeTimePeriodType();
        if (known == TypeTimePeriodTypeKnownValues.TimePeriodType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setTimePeriodType(new_value);
      }
    public void setTimePeriodType(TypeTimePeriodTypeKnownValues new_value)
      {
        TypeTimePeriodType new_full_value = new TypeTimePeriodType();
        Debug.Assert(new_value != TypeTimePeriodTypeKnownValues.TimePeriodType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setTimePeriodType(new_full_value);
      }
    public void unsetTimePeriodType()
      {
        flagHasTimePeriodType = false;
      }
    public void setGenre(TypeGenre new_value)
      {
        flagHasGenre = true;
        storeGenre = new_value;
      }
    public void setGenre(string chars)
      {
        TypeGenreKnownValues known = stringToGenre(chars);
        TypeGenre new_value = new TypeGenre();
        if (known == TypeGenreKnownValues.Genre__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setGenre(new_value);
      }
    public void setGenre(TypeGenreKnownValues new_value)
      {
        TypeGenre new_full_value = new TypeGenre();
        Debug.Assert(new_value != TypeGenreKnownValues.Genre__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setGenre(new_full_value);
      }
    public void unsetGenre()
      {
        flagHasGenre = false;
      }
    public void setRequestedGenre(MusicGenreJSON  new_value)
      {
        if (flagHasRequestedGenre)
          {
          }
        flagHasRequestedGenre = true;
        storeRequestedGenre = new_value;
      }
    public void unsetRequestedGenre()
      {
        if (flagHasRequestedGenre)
          {
          }
        flagHasRequestedGenre = false;
      }
    public void setGenreMatch(bool new_value)
      {
        flagHasGenreMatch = true;
        storeGenreMatch = new_value;
      }
    public void unsetGenreMatch()
      {
        flagHasGenreMatch = false;
      }
    public void setPlaylist(TypePlaylist new_value)
      {
        flagHasPlaylist = true;
        storePlaylist = new_value;
      }
    public void setPlaylist(string chars)
      {
        TypePlaylistKnownValues known = stringToPlaylist(chars);
        TypePlaylist new_value = new TypePlaylist();
        if (known == TypePlaylistKnownValues.Playlist__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPlaylist(new_value);
      }
    public void setPlaylist(TypePlaylistKnownValues new_value)
      {
        TypePlaylist new_full_value = new TypePlaylist();
        Debug.Assert(new_value != TypePlaylistKnownValues.Playlist__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setPlaylist(new_full_value);
      }
    public void unsetPlaylist()
      {
        flagHasPlaylist = false;
      }
    public void setBirthday(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasBirthday)
          {
          }
        flagHasBirthday = true;
        storeBirthday = new_value;
      }
    public void unsetBirthday()
      {
        if (flagHasBirthday)
          {
          }
        flagHasBirthday = false;
      }
    public void setLocation(MapLocationJSON  new_value)
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = true;
        storeLocation = new_value;
      }
    public void unsetLocation()
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = false;
      }
    public void setCountryCode(string new_value)
      {
        flagHasCountryCode = true;
        storeCountryCode = new_value;
      }
    public void unsetCountryCode()
      {
        flagHasCountryCode = false;
      }
    public void setCountryName(string new_value)
      {
        flagHasCountryName = true;
        storeCountryName = new_value;
      }
    public void unsetCountryName()
      {
        flagHasCountryName = false;
      }
    public void setGeoScope(TypeGeoScope new_value)
      {
        flagHasGeoScope = true;
        storeGeoScope = new_value;
      }
    public void setGeoScope(string chars)
      {
        TypeGeoScopeKnownValues known = stringToGeoScope(chars);
        TypeGeoScope new_value = new TypeGeoScope();
        if (known == TypeGeoScopeKnownValues.GeoScope__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setGeoScope(new_value);
      }
    public void setGeoScope(TypeGeoScopeKnownValues new_value)
      {
        TypeGeoScope new_full_value = new TypeGeoScope();
        Debug.Assert(new_value != TypeGeoScopeKnownValues.GeoScope__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setGeoScope(new_full_value);
      }
    public void unsetGeoScope()
      {
        flagHasGeoScope = false;
      }
    public void setPlay(bool new_value)
      {
        flagHasPlay = true;
        storePlay = new_value;
      }
    public void unsetPlay()
      {
        flagHasPlay = false;
      }
    public void setShuffle(bool new_value)
      {
        flagHasShuffle = true;
        storeShuffle = new_value;
      }
    public void unsetShuffle()
      {
        flagHasShuffle = false;
      }
    public void setHowMany(bool new_value)
      {
        flagHasHowMany = true;
        storeHowMany = new_value;
      }
    public void unsetHowMany()
      {
        flagHasHowMany = false;
      }
    public void setRequestedNumberOfResults(BigInteger new_value)
      {
        flagHasRequestedNumberOfResults = true;
        if (new_value < 0)
            throw new Exception("The value for field RequestedNumberOfResults of MusicChartsSearchCriteriaJSON is less than the lower bound (0) for that field.");
        storeRequestedNumberOfResults = new_value;
      }
    public void unsetRequestedNumberOfResults()
      {
        flagHasRequestedNumberOfResults = false;
      }
    public void initTrackResultSHIDs()
      {
        flagHasTrackResultSHIDs = true;
        storeTrackResultSHIDs.Clear();
      }
    public void appendTrackResultSHIDs(double to_append)
      {
        if (!flagHasTrackResultSHIDs)
          {
            flagHasTrackResultSHIDs = true;
            storeTrackResultSHIDs.Clear();
          }
        Debug.Assert(flagHasTrackResultSHIDs);
        storeTrackResultSHIDs.Add(to_append);
      }
    public void unsetTrackResultSHIDs()
      {
        flagHasTrackResultSHIDs = false;
        storeTrackResultSHIDs.Clear();
      }
    public void initAlbumResultSHIDs()
      {
        flagHasAlbumResultSHIDs = true;
        storeAlbumResultSHIDs.Clear();
      }
    public void appendAlbumResultSHIDs(double to_append)
      {
        if (!flagHasAlbumResultSHIDs)
          {
            flagHasAlbumResultSHIDs = true;
            storeAlbumResultSHIDs.Clear();
          }
        Debug.Assert(flagHasAlbumResultSHIDs);
        storeAlbumResultSHIDs.Add(to_append);
      }
    public void unsetAlbumResultSHIDs()
      {
        flagHasAlbumResultSHIDs = false;
        storeAlbumResultSHIDs.Clear();
      }
    public void initArtistResultSHIDs()
      {
        flagHasArtistResultSHIDs = true;
        storeArtistResultSHIDs.Clear();
      }
    public void appendArtistResultSHIDs(double to_append)
      {
        if (!flagHasArtistResultSHIDs)
          {
            flagHasArtistResultSHIDs = true;
            storeArtistResultSHIDs.Clear();
          }
        Debug.Assert(flagHasArtistResultSHIDs);
        storeArtistResultSHIDs.Add(to_append);
      }
    public void unsetArtistResultSHIDs()
      {
        flagHasArtistResultSHIDs = false;
        storeArtistResultSHIDs.Clear();
      }
    public void initVideoResultIDs()
      {
        flagHasVideoResultIDs = true;
        storeVideoResultIDs.Clear();
      }
    public void appendVideoResultIDs(string to_append)
      {
        if (!flagHasVideoResultIDs)
          {
            flagHasVideoResultIDs = true;
            storeVideoResultIDs.Clear();
          }
        Debug.Assert(flagHasVideoResultIDs);
        storeVideoResultIDs.Add(to_append);
      }
    public void unsetVideoResultIDs()
      {
        flagHasVideoResultIDs = false;
        storeVideoResultIDs.Clear();
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
        if (flagHasCurrentDateAndTime)
          {
            handler.start_pair("CurrentDateAndTime");
            if (partial_allowed)
                storeCurrentDateAndTime.write_partial_as_json(handler);
            else
                storeCurrentDateAndTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEntity);
        if (flagHasEntity)
          {
            handler.start_pair("Entity");
            if (storeEntity.in_known_list)
              {
                switch (storeEntity.list_value)
                  {
                    case TypeEntityKnownValues.Entity_Tracks:
                        handler.string_value("Tracks");
                        break;
                    case TypeEntityKnownValues.Entity_Artists:
                        handler.string_value("Artists");
                        break;
                    case TypeEntityKnownValues.Entity_Albums:
                        handler.string_value("Albums");
                        break;
                    case TypeEntityKnownValues.Entity_Videos:
                        handler.string_value("Videos");
                        break;
                    case TypeEntityKnownValues.Entity_ArtistsBornOn:
                        handler.string_value("ArtistsBornOn");
                        break;
                    case TypeEntityKnownValues.Entity_Playlist:
                        handler.string_value("Playlist");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeEntity.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasModifier);
        if (flagHasModifier)
          {
            handler.start_pair("Modifier");
            if (storeModifier.in_known_list)
              {
                switch (storeModifier.list_value)
                  {
                    case TypeModifierKnownValues.Modifier_Top:
                        handler.string_value("Top");
                        break;
                    case TypeModifierKnownValues.Modifier_New:
                        handler.string_value("New");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeModifier.string_value);
              }
          }
        if (flagHasTimePeriod)
          {
            handler.start_pair("TimePeriod");
            if (partial_allowed)
                storeTimePeriod.write_partial_as_json(handler);
            else
                storeTimePeriod.write_as_json(handler);
          }
        if (flagHasTimePeriodType)
          {
            handler.start_pair("TimePeriodType");
            if (storeTimePeriodType.in_known_list)
              {
                switch (storeTimePeriodType.list_value)
                  {
                    case TypeTimePeriodTypeKnownValues.TimePeriodType_Day:
                        handler.string_value("Day");
                        break;
                    case TypeTimePeriodTypeKnownValues.TimePeriodType_Week:
                        handler.string_value("Week");
                        break;
                    case TypeTimePeriodTypeKnownValues.TimePeriodType_Month:
                        handler.string_value("Month");
                        break;
                    case TypeTimePeriodTypeKnownValues.TimePeriodType_Year:
                        handler.string_value("Year");
                        break;
                    case TypeTimePeriodTypeKnownValues.TimePeriodType_Decade:
                        handler.string_value("Decade");
                        break;
                    case TypeTimePeriodTypeKnownValues.TimePeriodType_Century:
                        handler.string_value("Century");
                        break;
                    case TypeTimePeriodTypeKnownValues.TimePeriodType_None:
                        handler.string_value("None");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeTimePeriodType.string_value);
              }
          }
        if (flagHasGenre)
          {
            handler.start_pair("Genre");
            if (storeGenre.in_known_list)
              {
                switch (storeGenre.list_value)
                  {
                    case TypeGenreKnownValues.Genre_NoGenre:
                        handler.string_value("NoGenre");
                        break;
                    case TypeGenreKnownValues.Genre_Rock:
                        handler.string_value("Rock");
                        break;
                    case TypeGenreKnownValues.Genre_Pop:
                        handler.string_value("Pop");
                        break;
                    case TypeGenreKnownValues.Genre_Country:
                        handler.string_value("Country");
                        break;
                    case TypeGenreKnownValues.Genre_Electronic:
                        handler.string_value("Electronic");
                        break;
                    case TypeGenreKnownValues.Genre_Urban:
                        handler.string_value("Urban");
                        break;
                    case TypeGenreKnownValues.Genre_Latin:
                        handler.string_value("Latin");
                        break;
                    case TypeGenreKnownValues.Genre_AllGenres:
                        handler.string_value("AllGenres");
                        break;
                    case TypeGenreKnownValues.Genre_Avant_x20_Garde:
                        handler.string_value("Avant Garde");
                        break;
                    case TypeGenreKnownValues.Genre_Blues:
                        handler.string_value("Blues");
                        break;
                    case TypeGenreKnownValues.Genre_Childs:
                        handler.string_value("Childs");
                        break;
                    case TypeGenreKnownValues.Genre_Classical:
                        handler.string_value("Classical");
                        break;
                    case TypeGenreKnownValues.Genre_Easy:
                        handler.string_value("Easy");
                        break;
                    case TypeGenreKnownValues.Genre_Folk:
                        handler.string_value("Folk");
                        break;
                    case TypeGenreKnownValues.Genre_Gospel:
                        handler.string_value("Gospel");
                        break;
                    case TypeGenreKnownValues.Genre_Holiday:
                        handler.string_value("Holiday");
                        break;
                    case TypeGenreKnownValues.Genre_Jazz:
                        handler.string_value("Jazz");
                        break;
                    case TypeGenreKnownValues.Genre_Movie_x20_Soundtrack:
                        handler.string_value("Movie Soundtrack");
                        break;
                    case TypeGenreKnownValues.Genre_New_x20_Age:
                        handler.string_value("New Age");
                        break;
                    case TypeGenreKnownValues.Genre_Rap:
                        handler.string_value("Rap");
                        break;
                    case TypeGenreKnownValues.Genre_R_x26_B:
                        handler.string_value("R&B");
                        break;
                    case TypeGenreKnownValues.Genre_Reggae:
                        handler.string_value("Reggae");
                        break;
                    case TypeGenreKnownValues.Genre_Sound_x20_Effects:
                        handler.string_value("Sound Effects");
                        break;
                    case TypeGenreKnownValues.Genre_Spoken_x20_Word:
                        handler.string_value("Spoken Word");
                        break;
                    case TypeGenreKnownValues.Genre_Vocal:
                        handler.string_value("Vocal");
                        break;
                    case TypeGenreKnownValues.Genre_World:
                        handler.string_value("World");
                        break;
                    case TypeGenreKnownValues.Genre_AltGenre:
                        handler.string_value("AltGenre");
                        break;
                    case TypeGenreKnownValues.Genre_AltGenreFrenchFolk:
                        handler.string_value("AltGenreFrenchFolk");
                        break;
                    case TypeGenreKnownValues.Genre_AltGenreWestCoast:
                        handler.string_value("AltGenreWestCoast");
                        break;
                    case TypeGenreKnownValues.Genre_AltGenreEastCoast:
                        handler.string_value("AltGenreEastCoast");
                        break;
                    case TypeGenreKnownValues.Genre_AltGenreBritishPunk:
                        handler.string_value("AltGenreBritishPunk");
                        break;
                    case TypeGenreKnownValues.Genre_AltGenreVideoGame:
                        handler.string_value("AltGenreVideoGame");
                        break;
                    case TypeGenreKnownValues.Genre_AltGenreTVSoundtrack:
                        handler.string_value("AltGenreTVSoundtrack");
                        break;
                    case TypeGenreKnownValues.Genre_AltGenreBossaNova:
                        handler.string_value("AltGenreBossaNova");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeGenre.string_value);
              }
          }
        if (flagHasRequestedGenre)
          {
            handler.start_pair("RequestedGenre");
            if (partial_allowed)
                storeRequestedGenre.write_partial_as_json(handler);
            else
                storeRequestedGenre.write_as_json(handler);
          }
        if (flagHasGenreMatch)
          {
            handler.start_pair("GenreMatch");
            handler.boolean_value(storeGenreMatch);
          }
        if (flagHasPlaylist)
          {
            handler.start_pair("Playlist");
            if (storePlaylist.in_known_list)
              {
                switch (storePlaylist.list_value)
                  {
                    case TypePlaylistKnownValues.Playlist_NoPlaylist:
                        handler.string_value("NoPlaylist");
                        break;
                    case TypePlaylistKnownValues.Playlist_MemorialDay:
                        handler.string_value("MemorialDay");
                        break;
                    case TypePlaylistKnownValues.Playlist_JulyFourth:
                        handler.string_value("JulyFourth");
                        break;
                    case TypePlaylistKnownValues.Playlist_SummerHotSongs:
                        handler.string_value("SummerHotSongs");
                        break;
                    case TypePlaylistKnownValues.Playlist_SummerUltimate:
                        handler.string_value("SummerUltimate");
                        break;
                    case TypePlaylistKnownValues.Playlist_SummerLastSummerHits:
                        handler.string_value("SummerLastSummerHits");
                        break;
                    case TypePlaylistKnownValues.Playlist_Lollapalooza:
                        handler.string_value("Lollapalooza");
                        break;
                    case TypePlaylistKnownValues.Playlist_Olympics:
                        handler.string_value("Olympics");
                        break;
                    case TypePlaylistKnownValues.Playlist_OutsideLands:
                        handler.string_value("OutsideLands");
                        break;
                    case TypePlaylistKnownValues.Playlist_VMA:
                        handler.string_value("VMA");
                        break;
                    case TypePlaylistKnownValues.Playlist_AppleMusicFestival:
                        handler.string_value("AppleMusicFestival");
                        break;
                    case TypePlaylistKnownValues.Playlist_AustinCityLimits:
                        handler.string_value("AustinCityLimits");
                        break;
                    case TypePlaylistKnownValues.Playlist_MTVEuropeAwards:
                        handler.string_value("MTVEuropeAwards");
                        break;
                    case TypePlaylistKnownValues.Playlist_CMA:
                        handler.string_value("CMA");
                        break;
                    case TypePlaylistKnownValues.Playlist_LatinoGrammys:
                        handler.string_value("LatinoGrammys");
                        break;
                    case TypePlaylistKnownValues.Playlist_AMA:
                        handler.string_value("AMA");
                        break;
                    case TypePlaylistKnownValues.Playlist_YearInReview:
                        handler.string_value("YearInReview");
                        break;
                    case TypePlaylistKnownValues.Playlist_Holidays:
                        handler.string_value("Holidays");
                        break;
                    case TypePlaylistKnownValues.Playlist_NewYearsEve:
                        handler.string_value("NewYearsEve");
                        break;
                    case TypePlaylistKnownValues.Playlist_Halloween:
                        handler.string_value("Halloween");
                        break;
                    case TypePlaylistKnownValues.Playlist_ValentinesDay:
                        handler.string_value("ValentinesDay");
                        break;
                    case TypePlaylistKnownValues.Playlist_StPatricksDay:
                        handler.string_value("StPatricksDay");
                        break;
                    case TypePlaylistKnownValues.Playlist_AprilFoolsDay:
                        handler.string_value("AprilFoolsDay");
                        break;
                    case TypePlaylistKnownValues.Playlist_MothersDay:
                        handler.string_value("MothersDay");
                        break;
                    case TypePlaylistKnownValues.Playlist_FathersDay:
                        handler.string_value("FathersDay");
                        break;
                    case TypePlaylistKnownValues.Playlist_BackToSchool:
                        handler.string_value("BackToSchool");
                        break;
                    case TypePlaylistKnownValues.Playlist_LaborDay:
                        handler.string_value("LaborDay");
                        break;
                    case TypePlaylistKnownValues.Playlist_Thanksgiving:
                        handler.string_value("Thanksgiving");
                        break;
                    case TypePlaylistKnownValues.Playlist_BlackFriday:
                        handler.string_value("BlackFriday");
                        break;
                    case TypePlaylistKnownValues.Playlist_Christmas:
                        handler.string_value("Christmas");
                        break;
                    case TypePlaylistKnownValues.Playlist_Spring:
                        handler.string_value("Spring");
                        break;
                    case TypePlaylistKnownValues.Playlist_Summer:
                        handler.string_value("Summer");
                        break;
                    case TypePlaylistKnownValues.Playlist_Winter:
                        handler.string_value("Winter");
                        break;
                    case TypePlaylistKnownValues.Playlist_Fall:
                        handler.string_value("Fall");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storePlaylist.string_value);
              }
          }
        if (flagHasBirthday)
          {
            handler.start_pair("Birthday");
            if (partial_allowed)
                storeBirthday.write_partial_as_json(handler);
            else
                storeBirthday.write_as_json(handler);
          }
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            if (partial_allowed)
                storeLocation.write_partial_as_json(handler);
            else
                storeLocation.write_as_json(handler);
          }
        if (flagHasCountryCode)
          {
            handler.start_pair("CountryCode");
            handler.string_value(storeCountryCode);
          }
        if (flagHasCountryName)
          {
            handler.start_pair("CountryName");
            handler.string_value(storeCountryName);
          }
        Debug.Assert(partial_allowed || flagHasGeoScope);
        if (flagHasGeoScope)
          {
            handler.start_pair("GeoScope");
            if (storeGeoScope.in_known_list)
              {
                switch (storeGeoScope.list_value)
                  {
                    case TypeGeoScopeKnownValues.GeoScope_Country:
                        handler.string_value("Country");
                        break;
                    case TypeGeoScopeKnownValues.GeoScope_Continent:
                        handler.string_value("Continent");
                        break;
                    case TypeGeoScopeKnownValues.GeoScope_World:
                        handler.string_value("World");
                        break;
                    case TypeGeoScopeKnownValues.GeoScope_None:
                        handler.string_value("None");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeGeoScope.string_value);
              }
          }
        if (flagHasPlay)
          {
            handler.start_pair("Play");
            handler.boolean_value(storePlay);
          }
        if (flagHasShuffle)
          {
            handler.start_pair("Shuffle");
            handler.boolean_value(storeShuffle);
          }
        if (flagHasHowMany)
          {
            handler.start_pair("HowMany");
            handler.boolean_value(storeHowMany);
          }
        Debug.Assert(partial_allowed || flagHasRequestedNumberOfResults);
        if (flagHasRequestedNumberOfResults)
          {
            handler.start_pair("RequestedNumberOfResults");
            handler.number_value(storeRequestedNumberOfResults);
          }
        if (flagHasTrackResultSHIDs)
          {
            handler.start_pair("TrackResultSHIDs");
            handler.start_array();
            for (int num1 = 0; num1 < storeTrackResultSHIDs.Count; ++num1)
              {
                if (((double)(long)storeTrackResultSHIDs[num1]) == storeTrackResultSHIDs[num1])
                    handler.number_value((long)storeTrackResultSHIDs[num1]);
                else
                    handler.number_value(storeTrackResultSHIDs[num1]);
              }
            handler.finish_array();
          }
        if (flagHasAlbumResultSHIDs)
          {
            handler.start_pair("AlbumResultSHIDs");
            handler.start_array();
            for (int num2 = 0; num2 < storeAlbumResultSHIDs.Count; ++num2)
              {
                if (((double)(long)storeAlbumResultSHIDs[num2]) == storeAlbumResultSHIDs[num2])
                    handler.number_value((long)storeAlbumResultSHIDs[num2]);
                else
                    handler.number_value(storeAlbumResultSHIDs[num2]);
              }
            handler.finish_array();
          }
        if (flagHasArtistResultSHIDs)
          {
            handler.start_pair("ArtistResultSHIDs");
            handler.start_array();
            for (int num3 = 0; num3 < storeArtistResultSHIDs.Count; ++num3)
              {
                if (((double)(long)storeArtistResultSHIDs[num3]) == storeArtistResultSHIDs[num3])
                    handler.number_value((long)storeArtistResultSHIDs[num3]);
                else
                    handler.number_value(storeArtistResultSHIDs[num3]);
              }
            handler.finish_array();
          }
        if (flagHasVideoResultIDs)
          {
            handler.start_pair("VideoResultIDs");
            handler.start_array();
            for (int num4 = 0; num4 < storeVideoResultIDs.Count; ++num4)
              {
                handler.string_value(storeVideoResultIDs[num4]);
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
        if (!(hasEntity()))
          {
            return "When parsing the object for %what%, the \"Entity\" field was missing.";
          }
        if (!(hasModifier()))
          {
            return "When parsing the object for %what%, the \"Modifier\" field was missing.";
          }
        if (!(hasGeoScope()))
          {
            return "When parsing the object for %what%, the \"GeoScope\" field was missing.";
          }
        if (!(hasRequestedNumberOfResults()))
          {
            return "When parsing the object for %what%, the \"RequestedNumberOfResults\" field was missing.";
          }
        return null;
      }

    public static MusicChartsSearchCriteriaJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicChartsSearchCriteriaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsSearchCriteria", ignore_extras);
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
    public static MusicChartsSearchCriteriaJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicChartsSearchCriteriaJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicChartsSearchCriteriaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsSearchCriteria", ignore_extras);
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
    public static MusicChartsSearchCriteriaJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicChartsSearchCriteriaJSON from_text(string text, bool ignore_extras)
      {
        MusicChartsSearchCriteriaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsSearchCriteria", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicChartsSearchCriteriaJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicChartsSearchCriteriaJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicChartsSearchCriteriaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsSearchCriteria", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorCurrentDateAndTime;
    private abstract class FieldGeneratorEntity : JSONStringGenerator
          {
            protected FieldGeneratorEntity(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorEntity()
              {
              }
            protected override void handle_result(string result)
              {
                TypeEntityKnownValues known = stringToEntity(result);
                TypeEntity new_value = new TypeEntity();
                if (known == TypeEntityKnownValues.Entity__none)
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
            protected abstract void handle_result(TypeEntity result);
          };
    private class FieldHoldingGeneratorEntity : FieldGeneratorEntity
  {
    protected override void handle_result(TypeEntity result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorEntity(String what)
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
    public TypeEntity value;
  };
    private class FieldHoldingArrayGeneratorEntity : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorEntity
      {
        private FieldHoldingArrayGeneratorEntity top;

        protected override void handle_result(TypeEntity result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorEntity init_top)
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
    protected virtual void handle_result(List<TypeEntity> result)
      {
      }

    public FieldHoldingArrayGeneratorEntity(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeEntity>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorEntity()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeEntity>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeEntity> value;
  };
        private FieldHoldingGeneratorEntity fieldGeneratorEntity;
    private abstract class FieldGeneratorModifier : JSONStringGenerator
          {
            protected FieldGeneratorModifier(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorModifier()
              {
              }
            protected override void handle_result(string result)
              {
                TypeModifierKnownValues known = stringToModifier(result);
                TypeModifier new_value = new TypeModifier();
                if (known == TypeModifierKnownValues.Modifier__none)
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
            protected abstract void handle_result(TypeModifier result);
          };
    private class FieldHoldingGeneratorModifier : FieldGeneratorModifier
  {
    protected override void handle_result(TypeModifier result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorModifier(String what)
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
    public TypeModifier value;
  };
    private class FieldHoldingArrayGeneratorModifier : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorModifier
      {
        private FieldHoldingArrayGeneratorModifier top;

        protected override void handle_result(TypeModifier result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorModifier init_top)
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
    protected virtual void handle_result(List<TypeModifier> result)
      {
      }

    public FieldHoldingArrayGeneratorModifier(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeModifier>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorModifier()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeModifier>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeModifier> value;
  };
        private FieldHoldingGeneratorModifier fieldGeneratorModifier;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorTimePeriod;
    private abstract class FieldGeneratorTimePeriodType : JSONStringGenerator
          {
            protected FieldGeneratorTimePeriodType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorTimePeriodType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeTimePeriodTypeKnownValues known = stringToTimePeriodType(result);
                TypeTimePeriodType new_value = new TypeTimePeriodType();
                if (known == TypeTimePeriodTypeKnownValues.TimePeriodType__none)
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
            protected abstract void handle_result(TypeTimePeriodType result);
          };
    private class FieldHoldingGeneratorTimePeriodType : FieldGeneratorTimePeriodType
  {
    protected override void handle_result(TypeTimePeriodType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorTimePeriodType(String what)
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
    public TypeTimePeriodType value;
  };
    private class FieldHoldingArrayGeneratorTimePeriodType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorTimePeriodType
      {
        private FieldHoldingArrayGeneratorTimePeriodType top;

        protected override void handle_result(TypeTimePeriodType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorTimePeriodType init_top)
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
    protected virtual void handle_result(List<TypeTimePeriodType> result)
      {
      }

    public FieldHoldingArrayGeneratorTimePeriodType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTimePeriodType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorTimePeriodType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTimePeriodType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeTimePeriodType> value;
  };
        private FieldHoldingGeneratorTimePeriodType fieldGeneratorTimePeriodType;
    private abstract class FieldGeneratorGenre : JSONStringGenerator
          {
            protected FieldGeneratorGenre(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorGenre()
              {
              }
            protected override void handle_result(string result)
              {
                TypeGenreKnownValues known = stringToGenre(result);
                TypeGenre new_value = new TypeGenre();
                if (known == TypeGenreKnownValues.Genre__none)
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
            protected abstract void handle_result(TypeGenre result);
          };
    private class FieldHoldingGeneratorGenre : FieldGeneratorGenre
  {
    protected override void handle_result(TypeGenre result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorGenre(String what)
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
    public TypeGenre value;
  };
    private class FieldHoldingArrayGeneratorGenre : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorGenre
      {
        private FieldHoldingArrayGeneratorGenre top;

        protected override void handle_result(TypeGenre result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorGenre init_top)
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
    protected virtual void handle_result(List<TypeGenre> result)
      {
      }

    public FieldHoldingArrayGeneratorGenre(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeGenre>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorGenre()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeGenre>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeGenre> value;
  };
        private FieldHoldingGeneratorGenre fieldGeneratorGenre;
        private MusicGenreJSON.HoldingGenerator fieldGeneratorRequestedGenre;
        private JSONHoldingBooleanGenerator fieldGeneratorGenreMatch;
    private abstract class FieldGeneratorPlaylist : JSONStringGenerator
          {
            protected FieldGeneratorPlaylist(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorPlaylist()
              {
              }
            protected override void handle_result(string result)
              {
                TypePlaylistKnownValues known = stringToPlaylist(result);
                TypePlaylist new_value = new TypePlaylist();
                if (known == TypePlaylistKnownValues.Playlist__none)
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
            protected abstract void handle_result(TypePlaylist result);
          };
    private class FieldHoldingGeneratorPlaylist : FieldGeneratorPlaylist
  {
    protected override void handle_result(TypePlaylist result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorPlaylist(String what)
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
    public TypePlaylist value;
  };
    private class FieldHoldingArrayGeneratorPlaylist : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorPlaylist
      {
        private FieldHoldingArrayGeneratorPlaylist top;

        protected override void handle_result(TypePlaylist result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPlaylist init_top)
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
    protected virtual void handle_result(List<TypePlaylist> result)
      {
      }

    public FieldHoldingArrayGeneratorPlaylist(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePlaylist>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPlaylist()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePlaylist>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypePlaylist> value;
  };
        private FieldHoldingGeneratorPlaylist fieldGeneratorPlaylist;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorBirthday;
        private MapLocationJSON.HoldingGenerator fieldGeneratorLocation;
        private JSONHoldingStringGenerator fieldGeneratorCountryCode;
        private JSONHoldingStringGenerator fieldGeneratorCountryName;
    private abstract class FieldGeneratorGeoScope : JSONStringGenerator
          {
            protected FieldGeneratorGeoScope(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorGeoScope()
              {
              }
            protected override void handle_result(string result)
              {
                TypeGeoScopeKnownValues known = stringToGeoScope(result);
                TypeGeoScope new_value = new TypeGeoScope();
                if (known == TypeGeoScopeKnownValues.GeoScope__none)
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
            protected abstract void handle_result(TypeGeoScope result);
          };
    private class FieldHoldingGeneratorGeoScope : FieldGeneratorGeoScope
  {
    protected override void handle_result(TypeGeoScope result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorGeoScope(String what)
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
    public TypeGeoScope value;
  };
    private class FieldHoldingArrayGeneratorGeoScope : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorGeoScope
      {
        private FieldHoldingArrayGeneratorGeoScope top;

        protected override void handle_result(TypeGeoScope result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorGeoScope init_top)
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
    protected virtual void handle_result(List<TypeGeoScope> result)
      {
      }

    public FieldHoldingArrayGeneratorGeoScope(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeGeoScope>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorGeoScope()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeGeoScope>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeGeoScope> value;
  };
        private FieldHoldingGeneratorGeoScope fieldGeneratorGeoScope;
        private JSONHoldingBooleanGenerator fieldGeneratorPlay;
        private JSONHoldingBooleanGenerator fieldGeneratorShuffle;
        private JSONHoldingBooleanGenerator fieldGeneratorHowMany;
    private class FieldHoldingGeneratorRequestedNumberOfResults : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRequestedNumberOfResults(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRequestedNumberOfResults : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRequestedNumberOfResults(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorRequestedNumberOfResults fieldGeneratorRequestedNumberOfResults;
        private JSONHoldingNumberTextArrayGenerator fieldGeneratorTrackResultSHIDs;
        private JSONHoldingNumberTextArrayGenerator fieldGeneratorAlbumResultSHIDs;
        private JSONHoldingNumberTextArrayGenerator fieldGeneratorArtistResultSHIDs;
        private JSONHoldingStringArrayGenerator fieldGeneratorVideoResultIDs;

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
            MusicChartsSearchCriteriaJSON result = new MusicChartsSearchCriteriaJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MusicChartsSearchCriteriaJSON result)
          {
            if (fieldGeneratorCurrentDateAndTime.have_value)
              {
                result.setCurrentDateAndTime(fieldGeneratorCurrentDateAndTime.value);
                fieldGeneratorCurrentDateAndTime.have_value = false;
              }
            if (fieldGeneratorEntity.have_value)
              {
                result.setEntity(fieldGeneratorEntity.value);
                fieldGeneratorEntity.have_value = false;
              }
            else if ((!(result.hasEntity())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Entity\" field was missing.");
              }
            if (fieldGeneratorModifier.have_value)
              {
                result.setModifier(fieldGeneratorModifier.value);
                fieldGeneratorModifier.have_value = false;
              }
            else if ((!(result.hasModifier())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Modifier\" field was missing.");
              }
            if (fieldGeneratorTimePeriod.have_value)
              {
                result.setTimePeriod(fieldGeneratorTimePeriod.value);
                fieldGeneratorTimePeriod.have_value = false;
              }
            if (fieldGeneratorTimePeriodType.have_value)
              {
                result.setTimePeriodType(fieldGeneratorTimePeriodType.value);
                fieldGeneratorTimePeriodType.have_value = false;
              }
            if (fieldGeneratorGenre.have_value)
              {
                result.setGenre(fieldGeneratorGenre.value);
                fieldGeneratorGenre.have_value = false;
              }
            if (fieldGeneratorRequestedGenre.have_value)
              {
                result.setRequestedGenre(fieldGeneratorRequestedGenre.value);
                fieldGeneratorRequestedGenre.have_value = false;
              }
            if (fieldGeneratorGenreMatch.have_value)
              {
                result.setGenreMatch(fieldGeneratorGenreMatch.value);
                fieldGeneratorGenreMatch.have_value = false;
              }
            if (fieldGeneratorPlaylist.have_value)
              {
                result.setPlaylist(fieldGeneratorPlaylist.value);
                fieldGeneratorPlaylist.have_value = false;
              }
            if (fieldGeneratorBirthday.have_value)
              {
                result.setBirthday(fieldGeneratorBirthday.value);
                fieldGeneratorBirthday.have_value = false;
              }
            if (fieldGeneratorLocation.have_value)
              {
                result.setLocation(fieldGeneratorLocation.value);
                fieldGeneratorLocation.have_value = false;
              }
            if (fieldGeneratorCountryCode.have_value)
              {
                result.setCountryCode(fieldGeneratorCountryCode.value);
                fieldGeneratorCountryCode.have_value = false;
              }
            if (fieldGeneratorCountryName.have_value)
              {
                result.setCountryName(fieldGeneratorCountryName.value);
                fieldGeneratorCountryName.have_value = false;
              }
            if (fieldGeneratorGeoScope.have_value)
              {
                result.setGeoScope(fieldGeneratorGeoScope.value);
                fieldGeneratorGeoScope.have_value = false;
              }
            else if ((!(result.hasGeoScope())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"GeoScope\" field was missing.");
              }
            if (fieldGeneratorPlay.have_value)
              {
                result.setPlay(fieldGeneratorPlay.value);
                fieldGeneratorPlay.have_value = false;
              }
            if (fieldGeneratorShuffle.have_value)
              {
                result.setShuffle(fieldGeneratorShuffle.value);
                fieldGeneratorShuffle.have_value = false;
              }
            if (fieldGeneratorHowMany.have_value)
              {
                result.setHowMany(fieldGeneratorHowMany.value);
                fieldGeneratorHowMany.have_value = false;
              }
            if (fieldGeneratorRequestedNumberOfResults.have_value)
              {
                result.setRequestedNumberOfResults(fieldGeneratorRequestedNumberOfResults.value);
                fieldGeneratorRequestedNumberOfResults.have_value = false;
              }
            else if ((!(result.hasRequestedNumberOfResults())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedNumberOfResults\" field was missing.");
              }
            if (fieldGeneratorTrackResultSHIDs.have_value)
              {
                result.initTrackResultSHIDs();
                int count = fieldGeneratorTrackResultSHIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTrackResultSHIDs(Double.Parse(fieldGeneratorTrackResultSHIDs.value[num]));
                  }
                fieldGeneratorTrackResultSHIDs.value.Clear();
                fieldGeneratorTrackResultSHIDs.have_value = false;
              }
            if (fieldGeneratorAlbumResultSHIDs.have_value)
              {
                result.initAlbumResultSHIDs();
                int count = fieldGeneratorAlbumResultSHIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAlbumResultSHIDs(Double.Parse(fieldGeneratorAlbumResultSHIDs.value[num]));
                  }
                fieldGeneratorAlbumResultSHIDs.value.Clear();
                fieldGeneratorAlbumResultSHIDs.have_value = false;
              }
            if (fieldGeneratorArtistResultSHIDs.have_value)
              {
                result.initArtistResultSHIDs();
                int count = fieldGeneratorArtistResultSHIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendArtistResultSHIDs(Double.Parse(fieldGeneratorArtistResultSHIDs.value[num]));
                  }
                fieldGeneratorArtistResultSHIDs.value.Clear();
                fieldGeneratorArtistResultSHIDs.have_value = false;
              }
            if (fieldGeneratorVideoResultIDs.have_value)
              {
                result.initVideoResultIDs();
                int count = fieldGeneratorVideoResultIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendVideoResultIDs(fieldGeneratorVideoResultIDs.value[num]);
                  }
                fieldGeneratorVideoResultIDs.value.Clear();
                fieldGeneratorVideoResultIDs.have_value = false;
              }
          }
        protected abstract void handle_result(MusicChartsSearchCriteriaJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "bumResultSHIDs", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorAlbumResultSHIDs;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "tistResultSHIDs", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorArtistResultSHIDs;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'B':
                    if ((String.Compare(field_name, 1, "irthday", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorBirthday;
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'o':
                            if (String.Compare(field_name, 2, "untry", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 8, "ode", 0, 3, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorCountryCode;
                                        break;
                                    case 'N':
                                        if ((String.Compare(field_name, 8, "ame", 0, 3, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorCountryName;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rrentDateAndTime", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorCurrentDateAndTime;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "ntity", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorEntity;
                    break;
                case 'G':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'n':
                                if (String.Compare(field_name, 3, "re", 0, 2, false) == 0)
                                  {
                                    if (field_name.Length == 5)
                                      {
                                        return fieldGeneratorGenre;
                                      }
                                    switch (field_name[5])
                                      {
                                        case 'M':
                                            if ((String.Compare(field_name, 6, "atch", 0, 4, false) == 0) && (field_name.Length == 10))
                                                return fieldGeneratorGenreMatch;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 3, "Scope", 0, 5, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorGeoScope;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "owMany", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorHowMany;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "odifier", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorModifier;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "lay", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorPlay;
                          }
                        switch (field_name[4])
                          {
                            case 'l':
                                if ((String.Compare(field_name, 5, "ist", 0, 3, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorPlaylist;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "equested", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'G':
                                if ((String.Compare(field_name, 10, "enre", 0, 4, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorRequestedGenre;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 10, "umberOfResults", 0, 14, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorRequestedNumberOfResults;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "huffle", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorShuffle;
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'i':
                            if (String.Compare(field_name, 2, "mePeriod", 0, 8, false) == 0)
                              {
                                if (field_name.Length == 10)
                                  {
                                    return fieldGeneratorTimePeriod;
                                  }
                                switch (field_name[10])
                                  {
                                    case 'T':
                                        if ((String.Compare(field_name, 11, "ype", 0, 3, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorTimePeriodType;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "ackResultSHIDs", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorTrackResultSHIDs;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "ideoResultIDs", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorVideoResultIDs;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCurrentDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"CurrentDateAndTime\" of the MusicChartsSearchCriteria class", ignore_extras);
            fieldGeneratorEntity = new FieldHoldingGeneratorEntity("field \"Entity\" of the MusicChartsSearchCriteria class");
            fieldGeneratorModifier = new FieldHoldingGeneratorModifier("field \"Modifier\" of the MusicChartsSearchCriteria class");
            fieldGeneratorTimePeriod = new DateTimeRangeSpecJSON.HoldingGenerator("field \"TimePeriod\" of the MusicChartsSearchCriteria class", ignore_extras);
            fieldGeneratorTimePeriodType = new FieldHoldingGeneratorTimePeriodType("field \"TimePeriodType\" of the MusicChartsSearchCriteria class");
            fieldGeneratorGenre = new FieldHoldingGeneratorGenre("field \"Genre\" of the MusicChartsSearchCriteria class");
            fieldGeneratorRequestedGenre = new MusicGenreJSON.HoldingGenerator("field \"RequestedGenre\" of the MusicChartsSearchCriteria class", ignore_extras);
            fieldGeneratorGenreMatch = new JSONHoldingBooleanGenerator("field \"GenreMatch\" of the MusicChartsSearchCriteria class");
            fieldGeneratorPlaylist = new FieldHoldingGeneratorPlaylist("field \"Playlist\" of the MusicChartsSearchCriteria class");
            fieldGeneratorBirthday = new DateTimeRangeSpecJSON.HoldingGenerator("field \"Birthday\" of the MusicChartsSearchCriteria class", ignore_extras);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the MusicChartsSearchCriteria class", ignore_extras);
            fieldGeneratorCountryCode = new JSONHoldingStringGenerator("field \"CountryCode\" of the MusicChartsSearchCriteria class");
            fieldGeneratorCountryName = new JSONHoldingStringGenerator("field \"CountryName\" of the MusicChartsSearchCriteria class");
            fieldGeneratorGeoScope = new FieldHoldingGeneratorGeoScope("field \"GeoScope\" of the MusicChartsSearchCriteria class");
            fieldGeneratorPlay = new JSONHoldingBooleanGenerator("field \"Play\" of the MusicChartsSearchCriteria class");
            fieldGeneratorShuffle = new JSONHoldingBooleanGenerator("field \"Shuffle\" of the MusicChartsSearchCriteria class");
            fieldGeneratorHowMany = new JSONHoldingBooleanGenerator("field \"HowMany\" of the MusicChartsSearchCriteria class");
            fieldGeneratorRequestedNumberOfResults = new FieldHoldingGeneratorRequestedNumberOfResults("field \"RequestedNumberOfResults\" of the MusicChartsSearchCriteria class");
            fieldGeneratorTrackResultSHIDs = new JSONHoldingNumberTextArrayGenerator("field \"TrackResultSHIDs\" of the MusicChartsSearchCriteria class");
            fieldGeneratorAlbumResultSHIDs = new JSONHoldingNumberTextArrayGenerator("field \"AlbumResultSHIDs\" of the MusicChartsSearchCriteria class");
            fieldGeneratorArtistResultSHIDs = new JSONHoldingNumberTextArrayGenerator("field \"ArtistResultSHIDs\" of the MusicChartsSearchCriteria class");
            fieldGeneratorVideoResultIDs = new JSONHoldingStringArrayGenerator("field \"VideoResultIDs\" of the MusicChartsSearchCriteria class");
            set_what("the MusicChartsSearchCriteria class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCurrentDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"CurrentDateAndTime\" of the MusicChartsSearchCriteria class", false);
            fieldGeneratorEntity = new FieldHoldingGeneratorEntity("field \"Entity\" of the MusicChartsSearchCriteria class");
            fieldGeneratorModifier = new FieldHoldingGeneratorModifier("field \"Modifier\" of the MusicChartsSearchCriteria class");
            fieldGeneratorTimePeriod = new DateTimeRangeSpecJSON.HoldingGenerator("field \"TimePeriod\" of the MusicChartsSearchCriteria class", false);
            fieldGeneratorTimePeriodType = new FieldHoldingGeneratorTimePeriodType("field \"TimePeriodType\" of the MusicChartsSearchCriteria class");
            fieldGeneratorGenre = new FieldHoldingGeneratorGenre("field \"Genre\" of the MusicChartsSearchCriteria class");
            fieldGeneratorRequestedGenre = new MusicGenreJSON.HoldingGenerator("field \"RequestedGenre\" of the MusicChartsSearchCriteria class", false);
            fieldGeneratorGenreMatch = new JSONHoldingBooleanGenerator("field \"GenreMatch\" of the MusicChartsSearchCriteria class");
            fieldGeneratorPlaylist = new FieldHoldingGeneratorPlaylist("field \"Playlist\" of the MusicChartsSearchCriteria class");
            fieldGeneratorBirthday = new DateTimeRangeSpecJSON.HoldingGenerator("field \"Birthday\" of the MusicChartsSearchCriteria class", false);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the MusicChartsSearchCriteria class", false);
            fieldGeneratorCountryCode = new JSONHoldingStringGenerator("field \"CountryCode\" of the MusicChartsSearchCriteria class");
            fieldGeneratorCountryName = new JSONHoldingStringGenerator("field \"CountryName\" of the MusicChartsSearchCriteria class");
            fieldGeneratorGeoScope = new FieldHoldingGeneratorGeoScope("field \"GeoScope\" of the MusicChartsSearchCriteria class");
            fieldGeneratorPlay = new JSONHoldingBooleanGenerator("field \"Play\" of the MusicChartsSearchCriteria class");
            fieldGeneratorShuffle = new JSONHoldingBooleanGenerator("field \"Shuffle\" of the MusicChartsSearchCriteria class");
            fieldGeneratorHowMany = new JSONHoldingBooleanGenerator("field \"HowMany\" of the MusicChartsSearchCriteria class");
            fieldGeneratorRequestedNumberOfResults = new FieldHoldingGeneratorRequestedNumberOfResults("field \"RequestedNumberOfResults\" of the MusicChartsSearchCriteria class");
            fieldGeneratorTrackResultSHIDs = new JSONHoldingNumberTextArrayGenerator("field \"TrackResultSHIDs\" of the MusicChartsSearchCriteria class");
            fieldGeneratorAlbumResultSHIDs = new JSONHoldingNumberTextArrayGenerator("field \"AlbumResultSHIDs\" of the MusicChartsSearchCriteria class");
            fieldGeneratorArtistResultSHIDs = new JSONHoldingNumberTextArrayGenerator("field \"ArtistResultSHIDs\" of the MusicChartsSearchCriteria class");
            fieldGeneratorVideoResultIDs = new JSONHoldingStringArrayGenerator("field \"VideoResultIDs\" of the MusicChartsSearchCriteria class");
            set_what("the MusicChartsSearchCriteria class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCurrentDateAndTime.reset();
            fieldGeneratorEntity.reset();
            fieldGeneratorModifier.reset();
            fieldGeneratorTimePeriod.reset();
            fieldGeneratorTimePeriodType.reset();
            fieldGeneratorGenre.reset();
            fieldGeneratorRequestedGenre.reset();
            fieldGeneratorGenreMatch.reset();
            fieldGeneratorPlaylist.reset();
            fieldGeneratorBirthday.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorCountryCode.reset();
            fieldGeneratorCountryName.reset();
            fieldGeneratorGeoScope.reset();
            fieldGeneratorPlay.reset();
            fieldGeneratorShuffle.reset();
            fieldGeneratorHowMany.reset();
            fieldGeneratorRequestedNumberOfResults.reset();
            fieldGeneratorTrackResultSHIDs.reset();
            fieldGeneratorAlbumResultSHIDs.reset();
            fieldGeneratorArtistResultSHIDs.reset();
            fieldGeneratorVideoResultIDs.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorCurrentDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTimePeriod.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedGenre.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorBirthday.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLocation.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorCurrentDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTimePeriod.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedGenre.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorBirthday.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLocation.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicChartsSearchCriteriaJSON  result)
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
        public MusicChartsSearchCriteriaJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicChartsSearchCriteriaJSON  result)
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
    protected virtual void handle_result(List<MusicChartsSearchCriteriaJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicChartsSearchCriteriaJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicChartsSearchCriteriaJSON>();
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
    public List<MusicChartsSearchCriteriaJSON> value;
  };
  };
