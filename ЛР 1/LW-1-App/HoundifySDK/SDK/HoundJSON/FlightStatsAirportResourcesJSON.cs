/* file "FlightStatsAirportResourcesJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightStatsAirportResourcesJSON : JSONBase
  {
    private bool flagHasdepartureTerminal;
    private string storedepartureTerminal;
    private bool flagHasdepartureGate;
    private string storedepartureGate;
    private bool flagHasarrivalTerminal;
    private string storearrivalTerminal;
    private bool flagHasarrivalGate;
    private string storearrivalGate;
    private bool flagHasbaggage;
    private string storebaggage;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONdepartureTerminal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field departureTerminal of FlightStatsAirportResourcesJSON is not a string.");
        setdepartureTerminal(json_string.getData());
      }


    private void  fromJSONdepartureGate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field departureGate of FlightStatsAirportResourcesJSON is not a string.");
        setdepartureGate(json_string.getData());
      }


    private void  fromJSONarrivalTerminal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field arrivalTerminal of FlightStatsAirportResourcesJSON is not a string.");
        setarrivalTerminal(json_string.getData());
      }


    private void  fromJSONarrivalGate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field arrivalGate of FlightStatsAirportResourcesJSON is not a string.");
        setarrivalGate(json_string.getData());
      }


    private void  fromJSONbaggage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field baggage of FlightStatsAirportResourcesJSON is not a string.");
        setbaggage(json_string.getData());
      }


    public FlightStatsAirportResourcesJSON()
      {
        flagHasdepartureTerminal = false;
        flagHasdepartureGate = false;
        flagHasarrivalTerminal = false;
        flagHasarrivalGate = false;
        flagHasbaggage = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasdepartureTerminal()
      {
        return flagHasdepartureTerminal;
      }

    public string  getdepartureTerminal()
      {
        Debug.Assert(flagHasdepartureTerminal);
        return storedepartureTerminal;
      }

    public bool  hasdepartureGate()
      {
        return flagHasdepartureGate;
      }

    public string  getdepartureGate()
      {
        Debug.Assert(flagHasdepartureGate);
        return storedepartureGate;
      }

    public bool  hasarrivalTerminal()
      {
        return flagHasarrivalTerminal;
      }

    public string  getarrivalTerminal()
      {
        Debug.Assert(flagHasarrivalTerminal);
        return storearrivalTerminal;
      }

    public bool  hasarrivalGate()
      {
        return flagHasarrivalGate;
      }

    public string  getarrivalGate()
      {
        Debug.Assert(flagHasarrivalGate);
        return storearrivalGate;
      }

    public bool  hasbaggage()
      {
        return flagHasbaggage;
      }

    public string  getbaggage()
      {
        Debug.Assert(flagHasbaggage);
        return storebaggage;
      }


    public virtual int extraFlightStatsAirportResourcesComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatsAirportResourcesComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatsAirportResourcesComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatsAirportResourcesLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setdepartureTerminal(string new_value)
      {
        flagHasdepartureTerminal = true;
        storedepartureTerminal = new_value;
      }
    public void unsetdepartureTerminal()
      {
        flagHasdepartureTerminal = false;
      }
    public void setdepartureGate(string new_value)
      {
        flagHasdepartureGate = true;
        storedepartureGate = new_value;
      }
    public void unsetdepartureGate()
      {
        flagHasdepartureGate = false;
      }
    public void setarrivalTerminal(string new_value)
      {
        flagHasarrivalTerminal = true;
        storearrivalTerminal = new_value;
      }
    public void unsetarrivalTerminal()
      {
        flagHasarrivalTerminal = false;
      }
    public void setarrivalGate(string new_value)
      {
        flagHasarrivalGate = true;
        storearrivalGate = new_value;
      }
    public void unsetarrivalGate()
      {
        flagHasarrivalGate = false;
      }
    public void setbaggage(string new_value)
      {
        flagHasbaggage = true;
        storebaggage = new_value;
      }
    public void unsetbaggage()
      {
        flagHasbaggage = false;
      }

    public virtual void extraFlightStatsAirportResourcesAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatsAirportResourcesSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatsAirportResourcesLookup(key);
        if (old_field == null)
          {
            extraFlightStatsAirportResourcesAppendPair(key, new_component);
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
        if (flagHasdepartureTerminal)
          {
            handler.start_pair("departureTerminal");
            handler.string_value(storedepartureTerminal);
          }
        if (flagHasdepartureGate)
          {
            handler.start_pair("departureGate");
            handler.string_value(storedepartureGate);
          }
        if (flagHasarrivalTerminal)
          {
            handler.start_pair("arrivalTerminal");
            handler.string_value(storearrivalTerminal);
          }
        if (flagHasarrivalGate)
          {
            handler.start_pair("arrivalGate");
            handler.string_value(storearrivalGate);
          }
        if (flagHasbaggage)
          {
            handler.start_pair("baggage");
            handler.string_value(storebaggage);
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

    public static FlightStatsAirportResourcesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsAirportResourcesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsAirportResources", ignore_extras);
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
    public static FlightStatsAirportResourcesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatsAirportResourcesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsAirportResourcesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsAirportResources", ignore_extras);
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
    public static FlightStatsAirportResourcesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatsAirportResourcesJSON from_text(string text, bool ignore_extras)
      {
        FlightStatsAirportResourcesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsAirportResources", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatsAirportResourcesJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightStatsAirportResourcesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatsAirportResourcesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsAirportResources", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratordepartureTerminal;
        private JSONHoldingStringGenerator fieldGeneratordepartureGate;
        private JSONHoldingStringGenerator fieldGeneratorarrivalTerminal;
        private JSONHoldingStringGenerator fieldGeneratorarrivalGate;
        private JSONHoldingStringGenerator fieldGeneratorbaggage;
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
            FlightStatsAirportResourcesJSON result = new FlightStatsAirportResourcesJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatsAirportResourcesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightStatsAirportResourcesJSON result)
          {
            if (fieldGeneratordepartureTerminal.have_value)
              {
                result.setdepartureTerminal(fieldGeneratordepartureTerminal.value);
                fieldGeneratordepartureTerminal.have_value = false;
              }
            if (fieldGeneratordepartureGate.have_value)
              {
                result.setdepartureGate(fieldGeneratordepartureGate.value);
                fieldGeneratordepartureGate.have_value = false;
              }
            if (fieldGeneratorarrivalTerminal.have_value)
              {
                result.setarrivalTerminal(fieldGeneratorarrivalTerminal.value);
                fieldGeneratorarrivalTerminal.have_value = false;
              }
            if (fieldGeneratorarrivalGate.have_value)
              {
                result.setarrivalGate(fieldGeneratorarrivalGate.value);
                fieldGeneratorarrivalGate.have_value = false;
              }
            if (fieldGeneratorbaggage.have_value)
              {
                result.setbaggage(fieldGeneratorbaggage.value);
                fieldGeneratorbaggage.have_value = false;
              }
          }
        protected abstract void handle_result(FlightStatsAirportResourcesJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    if (String.Compare(field_name, 1, "rrival", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'G':
                                if ((String.Compare(field_name, 8, "ate", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorarrivalGate;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 8, "erminal", 0, 7, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorarrivalTerminal;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'b':
                    if ((String.Compare(field_name, 1, "aggage", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorbaggage;
                    break;
                case 'd':
                    if (String.Compare(field_name, 1, "eparture", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'G':
                                if ((String.Compare(field_name, 10, "ate", 0, 3, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratordepartureGate;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 10, "erminal", 0, 7, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratordepartureTerminal;
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
            fieldGeneratordepartureTerminal = new JSONHoldingStringGenerator("field \"departureTerminal\" of the FlightStatsAirportResources class");
            fieldGeneratordepartureGate = new JSONHoldingStringGenerator("field \"departureGate\" of the FlightStatsAirportResources class");
            fieldGeneratorarrivalTerminal = new JSONHoldingStringGenerator("field \"arrivalTerminal\" of the FlightStatsAirportResources class");
            fieldGeneratorarrivalGate = new JSONHoldingStringGenerator("field \"arrivalGate\" of the FlightStatsAirportResources class");
            fieldGeneratorbaggage = new JSONHoldingStringGenerator("field \"baggage\" of the FlightStatsAirportResources class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatsAirportResources class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratordepartureTerminal = new JSONHoldingStringGenerator("field \"departureTerminal\" of the FlightStatsAirportResources class");
            fieldGeneratordepartureGate = new JSONHoldingStringGenerator("field \"departureGate\" of the FlightStatsAirportResources class");
            fieldGeneratorarrivalTerminal = new JSONHoldingStringGenerator("field \"arrivalTerminal\" of the FlightStatsAirportResources class");
            fieldGeneratorarrivalGate = new JSONHoldingStringGenerator("field \"arrivalGate\" of the FlightStatsAirportResources class");
            fieldGeneratorbaggage = new JSONHoldingStringGenerator("field \"baggage\" of the FlightStatsAirportResources class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatsAirportResources class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratordepartureTerminal.reset();
            fieldGeneratordepartureGate.reset();
            fieldGeneratorarrivalTerminal.reset();
            fieldGeneratorarrivalGate.reset();
            fieldGeneratorbaggage.reset();
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
        protected override void handle_result(FlightStatsAirportResourcesJSON  result)
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
        public FlightStatsAirportResourcesJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatsAirportResourcesJSON  result)
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
    protected virtual void handle_result(List<FlightStatsAirportResourcesJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatsAirportResourcesJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatsAirportResourcesJSON>();
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
    public List<FlightStatsAirportResourcesJSON> value;
  };
  };
