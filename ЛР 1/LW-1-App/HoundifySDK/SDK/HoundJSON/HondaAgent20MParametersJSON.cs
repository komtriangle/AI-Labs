/* file "HondaAgent20MParametersJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HondaAgent20MParametersJSON : JSONBase
  {
    private bool flagHasTutorialType;
    private string storeTutorialType;
    private bool flagHasTutorialStep;
    private BigInteger storeTutorialStep;
    private bool flagHasDestination;
    private MapLocationJSON  storeDestination;
    private bool flagHasTemperature;
    private UnitsValue_TemperatureJSON  storeTemperature;
    private bool flagHasProbabilityOfPrecipitationPct;
    private sbyte storeProbabilityOfPrecipitationPct;
    private bool flagHasTrack;
    private MusicTrackJSON  storeTrack;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTutorialType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TutorialType of HondaAgent20MParametersJSON is not a string.");
        setTutorialType(json_string.getData());
      }


    private void  fromJSONTutorialStep(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TutorialStep of HondaAgent20MParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TutorialStep of HondaAgent20MParametersJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTutorialStep(extracted_integer);
      }


    private void  fromJSONDestination(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setDestination(convert_classy);
      }


    private void  fromJSONTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UnitsValue_TemperatureJSON convert_classy = UnitsValue_TemperatureJSON.from_json(json_value, ignore_extras, true);
        setTemperature(convert_classy);
      }


    private void  fromJSONProbabilityOfPrecipitationPct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ProbabilityOfPrecipitationPct of HondaAgent20MParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ProbabilityOfPrecipitationPct of HondaAgent20MParametersJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setProbabilityOfPrecipitationPct(extracted_integer);
      }


    private void  fromJSONTrack(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicTrackJSON convert_classy = MusicTrackJSON.from_json(json_value, ignore_extras, true);
        setTrack(convert_classy);
      }


    public HondaAgent20MParametersJSON()
      {
        flagHasTutorialType = false;
        flagHasTutorialStep = false;
        flagHasDestination = false;
        flagHasTemperature = false;
        flagHasProbabilityOfPrecipitationPct = false;
        flagHasTrack = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTutorialType()
      {
        return flagHasTutorialType;
      }

    public string  getTutorialType()
      {
        Debug.Assert(flagHasTutorialType);
        return storeTutorialType;
      }

    public bool  hasTutorialStep()
      {
        return flagHasTutorialStep;
      }

    public BigInteger  getTutorialStep()
      {
        Debug.Assert(flagHasTutorialStep);
        return storeTutorialStep;
      }

    public bool  hasDestination()
      {
        return flagHasDestination;
      }

    public MapLocationJSON   getDestination()
      {
        Debug.Assert(flagHasDestination);
        return storeDestination;
      }

    public bool  hasTemperature()
      {
        return flagHasTemperature;
      }

    public UnitsValue_TemperatureJSON   getTemperature()
      {
        Debug.Assert(flagHasTemperature);
        return storeTemperature;
      }

    public bool  hasProbabilityOfPrecipitationPct()
      {
        return flagHasProbabilityOfPrecipitationPct;
      }

    public sbyte  getProbabilityOfPrecipitationPct()
      {
        Debug.Assert(flagHasProbabilityOfPrecipitationPct);
        return storeProbabilityOfPrecipitationPct;
      }

    public bool  hasTrack()
      {
        return flagHasTrack;
      }

    public MusicTrackJSON   getTrack()
      {
        Debug.Assert(flagHasTrack);
        return storeTrack;
      }


    public virtual int extraHondaAgent20MParametersComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHondaAgent20MParametersComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHondaAgent20MParametersComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHondaAgent20MParametersLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTutorialType(string new_value)
      {
        flagHasTutorialType = true;
        storeTutorialType = new_value;
      }
    public void unsetTutorialType()
      {
        flagHasTutorialType = false;
      }
    public void setTutorialStep(BigInteger new_value)
      {
        flagHasTutorialStep = true;
        storeTutorialStep = new_value;
      }
    public void unsetTutorialStep()
      {
        flagHasTutorialStep = false;
      }
    public void setDestination(MapLocationJSON  new_value)
      {
        if (flagHasDestination)
          {
          }
        flagHasDestination = true;
        storeDestination = new_value;
      }
    public void unsetDestination()
      {
        if (flagHasDestination)
          {
          }
        flagHasDestination = false;
      }
    public void setTemperature(UnitsValue_TemperatureJSON  new_value)
      {
        if (flagHasTemperature)
          {
          }
        flagHasTemperature = true;
        storeTemperature = new_value;
      }
    public void unsetTemperature()
      {
        if (flagHasTemperature)
          {
          }
        flagHasTemperature = false;
      }
    public void setProbabilityOfPrecipitationPct(sbyte new_value)
      {
        flagHasProbabilityOfPrecipitationPct = true;
        if (new_value < 0)
            throw new Exception("The value for field ProbabilityOfPrecipitationPct of HondaAgent20MParametersJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field ProbabilityOfPrecipitationPct of HondaAgent20MParametersJSON is greater than the upper bound (100) for that field.");
        storeProbabilityOfPrecipitationPct = new_value;
      }
    public void unsetProbabilityOfPrecipitationPct()
      {
        flagHasProbabilityOfPrecipitationPct = false;
      }
    public void setTrack(MusicTrackJSON  new_value)
      {
        if (flagHasTrack)
          {
          }
        flagHasTrack = true;
        storeTrack = new_value;
      }
    public void unsetTrack()
      {
        if (flagHasTrack)
          {
          }
        flagHasTrack = false;
      }

    public virtual void extraHondaAgent20MParametersAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHondaAgent20MParametersSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHondaAgent20MParametersLookup(key);
        if (old_field == null)
          {
            extraHondaAgent20MParametersAppendPair(key, new_component);
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
        if (flagHasTutorialType)
          {
            handler.start_pair("TutorialType");
            handler.string_value(storeTutorialType);
          }
        if (flagHasTutorialStep)
          {
            handler.start_pair("TutorialStep");
            handler.number_value(storeTutorialStep);
          }
        if (flagHasDestination)
          {
            handler.start_pair("Destination");
            if (partial_allowed)
                storeDestination.write_partial_as_json(handler);
            else
                storeDestination.write_as_json(handler);
          }
        if (flagHasTemperature)
          {
            handler.start_pair("Temperature");
            if (partial_allowed)
                storeTemperature.write_partial_as_json(handler);
            else
                storeTemperature.write_as_json(handler);
          }
        if (flagHasProbabilityOfPrecipitationPct)
          {
            handler.start_pair("ProbabilityOfPrecipitationPct");
            handler.number_value(storeProbabilityOfPrecipitationPct);
          }
        if (flagHasTrack)
          {
            handler.start_pair("Track");
            if (partial_allowed)
                storeTrack.write_partial_as_json(handler);
            else
                storeTrack.write_as_json(handler);
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

    public static HondaAgent20MParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HondaAgent20MParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaAgent20MParameters", ignore_extras);
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
    public static HondaAgent20MParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HondaAgent20MParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HondaAgent20MParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaAgent20MParameters", ignore_extras);
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
    public static HondaAgent20MParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HondaAgent20MParametersJSON from_text(string text, bool ignore_extras)
      {
        HondaAgent20MParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaAgent20MParameters", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HondaAgent20MParametersJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HondaAgent20MParametersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HondaAgent20MParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaAgent20MParameters", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorTutorialType;
    private class FieldHoldingGeneratorTutorialStep : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorTutorialStep(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorTutorialStep : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorTutorialStep(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorTutorialStep fieldGeneratorTutorialStep;
        private MapLocationJSON.HoldingGenerator fieldGeneratorDestination;
        private UnitsValue_TemperatureJSON.HoldingGenerator fieldGeneratorTemperature;
    private class FieldHoldingGeneratorProbabilityOfPrecipitationPct : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorProbabilityOfPrecipitationPct(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorProbabilityOfPrecipitationPct : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorProbabilityOfPrecipitationPct(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorProbabilityOfPrecipitationPct fieldGeneratorProbabilityOfPrecipitationPct;
        private MusicTrackJSON.HoldingGenerator fieldGeneratorTrack;
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
            HondaAgent20MParametersJSON result = new HondaAgent20MParametersJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHondaAgent20MParametersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HondaAgent20MParametersJSON result)
          {
            if (fieldGeneratorTutorialType.have_value)
              {
                result.setTutorialType(fieldGeneratorTutorialType.value);
                fieldGeneratorTutorialType.have_value = false;
              }
            if (fieldGeneratorTutorialStep.have_value)
              {
                result.setTutorialStep(fieldGeneratorTutorialStep.value);
                fieldGeneratorTutorialStep.have_value = false;
              }
            if (fieldGeneratorDestination.have_value)
              {
                result.setDestination(fieldGeneratorDestination.value);
                fieldGeneratorDestination.have_value = false;
              }
            if (fieldGeneratorTemperature.have_value)
              {
                result.setTemperature(fieldGeneratorTemperature.value);
                fieldGeneratorTemperature.have_value = false;
              }
            if (fieldGeneratorProbabilityOfPrecipitationPct.have_value)
              {
                result.setProbabilityOfPrecipitationPct((sbyte)(fieldGeneratorProbabilityOfPrecipitationPct.value));
                fieldGeneratorProbabilityOfPrecipitationPct.have_value = false;
              }
            if (fieldGeneratorTrack.have_value)
              {
                result.setTrack(fieldGeneratorTrack.value);
                fieldGeneratorTrack.have_value = false;
              }
          }
        protected abstract void handle_result(HondaAgent20MParametersJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "estination", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDestination;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "robabilityOfPrecipitationPct", 0, 28, false) == 0) && (field_name.Length == 29))
                        return fieldGeneratorProbabilityOfPrecipitationPct;
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "mperature", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorTemperature;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "ack", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorTrack;
                            break;
                        case 'u':
                            if (String.Compare(field_name, 2, "torial", 0, 6, false) == 0)
                              {
                                switch (field_name[8])
                                  {
                                    case 'S':
                                        if ((String.Compare(field_name, 9, "tep", 0, 3, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorTutorialStep;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 9, "ype", 0, 3, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorTutorialType;
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
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTutorialType = new JSONHoldingStringGenerator("field \"TutorialType\" of the HondaAgent20MParameters class");
            fieldGeneratorTutorialStep = new FieldHoldingGeneratorTutorialStep("field \"TutorialStep\" of the HondaAgent20MParameters class");
            fieldGeneratorDestination = new MapLocationJSON.HoldingGenerator("field \"Destination\" of the HondaAgent20MParameters class", ignore_extras);
            fieldGeneratorTemperature = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Temperature\" of the HondaAgent20MParameters class", ignore_extras);
            fieldGeneratorProbabilityOfPrecipitationPct = new FieldHoldingGeneratorProbabilityOfPrecipitationPct("field \"ProbabilityOfPrecipitationPct\" of the HondaAgent20MParameters class");
            fieldGeneratorTrack = new MusicTrackJSON.HoldingGenerator("field \"Track\" of the HondaAgent20MParameters class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HondaAgent20MParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTutorialType = new JSONHoldingStringGenerator("field \"TutorialType\" of the HondaAgent20MParameters class");
            fieldGeneratorTutorialStep = new FieldHoldingGeneratorTutorialStep("field \"TutorialStep\" of the HondaAgent20MParameters class");
            fieldGeneratorDestination = new MapLocationJSON.HoldingGenerator("field \"Destination\" of the HondaAgent20MParameters class", false);
            fieldGeneratorTemperature = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Temperature\" of the HondaAgent20MParameters class", false);
            fieldGeneratorProbabilityOfPrecipitationPct = new FieldHoldingGeneratorProbabilityOfPrecipitationPct("field \"ProbabilityOfPrecipitationPct\" of the HondaAgent20MParameters class");
            fieldGeneratorTrack = new MusicTrackJSON.HoldingGenerator("field \"Track\" of the HondaAgent20MParameters class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HondaAgent20MParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTutorialType.reset();
            fieldGeneratorTutorialStep.reset();
            fieldGeneratorDestination.reset();
            fieldGeneratorTemperature.reset();
            fieldGeneratorProbabilityOfPrecipitationPct.reset();
            fieldGeneratorTrack.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDestination.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTrack.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDestination.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTrack.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HondaAgent20MParametersJSON  result)
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
        public HondaAgent20MParametersJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HondaAgent20MParametersJSON  result)
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
    protected virtual void handle_result(List<HondaAgent20MParametersJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HondaAgent20MParametersJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HondaAgent20MParametersJSON>();
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
    public List<HondaAgent20MParametersJSON> value;
  };
  };
