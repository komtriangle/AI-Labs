/* file "LocalSearchInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class LocalSearchInformationNuggetJSON : InformationNuggetJSON
  {
    public enum TypeLocalSearchCommandKind
      {
        LocalSearchCommandKind_ShowList
      };

    public static TypeLocalSearchCommandKind  stringToLocalSearchCommandKind(string chars)
      {
        if ((String.Compare(chars, 0, "ShowList", 0, 8, false) == 0) && (chars.Length == 8))
            return TypeLocalSearchCommandKind.LocalSearchCommandKind_ShowList;
        throw new Exception("The value for field `LocalSearchCommandKind' is not one of the legal values.");
      }

    public static string  stringFromLocalSearchCommandKind(TypeLocalSearchCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeLocalSearchCommandKind.LocalSearchCommandKind_ShowList:
                return "ShowList";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasLocalSearchCommandKind;
    private bool flagHasLocalSearchCriteria;
    private LocalSearchFilterSpecJSON  storeLocalSearchCriteria;
    private bool flagHasLocalSearchCriteriaIncremental;
    private LocalSearchFilterSpecJSON  storeLocalSearchCriteriaIncremental;
    private bool flagHasLocationNotSupported;
    private bool storeLocationNotSupported;
    private bool flagHasResultNameSingularSpoken;
    private string storeResultNameSingularSpoken;
    private bool flagHasResultNamePluralSpoken;
    private string storeResultNamePluralSpoken;
    private bool flagHasResultNameSingularWritten;
    private string storeResultNameSingularWritten;
    private bool flagHasResultNamePluralWritten;
    private string storeResultNamePluralWritten;
    private bool flagHasSimilarResultsReturned;
    private bool storeSimilarResultsReturned;
    private bool flagHasSimilarResultLocalSearchCriteria;
    private LocalSearchFilterSpecJSON  storeSimilarResultLocalSearchCriteria;
    private bool flagHasMessageUserSimilarResultsReturned;
    private bool storeMessageUserSimilarResultsReturned;
    private bool flagHasSimilarResultNameSingularSpoken;
    private string storeSimilarResultNameSingularSpoken;
    private bool flagHasSimilarResultNamePluralSpoken;
    private string storeSimilarResultNamePluralSpoken;
    private bool flagHasSimilarResultNameSingularWritten;
    private string storeSimilarResultNameSingularWritten;
    private bool flagHasSimilarResultNamePluralWritten;
    private string storeSimilarResultNamePluralWritten;
    private bool flagHasLocalSearchQuestionsResponseSpoken;
    private string storeLocalSearchQuestionsResponseSpoken;
    private bool flagHasLocalSearchQuestionsResponseWritten;
    private string storeLocalSearchQuestionsResponseWritten;
    private bool flagHasLocalResults;
    private List< LocalResultJSON  > storeLocalResults;
    private bool flagHasAttribution;
    private AttributionJSON  storeAttribution;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraLocalSearchCommandKindToJSON()
      {
        JSONStringValue generated_string_LocalSearchCommandKind;
        generated_string_LocalSearchCommandKind = new JSONStringValue("ShowList");
        return generated_string_LocalSearchCommandKind;
      }

    private JSONValue  extraLocalSearchCriteriaToJSON()
      {
        JSONValueHandler handler_LocalSearchCriteria = new JSONValueHandler();
        storeLocalSearchCriteria.write_as_json(handler_LocalSearchCriteria);
        return handler_LocalSearchCriteria.result;
      }

    private JSONValue  extraLocalSearchCriteriaIncrementalToJSON()
      {
        JSONValueHandler handler_LocalSearchCriteriaIncremental = new JSONValueHandler();
        storeLocalSearchCriteriaIncremental.write_as_json(handler_LocalSearchCriteriaIncremental);
        return handler_LocalSearchCriteriaIncremental.result;
      }

    private JSONValue  extraLocationNotSupportedToJSON()
      {
        JSONValue generated_boolean_LocationNotSupported = (storeLocationNotSupported ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_LocationNotSupported;
      }

    private JSONValue  extraResultNameSingularSpokenToJSON()
      {
        JSONStringValue generated_string_ResultNameSingularSpoken = new JSONStringValue(storeResultNameSingularSpoken);
        return generated_string_ResultNameSingularSpoken;
      }

    private JSONValue  extraResultNamePluralSpokenToJSON()
      {
        JSONStringValue generated_string_ResultNamePluralSpoken = new JSONStringValue(storeResultNamePluralSpoken);
        return generated_string_ResultNamePluralSpoken;
      }

    private JSONValue  extraResultNameSingularWrittenToJSON()
      {
        JSONStringValue generated_string_ResultNameSingularWritten = new JSONStringValue(storeResultNameSingularWritten);
        return generated_string_ResultNameSingularWritten;
      }

    private JSONValue  extraResultNamePluralWrittenToJSON()
      {
        JSONStringValue generated_string_ResultNamePluralWritten = new JSONStringValue(storeResultNamePluralWritten);
        return generated_string_ResultNamePluralWritten;
      }

    private JSONValue  extraSimilarResultsReturnedToJSON()
      {
        JSONValue generated_boolean_SimilarResultsReturned = (storeSimilarResultsReturned ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_SimilarResultsReturned;
      }

    private JSONValue  extraSimilarResultLocalSearchCriteriaToJSON()
      {
        JSONValueHandler handler_SimilarResultLocalSearchCriteria = new JSONValueHandler();
        storeSimilarResultLocalSearchCriteria.write_as_json(handler_SimilarResultLocalSearchCriteria);
        return handler_SimilarResultLocalSearchCriteria.result;
      }

    private JSONValue  extraMessageUserSimilarResultsReturnedToJSON()
      {
        JSONValue generated_boolean_MessageUserSimilarResultsReturned = (storeMessageUserSimilarResultsReturned ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_MessageUserSimilarResultsReturned;
      }

    private JSONValue  extraSimilarResultNameSingularSpokenToJSON()
      {
        JSONStringValue generated_string_SimilarResultNameSingularSpoken = new JSONStringValue(storeSimilarResultNameSingularSpoken);
        return generated_string_SimilarResultNameSingularSpoken;
      }

    private JSONValue  extraSimilarResultNamePluralSpokenToJSON()
      {
        JSONStringValue generated_string_SimilarResultNamePluralSpoken = new JSONStringValue(storeSimilarResultNamePluralSpoken);
        return generated_string_SimilarResultNamePluralSpoken;
      }

    private JSONValue  extraSimilarResultNameSingularWrittenToJSON()
      {
        JSONStringValue generated_string_SimilarResultNameSingularWritten = new JSONStringValue(storeSimilarResultNameSingularWritten);
        return generated_string_SimilarResultNameSingularWritten;
      }

    private JSONValue  extraSimilarResultNamePluralWrittenToJSON()
      {
        JSONStringValue generated_string_SimilarResultNamePluralWritten = new JSONStringValue(storeSimilarResultNamePluralWritten);
        return generated_string_SimilarResultNamePluralWritten;
      }

    private JSONValue  extraLocalSearchQuestionsResponseSpokenToJSON()
      {
        JSONStringValue generated_string_LocalSearchQuestionsResponseSpoken = new JSONStringValue(storeLocalSearchQuestionsResponseSpoken);
        return generated_string_LocalSearchQuestionsResponseSpoken;
      }

    private JSONValue  extraLocalSearchQuestionsResponseWrittenToJSON()
      {
        JSONStringValue generated_string_LocalSearchQuestionsResponseWritten = new JSONStringValue(storeLocalSearchQuestionsResponseWritten);
        return generated_string_LocalSearchQuestionsResponseWritten;
      }

    private JSONValue  extraLocalResultsToJSON()
      {
        JSONArrayValue generated_array_1_LocalResults = new JSONArrayValue();
        for (int num1 = 0; num1 < storeLocalResults.Count; ++num1)
          {
            JSONValueHandler handler_LocalResults = new JSONValueHandler();
            storeLocalResults[num1].write_as_json(handler_LocalResults);
            generated_array_1_LocalResults.appendComponent(handler_LocalResults.result);
          }
        return generated_array_1_LocalResults;
      }

    private JSONValue  extraAttributionToJSON()
      {
        JSONValueHandler handler_Attribution = new JSONValueHandler();
        storeAttribution.write_as_json(handler_Attribution);
        return handler_Attribution.result;
      }


    private void  fromJSONLocalSearchCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LocalSearchCommandKind of LocalSearchInformationNuggetJSON is not a string.");
        if (!(json_string.getData().Equals("ShowList")))
            throw new Exception("The value for field LocalSearchCommandKind of LocalSearchInformationNuggetJSON is not `ShowList'.");
        setLocalSearchCommandKind();
      }


    private void  fromJSONLocalSearchCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        LocalSearchFilterSpecJSON convert_classy = LocalSearchFilterSpecJSON.from_json(json_value, ignore_extras, true);
        setLocalSearchCriteria(convert_classy);
      }


    private void  fromJSONLocalSearchCriteriaIncremental(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        LocalSearchFilterSpecJSON convert_classy = LocalSearchFilterSpecJSON.from_json(json_value, ignore_extras, true);
        setLocalSearchCriteriaIncremental(convert_classy);
      }


    private void  fromJSONLocationNotSupported(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field LocationNotSupported of LocalSearchInformationNuggetJSON is not true for false.");
              }
          }
        setLocationNotSupported(the_bool);
      }


    private void  fromJSONResultNameSingularSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResultNameSingularSpoken of LocalSearchInformationNuggetJSON is not a string.");
        setResultNameSingularSpoken(json_string.getData());
      }


    private void  fromJSONResultNamePluralSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResultNamePluralSpoken of LocalSearchInformationNuggetJSON is not a string.");
        setResultNamePluralSpoken(json_string.getData());
      }


    private void  fromJSONResultNameSingularWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResultNameSingularWritten of LocalSearchInformationNuggetJSON is not a string.");
        setResultNameSingularWritten(json_string.getData());
      }


    private void  fromJSONResultNamePluralWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResultNamePluralWritten of LocalSearchInformationNuggetJSON is not a string.");
        setResultNamePluralWritten(json_string.getData());
      }


    private void  fromJSONSimilarResultsReturned(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SimilarResultsReturned of LocalSearchInformationNuggetJSON is not true for false.");
              }
          }
        setSimilarResultsReturned(the_bool);
      }


    private void  fromJSONSimilarResultLocalSearchCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        LocalSearchFilterSpecJSON convert_classy = LocalSearchFilterSpecJSON.from_json(json_value, ignore_extras, true);
        setSimilarResultLocalSearchCriteria(convert_classy);
      }


    private void  fromJSONMessageUserSimilarResultsReturned(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MessageUserSimilarResultsReturned of LocalSearchInformationNuggetJSON is not true for false.");
              }
          }
        setMessageUserSimilarResultsReturned(the_bool);
      }


    private void  fromJSONSimilarResultNameSingularSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SimilarResultNameSingularSpoken of LocalSearchInformationNuggetJSON is not a string.");
        setSimilarResultNameSingularSpoken(json_string.getData());
      }


    private void  fromJSONSimilarResultNamePluralSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SimilarResultNamePluralSpoken of LocalSearchInformationNuggetJSON is not a string.");
        setSimilarResultNamePluralSpoken(json_string.getData());
      }


    private void  fromJSONSimilarResultNameSingularWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SimilarResultNameSingularWritten of LocalSearchInformationNuggetJSON is not a string.");
        setSimilarResultNameSingularWritten(json_string.getData());
      }


    private void  fromJSONSimilarResultNamePluralWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SimilarResultNamePluralWritten of LocalSearchInformationNuggetJSON is not a string.");
        setSimilarResultNamePluralWritten(json_string.getData());
      }


    private void  fromJSONLocalSearchQuestionsResponseSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LocalSearchQuestionsResponseSpoken of LocalSearchInformationNuggetJSON is not a string.");
        setLocalSearchQuestionsResponseSpoken(json_string.getData());
      }


    private void  fromJSONLocalSearchQuestionsResponseWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LocalSearchQuestionsResponseWritten of LocalSearchInformationNuggetJSON is not a string.");
        setLocalSearchQuestionsResponseWritten(json_string.getData());
      }


    private void  fromJSONLocalResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field LocalResults of LocalSearchInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< LocalResultJSON  > vector_LocalResults1 = new List< LocalResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            LocalResultJSON convert_classy = LocalResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_LocalResults1.Add(convert_classy);
          }
        initLocalResults();
        for (int num1 = 0; num1 < vector_LocalResults1.Count; ++num1)
            appendLocalResults(vector_LocalResults1[num1]);
        for (int num1 = 0; num1 < vector_LocalResults1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AttributionJSON convert_classy = AttributionJSON.from_json(json_value, ignore_extras, true);
        setAttribution(convert_classy);
      }


    public LocalSearchInformationNuggetJSON()
      {
        flagHasLocalSearchCommandKind = false;
        flagHasLocalSearchCriteria = false;
        flagHasLocalSearchCriteriaIncremental = false;
        flagHasLocationNotSupported = false;
        flagHasResultNameSingularSpoken = false;
        flagHasResultNamePluralSpoken = false;
        flagHasResultNameSingularWritten = false;
        flagHasResultNamePluralWritten = false;
        flagHasSimilarResultsReturned = false;
        flagHasSimilarResultLocalSearchCriteria = false;
        flagHasMessageUserSimilarResultsReturned = false;
        flagHasSimilarResultNameSingularSpoken = false;
        flagHasSimilarResultNamePluralSpoken = false;
        flagHasSimilarResultNameSingularWritten = false;
        flagHasSimilarResultNamePluralWritten = false;
        flagHasLocalSearchQuestionsResponseSpoken = false;
        flagHasLocalSearchQuestionsResponseWritten = false;
        flagHasLocalResults = false;
        flagHasAttribution = false;
        storeResultNameSingularSpoken = "result";
        storeResultNamePluralSpoken = "results";
        storeResultNameSingularWritten = "result";
        storeResultNamePluralWritten = "results";
        storeSimilarResultsReturned = false;
        storeMessageUserSimilarResultsReturned = false;
        storeSimilarResultNameSingularSpoken = "similar result";
        storeSimilarResultNamePluralSpoken = "similar results";
        storeSimilarResultNameSingularWritten = "similar result";
        storeSimilarResultNamePluralWritten = "similar results";
        storeLocalResults = new List< LocalResultJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "LocalSearch";
      }

    public bool  hasLocalSearchCommandKind()
      {
        return flagHasLocalSearchCommandKind;
      }

    public TypeLocalSearchCommandKind  getLocalSearchCommandKind()
      {
        Debug.Assert(flagHasLocalSearchCommandKind);
        return TypeLocalSearchCommandKind.LocalSearchCommandKind_ShowList;
      }

    public string  getLocalSearchCommandKindAsString()
      {
        return stringFromLocalSearchCommandKind(getLocalSearchCommandKind());
      }

    public bool  hasLocalSearchCriteria()
      {
        return flagHasLocalSearchCriteria;
      }

    public LocalSearchFilterSpecJSON   getLocalSearchCriteria()
      {
        Debug.Assert(flagHasLocalSearchCriteria);
        return storeLocalSearchCriteria;
      }

    public bool  hasLocalSearchCriteriaIncremental()
      {
        return flagHasLocalSearchCriteriaIncremental;
      }

    public LocalSearchFilterSpecJSON   getLocalSearchCriteriaIncremental()
      {
        Debug.Assert(flagHasLocalSearchCriteriaIncremental);
        return storeLocalSearchCriteriaIncremental;
      }

    public bool  hasLocationNotSupported()
      {
        return flagHasLocationNotSupported;
      }

    public bool  getLocationNotSupported()
      {
        Debug.Assert(flagHasLocationNotSupported);
        return storeLocationNotSupported;
      }

    public bool  hasResultNameSingularSpoken()
      {
        return flagHasResultNameSingularSpoken;
      }

    public string  getResultNameSingularSpoken()
      {
        return storeResultNameSingularSpoken;
      }

    public bool  hasResultNamePluralSpoken()
      {
        return flagHasResultNamePluralSpoken;
      }

    public string  getResultNamePluralSpoken()
      {
        return storeResultNamePluralSpoken;
      }

    public bool  hasResultNameSingularWritten()
      {
        return flagHasResultNameSingularWritten;
      }

    public string  getResultNameSingularWritten()
      {
        return storeResultNameSingularWritten;
      }

    public bool  hasResultNamePluralWritten()
      {
        return flagHasResultNamePluralWritten;
      }

    public string  getResultNamePluralWritten()
      {
        return storeResultNamePluralWritten;
      }

    public bool  hasSimilarResultsReturned()
      {
        return flagHasSimilarResultsReturned;
      }

    public bool  getSimilarResultsReturned()
      {
        return storeSimilarResultsReturned;
      }

    public bool  hasSimilarResultLocalSearchCriteria()
      {
        return flagHasSimilarResultLocalSearchCriteria;
      }

    public LocalSearchFilterSpecJSON   getSimilarResultLocalSearchCriteria()
      {
        Debug.Assert(flagHasSimilarResultLocalSearchCriteria);
        return storeSimilarResultLocalSearchCriteria;
      }

    public bool  hasMessageUserSimilarResultsReturned()
      {
        return flagHasMessageUserSimilarResultsReturned;
      }

    public bool  getMessageUserSimilarResultsReturned()
      {
        return storeMessageUserSimilarResultsReturned;
      }

    public bool  hasSimilarResultNameSingularSpoken()
      {
        return flagHasSimilarResultNameSingularSpoken;
      }

    public string  getSimilarResultNameSingularSpoken()
      {
        return storeSimilarResultNameSingularSpoken;
      }

    public bool  hasSimilarResultNamePluralSpoken()
      {
        return flagHasSimilarResultNamePluralSpoken;
      }

    public string  getSimilarResultNamePluralSpoken()
      {
        return storeSimilarResultNamePluralSpoken;
      }

    public bool  hasSimilarResultNameSingularWritten()
      {
        return flagHasSimilarResultNameSingularWritten;
      }

    public string  getSimilarResultNameSingularWritten()
      {
        return storeSimilarResultNameSingularWritten;
      }

    public bool  hasSimilarResultNamePluralWritten()
      {
        return flagHasSimilarResultNamePluralWritten;
      }

    public string  getSimilarResultNamePluralWritten()
      {
        return storeSimilarResultNamePluralWritten;
      }

    public bool  hasLocalSearchQuestionsResponseSpoken()
      {
        return flagHasLocalSearchQuestionsResponseSpoken;
      }

    public string  getLocalSearchQuestionsResponseSpoken()
      {
        Debug.Assert(flagHasLocalSearchQuestionsResponseSpoken);
        return storeLocalSearchQuestionsResponseSpoken;
      }

    public bool  hasLocalSearchQuestionsResponseWritten()
      {
        return flagHasLocalSearchQuestionsResponseWritten;
      }

    public string  getLocalSearchQuestionsResponseWritten()
      {
        Debug.Assert(flagHasLocalSearchQuestionsResponseWritten);
        return storeLocalSearchQuestionsResponseWritten;
      }

    public bool  hasLocalResults()
      {
        return flagHasLocalResults;
      }

    public int  countOfLocalResults()
      {
        Debug.Assert(flagHasLocalResults);
        return storeLocalResults.Count;
      }

    public LocalResultJSON   elementOfLocalResults(int element_num)
      {
        Debug.Assert(flagHasLocalResults);
        return storeLocalResults[element_num];
      }

    public List< LocalResultJSON  >  getLocalResults()
      {
        Debug.Assert(flagHasLocalResults);
        return storeLocalResults;
      }

    public bool  hasAttribution()
      {
        return flagHasAttribution;
      }

    public AttributionJSON   getAttribution()
      {
        Debug.Assert(flagHasAttribution);
        return storeAttribution;
      }


    public virtual int extraLocalSearchInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraLocalSearchInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraLocalSearchInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraLocalSearchInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasLocalSearchCommandKind)
            ++result;
        if (flagHasLocalSearchCriteria)
            ++result;
        if (flagHasLocalSearchCriteriaIncremental)
            ++result;
        if (flagHasLocationNotSupported)
            ++result;
        if (flagHasResultNameSingularSpoken)
            ++result;
        if (flagHasResultNamePluralSpoken)
            ++result;
        if (flagHasResultNameSingularWritten)
            ++result;
        if (flagHasResultNamePluralWritten)
            ++result;
        if (flagHasSimilarResultsReturned)
            ++result;
        if (flagHasSimilarResultLocalSearchCriteria)
            ++result;
        if (flagHasMessageUserSimilarResultsReturned)
            ++result;
        if (flagHasSimilarResultNameSingularSpoken)
            ++result;
        if (flagHasSimilarResultNamePluralSpoken)
            ++result;
        if (flagHasSimilarResultNameSingularWritten)
            ++result;
        if (flagHasSimilarResultNamePluralWritten)
            ++result;
        if (flagHasLocalSearchQuestionsResponseSpoken)
            ++result;
        if (flagHasLocalSearchQuestionsResponseWritten)
            ++result;
        if (flagHasLocalResults)
            ++result;
        if (flagHasAttribution)
            ++result;
        result += extraLocalSearchInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasLocalSearchCommandKind)
          {
            if (remainder == 0)
                return "LocalSearchCommandKind";
            --remainder;
          }
        if (flagHasLocalSearchCriteria)
          {
            if (remainder == 0)
                return "LocalSearchCriteria";
            --remainder;
          }
        if (flagHasLocalSearchCriteriaIncremental)
          {
            if (remainder == 0)
                return "LocalSearchCriteriaIncremental";
            --remainder;
          }
        if (flagHasLocationNotSupported)
          {
            if (remainder == 0)
                return "LocationNotSupported";
            --remainder;
          }
        if (flagHasResultNameSingularSpoken)
          {
            if (remainder == 0)
                return "ResultNameSingularSpoken";
            --remainder;
          }
        if (flagHasResultNamePluralSpoken)
          {
            if (remainder == 0)
                return "ResultNamePluralSpoken";
            --remainder;
          }
        if (flagHasResultNameSingularWritten)
          {
            if (remainder == 0)
                return "ResultNameSingularWritten";
            --remainder;
          }
        if (flagHasResultNamePluralWritten)
          {
            if (remainder == 0)
                return "ResultNamePluralWritten";
            --remainder;
          }
        if (flagHasSimilarResultsReturned)
          {
            if (remainder == 0)
                return "SimilarResultsReturned";
            --remainder;
          }
        if (flagHasSimilarResultLocalSearchCriteria)
          {
            if (remainder == 0)
                return "SimilarResultLocalSearchCriteria";
            --remainder;
          }
        if (flagHasMessageUserSimilarResultsReturned)
          {
            if (remainder == 0)
                return "MessageUserSimilarResultsReturned";
            --remainder;
          }
        if (flagHasSimilarResultNameSingularSpoken)
          {
            if (remainder == 0)
                return "SimilarResultNameSingularSpoken";
            --remainder;
          }
        if (flagHasSimilarResultNamePluralSpoken)
          {
            if (remainder == 0)
                return "SimilarResultNamePluralSpoken";
            --remainder;
          }
        if (flagHasSimilarResultNameSingularWritten)
          {
            if (remainder == 0)
                return "SimilarResultNameSingularWritten";
            --remainder;
          }
        if (flagHasSimilarResultNamePluralWritten)
          {
            if (remainder == 0)
                return "SimilarResultNamePluralWritten";
            --remainder;
          }
        if (flagHasLocalSearchQuestionsResponseSpoken)
          {
            if (remainder == 0)
                return "LocalSearchQuestionsResponseSpoken";
            --remainder;
          }
        if (flagHasLocalSearchQuestionsResponseWritten)
          {
            if (remainder == 0)
                return "LocalSearchQuestionsResponseWritten";
            --remainder;
          }
        if (flagHasLocalResults)
          {
            if (remainder == 0)
                return "LocalResults";
            --remainder;
          }
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return "Attribution";
            --remainder;
          }
        return extraLocalSearchInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasLocalSearchCommandKind)
          {
            if (remainder == 0)
                return extraLocalSearchCommandKindToJSON();
            --remainder;
          }
        if (flagHasLocalSearchCriteria)
          {
            if (remainder == 0)
                return extraLocalSearchCriteriaToJSON();
            --remainder;
          }
        if (flagHasLocalSearchCriteriaIncremental)
          {
            if (remainder == 0)
                return extraLocalSearchCriteriaIncrementalToJSON();
            --remainder;
          }
        if (flagHasLocationNotSupported)
          {
            if (remainder == 0)
                return extraLocationNotSupportedToJSON();
            --remainder;
          }
        if (flagHasResultNameSingularSpoken)
          {
            if (remainder == 0)
                return extraResultNameSingularSpokenToJSON();
            --remainder;
          }
        if (flagHasResultNamePluralSpoken)
          {
            if (remainder == 0)
                return extraResultNamePluralSpokenToJSON();
            --remainder;
          }
        if (flagHasResultNameSingularWritten)
          {
            if (remainder == 0)
                return extraResultNameSingularWrittenToJSON();
            --remainder;
          }
        if (flagHasResultNamePluralWritten)
          {
            if (remainder == 0)
                return extraResultNamePluralWrittenToJSON();
            --remainder;
          }
        if (flagHasSimilarResultsReturned)
          {
            if (remainder == 0)
                return extraSimilarResultsReturnedToJSON();
            --remainder;
          }
        if (flagHasSimilarResultLocalSearchCriteria)
          {
            if (remainder == 0)
                return extraSimilarResultLocalSearchCriteriaToJSON();
            --remainder;
          }
        if (flagHasMessageUserSimilarResultsReturned)
          {
            if (remainder == 0)
                return extraMessageUserSimilarResultsReturnedToJSON();
            --remainder;
          }
        if (flagHasSimilarResultNameSingularSpoken)
          {
            if (remainder == 0)
                return extraSimilarResultNameSingularSpokenToJSON();
            --remainder;
          }
        if (flagHasSimilarResultNamePluralSpoken)
          {
            if (remainder == 0)
                return extraSimilarResultNamePluralSpokenToJSON();
            --remainder;
          }
        if (flagHasSimilarResultNameSingularWritten)
          {
            if (remainder == 0)
                return extraSimilarResultNameSingularWrittenToJSON();
            --remainder;
          }
        if (flagHasSimilarResultNamePluralWritten)
          {
            if (remainder == 0)
                return extraSimilarResultNamePluralWrittenToJSON();
            --remainder;
          }
        if (flagHasLocalSearchQuestionsResponseSpoken)
          {
            if (remainder == 0)
                return extraLocalSearchQuestionsResponseSpokenToJSON();
            --remainder;
          }
        if (flagHasLocalSearchQuestionsResponseWritten)
          {
            if (remainder == 0)
                return extraLocalSearchQuestionsResponseWrittenToJSON();
            --remainder;
          }
        if (flagHasLocalResults)
          {
            if (remainder == 0)
                return extraLocalResultsToJSON();
            --remainder;
          }
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return extraAttributionToJSON();
            --remainder;
          }
        return extraLocalSearchInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasAttribution ? extraAttributionToJSON() : null);
                break;
            case 'L':
                if (String.Compare(field_name, 1, "oca", 0, 3, false) == 0)
                  {
                    switch (field_name[4])
                      {
                        case 'l':
                            switch (field_name[5])
                              {
                                case 'R':
                                    if ((String.Compare(field_name, 6, "esults", 0, 6, false) == 0) && (field_name.Length == 12))
                                        return (flagHasLocalResults ? extraLocalResultsToJSON() : null);
                                    break;
                                case 'S':
                                    if (String.Compare(field_name, 6, "earch", 0, 5, false) == 0)
                                      {
                                        switch (field_name[11])
                                          {
                                            case 'C':
                                                switch (field_name[12])
                                                  {
                                                    case 'o':
                                                        if ((String.Compare(field_name, 13, "mmandKind", 0, 9, false) == 0) && (field_name.Length == 22))
                                                            return (flagHasLocalSearchCommandKind ? extraLocalSearchCommandKindToJSON() : null);
                                                        break;
                                                    case 'r':
                                                        if (String.Compare(field_name, 13, "iteria", 0, 6, false) == 0)
                                                          {
                                                            if (field_name.Length == 19)
                                                              {
                                                                return (flagHasLocalSearchCriteria ? extraLocalSearchCriteriaToJSON() : null);
                                                              }
                                                            switch (field_name[19])
                                                              {
                                                                case 'I':
                                                                    if ((String.Compare(field_name, 20, "ncremental", 0, 10, false) == 0) && (field_name.Length == 30))
                                                                        return (flagHasLocalSearchCriteriaIncremental ? extraLocalSearchCriteriaIncrementalToJSON() : null);
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
                                            case 'Q':
                                                if (String.Compare(field_name, 12, "uestionsResponse", 0, 16, false) == 0)
                                                  {
                                                    switch (field_name[28])
                                                      {
                                                        case 'S':
                                                            if ((String.Compare(field_name, 29, "poken", 0, 5, false) == 0) && (field_name.Length == 34))
                                                                return (flagHasLocalSearchQuestionsResponseSpoken ? extraLocalSearchQuestionsResponseSpokenToJSON() : null);
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(field_name, 29, "ritten", 0, 6, false) == 0) && (field_name.Length == 35))
                                                                return (flagHasLocalSearchQuestionsResponseWritten ? extraLocalSearchQuestionsResponseWrittenToJSON() : null);
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
                            break;
                        case 't':
                            if ((String.Compare(field_name, 5, "ionNotSupported", 0, 15, false) == 0) && (field_name.Length == 20))
                                return (flagHasLocationNotSupported ? extraLocationNotSupportedToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "essageUserSimilarResultsReturned", 0, 32, false) == 0) && (field_name.Length == 33))
                    return (flagHasMessageUserSimilarResultsReturned ? extraMessageUserSimilarResultsReturnedToJSON() : null);
                break;
            case 'R':
                if (String.Compare(field_name, 1, "esultName", 0, 9, false) == 0)
                  {
                    switch (field_name[10])
                      {
                        case 'P':
                            if (String.Compare(field_name, 11, "lural", 0, 5, false) == 0)
                              {
                                switch (field_name[16])
                                  {
                                    case 'S':
                                        if ((String.Compare(field_name, 17, "poken", 0, 5, false) == 0) && (field_name.Length == 22))
                                            return (flagHasResultNamePluralSpoken ? extraResultNamePluralSpokenToJSON() : null);
                                        break;
                                    case 'W':
                                        if ((String.Compare(field_name, 17, "ritten", 0, 6, false) == 0) && (field_name.Length == 23))
                                            return (flagHasResultNamePluralWritten ? extraResultNamePluralWrittenToJSON() : null);
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            if (String.Compare(field_name, 11, "ingular", 0, 7, false) == 0)
                              {
                                switch (field_name[18])
                                  {
                                    case 'S':
                                        if ((String.Compare(field_name, 19, "poken", 0, 5, false) == 0) && (field_name.Length == 24))
                                            return (flagHasResultNameSingularSpoken ? extraResultNameSingularSpokenToJSON() : null);
                                        break;
                                    case 'W':
                                        if ((String.Compare(field_name, 19, "ritten", 0, 6, false) == 0) && (field_name.Length == 25))
                                            return (flagHasResultNameSingularWritten ? extraResultNameSingularWrittenToJSON() : null);
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
                if (String.Compare(field_name, 1, "imilarResult", 0, 12, false) == 0)
                  {
                    switch (field_name[13])
                      {
                        case 'L':
                            if ((String.Compare(field_name, 14, "ocalSearchCriteria", 0, 18, false) == 0) && (field_name.Length == 32))
                                return (flagHasSimilarResultLocalSearchCriteria ? extraSimilarResultLocalSearchCriteriaToJSON() : null);
                            break;
                        case 'N':
                            if (String.Compare(field_name, 14, "ame", 0, 3, false) == 0)
                              {
                                switch (field_name[17])
                                  {
                                    case 'P':
                                        if (String.Compare(field_name, 18, "lural", 0, 5, false) == 0)
                                          {
                                            switch (field_name[23])
                                              {
                                                case 'S':
                                                    if ((String.Compare(field_name, 24, "poken", 0, 5, false) == 0) && (field_name.Length == 29))
                                                        return (flagHasSimilarResultNamePluralSpoken ? extraSimilarResultNamePluralSpokenToJSON() : null);
                                                    break;
                                                case 'W':
                                                    if ((String.Compare(field_name, 24, "ritten", 0, 6, false) == 0) && (field_name.Length == 30))
                                                        return (flagHasSimilarResultNamePluralWritten ? extraSimilarResultNamePluralWrittenToJSON() : null);
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'S':
                                        if (String.Compare(field_name, 18, "ingular", 0, 7, false) == 0)
                                          {
                                            switch (field_name[25])
                                              {
                                                case 'S':
                                                    if ((String.Compare(field_name, 26, "poken", 0, 5, false) == 0) && (field_name.Length == 31))
                                                        return (flagHasSimilarResultNameSingularSpoken ? extraSimilarResultNameSingularSpokenToJSON() : null);
                                                    break;
                                                case 'W':
                                                    if ((String.Compare(field_name, 26, "ritten", 0, 6, false) == 0) && (field_name.Length == 32))
                                                        return (flagHasSimilarResultNameSingularWritten ? extraSimilarResultNameSingularWrittenToJSON() : null);
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
                        case 's':
                            if ((String.Compare(field_name, 14, "Returned", 0, 8, false) == 0) && (field_name.Length == 22))
                                return (flagHasSimilarResultsReturned ? extraSimilarResultsReturnedToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraLocalSearchInformationNuggetLookup(field_name);
      }

    public void setLocalSearchCommandKind()
      {
        flagHasLocalSearchCommandKind = true;
      }
    public void setLocalSearchCommandKind(TypeLocalSearchCommandKind new_value)
      {
        setLocalSearchCommandKind();
      }
    public void setLocalSearchCommandKind(string chars)
      {
        setLocalSearchCommandKind(stringToLocalSearchCommandKind(chars));
      }
    public void unsetLocalSearchCommandKind()
      {
        flagHasLocalSearchCommandKind = false;
      }
    public void setLocalSearchCriteria(LocalSearchFilterSpecJSON  new_value)
      {
        if (flagHasLocalSearchCriteria)
          {
          }
        flagHasLocalSearchCriteria = true;
        storeLocalSearchCriteria = new_value;
      }
    public void unsetLocalSearchCriteria()
      {
        if (flagHasLocalSearchCriteria)
          {
          }
        flagHasLocalSearchCriteria = false;
      }
    public void setLocalSearchCriteriaIncremental(LocalSearchFilterSpecJSON  new_value)
      {
        if (flagHasLocalSearchCriteriaIncremental)
          {
          }
        flagHasLocalSearchCriteriaIncremental = true;
        storeLocalSearchCriteriaIncremental = new_value;
      }
    public void unsetLocalSearchCriteriaIncremental()
      {
        if (flagHasLocalSearchCriteriaIncremental)
          {
          }
        flagHasLocalSearchCriteriaIncremental = false;
      }
    public void setLocationNotSupported(bool new_value)
      {
        flagHasLocationNotSupported = true;
        storeLocationNotSupported = new_value;
      }
    public void unsetLocationNotSupported()
      {
        flagHasLocationNotSupported = false;
      }
    public void setResultNameSingularSpoken(string new_value)
      {
        flagHasResultNameSingularSpoken = true;
        storeResultNameSingularSpoken = new_value;
      }
    public void unsetResultNameSingularSpoken()
      {
        flagHasResultNameSingularSpoken = false;
      }
    public void setResultNamePluralSpoken(string new_value)
      {
        flagHasResultNamePluralSpoken = true;
        storeResultNamePluralSpoken = new_value;
      }
    public void unsetResultNamePluralSpoken()
      {
        flagHasResultNamePluralSpoken = false;
      }
    public void setResultNameSingularWritten(string new_value)
      {
        flagHasResultNameSingularWritten = true;
        storeResultNameSingularWritten = new_value;
      }
    public void unsetResultNameSingularWritten()
      {
        flagHasResultNameSingularWritten = false;
      }
    public void setResultNamePluralWritten(string new_value)
      {
        flagHasResultNamePluralWritten = true;
        storeResultNamePluralWritten = new_value;
      }
    public void unsetResultNamePluralWritten()
      {
        flagHasResultNamePluralWritten = false;
      }
    public void setSimilarResultsReturned(bool new_value)
      {
        flagHasSimilarResultsReturned = true;
        storeSimilarResultsReturned = new_value;
      }
    public void unsetSimilarResultsReturned()
      {
        flagHasSimilarResultsReturned = false;
      }
    public void setSimilarResultLocalSearchCriteria(LocalSearchFilterSpecJSON  new_value)
      {
        if (flagHasSimilarResultLocalSearchCriteria)
          {
          }
        flagHasSimilarResultLocalSearchCriteria = true;
        storeSimilarResultLocalSearchCriteria = new_value;
      }
    public void unsetSimilarResultLocalSearchCriteria()
      {
        if (flagHasSimilarResultLocalSearchCriteria)
          {
          }
        flagHasSimilarResultLocalSearchCriteria = false;
      }
    public void setMessageUserSimilarResultsReturned(bool new_value)
      {
        flagHasMessageUserSimilarResultsReturned = true;
        storeMessageUserSimilarResultsReturned = new_value;
      }
    public void unsetMessageUserSimilarResultsReturned()
      {
        flagHasMessageUserSimilarResultsReturned = false;
      }
    public void setSimilarResultNameSingularSpoken(string new_value)
      {
        flagHasSimilarResultNameSingularSpoken = true;
        storeSimilarResultNameSingularSpoken = new_value;
      }
    public void unsetSimilarResultNameSingularSpoken()
      {
        flagHasSimilarResultNameSingularSpoken = false;
      }
    public void setSimilarResultNamePluralSpoken(string new_value)
      {
        flagHasSimilarResultNamePluralSpoken = true;
        storeSimilarResultNamePluralSpoken = new_value;
      }
    public void unsetSimilarResultNamePluralSpoken()
      {
        flagHasSimilarResultNamePluralSpoken = false;
      }
    public void setSimilarResultNameSingularWritten(string new_value)
      {
        flagHasSimilarResultNameSingularWritten = true;
        storeSimilarResultNameSingularWritten = new_value;
      }
    public void unsetSimilarResultNameSingularWritten()
      {
        flagHasSimilarResultNameSingularWritten = false;
      }
    public void setSimilarResultNamePluralWritten(string new_value)
      {
        flagHasSimilarResultNamePluralWritten = true;
        storeSimilarResultNamePluralWritten = new_value;
      }
    public void unsetSimilarResultNamePluralWritten()
      {
        flagHasSimilarResultNamePluralWritten = false;
      }
    public void setLocalSearchQuestionsResponseSpoken(string new_value)
      {
        flagHasLocalSearchQuestionsResponseSpoken = true;
        storeLocalSearchQuestionsResponseSpoken = new_value;
      }
    public void unsetLocalSearchQuestionsResponseSpoken()
      {
        flagHasLocalSearchQuestionsResponseSpoken = false;
      }
    public void setLocalSearchQuestionsResponseWritten(string new_value)
      {
        flagHasLocalSearchQuestionsResponseWritten = true;
        storeLocalSearchQuestionsResponseWritten = new_value;
      }
    public void unsetLocalSearchQuestionsResponseWritten()
      {
        flagHasLocalSearchQuestionsResponseWritten = false;
      }
    public void initLocalResults()
      {
        if (flagHasLocalResults)
          {
            for (int num1 = 0; num1 < storeLocalResults.Count; ++num1)
              {
              }
          }
        flagHasLocalResults = true;
        storeLocalResults.Clear();
      }
    public void appendLocalResults(LocalResultJSON  to_append)
      {
        if (!flagHasLocalResults)
          {
            flagHasLocalResults = true;
            storeLocalResults.Clear();
          }
        Debug.Assert(flagHasLocalResults);
        storeLocalResults.Add(to_append);
      }
    public void unsetLocalResults()
      {
        if (flagHasLocalResults)
          {
            for (int num2 = 0; num2 < storeLocalResults.Count; ++num2)
              {
              }
          }
        flagHasLocalResults = false;
        storeLocalResults.Clear();
      }
    public void setAttribution(AttributionJSON  new_value)
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = true;
        storeAttribution = new_value;
      }
    public void unsetAttribution()
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = false;
      }

    public virtual void extraLocalSearchInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraLocalSearchInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraLocalSearchInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraLocalSearchInformationNuggetAppendPair(key, new_component);
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
            case 'A':
                if ((String.Compare(key, 1, "ttribution", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAttribution(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if (String.Compare(key, 1, "oca", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case 'l':
                            switch (key[5])
                              {
                                case 'R':
                                    if ((String.Compare(key, 6, "esults", 0, 6, false) == 0) && (key.Length == 12))
                                        {
                                        fromJSONLocalResults(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if (String.Compare(key, 6, "earch", 0, 5, false) == 0)
                                      {
                                        switch (key[11])
                                          {
                                            case 'C':
                                                switch (key[12])
                                                  {
                                                    case 'o':
                                                        if ((String.Compare(key, 13, "mmandKind", 0, 9, false) == 0) && (key.Length == 22))
                                                            {
                                                            fromJSONLocalSearchCommandKind(new_component, false);
                                                            return;
                                                            }
                                                        break;
                                                    case 'r':
                                                        if (String.Compare(key, 13, "iteria", 0, 6, false) == 0)
                                                          {
                                                            if (key.Length == 19)
                                                              {
                                                                {
                                                                fromJSONLocalSearchCriteria(new_component, false);
                                                                return;
                                                                }
                                                              }
                                                            switch (key[19])
                                                              {
                                                                case 'I':
                                                                    if ((String.Compare(key, 20, "ncremental", 0, 10, false) == 0) && (key.Length == 30))
                                                                        {
                                                                        fromJSONLocalSearchCriteriaIncremental(new_component, false);
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
                                                break;
                                            case 'Q':
                                                if (String.Compare(key, 12, "uestionsResponse", 0, 16, false) == 0)
                                                  {
                                                    switch (key[28])
                                                      {
                                                        case 'S':
                                                            if ((String.Compare(key, 29, "poken", 0, 5, false) == 0) && (key.Length == 34))
                                                                {
                                                                fromJSONLocalSearchQuestionsResponseSpoken(new_component, false);
                                                                return;
                                                                }
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(key, 29, "ritten", 0, 6, false) == 0) && (key.Length == 35))
                                                                {
                                                                fromJSONLocalSearchQuestionsResponseWritten(new_component, false);
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
                                default:
                                    break;
                              }
                            break;
                        case 't':
                            if ((String.Compare(key, 5, "ionNotSupported", 0, 15, false) == 0) && (key.Length == 20))
                                {
                                fromJSONLocationNotSupported(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if ((String.Compare(key, 1, "essageUserSimilarResultsReturned", 0, 32, false) == 0) && (key.Length == 33))
                    {
                    fromJSONMessageUserSimilarResultsReturned(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if (String.Compare(key, 1, "esultName", 0, 9, false) == 0)
                  {
                    switch (key[10])
                      {
                        case 'P':
                            if (String.Compare(key, 11, "lural", 0, 5, false) == 0)
                              {
                                switch (key[16])
                                  {
                                    case 'S':
                                        if ((String.Compare(key, 17, "poken", 0, 5, false) == 0) && (key.Length == 22))
                                            {
                                            fromJSONResultNamePluralSpoken(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'W':
                                        if ((String.Compare(key, 17, "ritten", 0, 6, false) == 0) && (key.Length == 23))
                                            {
                                            fromJSONResultNamePluralWritten(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            if (String.Compare(key, 11, "ingular", 0, 7, false) == 0)
                              {
                                switch (key[18])
                                  {
                                    case 'S':
                                        if ((String.Compare(key, 19, "poken", 0, 5, false) == 0) && (key.Length == 24))
                                            {
                                            fromJSONResultNameSingularSpoken(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'W':
                                        if ((String.Compare(key, 19, "ritten", 0, 6, false) == 0) && (key.Length == 25))
                                            {
                                            fromJSONResultNameSingularWritten(new_component, false);
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
                if (String.Compare(key, 1, "imilarResult", 0, 12, false) == 0)
                  {
                    switch (key[13])
                      {
                        case 'L':
                            if ((String.Compare(key, 14, "ocalSearchCriteria", 0, 18, false) == 0) && (key.Length == 32))
                                {
                                fromJSONSimilarResultLocalSearchCriteria(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if (String.Compare(key, 14, "ame", 0, 3, false) == 0)
                              {
                                switch (key[17])
                                  {
                                    case 'P':
                                        if (String.Compare(key, 18, "lural", 0, 5, false) == 0)
                                          {
                                            switch (key[23])
                                              {
                                                case 'S':
                                                    if ((String.Compare(key, 24, "poken", 0, 5, false) == 0) && (key.Length == 29))
                                                        {
                                                        fromJSONSimilarResultNamePluralSpoken(new_component, false);
                                                        return;
                                                        }
                                                    break;
                                                case 'W':
                                                    if ((String.Compare(key, 24, "ritten", 0, 6, false) == 0) && (key.Length == 30))
                                                        {
                                                        fromJSONSimilarResultNamePluralWritten(new_component, false);
                                                        return;
                                                        }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'S':
                                        if (String.Compare(key, 18, "ingular", 0, 7, false) == 0)
                                          {
                                            switch (key[25])
                                              {
                                                case 'S':
                                                    if ((String.Compare(key, 26, "poken", 0, 5, false) == 0) && (key.Length == 31))
                                                        {
                                                        fromJSONSimilarResultNameSingularSpoken(new_component, false);
                                                        return;
                                                        }
                                                    break;
                                                case 'W':
                                                    if ((String.Compare(key, 26, "ritten", 0, 6, false) == 0) && (key.Length == 32))
                                                        {
                                                        fromJSONSimilarResultNameSingularWritten(new_component, false);
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
                        case 's':
                            if ((String.Compare(key, 14, "Returned", 0, 8, false) == 0) && (key.Length == 22))
                                {
                                fromJSONSimilarResultsReturned(new_component, false);
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
        extraLocalSearchInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttribution", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAttribution(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if (String.Compare(key, 1, "oca", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case 'l':
                            switch (key[5])
                              {
                                case 'R':
                                    if ((String.Compare(key, 6, "esults", 0, 6, false) == 0) && (key.Length == 12))
                                        {
                                        fromJSONLocalResults(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if (String.Compare(key, 6, "earch", 0, 5, false) == 0)
                                      {
                                        switch (key[11])
                                          {
                                            case 'C':
                                                switch (key[12])
                                                  {
                                                    case 'o':
                                                        if ((String.Compare(key, 13, "mmandKind", 0, 9, false) == 0) && (key.Length == 22))
                                                            {
                                                            fromJSONLocalSearchCommandKind(new_component, false);
                                                            return;
                                                            }
                                                        break;
                                                    case 'r':
                                                        if (String.Compare(key, 13, "iteria", 0, 6, false) == 0)
                                                          {
                                                            if (key.Length == 19)
                                                              {
                                                                {
                                                                fromJSONLocalSearchCriteria(new_component, false);
                                                                return;
                                                                }
                                                              }
                                                            switch (key[19])
                                                              {
                                                                case 'I':
                                                                    if ((String.Compare(key, 20, "ncremental", 0, 10, false) == 0) && (key.Length == 30))
                                                                        {
                                                                        fromJSONLocalSearchCriteriaIncremental(new_component, false);
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
                                                break;
                                            case 'Q':
                                                if (String.Compare(key, 12, "uestionsResponse", 0, 16, false) == 0)
                                                  {
                                                    switch (key[28])
                                                      {
                                                        case 'S':
                                                            if ((String.Compare(key, 29, "poken", 0, 5, false) == 0) && (key.Length == 34))
                                                                {
                                                                fromJSONLocalSearchQuestionsResponseSpoken(new_component, false);
                                                                return;
                                                                }
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(key, 29, "ritten", 0, 6, false) == 0) && (key.Length == 35))
                                                                {
                                                                fromJSONLocalSearchQuestionsResponseWritten(new_component, false);
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
                                default:
                                    break;
                              }
                            break;
                        case 't':
                            if ((String.Compare(key, 5, "ionNotSupported", 0, 15, false) == 0) && (key.Length == 20))
                                {
                                fromJSONLocationNotSupported(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if ((String.Compare(key, 1, "essageUserSimilarResultsReturned", 0, 32, false) == 0) && (key.Length == 33))
                    {
                    fromJSONMessageUserSimilarResultsReturned(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if (String.Compare(key, 1, "esultName", 0, 9, false) == 0)
                  {
                    switch (key[10])
                      {
                        case 'P':
                            if (String.Compare(key, 11, "lural", 0, 5, false) == 0)
                              {
                                switch (key[16])
                                  {
                                    case 'S':
                                        if ((String.Compare(key, 17, "poken", 0, 5, false) == 0) && (key.Length == 22))
                                            {
                                            fromJSONResultNamePluralSpoken(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'W':
                                        if ((String.Compare(key, 17, "ritten", 0, 6, false) == 0) && (key.Length == 23))
                                            {
                                            fromJSONResultNamePluralWritten(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            if (String.Compare(key, 11, "ingular", 0, 7, false) == 0)
                              {
                                switch (key[18])
                                  {
                                    case 'S':
                                        if ((String.Compare(key, 19, "poken", 0, 5, false) == 0) && (key.Length == 24))
                                            {
                                            fromJSONResultNameSingularSpoken(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'W':
                                        if ((String.Compare(key, 19, "ritten", 0, 6, false) == 0) && (key.Length == 25))
                                            {
                                            fromJSONResultNameSingularWritten(new_component, false);
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
                if (String.Compare(key, 1, "imilarResult", 0, 12, false) == 0)
                  {
                    switch (key[13])
                      {
                        case 'L':
                            if ((String.Compare(key, 14, "ocalSearchCriteria", 0, 18, false) == 0) && (key.Length == 32))
                                {
                                fromJSONSimilarResultLocalSearchCriteria(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if (String.Compare(key, 14, "ame", 0, 3, false) == 0)
                              {
                                switch (key[17])
                                  {
                                    case 'P':
                                        if (String.Compare(key, 18, "lural", 0, 5, false) == 0)
                                          {
                                            switch (key[23])
                                              {
                                                case 'S':
                                                    if ((String.Compare(key, 24, "poken", 0, 5, false) == 0) && (key.Length == 29))
                                                        {
                                                        fromJSONSimilarResultNamePluralSpoken(new_component, false);
                                                        return;
                                                        }
                                                    break;
                                                case 'W':
                                                    if ((String.Compare(key, 24, "ritten", 0, 6, false) == 0) && (key.Length == 30))
                                                        {
                                                        fromJSONSimilarResultNamePluralWritten(new_component, false);
                                                        return;
                                                        }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'S':
                                        if (String.Compare(key, 18, "ingular", 0, 7, false) == 0)
                                          {
                                            switch (key[25])
                                              {
                                                case 'S':
                                                    if ((String.Compare(key, 26, "poken", 0, 5, false) == 0) && (key.Length == 31))
                                                        {
                                                        fromJSONSimilarResultNameSingularSpoken(new_component, false);
                                                        return;
                                                        }
                                                    break;
                                                case 'W':
                                                    if ((String.Compare(key, 26, "ritten", 0, 6, false) == 0) && (key.Length == 32))
                                                        {
                                                        fromJSONSimilarResultNameSingularWritten(new_component, false);
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
                        case 's':
                            if ((String.Compare(key, 14, "Returned", 0, 8, false) == 0) && (key.Length == 22))
                                {
                                fromJSONSimilarResultsReturned(new_component, false);
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
        extraLocalSearchInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasLocalSearchCommandKind);
        if (flagHasLocalSearchCommandKind)
          {
            handler.start_pair("LocalSearchCommandKind");
            handler.string_value("ShowList");
          }
        if (flagHasLocalSearchCriteria)
          {
            handler.start_pair("LocalSearchCriteria");
            if (partial_allowed)
                storeLocalSearchCriteria.write_partial_as_json(handler);
            else
                storeLocalSearchCriteria.write_as_json(handler);
          }
        if (flagHasLocalSearchCriteriaIncremental)
          {
            handler.start_pair("LocalSearchCriteriaIncremental");
            if (partial_allowed)
                storeLocalSearchCriteriaIncremental.write_partial_as_json(handler);
            else
                storeLocalSearchCriteriaIncremental.write_as_json(handler);
          }
        if (flagHasLocationNotSupported)
          {
            handler.start_pair("LocationNotSupported");
            handler.boolean_value(storeLocationNotSupported);
          }
        Debug.Assert(partial_allowed || flagHasResultNameSingularSpoken);
        if (flagHasResultNameSingularSpoken)
          {
            handler.start_pair("ResultNameSingularSpoken");
            handler.string_value(storeResultNameSingularSpoken);
          }
        Debug.Assert(partial_allowed || flagHasResultNamePluralSpoken);
        if (flagHasResultNamePluralSpoken)
          {
            handler.start_pair("ResultNamePluralSpoken");
            handler.string_value(storeResultNamePluralSpoken);
          }
        Debug.Assert(partial_allowed || flagHasResultNameSingularWritten);
        if (flagHasResultNameSingularWritten)
          {
            handler.start_pair("ResultNameSingularWritten");
            handler.string_value(storeResultNameSingularWritten);
          }
        Debug.Assert(partial_allowed || flagHasResultNamePluralWritten);
        if (flagHasResultNamePluralWritten)
          {
            handler.start_pair("ResultNamePluralWritten");
            handler.string_value(storeResultNamePluralWritten);
          }
        if (flagHasSimilarResultsReturned)
          {
            handler.start_pair("SimilarResultsReturned");
            handler.boolean_value(storeSimilarResultsReturned);
          }
        if (flagHasSimilarResultLocalSearchCriteria)
          {
            handler.start_pair("SimilarResultLocalSearchCriteria");
            if (partial_allowed)
                storeSimilarResultLocalSearchCriteria.write_partial_as_json(handler);
            else
                storeSimilarResultLocalSearchCriteria.write_as_json(handler);
          }
        if (flagHasMessageUserSimilarResultsReturned)
          {
            handler.start_pair("MessageUserSimilarResultsReturned");
            handler.boolean_value(storeMessageUserSimilarResultsReturned);
          }
        if (flagHasSimilarResultNameSingularSpoken)
          {
            handler.start_pair("SimilarResultNameSingularSpoken");
            handler.string_value(storeSimilarResultNameSingularSpoken);
          }
        if (flagHasSimilarResultNamePluralSpoken)
          {
            handler.start_pair("SimilarResultNamePluralSpoken");
            handler.string_value(storeSimilarResultNamePluralSpoken);
          }
        if (flagHasSimilarResultNameSingularWritten)
          {
            handler.start_pair("SimilarResultNameSingularWritten");
            handler.string_value(storeSimilarResultNameSingularWritten);
          }
        if (flagHasSimilarResultNamePluralWritten)
          {
            handler.start_pair("SimilarResultNamePluralWritten");
            handler.string_value(storeSimilarResultNamePluralWritten);
          }
        if (flagHasLocalSearchQuestionsResponseSpoken)
          {
            handler.start_pair("LocalSearchQuestionsResponseSpoken");
            handler.string_value(storeLocalSearchQuestionsResponseSpoken);
          }
        if (flagHasLocalSearchQuestionsResponseWritten)
          {
            handler.start_pair("LocalSearchQuestionsResponseWritten");
            handler.string_value(storeLocalSearchQuestionsResponseWritten);
          }
        Debug.Assert(partial_allowed || flagHasLocalResults);
        if (flagHasLocalResults)
          {
            handler.start_pair("LocalResults");
            handler.start_array();
            for (int num1 = 0; num1 < storeLocalResults.Count; ++num1)
              {
                if (partial_allowed)
                    storeLocalResults[num1].write_partial_as_json(handler);
                else
                    storeLocalResults[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasAttribution);
        if (flagHasAttribution)
          {
            handler.start_pair("Attribution");
            if (partial_allowed)
                storeAttribution.write_partial_as_json(handler);
            else
                storeAttribution.write_as_json(handler);
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
        if (!(hasLocalSearchCommandKind()))
          {
            return "When parsing the object for %what%, the \"LocalSearchCommandKind\" field was missing.";
          }
        if (!(hasResultNameSingularSpoken()))
          {
            return "When parsing the object for %what%, the \"ResultNameSingularSpoken\" field was missing.";
          }
        if (!(hasResultNamePluralSpoken()))
          {
            return "When parsing the object for %what%, the \"ResultNamePluralSpoken\" field was missing.";
          }
        if (!(hasResultNameSingularWritten()))
          {
            return "When parsing the object for %what%, the \"ResultNameSingularWritten\" field was missing.";
          }
        if (!(hasResultNamePluralWritten()))
          {
            return "When parsing the object for %what%, the \"ResultNamePluralWritten\" field was missing.";
          }
        if (!(hasLocalResults()))
          {
            return "When parsing the object for %what%, the \"LocalResults\" field was missing.";
          }
        if (!(hasAttribution()))
          {
            return "When parsing the object for %what%, the \"Attribution\" field was missing.";
          }
        return null;
      }

    public static new LocalSearchInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalSearchInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchInformationNugget", ignore_extras);
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
    public static new LocalSearchInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new LocalSearchInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalSearchInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchInformationNugget", ignore_extras);
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
    public static new LocalSearchInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new LocalSearchInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        LocalSearchInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LocalSearchInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new LocalSearchInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LocalSearchInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
    private abstract class FieldGeneratorLocalSearchCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorLocalSearchCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorLocalSearchCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToLocalSearchCommandKind(result));
              }
            protected abstract void handle_result(TypeLocalSearchCommandKind result);
          };
    private class FieldHoldingGeneratorLocalSearchCommandKind : FieldGeneratorLocalSearchCommandKind
  {
    protected override void handle_result(TypeLocalSearchCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorLocalSearchCommandKind(String what)
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
    public TypeLocalSearchCommandKind value;
  };
    private class FieldHoldingArrayGeneratorLocalSearchCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLocalSearchCommandKind
      {
        private FieldHoldingArrayGeneratorLocalSearchCommandKind top;

        protected override void handle_result(TypeLocalSearchCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLocalSearchCommandKind init_top)
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
    protected virtual void handle_result(List<TypeLocalSearchCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorLocalSearchCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLocalSearchCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLocalSearchCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLocalSearchCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLocalSearchCommandKind> value;
  };
        private FieldHoldingGeneratorLocalSearchCommandKind fieldGeneratorLocalSearchCommandKind;
        private LocalSearchFilterSpecJSON.HoldingGenerator fieldGeneratorLocalSearchCriteria;
        private LocalSearchFilterSpecJSON.HoldingGenerator fieldGeneratorLocalSearchCriteriaIncremental;
        private JSONHoldingBooleanGenerator fieldGeneratorLocationNotSupported;
        private JSONHoldingStringGenerator fieldGeneratorResultNameSingularSpoken;
        private JSONHoldingStringGenerator fieldGeneratorResultNamePluralSpoken;
        private JSONHoldingStringGenerator fieldGeneratorResultNameSingularWritten;
        private JSONHoldingStringGenerator fieldGeneratorResultNamePluralWritten;
        private JSONHoldingBooleanGenerator fieldGeneratorSimilarResultsReturned;
        private LocalSearchFilterSpecJSON.HoldingGenerator fieldGeneratorSimilarResultLocalSearchCriteria;
        private JSONHoldingBooleanGenerator fieldGeneratorMessageUserSimilarResultsReturned;
        private JSONHoldingStringGenerator fieldGeneratorSimilarResultNameSingularSpoken;
        private JSONHoldingStringGenerator fieldGeneratorSimilarResultNamePluralSpoken;
        private JSONHoldingStringGenerator fieldGeneratorSimilarResultNameSingularWritten;
        private JSONHoldingStringGenerator fieldGeneratorSimilarResultNamePluralWritten;
        private JSONHoldingStringGenerator fieldGeneratorLocalSearchQuestionsResponseSpoken;
        private JSONHoldingStringGenerator fieldGeneratorLocalSearchQuestionsResponseWritten;
        private LocalResultJSON.HoldingArrayGenerator fieldGeneratorLocalResults;
        private AttributionJSON.HoldingGenerator fieldGeneratorAttribution;
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
            if (!(getInformationNuggetJSONKey().Equals("LocalSearch")))
                throw new Exception("The key field has a value other than `LocalSearch'.");
            LocalSearchInformationNuggetJSON result = new LocalSearchInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraLocalSearchInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((LocalSearchInformationNuggetJSON )new_result);
          }
        protected void finish(LocalSearchInformationNuggetJSON result)
          {
            if (fieldGeneratorLocalSearchCommandKind.have_value)
              {
                result.setLocalSearchCommandKind();
                fieldGeneratorLocalSearchCommandKind.have_value = false;
              }
            else if ((!(result.hasLocalSearchCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LocalSearchCommandKind\" field was missing.");
              }
            if (fieldGeneratorLocalSearchCriteria.have_value)
              {
                result.setLocalSearchCriteria(fieldGeneratorLocalSearchCriteria.value);
                fieldGeneratorLocalSearchCriteria.have_value = false;
              }
            if (fieldGeneratorLocalSearchCriteriaIncremental.have_value)
              {
                result.setLocalSearchCriteriaIncremental(fieldGeneratorLocalSearchCriteriaIncremental.value);
                fieldGeneratorLocalSearchCriteriaIncremental.have_value = false;
              }
            if (fieldGeneratorLocationNotSupported.have_value)
              {
                result.setLocationNotSupported(fieldGeneratorLocationNotSupported.value);
                fieldGeneratorLocationNotSupported.have_value = false;
              }
            if (fieldGeneratorResultNameSingularSpoken.have_value)
              {
                result.setResultNameSingularSpoken(fieldGeneratorResultNameSingularSpoken.value);
                fieldGeneratorResultNameSingularSpoken.have_value = false;
              }
            else if ((!(result.hasResultNameSingularSpoken())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ResultNameSingularSpoken\" field was missing.");
              }
            if (fieldGeneratorResultNamePluralSpoken.have_value)
              {
                result.setResultNamePluralSpoken(fieldGeneratorResultNamePluralSpoken.value);
                fieldGeneratorResultNamePluralSpoken.have_value = false;
              }
            else if ((!(result.hasResultNamePluralSpoken())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ResultNamePluralSpoken\" field was missing.");
              }
            if (fieldGeneratorResultNameSingularWritten.have_value)
              {
                result.setResultNameSingularWritten(fieldGeneratorResultNameSingularWritten.value);
                fieldGeneratorResultNameSingularWritten.have_value = false;
              }
            else if ((!(result.hasResultNameSingularWritten())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ResultNameSingularWritten\" field was missing.");
              }
            if (fieldGeneratorResultNamePluralWritten.have_value)
              {
                result.setResultNamePluralWritten(fieldGeneratorResultNamePluralWritten.value);
                fieldGeneratorResultNamePluralWritten.have_value = false;
              }
            else if ((!(result.hasResultNamePluralWritten())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ResultNamePluralWritten\" field was missing.");
              }
            if (fieldGeneratorSimilarResultsReturned.have_value)
              {
                result.setSimilarResultsReturned(fieldGeneratorSimilarResultsReturned.value);
                fieldGeneratorSimilarResultsReturned.have_value = false;
              }
            if (fieldGeneratorSimilarResultLocalSearchCriteria.have_value)
              {
                result.setSimilarResultLocalSearchCriteria(fieldGeneratorSimilarResultLocalSearchCriteria.value);
                fieldGeneratorSimilarResultLocalSearchCriteria.have_value = false;
              }
            if (fieldGeneratorMessageUserSimilarResultsReturned.have_value)
              {
                result.setMessageUserSimilarResultsReturned(fieldGeneratorMessageUserSimilarResultsReturned.value);
                fieldGeneratorMessageUserSimilarResultsReturned.have_value = false;
              }
            if (fieldGeneratorSimilarResultNameSingularSpoken.have_value)
              {
                result.setSimilarResultNameSingularSpoken(fieldGeneratorSimilarResultNameSingularSpoken.value);
                fieldGeneratorSimilarResultNameSingularSpoken.have_value = false;
              }
            if (fieldGeneratorSimilarResultNamePluralSpoken.have_value)
              {
                result.setSimilarResultNamePluralSpoken(fieldGeneratorSimilarResultNamePluralSpoken.value);
                fieldGeneratorSimilarResultNamePluralSpoken.have_value = false;
              }
            if (fieldGeneratorSimilarResultNameSingularWritten.have_value)
              {
                result.setSimilarResultNameSingularWritten(fieldGeneratorSimilarResultNameSingularWritten.value);
                fieldGeneratorSimilarResultNameSingularWritten.have_value = false;
              }
            if (fieldGeneratorSimilarResultNamePluralWritten.have_value)
              {
                result.setSimilarResultNamePluralWritten(fieldGeneratorSimilarResultNamePluralWritten.value);
                fieldGeneratorSimilarResultNamePluralWritten.have_value = false;
              }
            if (fieldGeneratorLocalSearchQuestionsResponseSpoken.have_value)
              {
                result.setLocalSearchQuestionsResponseSpoken(fieldGeneratorLocalSearchQuestionsResponseSpoken.value);
                fieldGeneratorLocalSearchQuestionsResponseSpoken.have_value = false;
              }
            if (fieldGeneratorLocalSearchQuestionsResponseWritten.have_value)
              {
                result.setLocalSearchQuestionsResponseWritten(fieldGeneratorLocalSearchQuestionsResponseWritten.value);
                fieldGeneratorLocalSearchQuestionsResponseWritten.have_value = false;
              }
            if (fieldGeneratorLocalResults.have_value)
              {
                result.initLocalResults();
                int count = fieldGeneratorLocalResults.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendLocalResults(fieldGeneratorLocalResults.value[num]);
                  }
                fieldGeneratorLocalResults.value.Clear();
                fieldGeneratorLocalResults.have_value = false;
              }
            else if ((!(result.hasLocalResults())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LocalResults\" field was missing.");
              }
            if (fieldGeneratorAttribution.have_value)
              {
                result.setAttribution(fieldGeneratorAttribution.value);
                fieldGeneratorAttribution.have_value = false;
              }
            else if ((!(result.hasAttribution())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Attribution\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(LocalSearchInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorAttribution;
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "oca", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'l':
                                switch (field_name[5])
                                  {
                                    case 'R':
                                        if ((String.Compare(field_name, 6, "esults", 0, 6, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorLocalResults;
                                        break;
                                    case 'S':
                                        if (String.Compare(field_name, 6, "earch", 0, 5, false) == 0)
                                          {
                                            switch (field_name[11])
                                              {
                                                case 'C':
                                                    switch (field_name[12])
                                                      {
                                                        case 'o':
                                                            if ((String.Compare(field_name, 13, "mmandKind", 0, 9, false) == 0) && (field_name.Length == 22))
                                                                return fieldGeneratorLocalSearchCommandKind;
                                                            break;
                                                        case 'r':
                                                            if (String.Compare(field_name, 13, "iteria", 0, 6, false) == 0)
                                                              {
                                                                if (field_name.Length == 19)
                                                                  {
                                                                    return fieldGeneratorLocalSearchCriteria;
                                                                  }
                                                                switch (field_name[19])
                                                                  {
                                                                    case 'I':
                                                                        if ((String.Compare(field_name, 20, "ncremental", 0, 10, false) == 0) && (field_name.Length == 30))
                                                                            return fieldGeneratorLocalSearchCriteriaIncremental;
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
                                                case 'Q':
                                                    if (String.Compare(field_name, 12, "uestionsResponse", 0, 16, false) == 0)
                                                      {
                                                        switch (field_name[28])
                                                          {
                                                            case 'S':
                                                                if ((String.Compare(field_name, 29, "poken", 0, 5, false) == 0) && (field_name.Length == 34))
                                                                    return fieldGeneratorLocalSearchQuestionsResponseSpoken;
                                                                break;
                                                            case 'W':
                                                                if ((String.Compare(field_name, 29, "ritten", 0, 6, false) == 0) && (field_name.Length == 35))
                                                                    return fieldGeneratorLocalSearchQuestionsResponseWritten;
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
                                break;
                            case 't':
                                if ((String.Compare(field_name, 5, "ionNotSupported", 0, 15, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorLocationNotSupported;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "essageUserSimilarResultsReturned", 0, 32, false) == 0) && (field_name.Length == 33))
                        return fieldGeneratorMessageUserSimilarResultsReturned;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "esultName", 0, 9, false) == 0)
                      {
                        switch (field_name[10])
                          {
                            case 'P':
                                if (String.Compare(field_name, 11, "lural", 0, 5, false) == 0)
                                  {
                                    switch (field_name[16])
                                      {
                                        case 'S':
                                            if ((String.Compare(field_name, 17, "poken", 0, 5, false) == 0) && (field_name.Length == 22))
                                                return fieldGeneratorResultNamePluralSpoken;
                                            break;
                                        case 'W':
                                            if ((String.Compare(field_name, 17, "ritten", 0, 6, false) == 0) && (field_name.Length == 23))
                                                return fieldGeneratorResultNamePluralWritten;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'S':
                                if (String.Compare(field_name, 11, "ingular", 0, 7, false) == 0)
                                  {
                                    switch (field_name[18])
                                      {
                                        case 'S':
                                            if ((String.Compare(field_name, 19, "poken", 0, 5, false) == 0) && (field_name.Length == 24))
                                                return fieldGeneratorResultNameSingularSpoken;
                                            break;
                                        case 'W':
                                            if ((String.Compare(field_name, 19, "ritten", 0, 6, false) == 0) && (field_name.Length == 25))
                                                return fieldGeneratorResultNameSingularWritten;
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
                    if (String.Compare(field_name, 1, "imilarResult", 0, 12, false) == 0)
                      {
                        switch (field_name[13])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 14, "ocalSearchCriteria", 0, 18, false) == 0) && (field_name.Length == 32))
                                    return fieldGeneratorSimilarResultLocalSearchCriteria;
                                break;
                            case 'N':
                                if (String.Compare(field_name, 14, "ame", 0, 3, false) == 0)
                                  {
                                    switch (field_name[17])
                                      {
                                        case 'P':
                                            if (String.Compare(field_name, 18, "lural", 0, 5, false) == 0)
                                              {
                                                switch (field_name[23])
                                                  {
                                                    case 'S':
                                                        if ((String.Compare(field_name, 24, "poken", 0, 5, false) == 0) && (field_name.Length == 29))
                                                            return fieldGeneratorSimilarResultNamePluralSpoken;
                                                        break;
                                                    case 'W':
                                                        if ((String.Compare(field_name, 24, "ritten", 0, 6, false) == 0) && (field_name.Length == 30))
                                                            return fieldGeneratorSimilarResultNamePluralWritten;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'S':
                                            if (String.Compare(field_name, 18, "ingular", 0, 7, false) == 0)
                                              {
                                                switch (field_name[25])
                                                  {
                                                    case 'S':
                                                        if ((String.Compare(field_name, 26, "poken", 0, 5, false) == 0) && (field_name.Length == 31))
                                                            return fieldGeneratorSimilarResultNameSingularSpoken;
                                                        break;
                                                    case 'W':
                                                        if ((String.Compare(field_name, 26, "ritten", 0, 6, false) == 0) && (field_name.Length == 32))
                                                            return fieldGeneratorSimilarResultNameSingularWritten;
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
                            case 's':
                                if ((String.Compare(field_name, 14, "Returned", 0, 8, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorSimilarResultsReturned;
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
            fieldGeneratorLocalSearchCommandKind = new FieldHoldingGeneratorLocalSearchCommandKind("field \"LocalSearchCommandKind\" of the LocalSearchInformationNugget class");
            fieldGeneratorLocalSearchCriteria = new LocalSearchFilterSpecJSON.HoldingGenerator("field \"LocalSearchCriteria\" of the LocalSearchInformationNugget class", ignore_extras);
            fieldGeneratorLocalSearchCriteriaIncremental = new LocalSearchFilterSpecJSON.HoldingGenerator("field \"LocalSearchCriteriaIncremental\" of the LocalSearchInformationNugget class", ignore_extras);
            fieldGeneratorLocationNotSupported = new JSONHoldingBooleanGenerator("field \"LocationNotSupported\" of the LocalSearchInformationNugget class");
            fieldGeneratorResultNameSingularSpoken = new JSONHoldingStringGenerator("field \"ResultNameSingularSpoken\" of the LocalSearchInformationNugget class");
            fieldGeneratorResultNamePluralSpoken = new JSONHoldingStringGenerator("field \"ResultNamePluralSpoken\" of the LocalSearchInformationNugget class");
            fieldGeneratorResultNameSingularWritten = new JSONHoldingStringGenerator("field \"ResultNameSingularWritten\" of the LocalSearchInformationNugget class");
            fieldGeneratorResultNamePluralWritten = new JSONHoldingStringGenerator("field \"ResultNamePluralWritten\" of the LocalSearchInformationNugget class");
            fieldGeneratorSimilarResultsReturned = new JSONHoldingBooleanGenerator("field \"SimilarResultsReturned\" of the LocalSearchInformationNugget class");
            fieldGeneratorSimilarResultLocalSearchCriteria = new LocalSearchFilterSpecJSON.HoldingGenerator("field \"SimilarResultLocalSearchCriteria\" of the LocalSearchInformationNugget class", ignore_extras);
            fieldGeneratorMessageUserSimilarResultsReturned = new JSONHoldingBooleanGenerator("field \"MessageUserSimilarResultsReturned\" of the LocalSearchInformationNugget class");
            fieldGeneratorSimilarResultNameSingularSpoken = new JSONHoldingStringGenerator("field \"SimilarResultNameSingularSpoken\" of the LocalSearchInformationNugget class");
            fieldGeneratorSimilarResultNamePluralSpoken = new JSONHoldingStringGenerator("field \"SimilarResultNamePluralSpoken\" of the LocalSearchInformationNugget class");
            fieldGeneratorSimilarResultNameSingularWritten = new JSONHoldingStringGenerator("field \"SimilarResultNameSingularWritten\" of the LocalSearchInformationNugget class");
            fieldGeneratorSimilarResultNamePluralWritten = new JSONHoldingStringGenerator("field \"SimilarResultNamePluralWritten\" of the LocalSearchInformationNugget class");
            fieldGeneratorLocalSearchQuestionsResponseSpoken = new JSONHoldingStringGenerator("field \"LocalSearchQuestionsResponseSpoken\" of the LocalSearchInformationNugget class");
            fieldGeneratorLocalSearchQuestionsResponseWritten = new JSONHoldingStringGenerator("field \"LocalSearchQuestionsResponseWritten\" of the LocalSearchInformationNugget class");
            fieldGeneratorLocalResults = new LocalResultJSON.HoldingArrayGenerator("field \"LocalResults\" of the LocalSearchInformationNugget class", ignore_extras);
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the LocalSearchInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the LocalSearchInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorLocalSearchCommandKind = new FieldHoldingGeneratorLocalSearchCommandKind("field \"LocalSearchCommandKind\" of the LocalSearchInformationNugget class");
            fieldGeneratorLocalSearchCriteria = new LocalSearchFilterSpecJSON.HoldingGenerator("field \"LocalSearchCriteria\" of the LocalSearchInformationNugget class", false);
            fieldGeneratorLocalSearchCriteriaIncremental = new LocalSearchFilterSpecJSON.HoldingGenerator("field \"LocalSearchCriteriaIncremental\" of the LocalSearchInformationNugget class", false);
            fieldGeneratorLocationNotSupported = new JSONHoldingBooleanGenerator("field \"LocationNotSupported\" of the LocalSearchInformationNugget class");
            fieldGeneratorResultNameSingularSpoken = new JSONHoldingStringGenerator("field \"ResultNameSingularSpoken\" of the LocalSearchInformationNugget class");
            fieldGeneratorResultNamePluralSpoken = new JSONHoldingStringGenerator("field \"ResultNamePluralSpoken\" of the LocalSearchInformationNugget class");
            fieldGeneratorResultNameSingularWritten = new JSONHoldingStringGenerator("field \"ResultNameSingularWritten\" of the LocalSearchInformationNugget class");
            fieldGeneratorResultNamePluralWritten = new JSONHoldingStringGenerator("field \"ResultNamePluralWritten\" of the LocalSearchInformationNugget class");
            fieldGeneratorSimilarResultsReturned = new JSONHoldingBooleanGenerator("field \"SimilarResultsReturned\" of the LocalSearchInformationNugget class");
            fieldGeneratorSimilarResultLocalSearchCriteria = new LocalSearchFilterSpecJSON.HoldingGenerator("field \"SimilarResultLocalSearchCriteria\" of the LocalSearchInformationNugget class", false);
            fieldGeneratorMessageUserSimilarResultsReturned = new JSONHoldingBooleanGenerator("field \"MessageUserSimilarResultsReturned\" of the LocalSearchInformationNugget class");
            fieldGeneratorSimilarResultNameSingularSpoken = new JSONHoldingStringGenerator("field \"SimilarResultNameSingularSpoken\" of the LocalSearchInformationNugget class");
            fieldGeneratorSimilarResultNamePluralSpoken = new JSONHoldingStringGenerator("field \"SimilarResultNamePluralSpoken\" of the LocalSearchInformationNugget class");
            fieldGeneratorSimilarResultNameSingularWritten = new JSONHoldingStringGenerator("field \"SimilarResultNameSingularWritten\" of the LocalSearchInformationNugget class");
            fieldGeneratorSimilarResultNamePluralWritten = new JSONHoldingStringGenerator("field \"SimilarResultNamePluralWritten\" of the LocalSearchInformationNugget class");
            fieldGeneratorLocalSearchQuestionsResponseSpoken = new JSONHoldingStringGenerator("field \"LocalSearchQuestionsResponseSpoken\" of the LocalSearchInformationNugget class");
            fieldGeneratorLocalSearchQuestionsResponseWritten = new JSONHoldingStringGenerator("field \"LocalSearchQuestionsResponseWritten\" of the LocalSearchInformationNugget class");
            fieldGeneratorLocalResults = new LocalResultJSON.HoldingArrayGenerator("field \"LocalResults\" of the LocalSearchInformationNugget class", false);
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the LocalSearchInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the LocalSearchInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorLocalSearchCommandKind.reset();
            fieldGeneratorLocalSearchCriteria.reset();
            fieldGeneratorLocalSearchCriteriaIncremental.reset();
            fieldGeneratorLocationNotSupported.reset();
            fieldGeneratorResultNameSingularSpoken.reset();
            fieldGeneratorResultNamePluralSpoken.reset();
            fieldGeneratorResultNameSingularWritten.reset();
            fieldGeneratorResultNamePluralWritten.reset();
            fieldGeneratorSimilarResultsReturned.reset();
            fieldGeneratorSimilarResultLocalSearchCriteria.reset();
            fieldGeneratorMessageUserSimilarResultsReturned.reset();
            fieldGeneratorSimilarResultNameSingularSpoken.reset();
            fieldGeneratorSimilarResultNamePluralSpoken.reset();
            fieldGeneratorSimilarResultNameSingularWritten.reset();
            fieldGeneratorSimilarResultNamePluralWritten.reset();
            fieldGeneratorLocalSearchQuestionsResponseSpoken.reset();
            fieldGeneratorLocalSearchQuestionsResponseWritten.reset();
            fieldGeneratorLocalResults.reset();
            fieldGeneratorAttribution.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(LocalSearchInformationNuggetJSON  result)
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
        public LocalSearchInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LocalSearchInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<LocalSearchInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LocalSearchInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LocalSearchInformationNuggetJSON>();
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
    public List<LocalSearchInformationNuggetJSON> value;
  };
  };
