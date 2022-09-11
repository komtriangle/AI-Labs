/* file "HumaxHomeAutomationCredentialsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HumaxHomeAutomationCredentialsJSON : JSONBase
  {
    private bool flagHasaccess_token;
    private string storeaccess_token;
    private bool flagHastoken_type;
    private string storetoken_type;
    private bool flagHasrefresh_token;
    private string storerefresh_token;
    private bool flagHasexpires_in;
    private BigInteger storeexpires_in;
    private bool flagHasscope;
    private string storescope;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONaccess_token(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field access_token of HumaxHomeAutomationCredentialsJSON is not a string.");
        setaccess_token(json_string.getData());
      }


    private void  fromJSONtoken_type(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field token_type of HumaxHomeAutomationCredentialsJSON is not a string.");
        settoken_type(json_string.getData());
      }


    private void  fromJSONrefresh_token(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field refresh_token of HumaxHomeAutomationCredentialsJSON is not a string.");
        setrefresh_token(json_string.getData());
      }


    private void  fromJSONexpires_in(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field expires_in of HumaxHomeAutomationCredentialsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field expires_in of HumaxHomeAutomationCredentialsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setexpires_in(extracted_integer);
      }


    private void  fromJSONscope(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field scope of HumaxHomeAutomationCredentialsJSON is not a string.");
        setscope(json_string.getData());
      }


    public HumaxHomeAutomationCredentialsJSON()
      {
        flagHasaccess_token = false;
        flagHastoken_type = false;
        flagHasrefresh_token = false;
        flagHasexpires_in = false;
        flagHasscope = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasaccess_token()
      {
        return flagHasaccess_token;
      }

    public string  getaccess_token()
      {
        Debug.Assert(flagHasaccess_token);
        return storeaccess_token;
      }

    public bool  hastoken_type()
      {
        return flagHastoken_type;
      }

    public string  gettoken_type()
      {
        Debug.Assert(flagHastoken_type);
        return storetoken_type;
      }

    public bool  hasrefresh_token()
      {
        return flagHasrefresh_token;
      }

    public string  getrefresh_token()
      {
        Debug.Assert(flagHasrefresh_token);
        return storerefresh_token;
      }

    public bool  hasexpires_in()
      {
        return flagHasexpires_in;
      }

    public BigInteger  getexpires_in()
      {
        Debug.Assert(flagHasexpires_in);
        return storeexpires_in;
      }

    public bool  hasscope()
      {
        return flagHasscope;
      }

    public string  getscope()
      {
        Debug.Assert(flagHasscope);
        return storescope;
      }


    public virtual int extraHumaxHomeAutomationCredentialsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHumaxHomeAutomationCredentialsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHumaxHomeAutomationCredentialsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHumaxHomeAutomationCredentialsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setaccess_token(string new_value)
      {
        flagHasaccess_token = true;
        storeaccess_token = new_value;
      }
    public void unsetaccess_token()
      {
        flagHasaccess_token = false;
      }
    public void settoken_type(string new_value)
      {
        flagHastoken_type = true;
        storetoken_type = new_value;
      }
    public void unsettoken_type()
      {
        flagHastoken_type = false;
      }
    public void setrefresh_token(string new_value)
      {
        flagHasrefresh_token = true;
        storerefresh_token = new_value;
      }
    public void unsetrefresh_token()
      {
        flagHasrefresh_token = false;
      }
    public void setexpires_in(BigInteger new_value)
      {
        flagHasexpires_in = true;
        storeexpires_in = new_value;
      }
    public void unsetexpires_in()
      {
        flagHasexpires_in = false;
      }
    public void setscope(string new_value)
      {
        flagHasscope = true;
        storescope = new_value;
      }
    public void unsetscope()
      {
        flagHasscope = false;
      }

    public virtual void extraHumaxHomeAutomationCredentialsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHumaxHomeAutomationCredentialsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHumaxHomeAutomationCredentialsLookup(key);
        if (old_field == null)
          {
            extraHumaxHomeAutomationCredentialsAppendPair(key, new_component);
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
        if (flagHasaccess_token)
          {
            handler.start_pair("access_token");
            handler.string_value(storeaccess_token);
          }
        if (flagHastoken_type)
          {
            handler.start_pair("token_type");
            handler.string_value(storetoken_type);
          }
        if (flagHasrefresh_token)
          {
            handler.start_pair("refresh_token");
            handler.string_value(storerefresh_token);
          }
        if (flagHasexpires_in)
          {
            handler.start_pair("expires_in");
            handler.number_value(storeexpires_in);
          }
        if (flagHasscope)
          {
            handler.start_pair("scope");
            handler.string_value(storescope);
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

    public static HumaxHomeAutomationCredentialsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HumaxHomeAutomationCredentialsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HumaxHomeAutomationCredentials", ignore_extras);
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
    public static HumaxHomeAutomationCredentialsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HumaxHomeAutomationCredentialsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HumaxHomeAutomationCredentialsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HumaxHomeAutomationCredentials", ignore_extras);
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
    public static HumaxHomeAutomationCredentialsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HumaxHomeAutomationCredentialsJSON from_text(string text, bool ignore_extras)
      {
        HumaxHomeAutomationCredentialsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HumaxHomeAutomationCredentials", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HumaxHomeAutomationCredentialsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HumaxHomeAutomationCredentialsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HumaxHomeAutomationCredentialsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HumaxHomeAutomationCredentials", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratoraccess_token;
        private JSONHoldingStringGenerator fieldGeneratortoken_type;
        private JSONHoldingStringGenerator fieldGeneratorrefresh_token;
    private class FieldHoldingGeneratorexpires_in : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorexpires_in(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorexpires_in : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorexpires_in(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorexpires_in fieldGeneratorexpires_in;
        private JSONHoldingStringGenerator fieldGeneratorscope;
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
            HumaxHomeAutomationCredentialsJSON result = new HumaxHomeAutomationCredentialsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHumaxHomeAutomationCredentialsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HumaxHomeAutomationCredentialsJSON result)
          {
            if (fieldGeneratoraccess_token.have_value)
              {
                result.setaccess_token(fieldGeneratoraccess_token.value);
                fieldGeneratoraccess_token.have_value = false;
              }
            if (fieldGeneratortoken_type.have_value)
              {
                result.settoken_type(fieldGeneratortoken_type.value);
                fieldGeneratortoken_type.have_value = false;
              }
            if (fieldGeneratorrefresh_token.have_value)
              {
                result.setrefresh_token(fieldGeneratorrefresh_token.value);
                fieldGeneratorrefresh_token.have_value = false;
              }
            if (fieldGeneratorexpires_in.have_value)
              {
                result.setexpires_in(fieldGeneratorexpires_in.value);
                fieldGeneratorexpires_in.have_value = false;
              }
            if (fieldGeneratorscope.have_value)
              {
                result.setscope(fieldGeneratorscope.value);
                fieldGeneratorscope.have_value = false;
              }
          }
        protected abstract void handle_result(HumaxHomeAutomationCredentialsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    if ((String.Compare(field_name, 1, "ccess_token", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratoraccess_token;
                    break;
                case 'e':
                    if ((String.Compare(field_name, 1, "xpires_in", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorexpires_in;
                    break;
                case 'r':
                    if ((String.Compare(field_name, 1, "efresh_token", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorrefresh_token;
                    break;
                case 's':
                    if ((String.Compare(field_name, 1, "cope", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorscope;
                    break;
                case 't':
                    if ((String.Compare(field_name, 1, "oken_type", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratortoken_type;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratoraccess_token = new JSONHoldingStringGenerator("field \"access_token\" of the HumaxHomeAutomationCredentials class");
            fieldGeneratortoken_type = new JSONHoldingStringGenerator("field \"token_type\" of the HumaxHomeAutomationCredentials class");
            fieldGeneratorrefresh_token = new JSONHoldingStringGenerator("field \"refresh_token\" of the HumaxHomeAutomationCredentials class");
            fieldGeneratorexpires_in = new FieldHoldingGeneratorexpires_in("field \"expires_in\" of the HumaxHomeAutomationCredentials class");
            fieldGeneratorscope = new JSONHoldingStringGenerator("field \"scope\" of the HumaxHomeAutomationCredentials class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HumaxHomeAutomationCredentials class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratoraccess_token = new JSONHoldingStringGenerator("field \"access_token\" of the HumaxHomeAutomationCredentials class");
            fieldGeneratortoken_type = new JSONHoldingStringGenerator("field \"token_type\" of the HumaxHomeAutomationCredentials class");
            fieldGeneratorrefresh_token = new JSONHoldingStringGenerator("field \"refresh_token\" of the HumaxHomeAutomationCredentials class");
            fieldGeneratorexpires_in = new FieldHoldingGeneratorexpires_in("field \"expires_in\" of the HumaxHomeAutomationCredentials class");
            fieldGeneratorscope = new JSONHoldingStringGenerator("field \"scope\" of the HumaxHomeAutomationCredentials class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HumaxHomeAutomationCredentials class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratoraccess_token.reset();
            fieldGeneratortoken_type.reset();
            fieldGeneratorrefresh_token.reset();
            fieldGeneratorexpires_in.reset();
            fieldGeneratorscope.reset();
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
        protected override void handle_result(HumaxHomeAutomationCredentialsJSON  result)
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
        public HumaxHomeAutomationCredentialsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HumaxHomeAutomationCredentialsJSON  result)
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
    protected virtual void handle_result(List<HumaxHomeAutomationCredentialsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HumaxHomeAutomationCredentialsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HumaxHomeAutomationCredentialsJSON>();
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
    public List<HumaxHomeAutomationCredentialsJSON> value;
  };
  };
