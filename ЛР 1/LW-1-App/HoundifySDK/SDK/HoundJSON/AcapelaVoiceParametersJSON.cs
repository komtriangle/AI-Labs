/* file "AcapelaVoiceParametersJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class AcapelaVoiceParametersJSON : JSONBase
  {
    public enum TypeReadingMode
      {
        ReadingMode_Text,
        ReadingMode_Word,
        ReadingMode_Letter
      };

    public static TypeReadingMode  stringToReadingMode(string chars)
      {
        switch (chars[0])
          {
            case 'L':
                if ((String.Compare(chars, 1, "etter", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeReadingMode.ReadingMode_Letter;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "ext", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeReadingMode.ReadingMode_Text;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "ord", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeReadingMode.ReadingMode_Word;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `ReadingMode' is not one of the legal values.");
      }

    public static string  stringFromReadingMode(TypeReadingMode the_enum)
      {
        switch (the_enum)
          {
            case TypeReadingMode.ReadingMode_Text:
                return "Text";
            case TypeReadingMode.ReadingMode_Word:
                return "Word";
            case TypeReadingMode.ReadingMode_Letter:
                return "Letter";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasUseFilter;
    private bool storeUseFilter;
    private bool flagHasFilterValue1;
    private byte storeFilterValue1;
    private bool flagHasFilterValue2;
    private byte storeFilterValue2;
    private bool flagHasFilterValue3;
    private byte storeFilterValue3;
    private bool flagHasFilterValue4;
    private byte storeFilterValue4;
    private bool flagHasLeadingSilence;
    private short storeLeadingSilence;
    private bool flagHasTrailingSilence;
    private short storeTrailingSilence;
    private bool flagHasAudioBoost;
    private sbyte storeAudioBoost;
    private bool flagHasPausePunct;
    private AcapelaPauseValueJSON  storePausePunct;
    private bool flagHasPauseSemicolon;
    private AcapelaPauseValueJSON  storePauseSemicolon;
    private bool flagHasPauseComma;
    private AcapelaPauseValueJSON  storePauseComma;
    private bool flagHasPauseBracket;
    private AcapelaPauseValueJSON  storePauseBracket;
    private bool flagHasPauseSpell;
    private AcapelaPauseValueJSON  storePauseSpell;
    private bool flagHasVoiceShaping;
    private byte storeVoiceShaping;
    private bool flagHasReadingMode;
    private TypeReadingMode storeReadingMode;
    private bool flagHasSpeed;
    private short storeSpeed;
    private bool flagHasVolume;
    private byte storeVolume;
    private bool flagHasDisableSAPITags;
    private bool storeDisableSAPITags;
    private bool flagHasUseMaxAvailableSamplingRate;
    private bool storeUseMaxAvailableSamplingRate;
    private bool flagHasSampleRate;
    private BigInteger storeSampleRate;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONUseFilter(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UseFilter of AcapelaVoiceParametersJSON is not true for false.");
              }
          }
        setUseFilter(the_bool);
      }


    private void  fromJSONFilterValue1(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        byte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FilterValue1 of AcapelaVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FilterValue1 of AcapelaVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (byte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (byte)(json_integer.getLongInt())        ;
          }
        setFilterValue1(extracted_integer);
      }


    private void  fromJSONFilterValue2(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        byte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FilterValue2 of AcapelaVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FilterValue2 of AcapelaVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (byte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (byte)(json_integer.getLongInt())        ;
          }
        setFilterValue2(extracted_integer);
      }


    private void  fromJSONFilterValue3(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        byte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FilterValue3 of AcapelaVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FilterValue3 of AcapelaVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (byte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (byte)(json_integer.getLongInt())        ;
          }
        setFilterValue3(extracted_integer);
      }


    private void  fromJSONFilterValue4(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        byte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FilterValue4 of AcapelaVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FilterValue4 of AcapelaVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (byte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (byte)(json_integer.getLongInt())        ;
          }
        setFilterValue4(extracted_integer);
      }


    private void  fromJSONLeadingSilence(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        short extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field LeadingSilence of AcapelaVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field LeadingSilence of AcapelaVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (short)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (short)(json_integer.getLongInt())        ;
          }
        setLeadingSilence(extracted_integer);
      }


    private void  fromJSONTrailingSilence(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        short extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TrailingSilence of AcapelaVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TrailingSilence of AcapelaVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (short)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (short)(json_integer.getLongInt())        ;
          }
        setTrailingSilence(extracted_integer);
      }


    private void  fromJSONAudioBoost(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field AudioBoost of AcapelaVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AudioBoost of AcapelaVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setAudioBoost(extracted_integer);
      }


    private void  fromJSONPausePunct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AcapelaPauseValueJSON convert_classy = AcapelaPauseValueJSON.from_json(json_value, ignore_extras, true);
        setPausePunct(convert_classy);
      }


    private void  fromJSONPauseSemicolon(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AcapelaPauseValueJSON convert_classy = AcapelaPauseValueJSON.from_json(json_value, ignore_extras, true);
        setPauseSemicolon(convert_classy);
      }


    private void  fromJSONPauseComma(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AcapelaPauseValueJSON convert_classy = AcapelaPauseValueJSON.from_json(json_value, ignore_extras, true);
        setPauseComma(convert_classy);
      }


    private void  fromJSONPauseBracket(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AcapelaPauseValueJSON convert_classy = AcapelaPauseValueJSON.from_json(json_value, ignore_extras, true);
        setPauseBracket(convert_classy);
      }


    private void  fromJSONPauseSpell(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AcapelaPauseValueJSON convert_classy = AcapelaPauseValueJSON.from_json(json_value, ignore_extras, true);
        setPauseSpell(convert_classy);
      }


    private void  fromJSONVoiceShaping(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        byte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field VoiceShaping of AcapelaVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field VoiceShaping of AcapelaVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (byte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (byte)(json_integer.getLongInt())        ;
          }
        setVoiceShaping(extracted_integer);
      }


    private void  fromJSONReadingMode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ReadingMode of AcapelaVoiceParametersJSON is not a string.");
        TypeReadingMode the_enum;
        switch (json_string.getData()[0])
          {
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "etter", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeReadingMode.ReadingMode_Letter;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "ext", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeReadingMode.ReadingMode_Text;
                        goto enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "ord", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeReadingMode.ReadingMode_Word;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field ReadingMode of AcapelaVoiceParametersJSON is not one of the legal strings.");
      enum_is_done:;
        setReadingMode(the_enum);
      }


    private void  fromJSONSpeed(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        short extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Speed of AcapelaVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Speed of AcapelaVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (short)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (short)(json_integer.getLongInt())        ;
          }
        setSpeed(extracted_integer);
      }


    private void  fromJSONVolume(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        byte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Volume of AcapelaVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Volume of AcapelaVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (byte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (byte)(json_integer.getLongInt())        ;
          }
        setVolume(extracted_integer);
      }


    private void  fromJSONDisableSAPITags(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DisableSAPITags of AcapelaVoiceParametersJSON is not true for false.");
              }
          }
        setDisableSAPITags(the_bool);
      }


    private void  fromJSONUseMaxAvailableSamplingRate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UseMaxAvailableSamplingRate of AcapelaVoiceParametersJSON is not true for false.");
              }
          }
        setUseMaxAvailableSamplingRate(the_bool);
      }


    private void  fromJSONSampleRate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SampleRate of AcapelaVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SampleRate of AcapelaVoiceParametersJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSampleRate(extracted_integer);
      }


    public AcapelaVoiceParametersJSON()
      {
        flagHasUseFilter = false;
        flagHasFilterValue1 = false;
        flagHasFilterValue2 = false;
        flagHasFilterValue3 = false;
        flagHasFilterValue4 = false;
        flagHasLeadingSilence = false;
        flagHasTrailingSilence = false;
        flagHasAudioBoost = false;
        flagHasPausePunct = false;
        flagHasPauseSemicolon = false;
        flagHasPauseComma = false;
        flagHasPauseBracket = false;
        flagHasPauseSpell = false;
        flagHasVoiceShaping = false;
        flagHasReadingMode = false;
        flagHasSpeed = false;
        flagHasVolume = false;
        flagHasDisableSAPITags = false;
        flagHasUseMaxAvailableSamplingRate = false;
        flagHasSampleRate = false;
        storeUseFilter = false;
        storeFilterValue1 = 100;
        storeFilterValue2 = 100;
        storeFilterValue3 = 100;
        storeFilterValue4 = 100;
        storeLeadingSilence = 50;
        storeTrailingSilence = 500;
        storeAudioBoost = 0;
        storeVoiceShaping = 100;
        storeSpeed = 100;
        storeVolume = 100;
        storeSampleRate = 16000;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasUseFilter()
      {
        return flagHasUseFilter;
      }

    public bool  getUseFilter()
      {
        return storeUseFilter;
      }

    public bool  hasFilterValue1()
      {
        return flagHasFilterValue1;
      }

    public byte  getFilterValue1()
      {
        return storeFilterValue1;
      }

    public bool  hasFilterValue2()
      {
        return flagHasFilterValue2;
      }

    public byte  getFilterValue2()
      {
        return storeFilterValue2;
      }

    public bool  hasFilterValue3()
      {
        return flagHasFilterValue3;
      }

    public byte  getFilterValue3()
      {
        return storeFilterValue3;
      }

    public bool  hasFilterValue4()
      {
        return flagHasFilterValue4;
      }

    public byte  getFilterValue4()
      {
        return storeFilterValue4;
      }

    public bool  hasLeadingSilence()
      {
        return flagHasLeadingSilence;
      }

    public short  getLeadingSilence()
      {
        return storeLeadingSilence;
      }

    public bool  hasTrailingSilence()
      {
        return flagHasTrailingSilence;
      }

    public short  getTrailingSilence()
      {
        return storeTrailingSilence;
      }

    public bool  hasAudioBoost()
      {
        return flagHasAudioBoost;
      }

    public sbyte  getAudioBoost()
      {
        return storeAudioBoost;
      }

    public bool  hasPausePunct()
      {
        return flagHasPausePunct;
      }

    public AcapelaPauseValueJSON   getPausePunct()
      {
        Debug.Assert(flagHasPausePunct);
        return storePausePunct;
      }

    public AcapelaPauseValueJSON.TypeValue  getPausePunctValue()
      {
        return getPausePunct().getValue();
      }

    public string  getPausePunctAsString()
      {
        return getPausePunct().getValueAsString();
      }

    public bool  hasPauseSemicolon()
      {
        return flagHasPauseSemicolon;
      }

    public AcapelaPauseValueJSON   getPauseSemicolon()
      {
        Debug.Assert(flagHasPauseSemicolon);
        return storePauseSemicolon;
      }

    public AcapelaPauseValueJSON.TypeValue  getPauseSemicolonValue()
      {
        return getPauseSemicolon().getValue();
      }

    public string  getPauseSemicolonAsString()
      {
        return getPauseSemicolon().getValueAsString();
      }

    public bool  hasPauseComma()
      {
        return flagHasPauseComma;
      }

    public AcapelaPauseValueJSON   getPauseComma()
      {
        Debug.Assert(flagHasPauseComma);
        return storePauseComma;
      }

    public AcapelaPauseValueJSON.TypeValue  getPauseCommaValue()
      {
        return getPauseComma().getValue();
      }

    public string  getPauseCommaAsString()
      {
        return getPauseComma().getValueAsString();
      }

    public bool  hasPauseBracket()
      {
        return flagHasPauseBracket;
      }

    public AcapelaPauseValueJSON   getPauseBracket()
      {
        Debug.Assert(flagHasPauseBracket);
        return storePauseBracket;
      }

    public AcapelaPauseValueJSON.TypeValue  getPauseBracketValue()
      {
        return getPauseBracket().getValue();
      }

    public string  getPauseBracketAsString()
      {
        return getPauseBracket().getValueAsString();
      }

    public bool  hasPauseSpell()
      {
        return flagHasPauseSpell;
      }

    public AcapelaPauseValueJSON   getPauseSpell()
      {
        Debug.Assert(flagHasPauseSpell);
        return storePauseSpell;
      }

    public AcapelaPauseValueJSON.TypeValue  getPauseSpellValue()
      {
        return getPauseSpell().getValue();
      }

    public string  getPauseSpellAsString()
      {
        return getPauseSpell().getValueAsString();
      }

    public bool  hasVoiceShaping()
      {
        return flagHasVoiceShaping;
      }

    public byte  getVoiceShaping()
      {
        return storeVoiceShaping;
      }

    public bool  hasReadingMode()
      {
        return flagHasReadingMode;
      }

    public TypeReadingMode  getReadingMode()
      {
        Debug.Assert(flagHasReadingMode);
        return storeReadingMode;
      }

    public string  getReadingModeAsString()
      {
        return stringFromReadingMode(getReadingMode());
      }

    public bool  hasSpeed()
      {
        return flagHasSpeed;
      }

    public short  getSpeed()
      {
        return storeSpeed;
      }

    public bool  hasVolume()
      {
        return flagHasVolume;
      }

    public byte  getVolume()
      {
        return storeVolume;
      }

    public bool  hasDisableSAPITags()
      {
        return flagHasDisableSAPITags;
      }

    public bool  getDisableSAPITags()
      {
        Debug.Assert(flagHasDisableSAPITags);
        return storeDisableSAPITags;
      }

    public bool  hasUseMaxAvailableSamplingRate()
      {
        return flagHasUseMaxAvailableSamplingRate;
      }

    public bool  getUseMaxAvailableSamplingRate()
      {
        Debug.Assert(flagHasUseMaxAvailableSamplingRate);
        return storeUseMaxAvailableSamplingRate;
      }

    public bool  hasSampleRate()
      {
        return flagHasSampleRate;
      }

    public BigInteger  getSampleRate()
      {
        return storeSampleRate;
      }


    public virtual int extraAcapelaVoiceParametersComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAcapelaVoiceParametersComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAcapelaVoiceParametersComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAcapelaVoiceParametersLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setUseFilter(bool new_value)
      {
        flagHasUseFilter = true;
        storeUseFilter = new_value;
      }
    public void unsetUseFilter()
      {
        flagHasUseFilter = false;
      }
    public void setFilterValue1(byte new_value)
      {
        flagHasFilterValue1 = true;
        if (new_value < 0)
            throw new Exception("The value for field FilterValue1 of AcapelaVoiceParametersJSON is less than the lower bound (0) for that field.");
        if (new_value > 200)
            throw new Exception("The value for field FilterValue1 of AcapelaVoiceParametersJSON is greater than the upper bound (200) for that field.");
        storeFilterValue1 = new_value;
      }
    public void unsetFilterValue1()
      {
        flagHasFilterValue1 = false;
      }
    public void setFilterValue2(byte new_value)
      {
        flagHasFilterValue2 = true;
        if (new_value < 0)
            throw new Exception("The value for field FilterValue2 of AcapelaVoiceParametersJSON is less than the lower bound (0) for that field.");
        if (new_value > 200)
            throw new Exception("The value for field FilterValue2 of AcapelaVoiceParametersJSON is greater than the upper bound (200) for that field.");
        storeFilterValue2 = new_value;
      }
    public void unsetFilterValue2()
      {
        flagHasFilterValue2 = false;
      }
    public void setFilterValue3(byte new_value)
      {
        flagHasFilterValue3 = true;
        if (new_value < 0)
            throw new Exception("The value for field FilterValue3 of AcapelaVoiceParametersJSON is less than the lower bound (0) for that field.");
        if (new_value > 200)
            throw new Exception("The value for field FilterValue3 of AcapelaVoiceParametersJSON is greater than the upper bound (200) for that field.");
        storeFilterValue3 = new_value;
      }
    public void unsetFilterValue3()
      {
        flagHasFilterValue3 = false;
      }
    public void setFilterValue4(byte new_value)
      {
        flagHasFilterValue4 = true;
        if (new_value < 0)
            throw new Exception("The value for field FilterValue4 of AcapelaVoiceParametersJSON is less than the lower bound (0) for that field.");
        if (new_value > 200)
            throw new Exception("The value for field FilterValue4 of AcapelaVoiceParametersJSON is greater than the upper bound (200) for that field.");
        storeFilterValue4 = new_value;
      }
    public void unsetFilterValue4()
      {
        flagHasFilterValue4 = false;
      }
    public void setLeadingSilence(short new_value)
      {
        flagHasLeadingSilence = true;
        if (new_value < 20)
            throw new Exception("The value for field LeadingSilence of AcapelaVoiceParametersJSON is less than the lower bound (20) for that field.");
        if (new_value > 5000)
            throw new Exception("The value for field LeadingSilence of AcapelaVoiceParametersJSON is greater than the upper bound (5000) for that field.");
        storeLeadingSilence = new_value;
      }
    public void unsetLeadingSilence()
      {
        flagHasLeadingSilence = false;
      }
    public void setTrailingSilence(short new_value)
      {
        flagHasTrailingSilence = true;
        if (new_value < 20)
            throw new Exception("The value for field TrailingSilence of AcapelaVoiceParametersJSON is less than the lower bound (20) for that field.");
        if (new_value > 5000)
            throw new Exception("The value for field TrailingSilence of AcapelaVoiceParametersJSON is greater than the upper bound (5000) for that field.");
        storeTrailingSilence = new_value;
      }
    public void unsetTrailingSilence()
      {
        flagHasTrailingSilence = false;
      }
    public void setAudioBoost(sbyte new_value)
      {
        flagHasAudioBoost = true;
        if (new_value < 0)
            throw new Exception("The value for field AudioBoost of AcapelaVoiceParametersJSON is less than the lower bound (0) for that field.");
        if (new_value > 90)
            throw new Exception("The value for field AudioBoost of AcapelaVoiceParametersJSON is greater than the upper bound (90) for that field.");
        storeAudioBoost = new_value;
      }
    public void unsetAudioBoost()
      {
        flagHasAudioBoost = false;
      }
    public void setPausePunct(AcapelaPauseValueJSON  new_value)
      {
        if (flagHasPausePunct)
          {
          }
        flagHasPausePunct = true;
        storePausePunct = new_value;
      }
    public void setPausePunct(AcapelaPauseValueJSON.TypeValue new_value)
      {
        setPausePunct(new AcapelaPauseValueJSON(new_value));
      }
    public void setPausePunct(string chars)
      {
        AcapelaPauseValueJSON.TypeValueKnownValues known = AcapelaPauseValueJSON.stringToValue(chars);
        AcapelaPauseValueJSON.TypeValue new_value = new AcapelaPauseValueJSON.TypeValue();
        if (known == AcapelaPauseValueJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPausePunct(new_value);
      }
    public void unsetPausePunct()
      {
        if (flagHasPausePunct)
          {
          }
        flagHasPausePunct = false;
      }
    public void setPauseSemicolon(AcapelaPauseValueJSON  new_value)
      {
        if (flagHasPauseSemicolon)
          {
          }
        flagHasPauseSemicolon = true;
        storePauseSemicolon = new_value;
      }
    public void setPauseSemicolon(AcapelaPauseValueJSON.TypeValue new_value)
      {
        setPauseSemicolon(new AcapelaPauseValueJSON(new_value));
      }
    public void setPauseSemicolon(string chars)
      {
        AcapelaPauseValueJSON.TypeValueKnownValues known = AcapelaPauseValueJSON.stringToValue(chars);
        AcapelaPauseValueJSON.TypeValue new_value = new AcapelaPauseValueJSON.TypeValue();
        if (known == AcapelaPauseValueJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPauseSemicolon(new_value);
      }
    public void unsetPauseSemicolon()
      {
        if (flagHasPauseSemicolon)
          {
          }
        flagHasPauseSemicolon = false;
      }
    public void setPauseComma(AcapelaPauseValueJSON  new_value)
      {
        if (flagHasPauseComma)
          {
          }
        flagHasPauseComma = true;
        storePauseComma = new_value;
      }
    public void setPauseComma(AcapelaPauseValueJSON.TypeValue new_value)
      {
        setPauseComma(new AcapelaPauseValueJSON(new_value));
      }
    public void setPauseComma(string chars)
      {
        AcapelaPauseValueJSON.TypeValueKnownValues known = AcapelaPauseValueJSON.stringToValue(chars);
        AcapelaPauseValueJSON.TypeValue new_value = new AcapelaPauseValueJSON.TypeValue();
        if (known == AcapelaPauseValueJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPauseComma(new_value);
      }
    public void unsetPauseComma()
      {
        if (flagHasPauseComma)
          {
          }
        flagHasPauseComma = false;
      }
    public void setPauseBracket(AcapelaPauseValueJSON  new_value)
      {
        if (flagHasPauseBracket)
          {
          }
        flagHasPauseBracket = true;
        storePauseBracket = new_value;
      }
    public void setPauseBracket(AcapelaPauseValueJSON.TypeValue new_value)
      {
        setPauseBracket(new AcapelaPauseValueJSON(new_value));
      }
    public void setPauseBracket(string chars)
      {
        AcapelaPauseValueJSON.TypeValueKnownValues known = AcapelaPauseValueJSON.stringToValue(chars);
        AcapelaPauseValueJSON.TypeValue new_value = new AcapelaPauseValueJSON.TypeValue();
        if (known == AcapelaPauseValueJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPauseBracket(new_value);
      }
    public void unsetPauseBracket()
      {
        if (flagHasPauseBracket)
          {
          }
        flagHasPauseBracket = false;
      }
    public void setPauseSpell(AcapelaPauseValueJSON  new_value)
      {
        if (flagHasPauseSpell)
          {
          }
        flagHasPauseSpell = true;
        storePauseSpell = new_value;
      }
    public void setPauseSpell(AcapelaPauseValueJSON.TypeValue new_value)
      {
        setPauseSpell(new AcapelaPauseValueJSON(new_value));
      }
    public void setPauseSpell(string chars)
      {
        AcapelaPauseValueJSON.TypeValueKnownValues known = AcapelaPauseValueJSON.stringToValue(chars);
        AcapelaPauseValueJSON.TypeValue new_value = new AcapelaPauseValueJSON.TypeValue();
        if (known == AcapelaPauseValueJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPauseSpell(new_value);
      }
    public void unsetPauseSpell()
      {
        if (flagHasPauseSpell)
          {
          }
        flagHasPauseSpell = false;
      }
    public void setVoiceShaping(byte new_value)
      {
        flagHasVoiceShaping = true;
        if (new_value < 50)
            throw new Exception("The value for field VoiceShaping of AcapelaVoiceParametersJSON is less than the lower bound (50) for that field.");
        if (new_value > 150)
            throw new Exception("The value for field VoiceShaping of AcapelaVoiceParametersJSON is greater than the upper bound (150) for that field.");
        storeVoiceShaping = new_value;
      }
    public void unsetVoiceShaping()
      {
        flagHasVoiceShaping = false;
      }
    public void setReadingMode(TypeReadingMode new_value)
      {
        flagHasReadingMode = true;
        storeReadingMode = new_value;
      }
    public void setReadingMode(string chars)
      {
        setReadingMode(stringToReadingMode(chars));
      }
    public void unsetReadingMode()
      {
        flagHasReadingMode = false;
      }
    public void setSpeed(short new_value)
      {
        flagHasSpeed = true;
        if (new_value < 30)
            throw new Exception("The value for field Speed of AcapelaVoiceParametersJSON is less than the lower bound (30) for that field.");
        if (new_value > 300)
            throw new Exception("The value for field Speed of AcapelaVoiceParametersJSON is greater than the upper bound (300) for that field.");
        storeSpeed = new_value;
      }
    public void unsetSpeed()
      {
        flagHasSpeed = false;
      }
    public void setVolume(byte new_value)
      {
        flagHasVolume = true;
        if (new_value < 0)
            throw new Exception("The value for field Volume of AcapelaVoiceParametersJSON is less than the lower bound (0) for that field.");
        if (new_value > 150)
            throw new Exception("The value for field Volume of AcapelaVoiceParametersJSON is greater than the upper bound (150) for that field.");
        storeVolume = new_value;
      }
    public void unsetVolume()
      {
        flagHasVolume = false;
      }
    public void setDisableSAPITags(bool new_value)
      {
        flagHasDisableSAPITags = true;
        storeDisableSAPITags = new_value;
      }
    public void unsetDisableSAPITags()
      {
        flagHasDisableSAPITags = false;
      }
    public void setUseMaxAvailableSamplingRate(bool new_value)
      {
        flagHasUseMaxAvailableSamplingRate = true;
        storeUseMaxAvailableSamplingRate = new_value;
      }
    public void unsetUseMaxAvailableSamplingRate()
      {
        flagHasUseMaxAvailableSamplingRate = false;
      }
    public void setSampleRate(BigInteger new_value)
      {
        flagHasSampleRate = true;
        if (new_value < 0)
            throw new Exception("The value for field SampleRate of AcapelaVoiceParametersJSON is less than the lower bound (0) for that field.");
        storeSampleRate = new_value;
      }
    public void unsetSampleRate()
      {
        flagHasSampleRate = false;
      }

    public virtual void extraAcapelaVoiceParametersAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAcapelaVoiceParametersSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAcapelaVoiceParametersLookup(key);
        if (old_field == null)
          {
            extraAcapelaVoiceParametersAppendPair(key, new_component);
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
        if (flagHasUseFilter)
          {
            handler.start_pair("UseFilter");
            handler.boolean_value(storeUseFilter);
          }
        if (flagHasFilterValue1)
          {
            handler.start_pair("FilterValue1");
            handler.number_value(storeFilterValue1);
          }
        if (flagHasFilterValue2)
          {
            handler.start_pair("FilterValue2");
            handler.number_value(storeFilterValue2);
          }
        if (flagHasFilterValue3)
          {
            handler.start_pair("FilterValue3");
            handler.number_value(storeFilterValue3);
          }
        if (flagHasFilterValue4)
          {
            handler.start_pair("FilterValue4");
            handler.number_value(storeFilterValue4);
          }
        if (flagHasLeadingSilence)
          {
            handler.start_pair("LeadingSilence");
            handler.number_value(storeLeadingSilence);
          }
        if (flagHasTrailingSilence)
          {
            handler.start_pair("TrailingSilence");
            handler.number_value(storeTrailingSilence);
          }
        if (flagHasAudioBoost)
          {
            handler.start_pair("AudioBoost");
            handler.number_value(storeAudioBoost);
          }
        if (flagHasPausePunct)
          {
            handler.start_pair("PausePunct");
            if (partial_allowed)
                storePausePunct.write_partial_as_json(handler);
            else
                storePausePunct.write_as_json(handler);
          }
        if (flagHasPauseSemicolon)
          {
            handler.start_pair("PauseSemicolon");
            if (partial_allowed)
                storePauseSemicolon.write_partial_as_json(handler);
            else
                storePauseSemicolon.write_as_json(handler);
          }
        if (flagHasPauseComma)
          {
            handler.start_pair("PauseComma");
            if (partial_allowed)
                storePauseComma.write_partial_as_json(handler);
            else
                storePauseComma.write_as_json(handler);
          }
        if (flagHasPauseBracket)
          {
            handler.start_pair("PauseBracket");
            if (partial_allowed)
                storePauseBracket.write_partial_as_json(handler);
            else
                storePauseBracket.write_as_json(handler);
          }
        if (flagHasPauseSpell)
          {
            handler.start_pair("PauseSpell");
            if (partial_allowed)
                storePauseSpell.write_partial_as_json(handler);
            else
                storePauseSpell.write_as_json(handler);
          }
        if (flagHasVoiceShaping)
          {
            handler.start_pair("VoiceShaping");
            handler.number_value(storeVoiceShaping);
          }
        if (flagHasReadingMode)
          {
            handler.start_pair("ReadingMode");
            switch (storeReadingMode)
              {
                case TypeReadingMode.ReadingMode_Text:
                    handler.string_value("Text");
                    break;
                case TypeReadingMode.ReadingMode_Word:
                    handler.string_value("Word");
                    break;
                case TypeReadingMode.ReadingMode_Letter:
                    handler.string_value("Letter");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasSpeed)
          {
            handler.start_pair("Speed");
            handler.number_value(storeSpeed);
          }
        if (flagHasVolume)
          {
            handler.start_pair("Volume");
            handler.number_value(storeVolume);
          }
        if (flagHasDisableSAPITags)
          {
            handler.start_pair("DisableSAPITags");
            handler.boolean_value(storeDisableSAPITags);
          }
        if (flagHasUseMaxAvailableSamplingRate)
          {
            handler.start_pair("UseMaxAvailableSamplingRate");
            handler.boolean_value(storeUseMaxAvailableSamplingRate);
          }
        if (flagHasSampleRate)
          {
            handler.start_pair("SampleRate");
            handler.number_value(storeSampleRate);
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

    public static AcapelaVoiceParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AcapelaVoiceParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AcapelaVoiceParameters", ignore_extras);
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
    public static AcapelaVoiceParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AcapelaVoiceParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AcapelaVoiceParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AcapelaVoiceParameters", ignore_extras);
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
    public static AcapelaVoiceParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AcapelaVoiceParametersJSON from_text(string text, bool ignore_extras)
      {
        AcapelaVoiceParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AcapelaVoiceParameters", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AcapelaVoiceParametersJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AcapelaVoiceParametersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AcapelaVoiceParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AcapelaVoiceParameters", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorUseFilter;
    private class FieldHoldingGeneratorFilterValue1 : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorFilterValue1(String what) : base(what, 0, 200)
              {
              }
          };
    private class FieldHoldingArrayGeneratorFilterValue1 : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorFilterValue1(String what) : base(what, 0, 200)
              {
              }
          };
        private FieldHoldingGeneratorFilterValue1 fieldGeneratorFilterValue1;
    private class FieldHoldingGeneratorFilterValue2 : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorFilterValue2(String what) : base(what, 0, 200)
              {
              }
          };
    private class FieldHoldingArrayGeneratorFilterValue2 : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorFilterValue2(String what) : base(what, 0, 200)
              {
              }
          };
        private FieldHoldingGeneratorFilterValue2 fieldGeneratorFilterValue2;
    private class FieldHoldingGeneratorFilterValue3 : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorFilterValue3(String what) : base(what, 0, 200)
              {
              }
          };
    private class FieldHoldingArrayGeneratorFilterValue3 : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorFilterValue3(String what) : base(what, 0, 200)
              {
              }
          };
        private FieldHoldingGeneratorFilterValue3 fieldGeneratorFilterValue3;
    private class FieldHoldingGeneratorFilterValue4 : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorFilterValue4(String what) : base(what, 0, 200)
              {
              }
          };
    private class FieldHoldingArrayGeneratorFilterValue4 : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorFilterValue4(String what) : base(what, 0, 200)
              {
              }
          };
        private FieldHoldingGeneratorFilterValue4 fieldGeneratorFilterValue4;
    private class FieldHoldingGeneratorLeadingSilence : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorLeadingSilence(String what) : base(what, 20, 5000)
              {
              }
          };
    private class FieldHoldingArrayGeneratorLeadingSilence : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorLeadingSilence(String what) : base(what, 20, 5000)
              {
              }
          };
        private FieldHoldingGeneratorLeadingSilence fieldGeneratorLeadingSilence;
    private class FieldHoldingGeneratorTrailingSilence : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorTrailingSilence(String what) : base(what, 20, 5000)
              {
              }
          };
    private class FieldHoldingArrayGeneratorTrailingSilence : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorTrailingSilence(String what) : base(what, 20, 5000)
              {
              }
          };
        private FieldHoldingGeneratorTrailingSilence fieldGeneratorTrailingSilence;
    private class FieldHoldingGeneratorAudioBoost : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorAudioBoost(String what) : base(what, 0, 90)
              {
              }
          };
    private class FieldHoldingArrayGeneratorAudioBoost : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorAudioBoost(String what) : base(what, 0, 90)
              {
              }
          };
        private FieldHoldingGeneratorAudioBoost fieldGeneratorAudioBoost;
        private AcapelaPauseValueJSON.HoldingGenerator fieldGeneratorPausePunct;
        private AcapelaPauseValueJSON.HoldingGenerator fieldGeneratorPauseSemicolon;
        private AcapelaPauseValueJSON.HoldingGenerator fieldGeneratorPauseComma;
        private AcapelaPauseValueJSON.HoldingGenerator fieldGeneratorPauseBracket;
        private AcapelaPauseValueJSON.HoldingGenerator fieldGeneratorPauseSpell;
    private class FieldHoldingGeneratorVoiceShaping : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorVoiceShaping(String what) : base(what, 50, 150)
              {
              }
          };
    private class FieldHoldingArrayGeneratorVoiceShaping : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorVoiceShaping(String what) : base(what, 50, 150)
              {
              }
          };
        private FieldHoldingGeneratorVoiceShaping fieldGeneratorVoiceShaping;
    private abstract class FieldGeneratorReadingMode : JSONStringGenerator
          {
            protected FieldGeneratorReadingMode(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorReadingMode()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToReadingMode(result));
              }
            protected abstract void handle_result(TypeReadingMode result);
          };
    private class FieldHoldingGeneratorReadingMode : FieldGeneratorReadingMode
  {
    protected override void handle_result(TypeReadingMode result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorReadingMode(String what)
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
    public TypeReadingMode value;
  };
    private class FieldHoldingArrayGeneratorReadingMode : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorReadingMode
      {
        private FieldHoldingArrayGeneratorReadingMode top;

        protected override void handle_result(TypeReadingMode result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorReadingMode init_top)
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
    protected virtual void handle_result(List<TypeReadingMode> result)
      {
      }

    public FieldHoldingArrayGeneratorReadingMode(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeReadingMode>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorReadingMode()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeReadingMode>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeReadingMode> value;
  };
        private FieldHoldingGeneratorReadingMode fieldGeneratorReadingMode;
    private class FieldHoldingGeneratorSpeed : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorSpeed(String what) : base(what, 30, 300)
              {
              }
          };
    private class FieldHoldingArrayGeneratorSpeed : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorSpeed(String what) : base(what, 30, 300)
              {
              }
          };
        private FieldHoldingGeneratorSpeed fieldGeneratorSpeed;
    private class FieldHoldingGeneratorVolume : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorVolume(String what) : base(what, 0, 150)
              {
              }
          };
    private class FieldHoldingArrayGeneratorVolume : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorVolume(String what) : base(what, 0, 150)
              {
              }
          };
        private FieldHoldingGeneratorVolume fieldGeneratorVolume;
        private JSONHoldingBooleanGenerator fieldGeneratorDisableSAPITags;
        private JSONHoldingBooleanGenerator fieldGeneratorUseMaxAvailableSamplingRate;
    private class FieldHoldingGeneratorSampleRate : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSampleRate(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSampleRate : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSampleRate(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSampleRate fieldGeneratorSampleRate;
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
            AcapelaVoiceParametersJSON result = new AcapelaVoiceParametersJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAcapelaVoiceParametersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(AcapelaVoiceParametersJSON result)
          {
            if (fieldGeneratorUseFilter.have_value)
              {
                result.setUseFilter(fieldGeneratorUseFilter.value);
                fieldGeneratorUseFilter.have_value = false;
              }
            if (fieldGeneratorFilterValue1.have_value)
              {
                result.setFilterValue1((byte)(fieldGeneratorFilterValue1.value));
                fieldGeneratorFilterValue1.have_value = false;
              }
            if (fieldGeneratorFilterValue2.have_value)
              {
                result.setFilterValue2((byte)(fieldGeneratorFilterValue2.value));
                fieldGeneratorFilterValue2.have_value = false;
              }
            if (fieldGeneratorFilterValue3.have_value)
              {
                result.setFilterValue3((byte)(fieldGeneratorFilterValue3.value));
                fieldGeneratorFilterValue3.have_value = false;
              }
            if (fieldGeneratorFilterValue4.have_value)
              {
                result.setFilterValue4((byte)(fieldGeneratorFilterValue4.value));
                fieldGeneratorFilterValue4.have_value = false;
              }
            if (fieldGeneratorLeadingSilence.have_value)
              {
                result.setLeadingSilence((short)(fieldGeneratorLeadingSilence.value));
                fieldGeneratorLeadingSilence.have_value = false;
              }
            if (fieldGeneratorTrailingSilence.have_value)
              {
                result.setTrailingSilence((short)(fieldGeneratorTrailingSilence.value));
                fieldGeneratorTrailingSilence.have_value = false;
              }
            if (fieldGeneratorAudioBoost.have_value)
              {
                result.setAudioBoost((sbyte)(fieldGeneratorAudioBoost.value));
                fieldGeneratorAudioBoost.have_value = false;
              }
            if (fieldGeneratorPausePunct.have_value)
              {
                result.setPausePunct(fieldGeneratorPausePunct.value);
                fieldGeneratorPausePunct.have_value = false;
              }
            if (fieldGeneratorPauseSemicolon.have_value)
              {
                result.setPauseSemicolon(fieldGeneratorPauseSemicolon.value);
                fieldGeneratorPauseSemicolon.have_value = false;
              }
            if (fieldGeneratorPauseComma.have_value)
              {
                result.setPauseComma(fieldGeneratorPauseComma.value);
                fieldGeneratorPauseComma.have_value = false;
              }
            if (fieldGeneratorPauseBracket.have_value)
              {
                result.setPauseBracket(fieldGeneratorPauseBracket.value);
                fieldGeneratorPauseBracket.have_value = false;
              }
            if (fieldGeneratorPauseSpell.have_value)
              {
                result.setPauseSpell(fieldGeneratorPauseSpell.value);
                fieldGeneratorPauseSpell.have_value = false;
              }
            if (fieldGeneratorVoiceShaping.have_value)
              {
                result.setVoiceShaping((byte)(fieldGeneratorVoiceShaping.value));
                fieldGeneratorVoiceShaping.have_value = false;
              }
            if (fieldGeneratorReadingMode.have_value)
              {
                result.setReadingMode(fieldGeneratorReadingMode.value);
                fieldGeneratorReadingMode.have_value = false;
              }
            if (fieldGeneratorSpeed.have_value)
              {
                result.setSpeed((short)(fieldGeneratorSpeed.value));
                fieldGeneratorSpeed.have_value = false;
              }
            if (fieldGeneratorVolume.have_value)
              {
                result.setVolume((byte)(fieldGeneratorVolume.value));
                fieldGeneratorVolume.have_value = false;
              }
            if (fieldGeneratorDisableSAPITags.have_value)
              {
                result.setDisableSAPITags(fieldGeneratorDisableSAPITags.value);
                fieldGeneratorDisableSAPITags.have_value = false;
              }
            if (fieldGeneratorUseMaxAvailableSamplingRate.have_value)
              {
                result.setUseMaxAvailableSamplingRate(fieldGeneratorUseMaxAvailableSamplingRate.value);
                fieldGeneratorUseMaxAvailableSamplingRate.have_value = false;
              }
            if (fieldGeneratorSampleRate.have_value)
              {
                result.setSampleRate(fieldGeneratorSampleRate.value);
                fieldGeneratorSampleRate.have_value = false;
              }
          }
        protected abstract void handle_result(AcapelaVoiceParametersJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "udioBoost", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorAudioBoost;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "isableSAPITags", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorDisableSAPITags;
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "ilterValue", 0, 10, false) == 0)
                      {
                        switch (field_name[11])
                          {
                            case '1':
                                if (field_name.Length == 12)
                                    return fieldGeneratorFilterValue1;
                                break;
                            case '2':
                                if (field_name.Length == 12)
                                    return fieldGeneratorFilterValue2;
                                break;
                            case '3':
                                if (field_name.Length == 12)
                                    return fieldGeneratorFilterValue3;
                                break;
                            case '4':
                                if (field_name.Length == 12)
                                    return fieldGeneratorFilterValue4;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "eadingSilence", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorLeadingSilence;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "ause", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'B':
                                if ((String.Compare(field_name, 6, "racket", 0, 6, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorPauseBracket;
                                break;
                            case 'C':
                                if ((String.Compare(field_name, 6, "omma", 0, 4, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorPauseComma;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 6, "unct", 0, 4, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorPausePunct;
                                break;
                            case 'S':
                                switch (field_name[6])
                                  {
                                    case 'e':
                                        if ((String.Compare(field_name, 7, "micolon", 0, 7, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorPauseSemicolon;
                                        break;
                                    case 'p':
                                        if ((String.Compare(field_name, 7, "ell", 0, 3, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorPauseSpell;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "eadingMode", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorReadingMode;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "mpleRate", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorSampleRate;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "eed", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorSpeed;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "railingSilence", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorTrailingSilence;
                    break;
                case 'U':
                    if (String.Compare(field_name, 1, "se", 0, 2, false) == 0)
                      {
                        switch (field_name[3])
                          {
                            case 'F':
                                if ((String.Compare(field_name, 4, "ilter", 0, 5, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorUseFilter;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 4, "axAvailableSamplingRate", 0, 23, false) == 0) && (field_name.Length == 27))
                                    return fieldGeneratorUseMaxAvailableSamplingRate;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'V':
                    if (String.Compare(field_name, 1, "o", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'i':
                                if ((String.Compare(field_name, 3, "ceShaping", 0, 9, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorVoiceShaping;
                                break;
                            case 'l':
                                if ((String.Compare(field_name, 3, "ume", 0, 3, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorVolume;
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
            fieldGeneratorUseFilter = new JSONHoldingBooleanGenerator("field \"UseFilter\" of the AcapelaVoiceParameters class");
            fieldGeneratorFilterValue1 = new FieldHoldingGeneratorFilterValue1("field \"FilterValue1\" of the AcapelaVoiceParameters class");
            fieldGeneratorFilterValue2 = new FieldHoldingGeneratorFilterValue2("field \"FilterValue2\" of the AcapelaVoiceParameters class");
            fieldGeneratorFilterValue3 = new FieldHoldingGeneratorFilterValue3("field \"FilterValue3\" of the AcapelaVoiceParameters class");
            fieldGeneratorFilterValue4 = new FieldHoldingGeneratorFilterValue4("field \"FilterValue4\" of the AcapelaVoiceParameters class");
            fieldGeneratorLeadingSilence = new FieldHoldingGeneratorLeadingSilence("field \"LeadingSilence\" of the AcapelaVoiceParameters class");
            fieldGeneratorTrailingSilence = new FieldHoldingGeneratorTrailingSilence("field \"TrailingSilence\" of the AcapelaVoiceParameters class");
            fieldGeneratorAudioBoost = new FieldHoldingGeneratorAudioBoost("field \"AudioBoost\" of the AcapelaVoiceParameters class");
            fieldGeneratorPausePunct = new AcapelaPauseValueJSON.HoldingGenerator("field \"PausePunct\" of the AcapelaVoiceParameters class", ignore_extras);
            fieldGeneratorPauseSemicolon = new AcapelaPauseValueJSON.HoldingGenerator("field \"PauseSemicolon\" of the AcapelaVoiceParameters class", ignore_extras);
            fieldGeneratorPauseComma = new AcapelaPauseValueJSON.HoldingGenerator("field \"PauseComma\" of the AcapelaVoiceParameters class", ignore_extras);
            fieldGeneratorPauseBracket = new AcapelaPauseValueJSON.HoldingGenerator("field \"PauseBracket\" of the AcapelaVoiceParameters class", ignore_extras);
            fieldGeneratorPauseSpell = new AcapelaPauseValueJSON.HoldingGenerator("field \"PauseSpell\" of the AcapelaVoiceParameters class", ignore_extras);
            fieldGeneratorVoiceShaping = new FieldHoldingGeneratorVoiceShaping("field \"VoiceShaping\" of the AcapelaVoiceParameters class");
            fieldGeneratorReadingMode = new FieldHoldingGeneratorReadingMode("field \"ReadingMode\" of the AcapelaVoiceParameters class");
            fieldGeneratorSpeed = new FieldHoldingGeneratorSpeed("field \"Speed\" of the AcapelaVoiceParameters class");
            fieldGeneratorVolume = new FieldHoldingGeneratorVolume("field \"Volume\" of the AcapelaVoiceParameters class");
            fieldGeneratorDisableSAPITags = new JSONHoldingBooleanGenerator("field \"DisableSAPITags\" of the AcapelaVoiceParameters class");
            fieldGeneratorUseMaxAvailableSamplingRate = new JSONHoldingBooleanGenerator("field \"UseMaxAvailableSamplingRate\" of the AcapelaVoiceParameters class");
            fieldGeneratorSampleRate = new FieldHoldingGeneratorSampleRate("field \"SampleRate\" of the AcapelaVoiceParameters class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AcapelaVoiceParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorUseFilter = new JSONHoldingBooleanGenerator("field \"UseFilter\" of the AcapelaVoiceParameters class");
            fieldGeneratorFilterValue1 = new FieldHoldingGeneratorFilterValue1("field \"FilterValue1\" of the AcapelaVoiceParameters class");
            fieldGeneratorFilterValue2 = new FieldHoldingGeneratorFilterValue2("field \"FilterValue2\" of the AcapelaVoiceParameters class");
            fieldGeneratorFilterValue3 = new FieldHoldingGeneratorFilterValue3("field \"FilterValue3\" of the AcapelaVoiceParameters class");
            fieldGeneratorFilterValue4 = new FieldHoldingGeneratorFilterValue4("field \"FilterValue4\" of the AcapelaVoiceParameters class");
            fieldGeneratorLeadingSilence = new FieldHoldingGeneratorLeadingSilence("field \"LeadingSilence\" of the AcapelaVoiceParameters class");
            fieldGeneratorTrailingSilence = new FieldHoldingGeneratorTrailingSilence("field \"TrailingSilence\" of the AcapelaVoiceParameters class");
            fieldGeneratorAudioBoost = new FieldHoldingGeneratorAudioBoost("field \"AudioBoost\" of the AcapelaVoiceParameters class");
            fieldGeneratorPausePunct = new AcapelaPauseValueJSON.HoldingGenerator("field \"PausePunct\" of the AcapelaVoiceParameters class", false);
            fieldGeneratorPauseSemicolon = new AcapelaPauseValueJSON.HoldingGenerator("field \"PauseSemicolon\" of the AcapelaVoiceParameters class", false);
            fieldGeneratorPauseComma = new AcapelaPauseValueJSON.HoldingGenerator("field \"PauseComma\" of the AcapelaVoiceParameters class", false);
            fieldGeneratorPauseBracket = new AcapelaPauseValueJSON.HoldingGenerator("field \"PauseBracket\" of the AcapelaVoiceParameters class", false);
            fieldGeneratorPauseSpell = new AcapelaPauseValueJSON.HoldingGenerator("field \"PauseSpell\" of the AcapelaVoiceParameters class", false);
            fieldGeneratorVoiceShaping = new FieldHoldingGeneratorVoiceShaping("field \"VoiceShaping\" of the AcapelaVoiceParameters class");
            fieldGeneratorReadingMode = new FieldHoldingGeneratorReadingMode("field \"ReadingMode\" of the AcapelaVoiceParameters class");
            fieldGeneratorSpeed = new FieldHoldingGeneratorSpeed("field \"Speed\" of the AcapelaVoiceParameters class");
            fieldGeneratorVolume = new FieldHoldingGeneratorVolume("field \"Volume\" of the AcapelaVoiceParameters class");
            fieldGeneratorDisableSAPITags = new JSONHoldingBooleanGenerator("field \"DisableSAPITags\" of the AcapelaVoiceParameters class");
            fieldGeneratorUseMaxAvailableSamplingRate = new JSONHoldingBooleanGenerator("field \"UseMaxAvailableSamplingRate\" of the AcapelaVoiceParameters class");
            fieldGeneratorSampleRate = new FieldHoldingGeneratorSampleRate("field \"SampleRate\" of the AcapelaVoiceParameters class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AcapelaVoiceParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorUseFilter.reset();
            fieldGeneratorFilterValue1.reset();
            fieldGeneratorFilterValue2.reset();
            fieldGeneratorFilterValue3.reset();
            fieldGeneratorFilterValue4.reset();
            fieldGeneratorLeadingSilence.reset();
            fieldGeneratorTrailingSilence.reset();
            fieldGeneratorAudioBoost.reset();
            fieldGeneratorPausePunct.reset();
            fieldGeneratorPauseSemicolon.reset();
            fieldGeneratorPauseComma.reset();
            fieldGeneratorPauseBracket.reset();
            fieldGeneratorPauseSpell.reset();
            fieldGeneratorVoiceShaping.reset();
            fieldGeneratorReadingMode.reset();
            fieldGeneratorSpeed.reset();
            fieldGeneratorVolume.reset();
            fieldGeneratorDisableSAPITags.reset();
            fieldGeneratorUseMaxAvailableSamplingRate.reset();
            fieldGeneratorSampleRate.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPausePunct.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPauseSemicolon.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPauseComma.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPauseBracket.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPauseSpell.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPausePunct.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPauseSemicolon.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPauseComma.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPauseBracket.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPauseSpell.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(AcapelaVoiceParametersJSON  result)
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
        public AcapelaVoiceParametersJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AcapelaVoiceParametersJSON  result)
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
    protected virtual void handle_result(List<AcapelaVoiceParametersJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AcapelaVoiceParametersJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AcapelaVoiceParametersJSON>();
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
    public List<AcapelaVoiceParametersJSON> value;
  };
  };
