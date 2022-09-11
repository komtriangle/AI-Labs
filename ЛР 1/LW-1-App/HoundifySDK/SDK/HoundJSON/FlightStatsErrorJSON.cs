/* file "FlightStatsErrorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FlightStatsErrorJSON : JSONBase
  {
    private bool flagHashttpStatusCode;
    private BigInteger storehttpStatusCode;
    private bool flagHaserrorCode;
    private string storeerrorCode;
    private bool flagHaserrorId;
    private string storeerrorId;
    private bool flagHaserrorMessage;
    private string storeerrorMessage;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONhttpStatusCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field httpStatusCode of FlightStatsErrorJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field httpStatusCode of FlightStatsErrorJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        sethttpStatusCode(extracted_integer);
      }


    private void  fromJSONerrorCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field errorCode of FlightStatsErrorJSON is not a string.");
        seterrorCode(json_string.getData());
      }


    private void  fromJSONerrorId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field errorId of FlightStatsErrorJSON is not a string.");
        seterrorId(json_string.getData());
      }


    private void  fromJSONerrorMessage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field errorMessage of FlightStatsErrorJSON is not a string.");
        seterrorMessage(json_string.getData());
      }


    public FlightStatsErrorJSON()
      {
        flagHashttpStatusCode = false;
        flagHaserrorCode = false;
        flagHaserrorId = false;
        flagHaserrorMessage = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hashttpStatusCode()
      {
        return flagHashttpStatusCode;
      }

    public BigInteger  gethttpStatusCode()
      {
        Debug.Assert(flagHashttpStatusCode);
        return storehttpStatusCode;
      }

    public bool  haserrorCode()
      {
        return flagHaserrorCode;
      }

    public string  geterrorCode()
      {
        Debug.Assert(flagHaserrorCode);
        return storeerrorCode;
      }

    public bool  haserrorId()
      {
        return flagHaserrorId;
      }

    public string  geterrorId()
      {
        Debug.Assert(flagHaserrorId);
        return storeerrorId;
      }

    public bool  haserrorMessage()
      {
        return flagHaserrorMessage;
      }

    public string  geterrorMessage()
      {
        Debug.Assert(flagHaserrorMessage);
        return storeerrorMessage;
      }


    public virtual int extraFlightStatsErrorComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatsErrorComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatsErrorComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatsErrorLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void sethttpStatusCode(BigInteger new_value)
      {
        flagHashttpStatusCode = true;
        storehttpStatusCode = new_value;
      }
    public void unsethttpStatusCode()
      {
        flagHashttpStatusCode = false;
      }
    public void seterrorCode(string new_value)
      {
        flagHaserrorCode = true;
        storeerrorCode = new_value;
      }
    public void unseterrorCode()
      {
        flagHaserrorCode = false;
      }
    public void seterrorId(string new_value)
      {
        flagHaserrorId = true;
        storeerrorId = new_value;
      }
    public void unseterrorId()
      {
        flagHaserrorId = false;
      }
    public void seterrorMessage(string new_value)
      {
        flagHaserrorMessage = true;
        storeerrorMessage = new_value;
      }
    public void unseterrorMessage()
      {
        flagHaserrorMessage = false;
      }

    public virtual void extraFlightStatsErrorAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatsErrorSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatsErrorLookup(key);
        if (old_field == null)
          {
            extraFlightStatsErrorAppendPair(key, new_component);
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
        if (flagHashttpStatusCode)
          {
            handler.start_pair("httpStatusCode");
            handler.number_value(storehttpStatusCode);
          }
        if (flagHaserrorCode)
          {
            handler.start_pair("errorCode");
            handler.string_value(storeerrorCode);
          }
        if (flagHaserrorId)
          {
            handler.start_pair("errorId");
            handler.string_value(storeerrorId);
          }
        if (flagHaserrorMessage)
          {
            handler.start_pair("errorMessage");
            handler.string_value(storeerrorMessage);
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

    public static FlightStatsErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsError", ignore_extras);
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
    public static FlightStatsErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatsErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsError", ignore_extras);
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
    public static FlightStatsErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatsErrorJSON from_text(string text, bool ignore_extras)
      {
        FlightStatsErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsError", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatsErrorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightStatsErrorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatsErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsError", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorhttpStatusCode : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorhttpStatusCode(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorhttpStatusCode : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorhttpStatusCode(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorhttpStatusCode fieldGeneratorhttpStatusCode;
        private JSONHoldingStringGenerator fieldGeneratorerrorCode;
        private JSONHoldingStringGenerator fieldGeneratorerrorId;
        private JSONHoldingStringGenerator fieldGeneratorerrorMessage;
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
            FlightStatsErrorJSON result = new FlightStatsErrorJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatsErrorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightStatsErrorJSON result)
          {
            if (fieldGeneratorhttpStatusCode.have_value)
              {
                result.sethttpStatusCode(fieldGeneratorhttpStatusCode.value);
                fieldGeneratorhttpStatusCode.have_value = false;
              }
            if (fieldGeneratorerrorCode.have_value)
              {
                result.seterrorCode(fieldGeneratorerrorCode.value);
                fieldGeneratorerrorCode.have_value = false;
              }
            if (fieldGeneratorerrorId.have_value)
              {
                result.seterrorId(fieldGeneratorerrorId.value);
                fieldGeneratorerrorId.have_value = false;
              }
            if (fieldGeneratorerrorMessage.have_value)
              {
                result.seterrorMessage(fieldGeneratorerrorMessage.value);
                fieldGeneratorerrorMessage.have_value = false;
              }
          }
        protected abstract void handle_result(FlightStatsErrorJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'e':
                    if (String.Compare(field_name, 1, "rror", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 6, "ode", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorerrorCode;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 6, "d", 0, 1, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorerrorId;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 6, "essage", 0, 6, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorerrorMessage;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'h':
                    if ((String.Compare(field_name, 1, "ttpStatusCode", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorhttpStatusCode;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorhttpStatusCode = new FieldHoldingGeneratorhttpStatusCode("field \"httpStatusCode\" of the FlightStatsError class");
            fieldGeneratorerrorCode = new JSONHoldingStringGenerator("field \"errorCode\" of the FlightStatsError class");
            fieldGeneratorerrorId = new JSONHoldingStringGenerator("field \"errorId\" of the FlightStatsError class");
            fieldGeneratorerrorMessage = new JSONHoldingStringGenerator("field \"errorMessage\" of the FlightStatsError class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatsError class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorhttpStatusCode = new FieldHoldingGeneratorhttpStatusCode("field \"httpStatusCode\" of the FlightStatsError class");
            fieldGeneratorerrorCode = new JSONHoldingStringGenerator("field \"errorCode\" of the FlightStatsError class");
            fieldGeneratorerrorId = new JSONHoldingStringGenerator("field \"errorId\" of the FlightStatsError class");
            fieldGeneratorerrorMessage = new JSONHoldingStringGenerator("field \"errorMessage\" of the FlightStatsError class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatsError class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorhttpStatusCode.reset();
            fieldGeneratorerrorCode.reset();
            fieldGeneratorerrorId.reset();
            fieldGeneratorerrorMessage.reset();
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
        protected override void handle_result(FlightStatsErrorJSON  result)
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
        public FlightStatsErrorJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatsErrorJSON  result)
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
    protected virtual void handle_result(List<FlightStatsErrorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatsErrorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatsErrorJSON>();
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
    public List<FlightStatsErrorJSON> value;
  };
  };
