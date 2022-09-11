/* file "MusicSearchCriteriaJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MusicSearchCriteriaJSON : JSONBase
  {
    private bool flagHasSearchCriteriaType;
    private MusicSearchTypeJSON  storeSearchCriteriaType;
    private bool flagHasTrackResultIDs;
    private List< Double > storeTrackResultIDs;
    private bool flagHasArtistResultIDs;
    private List< Double > storeArtistResultIDs;
    private bool flagHasAlbumResultIDs;
    private List< Double > storeAlbumResultIDs;
    private bool flagHasTrackResultSHIDs;
    private List< SoundHoundTrackIDJSON  > storeTrackResultSHIDs;
    private bool flagHasArtistResultSHIDs;
    private List< SoundHoundArtistIDJSON  > storeArtistResultSHIDs;
    private bool flagHasAlbumResultSHIDs;
    private List< SoundHoundAlbumIDJSON  > storeAlbumResultSHIDs;
    private bool flagHasDateRange;
    private DateTimeRangeSpecJSON  storeDateRange;
    private bool flagHasTrackCount;
    private BigInteger storeTrackCount;
    private bool flagHasAlbumCount;
    private BigInteger storeAlbumCount;
    private bool flagHasMusicSearchTargetType;
    private MusicSearchTypeJSON  storeMusicSearchTargetType;


    private void  fromJSONSearchCriteriaType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicSearchTypeJSON convert_classy = MusicSearchTypeJSON.from_json(json_value, ignore_extras, true);
        setSearchCriteriaType(convert_classy);
      }


    private void  fromJSONTrackResultIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field TrackResultIDs of MusicSearchCriteriaJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Double > vector_TrackResultIDs1 = new List< Double >(count1);
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
                    throw new Exception("The value for an element of field TrackResultIDs of MusicSearchCriteriaJSON is not a number.");
                  }
              }
            vector_TrackResultIDs1.Add(the_double);
          }
        initTrackResultIDs();
        for (int num1 = 0; num1 < vector_TrackResultIDs1.Count; ++num1)
            appendTrackResultIDs(vector_TrackResultIDs1[num1]);
        for (int num1 = 0; num1 < vector_TrackResultIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONArtistResultIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ArtistResultIDs of MusicSearchCriteriaJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Double > vector_ArtistResultIDs1 = new List< Double >(count1);
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
                    throw new Exception("The value for an element of field ArtistResultIDs of MusicSearchCriteriaJSON is not a number.");
                  }
              }
            vector_ArtistResultIDs1.Add(the_double);
          }
        initArtistResultIDs();
        for (int num2 = 0; num2 < vector_ArtistResultIDs1.Count; ++num2)
            appendArtistResultIDs(vector_ArtistResultIDs1[num2]);
        for (int num1 = 0; num1 < vector_ArtistResultIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAlbumResultIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AlbumResultIDs of MusicSearchCriteriaJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Double > vector_AlbumResultIDs1 = new List< Double >(count1);
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
                    throw new Exception("The value for an element of field AlbumResultIDs of MusicSearchCriteriaJSON is not a number.");
                  }
              }
            vector_AlbumResultIDs1.Add(the_double);
          }
        initAlbumResultIDs();
        for (int num3 = 0; num3 < vector_AlbumResultIDs1.Count; ++num3)
            appendAlbumResultIDs(vector_AlbumResultIDs1[num3]);
        for (int num1 = 0; num1 < vector_AlbumResultIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTrackResultSHIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field TrackResultSHIDs of MusicSearchCriteriaJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SoundHoundTrackIDJSON  > vector_TrackResultSHIDs1 = new List< SoundHoundTrackIDJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SoundHoundTrackIDJSON convert_classy = SoundHoundTrackIDJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_TrackResultSHIDs1.Add(convert_classy);
          }
        initTrackResultSHIDs();
        for (int num4 = 0; num4 < vector_TrackResultSHIDs1.Count; ++num4)
            appendTrackResultSHIDs(vector_TrackResultSHIDs1[num4]);
        for (int num1 = 0; num1 < vector_TrackResultSHIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONArtistResultSHIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ArtistResultSHIDs of MusicSearchCriteriaJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SoundHoundArtistIDJSON  > vector_ArtistResultSHIDs1 = new List< SoundHoundArtistIDJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SoundHoundArtistIDJSON convert_classy = SoundHoundArtistIDJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ArtistResultSHIDs1.Add(convert_classy);
          }
        initArtistResultSHIDs();
        for (int num5 = 0; num5 < vector_ArtistResultSHIDs1.Count; ++num5)
            appendArtistResultSHIDs(vector_ArtistResultSHIDs1[num5]);
        for (int num1 = 0; num1 < vector_ArtistResultSHIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAlbumResultSHIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AlbumResultSHIDs of MusicSearchCriteriaJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SoundHoundAlbumIDJSON  > vector_AlbumResultSHIDs1 = new List< SoundHoundAlbumIDJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SoundHoundAlbumIDJSON convert_classy = SoundHoundAlbumIDJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AlbumResultSHIDs1.Add(convert_classy);
          }
        initAlbumResultSHIDs();
        for (int num6 = 0; num6 < vector_AlbumResultSHIDs1.Count; ++num6)
            appendAlbumResultSHIDs(vector_AlbumResultSHIDs1[num6]);
        for (int num1 = 0; num1 < vector_AlbumResultSHIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDateRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateRange(convert_classy);
      }


    private void  fromJSONTrackCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TrackCount of MusicSearchCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TrackCount of MusicSearchCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTrackCount(extracted_integer);
      }


    private void  fromJSONAlbumCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field AlbumCount of MusicSearchCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AlbumCount of MusicSearchCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAlbumCount(extracted_integer);
      }


    private void  fromJSONMusicSearchTargetType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicSearchTypeJSON convert_classy = MusicSearchTypeJSON.from_json(json_value, ignore_extras, true);
        setMusicSearchTargetType(convert_classy);
      }


    public MusicSearchCriteriaJSON()
      {
        flagHasSearchCriteriaType = false;
        flagHasTrackResultIDs = false;
        flagHasArtistResultIDs = false;
        flagHasAlbumResultIDs = false;
        flagHasTrackResultSHIDs = false;
        flagHasArtistResultSHIDs = false;
        flagHasAlbumResultSHIDs = false;
        flagHasDateRange = false;
        flagHasTrackCount = false;
        flagHasAlbumCount = false;
        flagHasMusicSearchTargetType = false;
        storeTrackResultIDs = new List< Double >();
        storeArtistResultIDs = new List< Double >();
        storeAlbumResultIDs = new List< Double >();
        storeTrackResultSHIDs = new List< SoundHoundTrackIDJSON  >();
        storeArtistResultSHIDs = new List< SoundHoundArtistIDJSON  >();
        storeAlbumResultSHIDs = new List< SoundHoundAlbumIDJSON  >();
      }

    public bool  hasSearchCriteriaType()
      {
        return flagHasSearchCriteriaType;
      }

    public MusicSearchTypeJSON   getSearchCriteriaType()
      {
        Debug.Assert(flagHasSearchCriteriaType);
        return storeSearchCriteriaType;
      }

    public MusicSearchTypeJSON.TypeValue  getSearchCriteriaTypeValue()
      {
        return getSearchCriteriaType().getValue();
      }

    public string  getSearchCriteriaTypeAsString()
      {
        return getSearchCriteriaType().getValueAsString();
      }

    public bool  hasTrackResultIDs()
      {
        return flagHasTrackResultIDs;
      }

    public int  countOfTrackResultIDs()
      {
        Debug.Assert(flagHasTrackResultIDs);
        return storeTrackResultIDs.Count;
      }

    public double  elementOfTrackResultIDs(int element_num)
      {
        Debug.Assert(flagHasTrackResultIDs);
        return storeTrackResultIDs[element_num];
      }

    public List< Double >  getTrackResultIDs()
      {
        Debug.Assert(flagHasTrackResultIDs);
        return storeTrackResultIDs;
      }

    public bool  hasArtistResultIDs()
      {
        return flagHasArtistResultIDs;
      }

    public int  countOfArtistResultIDs()
      {
        Debug.Assert(flagHasArtistResultIDs);
        return storeArtistResultIDs.Count;
      }

    public double  elementOfArtistResultIDs(int element_num)
      {
        Debug.Assert(flagHasArtistResultIDs);
        return storeArtistResultIDs[element_num];
      }

    public List< Double >  getArtistResultIDs()
      {
        Debug.Assert(flagHasArtistResultIDs);
        return storeArtistResultIDs;
      }

    public bool  hasAlbumResultIDs()
      {
        return flagHasAlbumResultIDs;
      }

    public int  countOfAlbumResultIDs()
      {
        Debug.Assert(flagHasAlbumResultIDs);
        return storeAlbumResultIDs.Count;
      }

    public double  elementOfAlbumResultIDs(int element_num)
      {
        Debug.Assert(flagHasAlbumResultIDs);
        return storeAlbumResultIDs[element_num];
      }

    public List< Double >  getAlbumResultIDs()
      {
        Debug.Assert(flagHasAlbumResultIDs);
        return storeAlbumResultIDs;
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

    public SoundHoundTrackIDJSON   elementOfTrackResultSHIDs(int element_num)
      {
        Debug.Assert(flagHasTrackResultSHIDs);
        return storeTrackResultSHIDs[element_num];
      }

    public List< SoundHoundTrackIDJSON  >  getTrackResultSHIDs()
      {
        Debug.Assert(flagHasTrackResultSHIDs);
        return storeTrackResultSHIDs;
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

    public SoundHoundArtistIDJSON   elementOfArtistResultSHIDs(int element_num)
      {
        Debug.Assert(flagHasArtistResultSHIDs);
        return storeArtistResultSHIDs[element_num];
      }

    public List< SoundHoundArtistIDJSON  >  getArtistResultSHIDs()
      {
        Debug.Assert(flagHasArtistResultSHIDs);
        return storeArtistResultSHIDs;
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

    public SoundHoundAlbumIDJSON   elementOfAlbumResultSHIDs(int element_num)
      {
        Debug.Assert(flagHasAlbumResultSHIDs);
        return storeAlbumResultSHIDs[element_num];
      }

    public List< SoundHoundAlbumIDJSON  >  getAlbumResultSHIDs()
      {
        Debug.Assert(flagHasAlbumResultSHIDs);
        return storeAlbumResultSHIDs;
      }

    public bool  hasDateRange()
      {
        return flagHasDateRange;
      }

    public DateTimeRangeSpecJSON   getDateRange()
      {
        Debug.Assert(flagHasDateRange);
        return storeDateRange;
      }

    public bool  hasTrackCount()
      {
        return flagHasTrackCount;
      }

    public BigInteger  getTrackCount()
      {
        Debug.Assert(flagHasTrackCount);
        return storeTrackCount;
      }

    public bool  hasAlbumCount()
      {
        return flagHasAlbumCount;
      }

    public BigInteger  getAlbumCount()
      {
        Debug.Assert(flagHasAlbumCount);
        return storeAlbumCount;
      }

    public bool  hasMusicSearchTargetType()
      {
        return flagHasMusicSearchTargetType;
      }

    public MusicSearchTypeJSON   getMusicSearchTargetType()
      {
        Debug.Assert(flagHasMusicSearchTargetType);
        return storeMusicSearchTargetType;
      }

    public MusicSearchTypeJSON.TypeValue  getMusicSearchTargetTypeValue()
      {
        return getMusicSearchTargetType().getValue();
      }

    public string  getMusicSearchTargetTypeAsString()
      {
        return getMusicSearchTargetType().getValueAsString();
      }



    public void setSearchCriteriaType(MusicSearchTypeJSON  new_value)
      {
        if (flagHasSearchCriteriaType)
          {
          }
        flagHasSearchCriteriaType = true;
        storeSearchCriteriaType = new_value;
      }
    public void setSearchCriteriaType(MusicSearchTypeJSON.TypeValue new_value)
      {
        setSearchCriteriaType(new MusicSearchTypeJSON(new_value));
      }
    public void setSearchCriteriaType(string chars)
      {
        MusicSearchTypeJSON.TypeValueKnownValues known = MusicSearchTypeJSON.stringToValue(chars);
        MusicSearchTypeJSON.TypeValue new_value = new MusicSearchTypeJSON.TypeValue();
        if (known == MusicSearchTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSearchCriteriaType(new_value);
      }
    public void unsetSearchCriteriaType()
      {
        if (flagHasSearchCriteriaType)
          {
          }
        flagHasSearchCriteriaType = false;
      }
    public void initTrackResultIDs()
      {
        flagHasTrackResultIDs = true;
        storeTrackResultIDs.Clear();
      }
    public void appendTrackResultIDs(double to_append)
      {
        if (!flagHasTrackResultIDs)
          {
            flagHasTrackResultIDs = true;
            storeTrackResultIDs.Clear();
          }
        Debug.Assert(flagHasTrackResultIDs);
        storeTrackResultIDs.Add(to_append);
      }
    public void unsetTrackResultIDs()
      {
        flagHasTrackResultIDs = false;
        storeTrackResultIDs.Clear();
      }
    public void initArtistResultIDs()
      {
        flagHasArtistResultIDs = true;
        storeArtistResultIDs.Clear();
      }
    public void appendArtistResultIDs(double to_append)
      {
        if (!flagHasArtistResultIDs)
          {
            flagHasArtistResultIDs = true;
            storeArtistResultIDs.Clear();
          }
        Debug.Assert(flagHasArtistResultIDs);
        storeArtistResultIDs.Add(to_append);
      }
    public void unsetArtistResultIDs()
      {
        flagHasArtistResultIDs = false;
        storeArtistResultIDs.Clear();
      }
    public void initAlbumResultIDs()
      {
        flagHasAlbumResultIDs = true;
        storeAlbumResultIDs.Clear();
      }
    public void appendAlbumResultIDs(double to_append)
      {
        if (!flagHasAlbumResultIDs)
          {
            flagHasAlbumResultIDs = true;
            storeAlbumResultIDs.Clear();
          }
        Debug.Assert(flagHasAlbumResultIDs);
        storeAlbumResultIDs.Add(to_append);
      }
    public void unsetAlbumResultIDs()
      {
        flagHasAlbumResultIDs = false;
        storeAlbumResultIDs.Clear();
      }
    public void initTrackResultSHIDs()
      {
        if (flagHasTrackResultSHIDs)
          {
            for (int num1 = 0; num1 < storeTrackResultSHIDs.Count; ++num1)
              {
              }
          }
        flagHasTrackResultSHIDs = true;
        storeTrackResultSHIDs.Clear();
      }
    public void appendTrackResultSHIDs(SoundHoundTrackIDJSON  to_append)
      {
        if (!flagHasTrackResultSHIDs)
          {
            flagHasTrackResultSHIDs = true;
            storeTrackResultSHIDs.Clear();
          }
        Debug.Assert(flagHasTrackResultSHIDs);
        storeTrackResultSHIDs.Add(to_append);
      }
    public void appendTrackResultSHIDs(long new_value)
      {
        appendTrackResultSHIDs(new SoundHoundTrackIDJSON(new_value));
      }
    public void unsetTrackResultSHIDs()
      {
        if (flagHasTrackResultSHIDs)
          {
            for (int num2 = 0; num2 < storeTrackResultSHIDs.Count; ++num2)
              {
              }
          }
        flagHasTrackResultSHIDs = false;
        storeTrackResultSHIDs.Clear();
      }
    public void initArtistResultSHIDs()
      {
        if (flagHasArtistResultSHIDs)
          {
            for (int num3 = 0; num3 < storeArtistResultSHIDs.Count; ++num3)
              {
              }
          }
        flagHasArtistResultSHIDs = true;
        storeArtistResultSHIDs.Clear();
      }
    public void appendArtistResultSHIDs(SoundHoundArtistIDJSON  to_append)
      {
        if (!flagHasArtistResultSHIDs)
          {
            flagHasArtistResultSHIDs = true;
            storeArtistResultSHIDs.Clear();
          }
        Debug.Assert(flagHasArtistResultSHIDs);
        storeArtistResultSHIDs.Add(to_append);
      }
    public void appendArtistResultSHIDs(long new_value)
      {
        appendArtistResultSHIDs(new SoundHoundArtistIDJSON(new_value));
      }
    public void unsetArtistResultSHIDs()
      {
        if (flagHasArtistResultSHIDs)
          {
            for (int num4 = 0; num4 < storeArtistResultSHIDs.Count; ++num4)
              {
              }
          }
        flagHasArtistResultSHIDs = false;
        storeArtistResultSHIDs.Clear();
      }
    public void initAlbumResultSHIDs()
      {
        if (flagHasAlbumResultSHIDs)
          {
            for (int num5 = 0; num5 < storeAlbumResultSHIDs.Count; ++num5)
              {
              }
          }
        flagHasAlbumResultSHIDs = true;
        storeAlbumResultSHIDs.Clear();
      }
    public void appendAlbumResultSHIDs(SoundHoundAlbumIDJSON  to_append)
      {
        if (!flagHasAlbumResultSHIDs)
          {
            flagHasAlbumResultSHIDs = true;
            storeAlbumResultSHIDs.Clear();
          }
        Debug.Assert(flagHasAlbumResultSHIDs);
        storeAlbumResultSHIDs.Add(to_append);
      }
    public void appendAlbumResultSHIDs(long new_value)
      {
        appendAlbumResultSHIDs(new SoundHoundAlbumIDJSON(new_value));
      }
    public void unsetAlbumResultSHIDs()
      {
        if (flagHasAlbumResultSHIDs)
          {
            for (int num6 = 0; num6 < storeAlbumResultSHIDs.Count; ++num6)
              {
              }
          }
        flagHasAlbumResultSHIDs = false;
        storeAlbumResultSHIDs.Clear();
      }
    public void setDateRange(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasDateRange)
          {
          }
        flagHasDateRange = true;
        storeDateRange = new_value;
      }
    public void unsetDateRange()
      {
        if (flagHasDateRange)
          {
          }
        flagHasDateRange = false;
      }
    public void setTrackCount(BigInteger new_value)
      {
        flagHasTrackCount = true;
        storeTrackCount = new_value;
      }
    public void unsetTrackCount()
      {
        flagHasTrackCount = false;
      }
    public void setAlbumCount(BigInteger new_value)
      {
        flagHasAlbumCount = true;
        storeAlbumCount = new_value;
      }
    public void unsetAlbumCount()
      {
        flagHasAlbumCount = false;
      }
    public void setMusicSearchTargetType(MusicSearchTypeJSON  new_value)
      {
        if (flagHasMusicSearchTargetType)
          {
          }
        flagHasMusicSearchTargetType = true;
        storeMusicSearchTargetType = new_value;
      }
    public void setMusicSearchTargetType(MusicSearchTypeJSON.TypeValue new_value)
      {
        setMusicSearchTargetType(new MusicSearchTypeJSON(new_value));
      }
    public void setMusicSearchTargetType(string chars)
      {
        MusicSearchTypeJSON.TypeValueKnownValues known = MusicSearchTypeJSON.stringToValue(chars);
        MusicSearchTypeJSON.TypeValue new_value = new MusicSearchTypeJSON.TypeValue();
        if (known == MusicSearchTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setMusicSearchTargetType(new_value);
      }
    public void unsetMusicSearchTargetType()
      {
        if (flagHasMusicSearchTargetType)
          {
          }
        flagHasMusicSearchTargetType = false;
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
        Debug.Assert(partial_allowed || flagHasSearchCriteriaType);
        if (flagHasSearchCriteriaType)
          {
            handler.start_pair("SearchCriteriaType");
            if (partial_allowed)
                storeSearchCriteriaType.write_partial_as_json(handler);
            else
                storeSearchCriteriaType.write_as_json(handler);
          }
        if (flagHasTrackResultIDs)
          {
            handler.start_pair("TrackResultIDs");
            handler.start_array();
            for (int num1 = 0; num1 < storeTrackResultIDs.Count; ++num1)
              {
                if (((double)(long)storeTrackResultIDs[num1]) == storeTrackResultIDs[num1])
                    handler.number_value((long)storeTrackResultIDs[num1]);
                else
                    handler.number_value(storeTrackResultIDs[num1]);
              }
            handler.finish_array();
          }
        if (flagHasArtistResultIDs)
          {
            handler.start_pair("ArtistResultIDs");
            handler.start_array();
            for (int num2 = 0; num2 < storeArtistResultIDs.Count; ++num2)
              {
                if (((double)(long)storeArtistResultIDs[num2]) == storeArtistResultIDs[num2])
                    handler.number_value((long)storeArtistResultIDs[num2]);
                else
                    handler.number_value(storeArtistResultIDs[num2]);
              }
            handler.finish_array();
          }
        if (flagHasAlbumResultIDs)
          {
            handler.start_pair("AlbumResultIDs");
            handler.start_array();
            for (int num3 = 0; num3 < storeAlbumResultIDs.Count; ++num3)
              {
                if (((double)(long)storeAlbumResultIDs[num3]) == storeAlbumResultIDs[num3])
                    handler.number_value((long)storeAlbumResultIDs[num3]);
                else
                    handler.number_value(storeAlbumResultIDs[num3]);
              }
            handler.finish_array();
          }
        if (flagHasTrackResultSHIDs)
          {
            handler.start_pair("TrackResultSHIDs");
            handler.start_array();
            for (int num4 = 0; num4 < storeTrackResultSHIDs.Count; ++num4)
              {
                if (partial_allowed)
                    storeTrackResultSHIDs[num4].write_partial_as_json(handler);
                else
                    storeTrackResultSHIDs[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasArtistResultSHIDs)
          {
            handler.start_pair("ArtistResultSHIDs");
            handler.start_array();
            for (int num5 = 0; num5 < storeArtistResultSHIDs.Count; ++num5)
              {
                if (partial_allowed)
                    storeArtistResultSHIDs[num5].write_partial_as_json(handler);
                else
                    storeArtistResultSHIDs[num5].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAlbumResultSHIDs)
          {
            handler.start_pair("AlbumResultSHIDs");
            handler.start_array();
            for (int num6 = 0; num6 < storeAlbumResultSHIDs.Count; ++num6)
              {
                if (partial_allowed)
                    storeAlbumResultSHIDs[num6].write_partial_as_json(handler);
                else
                    storeAlbumResultSHIDs[num6].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDateRange)
          {
            handler.start_pair("DateRange");
            if (partial_allowed)
                storeDateRange.write_partial_as_json(handler);
            else
                storeDateRange.write_as_json(handler);
          }
        if (flagHasTrackCount)
          {
            handler.start_pair("TrackCount");
            handler.number_value(storeTrackCount);
          }
        if (flagHasAlbumCount)
          {
            handler.start_pair("AlbumCount");
            handler.number_value(storeAlbumCount);
          }
        Debug.Assert(partial_allowed || flagHasMusicSearchTargetType);
        if (flagHasMusicSearchTargetType)
          {
            handler.start_pair("MusicSearchTargetType");
            if (partial_allowed)
                storeMusicSearchTargetType.write_partial_as_json(handler);
            else
                storeMusicSearchTargetType.write_as_json(handler);
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
        if (!(hasSearchCriteriaType()))
          {
            return "When parsing the object for %what%, the \"SearchCriteriaType\" field was missing.";
          }
        if (!(hasMusicSearchTargetType()))
          {
            return "When parsing the object for %what%, the \"MusicSearchTargetType\" field was missing.";
          }
        return null;
      }

    public static MusicSearchCriteriaJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicSearchCriteriaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchCriteria", ignore_extras);
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
    public static MusicSearchCriteriaJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicSearchCriteriaJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicSearchCriteriaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchCriteria", ignore_extras);
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
    public static MusicSearchCriteriaJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicSearchCriteriaJSON from_text(string text, bool ignore_extras)
      {
        MusicSearchCriteriaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchCriteria", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicSearchCriteriaJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicSearchCriteriaJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicSearchCriteriaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchCriteria", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MusicSearchTypeJSON.HoldingGenerator fieldGeneratorSearchCriteriaType;
        private JSONHoldingNumberTextArrayGenerator fieldGeneratorTrackResultIDs;
        private JSONHoldingNumberTextArrayGenerator fieldGeneratorArtistResultIDs;
        private JSONHoldingNumberTextArrayGenerator fieldGeneratorAlbumResultIDs;
        private SoundHoundTrackIDJSON.HoldingArrayGenerator fieldGeneratorTrackResultSHIDs;
        private SoundHoundArtistIDJSON.HoldingArrayGenerator fieldGeneratorArtistResultSHIDs;
        private SoundHoundAlbumIDJSON.HoldingArrayGenerator fieldGeneratorAlbumResultSHIDs;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDateRange;
    private class FieldHoldingGeneratorTrackCount : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorTrackCount(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorTrackCount : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorTrackCount(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorTrackCount fieldGeneratorTrackCount;
    private class FieldHoldingGeneratorAlbumCount : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorAlbumCount(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorAlbumCount : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorAlbumCount(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorAlbumCount fieldGeneratorAlbumCount;
        private MusicSearchTypeJSON.HoldingGenerator fieldGeneratorMusicSearchTargetType;

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
            MusicSearchCriteriaJSON result = new MusicSearchCriteriaJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MusicSearchCriteriaJSON result)
          {
            if (fieldGeneratorSearchCriteriaType.have_value)
              {
                result.setSearchCriteriaType(fieldGeneratorSearchCriteriaType.value);
                fieldGeneratorSearchCriteriaType.have_value = false;
              }
            else if ((!(result.hasSearchCriteriaType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SearchCriteriaType\" field was missing.");
              }
            if (fieldGeneratorTrackResultIDs.have_value)
              {
                result.initTrackResultIDs();
                int count = fieldGeneratorTrackResultIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTrackResultIDs(Double.Parse(fieldGeneratorTrackResultIDs.value[num]));
                  }
                fieldGeneratorTrackResultIDs.value.Clear();
                fieldGeneratorTrackResultIDs.have_value = false;
              }
            if (fieldGeneratorArtistResultIDs.have_value)
              {
                result.initArtistResultIDs();
                int count = fieldGeneratorArtistResultIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendArtistResultIDs(Double.Parse(fieldGeneratorArtistResultIDs.value[num]));
                  }
                fieldGeneratorArtistResultIDs.value.Clear();
                fieldGeneratorArtistResultIDs.have_value = false;
              }
            if (fieldGeneratorAlbumResultIDs.have_value)
              {
                result.initAlbumResultIDs();
                int count = fieldGeneratorAlbumResultIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAlbumResultIDs(Double.Parse(fieldGeneratorAlbumResultIDs.value[num]));
                  }
                fieldGeneratorAlbumResultIDs.value.Clear();
                fieldGeneratorAlbumResultIDs.have_value = false;
              }
            if (fieldGeneratorTrackResultSHIDs.have_value)
              {
                result.initTrackResultSHIDs();
                int count = fieldGeneratorTrackResultSHIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTrackResultSHIDs(fieldGeneratorTrackResultSHIDs.value[num]);
                  }
                fieldGeneratorTrackResultSHIDs.value.Clear();
                fieldGeneratorTrackResultSHIDs.have_value = false;
              }
            if (fieldGeneratorArtistResultSHIDs.have_value)
              {
                result.initArtistResultSHIDs();
                int count = fieldGeneratorArtistResultSHIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendArtistResultSHIDs(fieldGeneratorArtistResultSHIDs.value[num]);
                  }
                fieldGeneratorArtistResultSHIDs.value.Clear();
                fieldGeneratorArtistResultSHIDs.have_value = false;
              }
            if (fieldGeneratorAlbumResultSHIDs.have_value)
              {
                result.initAlbumResultSHIDs();
                int count = fieldGeneratorAlbumResultSHIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAlbumResultSHIDs(fieldGeneratorAlbumResultSHIDs.value[num]);
                  }
                fieldGeneratorAlbumResultSHIDs.value.Clear();
                fieldGeneratorAlbumResultSHIDs.have_value = false;
              }
            if (fieldGeneratorDateRange.have_value)
              {
                result.setDateRange(fieldGeneratorDateRange.value);
                fieldGeneratorDateRange.have_value = false;
              }
            if (fieldGeneratorTrackCount.have_value)
              {
                result.setTrackCount(fieldGeneratorTrackCount.value);
                fieldGeneratorTrackCount.have_value = false;
              }
            if (fieldGeneratorAlbumCount.have_value)
              {
                result.setAlbumCount(fieldGeneratorAlbumCount.value);
                fieldGeneratorAlbumCount.have_value = false;
              }
            if (fieldGeneratorMusicSearchTargetType.have_value)
              {
                result.setMusicSearchTargetType(fieldGeneratorMusicSearchTargetType.value);
                fieldGeneratorMusicSearchTargetType.have_value = false;
              }
            else if ((!(result.hasMusicSearchTargetType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MusicSearchTargetType\" field was missing.");
              }
          }
        protected abstract void handle_result(MusicSearchCriteriaJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if (String.Compare(field_name, 2, "bum", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 6, "ount", 0, 4, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorAlbumCount;
                                        break;
                                    case 'R':
                                        if (String.Compare(field_name, 6, "esult", 0, 5, false) == 0)
                                          {
                                            switch (field_name[11])
                                              {
                                                case 'I':
                                                    if ((String.Compare(field_name, 12, "Ds", 0, 2, false) == 0) && (field_name.Length == 14))
                                                        return fieldGeneratorAlbumResultIDs;
                                                    break;
                                                case 'S':
                                                    if ((String.Compare(field_name, 12, "HIDs", 0, 4, false) == 0) && (field_name.Length == 16))
                                                        return fieldGeneratorAlbumResultSHIDs;
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
                        case 'r':
                            if (String.Compare(field_name, 2, "tistResult", 0, 10, false) == 0)
                              {
                                switch (field_name[12])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 13, "Ds", 0, 2, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorArtistResultIDs;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 13, "HIDs", 0, 4, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorArtistResultSHIDs;
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
                case 'D':
                    if ((String.Compare(field_name, 1, "ateRange", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorDateRange;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "usicSearchTargetType", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorMusicSearchTargetType;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "earchCriteriaType", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorSearchCriteriaType;
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "rack", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 6, "ount", 0, 4, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorTrackCount;
                                break;
                            case 'R':
                                if (String.Compare(field_name, 6, "esult", 0, 5, false) == 0)
                                  {
                                    switch (field_name[11])
                                      {
                                        case 'I':
                                            if ((String.Compare(field_name, 12, "Ds", 0, 2, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorTrackResultIDs;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 12, "HIDs", 0, 4, false) == 0) && (field_name.Length == 16))
                                                return fieldGeneratorTrackResultSHIDs;
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
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSearchCriteriaType = new MusicSearchTypeJSON.HoldingGenerator("field \"SearchCriteriaType\" of the MusicSearchCriteria class", ignore_extras);
            fieldGeneratorTrackResultIDs = new JSONHoldingNumberTextArrayGenerator("field \"TrackResultIDs\" of the MusicSearchCriteria class");
            fieldGeneratorArtistResultIDs = new JSONHoldingNumberTextArrayGenerator("field \"ArtistResultIDs\" of the MusicSearchCriteria class");
            fieldGeneratorAlbumResultIDs = new JSONHoldingNumberTextArrayGenerator("field \"AlbumResultIDs\" of the MusicSearchCriteria class");
            fieldGeneratorTrackResultSHIDs = new SoundHoundTrackIDJSON.HoldingArrayGenerator("field \"TrackResultSHIDs\" of the MusicSearchCriteria class", ignore_extras);
            fieldGeneratorArtistResultSHIDs = new SoundHoundArtistIDJSON.HoldingArrayGenerator("field \"ArtistResultSHIDs\" of the MusicSearchCriteria class", ignore_extras);
            fieldGeneratorAlbumResultSHIDs = new SoundHoundAlbumIDJSON.HoldingArrayGenerator("field \"AlbumResultSHIDs\" of the MusicSearchCriteria class", ignore_extras);
            fieldGeneratorDateRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateRange\" of the MusicSearchCriteria class", ignore_extras);
            fieldGeneratorTrackCount = new FieldHoldingGeneratorTrackCount("field \"TrackCount\" of the MusicSearchCriteria class");
            fieldGeneratorAlbumCount = new FieldHoldingGeneratorAlbumCount("field \"AlbumCount\" of the MusicSearchCriteria class");
            fieldGeneratorMusicSearchTargetType = new MusicSearchTypeJSON.HoldingGenerator("field \"MusicSearchTargetType\" of the MusicSearchCriteria class", ignore_extras);
            set_what("the MusicSearchCriteria class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSearchCriteriaType = new MusicSearchTypeJSON.HoldingGenerator("field \"SearchCriteriaType\" of the MusicSearchCriteria class", false);
            fieldGeneratorTrackResultIDs = new JSONHoldingNumberTextArrayGenerator("field \"TrackResultIDs\" of the MusicSearchCriteria class");
            fieldGeneratorArtistResultIDs = new JSONHoldingNumberTextArrayGenerator("field \"ArtistResultIDs\" of the MusicSearchCriteria class");
            fieldGeneratorAlbumResultIDs = new JSONHoldingNumberTextArrayGenerator("field \"AlbumResultIDs\" of the MusicSearchCriteria class");
            fieldGeneratorTrackResultSHIDs = new SoundHoundTrackIDJSON.HoldingArrayGenerator("field \"TrackResultSHIDs\" of the MusicSearchCriteria class", false);
            fieldGeneratorArtistResultSHIDs = new SoundHoundArtistIDJSON.HoldingArrayGenerator("field \"ArtistResultSHIDs\" of the MusicSearchCriteria class", false);
            fieldGeneratorAlbumResultSHIDs = new SoundHoundAlbumIDJSON.HoldingArrayGenerator("field \"AlbumResultSHIDs\" of the MusicSearchCriteria class", false);
            fieldGeneratorDateRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateRange\" of the MusicSearchCriteria class", false);
            fieldGeneratorTrackCount = new FieldHoldingGeneratorTrackCount("field \"TrackCount\" of the MusicSearchCriteria class");
            fieldGeneratorAlbumCount = new FieldHoldingGeneratorAlbumCount("field \"AlbumCount\" of the MusicSearchCriteria class");
            fieldGeneratorMusicSearchTargetType = new MusicSearchTypeJSON.HoldingGenerator("field \"MusicSearchTargetType\" of the MusicSearchCriteria class", false);
            set_what("the MusicSearchCriteria class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSearchCriteriaType.reset();
            fieldGeneratorTrackResultIDs.reset();
            fieldGeneratorArtistResultIDs.reset();
            fieldGeneratorAlbumResultIDs.reset();
            fieldGeneratorTrackResultSHIDs.reset();
            fieldGeneratorArtistResultSHIDs.reset();
            fieldGeneratorAlbumResultSHIDs.reset();
            fieldGeneratorDateRange.reset();
            fieldGeneratorTrackCount.reset();
            fieldGeneratorAlbumCount.reset();
            fieldGeneratorMusicSearchTargetType.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSearchCriteriaType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTrackResultSHIDs.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorArtistResultSHIDs.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAlbumResultSHIDs.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDateRange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMusicSearchTargetType.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSearchCriteriaType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTrackResultSHIDs.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorArtistResultSHIDs.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAlbumResultSHIDs.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDateRange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMusicSearchTargetType.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicSearchCriteriaJSON  result)
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
        public MusicSearchCriteriaJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicSearchCriteriaJSON  result)
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
    protected virtual void handle_result(List<MusicSearchCriteriaJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicSearchCriteriaJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicSearchCriteriaJSON>();
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
    public List<MusicSearchCriteriaJSON> value;
  };
  };
