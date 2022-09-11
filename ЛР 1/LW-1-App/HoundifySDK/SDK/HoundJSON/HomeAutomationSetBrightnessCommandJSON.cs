/* file "HomeAutomationSetBrightnessCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationSetBrightnessCommandJSON : HomeAutomationControlCommandJSON
  {
    private bool flagHasBrightness;
    private double storeBrightness;
    private string textStoreBrightness;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraBrightnessToJSON()
      {
        JSONValue generated_rational_Brightness;
        if (textStoreBrightness != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreBrightness);
            generated_rational_Brightness = handler.result;
          }
        else if (((double)(long)storeBrightness) == storeBrightness)
            generated_rational_Brightness = new JSONIntegerValue((long)(storeBrightness));
        else
            generated_rational_Brightness = new JSONRationalValue(storeBrightness, 15);
        return generated_rational_Brightness;
      }


    private void  fromJSONBrightness(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Brightness of HomeAutomationSetBrightnessCommandJSON is not a number.");
              }
          }
        setBrightnessText(the_rational_text);
      }


    public HomeAutomationSetBrightnessCommandJSON()
      {
        flagHasBrightness = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getHomeAutomationControlCommandKind()
      {
        return "HomeAutomationSetBrightnessCommand";
      }

    public bool  hasBrightness()
      {
        return flagHasBrightness;
      }

    public double  getBrightness()
      {
        Debug.Assert(flagHasBrightness);
        if (textStoreBrightness != "")
          {
            return Double.Parse(textStoreBrightness);
          }
        return storeBrightness;
      }

    public string  getBrightnessAsText()
      {
        Debug.Assert(flagHasBrightness);
        if (textStoreBrightness == "")
          {
            return Convert.ToString(storeBrightness);
          }
        else
          {
            return (textStoreBrightness);
          }
      }


    public virtual int extraHomeAutomationSetBrightnessCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationSetBrightnessCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationSetBrightnessCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationSetBrightnessCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraHomeAutomationControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasBrightness)
            ++result;
        result += extraHomeAutomationSetBrightnessCommandComponentCount();
        return result;
      }
    public override string extraHomeAutomationControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasBrightness)
          {
            if (remainder == 0)
                return "Brightness";
            --remainder;
          }
        return extraHomeAutomationSetBrightnessCommandComponentKey(remainder);
      }
    public override JSONValue extraHomeAutomationControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasBrightness)
          {
            if (remainder == 0)
                return extraBrightnessToJSON();
            --remainder;
          }
        return extraHomeAutomationSetBrightnessCommandComponentValue(remainder);
      }
    public override JSONValue extraHomeAutomationControlCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Brightness", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasBrightness ? extraBrightnessToJSON() : null);
        return extraHomeAutomationSetBrightnessCommandLookup(field_name);
      }

    public void setBrightness(double new_value)
      {
        flagHasBrightness = true;
        if (new_value < 0)
            throw new Exception("The value for field Brightness of HomeAutomationSetBrightnessCommandJSON is less than the lower bound (0) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field Brightness of HomeAutomationSetBrightnessCommandJSON is greater than the upper bound (1) for that field.");
        storeBrightness = new_value;
        textStoreBrightness = "";
      }
    public void setBrightnessText(string new_value)
      {
        flagHasBrightness = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Brightness of HomeAutomationSetBrightnessCommandJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Brightness of HomeAutomationSetBrightnessCommandJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field Brightness of HomeAutomationSetBrightnessCommandJSON is greater than the upper bound (1) for that field.");
        textStoreBrightness = new_value;
      }
    public void unsetBrightness()
      {
        flagHasBrightness = false;
      }

    public virtual void extraHomeAutomationSetBrightnessCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationSetBrightnessCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationSetBrightnessCommandLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationSetBrightnessCommandAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "Brightness", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONBrightness(new_component, false);
            return;
            }
        extraHomeAutomationSetBrightnessCommandAppendPair(key, new_component);
      }
    public override void extraHomeAutomationControlCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Brightness", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONBrightness(new_component, false);
            return;
            }
        extraHomeAutomationSetBrightnessCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasBrightness);
        if (flagHasBrightness)
          {
            handler.start_pair("Brightness");
            if (textStoreBrightness != "")
                handler.number_value(textStoreBrightness);
            else if (((double)(long)storeBrightness) == storeBrightness)
                handler.number_value((long)storeBrightness);
            else
                handler.number_value(storeBrightness);
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
        if (!(hasBrightness()))
          {
            return "When parsing the object for %what%, the \"Brightness\" field was missing.";
          }
        return null;
      }

    public static new HomeAutomationSetBrightnessCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationSetBrightnessCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationSetBrightnessCommand", ignore_extras);
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
    public static new HomeAutomationSetBrightnessCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationSetBrightnessCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationSetBrightnessCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationSetBrightnessCommand", ignore_extras);
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
    public static new HomeAutomationSetBrightnessCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationSetBrightnessCommandJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationSetBrightnessCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationSetBrightnessCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationSetBrightnessCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HomeAutomationSetBrightnessCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationSetBrightnessCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationSetBrightnessCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : HomeAutomationControlCommandJSON.Generator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorBrightness;
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
            if (!(getHomeAutomationControlCommandJSONKey().Equals("HomeAutomationSetBrightnessCommand")))
                throw new Exception("The key field has a value other than `HomeAutomationSetBrightnessCommand'.");
            HomeAutomationSetBrightnessCommandJSON result = new HomeAutomationSetBrightnessCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationSetBrightnessCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(HomeAutomationControlCommandJSON new_result)
          {
            handle_result((HomeAutomationSetBrightnessCommandJSON )new_result);
          }
        protected void finish(HomeAutomationSetBrightnessCommandJSON result)
          {
            if (fieldGeneratorBrightness.have_value)
              {
                result.setBrightnessText(fieldGeneratorBrightness.value);
                fieldGeneratorBrightness.have_value = false;
              }
            else if ((!(result.hasBrightness())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Brightness\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(HomeAutomationSetBrightnessCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Brightness", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorBrightness;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorBrightness = new JSONHoldingNumberTextGenerator("field \"Brightness\" of the HomeAutomationSetBrightnessCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationSetBrightnessCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorBrightness = new JSONHoldingNumberTextGenerator("field \"Brightness\" of the HomeAutomationSetBrightnessCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationSetBrightnessCommand class");
          }

        public override void reset()
          {
            fieldGeneratorBrightness.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationSetBrightnessCommandJSON  result)
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
        public HomeAutomationSetBrightnessCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationSetBrightnessCommandJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationSetBrightnessCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationSetBrightnessCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationSetBrightnessCommandJSON>();
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
    public List<HomeAutomationSetBrightnessCommandJSON> value;
  };
  };
