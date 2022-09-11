/* file "ParkingClientStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ParkingClientStateJSON : JSONBase
  {
    private bool flagHasParkingClientId;
    private string storeParkingClientId;
    private bool flagHasEarliestArrivalTime;
    private DateAndOrTimeJSON  storeEarliestArrivalTime;
    private bool flagHasPassThru;
    private BigInteger storePassThru;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONParkingClientId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ParkingClientId of ParkingClientStateJSON is not a string.");
        setParkingClientId(json_string.getData());
      }


    private void  fromJSONEarliestArrivalTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEarliestArrivalTime(convert_classy);
      }


    private void  fromJSONPassThru(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PassThru of ParkingClientStateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PassThru of ParkingClientStateJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPassThru(extracted_integer);
      }


    public ParkingClientStateJSON()
      {
        flagHasParkingClientId = false;
        flagHasEarliestArrivalTime = false;
        flagHasPassThru = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasParkingClientId()
      {
        return flagHasParkingClientId;
      }

    public string  getParkingClientId()
      {
        Debug.Assert(flagHasParkingClientId);
        return storeParkingClientId;
      }

    public bool  hasEarliestArrivalTime()
      {
        return flagHasEarliestArrivalTime;
      }

    public DateAndOrTimeJSON   getEarliestArrivalTime()
      {
        Debug.Assert(flagHasEarliestArrivalTime);
        return storeEarliestArrivalTime;
      }

    public bool  hasPassThru()
      {
        return flagHasPassThru;
      }

    public BigInteger  getPassThru()
      {
        Debug.Assert(flagHasPassThru);
        return storePassThru;
      }


    public virtual int extraParkingClientStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraParkingClientStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraParkingClientStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraParkingClientStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setParkingClientId(string new_value)
      {
        flagHasParkingClientId = true;
        storeParkingClientId = new_value;
      }
    public void unsetParkingClientId()
      {
        flagHasParkingClientId = false;
      }
    public void setEarliestArrivalTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEarliestArrivalTime)
          {
          }
        flagHasEarliestArrivalTime = true;
        storeEarliestArrivalTime = new_value;
      }
    public void unsetEarliestArrivalTime()
      {
        if (flagHasEarliestArrivalTime)
          {
          }
        flagHasEarliestArrivalTime = false;
      }
    public void setPassThru(BigInteger new_value)
      {
        flagHasPassThru = true;
        storePassThru = new_value;
      }
    public void unsetPassThru()
      {
        flagHasPassThru = false;
      }

    public virtual void extraParkingClientStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraParkingClientStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraParkingClientStateLookup(key);
        if (old_field == null)
          {
            extraParkingClientStateAppendPair(key, new_component);
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
        if (flagHasParkingClientId)
          {
            handler.start_pair("ParkingClientId");
            handler.string_value(storeParkingClientId);
          }
        if (flagHasEarliestArrivalTime)
          {
            handler.start_pair("EarliestArrivalTime");
            if (partial_allowed)
                storeEarliestArrivalTime.write_partial_as_json(handler);
            else
                storeEarliestArrivalTime.write_as_json(handler);
          }
        if (flagHasPassThru)
          {
            handler.start_pair("PassThru");
            handler.number_value(storePassThru);
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

    public static ParkingClientStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ParkingClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ParkingClientState", ignore_extras);
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
    public static ParkingClientStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ParkingClientStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ParkingClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ParkingClientState", ignore_extras);
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
    public static ParkingClientStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ParkingClientStateJSON from_text(string text, bool ignore_extras)
      {
        ParkingClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ParkingClientState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ParkingClientStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ParkingClientStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ParkingClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ParkingClientState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorParkingClientId;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEarliestArrivalTime;
    private class FieldHoldingGeneratorPassThru : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorPassThru(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPassThru : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPassThru(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorPassThru fieldGeneratorPassThru;
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
            ParkingClientStateJSON result = new ParkingClientStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraParkingClientStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ParkingClientStateJSON result)
          {
            if (fieldGeneratorParkingClientId.have_value)
              {
                result.setParkingClientId(fieldGeneratorParkingClientId.value);
                fieldGeneratorParkingClientId.have_value = false;
              }
            if (fieldGeneratorEarliestArrivalTime.have_value)
              {
                result.setEarliestArrivalTime(fieldGeneratorEarliestArrivalTime.value);
                fieldGeneratorEarliestArrivalTime.have_value = false;
              }
            if (fieldGeneratorPassThru.have_value)
              {
                result.setPassThru(fieldGeneratorPassThru.value);
                fieldGeneratorPassThru.have_value = false;
              }
          }
        protected abstract void handle_result(ParkingClientStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "arliestArrivalTime", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorEarliestArrivalTime;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "a", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'r':
                                if ((String.Compare(field_name, 3, "kingClientId", 0, 12, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorParkingClientId;
                                break;
                            case 's':
                                if ((String.Compare(field_name, 3, "sThru", 0, 5, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorPassThru;
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
            fieldGeneratorParkingClientId = new JSONHoldingStringGenerator("field \"ParkingClientId\" of the ParkingClientState class");
            fieldGeneratorEarliestArrivalTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EarliestArrivalTime\" of the ParkingClientState class", ignore_extras);
            fieldGeneratorPassThru = new FieldHoldingGeneratorPassThru("field \"PassThru\" of the ParkingClientState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ParkingClientState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorParkingClientId = new JSONHoldingStringGenerator("field \"ParkingClientId\" of the ParkingClientState class");
            fieldGeneratorEarliestArrivalTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EarliestArrivalTime\" of the ParkingClientState class", false);
            fieldGeneratorPassThru = new FieldHoldingGeneratorPassThru("field \"PassThru\" of the ParkingClientState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ParkingClientState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorParkingClientId.reset();
            fieldGeneratorEarliestArrivalTime.reset();
            fieldGeneratorPassThru.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorEarliestArrivalTime.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorEarliestArrivalTime.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ParkingClientStateJSON  result)
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
        public ParkingClientStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ParkingClientStateJSON  result)
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
    protected virtual void handle_result(List<ParkingClientStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ParkingClientStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ParkingClientStateJSON>();
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
    public List<ParkingClientStateJSON> value;
  };
  };
