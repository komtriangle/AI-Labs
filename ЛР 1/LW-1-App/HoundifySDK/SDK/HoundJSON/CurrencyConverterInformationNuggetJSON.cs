/* file "CurrencyConverterInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CurrencyConverterInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasConversions;
    private List< CurrencyConversionJSON  > storeConversions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraConversionsToJSON()
      {
        JSONArrayValue generated_array_1_Conversions = new JSONArrayValue();
        for (int num1 = 0; num1 < storeConversions.Count; ++num1)
          {
            JSONValueHandler handler_Conversions = new JSONValueHandler();
            storeConversions[num1].write_as_json(handler_Conversions);
            generated_array_1_Conversions.appendComponent(handler_Conversions.result);
          }
        return generated_array_1_Conversions;
      }


    private void  fromJSONConversions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Conversions of CurrencyConverterInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< CurrencyConversionJSON  > vector_Conversions1 = new List< CurrencyConversionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CurrencyConversionJSON convert_classy = CurrencyConversionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Conversions1.Add(convert_classy);
          }
        initConversions();
        for (int num1 = 0; num1 < vector_Conversions1.Count; ++num1)
            appendConversions(vector_Conversions1[num1]);
        for (int num1 = 0; num1 < vector_Conversions1.Count; ++num1)
          {
          }
      }


    public CurrencyConverterInformationNuggetJSON()
      {
        flagHasConversions = false;
        storeConversions = new List< CurrencyConversionJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "CurrencyConverter";
      }

    public bool  hasConversions()
      {
        return flagHasConversions;
      }

    public int  countOfConversions()
      {
        Debug.Assert(flagHasConversions);
        return storeConversions.Count;
      }

    public CurrencyConversionJSON   elementOfConversions(int element_num)
      {
        Debug.Assert(flagHasConversions);
        return storeConversions[element_num];
      }

    public List< CurrencyConversionJSON  >  getConversions()
      {
        Debug.Assert(flagHasConversions);
        return storeConversions;
      }


    public virtual int extraCurrencyConverterInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCurrencyConverterInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCurrencyConverterInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCurrencyConverterInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasConversions)
            ++result;
        result += extraCurrencyConverterInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasConversions)
          {
            if (remainder == 0)
                return "Conversions";
            --remainder;
          }
        return extraCurrencyConverterInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasConversions)
          {
            if (remainder == 0)
                return extraConversionsToJSON();
            --remainder;
          }
        return extraCurrencyConverterInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Conversions", 0, 11, false) == 0) && (field_name.Length == 11))
            return (flagHasConversions ? extraConversionsToJSON() : null);
        return extraCurrencyConverterInformationNuggetLookup(field_name);
      }

    public void initConversions()
      {
        if (flagHasConversions)
          {
            for (int num1 = 0; num1 < storeConversions.Count; ++num1)
              {
              }
          }
        flagHasConversions = true;
        storeConversions.Clear();
      }
    public void appendConversions(CurrencyConversionJSON  to_append)
      {
        if (!flagHasConversions)
          {
            flagHasConversions = true;
            storeConversions.Clear();
          }
        Debug.Assert(flagHasConversions);
        storeConversions.Add(to_append);
      }
    public void unsetConversions()
      {
        if (flagHasConversions)
          {
            for (int num2 = 0; num2 < storeConversions.Count; ++num2)
              {
              }
          }
        flagHasConversions = false;
        storeConversions.Clear();
      }

    public virtual void extraCurrencyConverterInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCurrencyConverterInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCurrencyConverterInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraCurrencyConverterInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Conversions", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONConversions(new_component, false);
            return;
            }
        extraCurrencyConverterInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Conversions", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONConversions(new_component, false);
            return;
            }
        extraCurrencyConverterInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasConversions);
        if (flagHasConversions)
          {
            handler.start_pair("Conversions");
            handler.start_array();
            for (int num1 = 0; num1 < storeConversions.Count; ++num1)
              {
                if (partial_allowed)
                    storeConversions[num1].write_partial_as_json(handler);
                else
                    storeConversions[num1].write_as_json(handler);
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
        if (!(hasConversions()))
          {
            return "When parsing the object for %what%, the \"Conversions\" field was missing.";
          }
        return null;
      }

    public static new CurrencyConverterInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CurrencyConverterInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrencyConverterInformationNugget", ignore_extras);
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
    public static new CurrencyConverterInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CurrencyConverterInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CurrencyConverterInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrencyConverterInformationNugget", ignore_extras);
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
    public static new CurrencyConverterInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CurrencyConverterInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        CurrencyConverterInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrencyConverterInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CurrencyConverterInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CurrencyConverterInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CurrencyConverterInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrencyConverterInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private CurrencyConversionJSON.HoldingArrayGenerator fieldGeneratorConversions;
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
            if (!(getInformationNuggetJSONKey().Equals("CurrencyConverter")))
                throw new Exception("The key field has a value other than `CurrencyConverter'.");
            CurrencyConverterInformationNuggetJSON result = new CurrencyConverterInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCurrencyConverterInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((CurrencyConverterInformationNuggetJSON )new_result);
          }
        protected void finish(CurrencyConverterInformationNuggetJSON result)
          {
            if (fieldGeneratorConversions.have_value)
              {
                result.initConversions();
                int count = fieldGeneratorConversions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendConversions(fieldGeneratorConversions.value[num]);
                  }
                fieldGeneratorConversions.value.Clear();
                fieldGeneratorConversions.have_value = false;
              }
            else if ((!(result.hasConversions())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Conversions\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(CurrencyConverterInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Conversions", 0, 11, false) == 0) && (field_name.Length == 11))
                return fieldGeneratorConversions;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorConversions = new CurrencyConversionJSON.HoldingArrayGenerator("field \"Conversions\" of the CurrencyConverterInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CurrencyConverterInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorConversions = new CurrencyConversionJSON.HoldingArrayGenerator("field \"Conversions\" of the CurrencyConverterInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CurrencyConverterInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorConversions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CurrencyConverterInformationNuggetJSON  result)
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
        public CurrencyConverterInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CurrencyConverterInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<CurrencyConverterInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CurrencyConverterInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CurrencyConverterInformationNuggetJSON>();
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
    public List<CurrencyConverterInformationNuggetJSON> value;
  };
  };
