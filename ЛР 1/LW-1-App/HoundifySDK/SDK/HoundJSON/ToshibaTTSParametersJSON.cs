/* file "ToshibaTTSParametersJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ToshibaTTSParametersJSON : JSONBase
  {
    private bool flagHasSpeed;
    private sbyte storeSpeed;
    private bool flagHasVolume;
    private sbyte storeVolume;
    private bool flagHasPitch;
    private sbyte storePitch;
    private bool flagHasDepth;
    private sbyte storeDepth;
    private bool flagHasSampleRate;
    private BigInteger storeSampleRate;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSpeed(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Speed of ToshibaTTSParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Speed of ToshibaTTSParametersJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setSpeed(extracted_integer);
      }


    private void  fromJSONVolume(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Volume of ToshibaTTSParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Volume of ToshibaTTSParametersJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setVolume(extracted_integer);
      }


    private void  fromJSONPitch(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Pitch of ToshibaTTSParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Pitch of ToshibaTTSParametersJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setPitch(extracted_integer);
      }


    private void  fromJSONDepth(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Depth of ToshibaTTSParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Depth of ToshibaTTSParametersJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setDepth(extracted_integer);
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
                throw new Exception("The value for field SampleRate of ToshibaTTSParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SampleRate of ToshibaTTSParametersJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSampleRate(extracted_integer);
      }


    public ToshibaTTSParametersJSON()
      {
        flagHasSpeed = false;
        flagHasVolume = false;
        flagHasPitch = false;
        flagHasDepth = false;
        flagHasSampleRate = false;
        storeSpeed = 0;
        storeVolume = 50;
        storePitch = 0;
        storeDepth = 0;
        storeSampleRate = 44100;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSpeed()
      {
        return flagHasSpeed;
      }

    public sbyte  getSpeed()
      {
        return storeSpeed;
      }

    public bool  hasVolume()
      {
        return flagHasVolume;
      }

    public sbyte  getVolume()
      {
        return storeVolume;
      }

    public bool  hasPitch()
      {
        return flagHasPitch;
      }

    public sbyte  getPitch()
      {
        return storePitch;
      }

    public bool  hasDepth()
      {
        return flagHasDepth;
      }

    public sbyte  getDepth()
      {
        return storeDepth;
      }

    public bool  hasSampleRate()
      {
        return flagHasSampleRate;
      }

    public BigInteger  getSampleRate()
      {
        return storeSampleRate;
      }


    public virtual int extraToshibaTTSParametersComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraToshibaTTSParametersComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraToshibaTTSParametersComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraToshibaTTSParametersLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSpeed(sbyte new_value)
      {
        flagHasSpeed = true;
        if (new_value < -10)
            throw new Exception("The value for field Speed of ToshibaTTSParametersJSON is less than the lower bound (-10) for that field.");
        if (new_value > 10)
            throw new Exception("The value for field Speed of ToshibaTTSParametersJSON is greater than the upper bound (10) for that field.");
        storeSpeed = new_value;
      }
    public void unsetSpeed()
      {
        flagHasSpeed = false;
      }
    public void setVolume(sbyte new_value)
      {
        flagHasVolume = true;
        if (new_value < 0)
            throw new Exception("The value for field Volume of ToshibaTTSParametersJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field Volume of ToshibaTTSParametersJSON is greater than the upper bound (100) for that field.");
        storeVolume = new_value;
      }
    public void unsetVolume()
      {
        flagHasVolume = false;
      }
    public void setPitch(sbyte new_value)
      {
        flagHasPitch = true;
        if (new_value < -10)
            throw new Exception("The value for field Pitch of ToshibaTTSParametersJSON is less than the lower bound (-10) for that field.");
        if (new_value > 10)
            throw new Exception("The value for field Pitch of ToshibaTTSParametersJSON is greater than the upper bound (10) for that field.");
        storePitch = new_value;
      }
    public void unsetPitch()
      {
        flagHasPitch = false;
      }
    public void setDepth(sbyte new_value)
      {
        flagHasDepth = true;
        if (new_value < -4)
            throw new Exception("The value for field Depth of ToshibaTTSParametersJSON is less than the lower bound (-4) for that field.");
        if (new_value > 4)
            throw new Exception("The value for field Depth of ToshibaTTSParametersJSON is greater than the upper bound (4) for that field.");
        storeDepth = new_value;
      }
    public void unsetDepth()
      {
        flagHasDepth = false;
      }
    public void setSampleRate(BigInteger new_value)
      {
        flagHasSampleRate = true;
        if (new_value < 0)
            throw new Exception("The value for field SampleRate of ToshibaTTSParametersJSON is less than the lower bound (0) for that field.");
        storeSampleRate = new_value;
      }
    public void unsetSampleRate()
      {
        flagHasSampleRate = false;
      }

    public virtual void extraToshibaTTSParametersAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraToshibaTTSParametersSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraToshibaTTSParametersLookup(key);
        if (old_field == null)
          {
            extraToshibaTTSParametersAppendPair(key, new_component);
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
        if (flagHasPitch)
          {
            handler.start_pair("Pitch");
            handler.number_value(storePitch);
          }
        if (flagHasDepth)
          {
            handler.start_pair("Depth");
            handler.number_value(storeDepth);
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

    public static ToshibaTTSParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ToshibaTTSParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ToshibaTTSParameters", ignore_extras);
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
    public static ToshibaTTSParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ToshibaTTSParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ToshibaTTSParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ToshibaTTSParameters", ignore_extras);
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
    public static ToshibaTTSParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ToshibaTTSParametersJSON from_text(string text, bool ignore_extras)
      {
        ToshibaTTSParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ToshibaTTSParameters", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ToshibaTTSParametersJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ToshibaTTSParametersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ToshibaTTSParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ToshibaTTSParameters", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorSpeed : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorSpeed(String what) : base(what, -10, 10)
              {
              }
          };
    private class FieldHoldingArrayGeneratorSpeed : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorSpeed(String what) : base(what, -10, 10)
              {
              }
          };
        private FieldHoldingGeneratorSpeed fieldGeneratorSpeed;
    private class FieldHoldingGeneratorVolume : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorVolume(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorVolume : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorVolume(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorVolume fieldGeneratorVolume;
    private class FieldHoldingGeneratorPitch : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorPitch(String what) : base(what, -10, 10)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPitch : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPitch(String what) : base(what, -10, 10)
              {
              }
          };
        private FieldHoldingGeneratorPitch fieldGeneratorPitch;
    private class FieldHoldingGeneratorDepth : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorDepth(String what) : base(what, -4, 4)
              {
              }
          };
    private class FieldHoldingArrayGeneratorDepth : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorDepth(String what) : base(what, -4, 4)
              {
              }
          };
        private FieldHoldingGeneratorDepth fieldGeneratorDepth;
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
            ToshibaTTSParametersJSON result = new ToshibaTTSParametersJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraToshibaTTSParametersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ToshibaTTSParametersJSON result)
          {
            if (fieldGeneratorSpeed.have_value)
              {
                result.setSpeed((sbyte)(fieldGeneratorSpeed.value));
                fieldGeneratorSpeed.have_value = false;
              }
            if (fieldGeneratorVolume.have_value)
              {
                result.setVolume((sbyte)(fieldGeneratorVolume.value));
                fieldGeneratorVolume.have_value = false;
              }
            if (fieldGeneratorPitch.have_value)
              {
                result.setPitch((sbyte)(fieldGeneratorPitch.value));
                fieldGeneratorPitch.have_value = false;
              }
            if (fieldGeneratorDepth.have_value)
              {
                result.setDepth((sbyte)(fieldGeneratorDepth.value));
                fieldGeneratorDepth.have_value = false;
              }
            if (fieldGeneratorSampleRate.have_value)
              {
                result.setSampleRate(fieldGeneratorSampleRate.value);
                fieldGeneratorSampleRate.have_value = false;
              }
          }
        protected abstract void handle_result(ToshibaTTSParametersJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "epth", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorDepth;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "itch", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorPitch;
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
            fieldGeneratorSpeed = new FieldHoldingGeneratorSpeed("field \"Speed\" of the ToshibaTTSParameters class");
            fieldGeneratorVolume = new FieldHoldingGeneratorVolume("field \"Volume\" of the ToshibaTTSParameters class");
            fieldGeneratorPitch = new FieldHoldingGeneratorPitch("field \"Pitch\" of the ToshibaTTSParameters class");
            fieldGeneratorDepth = new FieldHoldingGeneratorDepth("field \"Depth\" of the ToshibaTTSParameters class");
            fieldGeneratorSampleRate = new FieldHoldingGeneratorSampleRate("field \"SampleRate\" of the ToshibaTTSParameters class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ToshibaTTSParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpeed = new FieldHoldingGeneratorSpeed("field \"Speed\" of the ToshibaTTSParameters class");
            fieldGeneratorVolume = new FieldHoldingGeneratorVolume("field \"Volume\" of the ToshibaTTSParameters class");
            fieldGeneratorPitch = new FieldHoldingGeneratorPitch("field \"Pitch\" of the ToshibaTTSParameters class");
            fieldGeneratorDepth = new FieldHoldingGeneratorDepth("field \"Depth\" of the ToshibaTTSParameters class");
            fieldGeneratorSampleRate = new FieldHoldingGeneratorSampleRate("field \"SampleRate\" of the ToshibaTTSParameters class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ToshibaTTSParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSpeed.reset();
            fieldGeneratorVolume.reset();
            fieldGeneratorPitch.reset();
            fieldGeneratorDepth.reset();
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
        protected override void handle_result(ToshibaTTSParametersJSON  result)
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
        public ToshibaTTSParametersJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ToshibaTTSParametersJSON  result)
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
    protected virtual void handle_result(List<ToshibaTTSParametersJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ToshibaTTSParametersJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ToshibaTTSParametersJSON>();
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
    public List<ToshibaTTSParametersJSON> value;
  };
  };
