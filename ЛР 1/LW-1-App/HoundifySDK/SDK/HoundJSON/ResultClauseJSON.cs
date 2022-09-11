/* file "ResultClauseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class ResultClauseJSON : JSONBase
  {
    private bool flagHasSpokenResponse;
    private string storeSpokenResponse;
    private bool flagHasSpokenResponseLong;
    private string storeSpokenResponseLong;
    private bool flagHasWrittenResponse;
    private string storeWrittenResponse;
    private bool flagHasWrittenResponseLong;
    private string storeWrittenResponseLong;
    private bool flagHasSpokenResponseSSML;
    private string storeSpokenResponseSSML;
    private bool flagHasSpokenResponseSSMLLong;
    private string storeSpokenResponseSSMLLong;
    private bool flagHasTemplateData;
    private TemplateJSON  storeTemplateData;
    private bool flagHasPreview;
    private PreviewJSON  storePreview;
    private bool flagHasSmallScreenHTML;
    private string storeSmallScreenHTML;
    private bool flagHasLargeScreenHTML;
    private string storeLargeScreenHTML;
    private bool flagHasHints;
    private HintsJSON  storeHints;
    private bool flagHasEmotion;
    private EmotionJSON  storeEmotion;
    private bool flagHasIcon;
    private IconJSON  storeIcon;
    private bool flagHasResponseAudioBytes;
    private string storeResponseAudioBytes;
    private bool flagHasResponseAudioError;
    private string storeResponseAudioError;
    private bool flagHasRequiredFeatures;
    private List< string > storeRequiredFeatures;
    private bool flagHasClientActionSucceededResult;
    private DynamicResponseJSON  storeClientActionSucceededResult;
    private bool flagHasClientActionFailedResult;
    private DynamicResponseJSON  storeClientActionFailedResult;
    private bool flagHasRequiredFeaturesSupportedResult;
    private DynamicResponseJSON  storeRequiredFeaturesSupportedResult;
    private bool flagHasErrorData;
    private CommandErrorJSON  storeErrorData;


    private void  fromJSONSpokenResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponse of ResultClauseJSON is not a string.");
        setSpokenResponse(json_string.getData());
      }


    private void  fromJSONSpokenResponseLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseLong of ResultClauseJSON is not a string.");
        setSpokenResponseLong(json_string.getData());
      }


    private void  fromJSONWrittenResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenResponse of ResultClauseJSON is not a string.");
        setWrittenResponse(json_string.getData());
      }


    private void  fromJSONWrittenResponseLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenResponseLong of ResultClauseJSON is not a string.");
        setWrittenResponseLong(json_string.getData());
      }


    private void  fromJSONSpokenResponseSSML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseSSML of ResultClauseJSON is not a string.");
        setSpokenResponseSSML(json_string.getData());
      }


    private void  fromJSONSpokenResponseSSMLLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseSSMLLong of ResultClauseJSON is not a string.");
        setSpokenResponseSSMLLong(json_string.getData());
      }


    private void  fromJSONTemplateData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TemplateJSON convert_classy = TemplateJSON.from_json(json_value, ignore_extras, true);
        setTemplateData(convert_classy);
      }


    private void  fromJSONPreview(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PreviewJSON convert_classy = PreviewJSON.from_json(json_value, ignore_extras, true);
        setPreview(convert_classy);
      }


    private void  fromJSONSmallScreenHTML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SmallScreenHTML of ResultClauseJSON is not a string.");
        setSmallScreenHTML(json_string.getData());
      }


    private void  fromJSONLargeScreenHTML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LargeScreenHTML of ResultClauseJSON is not a string.");
        setLargeScreenHTML(json_string.getData());
      }


    private void  fromJSONHints(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HintsJSON convert_classy = HintsJSON.from_json(json_value, ignore_extras, true);
        setHints(convert_classy);
      }


    private void  fromJSONEmotion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EmotionJSON convert_classy = EmotionJSON.from_json(json_value, ignore_extras, true);
        setEmotion(convert_classy);
      }


    private void  fromJSONIcon(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IconJSON convert_classy = IconJSON.from_json(json_value, ignore_extras, true);
        setIcon(convert_classy);
      }


    private void  fromJSONResponseAudioBytes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResponseAudioBytes of ResultClauseJSON is not a string.");
        setResponseAudioBytes(json_string.getData());
      }


    private void  fromJSONResponseAudioError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResponseAudioError of ResultClauseJSON is not a string.");
        setResponseAudioError(json_string.getData());
      }


    private void  fromJSONRequiredFeatures(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RequiredFeatures of ResultClauseJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field RequiredFeatures of ResultClauseJSON has too few elements.");
        List< string > vector_RequiredFeatures1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field RequiredFeatures of ResultClauseJSON is not a string.");
            vector_RequiredFeatures1.Add(json_string.getData());
          }
        Debug.Assert(vector_RequiredFeatures1.Count >= 1);
        initRequiredFeatures();
        for (int num1 = 0; num1 < vector_RequiredFeatures1.Count; ++num1)
            appendRequiredFeatures(vector_RequiredFeatures1[num1]);
        for (int num1 = 0; num1 < vector_RequiredFeatures1.Count; ++num1)
          {
          }
      }


    private void  fromJSONClientActionSucceededResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setClientActionSucceededResult(convert_classy);
      }


    private void  fromJSONClientActionFailedResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setClientActionFailedResult(convert_classy);
      }


    private void  fromJSONRequiredFeaturesSupportedResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setRequiredFeaturesSupportedResult(convert_classy);
      }


    private void  fromJSONErrorData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CommandErrorJSON convert_classy = CommandErrorJSON.from_json(json_value, ignore_extras, true);
        setErrorData(convert_classy);
      }


    public ResultClauseJSON()
      {
        flagHasSpokenResponse = false;
        flagHasSpokenResponseLong = false;
        flagHasWrittenResponse = false;
        flagHasWrittenResponseLong = false;
        flagHasSpokenResponseSSML = false;
        flagHasSpokenResponseSSMLLong = false;
        flagHasTemplateData = false;
        flagHasPreview = false;
        flagHasSmallScreenHTML = false;
        flagHasLargeScreenHTML = false;
        flagHasHints = false;
        flagHasEmotion = false;
        flagHasIcon = false;
        flagHasResponseAudioBytes = false;
        flagHasResponseAudioError = false;
        flagHasRequiredFeatures = false;
        flagHasClientActionSucceededResult = false;
        flagHasClientActionFailedResult = false;
        flagHasRequiredFeaturesSupportedResult = false;
        flagHasErrorData = false;
        storeRequiredFeatures = new List< string >();
      }

    public abstract string getClauseKind();
    public bool  hasSpokenResponse()
      {
        return flagHasSpokenResponse;
      }

    public string  getSpokenResponse()
      {
        Debug.Assert(flagHasSpokenResponse);
        return storeSpokenResponse;
      }

    public bool  hasSpokenResponseLong()
      {
        return flagHasSpokenResponseLong;
      }

    public string  getSpokenResponseLong()
      {
        Debug.Assert(flagHasSpokenResponseLong);
        return storeSpokenResponseLong;
      }

    public bool  hasWrittenResponse()
      {
        return flagHasWrittenResponse;
      }

    public string  getWrittenResponse()
      {
        Debug.Assert(flagHasWrittenResponse);
        return storeWrittenResponse;
      }

    public bool  hasWrittenResponseLong()
      {
        return flagHasWrittenResponseLong;
      }

    public string  getWrittenResponseLong()
      {
        Debug.Assert(flagHasWrittenResponseLong);
        return storeWrittenResponseLong;
      }

    public bool  hasSpokenResponseSSML()
      {
        return flagHasSpokenResponseSSML;
      }

    public string  getSpokenResponseSSML()
      {
        Debug.Assert(flagHasSpokenResponseSSML);
        return storeSpokenResponseSSML;
      }

    public bool  hasSpokenResponseSSMLLong()
      {
        return flagHasSpokenResponseSSMLLong;
      }

    public string  getSpokenResponseSSMLLong()
      {
        Debug.Assert(flagHasSpokenResponseSSMLLong);
        return storeSpokenResponseSSMLLong;
      }

    public bool  hasTemplateData()
      {
        return flagHasTemplateData;
      }

    public TemplateJSON   getTemplateData()
      {
        Debug.Assert(flagHasTemplateData);
        return storeTemplateData;
      }

    public bool  hasPreview()
      {
        return flagHasPreview;
      }

    public PreviewJSON   getPreview()
      {
        Debug.Assert(flagHasPreview);
        return storePreview;
      }

    public JSONValue   getPreviewValue()
      {
        return getPreview().getValue();
      }

    public bool  hasSmallScreenHTML()
      {
        return flagHasSmallScreenHTML;
      }

    public string  getSmallScreenHTML()
      {
        Debug.Assert(flagHasSmallScreenHTML);
        return storeSmallScreenHTML;
      }

    public bool  hasLargeScreenHTML()
      {
        return flagHasLargeScreenHTML;
      }

    public string  getLargeScreenHTML()
      {
        Debug.Assert(flagHasLargeScreenHTML);
        return storeLargeScreenHTML;
      }

    public bool  hasHints()
      {
        return flagHasHints;
      }

    public HintsJSON   getHints()
      {
        Debug.Assert(flagHasHints);
        return storeHints;
      }

    public bool  hasEmotion()
      {
        return flagHasEmotion;
      }

    public EmotionJSON   getEmotion()
      {
        Debug.Assert(flagHasEmotion);
        return storeEmotion;
      }

    public EmotionJSON.TypeValue  getEmotionValue()
      {
        return getEmotion().getValue();
      }

    public string  getEmotionAsString()
      {
        return getEmotion().getValueAsString();
      }

    public bool  hasIcon()
      {
        return flagHasIcon;
      }

    public IconJSON   getIcon()
      {
        Debug.Assert(flagHasIcon);
        return storeIcon;
      }

    public IconJSON.TypeValue  getIconValue()
      {
        return getIcon().getValue();
      }

    public string  getIconAsString()
      {
        return getIcon().getValueAsString();
      }

    public bool  hasResponseAudioBytes()
      {
        return flagHasResponseAudioBytes;
      }

    public string  getResponseAudioBytes()
      {
        Debug.Assert(flagHasResponseAudioBytes);
        return storeResponseAudioBytes;
      }

    public bool  hasResponseAudioError()
      {
        return flagHasResponseAudioError;
      }

    public string  getResponseAudioError()
      {
        Debug.Assert(flagHasResponseAudioError);
        return storeResponseAudioError;
      }

    public bool  hasRequiredFeatures()
      {
        return flagHasRequiredFeatures;
      }

    public int  countOfRequiredFeatures()
      {
        Debug.Assert(flagHasRequiredFeatures);
        return storeRequiredFeatures.Count;
      }

    public string  elementOfRequiredFeatures(int element_num)
      {
        Debug.Assert(flagHasRequiredFeatures);
        return storeRequiredFeatures[element_num];
      }

    public List< string >  getRequiredFeatures()
      {
        Debug.Assert(flagHasRequiredFeatures);
        return storeRequiredFeatures;
      }

    public bool  hasClientActionSucceededResult()
      {
        return flagHasClientActionSucceededResult;
      }

    public DynamicResponseJSON   getClientActionSucceededResult()
      {
        Debug.Assert(flagHasClientActionSucceededResult);
        return storeClientActionSucceededResult;
      }

    public bool  hasClientActionFailedResult()
      {
        return flagHasClientActionFailedResult;
      }

    public DynamicResponseJSON   getClientActionFailedResult()
      {
        Debug.Assert(flagHasClientActionFailedResult);
        return storeClientActionFailedResult;
      }

    public bool  hasRequiredFeaturesSupportedResult()
      {
        return flagHasRequiredFeaturesSupportedResult;
      }

    public DynamicResponseJSON   getRequiredFeaturesSupportedResult()
      {
        Debug.Assert(flagHasRequiredFeaturesSupportedResult);
        return storeRequiredFeaturesSupportedResult;
      }

    public bool  hasErrorData()
      {
        return flagHasErrorData;
      }

    public CommandErrorJSON   getErrorData()
      {
        Debug.Assert(flagHasErrorData);
        return storeErrorData;
      }


    public abstract int extraResultClauseComponentCount();
    public abstract string extraResultClauseComponentKey(int component_num);
    public abstract JSONValue extraResultClauseComponentValue(int component_num);
    public abstract JSONValue extraResultClauseLookup(string field_name);

    public void setSpokenResponse(string new_value)
      {
        flagHasSpokenResponse = true;
        storeSpokenResponse = new_value;
      }
    public void unsetSpokenResponse()
      {
        flagHasSpokenResponse = false;
      }
    public void setSpokenResponseLong(string new_value)
      {
        flagHasSpokenResponseLong = true;
        storeSpokenResponseLong = new_value;
      }
    public void unsetSpokenResponseLong()
      {
        flagHasSpokenResponseLong = false;
      }
    public void setWrittenResponse(string new_value)
      {
        flagHasWrittenResponse = true;
        storeWrittenResponse = new_value;
      }
    public void unsetWrittenResponse()
      {
        flagHasWrittenResponse = false;
      }
    public void setWrittenResponseLong(string new_value)
      {
        flagHasWrittenResponseLong = true;
        storeWrittenResponseLong = new_value;
      }
    public void unsetWrittenResponseLong()
      {
        flagHasWrittenResponseLong = false;
      }
    public void setSpokenResponseSSML(string new_value)
      {
        flagHasSpokenResponseSSML = true;
        storeSpokenResponseSSML = new_value;
      }
    public void unsetSpokenResponseSSML()
      {
        flagHasSpokenResponseSSML = false;
      }
    public void setSpokenResponseSSMLLong(string new_value)
      {
        flagHasSpokenResponseSSMLLong = true;
        storeSpokenResponseSSMLLong = new_value;
      }
    public void unsetSpokenResponseSSMLLong()
      {
        flagHasSpokenResponseSSMLLong = false;
      }
    public void setTemplateData(TemplateJSON  new_value)
      {
        if (flagHasTemplateData)
          {
          }
        flagHasTemplateData = true;
        storeTemplateData = new_value;
      }
    public void unsetTemplateData()
      {
        if (flagHasTemplateData)
          {
          }
        flagHasTemplateData = false;
      }
    public void setPreview(PreviewJSON  new_value)
      {
        if (flagHasPreview)
          {
          }
        flagHasPreview = true;
        storePreview = new_value;
      }
    public void setPreview(JSONValue  new_value)
      {
        setPreview(new PreviewJSON(new_value));
      }
    public void unsetPreview()
      {
        if (flagHasPreview)
          {
          }
        flagHasPreview = false;
      }
    public void setSmallScreenHTML(string new_value)
      {
        flagHasSmallScreenHTML = true;
        storeSmallScreenHTML = new_value;
      }
    public void unsetSmallScreenHTML()
      {
        flagHasSmallScreenHTML = false;
      }
    public void setLargeScreenHTML(string new_value)
      {
        flagHasLargeScreenHTML = true;
        storeLargeScreenHTML = new_value;
      }
    public void unsetLargeScreenHTML()
      {
        flagHasLargeScreenHTML = false;
      }
    public void setHints(HintsJSON  new_value)
      {
        if (flagHasHints)
          {
          }
        flagHasHints = true;
        storeHints = new_value;
      }
    public void unsetHints()
      {
        if (flagHasHints)
          {
          }
        flagHasHints = false;
      }
    public void setEmotion(EmotionJSON  new_value)
      {
        if (flagHasEmotion)
          {
          }
        flagHasEmotion = true;
        storeEmotion = new_value;
      }
    public void setEmotion(EmotionJSON.TypeValue new_value)
      {
        setEmotion(new EmotionJSON(new_value));
      }
    public void setEmotion(string chars)
      {
        setEmotion(new EmotionJSON(chars));
      }
    public void unsetEmotion()
      {
        if (flagHasEmotion)
          {
          }
        flagHasEmotion = false;
      }
    public void setIcon(IconJSON  new_value)
      {
        if (flagHasIcon)
          {
          }
        flagHasIcon = true;
        storeIcon = new_value;
      }
    public void setIcon(IconJSON.TypeValue new_value)
      {
        setIcon(new IconJSON(new_value));
      }
    public void setIcon(string chars)
      {
        setIcon(new IconJSON(chars));
      }
    public void unsetIcon()
      {
        if (flagHasIcon)
          {
          }
        flagHasIcon = false;
      }
    public void setResponseAudioBytes(string new_value)
      {
        flagHasResponseAudioBytes = true;
        storeResponseAudioBytes = new_value;
      }
    public void unsetResponseAudioBytes()
      {
        flagHasResponseAudioBytes = false;
      }
    public void setResponseAudioError(string new_value)
      {
        flagHasResponseAudioError = true;
        storeResponseAudioError = new_value;
      }
    public void unsetResponseAudioError()
      {
        flagHasResponseAudioError = false;
      }
    public void initRequiredFeatures()
      {
        flagHasRequiredFeatures = true;
        storeRequiredFeatures.Clear();
      }
    public void appendRequiredFeatures(string to_append)
      {
        if (!flagHasRequiredFeatures)
          {
            flagHasRequiredFeatures = true;
            storeRequiredFeatures.Clear();
          }
        Debug.Assert(flagHasRequiredFeatures);
        storeRequiredFeatures.Add(to_append);
      }
    public void unsetRequiredFeatures()
      {
        flagHasRequiredFeatures = false;
        storeRequiredFeatures.Clear();
      }
    public void setClientActionSucceededResult(DynamicResponseJSON  new_value)
      {
        if (flagHasClientActionSucceededResult)
          {
          }
        flagHasClientActionSucceededResult = true;
        storeClientActionSucceededResult = new_value;
      }
    public void unsetClientActionSucceededResult()
      {
        if (flagHasClientActionSucceededResult)
          {
          }
        flagHasClientActionSucceededResult = false;
      }
    public void setClientActionFailedResult(DynamicResponseJSON  new_value)
      {
        if (flagHasClientActionFailedResult)
          {
          }
        flagHasClientActionFailedResult = true;
        storeClientActionFailedResult = new_value;
      }
    public void unsetClientActionFailedResult()
      {
        if (flagHasClientActionFailedResult)
          {
          }
        flagHasClientActionFailedResult = false;
      }
    public void setRequiredFeaturesSupportedResult(DynamicResponseJSON  new_value)
      {
        if (flagHasRequiredFeaturesSupportedResult)
          {
          }
        flagHasRequiredFeaturesSupportedResult = true;
        storeRequiredFeaturesSupportedResult = new_value;
      }
    public void unsetRequiredFeaturesSupportedResult()
      {
        if (flagHasRequiredFeaturesSupportedResult)
          {
          }
        flagHasRequiredFeaturesSupportedResult = false;
      }
    public void setErrorData(CommandErrorJSON  new_value)
      {
        if (flagHasErrorData)
          {
          }
        flagHasErrorData = true;
        storeErrorData = new_value;
      }
    public void unsetErrorData()
      {
        if (flagHasErrorData)
          {
          }
        flagHasErrorData = false;
      }

    public abstract void extraResultClauseAppendPair(string key, JSONValue new_component);
    public abstract void extraResultClauseSetField(string key, JSONValue new_component);

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
        handler.pair("ClauseKind", getClauseKind());
        Debug.Assert(partial_allowed || flagHasSpokenResponse);
        if (flagHasSpokenResponse)
          {
            handler.start_pair("SpokenResponse");
            handler.string_value(storeSpokenResponse);
          }
        Debug.Assert(partial_allowed || flagHasSpokenResponseLong);
        if (flagHasSpokenResponseLong)
          {
            handler.start_pair("SpokenResponseLong");
            handler.string_value(storeSpokenResponseLong);
          }
        Debug.Assert(partial_allowed || flagHasWrittenResponse);
        if (flagHasWrittenResponse)
          {
            handler.start_pair("WrittenResponse");
            handler.string_value(storeWrittenResponse);
          }
        Debug.Assert(partial_allowed || flagHasWrittenResponseLong);
        if (flagHasWrittenResponseLong)
          {
            handler.start_pair("WrittenResponseLong");
            handler.string_value(storeWrittenResponseLong);
          }
        if (flagHasSpokenResponseSSML)
          {
            handler.start_pair("SpokenResponseSSML");
            handler.string_value(storeSpokenResponseSSML);
          }
        if (flagHasSpokenResponseSSMLLong)
          {
            handler.start_pair("SpokenResponseSSMLLong");
            handler.string_value(storeSpokenResponseSSMLLong);
          }
        if (flagHasTemplateData)
          {
            handler.start_pair("TemplateData");
            if (partial_allowed)
                storeTemplateData.write_partial_as_json(handler);
            else
                storeTemplateData.write_as_json(handler);
          }
        if (flagHasPreview)
          {
            handler.start_pair("Preview");
            if (partial_allowed)
                storePreview.write_partial_as_json(handler);
            else
                storePreview.write_as_json(handler);
          }
        if (flagHasSmallScreenHTML)
          {
            handler.start_pair("SmallScreenHTML");
            handler.string_value(storeSmallScreenHTML);
          }
        if (flagHasLargeScreenHTML)
          {
            handler.start_pair("LargeScreenHTML");
            handler.string_value(storeLargeScreenHTML);
          }
        if (flagHasHints)
          {
            handler.start_pair("Hints");
            if (partial_allowed)
                storeHints.write_partial_as_json(handler);
            else
                storeHints.write_as_json(handler);
          }
        if (flagHasEmotion)
          {
            handler.start_pair("Emotion");
            if (partial_allowed)
                storeEmotion.write_partial_as_json(handler);
            else
                storeEmotion.write_as_json(handler);
          }
        if (flagHasIcon)
          {
            handler.start_pair("Icon");
            if (partial_allowed)
                storeIcon.write_partial_as_json(handler);
            else
                storeIcon.write_as_json(handler);
          }
        if (flagHasResponseAudioBytes)
          {
            handler.start_pair("ResponseAudioBytes");
            handler.string_value(storeResponseAudioBytes);
          }
        if (flagHasResponseAudioError)
          {
            handler.start_pair("ResponseAudioError");
            handler.string_value(storeResponseAudioError);
          }
        if (flagHasRequiredFeatures)
          {
            handler.start_pair("RequiredFeatures");
            Debug.Assert(storeRequiredFeatures.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeRequiredFeatures.Count; ++num1)
              {
                handler.string_value(storeRequiredFeatures[num1]);
              }
            handler.finish_array();
          }
        if (flagHasClientActionSucceededResult)
          {
            handler.start_pair("ClientActionSucceededResult");
            if (partial_allowed)
                storeClientActionSucceededResult.write_partial_as_json(handler);
            else
                storeClientActionSucceededResult.write_as_json(handler);
          }
        if (flagHasClientActionFailedResult)
          {
            handler.start_pair("ClientActionFailedResult");
            if (partial_allowed)
                storeClientActionFailedResult.write_partial_as_json(handler);
            else
                storeClientActionFailedResult.write_as_json(handler);
          }
        if (flagHasRequiredFeaturesSupportedResult)
          {
            handler.start_pair("RequiredFeaturesSupportedResult");
            if (partial_allowed)
                storeRequiredFeaturesSupportedResult.write_partial_as_json(handler);
            else
                storeRequiredFeaturesSupportedResult.write_as_json(handler);
          }
        if (flagHasErrorData)
          {
            handler.start_pair("ErrorData");
            if (partial_allowed)
                storeErrorData.write_partial_as_json(handler);
            else
                storeErrorData.write_as_json(handler);
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
        if (!(hasSpokenResponse()))
          {
            return "When parsing the object for %what%, the \"SpokenResponse\" field was missing.";
          }
        if (!(hasSpokenResponseLong()))
          {
            return "When parsing the object for %what%, the \"SpokenResponseLong\" field was missing.";
          }
        if (!(hasWrittenResponse()))
          {
            return "When parsing the object for %what%, the \"WrittenResponse\" field was missing.";
          }
        if (!(hasWrittenResponseLong()))
          {
            return "When parsing the object for %what%, the \"WrittenResponseLong\" field was missing.";
          }
        return null;
      }

    public static ResultClauseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ResultClauseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ResultClause", ignore_extras);
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
    public static ResultClauseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ResultClauseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ResultClauseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ResultClause", ignore_extras);
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
    public static ResultClauseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ResultClauseJSON from_text(string text, bool ignore_extras)
      {
        ResultClauseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ResultClause", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ResultClauseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ResultClauseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ResultClauseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ResultClause", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponse;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponseLong;
        private JSONHoldingStringGenerator fieldGeneratorWrittenResponse;
        private JSONHoldingStringGenerator fieldGeneratorWrittenResponseLong;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponseSSML;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponseSSMLLong;
        private TemplateJSON.HoldingGenerator fieldGeneratorTemplateData;
        private PreviewJSON.HoldingGenerator fieldGeneratorPreview;
        private JSONHoldingStringGenerator fieldGeneratorSmallScreenHTML;
        private JSONHoldingStringGenerator fieldGeneratorLargeScreenHTML;
        private HintsJSON.HoldingGenerator fieldGeneratorHints;
        private EmotionJSON.HoldingGenerator fieldGeneratorEmotion;
        private IconJSON.HoldingGenerator fieldGeneratorIcon;
        private JSONHoldingStringGenerator fieldGeneratorResponseAudioBytes;
        private JSONHoldingStringGenerator fieldGeneratorResponseAudioError;
        private JSONHoldingStringArrayGenerator fieldGeneratorRequiredFeatures;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorClientActionSucceededResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorClientActionFailedResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorRequiredFeaturesSupportedResult;
        private CommandErrorJSON.HoldingGenerator fieldGeneratorErrorData;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `ClauseKind' field is missing.");
            ResultClauseJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraResultClauseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getResultClauseJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `ClauseKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(ResultClauseJSON result)
          {
            if (fieldGeneratorSpokenResponse.have_value)
              {
                result.setSpokenResponse(fieldGeneratorSpokenResponse.value);
                fieldGeneratorSpokenResponse.have_value = false;
              }
            else if ((!(result.hasSpokenResponse())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenResponse\" field was missing.");
              }
            if (fieldGeneratorSpokenResponseLong.have_value)
              {
                result.setSpokenResponseLong(fieldGeneratorSpokenResponseLong.value);
                fieldGeneratorSpokenResponseLong.have_value = false;
              }
            else if ((!(result.hasSpokenResponseLong())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenResponseLong\" field was missing.");
              }
            if (fieldGeneratorWrittenResponse.have_value)
              {
                result.setWrittenResponse(fieldGeneratorWrittenResponse.value);
                fieldGeneratorWrittenResponse.have_value = false;
              }
            else if ((!(result.hasWrittenResponse())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenResponse\" field was missing.");
              }
            if (fieldGeneratorWrittenResponseLong.have_value)
              {
                result.setWrittenResponseLong(fieldGeneratorWrittenResponseLong.value);
                fieldGeneratorWrittenResponseLong.have_value = false;
              }
            else if ((!(result.hasWrittenResponseLong())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenResponseLong\" field was missing.");
              }
            if (fieldGeneratorSpokenResponseSSML.have_value)
              {
                result.setSpokenResponseSSML(fieldGeneratorSpokenResponseSSML.value);
                fieldGeneratorSpokenResponseSSML.have_value = false;
              }
            if (fieldGeneratorSpokenResponseSSMLLong.have_value)
              {
                result.setSpokenResponseSSMLLong(fieldGeneratorSpokenResponseSSMLLong.value);
                fieldGeneratorSpokenResponseSSMLLong.have_value = false;
              }
            if (fieldGeneratorTemplateData.have_value)
              {
                result.setTemplateData(fieldGeneratorTemplateData.value);
                fieldGeneratorTemplateData.have_value = false;
              }
            if (fieldGeneratorPreview.have_value)
              {
                result.setPreview(fieldGeneratorPreview.value);
                fieldGeneratorPreview.have_value = false;
              }
            if (fieldGeneratorSmallScreenHTML.have_value)
              {
                result.setSmallScreenHTML(fieldGeneratorSmallScreenHTML.value);
                fieldGeneratorSmallScreenHTML.have_value = false;
              }
            if (fieldGeneratorLargeScreenHTML.have_value)
              {
                result.setLargeScreenHTML(fieldGeneratorLargeScreenHTML.value);
                fieldGeneratorLargeScreenHTML.have_value = false;
              }
            if (fieldGeneratorHints.have_value)
              {
                result.setHints(fieldGeneratorHints.value);
                fieldGeneratorHints.have_value = false;
              }
            if (fieldGeneratorEmotion.have_value)
              {
                result.setEmotion(fieldGeneratorEmotion.value);
                fieldGeneratorEmotion.have_value = false;
              }
            if (fieldGeneratorIcon.have_value)
              {
                result.setIcon(fieldGeneratorIcon.value);
                fieldGeneratorIcon.have_value = false;
              }
            if (fieldGeneratorResponseAudioBytes.have_value)
              {
                result.setResponseAudioBytes(fieldGeneratorResponseAudioBytes.value);
                fieldGeneratorResponseAudioBytes.have_value = false;
              }
            if (fieldGeneratorResponseAudioError.have_value)
              {
                result.setResponseAudioError(fieldGeneratorResponseAudioError.value);
                fieldGeneratorResponseAudioError.have_value = false;
              }
            if (fieldGeneratorRequiredFeatures.have_value)
              {
                result.initRequiredFeatures();
                int count = fieldGeneratorRequiredFeatures.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRequiredFeatures(fieldGeneratorRequiredFeatures.value[num]);
                  }
                fieldGeneratorRequiredFeatures.value.Clear();
                fieldGeneratorRequiredFeatures.have_value = false;
              }
            if (fieldGeneratorClientActionSucceededResult.have_value)
              {
                result.setClientActionSucceededResult(fieldGeneratorClientActionSucceededResult.value);
                fieldGeneratorClientActionSucceededResult.have_value = false;
              }
            if (fieldGeneratorClientActionFailedResult.have_value)
              {
                result.setClientActionFailedResult(fieldGeneratorClientActionFailedResult.value);
                fieldGeneratorClientActionFailedResult.have_value = false;
              }
            if (fieldGeneratorRequiredFeaturesSupportedResult.have_value)
              {
                result.setRequiredFeaturesSupportedResult(fieldGeneratorRequiredFeaturesSupportedResult.value);
                fieldGeneratorRequiredFeaturesSupportedResult.have_value = false;
              }
            if (fieldGeneratorErrorData.have_value)
              {
                result.setErrorData(fieldGeneratorErrorData.value);
                fieldGeneratorErrorData.have_value = false;
              }
          }
        protected abstract void handle_result(ResultClauseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "l", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 3, "useKind", 0, 7, false) == 0) && (field_name.Length == 10))
                                    {
                                    keyGenerator.reset();
                                    return keyGenerator;
                                    }
                                break;
                            case 'i':
                                if (String.Compare(field_name, 3, "entAction", 0, 9, false) == 0)
                                  {
                                    switch (field_name[12])
                                      {
                                        case 'F':
                                            if ((String.Compare(field_name, 13, "ailedResult", 0, 11, false) == 0) && (field_name.Length == 24))
                                                return fieldGeneratorClientActionFailedResult;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 13, "ucceededResult", 0, 14, false) == 0) && (field_name.Length == 27))
                                                return fieldGeneratorClientActionSucceededResult;
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
                case 'E':
                    switch (field_name[1])
                      {
                        case 'm':
                            if ((String.Compare(field_name, 2, "otion", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorEmotion;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "rorData", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorErrorData;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "ints", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorHints;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "con", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorIcon;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "argeScreenHTML", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorLargeScreenHTML;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "review", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorPreview;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'q':
                                if (String.Compare(field_name, 3, "uiredFeatures", 0, 13, false) == 0)
                                  {
                                    if (field_name.Length == 16)
                                      {
                                        return fieldGeneratorRequiredFeatures;
                                      }
                                    switch (field_name[16])
                                      {
                                        case 'S':
                                            if ((String.Compare(field_name, 17, "upportedResult", 0, 14, false) == 0) && (field_name.Length == 31))
                                                return fieldGeneratorRequiredFeaturesSupportedResult;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 's':
                                if (String.Compare(field_name, 3, "ponseAudio", 0, 10, false) == 0)
                                  {
                                    switch (field_name[13])
                                      {
                                        case 'B':
                                            if ((String.Compare(field_name, 14, "ytes", 0, 4, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorResponseAudioBytes;
                                            break;
                                        case 'E':
                                            if ((String.Compare(field_name, 14, "rror", 0, 4, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorResponseAudioError;
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
                    switch (field_name[1])
                      {
                        case 'm':
                            if ((String.Compare(field_name, 2, "allScreenHTML", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorSmallScreenHTML;
                            break;
                        case 'p':
                            if (String.Compare(field_name, 2, "okenResponse", 0, 12, false) == 0)
                              {
                                if (field_name.Length == 14)
                                  {
                                    return fieldGeneratorSpokenResponse;
                                  }
                                switch (field_name[14])
                                  {
                                    case 'L':
                                        if ((String.Compare(field_name, 15, "ong", 0, 3, false) == 0) && (field_name.Length == 18))
                                            return fieldGeneratorSpokenResponseLong;
                                        break;
                                    case 'S':
                                        if (String.Compare(field_name, 15, "SML", 0, 3, false) == 0)
                                          {
                                            if (field_name.Length == 18)
                                              {
                                                return fieldGeneratorSpokenResponseSSML;
                                              }
                                            switch (field_name[18])
                                              {
                                                case 'L':
                                                    if ((String.Compare(field_name, 19, "ong", 0, 3, false) == 0) && (field_name.Length == 22))
                                                        return fieldGeneratorSpokenResponseSSMLLong;
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
                case 'T':
                    if ((String.Compare(field_name, 1, "emplateData", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorTemplateData;
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "rittenResponse", 0, 14, false) == 0)
                      {
                        if (field_name.Length == 15)
                          {
                            return fieldGeneratorWrittenResponse;
                          }
                        switch (field_name[15])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 16, "ong", 0, 3, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorWrittenResponseLong;
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
            fieldGeneratorSpokenResponse = new JSONHoldingStringGenerator("field \"SpokenResponse\" of the ResultClause class");
            fieldGeneratorSpokenResponseLong = new JSONHoldingStringGenerator("field \"SpokenResponseLong\" of the ResultClause class");
            fieldGeneratorWrittenResponse = new JSONHoldingStringGenerator("field \"WrittenResponse\" of the ResultClause class");
            fieldGeneratorWrittenResponseLong = new JSONHoldingStringGenerator("field \"WrittenResponseLong\" of the ResultClause class");
            fieldGeneratorSpokenResponseSSML = new JSONHoldingStringGenerator("field \"SpokenResponseSSML\" of the ResultClause class");
            fieldGeneratorSpokenResponseSSMLLong = new JSONHoldingStringGenerator("field \"SpokenResponseSSMLLong\" of the ResultClause class");
            fieldGeneratorTemplateData = new TemplateJSON.HoldingGenerator("field \"TemplateData\" of the ResultClause class", ignore_extras);
            fieldGeneratorPreview = new PreviewJSON.HoldingGenerator("field \"Preview\" of the ResultClause class", ignore_extras);
            fieldGeneratorSmallScreenHTML = new JSONHoldingStringGenerator("field \"SmallScreenHTML\" of the ResultClause class");
            fieldGeneratorLargeScreenHTML = new JSONHoldingStringGenerator("field \"LargeScreenHTML\" of the ResultClause class");
            fieldGeneratorHints = new HintsJSON.HoldingGenerator("field \"Hints\" of the ResultClause class", ignore_extras);
            fieldGeneratorEmotion = new EmotionJSON.HoldingGenerator("field \"Emotion\" of the ResultClause class", ignore_extras);
            fieldGeneratorIcon = new IconJSON.HoldingGenerator("field \"Icon\" of the ResultClause class", ignore_extras);
            fieldGeneratorResponseAudioBytes = new JSONHoldingStringGenerator("field \"ResponseAudioBytes\" of the ResultClause class");
            fieldGeneratorResponseAudioError = new JSONHoldingStringGenerator("field \"ResponseAudioError\" of the ResultClause class");
            fieldGeneratorRequiredFeatures = new JSONHoldingStringArrayGenerator("field \"RequiredFeatures\" of the ResultClause class");
            fieldGeneratorClientActionSucceededResult = new DynamicResponseJSON.HoldingGenerator("field \"ClientActionSucceededResult\" of the ResultClause class", ignore_extras);
            fieldGeneratorClientActionFailedResult = new DynamicResponseJSON.HoldingGenerator("field \"ClientActionFailedResult\" of the ResultClause class", ignore_extras);
            fieldGeneratorRequiredFeaturesSupportedResult = new DynamicResponseJSON.HoldingGenerator("field \"RequiredFeaturesSupportedResult\" of the ResultClause class", ignore_extras);
            fieldGeneratorErrorData = new CommandErrorJSON.HoldingGenerator("field \"ErrorData\" of the ResultClause class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ClauseKind\" of the ResultClause class");
            set_what("the ResultClause class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpokenResponse = new JSONHoldingStringGenerator("field \"SpokenResponse\" of the ResultClause class");
            fieldGeneratorSpokenResponseLong = new JSONHoldingStringGenerator("field \"SpokenResponseLong\" of the ResultClause class");
            fieldGeneratorWrittenResponse = new JSONHoldingStringGenerator("field \"WrittenResponse\" of the ResultClause class");
            fieldGeneratorWrittenResponseLong = new JSONHoldingStringGenerator("field \"WrittenResponseLong\" of the ResultClause class");
            fieldGeneratorSpokenResponseSSML = new JSONHoldingStringGenerator("field \"SpokenResponseSSML\" of the ResultClause class");
            fieldGeneratorSpokenResponseSSMLLong = new JSONHoldingStringGenerator("field \"SpokenResponseSSMLLong\" of the ResultClause class");
            fieldGeneratorTemplateData = new TemplateJSON.HoldingGenerator("field \"TemplateData\" of the ResultClause class", false);
            fieldGeneratorPreview = new PreviewJSON.HoldingGenerator("field \"Preview\" of the ResultClause class", false);
            fieldGeneratorSmallScreenHTML = new JSONHoldingStringGenerator("field \"SmallScreenHTML\" of the ResultClause class");
            fieldGeneratorLargeScreenHTML = new JSONHoldingStringGenerator("field \"LargeScreenHTML\" of the ResultClause class");
            fieldGeneratorHints = new HintsJSON.HoldingGenerator("field \"Hints\" of the ResultClause class", false);
            fieldGeneratorEmotion = new EmotionJSON.HoldingGenerator("field \"Emotion\" of the ResultClause class", false);
            fieldGeneratorIcon = new IconJSON.HoldingGenerator("field \"Icon\" of the ResultClause class", false);
            fieldGeneratorResponseAudioBytes = new JSONHoldingStringGenerator("field \"ResponseAudioBytes\" of the ResultClause class");
            fieldGeneratorResponseAudioError = new JSONHoldingStringGenerator("field \"ResponseAudioError\" of the ResultClause class");
            fieldGeneratorRequiredFeatures = new JSONHoldingStringArrayGenerator("field \"RequiredFeatures\" of the ResultClause class");
            fieldGeneratorClientActionSucceededResult = new DynamicResponseJSON.HoldingGenerator("field \"ClientActionSucceededResult\" of the ResultClause class", false);
            fieldGeneratorClientActionFailedResult = new DynamicResponseJSON.HoldingGenerator("field \"ClientActionFailedResult\" of the ResultClause class", false);
            fieldGeneratorRequiredFeaturesSupportedResult = new DynamicResponseJSON.HoldingGenerator("field \"RequiredFeaturesSupportedResult\" of the ResultClause class", false);
            fieldGeneratorErrorData = new CommandErrorJSON.HoldingGenerator("field \"ErrorData\" of the ResultClause class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ClauseKind\" of the ResultClause class");
            set_what("the ResultClause class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSpokenResponse.reset();
            fieldGeneratorSpokenResponseLong.reset();
            fieldGeneratorWrittenResponse.reset();
            fieldGeneratorWrittenResponseLong.reset();
            fieldGeneratorSpokenResponseSSML.reset();
            fieldGeneratorSpokenResponseSSMLLong.reset();
            fieldGeneratorTemplateData.reset();
            fieldGeneratorPreview.reset();
            fieldGeneratorSmallScreenHTML.reset();
            fieldGeneratorLargeScreenHTML.reset();
            fieldGeneratorHints.reset();
            fieldGeneratorEmotion.reset();
            fieldGeneratorIcon.reset();
            fieldGeneratorResponseAudioBytes.reset();
            fieldGeneratorResponseAudioError.reset();
            fieldGeneratorRequiredFeatures.reset();
            fieldGeneratorClientActionSucceededResult.reset();
            fieldGeneratorClientActionFailedResult.reset();
            fieldGeneratorRequiredFeaturesSupportedResult.reset();
            fieldGeneratorErrorData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTemplateData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPreview.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHints.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEmotion.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorIcon.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorClientActionSucceededResult.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorClientActionFailedResult.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequiredFeaturesSupportedResult.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorErrorData.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTemplateData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPreview.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHints.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEmotion.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorIcon.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorClientActionSucceededResult.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorClientActionFailedResult.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequiredFeaturesSupportedResult.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorErrorData.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ResultClauseJSON  result)
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
        public ResultClauseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ResultClauseJSON  result)
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
    protected virtual void handle_result(List<ResultClauseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ResultClauseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ResultClauseJSON>();
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
    public List<ResultClauseJSON> value;
  };
    class GenericResultClauseJSON : ResultClauseJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericResultClauseJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getClauseKind()  { return key; }
        public override int extraResultClauseComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraResultClauseComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraResultClauseComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraResultClauseLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraResultClauseAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraResultClauseSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraResultClauseLookup(key);
            if (old_field == null)
              {
                extraResultClauseAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static ResultClauseJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {

        return new GenericResultClauseJSON(key);
      }
  };
