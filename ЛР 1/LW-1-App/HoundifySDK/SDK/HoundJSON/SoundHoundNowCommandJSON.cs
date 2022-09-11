/* file "SoundHoundNowCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SoundHoundNowCommandJSON : CommandResultJSON
  {
    public enum TypeClue
      {
        Clue_Music,
        Clue_SoundTrack,
        Clue_Singing,
        Clue_Humming,
        Clue_TV,
        Clue_Movies,
        Clue_Ad,
        Clue_Other
      };

    public static TypeClue  stringToClue(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "d", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeClue.Clue_Ad;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "umming", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeClue.Clue_Humming;
                break;
            case 'M':
                switch (chars[1])
                  {
                    case 'o':
                        if ((String.Compare(chars, 2, "vies", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeClue.Clue_Movies;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "sic", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeClue.Clue_Music;
                        break;
                    default:
                        break;
                  }
                break;
            case 'O':
                if ((String.Compare(chars, 1, "ther", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeClue.Clue_Other;
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'i':
                        if ((String.Compare(chars, 2, "nging", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeClue.Clue_Singing;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "undTrack", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypeClue.Clue_SoundTrack;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(chars, 1, "V", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeClue.Clue_TV;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Clue' is not one of the legal values.");
      }

    public static string  stringFromClue(TypeClue the_enum)
      {
        switch (the_enum)
          {
            case TypeClue.Clue_Music:
                return "Music";
            case TypeClue.Clue_SoundTrack:
                return "SoundTrack";
            case TypeClue.Clue_Singing:
                return "Singing";
            case TypeClue.Clue_Humming:
                return "Humming";
            case TypeClue.Clue_TV:
                return "TV";
            case TypeClue.Clue_Movies:
                return "Movies";
            case TypeClue.Clue_Ad:
                return "Ad";
            case TypeClue.Clue_Other:
                return "Other";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasClue;
    private TypeClue storeClue;
    private bool flagHasLaunchSoundHoundAppResult;
    private DynamicResponseJSON  storeLaunchSoundHoundAppResult;
    private bool flagHasSoundHoundNotInstalledResult;
    private DynamicResponseJSON  storeSoundHoundNotInstalledResult;
    private bool flagHasStartSoundHoundSearchResult;
    private DynamicResponseJSON  storeStartSoundHoundSearchResult;
    private bool flagHasCancelSoundHoundSearchResult;
    private DynamicResponseJSON  storeCancelSoundHoundSearchResult;
    private bool flagHasNoMatchResult;
    private DynamicResponseJSON  storeNoMatchResult;
    private bool flagHasSingleTrackResult;
    private DynamicResponseJSON  storeSingleTrackResult;
    private bool flagHasSingleTrackWithArtistResult;
    private DynamicResponseJSON  storeSingleTrackWithArtistResult;
    private bool flagHasMultipleTracksHighConfidenceResult;
    private DynamicResponseJSON  storeMultipleTracksHighConfidenceResult;
    private bool flagHasMultipleTracksWithArtistHighConfidenceResult;
    private DynamicResponseJSON  storeMultipleTracksWithArtistHighConfidenceResult;
    private bool flagHasMultipleTracksMediumConfidenceResult;
    private DynamicResponseJSON  storeMultipleTracksMediumConfidenceResult;
    private bool flagHasMultipleTracksLowConfidenceResult;
    private DynamicResponseJSON  storeMultipleTracksLowConfidenceResult;
    private bool flagHasOutOfScopeResult;
    private DynamicResponseJSON  storeOutOfScopeResult;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraClueToJSON()
      {
        JSONStringValue generated_string_Clue;
        switch (storeClue)
          {
            case TypeClue.Clue_Music:
                generated_string_Clue = new JSONStringValue("Music");
                break;
            case TypeClue.Clue_SoundTrack:
                generated_string_Clue = new JSONStringValue("SoundTrack");
                break;
            case TypeClue.Clue_Singing:
                generated_string_Clue = new JSONStringValue("Singing");
                break;
            case TypeClue.Clue_Humming:
                generated_string_Clue = new JSONStringValue("Humming");
                break;
            case TypeClue.Clue_TV:
                generated_string_Clue = new JSONStringValue("TV");
                break;
            case TypeClue.Clue_Movies:
                generated_string_Clue = new JSONStringValue("Movies");
                break;
            case TypeClue.Clue_Ad:
                generated_string_Clue = new JSONStringValue("Ad");
                break;
            case TypeClue.Clue_Other:
                generated_string_Clue = new JSONStringValue("Other");
                break;
            default:
                Debug.Assert(false);
                generated_string_Clue = null;
                break;
          }
        return generated_string_Clue;
      }

    private JSONValue  extraLaunchSoundHoundAppResultToJSON()
      {
        JSONValueHandler handler_LaunchSoundHoundAppResult = new JSONValueHandler();
        storeLaunchSoundHoundAppResult.write_as_json(handler_LaunchSoundHoundAppResult);
        return handler_LaunchSoundHoundAppResult.result;
      }

    private JSONValue  extraSoundHoundNotInstalledResultToJSON()
      {
        JSONValueHandler handler_SoundHoundNotInstalledResult = new JSONValueHandler();
        storeSoundHoundNotInstalledResult.write_as_json(handler_SoundHoundNotInstalledResult);
        return handler_SoundHoundNotInstalledResult.result;
      }

    private JSONValue  extraStartSoundHoundSearchResultToJSON()
      {
        JSONValueHandler handler_StartSoundHoundSearchResult = new JSONValueHandler();
        storeStartSoundHoundSearchResult.write_as_json(handler_StartSoundHoundSearchResult);
        return handler_StartSoundHoundSearchResult.result;
      }

    private JSONValue  extraCancelSoundHoundSearchResultToJSON()
      {
        JSONValueHandler handler_CancelSoundHoundSearchResult = new JSONValueHandler();
        storeCancelSoundHoundSearchResult.write_as_json(handler_CancelSoundHoundSearchResult);
        return handler_CancelSoundHoundSearchResult.result;
      }

    private JSONValue  extraNoMatchResultToJSON()
      {
        JSONValueHandler handler_NoMatchResult = new JSONValueHandler();
        storeNoMatchResult.write_as_json(handler_NoMatchResult);
        return handler_NoMatchResult.result;
      }

    private JSONValue  extraSingleTrackResultToJSON()
      {
        JSONValueHandler handler_SingleTrackResult = new JSONValueHandler();
        storeSingleTrackResult.write_as_json(handler_SingleTrackResult);
        return handler_SingleTrackResult.result;
      }

    private JSONValue  extraSingleTrackWithArtistResultToJSON()
      {
        JSONValueHandler handler_SingleTrackWithArtistResult = new JSONValueHandler();
        storeSingleTrackWithArtistResult.write_as_json(handler_SingleTrackWithArtistResult);
        return handler_SingleTrackWithArtistResult.result;
      }

    private JSONValue  extraMultipleTracksHighConfidenceResultToJSON()
      {
        JSONValueHandler handler_MultipleTracksHighConfidenceResult = new JSONValueHandler();
        storeMultipleTracksHighConfidenceResult.write_as_json(handler_MultipleTracksHighConfidenceResult);
        return handler_MultipleTracksHighConfidenceResult.result;
      }

    private JSONValue  extraMultipleTracksWithArtistHighConfidenceResultToJSON()
      {
        JSONValueHandler handler_MultipleTracksWithArtistHighConfidenceResult = new JSONValueHandler();
        storeMultipleTracksWithArtistHighConfidenceResult.write_as_json(handler_MultipleTracksWithArtistHighConfidenceResult);
        return handler_MultipleTracksWithArtistHighConfidenceResult.result;
      }

    private JSONValue  extraMultipleTracksMediumConfidenceResultToJSON()
      {
        JSONValueHandler handler_MultipleTracksMediumConfidenceResult = new JSONValueHandler();
        storeMultipleTracksMediumConfidenceResult.write_as_json(handler_MultipleTracksMediumConfidenceResult);
        return handler_MultipleTracksMediumConfidenceResult.result;
      }

    private JSONValue  extraMultipleTracksLowConfidenceResultToJSON()
      {
        JSONValueHandler handler_MultipleTracksLowConfidenceResult = new JSONValueHandler();
        storeMultipleTracksLowConfidenceResult.write_as_json(handler_MultipleTracksLowConfidenceResult);
        return handler_MultipleTracksLowConfidenceResult.result;
      }

    private JSONValue  extraOutOfScopeResultToJSON()
      {
        JSONValueHandler handler_OutOfScopeResult = new JSONValueHandler();
        storeOutOfScopeResult.write_as_json(handler_OutOfScopeResult);
        return handler_OutOfScopeResult.result;
      }


    private void  fromJSONClue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Clue of SoundHoundNowCommandJSON is not a string.");
        TypeClue the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "d", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = TypeClue.Clue_Ad;
                        goto enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "umming", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeClue.Clue_Humming;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "vies", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_enum = TypeClue.Clue_Movies;
                                goto enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "sic", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_enum = TypeClue.Clue_Music;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "ther", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeClue.Clue_Other;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "nging", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_enum = TypeClue.Clue_Singing;
                                goto enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "undTrack", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_enum = TypeClue.Clue_SoundTrack;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "V", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = TypeClue.Clue_TV;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Clue of SoundHoundNowCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setClue(the_enum);
      }


    private void  fromJSONLaunchSoundHoundAppResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setLaunchSoundHoundAppResult(convert_classy);
      }


    private void  fromJSONSoundHoundNotInstalledResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setSoundHoundNotInstalledResult(convert_classy);
      }


    private void  fromJSONStartSoundHoundSearchResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setStartSoundHoundSearchResult(convert_classy);
      }


    private void  fromJSONCancelSoundHoundSearchResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setCancelSoundHoundSearchResult(convert_classy);
      }


    private void  fromJSONNoMatchResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setNoMatchResult(convert_classy);
      }


    private void  fromJSONSingleTrackResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setSingleTrackResult(convert_classy);
      }


    private void  fromJSONSingleTrackWithArtistResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setSingleTrackWithArtistResult(convert_classy);
      }


    private void  fromJSONMultipleTracksHighConfidenceResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setMultipleTracksHighConfidenceResult(convert_classy);
      }


    private void  fromJSONMultipleTracksWithArtistHighConfidenceResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setMultipleTracksWithArtistHighConfidenceResult(convert_classy);
      }


    private void  fromJSONMultipleTracksMediumConfidenceResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setMultipleTracksMediumConfidenceResult(convert_classy);
      }


    private void  fromJSONMultipleTracksLowConfidenceResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setMultipleTracksLowConfidenceResult(convert_classy);
      }


    private void  fromJSONOutOfScopeResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setOutOfScopeResult(convert_classy);
      }


    public SoundHoundNowCommandJSON()
      {
        flagHasClue = false;
        flagHasLaunchSoundHoundAppResult = false;
        flagHasSoundHoundNotInstalledResult = false;
        flagHasStartSoundHoundSearchResult = false;
        flagHasCancelSoundHoundSearchResult = false;
        flagHasNoMatchResult = false;
        flagHasSingleTrackResult = false;
        flagHasSingleTrackWithArtistResult = false;
        flagHasMultipleTracksHighConfidenceResult = false;
        flagHasMultipleTracksWithArtistHighConfidenceResult = false;
        flagHasMultipleTracksMediumConfidenceResult = false;
        flagHasMultipleTracksLowConfidenceResult = false;
        flagHasOutOfScopeResult = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandKind()
      {
        return "SoundHoundNowCommand";
      }

    public bool  hasClue()
      {
        return flagHasClue;
      }

    public TypeClue  getClue()
      {
        Debug.Assert(flagHasClue);
        return storeClue;
      }

    public string  getClueAsString()
      {
        return stringFromClue(getClue());
      }

    public bool  hasLaunchSoundHoundAppResult()
      {
        return flagHasLaunchSoundHoundAppResult;
      }

    public DynamicResponseJSON   getLaunchSoundHoundAppResult()
      {
        Debug.Assert(flagHasLaunchSoundHoundAppResult);
        return storeLaunchSoundHoundAppResult;
      }

    public bool  hasSoundHoundNotInstalledResult()
      {
        return flagHasSoundHoundNotInstalledResult;
      }

    public DynamicResponseJSON   getSoundHoundNotInstalledResult()
      {
        Debug.Assert(flagHasSoundHoundNotInstalledResult);
        return storeSoundHoundNotInstalledResult;
      }

    public bool  hasStartSoundHoundSearchResult()
      {
        return flagHasStartSoundHoundSearchResult;
      }

    public DynamicResponseJSON   getStartSoundHoundSearchResult()
      {
        Debug.Assert(flagHasStartSoundHoundSearchResult);
        return storeStartSoundHoundSearchResult;
      }

    public bool  hasCancelSoundHoundSearchResult()
      {
        return flagHasCancelSoundHoundSearchResult;
      }

    public DynamicResponseJSON   getCancelSoundHoundSearchResult()
      {
        Debug.Assert(flagHasCancelSoundHoundSearchResult);
        return storeCancelSoundHoundSearchResult;
      }

    public bool  hasNoMatchResult()
      {
        return flagHasNoMatchResult;
      }

    public DynamicResponseJSON   getNoMatchResult()
      {
        Debug.Assert(flagHasNoMatchResult);
        return storeNoMatchResult;
      }

    public bool  hasSingleTrackResult()
      {
        return flagHasSingleTrackResult;
      }

    public DynamicResponseJSON   getSingleTrackResult()
      {
        Debug.Assert(flagHasSingleTrackResult);
        return storeSingleTrackResult;
      }

    public bool  hasSingleTrackWithArtistResult()
      {
        return flagHasSingleTrackWithArtistResult;
      }

    public DynamicResponseJSON   getSingleTrackWithArtistResult()
      {
        Debug.Assert(flagHasSingleTrackWithArtistResult);
        return storeSingleTrackWithArtistResult;
      }

    public bool  hasMultipleTracksHighConfidenceResult()
      {
        return flagHasMultipleTracksHighConfidenceResult;
      }

    public DynamicResponseJSON   getMultipleTracksHighConfidenceResult()
      {
        Debug.Assert(flagHasMultipleTracksHighConfidenceResult);
        return storeMultipleTracksHighConfidenceResult;
      }

    public bool  hasMultipleTracksWithArtistHighConfidenceResult()
      {
        return flagHasMultipleTracksWithArtistHighConfidenceResult;
      }

    public DynamicResponseJSON   getMultipleTracksWithArtistHighConfidenceResult()
      {
        Debug.Assert(flagHasMultipleTracksWithArtistHighConfidenceResult);
        return storeMultipleTracksWithArtistHighConfidenceResult;
      }

    public bool  hasMultipleTracksMediumConfidenceResult()
      {
        return flagHasMultipleTracksMediumConfidenceResult;
      }

    public DynamicResponseJSON   getMultipleTracksMediumConfidenceResult()
      {
        Debug.Assert(flagHasMultipleTracksMediumConfidenceResult);
        return storeMultipleTracksMediumConfidenceResult;
      }

    public bool  hasMultipleTracksLowConfidenceResult()
      {
        return flagHasMultipleTracksLowConfidenceResult;
      }

    public DynamicResponseJSON   getMultipleTracksLowConfidenceResult()
      {
        Debug.Assert(flagHasMultipleTracksLowConfidenceResult);
        return storeMultipleTracksLowConfidenceResult;
      }

    public bool  hasOutOfScopeResult()
      {
        return flagHasOutOfScopeResult;
      }

    public DynamicResponseJSON   getOutOfScopeResult()
      {
        Debug.Assert(flagHasOutOfScopeResult);
        return storeOutOfScopeResult;
      }


    public virtual int extraSoundHoundNowCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSoundHoundNowCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSoundHoundNowCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSoundHoundNowCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasClue)
            ++result;
        if (flagHasLaunchSoundHoundAppResult)
            ++result;
        if (flagHasSoundHoundNotInstalledResult)
            ++result;
        if (flagHasStartSoundHoundSearchResult)
            ++result;
        if (flagHasCancelSoundHoundSearchResult)
            ++result;
        if (flagHasNoMatchResult)
            ++result;
        if (flagHasSingleTrackResult)
            ++result;
        if (flagHasSingleTrackWithArtistResult)
            ++result;
        if (flagHasMultipleTracksHighConfidenceResult)
            ++result;
        if (flagHasMultipleTracksWithArtistHighConfidenceResult)
            ++result;
        if (flagHasMultipleTracksMediumConfidenceResult)
            ++result;
        if (flagHasMultipleTracksLowConfidenceResult)
            ++result;
        if (flagHasOutOfScopeResult)
            ++result;
        result += extraSoundHoundNowCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasClue)
          {
            if (remainder == 0)
                return "Clue";
            --remainder;
          }
        if (flagHasLaunchSoundHoundAppResult)
          {
            if (remainder == 0)
                return "LaunchSoundHoundAppResult";
            --remainder;
          }
        if (flagHasSoundHoundNotInstalledResult)
          {
            if (remainder == 0)
                return "SoundHoundNotInstalledResult";
            --remainder;
          }
        if (flagHasStartSoundHoundSearchResult)
          {
            if (remainder == 0)
                return "StartSoundHoundSearchResult";
            --remainder;
          }
        if (flagHasCancelSoundHoundSearchResult)
          {
            if (remainder == 0)
                return "CancelSoundHoundSearchResult";
            --remainder;
          }
        if (flagHasNoMatchResult)
          {
            if (remainder == 0)
                return "NoMatchResult";
            --remainder;
          }
        if (flagHasSingleTrackResult)
          {
            if (remainder == 0)
                return "SingleTrackResult";
            --remainder;
          }
        if (flagHasSingleTrackWithArtistResult)
          {
            if (remainder == 0)
                return "SingleTrackWithArtistResult";
            --remainder;
          }
        if (flagHasMultipleTracksHighConfidenceResult)
          {
            if (remainder == 0)
                return "MultipleTracksHighConfidenceResult";
            --remainder;
          }
        if (flagHasMultipleTracksWithArtistHighConfidenceResult)
          {
            if (remainder == 0)
                return "MultipleTracksWithArtistHighConfidenceResult";
            --remainder;
          }
        if (flagHasMultipleTracksMediumConfidenceResult)
          {
            if (remainder == 0)
                return "MultipleTracksMediumConfidenceResult";
            --remainder;
          }
        if (flagHasMultipleTracksLowConfidenceResult)
          {
            if (remainder == 0)
                return "MultipleTracksLowConfidenceResult";
            --remainder;
          }
        if (flagHasOutOfScopeResult)
          {
            if (remainder == 0)
                return "OutOfScopeResult";
            --remainder;
          }
        return extraSoundHoundNowCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasClue)
          {
            if (remainder == 0)
                return extraClueToJSON();
            --remainder;
          }
        if (flagHasLaunchSoundHoundAppResult)
          {
            if (remainder == 0)
                return extraLaunchSoundHoundAppResultToJSON();
            --remainder;
          }
        if (flagHasSoundHoundNotInstalledResult)
          {
            if (remainder == 0)
                return extraSoundHoundNotInstalledResultToJSON();
            --remainder;
          }
        if (flagHasStartSoundHoundSearchResult)
          {
            if (remainder == 0)
                return extraStartSoundHoundSearchResultToJSON();
            --remainder;
          }
        if (flagHasCancelSoundHoundSearchResult)
          {
            if (remainder == 0)
                return extraCancelSoundHoundSearchResultToJSON();
            --remainder;
          }
        if (flagHasNoMatchResult)
          {
            if (remainder == 0)
                return extraNoMatchResultToJSON();
            --remainder;
          }
        if (flagHasSingleTrackResult)
          {
            if (remainder == 0)
                return extraSingleTrackResultToJSON();
            --remainder;
          }
        if (flagHasSingleTrackWithArtistResult)
          {
            if (remainder == 0)
                return extraSingleTrackWithArtistResultToJSON();
            --remainder;
          }
        if (flagHasMultipleTracksHighConfidenceResult)
          {
            if (remainder == 0)
                return extraMultipleTracksHighConfidenceResultToJSON();
            --remainder;
          }
        if (flagHasMultipleTracksWithArtistHighConfidenceResult)
          {
            if (remainder == 0)
                return extraMultipleTracksWithArtistHighConfidenceResultToJSON();
            --remainder;
          }
        if (flagHasMultipleTracksMediumConfidenceResult)
          {
            if (remainder == 0)
                return extraMultipleTracksMediumConfidenceResultToJSON();
            --remainder;
          }
        if (flagHasMultipleTracksLowConfidenceResult)
          {
            if (remainder == 0)
                return extraMultipleTracksLowConfidenceResultToJSON();
            --remainder;
          }
        if (flagHasOutOfScopeResult)
          {
            if (remainder == 0)
                return extraOutOfScopeResultToJSON();
            --remainder;
          }
        return extraSoundHoundNowCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "ncelSoundHoundSearchResult", 0, 26, false) == 0) && (field_name.Length == 28))
                            return (flagHasCancelSoundHoundSearchResult ? extraCancelSoundHoundSearchResultToJSON() : null);
                        break;
                    case 'l':
                        if ((String.Compare(field_name, 2, "ue", 0, 2, false) == 0) && (field_name.Length == 4))
                            return (flagHasClue ? extraClueToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "aunchSoundHoundAppResult", 0, 24, false) == 0) && (field_name.Length == 25))
                    return (flagHasLaunchSoundHoundAppResult ? extraLaunchSoundHoundAppResultToJSON() : null);
                break;
            case 'M':
                if (String.Compare(field_name, 1, "ultipleTracks", 0, 13, false) == 0)
                  {
                    switch (field_name[14])
                      {
                        case 'H':
                            if ((String.Compare(field_name, 15, "ighConfidenceResult", 0, 19, false) == 0) && (field_name.Length == 34))
                                return (flagHasMultipleTracksHighConfidenceResult ? extraMultipleTracksHighConfidenceResultToJSON() : null);
                            break;
                        case 'L':
                            if ((String.Compare(field_name, 15, "owConfidenceResult", 0, 18, false) == 0) && (field_name.Length == 33))
                                return (flagHasMultipleTracksLowConfidenceResult ? extraMultipleTracksLowConfidenceResultToJSON() : null);
                            break;
                        case 'M':
                            if ((String.Compare(field_name, 15, "ediumConfidenceResult", 0, 21, false) == 0) && (field_name.Length == 36))
                                return (flagHasMultipleTracksMediumConfidenceResult ? extraMultipleTracksMediumConfidenceResultToJSON() : null);
                            break;
                        case 'W':
                            if ((String.Compare(field_name, 15, "ithArtistHighConfidenceResult", 0, 29, false) == 0) && (field_name.Length == 44))
                                return (flagHasMultipleTracksWithArtistHighConfidenceResult ? extraMultipleTracksWithArtistHighConfidenceResultToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "oMatchResult", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasNoMatchResult ? extraNoMatchResultToJSON() : null);
                break;
            case 'O':
                if ((String.Compare(field_name, 1, "utOfScopeResult", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasOutOfScopeResult ? extraOutOfScopeResultToJSON() : null);
                break;
            case 'S':
                switch (field_name[1])
                  {
                    case 'i':
                        if (String.Compare(field_name, 2, "ngleTrack", 0, 9, false) == 0)
                          {
                            switch (field_name[11])
                              {
                                case 'R':
                                    if ((String.Compare(field_name, 12, "esult", 0, 5, false) == 0) && (field_name.Length == 17))
                                        return (flagHasSingleTrackResult ? extraSingleTrackResultToJSON() : null);
                                    break;
                                case 'W':
                                    if ((String.Compare(field_name, 12, "ithArtistResult", 0, 15, false) == 0) && (field_name.Length == 27))
                                        return (flagHasSingleTrackWithArtistResult ? extraSingleTrackWithArtistResultToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if ((String.Compare(field_name, 2, "undHoundNotInstalledResult", 0, 26, false) == 0) && (field_name.Length == 28))
                            return (flagHasSoundHoundNotInstalledResult ? extraSoundHoundNotInstalledResultToJSON() : null);
                        break;
                    case 't':
                        if ((String.Compare(field_name, 2, "artSoundHoundSearchResult", 0, 25, false) == 0) && (field_name.Length == 27))
                            return (flagHasStartSoundHoundSearchResult ? extraStartSoundHoundSearchResultToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return extraSoundHoundNowCommandLookup(field_name);
      }

    public void setClue(TypeClue new_value)
      {
        flagHasClue = true;
        storeClue = new_value;
      }
    public void setClue(string chars)
      {
        setClue(stringToClue(chars));
      }
    public void unsetClue()
      {
        flagHasClue = false;
      }
    public void setLaunchSoundHoundAppResult(DynamicResponseJSON  new_value)
      {
        if (flagHasLaunchSoundHoundAppResult)
          {
          }
        flagHasLaunchSoundHoundAppResult = true;
        storeLaunchSoundHoundAppResult = new_value;
      }
    public void unsetLaunchSoundHoundAppResult()
      {
        if (flagHasLaunchSoundHoundAppResult)
          {
          }
        flagHasLaunchSoundHoundAppResult = false;
      }
    public void setSoundHoundNotInstalledResult(DynamicResponseJSON  new_value)
      {
        if (flagHasSoundHoundNotInstalledResult)
          {
          }
        flagHasSoundHoundNotInstalledResult = true;
        storeSoundHoundNotInstalledResult = new_value;
      }
    public void unsetSoundHoundNotInstalledResult()
      {
        if (flagHasSoundHoundNotInstalledResult)
          {
          }
        flagHasSoundHoundNotInstalledResult = false;
      }
    public void setStartSoundHoundSearchResult(DynamicResponseJSON  new_value)
      {
        if (flagHasStartSoundHoundSearchResult)
          {
          }
        flagHasStartSoundHoundSearchResult = true;
        storeStartSoundHoundSearchResult = new_value;
      }
    public void unsetStartSoundHoundSearchResult()
      {
        if (flagHasStartSoundHoundSearchResult)
          {
          }
        flagHasStartSoundHoundSearchResult = false;
      }
    public void setCancelSoundHoundSearchResult(DynamicResponseJSON  new_value)
      {
        if (flagHasCancelSoundHoundSearchResult)
          {
          }
        flagHasCancelSoundHoundSearchResult = true;
        storeCancelSoundHoundSearchResult = new_value;
      }
    public void unsetCancelSoundHoundSearchResult()
      {
        if (flagHasCancelSoundHoundSearchResult)
          {
          }
        flagHasCancelSoundHoundSearchResult = false;
      }
    public void setNoMatchResult(DynamicResponseJSON  new_value)
      {
        if (flagHasNoMatchResult)
          {
          }
        flagHasNoMatchResult = true;
        storeNoMatchResult = new_value;
      }
    public void unsetNoMatchResult()
      {
        if (flagHasNoMatchResult)
          {
          }
        flagHasNoMatchResult = false;
      }
    public void setSingleTrackResult(DynamicResponseJSON  new_value)
      {
        if (flagHasSingleTrackResult)
          {
          }
        flagHasSingleTrackResult = true;
        storeSingleTrackResult = new_value;
      }
    public void unsetSingleTrackResult()
      {
        if (flagHasSingleTrackResult)
          {
          }
        flagHasSingleTrackResult = false;
      }
    public void setSingleTrackWithArtistResult(DynamicResponseJSON  new_value)
      {
        if (flagHasSingleTrackWithArtistResult)
          {
          }
        flagHasSingleTrackWithArtistResult = true;
        storeSingleTrackWithArtistResult = new_value;
      }
    public void unsetSingleTrackWithArtistResult()
      {
        if (flagHasSingleTrackWithArtistResult)
          {
          }
        flagHasSingleTrackWithArtistResult = false;
      }
    public void setMultipleTracksHighConfidenceResult(DynamicResponseJSON  new_value)
      {
        if (flagHasMultipleTracksHighConfidenceResult)
          {
          }
        flagHasMultipleTracksHighConfidenceResult = true;
        storeMultipleTracksHighConfidenceResult = new_value;
      }
    public void unsetMultipleTracksHighConfidenceResult()
      {
        if (flagHasMultipleTracksHighConfidenceResult)
          {
          }
        flagHasMultipleTracksHighConfidenceResult = false;
      }
    public void setMultipleTracksWithArtistHighConfidenceResult(DynamicResponseJSON  new_value)
      {
        if (flagHasMultipleTracksWithArtistHighConfidenceResult)
          {
          }
        flagHasMultipleTracksWithArtistHighConfidenceResult = true;
        storeMultipleTracksWithArtistHighConfidenceResult = new_value;
      }
    public void unsetMultipleTracksWithArtistHighConfidenceResult()
      {
        if (flagHasMultipleTracksWithArtistHighConfidenceResult)
          {
          }
        flagHasMultipleTracksWithArtistHighConfidenceResult = false;
      }
    public void setMultipleTracksMediumConfidenceResult(DynamicResponseJSON  new_value)
      {
        if (flagHasMultipleTracksMediumConfidenceResult)
          {
          }
        flagHasMultipleTracksMediumConfidenceResult = true;
        storeMultipleTracksMediumConfidenceResult = new_value;
      }
    public void unsetMultipleTracksMediumConfidenceResult()
      {
        if (flagHasMultipleTracksMediumConfidenceResult)
          {
          }
        flagHasMultipleTracksMediumConfidenceResult = false;
      }
    public void setMultipleTracksLowConfidenceResult(DynamicResponseJSON  new_value)
      {
        if (flagHasMultipleTracksLowConfidenceResult)
          {
          }
        flagHasMultipleTracksLowConfidenceResult = true;
        storeMultipleTracksLowConfidenceResult = new_value;
      }
    public void unsetMultipleTracksLowConfidenceResult()
      {
        if (flagHasMultipleTracksLowConfidenceResult)
          {
          }
        flagHasMultipleTracksLowConfidenceResult = false;
      }
    public void setOutOfScopeResult(DynamicResponseJSON  new_value)
      {
        if (flagHasOutOfScopeResult)
          {
          }
        flagHasOutOfScopeResult = true;
        storeOutOfScopeResult = new_value;
      }
    public void unsetOutOfScopeResult()
      {
        if (flagHasOutOfScopeResult)
          {
          }
        flagHasOutOfScopeResult = false;
      }

    public virtual void extraSoundHoundNowCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSoundHoundNowCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSoundHoundNowCommandLookup(key);
        if (old_field == null)
          {
            extraSoundHoundNowCommandAppendPair(key, new_component);
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
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "ncelSoundHoundSearchResult", 0, 26, false) == 0) && (key.Length == 28))
                            {
                            fromJSONCancelSoundHoundSearchResult(new_component, false);
                            return;
                            }
                        break;
                    case 'l':
                        if ((String.Compare(key, 2, "ue", 0, 2, false) == 0) && (key.Length == 4))
                            {
                            fromJSONClue(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(key, 1, "aunchSoundHoundAppResult", 0, 24, false) == 0) && (key.Length == 25))
                    {
                    fromJSONLaunchSoundHoundAppResult(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if (String.Compare(key, 1, "ultipleTracks", 0, 13, false) == 0)
                  {
                    switch (key[14])
                      {
                        case 'H':
                            if ((String.Compare(key, 15, "ighConfidenceResult", 0, 19, false) == 0) && (key.Length == 34))
                                {
                                fromJSONMultipleTracksHighConfidenceResult(new_component, false);
                                return;
                                }
                            break;
                        case 'L':
                            if ((String.Compare(key, 15, "owConfidenceResult", 0, 18, false) == 0) && (key.Length == 33))
                                {
                                fromJSONMultipleTracksLowConfidenceResult(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 15, "ediumConfidenceResult", 0, 21, false) == 0) && (key.Length == 36))
                                {
                                fromJSONMultipleTracksMediumConfidenceResult(new_component, false);
                                return;
                                }
                            break;
                        case 'W':
                            if ((String.Compare(key, 15, "ithArtistHighConfidenceResult", 0, 29, false) == 0) && (key.Length == 44))
                                {
                                fromJSONMultipleTracksWithArtistHighConfidenceResult(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(key, 1, "oMatchResult", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONNoMatchResult(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "utOfScopeResult", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONOutOfScopeResult(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'i':
                        if (String.Compare(key, 2, "ngleTrack", 0, 9, false) == 0)
                          {
                            switch (key[11])
                              {
                                case 'R':
                                    if ((String.Compare(key, 12, "esult", 0, 5, false) == 0) && (key.Length == 17))
                                        {
                                        fromJSONSingleTrackResult(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'W':
                                    if ((String.Compare(key, 12, "ithArtistResult", 0, 15, false) == 0) && (key.Length == 27))
                                        {
                                        fromJSONSingleTrackWithArtistResult(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "undHoundNotInstalledResult", 0, 26, false) == 0) && (key.Length == 28))
                            {
                            fromJSONSoundHoundNotInstalledResult(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "artSoundHoundSearchResult", 0, 25, false) == 0) && (key.Length == 27))
                            {
                            fromJSONStartSoundHoundSearchResult(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraSoundHoundNowCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "ncelSoundHoundSearchResult", 0, 26, false) == 0) && (key.Length == 28))
                            {
                            fromJSONCancelSoundHoundSearchResult(new_component, false);
                            return;
                            }
                        break;
                    case 'l':
                        if ((String.Compare(key, 2, "ue", 0, 2, false) == 0) && (key.Length == 4))
                            {
                            fromJSONClue(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(key, 1, "aunchSoundHoundAppResult", 0, 24, false) == 0) && (key.Length == 25))
                    {
                    fromJSONLaunchSoundHoundAppResult(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if (String.Compare(key, 1, "ultipleTracks", 0, 13, false) == 0)
                  {
                    switch (key[14])
                      {
                        case 'H':
                            if ((String.Compare(key, 15, "ighConfidenceResult", 0, 19, false) == 0) && (key.Length == 34))
                                {
                                fromJSONMultipleTracksHighConfidenceResult(new_component, false);
                                return;
                                }
                            break;
                        case 'L':
                            if ((String.Compare(key, 15, "owConfidenceResult", 0, 18, false) == 0) && (key.Length == 33))
                                {
                                fromJSONMultipleTracksLowConfidenceResult(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 15, "ediumConfidenceResult", 0, 21, false) == 0) && (key.Length == 36))
                                {
                                fromJSONMultipleTracksMediumConfidenceResult(new_component, false);
                                return;
                                }
                            break;
                        case 'W':
                            if ((String.Compare(key, 15, "ithArtistHighConfidenceResult", 0, 29, false) == 0) && (key.Length == 44))
                                {
                                fromJSONMultipleTracksWithArtistHighConfidenceResult(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(key, 1, "oMatchResult", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONNoMatchResult(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "utOfScopeResult", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONOutOfScopeResult(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'i':
                        if (String.Compare(key, 2, "ngleTrack", 0, 9, false) == 0)
                          {
                            switch (key[11])
                              {
                                case 'R':
                                    if ((String.Compare(key, 12, "esult", 0, 5, false) == 0) && (key.Length == 17))
                                        {
                                        fromJSONSingleTrackResult(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'W':
                                    if ((String.Compare(key, 12, "ithArtistResult", 0, 15, false) == 0) && (key.Length == 27))
                                        {
                                        fromJSONSingleTrackWithArtistResult(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "undHoundNotInstalledResult", 0, 26, false) == 0) && (key.Length == 28))
                            {
                            fromJSONSoundHoundNotInstalledResult(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "artSoundHoundSearchResult", 0, 25, false) == 0) && (key.Length == 27))
                            {
                            fromJSONStartSoundHoundSearchResult(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraSoundHoundNowCommandSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        if (flagHasClue)
          {
            handler.start_pair("Clue");
            switch (storeClue)
              {
                case TypeClue.Clue_Music:
                    handler.string_value("Music");
                    break;
                case TypeClue.Clue_SoundTrack:
                    handler.string_value("SoundTrack");
                    break;
                case TypeClue.Clue_Singing:
                    handler.string_value("Singing");
                    break;
                case TypeClue.Clue_Humming:
                    handler.string_value("Humming");
                    break;
                case TypeClue.Clue_TV:
                    handler.string_value("TV");
                    break;
                case TypeClue.Clue_Movies:
                    handler.string_value("Movies");
                    break;
                case TypeClue.Clue_Ad:
                    handler.string_value("Ad");
                    break;
                case TypeClue.Clue_Other:
                    handler.string_value("Other");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasLaunchSoundHoundAppResult)
          {
            handler.start_pair("LaunchSoundHoundAppResult");
            if (partial_allowed)
                storeLaunchSoundHoundAppResult.write_partial_as_json(handler);
            else
                storeLaunchSoundHoundAppResult.write_as_json(handler);
          }
        if (flagHasSoundHoundNotInstalledResult)
          {
            handler.start_pair("SoundHoundNotInstalledResult");
            if (partial_allowed)
                storeSoundHoundNotInstalledResult.write_partial_as_json(handler);
            else
                storeSoundHoundNotInstalledResult.write_as_json(handler);
          }
        if (flagHasStartSoundHoundSearchResult)
          {
            handler.start_pair("StartSoundHoundSearchResult");
            if (partial_allowed)
                storeStartSoundHoundSearchResult.write_partial_as_json(handler);
            else
                storeStartSoundHoundSearchResult.write_as_json(handler);
          }
        if (flagHasCancelSoundHoundSearchResult)
          {
            handler.start_pair("CancelSoundHoundSearchResult");
            if (partial_allowed)
                storeCancelSoundHoundSearchResult.write_partial_as_json(handler);
            else
                storeCancelSoundHoundSearchResult.write_as_json(handler);
          }
        if (flagHasNoMatchResult)
          {
            handler.start_pair("NoMatchResult");
            if (partial_allowed)
                storeNoMatchResult.write_partial_as_json(handler);
            else
                storeNoMatchResult.write_as_json(handler);
          }
        if (flagHasSingleTrackResult)
          {
            handler.start_pair("SingleTrackResult");
            if (partial_allowed)
                storeSingleTrackResult.write_partial_as_json(handler);
            else
                storeSingleTrackResult.write_as_json(handler);
          }
        if (flagHasSingleTrackWithArtistResult)
          {
            handler.start_pair("SingleTrackWithArtistResult");
            if (partial_allowed)
                storeSingleTrackWithArtistResult.write_partial_as_json(handler);
            else
                storeSingleTrackWithArtistResult.write_as_json(handler);
          }
        if (flagHasMultipleTracksHighConfidenceResult)
          {
            handler.start_pair("MultipleTracksHighConfidenceResult");
            if (partial_allowed)
                storeMultipleTracksHighConfidenceResult.write_partial_as_json(handler);
            else
                storeMultipleTracksHighConfidenceResult.write_as_json(handler);
          }
        if (flagHasMultipleTracksWithArtistHighConfidenceResult)
          {
            handler.start_pair("MultipleTracksWithArtistHighConfidenceResult");
            if (partial_allowed)
                storeMultipleTracksWithArtistHighConfidenceResult.write_partial_as_json(handler);
            else
                storeMultipleTracksWithArtistHighConfidenceResult.write_as_json(handler);
          }
        if (flagHasMultipleTracksMediumConfidenceResult)
          {
            handler.start_pair("MultipleTracksMediumConfidenceResult");
            if (partial_allowed)
                storeMultipleTracksMediumConfidenceResult.write_partial_as_json(handler);
            else
                storeMultipleTracksMediumConfidenceResult.write_as_json(handler);
          }
        if (flagHasMultipleTracksLowConfidenceResult)
          {
            handler.start_pair("MultipleTracksLowConfidenceResult");
            if (partial_allowed)
                storeMultipleTracksLowConfidenceResult.write_partial_as_json(handler);
            else
                storeMultipleTracksLowConfidenceResult.write_as_json(handler);
          }
        if (flagHasOutOfScopeResult)
          {
            handler.start_pair("OutOfScopeResult");
            if (partial_allowed)
                storeOutOfScopeResult.write_partial_as_json(handler);
            else
                storeOutOfScopeResult.write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new SoundHoundNowCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SoundHoundNowCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SoundHoundNowCommand", ignore_extras);
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
    public static new SoundHoundNowCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SoundHoundNowCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SoundHoundNowCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SoundHoundNowCommand", ignore_extras);
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
    public static new SoundHoundNowCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SoundHoundNowCommandJSON from_text(string text, bool ignore_extras)
      {
        SoundHoundNowCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SoundHoundNowCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SoundHoundNowCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SoundHoundNowCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SoundHoundNowCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SoundHoundNowCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
    private abstract class FieldGeneratorClue : JSONStringGenerator
          {
            protected FieldGeneratorClue(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorClue()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToClue(result));
              }
            protected abstract void handle_result(TypeClue result);
          };
    private class FieldHoldingGeneratorClue : FieldGeneratorClue
  {
    protected override void handle_result(TypeClue result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorClue(String what)
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
    public TypeClue value;
  };
    private class FieldHoldingArrayGeneratorClue : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorClue
      {
        private FieldHoldingArrayGeneratorClue top;

        protected override void handle_result(TypeClue result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorClue init_top)
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
    protected virtual void handle_result(List<TypeClue> result)
      {
      }

    public FieldHoldingArrayGeneratorClue(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeClue>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorClue()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeClue>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeClue> value;
  };
        private FieldHoldingGeneratorClue fieldGeneratorClue;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorLaunchSoundHoundAppResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorSoundHoundNotInstalledResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorStartSoundHoundSearchResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorCancelSoundHoundSearchResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorNoMatchResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorSingleTrackResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorSingleTrackWithArtistResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorMultipleTracksHighConfidenceResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorMultipleTracksWithArtistHighConfidenceResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorMultipleTracksMediumConfidenceResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorMultipleTracksLowConfidenceResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorOutOfScopeResult;
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
            if (!(getCommandResultJSONKey().Equals("SoundHoundNowCommand")))
                throw new Exception("The key field has a value other than `SoundHoundNowCommand'.");
            SoundHoundNowCommandJSON result = new SoundHoundNowCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSoundHoundNowCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((SoundHoundNowCommandJSON )new_result);
          }
        protected void finish(SoundHoundNowCommandJSON result)
          {
            if (fieldGeneratorClue.have_value)
              {
                result.setClue(fieldGeneratorClue.value);
                fieldGeneratorClue.have_value = false;
              }
            if (fieldGeneratorLaunchSoundHoundAppResult.have_value)
              {
                result.setLaunchSoundHoundAppResult(fieldGeneratorLaunchSoundHoundAppResult.value);
                fieldGeneratorLaunchSoundHoundAppResult.have_value = false;
              }
            if (fieldGeneratorSoundHoundNotInstalledResult.have_value)
              {
                result.setSoundHoundNotInstalledResult(fieldGeneratorSoundHoundNotInstalledResult.value);
                fieldGeneratorSoundHoundNotInstalledResult.have_value = false;
              }
            if (fieldGeneratorStartSoundHoundSearchResult.have_value)
              {
                result.setStartSoundHoundSearchResult(fieldGeneratorStartSoundHoundSearchResult.value);
                fieldGeneratorStartSoundHoundSearchResult.have_value = false;
              }
            if (fieldGeneratorCancelSoundHoundSearchResult.have_value)
              {
                result.setCancelSoundHoundSearchResult(fieldGeneratorCancelSoundHoundSearchResult.value);
                fieldGeneratorCancelSoundHoundSearchResult.have_value = false;
              }
            if (fieldGeneratorNoMatchResult.have_value)
              {
                result.setNoMatchResult(fieldGeneratorNoMatchResult.value);
                fieldGeneratorNoMatchResult.have_value = false;
              }
            if (fieldGeneratorSingleTrackResult.have_value)
              {
                result.setSingleTrackResult(fieldGeneratorSingleTrackResult.value);
                fieldGeneratorSingleTrackResult.have_value = false;
              }
            if (fieldGeneratorSingleTrackWithArtistResult.have_value)
              {
                result.setSingleTrackWithArtistResult(fieldGeneratorSingleTrackWithArtistResult.value);
                fieldGeneratorSingleTrackWithArtistResult.have_value = false;
              }
            if (fieldGeneratorMultipleTracksHighConfidenceResult.have_value)
              {
                result.setMultipleTracksHighConfidenceResult(fieldGeneratorMultipleTracksHighConfidenceResult.value);
                fieldGeneratorMultipleTracksHighConfidenceResult.have_value = false;
              }
            if (fieldGeneratorMultipleTracksWithArtistHighConfidenceResult.have_value)
              {
                result.setMultipleTracksWithArtistHighConfidenceResult(fieldGeneratorMultipleTracksWithArtistHighConfidenceResult.value);
                fieldGeneratorMultipleTracksWithArtistHighConfidenceResult.have_value = false;
              }
            if (fieldGeneratorMultipleTracksMediumConfidenceResult.have_value)
              {
                result.setMultipleTracksMediumConfidenceResult(fieldGeneratorMultipleTracksMediumConfidenceResult.value);
                fieldGeneratorMultipleTracksMediumConfidenceResult.have_value = false;
              }
            if (fieldGeneratorMultipleTracksLowConfidenceResult.have_value)
              {
                result.setMultipleTracksLowConfidenceResult(fieldGeneratorMultipleTracksLowConfidenceResult.value);
                fieldGeneratorMultipleTracksLowConfidenceResult.have_value = false;
              }
            if (fieldGeneratorOutOfScopeResult.have_value)
              {
                result.setOutOfScopeResult(fieldGeneratorOutOfScopeResult.value);
                fieldGeneratorOutOfScopeResult.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SoundHoundNowCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ncelSoundHoundSearchResult", 0, 26, false) == 0) && (field_name.Length == 28))
                                return fieldGeneratorCancelSoundHoundSearchResult;
                            break;
                        case 'l':
                            if ((String.Compare(field_name, 2, "ue", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorClue;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "aunchSoundHoundAppResult", 0, 24, false) == 0) && (field_name.Length == 25))
                        return fieldGeneratorLaunchSoundHoundAppResult;
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "ultipleTracks", 0, 13, false) == 0)
                      {
                        switch (field_name[14])
                          {
                            case 'H':
                                if ((String.Compare(field_name, 15, "ighConfidenceResult", 0, 19, false) == 0) && (field_name.Length == 34))
                                    return fieldGeneratorMultipleTracksHighConfidenceResult;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 15, "owConfidenceResult", 0, 18, false) == 0) && (field_name.Length == 33))
                                    return fieldGeneratorMultipleTracksLowConfidenceResult;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 15, "ediumConfidenceResult", 0, 21, false) == 0) && (field_name.Length == 36))
                                    return fieldGeneratorMultipleTracksMediumConfidenceResult;
                                break;
                            case 'W':
                                if ((String.Compare(field_name, 15, "ithArtistHighConfidenceResult", 0, 29, false) == 0) && (field_name.Length == 44))
                                    return fieldGeneratorMultipleTracksWithArtistHighConfidenceResult;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "oMatchResult", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorNoMatchResult;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "utOfScopeResult", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorOutOfScopeResult;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'i':
                            if (String.Compare(field_name, 2, "ngleTrack", 0, 9, false) == 0)
                              {
                                switch (field_name[11])
                                  {
                                    case 'R':
                                        if ((String.Compare(field_name, 12, "esult", 0, 5, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorSingleTrackResult;
                                        break;
                                    case 'W':
                                        if ((String.Compare(field_name, 12, "ithArtistResult", 0, 15, false) == 0) && (field_name.Length == 27))
                                            return fieldGeneratorSingleTrackWithArtistResult;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "undHoundNotInstalledResult", 0, 26, false) == 0) && (field_name.Length == 28))
                                return fieldGeneratorSoundHoundNotInstalledResult;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "artSoundHoundSearchResult", 0, 25, false) == 0) && (field_name.Length == 27))
                                return fieldGeneratorStartSoundHoundSearchResult;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorClue = new FieldHoldingGeneratorClue("field \"Clue\" of the SoundHoundNowCommand class");
            fieldGeneratorLaunchSoundHoundAppResult = new DynamicResponseJSON.HoldingGenerator("field \"LaunchSoundHoundAppResult\" of the SoundHoundNowCommand class", ignore_extras);
            fieldGeneratorSoundHoundNotInstalledResult = new DynamicResponseJSON.HoldingGenerator("field \"SoundHoundNotInstalledResult\" of the SoundHoundNowCommand class", ignore_extras);
            fieldGeneratorStartSoundHoundSearchResult = new DynamicResponseJSON.HoldingGenerator("field \"StartSoundHoundSearchResult\" of the SoundHoundNowCommand class", ignore_extras);
            fieldGeneratorCancelSoundHoundSearchResult = new DynamicResponseJSON.HoldingGenerator("field \"CancelSoundHoundSearchResult\" of the SoundHoundNowCommand class", ignore_extras);
            fieldGeneratorNoMatchResult = new DynamicResponseJSON.HoldingGenerator("field \"NoMatchResult\" of the SoundHoundNowCommand class", ignore_extras);
            fieldGeneratorSingleTrackResult = new DynamicResponseJSON.HoldingGenerator("field \"SingleTrackResult\" of the SoundHoundNowCommand class", ignore_extras);
            fieldGeneratorSingleTrackWithArtistResult = new DynamicResponseJSON.HoldingGenerator("field \"SingleTrackWithArtistResult\" of the SoundHoundNowCommand class", ignore_extras);
            fieldGeneratorMultipleTracksHighConfidenceResult = new DynamicResponseJSON.HoldingGenerator("field \"MultipleTracksHighConfidenceResult\" of the SoundHoundNowCommand class", ignore_extras);
            fieldGeneratorMultipleTracksWithArtistHighConfidenceResult = new DynamicResponseJSON.HoldingGenerator("field \"MultipleTracksWithArtistHighConfidenceResult\" of the SoundHoundNowCommand class", ignore_extras);
            fieldGeneratorMultipleTracksMediumConfidenceResult = new DynamicResponseJSON.HoldingGenerator("field \"MultipleTracksMediumConfidenceResult\" of the SoundHoundNowCommand class", ignore_extras);
            fieldGeneratorMultipleTracksLowConfidenceResult = new DynamicResponseJSON.HoldingGenerator("field \"MultipleTracksLowConfidenceResult\" of the SoundHoundNowCommand class", ignore_extras);
            fieldGeneratorOutOfScopeResult = new DynamicResponseJSON.HoldingGenerator("field \"OutOfScopeResult\" of the SoundHoundNowCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SoundHoundNowCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorClue = new FieldHoldingGeneratorClue("field \"Clue\" of the SoundHoundNowCommand class");
            fieldGeneratorLaunchSoundHoundAppResult = new DynamicResponseJSON.HoldingGenerator("field \"LaunchSoundHoundAppResult\" of the SoundHoundNowCommand class", false);
            fieldGeneratorSoundHoundNotInstalledResult = new DynamicResponseJSON.HoldingGenerator("field \"SoundHoundNotInstalledResult\" of the SoundHoundNowCommand class", false);
            fieldGeneratorStartSoundHoundSearchResult = new DynamicResponseJSON.HoldingGenerator("field \"StartSoundHoundSearchResult\" of the SoundHoundNowCommand class", false);
            fieldGeneratorCancelSoundHoundSearchResult = new DynamicResponseJSON.HoldingGenerator("field \"CancelSoundHoundSearchResult\" of the SoundHoundNowCommand class", false);
            fieldGeneratorNoMatchResult = new DynamicResponseJSON.HoldingGenerator("field \"NoMatchResult\" of the SoundHoundNowCommand class", false);
            fieldGeneratorSingleTrackResult = new DynamicResponseJSON.HoldingGenerator("field \"SingleTrackResult\" of the SoundHoundNowCommand class", false);
            fieldGeneratorSingleTrackWithArtistResult = new DynamicResponseJSON.HoldingGenerator("field \"SingleTrackWithArtistResult\" of the SoundHoundNowCommand class", false);
            fieldGeneratorMultipleTracksHighConfidenceResult = new DynamicResponseJSON.HoldingGenerator("field \"MultipleTracksHighConfidenceResult\" of the SoundHoundNowCommand class", false);
            fieldGeneratorMultipleTracksWithArtistHighConfidenceResult = new DynamicResponseJSON.HoldingGenerator("field \"MultipleTracksWithArtistHighConfidenceResult\" of the SoundHoundNowCommand class", false);
            fieldGeneratorMultipleTracksMediumConfidenceResult = new DynamicResponseJSON.HoldingGenerator("field \"MultipleTracksMediumConfidenceResult\" of the SoundHoundNowCommand class", false);
            fieldGeneratorMultipleTracksLowConfidenceResult = new DynamicResponseJSON.HoldingGenerator("field \"MultipleTracksLowConfidenceResult\" of the SoundHoundNowCommand class", false);
            fieldGeneratorOutOfScopeResult = new DynamicResponseJSON.HoldingGenerator("field \"OutOfScopeResult\" of the SoundHoundNowCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SoundHoundNowCommand class");
          }

        public override void reset()
          {
            fieldGeneratorClue.reset();
            fieldGeneratorLaunchSoundHoundAppResult.reset();
            fieldGeneratorSoundHoundNotInstalledResult.reset();
            fieldGeneratorStartSoundHoundSearchResult.reset();
            fieldGeneratorCancelSoundHoundSearchResult.reset();
            fieldGeneratorNoMatchResult.reset();
            fieldGeneratorSingleTrackResult.reset();
            fieldGeneratorSingleTrackWithArtistResult.reset();
            fieldGeneratorMultipleTracksHighConfidenceResult.reset();
            fieldGeneratorMultipleTracksWithArtistHighConfidenceResult.reset();
            fieldGeneratorMultipleTracksMediumConfidenceResult.reset();
            fieldGeneratorMultipleTracksLowConfidenceResult.reset();
            fieldGeneratorOutOfScopeResult.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SoundHoundNowCommandJSON  result)
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
        public SoundHoundNowCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SoundHoundNowCommandJSON  result)
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
    protected virtual void handle_result(List<SoundHoundNowCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SoundHoundNowCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SoundHoundNowCommandJSON>();
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
    public List<SoundHoundNowCommandJSON> value;
  };
  };
