/* file "CustomSpeechRecognitionPatternsWeightJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CustomSpeechRecognitionPatternsWeightJSON : JSONBase
  {
    private bool flagHasValue;
    private double storeValue;
    private string textStoreValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Value of CustomSpeechRecognitionPatternsWeightJSON is not a number.");
              }
          }
        setValueText(the_rational_text);
      }


    public CustomSpeechRecognitionPatternsWeightJSON()
      {
        flagHasValue = false;
      }

    public CustomSpeechRecognitionPatternsWeightJSON(double init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public double  getValue()
      {
        Debug.Assert(flagHasValue);
        if (textStoreValue != "")
          {
            return Double.Parse(textStoreValue);
          }
        return storeValue;
      }

    public string  getValueAsText()
      {
        Debug.Assert(flagHasValue);
        if (textStoreValue == "")
          {
            return Convert.ToString(storeValue);
          }
        else
          {
            return (textStoreValue);
          }
      }



    public void setValue(double new_value)
      {
        flagHasValue = true;
        if (new_value < 0)
            throw new Exception("The value for field Value of CustomSpeechRecognitionPatternsWeightJSON is less than the lower bound (0) for that field.");
        storeValue = new_value;
        textStoreValue = "";
      }
    public void setValueText(string new_value)
      {
        flagHasValue = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Value of CustomSpeechRecognitionPatternsWeightJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Value of CustomSpeechRecognitionPatternsWeightJSON is less than the lower bound (0) for that field.");
        textStoreValue = new_value;
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        if (textStoreValue != "")
            handler.number_value(textStoreValue);
        else if (((double)(long)storeValue) == storeValue)
            handler.number_value((long)storeValue);
        else
            handler.number_value(storeValue);
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        if (textStoreValue != "")
            handler.number_value(textStoreValue);
        else if (((double)(long)storeValue) == storeValue)
            handler.number_value((long)storeValue);
        else
            handler.number_value(storeValue);
      }

    public static CustomSpeechRecognitionPatternsWeightJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CustomSpeechRecognitionPatternsWeightJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomSpeechRecognitionPatternsWeight", ignore_extras);
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
    public static CustomSpeechRecognitionPatternsWeightJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CustomSpeechRecognitionPatternsWeightJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CustomSpeechRecognitionPatternsWeightJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomSpeechRecognitionPatternsWeight", ignore_extras);
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
    public static CustomSpeechRecognitionPatternsWeightJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CustomSpeechRecognitionPatternsWeightJSON from_text(string text, bool ignore_extras)
      {
        CustomSpeechRecognitionPatternsWeightJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomSpeechRecognitionPatternsWeight", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CustomSpeechRecognitionPatternsWeightJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CustomSpeechRecognitionPatternsWeightJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CustomSpeechRecognitionPatternsWeightJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomSpeechRecognitionPatternsWeight", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONNumberTextGenerator
      {
        protected override void handle_result(string  new_value)
          {
            CustomSpeechRecognitionPatternsWeightJSON result = new CustomSpeechRecognitionPatternsWeightJSON();
            result.setValueText(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(CustomSpeechRecognitionPatternsWeightJSON new_result);
        public Generator(bool ignore_extras) : base("Type CustomSpeechRecognitionPatternsWeight")
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CustomSpeechRecognitionPatternsWeightJSON  result)
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
        public CustomSpeechRecognitionPatternsWeightJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CustomSpeechRecognitionPatternsWeightJSON  result)
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
    protected virtual void handle_result(List<CustomSpeechRecognitionPatternsWeightJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CustomSpeechRecognitionPatternsWeightJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CustomSpeechRecognitionPatternsWeightJSON>();
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
    public List<CustomSpeechRecognitionPatternsWeightJSON> value;
  };
  };
