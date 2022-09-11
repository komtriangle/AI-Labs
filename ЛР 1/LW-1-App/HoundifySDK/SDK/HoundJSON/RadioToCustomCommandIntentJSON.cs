/* file "RadioToCustomCommandIntentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RadioToCustomCommandIntentJSON : RadioCommandIntentJSON
  {
    private bool flagHasSource;
    private string storeSource;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSourceToJSON()
      {
        JSONStringValue generated_string_Source = new JSONStringValue(storeSource);
        return generated_string_Source;
      }


    private void  fromJSONSource(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Source of RadioToCustomCommandIntentJSON is not a string.");
        setSource(json_string.getData());
      }


    public RadioToCustomCommandIntentJSON()
      {
        flagHasSource = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRadioIntentKind()
      {
        return "RadioToCustom";
      }

    public bool  hasSource()
      {
        return flagHasSource;
      }

    public string  getSource()
      {
        Debug.Assert(flagHasSource);
        return storeSource;
      }


    public virtual int extraRadioToCustomCommandIntentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRadioToCustomCommandIntentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRadioToCustomCommandIntentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRadioToCustomCommandIntentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRadioCommandIntentComponentCount()
      {
        int result = 0;
        if (flagHasSource)
            ++result;
        result += extraRadioToCustomCommandIntentComponentCount();
        return result;
      }
    public override string extraRadioCommandIntentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSource)
          {
            if (remainder == 0)
                return "Source";
            --remainder;
          }
        return extraRadioToCustomCommandIntentComponentKey(remainder);
      }
    public override JSONValue extraRadioCommandIntentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSource)
          {
            if (remainder == 0)
                return extraSourceToJSON();
            --remainder;
          }
        return extraRadioToCustomCommandIntentComponentValue(remainder);
      }
    public override JSONValue extraRadioCommandIntentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Source", 0, 6, false) == 0) && (field_name.Length == 6))
            return (flagHasSource ? extraSourceToJSON() : null);
        return extraRadioToCustomCommandIntentLookup(field_name);
      }

    public void setSource(string new_value)
      {
        flagHasSource = true;
        storeSource = new_value;
      }
    public void unsetSource()
      {
        flagHasSource = false;
      }

    public virtual void extraRadioToCustomCommandIntentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRadioToCustomCommandIntentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRadioToCustomCommandIntentLookup(key);
        if (old_field == null)
          {
            extraRadioToCustomCommandIntentAppendPair(key, new_component);
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
    public override void extraRadioCommandIntentAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Source", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONSource(new_component, false);
            return;
            }
        extraRadioToCustomCommandIntentAppendPair(key, new_component);
      }
    public override void extraRadioCommandIntentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Source", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONSource(new_component, false);
            return;
            }
        extraRadioToCustomCommandIntentSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSource);
        if (flagHasSource)
          {
            handler.start_pair("Source");
            handler.string_value(storeSource);
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
        if (!(hasSource()))
          {
            return "When parsing the object for %what%, the \"Source\" field was missing.";
          }
        return null;
      }

    public static new RadioToCustomCommandIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioToCustomCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioToCustomCommandIntent", ignore_extras);
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
    public static new RadioToCustomCommandIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RadioToCustomCommandIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioToCustomCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioToCustomCommandIntent", ignore_extras);
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
    public static new RadioToCustomCommandIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RadioToCustomCommandIntentJSON from_text(string text, bool ignore_extras)
      {
        RadioToCustomCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioToCustomCommandIntent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RadioToCustomCommandIntentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RadioToCustomCommandIntentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RadioToCustomCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioToCustomCommandIntent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RadioCommandIntentJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorSource;
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
            if (!(getRadioCommandIntentJSONKey().Equals("RadioToCustom")))
                throw new Exception("The key field has a value other than `RadioToCustom'.");
            RadioToCustomCommandIntentJSON result = new RadioToCustomCommandIntentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRadioToCustomCommandIntentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RadioCommandIntentJSON new_result)
          {
            handle_result((RadioToCustomCommandIntentJSON )new_result);
          }
        protected void finish(RadioToCustomCommandIntentJSON result)
          {
            if (fieldGeneratorSource.have_value)
              {
                result.setSource(fieldGeneratorSource.value);
                fieldGeneratorSource.have_value = false;
              }
            else if ((!(result.hasSource())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Source\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RadioToCustomCommandIntentJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Source", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorSource;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSource = new JSONHoldingStringGenerator("field \"Source\" of the RadioToCustomCommandIntent class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RadioToCustomCommandIntent class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSource = new JSONHoldingStringGenerator("field \"Source\" of the RadioToCustomCommandIntent class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RadioToCustomCommandIntent class");
          }

        public override void reset()
          {
            fieldGeneratorSource.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RadioToCustomCommandIntentJSON  result)
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
        public RadioToCustomCommandIntentJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RadioToCustomCommandIntentJSON  result)
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
    protected virtual void handle_result(List<RadioToCustomCommandIntentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RadioToCustomCommandIntentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RadioToCustomCommandIntentJSON>();
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
    public List<RadioToCustomCommandIntentJSON> value;
  };
  };
