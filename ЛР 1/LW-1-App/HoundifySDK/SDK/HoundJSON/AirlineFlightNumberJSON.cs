/* file "AirlineFlightNumberJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AirlineFlightNumberJSON : JSONBase
  {
    private bool flagHasAirline;
    private AirlineJSON  storeAirline;
    private bool flagHasFlightNumber;
    private short storeFlightNumber;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONAirline(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AirlineJSON convert_classy = AirlineJSON.from_json(json_value, ignore_extras, true);
        setAirline(convert_classy);
      }


    private void  fromJSONFlightNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        short extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FlightNumber of AirlineFlightNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FlightNumber of AirlineFlightNumberJSON is not an integer.");
              }
            extracted_integer = (short)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (short)(json_integer.getLongInt())        ;
          }
        setFlightNumber(extracted_integer);
      }


    public AirlineFlightNumberJSON()
      {
        flagHasAirline = false;
        flagHasFlightNumber = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasAirline()
      {
        return flagHasAirline;
      }

    public AirlineJSON   getAirline()
      {
        Debug.Assert(flagHasAirline);
        return storeAirline;
      }

    public bool  hasFlightNumber()
      {
        return flagHasFlightNumber;
      }

    public short  getFlightNumber()
      {
        Debug.Assert(flagHasFlightNumber);
        return storeFlightNumber;
      }


    public virtual int extraAirlineFlightNumberComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAirlineFlightNumberComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAirlineFlightNumberComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAirlineFlightNumberLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setAirline(AirlineJSON  new_value)
      {
        if (flagHasAirline)
          {
          }
        flagHasAirline = true;
        storeAirline = new_value;
      }
    public void unsetAirline()
      {
        if (flagHasAirline)
          {
          }
        flagHasAirline = false;
      }
    public void setFlightNumber(short new_value)
      {
        flagHasFlightNumber = true;
        if (new_value < 0)
            throw new Exception("The value for field FlightNumber of AirlineFlightNumberJSON is less than the lower bound (0) for that field.");
        if (new_value > 9999)
            throw new Exception("The value for field FlightNumber of AirlineFlightNumberJSON is greater than the upper bound (9999) for that field.");
        storeFlightNumber = new_value;
      }
    public void unsetFlightNumber()
      {
        flagHasFlightNumber = false;
      }

    public virtual void extraAirlineFlightNumberAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAirlineFlightNumberSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAirlineFlightNumberLookup(key);
        if (old_field == null)
          {
            extraAirlineFlightNumberAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAirline);
        if (flagHasAirline)
          {
            handler.start_pair("Airline");
            if (partial_allowed)
                storeAirline.write_partial_as_json(handler);
            else
                storeAirline.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasFlightNumber);
        if (flagHasFlightNumber)
          {
            handler.start_pair("FlightNumber");
            handler.number_value(storeFlightNumber);
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
        if (!(hasAirline()))
          {
            return "When parsing the object for %what%, the \"Airline\" field was missing.";
          }
        if (!(hasFlightNumber()))
          {
            return "When parsing the object for %what%, the \"FlightNumber\" field was missing.";
          }
        return null;
      }

    public static AirlineFlightNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AirlineFlightNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AirlineFlightNumber", ignore_extras);
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
    public static AirlineFlightNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AirlineFlightNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AirlineFlightNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AirlineFlightNumber", ignore_extras);
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
    public static AirlineFlightNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AirlineFlightNumberJSON from_text(string text, bool ignore_extras)
      {
        AirlineFlightNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AirlineFlightNumber", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AirlineFlightNumberJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AirlineFlightNumberJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AirlineFlightNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AirlineFlightNumber", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private AirlineJSON.HoldingGenerator fieldGeneratorAirline;
    private class FieldHoldingGeneratorFlightNumber : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorFlightNumber(String what) : base(what, 0, 9999)
              {
              }
          };
    private class FieldHoldingArrayGeneratorFlightNumber : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorFlightNumber(String what) : base(what, 0, 9999)
              {
              }
          };
        private FieldHoldingGeneratorFlightNumber fieldGeneratorFlightNumber;
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
            AirlineFlightNumberJSON result = new AirlineFlightNumberJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAirlineFlightNumberAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(AirlineFlightNumberJSON result)
          {
            if (fieldGeneratorAirline.have_value)
              {
                result.setAirline(fieldGeneratorAirline.value);
                fieldGeneratorAirline.have_value = false;
              }
            else if ((!(result.hasAirline())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Airline\" field was missing.");
              }
            if (fieldGeneratorFlightNumber.have_value)
              {
                result.setFlightNumber((short)(fieldGeneratorFlightNumber.value));
                fieldGeneratorFlightNumber.have_value = false;
              }
            else if ((!(result.hasFlightNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlightNumber\" field was missing.");
              }
          }
        protected abstract void handle_result(AirlineFlightNumberJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "irline", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorAirline;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "lightNumber", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorFlightNumber;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAirline = new AirlineJSON.HoldingGenerator("field \"Airline\" of the AirlineFlightNumber class", ignore_extras);
            fieldGeneratorFlightNumber = new FieldHoldingGeneratorFlightNumber("field \"FlightNumber\" of the AirlineFlightNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AirlineFlightNumber class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAirline = new AirlineJSON.HoldingGenerator("field \"Airline\" of the AirlineFlightNumber class", false);
            fieldGeneratorFlightNumber = new FieldHoldingGeneratorFlightNumber("field \"FlightNumber\" of the AirlineFlightNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AirlineFlightNumber class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorAirline.reset();
            fieldGeneratorFlightNumber.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAirline.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAirline.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(AirlineFlightNumberJSON  result)
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
        public AirlineFlightNumberJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AirlineFlightNumberJSON  result)
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
    protected virtual void handle_result(List<AirlineFlightNumberJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AirlineFlightNumberJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AirlineFlightNumberJSON>();
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
    public List<AirlineFlightNumberJSON> value;
  };
  };
