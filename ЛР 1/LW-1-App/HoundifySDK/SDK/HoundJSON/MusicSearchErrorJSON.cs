/* file "MusicSearchErrorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicSearchErrorJSON : JSONBase
  {
    public enum TypeSearchErrorTypeKnownValues
      {
        SearchErrorType_SONG_NOT_FOUND_BY_ARTIST,
        SearchErrorType_TARGET_TYPE_NOT_FOUND,
        SearchErrorType__none
      };
    public struct TypeSearchErrorType
      {
        public bool in_known_list;
        public string string_value;
        public TypeSearchErrorTypeKnownValues list_value;
      };

    public static TypeSearchErrorTypeKnownValues  stringToSearchErrorType(string chars)
      {
        switch (chars[0])
          {
            case 'S':
                if ((String.Compare(chars, 1, "ONG_NOT_FOUND_BY_ARTIST", 0, 23, false) == 0) && (chars.Length == 24))
                    return TypeSearchErrorTypeKnownValues.SearchErrorType_SONG_NOT_FOUND_BY_ARTIST;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "ARGET_TYPE_NOT_FOUND", 0, 20, false) == 0) && (chars.Length == 21))
                    return TypeSearchErrorTypeKnownValues.SearchErrorType_TARGET_TYPE_NOT_FOUND;
                break;
            default:
                break;
          }
        return TypeSearchErrorTypeKnownValues.SearchErrorType__none;
      }

    public static string  stringFromSearchErrorType(TypeSearchErrorTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeSearchErrorTypeKnownValues.SearchErrorType_SONG_NOT_FOUND_BY_ARTIST:
                return "SONG_NOT_FOUND_BY_ARTIST";
            case TypeSearchErrorTypeKnownValues.SearchErrorType_TARGET_TYPE_NOT_FOUND:
                return "TARGET_TYPE_NOT_FOUND";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasSearchErrorType;
    private TypeSearchErrorType storeSearchErrorType;
    private bool flagHasArtist;
    private MusicArtistBaseJSON  storeArtist;
    private bool flagHasTrack;
    private MusicTrackBaseJSON  storeTrack;


    private void  fromJSONSearchErrorType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SearchErrorType of MusicSearchErrorJSON is not a string.");
        TypeSearchErrorType the_open_enum = new TypeSearchErrorType();
        switch (json_string.getData()[0])
          {
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "ONG_NOT_FOUND_BY_ARTIST", 0, 23, false) == 0) && (json_string.getData().Length == 24))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSearchErrorTypeKnownValues.SearchErrorType_SONG_NOT_FOUND_BY_ARTIST;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "ARGET_TYPE_NOT_FOUND", 0, 20, false) == 0) && (json_string.getData().Length == 21))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSearchErrorTypeKnownValues.SearchErrorType_TARGET_TYPE_NOT_FOUND;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setSearchErrorType(the_open_enum);
      }


    private void  fromJSONArtist(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicArtistBaseJSON convert_classy = MusicArtistBaseJSON.from_json(json_value, ignore_extras, true);
        setArtist(convert_classy);
      }


    private void  fromJSONTrack(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicTrackBaseJSON convert_classy = MusicTrackBaseJSON.from_json(json_value, ignore_extras, true);
        setTrack(convert_classy);
      }


    public MusicSearchErrorJSON()
      {
        flagHasSearchErrorType = false;
        flagHasArtist = false;
        flagHasTrack = false;
      }

    public bool  hasSearchErrorType()
      {
        return flagHasSearchErrorType;
      }

    public TypeSearchErrorType  getSearchErrorType()
      {
        Debug.Assert(flagHasSearchErrorType);
        return storeSearchErrorType;
      }

    public string  getSearchErrorTypeAsString()
      {
        TypeSearchErrorType result = getSearchErrorType();
        if (result.in_known_list)
            return stringFromSearchErrorType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasArtist()
      {
        return flagHasArtist;
      }

    public MusicArtistBaseJSON   getArtist()
      {
        Debug.Assert(flagHasArtist);
        return storeArtist;
      }

    public bool  hasTrack()
      {
        return flagHasTrack;
      }

    public MusicTrackBaseJSON   getTrack()
      {
        Debug.Assert(flagHasTrack);
        return storeTrack;
      }



    public void setSearchErrorType(TypeSearchErrorType new_value)
      {
        flagHasSearchErrorType = true;
        storeSearchErrorType = new_value;
      }
    public void setSearchErrorType(string chars)
      {
        TypeSearchErrorTypeKnownValues known = stringToSearchErrorType(chars);
        TypeSearchErrorType new_value = new TypeSearchErrorType();
        if (known == TypeSearchErrorTypeKnownValues.SearchErrorType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSearchErrorType(new_value);
      }
    public void setSearchErrorType(TypeSearchErrorTypeKnownValues new_value)
      {
        TypeSearchErrorType new_full_value = new TypeSearchErrorType();
        Debug.Assert(new_value != TypeSearchErrorTypeKnownValues.SearchErrorType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setSearchErrorType(new_full_value);
      }
    public void unsetSearchErrorType()
      {
        flagHasSearchErrorType = false;
      }
    public void setArtist(MusicArtistBaseJSON  new_value)
      {
        if (flagHasArtist)
          {
          }
        flagHasArtist = true;
        storeArtist = new_value;
      }
    public void unsetArtist()
      {
        if (flagHasArtist)
          {
          }
        flagHasArtist = false;
      }
    public void setTrack(MusicTrackBaseJSON  new_value)
      {
        if (flagHasTrack)
          {
          }
        flagHasTrack = true;
        storeTrack = new_value;
      }
    public void unsetTrack()
      {
        if (flagHasTrack)
          {
          }
        flagHasTrack = false;
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
        Debug.Assert(partial_allowed || flagHasSearchErrorType);
        if (flagHasSearchErrorType)
          {
            handler.start_pair("SearchErrorType");
            if (storeSearchErrorType.in_known_list)
              {
                switch (storeSearchErrorType.list_value)
                  {
                    case TypeSearchErrorTypeKnownValues.SearchErrorType_SONG_NOT_FOUND_BY_ARTIST:
                        handler.string_value("SONG_NOT_FOUND_BY_ARTIST");
                        break;
                    case TypeSearchErrorTypeKnownValues.SearchErrorType_TARGET_TYPE_NOT_FOUND:
                        handler.string_value("TARGET_TYPE_NOT_FOUND");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeSearchErrorType.string_value);
              }
          }
        if (flagHasArtist)
          {
            handler.start_pair("Artist");
            if (partial_allowed)
                storeArtist.write_partial_as_json(handler);
            else
                storeArtist.write_as_json(handler);
          }
        if (flagHasTrack)
          {
            handler.start_pair("Track");
            if (partial_allowed)
                storeTrack.write_partial_as_json(handler);
            else
                storeTrack.write_as_json(handler);
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
        if (!(hasSearchErrorType()))
          {
            return "When parsing the object for %what%, the \"SearchErrorType\" field was missing.";
          }
        return null;
      }

    public static MusicSearchErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicSearchErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchError", ignore_extras);
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
    public static MusicSearchErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicSearchErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicSearchErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchError", ignore_extras);
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
    public static MusicSearchErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicSearchErrorJSON from_text(string text, bool ignore_extras)
      {
        MusicSearchErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchError", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicSearchErrorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicSearchErrorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicSearchErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchError", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorSearchErrorType : JSONStringGenerator
          {
            protected FieldGeneratorSearchErrorType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSearchErrorType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeSearchErrorTypeKnownValues known = stringToSearchErrorType(result);
                TypeSearchErrorType new_value = new TypeSearchErrorType();
                if (known == TypeSearchErrorTypeKnownValues.SearchErrorType__none)
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
            protected abstract void handle_result(TypeSearchErrorType result);
          };
    private class FieldHoldingGeneratorSearchErrorType : FieldGeneratorSearchErrorType
  {
    protected override void handle_result(TypeSearchErrorType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSearchErrorType(String what)
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
    public TypeSearchErrorType value;
  };
    private class FieldHoldingArrayGeneratorSearchErrorType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSearchErrorType
      {
        private FieldHoldingArrayGeneratorSearchErrorType top;

        protected override void handle_result(TypeSearchErrorType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSearchErrorType init_top)
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
    protected virtual void handle_result(List<TypeSearchErrorType> result)
      {
      }

    public FieldHoldingArrayGeneratorSearchErrorType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSearchErrorType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSearchErrorType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSearchErrorType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSearchErrorType> value;
  };
        private FieldHoldingGeneratorSearchErrorType fieldGeneratorSearchErrorType;
        private MusicArtistBaseJSON.HoldingGenerator fieldGeneratorArtist;
        private MusicTrackBaseJSON.HoldingGenerator fieldGeneratorTrack;

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
            MusicSearchErrorJSON result = new MusicSearchErrorJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MusicSearchErrorJSON result)
          {
            if (fieldGeneratorSearchErrorType.have_value)
              {
                result.setSearchErrorType(fieldGeneratorSearchErrorType.value);
                fieldGeneratorSearchErrorType.have_value = false;
              }
            else if ((!(result.hasSearchErrorType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SearchErrorType\" field was missing.");
              }
            if (fieldGeneratorArtist.have_value)
              {
                result.setArtist(fieldGeneratorArtist.value);
                fieldGeneratorArtist.have_value = false;
              }
            if (fieldGeneratorTrack.have_value)
              {
                result.setTrack(fieldGeneratorTrack.value);
                fieldGeneratorTrack.have_value = false;
              }
          }
        protected abstract void handle_result(MusicSearchErrorJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "rtist", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorArtist;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "earchErrorType", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorSearchErrorType;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "rack", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTrack;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSearchErrorType = new FieldHoldingGeneratorSearchErrorType("field \"SearchErrorType\" of the MusicSearchError class");
            fieldGeneratorArtist = new MusicArtistBaseJSON.HoldingGenerator("field \"Artist\" of the MusicSearchError class", ignore_extras);
            fieldGeneratorTrack = new MusicTrackBaseJSON.HoldingGenerator("field \"Track\" of the MusicSearchError class", ignore_extras);
            set_what("the MusicSearchError class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSearchErrorType = new FieldHoldingGeneratorSearchErrorType("field \"SearchErrorType\" of the MusicSearchError class");
            fieldGeneratorArtist = new MusicArtistBaseJSON.HoldingGenerator("field \"Artist\" of the MusicSearchError class", false);
            fieldGeneratorTrack = new MusicTrackBaseJSON.HoldingGenerator("field \"Track\" of the MusicSearchError class", false);
            set_what("the MusicSearchError class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSearchErrorType.reset();
            fieldGeneratorArtist.reset();
            fieldGeneratorTrack.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorArtist.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTrack.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorArtist.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTrack.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicSearchErrorJSON  result)
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
        public MusicSearchErrorJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicSearchErrorJSON  result)
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
    protected virtual void handle_result(List<MusicSearchErrorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicSearchErrorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicSearchErrorJSON>();
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
    public List<MusicSearchErrorJSON> value;
  };
  };
