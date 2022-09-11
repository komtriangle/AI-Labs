/* file "HomeAutomationSetBrightnessDeltaCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationSetBrightnessDeltaCommandJSON : HomeAutomationControlCommandJSON
  {
    private bool flagHasBrightnessDelta;
    private double storeBrightnessDelta;
    private string textStoreBrightnessDelta;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraBrightnessDeltaToJSON()
      {
        JSONValue generated_rational_BrightnessDelta;
        if (textStoreBrightnessDelta != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreBrightnessDelta);
            generated_rational_BrightnessDelta = handler.result;
          }
        else if (((double)(long)storeBrightnessDelta) == storeBrightnessDelta)
            generated_rational_BrightnessDelta = new JSONIntegerValue((long)(storeBrightnessDelta));
        else
            generated_rational_BrightnessDelta = new JSONRationalValue(storeBrightnessDelta, 15);
        return generated_rational_BrightnessDelta;
      }


    private void  fromJSONBrightnessDelta(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field BrightnessDelta of HomeAutomationSetBrightnessDeltaCommandJSON is not a number.");
              }
          }
        setBrightnessDeltaText(the_rational_text);
      }


    public HomeAutomationSetBrightnessDeltaCommandJSON()
      {
        flagHasBrightnessDelta = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getHomeAutomationControlCommandKind()
      {
        return "HomeAutomationSetBrightnessDeltaCommand";
      }

    public bool  hasBrightnessDelta()
      {
        return flagHasBrightnessDelta;
      }

    public double  getBrightnessDelta()
      {
        Debug.Assert(flagHasBrightnessDelta);
        if (textStoreBrightnessDelta != "")
          {
            return Double.Parse(textStoreBrightnessDelta);
          }
        return storeBrightnessDelta;
      }

    public string  getBrightnessDeltaAsText()
      {
        Debug.Assert(flagHasBrightnessDelta);
        if (textStoreBrightnessDelta == "")
          {
            return Convert.ToString(storeBrightnessDelta);
          }
        else
          {
            return (textStoreBrightnessDelta);
          }
      }


    public virtual int extraHomeAutomationSetBrightnessDeltaCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationSetBrightnessDeltaCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationSetBrightnessDeltaCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationSetBrightnessDeltaCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraHomeAutomationControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasBrightnessDelta)
            ++result;
        result += extraHomeAutomationSetBrightnessDeltaCommandComponentCount();
        return result;
      }
    public override string extraHomeAutomationControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasBrightnessDelta)
          {
            if (remainder == 0)
                return "BrightnessDelta";
            --remainder;
          }
        return extraHomeAutomationSetBrightnessDeltaCommandComponentKey(remainder);
      }
    public override JSONValue extraHomeAutomationControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasBrightnessDelta)
          {
            if (remainder == 0)
                return extraBrightnessDeltaToJSON();
            --remainder;
          }
        return extraHomeAutomationSetBrightnessDeltaCommandComponentValue(remainder);
      }
    public override JSONValue extraHomeAutomationControlCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "BrightnessDelta", 0, 15, false) == 0) && (field_name.Length == 15))
            return (flagHasBrightnessDelta ? extraBrightnessDeltaToJSON() : null);
        return extraHomeAutomationSetBrightnessDeltaCommandLookup(field_name);
      }

    public void setBrightnessDelta(double new_value)
      {
        flagHasBrightnessDelta = true;
        if (new_value < -1)
            throw new Exception("The value for field BrightnessDelta of HomeAutomationSetBrightnessDeltaCommandJSON is less than the lower bound (-1) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field BrightnessDelta of HomeAutomationSetBrightnessDeltaCommandJSON is greater than the upper bound (1) for that field.");
        storeBrightnessDelta = new_value;
        textStoreBrightnessDelta = "";
      }
    public void setBrightnessDeltaText(string new_value)
      {
        flagHasBrightnessDelta = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field BrightnessDelta of HomeAutomationSetBrightnessDeltaCommandJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "1", "", false, "1") < 0)
            throw new Exception("The value for field BrightnessDelta of HomeAutomationSetBrightnessDeltaCommandJSON is less than the lower bound (-1) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field BrightnessDelta of HomeAutomationSetBrightnessDeltaCommandJSON is greater than the upper bound (1) for that field.");
        textStoreBrightnessDelta = new_value;
      }
    public void unsetBrightnessDelta()
      {
        flagHasBrightnessDelta = false;
      }

    public virtual void extraHomeAutomationSetBrightnessDeltaCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationSetBrightnessDeltaCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationSetBrightnessDeltaCommandLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationSetBrightnessDeltaCommandAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "BrightnessDelta", 0, 15, false) == 0) && (key.Length == 15))
            {
            fromJSONBrightnessDelta(new_component, false);
            return;
            }
        extraHomeAutomationSetBrightnessDeltaCommandAppendPair(key, new_component);
      }
    public override void extraHomeAutomationControlCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "BrightnessDelta", 0, 15, false) == 0) && (key.Length == 15))
            {
            fromJSONBrightnessDelta(new_component, false);
            return;
            }
        extraHomeAutomationSetBrightnessDeltaCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasBrightnessDelta);
        if (flagHasBrightnessDelta)
          {
            handler.start_pair("BrightnessDelta");
            if (textStoreBrightnessDelta != "")
                handler.number_value(textStoreBrightnessDelta);
            else if (((double)(long)storeBrightnessDelta) == storeBrightnessDelta)
                handler.number_value((long)storeBrightnessDelta);
            else
                handler.number_value(storeBrightnessDelta);
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
        if (!(hasBrightnessDelta()))
          {
            return "When parsing the object for %what%, the \"BrightnessDelta\" field was missing.";
          }
        return null;
      }

    public static new HomeAutomationSetBrightnessDeltaCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationSetBrightnessDeltaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationSetBrightnessDeltaCommand", ignore_extras);
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
    public static new HomeAutomationSetBrightnessDeltaCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationSetBrightnessDeltaCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationSetBrightnessDeltaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationSetBrightnessDeltaCommand", ignore_extras);
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
    public static new HomeAutomationSetBrightnessDeltaCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationSetBrightnessDeltaCommandJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationSetBrightnessDeltaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationSetBrightnessDeltaCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationSetBrightnessDeltaCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HomeAutomationSetBrightnessDeltaCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationSetBrightnessDeltaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationSetBrightnessDeltaCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : HomeAutomationControlCommandJSON.Generator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorBrightnessDelta;
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
            if (!(getHomeAutomationControlCommandJSONKey().Equals("HomeAutomationSetBrightnessDeltaCommand")))
                throw new Exception("The key field has a value other than `HomeAutomationSetBrightnessDeltaCommand'.");
            HomeAutomationSetBrightnessDeltaCommandJSON result = new HomeAutomationSetBrightnessDeltaCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationSetBrightnessDeltaCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(HomeAutomationControlCommandJSON new_result)
          {
            handle_result((HomeAutomationSetBrightnessDeltaCommandJSON )new_result);
          }
        protected void finish(HomeAutomationSetBrightnessDeltaCommandJSON result)
          {
            if (fieldGeneratorBrightnessDelta.have_value)
              {
                result.setBrightnessDeltaText(fieldGeneratorBrightnessDelta.value);
                fieldGeneratorBrightnessDelta.have_value = false;
              }
            else if ((!(result.hasBrightnessDelta())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"BrightnessDelta\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(HomeAutomationSetBrightnessDeltaCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "BrightnessDelta", 0, 15, false) == 0) && (field_name.Length == 15))
                return fieldGeneratorBrightnessDelta;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorBrightnessDelta = new JSONHoldingNumberTextGenerator("field \"BrightnessDelta\" of the HomeAutomationSetBrightnessDeltaCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationSetBrightnessDeltaCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorBrightnessDelta = new JSONHoldingNumberTextGenerator("field \"BrightnessDelta\" of the HomeAutomationSetBrightnessDeltaCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationSetBrightnessDeltaCommand class");
          }

        public override void reset()
          {
            fieldGeneratorBrightnessDelta.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationSetBrightnessDeltaCommandJSON  result)
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
        public HomeAutomationSetBrightnessDeltaCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationSetBrightnessDeltaCommandJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationSetBrightnessDeltaCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationSetBrightnessDeltaCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationSetBrightnessDeltaCommandJSON>();
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
    public List<HomeAutomationSetBrightnessDeltaCommandJSON> value;
  };
  };
