/* file "MoneyJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MoneyJSON : JSONBase
  {
    private bool flagHasCode;
    private string storeCode;
    private bool flagHasSymbol;
    private string storeSymbol;
    private bool flagHasAmount;
    private double storeAmount;
    private string textStoreAmount;


    private void  fromJSONCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Code of MoneyJSON is not a string.");
        setCode(json_string.getData());
      }


    private void  fromJSONSymbol(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Symbol of MoneyJSON is not a string.");
        setSymbol(json_string.getData());
      }


    private void  fromJSONAmount(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Amount of MoneyJSON is not a number.");
              }
          }
        setAmountText(the_rational_text);
      }


    public MoneyJSON()
      {
        flagHasCode = false;
        flagHasSymbol = false;
        flagHasAmount = false;
      }

    public bool  hasCode()
      {
        return flagHasCode;
      }

    public string  getCode()
      {
        Debug.Assert(flagHasCode);
        return storeCode;
      }

    public bool  hasSymbol()
      {
        return flagHasSymbol;
      }

    public string  getSymbol()
      {
        Debug.Assert(flagHasSymbol);
        return storeSymbol;
      }

    public bool  hasAmount()
      {
        return flagHasAmount;
      }

    public double  getAmount()
      {
        Debug.Assert(flagHasAmount);
        if (textStoreAmount != "")
          {
            return Double.Parse(textStoreAmount);
          }
        return storeAmount;
      }

    public string  getAmountAsText()
      {
        Debug.Assert(flagHasAmount);
        if (textStoreAmount == "")
          {
            return Convert.ToString(storeAmount);
          }
        else
          {
            return (textStoreAmount);
          }
      }



    public void setCode(string new_value)
      {
        flagHasCode = true;
        storeCode = new_value;
      }
    public void unsetCode()
      {
        flagHasCode = false;
      }
    public void setSymbol(string new_value)
      {
        flagHasSymbol = true;
        storeSymbol = new_value;
      }
    public void unsetSymbol()
      {
        flagHasSymbol = false;
      }
    public void setAmount(double new_value)
      {
        flagHasAmount = true;
        storeAmount = new_value;
        textStoreAmount = "";
      }
    public void setAmountText(string new_value)
      {
        flagHasAmount = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Amount of MoneyJSON is not a valid number.");
        textStoreAmount = new_value;
      }
    public void unsetAmount()
      {
        flagHasAmount = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        Debug.Assert(partial_allowed || flagHasCode);
        if (flagHasCode)
          {
            handler.start_pair("Code");
            handler.string_value(storeCode);
          }
        Debug.Assert(partial_allowed || flagHasSymbol);
        if (flagHasSymbol)
          {
            handler.start_pair("Symbol");
            handler.string_value(storeSymbol);
          }
        Debug.Assert(partial_allowed || flagHasAmount);
        if (flagHasAmount)
          {
            handler.start_pair("Amount");
            if (textStoreAmount != "")
                handler.number_value(textStoreAmount);
            else if (((double)(long)storeAmount) == storeAmount)
                handler.number_value((long)storeAmount);
            else
                handler.number_value(storeAmount);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasCode()))
          {
            return "When parsing the object for %what%, the \"Code\" field was missing.";
          }
        if (!(hasSymbol()))
          {
            return "When parsing the object for %what%, the \"Symbol\" field was missing.";
          }
        if (!(hasAmount()))
          {
            return "When parsing the object for %what%, the \"Amount\" field was missing.";
          }
        return null;
      }

    public static MoneyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MoneyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Money", ignore_extras);
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
    public static MoneyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MoneyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MoneyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Money", ignore_extras);
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
    public static MoneyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MoneyJSON from_text(string text, bool ignore_extras)
      {
        MoneyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Money", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MoneyJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MoneyJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MoneyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Money", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorCode;
        private JSONHoldingStringGenerator fieldGeneratorSymbol;
        private JSONHoldingNumberTextGenerator fieldGeneratorAmount;

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
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            MoneyJSON result = new MoneyJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MoneyJSON result)
          {
            if (fieldGeneratorCode.have_value)
              {
                result.setCode(fieldGeneratorCode.value);
                fieldGeneratorCode.have_value = false;
              }
            else if ((!(result.hasCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Code\" field was missing.");
              }
            if (fieldGeneratorSymbol.have_value)
              {
                result.setSymbol(fieldGeneratorSymbol.value);
                fieldGeneratorSymbol.have_value = false;
              }
            else if ((!(result.hasSymbol())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Symbol\" field was missing.");
              }
            if (fieldGeneratorAmount.have_value)
              {
                result.setAmountText(fieldGeneratorAmount.value);
                fieldGeneratorAmount.have_value = false;
              }
            else if ((!(result.hasAmount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Amount\" field was missing.");
              }
          }
        protected abstract void handle_result(MoneyJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "mount", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorAmount;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "ode", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorCode;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ymbol", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorSymbol;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCode = new JSONHoldingStringGenerator("field \"Code\" of the Money class");
            fieldGeneratorSymbol = new JSONHoldingStringGenerator("field \"Symbol\" of the Money class");
            fieldGeneratorAmount = new JSONHoldingNumberTextGenerator("field \"Amount\" of the Money class");
            set_what("the Money class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCode = new JSONHoldingStringGenerator("field \"Code\" of the Money class");
            fieldGeneratorSymbol = new JSONHoldingStringGenerator("field \"Symbol\" of the Money class");
            fieldGeneratorAmount = new JSONHoldingNumberTextGenerator("field \"Amount\" of the Money class");
            set_what("the Money class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCode.reset();
            fieldGeneratorSymbol.reset();
            fieldGeneratorAmount.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MoneyJSON  result)
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
        public MoneyJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MoneyJSON  result)
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
    protected virtual void handle_result(List<MoneyJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MoneyJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MoneyJSON>();
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
    public List<MoneyJSON> value;
  };
  };
