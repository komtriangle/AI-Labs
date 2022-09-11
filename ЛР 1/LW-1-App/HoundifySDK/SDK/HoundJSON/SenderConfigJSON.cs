/* file "SenderConfigJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public abstract class SenderConfigJSON : JSONBase
  {
    private bool flagHasPrintResponses;
    private bool storePrintResponses;
    private bool flagHasHTTPTimeout;
    private double storeHTTPTimeout;
    private string textStoreHTTPTimeout;
    private bool flagHasFlags;
    private BigInteger storeFlags;


    private void  fromJSONPrintResponses(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PrintResponses of SenderConfigJSON is not true for false.");
              }
          }
        setPrintResponses(the_bool);
      }


    private void  fromJSONHTTPTimeout(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field HTTPTimeout of SenderConfigJSON is not a number.");
              }
          }
        setHTTPTimeoutText(the_rational_text);
      }


    private void  fromJSONFlags(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Flags of SenderConfigJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Flags of SenderConfigJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFlags(extracted_integer);
      }


    public SenderConfigJSON()
      {
        flagHasPrintResponses = false;
        flagHasHTTPTimeout = false;
        flagHasFlags = false;
        storePrintResponses = false;
        storeHTTPTimeout = 30;
      }

    public abstract string getCommandSenderKind();
    public bool  hasPrintResponses()
      {
        return flagHasPrintResponses;
      }

    public bool  getPrintResponses()
      {
        return storePrintResponses;
      }

    public bool  hasHTTPTimeout()
      {
        return flagHasHTTPTimeout;
      }

    public double  getHTTPTimeout()
      {
        if (textStoreHTTPTimeout != "")
          {
            return Double.Parse(textStoreHTTPTimeout);
          }
        return storeHTTPTimeout;
      }

    public string  getHTTPTimeoutAsText()
      {
        if (textStoreHTTPTimeout == "")
          {
            return Convert.ToString(storeHTTPTimeout);
          }
        else
          {
            return (textStoreHTTPTimeout);
          }
      }

    public bool  hasFlags()
      {
        return flagHasFlags;
      }

    public BigInteger  getFlags()
      {
        Debug.Assert(flagHasFlags);
        return storeFlags;
      }


    public abstract int extraSenderConfigComponentCount();
    public abstract string extraSenderConfigComponentKey(int component_num);
    public abstract JSONValue extraSenderConfigComponentValue(int component_num);
    public abstract JSONValue extraSenderConfigLookup(string field_name);

    public void setPrintResponses(bool new_value)
      {
        flagHasPrintResponses = true;
        storePrintResponses = new_value;
      }
    public void unsetPrintResponses()
      {
        flagHasPrintResponses = false;
      }
    public void setHTTPTimeout(double new_value)
      {
        flagHasHTTPTimeout = true;
        if (new_value < 0.5)
            throw new Exception("The value for field HTTPTimeout of SenderConfigJSON is less than the lower bound (0.5) for that field.");
        if (new_value > 60)
            throw new Exception("The value for field HTTPTimeout of SenderConfigJSON is greater than the upper bound (60) for that field.");
        storeHTTPTimeout = new_value;
        textStoreHTTPTimeout = "";
      }
    public void setHTTPTimeoutText(string new_value)
      {
        flagHasHTTPTimeout = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HTTPTimeout of SenderConfigJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "5", "", false, "0") < 0)
            throw new Exception("The value for field HTTPTimeout of SenderConfigJSON is less than the lower bound (0.5) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "60", "", false, "2") > 0)
            throw new Exception("The value for field HTTPTimeout of SenderConfigJSON is greater than the upper bound (60) for that field.");
        textStoreHTTPTimeout = new_value;
      }
    public void unsetHTTPTimeout()
      {
        flagHasHTTPTimeout = false;
      }
    public void setFlags(BigInteger new_value)
      {
        flagHasFlags = true;
        if (new_value < 0)
            throw new Exception("The value for field Flags of SenderConfigJSON is less than the lower bound (0) for that field.");
        storeFlags = new_value;
      }
    public void unsetFlags()
      {
        flagHasFlags = false;
      }

    public abstract void extraSenderConfigAppendPair(string key, JSONValue new_component);
    public abstract void extraSenderConfigSetField(string key, JSONValue new_component);

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        handler.pair("CommandSenderKind", getCommandSenderKind());
        if (flagHasPrintResponses)
          {
            handler.start_pair("PrintResponses");
            handler.boolean_value(storePrintResponses);
          }
        if (flagHasHTTPTimeout)
          {
            handler.start_pair("HTTPTimeout");
            if (textStoreHTTPTimeout != "")
                handler.number_value(textStoreHTTPTimeout);
            else if (((double)(long)storeHTTPTimeout) == storeHTTPTimeout)
                handler.number_value((long)storeHTTPTimeout);
            else
                handler.number_value(storeHTTPTimeout);
          }
        if (flagHasFlags)
          {
            handler.start_pair("Flags");
            handler.number_value(storeFlags);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static SenderConfigJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SenderConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SenderConfig", ignore_extras);
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
    public static SenderConfigJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SenderConfigJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SenderConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SenderConfig", ignore_extras);
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
    public static SenderConfigJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SenderConfigJSON from_text(string text, bool ignore_extras)
      {
        SenderConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SenderConfig", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SenderConfigJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SenderConfigJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SenderConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SenderConfig", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorPrintResponses;
        private JSONHoldingNumberTextGenerator fieldGeneratorHTTPTimeout;
    private class FieldHoldingGeneratorFlags : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorFlags(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorFlags : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorFlags(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorFlags fieldGeneratorFlags;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `CommandSenderKind' field is missing.");
            SenderConfigJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSenderConfigAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getSenderConfigJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `CommandSenderKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(SenderConfigJSON result)
          {
            if (fieldGeneratorPrintResponses.have_value)
              {
                result.setPrintResponses(fieldGeneratorPrintResponses.value);
                fieldGeneratorPrintResponses.have_value = false;
              }
            if (fieldGeneratorHTTPTimeout.have_value)
              {
                result.setHTTPTimeoutText(fieldGeneratorHTTPTimeout.value);
                fieldGeneratorHTTPTimeout.have_value = false;
              }
            if (fieldGeneratorFlags.have_value)
              {
                result.setFlags(fieldGeneratorFlags.value);
                fieldGeneratorFlags.have_value = false;
              }
          }
        protected abstract void handle_result(SenderConfigJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ommandSenderKind", 0, 16, false) == 0) && (field_name.Length == 17))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "lags", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorFlags;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "TTPTimeout", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorHTTPTimeout;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "rintResponses", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorPrintResponses;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPrintResponses = new JSONHoldingBooleanGenerator("field \"PrintResponses\" of the SenderConfig class");
            fieldGeneratorHTTPTimeout = new JSONHoldingNumberTextGenerator("field \"HTTPTimeout\" of the SenderConfig class");
            fieldGeneratorFlags = new FieldHoldingGeneratorFlags("field \"Flags\" of the SenderConfig class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"CommandSenderKind\" of the SenderConfig class");
            set_what("the SenderConfig class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPrintResponses = new JSONHoldingBooleanGenerator("field \"PrintResponses\" of the SenderConfig class");
            fieldGeneratorHTTPTimeout = new JSONHoldingNumberTextGenerator("field \"HTTPTimeout\" of the SenderConfig class");
            fieldGeneratorFlags = new FieldHoldingGeneratorFlags("field \"Flags\" of the SenderConfig class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"CommandSenderKind\" of the SenderConfig class");
            set_what("the SenderConfig class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPrintResponses.reset();
            fieldGeneratorHTTPTimeout.reset();
            fieldGeneratorFlags.reset();
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
        protected override void handle_result(SenderConfigJSON  result)
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
        public SenderConfigJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SenderConfigJSON  result)
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
    protected virtual void handle_result(List<SenderConfigJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SenderConfigJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SenderConfigJSON>();
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
    public List<SenderConfigJSON> value;
  };
    class GenericSenderConfigJSON : SenderConfigJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericSenderConfigJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getCommandSenderKind()  { return key; }
        public override int extraSenderConfigComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraSenderConfigComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraSenderConfigComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraSenderConfigLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraSenderConfigAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraSenderConfigSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraSenderConfigLookup(key);
            if (old_field == null)
              {
                extraSenderConfigAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static SenderConfigJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {

        return new GenericSenderConfigJSON(key);
      }
  };
