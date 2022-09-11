/* file "MonetaryAmountJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MonetaryAmountJSON : AmountJSON
  {
    private bool flagHasCurrencyCode;
    private string storeCurrencyCode;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCurrencyCodeToJSON()
      {
        JSONStringValue generated_string_CurrencyCode = new JSONStringValue(storeCurrencyCode);
        return generated_string_CurrencyCode;
      }


    private void  fromJSONCurrencyCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CurrencyCode of MonetaryAmountJSON is not a string.");
        setCurrencyCode(json_string.getData());
      }


    public MonetaryAmountJSON()
      {
        flagHasCurrencyCode = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCurrencyCode()
      {
        return flagHasCurrencyCode;
      }

    public string  getCurrencyCode()
      {
        Debug.Assert(flagHasCurrencyCode);
        return storeCurrencyCode;
      }


    public virtual int extraMonetaryAmountComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMonetaryAmountComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMonetaryAmountComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMonetaryAmountLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraAmountComponentCount()
      {
        int result = 0;
        if (flagHasCurrencyCode)
            ++result;
        result += extraMonetaryAmountComponentCount();
        return result;
      }
    public override string extraAmountComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCurrencyCode)
          {
            if (remainder == 0)
                return "CurrencyCode";
            --remainder;
          }
        return extraMonetaryAmountComponentKey(remainder);
      }
    public override JSONValue extraAmountComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCurrencyCode)
          {
            if (remainder == 0)
                return extraCurrencyCodeToJSON();
            --remainder;
          }
        return extraMonetaryAmountComponentValue(remainder);
      }
    public override JSONValue extraAmountLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "CurrencyCode", 0, 12, false) == 0) && (field_name.Length == 12))
            return (flagHasCurrencyCode ? extraCurrencyCodeToJSON() : null);
        return extraMonetaryAmountLookup(field_name);
      }

    public void setCurrencyCode(string new_value)
      {
        flagHasCurrencyCode = true;
        storeCurrencyCode = new_value;
      }
    public void unsetCurrencyCode()
      {
        flagHasCurrencyCode = false;
      }

    public virtual void extraMonetaryAmountAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMonetaryAmountSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMonetaryAmountLookup(key);
        if (old_field == null)
          {
            extraMonetaryAmountAppendPair(key, new_component);
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
    public override void extraAmountAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "CurrencyCode", 0, 12, false) == 0) && (key.Length == 12))
            {
            fromJSONCurrencyCode(new_component, false);
            return;
            }
        extraMonetaryAmountAppendPair(key, new_component);
      }
    public override void extraAmountSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "CurrencyCode", 0, 12, false) == 0) && (key.Length == 12))
            {
            fromJSONCurrencyCode(new_component, false);
            return;
            }
        extraMonetaryAmountSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCurrencyCode);
        if (flagHasCurrencyCode)
          {
            handler.start_pair("CurrencyCode");
            handler.string_value(storeCurrencyCode);
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
        if (!(hasCurrencyCode()))
          {
            return "When parsing the object for %what%, the \"CurrencyCode\" field was missing.";
          }
        return null;
      }

    public static new MonetaryAmountJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MonetaryAmountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonetaryAmount", ignore_extras);
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
    public static new MonetaryAmountJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MonetaryAmountJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MonetaryAmountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonetaryAmount", ignore_extras);
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
    public static new MonetaryAmountJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MonetaryAmountJSON from_text(string text, bool ignore_extras)
      {
        MonetaryAmountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonetaryAmount", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MonetaryAmountJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MonetaryAmountJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MonetaryAmountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonetaryAmount", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : AmountJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorCurrencyCode;
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
            MonetaryAmountJSON result = new MonetaryAmountJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMonetaryAmountAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(AmountJSON new_result)
          {
            handle_result((MonetaryAmountJSON )new_result);
          }
        protected void finish(MonetaryAmountJSON result)
          {
            if (fieldGeneratorCurrencyCode.have_value)
              {
                result.setCurrencyCode(fieldGeneratorCurrencyCode.value);
                fieldGeneratorCurrencyCode.have_value = false;
              }
            else if ((!(result.hasCurrencyCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CurrencyCode\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MonetaryAmountJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "CurrencyCode", 0, 12, false) == 0) && (field_name.Length == 12))
                return fieldGeneratorCurrencyCode;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCurrencyCode = new JSONHoldingStringGenerator("field \"CurrencyCode\" of the MonetaryAmount class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MonetaryAmount class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCurrencyCode = new JSONHoldingStringGenerator("field \"CurrencyCode\" of the MonetaryAmount class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MonetaryAmount class");
          }

        public override void reset()
          {
            fieldGeneratorCurrencyCode.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MonetaryAmountJSON  result)
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
        public MonetaryAmountJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MonetaryAmountJSON  result)
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
    protected virtual void handle_result(List<MonetaryAmountJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MonetaryAmountJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MonetaryAmountJSON>();
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
    public List<MonetaryAmountJSON> value;
  };
    public static MonetaryAmountJSON from_AmountJSON_json(AmountJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        MonetaryAmountJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type MonetaryAmount", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
