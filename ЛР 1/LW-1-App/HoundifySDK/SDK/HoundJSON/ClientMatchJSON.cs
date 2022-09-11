/* file "ClientMatchJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ClientMatchJSON : JSONBase
  {
    public enum TypeExtendedBlock
      {
        ExtendedBlock_RAW_TOP_LEVEL_QUERY,
        ExtendedBlock_IMPERATIVE_PHRASE,
        ExtendedBlock_QUESTION,
        ExtendedBlock_SENTENCE
      };

    public static TypeExtendedBlock  stringToExtendedBlock(string chars)
      {
        switch (chars[0])
          {
            case 'I':
                if ((String.Compare(chars, 1, "MPERATIVE_PHRASE", 0, 16, false) == 0) && (chars.Length == 17))
                    return TypeExtendedBlock.ExtendedBlock_IMPERATIVE_PHRASE;
                break;
            case 'Q':
                if ((String.Compare(chars, 1, "UESTION", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeExtendedBlock.ExtendedBlock_QUESTION;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "AW_TOP_LEVEL_QUERY", 0, 18, false) == 0) && (chars.Length == 19))
                    return TypeExtendedBlock.ExtendedBlock_RAW_TOP_LEVEL_QUERY;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "ENTENCE", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeExtendedBlock.ExtendedBlock_SENTENCE;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `ExtendedBlock' is not one of the legal values.");
      }

    public static string  stringFromExtendedBlock(TypeExtendedBlock the_enum)
      {
        switch (the_enum)
          {
            case TypeExtendedBlock.ExtendedBlock_RAW_TOP_LEVEL_QUERY:
                return "RAW_TOP_LEVEL_QUERY";
            case TypeExtendedBlock.ExtendedBlock_IMPERATIVE_PHRASE:
                return "IMPERATIVE_PHRASE";
            case TypeExtendedBlock.ExtendedBlock_QUESTION:
                return "QUESTION";
            case TypeExtendedBlock.ExtendedBlock_SENTENCE:
                return "SENTENCE";
            default:
                Debug.Assert(false);
                return null;
          }
      }

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

    private bool flagHasExpression;
    private string storeExpression;
    private bool flagHasResult;
    private JSONValue  storeResult;
    private bool flagHasExtendedBlock;
    private TypeExtendedBlock storeExtendedBlock;
    private bool flagHasResultIsInformationNugget;
    private bool storeResultIsInformationNugget;
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
    private bool flagHasSpokenResponsePattern;
    private string storeSpokenResponsePattern;
    private bool flagHasSpokenResponsePatternLong;
    private string storeSpokenResponsePatternLong;
    private bool flagHasWrittenResponsePattern;
    private string storeWrittenResponsePattern;
    private bool flagHasWrittenResponsePatternLong;
    private string storeWrittenResponsePatternLong;
    private bool flagHasSpokenResponsePatternSSML;
    private string storeSpokenResponsePatternSSML;
    private bool flagHasSpokenResponsePatternSSMLLong;
    private string storeSpokenResponsePatternSSMLLong;
    private bool flagHasAutoListen;
    private bool storeAutoListen;
    private bool flagHasViewType;
    private List< TypeViewType > storeViewType;
    private bool flagHasTemplateData;
    private TemplateJSON  storeTemplateData;
    private bool flagHasPreview;
    private PreviewJSON  storePreview;
    private bool flagHasHTMLData;
    private HTMLDataJSON  storeHTMLData;
    private bool flagHasHints;
    private HintsJSON  storeHints;
    private bool flagHasEmotion;
    private EmotionJSON  storeEmotion;
    private bool flagHasIcon;
    private IconJSON  storeIcon;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONExpression(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Expression of ClientMatchJSON is not a string.");
        setExpression(json_string.getData());
      }


    private void  fromJSONResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        setResult(json_value);
      }


    private void  fromJSONExtendedBlock(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExtendedBlock of ClientMatchJSON is not a string.");
        TypeExtendedBlock the_enum;
        switch (json_string.getData()[0])
          {
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "MPERATIVE_PHRASE", 0, 16, false) == 0) && (json_string.getData().Length == 17))
                      {
                        the_enum = TypeExtendedBlock.ExtendedBlock_IMPERATIVE_PHRASE;
                        goto enum_is_done;
                      }
                break;
            case 'Q':
                if ((String.Compare(json_string.getData(), 1, "UESTION", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeExtendedBlock.ExtendedBlock_QUESTION;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "AW_TOP_LEVEL_QUERY", 0, 18, false) == 0) && (json_string.getData().Length == 19))
                      {
                        the_enum = TypeExtendedBlock.ExtendedBlock_RAW_TOP_LEVEL_QUERY;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "ENTENCE", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeExtendedBlock.ExtendedBlock_SENTENCE;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field ExtendedBlock of ClientMatchJSON is not one of the legal strings.");
      enum_is_done:;
        setExtendedBlock(the_enum);
      }


    private void  fromJSONResultIsInformationNugget(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ResultIsInformationNugget of ClientMatchJSON is not true for false.");
              }
          }
        setResultIsInformationNugget(the_bool);
      }


    private void  fromJSONSpokenResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponse of ClientMatchJSON is not a string.");
        setSpokenResponse(json_string.getData());
      }


    private void  fromJSONSpokenResponseLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseLong of ClientMatchJSON is not a string.");
        setSpokenResponseLong(json_string.getData());
      }


    private void  fromJSONWrittenResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenResponse of ClientMatchJSON is not a string.");
        setWrittenResponse(json_string.getData());
      }


    private void  fromJSONWrittenResponseLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenResponseLong of ClientMatchJSON is not a string.");
        setWrittenResponseLong(json_string.getData());
      }


    private void  fromJSONSpokenResponseSSML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseSSML of ClientMatchJSON is not a string.");
        setSpokenResponseSSML(json_string.getData());
      }


    private void  fromJSONSpokenResponseSSMLLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponseSSMLLong of ClientMatchJSON is not a string.");
        setSpokenResponseSSMLLong(json_string.getData());
      }


    private void  fromJSONSpokenResponsePattern(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponsePattern of ClientMatchJSON is not a string.");
        setSpokenResponsePattern(json_string.getData());
      }


    private void  fromJSONSpokenResponsePatternLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponsePatternLong of ClientMatchJSON is not a string.");
        setSpokenResponsePatternLong(json_string.getData());
      }


    private void  fromJSONWrittenResponsePattern(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenResponsePattern of ClientMatchJSON is not a string.");
        setWrittenResponsePattern(json_string.getData());
      }


    private void  fromJSONWrittenResponsePatternLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenResponsePatternLong of ClientMatchJSON is not a string.");
        setWrittenResponsePatternLong(json_string.getData());
      }


    private void  fromJSONSpokenResponsePatternSSML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponsePatternSSML of ClientMatchJSON is not a string.");
        setSpokenResponsePatternSSML(json_string.getData());
      }


    private void  fromJSONSpokenResponsePatternSSMLLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenResponsePatternSSMLLong of ClientMatchJSON is not a string.");
        setSpokenResponsePatternSSMLLong(json_string.getData());
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
                throw new Exception("The value for field AutoListen of ClientMatchJSON is not true for false.");
              }
          }
        setAutoListen(the_bool);
      }


    private void  fromJSONViewType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ViewType of ClientMatchJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ViewType of ClientMatchJSON has too few elements.");
        List< TypeViewType > vector_ViewType1 = new List< TypeViewType >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ViewType of ClientMatchJSON is not a string.");
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
            throw new Exception("The value for an element of field ViewType of ClientMatchJSON is not one of the legal strings.");
          enum_is_done:;
            vector_ViewType1.Add(the_enum);
          }
        Debug.Assert(vector_ViewType1.Count >= 1);
        initViewType();
        for (int num1 = 0; num1 < vector_ViewType1.Count; ++num1)
            appendViewType(vector_ViewType1[num1]);
        for (int num1 = 0; num1 < vector_ViewType1.Count; ++num1)
          {
          }
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


    private void  fromJSONHTMLData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HTMLDataJSON convert_classy = HTMLDataJSON.from_json(json_value, ignore_extras, true);
        setHTMLData(convert_classy);
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


    public ClientMatchJSON()
      {
        flagHasExpression = false;
        flagHasResult = false;
        flagHasExtendedBlock = false;
        flagHasResultIsInformationNugget = false;
        flagHasSpokenResponse = false;
        flagHasSpokenResponseLong = false;
        flagHasWrittenResponse = false;
        flagHasWrittenResponseLong = false;
        flagHasSpokenResponseSSML = false;
        flagHasSpokenResponseSSMLLong = false;
        flagHasSpokenResponsePattern = false;
        flagHasSpokenResponsePatternLong = false;
        flagHasWrittenResponsePattern = false;
        flagHasWrittenResponsePatternLong = false;
        flagHasSpokenResponsePatternSSML = false;
        flagHasSpokenResponsePatternSSMLLong = false;
        flagHasAutoListen = false;
        flagHasViewType = false;
        flagHasTemplateData = false;
        flagHasPreview = false;
        flagHasHTMLData = false;
        flagHasHints = false;
        flagHasEmotion = false;
        flagHasIcon = false;
        storeViewType = new List< TypeViewType >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasExpression()
      {
        return flagHasExpression;
      }

    public string  getExpression()
      {
        Debug.Assert(flagHasExpression);
        return storeExpression;
      }

    public bool  hasResult()
      {
        return flagHasResult;
      }

    public JSONValue   getResult()
      {
        Debug.Assert(flagHasResult);
        return storeResult;
      }

    public bool  hasExtendedBlock()
      {
        return flagHasExtendedBlock;
      }

    public TypeExtendedBlock  getExtendedBlock()
      {
        Debug.Assert(flagHasExtendedBlock);
        return storeExtendedBlock;
      }

    public string  getExtendedBlockAsString()
      {
        return stringFromExtendedBlock(getExtendedBlock());
      }

    public bool  hasResultIsInformationNugget()
      {
        return flagHasResultIsInformationNugget;
      }

    public bool  getResultIsInformationNugget()
      {
        Debug.Assert(flagHasResultIsInformationNugget);
        return storeResultIsInformationNugget;
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

    public bool  hasSpokenResponsePattern()
      {
        return flagHasSpokenResponsePattern;
      }

    public string  getSpokenResponsePattern()
      {
        Debug.Assert(flagHasSpokenResponsePattern);
        return storeSpokenResponsePattern;
      }

    public bool  hasSpokenResponsePatternLong()
      {
        return flagHasSpokenResponsePatternLong;
      }

    public string  getSpokenResponsePatternLong()
      {
        Debug.Assert(flagHasSpokenResponsePatternLong);
        return storeSpokenResponsePatternLong;
      }

    public bool  hasWrittenResponsePattern()
      {
        return flagHasWrittenResponsePattern;
      }

    public string  getWrittenResponsePattern()
      {
        Debug.Assert(flagHasWrittenResponsePattern);
        return storeWrittenResponsePattern;
      }

    public bool  hasWrittenResponsePatternLong()
      {
        return flagHasWrittenResponsePatternLong;
      }

    public string  getWrittenResponsePatternLong()
      {
        Debug.Assert(flagHasWrittenResponsePatternLong);
        return storeWrittenResponsePatternLong;
      }

    public bool  hasSpokenResponsePatternSSML()
      {
        return flagHasSpokenResponsePatternSSML;
      }

    public string  getSpokenResponsePatternSSML()
      {
        Debug.Assert(flagHasSpokenResponsePatternSSML);
        return storeSpokenResponsePatternSSML;
      }

    public bool  hasSpokenResponsePatternSSMLLong()
      {
        return flagHasSpokenResponsePatternSSMLLong;
      }

    public string  getSpokenResponsePatternSSMLLong()
      {
        Debug.Assert(flagHasSpokenResponsePatternSSMLLong);
        return storeSpokenResponsePatternSSMLLong;
      }

    public bool  hasAutoListen()
      {
        return flagHasAutoListen;
      }

    public bool  getAutoListen()
      {
        Debug.Assert(flagHasAutoListen);
        return storeAutoListen;
      }

    public bool  hasViewType()
      {
        return flagHasViewType;
      }

    public int  countOfViewType()
      {
        Debug.Assert(flagHasViewType);
        return storeViewType.Count;
      }

    public TypeViewType  elementOfViewType(int element_num)
      {
        Debug.Assert(flagHasViewType);
        return storeViewType[element_num];
      }

    public List< TypeViewType >  getViewType()
      {
        Debug.Assert(flagHasViewType);
        return storeViewType;
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

    public bool  hasHTMLData()
      {
        return flagHasHTMLData;
      }

    public HTMLDataJSON   getHTMLData()
      {
        Debug.Assert(flagHasHTMLData);
        return storeHTMLData;
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


    public virtual int extraClientMatchComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraClientMatchComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraClientMatchComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraClientMatchLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setExpression(string new_value)
      {
        flagHasExpression = true;
        storeExpression = new_value;
      }
    public void unsetExpression()
      {
        flagHasExpression = false;
      }
    public void setResult(JSONValue  new_value)
      {
        if (flagHasResult)
          {
          }
        flagHasResult = true;
        storeResult = new_value;
      }
    public void unsetResult()
      {
        if (flagHasResult)
          {
          }
        flagHasResult = false;
      }
    public void setExtendedBlock(TypeExtendedBlock new_value)
      {
        flagHasExtendedBlock = true;
        storeExtendedBlock = new_value;
      }
    public void setExtendedBlock(string chars)
      {
        setExtendedBlock(stringToExtendedBlock(chars));
      }
    public void unsetExtendedBlock()
      {
        flagHasExtendedBlock = false;
      }
    public void setResultIsInformationNugget(bool new_value)
      {
        flagHasResultIsInformationNugget = true;
        storeResultIsInformationNugget = new_value;
      }
    public void unsetResultIsInformationNugget()
      {
        flagHasResultIsInformationNugget = false;
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
    public void setSpokenResponsePattern(string new_value)
      {
        flagHasSpokenResponsePattern = true;
        storeSpokenResponsePattern = new_value;
      }
    public void unsetSpokenResponsePattern()
      {
        flagHasSpokenResponsePattern = false;
      }
    public void setSpokenResponsePatternLong(string new_value)
      {
        flagHasSpokenResponsePatternLong = true;
        storeSpokenResponsePatternLong = new_value;
      }
    public void unsetSpokenResponsePatternLong()
      {
        flagHasSpokenResponsePatternLong = false;
      }
    public void setWrittenResponsePattern(string new_value)
      {
        flagHasWrittenResponsePattern = true;
        storeWrittenResponsePattern = new_value;
      }
    public void unsetWrittenResponsePattern()
      {
        flagHasWrittenResponsePattern = false;
      }
    public void setWrittenResponsePatternLong(string new_value)
      {
        flagHasWrittenResponsePatternLong = true;
        storeWrittenResponsePatternLong = new_value;
      }
    public void unsetWrittenResponsePatternLong()
      {
        flagHasWrittenResponsePatternLong = false;
      }
    public void setSpokenResponsePatternSSML(string new_value)
      {
        flagHasSpokenResponsePatternSSML = true;
        storeSpokenResponsePatternSSML = new_value;
      }
    public void unsetSpokenResponsePatternSSML()
      {
        flagHasSpokenResponsePatternSSML = false;
      }
    public void setSpokenResponsePatternSSMLLong(string new_value)
      {
        flagHasSpokenResponsePatternSSMLLong = true;
        storeSpokenResponsePatternSSMLLong = new_value;
      }
    public void unsetSpokenResponsePatternSSMLLong()
      {
        flagHasSpokenResponsePatternSSMLLong = false;
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
    public void setHTMLData(HTMLDataJSON  new_value)
      {
        if (flagHasHTMLData)
          {
          }
        flagHasHTMLData = true;
        storeHTMLData = new_value;
      }
    public void unsetHTMLData()
      {
        if (flagHasHTMLData)
          {
          }
        flagHasHTMLData = false;
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

    public virtual void extraClientMatchAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraClientMatchSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraClientMatchLookup(key);
        if (old_field == null)
          {
            extraClientMatchAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasExpression);
        if (flagHasExpression)
          {
            handler.start_pair("Expression");
            handler.string_value(storeExpression);
          }
        Debug.Assert(partial_allowed || flagHasResult);
        if (flagHasResult)
          {
            handler.start_pair("Result");
            storeResult.write(handler);
          }
        if (flagHasExtendedBlock)
          {
            handler.start_pair("ExtendedBlock");
            switch (storeExtendedBlock)
              {
                case TypeExtendedBlock.ExtendedBlock_RAW_TOP_LEVEL_QUERY:
                    handler.string_value("RAW_TOP_LEVEL_QUERY");
                    break;
                case TypeExtendedBlock.ExtendedBlock_IMPERATIVE_PHRASE:
                    handler.string_value("IMPERATIVE_PHRASE");
                    break;
                case TypeExtendedBlock.ExtendedBlock_QUESTION:
                    handler.string_value("QUESTION");
                    break;
                case TypeExtendedBlock.ExtendedBlock_SENTENCE:
                    handler.string_value("SENTENCE");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasResultIsInformationNugget)
          {
            handler.start_pair("ResultIsInformationNugget");
            handler.boolean_value(storeResultIsInformationNugget);
          }
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
        if (flagHasSpokenResponsePattern)
          {
            handler.start_pair("SpokenResponsePattern");
            handler.string_value(storeSpokenResponsePattern);
          }
        if (flagHasSpokenResponsePatternLong)
          {
            handler.start_pair("SpokenResponsePatternLong");
            handler.string_value(storeSpokenResponsePatternLong);
          }
        if (flagHasWrittenResponsePattern)
          {
            handler.start_pair("WrittenResponsePattern");
            handler.string_value(storeWrittenResponsePattern);
          }
        if (flagHasWrittenResponsePatternLong)
          {
            handler.start_pair("WrittenResponsePatternLong");
            handler.string_value(storeWrittenResponsePatternLong);
          }
        if (flagHasSpokenResponsePatternSSML)
          {
            handler.start_pair("SpokenResponsePatternSSML");
            handler.string_value(storeSpokenResponsePatternSSML);
          }
        if (flagHasSpokenResponsePatternSSMLLong)
          {
            handler.start_pair("SpokenResponsePatternSSMLLong");
            handler.string_value(storeSpokenResponsePatternSSMLLong);
          }
        if (flagHasAutoListen)
          {
            handler.start_pair("AutoListen");
            handler.boolean_value(storeAutoListen);
          }
        if (flagHasViewType)
          {
            handler.start_pair("ViewType");
            Debug.Assert(storeViewType.Count >= 1);
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
        if (flagHasHTMLData)
          {
            handler.start_pair("HTMLData");
            if (partial_allowed)
                storeHTMLData.write_partial_as_json(handler);
            else
                storeHTMLData.write_as_json(handler);
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
        if (!(hasExpression()))
          {
            return "When parsing the object for %what%, the \"Expression\" field was missing.";
          }
        if (!(hasResult()))
          {
            return "When parsing the object for %what%, the \"Result\" field was missing.";
          }
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

    public static ClientMatchJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ClientMatchJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientMatch", ignore_extras);
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
    public static ClientMatchJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ClientMatchJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ClientMatchJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientMatch", ignore_extras);
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
    public static ClientMatchJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ClientMatchJSON from_text(string text, bool ignore_extras)
      {
        ClientMatchJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientMatch", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ClientMatchJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ClientMatchJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ClientMatchJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientMatch", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorExpression;
        private JSONHoldingValueGenerator fieldGeneratorResult;
    private abstract class FieldGeneratorExtendedBlock : JSONStringGenerator
          {
            protected FieldGeneratorExtendedBlock(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorExtendedBlock()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToExtendedBlock(result));
              }
            protected abstract void handle_result(TypeExtendedBlock result);
          };
    private class FieldHoldingGeneratorExtendedBlock : FieldGeneratorExtendedBlock
  {
    protected override void handle_result(TypeExtendedBlock result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorExtendedBlock(String what)
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
    public TypeExtendedBlock value;
  };
    private class FieldHoldingArrayGeneratorExtendedBlock : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorExtendedBlock
      {
        private FieldHoldingArrayGeneratorExtendedBlock top;

        protected override void handle_result(TypeExtendedBlock result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorExtendedBlock init_top)
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
    protected virtual void handle_result(List<TypeExtendedBlock> result)
      {
      }

    public FieldHoldingArrayGeneratorExtendedBlock(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeExtendedBlock>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorExtendedBlock()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeExtendedBlock>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeExtendedBlock> value;
  };
        private FieldHoldingGeneratorExtendedBlock fieldGeneratorExtendedBlock;
        private JSONHoldingBooleanGenerator fieldGeneratorResultIsInformationNugget;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponse;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponseLong;
        private JSONHoldingStringGenerator fieldGeneratorWrittenResponse;
        private JSONHoldingStringGenerator fieldGeneratorWrittenResponseLong;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponseSSML;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponseSSMLLong;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponsePattern;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponsePatternLong;
        private JSONHoldingStringGenerator fieldGeneratorWrittenResponsePattern;
        private JSONHoldingStringGenerator fieldGeneratorWrittenResponsePatternLong;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponsePatternSSML;
        private JSONHoldingStringGenerator fieldGeneratorSpokenResponsePatternSSMLLong;
        private JSONHoldingBooleanGenerator fieldGeneratorAutoListen;
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
        private TemplateJSON.HoldingGenerator fieldGeneratorTemplateData;
        private PreviewJSON.HoldingGenerator fieldGeneratorPreview;
        private HTMLDataJSON.HoldingGenerator fieldGeneratorHTMLData;
        private HintsJSON.HoldingGenerator fieldGeneratorHints;
        private EmotionJSON.HoldingGenerator fieldGeneratorEmotion;
        private IconJSON.HoldingGenerator fieldGeneratorIcon;
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
            ClientMatchJSON result = new ClientMatchJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraClientMatchAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ClientMatchJSON result)
          {
            if (fieldGeneratorExpression.have_value)
              {
                result.setExpression(fieldGeneratorExpression.value);
                fieldGeneratorExpression.have_value = false;
              }
            else if ((!(result.hasExpression())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Expression\" field was missing.");
              }
            if (fieldGeneratorResult.have_value)
              {
                result.setResult(fieldGeneratorResult.value);
                fieldGeneratorResult.have_value = false;
              }
            else if ((!(result.hasResult())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Result\" field was missing.");
              }
            if (fieldGeneratorExtendedBlock.have_value)
              {
                result.setExtendedBlock(fieldGeneratorExtendedBlock.value);
                fieldGeneratorExtendedBlock.have_value = false;
              }
            if (fieldGeneratorResultIsInformationNugget.have_value)
              {
                result.setResultIsInformationNugget(fieldGeneratorResultIsInformationNugget.value);
                fieldGeneratorResultIsInformationNugget.have_value = false;
              }
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
            if (fieldGeneratorSpokenResponsePattern.have_value)
              {
                result.setSpokenResponsePattern(fieldGeneratorSpokenResponsePattern.value);
                fieldGeneratorSpokenResponsePattern.have_value = false;
              }
            if (fieldGeneratorSpokenResponsePatternLong.have_value)
              {
                result.setSpokenResponsePatternLong(fieldGeneratorSpokenResponsePatternLong.value);
                fieldGeneratorSpokenResponsePatternLong.have_value = false;
              }
            if (fieldGeneratorWrittenResponsePattern.have_value)
              {
                result.setWrittenResponsePattern(fieldGeneratorWrittenResponsePattern.value);
                fieldGeneratorWrittenResponsePattern.have_value = false;
              }
            if (fieldGeneratorWrittenResponsePatternLong.have_value)
              {
                result.setWrittenResponsePatternLong(fieldGeneratorWrittenResponsePatternLong.value);
                fieldGeneratorWrittenResponsePatternLong.have_value = false;
              }
            if (fieldGeneratorSpokenResponsePatternSSML.have_value)
              {
                result.setSpokenResponsePatternSSML(fieldGeneratorSpokenResponsePatternSSML.value);
                fieldGeneratorSpokenResponsePatternSSML.have_value = false;
              }
            if (fieldGeneratorSpokenResponsePatternSSMLLong.have_value)
              {
                result.setSpokenResponsePatternSSMLLong(fieldGeneratorSpokenResponsePatternSSMLLong.value);
                fieldGeneratorSpokenResponsePatternSSMLLong.have_value = false;
              }
            if (fieldGeneratorAutoListen.have_value)
              {
                result.setAutoListen(fieldGeneratorAutoListen.value);
                fieldGeneratorAutoListen.have_value = false;
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
            if (fieldGeneratorHTMLData.have_value)
              {
                result.setHTMLData(fieldGeneratorHTMLData.value);
                fieldGeneratorHTMLData.have_value = false;
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
          }
        protected abstract void handle_result(ClientMatchJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "utoListen", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorAutoListen;
                    break;
                case 'E':
                    switch (field_name[1])
                      {
                        case 'm':
                            if ((String.Compare(field_name, 2, "otion", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorEmotion;
                            break;
                        case 'x':
                            switch (field_name[2])
                              {
                                case 'p':
                                    if ((String.Compare(field_name, 3, "ression", 0, 7, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorExpression;
                                    break;
                                case 't':
                                    if ((String.Compare(field_name, 3, "endedBlock", 0, 10, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorExtendedBlock;
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
                    switch (field_name[1])
                      {
                        case 'T':
                            if ((String.Compare(field_name, 2, "MLData", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorHTMLData;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "nts", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorHints;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "con", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorIcon;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "review", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorPreview;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "esult", 0, 5, false) == 0)
                      {
                        if (field_name.Length == 6)
                          {
                            return fieldGeneratorResult;
                          }
                        switch (field_name[6])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 7, "sInformationNugget", 0, 18, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorResultIsInformationNugget;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "pokenResponse", 0, 13, false) == 0)
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
                            case 'P':
                                if (String.Compare(field_name, 15, "attern", 0, 6, false) == 0)
                                  {
                                    if (field_name.Length == 21)
                                      {
                                        return fieldGeneratorSpokenResponsePattern;
                                      }
                                    switch (field_name[21])
                                      {
                                        case 'L':
                                            if ((String.Compare(field_name, 22, "ong", 0, 3, false) == 0) && (field_name.Length == 25))
                                                return fieldGeneratorSpokenResponsePatternLong;
                                            break;
                                        case 'S':
                                            if (String.Compare(field_name, 22, "SML", 0, 3, false) == 0)
                                              {
                                                if (field_name.Length == 25)
                                                  {
                                                    return fieldGeneratorSpokenResponsePatternSSML;
                                                  }
                                                switch (field_name[25])
                                                  {
                                                    case 'L':
                                                        if ((String.Compare(field_name, 26, "ong", 0, 3, false) == 0) && (field_name.Length == 29))
                                                            return fieldGeneratorSpokenResponsePatternSSMLLong;
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
                case 'T':
                    if ((String.Compare(field_name, 1, "emplateData", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorTemplateData;
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
                            case 'P':
                                if (String.Compare(field_name, 16, "attern", 0, 6, false) == 0)
                                  {
                                    if (field_name.Length == 22)
                                      {
                                        return fieldGeneratorWrittenResponsePattern;
                                      }
                                    switch (field_name[22])
                                      {
                                        case 'L':
                                            if ((String.Compare(field_name, 23, "ong", 0, 3, false) == 0) && (field_name.Length == 26))
                                                return fieldGeneratorWrittenResponsePatternLong;
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
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorExpression = new JSONHoldingStringGenerator("field \"Expression\" of the ClientMatch class");
            fieldGeneratorResult = new JSONHoldingValueGenerator("field \"Result\" of the ClientMatch class");
            fieldGeneratorExtendedBlock = new FieldHoldingGeneratorExtendedBlock("field \"ExtendedBlock\" of the ClientMatch class");
            fieldGeneratorResultIsInformationNugget = new JSONHoldingBooleanGenerator("field \"ResultIsInformationNugget\" of the ClientMatch class");
            fieldGeneratorSpokenResponse = new JSONHoldingStringGenerator("field \"SpokenResponse\" of the ClientMatch class");
            fieldGeneratorSpokenResponseLong = new JSONHoldingStringGenerator("field \"SpokenResponseLong\" of the ClientMatch class");
            fieldGeneratorWrittenResponse = new JSONHoldingStringGenerator("field \"WrittenResponse\" of the ClientMatch class");
            fieldGeneratorWrittenResponseLong = new JSONHoldingStringGenerator("field \"WrittenResponseLong\" of the ClientMatch class");
            fieldGeneratorSpokenResponseSSML = new JSONHoldingStringGenerator("field \"SpokenResponseSSML\" of the ClientMatch class");
            fieldGeneratorSpokenResponseSSMLLong = new JSONHoldingStringGenerator("field \"SpokenResponseSSMLLong\" of the ClientMatch class");
            fieldGeneratorSpokenResponsePattern = new JSONHoldingStringGenerator("field \"SpokenResponsePattern\" of the ClientMatch class");
            fieldGeneratorSpokenResponsePatternLong = new JSONHoldingStringGenerator("field \"SpokenResponsePatternLong\" of the ClientMatch class");
            fieldGeneratorWrittenResponsePattern = new JSONHoldingStringGenerator("field \"WrittenResponsePattern\" of the ClientMatch class");
            fieldGeneratorWrittenResponsePatternLong = new JSONHoldingStringGenerator("field \"WrittenResponsePatternLong\" of the ClientMatch class");
            fieldGeneratorSpokenResponsePatternSSML = new JSONHoldingStringGenerator("field \"SpokenResponsePatternSSML\" of the ClientMatch class");
            fieldGeneratorSpokenResponsePatternSSMLLong = new JSONHoldingStringGenerator("field \"SpokenResponsePatternSSMLLong\" of the ClientMatch class");
            fieldGeneratorAutoListen = new JSONHoldingBooleanGenerator("field \"AutoListen\" of the ClientMatch class");
            fieldGeneratorViewType = new FieldHoldingArrayGeneratorViewType("field \"ViewType\" of the ClientMatch class");
            fieldGeneratorTemplateData = new TemplateJSON.HoldingGenerator("field \"TemplateData\" of the ClientMatch class", ignore_extras);
            fieldGeneratorPreview = new PreviewJSON.HoldingGenerator("field \"Preview\" of the ClientMatch class", ignore_extras);
            fieldGeneratorHTMLData = new HTMLDataJSON.HoldingGenerator("field \"HTMLData\" of the ClientMatch class", ignore_extras);
            fieldGeneratorHints = new HintsJSON.HoldingGenerator("field \"Hints\" of the ClientMatch class", ignore_extras);
            fieldGeneratorEmotion = new EmotionJSON.HoldingGenerator("field \"Emotion\" of the ClientMatch class", ignore_extras);
            fieldGeneratorIcon = new IconJSON.HoldingGenerator("field \"Icon\" of the ClientMatch class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ClientMatch class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorExpression = new JSONHoldingStringGenerator("field \"Expression\" of the ClientMatch class");
            fieldGeneratorResult = new JSONHoldingValueGenerator("field \"Result\" of the ClientMatch class");
            fieldGeneratorExtendedBlock = new FieldHoldingGeneratorExtendedBlock("field \"ExtendedBlock\" of the ClientMatch class");
            fieldGeneratorResultIsInformationNugget = new JSONHoldingBooleanGenerator("field \"ResultIsInformationNugget\" of the ClientMatch class");
            fieldGeneratorSpokenResponse = new JSONHoldingStringGenerator("field \"SpokenResponse\" of the ClientMatch class");
            fieldGeneratorSpokenResponseLong = new JSONHoldingStringGenerator("field \"SpokenResponseLong\" of the ClientMatch class");
            fieldGeneratorWrittenResponse = new JSONHoldingStringGenerator("field \"WrittenResponse\" of the ClientMatch class");
            fieldGeneratorWrittenResponseLong = new JSONHoldingStringGenerator("field \"WrittenResponseLong\" of the ClientMatch class");
            fieldGeneratorSpokenResponseSSML = new JSONHoldingStringGenerator("field \"SpokenResponseSSML\" of the ClientMatch class");
            fieldGeneratorSpokenResponseSSMLLong = new JSONHoldingStringGenerator("field \"SpokenResponseSSMLLong\" of the ClientMatch class");
            fieldGeneratorSpokenResponsePattern = new JSONHoldingStringGenerator("field \"SpokenResponsePattern\" of the ClientMatch class");
            fieldGeneratorSpokenResponsePatternLong = new JSONHoldingStringGenerator("field \"SpokenResponsePatternLong\" of the ClientMatch class");
            fieldGeneratorWrittenResponsePattern = new JSONHoldingStringGenerator("field \"WrittenResponsePattern\" of the ClientMatch class");
            fieldGeneratorWrittenResponsePatternLong = new JSONHoldingStringGenerator("field \"WrittenResponsePatternLong\" of the ClientMatch class");
            fieldGeneratorSpokenResponsePatternSSML = new JSONHoldingStringGenerator("field \"SpokenResponsePatternSSML\" of the ClientMatch class");
            fieldGeneratorSpokenResponsePatternSSMLLong = new JSONHoldingStringGenerator("field \"SpokenResponsePatternSSMLLong\" of the ClientMatch class");
            fieldGeneratorAutoListen = new JSONHoldingBooleanGenerator("field \"AutoListen\" of the ClientMatch class");
            fieldGeneratorViewType = new FieldHoldingArrayGeneratorViewType("field \"ViewType\" of the ClientMatch class");
            fieldGeneratorTemplateData = new TemplateJSON.HoldingGenerator("field \"TemplateData\" of the ClientMatch class", false);
            fieldGeneratorPreview = new PreviewJSON.HoldingGenerator("field \"Preview\" of the ClientMatch class", false);
            fieldGeneratorHTMLData = new HTMLDataJSON.HoldingGenerator("field \"HTMLData\" of the ClientMatch class", false);
            fieldGeneratorHints = new HintsJSON.HoldingGenerator("field \"Hints\" of the ClientMatch class", false);
            fieldGeneratorEmotion = new EmotionJSON.HoldingGenerator("field \"Emotion\" of the ClientMatch class", false);
            fieldGeneratorIcon = new IconJSON.HoldingGenerator("field \"Icon\" of the ClientMatch class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ClientMatch class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorExpression.reset();
            fieldGeneratorResult.reset();
            fieldGeneratorExtendedBlock.reset();
            fieldGeneratorResultIsInformationNugget.reset();
            fieldGeneratorSpokenResponse.reset();
            fieldGeneratorSpokenResponseLong.reset();
            fieldGeneratorWrittenResponse.reset();
            fieldGeneratorWrittenResponseLong.reset();
            fieldGeneratorSpokenResponseSSML.reset();
            fieldGeneratorSpokenResponseSSMLLong.reset();
            fieldGeneratorSpokenResponsePattern.reset();
            fieldGeneratorSpokenResponsePatternLong.reset();
            fieldGeneratorWrittenResponsePattern.reset();
            fieldGeneratorWrittenResponsePatternLong.reset();
            fieldGeneratorSpokenResponsePatternSSML.reset();
            fieldGeneratorSpokenResponsePatternSSMLLong.reset();
            fieldGeneratorAutoListen.reset();
            fieldGeneratorViewType.reset();
            fieldGeneratorTemplateData.reset();
            fieldGeneratorPreview.reset();
            fieldGeneratorHTMLData.reset();
            fieldGeneratorHints.reset();
            fieldGeneratorEmotion.reset();
            fieldGeneratorIcon.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTemplateData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPreview.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHTMLData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHints.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEmotion.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorIcon.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTemplateData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPreview.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHTMLData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHints.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEmotion.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorIcon.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ClientMatchJSON  result)
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
        public ClientMatchJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ClientMatchJSON  result)
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
    protected virtual void handle_result(List<ClientMatchJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ClientMatchJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ClientMatchJSON>();
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
    public List<ClientMatchJSON> value;
  };
  };
