/* file "UnitsValue_TemperatureJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UnitsValue_TemperatureJSON : JSONBase
  {
    private bool flagHasFormat;
    private WeatherUnitsFormatJSON  storeFormat;
    private bool flagHasUnits;
    private WeatherTemperatureUnitsJSON  storeUnits;
    private bool flagHasAbbreviatedUnits;
    private string storeAbbreviatedUnits;
    private bool flagHasWrittenUnits;
    private string storeWrittenUnits;
    private bool flagHasSpokenUnits;
    private string storeSpokenUnits;
    private bool flagHasValue;
    private BigInteger storeValue;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFormat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherUnitsFormatJSON convert_classy = WeatherUnitsFormatJSON.from_json(json_value, ignore_extras, true);
        setFormat(convert_classy);
      }


    private void  fromJSONUnits(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherTemperatureUnitsJSON convert_classy = WeatherTemperatureUnitsJSON.from_json(json_value, ignore_extras, true);
        setUnits(convert_classy);
      }


    private void  fromJSONAbbreviatedUnits(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AbbreviatedUnits of UnitsValue_TemperatureJSON is not a string.");
        setAbbreviatedUnits(json_string.getData());
      }


    private void  fromJSONWrittenUnits(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenUnits of UnitsValue_TemperatureJSON is not a string.");
        setWrittenUnits(json_string.getData());
      }


    private void  fromJSONSpokenUnits(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenUnits of UnitsValue_TemperatureJSON is not a string.");
        setSpokenUnits(json_string.getData());
      }


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Value of UnitsValue_TemperatureJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Value of UnitsValue_TemperatureJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setValue(extracted_integer);
      }


    public UnitsValue_TemperatureJSON()
      {
        flagHasFormat = false;
        flagHasUnits = false;
        flagHasAbbreviatedUnits = false;
        flagHasWrittenUnits = false;
        flagHasSpokenUnits = false;
        flagHasValue = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFormat()
      {
        return flagHasFormat;
      }

    public WeatherUnitsFormatJSON   getFormat()
      {
        Debug.Assert(flagHasFormat);
        return storeFormat;
      }

    public WeatherUnitsFormatJSON.TypeValue  getFormatValue()
      {
        return getFormat().getValue();
      }

    public string  getFormatAsString()
      {
        return getFormat().getValueAsString();
      }

    public bool  hasUnits()
      {
        return flagHasUnits;
      }

    public WeatherTemperatureUnitsJSON   getUnits()
      {
        Debug.Assert(flagHasUnits);
        return storeUnits;
      }

    public WeatherTemperatureUnitsJSON.TypeValue  getUnitsValue()
      {
        return getUnits().getValue();
      }

    public string  getUnitsAsString()
      {
        return getUnits().getValueAsString();
      }

    public bool  hasAbbreviatedUnits()
      {
        return flagHasAbbreviatedUnits;
      }

    public string  getAbbreviatedUnits()
      {
        Debug.Assert(flagHasAbbreviatedUnits);
        return storeAbbreviatedUnits;
      }

    public bool  hasWrittenUnits()
      {
        return flagHasWrittenUnits;
      }

    public string  getWrittenUnits()
      {
        Debug.Assert(flagHasWrittenUnits);
        return storeWrittenUnits;
      }

    public bool  hasSpokenUnits()
      {
        return flagHasSpokenUnits;
      }

    public string  getSpokenUnits()
      {
        Debug.Assert(flagHasSpokenUnits);
        return storeSpokenUnits;
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public BigInteger  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }


    public virtual int extraUnitsValue_TemperatureComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUnitsValue_TemperatureComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUnitsValue_TemperatureComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUnitsValue_TemperatureLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFormat(WeatherUnitsFormatJSON  new_value)
      {
        if (flagHasFormat)
          {
          }
        flagHasFormat = true;
        storeFormat = new_value;
      }
    public void setFormat(WeatherUnitsFormatJSON.TypeValue new_value)
      {
        setFormat(new WeatherUnitsFormatJSON(new_value));
      }
    public void setFormat(string chars)
      {
        WeatherUnitsFormatJSON.TypeValueKnownValues known = WeatherUnitsFormatJSON.stringToValue(chars);
        WeatherUnitsFormatJSON.TypeValue new_value = new WeatherUnitsFormatJSON.TypeValue();
        if (known == WeatherUnitsFormatJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setFormat(new_value);
      }
    public void unsetFormat()
      {
        if (flagHasFormat)
          {
          }
        flagHasFormat = false;
      }
    public void setUnits(WeatherTemperatureUnitsJSON  new_value)
      {
        if (flagHasUnits)
          {
          }
        flagHasUnits = true;
        storeUnits = new_value;
      }
    public void setUnits(WeatherTemperatureUnitsJSON.TypeValue new_value)
      {
        setUnits(new WeatherTemperatureUnitsJSON(new_value));
      }
    public void setUnits(string chars)
      {
        WeatherTemperatureUnitsJSON.TypeValueKnownValues known = WeatherTemperatureUnitsJSON.stringToValue(chars);
        WeatherTemperatureUnitsJSON.TypeValue new_value = new WeatherTemperatureUnitsJSON.TypeValue();
        if (known == WeatherTemperatureUnitsJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setUnits(new_value);
      }
    public void unsetUnits()
      {
        if (flagHasUnits)
          {
          }
        flagHasUnits = false;
      }
    public void setAbbreviatedUnits(string new_value)
      {
        flagHasAbbreviatedUnits = true;
        storeAbbreviatedUnits = new_value;
      }
    public void unsetAbbreviatedUnits()
      {
        flagHasAbbreviatedUnits = false;
      }
    public void setWrittenUnits(string new_value)
      {
        flagHasWrittenUnits = true;
        storeWrittenUnits = new_value;
      }
    public void unsetWrittenUnits()
      {
        flagHasWrittenUnits = false;
      }
    public void setSpokenUnits(string new_value)
      {
        flagHasSpokenUnits = true;
        storeSpokenUnits = new_value;
      }
    public void unsetSpokenUnits()
      {
        flagHasSpokenUnits = false;
      }
    public void setValue(BigInteger new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }

    public virtual void extraUnitsValue_TemperatureAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUnitsValue_TemperatureSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUnitsValue_TemperatureLookup(key);
        if (old_field == null)
          {
            extraUnitsValue_TemperatureAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasFormat);
        if (flagHasFormat)
          {
            handler.start_pair("Format");
            if (partial_allowed)
                storeFormat.write_partial_as_json(handler);
            else
                storeFormat.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasUnits);
        if (flagHasUnits)
          {
            handler.start_pair("Units");
            if (partial_allowed)
                storeUnits.write_partial_as_json(handler);
            else
                storeUnits.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasAbbreviatedUnits);
        if (flagHasAbbreviatedUnits)
          {
            handler.start_pair("AbbreviatedUnits");
            handler.string_value(storeAbbreviatedUnits);
          }
        Debug.Assert(partial_allowed || flagHasWrittenUnits);
        if (flagHasWrittenUnits)
          {
            handler.start_pair("WrittenUnits");
            handler.string_value(storeWrittenUnits);
          }
        Debug.Assert(partial_allowed || flagHasSpokenUnits);
        if (flagHasSpokenUnits)
          {
            handler.start_pair("SpokenUnits");
            handler.string_value(storeSpokenUnits);
          }
        Debug.Assert(partial_allowed || flagHasValue);
        if (flagHasValue)
          {
            handler.start_pair("Value");
            handler.number_value(storeValue);
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
        if (!(hasFormat()))
          {
            return "When parsing the object for %what%, the \"Format\" field was missing.";
          }
        if (!(hasUnits()))
          {
            return "When parsing the object for %what%, the \"Units\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasAbbreviatedUnits()))
          {
            return "When parsing the object for %what%, the \"AbbreviatedUnits\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasWrittenUnits()))
          {
            return "When parsing the object for %what%, the \"WrittenUnits\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasSpokenUnits()))
          {
            return "When parsing the object for %what%, the \"SpokenUnits\" field was missing.";
          }
        if (!(hasValue()))
          {
            return "When parsing the object for %what%, the \"Value\" field was missing.";
          }
        return null;
      }

    public static UnitsValue_TemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnitsValue_TemperatureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitsValue_Temperature", ignore_extras);
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
    public static UnitsValue_TemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UnitsValue_TemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnitsValue_TemperatureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitsValue_Temperature", ignore_extras);
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
    public static UnitsValue_TemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UnitsValue_TemperatureJSON from_text(string text, bool ignore_extras)
      {
        UnitsValue_TemperatureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitsValue_Temperature", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UnitsValue_TemperatureJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UnitsValue_TemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UnitsValue_TemperatureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitsValue_Temperature", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private WeatherUnitsFormatJSON.HoldingGenerator fieldGeneratorFormat;
        private WeatherTemperatureUnitsJSON.HoldingGenerator fieldGeneratorUnits;
        private JSONHoldingStringGenerator fieldGeneratorAbbreviatedUnits;
        private JSONHoldingStringGenerator fieldGeneratorWrittenUnits;
        private JSONHoldingStringGenerator fieldGeneratorSpokenUnits;
    private class FieldHoldingGeneratorValue : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorValue(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorValue : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorValue(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorValue fieldGeneratorValue;
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
            UnitsValue_TemperatureJSON result = new UnitsValue_TemperatureJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUnitsValue_TemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UnitsValue_TemperatureJSON result)
          {
            if (fieldGeneratorFormat.have_value)
              {
                result.setFormat(fieldGeneratorFormat.value);
                fieldGeneratorFormat.have_value = false;
              }
            else if ((!(result.hasFormat())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Format\" field was missing.");
              }
            if (fieldGeneratorUnits.have_value)
              {
                result.setUnits(fieldGeneratorUnits.value);
                fieldGeneratorUnits.have_value = false;
              }
            else if ((!(result.hasUnits())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Units\" field was missing.");
              }
            if (fieldGeneratorAbbreviatedUnits.have_value)
              {
                result.setAbbreviatedUnits(fieldGeneratorAbbreviatedUnits.value);
                fieldGeneratorAbbreviatedUnits.have_value = false;
              }
            else if ((!(result.hasAbbreviatedUnits())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AbbreviatedUnits\" field was missing.");
              }
            if (fieldGeneratorWrittenUnits.have_value)
              {
                result.setWrittenUnits(fieldGeneratorWrittenUnits.value);
                fieldGeneratorWrittenUnits.have_value = false;
              }
            else if ((!(result.hasWrittenUnits())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenUnits\" field was missing.");
              }
            if (fieldGeneratorSpokenUnits.have_value)
              {
                result.setSpokenUnits(fieldGeneratorSpokenUnits.value);
                fieldGeneratorSpokenUnits.have_value = false;
              }
            else if ((!(result.hasSpokenUnits())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenUnits\" field was missing.");
              }
            if (fieldGeneratorValue.have_value)
              {
                result.setValue(fieldGeneratorValue.value);
                fieldGeneratorValue.have_value = false;
              }
            else if ((!(result.hasValue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Value\" field was missing.");
              }
          }
        protected abstract void handle_result(UnitsValue_TemperatureJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "bbreviatedUnits", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorAbbreviatedUnits;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "ormat", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorFormat;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pokenUnits", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorSpokenUnits;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nits", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorUnits;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "rittenUnits", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorWrittenUnits;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFormat = new WeatherUnitsFormatJSON.HoldingGenerator("field \"Format\" of the UnitsValue_Temperature class", ignore_extras);
            fieldGeneratorUnits = new WeatherTemperatureUnitsJSON.HoldingGenerator("field \"Units\" of the UnitsValue_Temperature class", ignore_extras);
            fieldGeneratorAbbreviatedUnits = new JSONHoldingStringGenerator("field \"AbbreviatedUnits\" of the UnitsValue_Temperature class");
            fieldGeneratorWrittenUnits = new JSONHoldingStringGenerator("field \"WrittenUnits\" of the UnitsValue_Temperature class");
            fieldGeneratorSpokenUnits = new JSONHoldingStringGenerator("field \"SpokenUnits\" of the UnitsValue_Temperature class");
            fieldGeneratorValue = new FieldHoldingGeneratorValue("field \"Value\" of the UnitsValue_Temperature class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UnitsValue_Temperature class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFormat = new WeatherUnitsFormatJSON.HoldingGenerator("field \"Format\" of the UnitsValue_Temperature class", false);
            fieldGeneratorUnits = new WeatherTemperatureUnitsJSON.HoldingGenerator("field \"Units\" of the UnitsValue_Temperature class", false);
            fieldGeneratorAbbreviatedUnits = new JSONHoldingStringGenerator("field \"AbbreviatedUnits\" of the UnitsValue_Temperature class");
            fieldGeneratorWrittenUnits = new JSONHoldingStringGenerator("field \"WrittenUnits\" of the UnitsValue_Temperature class");
            fieldGeneratorSpokenUnits = new JSONHoldingStringGenerator("field \"SpokenUnits\" of the UnitsValue_Temperature class");
            fieldGeneratorValue = new FieldHoldingGeneratorValue("field \"Value\" of the UnitsValue_Temperature class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UnitsValue_Temperature class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFormat.reset();
            fieldGeneratorUnits.reset();
            fieldGeneratorAbbreviatedUnits.reset();
            fieldGeneratorWrittenUnits.reset();
            fieldGeneratorSpokenUnits.reset();
            fieldGeneratorValue.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFormat.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUnits.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFormat.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUnits.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UnitsValue_TemperatureJSON  result)
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
        public UnitsValue_TemperatureJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UnitsValue_TemperatureJSON  result)
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
    protected virtual void handle_result(List<UnitsValue_TemperatureJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UnitsValue_TemperatureJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UnitsValue_TemperatureJSON>();
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
    public List<UnitsValue_TemperatureJSON> value;
  };
  };
