/* file "FlightPassengerTypeCountJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FlightPassengerTypeCountJSON : JSONBase
  {
    private bool flagHasPassengerType;
    private FlightPassengerTypeJSON  storePassengerType;
    private bool flagHasCount;
    private BigInteger storeCount;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPassengerType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightPassengerTypeJSON convert_classy = FlightPassengerTypeJSON.from_json(json_value, ignore_extras, true);
        setPassengerType(convert_classy);
      }


    private void  fromJSONCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Count of FlightPassengerTypeCountJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Count of FlightPassengerTypeCountJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCount(extracted_integer);
      }


    public FlightPassengerTypeCountJSON()
      {
        flagHasPassengerType = false;
        flagHasCount = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPassengerType()
      {
        return flagHasPassengerType;
      }

    public FlightPassengerTypeJSON   getPassengerType()
      {
        Debug.Assert(flagHasPassengerType);
        return storePassengerType;
      }

    public FlightPassengerTypeJSON.TypeValue  getPassengerTypeValue()
      {
        return getPassengerType().getValue();
      }

    public string  getPassengerTypeAsString()
      {
        return getPassengerType().getValueAsString();
      }

    public bool  hasCount()
      {
        return flagHasCount;
      }

    public BigInteger  getCount()
      {
        Debug.Assert(flagHasCount);
        return storeCount;
      }


    public virtual int extraFlightPassengerTypeCountComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightPassengerTypeCountComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightPassengerTypeCountComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightPassengerTypeCountLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPassengerType(FlightPassengerTypeJSON  new_value)
      {
        if (flagHasPassengerType)
          {
          }
        flagHasPassengerType = true;
        storePassengerType = new_value;
      }
    public void setPassengerType(FlightPassengerTypeJSON.TypeValue new_value)
      {
        setPassengerType(new FlightPassengerTypeJSON(new_value));
      }
    public void setPassengerType(string chars)
      {
        FlightPassengerTypeJSON.TypeValueKnownValues known = FlightPassengerTypeJSON.stringToValue(chars);
        FlightPassengerTypeJSON.TypeValue new_value = new FlightPassengerTypeJSON.TypeValue();
        if (known == FlightPassengerTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPassengerType(new_value);
      }
    public void unsetPassengerType()
      {
        if (flagHasPassengerType)
          {
          }
        flagHasPassengerType = false;
      }
    public void setCount(BigInteger new_value)
      {
        flagHasCount = true;
        if (new_value < 0)
            throw new Exception("The value for field Count of FlightPassengerTypeCountJSON is less than the lower bound (0) for that field.");
        storeCount = new_value;
      }
    public void unsetCount()
      {
        flagHasCount = false;
      }

    public virtual void extraFlightPassengerTypeCountAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightPassengerTypeCountSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightPassengerTypeCountLookup(key);
        if (old_field == null)
          {
            extraFlightPassengerTypeCountAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPassengerType);
        if (flagHasPassengerType)
          {
            handler.start_pair("PassengerType");
            if (partial_allowed)
                storePassengerType.write_partial_as_json(handler);
            else
                storePassengerType.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasCount);
        if (flagHasCount)
          {
            handler.start_pair("Count");
            handler.number_value(storeCount);
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
        if (!(hasPassengerType()))
          {
            return "When parsing the object for %what%, the \"PassengerType\" field was missing.";
          }
        if (!(hasCount()))
          {
            return "When parsing the object for %what%, the \"Count\" field was missing.";
          }
        return null;
      }

    public static FlightPassengerTypeCountJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightPassengerTypeCountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightPassengerTypeCount", ignore_extras);
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
    public static FlightPassengerTypeCountJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightPassengerTypeCountJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightPassengerTypeCountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightPassengerTypeCount", ignore_extras);
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
    public static FlightPassengerTypeCountJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightPassengerTypeCountJSON from_text(string text, bool ignore_extras)
      {
        FlightPassengerTypeCountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightPassengerTypeCount", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightPassengerTypeCountJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightPassengerTypeCountJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightPassengerTypeCountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightPassengerTypeCount", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private FlightPassengerTypeJSON.HoldingGenerator fieldGeneratorPassengerType;
    private class FieldHoldingGeneratorCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorCount fieldGeneratorCount;
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
            FlightPassengerTypeCountJSON result = new FlightPassengerTypeCountJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightPassengerTypeCountAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightPassengerTypeCountJSON result)
          {
            if (fieldGeneratorPassengerType.have_value)
              {
                result.setPassengerType(fieldGeneratorPassengerType.value);
                fieldGeneratorPassengerType.have_value = false;
              }
            else if ((!(result.hasPassengerType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PassengerType\" field was missing.");
              }
            if (fieldGeneratorCount.have_value)
              {
                result.setCount(fieldGeneratorCount.value);
                fieldGeneratorCount.have_value = false;
              }
            else if ((!(result.hasCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Count\" field was missing.");
              }
          }
        protected abstract void handle_result(FlightPassengerTypeCountJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ount", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorCount;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "assengerType", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorPassengerType;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPassengerType = new FlightPassengerTypeJSON.HoldingGenerator("field \"PassengerType\" of the FlightPassengerTypeCount class", ignore_extras);
            fieldGeneratorCount = new FieldHoldingGeneratorCount("field \"Count\" of the FlightPassengerTypeCount class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightPassengerTypeCount class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPassengerType = new FlightPassengerTypeJSON.HoldingGenerator("field \"PassengerType\" of the FlightPassengerTypeCount class", false);
            fieldGeneratorCount = new FieldHoldingGeneratorCount("field \"Count\" of the FlightPassengerTypeCount class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightPassengerTypeCount class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPassengerType.reset();
            fieldGeneratorCount.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPassengerType.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPassengerType.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightPassengerTypeCountJSON  result)
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
        public FlightPassengerTypeCountJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightPassengerTypeCountJSON  result)
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
    protected virtual void handle_result(List<FlightPassengerTypeCountJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightPassengerTypeCountJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightPassengerTypeCountJSON>();
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
    public List<FlightPassengerTypeCountJSON> value;
  };
  };
