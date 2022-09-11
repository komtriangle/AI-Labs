/* file "MusicSearchTypeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicSearchTypeJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_SearchForTracksOnAlbum,
        Value_SearchForTracksByArtist,
        Value_SearchForTracksByArtistImplied,
        Value_SearchForTracks,
        Value_SearchForArtists,
        Value_SearchForArtistsByTrack,
        Value_SearchForAlbums,
        Value_SearchForAlbumsByArtist,
        Value_SearchForAllAlbumsByArtist,
        Value_SearchForMusicEntities,
        Value_NONE,
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
            case 'N':
                if ((String.Compare(chars, 1, "ONE", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeValueKnownValues.Value_NONE;
                break;
            case 'S':
                if (String.Compare(chars, 1, "earchFor", 0, 8, false) == 0)
                  {
                    switch (chars[9])
                      {
                        case 'A':
                            switch (chars[10])
                              {
                                case 'l':
                                    switch (chars[11])
                                      {
                                        case 'b':
                                            if (String.Compare(chars, 12, "ums", 0, 3, false) == 0)
                                              {
                                                if (chars.Length == 15)
                                                  {
                                                    return TypeValueKnownValues.Value_SearchForAlbums;
                                                  }
                                                switch (chars[15])
                                                  {
                                                    case 'B':
                                                        if ((String.Compare(chars, 16, "yArtist", 0, 7, false) == 0) && (chars.Length == 23))
                                                            return TypeValueKnownValues.Value_SearchForAlbumsByArtist;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'l':
                                            if ((String.Compare(chars, 12, "AlbumsByArtist", 0, 14, false) == 0) && (chars.Length == 26))
                                                return TypeValueKnownValues.Value_SearchForAllAlbumsByArtist;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'r':
                                    if (String.Compare(chars, 11, "tists", 0, 5, false) == 0)
                                      {
                                        if (chars.Length == 16)
                                          {
                                            return TypeValueKnownValues.Value_SearchForArtists;
                                          }
                                        switch (chars[16])
                                          {
                                            case 'B':
                                                if ((String.Compare(chars, 17, "yTrack", 0, 6, false) == 0) && (chars.Length == 23))
                                                    return TypeValueKnownValues.Value_SearchForArtistsByTrack;
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
                        case 'M':
                            if ((String.Compare(chars, 10, "usicEntities", 0, 12, false) == 0) && (chars.Length == 22))
                                return TypeValueKnownValues.Value_SearchForMusicEntities;
                            break;
                        case 'T':
                            if (String.Compare(chars, 10, "racks", 0, 5, false) == 0)
                              {
                                if (chars.Length == 15)
                                  {
                                    return TypeValueKnownValues.Value_SearchForTracks;
                                  }
                                switch (chars[15])
                                  {
                                    case 'B':
                                        if (String.Compare(chars, 16, "yArtist", 0, 7, false) == 0)
                                          {
                                            if (chars.Length == 23)
                                              {
                                                return TypeValueKnownValues.Value_SearchForTracksByArtist;
                                              }
                                            switch (chars[23])
                                              {
                                                case 'I':
                                                    if ((String.Compare(chars, 24, "mplied", 0, 6, false) == 0) && (chars.Length == 30))
                                                        return TypeValueKnownValues.Value_SearchForTracksByArtistImplied;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'O':
                                        if ((String.Compare(chars, 16, "nAlbum", 0, 6, false) == 0) && (chars.Length == 22))
                                            return TypeValueKnownValues.Value_SearchForTracksOnAlbum;
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
        return TypeValueKnownValues.Value__none;
      }

    public static string  stringFromValue(TypeValueKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeValueKnownValues.Value_SearchForTracksOnAlbum:
                return "SearchForTracksOnAlbum";
            case TypeValueKnownValues.Value_SearchForTracksByArtist:
                return "SearchForTracksByArtist";
            case TypeValueKnownValues.Value_SearchForTracksByArtistImplied:
                return "SearchForTracksByArtistImplied";
            case TypeValueKnownValues.Value_SearchForTracks:
                return "SearchForTracks";
            case TypeValueKnownValues.Value_SearchForArtists:
                return "SearchForArtists";
            case TypeValueKnownValues.Value_SearchForArtistsByTrack:
                return "SearchForArtistsByTrack";
            case TypeValueKnownValues.Value_SearchForAlbums:
                return "SearchForAlbums";
            case TypeValueKnownValues.Value_SearchForAlbumsByArtist:
                return "SearchForAlbumsByArtist";
            case TypeValueKnownValues.Value_SearchForAllAlbumsByArtist:
                return "SearchForAllAlbumsByArtist";
            case TypeValueKnownValues.Value_SearchForMusicEntities:
                return "SearchForMusicEntities";
            case TypeValueKnownValues.Value_NONE:
                return "NONE";
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
            throw new Exception("The value for field Value of MusicSearchTypeJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "ONE", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_NONE;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if (String.Compare(json_string.getData(), 1, "earchFor", 0, 8, false) == 0)
                  {
                    switch (json_string.getData()[9])
                      {
                        case 'A':
                            switch (json_string.getData()[10])
                              {
                                case 'l':
                                    switch (json_string.getData()[11])
                                      {
                                        case 'b':
                                            if (String.Compare(json_string.getData(), 12, "ums", 0, 3, false) == 0)
                                              {
                                                if (json_string.getData().Length == 15)
                                                  {
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_SearchForAlbums;
                                                        goto open_enum_is_done;
                                                      }
                                                  }
                                                switch (json_string.getData()[15])
                                                  {
                                                    case 'B':
                                                        if ((String.Compare(json_string.getData(), 16, "yArtist", 0, 7, false) == 0) && (json_string.getData().Length == 23))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_SearchForAlbumsByArtist;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'l':
                                            if ((String.Compare(json_string.getData(), 12, "AlbumsByArtist", 0, 14, false) == 0) && (json_string.getData().Length == 26))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_SearchForAllAlbumsByArtist;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'r':
                                    if (String.Compare(json_string.getData(), 11, "tists", 0, 5, false) == 0)
                                      {
                                        if (json_string.getData().Length == 16)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SearchForArtists;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[16])
                                          {
                                            case 'B':
                                                if ((String.Compare(json_string.getData(), 17, "yTrack", 0, 6, false) == 0) && (json_string.getData().Length == 23))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_SearchForArtistsByTrack;
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
                        case 'M':
                            if ((String.Compare(json_string.getData(), 10, "usicEntities", 0, 12, false) == 0) && (json_string.getData().Length == 22))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SearchForMusicEntities;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'T':
                            if (String.Compare(json_string.getData(), 10, "racks", 0, 5, false) == 0)
                              {
                                if (json_string.getData().Length == 15)
                                  {
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_SearchForTracks;
                                        goto open_enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[15])
                                  {
                                    case 'B':
                                        if (String.Compare(json_string.getData(), 16, "yArtist", 0, 7, false) == 0)
                                          {
                                            if (json_string.getData().Length == 23)
                                              {
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_SearchForTracksByArtist;
                                                    goto open_enum_is_done;
                                                  }
                                              }
                                            switch (json_string.getData()[23])
                                              {
                                                case 'I':
                                                    if ((String.Compare(json_string.getData(), 24, "mplied", 0, 6, false) == 0) && (json_string.getData().Length == 30))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_SearchForTracksByArtistImplied;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'O':
                                        if ((String.Compare(json_string.getData(), 16, "nAlbum", 0, 6, false) == 0) && (json_string.getData().Length == 22))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SearchForTracksOnAlbum;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setValue(the_open_enum);
      }


    public MusicSearchTypeJSON()
      {
        flagHasValue = false;
      }

    public MusicSearchTypeJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public MusicSearchTypeJSON(string init_value)
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

    public MusicSearchTypeJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_SearchForTracksOnAlbum:
                    handler.string_value("SearchForTracksOnAlbum");
                    break;
                case TypeValueKnownValues.Value_SearchForTracksByArtist:
                    handler.string_value("SearchForTracksByArtist");
                    break;
                case TypeValueKnownValues.Value_SearchForTracksByArtistImplied:
                    handler.string_value("SearchForTracksByArtistImplied");
                    break;
                case TypeValueKnownValues.Value_SearchForTracks:
                    handler.string_value("SearchForTracks");
                    break;
                case TypeValueKnownValues.Value_SearchForArtists:
                    handler.string_value("SearchForArtists");
                    break;
                case TypeValueKnownValues.Value_SearchForArtistsByTrack:
                    handler.string_value("SearchForArtistsByTrack");
                    break;
                case TypeValueKnownValues.Value_SearchForAlbums:
                    handler.string_value("SearchForAlbums");
                    break;
                case TypeValueKnownValues.Value_SearchForAlbumsByArtist:
                    handler.string_value("SearchForAlbumsByArtist");
                    break;
                case TypeValueKnownValues.Value_SearchForAllAlbumsByArtist:
                    handler.string_value("SearchForAllAlbumsByArtist");
                    break;
                case TypeValueKnownValues.Value_SearchForMusicEntities:
                    handler.string_value("SearchForMusicEntities");
                    break;
                case TypeValueKnownValues.Value_NONE:
                    handler.string_value("NONE");
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
                case TypeValueKnownValues.Value_SearchForTracksOnAlbum:
                    handler.string_value("SearchForTracksOnAlbum");
                    break;
                case TypeValueKnownValues.Value_SearchForTracksByArtist:
                    handler.string_value("SearchForTracksByArtist");
                    break;
                case TypeValueKnownValues.Value_SearchForTracksByArtistImplied:
                    handler.string_value("SearchForTracksByArtistImplied");
                    break;
                case TypeValueKnownValues.Value_SearchForTracks:
                    handler.string_value("SearchForTracks");
                    break;
                case TypeValueKnownValues.Value_SearchForArtists:
                    handler.string_value("SearchForArtists");
                    break;
                case TypeValueKnownValues.Value_SearchForArtistsByTrack:
                    handler.string_value("SearchForArtistsByTrack");
                    break;
                case TypeValueKnownValues.Value_SearchForAlbums:
                    handler.string_value("SearchForAlbums");
                    break;
                case TypeValueKnownValues.Value_SearchForAlbumsByArtist:
                    handler.string_value("SearchForAlbumsByArtist");
                    break;
                case TypeValueKnownValues.Value_SearchForAllAlbumsByArtist:
                    handler.string_value("SearchForAllAlbumsByArtist");
                    break;
                case TypeValueKnownValues.Value_SearchForMusicEntities:
                    handler.string_value("SearchForMusicEntities");
                    break;
                case TypeValueKnownValues.Value_NONE:
                    handler.string_value("NONE");
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

    public static MusicSearchTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicSearchTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchType", ignore_extras);
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
    public static MusicSearchTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicSearchTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicSearchTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchType", ignore_extras);
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
    public static MusicSearchTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicSearchTypeJSON from_text(string text, bool ignore_extras)
      {
        MusicSearchTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchType", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicSearchTypeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicSearchTypeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicSearchTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchType", ignore_extras);
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
            MusicSearchTypeJSON result = new MusicSearchTypeJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(MusicSearchTypeJSON new_result);
        public Generator(bool ignore_extras) : base("Type MusicSearchType")
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
        protected override void handle_result(MusicSearchTypeJSON  result)
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
        public MusicSearchTypeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicSearchTypeJSON  result)
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
    protected virtual void handle_result(List<MusicSearchTypeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicSearchTypeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicSearchTypeJSON>();
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
    public List<MusicSearchTypeJSON> value;
  };
  };
