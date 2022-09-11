/* file "DynamicResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DynamicResponseJSON : JSONBase
  {
    public enum TypeViewType
      {
        ViewType_Native,
        ViewType_Template,
        ViewType_HTML,
        ViewType_None,
        ViewType_Error
      };

    public static TypeViewType  stringToViewType(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if ((String.Compare(chars, 1, "rror", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeViewType.ViewType_Error;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "TML", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeViewType.ViewType_HTML;
                break;
            case 'N':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "tive", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeViewType.ViewType_Native;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "ne", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeViewType.ViewType_None;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(chars, 1, "emplate", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeViewType.ViewType_Template;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `ViewType' is not one of the legal values.");
      }

    public static string  stringFromViewType(TypeViewType the_enum)
      {
        switch (the_enum)
          {
            case TypeViewType.ViewType_Native:
                return "Native";
            case TypeViewType.ViewType_Template:
                return "Template";
            case TypeViewType.ViewType_HTML:
                return "HTML";
            case TypeViewType.ViewType_None:
                return "None";
            case TypeViewType.ViewType_Error:
                return "Error";
            default:
                Debug.Assert(false);
                return null;
          }
      }

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
    private bool flagHasAutoListen;
    private bool storeAutoListen;
    private bool flagHasUserVisibleMode;
    private string storeUserVisibleMode;
    private bool flagHasConversationState;
    private ConversationStateJSON  storeConversationState;
    private bool flagHasViewType;
    private List< TypeViewType > storeViewType;
    private bool flagHasTemplateName;
    private string storeTemplateName;
    private bool flagHasTemplateData;
    private TemplateJSON  storeTemplateData;
    private bool flagHasCombiningTemplateData;
    private TemplateJSON  storeCombiningTemplateData;
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
    private bool flagHasResponseAudioURL;
    private string storeResponseAudioURL;
    private bool flagHasResponseAudioError;
    private string storeResponseAudioError;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSpokenResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponse of DynamicResponseJSON is not a string.");
        setSpokenResponse(json_string.getData());
      }


    private void  fromJSONSpokenResponseLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseLong of DynamicResponseJSON is not a string.");
        setSpokenResponseLong(json_string.getData());
      }


    private void  fromJSONWrittenResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenResponse of DynamicResponseJSON is not a string.");
        setWrittenResponse(json_string.getData());
      }


    private void  fromJSONWrittenResponseLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenResponseLong of DynamicResponseJSON is not a string.");
        setWrittenResponseLong(json_string.getData());
      }


    private void  fromJSONSpokenResponseSSML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseSSML of DynamicResponseJSON is not a string.");
        setSpokenResponseSSML(json_string.getData());
      }


    private void  fromJSONSpokenResponseSSMLLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseSSMLLong of DynamicResponseJSON is not a string.");
        setSpokenResponseSSMLLong(json_string.getData());
      }


    private void  fromJSONAutoListen(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AutoListen of DynamicResponseJSON is not true for false.");
              }
          }
        setAutoListen(the_bool);
      }


    private void  fromJSONUserVisibleMode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UserVisibleMode of DynamicResponseJSON is not a string.");
        setUserVisibleMode(json_string.getData());
      }


    private void  fromJSONConversationState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ConversationStateJSON convert_classy = ConversationStateJSON.from_json(json_value, ignore_extras, true);
        setConversationState(convert_classy);
      }


    private void  fromJSONViewType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ViewType of DynamicResponseJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeViewType > vector_ViewType1 = new List< TypeViewType >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ViewType of DynamicResponseJSON is not a string.");
            TypeViewType the_enum;
            switch (json_string.getData()[0])
              {
                case 'E':
                    if ((String.Compare(json_string.getData(), 1, "rror", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeViewType.ViewType_Error;
                            goto enum_is_done;
                          }
                    break;
                case 'H':
                    if ((String.Compare(json_string.getData(), 1, "TML", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypeViewType.ViewType_HTML;
                            goto enum_is_done;
                          }
                    break;
                case 'N':
                    switch (json_string.getData()[1])
                      {
                        case 'a':
                            if ((String.Compare(json_string.getData(), 2, "tive", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_enum = TypeViewType.ViewType_Native;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'o':
                            if ((String.Compare(json_string.getData(), 2, "ne", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                                  {
                                    the_enum = TypeViewType.ViewType_None;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(json_string.getData(), 1, "emplate", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_enum = TypeViewType.ViewType_Template;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for an element of field ViewType of DynamicResponseJSON is not one of the legal strings.");
          enum_is_done:;
            vector_ViewType1.Add(the_enum);
          }
        initViewType();
        for (int num1 = 0; num1 < vector_ViewType1.Count; ++num1)
            appendViewType(vector_ViewType1[num1]);
        for (int num1 = 0; num1 < vector_ViewType1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTemplateName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TemplateName of DynamicResponseJSON is not a string.");
        setTemplateName(json_string.getData());
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


    private void  fromJSONSmallScreenHTML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SmallScreenHTML of DynamicResponseJSON is not a string.");
        setSmallScreenHTML(json_string.getData());
      }


    private void  fromJSONLargeScreenHTML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LargeScreenHTML of DynamicResponseJSON is not a string.");
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
            throw new Exception("The value for field ResponseAudioBytes of DynamicResponseJSON is not a string.");
        setResponseAudioBytes(json_string.getData());
      }


    private void  fromJSONResponseAudioURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResponseAudioURL of DynamicResponseJSON is not a string.");
        setResponseAudioURL(json_string.getData());
      }


    private void  fromJSONResponseAudioError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResponseAudioError of DynamicResponseJSON is not a string.");
        setResponseAudioError(json_string.getData());
      }


    public DynamicResponseJSON()
      {
        flagHasSpokenResponse = false;
        flagHasSpokenResponseLong = false;
        flagHasWrittenResponse = false;
        flagHasWrittenResponseLong = false;
        flagHasSpokenResponseSSML = false;
        flagHasSpokenResponseSSMLLong = false;
        flagHasAutoListen = false;
        flagHasUserVisibleMode = false;
        flagHasConversationState = false;
        flagHasViewType = false;
        flagHasTemplateName = false;
        flagHasTemplateData = false;
        flagHasCombiningTemplateData = false;
        flagHasSmallScreenHTML = false;
        flagHasLargeScreenHTML = false;
        flagHasHints = false;
        flagHasEmotion = false;
        flagHasIcon = false;
        flagHasResponseAudioBytes = false;
        flagHasResponseAudioURL = false;
        flagHasResponseAudioError = false;
        storeAutoListen = false;
        storeViewType = new List< TypeViewType >();
        TypeViewType element2;
        element2 = TypeViewType.ViewType_Native;
        storeViewType.Add(element2);
        TypeViewType element3;
        element3 = TypeViewType.ViewType_Template;
        storeViewType.Add(element3);
        TypeViewType element4;
        element4 = TypeViewType.ViewType_HTML;
        storeViewType.Add(element4);
        TypeViewType element5;
        element5 = TypeViewType.ViewType_None;
        storeViewType.Add(element5);
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

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

    public bool  hasAutoListen()
      {
        return flagHasAutoListen;
      }

    public bool  getAutoListen()
      {
        return storeAutoListen;
      }

    public bool  hasUserVisibleMode()
      {
        return flagHasUserVisibleMode;
      }

    public string  getUserVisibleMode()
      {
        Debug.Assert(flagHasUserVisibleMode);
        return storeUserVisibleMode;
      }

    public bool  hasConversationState()
      {
        return flagHasConversationState;
      }

    public ConversationStateJSON   getConversationState()
      {
        Debug.Assert(flagHasConversationState);
        return storeConversationState;
      }

    public bool  hasViewType()
      {
        return flagHasViewType;
      }

    public int  countOfViewType()
      {
        return storeViewType.Count;
      }

    public TypeViewType  elementOfViewType(int element_num)
      {
        return storeViewType[element_num];
      }

    public List< TypeViewType >  getViewType()
      {
        return storeViewType;
      }

    public bool  hasTemplateName()
      {
        return flagHasTemplateName;
      }

    public string  getTemplateName()
      {
        Debug.Assert(flagHasTemplateName);
        return storeTemplateName;
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

    public bool  hasResponseAudioURL()
      {
        return flagHasResponseAudioURL;
      }

    public string  getResponseAudioURL()
      {
        Debug.Assert(flagHasResponseAudioURL);
        return storeResponseAudioURL;
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


    public virtual int extraDynamicResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDynamicResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDynamicResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDynamicResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

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
    public void setAutoListen(bool new_value)
      {
        flagHasAutoListen = true;
        storeAutoListen = new_value;
      }
    public void unsetAutoListen()
      {
        flagHasAutoListen = false;
      }
    public void setUserVisibleMode(string new_value)
      {
        flagHasUserVisibleMode = true;
        storeUserVisibleMode = new_value;
      }
    public void unsetUserVisibleMode()
      {
        flagHasUserVisibleMode = false;
      }
    public void setConversationState(ConversationStateJSON  new_value)
      {
        if (flagHasConversationState)
          {
          }
        flagHasConversationState = true;
        storeConversationState = new_value;
      }
    public void unsetConversationState()
      {
        if (flagHasConversationState)
          {
          }
        flagHasConversationState = false;
      }
    public void initViewType()
      {
        flagHasViewType = true;
        storeViewType.Clear();
      }
    public void appendViewType(TypeViewType to_append)
      {
        if (!flagHasViewType)
          {
            flagHasViewType = true;
            storeViewType.Clear();
          }
        Debug.Assert(flagHasViewType);
        storeViewType.Add(to_append);
      }
    public void appendViewType(string chars)
      {
        appendViewType(stringToViewType(chars));
      }
    public void unsetViewType()
      {
        flagHasViewType = false;
        storeViewType.Clear();
      }
    public void setTemplateName(string new_value)
      {
        flagHasTemplateName = true;
        storeTemplateName = new_value;
      }
    public void unsetTemplateName()
      {
        flagHasTemplateName = false;
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
    public void setResponseAudioURL(string new_value)
      {
        flagHasResponseAudioURL = true;
        storeResponseAudioURL = new_value;
      }
    public void unsetResponseAudioURL()
      {
        flagHasResponseAudioURL = false;
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

    public virtual void extraDynamicResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDynamicResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDynamicResponseLookup(key);
        if (old_field == null)
          {
            extraDynamicResponseAppendPair(key, new_component);
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
        if (flagHasAutoListen)
          {
            handler.start_pair("AutoListen");
            handler.boolean_value(storeAutoListen);
          }
        if (flagHasUserVisibleMode)
          {
            handler.start_pair("UserVisibleMode");
            handler.string_value(storeUserVisibleMode);
          }
        if (flagHasConversationState)
          {
            handler.start_pair("ConversationState");
            if (partial_allowed)
                storeConversationState.write_partial_as_json(handler);
            else
                storeConversationState.write_as_json(handler);
          }
        if (flagHasViewType)
          {
            handler.start_pair("ViewType");
            handler.start_array();
            for (int num1 = 0; num1 < storeViewType.Count; ++num1)
              {
                switch (storeViewType[num1])
                  {
                    case TypeViewType.ViewType_Native:
                        handler.string_value("Native");
                        break;
                    case TypeViewType.ViewType_Template:
                        handler.string_value("Template");
                        break;
                    case TypeViewType.ViewType_HTML:
                        handler.string_value("HTML");
                        break;
                    case TypeViewType.ViewType_None:
                        handler.string_value("None");
                        break;
                    case TypeViewType.ViewType_Error:
                        handler.string_value("Error");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            handler.finish_array();
          }
        if (flagHasTemplateName)
          {
            handler.start_pair("TemplateName");
            handler.string_value(storeTemplateName);
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
        if (flagHasResponseAudioURL)
          {
            handler.start_pair("ResponseAudioURL");
            handler.string_value(storeResponseAudioURL);
          }
        if (flagHasResponseAudioError)
          {
            handler.start_pair("ResponseAudioError");
            handler.string_value(storeResponseAudioError);
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

    public static DynamicResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DynamicResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DynamicResponse", ignore_extras);
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
    public static DynamicResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DynamicResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DynamicResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DynamicResponse", ignore_extras);
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
    public static DynamicResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DynamicResponseJSON from_text(string text, bool ignore_extras)
      {
        DynamicResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DynamicResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DynamicResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DynamicResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DynamicResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DynamicResponse", ignore_extras);
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
        private JSONHoldingBooleanGenerator fieldGeneratorAutoListen;
        private JSONHoldingStringGenerator fieldGeneratorUserVisibleMode;
        private ConversationStateJSON.HoldingGenerator fieldGeneratorConversationState;
    private abstract class FieldGeneratorViewType : JSONStringGenerator
          {
            protected FieldGeneratorViewType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorViewType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToViewType(result));
              }
            protected abstract void handle_result(TypeViewType result);
          };
    private class FieldHoldingGeneratorViewType : FieldGeneratorViewType
  {
    protected override void handle_result(TypeViewType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorViewType(String what)
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
    public TypeViewType value;
  };
    private class FieldHoldingArrayGeneratorViewType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorViewType
      {
        private FieldHoldingArrayGeneratorViewType top;

        protected override void handle_result(TypeViewType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorViewType init_top)
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
    protected virtual void handle_result(List<TypeViewType> result)
      {
      }

    public FieldHoldingArrayGeneratorViewType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeViewType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorViewType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeViewType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeViewType> value;
  };
        private FieldHoldingArrayGeneratorViewType fieldGeneratorViewType;
        private JSONHoldingStringGenerator fieldGeneratorTemplateName;
        private TemplateJSON.HoldingGenerator fieldGeneratorTemplateData;
        private TemplateJSON.HoldingGenerator fieldGeneratorCombiningTemplateData;
        private JSONHoldingStringGenerator fieldGeneratorSmallScreenHTML;
        private JSONHoldingStringGenerator fieldGeneratorLargeScreenHTML;
        private HintsJSON.HoldingGenerator fieldGeneratorHints;
        private EmotionJSON.HoldingGenerator fieldGeneratorEmotion;
        private IconJSON.HoldingGenerator fieldGeneratorIcon;
        private JSONHoldingStringGenerator fieldGeneratorResponseAudioBytes;
        private JSONHoldingStringGenerator fieldGeneratorResponseAudioURL;
        private JSONHoldingStringGenerator fieldGeneratorResponseAudioError;
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
            DynamicResponseJSON result = new DynamicResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDynamicResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DynamicResponseJSON result)
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
            if (fieldGeneratorAutoListen.have_value)
              {
                result.setAutoListen(fieldGeneratorAutoListen.value);
                fieldGeneratorAutoListen.have_value = false;
              }
            if (fieldGeneratorUserVisibleMode.have_value)
              {
                result.setUserVisibleMode(fieldGeneratorUserVisibleMode.value);
                fieldGeneratorUserVisibleMode.have_value = false;
              }
            if (fieldGeneratorConversationState.have_value)
              {
                result.setConversationState(fieldGeneratorConversationState.value);
                fieldGeneratorConversationState.have_value = false;
              }
            if (fieldGeneratorViewType.have_value)
              {
                result.initViewType();
                int count = fieldGeneratorViewType.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendViewType(fieldGeneratorViewType.value[num]);
                  }
                fieldGeneratorViewType.value.Clear();
                fieldGeneratorViewType.have_value = false;
              }
            if (fieldGeneratorTemplateName.have_value)
              {
                result.setTemplateName(fieldGeneratorTemplateName.value);
                fieldGeneratorTemplateName.have_value = false;
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
            if (fieldGeneratorResponseAudioURL.have_value)
              {
                result.setResponseAudioURL(fieldGeneratorResponseAudioURL.value);
                fieldGeneratorResponseAudioURL.have_value = false;
              }
            if (fieldGeneratorResponseAudioError.have_value)
              {
                result.setResponseAudioError(fieldGeneratorResponseAudioError.value);
                fieldGeneratorResponseAudioError.have_value = false;
              }
          }
        protected abstract void handle_result(DynamicResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "utoListen", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorAutoListen;
                    break;
                case 'C':
                    if (String.Compare(field_name, 1, "o", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'm':
                                if ((String.Compare(field_name, 3, "biningTemplateData", 0, 18, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorCombiningTemplateData;
                                break;
                            case 'n':
                                if ((String.Compare(field_name, 3, "versationState", 0, 14, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorConversationState;
                                break;
                            default:
                                break;
                          }
                      }
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
                case 'R':
                    if (String.Compare(field_name, 1, "esponseAudio", 0, 12, false) == 0)
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
                            case 'U':
                                if ((String.Compare(field_name, 14, "RL", 0, 2, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorResponseAudioURL;
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
                    if (String.Compare(field_name, 1, "emplate", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 9, "ata", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorTemplateData;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 9, "ame", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorTemplateName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serVisibleMode", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorUserVisibleMode;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "iewType", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorViewType;
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
            fieldGeneratorSpokenResponse = new JSONHoldingStringGenerator("field \"SpokenResponse\" of the DynamicResponse class");
            fieldGeneratorSpokenResponseLong = new JSONHoldingStringGenerator("field \"SpokenResponseLong\" of the DynamicResponse class");
            fieldGeneratorWrittenResponse = new JSONHoldingStringGenerator("field \"WrittenResponse\" of the DynamicResponse class");
            fieldGeneratorWrittenResponseLong = new JSONHoldingStringGenerator("field \"WrittenResponseLong\" of the DynamicResponse class");
            fieldGeneratorSpokenResponseSSML = new JSONHoldingStringGenerator("field \"SpokenResponseSSML\" of the DynamicResponse class");
            fieldGeneratorSpokenResponseSSMLLong = new JSONHoldingStringGenerator("field \"SpokenResponseSSMLLong\" of the DynamicResponse class");
            fieldGeneratorAutoListen = new JSONHoldingBooleanGenerator("field \"AutoListen\" of the DynamicResponse class");
            fieldGeneratorUserVisibleMode = new JSONHoldingStringGenerator("field \"UserVisibleMode\" of the DynamicResponse class");
            fieldGeneratorConversationState = new ConversationStateJSON.HoldingGenerator("field \"ConversationState\" of the DynamicResponse class", ignore_extras);
            fieldGeneratorViewType = new FieldHoldingArrayGeneratorViewType("field \"ViewType\" of the DynamicResponse class");
            fieldGeneratorTemplateName = new JSONHoldingStringGenerator("field \"TemplateName\" of the DynamicResponse class");
            fieldGeneratorTemplateData = new TemplateJSON.HoldingGenerator("field \"TemplateData\" of the DynamicResponse class", ignore_extras);
            fieldGeneratorCombiningTemplateData = new TemplateJSON.HoldingGenerator("field \"CombiningTemplateData\" of the DynamicResponse class", ignore_extras);
            fieldGeneratorSmallScreenHTML = new JSONHoldingStringGenerator("field \"SmallScreenHTML\" of the DynamicResponse class");
            fieldGeneratorLargeScreenHTML = new JSONHoldingStringGenerator("field \"LargeScreenHTML\" of the DynamicResponse class");
            fieldGeneratorHints = new HintsJSON.HoldingGenerator("field \"Hints\" of the DynamicResponse class", ignore_extras);
            fieldGeneratorEmotion = new EmotionJSON.HoldingGenerator("field \"Emotion\" of the DynamicResponse class", ignore_extras);
            fieldGeneratorIcon = new IconJSON.HoldingGenerator("field \"Icon\" of the DynamicResponse class", ignore_extras);
            fieldGeneratorResponseAudioBytes = new JSONHoldingStringGenerator("field \"ResponseAudioBytes\" of the DynamicResponse class");
            fieldGeneratorResponseAudioURL = new JSONHoldingStringGenerator("field \"ResponseAudioURL\" of the DynamicResponse class");
            fieldGeneratorResponseAudioError = new JSONHoldingStringGenerator("field \"ResponseAudioError\" of the DynamicResponse class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DynamicResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpokenResponse = new JSONHoldingStringGenerator("field \"SpokenResponse\" of the DynamicResponse class");
            fieldGeneratorSpokenResponseLong = new JSONHoldingStringGenerator("field \"SpokenResponseLong\" of the DynamicResponse class");
            fieldGeneratorWrittenResponse = new JSONHoldingStringGenerator("field \"WrittenResponse\" of the DynamicResponse class");
            fieldGeneratorWrittenResponseLong = new JSONHoldingStringGenerator("field \"WrittenResponseLong\" of the DynamicResponse class");
            fieldGeneratorSpokenResponseSSML = new JSONHoldingStringGenerator("field \"SpokenResponseSSML\" of the DynamicResponse class");
            fieldGeneratorSpokenResponseSSMLLong = new JSONHoldingStringGenerator("field \"SpokenResponseSSMLLong\" of the DynamicResponse class");
            fieldGeneratorAutoListen = new JSONHoldingBooleanGenerator("field \"AutoListen\" of the DynamicResponse class");
            fieldGeneratorUserVisibleMode = new JSONHoldingStringGenerator("field \"UserVisibleMode\" of the DynamicResponse class");
            fieldGeneratorConversationState = new ConversationStateJSON.HoldingGenerator("field \"ConversationState\" of the DynamicResponse class", false);
            fieldGeneratorViewType = new FieldHoldingArrayGeneratorViewType("field \"ViewType\" of the DynamicResponse class");
            fieldGeneratorTemplateName = new JSONHoldingStringGenerator("field \"TemplateName\" of the DynamicResponse class");
            fieldGeneratorTemplateData = new TemplateJSON.HoldingGenerator("field \"TemplateData\" of the DynamicResponse class", false);
            fieldGeneratorCombiningTemplateData = new TemplateJSON.HoldingGenerator("field \"CombiningTemplateData\" of the DynamicResponse class", false);
            fieldGeneratorSmallScreenHTML = new JSONHoldingStringGenerator("field \"SmallScreenHTML\" of the DynamicResponse class");
            fieldGeneratorLargeScreenHTML = new JSONHoldingStringGenerator("field \"LargeScreenHTML\" of the DynamicResponse class");
            fieldGeneratorHints = new HintsJSON.HoldingGenerator("field \"Hints\" of the DynamicResponse class", false);
            fieldGeneratorEmotion = new EmotionJSON.HoldingGenerator("field \"Emotion\" of the DynamicResponse class", false);
            fieldGeneratorIcon = new IconJSON.HoldingGenerator("field \"Icon\" of the DynamicResponse class", false);
            fieldGeneratorResponseAudioBytes = new JSONHoldingStringGenerator("field \"ResponseAudioBytes\" of the DynamicResponse class");
            fieldGeneratorResponseAudioURL = new JSONHoldingStringGenerator("field \"ResponseAudioURL\" of the DynamicResponse class");
            fieldGeneratorResponseAudioError = new JSONHoldingStringGenerator("field \"ResponseAudioError\" of the DynamicResponse class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DynamicResponse class");
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
            fieldGeneratorAutoListen.reset();
            fieldGeneratorUserVisibleMode.reset();
            fieldGeneratorConversationState.reset();
            fieldGeneratorViewType.reset();
            fieldGeneratorTemplateName.reset();
            fieldGeneratorTemplateData.reset();
            fieldGeneratorCombiningTemplateData.reset();
            fieldGeneratorSmallScreenHTML.reset();
            fieldGeneratorLargeScreenHTML.reset();
            fieldGeneratorHints.reset();
            fieldGeneratorEmotion.reset();
            fieldGeneratorIcon.reset();
            fieldGeneratorResponseAudioBytes.reset();
            fieldGeneratorResponseAudioURL.reset();
            fieldGeneratorResponseAudioError.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorConversationState.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTemplateData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCombiningTemplateData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHints.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEmotion.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorIcon.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorConversationState.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTemplateData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCombiningTemplateData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHints.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEmotion.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorIcon.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DynamicResponseJSON  result)
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
        public DynamicResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DynamicResponseJSON  result)
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
    protected virtual void handle_result(List<DynamicResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DynamicResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DynamicResponseJSON>();
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
    public List<DynamicResponseJSON> value;
  };
  };
