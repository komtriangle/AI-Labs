/* file "TimeDifferenceJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class TimeDifferenceJSON : JSONBase
  {
    private bool flagHasAmount;
    private BigInteger storeAmount;
    private bool flagHasText;
    private string storeText;
    private bool flagHasSpokenText;
    private string storeSpokenText;
    private bool flagHasShortText;
    private string storeShortText;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONAmount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Amount of TimeDifferenceJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Amount of TimeDifferenceJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAmount(extracted_integer);
      }


    private void  fromJSONText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Text of TimeDifferenceJSON is not a string.");
        setText(json_string.getData());
      }


    private void  fromJSONSpokenText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenText of TimeDifferenceJSON is not a string.");
        setSpokenText(json_string.getData());
      }


    private void  fromJSONShortText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ShortText of TimeDifferenceJSON is not a string.");
        setShortText(json_string.getData());
      }


    public TimeDifferenceJSON()
      {
        flagHasAmount = false;
        flagHasText = false;
        flagHasSpokenText = false;
        flagHasShortText = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasAmount()
      {
        return flagHasAmount;
      }

    public BigInteger  getAmount()
      {
        Debug.Assert(flagHasAmount);
        return storeAmount;
      }

    public bool  hasText()
      {
        return flagHasText;
      }

    public string  getText()
      {
        Debug.Assert(flagHasText);
        return storeText;
      }

    public bool  hasSpokenText()
      {
        return flagHasSpokenText;
      }

    public string  getSpokenText()
      {
        Debug.Assert(flagHasSpokenText);
        return storeSpokenText;
      }

    public bool  hasShortText()
      {
        return flagHasShortText;
      }

    public string  getShortText()
      {
        Debug.Assert(flagHasShortText);
        return storeShortText;
      }


    public virtual int extraTimeDifferenceComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimeDifferenceComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimeDifferenceComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimeDifferenceLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setAmount(BigInteger new_value)
      {
        flagHasAmount = true;
        storeAmount = new_value;
      }
    public void unsetAmount()
      {
        flagHasAmount = false;
      }
    public void setText(string new_value)
      {
        flagHasText = true;
        storeText = new_value;
      }
    public void unsetText()
      {
        flagHasText = false;
      }
    public void setSpokenText(string new_value)
      {
        flagHasSpokenText = true;
        storeSpokenText = new_value;
      }
    public void unsetSpokenText()
      {
        flagHasSpokenText = false;
      }
    public void setShortText(string new_value)
      {
        flagHasShortText = true;
        storeShortText = new_value;
      }
    public void unsetShortText()
      {
        flagHasShortText = false;
      }

    public virtual void extraTimeDifferenceAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimeDifferenceSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimeDifferenceLookup(key);
        if (old_field == null)
          {
            extraTimeDifferenceAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAmount);
        if (flagHasAmount)
          {
            handler.start_pair("Amount");
            handler.number_value(storeAmount);
          }
        Debug.Assert(partial_allowed || flagHasText);
        if (flagHasText)
          {
            handler.start_pair("Text");
            handler.string_value(storeText);
          }
        Debug.Assert(partial_allowed || flagHasSpokenText);
        if (flagHasSpokenText)
          {
            handler.start_pair("SpokenText");
            handler.string_value(storeSpokenText);
          }
        Debug.Assert(partial_allowed || flagHasShortText);
        if (flagHasShortText)
          {
            handler.start_pair("ShortText");
            handler.string_value(storeShortText);
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
        if (!(hasAmount()))
          {
            return "When parsing the object for %what%, the \"Amount\" field was missing.";
          }
        if (!(hasText()))
          {
            return "When parsing the object for %what%, the \"Text\" field was missing.";
          }
        if (!(hasSpokenText()))
          {
            return "When parsing the object for %what%, the \"SpokenText\" field was missing.";
          }
        if (!(hasShortText()))
          {
            return "When parsing the object for %what%, the \"ShortText\" field was missing.";
          }
        return null;
      }

    public static TimeDifferenceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeDifferenceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeDifference", ignore_extras);
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
    public static TimeDifferenceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TimeDifferenceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeDifferenceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeDifference", ignore_extras);
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
    public static TimeDifferenceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TimeDifferenceJSON from_text(string text, bool ignore_extras)
      {
        TimeDifferenceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeDifference", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimeDifferenceJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TimeDifferenceJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimeDifferenceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeDifference", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorAmount : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorAmount(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorAmount : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorAmount(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorAmount fieldGeneratorAmount;
        private JSONHoldingStringGenerator fieldGeneratorText;
        private JSONHoldingStringGenerator fieldGeneratorSpokenText;
        private JSONHoldingStringGenerator fieldGeneratorShortText;
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
            TimeDifferenceJSON result = new TimeDifferenceJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimeDifferenceAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TimeDifferenceJSON result)
          {
            if (fieldGeneratorAmount.have_value)
              {
                result.setAmount(fieldGeneratorAmount.value);
                fieldGeneratorAmount.have_value = false;
              }
            else if ((!(result.hasAmount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Amount\" field was missing.");
              }
            if (fieldGeneratorText.have_value)
              {
                result.setText(fieldGeneratorText.value);
                fieldGeneratorText.have_value = false;
              }
            else if ((!(result.hasText())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Text\" field was missing.");
              }
            if (fieldGeneratorSpokenText.have_value)
              {
                result.setSpokenText(fieldGeneratorSpokenText.value);
                fieldGeneratorSpokenText.have_value = false;
              }
            else if ((!(result.hasSpokenText())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenText\" field was missing.");
              }
            if (fieldGeneratorShortText.have_value)
              {
                result.setShortText(fieldGeneratorShortText.value);
                fieldGeneratorShortText.have_value = false;
              }
            else if ((!(result.hasShortText())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ShortText\" field was missing.");
              }
          }
        protected abstract void handle_result(TimeDifferenceJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "mount", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorAmount;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "ortText", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorShortText;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenText", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorSpokenText;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ext", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorText;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAmount = new FieldHoldingGeneratorAmount("field \"Amount\" of the TimeDifference class");
            fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TimeDifference class");
            fieldGeneratorSpokenText = new JSONHoldingStringGenerator("field \"SpokenText\" of the TimeDifference class");
            fieldGeneratorShortText = new JSONHoldingStringGenerator("field \"ShortText\" of the TimeDifference class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimeDifference class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAmount = new FieldHoldingGeneratorAmount("field \"Amount\" of the TimeDifference class");
            fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TimeDifference class");
            fieldGeneratorSpokenText = new JSONHoldingStringGenerator("field \"SpokenText\" of the TimeDifference class");
            fieldGeneratorShortText = new JSONHoldingStringGenerator("field \"ShortText\" of the TimeDifference class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimeDifference class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorAmount.reset();
            fieldGeneratorText.reset();
            fieldGeneratorSpokenText.reset();
            fieldGeneratorShortText.reset();
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
        protected override void handle_result(TimeDifferenceJSON  result)
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
        public TimeDifferenceJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimeDifferenceJSON  result)
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
    protected virtual void handle_result(List<TimeDifferenceJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimeDifferenceJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimeDifferenceJSON>();
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
    public List<TimeDifferenceJSON> value;
  };
  };
