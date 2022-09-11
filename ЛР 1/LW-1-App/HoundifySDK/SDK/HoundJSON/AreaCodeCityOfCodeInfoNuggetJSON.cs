/* file "AreaCodeCityOfCodeInfoNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class AreaCodeCityOfCodeInfoNuggetJSON : AreaCodeInfoNuggetJSON
  {
    private bool flagHasAreaCode;
    private BigInteger storeAreaCode;
    private bool flagHasCityName;
    private List< string > storeCityName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraAreaCodeToJSON()
      {
        JSONIntegerValue generated_integer_AreaCode = new JSONIntegerValue(storeAreaCode);
        return generated_integer_AreaCode;
      }

    private JSONValue  extraCityNameToJSON()
      {
        JSONArrayValue generated_array_1_CityName = new JSONArrayValue();
        for (int num1 = 0; num1 < storeCityName.Count; ++num1)
          {
            JSONStringValue generated_string_CityName = new JSONStringValue(storeCityName[num1]);
            generated_array_1_CityName.appendComponent(generated_string_CityName);
          }
        return generated_array_1_CityName;
      }


    private void  fromJSONAreaCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field AreaCode of AreaCodeCityOfCodeInfoNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AreaCode of AreaCodeCityOfCodeInfoNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAreaCode(extracted_integer);
      }


    private void  fromJSONCityName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CityName of AreaCodeCityOfCodeInfoNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_CityName1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field CityName of AreaCodeCityOfCodeInfoNuggetJSON is not a string.");
            vector_CityName1.Add(json_string.getData());
          }
        initCityName();
        for (int num1 = 0; num1 < vector_CityName1.Count; ++num1)
            appendCityName(vector_CityName1[num1]);
        for (int num1 = 0; num1 < vector_CityName1.Count; ++num1)
          {
          }
      }


    public AreaCodeCityOfCodeInfoNuggetJSON()
      {
        flagHasAreaCode = false;
        flagHasCityName = false;
        storeCityName = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getAreaCodeInfoNuggetKind()
      {
        return "AreaCodeCityOfCodeInfoNugget";
      }

    public bool  hasAreaCode()
      {
        return flagHasAreaCode;
      }

    public BigInteger  getAreaCode()
      {
        Debug.Assert(flagHasAreaCode);
        return storeAreaCode;
      }

    public bool  hasCityName()
      {
        return flagHasCityName;
      }

    public int  countOfCityName()
      {
        Debug.Assert(flagHasCityName);
        return storeCityName.Count;
      }

    public string  elementOfCityName(int element_num)
      {
        Debug.Assert(flagHasCityName);
        return storeCityName[element_num];
      }

    public List< string >  getCityName()
      {
        Debug.Assert(flagHasCityName);
        return storeCityName;
      }


    public virtual int extraAreaCodeCityOfCodeInfoNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAreaCodeCityOfCodeInfoNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAreaCodeCityOfCodeInfoNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAreaCodeCityOfCodeInfoNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraAreaCodeInfoNuggetComponentCount()
      {
        int result = 0;
        if (flagHasAreaCode)
            ++result;
        if (flagHasCityName)
            ++result;
        result += extraAreaCodeCityOfCodeInfoNuggetComponentCount();
        return result;
      }
    public override string extraAreaCodeInfoNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAreaCode)
          {
            if (remainder == 0)
                return "AreaCode";
            --remainder;
          }
        if (flagHasCityName)
          {
            if (remainder == 0)
                return "CityName";
            --remainder;
          }
        return extraAreaCodeCityOfCodeInfoNuggetComponentKey(remainder);
      }
    public override JSONValue extraAreaCodeInfoNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAreaCode)
          {
            if (remainder == 0)
                return extraAreaCodeToJSON();
            --remainder;
          }
        if (flagHasCityName)
          {
            if (remainder == 0)
                return extraCityNameToJSON();
            --remainder;
          }
        return extraAreaCodeCityOfCodeInfoNuggetComponentValue(remainder);
      }
    public override JSONValue extraAreaCodeInfoNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "reaCode", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasAreaCode ? extraAreaCodeToJSON() : null);
                break;
            case 'C':
                if ((String.Compare(field_name, 1, "ityName", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasCityName ? extraCityNameToJSON() : null);
                break;
            default:
                break;
          }
        return extraAreaCodeCityOfCodeInfoNuggetLookup(field_name);
      }

    public void setAreaCode(BigInteger new_value)
      {
        flagHasAreaCode = true;
        storeAreaCode = new_value;
      }
    public void unsetAreaCode()
      {
        flagHasAreaCode = false;
      }
    public void initCityName()
      {
        flagHasCityName = true;
        storeCityName.Clear();
      }
    public void appendCityName(string to_append)
      {
        if (!flagHasCityName)
          {
            flagHasCityName = true;
            storeCityName.Clear();
          }
        Debug.Assert(flagHasCityName);
        storeCityName.Add(to_append);
      }
    public void unsetCityName()
      {
        flagHasCityName = false;
        storeCityName.Clear();
      }

    public virtual void extraAreaCodeCityOfCodeInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAreaCodeCityOfCodeInfoNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAreaCodeCityOfCodeInfoNuggetLookup(key);
        if (old_field == null)
          {
            extraAreaCodeCityOfCodeInfoNuggetAppendPair(key, new_component);
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
    public override void extraAreaCodeInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "reaCode", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONAreaCode(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if ((String.Compare(key, 1, "ityName", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONCityName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraAreaCodeCityOfCodeInfoNuggetAppendPair(key, new_component);
      }
    public override void extraAreaCodeInfoNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "reaCode", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONAreaCode(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if ((String.Compare(key, 1, "ityName", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONCityName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraAreaCodeCityOfCodeInfoNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAreaCode);
        if (flagHasAreaCode)
          {
            handler.start_pair("AreaCode");
            handler.number_value(storeAreaCode);
          }
        if (flagHasCityName)
          {
            handler.start_pair("CityName");
            handler.start_array();
            for (int num1 = 0; num1 < storeCityName.Count; ++num1)
              {
                handler.string_value(storeCityName[num1]);
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
        if (!(hasAreaCode()))
          {
            return "When parsing the object for %what%, the \"AreaCode\" field was missing.";
          }
        return null;
      }

    public static new AreaCodeCityOfCodeInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AreaCodeCityOfCodeInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeCityOfCodeInfoNugget", ignore_extras);
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
    public static new AreaCodeCityOfCodeInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AreaCodeCityOfCodeInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AreaCodeCityOfCodeInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeCityOfCodeInfoNugget", ignore_extras);
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
    public static new AreaCodeCityOfCodeInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AreaCodeCityOfCodeInfoNuggetJSON from_text(string text, bool ignore_extras)
      {
        AreaCodeCityOfCodeInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeCityOfCodeInfoNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AreaCodeCityOfCodeInfoNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new AreaCodeCityOfCodeInfoNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AreaCodeCityOfCodeInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeCityOfCodeInfoNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : AreaCodeInfoNuggetJSON.Generator
      {
    private class FieldHoldingGeneratorAreaCode : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorAreaCode(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorAreaCode : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorAreaCode(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorAreaCode fieldGeneratorAreaCode;
        private JSONHoldingStringArrayGenerator fieldGeneratorCityName;
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
            if (!(getAreaCodeInfoNuggetJSONKey().Equals("AreaCodeCityOfCodeInfoNugget")))
                throw new Exception("The key field has a value other than `AreaCodeCityOfCodeInfoNugget'.");
            AreaCodeCityOfCodeInfoNuggetJSON result = new AreaCodeCityOfCodeInfoNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAreaCodeCityOfCodeInfoNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(AreaCodeInfoNuggetJSON new_result)
          {
            handle_result((AreaCodeCityOfCodeInfoNuggetJSON )new_result);
          }
        protected void finish(AreaCodeCityOfCodeInfoNuggetJSON result)
          {
            if (fieldGeneratorAreaCode.have_value)
              {
                result.setAreaCode(fieldGeneratorAreaCode.value);
                fieldGeneratorAreaCode.have_value = false;
              }
            else if ((!(result.hasAreaCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AreaCode\" field was missing.");
              }
            if (fieldGeneratorCityName.have_value)
              {
                result.initCityName();
                int count = fieldGeneratorCityName.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCityName(fieldGeneratorCityName.value[num]);
                  }
                fieldGeneratorCityName.value.Clear();
                fieldGeneratorCityName.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(AreaCodeCityOfCodeInfoNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "reaCode", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorAreaCode;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "ityName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorCityName;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAreaCode = new FieldHoldingGeneratorAreaCode("field \"AreaCode\" of the AreaCodeCityOfCodeInfoNugget class");
            fieldGeneratorCityName = new JSONHoldingStringArrayGenerator("field \"CityName\" of the AreaCodeCityOfCodeInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AreaCodeCityOfCodeInfoNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAreaCode = new FieldHoldingGeneratorAreaCode("field \"AreaCode\" of the AreaCodeCityOfCodeInfoNugget class");
            fieldGeneratorCityName = new JSONHoldingStringArrayGenerator("field \"CityName\" of the AreaCodeCityOfCodeInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AreaCodeCityOfCodeInfoNugget class");
          }

        public override void reset()
          {
            fieldGeneratorAreaCode.reset();
            fieldGeneratorCityName.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(AreaCodeCityOfCodeInfoNuggetJSON  result)
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
        public AreaCodeCityOfCodeInfoNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AreaCodeCityOfCodeInfoNuggetJSON  result)
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
    protected virtual void handle_result(List<AreaCodeCityOfCodeInfoNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AreaCodeCityOfCodeInfoNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AreaCodeCityOfCodeInfoNuggetJSON>();
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
    public List<AreaCodeCityOfCodeInfoNuggetJSON> value;
  };
  };
