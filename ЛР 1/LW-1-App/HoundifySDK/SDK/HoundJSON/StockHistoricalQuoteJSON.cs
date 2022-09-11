/* file "StockHistoricalQuoteJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


public class StockHistoricalQuoteJSON : JSONBase
  {
    public static Regex expressionStartDateTime = new Regex("^[0-9][0-9][0-9][0-9]/[0-1][0-9]/[0-3][0-9]( [0-2][0-9]:[0-9][0-9]:[0-9][0-9])?");
    public static Regex expressionEndDateTime = new Regex("^[0-9][0-9][0-9][0-9]/[0-1][0-9]/[0-3][0-9]( [0-2][0-9]:[0-9][0-9]:[0-9][0-9])?");
    private bool flagHasStartDateTime;
    private string storeStartDateTime;
    private bool flagHasEndDateTime;
    private string storeEndDateTime;
    private bool flagHasOpen;
    private double storeOpen;
    private string textStoreOpen;
    private bool flagHasClose;
    private double storeClose;
    private string textStoreClose;
    private bool flagHasHigh;
    private double storeHigh;
    private string textStoreHigh;
    private bool flagHasLow;
    private double storeLow;
    private string textStoreLow;
    private bool flagHasVolume;
    private double storeVolume;
    private string textStoreVolume;
    private bool flagHasSplitRatio;
    private double storeSplitRatio;
    private string textStoreSplitRatio;
    private bool flagHasCurrency;
    private string storeCurrency;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStartDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StartDateTime of StockHistoricalQuoteJSON is not a string.");
        setStartDateTime(json_string.getData());
      }


    private void  fromJSONEndDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EndDateTime of StockHistoricalQuoteJSON is not a string.");
        setEndDateTime(json_string.getData());
      }


    private void  fromJSONOpen(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Open of StockHistoricalQuoteJSON is not a number.");
              }
          }
        setOpenText(the_rational_text);
      }


    private void  fromJSONClose(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Close of StockHistoricalQuoteJSON is not a number.");
              }
          }
        setCloseText(the_rational_text);
      }


    private void  fromJSONHigh(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field High of StockHistoricalQuoteJSON is not a number.");
              }
          }
        setHighText(the_rational_text);
      }


    private void  fromJSONLow(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Low of StockHistoricalQuoteJSON is not a number.");
              }
          }
        setLowText(the_rational_text);
      }


    private void  fromJSONVolume(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Volume of StockHistoricalQuoteJSON is not a number.");
              }
          }
        setVolumeText(the_rational_text);
      }


    private void  fromJSONSplitRatio(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SplitRatio of StockHistoricalQuoteJSON is not a number.");
              }
          }
        setSplitRatioText(the_rational_text);
      }


    private void  fromJSONCurrency(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Currency of StockHistoricalQuoteJSON is not a string.");
        setCurrency(json_string.getData());
      }


    public StockHistoricalQuoteJSON()
      {
        flagHasStartDateTime = false;
        flagHasEndDateTime = false;
        flagHasOpen = false;
        flagHasClose = false;
        flagHasHigh = false;
        flagHasLow = false;
        flagHasVolume = false;
        flagHasSplitRatio = false;
        flagHasCurrency = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStartDateTime()
      {
        return flagHasStartDateTime;
      }

    public string  getStartDateTime()
      {
        Debug.Assert(flagHasStartDateTime);
        return storeStartDateTime;
      }

    public bool  hasEndDateTime()
      {
        return flagHasEndDateTime;
      }

    public string  getEndDateTime()
      {
        Debug.Assert(flagHasEndDateTime);
        return storeEndDateTime;
      }

    public bool  hasOpen()
      {
        return flagHasOpen;
      }

    public double  getOpen()
      {
        Debug.Assert(flagHasOpen);
        if (textStoreOpen != "")
          {
            return Double.Parse(textStoreOpen);
          }
        return storeOpen;
      }

    public string  getOpenAsText()
      {
        Debug.Assert(flagHasOpen);
        if (textStoreOpen == "")
          {
            return Convert.ToString(storeOpen);
          }
        else
          {
            return (textStoreOpen);
          }
      }

    public bool  hasClose()
      {
        return flagHasClose;
      }

    public double  getClose()
      {
        Debug.Assert(flagHasClose);
        if (textStoreClose != "")
          {
            return Double.Parse(textStoreClose);
          }
        return storeClose;
      }

    public string  getCloseAsText()
      {
        Debug.Assert(flagHasClose);
        if (textStoreClose == "")
          {
            return Convert.ToString(storeClose);
          }
        else
          {
            return (textStoreClose);
          }
      }

    public bool  hasHigh()
      {
        return flagHasHigh;
      }

    public double  getHigh()
      {
        Debug.Assert(flagHasHigh);
        if (textStoreHigh != "")
          {
            return Double.Parse(textStoreHigh);
          }
        return storeHigh;
      }

    public string  getHighAsText()
      {
        Debug.Assert(flagHasHigh);
        if (textStoreHigh == "")
          {
            return Convert.ToString(storeHigh);
          }
        else
          {
            return (textStoreHigh);
          }
      }

    public bool  hasLow()
      {
        return flagHasLow;
      }

    public double  getLow()
      {
        Debug.Assert(flagHasLow);
        if (textStoreLow != "")
          {
            return Double.Parse(textStoreLow);
          }
        return storeLow;
      }

    public string  getLowAsText()
      {
        Debug.Assert(flagHasLow);
        if (textStoreLow == "")
          {
            return Convert.ToString(storeLow);
          }
        else
          {
            return (textStoreLow);
          }
      }

    public bool  hasVolume()
      {
        return flagHasVolume;
      }

    public double  getVolume()
      {
        Debug.Assert(flagHasVolume);
        if (textStoreVolume != "")
          {
            return Double.Parse(textStoreVolume);
          }
        return storeVolume;
      }

    public string  getVolumeAsText()
      {
        Debug.Assert(flagHasVolume);
        if (textStoreVolume == "")
          {
            return Convert.ToString(storeVolume);
          }
        else
          {
            return (textStoreVolume);
          }
      }

    public bool  hasSplitRatio()
      {
        return flagHasSplitRatio;
      }

    public double  getSplitRatio()
      {
        Debug.Assert(flagHasSplitRatio);
        if (textStoreSplitRatio != "")
          {
            return Double.Parse(textStoreSplitRatio);
          }
        return storeSplitRatio;
      }

    public string  getSplitRatioAsText()
      {
        Debug.Assert(flagHasSplitRatio);
        if (textStoreSplitRatio == "")
          {
            return Convert.ToString(storeSplitRatio);
          }
        else
          {
            return (textStoreSplitRatio);
          }
      }

    public bool  hasCurrency()
      {
        return flagHasCurrency;
      }

    public string  getCurrency()
      {
        Debug.Assert(flagHasCurrency);
        return storeCurrency;
      }


    public virtual int extraStockHistoricalQuoteComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockHistoricalQuoteComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockHistoricalQuoteComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockHistoricalQuoteLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setStartDateTime(string new_value)
      {
        flagHasStartDateTime = true;
        if (!expressionStartDateTime.IsMatch(new_value))
            throw new Exception("The value is not in the regular expression for field StartDateTime of StockHistoricalQuoteJSON.");
        storeStartDateTime = new_value;
      }
    public void unsetStartDateTime()
      {
        flagHasStartDateTime = false;
      }
    public void setEndDateTime(string new_value)
      {
        flagHasEndDateTime = true;
        if (!expressionEndDateTime.IsMatch(new_value))
            throw new Exception("The value is not in the regular expression for field EndDateTime of StockHistoricalQuoteJSON.");
        storeEndDateTime = new_value;
      }
    public void unsetEndDateTime()
      {
        flagHasEndDateTime = false;
      }
    public void setOpen(double new_value)
      {
        flagHasOpen = true;
        storeOpen = new_value;
        textStoreOpen = "";
      }
    public void setOpenText(string new_value)
      {
        flagHasOpen = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Open of StockHistoricalQuoteJSON is not a valid number.");
        textStoreOpen = new_value;
      }
    public void unsetOpen()
      {
        flagHasOpen = false;
      }
    public void setClose(double new_value)
      {
        flagHasClose = true;
        storeClose = new_value;
        textStoreClose = "";
      }
    public void setCloseText(string new_value)
      {
        flagHasClose = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Close of StockHistoricalQuoteJSON is not a valid number.");
        textStoreClose = new_value;
      }
    public void unsetClose()
      {
        flagHasClose = false;
      }
    public void setHigh(double new_value)
      {
        flagHasHigh = true;
        storeHigh = new_value;
        textStoreHigh = "";
      }
    public void setHighText(string new_value)
      {
        flagHasHigh = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field High of StockHistoricalQuoteJSON is not a valid number.");
        textStoreHigh = new_value;
      }
    public void unsetHigh()
      {
        flagHasHigh = false;
      }
    public void setLow(double new_value)
      {
        flagHasLow = true;
        storeLow = new_value;
        textStoreLow = "";
      }
    public void setLowText(string new_value)
      {
        flagHasLow = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Low of StockHistoricalQuoteJSON is not a valid number.");
        textStoreLow = new_value;
      }
    public void unsetLow()
      {
        flagHasLow = false;
      }
    public void setVolume(double new_value)
      {
        flagHasVolume = true;
        storeVolume = new_value;
        textStoreVolume = "";
      }
    public void setVolumeText(string new_value)
      {
        flagHasVolume = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Volume of StockHistoricalQuoteJSON is not a valid number.");
        textStoreVolume = new_value;
      }
    public void unsetVolume()
      {
        flagHasVolume = false;
      }
    public void setSplitRatio(double new_value)
      {
        flagHasSplitRatio = true;
        storeSplitRatio = new_value;
        textStoreSplitRatio = "";
      }
    public void setSplitRatioText(string new_value)
      {
        flagHasSplitRatio = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field SplitRatio of StockHistoricalQuoteJSON is not a valid number.");
        textStoreSplitRatio = new_value;
      }
    public void unsetSplitRatio()
      {
        flagHasSplitRatio = false;
      }
    public void setCurrency(string new_value)
      {
        flagHasCurrency = true;
        storeCurrency = new_value;
      }
    public void unsetCurrency()
      {
        flagHasCurrency = false;
      }

    public virtual void extraStockHistoricalQuoteAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockHistoricalQuoteSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockHistoricalQuoteLookup(key);
        if (old_field == null)
          {
            extraStockHistoricalQuoteAppendPair(key, new_component);
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
        if (flagHasStartDateTime)
          {
            handler.start_pair("StartDateTime");
            handler.string_value(storeStartDateTime);
          }
        if (flagHasEndDateTime)
          {
            handler.start_pair("EndDateTime");
            handler.string_value(storeEndDateTime);
          }
        if (flagHasOpen)
          {
            handler.start_pair("Open");
            if (textStoreOpen != "")
                handler.number_value(textStoreOpen);
            else if (((double)(long)storeOpen) == storeOpen)
                handler.number_value((long)storeOpen);
            else
                handler.number_value(storeOpen);
          }
        if (flagHasClose)
          {
            handler.start_pair("Close");
            if (textStoreClose != "")
                handler.number_value(textStoreClose);
            else if (((double)(long)storeClose) == storeClose)
                handler.number_value((long)storeClose);
            else
                handler.number_value(storeClose);
          }
        if (flagHasHigh)
          {
            handler.start_pair("High");
            if (textStoreHigh != "")
                handler.number_value(textStoreHigh);
            else if (((double)(long)storeHigh) == storeHigh)
                handler.number_value((long)storeHigh);
            else
                handler.number_value(storeHigh);
          }
        if (flagHasLow)
          {
            handler.start_pair("Low");
            if (textStoreLow != "")
                handler.number_value(textStoreLow);
            else if (((double)(long)storeLow) == storeLow)
                handler.number_value((long)storeLow);
            else
                handler.number_value(storeLow);
          }
        if (flagHasVolume)
          {
            handler.start_pair("Volume");
            if (textStoreVolume != "")
                handler.number_value(textStoreVolume);
            else if (((double)(long)storeVolume) == storeVolume)
                handler.number_value((long)storeVolume);
            else
                handler.number_value(storeVolume);
          }
        if (flagHasSplitRatio)
          {
            handler.start_pair("SplitRatio");
            if (textStoreSplitRatio != "")
                handler.number_value(textStoreSplitRatio);
            else if (((double)(long)storeSplitRatio) == storeSplitRatio)
                handler.number_value((long)storeSplitRatio);
            else
                handler.number_value(storeSplitRatio);
          }
        if (flagHasCurrency)
          {
            handler.start_pair("Currency");
            handler.string_value(storeCurrency);
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

    public static StockHistoricalQuoteJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockHistoricalQuoteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockHistoricalQuote", ignore_extras);
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
    public static StockHistoricalQuoteJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockHistoricalQuoteJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockHistoricalQuoteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockHistoricalQuote", ignore_extras);
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
    public static StockHistoricalQuoteJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockHistoricalQuoteJSON from_text(string text, bool ignore_extras)
      {
        StockHistoricalQuoteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockHistoricalQuote", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockHistoricalQuoteJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockHistoricalQuoteJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockHistoricalQuoteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockHistoricalQuote", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorStartDateTime : JSONStringGenerator
          {
            private Regex checker;
            protected FieldGeneratorStartDateTime()  { checker = new Regex("^[0-9][0-9][0-9][0-9]/[0-1][0-9]/[0-3][0-9]( [0-2][0-9]:[0-9][0-9]:[0-9][0-9])?"); }
            protected FieldGeneratorStartDateTime(string  what) : base(what) { checker = new Regex("^[0-9][0-9][0-9][0-9]/[0-1][0-9]/[0-3][0-9]( [0-2][0-9]:[0-9][0-9]:[0-9][0-9])?"); }
            protected void validate(string result)
              {
                if (!(checker.IsMatch(result)))
                    error("The string for %what% doesn't match the required pattern @^[0-9][0-9][0-9][0-9]/[0-1][0-9]/[0-3][0-9]( [0-2][0-9]:[0-9][0-9]:[0-9][0-9])?@.");
              }
          };
    private class FieldHoldingGeneratorStartDateTime : FieldGeneratorStartDateTime
  {
    protected override void handle_result(string result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorStartDateTime(String what)
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
    public string value;
  };
    private class FieldHoldingArrayGeneratorStartDateTime : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorStartDateTime
      {
        private FieldHoldingArrayGeneratorStartDateTime top;

        protected override void handle_result(string result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorStartDateTime init_top)
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
    protected virtual void handle_result(List<string> result)
      {
      }

    public FieldHoldingArrayGeneratorStartDateTime(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorStartDateTime()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<string> value;
  };
        private FieldHoldingGeneratorStartDateTime fieldGeneratorStartDateTime;
    private abstract class FieldGeneratorEndDateTime : JSONStringGenerator
          {
            private Regex checker;
            protected FieldGeneratorEndDateTime()  { checker = new Regex("^[0-9][0-9][0-9][0-9]/[0-1][0-9]/[0-3][0-9]( [0-2][0-9]:[0-9][0-9]:[0-9][0-9])?"); }
            protected FieldGeneratorEndDateTime(string  what) : base(what) { checker = new Regex("^[0-9][0-9][0-9][0-9]/[0-1][0-9]/[0-3][0-9]( [0-2][0-9]:[0-9][0-9]:[0-9][0-9])?"); }
            protected void validate(string result)
              {
                if (!(checker.IsMatch(result)))
                    error("The string for %what% doesn't match the required pattern @^[0-9][0-9][0-9][0-9]/[0-1][0-9]/[0-3][0-9]( [0-2][0-9]:[0-9][0-9]:[0-9][0-9])?@.");
              }
          };
    private class FieldHoldingGeneratorEndDateTime : FieldGeneratorEndDateTime
  {
    protected override void handle_result(string result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorEndDateTime(String what)
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
    public string value;
  };
    private class FieldHoldingArrayGeneratorEndDateTime : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorEndDateTime
      {
        private FieldHoldingArrayGeneratorEndDateTime top;

        protected override void handle_result(string result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorEndDateTime init_top)
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
    protected virtual void handle_result(List<string> result)
      {
      }

    public FieldHoldingArrayGeneratorEndDateTime(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorEndDateTime()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<string> value;
  };
        private FieldHoldingGeneratorEndDateTime fieldGeneratorEndDateTime;
        private JSONHoldingNumberTextGenerator fieldGeneratorOpen;
        private JSONHoldingNumberTextGenerator fieldGeneratorClose;
        private JSONHoldingNumberTextGenerator fieldGeneratorHigh;
        private JSONHoldingNumberTextGenerator fieldGeneratorLow;
        private JSONHoldingNumberTextGenerator fieldGeneratorVolume;
        private JSONHoldingNumberTextGenerator fieldGeneratorSplitRatio;
        private JSONHoldingStringGenerator fieldGeneratorCurrency;
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
            StockHistoricalQuoteJSON result = new StockHistoricalQuoteJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockHistoricalQuoteAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockHistoricalQuoteJSON result)
          {
            if (fieldGeneratorStartDateTime.have_value)
              {
                result.setStartDateTime(fieldGeneratorStartDateTime.value);
                fieldGeneratorStartDateTime.have_value = false;
              }
            if (fieldGeneratorEndDateTime.have_value)
              {
                result.setEndDateTime(fieldGeneratorEndDateTime.value);
                fieldGeneratorEndDateTime.have_value = false;
              }
            if (fieldGeneratorOpen.have_value)
              {
                result.setOpenText(fieldGeneratorOpen.value);
                fieldGeneratorOpen.have_value = false;
              }
            if (fieldGeneratorClose.have_value)
              {
                result.setCloseText(fieldGeneratorClose.value);
                fieldGeneratorClose.have_value = false;
              }
            if (fieldGeneratorHigh.have_value)
              {
                result.setHighText(fieldGeneratorHigh.value);
                fieldGeneratorHigh.have_value = false;
              }
            if (fieldGeneratorLow.have_value)
              {
                result.setLowText(fieldGeneratorLow.value);
                fieldGeneratorLow.have_value = false;
              }
            if (fieldGeneratorVolume.have_value)
              {
                result.setVolumeText(fieldGeneratorVolume.value);
                fieldGeneratorVolume.have_value = false;
              }
            if (fieldGeneratorSplitRatio.have_value)
              {
                result.setSplitRatioText(fieldGeneratorSplitRatio.value);
                fieldGeneratorSplitRatio.have_value = false;
              }
            if (fieldGeneratorCurrency.have_value)
              {
                result.setCurrency(fieldGeneratorCurrency.value);
                fieldGeneratorCurrency.have_value = false;
              }
          }
        protected abstract void handle_result(StockHistoricalQuoteJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "ose", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorClose;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rrency", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorCurrency;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "ndDateTime", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorEndDateTime;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "igh", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorHigh;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ow", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorLow;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "pen", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorOpen;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'p':
                            if ((String.Compare(field_name, 2, "litRatio", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorSplitRatio;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "artDateTime", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorStartDateTime;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "olume", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorVolume;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorStartDateTime = new FieldHoldingGeneratorStartDateTime("field \"StartDateTime\" of the StockHistoricalQuote class");
            fieldGeneratorEndDateTime = new FieldHoldingGeneratorEndDateTime("field \"EndDateTime\" of the StockHistoricalQuote class");
            fieldGeneratorOpen = new JSONHoldingNumberTextGenerator("field \"Open\" of the StockHistoricalQuote class");
            fieldGeneratorClose = new JSONHoldingNumberTextGenerator("field \"Close\" of the StockHistoricalQuote class");
            fieldGeneratorHigh = new JSONHoldingNumberTextGenerator("field \"High\" of the StockHistoricalQuote class");
            fieldGeneratorLow = new JSONHoldingNumberTextGenerator("field \"Low\" of the StockHistoricalQuote class");
            fieldGeneratorVolume = new JSONHoldingNumberTextGenerator("field \"Volume\" of the StockHistoricalQuote class");
            fieldGeneratorSplitRatio = new JSONHoldingNumberTextGenerator("field \"SplitRatio\" of the StockHistoricalQuote class");
            fieldGeneratorCurrency = new JSONHoldingStringGenerator("field \"Currency\" of the StockHistoricalQuote class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockHistoricalQuote class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStartDateTime = new FieldHoldingGeneratorStartDateTime("field \"StartDateTime\" of the StockHistoricalQuote class");
            fieldGeneratorEndDateTime = new FieldHoldingGeneratorEndDateTime("field \"EndDateTime\" of the StockHistoricalQuote class");
            fieldGeneratorOpen = new JSONHoldingNumberTextGenerator("field \"Open\" of the StockHistoricalQuote class");
            fieldGeneratorClose = new JSONHoldingNumberTextGenerator("field \"Close\" of the StockHistoricalQuote class");
            fieldGeneratorHigh = new JSONHoldingNumberTextGenerator("field \"High\" of the StockHistoricalQuote class");
            fieldGeneratorLow = new JSONHoldingNumberTextGenerator("field \"Low\" of the StockHistoricalQuote class");
            fieldGeneratorVolume = new JSONHoldingNumberTextGenerator("field \"Volume\" of the StockHistoricalQuote class");
            fieldGeneratorSplitRatio = new JSONHoldingNumberTextGenerator("field \"SplitRatio\" of the StockHistoricalQuote class");
            fieldGeneratorCurrency = new JSONHoldingStringGenerator("field \"Currency\" of the StockHistoricalQuote class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockHistoricalQuote class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStartDateTime.reset();
            fieldGeneratorEndDateTime.reset();
            fieldGeneratorOpen.reset();
            fieldGeneratorClose.reset();
            fieldGeneratorHigh.reset();
            fieldGeneratorLow.reset();
            fieldGeneratorVolume.reset();
            fieldGeneratorSplitRatio.reset();
            fieldGeneratorCurrency.reset();
            base.reset();
            unknownFieldGenerator.reset();
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
        protected override void handle_result(StockHistoricalQuoteJSON  result)
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
        public StockHistoricalQuoteJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockHistoricalQuoteJSON  result)
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
    protected virtual void handle_result(List<StockHistoricalQuoteJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockHistoricalQuoteJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockHistoricalQuoteJSON>();
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
    public List<StockHistoricalQuoteJSON> value;
  };
  };
