/* file "MusicSearchResultsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MusicSearchResultsJSON : JSONBase
  {
    public enum TypeLatestListTypeKnownValues
      {
        LatestListType_Track,
        LatestListType_Artist,
        LatestListType_Album,
        LatestListType__none
      };
    public struct TypeLatestListType
      {
        public bool in_known_list;
        public string string_value;
        public TypeLatestListTypeKnownValues list_value;
      };

    public static TypeLatestListTypeKnownValues  stringToLatestListType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'l':
                        if ((String.Compare(chars, 2, "bum", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeLatestListTypeKnownValues.LatestListType_Album;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "tist", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeLatestListTypeKnownValues.LatestListType_Artist;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(chars, 1, "rack", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeLatestListTypeKnownValues.LatestListType_Track;
                break;
            default:
                break;
          }
        return TypeLatestListTypeKnownValues.LatestListType__none;
      }

    public static string  stringFromLatestListType(TypeLatestListTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeLatestListTypeKnownValues.LatestListType_Track:
                return "Track";
            case TypeLatestListTypeKnownValues.LatestListType_Artist:
                return "Artist";
            case TypeLatestListTypeKnownValues.LatestListType_Album:
                return "Album";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasTrackResults;
    private List< MusicTrackResultJSON  > storeTrackResults;
    private bool flagHasArtistResults;
    private List< MusicArtistResultJSON  > storeArtistResults;
    private bool flagHasAlbumResults;
    private List< MusicAlbumResultJSON  > storeAlbumResults;
    private bool flagHasLatestListType;
    private TypeLatestListType storeLatestListType;
    private bool flagHasLastTrackListIndex;
    private BigInteger storeLastTrackListIndex;
    private bool flagHasLastArtistListIndex;
    private BigInteger storeLastArtistListIndex;
    private bool flagHasLastAlbumListIndex;
    private BigInteger storeLastAlbumListIndex;


    private void  fromJSONTrackResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field TrackResults of MusicSearchResultsJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field TrackResults of MusicSearchResultsJSON has too few elements.");
        List< MusicTrackResultJSON  > vector_TrackResults1 = new List< MusicTrackResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicTrackResultJSON convert_classy = MusicTrackResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_TrackResults1.Add(convert_classy);
          }
        Debug.Assert(vector_TrackResults1.Count >= 1);
        initTrackResults();
        for (int num1 = 0; num1 < vector_TrackResults1.Count; ++num1)
            appendTrackResults(vector_TrackResults1[num1]);
        for (int num1 = 0; num1 < vector_TrackResults1.Count; ++num1)
          {
          }
      }


    private void  fromJSONArtistResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ArtistResults of MusicSearchResultsJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ArtistResults of MusicSearchResultsJSON has too few elements.");
        List< MusicArtistResultJSON  > vector_ArtistResults1 = new List< MusicArtistResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicArtistResultJSON convert_classy = MusicArtistResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ArtistResults1.Add(convert_classy);
          }
        Debug.Assert(vector_ArtistResults1.Count >= 1);
        initArtistResults();
        for (int num2 = 0; num2 < vector_ArtistResults1.Count; ++num2)
            appendArtistResults(vector_ArtistResults1[num2]);
        for (int num1 = 0; num1 < vector_ArtistResults1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAlbumResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AlbumResults of MusicSearchResultsJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field AlbumResults of MusicSearchResultsJSON has too few elements.");
        List< MusicAlbumResultJSON  > vector_AlbumResults1 = new List< MusicAlbumResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicAlbumResultJSON convert_classy = MusicAlbumResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AlbumResults1.Add(convert_classy);
          }
        Debug.Assert(vector_AlbumResults1.Count >= 1);
        initAlbumResults();
        for (int num3 = 0; num3 < vector_AlbumResults1.Count; ++num3)
            appendAlbumResults(vector_AlbumResults1[num3]);
        for (int num1 = 0; num1 < vector_AlbumResults1.Count; ++num1)
          {
          }
      }


    private void  fromJSONLatestListType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LatestListType of MusicSearchResultsJSON is not a string.");
        TypeLatestListType the_open_enum = new TypeLatestListType();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "bum", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeLatestListTypeKnownValues.LatestListType_Album;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "tist", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeLatestListTypeKnownValues.LatestListType_Artist;
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
                        the_open_enum.list_value = TypeLatestListTypeKnownValues.LatestListType_Track;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setLatestListType(the_open_enum);
      }


    private void  fromJSONLastTrackListIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field LastTrackListIndex of MusicSearchResultsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field LastTrackListIndex of MusicSearchResultsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setLastTrackListIndex(extracted_integer);
      }


    private void  fromJSONLastArtistListIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field LastArtistListIndex of MusicSearchResultsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field LastArtistListIndex of MusicSearchResultsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setLastArtistListIndex(extracted_integer);
      }


    private void  fromJSONLastAlbumListIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field LastAlbumListIndex of MusicSearchResultsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field LastAlbumListIndex of MusicSearchResultsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setLastAlbumListIndex(extracted_integer);
      }


    public MusicSearchResultsJSON()
      {
        flagHasTrackResults = false;
        flagHasArtistResults = false;
        flagHasAlbumResults = false;
        flagHasLatestListType = false;
        flagHasLastTrackListIndex = false;
        flagHasLastArtistListIndex = false;
        flagHasLastAlbumListIndex = false;
        storeTrackResults = new List< MusicTrackResultJSON  >();
        storeArtistResults = new List< MusicArtistResultJSON  >();
        storeAlbumResults = new List< MusicAlbumResultJSON  >();
      }

    public bool  hasTrackResults()
      {
        return flagHasTrackResults;
      }

    public int  countOfTrackResults()
      {
        Debug.Assert(flagHasTrackResults);
        return storeTrackResults.Count;
      }

    public MusicTrackResultJSON   elementOfTrackResults(int element_num)
      {
        Debug.Assert(flagHasTrackResults);
        return storeTrackResults[element_num];
      }

    public List< MusicTrackResultJSON  >  getTrackResults()
      {
        Debug.Assert(flagHasTrackResults);
        return storeTrackResults;
      }

    public bool  hasArtistResults()
      {
        return flagHasArtistResults;
      }

    public int  countOfArtistResults()
      {
        Debug.Assert(flagHasArtistResults);
        return storeArtistResults.Count;
      }

    public MusicArtistResultJSON   elementOfArtistResults(int element_num)
      {
        Debug.Assert(flagHasArtistResults);
        return storeArtistResults[element_num];
      }

    public List< MusicArtistResultJSON  >  getArtistResults()
      {
        Debug.Assert(flagHasArtistResults);
        return storeArtistResults;
      }

    public bool  hasAlbumResults()
      {
        return flagHasAlbumResults;
      }

    public int  countOfAlbumResults()
      {
        Debug.Assert(flagHasAlbumResults);
        return storeAlbumResults.Count;
      }

    public MusicAlbumResultJSON   elementOfAlbumResults(int element_num)
      {
        Debug.Assert(flagHasAlbumResults);
        return storeAlbumResults[element_num];
      }

    public List< MusicAlbumResultJSON  >  getAlbumResults()
      {
        Debug.Assert(flagHasAlbumResults);
        return storeAlbumResults;
      }

    public bool  hasLatestListType()
      {
        return flagHasLatestListType;
      }

    public TypeLatestListType  getLatestListType()
      {
        Debug.Assert(flagHasLatestListType);
        return storeLatestListType;
      }

    public string  getLatestListTypeAsString()
      {
        TypeLatestListType result = getLatestListType();
        if (result.in_known_list)
            return stringFromLatestListType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasLastTrackListIndex()
      {
        return flagHasLastTrackListIndex;
      }

    public BigInteger  getLastTrackListIndex()
      {
        Debug.Assert(flagHasLastTrackListIndex);
        return storeLastTrackListIndex;
      }

    public bool  hasLastArtistListIndex()
      {
        return flagHasLastArtistListIndex;
      }

    public BigInteger  getLastArtistListIndex()
      {
        Debug.Assert(flagHasLastArtistListIndex);
        return storeLastArtistListIndex;
      }

    public bool  hasLastAlbumListIndex()
      {
        return flagHasLastAlbumListIndex;
      }

    public BigInteger  getLastAlbumListIndex()
      {
        Debug.Assert(flagHasLastAlbumListIndex);
        return storeLastAlbumListIndex;
      }



    public void initTrackResults()
      {
        if (flagHasTrackResults)
          {
            for (int num1 = 0; num1 < storeTrackResults.Count; ++num1)
              {
              }
          }
        flagHasTrackResults = true;
        storeTrackResults.Clear();
      }
    public void appendTrackResults(MusicTrackResultJSON  to_append)
      {
        if (!flagHasTrackResults)
          {
            flagHasTrackResults = true;
            storeTrackResults.Clear();
          }
        Debug.Assert(flagHasTrackResults);
        storeTrackResults.Add(to_append);
      }
    public void unsetTrackResults()
      {
        if (flagHasTrackResults)
          {
            for (int num2 = 0; num2 < storeTrackResults.Count; ++num2)
              {
              }
          }
        flagHasTrackResults = false;
        storeTrackResults.Clear();
      }
    public void initArtistResults()
      {
        if (flagHasArtistResults)
          {
            for (int num3 = 0; num3 < storeArtistResults.Count; ++num3)
              {
              }
          }
        flagHasArtistResults = true;
        storeArtistResults.Clear();
      }
    public void appendArtistResults(MusicArtistResultJSON  to_append)
      {
        if (!flagHasArtistResults)
          {
            flagHasArtistResults = true;
            storeArtistResults.Clear();
          }
        Debug.Assert(flagHasArtistResults);
        storeArtistResults.Add(to_append);
      }
    public void unsetArtistResults()
      {
        if (flagHasArtistResults)
          {
            for (int num4 = 0; num4 < storeArtistResults.Count; ++num4)
              {
              }
          }
        flagHasArtistResults = false;
        storeArtistResults.Clear();
      }
    public void initAlbumResults()
      {
        if (flagHasAlbumResults)
          {
            for (int num5 = 0; num5 < storeAlbumResults.Count; ++num5)
              {
              }
          }
        flagHasAlbumResults = true;
        storeAlbumResults.Clear();
      }
    public void appendAlbumResults(MusicAlbumResultJSON  to_append)
      {
        if (!flagHasAlbumResults)
          {
            flagHasAlbumResults = true;
            storeAlbumResults.Clear();
          }
        Debug.Assert(flagHasAlbumResults);
        storeAlbumResults.Add(to_append);
      }
    public void unsetAlbumResults()
      {
        if (flagHasAlbumResults)
          {
            for (int num6 = 0; num6 < storeAlbumResults.Count; ++num6)
              {
              }
          }
        flagHasAlbumResults = false;
        storeAlbumResults.Clear();
      }
    public void setLatestListType(TypeLatestListType new_value)
      {
        flagHasLatestListType = true;
        storeLatestListType = new_value;
      }
    public void setLatestListType(string chars)
      {
        TypeLatestListTypeKnownValues known = stringToLatestListType(chars);
        TypeLatestListType new_value = new TypeLatestListType();
        if (known == TypeLatestListTypeKnownValues.LatestListType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setLatestListType(new_value);
      }
    public void setLatestListType(TypeLatestListTypeKnownValues new_value)
      {
        TypeLatestListType new_full_value = new TypeLatestListType();
        Debug.Assert(new_value != TypeLatestListTypeKnownValues.LatestListType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setLatestListType(new_full_value);
      }
    public void unsetLatestListType()
      {
        flagHasLatestListType = false;
      }
    public void setLastTrackListIndex(BigInteger new_value)
      {
        flagHasLastTrackListIndex = true;
        storeLastTrackListIndex = new_value;
      }
    public void unsetLastTrackListIndex()
      {
        flagHasLastTrackListIndex = false;
      }
    public void setLastArtistListIndex(BigInteger new_value)
      {
        flagHasLastArtistListIndex = true;
        storeLastArtistListIndex = new_value;
      }
    public void unsetLastArtistListIndex()
      {
        flagHasLastArtistListIndex = false;
      }
    public void setLastAlbumListIndex(BigInteger new_value)
      {
        flagHasLastAlbumListIndex = true;
        storeLastAlbumListIndex = new_value;
      }
    public void unsetLastAlbumListIndex()
      {
        flagHasLastAlbumListIndex = false;
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
        if (flagHasTrackResults)
          {
            handler.start_pair("TrackResults");
            Debug.Assert(storeTrackResults.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeTrackResults.Count; ++num1)
              {
                if (partial_allowed)
                    storeTrackResults[num1].write_partial_as_json(handler);
                else
                    storeTrackResults[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasArtistResults)
          {
            handler.start_pair("ArtistResults");
            Debug.Assert(storeArtistResults.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeArtistResults.Count; ++num2)
              {
                if (partial_allowed)
                    storeArtistResults[num2].write_partial_as_json(handler);
                else
                    storeArtistResults[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAlbumResults)
          {
            handler.start_pair("AlbumResults");
            Debug.Assert(storeAlbumResults.Count >= 1);
            handler.start_array();
            for (int num3 = 0; num3 < storeAlbumResults.Count; ++num3)
              {
                if (partial_allowed)
                    storeAlbumResults[num3].write_partial_as_json(handler);
                else
                    storeAlbumResults[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasLatestListType);
        if (flagHasLatestListType)
          {
            handler.start_pair("LatestListType");
            if (storeLatestListType.in_known_list)
              {
                switch (storeLatestListType.list_value)
                  {
                    case TypeLatestListTypeKnownValues.LatestListType_Track:
                        handler.string_value("Track");
                        break;
                    case TypeLatestListTypeKnownValues.LatestListType_Artist:
                        handler.string_value("Artist");
                        break;
                    case TypeLatestListTypeKnownValues.LatestListType_Album:
                        handler.string_value("Album");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeLatestListType.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasLastTrackListIndex);
        if (flagHasLastTrackListIndex)
          {
            handler.start_pair("LastTrackListIndex");
            handler.number_value(storeLastTrackListIndex);
          }
        Debug.Assert(partial_allowed || flagHasLastArtistListIndex);
        if (flagHasLastArtistListIndex)
          {
            handler.start_pair("LastArtistListIndex");
            handler.number_value(storeLastArtistListIndex);
          }
        Debug.Assert(partial_allowed || flagHasLastAlbumListIndex);
        if (flagHasLastAlbumListIndex)
          {
            handler.start_pair("LastAlbumListIndex");
            handler.number_value(storeLastAlbumListIndex);
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
        if (!(hasLatestListType()))
          {
            return "When parsing the object for %what%, the \"LatestListType\" field was missing.";
          }
        if (!(hasLastTrackListIndex()))
          {
            return "When parsing the object for %what%, the \"LastTrackListIndex\" field was missing.";
          }
        if (!(hasLastArtistListIndex()))
          {
            return "When parsing the object for %what%, the \"LastArtistListIndex\" field was missing.";
          }
        if (!(hasLastAlbumListIndex()))
          {
            return "When parsing the object for %what%, the \"LastAlbumListIndex\" field was missing.";
          }
        return null;
      }

    public static MusicSearchResultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicSearchResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchResults", ignore_extras);
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
    public static MusicSearchResultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicSearchResultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicSearchResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchResults", ignore_extras);
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
    public static MusicSearchResultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicSearchResultsJSON from_text(string text, bool ignore_extras)
      {
        MusicSearchResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchResults", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicSearchResultsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicSearchResultsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicSearchResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchResults", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MusicTrackResultJSON.HoldingArrayGenerator fieldGeneratorTrackResults;
        private MusicArtistResultJSON.HoldingArrayGenerator fieldGeneratorArtistResults;
        private MusicAlbumResultJSON.HoldingArrayGenerator fieldGeneratorAlbumResults;
    private abstract class FieldGeneratorLatestListType : JSONStringGenerator
          {
            protected FieldGeneratorLatestListType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorLatestListType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeLatestListTypeKnownValues known = stringToLatestListType(result);
                TypeLatestListType new_value = new TypeLatestListType();
                if (known == TypeLatestListTypeKnownValues.LatestListType__none)
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
            protected abstract void handle_result(TypeLatestListType result);
          };
    private class FieldHoldingGeneratorLatestListType : FieldGeneratorLatestListType
  {
    protected override void handle_result(TypeLatestListType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorLatestListType(String what)
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
    public TypeLatestListType value;
  };
    private class FieldHoldingArrayGeneratorLatestListType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLatestListType
      {
        private FieldHoldingArrayGeneratorLatestListType top;

        protected override void handle_result(TypeLatestListType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLatestListType init_top)
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
    protected virtual void handle_result(List<TypeLatestListType> result)
      {
      }

    public FieldHoldingArrayGeneratorLatestListType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLatestListType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLatestListType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLatestListType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLatestListType> value;
  };
        private FieldHoldingGeneratorLatestListType fieldGeneratorLatestListType;
    private class FieldHoldingGeneratorLastTrackListIndex : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorLastTrackListIndex(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorLastTrackListIndex : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorLastTrackListIndex(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorLastTrackListIndex fieldGeneratorLastTrackListIndex;
    private class FieldHoldingGeneratorLastArtistListIndex : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorLastArtistListIndex(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorLastArtistListIndex : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorLastArtistListIndex(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorLastArtistListIndex fieldGeneratorLastArtistListIndex;
    private class FieldHoldingGeneratorLastAlbumListIndex : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorLastAlbumListIndex(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorLastAlbumListIndex : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorLastAlbumListIndex(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorLastAlbumListIndex fieldGeneratorLastAlbumListIndex;

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
            MusicSearchResultsJSON result = new MusicSearchResultsJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MusicSearchResultsJSON result)
          {
            if (fieldGeneratorTrackResults.have_value)
              {
                result.initTrackResults();
                int count = fieldGeneratorTrackResults.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTrackResults(fieldGeneratorTrackResults.value[num]);
                  }
                fieldGeneratorTrackResults.value.Clear();
                fieldGeneratorTrackResults.have_value = false;
              }
            if (fieldGeneratorArtistResults.have_value)
              {
                result.initArtistResults();
                int count = fieldGeneratorArtistResults.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendArtistResults(fieldGeneratorArtistResults.value[num]);
                  }
                fieldGeneratorArtistResults.value.Clear();
                fieldGeneratorArtistResults.have_value = false;
              }
            if (fieldGeneratorAlbumResults.have_value)
              {
                result.initAlbumResults();
                int count = fieldGeneratorAlbumResults.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAlbumResults(fieldGeneratorAlbumResults.value[num]);
                  }
                fieldGeneratorAlbumResults.value.Clear();
                fieldGeneratorAlbumResults.have_value = false;
              }
            if (fieldGeneratorLatestListType.have_value)
              {
                result.setLatestListType(fieldGeneratorLatestListType.value);
                fieldGeneratorLatestListType.have_value = false;
              }
            else if ((!(result.hasLatestListType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LatestListType\" field was missing.");
              }
            if (fieldGeneratorLastTrackListIndex.have_value)
              {
                result.setLastTrackListIndex(fieldGeneratorLastTrackListIndex.value);
                fieldGeneratorLastTrackListIndex.have_value = false;
              }
            else if ((!(result.hasLastTrackListIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LastTrackListIndex\" field was missing.");
              }
            if (fieldGeneratorLastArtistListIndex.have_value)
              {
                result.setLastArtistListIndex(fieldGeneratorLastArtistListIndex.value);
                fieldGeneratorLastArtistListIndex.have_value = false;
              }
            else if ((!(result.hasLastArtistListIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LastArtistListIndex\" field was missing.");
              }
            if (fieldGeneratorLastAlbumListIndex.have_value)
              {
                result.setLastAlbumListIndex(fieldGeneratorLastAlbumListIndex.value);
                fieldGeneratorLastAlbumListIndex.have_value = false;
              }
            else if ((!(result.hasLastAlbumListIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LastAlbumListIndex\" field was missing.");
              }
          }
        protected abstract void handle_result(MusicSearchResultsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "bumResults", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorAlbumResults;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "tistResults", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorArtistResults;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "a", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 's':
                                if (String.Compare(field_name, 3, "t", 0, 1, false) == 0)
                                  {
                                    switch (field_name[4])
                                      {
                                        case 'A':
                                            switch (field_name[5])
                                              {
                                                case 'l':
                                                    if ((String.Compare(field_name, 6, "bumListIndex", 0, 12, false) == 0) && (field_name.Length == 18))
                                                        return fieldGeneratorLastAlbumListIndex;
                                                    break;
                                                case 'r':
                                                    if ((String.Compare(field_name, 6, "tistListIndex", 0, 13, false) == 0) && (field_name.Length == 19))
                                                        return fieldGeneratorLastArtistListIndex;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 5, "rackListIndex", 0, 13, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorLastTrackListIndex;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 't':
                                if ((String.Compare(field_name, 3, "estListType", 0, 11, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorLatestListType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "rackResults", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorTrackResults;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTrackResults = new MusicTrackResultJSON.HoldingArrayGenerator("field \"TrackResults\" of the MusicSearchResults class", ignore_extras);
            fieldGeneratorArtistResults = new MusicArtistResultJSON.HoldingArrayGenerator("field \"ArtistResults\" of the MusicSearchResults class", ignore_extras);
            fieldGeneratorAlbumResults = new MusicAlbumResultJSON.HoldingArrayGenerator("field \"AlbumResults\" of the MusicSearchResults class", ignore_extras);
            fieldGeneratorLatestListType = new FieldHoldingGeneratorLatestListType("field \"LatestListType\" of the MusicSearchResults class");
            fieldGeneratorLastTrackListIndex = new FieldHoldingGeneratorLastTrackListIndex("field \"LastTrackListIndex\" of the MusicSearchResults class");
            fieldGeneratorLastArtistListIndex = new FieldHoldingGeneratorLastArtistListIndex("field \"LastArtistListIndex\" of the MusicSearchResults class");
            fieldGeneratorLastAlbumListIndex = new FieldHoldingGeneratorLastAlbumListIndex("field \"LastAlbumListIndex\" of the MusicSearchResults class");
            set_what("the MusicSearchResults class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTrackResults = new MusicTrackResultJSON.HoldingArrayGenerator("field \"TrackResults\" of the MusicSearchResults class", false);
            fieldGeneratorArtistResults = new MusicArtistResultJSON.HoldingArrayGenerator("field \"ArtistResults\" of the MusicSearchResults class", false);
            fieldGeneratorAlbumResults = new MusicAlbumResultJSON.HoldingArrayGenerator("field \"AlbumResults\" of the MusicSearchResults class", false);
            fieldGeneratorLatestListType = new FieldHoldingGeneratorLatestListType("field \"LatestListType\" of the MusicSearchResults class");
            fieldGeneratorLastTrackListIndex = new FieldHoldingGeneratorLastTrackListIndex("field \"LastTrackListIndex\" of the MusicSearchResults class");
            fieldGeneratorLastArtistListIndex = new FieldHoldingGeneratorLastArtistListIndex("field \"LastArtistListIndex\" of the MusicSearchResults class");
            fieldGeneratorLastAlbumListIndex = new FieldHoldingGeneratorLastAlbumListIndex("field \"LastAlbumListIndex\" of the MusicSearchResults class");
            set_what("the MusicSearchResults class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTrackResults.reset();
            fieldGeneratorArtistResults.reset();
            fieldGeneratorAlbumResults.reset();
            fieldGeneratorLatestListType.reset();
            fieldGeneratorLastTrackListIndex.reset();
            fieldGeneratorLastArtistListIndex.reset();
            fieldGeneratorLastAlbumListIndex.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTrackResults.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorArtistResults.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAlbumResults.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTrackResults.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorArtistResults.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAlbumResults.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicSearchResultsJSON  result)
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
        public MusicSearchResultsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicSearchResultsJSON  result)
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
    protected virtual void handle_result(List<MusicSearchResultsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicSearchResultsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicSearchResultsJSON>();
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
    public List<MusicSearchResultsJSON> value;
  };
  };
