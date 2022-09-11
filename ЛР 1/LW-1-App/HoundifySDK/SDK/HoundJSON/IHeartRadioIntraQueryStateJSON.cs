/* file "IHeartRadioIntraQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class IHeartRadioIntraQueryStateJSON : JSONBase
  {
    private bool flagHasStations;
    private List< RadioStationJSON  > storeStations;
    private bool flagHasSpokenStationIndices;
    private List< BigInteger > storeSpokenStationIndices;
    private bool flagHasStationIndicesToPlay;
    private List< BigInteger > storeStationIndicesToPlay;
    private bool flagHasUserRequestedQueryInfo;
    private IHeartRadioQueryInfoJSON  storeUserRequestedQueryInfo;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Stations of IHeartRadioIntraQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RadioStationJSON  > vector_Stations1 = new List< RadioStationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RadioStationJSON convert_classy = RadioStationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Stations1.Add(convert_classy);
          }
        initStations();
        for (int num1 = 0; num1 < vector_Stations1.Count; ++num1)
            appendStations(vector_Stations1[num1]);
        for (int num1 = 0; num1 < vector_Stations1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpokenStationIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SpokenStationIndices of IHeartRadioIntraQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field SpokenStationIndices of IHeartRadioIntraQueryStateJSON has too few elements.");
        List< BigInteger > vector_SpokenStationIndices1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field SpokenStationIndices of IHeartRadioIntraQueryStateJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field SpokenStationIndices of IHeartRadioIntraQueryStateJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_SpokenStationIndices1.Add(extracted_integer);
          }
        Debug.Assert(vector_SpokenStationIndices1.Count >= 1);
        initSpokenStationIndices();
        for (int num2 = 0; num2 < vector_SpokenStationIndices1.Count; ++num2)
            appendSpokenStationIndices(vector_SpokenStationIndices1[num2]);
        for (int num1 = 0; num1 < vector_SpokenStationIndices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONStationIndicesToPlay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field StationIndicesToPlay of IHeartRadioIntraQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field StationIndicesToPlay of IHeartRadioIntraQueryStateJSON has too few elements.");
        List< BigInteger > vector_StationIndicesToPlay1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field StationIndicesToPlay of IHeartRadioIntraQueryStateJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field StationIndicesToPlay of IHeartRadioIntraQueryStateJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_StationIndicesToPlay1.Add(extracted_integer);
          }
        Debug.Assert(vector_StationIndicesToPlay1.Count >= 1);
        initStationIndicesToPlay();
        for (int num3 = 0; num3 < vector_StationIndicesToPlay1.Count; ++num3)
            appendStationIndicesToPlay(vector_StationIndicesToPlay1[num3]);
        for (int num1 = 0; num1 < vector_StationIndicesToPlay1.Count; ++num1)
          {
          }
      }


    private void  fromJSONUserRequestedQueryInfo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioQueryInfoJSON convert_classy = IHeartRadioQueryInfoJSON.from_json(json_value, ignore_extras, true);
        setUserRequestedQueryInfo(convert_classy);
      }


    public IHeartRadioIntraQueryStateJSON()
      {
        flagHasStations = false;
        flagHasSpokenStationIndices = false;
        flagHasStationIndicesToPlay = false;
        flagHasUserRequestedQueryInfo = false;
        storeStations = new List< RadioStationJSON  >();
        storeSpokenStationIndices = new List< BigInteger >();
        storeStationIndicesToPlay = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStations()
      {
        return flagHasStations;
      }

    public int  countOfStations()
      {
        Debug.Assert(flagHasStations);
        return storeStations.Count;
      }

    public RadioStationJSON   elementOfStations(int element_num)
      {
        Debug.Assert(flagHasStations);
        return storeStations[element_num];
      }

    public List< RadioStationJSON  >  getStations()
      {
        Debug.Assert(flagHasStations);
        return storeStations;
      }

    public bool  hasSpokenStationIndices()
      {
        return flagHasSpokenStationIndices;
      }

    public int  countOfSpokenStationIndices()
      {
        Debug.Assert(flagHasSpokenStationIndices);
        return storeSpokenStationIndices.Count;
      }

    public BigInteger  elementOfSpokenStationIndices(int element_num)
      {
        Debug.Assert(flagHasSpokenStationIndices);
        return storeSpokenStationIndices[element_num];
      }

    public List< BigInteger >  getSpokenStationIndices()
      {
        Debug.Assert(flagHasSpokenStationIndices);
        return storeSpokenStationIndices;
      }

    public bool  hasStationIndicesToPlay()
      {
        return flagHasStationIndicesToPlay;
      }

    public int  countOfStationIndicesToPlay()
      {
        Debug.Assert(flagHasStationIndicesToPlay);
        return storeStationIndicesToPlay.Count;
      }

    public BigInteger  elementOfStationIndicesToPlay(int element_num)
      {
        Debug.Assert(flagHasStationIndicesToPlay);
        return storeStationIndicesToPlay[element_num];
      }

    public List< BigInteger >  getStationIndicesToPlay()
      {
        Debug.Assert(flagHasStationIndicesToPlay);
        return storeStationIndicesToPlay;
      }

    public bool  hasUserRequestedQueryInfo()
      {
        return flagHasUserRequestedQueryInfo;
      }

    public IHeartRadioQueryInfoJSON   getUserRequestedQueryInfo()
      {
        Debug.Assert(flagHasUserRequestedQueryInfo);
        return storeUserRequestedQueryInfo;
      }


    public virtual int extraIHeartRadioIntraQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioIntraQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioIntraQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioIntraQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initStations()
      {
        if (flagHasStations)
          {
            for (int num1 = 0; num1 < storeStations.Count; ++num1)
              {
              }
          }
        flagHasStations = true;
        storeStations.Clear();
      }
    public void appendStations(RadioStationJSON  to_append)
      {
        if (!flagHasStations)
          {
            flagHasStations = true;
            storeStations.Clear();
          }
        Debug.Assert(flagHasStations);
        storeStations.Add(to_append);
      }
    public void unsetStations()
      {
        if (flagHasStations)
          {
            for (int num2 = 0; num2 < storeStations.Count; ++num2)
              {
              }
          }
        flagHasStations = false;
        storeStations.Clear();
      }
    public void initSpokenStationIndices()
      {
        flagHasSpokenStationIndices = true;
        storeSpokenStationIndices.Clear();
      }
    public void appendSpokenStationIndices(BigInteger to_append)
      {
        if (!flagHasSpokenStationIndices)
          {
            flagHasSpokenStationIndices = true;
            storeSpokenStationIndices.Clear();
          }
        Debug.Assert(flagHasSpokenStationIndices);
        storeSpokenStationIndices.Add(to_append);
      }
    public void unsetSpokenStationIndices()
      {
        flagHasSpokenStationIndices = false;
        storeSpokenStationIndices.Clear();
      }
    public void initStationIndicesToPlay()
      {
        flagHasStationIndicesToPlay = true;
        storeStationIndicesToPlay.Clear();
      }
    public void appendStationIndicesToPlay(BigInteger to_append)
      {
        if (!flagHasStationIndicesToPlay)
          {
            flagHasStationIndicesToPlay = true;
            storeStationIndicesToPlay.Clear();
          }
        Debug.Assert(flagHasStationIndicesToPlay);
        storeStationIndicesToPlay.Add(to_append);
      }
    public void unsetStationIndicesToPlay()
      {
        flagHasStationIndicesToPlay = false;
        storeStationIndicesToPlay.Clear();
      }
    public void setUserRequestedQueryInfo(IHeartRadioQueryInfoJSON  new_value)
      {
        if (flagHasUserRequestedQueryInfo)
          {
          }
        flagHasUserRequestedQueryInfo = true;
        storeUserRequestedQueryInfo = new_value;
      }
    public void unsetUserRequestedQueryInfo()
      {
        if (flagHasUserRequestedQueryInfo)
          {
          }
        flagHasUserRequestedQueryInfo = false;
      }

    public virtual void extraIHeartRadioIntraQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioIntraQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioIntraQueryStateLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioIntraQueryStateAppendPair(key, new_component);
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
        if (flagHasStations)
          {
            handler.start_pair("Stations");
            handler.start_array();
            for (int num1 = 0; num1 < storeStations.Count; ++num1)
              {
                if (partial_allowed)
                    storeStations[num1].write_partial_as_json(handler);
                else
                    storeStations[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSpokenStationIndices)
          {
            handler.start_pair("SpokenStationIndices");
            Debug.Assert(storeSpokenStationIndices.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeSpokenStationIndices.Count; ++num2)
              {
                handler.number_value(storeSpokenStationIndices[num2]);
              }
            handler.finish_array();
          }
        if (flagHasStationIndicesToPlay)
          {
            handler.start_pair("StationIndicesToPlay");
            Debug.Assert(storeStationIndicesToPlay.Count >= 1);
            handler.start_array();
            for (int num3 = 0; num3 < storeStationIndicesToPlay.Count; ++num3)
              {
                handler.number_value(storeStationIndicesToPlay[num3]);
              }
            handler.finish_array();
          }
        if (flagHasUserRequestedQueryInfo)
          {
            handler.start_pair("UserRequestedQueryInfo");
            if (partial_allowed)
                storeUserRequestedQueryInfo.write_partial_as_json(handler);
            else
                storeUserRequestedQueryInfo.write_as_json(handler);
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

    public static IHeartRadioIntraQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioIntraQueryState", ignore_extras);
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
    public static IHeartRadioIntraQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioIntraQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioIntraQueryState", ignore_extras);
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
    public static IHeartRadioIntraQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioIntraQueryStateJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioIntraQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioIntraQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioIntraQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioIntraQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private RadioStationJSON.HoldingArrayGenerator fieldGeneratorStations;
    private class FieldHoldingGeneratorSpokenStationIndices : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSpokenStationIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSpokenStationIndices : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSpokenStationIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorSpokenStationIndices fieldGeneratorSpokenStationIndices;
    private class FieldHoldingGeneratorStationIndicesToPlay : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorStationIndicesToPlay(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorStationIndicesToPlay : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorStationIndicesToPlay(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorStationIndicesToPlay fieldGeneratorStationIndicesToPlay;
        private IHeartRadioQueryInfoJSON.HoldingGenerator fieldGeneratorUserRequestedQueryInfo;
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
            IHeartRadioIntraQueryStateJSON result = new IHeartRadioIntraQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioIntraQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioIntraQueryStateJSON result)
          {
            if (fieldGeneratorStations.have_value)
              {
                result.initStations();
                int count = fieldGeneratorStations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStations(fieldGeneratorStations.value[num]);
                  }
                fieldGeneratorStations.value.Clear();
                fieldGeneratorStations.have_value = false;
              }
            if (fieldGeneratorSpokenStationIndices.have_value)
              {
                result.initSpokenStationIndices();
                int count = fieldGeneratorSpokenStationIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSpokenStationIndices(fieldGeneratorSpokenStationIndices.value[num]);
                  }
                fieldGeneratorSpokenStationIndices.value.Clear();
                fieldGeneratorSpokenStationIndices.have_value = false;
              }
            if (fieldGeneratorStationIndicesToPlay.have_value)
              {
                result.initStationIndicesToPlay();
                int count = fieldGeneratorStationIndicesToPlay.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStationIndicesToPlay(fieldGeneratorStationIndicesToPlay.value[num]);
                  }
                fieldGeneratorStationIndicesToPlay.value.Clear();
                fieldGeneratorStationIndicesToPlay.have_value = false;
              }
            if (fieldGeneratorUserRequestedQueryInfo.have_value)
              {
                result.setUserRequestedQueryInfo(fieldGeneratorUserRequestedQueryInfo.value);
                fieldGeneratorUserRequestedQueryInfo.have_value = false;
              }
          }
        protected abstract void handle_result(IHeartRadioIntraQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'S':
                    switch (field_name[1])
                      {
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenStationIndices", 0, 18, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorSpokenStationIndices;
                            break;
                        case 't':
                            if (String.Compare(field_name, 2, "ation", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 8, "ndicesToPlay", 0, 12, false) == 0) && (field_name.Length == 20))
                                            return fieldGeneratorStationIndicesToPlay;
                                        break;
                                    case 's':
                                        if (field_name.Length == 8)
                                            return fieldGeneratorStations;
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
                case 'U':
                    if ((String.Compare(field_name, 1, "serRequestedQueryInfo", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorUserRequestedQueryInfo;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorStations = new RadioStationJSON.HoldingArrayGenerator("field \"Stations\" of the IHeartRadioIntraQueryState class", ignore_extras);
            fieldGeneratorSpokenStationIndices = new FieldHoldingArrayGeneratorSpokenStationIndices("field \"SpokenStationIndices\" of the IHeartRadioIntraQueryState class");
            fieldGeneratorStationIndicesToPlay = new FieldHoldingArrayGeneratorStationIndicesToPlay("field \"StationIndicesToPlay\" of the IHeartRadioIntraQueryState class");
            fieldGeneratorUserRequestedQueryInfo = new IHeartRadioQueryInfoJSON.HoldingGenerator("field \"UserRequestedQueryInfo\" of the IHeartRadioIntraQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioIntraQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStations = new RadioStationJSON.HoldingArrayGenerator("field \"Stations\" of the IHeartRadioIntraQueryState class", false);
            fieldGeneratorSpokenStationIndices = new FieldHoldingArrayGeneratorSpokenStationIndices("field \"SpokenStationIndices\" of the IHeartRadioIntraQueryState class");
            fieldGeneratorStationIndicesToPlay = new FieldHoldingArrayGeneratorStationIndicesToPlay("field \"StationIndicesToPlay\" of the IHeartRadioIntraQueryState class");
            fieldGeneratorUserRequestedQueryInfo = new IHeartRadioQueryInfoJSON.HoldingGenerator("field \"UserRequestedQueryInfo\" of the IHeartRadioIntraQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioIntraQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStations.reset();
            fieldGeneratorSpokenStationIndices.reset();
            fieldGeneratorStationIndicesToPlay.reset();
            fieldGeneratorUserRequestedQueryInfo.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStations.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUserRequestedQueryInfo.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStations.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUserRequestedQueryInfo.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(IHeartRadioIntraQueryStateJSON  result)
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
        public IHeartRadioIntraQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioIntraQueryStateJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioIntraQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioIntraQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioIntraQueryStateJSON>();
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
    public List<IHeartRadioIntraQueryStateJSON> value;
  };
  };
