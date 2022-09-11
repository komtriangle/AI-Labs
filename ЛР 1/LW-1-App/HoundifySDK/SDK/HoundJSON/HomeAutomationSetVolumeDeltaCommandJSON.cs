/* file "HomeAutomationSetVolumeDeltaCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationSetVolumeDeltaCommandJSON : HomeAutomationControlCommandJSON
  {
    private bool flagHasVolumeDelta;
    private double storeVolumeDelta;
    private string textStoreVolumeDelta;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraVolumeDeltaToJSON()
      {
        JSONValue generated_rational_VolumeDelta;
        if (textStoreVolumeDelta != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreVolumeDelta);
            generated_rational_VolumeDelta = handler.result;
          }
        else if (((double)(long)storeVolumeDelta) == storeVolumeDelta)
            generated_rational_VolumeDelta = new JSONIntegerValue((long)(storeVolumeDelta));
        else
            generated_rational_VolumeDelta = new JSONRationalValue(storeVolumeDelta, 15);
        return generated_rational_VolumeDelta;
      }


    private void  fromJSONVolumeDelta(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field VolumeDelta of HomeAutomationSetVolumeDeltaCommandJSON is not a number.");
              }
          }
        setVolumeDeltaText(the_rational_text);
      }


    public HomeAutomationSetVolumeDeltaCommandJSON()
      {
        flagHasVolumeDelta = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getHomeAutomationControlCommandKind()
      {
        return "HomeAutomationSetVolumeDeltaCommand";
      }

    public bool  hasVolumeDelta()
      {
        return flagHasVolumeDelta;
      }

    public double  getVolumeDelta()
      {
        Debug.Assert(flagHasVolumeDelta);
        if (textStoreVolumeDelta != "")
          {
            return Double.Parse(textStoreVolumeDelta);
          }
        return storeVolumeDelta;
      }

    public string  getVolumeDeltaAsText()
      {
        Debug.Assert(flagHasVolumeDelta);
        if (textStoreVolumeDelta == "")
          {
            return Convert.ToString(storeVolumeDelta);
          }
        else
          {
            return (textStoreVolumeDelta);
          }
      }


    public virtual int extraHomeAutomationSetVolumeDeltaCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationSetVolumeDeltaCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationSetVolumeDeltaCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationSetVolumeDeltaCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraHomeAutomationControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasVolumeDelta)
            ++result;
        result += extraHomeAutomationSetVolumeDeltaCommandComponentCount();
        return result;
      }
    public override string extraHomeAutomationControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasVolumeDelta)
          {
            if (remainder == 0)
                return "VolumeDelta";
            --remainder;
          }
        return extraHomeAutomationSetVolumeDeltaCommandComponentKey(remainder);
      }
    public override JSONValue extraHomeAutomationControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasVolumeDelta)
          {
            if (remainder == 0)
                return extraVolumeDeltaToJSON();
            --remainder;
          }
        return extraHomeAutomationSetVolumeDeltaCommandComponentValue(remainder);
      }
    public override JSONValue extraHomeAutomationControlCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "VolumeDelta", 0, 11, false) == 0) && (field_name.Length == 11))
            return (flagHasVolumeDelta ? extraVolumeDeltaToJSON() : null);
        return extraHomeAutomationSetVolumeDeltaCommandLookup(field_name);
      }

    public void setVolumeDelta(double new_value)
      {
        flagHasVolumeDelta = true;
        if (new_value < -1)
            throw new Exception("The value for field VolumeDelta of HomeAutomationSetVolumeDeltaCommandJSON is less than the lower bound (-1) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field VolumeDelta of HomeAutomationSetVolumeDeltaCommandJSON is greater than the upper bound (1) for that field.");
        storeVolumeDelta = new_value;
        textStoreVolumeDelta = "";
      }
    public void setVolumeDeltaText(string new_value)
      {
        flagHasVolumeDelta = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field VolumeDelta of HomeAutomationSetVolumeDeltaCommandJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "1", "", false, "1") < 0)
            throw new Exception("The value for field VolumeDelta of HomeAutomationSetVolumeDeltaCommandJSON is less than the lower bound (-1) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field VolumeDelta of HomeAutomationSetVolumeDeltaCommandJSON is greater than the upper bound (1) for that field.");
        textStoreVolumeDelta = new_value;
      }
    public void unsetVolumeDelta()
      {
        flagHasVolumeDelta = false;
      }

    public virtual void extraHomeAutomationSetVolumeDeltaCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationSetVolumeDeltaCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationSetVolumeDeltaCommandLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationSetVolumeDeltaCommandAppendPair(key, new_component);
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
    public override void extraHomeAutomationControlCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "VolumeDelta", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONVolumeDelta(new_component, false);
            return;
            }
        extraHomeAutomationSetVolumeDeltaCommandAppendPair(key, new_component);
      }
    public override void extraHomeAutomationControlCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "VolumeDelta", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONVolumeDelta(new_component, false);
            return;
            }
        extraHomeAutomationSetVolumeDeltaCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasVolumeDelta);
        if (flagHasVolumeDelta)
          {
            handler.start_pair("VolumeDelta");
            if (textStoreVolumeDelta != "")
                handler.number_value(textStoreVolumeDelta);
            else if (((double)(long)storeVolumeDelta) == storeVolumeDelta)
                handler.number_value((long)storeVolumeDelta);
            else
                handler.number_value(storeVolumeDelta);
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
        if (!(hasVolumeDelta()))
          {
            return "When parsing the object for %what%, the \"VolumeDelta\" field was missing.";
          }
        return null;
      }

    public static new HomeAutomationSetVolumeDeltaCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationSetVolumeDeltaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationSetVolumeDeltaCommand", ignore_extras);
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
    public static new HomeAutomationSetVolumeDeltaCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationSetVolumeDeltaCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationSetVolumeDeltaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationSetVolumeDeltaCommand", ignore_extras);
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
    public static new HomeAutomationSetVolumeDeltaCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationSetVolumeDeltaCommandJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationSetVolumeDeltaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationSetVolumeDeltaCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationSetVolumeDeltaCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HomeAutomationSetVolumeDeltaCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationSetVolumeDeltaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationSetVolumeDeltaCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : HomeAutomationControlCommandJSON.Generator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorVolumeDelta;
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
            if (!(getHomeAutomationControlCommandJSONKey().Equals("HomeAutomationSetVolumeDeltaCommand")))
                throw new Exception("The key field has a value other than `HomeAutomationSetVolumeDeltaCommand'.");
            HomeAutomationSetVolumeDeltaCommandJSON result = new HomeAutomationSetVolumeDeltaCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationSetVolumeDeltaCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(HomeAutomationControlCommandJSON new_result)
          {
            handle_result((HomeAutomationSetVolumeDeltaCommandJSON )new_result);
          }
        protected void finish(HomeAutomationSetVolumeDeltaCommandJSON result)
          {
            if (fieldGeneratorVolumeDelta.have_value)
              {
                result.setVolumeDeltaText(fieldGeneratorVolumeDelta.value);
                fieldGeneratorVolumeDelta.have_value = false;
              }
            else if ((!(result.hasVolumeDelta())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"VolumeDelta\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(HomeAutomationSetVolumeDeltaCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "VolumeDelta", 0, 11, false) == 0) && (field_name.Length == 11))
                return fieldGeneratorVolumeDelta;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorVolumeDelta = new JSONHoldingNumberTextGenerator("field \"VolumeDelta\" of the HomeAutomationSetVolumeDeltaCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationSetVolumeDeltaCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorVolumeDelta = new JSONHoldingNumberTextGenerator("field \"VolumeDelta\" of the HomeAutomationSetVolumeDeltaCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationSetVolumeDeltaCommand class");
          }

        public override void reset()
          {
            fieldGeneratorVolumeDelta.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationSetVolumeDeltaCommandJSON  result)
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
        public HomeAutomationSetVolumeDeltaCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationSetVolumeDeltaCommandJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationSetVolumeDeltaCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationSetVolumeDeltaCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationSetVolumeDeltaCommandJSON>();
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
    public List<HomeAutomationSetVolumeDeltaCommandJSON> value;
  };
  };
