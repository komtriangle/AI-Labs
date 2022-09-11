/* file "MusicChartsSearchCriteriaAdditionalJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicChartsSearchCriteriaAdditionalJSON : JSONBase
  {
    public enum TypeMusicDecadeKnownValues
      {
        MusicDecade_NoMusicDecade,
        MusicDecade_1940s,
        MusicDecade_1950s,
        MusicDecade_1960s,
        MusicDecade_1970s,
        MusicDecade_1980s,
        MusicDecade_1990s,
        MusicDecade_2000s,
        MusicDecade_2010s,
        MusicDecade__none
      };
    public struct TypeMusicDecade
      {
        public bool in_known_list;
        public string string_value;
        public TypeMusicDecadeKnownValues list_value;
      };

    public static TypeMusicDecadeKnownValues  stringToMusicDecade(string chars)
      {
        switch (chars[0])
          {
            case '1':
                if (String.Compare(chars, 1, "9", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case '4':
                            if ((String.Compare(chars, 3, "0s", 0, 2, false) == 0) && (chars.Length == 5))
                                return TypeMusicDecadeKnownValues.MusicDecade_1940s;
                            break;
                        case '5':
                            if ((String.Compare(chars, 3, "0s", 0, 2, false) == 0) && (chars.Length == 5))
                                return TypeMusicDecadeKnownValues.MusicDecade_1950s;
                            break;
                        case '6':
                            if ((String.Compare(chars, 3, "0s", 0, 2, false) == 0) && (chars.Length == 5))
                                return TypeMusicDecadeKnownValues.MusicDecade_1960s;
                            break;
                        case '7':
                            if ((String.Compare(chars, 3, "0s", 0, 2, false) == 0) && (chars.Length == 5))
                                return TypeMusicDecadeKnownValues.MusicDecade_1970s;
                            break;
                        case '8':
                            if ((String.Compare(chars, 3, "0s", 0, 2, false) == 0) && (chars.Length == 5))
                                return TypeMusicDecadeKnownValues.MusicDecade_1980s;
                            break;
                        case '9':
                            if ((String.Compare(chars, 3, "0s", 0, 2, false) == 0) && (chars.Length == 5))
                                return TypeMusicDecadeKnownValues.MusicDecade_1990s;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case '2':
                if (String.Compare(chars, 1, "0", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case '0':
                            if ((String.Compare(chars, 3, "0s", 0, 2, false) == 0) && (chars.Length == 5))
                                return TypeMusicDecadeKnownValues.MusicDecade_2000s;
                            break;
                        case '1':
                            if ((String.Compare(chars, 3, "0s", 0, 2, false) == 0) && (chars.Length == 5))
                                return TypeMusicDecadeKnownValues.MusicDecade_2010s;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(chars, 1, "oMusicDecade", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeMusicDecadeKnownValues.MusicDecade_NoMusicDecade;
                break;
            default:
                break;
          }
        return TypeMusicDecadeKnownValues.MusicDecade__none;
      }

    public static string  stringFromMusicDecade(TypeMusicDecadeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeMusicDecadeKnownValues.MusicDecade_NoMusicDecade:
                return "NoMusicDecade";
            case TypeMusicDecadeKnownValues.MusicDecade_1940s:
                return "1940s";
            case TypeMusicDecadeKnownValues.MusicDecade_1950s:
                return "1950s";
            case TypeMusicDecadeKnownValues.MusicDecade_1960s:
                return "1960s";
            case TypeMusicDecadeKnownValues.MusicDecade_1970s:
                return "1970s";
            case TypeMusicDecadeKnownValues.MusicDecade_1980s:
                return "1980s";
            case TypeMusicDecadeKnownValues.MusicDecade_1990s:
                return "1990s";
            case TypeMusicDecadeKnownValues.MusicDecade_2000s:
                return "2000s";
            case TypeMusicDecadeKnownValues.MusicDecade_2010s:
                return "2010s";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeMoodKnownValues
      {
        Mood_NoMood,
        Mood_Angry,
        Mood_Happy,
        Mood_Inspirational,
        Mood_Lonely,
        Mood_Nostalgic,
        Mood_Quiet,
        Mood_Sad,
        Mood_Soothing,
        Mood_Sweet,
        Mood__none
      };
    public struct TypeMood
      {
        public bool in_known_list;
        public string string_value;
        public TypeMoodKnownValues list_value;
      };

    public static TypeMoodKnownValues  stringToMood(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ngry", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeMoodKnownValues.Mood_Angry;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "appy", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeMoodKnownValues.Mood_Happy;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nspirational", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeMoodKnownValues.Mood_Inspirational;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "onely", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeMoodKnownValues.Mood_Lonely;
                break;
            case 'N':
                if (String.Compare(chars, 1, "o", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'M':
                            if ((String.Compare(chars, 3, "ood", 0, 3, false) == 0) && (chars.Length == 6))
                                return TypeMoodKnownValues.Mood_NoMood;
                            break;
                        case 's':
                            if ((String.Compare(chars, 3, "talgic", 0, 6, false) == 0) && (chars.Length == 9))
                                return TypeMoodKnownValues.Mood_Nostalgic;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Q':
                if ((String.Compare(chars, 1, "uiet", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeMoodKnownValues.Mood_Quiet;
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "d", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeMoodKnownValues.Mood_Sad;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "othing", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeMoodKnownValues.Mood_Soothing;
                        break;
                    case 'w':
                        if ((String.Compare(chars, 2, "eet", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeMoodKnownValues.Mood_Sweet;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return TypeMoodKnownValues.Mood__none;
      }

    public static string  stringFromMood(TypeMoodKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeMoodKnownValues.Mood_NoMood:
                return "NoMood";
            case TypeMoodKnownValues.Mood_Angry:
                return "Angry";
            case TypeMoodKnownValues.Mood_Happy:
                return "Happy";
            case TypeMoodKnownValues.Mood_Inspirational:
                return "Inspirational";
            case TypeMoodKnownValues.Mood_Lonely:
                return "Lonely";
            case TypeMoodKnownValues.Mood_Nostalgic:
                return "Nostalgic";
            case TypeMoodKnownValues.Mood_Quiet:
                return "Quiet";
            case TypeMoodKnownValues.Mood_Sad:
                return "Sad";
            case TypeMoodKnownValues.Mood_Soothing:
                return "Soothing";
            case TypeMoodKnownValues.Mood_Sweet:
                return "Sweet";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasLanguageCode;
    private string storeLanguageCode;
    private bool flagHasLanguageName;
    private string storeLanguageName;
    private bool flagHasMusicDecade;
    private TypeMusicDecade storeMusicDecade;
    private bool flagHasMood;
    private TypeMood storeMood;
    private bool flagHasMoodName;
    private string storeMoodName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONLanguageCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LanguageCode of MusicChartsSearchCriteriaAdditionalJSON is not a string.");
        setLanguageCode(json_string.getData());
      }


    private void  fromJSONLanguageName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LanguageName of MusicChartsSearchCriteriaAdditionalJSON is not a string.");
        setLanguageName(json_string.getData());
      }


    private void  fromJSONMusicDecade(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MusicDecade of MusicChartsSearchCriteriaAdditionalJSON is not a string.");
        TypeMusicDecade the_open_enum = new TypeMusicDecade();
        switch (json_string.getData()[0])
          {
            case '1':
                if (String.Compare(json_string.getData(), 1, "9", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case '4':
                            if ((String.Compare(json_string.getData(), 3, "0s", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeMusicDecadeKnownValues.MusicDecade_1940s;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case '5':
                            if ((String.Compare(json_string.getData(), 3, "0s", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeMusicDecadeKnownValues.MusicDecade_1950s;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case '6':
                            if ((String.Compare(json_string.getData(), 3, "0s", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeMusicDecadeKnownValues.MusicDecade_1960s;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case '7':
                            if ((String.Compare(json_string.getData(), 3, "0s", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeMusicDecadeKnownValues.MusicDecade_1970s;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case '8':
                            if ((String.Compare(json_string.getData(), 3, "0s", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeMusicDecadeKnownValues.MusicDecade_1980s;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case '9':
                            if ((String.Compare(json_string.getData(), 3, "0s", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeMusicDecadeKnownValues.MusicDecade_1990s;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case '2':
                if (String.Compare(json_string.getData(), 1, "0", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case '0':
                            if ((String.Compare(json_string.getData(), 3, "0s", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeMusicDecadeKnownValues.MusicDecade_2000s;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case '1':
                            if ((String.Compare(json_string.getData(), 3, "0s", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeMusicDecadeKnownValues.MusicDecade_2010s;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "oMusicDecade", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMusicDecadeKnownValues.MusicDecade_NoMusicDecade;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setMusicDecade(the_open_enum);
      }


    private void  fromJSONMood(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Mood of MusicChartsSearchCriteriaAdditionalJSON is not a string.");
        TypeMood the_open_enum = new TypeMood();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ngry", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMoodKnownValues.Mood_Angry;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "appy", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMoodKnownValues.Mood_Happy;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nspirational", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMoodKnownValues.Mood_Inspirational;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "onely", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMoodKnownValues.Mood_Lonely;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                if (String.Compare(json_string.getData(), 1, "o", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'M':
                            if ((String.Compare(json_string.getData(), 3, "ood", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeMoodKnownValues.Mood_NoMood;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 's':
                            if ((String.Compare(json_string.getData(), 3, "talgic", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeMoodKnownValues.Mood_Nostalgic;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Q':
                if ((String.Compare(json_string.getData(), 1, "uiet", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMoodKnownValues.Mood_Quiet;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "d", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeMoodKnownValues.Mood_Sad;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "othing", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeMoodKnownValues.Mood_Soothing;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'w':
                        if ((String.Compare(json_string.getData(), 2, "eet", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeMoodKnownValues.Mood_Sweet;
                                goto open_enum_is_done;
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
        setMood(the_open_enum);
      }


    private void  fromJSONMoodName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MoodName of MusicChartsSearchCriteriaAdditionalJSON is not a string.");
        setMoodName(json_string.getData());
      }


    public MusicChartsSearchCriteriaAdditionalJSON()
      {
        flagHasLanguageCode = false;
        flagHasLanguageName = false;
        flagHasMusicDecade = false;
        flagHasMood = false;
        flagHasMoodName = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasLanguageCode()
      {
        return flagHasLanguageCode;
      }

    public string  getLanguageCode()
      {
        Debug.Assert(flagHasLanguageCode);
        return storeLanguageCode;
      }

    public bool  hasLanguageName()
      {
        return flagHasLanguageName;
      }

    public string  getLanguageName()
      {
        Debug.Assert(flagHasLanguageName);
        return storeLanguageName;
      }

    public bool  hasMusicDecade()
      {
        return flagHasMusicDecade;
      }

    public TypeMusicDecade  getMusicDecade()
      {
        Debug.Assert(flagHasMusicDecade);
        return storeMusicDecade;
      }

    public string  getMusicDecadeAsString()
      {
        TypeMusicDecade result = getMusicDecade();
        if (result.in_known_list)
            return stringFromMusicDecade(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasMood()
      {
        return flagHasMood;
      }

    public TypeMood  getMood()
      {
        Debug.Assert(flagHasMood);
        return storeMood;
      }

    public string  getMoodAsString()
      {
        TypeMood result = getMood();
        if (result.in_known_list)
            return stringFromMood(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasMoodName()
      {
        return flagHasMoodName;
      }

    public string  getMoodName()
      {
        Debug.Assert(flagHasMoodName);
        return storeMoodName;
      }


    public virtual int extraMusicChartsSearchCriteriaAdditionalComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMusicChartsSearchCriteriaAdditionalComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMusicChartsSearchCriteriaAdditionalComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMusicChartsSearchCriteriaAdditionalLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setLanguageCode(string new_value)
      {
        flagHasLanguageCode = true;
        storeLanguageCode = new_value;
      }
    public void unsetLanguageCode()
      {
        flagHasLanguageCode = false;
      }
    public void setLanguageName(string new_value)
      {
        flagHasLanguageName = true;
        storeLanguageName = new_value;
      }
    public void unsetLanguageName()
      {
        flagHasLanguageName = false;
      }
    public void setMusicDecade(TypeMusicDecade new_value)
      {
        flagHasMusicDecade = true;
        storeMusicDecade = new_value;
      }
    public void setMusicDecade(string chars)
      {
        TypeMusicDecadeKnownValues known = stringToMusicDecade(chars);
        TypeMusicDecade new_value = new TypeMusicDecade();
        if (known == TypeMusicDecadeKnownValues.MusicDecade__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setMusicDecade(new_value);
      }
    public void setMusicDecade(TypeMusicDecadeKnownValues new_value)
      {
        TypeMusicDecade new_full_value = new TypeMusicDecade();
        Debug.Assert(new_value != TypeMusicDecadeKnownValues.MusicDecade__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setMusicDecade(new_full_value);
      }
    public void unsetMusicDecade()
      {
        flagHasMusicDecade = false;
      }
    public void setMood(TypeMood new_value)
      {
        flagHasMood = true;
        storeMood = new_value;
      }
    public void setMood(string chars)
      {
        TypeMoodKnownValues known = stringToMood(chars);
        TypeMood new_value = new TypeMood();
        if (known == TypeMoodKnownValues.Mood__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setMood(new_value);
      }
    public void setMood(TypeMoodKnownValues new_value)
      {
        TypeMood new_full_value = new TypeMood();
        Debug.Assert(new_value != TypeMoodKnownValues.Mood__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setMood(new_full_value);
      }
    public void unsetMood()
      {
        flagHasMood = false;
      }
    public void setMoodName(string new_value)
      {
        flagHasMoodName = true;
        storeMoodName = new_value;
      }
    public void unsetMoodName()
      {
        flagHasMoodName = false;
      }

    public virtual void extraMusicChartsSearchCriteriaAdditionalAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMusicChartsSearchCriteriaAdditionalSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMusicChartsSearchCriteriaAdditionalLookup(key);
        if (old_field == null)
          {
            extraMusicChartsSearchCriteriaAdditionalAppendPair(key, new_component);
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
        if (flagHasLanguageCode)
          {
            handler.start_pair("LanguageCode");
            handler.string_value(storeLanguageCode);
          }
        if (flagHasLanguageName)
          {
            handler.start_pair("LanguageName");
            handler.string_value(storeLanguageName);
          }
        if (flagHasMusicDecade)
          {
            handler.start_pair("MusicDecade");
            if (storeMusicDecade.in_known_list)
              {
                switch (storeMusicDecade.list_value)
                  {
                    case TypeMusicDecadeKnownValues.MusicDecade_NoMusicDecade:
                        handler.string_value("NoMusicDecade");
                        break;
                    case TypeMusicDecadeKnownValues.MusicDecade_1940s:
                        handler.string_value("1940s");
                        break;
                    case TypeMusicDecadeKnownValues.MusicDecade_1950s:
                        handler.string_value("1950s");
                        break;
                    case TypeMusicDecadeKnownValues.MusicDecade_1960s:
                        handler.string_value("1960s");
                        break;
                    case TypeMusicDecadeKnownValues.MusicDecade_1970s:
                        handler.string_value("1970s");
                        break;
                    case TypeMusicDecadeKnownValues.MusicDecade_1980s:
                        handler.string_value("1980s");
                        break;
                    case TypeMusicDecadeKnownValues.MusicDecade_1990s:
                        handler.string_value("1990s");
                        break;
                    case TypeMusicDecadeKnownValues.MusicDecade_2000s:
                        handler.string_value("2000s");
                        break;
                    case TypeMusicDecadeKnownValues.MusicDecade_2010s:
                        handler.string_value("2010s");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeMusicDecade.string_value);
              }
          }
        if (flagHasMood)
          {
            handler.start_pair("Mood");
            if (storeMood.in_known_list)
              {
                switch (storeMood.list_value)
                  {
                    case TypeMoodKnownValues.Mood_NoMood:
                        handler.string_value("NoMood");
                        break;
                    case TypeMoodKnownValues.Mood_Angry:
                        handler.string_value("Angry");
                        break;
                    case TypeMoodKnownValues.Mood_Happy:
                        handler.string_value("Happy");
                        break;
                    case TypeMoodKnownValues.Mood_Inspirational:
                        handler.string_value("Inspirational");
                        break;
                    case TypeMoodKnownValues.Mood_Lonely:
                        handler.string_value("Lonely");
                        break;
                    case TypeMoodKnownValues.Mood_Nostalgic:
                        handler.string_value("Nostalgic");
                        break;
                    case TypeMoodKnownValues.Mood_Quiet:
                        handler.string_value("Quiet");
                        break;
                    case TypeMoodKnownValues.Mood_Sad:
                        handler.string_value("Sad");
                        break;
                    case TypeMoodKnownValues.Mood_Soothing:
                        handler.string_value("Soothing");
                        break;
                    case TypeMoodKnownValues.Mood_Sweet:
                        handler.string_value("Sweet");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeMood.string_value);
              }
          }
        if (flagHasMoodName)
          {
            handler.start_pair("MoodName");
            handler.string_value(storeMoodName);
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
        return null;
      }

    public static MusicChartsSearchCriteriaAdditionalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicChartsSearchCriteriaAdditionalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsSearchCriteriaAdditional", ignore_extras);
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
    public static MusicChartsSearchCriteriaAdditionalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicChartsSearchCriteriaAdditionalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicChartsSearchCriteriaAdditionalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsSearchCriteriaAdditional", ignore_extras);
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
    public static MusicChartsSearchCriteriaAdditionalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicChartsSearchCriteriaAdditionalJSON from_text(string text, bool ignore_extras)
      {
        MusicChartsSearchCriteriaAdditionalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsSearchCriteriaAdditional", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicChartsSearchCriteriaAdditionalJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicChartsSearchCriteriaAdditionalJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicChartsSearchCriteriaAdditionalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsSearchCriteriaAdditional", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorLanguageCode;
        private JSONHoldingStringGenerator fieldGeneratorLanguageName;
    private abstract class FieldGeneratorMusicDecade : JSONStringGenerator
          {
            protected FieldGeneratorMusicDecade(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorMusicDecade()
              {
              }
            protected override void handle_result(string result)
              {
                TypeMusicDecadeKnownValues known = stringToMusicDecade(result);
                TypeMusicDecade new_value = new TypeMusicDecade();
                if (known == TypeMusicDecadeKnownValues.MusicDecade__none)
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
            protected abstract void handle_result(TypeMusicDecade result);
          };
    private class FieldHoldingGeneratorMusicDecade : FieldGeneratorMusicDecade
  {
    protected override void handle_result(TypeMusicDecade result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorMusicDecade(String what)
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
    public TypeMusicDecade value;
  };
    private class FieldHoldingArrayGeneratorMusicDecade : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorMusicDecade
      {
        private FieldHoldingArrayGeneratorMusicDecade top;

        protected override void handle_result(TypeMusicDecade result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorMusicDecade init_top)
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
    protected virtual void handle_result(List<TypeMusicDecade> result)
      {
      }

    public FieldHoldingArrayGeneratorMusicDecade(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMusicDecade>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorMusicDecade()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMusicDecade>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeMusicDecade> value;
  };
        private FieldHoldingGeneratorMusicDecade fieldGeneratorMusicDecade;
    private abstract class FieldGeneratorMood : JSONStringGenerator
          {
            protected FieldGeneratorMood(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorMood()
              {
              }
            protected override void handle_result(string result)
              {
                TypeMoodKnownValues known = stringToMood(result);
                TypeMood new_value = new TypeMood();
                if (known == TypeMoodKnownValues.Mood__none)
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
            protected abstract void handle_result(TypeMood result);
          };
    private class FieldHoldingGeneratorMood : FieldGeneratorMood
  {
    protected override void handle_result(TypeMood result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorMood(String what)
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
    public TypeMood value;
  };
    private class FieldHoldingArrayGeneratorMood : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorMood
      {
        private FieldHoldingArrayGeneratorMood top;

        protected override void handle_result(TypeMood result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorMood init_top)
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
    protected virtual void handle_result(List<TypeMood> result)
      {
      }

    public FieldHoldingArrayGeneratorMood(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMood>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorMood()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMood>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeMood> value;
  };
        private FieldHoldingGeneratorMood fieldGeneratorMood;
        private JSONHoldingStringGenerator fieldGeneratorMoodName;
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
            MusicChartsSearchCriteriaAdditionalJSON result = new MusicChartsSearchCriteriaAdditionalJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicChartsSearchCriteriaAdditionalAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MusicChartsSearchCriteriaAdditionalJSON result)
          {
            if (fieldGeneratorLanguageCode.have_value)
              {
                result.setLanguageCode(fieldGeneratorLanguageCode.value);
                fieldGeneratorLanguageCode.have_value = false;
              }
            if (fieldGeneratorLanguageName.have_value)
              {
                result.setLanguageName(fieldGeneratorLanguageName.value);
                fieldGeneratorLanguageName.have_value = false;
              }
            if (fieldGeneratorMusicDecade.have_value)
              {
                result.setMusicDecade(fieldGeneratorMusicDecade.value);
                fieldGeneratorMusicDecade.have_value = false;
              }
            if (fieldGeneratorMood.have_value)
              {
                result.setMood(fieldGeneratorMood.value);
                fieldGeneratorMood.have_value = false;
              }
            if (fieldGeneratorMoodName.have_value)
              {
                result.setMoodName(fieldGeneratorMoodName.value);
                fieldGeneratorMoodName.have_value = false;
              }
          }
        protected abstract void handle_result(MusicChartsSearchCriteriaAdditionalJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    if (String.Compare(field_name, 1, "anguage", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 9, "ode", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorLanguageCode;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 9, "ame", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorLanguageName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'o':
                            if (String.Compare(field_name, 2, "od", 0, 2, false) == 0)
                              {
                                if (field_name.Length == 4)
                                  {
                                    return fieldGeneratorMood;
                                  }
                                switch (field_name[4])
                                  {
                                    case 'N':
                                        if ((String.Compare(field_name, 5, "ame", 0, 3, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorMoodName;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "sicDecade", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorMusicDecade;
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
            fieldGeneratorLanguageCode = new JSONHoldingStringGenerator("field \"LanguageCode\" of the MusicChartsSearchCriteriaAdditional class");
            fieldGeneratorLanguageName = new JSONHoldingStringGenerator("field \"LanguageName\" of the MusicChartsSearchCriteriaAdditional class");
            fieldGeneratorMusicDecade = new FieldHoldingGeneratorMusicDecade("field \"MusicDecade\" of the MusicChartsSearchCriteriaAdditional class");
            fieldGeneratorMood = new FieldHoldingGeneratorMood("field \"Mood\" of the MusicChartsSearchCriteriaAdditional class");
            fieldGeneratorMoodName = new JSONHoldingStringGenerator("field \"MoodName\" of the MusicChartsSearchCriteriaAdditional class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MusicChartsSearchCriteriaAdditional class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLanguageCode = new JSONHoldingStringGenerator("field \"LanguageCode\" of the MusicChartsSearchCriteriaAdditional class");
            fieldGeneratorLanguageName = new JSONHoldingStringGenerator("field \"LanguageName\" of the MusicChartsSearchCriteriaAdditional class");
            fieldGeneratorMusicDecade = new FieldHoldingGeneratorMusicDecade("field \"MusicDecade\" of the MusicChartsSearchCriteriaAdditional class");
            fieldGeneratorMood = new FieldHoldingGeneratorMood("field \"Mood\" of the MusicChartsSearchCriteriaAdditional class");
            fieldGeneratorMoodName = new JSONHoldingStringGenerator("field \"MoodName\" of the MusicChartsSearchCriteriaAdditional class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MusicChartsSearchCriteriaAdditional class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorLanguageCode.reset();
            fieldGeneratorLanguageName.reset();
            fieldGeneratorMusicDecade.reset();
            fieldGeneratorMood.reset();
            fieldGeneratorMoodName.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicChartsSearchCriteriaAdditionalJSON  result)
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
        public MusicChartsSearchCriteriaAdditionalJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicChartsSearchCriteriaAdditionalJSON  result)
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
    protected virtual void handle_result(List<MusicChartsSearchCriteriaAdditionalJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicChartsSearchCriteriaAdditionalJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicChartsSearchCriteriaAdditionalJSON>();
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
    public List<MusicChartsSearchCriteriaAdditionalJSON> value;
  };
  };
