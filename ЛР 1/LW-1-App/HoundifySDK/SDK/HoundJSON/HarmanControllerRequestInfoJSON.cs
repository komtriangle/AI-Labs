/* file "HarmanControllerRequestInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HarmanControllerRequestInfoJSON : JSONBase
  {
    private bool flagHasURL;
    private string storeURL;
    private bool flagHasTimestamp;
    private BigInteger storeTimestamp;
    private bool flagHasMessageID;
    private string storeMessageID;
    private bool flagHasMessageBody;
    private string storeMessageBody;
    private bool flagHasResponseCode;
    private BigInteger storeResponseCode;
    private bool flagHasResponseBody;
    private string storeResponseBody;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field URL of HarmanControllerRequestInfoJSON is not a string.");
        setURL(json_string.getData());
      }


    private void  fromJSONTimestamp(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Timestamp of HarmanControllerRequestInfoJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Timestamp of HarmanControllerRequestInfoJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTimestamp(extracted_integer);
      }


    private void  fromJSONMessageID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MessageID of HarmanControllerRequestInfoJSON is not a string.");
        setMessageID(json_string.getData());
      }


    private void  fromJSONMessageBody(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MessageBody of HarmanControllerRequestInfoJSON is not a string.");
        setMessageBody(json_string.getData());
      }


    private void  fromJSONResponseCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ResponseCode of HarmanControllerRequestInfoJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ResponseCode of HarmanControllerRequestInfoJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setResponseCode(extracted_integer);
      }


    private void  fromJSONResponseBody(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResponseBody of HarmanControllerRequestInfoJSON is not a string.");
        setResponseBody(json_string.getData());
      }


    public HarmanControllerRequestInfoJSON()
      {
        flagHasURL = false;
        flagHasTimestamp = false;
        flagHasMessageID = false;
        flagHasMessageBody = false;
        flagHasResponseCode = false;
        flagHasResponseBody = false;
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

    public bool  hasTimestamp()
      {
        return flagHasTimestamp;
      }

    public BigInteger  getTimestamp()
      {
        Debug.Assert(flagHasTimestamp);
        return storeTimestamp;
      }

    public bool  hasMessageID()
      {
        return flagHasMessageID;
      }

    public string  getMessageID()
      {
        Debug.Assert(flagHasMessageID);
        return storeMessageID;
      }

    public bool  hasMessageBody()
      {
        return flagHasMessageBody;
      }

    public string  getMessageBody()
      {
        Debug.Assert(flagHasMessageBody);
        return storeMessageBody;
      }

    public bool  hasResponseCode()
      {
        return flagHasResponseCode;
      }

    public BigInteger  getResponseCode()
      {
        Debug.Assert(flagHasResponseCode);
        return storeResponseCode;
      }

    public bool  hasResponseBody()
      {
        return flagHasResponseBody;
      }

    public string  getResponseBody()
      {
        Debug.Assert(flagHasResponseBody);
        return storeResponseBody;
      }


    public virtual int extraHarmanControllerRequestInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHarmanControllerRequestInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHarmanControllerRequestInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHarmanControllerRequestInfoLookup(string field_name)
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
    public void setTimestamp(BigInteger new_value)
      {
        flagHasTimestamp = true;
        if (new_value < 0)
            throw new Exception("The value for field Timestamp of HarmanControllerRequestInfoJSON is less than the lower bound (0) for that field.");
        storeTimestamp = new_value;
      }
    public void unsetTimestamp()
      {
        flagHasTimestamp = false;
      }
    public void setMessageID(string new_value)
      {
        flagHasMessageID = true;
        storeMessageID = new_value;
      }
    public void unsetMessageID()
      {
        flagHasMessageID = false;
      }
    public void setMessageBody(string new_value)
      {
        flagHasMessageBody = true;
        storeMessageBody = new_value;
      }
    public void unsetMessageBody()
      {
        flagHasMessageBody = false;
      }
    public void setResponseCode(BigInteger new_value)
      {
        flagHasResponseCode = true;
        if (new_value < 0)
            throw new Exception("The value for field ResponseCode of HarmanControllerRequestInfoJSON is less than the lower bound (0) for that field.");
        storeResponseCode = new_value;
      }
    public void unsetResponseCode()
      {
        flagHasResponseCode = false;
      }
    public void setResponseBody(string new_value)
      {
        flagHasResponseBody = true;
        storeResponseBody = new_value;
      }
    public void unsetResponseBody()
      {
        flagHasResponseBody = false;
      }

    public virtual void extraHarmanControllerRequestInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHarmanControllerRequestInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHarmanControllerRequestInfoLookup(key);
        if (old_field == null)
          {
            extraHarmanControllerRequestInfoAppendPair(key, new_component);
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
        if (flagHasURL)
          {
            handler.start_pair("URL");
            handler.string_value(storeURL);
          }
        if (flagHasTimestamp)
          {
            handler.start_pair("Timestamp");
            handler.number_value(storeTimestamp);
          }
        if (flagHasMessageID)
          {
            handler.start_pair("MessageID");
            handler.string_value(storeMessageID);
          }
        if (flagHasMessageBody)
          {
            handler.start_pair("MessageBody");
            handler.string_value(storeMessageBody);
          }
        if (flagHasResponseCode)
          {
            handler.start_pair("ResponseCode");
            handler.number_value(storeResponseCode);
          }
        if (flagHasResponseBody)
          {
            handler.start_pair("ResponseBody");
            handler.string_value(storeResponseBody);
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

    public static HarmanControllerRequestInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanControllerRequestInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanControllerRequestInfo", ignore_extras);
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
    public static HarmanControllerRequestInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanControllerRequestInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanControllerRequestInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanControllerRequestInfo", ignore_extras);
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
    public static HarmanControllerRequestInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanControllerRequestInfoJSON from_text(string text, bool ignore_extras)
      {
        HarmanControllerRequestInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanControllerRequestInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HarmanControllerRequestInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HarmanControllerRequestInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HarmanControllerRequestInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanControllerRequestInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorURL;
    private class FieldHoldingGeneratorTimestamp : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTimestamp(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTimestamp : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTimestamp(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTimestamp fieldGeneratorTimestamp;
        private JSONHoldingStringGenerator fieldGeneratorMessageID;
        private JSONHoldingStringGenerator fieldGeneratorMessageBody;
    private class FieldHoldingGeneratorResponseCode : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorResponseCode(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorResponseCode : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorResponseCode(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorResponseCode fieldGeneratorResponseCode;
        private JSONHoldingStringGenerator fieldGeneratorResponseBody;
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
            HarmanControllerRequestInfoJSON result = new HarmanControllerRequestInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHarmanControllerRequestInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HarmanControllerRequestInfoJSON result)
          {
            if (fieldGeneratorURL.have_value)
              {
                result.setURL(fieldGeneratorURL.value);
                fieldGeneratorURL.have_value = false;
              }
            if (fieldGeneratorTimestamp.have_value)
              {
                result.setTimestamp(fieldGeneratorTimestamp.value);
                fieldGeneratorTimestamp.have_value = false;
              }
            if (fieldGeneratorMessageID.have_value)
              {
                result.setMessageID(fieldGeneratorMessageID.value);
                fieldGeneratorMessageID.have_value = false;
              }
            if (fieldGeneratorMessageBody.have_value)
              {
                result.setMessageBody(fieldGeneratorMessageBody.value);
                fieldGeneratorMessageBody.have_value = false;
              }
            if (fieldGeneratorResponseCode.have_value)
              {
                result.setResponseCode(fieldGeneratorResponseCode.value);
                fieldGeneratorResponseCode.have_value = false;
              }
            if (fieldGeneratorResponseBody.have_value)
              {
                result.setResponseBody(fieldGeneratorResponseBody.value);
                fieldGeneratorResponseBody.have_value = false;
              }
          }
        protected abstract void handle_result(HarmanControllerRequestInfoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'M':
                    if (String.Compare(field_name, 1, "essage", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'B':
                                if ((String.Compare(field_name, 8, "ody", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorMessageBody;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 8, "D", 0, 1, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorMessageID;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "esponse", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'B':
                                if ((String.Compare(field_name, 9, "ody", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorResponseBody;
                                break;
                            case 'C':
                                if ((String.Compare(field_name, 9, "ode", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorResponseCode;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "imestamp", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorTimestamp;
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
            fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the HarmanControllerRequestInfo class");
            fieldGeneratorTimestamp = new FieldHoldingGeneratorTimestamp("field \"Timestamp\" of the HarmanControllerRequestInfo class");
            fieldGeneratorMessageID = new JSONHoldingStringGenerator("field \"MessageID\" of the HarmanControllerRequestInfo class");
            fieldGeneratorMessageBody = new JSONHoldingStringGenerator("field \"MessageBody\" of the HarmanControllerRequestInfo class");
            fieldGeneratorResponseCode = new FieldHoldingGeneratorResponseCode("field \"ResponseCode\" of the HarmanControllerRequestInfo class");
            fieldGeneratorResponseBody = new JSONHoldingStringGenerator("field \"ResponseBody\" of the HarmanControllerRequestInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HarmanControllerRequestInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the HarmanControllerRequestInfo class");
            fieldGeneratorTimestamp = new FieldHoldingGeneratorTimestamp("field \"Timestamp\" of the HarmanControllerRequestInfo class");
            fieldGeneratorMessageID = new JSONHoldingStringGenerator("field \"MessageID\" of the HarmanControllerRequestInfo class");
            fieldGeneratorMessageBody = new JSONHoldingStringGenerator("field \"MessageBody\" of the HarmanControllerRequestInfo class");
            fieldGeneratorResponseCode = new FieldHoldingGeneratorResponseCode("field \"ResponseCode\" of the HarmanControllerRequestInfo class");
            fieldGeneratorResponseBody = new JSONHoldingStringGenerator("field \"ResponseBody\" of the HarmanControllerRequestInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HarmanControllerRequestInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorURL.reset();
            fieldGeneratorTimestamp.reset();
            fieldGeneratorMessageID.reset();
            fieldGeneratorMessageBody.reset();
            fieldGeneratorResponseCode.reset();
            fieldGeneratorResponseBody.reset();
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
        protected override void handle_result(HarmanControllerRequestInfoJSON  result)
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
        public HarmanControllerRequestInfoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HarmanControllerRequestInfoJSON  result)
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
    protected virtual void handle_result(List<HarmanControllerRequestInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HarmanControllerRequestInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HarmanControllerRequestInfoJSON>();
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
    public List<HarmanControllerRequestInfoJSON> value;
  };
  };
