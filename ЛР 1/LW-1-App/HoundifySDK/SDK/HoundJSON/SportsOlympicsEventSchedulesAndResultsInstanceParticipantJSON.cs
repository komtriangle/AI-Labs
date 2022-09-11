/* file "SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON : JSONBase
  {
    private bool flagHasAthletes;
    private List< SportsOlympicsAthleteJSON  > storeAthletes;
    private bool flagHasOrganization;
    private SportsOlympicsOrganizationJSON  storeOrganization;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONAthletes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Athletes of SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsOlympicsAthleteJSON  > vector_Athletes1 = new List< SportsOlympicsAthleteJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsOlympicsAthleteJSON convert_classy = SportsOlympicsAthleteJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Athletes1.Add(convert_classy);
          }
        initAthletes();
        for (int num1 = 0; num1 < vector_Athletes1.Count; ++num1)
            appendAthletes(vector_Athletes1[num1]);
        for (int num1 = 0; num1 < vector_Athletes1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOrganization(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsOrganizationJSON convert_classy = SportsOlympicsOrganizationJSON.from_json(json_value, ignore_extras, true);
        setOrganization(convert_classy);
      }


    public SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON()
      {
        flagHasAthletes = false;
        flagHasOrganization = false;
        storeAthletes = new List< SportsOlympicsAthleteJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasAthletes()
      {
        return flagHasAthletes;
      }

    public int  countOfAthletes()
      {
        Debug.Assert(flagHasAthletes);
        return storeAthletes.Count;
      }

    public SportsOlympicsAthleteJSON   elementOfAthletes(int element_num)
      {
        Debug.Assert(flagHasAthletes);
        return storeAthletes[element_num];
      }

    public List< SportsOlympicsAthleteJSON  >  getAthletes()
      {
        Debug.Assert(flagHasAthletes);
        return storeAthletes;
      }

    public bool  hasOrganization()
      {
        return flagHasOrganization;
      }

    public SportsOlympicsOrganizationJSON   getOrganization()
      {
        Debug.Assert(flagHasOrganization);
        return storeOrganization;
      }


    public virtual int extraSportsOlympicsEventSchedulesAndResultsInstanceParticipantComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsEventSchedulesAndResultsInstanceParticipantComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsInstanceParticipantComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsInstanceParticipantLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initAthletes()
      {
        if (flagHasAthletes)
          {
            for (int num1 = 0; num1 < storeAthletes.Count; ++num1)
              {
              }
          }
        flagHasAthletes = true;
        storeAthletes.Clear();
      }
    public void appendAthletes(SportsOlympicsAthleteJSON  to_append)
      {
        if (!flagHasAthletes)
          {
            flagHasAthletes = true;
            storeAthletes.Clear();
          }
        Debug.Assert(flagHasAthletes);
        storeAthletes.Add(to_append);
      }
    public void unsetAthletes()
      {
        if (flagHasAthletes)
          {
            for (int num2 = 0; num2 < storeAthletes.Count; ++num2)
              {
              }
          }
        flagHasAthletes = false;
        storeAthletes.Clear();
      }
    public void setOrganization(SportsOlympicsOrganizationJSON  new_value)
      {
        if (flagHasOrganization)
          {
          }
        flagHasOrganization = true;
        storeOrganization = new_value;
      }
    public void unsetOrganization()
      {
        if (flagHasOrganization)
          {
          }
        flagHasOrganization = false;
      }

    public virtual void extraSportsOlympicsEventSchedulesAndResultsInstanceParticipantAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsEventSchedulesAndResultsInstanceParticipantSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsEventSchedulesAndResultsInstanceParticipantLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsEventSchedulesAndResultsInstanceParticipantAppendPair(key, new_component);
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
        if (flagHasAthletes)
          {
            handler.start_pair("Athletes");
            handler.start_array();
            for (int num1 = 0; num1 < storeAthletes.Count; ++num1)
              {
                if (partial_allowed)
                    storeAthletes[num1].write_partial_as_json(handler);
                else
                    storeAthletes[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasOrganization);
        if (flagHasOrganization)
          {
            handler.start_pair("Organization");
            if (partial_allowed)
                storeOrganization.write_partial_as_json(handler);
            else
                storeOrganization.write_as_json(handler);
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
        if (!(hasOrganization()))
          {
            return "When parsing the object for %what%, the \"Organization\" field was missing.";
          }
        return null;
      }

    public static SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsInstanceParticipant", ignore_extras);
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
    public static SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsInstanceParticipant", ignore_extras);
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
    public static SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsInstanceParticipant", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsInstanceParticipant", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsOlympicsAthleteJSON.HoldingArrayGenerator fieldGeneratorAthletes;
        private SportsOlympicsOrganizationJSON.HoldingGenerator fieldGeneratorOrganization;
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
            SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON result = new SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsEventSchedulesAndResultsInstanceParticipantAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON result)
          {
            if (fieldGeneratorAthletes.have_value)
              {
                result.initAthletes();
                int count = fieldGeneratorAthletes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAthletes(fieldGeneratorAthletes.value[num]);
                  }
                fieldGeneratorAthletes.value.Clear();
                fieldGeneratorAthletes.have_value = false;
              }
            if (fieldGeneratorOrganization.have_value)
              {
                result.setOrganization(fieldGeneratorOrganization.value);
                fieldGeneratorOrganization.have_value = false;
              }
            else if ((!(result.hasOrganization())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Organization\" field was missing.");
              }
          }
        protected abstract void handle_result(SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "thletes", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorAthletes;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "rganization", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorOrganization;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAthletes = new SportsOlympicsAthleteJSON.HoldingArrayGenerator("field \"Athletes\" of the SportsOlympicsEventSchedulesAndResultsInstanceParticipant class", ignore_extras);
            fieldGeneratorOrganization = new SportsOlympicsOrganizationJSON.HoldingGenerator("field \"Organization\" of the SportsOlympicsEventSchedulesAndResultsInstanceParticipant class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsEventSchedulesAndResultsInstanceParticipant class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAthletes = new SportsOlympicsAthleteJSON.HoldingArrayGenerator("field \"Athletes\" of the SportsOlympicsEventSchedulesAndResultsInstanceParticipant class", false);
            fieldGeneratorOrganization = new SportsOlympicsOrganizationJSON.HoldingGenerator("field \"Organization\" of the SportsOlympicsEventSchedulesAndResultsInstanceParticipant class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsEventSchedulesAndResultsInstanceParticipant class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorAthletes.reset();
            fieldGeneratorOrganization.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAthletes.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOrganization.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAthletes.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOrganization.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON  result)
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
        public SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON>();
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
    public List<SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON> value;
  };
  };
