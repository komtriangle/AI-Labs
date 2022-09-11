/* file "AirQualityDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class AirQualityDataJSON : JSONBase
  {
    private bool flagHasValue;
    private BigInteger storeValue;
    private bool flagHasCategory;
    private AirQualityCategoryJSON  storeCategory;
    private bool flagHasPM25;
    private BigInteger storePM25;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


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
                throw new Exception("The value for field Value of AirQualityDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Value of AirQualityDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setValue(extracted_integer);
      }


    private void  fromJSONCategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AirQualityCategoryJSON convert_classy = AirQualityCategoryJSON.from_json(json_value, ignore_extras, true);
        setCategory(convert_classy);
      }


    private void  fromJSONPM25(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PM25 of AirQualityDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PM25 of AirQualityDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPM25(extracted_integer);
      }


    public AirQualityDataJSON()
      {
        flagHasValue = false;
        flagHasCategory = false;
        flagHasPM25 = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasCategory()
      {
        return flagHasCategory;
      }

    public AirQualityCategoryJSON   getCategory()
      {
        Debug.Assert(flagHasCategory);
        return storeCategory;
      }

    public AirQualityCategoryJSON.TypeValue  getCategoryValue()
      {
        return getCategory().getValue();
      }

    public string  getCategoryAsString()
      {
        return getCategory().getValueAsString();
      }

    public bool  hasPM25()
      {
        return flagHasPM25;
      }

    public BigInteger  getPM25()
      {
        Debug.Assert(flagHasPM25);
        return storePM25;
      }


    public virtual int extraAirQualityDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAirQualityDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAirQualityDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAirQualityDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setValue(BigInteger new_value)
      {
        flagHasValue = true;
        if (new_value < 0)
            throw new Exception("The value for field Value of AirQualityDataJSON is less than the lower bound (0) for that field.");
        storeValue = new_value;
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }
    public void setCategory(AirQualityCategoryJSON  new_value)
      {
        if (flagHasCategory)
          {
          }
        flagHasCategory = true;
        storeCategory = new_value;
      }
    public void setCategory(AirQualityCategoryJSON.TypeValue new_value)
      {
        setCategory(new AirQualityCategoryJSON(new_value));
      }
    public void setCategory(string chars)
      {
        AirQualityCategoryJSON.TypeValueKnownValues known = AirQualityCategoryJSON.stringToValue(chars);
        AirQualityCategoryJSON.TypeValue new_value = new AirQualityCategoryJSON.TypeValue();
        if (known == AirQualityCategoryJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setCategory(new_value);
      }
    public void unsetCategory()
      {
        if (flagHasCategory)
          {
          }
        flagHasCategory = false;
      }
    public void setPM25(BigInteger new_value)
      {
        flagHasPM25 = true;
        if (new_value < 0)
            throw new Exception("The value for field PM25 of AirQualityDataJSON is less than the lower bound (0) for that field.");
        storePM25 = new_value;
      }
    public void unsetPM25()
      {
        flagHasPM25 = false;
      }

    public virtual void extraAirQualityDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAirQualityDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAirQualityDataLookup(key);
        if (old_field == null)
          {
            extraAirQualityDataAppendPair(key, new_component);
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
        if (flagHasValue)
          {
            handler.start_pair("Value");
            handler.number_value(storeValue);
          }
        if (flagHasCategory)
          {
            handler.start_pair("Category");
            if (partial_allowed)
                storeCategory.write_partial_as_json(handler);
            else
                storeCategory.write_as_json(handler);
          }
        if (flagHasPM25)
          {
            handler.start_pair("PM25");
            handler.number_value(storePM25);
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

    public static AirQualityDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AirQualityDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AirQualityData", ignore_extras);
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
    public static AirQualityDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AirQualityDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AirQualityDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AirQualityData", ignore_extras);
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
    public static AirQualityDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AirQualityDataJSON from_text(string text, bool ignore_extras)
      {
        AirQualityDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AirQualityData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AirQualityDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AirQualityDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AirQualityDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AirQualityData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorValue : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorValue(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorValue : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorValue(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorValue fieldGeneratorValue;
        private AirQualityCategoryJSON.HoldingGenerator fieldGeneratorCategory;
    private class FieldHoldingGeneratorPM25 : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorPM25(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorPM25 : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorPM25(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorPM25 fieldGeneratorPM25;
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
            AirQualityDataJSON result = new AirQualityDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAirQualityDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(AirQualityDataJSON result)
          {
            if (fieldGeneratorValue.have_value)
              {
                result.setValue(fieldGeneratorValue.value);
                fieldGeneratorValue.have_value = false;
              }
            if (fieldGeneratorCategory.have_value)
              {
                result.setCategory(fieldGeneratorCategory.value);
                fieldGeneratorCategory.have_value = false;
              }
            if (fieldGeneratorPM25.have_value)
              {
                result.setPM25(fieldGeneratorPM25.value);
                fieldGeneratorPM25.have_value = false;
              }
          }
        protected abstract void handle_result(AirQualityDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ategory", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorCategory;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "M25", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorPM25;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorValue = new FieldHoldingGeneratorValue("field \"Value\" of the AirQualityData class");
            fieldGeneratorCategory = new AirQualityCategoryJSON.HoldingGenerator("field \"Category\" of the AirQualityData class", ignore_extras);
            fieldGeneratorPM25 = new FieldHoldingGeneratorPM25("field \"PM25\" of the AirQualityData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AirQualityData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorValue = new FieldHoldingGeneratorValue("field \"Value\" of the AirQualityData class");
            fieldGeneratorCategory = new AirQualityCategoryJSON.HoldingGenerator("field \"Category\" of the AirQualityData class", false);
            fieldGeneratorPM25 = new FieldHoldingGeneratorPM25("field \"PM25\" of the AirQualityData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AirQualityData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorValue.reset();
            fieldGeneratorCategory.reset();
            fieldGeneratorPM25.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorCategory.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorCategory.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(AirQualityDataJSON  result)
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
        public AirQualityDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AirQualityDataJSON  result)
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
    protected virtual void handle_result(List<AirQualityDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AirQualityDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AirQualityDataJSON>();
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
    public List<AirQualityDataJSON> value;
  };
  };
