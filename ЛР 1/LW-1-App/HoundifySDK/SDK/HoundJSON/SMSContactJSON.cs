/* file "SMSContactJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SMSContactJSON : ContactJSON
  {
    private bool flagHasLabeledPhoneNumbers;
    private List< LabeledPhoneNumberJSON  > storeLabeledPhoneNumbers;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraLabeledPhoneNumbersToJSON()
      {
        JSONArrayValue generated_array_1_LabeledPhoneNumbers = new JSONArrayValue();
        for (int num1 = 0; num1 < storeLabeledPhoneNumbers.Count; ++num1)
          {
            JSONValueHandler handler_LabeledPhoneNumbers = new JSONValueHandler();
            storeLabeledPhoneNumbers[num1].write_as_json(handler_LabeledPhoneNumbers);
            generated_array_1_LabeledPhoneNumbers.appendComponent(handler_LabeledPhoneNumbers.result);
          }
        return generated_array_1_LabeledPhoneNumbers;
      }


    private void  fromJSONLabeledPhoneNumbers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field LabeledPhoneNumbers of SMSContactJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< LabeledPhoneNumberJSON  > vector_LabeledPhoneNumbers1 = new List< LabeledPhoneNumberJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            LabeledPhoneNumberJSON convert_classy = LabeledPhoneNumberJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_LabeledPhoneNumbers1.Add(convert_classy);
          }
        initLabeledPhoneNumbers();
        for (int num1 = 0; num1 < vector_LabeledPhoneNumbers1.Count; ++num1)
            appendLabeledPhoneNumbers(vector_LabeledPhoneNumbers1[num1]);
        for (int num1 = 0; num1 < vector_LabeledPhoneNumbers1.Count; ++num1)
          {
          }
      }


    public SMSContactJSON()
      {
        flagHasLabeledPhoneNumbers = false;
        storeLabeledPhoneNumbers = new List< LabeledPhoneNumberJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasLabeledPhoneNumbers()
      {
        return flagHasLabeledPhoneNumbers;
      }

    public int  countOfLabeledPhoneNumbers()
      {
        Debug.Assert(flagHasLabeledPhoneNumbers);
        return storeLabeledPhoneNumbers.Count;
      }

    public LabeledPhoneNumberJSON   elementOfLabeledPhoneNumbers(int element_num)
      {
        Debug.Assert(flagHasLabeledPhoneNumbers);
        return storeLabeledPhoneNumbers[element_num];
      }

    public List< LabeledPhoneNumberJSON  >  getLabeledPhoneNumbers()
      {
        Debug.Assert(flagHasLabeledPhoneNumbers);
        return storeLabeledPhoneNumbers;
      }


    public virtual int extraSMSContactComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSMSContactComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSMSContactComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSMSContactLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraContactComponentCount()
      {
        int result = 0;
        if (flagHasLabeledPhoneNumbers)
            ++result;
        result += extraSMSContactComponentCount();
        return result;
      }
    public override string extraContactComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasLabeledPhoneNumbers)
          {
            if (remainder == 0)
                return "LabeledPhoneNumbers";
            --remainder;
          }
        return extraSMSContactComponentKey(remainder);
      }
    public override JSONValue extraContactComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasLabeledPhoneNumbers)
          {
            if (remainder == 0)
                return extraLabeledPhoneNumbersToJSON();
            --remainder;
          }
        return extraSMSContactComponentValue(remainder);
      }
    public override JSONValue extraContactLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "LabeledPhoneNumbers", 0, 19, false) == 0) && (field_name.Length == 19))
            return (flagHasLabeledPhoneNumbers ? extraLabeledPhoneNumbersToJSON() : null);
        return extraSMSContactLookup(field_name);
      }

    public void initLabeledPhoneNumbers()
      {
        if (flagHasLabeledPhoneNumbers)
          {
            for (int num1 = 0; num1 < storeLabeledPhoneNumbers.Count; ++num1)
              {
              }
          }
        flagHasLabeledPhoneNumbers = true;
        storeLabeledPhoneNumbers.Clear();
      }
    public void appendLabeledPhoneNumbers(LabeledPhoneNumberJSON  to_append)
      {
        if (!flagHasLabeledPhoneNumbers)
          {
            flagHasLabeledPhoneNumbers = true;
            storeLabeledPhoneNumbers.Clear();
          }
        Debug.Assert(flagHasLabeledPhoneNumbers);
        storeLabeledPhoneNumbers.Add(to_append);
      }
    public void unsetLabeledPhoneNumbers()
      {
        if (flagHasLabeledPhoneNumbers)
          {
            for (int num2 = 0; num2 < storeLabeledPhoneNumbers.Count; ++num2)
              {
              }
          }
        flagHasLabeledPhoneNumbers = false;
        storeLabeledPhoneNumbers.Clear();
      }

    public virtual void extraSMSContactAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSMSContactSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSMSContactLookup(key);
        if (old_field == null)
          {
            extraSMSContactAppendPair(key, new_component);
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
    public override void extraContactAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "LabeledPhoneNumbers", 0, 19, false) == 0) && (key.Length == 19))
            {
            fromJSONLabeledPhoneNumbers(new_component, false);
            return;
            }
        extraSMSContactAppendPair(key, new_component);
      }
    public override void extraContactSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "LabeledPhoneNumbers", 0, 19, false) == 0) && (key.Length == 19))
            {
            fromJSONLabeledPhoneNumbers(new_component, false);
            return;
            }
        extraSMSContactSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        if (flagHasLabeledPhoneNumbers)
          {
            handler.start_pair("LabeledPhoneNumbers");
            handler.start_array();
            for (int num1 = 0; num1 < storeLabeledPhoneNumbers.Count; ++num1)
              {
                if (partial_allowed)
                    storeLabeledPhoneNumbers[num1].write_partial_as_json(handler);
                else
                    storeLabeledPhoneNumbers[num1].write_as_json(handler);
              }
            handler.finish_array();
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
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new SMSContactJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSContactJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSContact", ignore_extras);
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
    public static new SMSContactJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SMSContactJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSContactJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSContact", ignore_extras);
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
    public static new SMSContactJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SMSContactJSON from_text(string text, bool ignore_extras)
      {
        SMSContactJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSContact", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SMSContactJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SMSContactJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SMSContactJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSContact", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ContactJSON.Generator
      {
        private LabeledPhoneNumberJSON.HoldingArrayGenerator fieldGeneratorLabeledPhoneNumbers;
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
            SMSContactJSON result = new SMSContactJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSMSContactAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ContactJSON new_result)
          {
            handle_result((SMSContactJSON )new_result);
          }
        protected void finish(SMSContactJSON result)
          {
            if (fieldGeneratorLabeledPhoneNumbers.have_value)
              {
                result.initLabeledPhoneNumbers();
                int count = fieldGeneratorLabeledPhoneNumbers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendLabeledPhoneNumbers(fieldGeneratorLabeledPhoneNumbers.value[num]);
                  }
                fieldGeneratorLabeledPhoneNumbers.value.Clear();
                fieldGeneratorLabeledPhoneNumbers.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SMSContactJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "LabeledPhoneNumbers", 0, 19, false) == 0) && (field_name.Length == 19))
                return fieldGeneratorLabeledPhoneNumbers;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorLabeledPhoneNumbers = new LabeledPhoneNumberJSON.HoldingArrayGenerator("field \"LabeledPhoneNumbers\" of the SMSContact class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SMSContact class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorLabeledPhoneNumbers = new LabeledPhoneNumberJSON.HoldingArrayGenerator("field \"LabeledPhoneNumbers\" of the SMSContact class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SMSContact class");
          }

        public override void reset()
          {
            fieldGeneratorLabeledPhoneNumbers.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SMSContactJSON  result)
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
        public SMSContactJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SMSContactJSON  result)
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
    protected virtual void handle_result(List<SMSContactJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SMSContactJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SMSContactJSON>();
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
    public List<SMSContactJSON> value;
  };
    public static SMSContactJSON from_ContactJSON_json(ContactJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        SMSContactJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type SMSContact", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
