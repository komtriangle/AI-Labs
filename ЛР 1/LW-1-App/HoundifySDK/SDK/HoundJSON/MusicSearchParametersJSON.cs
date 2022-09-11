/* file "MusicSearchParametersJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MusicSearchParametersJSON : JSONBase
  {
    private bool flagHasSearchCriteriaType;
    private MusicSearchTypeJSON  storeSearchCriteriaType;
    private bool flagHasCurrentDateAndTime;
    private DateAndOrTimeJSON  storeCurrentDateAndTime;
    private bool flagHasRequestedNumberOfResults;
    private BigInteger storeRequestedNumberOfResults;
    private bool flagHasRequestedField;
    private MusicRequestedFieldJSON  storeRequestedField;
    private bool flagHasAlbumReleaseDateRangeFilter;
    private DateTimeRangeSpecJSON  storeAlbumReleaseDateRangeFilter;
    private bool flagHasTrackReleaseDateRangeFilter;
    private DateTimeRangeSpecJSON  storeTrackReleaseDateRangeFilter;
    private bool flagHasArtistBirthDateRangeFilter;
    private DateTimeRangeSpecJSON  storeArtistBirthDateRangeFilter;
    private bool flagHasUserRequestedTopEntities;
    private bool storeUserRequestedTopEntities;
    private bool flagHasUserRequestedLatestEntities;
    private bool storeUserRequestedLatestEntities;
    private bool flagHasUserRequestedEarliestEntities;
    private bool storeUserRequestedEarliestEntities;
    private bool flagHasUserRequestedVideos;
    private bool storeUserRequestedVideos;
    private bool flagHasUserRequestedPreview;
    private bool storeUserRequestedPreview;
    private bool flagHasUserRequestedBuy;
    private bool storeUserRequestedBuy;
    private bool flagHasFilteredByArtists;
    private List< MusicArtistJSON  > storeFilteredByArtists;
    private bool flagHasFilteredByAlbums;
    private List< MusicAlbumJSON  > storeFilteredByAlbums;


    private void  fromJSONSearchCriteriaType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicSearchTypeJSON convert_classy = MusicSearchTypeJSON.from_json(json_value, ignore_extras, true);
        setSearchCriteriaType(convert_classy);
      }


    private void  fromJSONCurrentDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setCurrentDateAndTime(convert_classy);
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
                throw new Exception("The value for field RequestedNumberOfResults of MusicSearchParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RequestedNumberOfResults of MusicSearchParametersJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRequestedNumberOfResults(extracted_integer);
      }


    private void  fromJSONRequestedField(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicRequestedFieldJSON convert_classy = MusicRequestedFieldJSON.from_json(json_value, ignore_extras, true);
        setRequestedField(convert_classy);
      }


    private void  fromJSONAlbumReleaseDateRangeFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setAlbumReleaseDateRangeFilter(convert_classy);
      }


    private void  fromJSONTrackReleaseDateRangeFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setTrackReleaseDateRangeFilter(convert_classy);
      }


    private void  fromJSONArtistBirthDateRangeFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setArtistBirthDateRangeFilter(convert_classy);
      }


    private void  fromJSONUserRequestedTopEntities(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserRequestedTopEntities of MusicSearchParametersJSON is not true for false.");
              }
          }
        setUserRequestedTopEntities(the_bool);
      }


    private void  fromJSONUserRequestedLatestEntities(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserRequestedLatestEntities of MusicSearchParametersJSON is not true for false.");
              }
          }
        setUserRequestedLatestEntities(the_bool);
      }


    private void  fromJSONUserRequestedEarliestEntities(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserRequestedEarliestEntities of MusicSearchParametersJSON is not true for false.");
              }
          }
        setUserRequestedEarliestEntities(the_bool);
      }


    private void  fromJSONUserRequestedVideos(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserRequestedVideos of MusicSearchParametersJSON is not true for false.");
              }
          }
        setUserRequestedVideos(the_bool);
      }


    private void  fromJSONUserRequestedPreview(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserRequestedPreview of MusicSearchParametersJSON is not true for false.");
              }
          }
        setUserRequestedPreview(the_bool);
      }


    private void  fromJSONUserRequestedBuy(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserRequestedBuy of MusicSearchParametersJSON is not true for false.");
              }
          }
        setUserRequestedBuy(the_bool);
      }


    private void  fromJSONFilteredByArtists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FilteredByArtists of MusicSearchParametersJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field FilteredByArtists of MusicSearchParametersJSON has too few elements.");
        List< MusicArtistJSON  > vector_FilteredByArtists1 = new List< MusicArtistJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicArtistJSON convert_classy = MusicArtistJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FilteredByArtists1.Add(convert_classy);
          }
        Debug.Assert(vector_FilteredByArtists1.Count >= 1);
        initFilteredByArtists();
        for (int num1 = 0; num1 < vector_FilteredByArtists1.Count; ++num1)
            appendFilteredByArtists(vector_FilteredByArtists1[num1]);
        for (int num1 = 0; num1 < vector_FilteredByArtists1.Count; ++num1)
          {
          }
      }


    private void  fromJSONFilteredByAlbums(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FilteredByAlbums of MusicSearchParametersJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field FilteredByAlbums of MusicSearchParametersJSON has too few elements.");
        List< MusicAlbumJSON  > vector_FilteredByAlbums1 = new List< MusicAlbumJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicAlbumJSON convert_classy = MusicAlbumJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FilteredByAlbums1.Add(convert_classy);
          }
        Debug.Assert(vector_FilteredByAlbums1.Count >= 1);
        initFilteredByAlbums();
        for (int num2 = 0; num2 < vector_FilteredByAlbums1.Count; ++num2)
            appendFilteredByAlbums(vector_FilteredByAlbums1[num2]);
        for (int num1 = 0; num1 < vector_FilteredByAlbums1.Count; ++num1)
          {
          }
      }


    public MusicSearchParametersJSON()
      {
        flagHasSearchCriteriaType = false;
        flagHasCurrentDateAndTime = false;
        flagHasRequestedNumberOfResults = false;
        flagHasRequestedField = false;
        flagHasAlbumReleaseDateRangeFilter = false;
        flagHasTrackReleaseDateRangeFilter = false;
        flagHasArtistBirthDateRangeFilter = false;
        flagHasUserRequestedTopEntities = false;
        flagHasUserRequestedLatestEntities = false;
        flagHasUserRequestedEarliestEntities = false;
        flagHasUserRequestedVideos = false;
        flagHasUserRequestedPreview = false;
        flagHasUserRequestedBuy = false;
        flagHasFilteredByArtists = false;
        flagHasFilteredByAlbums = false;
        storeFilteredByArtists = new List< MusicArtistJSON  >();
        storeFilteredByAlbums = new List< MusicAlbumJSON  >();
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

    public bool  hasCurrentDateAndTime()
      {
        return flagHasCurrentDateAndTime;
      }

    public DateAndOrTimeJSON   getCurrentDateAndTime()
      {
        Debug.Assert(flagHasCurrentDateAndTime);
        return storeCurrentDateAndTime;
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

    public bool  hasRequestedField()
      {
        return flagHasRequestedField;
      }

    public MusicRequestedFieldJSON   getRequestedField()
      {
        Debug.Assert(flagHasRequestedField);
        return storeRequestedField;
      }

    public MusicRequestedFieldJSON.TypeValue  getRequestedFieldValue()
      {
        return getRequestedField().getValue();
      }

    public string  getRequestedFieldAsString()
      {
        return getRequestedField().getValueAsString();
      }

    public bool  hasAlbumReleaseDateRangeFilter()
      {
        return flagHasAlbumReleaseDateRangeFilter;
      }

    public DateTimeRangeSpecJSON   getAlbumReleaseDateRangeFilter()
      {
        Debug.Assert(flagHasAlbumReleaseDateRangeFilter);
        return storeAlbumReleaseDateRangeFilter;
      }

    public bool  hasTrackReleaseDateRangeFilter()
      {
        return flagHasTrackReleaseDateRangeFilter;
      }

    public DateTimeRangeSpecJSON   getTrackReleaseDateRangeFilter()
      {
        Debug.Assert(flagHasTrackReleaseDateRangeFilter);
        return storeTrackReleaseDateRangeFilter;
      }

    public bool  hasArtistBirthDateRangeFilter()
      {
        return flagHasArtistBirthDateRangeFilter;
      }

    public DateTimeRangeSpecJSON   getArtistBirthDateRangeFilter()
      {
        Debug.Assert(flagHasArtistBirthDateRangeFilter);
        return storeArtistBirthDateRangeFilter;
      }

    public bool  hasUserRequestedTopEntities()
      {
        return flagHasUserRequestedTopEntities;
      }

    public bool  getUserRequestedTopEntities()
      {
        Debug.Assert(flagHasUserRequestedTopEntities);
        return storeUserRequestedTopEntities;
      }

    public bool  hasUserRequestedLatestEntities()
      {
        return flagHasUserRequestedLatestEntities;
      }

    public bool  getUserRequestedLatestEntities()
      {
        Debug.Assert(flagHasUserRequestedLatestEntities);
        return storeUserRequestedLatestEntities;
      }

    public bool  hasUserRequestedEarliestEntities()
      {
        return flagHasUserRequestedEarliestEntities;
      }

    public bool  getUserRequestedEarliestEntities()
      {
        Debug.Assert(flagHasUserRequestedEarliestEntities);
        return storeUserRequestedEarliestEntities;
      }

    public bool  hasUserRequestedVideos()
      {
        return flagHasUserRequestedVideos;
      }

    public bool  getUserRequestedVideos()
      {
        Debug.Assert(flagHasUserRequestedVideos);
        return storeUserRequestedVideos;
      }

    public bool  hasUserRequestedPreview()
      {
        return flagHasUserRequestedPreview;
      }

    public bool  getUserRequestedPreview()
      {
        Debug.Assert(flagHasUserRequestedPreview);
        return storeUserRequestedPreview;
      }

    public bool  hasUserRequestedBuy()
      {
        return flagHasUserRequestedBuy;
      }

    public bool  getUserRequestedBuy()
      {
        Debug.Assert(flagHasUserRequestedBuy);
        return storeUserRequestedBuy;
      }

    public bool  hasFilteredByArtists()
      {
        return flagHasFilteredByArtists;
      }

    public int  countOfFilteredByArtists()
      {
        Debug.Assert(flagHasFilteredByArtists);
        return storeFilteredByArtists.Count;
      }

    public MusicArtistJSON   elementOfFilteredByArtists(int element_num)
      {
        Debug.Assert(flagHasFilteredByArtists);
        return storeFilteredByArtists[element_num];
      }

    public List< MusicArtistJSON  >  getFilteredByArtists()
      {
        Debug.Assert(flagHasFilteredByArtists);
        return storeFilteredByArtists;
      }

    public bool  hasFilteredByAlbums()
      {
        return flagHasFilteredByAlbums;
      }

    public int  countOfFilteredByAlbums()
      {
        Debug.Assert(flagHasFilteredByAlbums);
        return storeFilteredByAlbums.Count;
      }

    public MusicAlbumJSON   elementOfFilteredByAlbums(int element_num)
      {
        Debug.Assert(flagHasFilteredByAlbums);
        return storeFilteredByAlbums[element_num];
      }

    public List< MusicAlbumJSON  >  getFilteredByAlbums()
      {
        Debug.Assert(flagHasFilteredByAlbums);
        return storeFilteredByAlbums;
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
    public void setRequestedNumberOfResults(BigInteger new_value)
      {
        flagHasRequestedNumberOfResults = true;
        if (new_value < 1)
            throw new Exception("The value for field RequestedNumberOfResults of MusicSearchParametersJSON is less than the lower bound (1) for that field.");
        storeRequestedNumberOfResults = new_value;
      }
    public void unsetRequestedNumberOfResults()
      {
        flagHasRequestedNumberOfResults = false;
      }
    public void setRequestedField(MusicRequestedFieldJSON  new_value)
      {
        if (flagHasRequestedField)
          {
          }
        flagHasRequestedField = true;
        storeRequestedField = new_value;
      }
    public void setRequestedField(MusicRequestedFieldJSON.TypeValue new_value)
      {
        setRequestedField(new MusicRequestedFieldJSON(new_value));
      }
    public void setRequestedField(string chars)
      {
        MusicRequestedFieldJSON.TypeValueKnownValues known = MusicRequestedFieldJSON.stringToValue(chars);
        MusicRequestedFieldJSON.TypeValue new_value = new MusicRequestedFieldJSON.TypeValue();
        if (known == MusicRequestedFieldJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setRequestedField(new_value);
      }
    public void unsetRequestedField()
      {
        if (flagHasRequestedField)
          {
          }
        flagHasRequestedField = false;
      }
    public void setAlbumReleaseDateRangeFilter(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasAlbumReleaseDateRangeFilter)
          {
          }
        flagHasAlbumReleaseDateRangeFilter = true;
        storeAlbumReleaseDateRangeFilter = new_value;
      }
    public void unsetAlbumReleaseDateRangeFilter()
      {
        if (flagHasAlbumReleaseDateRangeFilter)
          {
          }
        flagHasAlbumReleaseDateRangeFilter = false;
      }
    public void setTrackReleaseDateRangeFilter(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasTrackReleaseDateRangeFilter)
          {
          }
        flagHasTrackReleaseDateRangeFilter = true;
        storeTrackReleaseDateRangeFilter = new_value;
      }
    public void unsetTrackReleaseDateRangeFilter()
      {
        if (flagHasTrackReleaseDateRangeFilter)
          {
          }
        flagHasTrackReleaseDateRangeFilter = false;
      }
    public void setArtistBirthDateRangeFilter(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasArtistBirthDateRangeFilter)
          {
          }
        flagHasArtistBirthDateRangeFilter = true;
        storeArtistBirthDateRangeFilter = new_value;
      }
    public void unsetArtistBirthDateRangeFilter()
      {
        if (flagHasArtistBirthDateRangeFilter)
          {
          }
        flagHasArtistBirthDateRangeFilter = false;
      }
    public void setUserRequestedTopEntities(bool new_value)
      {
        flagHasUserRequestedTopEntities = true;
        storeUserRequestedTopEntities = new_value;
      }
    public void unsetUserRequestedTopEntities()
      {
        flagHasUserRequestedTopEntities = false;
      }
    public void setUserRequestedLatestEntities(bool new_value)
      {
        flagHasUserRequestedLatestEntities = true;
        storeUserRequestedLatestEntities = new_value;
      }
    public void unsetUserRequestedLatestEntities()
      {
        flagHasUserRequestedLatestEntities = false;
      }
    public void setUserRequestedEarliestEntities(bool new_value)
      {
        flagHasUserRequestedEarliestEntities = true;
        storeUserRequestedEarliestEntities = new_value;
      }
    public void unsetUserRequestedEarliestEntities()
      {
        flagHasUserRequestedEarliestEntities = false;
      }
    public void setUserRequestedVideos(bool new_value)
      {
        flagHasUserRequestedVideos = true;
        storeUserRequestedVideos = new_value;
      }
    public void unsetUserRequestedVideos()
      {
        flagHasUserRequestedVideos = false;
      }
    public void setUserRequestedPreview(bool new_value)
      {
        flagHasUserRequestedPreview = true;
        storeUserRequestedPreview = new_value;
      }
    public void unsetUserRequestedPreview()
      {
        flagHasUserRequestedPreview = false;
      }
    public void setUserRequestedBuy(bool new_value)
      {
        flagHasUserRequestedBuy = true;
        storeUserRequestedBuy = new_value;
      }
    public void unsetUserRequestedBuy()
      {
        flagHasUserRequestedBuy = false;
      }
    public void initFilteredByArtists()
      {
        if (flagHasFilteredByArtists)
          {
            for (int num1 = 0; num1 < storeFilteredByArtists.Count; ++num1)
              {
              }
          }
        flagHasFilteredByArtists = true;
        storeFilteredByArtists.Clear();
      }
    public void appendFilteredByArtists(MusicArtistJSON  to_append)
      {
        if (!flagHasFilteredByArtists)
          {
            flagHasFilteredByArtists = true;
            storeFilteredByArtists.Clear();
          }
        Debug.Assert(flagHasFilteredByArtists);
        storeFilteredByArtists.Add(to_append);
      }
    public void unsetFilteredByArtists()
      {
        if (flagHasFilteredByArtists)
          {
            for (int num2 = 0; num2 < storeFilteredByArtists.Count; ++num2)
              {
              }
          }
        flagHasFilteredByArtists = false;
        storeFilteredByArtists.Clear();
      }
    public void initFilteredByAlbums()
      {
        if (flagHasFilteredByAlbums)
          {
            for (int num3 = 0; num3 < storeFilteredByAlbums.Count; ++num3)
              {
              }
          }
        flagHasFilteredByAlbums = true;
        storeFilteredByAlbums.Clear();
      }
    public void appendFilteredByAlbums(MusicAlbumJSON  to_append)
      {
        if (!flagHasFilteredByAlbums)
          {
            flagHasFilteredByAlbums = true;
            storeFilteredByAlbums.Clear();
          }
        Debug.Assert(flagHasFilteredByAlbums);
        storeFilteredByAlbums.Add(to_append);
      }
    public void unsetFilteredByAlbums()
      {
        if (flagHasFilteredByAlbums)
          {
            for (int num4 = 0; num4 < storeFilteredByAlbums.Count; ++num4)
              {
              }
          }
        flagHasFilteredByAlbums = false;
        storeFilteredByAlbums.Clear();
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
        if (flagHasCurrentDateAndTime)
          {
            handler.start_pair("CurrentDateAndTime");
            if (partial_allowed)
                storeCurrentDateAndTime.write_partial_as_json(handler);
            else
                storeCurrentDateAndTime.write_as_json(handler);
          }
        if (flagHasRequestedNumberOfResults)
          {
            handler.start_pair("RequestedNumberOfResults");
            handler.number_value(storeRequestedNumberOfResults);
          }
        if (flagHasRequestedField)
          {
            handler.start_pair("RequestedField");
            if (partial_allowed)
                storeRequestedField.write_partial_as_json(handler);
            else
                storeRequestedField.write_as_json(handler);
          }
        if (flagHasAlbumReleaseDateRangeFilter)
          {
            handler.start_pair("AlbumReleaseDateRangeFilter");
            if (partial_allowed)
                storeAlbumReleaseDateRangeFilter.write_partial_as_json(handler);
            else
                storeAlbumReleaseDateRangeFilter.write_as_json(handler);
          }
        if (flagHasTrackReleaseDateRangeFilter)
          {
            handler.start_pair("TrackReleaseDateRangeFilter");
            if (partial_allowed)
                storeTrackReleaseDateRangeFilter.write_partial_as_json(handler);
            else
                storeTrackReleaseDateRangeFilter.write_as_json(handler);
          }
        if (flagHasArtistBirthDateRangeFilter)
          {
            handler.start_pair("ArtistBirthDateRangeFilter");
            if (partial_allowed)
                storeArtistBirthDateRangeFilter.write_partial_as_json(handler);
            else
                storeArtistBirthDateRangeFilter.write_as_json(handler);
          }
        if (flagHasUserRequestedTopEntities)
          {
            handler.start_pair("UserRequestedTopEntities");
            handler.boolean_value(storeUserRequestedTopEntities);
          }
        if (flagHasUserRequestedLatestEntities)
          {
            handler.start_pair("UserRequestedLatestEntities");
            handler.boolean_value(storeUserRequestedLatestEntities);
          }
        if (flagHasUserRequestedEarliestEntities)
          {
            handler.start_pair("UserRequestedEarliestEntities");
            handler.boolean_value(storeUserRequestedEarliestEntities);
          }
        if (flagHasUserRequestedVideos)
          {
            handler.start_pair("UserRequestedVideos");
            handler.boolean_value(storeUserRequestedVideos);
          }
        if (flagHasUserRequestedPreview)
          {
            handler.start_pair("UserRequestedPreview");
            handler.boolean_value(storeUserRequestedPreview);
          }
        if (flagHasUserRequestedBuy)
          {
            handler.start_pair("UserRequestedBuy");
            handler.boolean_value(storeUserRequestedBuy);
          }
        if (flagHasFilteredByArtists)
          {
            handler.start_pair("FilteredByArtists");
            Debug.Assert(storeFilteredByArtists.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeFilteredByArtists.Count; ++num1)
              {
                if (partial_allowed)
                    storeFilteredByArtists[num1].write_partial_as_json(handler);
                else
                    storeFilteredByArtists[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasFilteredByAlbums)
          {
            handler.start_pair("FilteredByAlbums");
            Debug.Assert(storeFilteredByAlbums.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeFilteredByAlbums.Count; ++num2)
              {
                if (partial_allowed)
                    storeFilteredByAlbums[num2].write_partial_as_json(handler);
                else
                    storeFilteredByAlbums[num2].write_as_json(handler);
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
        if (!(hasSearchCriteriaType()))
          {
            return "When parsing the object for %what%, the \"SearchCriteriaType\" field was missing.";
          }
        return null;
      }

    public static MusicSearchParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicSearchParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchParameters", ignore_extras);
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
    public static MusicSearchParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicSearchParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicSearchParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchParameters", ignore_extras);
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
    public static MusicSearchParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicSearchParametersJSON from_text(string text, bool ignore_extras)
      {
        MusicSearchParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchParameters", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicSearchParametersJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicSearchParametersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicSearchParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicSearchParameters", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MusicSearchTypeJSON.HoldingGenerator fieldGeneratorSearchCriteriaType;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorCurrentDateAndTime;
    private class FieldHoldingGeneratorRequestedNumberOfResults : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRequestedNumberOfResults(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRequestedNumberOfResults : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRequestedNumberOfResults(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorRequestedNumberOfResults fieldGeneratorRequestedNumberOfResults;
        private MusicRequestedFieldJSON.HoldingGenerator fieldGeneratorRequestedField;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorAlbumReleaseDateRangeFilter;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorTrackReleaseDateRangeFilter;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorArtistBirthDateRangeFilter;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedTopEntities;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedLatestEntities;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedEarliestEntities;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedVideos;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedPreview;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedBuy;
        private MusicArtistJSON.HoldingArrayGenerator fieldGeneratorFilteredByArtists;
        private MusicAlbumJSON.HoldingArrayGenerator fieldGeneratorFilteredByAlbums;

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
            MusicSearchParametersJSON result = new MusicSearchParametersJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MusicSearchParametersJSON result)
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
            if (fieldGeneratorCurrentDateAndTime.have_value)
              {
                result.setCurrentDateAndTime(fieldGeneratorCurrentDateAndTime.value);
                fieldGeneratorCurrentDateAndTime.have_value = false;
              }
            if (fieldGeneratorRequestedNumberOfResults.have_value)
              {
                result.setRequestedNumberOfResults(fieldGeneratorRequestedNumberOfResults.value);
                fieldGeneratorRequestedNumberOfResults.have_value = false;
              }
            if (fieldGeneratorRequestedField.have_value)
              {
                result.setRequestedField(fieldGeneratorRequestedField.value);
                fieldGeneratorRequestedField.have_value = false;
              }
            if (fieldGeneratorAlbumReleaseDateRangeFilter.have_value)
              {
                result.setAlbumReleaseDateRangeFilter(fieldGeneratorAlbumReleaseDateRangeFilter.value);
                fieldGeneratorAlbumReleaseDateRangeFilter.have_value = false;
              }
            if (fieldGeneratorTrackReleaseDateRangeFilter.have_value)
              {
                result.setTrackReleaseDateRangeFilter(fieldGeneratorTrackReleaseDateRangeFilter.value);
                fieldGeneratorTrackReleaseDateRangeFilter.have_value = false;
              }
            if (fieldGeneratorArtistBirthDateRangeFilter.have_value)
              {
                result.setArtistBirthDateRangeFilter(fieldGeneratorArtistBirthDateRangeFilter.value);
                fieldGeneratorArtistBirthDateRangeFilter.have_value = false;
              }
            if (fieldGeneratorUserRequestedTopEntities.have_value)
              {
                result.setUserRequestedTopEntities(fieldGeneratorUserRequestedTopEntities.value);
                fieldGeneratorUserRequestedTopEntities.have_value = false;
              }
            if (fieldGeneratorUserRequestedLatestEntities.have_value)
              {
                result.setUserRequestedLatestEntities(fieldGeneratorUserRequestedLatestEntities.value);
                fieldGeneratorUserRequestedLatestEntities.have_value = false;
              }
            if (fieldGeneratorUserRequestedEarliestEntities.have_value)
              {
                result.setUserRequestedEarliestEntities(fieldGeneratorUserRequestedEarliestEntities.value);
                fieldGeneratorUserRequestedEarliestEntities.have_value = false;
              }
            if (fieldGeneratorUserRequestedVideos.have_value)
              {
                result.setUserRequestedVideos(fieldGeneratorUserRequestedVideos.value);
                fieldGeneratorUserRequestedVideos.have_value = false;
              }
            if (fieldGeneratorUserRequestedPreview.have_value)
              {
                result.setUserRequestedPreview(fieldGeneratorUserRequestedPreview.value);
                fieldGeneratorUserRequestedPreview.have_value = false;
              }
            if (fieldGeneratorUserRequestedBuy.have_value)
              {
                result.setUserRequestedBuy(fieldGeneratorUserRequestedBuy.value);
                fieldGeneratorUserRequestedBuy.have_value = false;
              }
            if (fieldGeneratorFilteredByArtists.have_value)
              {
                result.initFilteredByArtists();
                int count = fieldGeneratorFilteredByArtists.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFilteredByArtists(fieldGeneratorFilteredByArtists.value[num]);
                  }
                fieldGeneratorFilteredByArtists.value.Clear();
                fieldGeneratorFilteredByArtists.have_value = false;
              }
            if (fieldGeneratorFilteredByAlbums.have_value)
              {
                result.initFilteredByAlbums();
                int count = fieldGeneratorFilteredByAlbums.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFilteredByAlbums(fieldGeneratorFilteredByAlbums.value[num]);
                  }
                fieldGeneratorFilteredByAlbums.value.Clear();
                fieldGeneratorFilteredByAlbums.have_value = false;
              }
          }
        protected abstract void handle_result(MusicSearchParametersJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "bumReleaseDateRangeFilter", 0, 25, false) == 0) && (field_name.Length == 27))
                                return fieldGeneratorAlbumReleaseDateRangeFilter;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "tistBirthDateRangeFilter", 0, 24, false) == 0) && (field_name.Length == 26))
                                return fieldGeneratorArtistBirthDateRangeFilter;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "urrentDateAndTime", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorCurrentDateAndTime;
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "ilteredByA", 0, 10, false) == 0)
                      {
                        switch (field_name[11])
                          {
                            case 'l':
                                if ((String.Compare(field_name, 12, "bums", 0, 4, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorFilteredByAlbums;
                                break;
                            case 'r':
                                if ((String.Compare(field_name, 12, "tists", 0, 5, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorFilteredByArtists;
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
                            case 'F':
                                if ((String.Compare(field_name, 10, "ield", 0, 4, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorRequestedField;
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
                    if ((String.Compare(field_name, 1, "earchCriteriaType", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorSearchCriteriaType;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "rackReleaseDateRangeFilter", 0, 26, false) == 0) && (field_name.Length == 27))
                        return fieldGeneratorTrackReleaseDateRangeFilter;
                    break;
                case 'U':
                    if (String.Compare(field_name, 1, "serRequested", 0, 12, false) == 0)
                      {
                        switch (field_name[13])
                          {
                            case 'B':
                                if ((String.Compare(field_name, 14, "uy", 0, 2, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorUserRequestedBuy;
                                break;
                            case 'E':
                                if ((String.Compare(field_name, 14, "arliestEntities", 0, 15, false) == 0) && (field_name.Length == 29))
                                    return fieldGeneratorUserRequestedEarliestEntities;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 14, "atestEntities", 0, 13, false) == 0) && (field_name.Length == 27))
                                    return fieldGeneratorUserRequestedLatestEntities;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 14, "review", 0, 6, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorUserRequestedPreview;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 14, "opEntities", 0, 10, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorUserRequestedTopEntities;
                                break;
                            case 'V':
                                if ((String.Compare(field_name, 14, "ideos", 0, 5, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorUserRequestedVideos;
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
            fieldGeneratorSearchCriteriaType = new MusicSearchTypeJSON.HoldingGenerator("field \"SearchCriteriaType\" of the MusicSearchParameters class", ignore_extras);
            fieldGeneratorCurrentDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"CurrentDateAndTime\" of the MusicSearchParameters class", ignore_extras);
            fieldGeneratorRequestedNumberOfResults = new FieldHoldingGeneratorRequestedNumberOfResults("field \"RequestedNumberOfResults\" of the MusicSearchParameters class");
            fieldGeneratorRequestedField = new MusicRequestedFieldJSON.HoldingGenerator("field \"RequestedField\" of the MusicSearchParameters class", ignore_extras);
            fieldGeneratorAlbumReleaseDateRangeFilter = new DateTimeRangeSpecJSON.HoldingGenerator("field \"AlbumReleaseDateRangeFilter\" of the MusicSearchParameters class", ignore_extras);
            fieldGeneratorTrackReleaseDateRangeFilter = new DateTimeRangeSpecJSON.HoldingGenerator("field \"TrackReleaseDateRangeFilter\" of the MusicSearchParameters class", ignore_extras);
            fieldGeneratorArtistBirthDateRangeFilter = new DateTimeRangeSpecJSON.HoldingGenerator("field \"ArtistBirthDateRangeFilter\" of the MusicSearchParameters class", ignore_extras);
            fieldGeneratorUserRequestedTopEntities = new JSONHoldingBooleanGenerator("field \"UserRequestedTopEntities\" of the MusicSearchParameters class");
            fieldGeneratorUserRequestedLatestEntities = new JSONHoldingBooleanGenerator("field \"UserRequestedLatestEntities\" of the MusicSearchParameters class");
            fieldGeneratorUserRequestedEarliestEntities = new JSONHoldingBooleanGenerator("field \"UserRequestedEarliestEntities\" of the MusicSearchParameters class");
            fieldGeneratorUserRequestedVideos = new JSONHoldingBooleanGenerator("field \"UserRequestedVideos\" of the MusicSearchParameters class");
            fieldGeneratorUserRequestedPreview = new JSONHoldingBooleanGenerator("field \"UserRequestedPreview\" of the MusicSearchParameters class");
            fieldGeneratorUserRequestedBuy = new JSONHoldingBooleanGenerator("field \"UserRequestedBuy\" of the MusicSearchParameters class");
            fieldGeneratorFilteredByArtists = new MusicArtistJSON.HoldingArrayGenerator("field \"FilteredByArtists\" of the MusicSearchParameters class", ignore_extras);
            fieldGeneratorFilteredByAlbums = new MusicAlbumJSON.HoldingArrayGenerator("field \"FilteredByAlbums\" of the MusicSearchParameters class", ignore_extras);
            set_what("the MusicSearchParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSearchCriteriaType = new MusicSearchTypeJSON.HoldingGenerator("field \"SearchCriteriaType\" of the MusicSearchParameters class", false);
            fieldGeneratorCurrentDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"CurrentDateAndTime\" of the MusicSearchParameters class", false);
            fieldGeneratorRequestedNumberOfResults = new FieldHoldingGeneratorRequestedNumberOfResults("field \"RequestedNumberOfResults\" of the MusicSearchParameters class");
            fieldGeneratorRequestedField = new MusicRequestedFieldJSON.HoldingGenerator("field \"RequestedField\" of the MusicSearchParameters class", false);
            fieldGeneratorAlbumReleaseDateRangeFilter = new DateTimeRangeSpecJSON.HoldingGenerator("field \"AlbumReleaseDateRangeFilter\" of the MusicSearchParameters class", false);
            fieldGeneratorTrackReleaseDateRangeFilter = new DateTimeRangeSpecJSON.HoldingGenerator("field \"TrackReleaseDateRangeFilter\" of the MusicSearchParameters class", false);
            fieldGeneratorArtistBirthDateRangeFilter = new DateTimeRangeSpecJSON.HoldingGenerator("field \"ArtistBirthDateRangeFilter\" of the MusicSearchParameters class", false);
            fieldGeneratorUserRequestedTopEntities = new JSONHoldingBooleanGenerator("field \"UserRequestedTopEntities\" of the MusicSearchParameters class");
            fieldGeneratorUserRequestedLatestEntities = new JSONHoldingBooleanGenerator("field \"UserRequestedLatestEntities\" of the MusicSearchParameters class");
            fieldGeneratorUserRequestedEarliestEntities = new JSONHoldingBooleanGenerator("field \"UserRequestedEarliestEntities\" of the MusicSearchParameters class");
            fieldGeneratorUserRequestedVideos = new JSONHoldingBooleanGenerator("field \"UserRequestedVideos\" of the MusicSearchParameters class");
            fieldGeneratorUserRequestedPreview = new JSONHoldingBooleanGenerator("field \"UserRequestedPreview\" of the MusicSearchParameters class");
            fieldGeneratorUserRequestedBuy = new JSONHoldingBooleanGenerator("field \"UserRequestedBuy\" of the MusicSearchParameters class");
            fieldGeneratorFilteredByArtists = new MusicArtistJSON.HoldingArrayGenerator("field \"FilteredByArtists\" of the MusicSearchParameters class", false);
            fieldGeneratorFilteredByAlbums = new MusicAlbumJSON.HoldingArrayGenerator("field \"FilteredByAlbums\" of the MusicSearchParameters class", false);
            set_what("the MusicSearchParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSearchCriteriaType.reset();
            fieldGeneratorCurrentDateAndTime.reset();
            fieldGeneratorRequestedNumberOfResults.reset();
            fieldGeneratorRequestedField.reset();
            fieldGeneratorAlbumReleaseDateRangeFilter.reset();
            fieldGeneratorTrackReleaseDateRangeFilter.reset();
            fieldGeneratorArtistBirthDateRangeFilter.reset();
            fieldGeneratorUserRequestedTopEntities.reset();
            fieldGeneratorUserRequestedLatestEntities.reset();
            fieldGeneratorUserRequestedEarliestEntities.reset();
            fieldGeneratorUserRequestedVideos.reset();
            fieldGeneratorUserRequestedPreview.reset();
            fieldGeneratorUserRequestedBuy.reset();
            fieldGeneratorFilteredByArtists.reset();
            fieldGeneratorFilteredByAlbums.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSearchCriteriaType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCurrentDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedField.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAlbumReleaseDateRangeFilter.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTrackReleaseDateRangeFilter.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorArtistBirthDateRangeFilter.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFilteredByArtists.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFilteredByAlbums.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSearchCriteriaType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCurrentDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedField.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAlbumReleaseDateRangeFilter.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTrackReleaseDateRangeFilter.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorArtistBirthDateRangeFilter.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFilteredByArtists.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFilteredByAlbums.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicSearchParametersJSON  result)
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
        public MusicSearchParametersJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicSearchParametersJSON  result)
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
    protected virtual void handle_result(List<MusicSearchParametersJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicSearchParametersJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicSearchParametersJSON>();
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
    public List<MusicSearchParametersJSON> value;
  };
  };
