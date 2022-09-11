/* file "LeapYearLookupInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class LeapYearLookupInformationNuggetJSON : DateAndTimeInformationNuggetJSON
  {
    private bool flagHasYear;
    private BigInteger storeYear;
    private bool flagHasIsLeapYear;
    private bool storeIsLeapYear;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraYearToJSON()
      {
        JSONIntegerValue generated_integer_Year = new JSONIntegerValue(storeYear);
        return generated_integer_Year;
      }

    private JSONValue  extraIsLeapYearToJSON()
      {
        JSONValue generated_boolean_IsLeapYear = (storeIsLeapYear ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsLeapYear;
      }


    private void  fromJSONYear(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Year of LeapYearLookupInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Year of LeapYearLookupInformationNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setYear(extracted_integer);
      }


    private void  fromJSONIsLeapYear(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsLeapYear of LeapYearLookupInformationNuggetJSON is not true for false.");
              }
          }
        setIsLeapYear(the_bool);
      }


    public LeapYearLookupInformationNuggetJSON()
      {
        flagHasYear = false;
        flagHasIsLeapYear = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDateAndTimeNuggetKind()
      {
        return "LeapYearLookup";
      }

    public bool  hasYear()
      {
        return flagHasYear;
      }

    public BigInteger  getYear()
      {
        Debug.Assert(flagHasYear);
        return storeYear;
      }

    public bool  hasIsLeapYear()
      {
        return flagHasIsLeapYear;
      }

    public bool  getIsLeapYear()
      {
        Debug.Assert(flagHasIsLeapYear);
        return storeIsLeapYear;
      }


    public virtual int extraLeapYearLookupInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraLeapYearLookupInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraLeapYearLookupInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraLeapYearLookupInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDateAndTimeInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasYear)
            ++result;
        if (flagHasIsLeapYear)
            ++result;
        result += extraLeapYearLookupInformationNuggetComponentCount();
        return result;
      }
    public override string extraDateAndTimeInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasYear)
          {
            if (remainder == 0)
                return "Year";
            --remainder;
          }
        if (flagHasIsLeapYear)
          {
            if (remainder == 0)
                return "IsLeapYear";
            --remainder;
          }
        return extraLeapYearLookupInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasYear)
          {
            if (remainder == 0)
                return extraYearToJSON();
            --remainder;
          }
        if (flagHasIsLeapYear)
          {
            if (remainder == 0)
                return extraIsLeapYearToJSON();
            --remainder;
          }
        return extraLeapYearLookupInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'I':
                if ((String.Compare(field_name, 1, "sLeapYear", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasIsLeapYear ? extraIsLeapYearToJSON() : null);
                break;
            case 'Y':
                if ((String.Compare(field_name, 1, "ear", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasYear ? extraYearToJSON() : null);
                break;
            default:
                break;
          }
        return extraLeapYearLookupInformationNuggetLookup(field_name);
      }

    public void setYear(BigInteger new_value)
      {
        flagHasYear = true;
        storeYear = new_value;
      }
    public void unsetYear()
      {
        flagHasYear = false;
      }
    public void setIsLeapYear(bool new_value)
      {
        flagHasIsLeapYear = true;
        storeIsLeapYear = new_value;
      }
    public void unsetIsLeapYear()
      {
        flagHasIsLeapYear = false;
      }

    public virtual void extraLeapYearLookupInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraLeapYearLookupInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraLeapYearLookupInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraLeapYearLookupInformationNuggetAppendPair(key, new_component);
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
    public override void extraDateAndTimeInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "sLeapYear", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONIsLeapYear(new_component, false);
                    return;
                    }
                break;
            case 'Y':
                if ((String.Compare(key, 1, "ear", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONYear(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraLeapYearLookupInformationNuggetAppendPair(key, new_component);
      }
    public override void extraDateAndTimeInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "sLeapYear", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONIsLeapYear(new_component, false);
                    return;
                    }
                break;
            case 'Y':
                if ((String.Compare(key, 1, "ear", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONYear(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraLeapYearLookupInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasYear);
        if (flagHasYear)
          {
            handler.start_pair("Year");
            handler.number_value(storeYear);
          }
        Debug.Assert(partial_allowed || flagHasIsLeapYear);
        if (flagHasIsLeapYear)
          {
            handler.start_pair("IsLeapYear");
            handler.boolean_value(storeIsLeapYear);
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
        if (!(hasYear()))
          {
            return "When parsing the object for %what%, the \"Year\" field was missing.";
          }
        if (!(hasIsLeapYear()))
          {
            return "When parsing the object for %what%, the \"IsLeapYear\" field was missing.";
          }
        return null;
      }

    public static new LeapYearLookupInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LeapYearLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LeapYearLookupInformationNugget", ignore_extras);
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
    public static new LeapYearLookupInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new LeapYearLookupInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LeapYearLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LeapYearLookupInformationNugget", ignore_extras);
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
    public static new LeapYearLookupInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new LeapYearLookupInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        LeapYearLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LeapYearLookupInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LeapYearLookupInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new LeapYearLookupInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LeapYearLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LeapYearLookupInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DateAndTimeInformationNuggetJSON.Generator
      {
    private class FieldHoldingGeneratorYear : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorYear(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorYear : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorYear(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorYear fieldGeneratorYear;
        private JSONHoldingBooleanGenerator fieldGeneratorIsLeapYear;
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
            if (!(getDateAndTimeInformationNuggetJSONKey().Equals("LeapYearLookup")))
                throw new Exception("The key field has a value other than `LeapYearLookup'.");
            LeapYearLookupInformationNuggetJSON result = new LeapYearLookupInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraLeapYearLookupInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DateAndTimeInformationNuggetJSON new_result)
          {
            handle_result((LeapYearLookupInformationNuggetJSON )new_result);
          }
        protected void finish(LeapYearLookupInformationNuggetJSON result)
          {
            if (fieldGeneratorYear.have_value)
              {
                result.setYear(fieldGeneratorYear.value);
                fieldGeneratorYear.have_value = false;
              }
            else if ((!(result.hasYear())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Year\" field was missing.");
              }
            if (fieldGeneratorIsLeapYear.have_value)
              {
                result.setIsLeapYear(fieldGeneratorIsLeapYear.value);
                fieldGeneratorIsLeapYear.have_value = false;
              }
            else if ((!(result.hasIsLeapYear())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsLeapYear\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(LeapYearLookupInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "sLeapYear", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorIsLeapYear;
                    break;
                case 'Y':
                    if ((String.Compare(field_name, 1, "ear", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorYear;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the LeapYearLookupInformationNugget class");
            fieldGeneratorIsLeapYear = new JSONHoldingBooleanGenerator("field \"IsLeapYear\" of the LeapYearLookupInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the LeapYearLookupInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the LeapYearLookupInformationNugget class");
            fieldGeneratorIsLeapYear = new JSONHoldingBooleanGenerator("field \"IsLeapYear\" of the LeapYearLookupInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the LeapYearLookupInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorYear.reset();
            fieldGeneratorIsLeapYear.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(LeapYearLookupInformationNuggetJSON  result)
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
        public LeapYearLookupInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LeapYearLookupInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<LeapYearLookupInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LeapYearLookupInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LeapYearLookupInformationNuggetJSON>();
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
    public List<LeapYearLookupInformationNuggetJSON> value;
  };
  };
