/* file "RadioPresetCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RadioPresetCommandJSON : RadioCommandJSON
  {
    private bool flagHasPresetNumber;
    private sbyte storePresetNumber;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraPresetNumberToJSON()
      {
        JSONIntegerValue generated_integer_PresetNumber = new JSONIntegerValue(storePresetNumber);
        return generated_integer_PresetNumber;
      }


    private void  fromJSONPresetNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PresetNumber of RadioPresetCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PresetNumber of RadioPresetCommandJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setPresetNumber(extracted_integer);
      }


    public RadioPresetCommandJSON()
      {
        flagHasPresetNumber = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRadioCommandKind()
      {
        return "RadioPreset";
      }

    public bool  hasPresetNumber()
      {
        return flagHasPresetNumber;
      }

    public sbyte  getPresetNumber()
      {
        Debug.Assert(flagHasPresetNumber);
        return storePresetNumber;
      }


    public virtual int extraRadioPresetCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRadioPresetCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRadioPresetCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRadioPresetCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRadioCommandComponentCount()
      {
        int result = 0;
        if (flagHasPresetNumber)
            ++result;
        result += extraRadioPresetCommandComponentCount();
        return result;
      }
    public override string extraRadioCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasPresetNumber)
          {
            if (remainder == 0)
                return "PresetNumber";
            --remainder;
          }
        return extraRadioPresetCommandComponentKey(remainder);
      }
    public override JSONValue extraRadioCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasPresetNumber)
          {
            if (remainder == 0)
                return extraPresetNumberToJSON();
            --remainder;
          }
        return extraRadioPresetCommandComponentValue(remainder);
      }
    public override JSONValue extraRadioCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "PresetNumber", 0, 12, false) == 0) && (field_name.Length == 12))
            return (flagHasPresetNumber ? extraPresetNumberToJSON() : null);
        return extraRadioPresetCommandLookup(field_name);
      }

    public void setPresetNumber(sbyte new_value)
      {
        flagHasPresetNumber = true;
        if (new_value < 1)
            throw new Exception("The value for field PresetNumber of RadioPresetCommandJSON is less than the lower bound (1) for that field.");
        if (new_value > 18)
            throw new Exception("The value for field PresetNumber of RadioPresetCommandJSON is greater than the upper bound (18) for that field.");
        storePresetNumber = new_value;
      }
    public void unsetPresetNumber()
      {
        flagHasPresetNumber = false;
      }

    public virtual void extraRadioPresetCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRadioPresetCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRadioPresetCommandLookup(key);
        if (old_field == null)
          {
            extraRadioPresetCommandAppendPair(key, new_component);
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
    public override void extraRadioCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "PresetNumber", 0, 12, false) == 0) && (key.Length == 12))
            {
            fromJSONPresetNumber(new_component, false);
            return;
            }
        extraRadioPresetCommandAppendPair(key, new_component);
      }
    public override void extraRadioCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "PresetNumber", 0, 12, false) == 0) && (key.Length == 12))
            {
            fromJSONPresetNumber(new_component, false);
            return;
            }
        extraRadioPresetCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPresetNumber);
        if (flagHasPresetNumber)
          {
            handler.start_pair("PresetNumber");
            handler.number_value(storePresetNumber);
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
        if (!(hasPresetNumber()))
          {
            return "When parsing the object for %what%, the \"PresetNumber\" field was missing.";
          }
        return null;
      }

    public static new RadioPresetCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioPresetCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioPresetCommand", ignore_extras);
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
    public static new RadioPresetCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RadioPresetCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioPresetCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioPresetCommand", ignore_extras);
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
    public static new RadioPresetCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RadioPresetCommandJSON from_text(string text, bool ignore_extras)
      {
        RadioPresetCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioPresetCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RadioPresetCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RadioPresetCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RadioPresetCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioPresetCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RadioCommandJSON.Generator
      {
    private class FieldHoldingGeneratorPresetNumber : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorPresetNumber(String what) : base(what, 1, 18)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPresetNumber : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPresetNumber(String what) : base(what, 1, 18)
              {
              }
          };
        private FieldHoldingGeneratorPresetNumber fieldGeneratorPresetNumber;
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
            if (!(getRadioCommandJSONKey().Equals("RadioPreset")))
                throw new Exception("The key field has a value other than `RadioPreset'.");
            RadioPresetCommandJSON result = new RadioPresetCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRadioPresetCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RadioCommandJSON new_result)
          {
            handle_result((RadioPresetCommandJSON )new_result);
          }
        protected void finish(RadioPresetCommandJSON result)
          {
            if (fieldGeneratorPresetNumber.have_value)
              {
                result.setPresetNumber((sbyte)(fieldGeneratorPresetNumber.value));
                fieldGeneratorPresetNumber.have_value = false;
              }
            else if ((!(result.hasPresetNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PresetNumber\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RadioPresetCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "PresetNumber", 0, 12, false) == 0) && (field_name.Length == 12))
                return fieldGeneratorPresetNumber;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorPresetNumber = new FieldHoldingGeneratorPresetNumber("field \"PresetNumber\" of the RadioPresetCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RadioPresetCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorPresetNumber = new FieldHoldingGeneratorPresetNumber("field \"PresetNumber\" of the RadioPresetCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RadioPresetCommand class");
          }

        public override void reset()
          {
            fieldGeneratorPresetNumber.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RadioPresetCommandJSON  result)
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
        public RadioPresetCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RadioPresetCommandJSON  result)
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
    protected virtual void handle_result(List<RadioPresetCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RadioPresetCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RadioPresetCommandJSON>();
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
    public List<RadioPresetCommandJSON> value;
  };
  };
