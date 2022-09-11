/* file "StreamFulfillmentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class StreamFulfillmentJSON : JSONBase
  {
    private bool flagHasURL;
    private string storeURL;
    private bool flagHasEncoding;
    private StreamEncodingEnumJSON  storeEncoding;
    private bool flagHasBitsPerSecond;
    private BigInteger storeBitsPerSecond;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field URL of StreamFulfillmentJSON is not a string.");
        setURL(json_string.getData());
      }


    private void  fromJSONEncoding(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StreamEncodingEnumJSON convert_classy = StreamEncodingEnumJSON.from_json(json_value, ignore_extras, true);
        setEncoding(convert_classy);
      }


    private void  fromJSONBitsPerSecond(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field BitsPerSecond of StreamFulfillmentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field BitsPerSecond of StreamFulfillmentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setBitsPerSecond(extracted_integer);
      }


    public StreamFulfillmentJSON()
      {
        flagHasURL = false;
        flagHasEncoding = false;
        flagHasBitsPerSecond = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasURL()
      {
        return flagHasURL;
      }

    public string  getURL()
      {
        Debug.Assert(flagHasURL);
        return storeURL;
      }

    public bool  hasEncoding()
      {
        return flagHasEncoding;
      }

    public StreamEncodingEnumJSON   getEncoding()
      {
        Debug.Assert(flagHasEncoding);
        return storeEncoding;
      }

    public StreamEncodingEnumJSON.TypeValue  getEncodingValue()
      {
        return getEncoding().getValue();
      }

    public string  getEncodingAsString()
      {
        return getEncoding().getValueAsString();
      }

    public bool  hasBitsPerSecond()
      {
        return flagHasBitsPerSecond;
      }

    public BigInteger  getBitsPerSecond()
      {
        Debug.Assert(flagHasBitsPerSecond);
        return storeBitsPerSecond;
      }


    public virtual int extraStreamFulfillmentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStreamFulfillmentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStreamFulfillmentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStreamFulfillmentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setURL(string new_value)
      {
        flagHasURL = true;
        storeURL = new_value;
      }
    public void unsetURL()
      {
        flagHasURL = false;
      }
    public void setEncoding(StreamEncodingEnumJSON  new_value)
      {
        if (flagHasEncoding)
          {
          }
        flagHasEncoding = true;
        storeEncoding = new_value;
      }
    public void setEncoding(StreamEncodingEnumJSON.TypeValue new_value)
      {
        setEncoding(new StreamEncodingEnumJSON(new_value));
      }
    public void setEncoding(string chars)
      {
        StreamEncodingEnumJSON.TypeValueKnownValues known = StreamEncodingEnumJSON.stringToValue(chars);
        StreamEncodingEnumJSON.TypeValue new_value = new StreamEncodingEnumJSON.TypeValue();
        if (known == StreamEncodingEnumJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setEncoding(new_value);
      }
    public void unsetEncoding()
      {
        if (flagHasEncoding)
          {
          }
        flagHasEncoding = false;
      }
    public void setBitsPerSecond(BigInteger new_value)
      {
        flagHasBitsPerSecond = true;
        storeBitsPerSecond = new_value;
      }
    public void unsetBitsPerSecond()
      {
        flagHasBitsPerSecond = false;
      }

    public virtual void extraStreamFulfillmentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStreamFulfillmentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStreamFulfillmentLookup(key);
        if (old_field == null)
          {
            extraStreamFulfillmentAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasURL);
        if (flagHasURL)
          {
            handler.start_pair("URL");
            handler.string_value(storeURL);
          }
        if (flagHasEncoding)
          {
            handler.start_pair("Encoding");
            if (partial_allowed)
                storeEncoding.write_partial_as_json(handler);
            else
                storeEncoding.write_as_json(handler);
          }
        if (flagHasBitsPerSecond)
          {
            handler.start_pair("BitsPerSecond");
            handler.number_value(storeBitsPerSecond);
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
        if (!(hasURL()))
          {
            return "When parsing the object for %what%, the \"URL\" field was missing.";
          }
        return null;
      }

    public static StreamFulfillmentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StreamFulfillmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamFulfillment", ignore_extras);
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
    public static StreamFulfillmentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StreamFulfillmentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StreamFulfillmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamFulfillment", ignore_extras);
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
    public static StreamFulfillmentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StreamFulfillmentJSON from_text(string text, bool ignore_extras)
      {
        StreamFulfillmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamFulfillment", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StreamFulfillmentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StreamFulfillmentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StreamFulfillmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamFulfillment", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorURL;
        private StreamEncodingEnumJSON.HoldingGenerator fieldGeneratorEncoding;
    private class FieldHoldingGeneratorBitsPerSecond : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorBitsPerSecond(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorBitsPerSecond : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorBitsPerSecond(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorBitsPerSecond fieldGeneratorBitsPerSecond;
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
            StreamFulfillmentJSON result = new StreamFulfillmentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStreamFulfillmentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StreamFulfillmentJSON result)
          {
            if (fieldGeneratorURL.have_value)
              {
                result.setURL(fieldGeneratorURL.value);
                fieldGeneratorURL.have_value = false;
              }
            else if ((!(result.hasURL())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"URL\" field was missing.");
              }
            if (fieldGeneratorEncoding.have_value)
              {
                result.setEncoding(fieldGeneratorEncoding.value);
                fieldGeneratorEncoding.have_value = false;
              }
            if (fieldGeneratorBitsPerSecond.have_value)
              {
                result.setBitsPerSecond(fieldGeneratorBitsPerSecond.value);
                fieldGeneratorBitsPerSecond.have_value = false;
              }
          }
        protected abstract void handle_result(StreamFulfillmentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "itsPerSecond", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorBitsPerSecond;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "ncoding", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorEncoding;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "RL", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorURL;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the StreamFulfillment class");
            fieldGeneratorEncoding = new StreamEncodingEnumJSON.HoldingGenerator("field \"Encoding\" of the StreamFulfillment class", ignore_extras);
            fieldGeneratorBitsPerSecond = new FieldHoldingGeneratorBitsPerSecond("field \"BitsPerSecond\" of the StreamFulfillment class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StreamFulfillment class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the StreamFulfillment class");
            fieldGeneratorEncoding = new StreamEncodingEnumJSON.HoldingGenerator("field \"Encoding\" of the StreamFulfillment class", false);
            fieldGeneratorBitsPerSecond = new FieldHoldingGeneratorBitsPerSecond("field \"BitsPerSecond\" of the StreamFulfillment class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StreamFulfillment class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorURL.reset();
            fieldGeneratorEncoding.reset();
            fieldGeneratorBitsPerSecond.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorEncoding.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorEncoding.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StreamFulfillmentJSON  result)
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
        public StreamFulfillmentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StreamFulfillmentJSON  result)
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
    protected virtual void handle_result(List<StreamFulfillmentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StreamFulfillmentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StreamFulfillmentJSON>();
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
    public List<StreamFulfillmentJSON> value;
  };
  };
