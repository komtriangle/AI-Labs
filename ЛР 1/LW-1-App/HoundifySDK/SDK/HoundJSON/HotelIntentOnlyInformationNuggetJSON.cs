/* file "HotelIntentOnlyInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HotelIntentOnlyInformationNuggetJSON : InformationNuggetJSON
  {
    public enum TypeHotelIntentOnlyCommandKind
      {
        HotelIntentOnlyCommandKind_ShowList
      };

    public static TypeHotelIntentOnlyCommandKind  stringToHotelIntentOnlyCommandKind(string chars)
      {
        if ((String.Compare(chars, 0, "ShowList", 0, 8, false) == 0) && (chars.Length == 8))
            return TypeHotelIntentOnlyCommandKind.HotelIntentOnlyCommandKind_ShowList;
        throw new Exception("The value for field `HotelIntentOnlyCommandKind' is not one of the legal values.");
      }

    public static string  stringFromHotelIntentOnlyCommandKind(TypeHotelIntentOnlyCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeHotelIntentOnlyCommandKind.HotelIntentOnlyCommandKind_ShowList:
                return "ShowList";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasHotelIntentOnlyCommandKind;
    private bool flagHasHotelSearchCriteria;
    private HotelFilterSpecJSON  storeHotelSearchCriteria;
    private bool flagHasHotelSearchCriteriaIncremental;
    private HotelFilterSpecJSON  storeHotelSearchCriteriaIncremental;
    private bool flagHasSpokenResponseNoResults;
    private string storeSpokenResponseNoResults;
    private bool flagHasSpokenResponseWithResults;
    private string storeSpokenResponseWithResults;
    private bool flagHasWrittenResponseNoResults;
    private string storeWrittenResponseNoResults;
    private bool flagHasWrittenResponseWithResults;
    private string storeWrittenResponseWithResults;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraHotelIntentOnlyCommandKindToJSON()
      {
        JSONStringValue generated_string_HotelIntentOnlyCommandKind;
        generated_string_HotelIntentOnlyCommandKind = new JSONStringValue("ShowList");
        return generated_string_HotelIntentOnlyCommandKind;
      }

    private JSONValue  extraHotelSearchCriteriaToJSON()
      {
        JSONValueHandler handler_HotelSearchCriteria = new JSONValueHandler();
        storeHotelSearchCriteria.write_as_json(handler_HotelSearchCriteria);
        return handler_HotelSearchCriteria.result;
      }

    private JSONValue  extraHotelSearchCriteriaIncrementalToJSON()
      {
        JSONValueHandler handler_HotelSearchCriteriaIncremental = new JSONValueHandler();
        storeHotelSearchCriteriaIncremental.write_as_json(handler_HotelSearchCriteriaIncremental);
        return handler_HotelSearchCriteriaIncremental.result;
      }

    private JSONValue  extraSpokenResponseNoResultsToJSON()
      {
        JSONStringValue generated_string_SpokenResponseNoResults = new JSONStringValue(storeSpokenResponseNoResults);
        return generated_string_SpokenResponseNoResults;
      }

    private JSONValue  extraSpokenResponseWithResultsToJSON()
      {
        JSONStringValue generated_string_SpokenResponseWithResults = new JSONStringValue(storeSpokenResponseWithResults);
        return generated_string_SpokenResponseWithResults;
      }

    private JSONValue  extraWrittenResponseNoResultsToJSON()
      {
        JSONStringValue generated_string_WrittenResponseNoResults = new JSONStringValue(storeWrittenResponseNoResults);
        return generated_string_WrittenResponseNoResults;
      }

    private JSONValue  extraWrittenResponseWithResultsToJSON()
      {
        JSONStringValue generated_string_WrittenResponseWithResults = new JSONStringValue(storeWrittenResponseWithResults);
        return generated_string_WrittenResponseWithResults;
      }


    private void  fromJSONHotelIntentOnlyCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HotelIntentOnlyCommandKind of HotelIntentOnlyInformationNuggetJSON is not a string.");
        if (!(json_string.getData().Equals("ShowList")))
            throw new Exception("The value for field HotelIntentOnlyCommandKind of HotelIntentOnlyInformationNuggetJSON is not `ShowList'.");
        setHotelIntentOnlyCommandKind();
      }


    private void  fromJSONHotelSearchCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HotelFilterSpecJSON convert_classy = HotelFilterSpecJSON.from_json(json_value, ignore_extras, true);
        setHotelSearchCriteria(convert_classy);
      }


    private void  fromJSONHotelSearchCriteriaIncremental(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HotelFilterSpecJSON convert_classy = HotelFilterSpecJSON.from_json(json_value, ignore_extras, true);
        setHotelSearchCriteriaIncremental(convert_classy);
      }


    private void  fromJSONSpokenResponseNoResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseNoResults of HotelIntentOnlyInformationNuggetJSON is not a string.");
        setSpokenResponseNoResults(json_string.getData());
      }


    private void  fromJSONSpokenResponseWithResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseWithResults of HotelIntentOnlyInformationNuggetJSON is not a string.");
        setSpokenResponseWithResults(json_string.getData());
      }


    private void  fromJSONWrittenResponseNoResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenResponseNoResults of HotelIntentOnlyInformationNuggetJSON is not a string.");
        setWrittenResponseNoResults(json_string.getData());
      }


    private void  fromJSONWrittenResponseWithResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenResponseWithResults of HotelIntentOnlyInformationNuggetJSON is not a string.");
        setWrittenResponseWithResults(json_string.getData());
      }


    public HotelIntentOnlyInformationNuggetJSON()
      {
        flagHasHotelIntentOnlyCommandKind = false;
        flagHasHotelSearchCriteria = false;
        flagHasHotelSearchCriteriaIncremental = false;
        flagHasSpokenResponseNoResults = false;
        flagHasSpokenResponseWithResults = false;
        flagHasWrittenResponseNoResults = false;
        flagHasWrittenResponseWithResults = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "HotelIntentOnly";
      }

    public bool  hasHotelIntentOnlyCommandKind()
      {
        return flagHasHotelIntentOnlyCommandKind;
      }

    public TypeHotelIntentOnlyCommandKind  getHotelIntentOnlyCommandKind()
      {
        Debug.Assert(flagHasHotelIntentOnlyCommandKind);
        return TypeHotelIntentOnlyCommandKind.HotelIntentOnlyCommandKind_ShowList;
      }

    public string  getHotelIntentOnlyCommandKindAsString()
      {
        return stringFromHotelIntentOnlyCommandKind(getHotelIntentOnlyCommandKind());
      }

    public bool  hasHotelSearchCriteria()
      {
        return flagHasHotelSearchCriteria;
      }

    public HotelFilterSpecJSON   getHotelSearchCriteria()
      {
        Debug.Assert(flagHasHotelSearchCriteria);
        return storeHotelSearchCriteria;
      }

    public bool  hasHotelSearchCriteriaIncremental()
      {
        return flagHasHotelSearchCriteriaIncremental;
      }

    public HotelFilterSpecJSON   getHotelSearchCriteriaIncremental()
      {
        Debug.Assert(flagHasHotelSearchCriteriaIncremental);
        return storeHotelSearchCriteriaIncremental;
      }

    public bool  hasSpokenResponseNoResults()
      {
        return flagHasSpokenResponseNoResults;
      }

    public string  getSpokenResponseNoResults()
      {
        Debug.Assert(flagHasSpokenResponseNoResults);
        return storeSpokenResponseNoResults;
      }

    public bool  hasSpokenResponseWithResults()
      {
        return flagHasSpokenResponseWithResults;
      }

    public string  getSpokenResponseWithResults()
      {
        Debug.Assert(flagHasSpokenResponseWithResults);
        return storeSpokenResponseWithResults;
      }

    public bool  hasWrittenResponseNoResults()
      {
        return flagHasWrittenResponseNoResults;
      }

    public string  getWrittenResponseNoResults()
      {
        Debug.Assert(flagHasWrittenResponseNoResults);
        return storeWrittenResponseNoResults;
      }

    public bool  hasWrittenResponseWithResults()
      {
        return flagHasWrittenResponseWithResults;
      }

    public string  getWrittenResponseWithResults()
      {
        Debug.Assert(flagHasWrittenResponseWithResults);
        return storeWrittenResponseWithResults;
      }


    public virtual int extraHotelIntentOnlyInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHotelIntentOnlyInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHotelIntentOnlyInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHotelIntentOnlyInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasHotelIntentOnlyCommandKind)
            ++result;
        if (flagHasHotelSearchCriteria)
            ++result;
        if (flagHasHotelSearchCriteriaIncremental)
            ++result;
        if (flagHasSpokenResponseNoResults)
            ++result;
        if (flagHasSpokenResponseWithResults)
            ++result;
        if (flagHasWrittenResponseNoResults)
            ++result;
        if (flagHasWrittenResponseWithResults)
            ++result;
        result += extraHotelIntentOnlyInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasHotelIntentOnlyCommandKind)
          {
            if (remainder == 0)
                return "HotelIntentOnlyCommandKind";
            --remainder;
          }
        if (flagHasHotelSearchCriteria)
          {
            if (remainder == 0)
                return "HotelSearchCriteria";
            --remainder;
          }
        if (flagHasHotelSearchCriteriaIncremental)
          {
            if (remainder == 0)
                return "HotelSearchCriteriaIncremental";
            --remainder;
          }
        if (flagHasSpokenResponseNoResults)
          {
            if (remainder == 0)
                return "SpokenResponseNoResults";
            --remainder;
          }
        if (flagHasSpokenResponseWithResults)
          {
            if (remainder == 0)
                return "SpokenResponseWithResults";
            --remainder;
          }
        if (flagHasWrittenResponseNoResults)
          {
            if (remainder == 0)
                return "WrittenResponseNoResults";
            --remainder;
          }
        if (flagHasWrittenResponseWithResults)
          {
            if (remainder == 0)
                return "WrittenResponseWithResults";
            --remainder;
          }
        return extraHotelIntentOnlyInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasHotelIntentOnlyCommandKind)
          {
            if (remainder == 0)
                return extraHotelIntentOnlyCommandKindToJSON();
            --remainder;
          }
        if (flagHasHotelSearchCriteria)
          {
            if (remainder == 0)
                return extraHotelSearchCriteriaToJSON();
            --remainder;
          }
        if (flagHasHotelSearchCriteriaIncremental)
          {
            if (remainder == 0)
                return extraHotelSearchCriteriaIncrementalToJSON();
            --remainder;
          }
        if (flagHasSpokenResponseNoResults)
          {
            if (remainder == 0)
                return extraSpokenResponseNoResultsToJSON();
            --remainder;
          }
        if (flagHasSpokenResponseWithResults)
          {
            if (remainder == 0)
                return extraSpokenResponseWithResultsToJSON();
            --remainder;
          }
        if (flagHasWrittenResponseNoResults)
          {
            if (remainder == 0)
                return extraWrittenResponseNoResultsToJSON();
            --remainder;
          }
        if (flagHasWrittenResponseWithResults)
          {
            if (remainder == 0)
                return extraWrittenResponseWithResultsToJSON();
            --remainder;
          }
        return extraHotelIntentOnlyInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'H':
                if (String.Compare(field_name, 1, "otel", 0, 4, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 6, "ntentOnlyCommandKind", 0, 20, false) == 0) && (field_name.Length == 26))
                                return (flagHasHotelIntentOnlyCommandKind ? extraHotelIntentOnlyCommandKindToJSON() : null);
                            break;
                        case 'S':
                            if (String.Compare(field_name, 6, "earchCriteria", 0, 13, false) == 0)
                              {
                                if (field_name.Length == 19)
                                  {
                                    return (flagHasHotelSearchCriteria ? extraHotelSearchCriteriaToJSON() : null);
                                  }
                                switch (field_name[19])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 20, "ncremental", 0, 10, false) == 0) && (field_name.Length == 30))
                                            return (flagHasHotelSearchCriteriaIncremental ? extraHotelSearchCriteriaIncrementalToJSON() : null);
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
            case 'S':
                if (String.Compare(field_name, 1, "pokenResponse", 0, 13, false) == 0)
                  {
                    switch (field_name[14])
                      {
                        case 'N':
                            if ((String.Compare(field_name, 15, "oResults", 0, 8, false) == 0) && (field_name.Length == 23))
                                return (flagHasSpokenResponseNoResults ? extraSpokenResponseNoResultsToJSON() : null);
                            break;
                        case 'W':
                            if ((String.Compare(field_name, 15, "ithResults", 0, 10, false) == 0) && (field_name.Length == 25))
                                return (flagHasSpokenResponseWithResults ? extraSpokenResponseWithResultsToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if (String.Compare(field_name, 1, "rittenResponse", 0, 14, false) == 0)
                  {
                    switch (field_name[15])
                      {
                        case 'N':
                            if ((String.Compare(field_name, 16, "oResults", 0, 8, false) == 0) && (field_name.Length == 24))
                                return (flagHasWrittenResponseNoResults ? extraWrittenResponseNoResultsToJSON() : null);
                            break;
                        case 'W':
                            if ((String.Compare(field_name, 16, "ithResults", 0, 10, false) == 0) && (field_name.Length == 26))
                                return (flagHasWrittenResponseWithResults ? extraWrittenResponseWithResultsToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraHotelIntentOnlyInformationNuggetLookup(field_name);
      }

    public void setHotelIntentOnlyCommandKind()
      {
        flagHasHotelIntentOnlyCommandKind = true;
      }
    public void setHotelIntentOnlyCommandKind(TypeHotelIntentOnlyCommandKind new_value)
      {
        setHotelIntentOnlyCommandKind();
      }
    public void setHotelIntentOnlyCommandKind(string chars)
      {
        setHotelIntentOnlyCommandKind(stringToHotelIntentOnlyCommandKind(chars));
      }
    public void unsetHotelIntentOnlyCommandKind()
      {
        flagHasHotelIntentOnlyCommandKind = false;
      }
    public void setHotelSearchCriteria(HotelFilterSpecJSON  new_value)
      {
        if (flagHasHotelSearchCriteria)
          {
          }
        flagHasHotelSearchCriteria = true;
        storeHotelSearchCriteria = new_value;
      }
    public void unsetHotelSearchCriteria()
      {
        if (flagHasHotelSearchCriteria)
          {
          }
        flagHasHotelSearchCriteria = false;
      }
    public void setHotelSearchCriteriaIncremental(HotelFilterSpecJSON  new_value)
      {
        if (flagHasHotelSearchCriteriaIncremental)
          {
          }
        flagHasHotelSearchCriteriaIncremental = true;
        storeHotelSearchCriteriaIncremental = new_value;
      }
    public void unsetHotelSearchCriteriaIncremental()
      {
        if (flagHasHotelSearchCriteriaIncremental)
          {
          }
        flagHasHotelSearchCriteriaIncremental = false;
      }
    public void setSpokenResponseNoResults(string new_value)
      {
        flagHasSpokenResponseNoResults = true;
        storeSpokenResponseNoResults = new_value;
      }
    public void unsetSpokenResponseNoResults()
      {
        flagHasSpokenResponseNoResults = false;
      }
    public void setSpokenResponseWithResults(string new_value)
      {
        flagHasSpokenResponseWithResults = true;
        storeSpokenResponseWithResults = new_value;
      }
    public void unsetSpokenResponseWithResults()
      {
        flagHasSpokenResponseWithResults = false;
      }
    public void setWrittenResponseNoResults(string new_value)
      {
        flagHasWrittenResponseNoResults = true;
        storeWrittenResponseNoResults = new_value;
      }
    public void unsetWrittenResponseNoResults()
      {
        flagHasWrittenResponseNoResults = false;
      }
    public void setWrittenResponseWithResults(string new_value)
      {
        flagHasWrittenResponseWithResults = true;
        storeWrittenResponseWithResults = new_value;
      }
    public void unsetWrittenResponseWithResults()
      {
        flagHasWrittenResponseWithResults = false;
      }

    public virtual void extraHotelIntentOnlyInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHotelIntentOnlyInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHotelIntentOnlyInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraHotelIntentOnlyInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'H':
                if (String.Compare(key, 1, "otel", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'I':
                            if ((String.Compare(key, 6, "ntentOnlyCommandKind", 0, 20, false) == 0) && (key.Length == 26))
                                {
                                fromJSONHotelIntentOnlyCommandKind(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if (String.Compare(key, 6, "earchCriteria", 0, 13, false) == 0)
                              {
                                if (key.Length == 19)
                                  {
                                    {
                                    fromJSONHotelSearchCriteria(new_component, false);
                                    return;
                                    }
                                  }
                                switch (key[19])
                                  {
                                    case 'I':
                                        if ((String.Compare(key, 20, "ncremental", 0, 10, false) == 0) && (key.Length == 30))
                                            {
                                            fromJSONHotelSearchCriteriaIncremental(new_component, false);
                                            return;
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
            case 'S':
                if (String.Compare(key, 1, "pokenResponse", 0, 13, false) == 0)
                  {
                    switch (key[14])
                      {
                        case 'N':
                            if ((String.Compare(key, 15, "oResults", 0, 8, false) == 0) && (key.Length == 23))
                                {
                                fromJSONSpokenResponseNoResults(new_component, false);
                                return;
                                }
                            break;
                        case 'W':
                            if ((String.Compare(key, 15, "ithResults", 0, 10, false) == 0) && (key.Length == 25))
                                {
                                fromJSONSpokenResponseWithResults(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if (String.Compare(key, 1, "rittenResponse", 0, 14, false) == 0)
                  {
                    switch (key[15])
                      {
                        case 'N':
                            if ((String.Compare(key, 16, "oResults", 0, 8, false) == 0) && (key.Length == 24))
                                {
                                fromJSONWrittenResponseNoResults(new_component, false);
                                return;
                                }
                            break;
                        case 'W':
                            if ((String.Compare(key, 16, "ithResults", 0, 10, false) == 0) && (key.Length == 26))
                                {
                                fromJSONWrittenResponseWithResults(new_component, false);
                                return;
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
        extraHotelIntentOnlyInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'H':
                if (String.Compare(key, 1, "otel", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'I':
                            if ((String.Compare(key, 6, "ntentOnlyCommandKind", 0, 20, false) == 0) && (key.Length == 26))
                                {
                                fromJSONHotelIntentOnlyCommandKind(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if (String.Compare(key, 6, "earchCriteria", 0, 13, false) == 0)
                              {
                                if (key.Length == 19)
                                  {
                                    {
                                    fromJSONHotelSearchCriteria(new_component, false);
                                    return;
                                    }
                                  }
                                switch (key[19])
                                  {
                                    case 'I':
                                        if ((String.Compare(key, 20, "ncremental", 0, 10, false) == 0) && (key.Length == 30))
                                            {
                                            fromJSONHotelSearchCriteriaIncremental(new_component, false);
                                            return;
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
            case 'S':
                if (String.Compare(key, 1, "pokenResponse", 0, 13, false) == 0)
                  {
                    switch (key[14])
                      {
                        case 'N':
                            if ((String.Compare(key, 15, "oResults", 0, 8, false) == 0) && (key.Length == 23))
                                {
                                fromJSONSpokenResponseNoResults(new_component, false);
                                return;
                                }
                            break;
                        case 'W':
                            if ((String.Compare(key, 15, "ithResults", 0, 10, false) == 0) && (key.Length == 25))
                                {
                                fromJSONSpokenResponseWithResults(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if (String.Compare(key, 1, "rittenResponse", 0, 14, false) == 0)
                  {
                    switch (key[15])
                      {
                        case 'N':
                            if ((String.Compare(key, 16, "oResults", 0, 8, false) == 0) && (key.Length == 24))
                                {
                                fromJSONWrittenResponseNoResults(new_component, false);
                                return;
                                }
                            break;
                        case 'W':
                            if ((String.Compare(key, 16, "ithResults", 0, 10, false) == 0) && (key.Length == 26))
                                {
                                fromJSONWrittenResponseWithResults(new_component, false);
                                return;
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
        extraHotelIntentOnlyInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasHotelIntentOnlyCommandKind);
        if (flagHasHotelIntentOnlyCommandKind)
          {
            handler.start_pair("HotelIntentOnlyCommandKind");
            handler.string_value("ShowList");
          }
        if (flagHasHotelSearchCriteria)
          {
            handler.start_pair("HotelSearchCriteria");
            if (partial_allowed)
                storeHotelSearchCriteria.write_partial_as_json(handler);
            else
                storeHotelSearchCriteria.write_as_json(handler);
          }
        if (flagHasHotelSearchCriteriaIncremental)
          {
            handler.start_pair("HotelSearchCriteriaIncremental");
            if (partial_allowed)
                storeHotelSearchCriteriaIncremental.write_partial_as_json(handler);
            else
                storeHotelSearchCriteriaIncremental.write_as_json(handler);
          }
        if (flagHasSpokenResponseNoResults)
          {
            handler.start_pair("SpokenResponseNoResults");
            handler.string_value(storeSpokenResponseNoResults);
          }
        if (flagHasSpokenResponseWithResults)
          {
            handler.start_pair("SpokenResponseWithResults");
            handler.string_value(storeSpokenResponseWithResults);
          }
        if (flagHasWrittenResponseNoResults)
          {
            handler.start_pair("WrittenResponseNoResults");
            handler.string_value(storeWrittenResponseNoResults);
          }
        if (flagHasWrittenResponseWithResults)
          {
            handler.start_pair("WrittenResponseWithResults");
            handler.string_value(storeWrittenResponseWithResults);
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
        if (!(hasHotelIntentOnlyCommandKind()))
          {
            return "When parsing the object for %what%, the \"HotelIntentOnlyCommandKind\" field was missing.";
          }
        return null;
      }

    public static new HotelIntentOnlyInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HotelIntentOnlyInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelIntentOnlyInformationNugget", ignore_extras);
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
    public static new HotelIntentOnlyInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HotelIntentOnlyInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HotelIntentOnlyInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelIntentOnlyInformationNugget", ignore_extras);
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
    public static new HotelIntentOnlyInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HotelIntentOnlyInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        HotelIntentOnlyInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelIntentOnlyInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HotelIntentOnlyInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HotelIntentOnlyInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HotelIntentOnlyInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelIntentOnlyInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
    private abstract class FieldGeneratorHotelIntentOnlyCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorHotelIntentOnlyCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorHotelIntentOnlyCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToHotelIntentOnlyCommandKind(result));
              }
            protected abstract void handle_result(TypeHotelIntentOnlyCommandKind result);
          };
    private class FieldHoldingGeneratorHotelIntentOnlyCommandKind : FieldGeneratorHotelIntentOnlyCommandKind
  {
    protected override void handle_result(TypeHotelIntentOnlyCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorHotelIntentOnlyCommandKind(String what)
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
    public TypeHotelIntentOnlyCommandKind value;
  };
    private class FieldHoldingArrayGeneratorHotelIntentOnlyCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorHotelIntentOnlyCommandKind
      {
        private FieldHoldingArrayGeneratorHotelIntentOnlyCommandKind top;

        protected override void handle_result(TypeHotelIntentOnlyCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorHotelIntentOnlyCommandKind init_top)
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
    protected virtual void handle_result(List<TypeHotelIntentOnlyCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorHotelIntentOnlyCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeHotelIntentOnlyCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorHotelIntentOnlyCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeHotelIntentOnlyCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeHotelIntentOnlyCommandKind> value;
  };
        private FieldHoldingGeneratorHotelIntentOnlyCommandKind fieldGeneratorHotelIntentOnlyCommandKind;
        private HotelFilterSpecJSON.HoldingGenerator fieldGeneratorHotelSearchCriteria;
        private HotelFilterSpecJSON.HoldingGenerator fieldGeneratorHotelSearchCriteriaIncremental;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponseNoResults;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponseWithResults;
        private JSONHoldingStringGenerator fieldGeneratorWrittenResponseNoResults;
        private JSONHoldingStringGenerator fieldGeneratorWrittenResponseWithResults;
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
            if (!(getInformationNuggetJSONKey().Equals("HotelIntentOnly")))
                throw new Exception("The key field has a value other than `HotelIntentOnly'.");
            HotelIntentOnlyInformationNuggetJSON result = new HotelIntentOnlyInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHotelIntentOnlyInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((HotelIntentOnlyInformationNuggetJSON )new_result);
          }
        protected void finish(HotelIntentOnlyInformationNuggetJSON result)
          {
            if (fieldGeneratorHotelIntentOnlyCommandKind.have_value)
              {
                result.setHotelIntentOnlyCommandKind();
                fieldGeneratorHotelIntentOnlyCommandKind.have_value = false;
              }
            else if ((!(result.hasHotelIntentOnlyCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"HotelIntentOnlyCommandKind\" field was missing.");
              }
            if (fieldGeneratorHotelSearchCriteria.have_value)
              {
                result.setHotelSearchCriteria(fieldGeneratorHotelSearchCriteria.value);
                fieldGeneratorHotelSearchCriteria.have_value = false;
              }
            if (fieldGeneratorHotelSearchCriteriaIncremental.have_value)
              {
                result.setHotelSearchCriteriaIncremental(fieldGeneratorHotelSearchCriteriaIncremental.value);
                fieldGeneratorHotelSearchCriteriaIncremental.have_value = false;
              }
            if (fieldGeneratorSpokenResponseNoResults.have_value)
              {
                result.setSpokenResponseNoResults(fieldGeneratorSpokenResponseNoResults.value);
                fieldGeneratorSpokenResponseNoResults.have_value = false;
              }
            if (fieldGeneratorSpokenResponseWithResults.have_value)
              {
                result.setSpokenResponseWithResults(fieldGeneratorSpokenResponseWithResults.value);
                fieldGeneratorSpokenResponseWithResults.have_value = false;
              }
            if (fieldGeneratorWrittenResponseNoResults.have_value)
              {
                result.setWrittenResponseNoResults(fieldGeneratorWrittenResponseNoResults.value);
                fieldGeneratorWrittenResponseNoResults.have_value = false;
              }
            if (fieldGeneratorWrittenResponseWithResults.have_value)
              {
                result.setWrittenResponseWithResults(fieldGeneratorWrittenResponseWithResults.value);
                fieldGeneratorWrittenResponseWithResults.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(HotelIntentOnlyInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'H':
                    if (String.Compare(field_name, 1, "otel", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 6, "ntentOnlyCommandKind", 0, 20, false) == 0) && (field_name.Length == 26))
                                    return fieldGeneratorHotelIntentOnlyCommandKind;
                                break;
                            case 'S':
                                if (String.Compare(field_name, 6, "earchCriteria", 0, 13, false) == 0)
                                  {
                                    if (field_name.Length == 19)
                                      {
                                        return fieldGeneratorHotelSearchCriteria;
                                      }
                                    switch (field_name[19])
                                      {
                                        case 'I':
                                            if ((String.Compare(field_name, 20, "ncremental", 0, 10, false) == 0) && (field_name.Length == 30))
                                                return fieldGeneratorHotelSearchCriteriaIncremental;
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
                case 'S':
                    if (String.Compare(field_name, 1, "pokenResponse", 0, 13, false) == 0)
                      {
                        switch (field_name[14])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 15, "oResults", 0, 8, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorSpokenResponseNoResults;
                                break;
                            case 'W':
                                if ((String.Compare(field_name, 15, "ithResults", 0, 10, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorSpokenResponseWithResults;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "rittenResponse", 0, 14, false) == 0)
                      {
                        switch (field_name[15])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 16, "oResults", 0, 8, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorWrittenResponseNoResults;
                                break;
                            case 'W':
                                if ((String.Compare(field_name, 16, "ithResults", 0, 10, false) == 0) && (field_name.Length == 26))
                                    return fieldGeneratorWrittenResponseWithResults;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorHotelIntentOnlyCommandKind = new FieldHoldingGeneratorHotelIntentOnlyCommandKind("field \"HotelIntentOnlyCommandKind\" of the HotelIntentOnlyInformationNugget class");
            fieldGeneratorHotelSearchCriteria = new HotelFilterSpecJSON.HoldingGenerator("field \"HotelSearchCriteria\" of the HotelIntentOnlyInformationNugget class", ignore_extras);
            fieldGeneratorHotelSearchCriteriaIncremental = new HotelFilterSpecJSON.HoldingGenerator("field \"HotelSearchCriteriaIncremental\" of the HotelIntentOnlyInformationNugget class", ignore_extras);
            fieldGeneratorSpokenResponseNoResults = new JSONHoldingStringGenerator("field \"SpokenResponseNoResults\" of the HotelIntentOnlyInformationNugget class");
            fieldGeneratorSpokenResponseWithResults = new JSONHoldingStringGenerator("field \"SpokenResponseWithResults\" of the HotelIntentOnlyInformationNugget class");
            fieldGeneratorWrittenResponseNoResults = new JSONHoldingStringGenerator("field \"WrittenResponseNoResults\" of the HotelIntentOnlyInformationNugget class");
            fieldGeneratorWrittenResponseWithResults = new JSONHoldingStringGenerator("field \"WrittenResponseWithResults\" of the HotelIntentOnlyInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HotelIntentOnlyInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorHotelIntentOnlyCommandKind = new FieldHoldingGeneratorHotelIntentOnlyCommandKind("field \"HotelIntentOnlyCommandKind\" of the HotelIntentOnlyInformationNugget class");
            fieldGeneratorHotelSearchCriteria = new HotelFilterSpecJSON.HoldingGenerator("field \"HotelSearchCriteria\" of the HotelIntentOnlyInformationNugget class", false);
            fieldGeneratorHotelSearchCriteriaIncremental = new HotelFilterSpecJSON.HoldingGenerator("field \"HotelSearchCriteriaIncremental\" of the HotelIntentOnlyInformationNugget class", false);
            fieldGeneratorSpokenResponseNoResults = new JSONHoldingStringGenerator("field \"SpokenResponseNoResults\" of the HotelIntentOnlyInformationNugget class");
            fieldGeneratorSpokenResponseWithResults = new JSONHoldingStringGenerator("field \"SpokenResponseWithResults\" of the HotelIntentOnlyInformationNugget class");
            fieldGeneratorWrittenResponseNoResults = new JSONHoldingStringGenerator("field \"WrittenResponseNoResults\" of the HotelIntentOnlyInformationNugget class");
            fieldGeneratorWrittenResponseWithResults = new JSONHoldingStringGenerator("field \"WrittenResponseWithResults\" of the HotelIntentOnlyInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HotelIntentOnlyInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorHotelIntentOnlyCommandKind.reset();
            fieldGeneratorHotelSearchCriteria.reset();
            fieldGeneratorHotelSearchCriteriaIncremental.reset();
            fieldGeneratorSpokenResponseNoResults.reset();
            fieldGeneratorSpokenResponseWithResults.reset();
            fieldGeneratorWrittenResponseNoResults.reset();
            fieldGeneratorWrittenResponseWithResults.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(HotelIntentOnlyInformationNuggetJSON  result)
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
        public HotelIntentOnlyInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HotelIntentOnlyInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<HotelIntentOnlyInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HotelIntentOnlyInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HotelIntentOnlyInformationNuggetJSON>();
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
    public List<HotelIntentOnlyInformationNuggetJSON> value;
  };
  };
