/* file "ChargingClientStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ChargingClientStateJSON : JSONBase
  {
    private bool flagHasCustomizeId;
    private string storeCustomizeId;
    private bool flagHasPassThru;
    private BigInteger storePassThru;
    private bool flagHasAvailableRange;
    private BigInteger storeAvailableRange;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCustomizeId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CustomizeId of ChargingClientStateJSON is not a string.");
        setCustomizeId(json_string.getData());
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
                throw new Exception("The value for field PassThru of ChargingClientStateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PassThru of ChargingClientStateJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPassThru(extracted_integer);
      }


    private void  fromJSONAvailableRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field AvailableRange of ChargingClientStateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AvailableRange of ChargingClientStateJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAvailableRange(extracted_integer);
      }


    public ChargingClientStateJSON()
      {
        flagHasCustomizeId = false;
        flagHasPassThru = false;
        flagHasAvailableRange = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCustomizeId()
      {
        return flagHasCustomizeId;
      }

    public string  getCustomizeId()
      {
        Debug.Assert(flagHasCustomizeId);
        return storeCustomizeId;
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

    public bool  hasAvailableRange()
      {
        return flagHasAvailableRange;
      }

    public BigInteger  getAvailableRange()
      {
        Debug.Assert(flagHasAvailableRange);
        return storeAvailableRange;
      }


    public virtual int extraChargingClientStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraChargingClientStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraChargingClientStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraChargingClientStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCustomizeId(string new_value)
      {
        flagHasCustomizeId = true;
        storeCustomizeId = new_value;
      }
    public void unsetCustomizeId()
      {
        flagHasCustomizeId = false;
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
    public void setAvailableRange(BigInteger new_value)
      {
        flagHasAvailableRange = true;
        storeAvailableRange = new_value;
      }
    public void unsetAvailableRange()
      {
        flagHasAvailableRange = false;
      }

    public virtual void extraChargingClientStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraChargingClientStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraChargingClientStateLookup(key);
        if (old_field == null)
          {
            extraChargingClientStateAppendPair(key, new_component);
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
        if (flagHasCustomizeId)
          {
            handler.start_pair("CustomizeId");
            handler.string_value(storeCustomizeId);
          }
        if (flagHasPassThru)
          {
            handler.start_pair("PassThru");
            handler.number_value(storePassThru);
          }
        if (flagHasAvailableRange)
          {
            handler.start_pair("AvailableRange");
            handler.number_value(storeAvailableRange);
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

    public static ChargingClientStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChargingClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChargingClientState", ignore_extras);
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
    public static ChargingClientStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ChargingClientStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChargingClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChargingClientState", ignore_extras);
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
    public static ChargingClientStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ChargingClientStateJSON from_text(string text, bool ignore_extras)
      {
        ChargingClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChargingClientState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ChargingClientStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ChargingClientStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ChargingClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChargingClientState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorCustomizeId;
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
    private class FieldHoldingGeneratorAvailableRange : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorAvailableRange(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorAvailableRange : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorAvailableRange(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorAvailableRange fieldGeneratorAvailableRange;
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
            ChargingClientStateJSON result = new ChargingClientStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraChargingClientStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ChargingClientStateJSON result)
          {
            if (fieldGeneratorCustomizeId.have_value)
              {
                result.setCustomizeId(fieldGeneratorCustomizeId.value);
                fieldGeneratorCustomizeId.have_value = false;
              }
            if (fieldGeneratorPassThru.have_value)
              {
                result.setPassThru(fieldGeneratorPassThru.value);
                fieldGeneratorPassThru.have_value = false;
              }
            if (fieldGeneratorAvailableRange.have_value)
              {
                result.setAvailableRange(fieldGeneratorAvailableRange.value);
                fieldGeneratorAvailableRange.have_value = false;
              }
          }
        protected abstract void handle_result(ChargingClientStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "vailableRange", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorAvailableRange;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "ustomizeId", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCustomizeId;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "assThru", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorPassThru;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCustomizeId = new JSONHoldingStringGenerator("field \"CustomizeId\" of the ChargingClientState class");
            fieldGeneratorPassThru = new FieldHoldingGeneratorPassThru("field \"PassThru\" of the ChargingClientState class");
            fieldGeneratorAvailableRange = new FieldHoldingGeneratorAvailableRange("field \"AvailableRange\" of the ChargingClientState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ChargingClientState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCustomizeId = new JSONHoldingStringGenerator("field \"CustomizeId\" of the ChargingClientState class");
            fieldGeneratorPassThru = new FieldHoldingGeneratorPassThru("field \"PassThru\" of the ChargingClientState class");
            fieldGeneratorAvailableRange = new FieldHoldingGeneratorAvailableRange("field \"AvailableRange\" of the ChargingClientState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ChargingClientState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCustomizeId.reset();
            fieldGeneratorPassThru.reset();
            fieldGeneratorAvailableRange.reset();
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
        protected override void handle_result(ChargingClientStateJSON  result)
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
        public ChargingClientStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ChargingClientStateJSON  result)
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
    protected virtual void handle_result(List<ChargingClientStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ChargingClientStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ChargingClientStateJSON>();
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
    public List<ChargingClientStateJSON> value;
  };
  };
