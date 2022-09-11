/* file "HoundPartialTranscriptJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HoundPartialTranscriptJSON : JSONBase
  {
    public enum TypeFormat
      {
        Format_SoundHoundVoiceSearchParialTranscript,
        Format_HoundVoiceQueryPartialTranscript
      };

    public static TypeFormat  stringToFormat(string chars)
      {
        switch (chars[0])
          {
            case 'H':
                if ((String.Compare(chars, 1, "oundVoiceQueryPartialTranscript", 0, 31, false) == 0) && (chars.Length == 32))
                    return TypeFormat.Format_HoundVoiceQueryPartialTranscript;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "oundHoundVoiceSearchParialTranscript", 0, 36, false) == 0) && (chars.Length == 37))
                    return TypeFormat.Format_SoundHoundVoiceSearchParialTranscript;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Format' is not one of the legal values.");
      }

    public static string  stringFromFormat(TypeFormat the_enum)
      {
        switch (the_enum)
          {
            case TypeFormat.Format_SoundHoundVoiceSearchParialTranscript:
                return "SoundHoundVoiceSearchParialTranscript";
            case TypeFormat.Format_HoundVoiceQueryPartialTranscript:
                return "HoundVoiceQueryPartialTranscript";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeFormatVersion
      {
        FormatVersion_1_x2e_0
      };

    public static TypeFormatVersion  stringToFormatVersion(string chars)
      {
        if ((String.Compare(chars, 0, "1.0", 0, 3, false) == 0) && (chars.Length == 3))
            return TypeFormatVersion.FormatVersion_1_x2e_0;
        throw new Exception("The value for field `FormatVersion' is not one of the legal values.");
      }

    public static string  stringFromFormatVersion(TypeFormatVersion the_enum)
      {
        switch (the_enum)
          {
            case TypeFormatVersion.FormatVersion_1_x2e_0:
                return "1.0";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeLocalOrRemote
      {
        LocalOrRemote_Local,
        LocalOrRemote_Remote
      };

    public static TypeLocalOrRemote  stringToLocalOrRemote(string chars)
      {
        switch (chars[0])
          {
            case 'L':
                if ((String.Compare(chars, 1, "ocal", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeLocalOrRemote.LocalOrRemote_Local;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "emote", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeLocalOrRemote.LocalOrRemote_Remote;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `LocalOrRemote' is not one of the legal values.");
      }

    public static string  stringFromLocalOrRemote(TypeLocalOrRemote the_enum)
      {
        switch (the_enum)
          {
            case TypeLocalOrRemote.LocalOrRemote_Local:
                return "Local";
            case TypeLocalOrRemote.LocalOrRemote_Remote:
                return "Remote";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasFormat;
    private TypeFormat storeFormat;
    private bool flagHasFormatVersion;
    private bool flagHasPartialTranscript;
    private string storePartialTranscript;
    private bool flagHasFinalPartialTranscript;
    private string storeFinalPartialTranscript;
    private bool flagHasDurationMS;
    private double storeDurationMS;
    private string textStoreDurationMS;
    private bool flagHasDone;
    private bool storeDone;
    private bool flagHasSafeToStopAudio;
    private bool storeSafeToStopAudio;
    private bool flagHasLocalOrRemote;
    private TypeLocalOrRemote storeLocalOrRemote;
    private bool flagHasFinalPartialTranscriptTokens;
    private HoundTranscriptTokensJSON  storeFinalPartialTranscriptTokens;
    private bool flagHasPartialTranscriptTokens;
    private HoundTranscriptTokensJSON  storePartialTranscriptTokens;
    private bool flagHasEntityDetection;
    private EntityDetectionJSON  storeEntityDetection;
    private bool flagHasTopicIdentification;
    private TopicIdentificationResultsJSON  storeTopicIdentification;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFormat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Format of HoundPartialTranscriptJSON is not a string.");
        TypeFormat the_enum;
        switch (json_string.getData()[0])
          {
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "oundVoiceQueryPartialTranscript", 0, 31, false) == 0) && (json_string.getData().Length == 32))
                      {
                        the_enum = TypeFormat.Format_HoundVoiceQueryPartialTranscript;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "oundHoundVoiceSearchParialTranscript", 0, 36, false) == 0) && (json_string.getData().Length == 37))
                      {
                        the_enum = TypeFormat.Format_SoundHoundVoiceSearchParialTranscript;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Format of HoundPartialTranscriptJSON is not one of the legal strings.");
      enum_is_done:;
        setFormat(the_enum);
      }


    private void  fromJSONFormatVersion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FormatVersion of HoundPartialTranscriptJSON is not a string.");
        if (!(json_string.getData().Equals("1.0")))
            throw new Exception("The value for field FormatVersion of HoundPartialTranscriptJSON is not `1.0'.");
        setFormatVersion();
      }


    private void  fromJSONPartialTranscript(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PartialTranscript of HoundPartialTranscriptJSON is not a string.");
        setPartialTranscript(json_string.getData());
      }


    private void  fromJSONFinalPartialTranscript(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FinalPartialTranscript of HoundPartialTranscriptJSON is not a string.");
        setFinalPartialTranscript(json_string.getData());
      }


    private void  fromJSONDurationMS(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DurationMS of HoundPartialTranscriptJSON is not a number.");
              }
          }
        setDurationMSText(the_rational_text);
      }


    private void  fromJSONDone(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Done of HoundPartialTranscriptJSON is not true for false.");
              }
          }
        setDone(the_bool);
      }


    private void  fromJSONSafeToStopAudio(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SafeToStopAudio of HoundPartialTranscriptJSON is not true for false.");
              }
          }
        setSafeToStopAudio(the_bool);
      }


    private void  fromJSONLocalOrRemote(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LocalOrRemote of HoundPartialTranscriptJSON is not a string.");
        TypeLocalOrRemote the_enum;
        switch (json_string.getData()[0])
          {
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ocal", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeLocalOrRemote.LocalOrRemote_Local;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "emote", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeLocalOrRemote.LocalOrRemote_Remote;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field LocalOrRemote of HoundPartialTranscriptJSON is not one of the legal strings.");
      enum_is_done:;
        setLocalOrRemote(the_enum);
      }


    private void  fromJSONFinalPartialTranscriptTokens(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HoundTranscriptTokensJSON convert_classy = HoundTranscriptTokensJSON.from_json(json_value, ignore_extras, true);
        setFinalPartialTranscriptTokens(convert_classy);
      }


    private void  fromJSONPartialTranscriptTokens(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HoundTranscriptTokensJSON convert_classy = HoundTranscriptTokensJSON.from_json(json_value, ignore_extras, true);
        setPartialTranscriptTokens(convert_classy);
      }


    private void  fromJSONEntityDetection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EntityDetectionJSON convert_classy = EntityDetectionJSON.from_json(json_value, ignore_extras, true);
        setEntityDetection(convert_classy);
      }


    private void  fromJSONTopicIdentification(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TopicIdentificationResultsJSON convert_classy = TopicIdentificationResultsJSON.from_json(json_value, ignore_extras, true);
        setTopicIdentification(convert_classy);
      }


    public HoundPartialTranscriptJSON()
      {
        flagHasFormat = false;
        flagHasFormatVersion = false;
        flagHasPartialTranscript = false;
        flagHasFinalPartialTranscript = false;
        flagHasDurationMS = false;
        flagHasDone = false;
        flagHasSafeToStopAudio = false;
        flagHasLocalOrRemote = false;
        flagHasFinalPartialTranscriptTokens = false;
        flagHasPartialTranscriptTokens = false;
        flagHasEntityDetection = false;
        flagHasTopicIdentification = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFormat()
      {
        return flagHasFormat;
      }

    public TypeFormat  getFormat()
      {
        Debug.Assert(flagHasFormat);
        return storeFormat;
      }

    public string  getFormatAsString()
      {
        return stringFromFormat(getFormat());
      }

    public bool  hasFormatVersion()
      {
        return flagHasFormatVersion;
      }

    public TypeFormatVersion  getFormatVersion()
      {
        Debug.Assert(flagHasFormatVersion);
        return TypeFormatVersion.FormatVersion_1_x2e_0;
      }

    public string  getFormatVersionAsString()
      {
        return stringFromFormatVersion(getFormatVersion());
      }

    public bool  hasPartialTranscript()
      {
        return flagHasPartialTranscript;
      }

    public string  getPartialTranscript()
      {
        Debug.Assert(flagHasPartialTranscript);
        return storePartialTranscript;
      }

    public bool  hasFinalPartialTranscript()
      {
        return flagHasFinalPartialTranscript;
      }

    public string  getFinalPartialTranscript()
      {
        //Debug.Assert(flagHasFinalPartialTranscript);
        return storeFinalPartialTranscript;
      }

    public bool  hasDurationMS()
      {
        return flagHasDurationMS;
      }

    public double  getDurationMS()
      {
        Debug.Assert(flagHasDurationMS);
        if (textStoreDurationMS != "")
          {
            return Double.Parse(textStoreDurationMS);
          }
        return storeDurationMS;
      }

    public string  getDurationMSAsText()
      {
        Debug.Assert(flagHasDurationMS);
        if (textStoreDurationMS == "")
          {
            return Convert.ToString(storeDurationMS);
          }
        else
          {
            return (textStoreDurationMS);
          }
      }

    public bool  hasDone()
      {
        return flagHasDone;
      }

    public bool  getDone()
      {
        Debug.Assert(flagHasDone);
        return storeDone;
      }

    public bool  hasSafeToStopAudio()
      {
        return flagHasSafeToStopAudio;
      }

    public bool  getSafeToStopAudio()
      {
        Debug.Assert(flagHasSafeToStopAudio);
        return storeSafeToStopAudio;
      }

    public bool  hasLocalOrRemote()
      {
        return flagHasLocalOrRemote;
      }

    public TypeLocalOrRemote  getLocalOrRemote()
      {
        Debug.Assert(flagHasLocalOrRemote);
        return storeLocalOrRemote;
      }

    public string  getLocalOrRemoteAsString()
      {
        return stringFromLocalOrRemote(getLocalOrRemote());
      }

    public bool  hasFinalPartialTranscriptTokens()
      {
        return flagHasFinalPartialTranscriptTokens;
      }

    public HoundTranscriptTokensJSON   getFinalPartialTranscriptTokens()
      {
        Debug.Assert(flagHasFinalPartialTranscriptTokens);
        return storeFinalPartialTranscriptTokens;
      }

    public bool  hasPartialTranscriptTokens()
      {
        return flagHasPartialTranscriptTokens;
      }

    public HoundTranscriptTokensJSON   getPartialTranscriptTokens()
      {
        Debug.Assert(flagHasPartialTranscriptTokens);
        return storePartialTranscriptTokens;
      }

    public bool  hasEntityDetection()
      {
        return flagHasEntityDetection;
      }

    public EntityDetectionJSON   getEntityDetection()
      {
        Debug.Assert(flagHasEntityDetection);
        return storeEntityDetection;
      }

    public bool  hasTopicIdentification()
      {
        return flagHasTopicIdentification;
      }

    public TopicIdentificationResultsJSON   getTopicIdentification()
      {
        Debug.Assert(flagHasTopicIdentification);
        return storeTopicIdentification;
      }


    public virtual int extraHoundPartialTranscriptComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHoundPartialTranscriptComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHoundPartialTranscriptComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHoundPartialTranscriptLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFormat(TypeFormat new_value)
      {
        flagHasFormat = true;
        storeFormat = new_value;
      }
    public void setFormat(string chars)
      {
        setFormat(stringToFormat(chars));
      }
    public void unsetFormat()
      {
        flagHasFormat = false;
      }
    public void setFormatVersion()
      {
        flagHasFormatVersion = true;
      }
    public void setFormatVersion(TypeFormatVersion new_value)
      {
        setFormatVersion();
      }
    public void setFormatVersion(string chars)
      {
        setFormatVersion(stringToFormatVersion(chars));
      }
    public void unsetFormatVersion()
      {
        flagHasFormatVersion = false;
      }
    public void setPartialTranscript(string new_value)
      {
        flagHasPartialTranscript = true;
        storePartialTranscript = new_value;
      }
    public void unsetPartialTranscript()
      {
        flagHasPartialTranscript = false;
      }
    public void setFinalPartialTranscript(string new_value)
      {
        flagHasFinalPartialTranscript = true;
        storeFinalPartialTranscript = new_value;
      }
    public void unsetFinalPartialTranscript()
      {
        flagHasFinalPartialTranscript = false;
      }
    public void setDurationMS(double new_value)
      {
        flagHasDurationMS = true;
        if (new_value < 0)
            throw new Exception("The value for field DurationMS of HoundPartialTranscriptJSON is less than the lower bound (0) for that field.");
        storeDurationMS = new_value;
        textStoreDurationMS = "";
      }
    public void setDurationMSText(string new_value)
      {
        flagHasDurationMS = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field DurationMS of HoundPartialTranscriptJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field DurationMS of HoundPartialTranscriptJSON is less than the lower bound (0) for that field.");
        textStoreDurationMS = new_value;
      }
    public void unsetDurationMS()
      {
        flagHasDurationMS = false;
      }
    public void setDone(bool new_value)
      {
        flagHasDone = true;
        storeDone = new_value;
      }
    public void unsetDone()
      {
        flagHasDone = false;
      }
    public void setSafeToStopAudio(bool new_value)
      {
        flagHasSafeToStopAudio = true;
        storeSafeToStopAudio = new_value;
      }
    public void unsetSafeToStopAudio()
      {
        flagHasSafeToStopAudio = false;
      }
    public void setLocalOrRemote(TypeLocalOrRemote new_value)
      {
        flagHasLocalOrRemote = true;
        storeLocalOrRemote = new_value;
      }
    public void setLocalOrRemote(string chars)
      {
        setLocalOrRemote(stringToLocalOrRemote(chars));
      }
    public void unsetLocalOrRemote()
      {
        flagHasLocalOrRemote = false;
      }
    public void setFinalPartialTranscriptTokens(HoundTranscriptTokensJSON  new_value)
      {
        if (flagHasFinalPartialTranscriptTokens)
          {
          }
        flagHasFinalPartialTranscriptTokens = true;
        storeFinalPartialTranscriptTokens = new_value;
      }
    public void unsetFinalPartialTranscriptTokens()
      {
        if (flagHasFinalPartialTranscriptTokens)
          {
          }
        flagHasFinalPartialTranscriptTokens = false;
      }
    public void setPartialTranscriptTokens(HoundTranscriptTokensJSON  new_value)
      {
        if (flagHasPartialTranscriptTokens)
          {
          }
        flagHasPartialTranscriptTokens = true;
        storePartialTranscriptTokens = new_value;
      }
    public void unsetPartialTranscriptTokens()
      {
        if (flagHasPartialTranscriptTokens)
          {
          }
        flagHasPartialTranscriptTokens = false;
      }
    public void setEntityDetection(EntityDetectionJSON  new_value)
      {
        if (flagHasEntityDetection)
          {
          }
        flagHasEntityDetection = true;
        storeEntityDetection = new_value;
      }
    public void unsetEntityDetection()
      {
        if (flagHasEntityDetection)
          {
          }
        flagHasEntityDetection = false;
      }
    public void setTopicIdentification(TopicIdentificationResultsJSON  new_value)
      {
        if (flagHasTopicIdentification)
          {
          }
        flagHasTopicIdentification = true;
        storeTopicIdentification = new_value;
      }
    public void unsetTopicIdentification()
      {
        if (flagHasTopicIdentification)
          {
          }
        flagHasTopicIdentification = false;
      }

    public virtual void extraHoundPartialTranscriptAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHoundPartialTranscriptSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHoundPartialTranscriptLookup(key);
        if (old_field == null)
          {
            extraHoundPartialTranscriptAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasFormat);
        if (flagHasFormat)
          {
            handler.start_pair("Format");
            switch (storeFormat)
              {
                case TypeFormat.Format_SoundHoundVoiceSearchParialTranscript:
                    handler.string_value("SoundHoundVoiceSearchParialTranscript");
                    break;
                case TypeFormat.Format_HoundVoiceQueryPartialTranscript:
                    handler.string_value("HoundVoiceQueryPartialTranscript");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasFormatVersion);
        if (flagHasFormatVersion)
          {
            handler.start_pair("FormatVersion");
            handler.string_value("1.0");
          }
        Debug.Assert(partial_allowed || flagHasPartialTranscript);
        if (flagHasPartialTranscript)
          {
            handler.start_pair("PartialTranscript");
            handler.string_value(storePartialTranscript);
          }
        if (flagHasFinalPartialTranscript)
          {
            handler.start_pair("FinalPartialTranscript");
            handler.string_value(storeFinalPartialTranscript);
          }
        Debug.Assert(partial_allowed || flagHasDurationMS);
        if (flagHasDurationMS)
          {
            handler.start_pair("DurationMS");
            if (textStoreDurationMS != "")
                handler.number_value(textStoreDurationMS);
            else if (((double)(long)storeDurationMS) == storeDurationMS)
                handler.number_value((long)storeDurationMS);
            else
                handler.number_value(storeDurationMS);
          }
        Debug.Assert(partial_allowed || flagHasDone);
        if (flagHasDone)
          {
            handler.start_pair("Done");
            handler.boolean_value(storeDone);
          }
        if (flagHasSafeToStopAudio)
          {
            handler.start_pair("SafeToStopAudio");
            handler.boolean_value(storeSafeToStopAudio);
          }
        if (flagHasLocalOrRemote)
          {
            handler.start_pair("LocalOrRemote");
            switch (storeLocalOrRemote)
              {
                case TypeLocalOrRemote.LocalOrRemote_Local:
                    handler.string_value("Local");
                    break;
                case TypeLocalOrRemote.LocalOrRemote_Remote:
                    handler.string_value("Remote");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasFinalPartialTranscriptTokens)
          {
            handler.start_pair("FinalPartialTranscriptTokens");
            if (partial_allowed)
                storeFinalPartialTranscriptTokens.write_partial_as_json(handler);
            else
                storeFinalPartialTranscriptTokens.write_as_json(handler);
          }
        if (flagHasPartialTranscriptTokens)
          {
            handler.start_pair("PartialTranscriptTokens");
            if (partial_allowed)
                storePartialTranscriptTokens.write_partial_as_json(handler);
            else
                storePartialTranscriptTokens.write_as_json(handler);
          }
        if (flagHasEntityDetection)
          {
            handler.start_pair("EntityDetection");
            if (partial_allowed)
                storeEntityDetection.write_partial_as_json(handler);
            else
                storeEntityDetection.write_as_json(handler);
          }
        if (flagHasTopicIdentification)
          {
            handler.start_pair("TopicIdentification");
            if (partial_allowed)
                storeTopicIdentification.write_partial_as_json(handler);
            else
                storeTopicIdentification.write_as_json(handler);
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
        if (!(hasFormat()))
          {
            return "When parsing the object for %what%, the \"Format\" field was missing.";
          }
        if (!(hasFormatVersion()))
          {
            return "When parsing the object for %what%, the \"FormatVersion\" field was missing.";
          }
        if (!(hasPartialTranscript()))
          {
            return "When parsing the object for %what%, the \"PartialTranscript\" field was missing.";
          }
        if (!(hasDurationMS()))
          {
            return "When parsing the object for %what%, the \"DurationMS\" field was missing.";
          }
        if (!(hasDone()))
          {
            return "When parsing the object for %what%, the \"Done\" field was missing.";
          }
        return null;
      }

    public static HoundPartialTranscriptJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundPartialTranscriptJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundPartialTranscript", ignore_extras);
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
    public static HoundPartialTranscriptJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HoundPartialTranscriptJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundPartialTranscriptJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundPartialTranscript", ignore_extras);
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
    public static HoundPartialTranscriptJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HoundPartialTranscriptJSON from_text(string text, bool ignore_extras)
      {
        HoundPartialTranscriptJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundPartialTranscript", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HoundPartialTranscriptJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HoundPartialTranscriptJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HoundPartialTranscriptJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundPartialTranscript", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorFormat : JSONStringGenerator
          {
            protected FieldGeneratorFormat(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFormat()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToFormat(result));
              }
            protected abstract void handle_result(TypeFormat result);
          };
    private class FieldHoldingGeneratorFormat : FieldGeneratorFormat
  {
    protected override void handle_result(TypeFormat result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFormat(String what)
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
    public TypeFormat value;
  };
    private class FieldHoldingArrayGeneratorFormat : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFormat
      {
        private FieldHoldingArrayGeneratorFormat top;

        protected override void handle_result(TypeFormat result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFormat init_top)
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
    protected virtual void handle_result(List<TypeFormat> result)
      {
      }

    public FieldHoldingArrayGeneratorFormat(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormat>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFormat()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormat>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFormat> value;
  };
        private FieldHoldingGeneratorFormat fieldGeneratorFormat;
    private abstract class FieldGeneratorFormatVersion : JSONStringGenerator
          {
            protected FieldGeneratorFormatVersion(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFormatVersion()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToFormatVersion(result));
              }
            protected abstract void handle_result(TypeFormatVersion result);
          };
    private class FieldHoldingGeneratorFormatVersion : FieldGeneratorFormatVersion
  {
    protected override void handle_result(TypeFormatVersion result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFormatVersion(String what)
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
    public TypeFormatVersion value;
  };
    private class FieldHoldingArrayGeneratorFormatVersion : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFormatVersion
      {
        private FieldHoldingArrayGeneratorFormatVersion top;

        protected override void handle_result(TypeFormatVersion result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFormatVersion init_top)
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
    protected virtual void handle_result(List<TypeFormatVersion> result)
      {
      }

    public FieldHoldingArrayGeneratorFormatVersion(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormatVersion>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFormatVersion()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormatVersion>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFormatVersion> value;
  };
        private FieldHoldingGeneratorFormatVersion fieldGeneratorFormatVersion;
        private JSONHoldingStringGenerator fieldGeneratorPartialTranscript;
        private JSONHoldingStringGenerator fieldGeneratorFinalPartialTranscript;
        private JSONHoldingNumberTextGenerator fieldGeneratorDurationMS;
        private JSONHoldingBooleanGenerator fieldGeneratorDone;
        private JSONHoldingBooleanGenerator fieldGeneratorSafeToStopAudio;
    private abstract class FieldGeneratorLocalOrRemote : JSONStringGenerator
          {
            protected FieldGeneratorLocalOrRemote(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorLocalOrRemote()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToLocalOrRemote(result));
              }
            protected abstract void handle_result(TypeLocalOrRemote result);
          };
    private class FieldHoldingGeneratorLocalOrRemote : FieldGeneratorLocalOrRemote
  {
    protected override void handle_result(TypeLocalOrRemote result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorLocalOrRemote(String what)
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
    public TypeLocalOrRemote value;
  };
    private class FieldHoldingArrayGeneratorLocalOrRemote : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLocalOrRemote
      {
        private FieldHoldingArrayGeneratorLocalOrRemote top;

        protected override void handle_result(TypeLocalOrRemote result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLocalOrRemote init_top)
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
    protected virtual void handle_result(List<TypeLocalOrRemote> result)
      {
      }

    public FieldHoldingArrayGeneratorLocalOrRemote(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLocalOrRemote>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLocalOrRemote()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLocalOrRemote>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLocalOrRemote> value;
  };
        private FieldHoldingGeneratorLocalOrRemote fieldGeneratorLocalOrRemote;
        private HoundTranscriptTokensJSON.HoldingGenerator fieldGeneratorFinalPartialTranscriptTokens;
        private HoundTranscriptTokensJSON.HoldingGenerator fieldGeneratorPartialTranscriptTokens;
        private EntityDetectionJSON.HoldingGenerator fieldGeneratorEntityDetection;
        private TopicIdentificationResultsJSON.HoldingGenerator fieldGeneratorTopicIdentification;
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
            HoundPartialTranscriptJSON result = new HoundPartialTranscriptJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHoundPartialTranscriptAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HoundPartialTranscriptJSON result)
          {
            if (fieldGeneratorFormat.have_value)
              {
                result.setFormat(fieldGeneratorFormat.value);
                fieldGeneratorFormat.have_value = false;
              }
            else if ((!(result.hasFormat())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Format\" field was missing.");
              }
            if (fieldGeneratorFormatVersion.have_value)
              {
                result.setFormatVersion();
                fieldGeneratorFormatVersion.have_value = false;
              }
            else if ((!(result.hasFormatVersion())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FormatVersion\" field was missing.");
              }
            if (fieldGeneratorPartialTranscript.have_value)
              {
                result.setPartialTranscript(fieldGeneratorPartialTranscript.value);
                fieldGeneratorPartialTranscript.have_value = false;
              }
            else if ((!(result.hasPartialTranscript())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PartialTranscript\" field was missing.");
              }
            if (fieldGeneratorFinalPartialTranscript.have_value)
              {
                result.setFinalPartialTranscript(fieldGeneratorFinalPartialTranscript.value);
                fieldGeneratorFinalPartialTranscript.have_value = false;
              }
            if (fieldGeneratorDurationMS.have_value)
              {
                result.setDurationMSText(fieldGeneratorDurationMS.value);
                fieldGeneratorDurationMS.have_value = false;
              }
            else if ((!(result.hasDurationMS())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DurationMS\" field was missing.");
              }
            if (fieldGeneratorDone.have_value)
              {
                result.setDone(fieldGeneratorDone.value);
                fieldGeneratorDone.have_value = false;
              }
            else if ((!(result.hasDone())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Done\" field was missing.");
              }
            if (fieldGeneratorSafeToStopAudio.have_value)
              {
                result.setSafeToStopAudio(fieldGeneratorSafeToStopAudio.value);
                fieldGeneratorSafeToStopAudio.have_value = false;
              }
            if (fieldGeneratorLocalOrRemote.have_value)
              {
                result.setLocalOrRemote(fieldGeneratorLocalOrRemote.value);
                fieldGeneratorLocalOrRemote.have_value = false;
              }
            if (fieldGeneratorFinalPartialTranscriptTokens.have_value)
              {
                result.setFinalPartialTranscriptTokens(fieldGeneratorFinalPartialTranscriptTokens.value);
                fieldGeneratorFinalPartialTranscriptTokens.have_value = false;
              }
            if (fieldGeneratorPartialTranscriptTokens.have_value)
              {
                result.setPartialTranscriptTokens(fieldGeneratorPartialTranscriptTokens.value);
                fieldGeneratorPartialTranscriptTokens.have_value = false;
              }
            if (fieldGeneratorEntityDetection.have_value)
              {
                result.setEntityDetection(fieldGeneratorEntityDetection.value);
                fieldGeneratorEntityDetection.have_value = false;
              }
            if (fieldGeneratorTopicIdentification.have_value)
              {
                result.setTopicIdentification(fieldGeneratorTopicIdentification.value);
                fieldGeneratorTopicIdentification.have_value = false;
              }
          }
        protected abstract void handle_result(HoundPartialTranscriptJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    switch (field_name[1])
                      {
                        case 'o':
                            if ((String.Compare(field_name, 2, "ne", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorDone;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rationMS", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorDurationMS;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "ntityDetection", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorEntityDetection;
                    break;
                case 'F':
                    switch (field_name[1])
                      {
                        case 'i':
                            if (String.Compare(field_name, 2, "nalPartialTranscript", 0, 20, false) == 0)
                              {
                                if (field_name.Length == 22)
                                  {
                                    return fieldGeneratorFinalPartialTranscript;
                                  }
                                switch (field_name[22])
                                  {
                                    case 'T':
                                        if ((String.Compare(field_name, 23, "okens", 0, 5, false) == 0) && (field_name.Length == 28))
                                            return fieldGeneratorFinalPartialTranscriptTokens;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "rmat", 0, 4, false) == 0)
                              {
                                if (field_name.Length == 6)
                                  {
                                    return fieldGeneratorFormat;
                                  }
                                switch (field_name[6])
                                  {
                                    case 'V':
                                        if ((String.Compare(field_name, 7, "ersion", 0, 6, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorFormatVersion;
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
                case 'L':
                    if ((String.Compare(field_name, 1, "ocalOrRemote", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorLocalOrRemote;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "artialTranscript", 0, 16, false) == 0)
                      {
                        if (field_name.Length == 17)
                          {
                            return fieldGeneratorPartialTranscript;
                          }
                        switch (field_name[17])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 18, "okens", 0, 5, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorPartialTranscriptTokens;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "afeToStopAudio", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorSafeToStopAudio;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "opicIdentification", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorTopicIdentification;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFormat = new FieldHoldingGeneratorFormat("field \"Format\" of the HoundPartialTranscript class");
            fieldGeneratorFormatVersion = new FieldHoldingGeneratorFormatVersion("field \"FormatVersion\" of the HoundPartialTranscript class");
            fieldGeneratorPartialTranscript = new JSONHoldingStringGenerator("field \"PartialTranscript\" of the HoundPartialTranscript class");
            fieldGeneratorFinalPartialTranscript = new JSONHoldingStringGenerator("field \"FinalPartialTranscript\" of the HoundPartialTranscript class");
            fieldGeneratorDurationMS = new JSONHoldingNumberTextGenerator("field \"DurationMS\" of the HoundPartialTranscript class");
            fieldGeneratorDone = new JSONHoldingBooleanGenerator("field \"Done\" of the HoundPartialTranscript class");
            fieldGeneratorSafeToStopAudio = new JSONHoldingBooleanGenerator("field \"SafeToStopAudio\" of the HoundPartialTranscript class");
            fieldGeneratorLocalOrRemote = new FieldHoldingGeneratorLocalOrRemote("field \"LocalOrRemote\" of the HoundPartialTranscript class");
            fieldGeneratorFinalPartialTranscriptTokens = new HoundTranscriptTokensJSON.HoldingGenerator("field \"FinalPartialTranscriptTokens\" of the HoundPartialTranscript class", ignore_extras);
            fieldGeneratorPartialTranscriptTokens = new HoundTranscriptTokensJSON.HoldingGenerator("field \"PartialTranscriptTokens\" of the HoundPartialTranscript class", ignore_extras);
            fieldGeneratorEntityDetection = new EntityDetectionJSON.HoldingGenerator("field \"EntityDetection\" of the HoundPartialTranscript class", ignore_extras);
            fieldGeneratorTopicIdentification = new TopicIdentificationResultsJSON.HoldingGenerator("field \"TopicIdentification\" of the HoundPartialTranscript class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HoundPartialTranscript class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFormat = new FieldHoldingGeneratorFormat("field \"Format\" of the HoundPartialTranscript class");
            fieldGeneratorFormatVersion = new FieldHoldingGeneratorFormatVersion("field \"FormatVersion\" of the HoundPartialTranscript class");
            fieldGeneratorPartialTranscript = new JSONHoldingStringGenerator("field \"PartialTranscript\" of the HoundPartialTranscript class");
            fieldGeneratorFinalPartialTranscript = new JSONHoldingStringGenerator("field \"FinalPartialTranscript\" of the HoundPartialTranscript class");
            fieldGeneratorDurationMS = new JSONHoldingNumberTextGenerator("field \"DurationMS\" of the HoundPartialTranscript class");
            fieldGeneratorDone = new JSONHoldingBooleanGenerator("field \"Done\" of the HoundPartialTranscript class");
            fieldGeneratorSafeToStopAudio = new JSONHoldingBooleanGenerator("field \"SafeToStopAudio\" of the HoundPartialTranscript class");
            fieldGeneratorLocalOrRemote = new FieldHoldingGeneratorLocalOrRemote("field \"LocalOrRemote\" of the HoundPartialTranscript class");
            fieldGeneratorFinalPartialTranscriptTokens = new HoundTranscriptTokensJSON.HoldingGenerator("field \"FinalPartialTranscriptTokens\" of the HoundPartialTranscript class", false);
            fieldGeneratorPartialTranscriptTokens = new HoundTranscriptTokensJSON.HoldingGenerator("field \"PartialTranscriptTokens\" of the HoundPartialTranscript class", false);
            fieldGeneratorEntityDetection = new EntityDetectionJSON.HoldingGenerator("field \"EntityDetection\" of the HoundPartialTranscript class", false);
            fieldGeneratorTopicIdentification = new TopicIdentificationResultsJSON.HoldingGenerator("field \"TopicIdentification\" of the HoundPartialTranscript class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HoundPartialTranscript class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFormat.reset();
            fieldGeneratorFormatVersion.reset();
            fieldGeneratorPartialTranscript.reset();
            fieldGeneratorFinalPartialTranscript.reset();
            fieldGeneratorDurationMS.reset();
            fieldGeneratorDone.reset();
            fieldGeneratorSafeToStopAudio.reset();
            fieldGeneratorLocalOrRemote.reset();
            fieldGeneratorFinalPartialTranscriptTokens.reset();
            fieldGeneratorPartialTranscriptTokens.reset();
            fieldGeneratorEntityDetection.reset();
            fieldGeneratorTopicIdentification.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFinalPartialTranscriptTokens.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPartialTranscriptTokens.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEntityDetection.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTopicIdentification.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFinalPartialTranscriptTokens.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPartialTranscriptTokens.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEntityDetection.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTopicIdentification.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HoundPartialTranscriptJSON  result)
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
        public HoundPartialTranscriptJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HoundPartialTranscriptJSON  result)
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
    protected virtual void handle_result(List<HoundPartialTranscriptJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HoundPartialTranscriptJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HoundPartialTranscriptJSON>();
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
    public List<HoundPartialTranscriptJSON> value;
  };
  };
