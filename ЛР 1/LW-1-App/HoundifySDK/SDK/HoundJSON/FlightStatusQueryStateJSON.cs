/* file "FlightStatusQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightStatusQueryStateJSON : JSONBase
  {
    private bool flagHasFollowUpOnPreviousFlights;
    private bool storeFollowUpOnPreviousFlights;
    private bool flagHasFlightSpecs;
    private List< FlightSpecJSON  > storeFlightSpecs;
    private bool flagHasModeState;
    private FlightStatusModeJSON  storeModeState;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFollowUpOnPreviousFlights(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field FollowUpOnPreviousFlights of FlightStatusQueryStateJSON is not true for false.");
              }
          }
        setFollowUpOnPreviousFlights(the_bool);
      }


    private void  fromJSONFlightSpecs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FlightSpecs of FlightStatusQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< FlightSpecJSON  > vector_FlightSpecs1 = new List< FlightSpecJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightSpecJSON convert_classy = FlightSpecJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FlightSpecs1.Add(convert_classy);
          }
        initFlightSpecs();
        for (int num1 = 0; num1 < vector_FlightSpecs1.Count; ++num1)
            appendFlightSpecs(vector_FlightSpecs1[num1]);
        for (int num1 = 0; num1 < vector_FlightSpecs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONModeState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatusModeJSON convert_classy = FlightStatusModeJSON.from_json(json_value, ignore_extras, true);
        setModeState(convert_classy);
      }


    public FlightStatusQueryStateJSON()
      {
        flagHasFollowUpOnPreviousFlights = false;
        flagHasFlightSpecs = false;
        flagHasModeState = false;
        storeFlightSpecs = new List< FlightSpecJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFollowUpOnPreviousFlights()
      {
        return flagHasFollowUpOnPreviousFlights;
      }

    public bool  getFollowUpOnPreviousFlights()
      {
        Debug.Assert(flagHasFollowUpOnPreviousFlights);
        return storeFollowUpOnPreviousFlights;
      }

    public bool  hasFlightSpecs()
      {
        return flagHasFlightSpecs;
      }

    public int  countOfFlightSpecs()
      {
        Debug.Assert(flagHasFlightSpecs);
        return storeFlightSpecs.Count;
      }

    public FlightSpecJSON   elementOfFlightSpecs(int element_num)
      {
        Debug.Assert(flagHasFlightSpecs);
        return storeFlightSpecs[element_num];
      }

    public List< FlightSpecJSON  >  getFlightSpecs()
      {
        Debug.Assert(flagHasFlightSpecs);
        return storeFlightSpecs;
      }

    public bool  hasModeState()
      {
        return flagHasModeState;
      }

    public FlightStatusModeJSON   getModeState()
      {
        Debug.Assert(flagHasModeState);
        return storeModeState;
      }


    public virtual int extraFlightStatusQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatusQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatusQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatusQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFollowUpOnPreviousFlights(bool new_value)
      {
        flagHasFollowUpOnPreviousFlights = true;
        storeFollowUpOnPreviousFlights = new_value;
      }
    public void unsetFollowUpOnPreviousFlights()
      {
        flagHasFollowUpOnPreviousFlights = false;
      }
    public void initFlightSpecs()
      {
        if (flagHasFlightSpecs)
          {
            for (int num1 = 0; num1 < storeFlightSpecs.Count; ++num1)
              {
              }
          }
        flagHasFlightSpecs = true;
        storeFlightSpecs.Clear();
      }
    public void appendFlightSpecs(FlightSpecJSON  to_append)
      {
        if (!flagHasFlightSpecs)
          {
            flagHasFlightSpecs = true;
            storeFlightSpecs.Clear();
          }
        Debug.Assert(flagHasFlightSpecs);
        storeFlightSpecs.Add(to_append);
      }
    public void unsetFlightSpecs()
      {
        if (flagHasFlightSpecs)
          {
            for (int num2 = 0; num2 < storeFlightSpecs.Count; ++num2)
              {
              }
          }
        flagHasFlightSpecs = false;
        storeFlightSpecs.Clear();
      }
    public void setModeState(FlightStatusModeJSON  new_value)
      {
        if (flagHasModeState)
          {
          }
        flagHasModeState = true;
        storeModeState = new_value;
      }
    public void unsetModeState()
      {
        if (flagHasModeState)
          {
          }
        flagHasModeState = false;
      }

    public virtual void extraFlightStatusQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatusQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatusQueryStateLookup(key);
        if (old_field == null)
          {
            extraFlightStatusQueryStateAppendPair(key, new_component);
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
        if (flagHasFollowUpOnPreviousFlights)
          {
            handler.start_pair("FollowUpOnPreviousFlights");
            handler.boolean_value(storeFollowUpOnPreviousFlights);
          }
        Debug.Assert(partial_allowed || flagHasFlightSpecs);
        if (flagHasFlightSpecs)
          {
            handler.start_pair("FlightSpecs");
            handler.start_array();
            for (int num1 = 0; num1 < storeFlightSpecs.Count; ++num1)
              {
                if (partial_allowed)
                    storeFlightSpecs[num1].write_partial_as_json(handler);
                else
                    storeFlightSpecs[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasModeState)
          {
            handler.start_pair("ModeState");
            if (partial_allowed)
                storeModeState.write_partial_as_json(handler);
            else
                storeModeState.write_as_json(handler);
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
        if (!(hasFlightSpecs()))
          {
            return "When parsing the object for %what%, the \"FlightSpecs\" field was missing.";
          }
        return null;
      }

    public static FlightStatusQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatusQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusQueryState", ignore_extras);
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
    public static FlightStatusQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatusQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatusQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusQueryState", ignore_extras);
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
    public static FlightStatusQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatusQueryStateJSON from_text(string text, bool ignore_extras)
      {
        FlightStatusQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatusQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightStatusQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatusQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorFollowUpOnPreviousFlights;
        private FlightSpecJSON.HoldingArrayGenerator fieldGeneratorFlightSpecs;
        private FlightStatusModeJSON.HoldingGenerator fieldGeneratorModeState;
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
            FlightStatusQueryStateJSON result = new FlightStatusQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatusQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightStatusQueryStateJSON result)
          {
            if (fieldGeneratorFollowUpOnPreviousFlights.have_value)
              {
                result.setFollowUpOnPreviousFlights(fieldGeneratorFollowUpOnPreviousFlights.value);
                fieldGeneratorFollowUpOnPreviousFlights.have_value = false;
              }
            if (fieldGeneratorFlightSpecs.have_value)
              {
                result.initFlightSpecs();
                int count = fieldGeneratorFlightSpecs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFlightSpecs(fieldGeneratorFlightSpecs.value[num]);
                  }
                fieldGeneratorFlightSpecs.value.Clear();
                fieldGeneratorFlightSpecs.have_value = false;
              }
            else if ((!(result.hasFlightSpecs())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlightSpecs\" field was missing.");
              }
            if (fieldGeneratorModeState.have_value)
              {
                result.setModeState(fieldGeneratorModeState.value);
                fieldGeneratorModeState.have_value = false;
              }
          }
        protected abstract void handle_result(FlightStatusQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "ightSpecs", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorFlightSpecs;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "llowUpOnPreviousFlights", 0, 23, false) == 0) && (field_name.Length == 25))
                                return fieldGeneratorFollowUpOnPreviousFlights;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "odeState", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorModeState;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFollowUpOnPreviousFlights = new JSONHoldingBooleanGenerator("field \"FollowUpOnPreviousFlights\" of the FlightStatusQueryState class");
            fieldGeneratorFlightSpecs = new FlightSpecJSON.HoldingArrayGenerator("field \"FlightSpecs\" of the FlightStatusQueryState class", ignore_extras);
            fieldGeneratorModeState = new FlightStatusModeJSON.HoldingGenerator("field \"ModeState\" of the FlightStatusQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatusQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFollowUpOnPreviousFlights = new JSONHoldingBooleanGenerator("field \"FollowUpOnPreviousFlights\" of the FlightStatusQueryState class");
            fieldGeneratorFlightSpecs = new FlightSpecJSON.HoldingArrayGenerator("field \"FlightSpecs\" of the FlightStatusQueryState class", false);
            fieldGeneratorModeState = new FlightStatusModeJSON.HoldingGenerator("field \"ModeState\" of the FlightStatusQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatusQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFollowUpOnPreviousFlights.reset();
            fieldGeneratorFlightSpecs.reset();
            fieldGeneratorModeState.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFlightSpecs.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorModeState.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFlightSpecs.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorModeState.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightStatusQueryStateJSON  result)
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
        public FlightStatusQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatusQueryStateJSON  result)
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
    protected virtual void handle_result(List<FlightStatusQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatusQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatusQueryStateJSON>();
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
    public List<FlightStatusQueryStateJSON> value;
  };
  };
