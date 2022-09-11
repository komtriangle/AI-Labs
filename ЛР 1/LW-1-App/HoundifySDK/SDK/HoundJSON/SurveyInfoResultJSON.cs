/* file "SurveyInfoResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SurveyInfoResultJSON : SurveyResultJSON
  {
    private bool flagHasSurveyMedia;
    private SurveyMediaJSON  storeSurveyMedia;
    private bool flagHasSurveyDescription;
    private string storeSurveyDescription;
    private bool flagHasSurveyProvider;
    private string storeSurveyProvider;
    private bool flagHasSurveyMetaInformation;
    private SurveyMetaInfoJSON  storeSurveyMetaInformation;
    private bool flagHasSurveyQuestions;
    private List< SurveyQuestionJSON  > storeSurveyQuestions;
    private bool flagHasRemainingQuestions;
    private List< BigInteger > storeRemainingQuestions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSurveyMediaToJSON()
      {
        JSONValueHandler handler_SurveyMedia = new JSONValueHandler();
        storeSurveyMedia.write_as_json(handler_SurveyMedia);
        return handler_SurveyMedia.result;
      }

    private JSONValue  extraSurveyDescriptionToJSON()
      {
        JSONStringValue generated_string_SurveyDescription = new JSONStringValue(storeSurveyDescription);
        return generated_string_SurveyDescription;
      }

    private JSONValue  extraSurveyProviderToJSON()
      {
        JSONStringValue generated_string_SurveyProvider = new JSONStringValue(storeSurveyProvider);
        return generated_string_SurveyProvider;
      }

    private JSONValue  extraSurveyMetaInformationToJSON()
      {
        JSONValueHandler handler_SurveyMetaInformation = new JSONValueHandler();
        storeSurveyMetaInformation.write_as_json(handler_SurveyMetaInformation);
        return handler_SurveyMetaInformation.result;
      }

    private JSONValue  extraSurveyQuestionsToJSON()
      {
        JSONArrayValue generated_array_1_SurveyQuestions = new JSONArrayValue();
        for (int num1 = 0; num1 < storeSurveyQuestions.Count; ++num1)
          {
            JSONValueHandler handler_SurveyQuestions = new JSONValueHandler();
            storeSurveyQuestions[num1].write_as_json(handler_SurveyQuestions);
            generated_array_1_SurveyQuestions.appendComponent(handler_SurveyQuestions.result);
          }
        return generated_array_1_SurveyQuestions;
      }

    private JSONValue  extraRemainingQuestionsToJSON()
      {
        JSONArrayValue generated_array_2_RemainingQuestions = new JSONArrayValue();
        for (int num2 = 0; num2 < storeRemainingQuestions.Count; ++num2)
          {
            JSONIntegerValue generated_integer_RemainingQuestions = new JSONIntegerValue(storeRemainingQuestions[num2]);
            generated_array_2_RemainingQuestions.appendComponent(generated_integer_RemainingQuestions);
          }
        return generated_array_2_RemainingQuestions;
      }


    private void  fromJSONSurveyMedia(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SurveyMediaJSON convert_classy = SurveyMediaJSON.from_json(json_value, ignore_extras, true);
        setSurveyMedia(convert_classy);
      }


    private void  fromJSONSurveyDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SurveyDescription of SurveyInfoResultJSON is not a string.");
        setSurveyDescription(json_string.getData());
      }


    private void  fromJSONSurveyProvider(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SurveyProvider of SurveyInfoResultJSON is not a string.");
        setSurveyProvider(json_string.getData());
      }


    private void  fromJSONSurveyMetaInformation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SurveyMetaInfoJSON convert_classy = SurveyMetaInfoJSON.from_json(json_value, ignore_extras, true);
        setSurveyMetaInformation(convert_classy);
      }


    private void  fromJSONSurveyQuestions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SurveyQuestions of SurveyInfoResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SurveyQuestionJSON  > vector_SurveyQuestions1 = new List< SurveyQuestionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SurveyQuestionJSON convert_classy = SurveyQuestionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_SurveyQuestions1.Add(convert_classy);
          }
        initSurveyQuestions();
        for (int num1 = 0; num1 < vector_SurveyQuestions1.Count; ++num1)
            appendSurveyQuestions(vector_SurveyQuestions1[num1]);
        for (int num1 = 0; num1 < vector_SurveyQuestions1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRemainingQuestions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RemainingQuestions of SurveyInfoResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_RemainingQuestions1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field RemainingQuestions of SurveyInfoResultJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field RemainingQuestions of SurveyInfoResultJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_RemainingQuestions1.Add(extracted_integer);
          }
        initRemainingQuestions();
        for (int num2 = 0; num2 < vector_RemainingQuestions1.Count; ++num2)
            appendRemainingQuestions(vector_RemainingQuestions1[num2]);
        for (int num1 = 0; num1 < vector_RemainingQuestions1.Count; ++num1)
          {
          }
      }


    public SurveyInfoResultJSON()
      {
        flagHasSurveyMedia = false;
        flagHasSurveyDescription = false;
        flagHasSurveyProvider = false;
        flagHasSurveyMetaInformation = false;
        flagHasSurveyQuestions = false;
        flagHasRemainingQuestions = false;
        storeSurveyQuestions = new List< SurveyQuestionJSON  >();
        storeRemainingQuestions = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSurveyResultType()
      {
        return "SurveyInfoResult";
      }

    public bool  hasSurveyMedia()
      {
        return flagHasSurveyMedia;
      }

    public SurveyMediaJSON   getSurveyMedia()
      {
        Debug.Assert(flagHasSurveyMedia);
        return storeSurveyMedia;
      }

    public bool  hasSurveyDescription()
      {
        return flagHasSurveyDescription;
      }

    public string  getSurveyDescription()
      {
        Debug.Assert(flagHasSurveyDescription);
        return storeSurveyDescription;
      }

    public bool  hasSurveyProvider()
      {
        return flagHasSurveyProvider;
      }

    public string  getSurveyProvider()
      {
        Debug.Assert(flagHasSurveyProvider);
        return storeSurveyProvider;
      }

    public bool  hasSurveyMetaInformation()
      {
        return flagHasSurveyMetaInformation;
      }

    public SurveyMetaInfoJSON   getSurveyMetaInformation()
      {
        Debug.Assert(flagHasSurveyMetaInformation);
        return storeSurveyMetaInformation;
      }

    public bool  hasSurveyQuestions()
      {
        return flagHasSurveyQuestions;
      }

    public int  countOfSurveyQuestions()
      {
        Debug.Assert(flagHasSurveyQuestions);
        return storeSurveyQuestions.Count;
      }

    public SurveyQuestionJSON   elementOfSurveyQuestions(int element_num)
      {
        Debug.Assert(flagHasSurveyQuestions);
        return storeSurveyQuestions[element_num];
      }

    public List< SurveyQuestionJSON  >  getSurveyQuestions()
      {
        Debug.Assert(flagHasSurveyQuestions);
        return storeSurveyQuestions;
      }

    public bool  hasRemainingQuestions()
      {
        return flagHasRemainingQuestions;
      }

    public int  countOfRemainingQuestions()
      {
        Debug.Assert(flagHasRemainingQuestions);
        return storeRemainingQuestions.Count;
      }

    public BigInteger  elementOfRemainingQuestions(int element_num)
      {
        Debug.Assert(flagHasRemainingQuestions);
        return storeRemainingQuestions[element_num];
      }

    public List< BigInteger >  getRemainingQuestions()
      {
        Debug.Assert(flagHasRemainingQuestions);
        return storeRemainingQuestions;
      }


    public virtual int extraSurveyInfoResultComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSurveyInfoResultComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSurveyInfoResultComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSurveyInfoResultLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSurveyResultComponentCount()
      {
        int result = 0;
        if (flagHasSurveyMedia)
            ++result;
        if (flagHasSurveyDescription)
            ++result;
        if (flagHasSurveyProvider)
            ++result;
        if (flagHasSurveyMetaInformation)
            ++result;
        if (flagHasSurveyQuestions)
            ++result;
        if (flagHasRemainingQuestions)
            ++result;
        result += extraSurveyInfoResultComponentCount();
        return result;
      }
    public override string extraSurveyResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSurveyMedia)
          {
            if (remainder == 0)
                return "SurveyMedia";
            --remainder;
          }
        if (flagHasSurveyDescription)
          {
            if (remainder == 0)
                return "SurveyDescription";
            --remainder;
          }
        if (flagHasSurveyProvider)
          {
            if (remainder == 0)
                return "SurveyProvider";
            --remainder;
          }
        if (flagHasSurveyMetaInformation)
          {
            if (remainder == 0)
                return "SurveyMetaInformation";
            --remainder;
          }
        if (flagHasSurveyQuestions)
          {
            if (remainder == 0)
                return "SurveyQuestions";
            --remainder;
          }
        if (flagHasRemainingQuestions)
          {
            if (remainder == 0)
                return "RemainingQuestions";
            --remainder;
          }
        return extraSurveyInfoResultComponentKey(remainder);
      }
    public override JSONValue extraSurveyResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSurveyMedia)
          {
            if (remainder == 0)
                return extraSurveyMediaToJSON();
            --remainder;
          }
        if (flagHasSurveyDescription)
          {
            if (remainder == 0)
                return extraSurveyDescriptionToJSON();
            --remainder;
          }
        if (flagHasSurveyProvider)
          {
            if (remainder == 0)
                return extraSurveyProviderToJSON();
            --remainder;
          }
        if (flagHasSurveyMetaInformation)
          {
            if (remainder == 0)
                return extraSurveyMetaInformationToJSON();
            --remainder;
          }
        if (flagHasSurveyQuestions)
          {
            if (remainder == 0)
                return extraSurveyQuestionsToJSON();
            --remainder;
          }
        if (flagHasRemainingQuestions)
          {
            if (remainder == 0)
                return extraRemainingQuestionsToJSON();
            --remainder;
          }
        return extraSurveyInfoResultComponentValue(remainder);
      }
    public override JSONValue extraSurveyResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'R':
                if ((String.Compare(field_name, 1, "emainingQuestions", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasRemainingQuestions ? extraRemainingQuestionsToJSON() : null);
                break;
            case 'S':
                if (String.Compare(field_name, 1, "urvey", 0, 5, false) == 0)
                  {
                    switch (field_name[6])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 7, "escription", 0, 10, false) == 0) && (field_name.Length == 17))
                                return (flagHasSurveyDescription ? extraSurveyDescriptionToJSON() : null);
                            break;
                        case 'M':
                            if (String.Compare(field_name, 7, "e", 0, 1, false) == 0)
                              {
                                switch (field_name[8])
                                  {
                                    case 'd':
                                        if ((String.Compare(field_name, 9, "ia", 0, 2, false) == 0) && (field_name.Length == 11))
                                            return (flagHasSurveyMedia ? extraSurveyMediaToJSON() : null);
                                        break;
                                    case 't':
                                        if ((String.Compare(field_name, 9, "aInformation", 0, 12, false) == 0) && (field_name.Length == 21))
                                            return (flagHasSurveyMetaInformation ? extraSurveyMetaInformationToJSON() : null);
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'P':
                            if ((String.Compare(field_name, 7, "rovider", 0, 7, false) == 0) && (field_name.Length == 14))
                                return (flagHasSurveyProvider ? extraSurveyProviderToJSON() : null);
                            break;
                        case 'Q':
                            if ((String.Compare(field_name, 7, "uestions", 0, 8, false) == 0) && (field_name.Length == 15))
                                return (flagHasSurveyQuestions ? extraSurveyQuestionsToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraSurveyInfoResultLookup(field_name);
      }

    public void setSurveyMedia(SurveyMediaJSON  new_value)
      {
        if (flagHasSurveyMedia)
          {
          }
        flagHasSurveyMedia = true;
        storeSurveyMedia = new_value;
      }
    public void unsetSurveyMedia()
      {
        if (flagHasSurveyMedia)
          {
          }
        flagHasSurveyMedia = false;
      }
    public void setSurveyDescription(string new_value)
      {
        flagHasSurveyDescription = true;
        storeSurveyDescription = new_value;
      }
    public void unsetSurveyDescription()
      {
        flagHasSurveyDescription = false;
      }
    public void setSurveyProvider(string new_value)
      {
        flagHasSurveyProvider = true;
        storeSurveyProvider = new_value;
      }
    public void unsetSurveyProvider()
      {
        flagHasSurveyProvider = false;
      }
    public void setSurveyMetaInformation(SurveyMetaInfoJSON  new_value)
      {
        if (flagHasSurveyMetaInformation)
          {
          }
        flagHasSurveyMetaInformation = true;
        storeSurveyMetaInformation = new_value;
      }
    public void unsetSurveyMetaInformation()
      {
        if (flagHasSurveyMetaInformation)
          {
          }
        flagHasSurveyMetaInformation = false;
      }
    public void initSurveyQuestions()
      {
        if (flagHasSurveyQuestions)
          {
            for (int num1 = 0; num1 < storeSurveyQuestions.Count; ++num1)
              {
              }
          }
        flagHasSurveyQuestions = true;
        storeSurveyQuestions.Clear();
      }
    public void appendSurveyQuestions(SurveyQuestionJSON  to_append)
      {
        if (!flagHasSurveyQuestions)
          {
            flagHasSurveyQuestions = true;
            storeSurveyQuestions.Clear();
          }
        Debug.Assert(flagHasSurveyQuestions);
        storeSurveyQuestions.Add(to_append);
      }
    public void unsetSurveyQuestions()
      {
        if (flagHasSurveyQuestions)
          {
            for (int num2 = 0; num2 < storeSurveyQuestions.Count; ++num2)
              {
              }
          }
        flagHasSurveyQuestions = false;
        storeSurveyQuestions.Clear();
      }
    public void initRemainingQuestions()
      {
        flagHasRemainingQuestions = true;
        storeRemainingQuestions.Clear();
      }
    public void appendRemainingQuestions(BigInteger to_append)
      {
        if (!flagHasRemainingQuestions)
          {
            flagHasRemainingQuestions = true;
            storeRemainingQuestions.Clear();
          }
        Debug.Assert(flagHasRemainingQuestions);
        storeRemainingQuestions.Add(to_append);
      }
    public void unsetRemainingQuestions()
      {
        flagHasRemainingQuestions = false;
        storeRemainingQuestions.Clear();
      }

    public virtual void extraSurveyInfoResultAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSurveyInfoResultSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSurveyInfoResultLookup(key);
        if (old_field == null)
          {
            extraSurveyInfoResultAppendPair(key, new_component);
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
    public override void extraSurveyResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'R':
                if ((String.Compare(key, 1, "emainingQuestions", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONRemainingQuestions(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if (String.Compare(key, 1, "urvey", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'D':
                            if ((String.Compare(key, 7, "escription", 0, 10, false) == 0) && (key.Length == 17))
                                {
                                fromJSONSurveyDescription(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if (String.Compare(key, 7, "e", 0, 1, false) == 0)
                              {
                                switch (key[8])
                                  {
                                    case 'd':
                                        if ((String.Compare(key, 9, "ia", 0, 2, false) == 0) && (key.Length == 11))
                                            {
                                            fromJSONSurveyMedia(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 't':
                                        if ((String.Compare(key, 9, "aInformation", 0, 12, false) == 0) && (key.Length == 21))
                                            {
                                            fromJSONSurveyMetaInformation(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'P':
                            if ((String.Compare(key, 7, "rovider", 0, 7, false) == 0) && (key.Length == 14))
                                {
                                fromJSONSurveyProvider(new_component, false);
                                return;
                                }
                            break;
                        case 'Q':
                            if ((String.Compare(key, 7, "uestions", 0, 8, false) == 0) && (key.Length == 15))
                                {
                                fromJSONSurveyQuestions(new_component, false);
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
        extraSurveyInfoResultAppendPair(key, new_component);
      }
    public override void extraSurveyResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'R':
                if ((String.Compare(key, 1, "emainingQuestions", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONRemainingQuestions(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if (String.Compare(key, 1, "urvey", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'D':
                            if ((String.Compare(key, 7, "escription", 0, 10, false) == 0) && (key.Length == 17))
                                {
                                fromJSONSurveyDescription(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if (String.Compare(key, 7, "e", 0, 1, false) == 0)
                              {
                                switch (key[8])
                                  {
                                    case 'd':
                                        if ((String.Compare(key, 9, "ia", 0, 2, false) == 0) && (key.Length == 11))
                                            {
                                            fromJSONSurveyMedia(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 't':
                                        if ((String.Compare(key, 9, "aInformation", 0, 12, false) == 0) && (key.Length == 21))
                                            {
                                            fromJSONSurveyMetaInformation(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'P':
                            if ((String.Compare(key, 7, "rovider", 0, 7, false) == 0) && (key.Length == 14))
                                {
                                fromJSONSurveyProvider(new_component, false);
                                return;
                                }
                            break;
                        case 'Q':
                            if ((String.Compare(key, 7, "uestions", 0, 8, false) == 0) && (key.Length == 15))
                                {
                                fromJSONSurveyQuestions(new_component, false);
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
        extraSurveyInfoResultSetField(key, new_component);
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
        if (flagHasSurveyMedia)
          {
            handler.start_pair("SurveyMedia");
            if (partial_allowed)
                storeSurveyMedia.write_partial_as_json(handler);
            else
                storeSurveyMedia.write_as_json(handler);
          }
        if (flagHasSurveyDescription)
          {
            handler.start_pair("SurveyDescription");
            handler.string_value(storeSurveyDescription);
          }
        if (flagHasSurveyProvider)
          {
            handler.start_pair("SurveyProvider");
            handler.string_value(storeSurveyProvider);
          }
        if (flagHasSurveyMetaInformation)
          {
            handler.start_pair("SurveyMetaInformation");
            if (partial_allowed)
                storeSurveyMetaInformation.write_partial_as_json(handler);
            else
                storeSurveyMetaInformation.write_as_json(handler);
          }
        if (flagHasSurveyQuestions)
          {
            handler.start_pair("SurveyQuestions");
            handler.start_array();
            for (int num1 = 0; num1 < storeSurveyQuestions.Count; ++num1)
              {
                if (partial_allowed)
                    storeSurveyQuestions[num1].write_partial_as_json(handler);
                else
                    storeSurveyQuestions[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRemainingQuestions)
          {
            handler.start_pair("RemainingQuestions");
            handler.start_array();
            for (int num2 = 0; num2 < storeRemainingQuestions.Count; ++num2)
              {
                handler.number_value(storeRemainingQuestions[num2]);
              }
            handler.finish_array();
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

    public static new SurveyInfoResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyInfoResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyInfoResult", ignore_extras);
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
    public static new SurveyInfoResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SurveyInfoResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyInfoResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyInfoResult", ignore_extras);
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
    public static new SurveyInfoResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SurveyInfoResultJSON from_text(string text, bool ignore_extras)
      {
        SurveyInfoResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyInfoResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SurveyInfoResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SurveyInfoResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SurveyInfoResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyInfoResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SurveyResultJSON.Generator
      {
        private SurveyMediaJSON.HoldingGenerator fieldGeneratorSurveyMedia;
        private JSONHoldingStringGenerator fieldGeneratorSurveyDescription;
        private JSONHoldingStringGenerator fieldGeneratorSurveyProvider;
        private SurveyMetaInfoJSON.HoldingGenerator fieldGeneratorSurveyMetaInformation;
        private SurveyQuestionJSON.HoldingArrayGenerator fieldGeneratorSurveyQuestions;
    private class FieldHoldingGeneratorRemainingQuestions : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRemainingQuestions(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRemainingQuestions : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRemainingQuestions(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorRemainingQuestions fieldGeneratorRemainingQuestions;
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
            if (!(getSurveyResultJSONKey().Equals("SurveyInfoResult")))
                throw new Exception("The key field has a value other than `SurveyInfoResult'.");
            SurveyInfoResultJSON result = new SurveyInfoResultJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSurveyInfoResultAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SurveyResultJSON new_result)
          {
            handle_result((SurveyInfoResultJSON )new_result);
          }
        protected void finish(SurveyInfoResultJSON result)
          {
            if (fieldGeneratorSurveyMedia.have_value)
              {
                result.setSurveyMedia(fieldGeneratorSurveyMedia.value);
                fieldGeneratorSurveyMedia.have_value = false;
              }
            if (fieldGeneratorSurveyDescription.have_value)
              {
                result.setSurveyDescription(fieldGeneratorSurveyDescription.value);
                fieldGeneratorSurveyDescription.have_value = false;
              }
            if (fieldGeneratorSurveyProvider.have_value)
              {
                result.setSurveyProvider(fieldGeneratorSurveyProvider.value);
                fieldGeneratorSurveyProvider.have_value = false;
              }
            if (fieldGeneratorSurveyMetaInformation.have_value)
              {
                result.setSurveyMetaInformation(fieldGeneratorSurveyMetaInformation.value);
                fieldGeneratorSurveyMetaInformation.have_value = false;
              }
            if (fieldGeneratorSurveyQuestions.have_value)
              {
                result.initSurveyQuestions();
                int count = fieldGeneratorSurveyQuestions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSurveyQuestions(fieldGeneratorSurveyQuestions.value[num]);
                  }
                fieldGeneratorSurveyQuestions.value.Clear();
                fieldGeneratorSurveyQuestions.have_value = false;
              }
            if (fieldGeneratorRemainingQuestions.have_value)
              {
                result.initRemainingQuestions();
                int count = fieldGeneratorRemainingQuestions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRemainingQuestions(fieldGeneratorRemainingQuestions.value[num]);
                  }
                fieldGeneratorRemainingQuestions.value.Clear();
                fieldGeneratorRemainingQuestions.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SurveyInfoResultJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'R':
                    if ((String.Compare(field_name, 1, "emainingQuestions", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorRemainingQuestions;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "urvey", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 7, "escription", 0, 10, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorSurveyDescription;
                                break;
                            case 'M':
                                if (String.Compare(field_name, 7, "e", 0, 1, false) == 0)
                                  {
                                    switch (field_name[8])
                                      {
                                        case 'd':
                                            if ((String.Compare(field_name, 9, "ia", 0, 2, false) == 0) && (field_name.Length == 11))
                                                return fieldGeneratorSurveyMedia;
                                            break;
                                        case 't':
                                            if ((String.Compare(field_name, 9, "aInformation", 0, 12, false) == 0) && (field_name.Length == 21))
                                                return fieldGeneratorSurveyMetaInformation;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 7, "rovider", 0, 7, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorSurveyProvider;
                                break;
                            case 'Q':
                                if ((String.Compare(field_name, 7, "uestions", 0, 8, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorSurveyQuestions;
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
            fieldGeneratorSurveyMedia = new SurveyMediaJSON.HoldingGenerator("field \"SurveyMedia\" of the SurveyInfoResult class", ignore_extras);
            fieldGeneratorSurveyDescription = new JSONHoldingStringGenerator("field \"SurveyDescription\" of the SurveyInfoResult class");
            fieldGeneratorSurveyProvider = new JSONHoldingStringGenerator("field \"SurveyProvider\" of the SurveyInfoResult class");
            fieldGeneratorSurveyMetaInformation = new SurveyMetaInfoJSON.HoldingGenerator("field \"SurveyMetaInformation\" of the SurveyInfoResult class", ignore_extras);
            fieldGeneratorSurveyQuestions = new SurveyQuestionJSON.HoldingArrayGenerator("field \"SurveyQuestions\" of the SurveyInfoResult class", ignore_extras);
            fieldGeneratorRemainingQuestions = new FieldHoldingArrayGeneratorRemainingQuestions("field \"RemainingQuestions\" of the SurveyInfoResult class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SurveyInfoResult class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSurveyMedia = new SurveyMediaJSON.HoldingGenerator("field \"SurveyMedia\" of the SurveyInfoResult class", false);
            fieldGeneratorSurveyDescription = new JSONHoldingStringGenerator("field \"SurveyDescription\" of the SurveyInfoResult class");
            fieldGeneratorSurveyProvider = new JSONHoldingStringGenerator("field \"SurveyProvider\" of the SurveyInfoResult class");
            fieldGeneratorSurveyMetaInformation = new SurveyMetaInfoJSON.HoldingGenerator("field \"SurveyMetaInformation\" of the SurveyInfoResult class", false);
            fieldGeneratorSurveyQuestions = new SurveyQuestionJSON.HoldingArrayGenerator("field \"SurveyQuestions\" of the SurveyInfoResult class", false);
            fieldGeneratorRemainingQuestions = new FieldHoldingArrayGeneratorRemainingQuestions("field \"RemainingQuestions\" of the SurveyInfoResult class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SurveyInfoResult class");
          }

        public override void reset()
          {
            fieldGeneratorSurveyMedia.reset();
            fieldGeneratorSurveyDescription.reset();
            fieldGeneratorSurveyProvider.reset();
            fieldGeneratorSurveyMetaInformation.reset();
            fieldGeneratorSurveyQuestions.reset();
            fieldGeneratorRemainingQuestions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SurveyInfoResultJSON  result)
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
        public SurveyInfoResultJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SurveyInfoResultJSON  result)
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
    protected virtual void handle_result(List<SurveyInfoResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SurveyInfoResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SurveyInfoResultJSON>();
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
    public List<SurveyInfoResultJSON> value;
  };
  };
