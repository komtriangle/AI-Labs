/* file "ReadSpeakerVoiceParametersJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ReadSpeakerVoiceParametersJSON : JSONBase
  {
    private bool flagHasPitch;
    private byte storePitch;
    private bool flagHasSpeed;
    private short storeSpeed;
    private bool flagHasVolume;
    private short storeVolume;
    private bool flagHasPause;
    private int storePause;
    private bool flagHasDictIdx;
    private short storeDictIdx;
    private bool flagHasCommaPause;
    private int storeCommaPause;
    private bool flagHasParenthesisNum;
    private BigInteger storeParenthesisNum;
    private bool flagHasEmphasisFactor;
    private BigInteger storeEmphasisFactor;
    private bool flagHasSampleRate;
    private BigInteger storeSampleRate;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPitch(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        byte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Pitch of ReadSpeakerVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Pitch of ReadSpeakerVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (byte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (byte)(json_integer.getLongInt())        ;
          }
        setPitch(extracted_integer);
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
                throw new Exception("The value for field Speed of ReadSpeakerVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Speed of ReadSpeakerVoiceParametersJSON is not an integer.");
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
        short extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Volume of ReadSpeakerVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Volume of ReadSpeakerVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (short)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (short)(json_integer.getLongInt())        ;
          }
        setVolume(extracted_integer);
      }


    private void  fromJSONPause(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        int extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Pause of ReadSpeakerVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Pause of ReadSpeakerVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (int)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (int)(json_integer.getLongInt())        ;
          }
        setPause(extracted_integer);
      }


    private void  fromJSONDictIdx(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        short extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DictIdx of ReadSpeakerVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DictIdx of ReadSpeakerVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (short)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (short)(json_integer.getLongInt())        ;
          }
        setDictIdx(extracted_integer);
      }


    private void  fromJSONCommaPause(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        int extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CommaPause of ReadSpeakerVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CommaPause of ReadSpeakerVoiceParametersJSON is not an integer.");
              }
            extracted_integer = (int)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (int)(json_integer.getLongInt())        ;
          }
        setCommaPause(extracted_integer);
      }


    private void  fromJSONParenthesisNum(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ParenthesisNum of ReadSpeakerVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ParenthesisNum of ReadSpeakerVoiceParametersJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setParenthesisNum(extracted_integer);
      }


    private void  fromJSONEmphasisFactor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field EmphasisFactor of ReadSpeakerVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field EmphasisFactor of ReadSpeakerVoiceParametersJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setEmphasisFactor(extracted_integer);
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
                throw new Exception("The value for field SampleRate of ReadSpeakerVoiceParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SampleRate of ReadSpeakerVoiceParametersJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSampleRate(extracted_integer);
      }


    public ReadSpeakerVoiceParametersJSON()
      {
        flagHasPitch = false;
        flagHasSpeed = false;
        flagHasVolume = false;
        flagHasPause = false;
        flagHasDictIdx = false;
        flagHasCommaPause = false;
        flagHasParenthesisNum = false;
        flagHasEmphasisFactor = false;
        flagHasSampleRate = false;
        storePitch = 100;
        storeSpeed = 100;
        storeVolume = 100;
        storePause = 687;
        storeDictIdx = 0;
        storeCommaPause = 200;
        storeParenthesisNum = 0;
        storeEmphasisFactor = 0;
        storeSampleRate = 16000;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPitch()
      {
        return flagHasPitch;
      }

    public byte  getPitch()
      {
        return storePitch;
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

    public short  getVolume()
      {
        return storeVolume;
      }

    public bool  hasPause()
      {
        return flagHasPause;
      }

    public int  getPause()
      {
        return storePause;
      }

    public bool  hasDictIdx()
      {
        return flagHasDictIdx;
      }

    public short  getDictIdx()
      {
        return storeDictIdx;
      }

    public bool  hasCommaPause()
      {
        return flagHasCommaPause;
      }

    public int  getCommaPause()
      {
        return storeCommaPause;
      }

    public bool  hasParenthesisNum()
      {
        return flagHasParenthesisNum;
      }

    public BigInteger  getParenthesisNum()
      {
        return storeParenthesisNum;
      }

    public bool  hasEmphasisFactor()
      {
        return flagHasEmphasisFactor;
      }

    public BigInteger  getEmphasisFactor()
      {
        return storeEmphasisFactor;
      }

    public bool  hasSampleRate()
      {
        return flagHasSampleRate;
      }

    public BigInteger  getSampleRate()
      {
        return storeSampleRate;
      }


    public virtual int extraReadSpeakerVoiceParametersComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraReadSpeakerVoiceParametersComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraReadSpeakerVoiceParametersComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraReadSpeakerVoiceParametersLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPitch(byte new_value)
      {
        flagHasPitch = true;
        if (new_value < 50)
            throw new Exception("The value for field Pitch of ReadSpeakerVoiceParametersJSON is less than the lower bound (50) for that field.");
        if (new_value > 200)
            throw new Exception("The value for field Pitch of ReadSpeakerVoiceParametersJSON is greater than the upper bound (200) for that field.");
        storePitch = new_value;
      }
    public void unsetPitch()
      {
        flagHasPitch = false;
      }
    public void setSpeed(short new_value)
      {
        flagHasSpeed = true;
        if (new_value < 50)
            throw new Exception("The value for field Speed of ReadSpeakerVoiceParametersJSON is less than the lower bound (50) for that field.");
        if (new_value > 400)
            throw new Exception("The value for field Speed of ReadSpeakerVoiceParametersJSON is greater than the upper bound (400) for that field.");
        storeSpeed = new_value;
      }
    public void unsetSpeed()
      {
        flagHasSpeed = false;
      }
    public void setVolume(short new_value)
      {
        flagHasVolume = true;
        if (new_value < 0)
            throw new Exception("The value for field Volume of ReadSpeakerVoiceParametersJSON is less than the lower bound (0) for that field.");
        if (new_value > 500)
            throw new Exception("The value for field Volume of ReadSpeakerVoiceParametersJSON is greater than the upper bound (500) for that field.");
        storeVolume = new_value;
      }
    public void unsetVolume()
      {
        flagHasVolume = false;
      }
    public void setPause(int new_value)
      {
        flagHasPause = true;
        if (new_value < 0)
            throw new Exception("The value for field Pause of ReadSpeakerVoiceParametersJSON is less than the lower bound (0) for that field.");
        if (new_value > 65536)
            throw new Exception("The value for field Pause of ReadSpeakerVoiceParametersJSON is greater than the upper bound (65536) for that field.");
        storePause = new_value;
      }
    public void unsetPause()
      {
        flagHasPause = false;
      }
    public void setDictIdx(short new_value)
      {
        flagHasDictIdx = true;
        if (new_value < 0)
            throw new Exception("The value for field DictIdx of ReadSpeakerVoiceParametersJSON is less than the lower bound (0) for that field.");
        if (new_value > 1023)
            throw new Exception("The value for field DictIdx of ReadSpeakerVoiceParametersJSON is greater than the upper bound (1023) for that field.");
        storeDictIdx = new_value;
      }
    public void unsetDictIdx()
      {
        flagHasDictIdx = false;
      }
    public void setCommaPause(int new_value)
      {
        flagHasCommaPause = true;
        if (new_value < 0)
            throw new Exception("The value for field CommaPause of ReadSpeakerVoiceParametersJSON is less than the lower bound (0) for that field.");
        if (new_value > 65536)
            throw new Exception("The value for field CommaPause of ReadSpeakerVoiceParametersJSON is greater than the upper bound (65536) for that field.");
        storeCommaPause = new_value;
      }
    public void unsetCommaPause()
      {
        flagHasCommaPause = false;
      }
    public void setParenthesisNum(BigInteger new_value)
      {
        flagHasParenthesisNum = true;
        if (new_value < 0)
            throw new Exception("The value for field ParenthesisNum of ReadSpeakerVoiceParametersJSON is less than the lower bound (0) for that field.");
        storeParenthesisNum = new_value;
      }
    public void unsetParenthesisNum()
      {
        flagHasParenthesisNum = false;
      }
    public void setEmphasisFactor(BigInteger new_value)
      {
        flagHasEmphasisFactor = true;
        storeEmphasisFactor = new_value;
      }
    public void unsetEmphasisFactor()
      {
        flagHasEmphasisFactor = false;
      }
    public void setSampleRate(BigInteger new_value)
      {
        flagHasSampleRate = true;
        if (new_value < 0)
            throw new Exception("The value for field SampleRate of ReadSpeakerVoiceParametersJSON is less than the lower bound (0) for that field.");
        storeSampleRate = new_value;
      }
    public void unsetSampleRate()
      {
        flagHasSampleRate = false;
      }

    public virtual void extraReadSpeakerVoiceParametersAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraReadSpeakerVoiceParametersSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraReadSpeakerVoiceParametersLookup(key);
        if (old_field == null)
          {
            extraReadSpeakerVoiceParametersAppendPair(key, new_component);
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
        if (flagHasPitch)
          {
            handler.start_pair("Pitch");
            handler.number_value(storePitch);
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
        if (flagHasPause)
          {
            handler.start_pair("Pause");
            handler.number_value(storePause);
          }
        if (flagHasDictIdx)
          {
            handler.start_pair("DictIdx");
            handler.number_value(storeDictIdx);
          }
        if (flagHasCommaPause)
          {
            handler.start_pair("CommaPause");
            handler.number_value(storeCommaPause);
          }
        if (flagHasParenthesisNum)
          {
            handler.start_pair("ParenthesisNum");
            handler.number_value(storeParenthesisNum);
          }
        if (flagHasEmphasisFactor)
          {
            handler.start_pair("EmphasisFactor");
            handler.number_value(storeEmphasisFactor);
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

    public static ReadSpeakerVoiceParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ReadSpeakerVoiceParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ReadSpeakerVoiceParameters", ignore_extras);
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
    public static ReadSpeakerVoiceParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ReadSpeakerVoiceParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ReadSpeakerVoiceParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ReadSpeakerVoiceParameters", ignore_extras);
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
    public static ReadSpeakerVoiceParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ReadSpeakerVoiceParametersJSON from_text(string text, bool ignore_extras)
      {
        ReadSpeakerVoiceParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ReadSpeakerVoiceParameters", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ReadSpeakerVoiceParametersJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ReadSpeakerVoiceParametersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ReadSpeakerVoiceParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ReadSpeakerVoiceParameters", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorPitch : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorPitch(String what) : base(what, 50, 200)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPitch : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPitch(String what) : base(what, 50, 200)
              {
              }
          };
        private FieldHoldingGeneratorPitch fieldGeneratorPitch;
    private class FieldHoldingGeneratorSpeed : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorSpeed(String what) : base(what, 50, 400)
              {
              }
          };
    private class FieldHoldingArrayGeneratorSpeed : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorSpeed(String what) : base(what, 50, 400)
              {
              }
          };
        private FieldHoldingGeneratorSpeed fieldGeneratorSpeed;
    private class FieldHoldingGeneratorVolume : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorVolume(String what) : base(what, 0, 500)
              {
              }
          };
    private class FieldHoldingArrayGeneratorVolume : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorVolume(String what) : base(what, 0, 500)
              {
              }
          };
        private FieldHoldingGeneratorVolume fieldGeneratorVolume;
    private class FieldHoldingGeneratorPause : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorPause(String what) : base(what, 0, 65536)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPause : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPause(String what) : base(what, 0, 65536)
              {
              }
          };
        private FieldHoldingGeneratorPause fieldGeneratorPause;
    private class FieldHoldingGeneratorDictIdx : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorDictIdx(String what) : base(what, 0, 1023)
              {
              }
          };
    private class FieldHoldingArrayGeneratorDictIdx : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorDictIdx(String what) : base(what, 0, 1023)
              {
              }
          };
        private FieldHoldingGeneratorDictIdx fieldGeneratorDictIdx;
    private class FieldHoldingGeneratorCommaPause : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorCommaPause(String what) : base(what, 0, 65536)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCommaPause : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCommaPause(String what) : base(what, 0, 65536)
              {
              }
          };
        private FieldHoldingGeneratorCommaPause fieldGeneratorCommaPause;
    private class FieldHoldingGeneratorParenthesisNum : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorParenthesisNum(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorParenthesisNum : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorParenthesisNum(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorParenthesisNum fieldGeneratorParenthesisNum;
    private class FieldHoldingGeneratorEmphasisFactor : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorEmphasisFactor(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorEmphasisFactor : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorEmphasisFactor(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorEmphasisFactor fieldGeneratorEmphasisFactor;
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
            ReadSpeakerVoiceParametersJSON result = new ReadSpeakerVoiceParametersJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraReadSpeakerVoiceParametersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ReadSpeakerVoiceParametersJSON result)
          {
            if (fieldGeneratorPitch.have_value)
              {
                result.setPitch((byte)(fieldGeneratorPitch.value));
                fieldGeneratorPitch.have_value = false;
              }
            if (fieldGeneratorSpeed.have_value)
              {
                result.setSpeed((short)(fieldGeneratorSpeed.value));
                fieldGeneratorSpeed.have_value = false;
              }
            if (fieldGeneratorVolume.have_value)
              {
                result.setVolume((short)(fieldGeneratorVolume.value));
                fieldGeneratorVolume.have_value = false;
              }
            if (fieldGeneratorPause.have_value)
              {
                result.setPause((int)(fieldGeneratorPause.value));
                fieldGeneratorPause.have_value = false;
              }
            if (fieldGeneratorDictIdx.have_value)
              {
                result.setDictIdx((short)(fieldGeneratorDictIdx.value));
                fieldGeneratorDictIdx.have_value = false;
              }
            if (fieldGeneratorCommaPause.have_value)
              {
                result.setCommaPause((int)(fieldGeneratorCommaPause.value));
                fieldGeneratorCommaPause.have_value = false;
              }
            if (fieldGeneratorParenthesisNum.have_value)
              {
                result.setParenthesisNum(fieldGeneratorParenthesisNum.value);
                fieldGeneratorParenthesisNum.have_value = false;
              }
            if (fieldGeneratorEmphasisFactor.have_value)
              {
                result.setEmphasisFactor(fieldGeneratorEmphasisFactor.value);
                fieldGeneratorEmphasisFactor.have_value = false;
              }
            if (fieldGeneratorSampleRate.have_value)
              {
                result.setSampleRate(fieldGeneratorSampleRate.value);
                fieldGeneratorSampleRate.have_value = false;
              }
          }
        protected abstract void handle_result(ReadSpeakerVoiceParametersJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ommaPause", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorCommaPause;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ictIdx", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorDictIdx;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "mphasisFactor", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorEmphasisFactor;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'a':
                            switch (field_name[2])
                              {
                                case 'r':
                                    if ((String.Compare(field_name, 3, "enthesisNum", 0, 11, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorParenthesisNum;
                                    break;
                                case 'u':
                                    if ((String.Compare(field_name, 3, "se", 0, 2, false) == 0) && (field_name.Length == 5))
                                        return fieldGeneratorPause;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "tch", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorPitch;
                            break;
                        default:
                            break;
                      }
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
                case 'V':
                    if ((String.Compare(field_name, 1, "olume", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorVolume;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPitch = new FieldHoldingGeneratorPitch("field \"Pitch\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorSpeed = new FieldHoldingGeneratorSpeed("field \"Speed\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorVolume = new FieldHoldingGeneratorVolume("field \"Volume\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorPause = new FieldHoldingGeneratorPause("field \"Pause\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorDictIdx = new FieldHoldingGeneratorDictIdx("field \"DictIdx\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorCommaPause = new FieldHoldingGeneratorCommaPause("field \"CommaPause\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorParenthesisNum = new FieldHoldingGeneratorParenthesisNum("field \"ParenthesisNum\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorEmphasisFactor = new FieldHoldingGeneratorEmphasisFactor("field \"EmphasisFactor\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorSampleRate = new FieldHoldingGeneratorSampleRate("field \"SampleRate\" of the ReadSpeakerVoiceParameters class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ReadSpeakerVoiceParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPitch = new FieldHoldingGeneratorPitch("field \"Pitch\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorSpeed = new FieldHoldingGeneratorSpeed("field \"Speed\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorVolume = new FieldHoldingGeneratorVolume("field \"Volume\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorPause = new FieldHoldingGeneratorPause("field \"Pause\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorDictIdx = new FieldHoldingGeneratorDictIdx("field \"DictIdx\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorCommaPause = new FieldHoldingGeneratorCommaPause("field \"CommaPause\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorParenthesisNum = new FieldHoldingGeneratorParenthesisNum("field \"ParenthesisNum\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorEmphasisFactor = new FieldHoldingGeneratorEmphasisFactor("field \"EmphasisFactor\" of the ReadSpeakerVoiceParameters class");
            fieldGeneratorSampleRate = new FieldHoldingGeneratorSampleRate("field \"SampleRate\" of the ReadSpeakerVoiceParameters class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ReadSpeakerVoiceParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPitch.reset();
            fieldGeneratorSpeed.reset();
            fieldGeneratorVolume.reset();
            fieldGeneratorPause.reset();
            fieldGeneratorDictIdx.reset();
            fieldGeneratorCommaPause.reset();
            fieldGeneratorParenthesisNum.reset();
            fieldGeneratorEmphasisFactor.reset();
            fieldGeneratorSampleRate.reset();
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
        protected override void handle_result(ReadSpeakerVoiceParametersJSON  result)
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
        public ReadSpeakerVoiceParametersJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ReadSpeakerVoiceParametersJSON  result)
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
    protected virtual void handle_result(List<ReadSpeakerVoiceParametersJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ReadSpeakerVoiceParametersJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ReadSpeakerVoiceParametersJSON>();
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
    public List<ReadSpeakerVoiceParametersJSON> value;
  };
  };
