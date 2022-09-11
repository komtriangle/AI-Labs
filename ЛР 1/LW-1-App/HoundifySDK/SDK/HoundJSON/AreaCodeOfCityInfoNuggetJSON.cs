/* file "AreaCodeOfCityInfoNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class AreaCodeOfCityInfoNuggetJSON : AreaCodeInfoNuggetJSON
  {
    private bool flagHasCityName;
    private string storeCityName;
    private bool flagHasLocDump;
    private string storeLocDump;
    private bool flagHasAreaCodes;
    private List< BigInteger > storeAreaCodes;
    private bool flagHasInternationalAreaCodes;
    private List< string > storeInternationalAreaCodes;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCityNameToJSON()
      {
        JSONStringValue generated_string_CityName = new JSONStringValue(storeCityName);
        return generated_string_CityName;
      }

    private JSONValue  extraLocDumpToJSON()
      {
        JSONStringValue generated_string_LocDump = new JSONStringValue(storeLocDump);
        return generated_string_LocDump;
      }

    private JSONValue  extraAreaCodesToJSON()
      {
        JSONArrayValue generated_array_1_AreaCodes = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAreaCodes.Count; ++num1)
          {
            JSONIntegerValue generated_integer_AreaCodes = new JSONIntegerValue(storeAreaCodes[num1]);
            generated_array_1_AreaCodes.appendComponent(generated_integer_AreaCodes);
          }
        return generated_array_1_AreaCodes;
      }

    private JSONValue  extraInternationalAreaCodesToJSON()
      {
        JSONArrayValue generated_array_2_InternationalAreaCodes = new JSONArrayValue();
        for (int num2 = 0; num2 < storeInternationalAreaCodes.Count; ++num2)
          {
            JSONStringValue generated_string_InternationalAreaCodes = new JSONStringValue(storeInternationalAreaCodes[num2]);
            generated_array_2_InternationalAreaCodes.appendComponent(generated_string_InternationalAreaCodes);
          }
        return generated_array_2_InternationalAreaCodes;
      }


    private void  fromJSONCityName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CityName of AreaCodeOfCityInfoNuggetJSON is not a string.");
        setCityName(json_string.getData());
      }


    private void  fromJSONLocDump(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LocDump of AreaCodeOfCityInfoNuggetJSON is not a string.");
        setLocDump(json_string.getData());
      }


    private void  fromJSONAreaCodes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AreaCodes of AreaCodeOfCityInfoNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_AreaCodes1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field AreaCodes of AreaCodeOfCityInfoNuggetJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field AreaCodes of AreaCodeOfCityInfoNuggetJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_AreaCodes1.Add(extracted_integer);
          }
        initAreaCodes();
        for (int num1 = 0; num1 < vector_AreaCodes1.Count; ++num1)
            appendAreaCodes(vector_AreaCodes1[num1]);
        for (int num1 = 0; num1 < vector_AreaCodes1.Count; ++num1)
          {
          }
      }


    private void  fromJSONInternationalAreaCodes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InternationalAreaCodes of AreaCodeOfCityInfoNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_InternationalAreaCodes1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field InternationalAreaCodes of AreaCodeOfCityInfoNuggetJSON is not a string.");
            vector_InternationalAreaCodes1.Add(json_string.getData());
          }
        initInternationalAreaCodes();
        for (int num2 = 0; num2 < vector_InternationalAreaCodes1.Count; ++num2)
            appendInternationalAreaCodes(vector_InternationalAreaCodes1[num2]);
        for (int num1 = 0; num1 < vector_InternationalAreaCodes1.Count; ++num1)
          {
          }
      }


    public AreaCodeOfCityInfoNuggetJSON()
      {
        flagHasCityName = false;
        flagHasLocDump = false;
        flagHasAreaCodes = false;
        flagHasInternationalAreaCodes = false;
        storeAreaCodes = new List< BigInteger >();
        storeInternationalAreaCodes = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getAreaCodeInfoNuggetKind()
      {
        return "AreaCodeOfCityInfoNugget";
      }

    public bool  hasCityName()
      {
        return flagHasCityName;
      }

    public string  getCityName()
      {
        Debug.Assert(flagHasCityName);
        return storeCityName;
      }

    public bool  hasLocDump()
      {
        return flagHasLocDump;
      }

    public string  getLocDump()
      {
        Debug.Assert(flagHasLocDump);
        return storeLocDump;
      }

    public bool  hasAreaCodes()
      {
        return flagHasAreaCodes;
      }

    public int  countOfAreaCodes()
      {
        Debug.Assert(flagHasAreaCodes);
        return storeAreaCodes.Count;
      }

    public BigInteger  elementOfAreaCodes(int element_num)
      {
        Debug.Assert(flagHasAreaCodes);
        return storeAreaCodes[element_num];
      }

    public List< BigInteger >  getAreaCodes()
      {
        Debug.Assert(flagHasAreaCodes);
        return storeAreaCodes;
      }

    public bool  hasInternationalAreaCodes()
      {
        return flagHasInternationalAreaCodes;
      }

    public int  countOfInternationalAreaCodes()
      {
        Debug.Assert(flagHasInternationalAreaCodes);
        return storeInternationalAreaCodes.Count;
      }

    public string  elementOfInternationalAreaCodes(int element_num)
      {
        Debug.Assert(flagHasInternationalAreaCodes);
        return storeInternationalAreaCodes[element_num];
      }

    public List< string >  getInternationalAreaCodes()
      {
        Debug.Assert(flagHasInternationalAreaCodes);
        return storeInternationalAreaCodes;
      }


    public virtual int extraAreaCodeOfCityInfoNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAreaCodeOfCityInfoNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAreaCodeOfCityInfoNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAreaCodeOfCityInfoNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraAreaCodeInfoNuggetComponentCount()
      {
        int result = 0;
        if (flagHasCityName)
            ++result;
        if (flagHasLocDump)
            ++result;
        if (flagHasAreaCodes)
            ++result;
        if (flagHasInternationalAreaCodes)
            ++result;
        result += extraAreaCodeOfCityInfoNuggetComponentCount();
        return result;
      }
    public override string extraAreaCodeInfoNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCityName)
          {
            if (remainder == 0)
                return "CityName";
            --remainder;
          }
        if (flagHasLocDump)
          {
            if (remainder == 0)
                return "LocDump";
            --remainder;
          }
        if (flagHasAreaCodes)
          {
            if (remainder == 0)
                return "AreaCodes";
            --remainder;
          }
        if (flagHasInternationalAreaCodes)
          {
            if (remainder == 0)
                return "InternationalAreaCodes";
            --remainder;
          }
        return extraAreaCodeOfCityInfoNuggetComponentKey(remainder);
      }
    public override JSONValue extraAreaCodeInfoNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCityName)
          {
            if (remainder == 0)
                return extraCityNameToJSON();
            --remainder;
          }
        if (flagHasLocDump)
          {
            if (remainder == 0)
                return extraLocDumpToJSON();
            --remainder;
          }
        if (flagHasAreaCodes)
          {
            if (remainder == 0)
                return extraAreaCodesToJSON();
            --remainder;
          }
        if (flagHasInternationalAreaCodes)
          {
            if (remainder == 0)
                return extraInternationalAreaCodesToJSON();
            --remainder;
          }
        return extraAreaCodeOfCityInfoNuggetComponentValue(remainder);
      }
    public override JSONValue extraAreaCodeInfoNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "reaCodes", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasAreaCodes ? extraAreaCodesToJSON() : null);
                break;
            case 'C':
                if ((String.Compare(field_name, 1, "ityName", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasCityName ? extraCityNameToJSON() : null);
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "nternationalAreaCodes", 0, 21, false) == 0) && (field_name.Length == 22))
                    return (flagHasInternationalAreaCodes ? extraInternationalAreaCodesToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "ocDump", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasLocDump ? extraLocDumpToJSON() : null);
                break;
            default:
                break;
          }
        return extraAreaCodeOfCityInfoNuggetLookup(field_name);
      }

    public void setCityName(string new_value)
      {
        flagHasCityName = true;
        storeCityName = new_value;
      }
    public void unsetCityName()
      {
        flagHasCityName = false;
      }
    public void setLocDump(string new_value)
      {
        flagHasLocDump = true;
        storeLocDump = new_value;
      }
    public void unsetLocDump()
      {
        flagHasLocDump = false;
      }
    public void initAreaCodes()
      {
        flagHasAreaCodes = true;
        storeAreaCodes.Clear();
      }
    public void appendAreaCodes(BigInteger to_append)
      {
        if (!flagHasAreaCodes)
          {
            flagHasAreaCodes = true;
            storeAreaCodes.Clear();
          }
        Debug.Assert(flagHasAreaCodes);
        storeAreaCodes.Add(to_append);
      }
    public void unsetAreaCodes()
      {
        flagHasAreaCodes = false;
        storeAreaCodes.Clear();
      }
    public void initInternationalAreaCodes()
      {
        flagHasInternationalAreaCodes = true;
        storeInternationalAreaCodes.Clear();
      }
    public void appendInternationalAreaCodes(string to_append)
      {
        if (!flagHasInternationalAreaCodes)
          {
            flagHasInternationalAreaCodes = true;
            storeInternationalAreaCodes.Clear();
          }
        Debug.Assert(flagHasInternationalAreaCodes);
        storeInternationalAreaCodes.Add(to_append);
      }
    public void unsetInternationalAreaCodes()
      {
        flagHasInternationalAreaCodes = false;
        storeInternationalAreaCodes.Clear();
      }

    public virtual void extraAreaCodeOfCityInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAreaCodeOfCityInfoNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAreaCodeOfCityInfoNuggetLookup(key);
        if (old_field == null)
          {
            extraAreaCodeOfCityInfoNuggetAppendPair(key, new_component);
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
                if ((String.Compare(key, 1, "reaCodes", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONAreaCodes(new_component, false);
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
            case 'I':
                if ((String.Compare(key, 1, "nternationalAreaCodes", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONInternationalAreaCodes(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocDump", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONLocDump(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraAreaCodeOfCityInfoNuggetAppendPair(key, new_component);
      }
    public override void extraAreaCodeInfoNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "reaCodes", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONAreaCodes(new_component, false);
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
            case 'I':
                if ((String.Compare(key, 1, "nternationalAreaCodes", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONInternationalAreaCodes(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocDump", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONLocDump(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraAreaCodeOfCityInfoNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCityName);
        if (flagHasCityName)
          {
            handler.start_pair("CityName");
            handler.string_value(storeCityName);
          }
        Debug.Assert(partial_allowed || flagHasLocDump);
        if (flagHasLocDump)
          {
            handler.start_pair("LocDump");
            handler.string_value(storeLocDump);
          }
        if (flagHasAreaCodes)
          {
            handler.start_pair("AreaCodes");
            handler.start_array();
            for (int num1 = 0; num1 < storeAreaCodes.Count; ++num1)
              {
                handler.number_value(storeAreaCodes[num1]);
              }
            handler.finish_array();
          }
        if (flagHasInternationalAreaCodes)
          {
            handler.start_pair("InternationalAreaCodes");
            handler.start_array();
            for (int num2 = 0; num2 < storeInternationalAreaCodes.Count; ++num2)
              {
                handler.string_value(storeInternationalAreaCodes[num2]);
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
        if (!(hasCityName()))
          {
            return "When parsing the object for %what%, the \"CityName\" field was missing.";
          }
        if (!(hasLocDump()))
          {
            return "When parsing the object for %what%, the \"LocDump\" field was missing.";
          }
        return null;
      }

    public static new AreaCodeOfCityInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AreaCodeOfCityInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeOfCityInfoNugget", ignore_extras);
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
    public static new AreaCodeOfCityInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AreaCodeOfCityInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AreaCodeOfCityInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeOfCityInfoNugget", ignore_extras);
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
    public static new AreaCodeOfCityInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AreaCodeOfCityInfoNuggetJSON from_text(string text, bool ignore_extras)
      {
        AreaCodeOfCityInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeOfCityInfoNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AreaCodeOfCityInfoNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new AreaCodeOfCityInfoNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AreaCodeOfCityInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeOfCityInfoNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : AreaCodeInfoNuggetJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorCityName;
        private JSONHoldingStringGenerator fieldGeneratorLocDump;
    private class FieldHoldingGeneratorAreaCodes : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorAreaCodes(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorAreaCodes : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorAreaCodes(String what) : base(what)
              {
              }
          };
        private FieldHoldingArrayGeneratorAreaCodes fieldGeneratorAreaCodes;
        private JSONHoldingStringArrayGenerator fieldGeneratorInternationalAreaCodes;
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
            if (!(getAreaCodeInfoNuggetJSONKey().Equals("AreaCodeOfCityInfoNugget")))
                throw new Exception("The key field has a value other than `AreaCodeOfCityInfoNugget'.");
            AreaCodeOfCityInfoNuggetJSON result = new AreaCodeOfCityInfoNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAreaCodeOfCityInfoNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(AreaCodeInfoNuggetJSON new_result)
          {
            handle_result((AreaCodeOfCityInfoNuggetJSON )new_result);
          }
        protected void finish(AreaCodeOfCityInfoNuggetJSON result)
          {
            if (fieldGeneratorCityName.have_value)
              {
                result.setCityName(fieldGeneratorCityName.value);
                fieldGeneratorCityName.have_value = false;
              }
            else if ((!(result.hasCityName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CityName\" field was missing.");
              }
            if (fieldGeneratorLocDump.have_value)
              {
                result.setLocDump(fieldGeneratorLocDump.value);
                fieldGeneratorLocDump.have_value = false;
              }
            else if ((!(result.hasLocDump())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LocDump\" field was missing.");
              }
            if (fieldGeneratorAreaCodes.have_value)
              {
                result.initAreaCodes();
                int count = fieldGeneratorAreaCodes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAreaCodes(fieldGeneratorAreaCodes.value[num]);
                  }
                fieldGeneratorAreaCodes.value.Clear();
                fieldGeneratorAreaCodes.have_value = false;
              }
            if (fieldGeneratorInternationalAreaCodes.have_value)
              {
                result.initInternationalAreaCodes();
                int count = fieldGeneratorInternationalAreaCodes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInternationalAreaCodes(fieldGeneratorInternationalAreaCodes.value[num]);
                  }
                fieldGeneratorInternationalAreaCodes.value.Clear();
                fieldGeneratorInternationalAreaCodes.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(AreaCodeOfCityInfoNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "reaCodes", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorAreaCodes;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "ityName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorCityName;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nternationalAreaCodes", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorInternationalAreaCodes;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocDump", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorLocDump;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCityName = new JSONHoldingStringGenerator("field \"CityName\" of the AreaCodeOfCityInfoNugget class");
            fieldGeneratorLocDump = new JSONHoldingStringGenerator("field \"LocDump\" of the AreaCodeOfCityInfoNugget class");
            fieldGeneratorAreaCodes = new FieldHoldingArrayGeneratorAreaCodes("field \"AreaCodes\" of the AreaCodeOfCityInfoNugget class");
            fieldGeneratorInternationalAreaCodes = new JSONHoldingStringArrayGenerator("field \"InternationalAreaCodes\" of the AreaCodeOfCityInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AreaCodeOfCityInfoNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCityName = new JSONHoldingStringGenerator("field \"CityName\" of the AreaCodeOfCityInfoNugget class");
            fieldGeneratorLocDump = new JSONHoldingStringGenerator("field \"LocDump\" of the AreaCodeOfCityInfoNugget class");
            fieldGeneratorAreaCodes = new FieldHoldingArrayGeneratorAreaCodes("field \"AreaCodes\" of the AreaCodeOfCityInfoNugget class");
            fieldGeneratorInternationalAreaCodes = new JSONHoldingStringArrayGenerator("field \"InternationalAreaCodes\" of the AreaCodeOfCityInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AreaCodeOfCityInfoNugget class");
          }

        public override void reset()
          {
            fieldGeneratorCityName.reset();
            fieldGeneratorLocDump.reset();
            fieldGeneratorAreaCodes.reset();
            fieldGeneratorInternationalAreaCodes.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(AreaCodeOfCityInfoNuggetJSON  result)
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
        public AreaCodeOfCityInfoNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AreaCodeOfCityInfoNuggetJSON  result)
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
    protected virtual void handle_result(List<AreaCodeOfCityInfoNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AreaCodeOfCityInfoNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AreaCodeOfCityInfoNuggetJSON>();
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
    public List<AreaCodeOfCityInfoNuggetJSON> value;
  };
  };
