/* file "SportsStatsTypeAndValueJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsStatsTypeAndValueJSON : JSONBase
  {
    private bool flagHasType;
    private SportsStatsTypeJSON  storeType;
    private bool flagHasValue;
    private string storeValue;
    private bool flagHasValueNumeric;
    private double storeValueNumeric;
    private string textStoreValueNumeric;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsStatsTypeJSON convert_classy = SportsStatsTypeJSON.from_json(json_value, ignore_extras, true);
        setType(convert_classy);
      }


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Value of SportsStatsTypeAndValueJSON is not a string.");
        setValue(json_string.getData());
      }


    private void  fromJSONValueNumeric(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ValueNumeric of SportsStatsTypeAndValueJSON is not a number.");
              }
          }
        setValueNumericText(the_rational_text);
      }


    public SportsStatsTypeAndValueJSON()
      {
        flagHasType = false;
        flagHasValue = false;
        flagHasValueNumeric = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public SportsStatsTypeJSON   getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public SportsStatsTypeJSON.TypeValue  getTypeValue()
      {
        return getType().getValue();
      }

    public string  getTypeAsString()
      {
        return getType().getValueAsString();
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public string  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public bool  hasValueNumeric()
      {
        return flagHasValueNumeric;
      }

    public double  getValueNumeric()
      {
        Debug.Assert(flagHasValueNumeric);
        if (textStoreValueNumeric != "")
          {
            return Double.Parse(textStoreValueNumeric);
          }
        return storeValueNumeric;
      }

    public string  getValueNumericAsText()
      {
        Debug.Assert(flagHasValueNumeric);
        if (textStoreValueNumeric == "")
          {
            return Convert.ToString(storeValueNumeric);
          }
        else
          {
            return (textStoreValueNumeric);
          }
      }


    public virtual int extraSportsStatsTypeAndValueComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStatsTypeAndValueComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStatsTypeAndValueComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStatsTypeAndValueLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setType(SportsStatsTypeJSON  new_value)
      {
        if (flagHasType)
          {
          }
        flagHasType = true;
        storeType = new_value;
      }
    public void setType(SportsStatsTypeJSON.TypeValue new_value)
      {
        setType(new SportsStatsTypeJSON(new_value));
      }
    public void setType(string chars)
      {
        SportsStatsTypeJSON.TypeValueKnownValues known = SportsStatsTypeJSON.stringToValue(chars);
        SportsStatsTypeJSON.TypeValue new_value = new SportsStatsTypeJSON.TypeValue();
        if (known == SportsStatsTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setType(new_value);
      }
    public void unsetType()
      {
        if (flagHasType)
          {
          }
        flagHasType = false;
      }
    public void setValue(string new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }
    public void setValueNumeric(double new_value)
      {
        flagHasValueNumeric = true;
        storeValueNumeric = new_value;
        textStoreValueNumeric = "";
      }
    public void setValueNumericText(string new_value)
      {
        flagHasValueNumeric = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field ValueNumeric of SportsStatsTypeAndValueJSON is not a valid number.");
        textStoreValueNumeric = new_value;
      }
    public void unsetValueNumeric()
      {
        flagHasValueNumeric = false;
      }

    public virtual void extraSportsStatsTypeAndValueAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStatsTypeAndValueSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStatsTypeAndValueLookup(key);
        if (old_field == null)
          {
            extraSportsStatsTypeAndValueAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasType);
        if (flagHasType)
          {
            handler.start_pair("Type");
            if (partial_allowed)
                storeType.write_partial_as_json(handler);
            else
                storeType.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasValue);
        if (flagHasValue)
          {
            handler.start_pair("Value");
            handler.string_value(storeValue);
          }
        if (flagHasValueNumeric)
          {
            handler.start_pair("ValueNumeric");
            if (textStoreValueNumeric != "")
                handler.number_value(textStoreValueNumeric);
            else if (((double)(long)storeValueNumeric) == storeValueNumeric)
                handler.number_value((long)storeValueNumeric);
            else
                handler.number_value(storeValueNumeric);
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
        if (!(hasType()))
          {
            return "When parsing the object for %what%, the \"Type\" field was missing.";
          }
        if (!(hasValue()))
          {
            return "When parsing the object for %what%, the \"Value\" field was missing.";
          }
        return null;
      }

    public static SportsStatsTypeAndValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStatsTypeAndValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsTypeAndValue", ignore_extras);
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
    public static SportsStatsTypeAndValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStatsTypeAndValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStatsTypeAndValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsTypeAndValue", ignore_extras);
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
    public static SportsStatsTypeAndValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStatsTypeAndValueJSON from_text(string text, bool ignore_extras)
      {
        SportsStatsTypeAndValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsTypeAndValue", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStatsTypeAndValueJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsStatsTypeAndValueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStatsTypeAndValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsTypeAndValue", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsStatsTypeJSON.HoldingGenerator fieldGeneratorType;
        private JSONHoldingStringGenerator fieldGeneratorValue;
        private JSONHoldingNumberTextGenerator fieldGeneratorValueNumeric;
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
            SportsStatsTypeAndValueJSON result = new SportsStatsTypeAndValueJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStatsTypeAndValueAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsStatsTypeAndValueJSON result)
          {
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
            else if ((!(result.hasType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Type\" field was missing.");
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
            if (fieldGeneratorValueNumeric.have_value)
              {
                result.setValueNumericText(fieldGeneratorValueNumeric.value);
                fieldGeneratorValueNumeric.have_value = false;
              }
          }
        protected abstract void handle_result(SportsStatsTypeAndValueJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'T':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorType;
                    break;
                case 'V':
                    if (String.Compare(field_name, 1, "alue", 0, 4, false) == 0)
                      {
                        if (field_name.Length == 5)
                          {
                            return fieldGeneratorValue;
                          }
                        switch (field_name[5])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 6, "umeric", 0, 6, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorValueNumeric;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorType = new SportsStatsTypeJSON.HoldingGenerator("field \"Type\" of the SportsStatsTypeAndValue class", ignore_extras);
            fieldGeneratorValue = new JSONHoldingStringGenerator("field \"Value\" of the SportsStatsTypeAndValue class");
            fieldGeneratorValueNumeric = new JSONHoldingNumberTextGenerator("field \"ValueNumeric\" of the SportsStatsTypeAndValue class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStatsTypeAndValue class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorType = new SportsStatsTypeJSON.HoldingGenerator("field \"Type\" of the SportsStatsTypeAndValue class", false);
            fieldGeneratorValue = new JSONHoldingStringGenerator("field \"Value\" of the SportsStatsTypeAndValue class");
            fieldGeneratorValueNumeric = new JSONHoldingNumberTextGenerator("field \"ValueNumeric\" of the SportsStatsTypeAndValue class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStatsTypeAndValue class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorType.reset();
            fieldGeneratorValue.reset();
            fieldGeneratorValueNumeric.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorType.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorType.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsStatsTypeAndValueJSON  result)
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
        public SportsStatsTypeAndValueJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStatsTypeAndValueJSON  result)
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
    protected virtual void handle_result(List<SportsStatsTypeAndValueJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStatsTypeAndValueJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStatsTypeAndValueJSON>();
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
    public List<SportsStatsTypeAndValueJSON> value;
  };
  };
