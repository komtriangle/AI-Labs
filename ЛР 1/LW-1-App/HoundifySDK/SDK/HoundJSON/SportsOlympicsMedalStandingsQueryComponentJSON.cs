/* file "SportsOlympicsMedalStandingsQueryComponentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsOlympicsMedalStandingsQueryComponentJSON : JSONBase
  {
    private bool flagHasQueryType;
    private SportsOlympicsMedalStandingsQueryTypeJSON  storeQueryType;
    private bool flagHasOrganization;
    private SportsOlympicsOrganizationJSON  storeOrganization;
    private bool flagHasMedalType;
    private SportsOlympicsMedalJSON  storeMedalType;
    private bool flagHasRank;
    private BigInteger storeRank;
    private bool flagHasRankResult;
    private BigInteger storeRankResult;
    private bool flagHasGames;
    private SportsOlympicsGamesJSON  storeGames;
    private bool flagHasSortMethod;
    private SportsOlympicsMedalStandingsSortMethodJSON  storeSortMethod;
    private bool flagHasStandingsIndex;
    private BigInteger storeStandingsIndex;
    private bool flagHasOrganizationIndices;
    private List< BigInteger > storeOrganizationIndices;
    private bool flagHasError;
    private SportsOlympicsMedalStandingsErrorJSON  storeError;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQueryType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsMedalStandingsQueryTypeJSON convert_classy = SportsOlympicsMedalStandingsQueryTypeJSON.from_json(json_value, ignore_extras, true);
        setQueryType(convert_classy);
      }


    private void  fromJSONOrganization(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsOrganizationJSON convert_classy = SportsOlympicsOrganizationJSON.from_json(json_value, ignore_extras, true);
        setOrganization(convert_classy);
      }


    private void  fromJSONMedalType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsMedalJSON convert_classy = SportsOlympicsMedalJSON.from_json(json_value, ignore_extras, true);
        setMedalType(convert_classy);
      }


    private void  fromJSONRank(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Rank of SportsOlympicsMedalStandingsQueryComponentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Rank of SportsOlympicsMedalStandingsQueryComponentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRank(extracted_integer);
      }


    private void  fromJSONRankResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field RankResult of SportsOlympicsMedalStandingsQueryComponentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RankResult of SportsOlympicsMedalStandingsQueryComponentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRankResult(extracted_integer);
      }


    private void  fromJSONGames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsGamesJSON convert_classy = SportsOlympicsGamesJSON.from_json(json_value, ignore_extras, true);
        setGames(convert_classy);
      }


    private void  fromJSONSortMethod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsMedalStandingsSortMethodJSON convert_classy = SportsOlympicsMedalStandingsSortMethodJSON.from_json(json_value, ignore_extras, true);
        setSortMethod(convert_classy);
      }


    private void  fromJSONStandingsIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StandingsIndex of SportsOlympicsMedalStandingsQueryComponentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StandingsIndex of SportsOlympicsMedalStandingsQueryComponentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setStandingsIndex(extracted_integer);
      }


    private void  fromJSONOrganizationIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field OrganizationIndices of SportsOlympicsMedalStandingsQueryComponentJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_OrganizationIndices1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field OrganizationIndices of SportsOlympicsMedalStandingsQueryComponentJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field OrganizationIndices of SportsOlympicsMedalStandingsQueryComponentJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_OrganizationIndices1.Add(extracted_integer);
          }
        initOrganizationIndices();
        for (int num1 = 0; num1 < vector_OrganizationIndices1.Count; ++num1)
            appendOrganizationIndices(vector_OrganizationIndices1[num1]);
        for (int num1 = 0; num1 < vector_OrganizationIndices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsMedalStandingsErrorJSON convert_classy = SportsOlympicsMedalStandingsErrorJSON.from_json(json_value, ignore_extras, true);
        setError(convert_classy);
      }


    public SportsOlympicsMedalStandingsQueryComponentJSON()
      {
        flagHasQueryType = false;
        flagHasOrganization = false;
        flagHasMedalType = false;
        flagHasRank = false;
        flagHasRankResult = false;
        flagHasGames = false;
        flagHasSortMethod = false;
        flagHasStandingsIndex = false;
        flagHasOrganizationIndices = false;
        flagHasError = false;
        storeOrganizationIndices = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasQueryType()
      {
        return flagHasQueryType;
      }

    public SportsOlympicsMedalStandingsQueryTypeJSON   getQueryType()
      {
        Debug.Assert(flagHasQueryType);
        return storeQueryType;
      }

    public SportsOlympicsMedalStandingsQueryTypeJSON.TypeValue  getQueryTypeValue()
      {
        return getQueryType().getValue();
      }

    public string  getQueryTypeAsString()
      {
        return getQueryType().getValueAsString();
      }

    public bool  hasOrganization()
      {
        return flagHasOrganization;
      }

    public SportsOlympicsOrganizationJSON   getOrganization()
      {
        Debug.Assert(flagHasOrganization);
        return storeOrganization;
      }

    public bool  hasMedalType()
      {
        return flagHasMedalType;
      }

    public SportsOlympicsMedalJSON   getMedalType()
      {
        Debug.Assert(flagHasMedalType);
        return storeMedalType;
      }

    public SportsOlympicsMedalJSON.TypeValue  getMedalTypeValue()
      {
        return getMedalType().getValue();
      }

    public string  getMedalTypeAsString()
      {
        return getMedalType().getValueAsString();
      }

    public bool  hasRank()
      {
        return flagHasRank;
      }

    public BigInteger  getRank()
      {
        Debug.Assert(flagHasRank);
        return storeRank;
      }

    public bool  hasRankResult()
      {
        return flagHasRankResult;
      }

    public BigInteger  getRankResult()
      {
        Debug.Assert(flagHasRankResult);
        return storeRankResult;
      }

    public bool  hasGames()
      {
        return flagHasGames;
      }

    public SportsOlympicsGamesJSON   getGames()
      {
        Debug.Assert(flagHasGames);
        return storeGames;
      }

    public bool  hasSortMethod()
      {
        return flagHasSortMethod;
      }

    public SportsOlympicsMedalStandingsSortMethodJSON   getSortMethod()
      {
        Debug.Assert(flagHasSortMethod);
        return storeSortMethod;
      }

    public SportsOlympicsMedalStandingsSortMethodJSON.TypeValue  getSortMethodValue()
      {
        return getSortMethod().getValue();
      }

    public string  getSortMethodAsString()
      {
        return getSortMethod().getValueAsString();
      }

    public bool  hasStandingsIndex()
      {
        return flagHasStandingsIndex;
      }

    public BigInteger  getStandingsIndex()
      {
        Debug.Assert(flagHasStandingsIndex);
        return storeStandingsIndex;
      }

    public bool  hasOrganizationIndices()
      {
        return flagHasOrganizationIndices;
      }

    public int  countOfOrganizationIndices()
      {
        Debug.Assert(flagHasOrganizationIndices);
        return storeOrganizationIndices.Count;
      }

    public BigInteger  elementOfOrganizationIndices(int element_num)
      {
        Debug.Assert(flagHasOrganizationIndices);
        return storeOrganizationIndices[element_num];
      }

    public List< BigInteger >  getOrganizationIndices()
      {
        Debug.Assert(flagHasOrganizationIndices);
        return storeOrganizationIndices;
      }

    public bool  hasError()
      {
        return flagHasError;
      }

    public SportsOlympicsMedalStandingsErrorJSON   getError()
      {
        Debug.Assert(flagHasError);
        return storeError;
      }

    public SportsOlympicsMedalStandingsErrorJSON.TypeValue  getErrorValue()
      {
        return getError().getValue();
      }

    public string  getErrorAsString()
      {
        return getError().getValueAsString();
      }


    public virtual int extraSportsOlympicsMedalStandingsQueryComponentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsMedalStandingsQueryComponentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsMedalStandingsQueryComponentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsMedalStandingsQueryComponentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setQueryType(SportsOlympicsMedalStandingsQueryTypeJSON  new_value)
      {
        if (flagHasQueryType)
          {
          }
        flagHasQueryType = true;
        storeQueryType = new_value;
      }
    public void setQueryType(SportsOlympicsMedalStandingsQueryTypeJSON.TypeValue new_value)
      {
        setQueryType(new SportsOlympicsMedalStandingsQueryTypeJSON(new_value));
      }
    public void setQueryType(string chars)
      {
        SportsOlympicsMedalStandingsQueryTypeJSON.TypeValueKnownValues known = SportsOlympicsMedalStandingsQueryTypeJSON.stringToValue(chars);
        SportsOlympicsMedalStandingsQueryTypeJSON.TypeValue new_value = new SportsOlympicsMedalStandingsQueryTypeJSON.TypeValue();
        if (known == SportsOlympicsMedalStandingsQueryTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setQueryType(new_value);
      }
    public void unsetQueryType()
      {
        if (flagHasQueryType)
          {
          }
        flagHasQueryType = false;
      }
    public void setOrganization(SportsOlympicsOrganizationJSON  new_value)
      {
        if (flagHasOrganization)
          {
          }
        flagHasOrganization = true;
        storeOrganization = new_value;
      }
    public void unsetOrganization()
      {
        if (flagHasOrganization)
          {
          }
        flagHasOrganization = false;
      }
    public void setMedalType(SportsOlympicsMedalJSON  new_value)
      {
        if (flagHasMedalType)
          {
          }
        flagHasMedalType = true;
        storeMedalType = new_value;
      }
    public void setMedalType(SportsOlympicsMedalJSON.TypeValue new_value)
      {
        setMedalType(new SportsOlympicsMedalJSON(new_value));
      }
    public void setMedalType(string chars)
      {
        SportsOlympicsMedalJSON.TypeValueKnownValues known = SportsOlympicsMedalJSON.stringToValue(chars);
        SportsOlympicsMedalJSON.TypeValue new_value = new SportsOlympicsMedalJSON.TypeValue();
        if (known == SportsOlympicsMedalJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setMedalType(new_value);
      }
    public void unsetMedalType()
      {
        if (flagHasMedalType)
          {
          }
        flagHasMedalType = false;
      }
    public void setRank(BigInteger new_value)
      {
        flagHasRank = true;
        if (new_value < 1)
            throw new Exception("The value for field Rank of SportsOlympicsMedalStandingsQueryComponentJSON is less than the lower bound (1) for that field.");
        storeRank = new_value;
      }
    public void unsetRank()
      {
        flagHasRank = false;
      }
    public void setRankResult(BigInteger new_value)
      {
        flagHasRankResult = true;
        if (new_value < 1)
            throw new Exception("The value for field RankResult of SportsOlympicsMedalStandingsQueryComponentJSON is less than the lower bound (1) for that field.");
        storeRankResult = new_value;
      }
    public void unsetRankResult()
      {
        flagHasRankResult = false;
      }
    public void setGames(SportsOlympicsGamesJSON  new_value)
      {
        if (flagHasGames)
          {
          }
        flagHasGames = true;
        storeGames = new_value;
      }
    public void unsetGames()
      {
        if (flagHasGames)
          {
          }
        flagHasGames = false;
      }
    public void setSortMethod(SportsOlympicsMedalStandingsSortMethodJSON  new_value)
      {
        if (flagHasSortMethod)
          {
          }
        flagHasSortMethod = true;
        storeSortMethod = new_value;
      }
    public void setSortMethod(SportsOlympicsMedalStandingsSortMethodJSON.TypeValue new_value)
      {
        setSortMethod(new SportsOlympicsMedalStandingsSortMethodJSON(new_value));
      }
    public void setSortMethod(string chars)
      {
        SportsOlympicsMedalStandingsSortMethodJSON.TypeValueKnownValues known = SportsOlympicsMedalStandingsSortMethodJSON.stringToValue(chars);
        SportsOlympicsMedalStandingsSortMethodJSON.TypeValue new_value = new SportsOlympicsMedalStandingsSortMethodJSON.TypeValue();
        if (known == SportsOlympicsMedalStandingsSortMethodJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSortMethod(new_value);
      }
    public void unsetSortMethod()
      {
        if (flagHasSortMethod)
          {
          }
        flagHasSortMethod = false;
      }
    public void setStandingsIndex(BigInteger new_value)
      {
        flagHasStandingsIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field StandingsIndex of SportsOlympicsMedalStandingsQueryComponentJSON is less than the lower bound (0) for that field.");
        storeStandingsIndex = new_value;
      }
    public void unsetStandingsIndex()
      {
        flagHasStandingsIndex = false;
      }
    public void initOrganizationIndices()
      {
        flagHasOrganizationIndices = true;
        storeOrganizationIndices.Clear();
      }
    public void appendOrganizationIndices(BigInteger to_append)
      {
        if (!flagHasOrganizationIndices)
          {
            flagHasOrganizationIndices = true;
            storeOrganizationIndices.Clear();
          }
        Debug.Assert(flagHasOrganizationIndices);
        storeOrganizationIndices.Add(to_append);
      }
    public void unsetOrganizationIndices()
      {
        flagHasOrganizationIndices = false;
        storeOrganizationIndices.Clear();
      }
    public void setError(SportsOlympicsMedalStandingsErrorJSON  new_value)
      {
        if (flagHasError)
          {
          }
        flagHasError = true;
        storeError = new_value;
      }
    public void setError(SportsOlympicsMedalStandingsErrorJSON.TypeValue new_value)
      {
        setError(new SportsOlympicsMedalStandingsErrorJSON(new_value));
      }
    public void setError(string chars)
      {
        SportsOlympicsMedalStandingsErrorJSON.TypeValueKnownValues known = SportsOlympicsMedalStandingsErrorJSON.stringToValue(chars);
        SportsOlympicsMedalStandingsErrorJSON.TypeValue new_value = new SportsOlympicsMedalStandingsErrorJSON.TypeValue();
        if (known == SportsOlympicsMedalStandingsErrorJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setError(new_value);
      }
    public void unsetError()
      {
        if (flagHasError)
          {
          }
        flagHasError = false;
      }

    public virtual void extraSportsOlympicsMedalStandingsQueryComponentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsMedalStandingsQueryComponentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsMedalStandingsQueryComponentLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsMedalStandingsQueryComponentAppendPair(key, new_component);
          }
        else
          {
            int count = extraKeys.Count;
            Debug.Assert(count == extraValues.Count);
            for (int num = 0; num < count; ++num)
              {
                if (extraKeys[num].Equals( key))
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

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        Debug.Assert(partial_allowed || flagHasQueryType);
        if (flagHasQueryType)
          {
            handler.start_pair("QueryType");
            if (partial_allowed)
                storeQueryType.write_partial_as_json(handler);
            else
                storeQueryType.write_as_json(handler);
          }
        if (flagHasOrganization)
          {
            handler.start_pair("Organization");
            if (partial_allowed)
                storeOrganization.write_partial_as_json(handler);
            else
                storeOrganization.write_as_json(handler);
          }
        if (flagHasMedalType)
          {
            handler.start_pair("MedalType");
            if (partial_allowed)
                storeMedalType.write_partial_as_json(handler);
            else
                storeMedalType.write_as_json(handler);
          }
        if (flagHasRank)
          {
            handler.start_pair("Rank");
            handler.number_value(storeRank);
          }
        if (flagHasRankResult)
          {
            handler.start_pair("RankResult");
            handler.number_value(storeRankResult);
          }
        Debug.Assert(partial_allowed || flagHasGames);
        if (flagHasGames)
          {
            handler.start_pair("Games");
            if (partial_allowed)
                storeGames.write_partial_as_json(handler);
            else
                storeGames.write_as_json(handler);
          }
        if (flagHasSortMethod)
          {
            handler.start_pair("SortMethod");
            if (partial_allowed)
                storeSortMethod.write_partial_as_json(handler);
            else
                storeSortMethod.write_as_json(handler);
          }
        if (flagHasStandingsIndex)
          {
            handler.start_pair("StandingsIndex");
            handler.number_value(storeStandingsIndex);
          }
        if (flagHasOrganizationIndices)
          {
            handler.start_pair("OrganizationIndices");
            handler.start_array();
            for (int num1 = 0; num1 < storeOrganizationIndices.Count; ++num1)
              {
                handler.number_value(storeOrganizationIndices[num1]);
              }
            handler.finish_array();
          }
        if (flagHasError)
          {
            handler.start_pair("Error");
            if (partial_allowed)
                storeError.write_partial_as_json(handler);
            else
                storeError.write_as_json(handler);
          }
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasQueryType()))
          {
            return "When parsing the object for %what%, the \"QueryType\" field was missing.";
          }
        if (!(hasGames()))
          {
            return "When parsing the object for %what%, the \"Games\" field was missing.";
          }
        return null;
      }

    public static SportsOlympicsMedalStandingsQueryComponentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsQueryComponentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsQueryComponent", ignore_extras);
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
    public static SportsOlympicsMedalStandingsQueryComponentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsMedalStandingsQueryComponentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsQueryComponentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsQueryComponent", ignore_extras);
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
    public static SportsOlympicsMedalStandingsQueryComponentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsMedalStandingsQueryComponentJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsQueryComponentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsQueryComponent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsMedalStandingsQueryComponentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsMedalStandingsQueryComponentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsQueryComponentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsQueryComponent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsOlympicsMedalStandingsQueryTypeJSON.HoldingGenerator fieldGeneratorQueryType;
        private SportsOlympicsOrganizationJSON.HoldingGenerator fieldGeneratorOrganization;
        private SportsOlympicsMedalJSON.HoldingGenerator fieldGeneratorMedalType;
    private class FieldHoldingGeneratorRank : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRank(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRank : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRank(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorRank fieldGeneratorRank;
    private class FieldHoldingGeneratorRankResult : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRankResult(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRankResult : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRankResult(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorRankResult fieldGeneratorRankResult;
        private SportsOlympicsGamesJSON.HoldingGenerator fieldGeneratorGames;
        private SportsOlympicsMedalStandingsSortMethodJSON.HoldingGenerator fieldGeneratorSortMethod;
    private class FieldHoldingGeneratorStandingsIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorStandingsIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorStandingsIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorStandingsIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorStandingsIndex fieldGeneratorStandingsIndex;
    private class FieldHoldingGeneratorOrganizationIndices : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorOrganizationIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorOrganizationIndices : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorOrganizationIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorOrganizationIndices fieldGeneratorOrganizationIndices;
        private SportsOlympicsMedalStandingsErrorJSON.HoldingGenerator fieldGeneratorError;
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
            SportsOlympicsMedalStandingsQueryComponentJSON result = new SportsOlympicsMedalStandingsQueryComponentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsMedalStandingsQueryComponentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsMedalStandingsQueryComponentJSON result)
          {
            if (fieldGeneratorQueryType.have_value)
              {
                result.setQueryType(fieldGeneratorQueryType.value);
                fieldGeneratorQueryType.have_value = false;
              }
            else if ((!(result.hasQueryType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryType\" field was missing.");
              }
            if (fieldGeneratorOrganization.have_value)
              {
                result.setOrganization(fieldGeneratorOrganization.value);
                fieldGeneratorOrganization.have_value = false;
              }
            if (fieldGeneratorMedalType.have_value)
              {
                result.setMedalType(fieldGeneratorMedalType.value);
                fieldGeneratorMedalType.have_value = false;
              }
            if (fieldGeneratorRank.have_value)
              {
                result.setRank(fieldGeneratorRank.value);
                fieldGeneratorRank.have_value = false;
              }
            if (fieldGeneratorRankResult.have_value)
              {
                result.setRankResult(fieldGeneratorRankResult.value);
                fieldGeneratorRankResult.have_value = false;
              }
            if (fieldGeneratorGames.have_value)
              {
                result.setGames(fieldGeneratorGames.value);
                fieldGeneratorGames.have_value = false;
              }
            else if ((!(result.hasGames())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Games\" field was missing.");
              }
            if (fieldGeneratorSortMethod.have_value)
              {
                result.setSortMethod(fieldGeneratorSortMethod.value);
                fieldGeneratorSortMethod.have_value = false;
              }
            if (fieldGeneratorStandingsIndex.have_value)
              {
                result.setStandingsIndex(fieldGeneratorStandingsIndex.value);
                fieldGeneratorStandingsIndex.have_value = false;
              }
            if (fieldGeneratorOrganizationIndices.have_value)
              {
                result.initOrganizationIndices();
                int count = fieldGeneratorOrganizationIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOrganizationIndices(fieldGeneratorOrganizationIndices.value[num]);
                  }
                fieldGeneratorOrganizationIndices.value.Clear();
                fieldGeneratorOrganizationIndices.have_value = false;
              }
            if (fieldGeneratorError.have_value)
              {
                result.setError(fieldGeneratorError.value);
                fieldGeneratorError.have_value = false;
              }
          }
        protected abstract void handle_result(SportsOlympicsMedalStandingsQueryComponentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorError;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "ames", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorGames;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "edalType", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorMedalType;
                    break;
                case 'O':
                    if (String.Compare(field_name, 1, "rganization", 0, 11, false) == 0)
                      {
                        if (field_name.Length == 12)
                          {
                            return fieldGeneratorOrganization;
                          }
                        switch (field_name[12])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 13, "ndices", 0, 6, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorOrganizationIndices;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryType", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorQueryType;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "ank", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorRank;
                          }
                        switch (field_name[4])
                          {
                            case 'R':
                                if ((String.Compare(field_name, 5, "esult", 0, 5, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorRankResult;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'o':
                            if ((String.Compare(field_name, 2, "rtMethod", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorSortMethod;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "andingsIndex", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorStandingsIndex;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQueryType = new SportsOlympicsMedalStandingsQueryTypeJSON.HoldingGenerator("field \"QueryType\" of the SportsOlympicsMedalStandingsQueryComponent class", ignore_extras);
            fieldGeneratorOrganization = new SportsOlympicsOrganizationJSON.HoldingGenerator("field \"Organization\" of the SportsOlympicsMedalStandingsQueryComponent class", ignore_extras);
            fieldGeneratorMedalType = new SportsOlympicsMedalJSON.HoldingGenerator("field \"MedalType\" of the SportsOlympicsMedalStandingsQueryComponent class", ignore_extras);
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsOlympicsMedalStandingsQueryComponent class");
            fieldGeneratorRankResult = new FieldHoldingGeneratorRankResult("field \"RankResult\" of the SportsOlympicsMedalStandingsQueryComponent class");
            fieldGeneratorGames = new SportsOlympicsGamesJSON.HoldingGenerator("field \"Games\" of the SportsOlympicsMedalStandingsQueryComponent class", ignore_extras);
            fieldGeneratorSortMethod = new SportsOlympicsMedalStandingsSortMethodJSON.HoldingGenerator("field \"SortMethod\" of the SportsOlympicsMedalStandingsQueryComponent class", ignore_extras);
            fieldGeneratorStandingsIndex = new FieldHoldingGeneratorStandingsIndex("field \"StandingsIndex\" of the SportsOlympicsMedalStandingsQueryComponent class");
            fieldGeneratorOrganizationIndices = new FieldHoldingArrayGeneratorOrganizationIndices("field \"OrganizationIndices\" of the SportsOlympicsMedalStandingsQueryComponent class");
            fieldGeneratorError = new SportsOlympicsMedalStandingsErrorJSON.HoldingGenerator("field \"Error\" of the SportsOlympicsMedalStandingsQueryComponent class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsMedalStandingsQueryComponent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQueryType = new SportsOlympicsMedalStandingsQueryTypeJSON.HoldingGenerator("field \"QueryType\" of the SportsOlympicsMedalStandingsQueryComponent class", false);
            fieldGeneratorOrganization = new SportsOlympicsOrganizationJSON.HoldingGenerator("field \"Organization\" of the SportsOlympicsMedalStandingsQueryComponent class", false);
            fieldGeneratorMedalType = new SportsOlympicsMedalJSON.HoldingGenerator("field \"MedalType\" of the SportsOlympicsMedalStandingsQueryComponent class", false);
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsOlympicsMedalStandingsQueryComponent class");
            fieldGeneratorRankResult = new FieldHoldingGeneratorRankResult("field \"RankResult\" of the SportsOlympicsMedalStandingsQueryComponent class");
            fieldGeneratorGames = new SportsOlympicsGamesJSON.HoldingGenerator("field \"Games\" of the SportsOlympicsMedalStandingsQueryComponent class", false);
            fieldGeneratorSortMethod = new SportsOlympicsMedalStandingsSortMethodJSON.HoldingGenerator("field \"SortMethod\" of the SportsOlympicsMedalStandingsQueryComponent class", false);
            fieldGeneratorStandingsIndex = new FieldHoldingGeneratorStandingsIndex("field \"StandingsIndex\" of the SportsOlympicsMedalStandingsQueryComponent class");
            fieldGeneratorOrganizationIndices = new FieldHoldingArrayGeneratorOrganizationIndices("field \"OrganizationIndices\" of the SportsOlympicsMedalStandingsQueryComponent class");
            fieldGeneratorError = new SportsOlympicsMedalStandingsErrorJSON.HoldingGenerator("field \"Error\" of the SportsOlympicsMedalStandingsQueryComponent class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsMedalStandingsQueryComponent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQueryType.reset();
            fieldGeneratorOrganization.reset();
            fieldGeneratorMedalType.reset();
            fieldGeneratorRank.reset();
            fieldGeneratorRankResult.reset();
            fieldGeneratorGames.reset();
            fieldGeneratorSortMethod.reset();
            fieldGeneratorStandingsIndex.reset();
            fieldGeneratorOrganizationIndices.reset();
            fieldGeneratorError.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorQueryType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOrganization.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMedalType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGames.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSortMethod.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorError.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorQueryType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOrganization.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMedalType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGames.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSortMethod.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorError.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsMedalStandingsQueryComponentJSON  result)
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
        public SportsOlympicsMedalStandingsQueryComponentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsMedalStandingsQueryComponentJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsMedalStandingsQueryComponentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsMedalStandingsQueryComponentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsMedalStandingsQueryComponentJSON>();
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
    public List<SportsOlympicsMedalStandingsQueryComponentJSON> value;
  };
  };
