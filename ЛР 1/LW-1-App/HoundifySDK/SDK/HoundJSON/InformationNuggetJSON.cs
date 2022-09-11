/* file "InformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class InformationNuggetJSON : JSONBase
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
    private bool flagHasCombiningTemplateData;
    private TemplateJSON  storeCombiningTemplateData;
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
    private bool flagHasUnderstandingConfidence;
    private double storeUnderstandingConfidence;
    private string textStoreUnderstandingConfidence;
    private bool flagHasOutputOverrideDiagnostics;
    private List< string > storeOutputOverrideDiagnostics;


    private void  fromJSONSpokenResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponse of InformationNuggetJSON is not a string.");
        setSpokenResponse(json_string.getData());
      }


    private void  fromJSONSpokenResponseLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseLong of InformationNuggetJSON is not a string.");
        setSpokenResponseLong(json_string.getData());
      }


    private void  fromJSONWrittenResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenResponse of InformationNuggetJSON is not a string.");
        setWrittenResponse(json_string.getData());
      }


    private void  fromJSONWrittenResponseLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenResponseLong of InformationNuggetJSON is not a string.");
        setWrittenResponseLong(json_string.getData());
      }


    private void  fromJSONSpokenResponseSSML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseSSML of InformationNuggetJSON is not a string.");
        setSpokenResponseSSML(json_string.getData());
      }


    private void  fromJSONSpokenResponseSSMLLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseSSMLLong of InformationNuggetJSON is not a string.");
        setSpokenResponseSSMLLong(json_string.getData());
      }


    private void  fromJSONTemplateData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TemplateJSON convert_classy = TemplateJSON.from_json(json_value, ignore_extras, true);
        setTemplateData(convert_classy);
      }


    private void  fromJSONCombiningTemplateData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TemplateJSON convert_classy = TemplateJSON.from_json(json_value, ignore_extras, true);
        setCombiningTemplateData(convert_classy);
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
            throw new Exception("The value for field SmallScreenHTML of InformationNuggetJSON is not a string.");
        setSmallScreenHTML(json_string.getData());
      }


    private void  fromJSONLargeScreenHTML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LargeScreenHTML of InformationNuggetJSON is not a string.");
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


    private void  fromJSONUnderstandingConfidence(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field UnderstandingConfidence of InformationNuggetJSON is not a number.");
              }
          }
        setUnderstandingConfidenceText(the_rational_text);
      }


    private void  fromJSONOutputOverrideDiagnostics(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field OutputOverrideDiagnostics of InformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_OutputOverrideDiagnostics1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field OutputOverrideDiagnostics of InformationNuggetJSON is not a string.");
            vector_OutputOverrideDiagnostics1.Add(json_string.getData());
          }
        initOutputOverrideDiagnostics();
        for (int num1 = 0; num1 < vector_OutputOverrideDiagnostics1.Count; ++num1)
            appendOutputOverrideDiagnostics(vector_OutputOverrideDiagnostics1[num1]);
        for (int num1 = 0; num1 < vector_OutputOverrideDiagnostics1.Count; ++num1)
          {
          }
      }


    public InformationNuggetJSON()
      {
        flagHasSpokenResponse = false;
        flagHasSpokenResponseLong = false;
        flagHasWrittenResponse = false;
        flagHasWrittenResponseLong = false;
        flagHasSpokenResponseSSML = false;
        flagHasSpokenResponseSSMLLong = false;
        flagHasTemplateData = false;
        flagHasCombiningTemplateData = false;
        flagHasPreview = false;
        flagHasSmallScreenHTML = false;
        flagHasLargeScreenHTML = false;
        flagHasHints = false;
        flagHasEmotion = false;
        flagHasIcon = false;
        flagHasUnderstandingConfidence = false;
        flagHasOutputOverrideDiagnostics = false;
        storeOutputOverrideDiagnostics = new List< string >();
      }

    public abstract string getNuggetKind();
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

    public bool  hasCombiningTemplateData()
      {
        return flagHasCombiningTemplateData;
      }

    public TemplateJSON   getCombiningTemplateData()
      {
        Debug.Assert(flagHasCombiningTemplateData);
        return storeCombiningTemplateData;
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

    public bool  hasUnderstandingConfidence()
      {
        return flagHasUnderstandingConfidence;
      }

    public double  getUnderstandingConfidence()
      {
        Debug.Assert(flagHasUnderstandingConfidence);
        if (textStoreUnderstandingConfidence != "")
          {
            return Double.Parse(textStoreUnderstandingConfidence);
          }
        return storeUnderstandingConfidence;
      }

    public string  getUnderstandingConfidenceAsText()
      {
        Debug.Assert(flagHasUnderstandingConfidence);
        if (textStoreUnderstandingConfidence == "")
          {
            return Convert.ToString(storeUnderstandingConfidence);
          }
        else
          {
            return (textStoreUnderstandingConfidence);
          }
      }

    public bool  hasOutputOverrideDiagnostics()
      {
        return flagHasOutputOverrideDiagnostics;
      }

    public int  countOfOutputOverrideDiagnostics()
      {
        Debug.Assert(flagHasOutputOverrideDiagnostics);
        return storeOutputOverrideDiagnostics.Count;
      }

    public string  elementOfOutputOverrideDiagnostics(int element_num)
      {
        Debug.Assert(flagHasOutputOverrideDiagnostics);
        return storeOutputOverrideDiagnostics[element_num];
      }

    public List< string >  getOutputOverrideDiagnostics()
      {
        Debug.Assert(flagHasOutputOverrideDiagnostics);
        return storeOutputOverrideDiagnostics;
      }


    public abstract int extraInformationNuggetComponentCount();
    public abstract string extraInformationNuggetComponentKey(int component_num);
    public abstract JSONValue extraInformationNuggetComponentValue(int component_num);
    public abstract JSONValue extraInformationNuggetLookup(string field_name);

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
    public void setCombiningTemplateData(TemplateJSON  new_value)
      {
        if (flagHasCombiningTemplateData)
          {
          }
        flagHasCombiningTemplateData = true;
        storeCombiningTemplateData = new_value;
      }
    public void unsetCombiningTemplateData()
      {
        if (flagHasCombiningTemplateData)
          {
          }
        flagHasCombiningTemplateData = false;
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
    public void setUnderstandingConfidence(double new_value)
      {
        flagHasUnderstandingConfidence = true;
        if (new_value < 0)
            throw new Exception("The value for field UnderstandingConfidence of InformationNuggetJSON is less than the lower bound (0) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field UnderstandingConfidence of InformationNuggetJSON is greater than the upper bound (1) for that field.");
        storeUnderstandingConfidence = new_value;
        textStoreUnderstandingConfidence = "";
      }
    public void setUnderstandingConfidenceText(string new_value)
      {
        flagHasUnderstandingConfidence = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field UnderstandingConfidence of InformationNuggetJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field UnderstandingConfidence of InformationNuggetJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field UnderstandingConfidence of InformationNuggetJSON is greater than the upper bound (1) for that field.");
        textStoreUnderstandingConfidence = new_value;
      }
    public void unsetUnderstandingConfidence()
      {
        flagHasUnderstandingConfidence = false;
      }
    public void initOutputOverrideDiagnostics()
      {
        flagHasOutputOverrideDiagnostics = true;
        storeOutputOverrideDiagnostics.Clear();
      }
    public void appendOutputOverrideDiagnostics(string to_append)
      {
        if (!flagHasOutputOverrideDiagnostics)
          {
            flagHasOutputOverrideDiagnostics = true;
            storeOutputOverrideDiagnostics.Clear();
          }
        Debug.Assert(flagHasOutputOverrideDiagnostics);
        storeOutputOverrideDiagnostics.Add(to_append);
      }
    public void unsetOutputOverrideDiagnostics()
      {
        flagHasOutputOverrideDiagnostics = false;
        storeOutputOverrideDiagnostics.Clear();
      }

    public abstract void extraInformationNuggetAppendPair(string key, JSONValue new_component);
    public abstract void extraInformationNuggetSetField(string key, JSONValue new_component);

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
        handler.pair("NuggetKind", getNuggetKind());
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
        if (flagHasCombiningTemplateData)
          {
            handler.start_pair("CombiningTemplateData");
            if (partial_allowed)
                storeCombiningTemplateData.write_partial_as_json(handler);
            else
                storeCombiningTemplateData.write_as_json(handler);
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
        if (flagHasUnderstandingConfidence)
          {
            handler.start_pair("UnderstandingConfidence");
            if (textStoreUnderstandingConfidence != "")
                handler.number_value(textStoreUnderstandingConfidence);
            else if (((double)(long)storeUnderstandingConfidence) == storeUnderstandingConfidence)
                handler.number_value((long)storeUnderstandingConfidence);
            else
                handler.number_value(storeUnderstandingConfidence);
          }
        if (flagHasOutputOverrideDiagnostics)
          {
            handler.start_pair("OutputOverrideDiagnostics");
            handler.start_array();
            for (int num1 = 0; num1 < storeOutputOverrideDiagnostics.Count; ++num1)
              {
                handler.string_value(storeOutputOverrideDiagnostics[num1]);
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
        if ((!allow_unpolished) && !(hasSpokenResponse()))
          {
            return "When parsing the object for %what%, the \"SpokenResponse\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasSpokenResponseLong()))
          {
            return "When parsing the object for %what%, the \"SpokenResponseLong\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasWrittenResponse()))
          {
            return "When parsing the object for %what%, the \"WrittenResponse\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasWrittenResponseLong()))
          {
            return "When parsing the object for %what%, the \"WrittenResponseLong\" field was missing.";
          }
        return null;
      }

    public static InformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        InformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type InformationNugget", ignore_extras);
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
    public static InformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static InformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        InformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type InformationNugget", ignore_extras);
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
    public static InformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static InformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        InformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type InformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for InformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static InformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        InformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type InformationNugget", ignore_extras);
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
        private TemplateJSON.HoldingGenerator fieldGeneratorCombiningTemplateData;
        private PreviewJSON.HoldingGenerator fieldGeneratorPreview;
        private JSONHoldingStringGenerator fieldGeneratorSmallScreenHTML;
        private JSONHoldingStringGenerator fieldGeneratorLargeScreenHTML;
        private HintsJSON.HoldingGenerator fieldGeneratorHints;
        private EmotionJSON.HoldingGenerator fieldGeneratorEmotion;
        private IconJSON.HoldingGenerator fieldGeneratorIcon;
        private JSONHoldingNumberTextGenerator fieldGeneratorUnderstandingConfidence;
        private JSONHoldingStringArrayGenerator fieldGeneratorOutputOverrideDiagnostics;
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
                throw new Exception("The `NuggetKind' field is missing.");
            InformationNuggetJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getInformationNuggetJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `NuggetKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(InformationNuggetJSON result)
          {
            if (fieldGeneratorSpokenResponse.have_value)
              {
                result.setSpokenResponse(fieldGeneratorSpokenResponse.value);
                fieldGeneratorSpokenResponse.have_value = false;
              }
            else if ((!(result.hasSpokenResponse())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenResponse\" field was missing.");
              }
            if (fieldGeneratorSpokenResponseLong.have_value)
              {
                result.setSpokenResponseLong(fieldGeneratorSpokenResponseLong.value);
                fieldGeneratorSpokenResponseLong.have_value = false;
              }
            else if ((!(result.hasSpokenResponseLong())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenResponseLong\" field was missing.");
              }
            if (fieldGeneratorWrittenResponse.have_value)
              {
                result.setWrittenResponse(fieldGeneratorWrittenResponse.value);
                fieldGeneratorWrittenResponse.have_value = false;
              }
            else if ((!(result.hasWrittenResponse())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenResponse\" field was missing.");
              }
            if (fieldGeneratorWrittenResponseLong.have_value)
              {
                result.setWrittenResponseLong(fieldGeneratorWrittenResponseLong.value);
                fieldGeneratorWrittenResponseLong.have_value = false;
              }
            else if ((!(result.hasWrittenResponseLong())) && (!allow_unpolished) && !allow_incomplete)
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
            if (fieldGeneratorCombiningTemplateData.have_value)
              {
                result.setCombiningTemplateData(fieldGeneratorCombiningTemplateData.value);
                fieldGeneratorCombiningTemplateData.have_value = false;
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
            if (fieldGeneratorUnderstandingConfidence.have_value)
              {
                result.setUnderstandingConfidenceText(fieldGeneratorUnderstandingConfidence.value);
                fieldGeneratorUnderstandingConfidence.have_value = false;
              }
            if (fieldGeneratorOutputOverrideDiagnostics.have_value)
              {
                result.initOutputOverrideDiagnostics();
                int count = fieldGeneratorOutputOverrideDiagnostics.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOutputOverrideDiagnostics(fieldGeneratorOutputOverrideDiagnostics.value[num]);
                  }
                fieldGeneratorOutputOverrideDiagnostics.value.Clear();
                fieldGeneratorOutputOverrideDiagnostics.have_value = false;
              }
          }
        protected abstract void handle_result(InformationNuggetJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ombiningTemplateData", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorCombiningTemplateData;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "motion", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorEmotion;
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
                case 'N':
                    if ((String.Compare(field_name, 1, "uggetKind", 0, 9, false) == 0) && (field_name.Length == 10))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "utputOverrideDiagnostics", 0, 24, false) == 0) && (field_name.Length == 25))
                        return fieldGeneratorOutputOverrideDiagnostics;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "review", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorPreview;
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
                case 'U':
                    if ((String.Compare(field_name, 1, "nderstandingConfidence", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorUnderstandingConfidence;
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
            fieldGeneratorSpokenResponse = new JSONHoldingStringGenerator("field \"SpokenResponse\" of the InformationNugget class");
            fieldGeneratorSpokenResponseLong = new JSONHoldingStringGenerator("field \"SpokenResponseLong\" of the InformationNugget class");
            fieldGeneratorWrittenResponse = new JSONHoldingStringGenerator("field \"WrittenResponse\" of the InformationNugget class");
            fieldGeneratorWrittenResponseLong = new JSONHoldingStringGenerator("field \"WrittenResponseLong\" of the InformationNugget class");
            fieldGeneratorSpokenResponseSSML = new JSONHoldingStringGenerator("field \"SpokenResponseSSML\" of the InformationNugget class");
            fieldGeneratorSpokenResponseSSMLLong = new JSONHoldingStringGenerator("field \"SpokenResponseSSMLLong\" of the InformationNugget class");
            fieldGeneratorTemplateData = new TemplateJSON.HoldingGenerator("field \"TemplateData\" of the InformationNugget class", ignore_extras);
            fieldGeneratorCombiningTemplateData = new TemplateJSON.HoldingGenerator("field \"CombiningTemplateData\" of the InformationNugget class", ignore_extras);
            fieldGeneratorPreview = new PreviewJSON.HoldingGenerator("field \"Preview\" of the InformationNugget class", ignore_extras);
            fieldGeneratorSmallScreenHTML = new JSONHoldingStringGenerator("field \"SmallScreenHTML\" of the InformationNugget class");
            fieldGeneratorLargeScreenHTML = new JSONHoldingStringGenerator("field \"LargeScreenHTML\" of the InformationNugget class");
            fieldGeneratorHints = new HintsJSON.HoldingGenerator("field \"Hints\" of the InformationNugget class", ignore_extras);
            fieldGeneratorEmotion = new EmotionJSON.HoldingGenerator("field \"Emotion\" of the InformationNugget class", ignore_extras);
            fieldGeneratorIcon = new IconJSON.HoldingGenerator("field \"Icon\" of the InformationNugget class", ignore_extras);
            fieldGeneratorUnderstandingConfidence = new JSONHoldingNumberTextGenerator("field \"UnderstandingConfidence\" of the InformationNugget class");
            fieldGeneratorOutputOverrideDiagnostics = new JSONHoldingStringArrayGenerator("field \"OutputOverrideDiagnostics\" of the InformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"NuggetKind\" of the InformationNugget class");
            set_what("the InformationNugget class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpokenResponse = new JSONHoldingStringGenerator("field \"SpokenResponse\" of the InformationNugget class");
            fieldGeneratorSpokenResponseLong = new JSONHoldingStringGenerator("field \"SpokenResponseLong\" of the InformationNugget class");
            fieldGeneratorWrittenResponse = new JSONHoldingStringGenerator("field \"WrittenResponse\" of the InformationNugget class");
            fieldGeneratorWrittenResponseLong = new JSONHoldingStringGenerator("field \"WrittenResponseLong\" of the InformationNugget class");
            fieldGeneratorSpokenResponseSSML = new JSONHoldingStringGenerator("field \"SpokenResponseSSML\" of the InformationNugget class");
            fieldGeneratorSpokenResponseSSMLLong = new JSONHoldingStringGenerator("field \"SpokenResponseSSMLLong\" of the InformationNugget class");
            fieldGeneratorTemplateData = new TemplateJSON.HoldingGenerator("field \"TemplateData\" of the InformationNugget class", false);
            fieldGeneratorCombiningTemplateData = new TemplateJSON.HoldingGenerator("field \"CombiningTemplateData\" of the InformationNugget class", false);
            fieldGeneratorPreview = new PreviewJSON.HoldingGenerator("field \"Preview\" of the InformationNugget class", false);
            fieldGeneratorSmallScreenHTML = new JSONHoldingStringGenerator("field \"SmallScreenHTML\" of the InformationNugget class");
            fieldGeneratorLargeScreenHTML = new JSONHoldingStringGenerator("field \"LargeScreenHTML\" of the InformationNugget class");
            fieldGeneratorHints = new HintsJSON.HoldingGenerator("field \"Hints\" of the InformationNugget class", false);
            fieldGeneratorEmotion = new EmotionJSON.HoldingGenerator("field \"Emotion\" of the InformationNugget class", false);
            fieldGeneratorIcon = new IconJSON.HoldingGenerator("field \"Icon\" of the InformationNugget class", false);
            fieldGeneratorUnderstandingConfidence = new JSONHoldingNumberTextGenerator("field \"UnderstandingConfidence\" of the InformationNugget class");
            fieldGeneratorOutputOverrideDiagnostics = new JSONHoldingStringArrayGenerator("field \"OutputOverrideDiagnostics\" of the InformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"NuggetKind\" of the InformationNugget class");
            set_what("the InformationNugget class");
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
            fieldGeneratorCombiningTemplateData.reset();
            fieldGeneratorPreview.reset();
            fieldGeneratorSmallScreenHTML.reset();
            fieldGeneratorLargeScreenHTML.reset();
            fieldGeneratorHints.reset();
            fieldGeneratorEmotion.reset();
            fieldGeneratorIcon.reset();
            fieldGeneratorUnderstandingConfidence.reset();
            fieldGeneratorOutputOverrideDiagnostics.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTemplateData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCombiningTemplateData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPreview.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHints.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEmotion.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorIcon.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTemplateData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCombiningTemplateData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPreview.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHints.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEmotion.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorIcon.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(InformationNuggetJSON  result)
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
        public InformationNuggetJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(InformationNuggetJSON  result)
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
    protected virtual void handle_result(List<InformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<InformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<InformationNuggetJSON>();
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
    public List<InformationNuggetJSON> value;
  };
    class GenericInformationNuggetJSON : InformationNuggetJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericInformationNuggetJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getNuggetKind()  { return key; }
        public override int extraInformationNuggetComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraInformationNuggetComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraInformationNuggetComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraInformationNuggetLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraInformationNuggetSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraInformationNuggetLookup(key);
            if (old_field == null)
              {
                extraInformationNuggetAppendPair(key, new_component);
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
    public static InformationNuggetJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'A':
            switch (key[1])
              {
                case 'l':
                    if ((String.Compare(key, 2, "arm", 0, 3, false) == 0) && (key.Length == 5))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("AlarmNuggetKind") ? other_field_index["AlarmNuggetKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `AlarmNuggetKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `AlarmNuggetKind' field has a non-string value.");
                        return AlarmInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'r':
                    switch (key[2])
                      {
                        case 'e':
                            if ((String.Compare(key, 3, "aCodeInfoNugget", 0, 15, false) == 0) && (key.Length == 18))
                              {
                                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("AreaCodeInfoNuggetKind") ? other_field_index["AreaCodeInfoNuggetKind"] : null));
                                if (key_value == null)
                                    throw new Exception("The `AreaCodeInfoNuggetKind' field is missing.");
                                JSONStringValue key_string_value = key_value.string_value();
                                if (key_string_value == null)
                                    throw new Exception("The `AreaCodeInfoNuggetKind' field has a non-string value.");
                                return AreaCodeInfoNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                              }
                            break;
                        case 'i':
                            if ((String.Compare(key, 3, "th", 0, 2, false) == 0) && (key.Length == 5))
                                return new ArithInformationNuggetJSON();
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'B':
            switch (key[1])
              {
                case 'a':
                    switch (key[2])
                      {
                        case 's':
                            if ((String.Compare(key, 3, "eConverter", 0, 10, false) == 0) && (key.Length == 13))
                                return new BaseConverterInformationNuggetJSON();
                            break;
                        case 't':
                            if ((String.Compare(key, 3, "tleshipQuit", 0, 11, false) == 0) && (key.Length == 14))
                                return new BattleshipQuitInformationNuggetJSON();
                            break;
                        default:
                            break;
                      }
                    break;
                case 'l':
                    if ((String.Compare(key, 2, "ackjack", 0, 7, false) == 0) && (key.Length == 9))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("BlackjackNuggetKind") ? other_field_index["BlackjackNuggetKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `BlackjackNuggetKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `BlackjackNuggetKind' field has a non-string value.");
                        return BlackjackInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'u':
                    if ((String.Compare(key, 2, "sinessInformationQueries", 0, 24, false) == 0) && (key.Length == 26))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("BusinessInformationQueriesNuggetKind") ? other_field_index["BusinessInformationQueriesNuggetKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `BusinessInformationQueriesNuggetKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `BusinessInformationQueriesNuggetKind' field has a non-string value.");
                        return BusinessInformationQueriesNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'C':
            switch (key[1])
              {
                case 'a':
                    switch (key[2])
                      {
                        case 'l':
                            if (String.Compare(key, 3, "endar", 0, 5, false) == 0)
                              {
                                switch (key[8])
                                  {
                                    case 'C':
                                        if ((String.Compare(key, 9, "learEventsInformationNugget", 0, 27, false) == 0) && (key.Length == 36))
                                            return new CalendarClearEventsInformationNuggetJSON();
                                        break;
                                    case 'U':
                                        if ((String.Compare(key, 9, "ploadEventsInformationNugget", 0, 28, false) == 0) && (key.Length == 37))
                                            return new CalendarUploadEventsInformationNuggetJSON();
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'n':
                            if ((String.Compare(key, 3, "celAddGuestsInformationNugget", 0, 29, false) == 0) && (key.Length == 32))
                                return new CancelAddGuestsInformationNuggetJSON();
                            break;
                        default:
                            break;
                      }
                    break;
                case 'h':
                    switch (key[2])
                      {
                        case 'e':
                            if (String.Compare(key, 3, "micalElement", 0, 12, false) == 0)
                              {
                                switch (key[15])
                                  {
                                    case 'G':
                                        if ((String.Compare(key, 16, "roupQueryInformationNugget", 0, 26, false) == 0) && (key.Length == 42))
                                            return new ChemicalElementGroupQueryInformationNuggetJSON();
                                        break;
                                    case 'Q':
                                        if ((String.Compare(key, 16, "ueryInformationNugget", 0, 21, false) == 0) && (key.Length == 37))
                                            return new ChemicalElementQueryInformationNuggetJSON();
                                        break;
                                    case 'S':
                                        if ((String.Compare(key, 16, "eriesQueryInformationNugget", 0, 27, false) == 0) && (key.Length == 43))
                                            return new ChemicalElementSeriesQueryInformationNuggetJSON();
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if ((String.Compare(key, 3, "neseZodiacInfoNugget", 0, 20, false) == 0) && (key.Length == 23))
                              {
                                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("ChineseZodiacInfoNuggetKind") ? other_field_index["ChineseZodiacInfoNuggetKind"] : null));
                                if (key_value == null)
                                    throw new Exception("The `ChineseZodiacInfoNuggetKind' field is missing.");
                                JSONStringValue key_string_value = key_value.string_value();
                                if (key_string_value == null)
                                    throw new Exception("The `ChineseZodiacInfoNuggetKind' field has a non-string value.");
                                return ChineseZodiacInfoNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'l':
                    if ((String.Compare(key, 2, "ientMatch", 0, 9, false) == 0) && (key.Length == 11))
                        return new ClientMatchInformationNuggetJSON();
                    break;
                case 'o':
                    if ((String.Compare(key, 2, "untryQueries", 0, 12, false) == 0) && (key.Length == 14))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("CountryQueriesNuggetKind") ? other_field_index["CountryQueriesNuggetKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `CountryQueriesNuggetKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `CountryQueriesNuggetKind' field has a non-string value.");
                        return CountryQueriesNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'u':
                    if ((String.Compare(key, 2, "rrencyConverter", 0, 15, false) == 0) && (key.Length == 17))
                        return new CurrencyConverterInformationNuggetJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'D':
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "teAndTime", 0, 9, false) == 0) && (key.Length == 11))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("DateAndTimeNuggetKind") ? other_field_index["DateAndTimeNuggetKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `DateAndTimeNuggetKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `DateAndTimeNuggetKind' field has a non-string value.");
                        return DateAndTimeInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'i':
                    switch (key[2])
                      {
                        case 'c':
                            if (String.Compare(key, 3, "tionary", 0, 7, false) == 0)
                              {
                                if (key.Length == 10)
                                  {
                                    return new DictionaryInformationNuggetJSON();
                                  }
                                switch (key[10])
                                  {
                                    case 'S':
                                        if ((String.Compare(key, 11, "earch", 0, 5, false) == 0) && (key.Length == 16))
                                            return new DictionarySearchInformationNuggetJSON();
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if ((String.Compare(key, 3, "hInformationNugget", 0, 18, false) == 0) && (key.Length == 21))
                                return new DishInformationNuggetJSON();
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'E':
            if ((String.Compare(key, 1, "quationSolverInformationNugget", 0, 30, false) == 0) && (key.Length == 31))
                return new EquationSolverInformationNuggetJSON();
            break;
        case 'F':
            if (String.Compare(key, 1, "light", 0, 5, false) == 0)
              {
                switch (key[6])
                  {
                    case 'B':
                        if ((String.Compare(key, 7, "ooking", 0, 6, false) == 0) && (key.Length == 13))
                            return new FlightBookingInformationNuggetJSON();
                        break;
                    case 'S':
                        if ((String.Compare(key, 7, "tatus", 0, 5, false) == 0) && (key.Length == 12))
                            return new FlightStatusInformationNuggetJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'G':
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "mesMenu", 0, 7, false) == 0) && (key.Length == 9))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("GamesMenuNuggetKind") ? other_field_index["GamesMenuNuggetKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `GamesMenuNuggetKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `GamesMenuNuggetKind' field has a non-string value.");
                        return GamesMenuInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'e':
                    switch (key[2])
                      {
                        case 'n':
                            if ((String.Compare(key, 3, "eralizedThing", 0, 13, false) == 0) && (key.Length == 16))
                              {
                                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("GeneralizedThingNuggetKind") ? other_field_index["GeneralizedThingNuggetKind"] : null));
                                if (key_value == null)
                                    throw new Exception("The `GeneralizedThingNuggetKind' field is missing.");
                                JSONStringValue key_string_value = key_value.string_value();
                                if (key_string_value == null)
                                    throw new Exception("The `GeneralizedThingNuggetKind' field has a non-string value.");
                                return GeneralizedThingInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                              }
                            break;
                        case 'o':
                            switch (key[3])
                              {
                                case 'm':
                                    if ((String.Compare(key, 4, "etryInfoNugget", 0, 14, false) == 0) && (key.Length == 18))
                                      {
                                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("GeometryInfoNuggetKind") ? other_field_index["GeometryInfoNuggetKind"] : null));
                                        if (key_value == null)
                                            throw new Exception("The `GeometryInfoNuggetKind' field is missing.");
                                        JSONStringValue key_string_value = key_value.string_value();
                                        if (key_string_value == null)
                                            throw new Exception("The `GeometryInfoNuggetKind' field has a non-string value.");
                                        return GeometryInfoNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                                      }
                                    break;
                                case 'n':
                                    if ((String.Compare(key, 4, "ameFacts", 0, 8, false) == 0) && (key.Length == 12))
                                        return new GeonameFactsInformationNuggetJSON();
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'H':
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "ngman", 0, 5, false) == 0) && (key.Length == 7))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("HangmanNuggetKind") ? other_field_index["HangmanNuggetKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `HangmanNuggetKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `HangmanNuggetKind' field has a non-string value.");
                        return HangmanInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'o':
                    switch (key[2])
                      {
                        case 'r':
                            if ((String.Compare(key, 3, "oscopesInformationNugget", 0, 24, false) == 0) && (key.Length == 27))
                              {
                                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("HoroscopesInformationNuggetKind") ? other_field_index["HoroscopesInformationNuggetKind"] : null));
                                if (key_value == null)
                                    throw new Exception("The `HoroscopesInformationNuggetKind' field is missing.");
                                JSONStringValue key_string_value = key_value.string_value();
                                if (key_string_value == null)
                                    throw new Exception("The `HoroscopesInformationNuggetKind' field has a non-string value.");
                                return HoroscopesInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                              }
                            break;
                        case 't':
                            if (String.Compare(key, 3, "el", 0, 2, false) == 0)
                              {
                                if (key.Length == 5)
                                  {
                                    return new HotelInformationNuggetJSON();
                                  }
                                switch (key[5])
                                  {
                                    case 'I':
                                        if ((String.Compare(key, 6, "ntentOnly", 0, 9, false) == 0) && (key.Length == 15))
                                            return new HotelIntentOnlyInformationNuggetJSON();
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
                default:
                    break;
              }
            break;
        case 'I':
            if ((String.Compare(key, 1, "HeartRadioInformationNugget", 0, 27, false) == 0) && (key.Length == 28))
              {
                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("IHeartRadioInformationNuggetKind") ? other_field_index["IHeartRadioInformationNuggetKind"] : null));
                if (key_value == null)
                    throw new Exception("The `IHeartRadioInformationNuggetKind' field is missing.");
                JSONStringValue key_string_value = key_value.string_value();
                if (key_string_value == null)
                    throw new Exception("The `IHeartRadioInformationNuggetKind' field has a non-string value.");
                return IHeartRadioInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
              }
            break;
        case 'L':
            if (String.Compare(key, 1, "o", 0, 1, false) == 0)
              {
                switch (key[2])
                  {
                    case 'c':
                        if ((String.Compare(key, 3, "alSearch", 0, 8, false) == 0) && (key.Length == 11))
                            return new LocalSearchInformationNuggetJSON();
                        break;
                    case 't':
                        if ((String.Compare(key, 3, "teryQueryInformationNugget", 0, 26, false) == 0) && (key.Length == 29))
                            return new LotteryQueryInformationNuggetJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'M':
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "p", 0, 1, false) == 0) && (key.Length == 3))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("MapNuggetKind") ? other_field_index["MapNuggetKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `MapNuggetKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `MapNuggetKind' field has a non-string value.");
                        return MapInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'o':
                    if ((String.Compare(key, 2, "rtgageCalculator", 0, 16, false) == 0) && (key.Length == 18))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("MortgageCalculatorNuggetKind") ? other_field_index["MortgageCalculatorNuggetKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `MortgageCalculatorNuggetKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `MortgageCalculatorNuggetKind' field has a non-string value.");
                        return MortgageCalculatorInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'u':
                    switch (key[2])
                      {
                        case 'l':
                            if (String.Compare(key, 3, "tipleChoiceQuiz", 0, 15, false) == 0)
                              {
                                switch (key[18])
                                  {
                                    case 'C':
                                        if ((String.Compare(key, 19, "urrentPlayer", 0, 12, false) == 0) && (key.Length == 31))
                                            return new MultipleChoiceQuizCurrentPlayerJSON();
                                        break;
                                    case 'R':
                                        if ((String.Compare(key, 19, "esponse", 0, 7, false) == 0) && (key.Length == 26))
                                            return new MultipleChoiceQuizResponseJSON();
                                        break;
                                    case 'S':
                                        if ((String.Compare(key, 19, "tatsResult", 0, 10, false) == 0) && (key.Length == 29))
                                            return new MultipleChoiceQuizStatsResultJSON();
                                        break;
                                    case 'W':
                                        if ((String.Compare(key, 19, "elcomeResponse", 0, 14, false) == 0) && (key.Length == 33))
                                            return new MultipleChoiceQuizWelcomeResponseJSON();
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if (String.Compare(key, 3, "ic", 0, 2, false) == 0)
                              {
                                if (key.Length == 5)
                                  {
                                  {
                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("MusicNuggetKind") ? other_field_index["MusicNuggetKind"] : null));
                                    if (key_value == null)
                                        throw new Exception("The `MusicNuggetKind' field is missing.");
                                    JSONStringValue key_string_value = key_value.string_value();
                                    if (key_string_value == null)
                                        throw new Exception("The `MusicNuggetKind' field has a non-string value.");
                                    return MusicInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                                  }
                                  }
                                switch (key[5])
                                  {
                                    case 'T':
                                        if ((String.Compare(key, 6, "heoryInfoNugget", 0, 15, false) == 0) && (key.Length == 21))
                                          {
                                            JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("MusicTheoryInfoNuggetKind") ? other_field_index["MusicTheoryInfoNuggetKind"] : null));
                                            if (key_value == null)
                                                throw new Exception("The `MusicTheoryInfoNuggetKind' field is missing.");
                                            JSONStringValue key_string_value = key_value.string_value();
                                            if (key_string_value == null)
                                                throw new Exception("The `MusicTheoryInfoNuggetKind' field has a non-string value.");
                                            return MusicTheoryInfoNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
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
                default:
                    break;
              }
            break;
        case 'N':
            switch (key[1])
              {
                case 'o':
                    switch (key[2])
                      {
                        case 'G':
                            if ((String.Compare(key, 3, "roupChemicalElementQueryInformationNugget", 0, 41, false) == 0) && (key.Length == 44))
                                return new NoGroupChemicalElementQueryInformationNuggetJSON();
                            break;
                        case 'S':
                            if ((String.Compare(key, 3, "eriesChemicalElementQueryInformationNugget", 0, 42, false) == 0) && (key.Length == 45))
                                return new NoSeriesChemicalElementQueryInformationNuggetJSON();
                            break;
                        default:
                            break;
                      }
                    break;
                case 'u':
                    switch (key[2])
                      {
                        case 'm':
                            if (String.Compare(key, 3, "ber", 0, 3, false) == 0)
                              {
                                switch (key[6])
                                  {
                                    case 'F':
                                        if ((String.Compare(key, 7, "actsInformationNuggets", 0, 22, false) == 0) && (key.Length == 29))
                                            return new NumberFactsInfoNuggetJSON();
                                        break;
                                    case 'G':
                                        if ((String.Compare(key, 7, "uess", 0, 4, false) == 0) && (key.Length == 11))
                                          {
                                            JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("NumberGuessNuggetKind") ? other_field_index["NumberGuessNuggetKind"] : null));
                                            if (key_value == null)
                                                throw new Exception("The `NumberGuessNuggetKind' field is missing.");
                                            JSONStringValue key_string_value = key_value.string_value();
                                            if (key_string_value == null)
                                                throw new Exception("The `NumberGuessNuggetKind' field has a non-string value.");
                                            return NumberGuessInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 't':
                            if ((String.Compare(key, 3, "rition", 0, 6, false) == 0) && (key.Length == 9))
                                return new NutritionInformationNuggetJSON();
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'P':
            switch (key[1])
              {
                case 'e':
                    if ((String.Compare(key, 2, "rsonQueries", 0, 11, false) == 0) && (key.Length == 13))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("PersonQueriesNuggetKind") ? other_field_index["PersonQueriesNuggetKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `PersonQueriesNuggetKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `PersonQueriesNuggetKind' field has a non-string value.");
                        return PersonQueriesNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'l':
                    if ((String.Compare(key, 2, "anet", 0, 4, false) == 0) && (key.Length == 6))
                        return new PlanetInformationNuggetJSON();
                    break;
                case 'r':
                    if ((String.Compare(key, 2, "opertyValue", 0, 11, false) == 0) && (key.Length == 13))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("PropertyValueKind") ? other_field_index["PropertyValueKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `PropertyValueKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `PropertyValueKind' field has a non-string value.");
                        return PropertyValueInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'R':
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "ndomNumberGenerator", 0, 19, false) == 0) && (key.Length == 21))
                        return new RandomNumberGeneratorInformationNuggetJSON();
                    break;
                case 'e':
                    if (String.Compare(key, 2, "cipe", 0, 4, false) == 0)
                      {
                        switch (key[6])
                          {
                            case 'A':
                                if (String.Compare(key, 7, "id", 0, 2, false) == 0)
                                  {
                                    if (key.Length == 9)
                                      {
                                      {
                                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("RecipeAidNuggetKind") ? other_field_index["RecipeAidNuggetKind"] : null));
                                        if (key_value == null)
                                            throw new Exception("The `RecipeAidNuggetKind' field is missing.");
                                        JSONStringValue key_string_value = key_value.string_value();
                                        if (key_string_value == null)
                                            throw new Exception("The `RecipeAidNuggetKind' field has a non-string value.");
                                        return RecipeAidInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                                      }
                                      }
                                    switch (key[9])
                                      {
                                        case 'I':
                                            if ((String.Compare(key, 10, "ngredientSubstitution", 0, 21, false) == 0) && (key.Length == 31))
                                                return new RecipeAidIngredientSubstitutionInformationNuggetJSON();
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'S':
                                if ((String.Compare(key, 7, "earchResultInfoNugget", 0, 21, false) == 0) && (key.Length == 28))
                                    return new RecipeSearchResultInfoNuggetJSON();
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'i':
                    if (String.Compare(key, 2, "vers", 0, 4, false) == 0)
                      {
                        switch (key[6])
                          {
                            case 'B':
                                if ((String.Compare(key, 7, "yLocationInformationNugget", 0, 26, false) == 0) && (key.Length == 33))
                                    return new RiversByLocationInformationNuggetJSON();
                                break;
                            case 'I':
                                if ((String.Compare(key, 7, "nfoInformationNugget", 0, 20, false) == 0) && (key.Length == 27))
                                    return new RiversInfoInformationNuggetJSON();
                                break;
                            case 'L':
                                if ((String.Compare(key, 7, "istInformationNugget", 0, 20, false) == 0) && (key.Length == 27))
                                    return new RiversListInformationNuggetJSON();
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'o':
                    if ((String.Compare(key, 2, "ckPaperScissors", 0, 15, false) == 0) && (key.Length == 17))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("RockPaperScissorsNuggetKind") ? other_field_index["RockPaperScissorsNuggetKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `RockPaperScissorsNuggetKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `RockPaperScissorsNuggetKind' field has a non-string value.");
                        return RockPaperScissorsInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'S':
            switch (key[1])
              {
                case 'h':
                    if ((String.Compare(key, 2, "owContact", 0, 9, false) == 0) && (key.Length == 11))
                        return new ShowContactNuggetJSON();
                    break;
                case 'm':
                    if ((String.Compare(key, 2, "allTalk", 0, 7, false) == 0) && (key.Length == 9))
                        return new SmallTalkInformationNuggetJSON();
                    break;
                case 'p':
                    if (String.Compare(key, 2, "orts", 0, 4, false) == 0)
                      {
                        if (key.Length == 6)
                          {
                          {
                            JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("SportsNuggetKind") ? other_field_index["SportsNuggetKind"] : null));
                            if (key_value == null)
                                throw new Exception("The `SportsNuggetKind' field is missing.");
                            JSONStringValue key_string_value = key_value.string_value();
                            if (key_string_value == null)
                                throw new Exception("The `SportsNuggetKind' field has a non-string value.");
                            return SportsInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                          }
                          }
                        switch (key[6])
                          {
                            case 'O':
                                if ((String.Compare(key, 7, "lympicsInformationNugget", 0, 24, false) == 0) && (key.Length == 31))
                                  {
                                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("SportsOlympicsInformationNuggetKind") ? other_field_index["SportsOlympicsInformationNuggetKind"] : null));
                                    if (key_value == null)
                                        throw new Exception("The `SportsOlympicsInformationNuggetKind' field is missing.");
                                    JSONStringValue key_string_value = key_value.string_value();
                                    if (key_string_value == null)
                                        throw new Exception("The `SportsOlympicsInformationNuggetKind' field has a non-string value.");
                                    return SportsOlympicsInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 't':
                    if ((String.Compare(key, 2, "ockMarket", 0, 9, false) == 0) && (key.Length == 11))
                        return new StockMarketInformationNuggetJSON();
                    break;
                case 'u':
                    if ((String.Compare(key, 2, "ggestedRadio", 0, 12, false) == 0) && (key.Length == 14))
                        return new RadioSuggestionInformationNuggetJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'T':
            switch (key[1])
              {
                case 'a':
                    if (String.Compare(key, 2, "sklist", 0, 6, false) == 0)
                      {
                        switch (key[8])
                          {
                            case 'A':
                                if ((String.Compare(key, 9, "llListsNugget", 0, 13, false) == 0) && (key.Length == 22))
                                    return new TasklistAllListsNuggetJSON();
                                break;
                            case 'L':
                                if (String.Compare(key, 9, "ist", 0, 3, false) == 0)
                                  {
                                    switch (key[12])
                                      {
                                        case 'E':
                                            if ((String.Compare(key, 13, "ntryNugget", 0, 10, false) == 0) && (key.Length == 23))
                                                return new TasklistListEntryNuggetJSON();
                                            break;
                                        case 'N':
                                            if ((String.Compare(key, 13, "ugget", 0, 5, false) == 0) && (key.Length == 18))
                                                return new TasklistListNuggetJSON();
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
                case 'h':
                    if ((String.Compare(key, 2, "irdPartyCalendarInformationNugget", 0, 33, false) == 0) && (key.Length == 35))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("ThirdPartyCalendarInformationNuggetType") ? other_field_index["ThirdPartyCalendarInformationNuggetType"] : null));
                        if (key_value == null)
                            throw new Exception("The `ThirdPartyCalendarInformationNuggetType' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `ThirdPartyCalendarInformationNuggetType' field has a non-string value.");
                        return ThirdPartyCalendarInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'i':
                    switch (key[2])
                      {
                        case 'm':
                            if ((String.Compare(key, 3, "er", 0, 2, false) == 0) && (key.Length == 5))
                              {
                                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("TimerNuggetKind") ? other_field_index["TimerNuggetKind"] : null));
                                if (key_value == null)
                                    throw new Exception("The `TimerNuggetKind' field is missing.");
                                JSONStringValue key_string_value = key_value.string_value();
                                if (key_string_value == null)
                                    throw new Exception("The `TimerNuggetKind' field has a non-string value.");
                                return TimerInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                              }
                            break;
                        case 'p':
                            if ((String.Compare(key, 3, "CalculatorCancel", 0, 16, false) == 0) && (key.Length == 19))
                                return new TipCalculatorCancelInformationNuggetJSON();
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'U':
            switch (key[1])
              {
                case 'b':
                    if ((String.Compare(key, 2, "er", 0, 2, false) == 0) && (key.Length == 4))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("UberNuggetKind") ? other_field_index["UberNuggetKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `UberNuggetKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `UberNuggetKind' field has a non-string value.");
                        return UberInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'n':
                    switch (key[2])
                      {
                        case 'i':
                            if ((String.Compare(key, 3, "tConverter", 0, 10, false) == 0) && (key.Length == 13))
                                return new UnitConverterInformationNuggetJSON();
                            break;
                        case 'k':
                            if (String.Compare(key, 3, "nownChemicalElement", 0, 19, false) == 0)
                              {
                                switch (key[22])
                                  {
                                    case 'G':
                                        if ((String.Compare(key, 23, "roupQueryInformationNugget", 0, 26, false) == 0) && (key.Length == 49))
                                            return new UnknownChemicalElementGroupQueryInformationNuggetJSON();
                                        break;
                                    case 'Q':
                                        if ((String.Compare(key, 23, "ueryInformationNugget", 0, 21, false) == 0) && (key.Length == 44))
                                            return new UnknownChemicalElementQueryInformationNuggetJSON();
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
                case 's':
                    if ((String.Compare(key, 2, "erMemory", 0, 8, false) == 0) && (key.Length == 10))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("UserMemoryNuggetKind") ? other_field_index["UserMemoryNuggetKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `UserMemoryNuggetKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `UserMemoryNuggetKind' field has a non-string value.");
                        return UserMemoryNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'W':
            switch (key[1])
              {
                case 'e':
                    switch (key[2])
                      {
                        case 'a':
                            if ((String.Compare(key, 3, "ther", 0, 4, false) == 0) && (key.Length == 7))
                              {
                                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("WeatherNuggetKind") ? other_field_index["WeatherNuggetKind"] : null));
                                if (key_value == null)
                                    throw new Exception("The `WeatherNuggetKind' field is missing.");
                                JSONStringValue key_string_value = key_value.string_value();
                                if (key_string_value == null)
                                    throw new Exception("The `WeatherNuggetKind' field has a non-string value.");
                                return WeatherInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                              }
                            break;
                        case 's':
                            if ((String.Compare(key, 3, "ternAstrologyInformationNugget", 0, 30, false) == 0) && (key.Length == 33))
                              {
                                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("WesternAstrologyInformationNuggetKind") ? other_field_index["WesternAstrologyInformationNuggetKind"] : null));
                                if (key_value == null)
                                    throw new Exception("The `WesternAstrologyInformationNuggetKind' field is missing.");
                                JSONStringValue key_string_value = key_value.string_value();
                                if (key_string_value == null)
                                    throw new Exception("The `WesternAstrologyInformationNuggetKind' field has a non-string value.");
                                return WesternAstrologyInformationNuggetJSON.createForKey(key_string_value.getData(), other_field_index);
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'h':
                    if (String.Compare(key, 2, "at", 0, 2, false) == 0)
                      {
                        switch (key[4])
                          {
                            case 'D':
                                if ((String.Compare(key, 5, "rinkCanMakeNugget", 0, 17, false) == 0) && (key.Length == 22))
                                    return new WhatDrinkCanMakeQuestionJSON();
                                break;
                            case 's':
                                if ((String.Compare(key, 5, "InDrinkNugget", 0, 13, false) == 0) && (key.Length == 18))
                                    return new WhatsInDrinkQuestionJSON();
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'i':
                    if ((String.Compare(key, 2, "kipedia", 0, 7, false) == 0) && (key.Length == 9))
                        return new WikipediaInformationNuggetJSON();
                    break;
                default:
                    break;
              }
            break;
        default:
            break;
      }

        return new GenericInformationNuggetJSON(key);
      }
  };
