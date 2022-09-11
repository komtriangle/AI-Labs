/* file "SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON : JSONBase
  {
    private bool flagHasEventInstancesIndex;
    private BigInteger storeEventInstancesIndex;
    private bool flagHasMedalWinnersIndices;
    private List< BigInteger > storeMedalWinnersIndices;
    private bool flagHasParticipantsIndices;
    private List< BigInteger > storeParticipantsIndices;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONEventInstancesIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field EventInstancesIndex of SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field EventInstancesIndex of SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setEventInstancesIndex(extracted_integer);
      }


    private void  fromJSONMedalWinnersIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MedalWinnersIndices of SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_MedalWinnersIndices1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field MedalWinnersIndices of SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field MedalWinnersIndices of SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_MedalWinnersIndices1.Add(extracted_integer);
          }
        initMedalWinnersIndices();
        for (int num1 = 0; num1 < vector_MedalWinnersIndices1.Count; ++num1)
            appendMedalWinnersIndices(vector_MedalWinnersIndices1[num1]);
        for (int num1 = 0; num1 < vector_MedalWinnersIndices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONParticipantsIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ParticipantsIndices of SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_ParticipantsIndices1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field ParticipantsIndices of SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field ParticipantsIndices of SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_ParticipantsIndices1.Add(extracted_integer);
          }
        initParticipantsIndices();
        for (int num2 = 0; num2 < vector_ParticipantsIndices1.Count; ++num2)
            appendParticipantsIndices(vector_ParticipantsIndices1[num2]);
        for (int num1 = 0; num1 < vector_ParticipantsIndices1.Count; ++num1)
          {
          }
      }


    public SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON()
      {
        flagHasEventInstancesIndex = false;
        flagHasMedalWinnersIndices = false;
        flagHasParticipantsIndices = false;
        storeMedalWinnersIndices = new List< BigInteger >();
        storeParticipantsIndices = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasEventInstancesIndex()
      {
        return flagHasEventInstancesIndex;
      }

    public BigInteger  getEventInstancesIndex()
      {
        Debug.Assert(flagHasEventInstancesIndex);
        return storeEventInstancesIndex;
      }

    public bool  hasMedalWinnersIndices()
      {
        return flagHasMedalWinnersIndices;
      }

    public int  countOfMedalWinnersIndices()
      {
        Debug.Assert(flagHasMedalWinnersIndices);
        return storeMedalWinnersIndices.Count;
      }

    public BigInteger  elementOfMedalWinnersIndices(int element_num)
      {
        Debug.Assert(flagHasMedalWinnersIndices);
        return storeMedalWinnersIndices[element_num];
      }

    public List< BigInteger >  getMedalWinnersIndices()
      {
        Debug.Assert(flagHasMedalWinnersIndices);
        return storeMedalWinnersIndices;
      }

    public bool  hasParticipantsIndices()
      {
        return flagHasParticipantsIndices;
      }

    public int  countOfParticipantsIndices()
      {
        Debug.Assert(flagHasParticipantsIndices);
        return storeParticipantsIndices.Count;
      }

    public BigInteger  elementOfParticipantsIndices(int element_num)
      {
        Debug.Assert(flagHasParticipantsIndices);
        return storeParticipantsIndices[element_num];
      }

    public List< BigInteger >  getParticipantsIndices()
      {
        Debug.Assert(flagHasParticipantsIndices);
        return storeParticipantsIndices;
      }


    public virtual int extraSportsOlympicsEventSchedulesAndResultsEventInstanceMappingComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsEventSchedulesAndResultsEventInstanceMappingComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsEventInstanceMappingComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsEventInstanceMappingLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setEventInstancesIndex(BigInteger new_value)
      {
        flagHasEventInstancesIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field EventInstancesIndex of SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON is less than the lower bound (0) for that field.");
        storeEventInstancesIndex = new_value;
      }
    public void unsetEventInstancesIndex()
      {
        flagHasEventInstancesIndex = false;
      }
    public void initMedalWinnersIndices()
      {
        flagHasMedalWinnersIndices = true;
        storeMedalWinnersIndices.Clear();
      }
    public void appendMedalWinnersIndices(BigInteger to_append)
      {
        if (!flagHasMedalWinnersIndices)
          {
            flagHasMedalWinnersIndices = true;
            storeMedalWinnersIndices.Clear();
          }
        Debug.Assert(flagHasMedalWinnersIndices);
        storeMedalWinnersIndices.Add(to_append);
      }
    public void unsetMedalWinnersIndices()
      {
        flagHasMedalWinnersIndices = false;
        storeMedalWinnersIndices.Clear();
      }
    public void initParticipantsIndices()
      {
        flagHasParticipantsIndices = true;
        storeParticipantsIndices.Clear();
      }
    public void appendParticipantsIndices(BigInteger to_append)
      {
        if (!flagHasParticipantsIndices)
          {
            flagHasParticipantsIndices = true;
            storeParticipantsIndices.Clear();
          }
        Debug.Assert(flagHasParticipantsIndices);
        storeParticipantsIndices.Add(to_append);
      }
    public void unsetParticipantsIndices()
      {
        flagHasParticipantsIndices = false;
        storeParticipantsIndices.Clear();
      }

    public virtual void extraSportsOlympicsEventSchedulesAndResultsEventInstanceMappingAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsEventSchedulesAndResultsEventInstanceMappingSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsEventSchedulesAndResultsEventInstanceMappingLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsEventSchedulesAndResultsEventInstanceMappingAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasEventInstancesIndex);
        if (flagHasEventInstancesIndex)
          {
            handler.start_pair("EventInstancesIndex");
            handler.number_value(storeEventInstancesIndex);
          }
        if (flagHasMedalWinnersIndices)
          {
            handler.start_pair("MedalWinnersIndices");
            handler.start_array();
            for (int num1 = 0; num1 < storeMedalWinnersIndices.Count; ++num1)
              {
                handler.number_value(storeMedalWinnersIndices[num1]);
              }
            handler.finish_array();
          }
        if (flagHasParticipantsIndices)
          {
            handler.start_pair("ParticipantsIndices");
            handler.start_array();
            for (int num2 = 0; num2 < storeParticipantsIndices.Count; ++num2)
              {
                handler.number_value(storeParticipantsIndices[num2]);
              }
            handler.finish_array();
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
        if (!(hasEventInstancesIndex()))
          {
            return "When parsing the object for %what%, the \"EventInstancesIndex\" field was missing.";
          }
        return null;
      }

    public static SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsEventInstanceMapping", ignore_extras);
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
    public static SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsEventInstanceMapping", ignore_extras);
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
    public static SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsEventInstanceMapping", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsEventInstanceMapping", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorEventInstancesIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorEventInstancesIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorEventInstancesIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorEventInstancesIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorEventInstancesIndex fieldGeneratorEventInstancesIndex;
    private class FieldHoldingGeneratorMedalWinnersIndices : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorMedalWinnersIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorMedalWinnersIndices : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorMedalWinnersIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorMedalWinnersIndices fieldGeneratorMedalWinnersIndices;
    private class FieldHoldingGeneratorParticipantsIndices : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorParticipantsIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorParticipantsIndices : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorParticipantsIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorParticipantsIndices fieldGeneratorParticipantsIndices;
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
            SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON result = new SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsEventSchedulesAndResultsEventInstanceMappingAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON result)
          {
            if (fieldGeneratorEventInstancesIndex.have_value)
              {
                result.setEventInstancesIndex(fieldGeneratorEventInstancesIndex.value);
                fieldGeneratorEventInstancesIndex.have_value = false;
              }
            else if ((!(result.hasEventInstancesIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EventInstancesIndex\" field was missing.");
              }
            if (fieldGeneratorMedalWinnersIndices.have_value)
              {
                result.initMedalWinnersIndices();
                int count = fieldGeneratorMedalWinnersIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMedalWinnersIndices(fieldGeneratorMedalWinnersIndices.value[num]);
                  }
                fieldGeneratorMedalWinnersIndices.value.Clear();
                fieldGeneratorMedalWinnersIndices.have_value = false;
              }
            if (fieldGeneratorParticipantsIndices.have_value)
              {
                result.initParticipantsIndices();
                int count = fieldGeneratorParticipantsIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendParticipantsIndices(fieldGeneratorParticipantsIndices.value[num]);
                  }
                fieldGeneratorParticipantsIndices.value.Clear();
                fieldGeneratorParticipantsIndices.have_value = false;
              }
          }
        protected abstract void handle_result(SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "ventInstancesIndex", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorEventInstancesIndex;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "edalWinnersIndices", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorMedalWinnersIndices;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "articipantsIndices", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorParticipantsIndices;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorEventInstancesIndex = new FieldHoldingGeneratorEventInstancesIndex("field \"EventInstancesIndex\" of the SportsOlympicsEventSchedulesAndResultsEventInstanceMapping class");
            fieldGeneratorMedalWinnersIndices = new FieldHoldingArrayGeneratorMedalWinnersIndices("field \"MedalWinnersIndices\" of the SportsOlympicsEventSchedulesAndResultsEventInstanceMapping class");
            fieldGeneratorParticipantsIndices = new FieldHoldingArrayGeneratorParticipantsIndices("field \"ParticipantsIndices\" of the SportsOlympicsEventSchedulesAndResultsEventInstanceMapping class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsEventSchedulesAndResultsEventInstanceMapping class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorEventInstancesIndex = new FieldHoldingGeneratorEventInstancesIndex("field \"EventInstancesIndex\" of the SportsOlympicsEventSchedulesAndResultsEventInstanceMapping class");
            fieldGeneratorMedalWinnersIndices = new FieldHoldingArrayGeneratorMedalWinnersIndices("field \"MedalWinnersIndices\" of the SportsOlympicsEventSchedulesAndResultsEventInstanceMapping class");
            fieldGeneratorParticipantsIndices = new FieldHoldingArrayGeneratorParticipantsIndices("field \"ParticipantsIndices\" of the SportsOlympicsEventSchedulesAndResultsEventInstanceMapping class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsEventSchedulesAndResultsEventInstanceMapping class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorEventInstancesIndex.reset();
            fieldGeneratorMedalWinnersIndices.reset();
            fieldGeneratorParticipantsIndices.reset();
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
        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON  result)
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
        public SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON>();
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
    public List<SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON> value;
  };
  };
