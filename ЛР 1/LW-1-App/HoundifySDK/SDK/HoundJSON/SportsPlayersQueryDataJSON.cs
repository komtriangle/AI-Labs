/* file "SportsPlayersQueryDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsPlayersQueryDataJSON : JSONBase
  {
    public enum TypeTypeKnownValues
      {
        Type_PlayerInfo,
        Type_Who,
        Type__none
      };
    public struct TypeType
      {
        public bool in_known_list;
        public string string_value;
        public TypeTypeKnownValues list_value;
      };

    public static TypeTypeKnownValues  stringToType(string chars)
      {
        switch (chars[0])
          {
            case 'P':
                if ((String.Compare(chars, 1, "layerInfo", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeTypeKnownValues.Type_PlayerInfo;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "ho", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeTypeKnownValues.Type_Who;
                break;
            default:
                break;
          }
        return TypeTypeKnownValues.Type__none;
      }

    public static string  stringFromType(TypeTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeTypeKnownValues.Type_PlayerInfo:
                return "PlayerInfo";
            case TypeTypeKnownValues.Type_Who:
                return "Who";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeErrorKnownValues
      {
        Error_NoResultFromPreviousQuery,
        Error_NoPlayersFound,
        Error__none
      };
    public struct TypeError
      {
        public bool in_known_list;
        public string string_value;
        public TypeErrorKnownValues list_value;
      };

    public static TypeErrorKnownValues  stringToError(string chars)
      {
        if (String.Compare(chars, 0, "No", 0, 2, false) == 0)
          {
            switch (chars[2])
              {
                case 'P':
                    if ((String.Compare(chars, 3, "layersFound", 0, 11, false) == 0) && (chars.Length == 14))
                        return TypeErrorKnownValues.Error_NoPlayersFound;
                    break;
                case 'R':
                    if ((String.Compare(chars, 3, "esultFromPreviousQuery", 0, 22, false) == 0) && (chars.Length == 25))
                        return TypeErrorKnownValues.Error_NoResultFromPreviousQuery;
                    break;
                default:
                    break;
              }
          }
        return TypeErrorKnownValues.Error__none;
      }

    public static string  stringFromError(TypeErrorKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeErrorKnownValues.Error_NoResultFromPreviousQuery:
                return "NoResultFromPreviousQuery";
            case TypeErrorKnownValues.Error_NoPlayersFound:
                return "NoPlayersFound";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasType;
    private TypeType storeType;
    private bool flagHasPlayerID;
    private string storePlayerID;
    private bool flagHasTeam;
    private SportsTeamNewJSON  storeTeam;
    private bool flagHasDetail;
    private SportsPlayerDetailJSON  storeDetail;
    private bool flagHasPositions;
    private List< SportsPlayerPositionJSON  > storePositions;
    private bool flagHasPlayersPositionsIndices;
    private List< List< SportsPlayersPositionIndexJSON  > > storePlayersPositionsIndices;
    private bool flagHasFallbackPositions;
    private List< SportsPlayerPositionJSON  > storeFallbackPositions;
    private bool flagHasPlayersFallbackPositionsIndices;
    private List< List< SportsPlayersPositionIndexJSON  > > storePlayersFallbackPositionsIndices;
    private bool flagHasJerseyNumber;
    private BigInteger storeJerseyNumber;
    private bool flagHasPlayersIndices;
    private List< BigInteger > storePlayersIndices;
    private bool flagHasError;
    private TypeError storeError;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Type of SportsPlayersQueryDataJSON is not a string.");
        TypeType the_open_enum = new TypeType();
        switch (json_string.getData()[0])
          {
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "layerInfo", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_PlayerInfo;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "ho", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_Who;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setType(the_open_enum);
      }


    private void  fromJSONPlayerID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PlayerID of SportsPlayersQueryDataJSON is not a string.");
        setPlayerID(json_string.getData());
      }


    private void  fromJSONTeam(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsTeamNewJSON convert_classy = SportsTeamNewJSON.from_json(json_value, ignore_extras, true);
        setTeam(convert_classy);
      }


    private void  fromJSONDetail(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsPlayerDetailJSON convert_classy = SportsPlayerDetailJSON.from_json(json_value, ignore_extras, true);
        setDetail(convert_classy);
      }


    private void  fromJSONPositions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Positions of SportsPlayersQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Positions of SportsPlayersQueryDataJSON has too few elements.");
        List< SportsPlayerPositionJSON  > vector_Positions1 = new List< SportsPlayerPositionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsPlayerPositionJSON convert_classy = SportsPlayerPositionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Positions1.Add(convert_classy);
          }
        Debug.Assert(vector_Positions1.Count >= 1);
        initPositions();
        for (int num1 = 0; num1 < vector_Positions1.Count; ++num1)
            appendPositions(vector_Positions1[num1]);
        for (int num1 = 0; num1 < vector_Positions1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPlayersPositionsIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PlayersPositionsIndices of SportsPlayersQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field PlayersPositionsIndices of SportsPlayersQueryDataJSON has too few elements.");
        List< List< SportsPlayersPositionIndexJSON  > > vector_PlayersPositionsIndices1 = new List< List< SportsPlayersPositionIndexJSON  > >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONArrayValue json_array2 = json_array1.component(num1).array_value();
            if (json_array2 == null)
                throw new Exception("The value for an element of field PlayersPositionsIndices of SportsPlayersQueryDataJSON is not an array.");
            int count2 = json_array2.componentCount();
            List< SportsPlayersPositionIndexJSON  > vector_PlayersPositionsIndices2 = new List< SportsPlayersPositionIndexJSON  >(count2);
            for (int num2 = 0; num2 < count2; ++num2)
              {
                SportsPlayersPositionIndexJSON convert_classy = SportsPlayersPositionIndexJSON.from_json(json_array2.component(num2), ignore_extras, true);
                vector_PlayersPositionsIndices2.Add(convert_classy);
              }
            vector_PlayersPositionsIndices1.Add(vector_PlayersPositionsIndices2);
          }
        Debug.Assert(vector_PlayersPositionsIndices1.Count >= 1);
        initPlayersPositionsIndices();
        for (int num2 = 0; num2 < vector_PlayersPositionsIndices1.Count; ++num2)
            appendPlayersPositionsIndices(vector_PlayersPositionsIndices1[num2]);
        for (int num1 = 0; num1 < vector_PlayersPositionsIndices1.Count; ++num1)
          {
            for (int num2 = 0; num2 < vector_PlayersPositionsIndices1[num1].Count; ++num2)
              {
              }
          }
      }


    private void  fromJSONFallbackPositions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FallbackPositions of SportsPlayersQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field FallbackPositions of SportsPlayersQueryDataJSON has too few elements.");
        List< SportsPlayerPositionJSON  > vector_FallbackPositions1 = new List< SportsPlayerPositionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsPlayerPositionJSON convert_classy = SportsPlayerPositionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FallbackPositions1.Add(convert_classy);
          }
        Debug.Assert(vector_FallbackPositions1.Count >= 1);
        initFallbackPositions();
        for (int num3 = 0; num3 < vector_FallbackPositions1.Count; ++num3)
            appendFallbackPositions(vector_FallbackPositions1[num3]);
        for (int num1 = 0; num1 < vector_FallbackPositions1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPlayersFallbackPositionsIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PlayersFallbackPositionsIndices of SportsPlayersQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field PlayersFallbackPositionsIndices of SportsPlayersQueryDataJSON has too few elements.");
        List< List< SportsPlayersPositionIndexJSON  > > vector_PlayersFallbackPositionsIndices1 = new List< List< SportsPlayersPositionIndexJSON  > >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONArrayValue json_array2 = json_array1.component(num1).array_value();
            if (json_array2 == null)
                throw new Exception("The value for an element of field PlayersFallbackPositionsIndices of SportsPlayersQueryDataJSON is not an array.");
            int count2 = json_array2.componentCount();
            List< SportsPlayersPositionIndexJSON  > vector_PlayersFallbackPositionsIndices2 = new List< SportsPlayersPositionIndexJSON  >(count2);
            for (int num2 = 0; num2 < count2; ++num2)
              {
                SportsPlayersPositionIndexJSON convert_classy = SportsPlayersPositionIndexJSON.from_json(json_array2.component(num2), ignore_extras, true);
                vector_PlayersFallbackPositionsIndices2.Add(convert_classy);
              }
            vector_PlayersFallbackPositionsIndices1.Add(vector_PlayersFallbackPositionsIndices2);
          }
        Debug.Assert(vector_PlayersFallbackPositionsIndices1.Count >= 1);
        initPlayersFallbackPositionsIndices();
        for (int num4 = 0; num4 < vector_PlayersFallbackPositionsIndices1.Count; ++num4)
            appendPlayersFallbackPositionsIndices(vector_PlayersFallbackPositionsIndices1[num4]);
        for (int num1 = 0; num1 < vector_PlayersFallbackPositionsIndices1.Count; ++num1)
          {
            for (int num2 = 0; num2 < vector_PlayersFallbackPositionsIndices1[num1].Count; ++num2)
              {
              }
          }
      }


    private void  fromJSONJerseyNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field JerseyNumber of SportsPlayersQueryDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field JerseyNumber of SportsPlayersQueryDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setJerseyNumber(extracted_integer);
      }


    private void  fromJSONPlayersIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PlayersIndices of SportsPlayersQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field PlayersIndices of SportsPlayersQueryDataJSON has too few elements.");
        List< BigInteger > vector_PlayersIndices1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field PlayersIndices of SportsPlayersQueryDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field PlayersIndices of SportsPlayersQueryDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_PlayersIndices1.Add(extracted_integer);
          }
        Debug.Assert(vector_PlayersIndices1.Count >= 1);
        initPlayersIndices();
        for (int num5 = 0; num5 < vector_PlayersIndices1.Count; ++num5)
            appendPlayersIndices(vector_PlayersIndices1[num5]);
        for (int num1 = 0; num1 < vector_PlayersIndices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Error of SportsPlayersQueryDataJSON is not a string.");
        TypeError the_open_enum = new TypeError();
        if (String.Compare(json_string.getData(), 0, "No", 0, 2, false) == 0)
          {
            switch (json_string.getData()[2])
              {
                case 'P':
                    if ((String.Compare(json_string.getData(), 3, "layersFound", 0, 11, false) == 0) && (json_string.getData().Length == 14))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeErrorKnownValues.Error_NoPlayersFound;
                            goto open_enum_is_done;
                          }
                    break;
                case 'R':
                    if ((String.Compare(json_string.getData(), 3, "esultFromPreviousQuery", 0, 22, false) == 0) && (json_string.getData().Length == 25))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeErrorKnownValues.Error_NoResultFromPreviousQuery;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setError(the_open_enum);
      }


    public SportsPlayersQueryDataJSON()
      {
        flagHasType = false;
        flagHasPlayerID = false;
        flagHasTeam = false;
        flagHasDetail = false;
        flagHasPositions = false;
        flagHasPlayersPositionsIndices = false;
        flagHasFallbackPositions = false;
        flagHasPlayersFallbackPositionsIndices = false;
        flagHasJerseyNumber = false;
        flagHasPlayersIndices = false;
        flagHasError = false;
        storePositions = new List< SportsPlayerPositionJSON  >();
        storePlayersPositionsIndices = new List< List< SportsPlayersPositionIndexJSON  > >();
        storeFallbackPositions = new List< SportsPlayerPositionJSON  >();
        storePlayersFallbackPositionsIndices = new List< List< SportsPlayersPositionIndexJSON  > >();
        storePlayersIndices = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public TypeType  getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public string  getTypeAsString()
      {
        TypeType result = getType();
        if (result.in_known_list)
            return stringFromType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasPlayerID()
      {
        return flagHasPlayerID;
      }

    public string  getPlayerID()
      {
        Debug.Assert(flagHasPlayerID);
        return storePlayerID;
      }

    public bool  hasTeam()
      {
        return flagHasTeam;
      }

    public SportsTeamNewJSON   getTeam()
      {
        Debug.Assert(flagHasTeam);
        return storeTeam;
      }

    public bool  hasDetail()
      {
        return flagHasDetail;
      }

    public SportsPlayerDetailJSON   getDetail()
      {
        Debug.Assert(flagHasDetail);
        return storeDetail;
      }

    public SportsPlayerDetailJSON.TypeValue  getDetailValue()
      {
        return getDetail().getValue();
      }

    public string  getDetailAsString()
      {
        return getDetail().getValueAsString();
      }

    public bool  hasPositions()
      {
        return flagHasPositions;
      }

    public int  countOfPositions()
      {
        Debug.Assert(flagHasPositions);
        return storePositions.Count;
      }

    public SportsPlayerPositionJSON   elementOfPositions(int element_num)
      {
        Debug.Assert(flagHasPositions);
        return storePositions[element_num];
      }

    public List< SportsPlayerPositionJSON  >  getPositions()
      {
        Debug.Assert(flagHasPositions);
        return storePositions;
      }

    public bool  hasPlayersPositionsIndices()
      {
        return flagHasPlayersPositionsIndices;
      }

    public int  countOfPlayersPositionsIndices()
      {
        Debug.Assert(flagHasPlayersPositionsIndices);
        return storePlayersPositionsIndices.Count;
      }

    public List< SportsPlayersPositionIndexJSON  >  elementOfPlayersPositionsIndices(int element_num)
      {
        Debug.Assert(flagHasPlayersPositionsIndices);
        return storePlayersPositionsIndices[element_num];
      }

    public List< List< SportsPlayersPositionIndexJSON  > >  getPlayersPositionsIndices()
      {
        Debug.Assert(flagHasPlayersPositionsIndices);
        return storePlayersPositionsIndices;
      }

    public bool  hasFallbackPositions()
      {
        return flagHasFallbackPositions;
      }

    public int  countOfFallbackPositions()
      {
        Debug.Assert(flagHasFallbackPositions);
        return storeFallbackPositions.Count;
      }

    public SportsPlayerPositionJSON   elementOfFallbackPositions(int element_num)
      {
        Debug.Assert(flagHasFallbackPositions);
        return storeFallbackPositions[element_num];
      }

    public List< SportsPlayerPositionJSON  >  getFallbackPositions()
      {
        Debug.Assert(flagHasFallbackPositions);
        return storeFallbackPositions;
      }

    public bool  hasPlayersFallbackPositionsIndices()
      {
        return flagHasPlayersFallbackPositionsIndices;
      }

    public int  countOfPlayersFallbackPositionsIndices()
      {
        Debug.Assert(flagHasPlayersFallbackPositionsIndices);
        return storePlayersFallbackPositionsIndices.Count;
      }

    public List< SportsPlayersPositionIndexJSON  >  elementOfPlayersFallbackPositionsIndices(int element_num)
      {
        Debug.Assert(flagHasPlayersFallbackPositionsIndices);
        return storePlayersFallbackPositionsIndices[element_num];
      }

    public List< List< SportsPlayersPositionIndexJSON  > >  getPlayersFallbackPositionsIndices()
      {
        Debug.Assert(flagHasPlayersFallbackPositionsIndices);
        return storePlayersFallbackPositionsIndices;
      }

    public bool  hasJerseyNumber()
      {
        return flagHasJerseyNumber;
      }

    public BigInteger  getJerseyNumber()
      {
        Debug.Assert(flagHasJerseyNumber);
        return storeJerseyNumber;
      }

    public bool  hasPlayersIndices()
      {
        return flagHasPlayersIndices;
      }

    public int  countOfPlayersIndices()
      {
        Debug.Assert(flagHasPlayersIndices);
        return storePlayersIndices.Count;
      }

    public BigInteger  elementOfPlayersIndices(int element_num)
      {
        Debug.Assert(flagHasPlayersIndices);
        return storePlayersIndices[element_num];
      }

    public List< BigInteger >  getPlayersIndices()
      {
        Debug.Assert(flagHasPlayersIndices);
        return storePlayersIndices;
      }

    public bool  hasError()
      {
        return flagHasError;
      }

    public TypeError  getError()
      {
        Debug.Assert(flagHasError);
        return storeError;
      }

    public string  getErrorAsString()
      {
        TypeError result = getError();
        if (result.in_known_list)
            return stringFromError(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraSportsPlayersQueryDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsPlayersQueryDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsPlayersQueryDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsPlayersQueryDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setType(TypeType new_value)
      {
        flagHasType = true;
        storeType = new_value;
      }
    public void setType(string chars)
      {
        TypeTypeKnownValues known = stringToType(chars);
        TypeType new_value = new TypeType();
        if (known == TypeTypeKnownValues.Type__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setType(new_value);
      }
    public void setType(TypeTypeKnownValues new_value)
      {
        TypeType new_full_value = new TypeType();
        Debug.Assert(new_value != TypeTypeKnownValues.Type__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setType(new_full_value);
      }
    public void unsetType()
      {
        flagHasType = false;
      }
    public void setPlayerID(string new_value)
      {
        flagHasPlayerID = true;
        storePlayerID = new_value;
      }
    public void unsetPlayerID()
      {
        flagHasPlayerID = false;
      }
    public void setTeam(SportsTeamNewJSON  new_value)
      {
        if (flagHasTeam)
          {
          }
        flagHasTeam = true;
        storeTeam = new_value;
      }
    public void unsetTeam()
      {
        if (flagHasTeam)
          {
          }
        flagHasTeam = false;
      }
    public void setDetail(SportsPlayerDetailJSON  new_value)
      {
        if (flagHasDetail)
          {
          }
        flagHasDetail = true;
        storeDetail = new_value;
      }
    public void setDetail(SportsPlayerDetailJSON.TypeValue new_value)
      {
        setDetail(new SportsPlayerDetailJSON(new_value));
      }
    public void setDetail(string chars)
      {
        SportsPlayerDetailJSON.TypeValueKnownValues known = SportsPlayerDetailJSON.stringToValue(chars);
        SportsPlayerDetailJSON.TypeValue new_value = new SportsPlayerDetailJSON.TypeValue();
        if (known == SportsPlayerDetailJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setDetail(new_value);
      }
    public void unsetDetail()
      {
        if (flagHasDetail)
          {
          }
        flagHasDetail = false;
      }
    public void initPositions()
      {
        if (flagHasPositions)
          {
            for (int num1 = 0; num1 < storePositions.Count; ++num1)
              {
              }
          }
        flagHasPositions = true;
        storePositions.Clear();
      }
    public void appendPositions(SportsPlayerPositionJSON  to_append)
      {
        if (!flagHasPositions)
          {
            flagHasPositions = true;
            storePositions.Clear();
          }
        Debug.Assert(flagHasPositions);
        storePositions.Add(to_append);
      }
    public void appendPositions(SportsPlayerPositionJSON.TypeValue new_value)
      {
        appendPositions(new SportsPlayerPositionJSON(new_value));
      }
    public void appendPositions(string chars)
      {
        SportsPlayerPositionJSON.TypeValueKnownValues known = SportsPlayerPositionJSON.stringToValue(chars);
        SportsPlayerPositionJSON.TypeValue new_value = new SportsPlayerPositionJSON.TypeValue();
        if (known == SportsPlayerPositionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendPositions(new_value);
      }
    public void unsetPositions()
      {
        if (flagHasPositions)
          {
            for (int num2 = 0; num2 < storePositions.Count; ++num2)
              {
              }
          }
        flagHasPositions = false;
        storePositions.Clear();
      }
    public void initPlayersPositionsIndices()
      {
        if (flagHasPlayersPositionsIndices)
          {
            for (int num3 = 0; num3 < storePlayersPositionsIndices.Count; ++num3)
              {
                for (int num4 = 0; num4 < storePlayersPositionsIndices[num3].Count; ++num4)
                  {
                  }
              }
          }
        flagHasPlayersPositionsIndices = true;
        storePlayersPositionsIndices.Clear();
      }
    public void appendPlayersPositionsIndices(List< SportsPlayersPositionIndexJSON  > to_append)
      {
        if (!flagHasPlayersPositionsIndices)
          {
            flagHasPlayersPositionsIndices = true;
            storePlayersPositionsIndices.Clear();
          }
        Debug.Assert(flagHasPlayersPositionsIndices);
        for (int num1 = 0; num1 < to_append.Count; ++num1)
          {
          }
        storePlayersPositionsIndices.Add(to_append);
      }
    public void unsetPlayersPositionsIndices()
      {
        if (flagHasPlayersPositionsIndices)
          {
            for (int num5 = 0; num5 < storePlayersPositionsIndices.Count; ++num5)
              {
                for (int num6 = 0; num6 < storePlayersPositionsIndices[num5].Count; ++num6)
                  {
                  }
              }
          }
        flagHasPlayersPositionsIndices = false;
        storePlayersPositionsIndices.Clear();
      }
    public void initFallbackPositions()
      {
        if (flagHasFallbackPositions)
          {
            for (int num7 = 0; num7 < storeFallbackPositions.Count; ++num7)
              {
              }
          }
        flagHasFallbackPositions = true;
        storeFallbackPositions.Clear();
      }
    public void appendFallbackPositions(SportsPlayerPositionJSON  to_append)
      {
        if (!flagHasFallbackPositions)
          {
            flagHasFallbackPositions = true;
            storeFallbackPositions.Clear();
          }
        Debug.Assert(flagHasFallbackPositions);
        storeFallbackPositions.Add(to_append);
      }
    public void appendFallbackPositions(SportsPlayerPositionJSON.TypeValue new_value)
      {
        appendFallbackPositions(new SportsPlayerPositionJSON(new_value));
      }
    public void appendFallbackPositions(string chars)
      {
        SportsPlayerPositionJSON.TypeValueKnownValues known = SportsPlayerPositionJSON.stringToValue(chars);
        SportsPlayerPositionJSON.TypeValue new_value = new SportsPlayerPositionJSON.TypeValue();
        if (known == SportsPlayerPositionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendFallbackPositions(new_value);
      }
    public void unsetFallbackPositions()
      {
        if (flagHasFallbackPositions)
          {
            for (int num8 = 0; num8 < storeFallbackPositions.Count; ++num8)
              {
              }
          }
        flagHasFallbackPositions = false;
        storeFallbackPositions.Clear();
      }
    public void initPlayersFallbackPositionsIndices()
      {
        if (flagHasPlayersFallbackPositionsIndices)
          {
            for (int num9 = 0; num9 < storePlayersFallbackPositionsIndices.Count; ++num9)
              {
                for (int num10 = 0; num10 < storePlayersFallbackPositionsIndices[num9].Count; ++num10)
                  {
                  }
              }
          }
        flagHasPlayersFallbackPositionsIndices = true;
        storePlayersFallbackPositionsIndices.Clear();
      }
    public void appendPlayersFallbackPositionsIndices(List< SportsPlayersPositionIndexJSON  > to_append)
      {
        if (!flagHasPlayersFallbackPositionsIndices)
          {
            flagHasPlayersFallbackPositionsIndices = true;
            storePlayersFallbackPositionsIndices.Clear();
          }
        Debug.Assert(flagHasPlayersFallbackPositionsIndices);
        for (int num2 = 0; num2 < to_append.Count; ++num2)
          {
          }
        storePlayersFallbackPositionsIndices.Add(to_append);
      }
    public void unsetPlayersFallbackPositionsIndices()
      {
        if (flagHasPlayersFallbackPositionsIndices)
          {
            for (int num11 = 0; num11 < storePlayersFallbackPositionsIndices.Count; ++num11)
              {
                for (int num12 = 0; num12 < storePlayersFallbackPositionsIndices[num11].Count; ++num12)
                  {
                  }
              }
          }
        flagHasPlayersFallbackPositionsIndices = false;
        storePlayersFallbackPositionsIndices.Clear();
      }
    public void setJerseyNumber(BigInteger new_value)
      {
        flagHasJerseyNumber = true;
        if (new_value < 0)
            throw new Exception("The value for field JerseyNumber of SportsPlayersQueryDataJSON is less than the lower bound (0) for that field.");
        storeJerseyNumber = new_value;
      }
    public void unsetJerseyNumber()
      {
        flagHasJerseyNumber = false;
      }
    public void initPlayersIndices()
      {
        flagHasPlayersIndices = true;
        storePlayersIndices.Clear();
      }
    public void appendPlayersIndices(BigInteger to_append)
      {
        if (!flagHasPlayersIndices)
          {
            flagHasPlayersIndices = true;
            storePlayersIndices.Clear();
          }
        Debug.Assert(flagHasPlayersIndices);
        storePlayersIndices.Add(to_append);
      }
    public void unsetPlayersIndices()
      {
        flagHasPlayersIndices = false;
        storePlayersIndices.Clear();
      }
    public void setError(TypeError new_value)
      {
        flagHasError = true;
        storeError = new_value;
      }
    public void setError(string chars)
      {
        TypeErrorKnownValues known = stringToError(chars);
        TypeError new_value = new TypeError();
        if (known == TypeErrorKnownValues.Error__none)
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
    public void setError(TypeErrorKnownValues new_value)
      {
        TypeError new_full_value = new TypeError();
        Debug.Assert(new_value != TypeErrorKnownValues.Error__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setError(new_full_value);
      }
    public void unsetError()
      {
        flagHasError = false;
      }

    public virtual void extraSportsPlayersQueryDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsPlayersQueryDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsPlayersQueryDataLookup(key);
        if (old_field == null)
          {
            extraSportsPlayersQueryDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasType);
        if (flagHasType)
          {
            handler.start_pair("Type");
            if (storeType.in_known_list)
              {
                switch (storeType.list_value)
                  {
                    case TypeTypeKnownValues.Type_PlayerInfo:
                        handler.string_value("PlayerInfo");
                        break;
                    case TypeTypeKnownValues.Type_Who:
                        handler.string_value("Who");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeType.string_value);
              }
          }
        if (flagHasPlayerID)
          {
            handler.start_pair("PlayerID");
            handler.string_value(storePlayerID);
          }
        if (flagHasTeam)
          {
            handler.start_pair("Team");
            if (partial_allowed)
                storeTeam.write_partial_as_json(handler);
            else
                storeTeam.write_as_json(handler);
          }
        if (flagHasDetail)
          {
            handler.start_pair("Detail");
            if (partial_allowed)
                storeDetail.write_partial_as_json(handler);
            else
                storeDetail.write_as_json(handler);
          }
        if (flagHasPositions)
          {
            handler.start_pair("Positions");
            Debug.Assert(storePositions.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storePositions.Count; ++num1)
              {
                if (partial_allowed)
                    storePositions[num1].write_partial_as_json(handler);
                else
                    storePositions[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasPlayersPositionsIndices)
          {
            handler.start_pair("PlayersPositionsIndices");
            Debug.Assert(storePlayersPositionsIndices.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storePlayersPositionsIndices.Count; ++num2)
              {
                handler.start_array();
                for (int num3 = 0; num3 < storePlayersPositionsIndices[num2].Count; ++num3)
                  {
                    if (partial_allowed)
                        storePlayersPositionsIndices[num2][num3].write_partial_as_json(handler);
                    else
                        storePlayersPositionsIndices[num2][num3].write_as_json(handler);
                  }
                handler.finish_array();
              }
            handler.finish_array();
          }
        if (flagHasFallbackPositions)
          {
            handler.start_pair("FallbackPositions");
            Debug.Assert(storeFallbackPositions.Count >= 1);
            handler.start_array();
            for (int num4 = 0; num4 < storeFallbackPositions.Count; ++num4)
              {
                if (partial_allowed)
                    storeFallbackPositions[num4].write_partial_as_json(handler);
                else
                    storeFallbackPositions[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasPlayersFallbackPositionsIndices)
          {
            handler.start_pair("PlayersFallbackPositionsIndices");
            Debug.Assert(storePlayersFallbackPositionsIndices.Count >= 1);
            handler.start_array();
            for (int num5 = 0; num5 < storePlayersFallbackPositionsIndices.Count; ++num5)
              {
                handler.start_array();
                for (int num6 = 0; num6 < storePlayersFallbackPositionsIndices[num5].Count; ++num6)
                  {
                    if (partial_allowed)
                        storePlayersFallbackPositionsIndices[num5][num6].write_partial_as_json(handler);
                    else
                        storePlayersFallbackPositionsIndices[num5][num6].write_as_json(handler);
                  }
                handler.finish_array();
              }
            handler.finish_array();
          }
        if (flagHasJerseyNumber)
          {
            handler.start_pair("JerseyNumber");
            handler.number_value(storeJerseyNumber);
          }
        if (flagHasPlayersIndices)
          {
            handler.start_pair("PlayersIndices");
            Debug.Assert(storePlayersIndices.Count >= 1);
            handler.start_array();
            for (int num7 = 0; num7 < storePlayersIndices.Count; ++num7)
              {
                handler.number_value(storePlayersIndices[num7]);
              }
            handler.finish_array();
          }
        if (flagHasError)
          {
            handler.start_pair("Error");
            if (storeError.in_known_list)
              {
                switch (storeError.list_value)
                  {
                    case TypeErrorKnownValues.Error_NoResultFromPreviousQuery:
                        handler.string_value("NoResultFromPreviousQuery");
                        break;
                    case TypeErrorKnownValues.Error_NoPlayersFound:
                        handler.string_value("NoPlayersFound");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeError.string_value);
              }
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
        if (!(hasType()))
          {
            return "When parsing the object for %what%, the \"Type\" field was missing.";
          }
        return null;
      }

    public static SportsPlayersQueryDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayersQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersQueryData", ignore_extras);
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
    public static SportsPlayersQueryDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayersQueryDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayersQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersQueryData", ignore_extras);
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
    public static SportsPlayersQueryDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayersQueryDataJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayersQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersQueryData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayersQueryDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsPlayersQueryDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayersQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersQueryData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorType : JSONStringGenerator
          {
            protected FieldGeneratorType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeTypeKnownValues known = stringToType(result);
                TypeType new_value = new TypeType();
                if (known == TypeTypeKnownValues.Type__none)
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
            protected abstract void handle_result(TypeType result);
          };
    private class FieldHoldingGeneratorType : FieldGeneratorType
  {
    protected override void handle_result(TypeType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorType(String what)
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
    public TypeType value;
  };
    private class FieldHoldingArrayGeneratorType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorType
      {
        private FieldHoldingArrayGeneratorType top;

        protected override void handle_result(TypeType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorType init_top)
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
    protected virtual void handle_result(List<TypeType> result)
      {
      }

    public FieldHoldingArrayGeneratorType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeType> value;
  };
        private FieldHoldingGeneratorType fieldGeneratorType;
        private JSONHoldingStringGenerator fieldGeneratorPlayerID;
        private SportsTeamNewJSON.HoldingGenerator fieldGeneratorTeam;
        private SportsPlayerDetailJSON.HoldingGenerator fieldGeneratorDetail;
        private SportsPlayerPositionJSON.HoldingArrayGenerator fieldGeneratorPositions;
    private class FieldHoldingArrayGeneratorPlayersPositionsIndices : JSONArrayGenerator
  {
    protected class ElementHandler : SportsPlayersPositionIndexJSON.HoldingArrayGenerator
      {
        private FieldHoldingArrayGeneratorPlayersPositionsIndices top;

        protected override void handle_result(List< SportsPlayersPositionIndexJSON  > result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPlayersPositionsIndices init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<List< SportsPlayersPositionIndexJSON  >> result)
      {
      }

    public FieldHoldingArrayGeneratorPlayersPositionsIndices(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<List< SportsPlayersPositionIndexJSON  >>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPlayersPositionsIndices(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<List< SportsPlayersPositionIndexJSON  >>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<List< SportsPlayersPositionIndexJSON  >> value;
  };
        private FieldHoldingArrayGeneratorPlayersPositionsIndices fieldGeneratorPlayersPositionsIndices;
        private SportsPlayerPositionJSON.HoldingArrayGenerator fieldGeneratorFallbackPositions;
    private class FieldHoldingArrayGeneratorPlayersFallbackPositionsIndices : JSONArrayGenerator
  {
    protected class ElementHandler : SportsPlayersPositionIndexJSON.HoldingArrayGenerator
      {
        private FieldHoldingArrayGeneratorPlayersFallbackPositionsIndices top;

        protected override void handle_result(List< SportsPlayersPositionIndexJSON  > result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPlayersFallbackPositionsIndices init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<List< SportsPlayersPositionIndexJSON  >> result)
      {
      }

    public FieldHoldingArrayGeneratorPlayersFallbackPositionsIndices(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<List< SportsPlayersPositionIndexJSON  >>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPlayersFallbackPositionsIndices(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<List< SportsPlayersPositionIndexJSON  >>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<List< SportsPlayersPositionIndexJSON  >> value;
  };
        private FieldHoldingArrayGeneratorPlayersFallbackPositionsIndices fieldGeneratorPlayersFallbackPositionsIndices;
    private class FieldHoldingGeneratorJerseyNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorJerseyNumber(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorJerseyNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorJerseyNumber(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorJerseyNumber fieldGeneratorJerseyNumber;
    private class FieldHoldingGeneratorPlayersIndices : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorPlayersIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorPlayersIndices : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorPlayersIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorPlayersIndices fieldGeneratorPlayersIndices;
    private abstract class FieldGeneratorError : JSONStringGenerator
          {
            protected FieldGeneratorError(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorError()
              {
              }
            protected override void handle_result(string result)
              {
                TypeErrorKnownValues known = stringToError(result);
                TypeError new_value = new TypeError();
                if (known == TypeErrorKnownValues.Error__none)
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
            protected abstract void handle_result(TypeError result);
          };
    private class FieldHoldingGeneratorError : FieldGeneratorError
  {
    protected override void handle_result(TypeError result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorError(String what)
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
    public TypeError value;
  };
    private class FieldHoldingArrayGeneratorError : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorError
      {
        private FieldHoldingArrayGeneratorError top;

        protected override void handle_result(TypeError result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorError init_top)
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
    protected virtual void handle_result(List<TypeError> result)
      {
      }

    public FieldHoldingArrayGeneratorError(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeError>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorError()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeError>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeError> value;
  };
        private FieldHoldingGeneratorError fieldGeneratorError;
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
            SportsPlayersQueryDataJSON result = new SportsPlayersQueryDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsPlayersQueryDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsPlayersQueryDataJSON result)
          {
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
            else if ((!(result.hasType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Type\" field was missing.");
              }
            if (fieldGeneratorPlayerID.have_value)
              {
                result.setPlayerID(fieldGeneratorPlayerID.value);
                fieldGeneratorPlayerID.have_value = false;
              }
            if (fieldGeneratorTeam.have_value)
              {
                result.setTeam(fieldGeneratorTeam.value);
                fieldGeneratorTeam.have_value = false;
              }
            if (fieldGeneratorDetail.have_value)
              {
                result.setDetail(fieldGeneratorDetail.value);
                fieldGeneratorDetail.have_value = false;
              }
            if (fieldGeneratorPositions.have_value)
              {
                result.initPositions();
                int count = fieldGeneratorPositions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPositions(fieldGeneratorPositions.value[num]);
                  }
                fieldGeneratorPositions.value.Clear();
                fieldGeneratorPositions.have_value = false;
              }
            if (fieldGeneratorPlayersPositionsIndices.have_value)
              {
                result.initPlayersPositionsIndices();
                int count = fieldGeneratorPlayersPositionsIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    List< SportsPlayersPositionIndexJSON  > unwrapped0 = new List< SportsPlayersPositionIndexJSON  >();
                    for (int num0 = 0; num0 < fieldGeneratorPlayersPositionsIndices.value[num].Count; ++num0)
                      {
                        unwrapped0.Add(fieldGeneratorPlayersPositionsIndices.value[num][num0]);
                      }
                    result.appendPlayersPositionsIndices(unwrapped0);
                  }
                fieldGeneratorPlayersPositionsIndices.value.Clear();
                fieldGeneratorPlayersPositionsIndices.have_value = false;
              }
            if (fieldGeneratorFallbackPositions.have_value)
              {
                result.initFallbackPositions();
                int count = fieldGeneratorFallbackPositions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFallbackPositions(fieldGeneratorFallbackPositions.value[num]);
                  }
                fieldGeneratorFallbackPositions.value.Clear();
                fieldGeneratorFallbackPositions.have_value = false;
              }
            if (fieldGeneratorPlayersFallbackPositionsIndices.have_value)
              {
                result.initPlayersFallbackPositionsIndices();
                int count = fieldGeneratorPlayersFallbackPositionsIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    List< SportsPlayersPositionIndexJSON  > unwrapped0 = new List< SportsPlayersPositionIndexJSON  >();
                    for (int num0 = 0; num0 < fieldGeneratorPlayersFallbackPositionsIndices.value[num].Count; ++num0)
                      {
                        unwrapped0.Add(fieldGeneratorPlayersFallbackPositionsIndices.value[num][num0]);
                      }
                    result.appendPlayersFallbackPositionsIndices(unwrapped0);
                  }
                fieldGeneratorPlayersFallbackPositionsIndices.value.Clear();
                fieldGeneratorPlayersFallbackPositionsIndices.have_value = false;
              }
            if (fieldGeneratorJerseyNumber.have_value)
              {
                result.setJerseyNumber(fieldGeneratorJerseyNumber.value);
                fieldGeneratorJerseyNumber.have_value = false;
              }
            if (fieldGeneratorPlayersIndices.have_value)
              {
                result.initPlayersIndices();
                int count = fieldGeneratorPlayersIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPlayersIndices(fieldGeneratorPlayersIndices.value[num]);
                  }
                fieldGeneratorPlayersIndices.value.Clear();
                fieldGeneratorPlayersIndices.have_value = false;
              }
            if (fieldGeneratorError.have_value)
              {
                result.setError(fieldGeneratorError.value);
                fieldGeneratorError.have_value = false;
              }
          }
        protected abstract void handle_result(SportsPlayersQueryDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "etail", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorDetail;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorError;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "allbackPositions", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorFallbackPositions;
                    break;
                case 'J':
                    if ((String.Compare(field_name, 1, "erseyNumber", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorJerseyNumber;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'l':
                            if (String.Compare(field_name, 2, "ayer", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 7, "D", 0, 1, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorPlayerID;
                                        break;
                                    case 's':
                                        switch (field_name[7])
                                          {
                                            case 'F':
                                                if ((String.Compare(field_name, 8, "allbackPositionsIndices", 0, 23, false) == 0) && (field_name.Length == 31))
                                                    return fieldGeneratorPlayersFallbackPositionsIndices;
                                                break;
                                            case 'I':
                                                if ((String.Compare(field_name, 8, "ndices", 0, 6, false) == 0) && (field_name.Length == 14))
                                                    return fieldGeneratorPlayersIndices;
                                                break;
                                            case 'P':
                                                if ((String.Compare(field_name, 8, "ositionsIndices", 0, 15, false) == 0) && (field_name.Length == 23))
                                                    return fieldGeneratorPlayersPositionsIndices;
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
                        case 'o':
                            if ((String.Compare(field_name, 2, "sitions", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorPositions;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "am", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorTeam;
                            break;
                        case 'y':
                            if ((String.Compare(field_name, 2, "pe", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorType;
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
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the SportsPlayersQueryData class");
            fieldGeneratorPlayerID = new JSONHoldingStringGenerator("field \"PlayerID\" of the SportsPlayersQueryData class");
            fieldGeneratorTeam = new SportsTeamNewJSON.HoldingGenerator("field \"Team\" of the SportsPlayersQueryData class", ignore_extras);
            fieldGeneratorDetail = new SportsPlayerDetailJSON.HoldingGenerator("field \"Detail\" of the SportsPlayersQueryData class", ignore_extras);
            fieldGeneratorPositions = new SportsPlayerPositionJSON.HoldingArrayGenerator("field \"Positions\" of the SportsPlayersQueryData class", ignore_extras);
            fieldGeneratorPlayersPositionsIndices = new FieldHoldingArrayGeneratorPlayersPositionsIndices("field \"PlayersPositionsIndices\" of the SportsPlayersQueryData class", ignore_extras);
            fieldGeneratorFallbackPositions = new SportsPlayerPositionJSON.HoldingArrayGenerator("field \"FallbackPositions\" of the SportsPlayersQueryData class", ignore_extras);
            fieldGeneratorPlayersFallbackPositionsIndices = new FieldHoldingArrayGeneratorPlayersFallbackPositionsIndices("field \"PlayersFallbackPositionsIndices\" of the SportsPlayersQueryData class", ignore_extras);
            fieldGeneratorJerseyNumber = new FieldHoldingGeneratorJerseyNumber("field \"JerseyNumber\" of the SportsPlayersQueryData class");
            fieldGeneratorPlayersIndices = new FieldHoldingArrayGeneratorPlayersIndices("field \"PlayersIndices\" of the SportsPlayersQueryData class");
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the SportsPlayersQueryData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsPlayersQueryData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the SportsPlayersQueryData class");
            fieldGeneratorPlayerID = new JSONHoldingStringGenerator("field \"PlayerID\" of the SportsPlayersQueryData class");
            fieldGeneratorTeam = new SportsTeamNewJSON.HoldingGenerator("field \"Team\" of the SportsPlayersQueryData class", false);
            fieldGeneratorDetail = new SportsPlayerDetailJSON.HoldingGenerator("field \"Detail\" of the SportsPlayersQueryData class", false);
            fieldGeneratorPositions = new SportsPlayerPositionJSON.HoldingArrayGenerator("field \"Positions\" of the SportsPlayersQueryData class", false);
            fieldGeneratorPlayersPositionsIndices = new FieldHoldingArrayGeneratorPlayersPositionsIndices("field \"PlayersPositionsIndices\" of the SportsPlayersQueryData class", false);
            fieldGeneratorFallbackPositions = new SportsPlayerPositionJSON.HoldingArrayGenerator("field \"FallbackPositions\" of the SportsPlayersQueryData class", false);
            fieldGeneratorPlayersFallbackPositionsIndices = new FieldHoldingArrayGeneratorPlayersFallbackPositionsIndices("field \"PlayersFallbackPositionsIndices\" of the SportsPlayersQueryData class", false);
            fieldGeneratorJerseyNumber = new FieldHoldingGeneratorJerseyNumber("field \"JerseyNumber\" of the SportsPlayersQueryData class");
            fieldGeneratorPlayersIndices = new FieldHoldingArrayGeneratorPlayersIndices("field \"PlayersIndices\" of the SportsPlayersQueryData class");
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the SportsPlayersQueryData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsPlayersQueryData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorType.reset();
            fieldGeneratorPlayerID.reset();
            fieldGeneratorTeam.reset();
            fieldGeneratorDetail.reset();
            fieldGeneratorPositions.reset();
            fieldGeneratorPlayersPositionsIndices.reset();
            fieldGeneratorFallbackPositions.reset();
            fieldGeneratorPlayersFallbackPositionsIndices.reset();
            fieldGeneratorJerseyNumber.reset();
            fieldGeneratorPlayersIndices.reset();
            fieldGeneratorError.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTeam.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDetail.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPositions.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFallbackPositions.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTeam.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDetail.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPositions.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFallbackPositions.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsPlayersQueryDataJSON  result)
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
        public SportsPlayersQueryDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayersQueryDataJSON  result)
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
    protected virtual void handle_result(List<SportsPlayersQueryDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayersQueryDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayersQueryDataJSON>();
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
    public List<SportsPlayersQueryDataJSON> value;
  };
  };
