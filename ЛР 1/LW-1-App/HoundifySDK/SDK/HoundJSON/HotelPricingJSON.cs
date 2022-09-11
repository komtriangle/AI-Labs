/* file "HotelPricingJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HotelPricingJSON : JSONBase
  {
    private bool flagHasHotelRateCurrency;
    private string storeHotelRateCurrency;
    private bool flagHasHotelRateCurrencySymbol;
    private string storeHotelRateCurrencySymbol;
    private bool flagHasHotelBaseRate;
    private double storeHotelBaseRate;
    private string textStoreHotelBaseRate;
    private bool flagHasHotelNightlyBaseRate;
    private double storeHotelNightlyBaseRate;
    private string textStoreHotelNightlyBaseRate;
    private bool flagHasHotelNightlyMinBaseRate;
    private double storeHotelNightlyMinBaseRate;
    private string textStoreHotelNightlyMinBaseRate;
    private bool flagHasHotelNightlyMaxBaseRate;
    private double storeHotelNightlyMaxBaseRate;
    private string textStoreHotelNightlyMaxBaseRate;
    private bool flagHasHotelShowPriceRange;
    private bool storeHotelShowPriceRange;
    private bool flagHasHotelTaxesAndFeesRate;
    private double storeHotelTaxesAndFeesRate;
    private string textStoreHotelTaxesAndFeesRate;
    private bool flagHasHotelMandatoryTaxesAndFeesRate;
    private double storeHotelMandatoryTaxesAndFeesRate;
    private string textStoreHotelMandatoryTaxesAndFeesRate;
    private bool flagHasHotelTotalRate;
    private double storeHotelTotalRate;
    private string textStoreHotelTotalRate;
    private bool flagHasHotelNightlyTotalRate;
    private double storeHotelNightlyTotalRate;
    private string textStoreHotelNightlyTotalRate;


    private void  fromJSONHotelRateCurrency(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HotelRateCurrency of HotelPricingJSON is not a string.");
        setHotelRateCurrency(json_string.getData());
      }


    private void  fromJSONHotelRateCurrencySymbol(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HotelRateCurrencySymbol of HotelPricingJSON is not a string.");
        setHotelRateCurrencySymbol(json_string.getData());
      }


    private void  fromJSONHotelBaseRate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HotelBaseRate of HotelPricingJSON is not a number.");
              }
          }
        setHotelBaseRateText(the_rational_text);
      }


    private void  fromJSONHotelNightlyBaseRate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HotelNightlyBaseRate of HotelPricingJSON is not a number.");
              }
          }
        setHotelNightlyBaseRateText(the_rational_text);
      }


    private void  fromJSONHotelNightlyMinBaseRate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HotelNightlyMinBaseRate of HotelPricingJSON is not a number.");
              }
          }
        setHotelNightlyMinBaseRateText(the_rational_text);
      }


    private void  fromJSONHotelNightlyMaxBaseRate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HotelNightlyMaxBaseRate of HotelPricingJSON is not a number.");
              }
          }
        setHotelNightlyMaxBaseRateText(the_rational_text);
      }


    private void  fromJSONHotelShowPriceRange(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HotelShowPriceRange of HotelPricingJSON is not true for false.");
              }
          }
        setHotelShowPriceRange(the_bool);
      }


    private void  fromJSONHotelTaxesAndFeesRate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HotelTaxesAndFeesRate of HotelPricingJSON is not a number.");
              }
          }
        setHotelTaxesAndFeesRateText(the_rational_text);
      }


    private void  fromJSONHotelMandatoryTaxesAndFeesRate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HotelMandatoryTaxesAndFeesRate of HotelPricingJSON is not a number.");
              }
          }
        setHotelMandatoryTaxesAndFeesRateText(the_rational_text);
      }


    private void  fromJSONHotelTotalRate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HotelTotalRate of HotelPricingJSON is not a number.");
              }
          }
        setHotelTotalRateText(the_rational_text);
      }


    private void  fromJSONHotelNightlyTotalRate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HotelNightlyTotalRate of HotelPricingJSON is not a number.");
              }
          }
        setHotelNightlyTotalRateText(the_rational_text);
      }


    public HotelPricingJSON()
      {
        flagHasHotelRateCurrency = false;
        flagHasHotelRateCurrencySymbol = false;
        flagHasHotelBaseRate = false;
        flagHasHotelNightlyBaseRate = false;
        flagHasHotelNightlyMinBaseRate = false;
        flagHasHotelNightlyMaxBaseRate = false;
        flagHasHotelShowPriceRange = false;
        flagHasHotelTaxesAndFeesRate = false;
        flagHasHotelMandatoryTaxesAndFeesRate = false;
        flagHasHotelTotalRate = false;
        flagHasHotelNightlyTotalRate = false;
      }

    public bool  hasHotelRateCurrency()
      {
        return flagHasHotelRateCurrency;
      }

    public string  getHotelRateCurrency()
      {
        Debug.Assert(flagHasHotelRateCurrency);
        return storeHotelRateCurrency;
      }

    public bool  hasHotelRateCurrencySymbol()
      {
        return flagHasHotelRateCurrencySymbol;
      }

    public string  getHotelRateCurrencySymbol()
      {
        Debug.Assert(flagHasHotelRateCurrencySymbol);
        return storeHotelRateCurrencySymbol;
      }

    public bool  hasHotelBaseRate()
      {
        return flagHasHotelBaseRate;
      }

    public double  getHotelBaseRate()
      {
        Debug.Assert(flagHasHotelBaseRate);
        if (textStoreHotelBaseRate != "")
          {
            return Double.Parse(textStoreHotelBaseRate);
          }
        return storeHotelBaseRate;
      }

    public string  getHotelBaseRateAsText()
      {
        Debug.Assert(flagHasHotelBaseRate);
        if (textStoreHotelBaseRate == "")
          {
            return Convert.ToString(storeHotelBaseRate);
          }
        else
          {
            return (textStoreHotelBaseRate);
          }
      }

    public bool  hasHotelNightlyBaseRate()
      {
        return flagHasHotelNightlyBaseRate;
      }

    public double  getHotelNightlyBaseRate()
      {
        Debug.Assert(flagHasHotelNightlyBaseRate);
        if (textStoreHotelNightlyBaseRate != "")
          {
            return Double.Parse(textStoreHotelNightlyBaseRate);
          }
        return storeHotelNightlyBaseRate;
      }

    public string  getHotelNightlyBaseRateAsText()
      {
        Debug.Assert(flagHasHotelNightlyBaseRate);
        if (textStoreHotelNightlyBaseRate == "")
          {
            return Convert.ToString(storeHotelNightlyBaseRate);
          }
        else
          {
            return (textStoreHotelNightlyBaseRate);
          }
      }

    public bool  hasHotelNightlyMinBaseRate()
      {
        return flagHasHotelNightlyMinBaseRate;
      }

    public double  getHotelNightlyMinBaseRate()
      {
        Debug.Assert(flagHasHotelNightlyMinBaseRate);
        if (textStoreHotelNightlyMinBaseRate != "")
          {
            return Double.Parse(textStoreHotelNightlyMinBaseRate);
          }
        return storeHotelNightlyMinBaseRate;
      }

    public string  getHotelNightlyMinBaseRateAsText()
      {
        Debug.Assert(flagHasHotelNightlyMinBaseRate);
        if (textStoreHotelNightlyMinBaseRate == "")
          {
            return Convert.ToString(storeHotelNightlyMinBaseRate);
          }
        else
          {
            return (textStoreHotelNightlyMinBaseRate);
          }
      }

    public bool  hasHotelNightlyMaxBaseRate()
      {
        return flagHasHotelNightlyMaxBaseRate;
      }

    public double  getHotelNightlyMaxBaseRate()
      {
        Debug.Assert(flagHasHotelNightlyMaxBaseRate);
        if (textStoreHotelNightlyMaxBaseRate != "")
          {
            return Double.Parse(textStoreHotelNightlyMaxBaseRate);
          }
        return storeHotelNightlyMaxBaseRate;
      }

    public string  getHotelNightlyMaxBaseRateAsText()
      {
        Debug.Assert(flagHasHotelNightlyMaxBaseRate);
        if (textStoreHotelNightlyMaxBaseRate == "")
          {
            return Convert.ToString(storeHotelNightlyMaxBaseRate);
          }
        else
          {
            return (textStoreHotelNightlyMaxBaseRate);
          }
      }

    public bool  hasHotelShowPriceRange()
      {
        return flagHasHotelShowPriceRange;
      }

    public bool  getHotelShowPriceRange()
      {
        Debug.Assert(flagHasHotelShowPriceRange);
        return storeHotelShowPriceRange;
      }

    public bool  hasHotelTaxesAndFeesRate()
      {
        return flagHasHotelTaxesAndFeesRate;
      }

    public double  getHotelTaxesAndFeesRate()
      {
        Debug.Assert(flagHasHotelTaxesAndFeesRate);
        if (textStoreHotelTaxesAndFeesRate != "")
          {
            return Double.Parse(textStoreHotelTaxesAndFeesRate);
          }
        return storeHotelTaxesAndFeesRate;
      }

    public string  getHotelTaxesAndFeesRateAsText()
      {
        Debug.Assert(flagHasHotelTaxesAndFeesRate);
        if (textStoreHotelTaxesAndFeesRate == "")
          {
            return Convert.ToString(storeHotelTaxesAndFeesRate);
          }
        else
          {
            return (textStoreHotelTaxesAndFeesRate);
          }
      }

    public bool  hasHotelMandatoryTaxesAndFeesRate()
      {
        return flagHasHotelMandatoryTaxesAndFeesRate;
      }

    public double  getHotelMandatoryTaxesAndFeesRate()
      {
        Debug.Assert(flagHasHotelMandatoryTaxesAndFeesRate);
        if (textStoreHotelMandatoryTaxesAndFeesRate != "")
          {
            return Double.Parse(textStoreHotelMandatoryTaxesAndFeesRate);
          }
        return storeHotelMandatoryTaxesAndFeesRate;
      }

    public string  getHotelMandatoryTaxesAndFeesRateAsText()
      {
        Debug.Assert(flagHasHotelMandatoryTaxesAndFeesRate);
        if (textStoreHotelMandatoryTaxesAndFeesRate == "")
          {
            return Convert.ToString(storeHotelMandatoryTaxesAndFeesRate);
          }
        else
          {
            return (textStoreHotelMandatoryTaxesAndFeesRate);
          }
      }

    public bool  hasHotelTotalRate()
      {
        return flagHasHotelTotalRate;
      }

    public double  getHotelTotalRate()
      {
        Debug.Assert(flagHasHotelTotalRate);
        if (textStoreHotelTotalRate != "")
          {
            return Double.Parse(textStoreHotelTotalRate);
          }
        return storeHotelTotalRate;
      }

    public string  getHotelTotalRateAsText()
      {
        Debug.Assert(flagHasHotelTotalRate);
        if (textStoreHotelTotalRate == "")
          {
            return Convert.ToString(storeHotelTotalRate);
          }
        else
          {
            return (textStoreHotelTotalRate);
          }
      }

    public bool  hasHotelNightlyTotalRate()
      {
        return flagHasHotelNightlyTotalRate;
      }

    public double  getHotelNightlyTotalRate()
      {
        Debug.Assert(flagHasHotelNightlyTotalRate);
        if (textStoreHotelNightlyTotalRate != "")
          {
            return Double.Parse(textStoreHotelNightlyTotalRate);
          }
        return storeHotelNightlyTotalRate;
      }

    public string  getHotelNightlyTotalRateAsText()
      {
        Debug.Assert(flagHasHotelNightlyTotalRate);
        if (textStoreHotelNightlyTotalRate == "")
          {
            return Convert.ToString(storeHotelNightlyTotalRate);
          }
        else
          {
            return (textStoreHotelNightlyTotalRate);
          }
      }



    public void setHotelRateCurrency(string new_value)
      {
        flagHasHotelRateCurrency = true;
        storeHotelRateCurrency = new_value;
      }
    public void unsetHotelRateCurrency()
      {
        flagHasHotelRateCurrency = false;
      }
    public void setHotelRateCurrencySymbol(string new_value)
      {
        flagHasHotelRateCurrencySymbol = true;
        storeHotelRateCurrencySymbol = new_value;
      }
    public void unsetHotelRateCurrencySymbol()
      {
        flagHasHotelRateCurrencySymbol = false;
      }
    public void setHotelBaseRate(double new_value)
      {
        flagHasHotelBaseRate = true;
        if (new_value < 0)
            throw new Exception("The value for field HotelBaseRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        storeHotelBaseRate = new_value;
        textStoreHotelBaseRate = "";
      }
    public void setHotelBaseRateText(string new_value)
      {
        flagHasHotelBaseRate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HotelBaseRate of HotelPricingJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field HotelBaseRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        textStoreHotelBaseRate = new_value;
      }
    public void unsetHotelBaseRate()
      {
        flagHasHotelBaseRate = false;
      }
    public void setHotelNightlyBaseRate(double new_value)
      {
        flagHasHotelNightlyBaseRate = true;
        if (new_value < 0)
            throw new Exception("The value for field HotelNightlyBaseRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        storeHotelNightlyBaseRate = new_value;
        textStoreHotelNightlyBaseRate = "";
      }
    public void setHotelNightlyBaseRateText(string new_value)
      {
        flagHasHotelNightlyBaseRate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HotelNightlyBaseRate of HotelPricingJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field HotelNightlyBaseRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        textStoreHotelNightlyBaseRate = new_value;
      }
    public void unsetHotelNightlyBaseRate()
      {
        flagHasHotelNightlyBaseRate = false;
      }
    public void setHotelNightlyMinBaseRate(double new_value)
      {
        flagHasHotelNightlyMinBaseRate = true;
        if (new_value < 0)
            throw new Exception("The value for field HotelNightlyMinBaseRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        storeHotelNightlyMinBaseRate = new_value;
        textStoreHotelNightlyMinBaseRate = "";
      }
    public void setHotelNightlyMinBaseRateText(string new_value)
      {
        flagHasHotelNightlyMinBaseRate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HotelNightlyMinBaseRate of HotelPricingJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field HotelNightlyMinBaseRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        textStoreHotelNightlyMinBaseRate = new_value;
      }
    public void unsetHotelNightlyMinBaseRate()
      {
        flagHasHotelNightlyMinBaseRate = false;
      }
    public void setHotelNightlyMaxBaseRate(double new_value)
      {
        flagHasHotelNightlyMaxBaseRate = true;
        if (new_value < 0)
            throw new Exception("The value for field HotelNightlyMaxBaseRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        storeHotelNightlyMaxBaseRate = new_value;
        textStoreHotelNightlyMaxBaseRate = "";
      }
    public void setHotelNightlyMaxBaseRateText(string new_value)
      {
        flagHasHotelNightlyMaxBaseRate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HotelNightlyMaxBaseRate of HotelPricingJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field HotelNightlyMaxBaseRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        textStoreHotelNightlyMaxBaseRate = new_value;
      }
    public void unsetHotelNightlyMaxBaseRate()
      {
        flagHasHotelNightlyMaxBaseRate = false;
      }
    public void setHotelShowPriceRange(bool new_value)
      {
        flagHasHotelShowPriceRange = true;
        storeHotelShowPriceRange = new_value;
      }
    public void unsetHotelShowPriceRange()
      {
        flagHasHotelShowPriceRange = false;
      }
    public void setHotelTaxesAndFeesRate(double new_value)
      {
        flagHasHotelTaxesAndFeesRate = true;
        if (new_value < 0)
            throw new Exception("The value for field HotelTaxesAndFeesRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        storeHotelTaxesAndFeesRate = new_value;
        textStoreHotelTaxesAndFeesRate = "";
      }
    public void setHotelTaxesAndFeesRateText(string new_value)
      {
        flagHasHotelTaxesAndFeesRate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HotelTaxesAndFeesRate of HotelPricingJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field HotelTaxesAndFeesRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        textStoreHotelTaxesAndFeesRate = new_value;
      }
    public void unsetHotelTaxesAndFeesRate()
      {
        flagHasHotelTaxesAndFeesRate = false;
      }
    public void setHotelMandatoryTaxesAndFeesRate(double new_value)
      {
        flagHasHotelMandatoryTaxesAndFeesRate = true;
        if (new_value < 0)
            throw new Exception("The value for field HotelMandatoryTaxesAndFeesRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        storeHotelMandatoryTaxesAndFeesRate = new_value;
        textStoreHotelMandatoryTaxesAndFeesRate = "";
      }
    public void setHotelMandatoryTaxesAndFeesRateText(string new_value)
      {
        flagHasHotelMandatoryTaxesAndFeesRate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HotelMandatoryTaxesAndFeesRate of HotelPricingJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field HotelMandatoryTaxesAndFeesRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        textStoreHotelMandatoryTaxesAndFeesRate = new_value;
      }
    public void unsetHotelMandatoryTaxesAndFeesRate()
      {
        flagHasHotelMandatoryTaxesAndFeesRate = false;
      }
    public void setHotelTotalRate(double new_value)
      {
        flagHasHotelTotalRate = true;
        if (new_value < 0)
            throw new Exception("The value for field HotelTotalRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        storeHotelTotalRate = new_value;
        textStoreHotelTotalRate = "";
      }
    public void setHotelTotalRateText(string new_value)
      {
        flagHasHotelTotalRate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HotelTotalRate of HotelPricingJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field HotelTotalRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        textStoreHotelTotalRate = new_value;
      }
    public void unsetHotelTotalRate()
      {
        flagHasHotelTotalRate = false;
      }
    public void setHotelNightlyTotalRate(double new_value)
      {
        flagHasHotelNightlyTotalRate = true;
        if (new_value < 0)
            throw new Exception("The value for field HotelNightlyTotalRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        storeHotelNightlyTotalRate = new_value;
        textStoreHotelNightlyTotalRate = "";
      }
    public void setHotelNightlyTotalRateText(string new_value)
      {
        flagHasHotelNightlyTotalRate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HotelNightlyTotalRate of HotelPricingJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field HotelNightlyTotalRate of HotelPricingJSON is less than the lower bound (0) for that field.");
        textStoreHotelNightlyTotalRate = new_value;
      }
    public void unsetHotelNightlyTotalRate()
      {
        flagHasHotelNightlyTotalRate = false;
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
        if (flagHasHotelRateCurrency)
          {
            handler.start_pair("HotelRateCurrency");
            handler.string_value(storeHotelRateCurrency);
          }
        if (flagHasHotelRateCurrencySymbol)
          {
            handler.start_pair("HotelRateCurrencySymbol");
            handler.string_value(storeHotelRateCurrencySymbol);
          }
        if (flagHasHotelBaseRate)
          {
            handler.start_pair("HotelBaseRate");
            if (textStoreHotelBaseRate != "")
                handler.number_value(textStoreHotelBaseRate);
            else if (((double)(long)storeHotelBaseRate) == storeHotelBaseRate)
                handler.number_value((long)storeHotelBaseRate);
            else
                handler.number_value(storeHotelBaseRate);
          }
        if (flagHasHotelNightlyBaseRate)
          {
            handler.start_pair("HotelNightlyBaseRate");
            if (textStoreHotelNightlyBaseRate != "")
                handler.number_value(textStoreHotelNightlyBaseRate);
            else if (((double)(long)storeHotelNightlyBaseRate) == storeHotelNightlyBaseRate)
                handler.number_value((long)storeHotelNightlyBaseRate);
            else
                handler.number_value(storeHotelNightlyBaseRate);
          }
        if (flagHasHotelNightlyMinBaseRate)
          {
            handler.start_pair("HotelNightlyMinBaseRate");
            if (textStoreHotelNightlyMinBaseRate != "")
                handler.number_value(textStoreHotelNightlyMinBaseRate);
            else if (((double)(long)storeHotelNightlyMinBaseRate) == storeHotelNightlyMinBaseRate)
                handler.number_value((long)storeHotelNightlyMinBaseRate);
            else
                handler.number_value(storeHotelNightlyMinBaseRate);
          }
        if (flagHasHotelNightlyMaxBaseRate)
          {
            handler.start_pair("HotelNightlyMaxBaseRate");
            if (textStoreHotelNightlyMaxBaseRate != "")
                handler.number_value(textStoreHotelNightlyMaxBaseRate);
            else if (((double)(long)storeHotelNightlyMaxBaseRate) == storeHotelNightlyMaxBaseRate)
                handler.number_value((long)storeHotelNightlyMaxBaseRate);
            else
                handler.number_value(storeHotelNightlyMaxBaseRate);
          }
        if (flagHasHotelShowPriceRange)
          {
            handler.start_pair("HotelShowPriceRange");
            handler.boolean_value(storeHotelShowPriceRange);
          }
        if (flagHasHotelTaxesAndFeesRate)
          {
            handler.start_pair("HotelTaxesAndFeesRate");
            if (textStoreHotelTaxesAndFeesRate != "")
                handler.number_value(textStoreHotelTaxesAndFeesRate);
            else if (((double)(long)storeHotelTaxesAndFeesRate) == storeHotelTaxesAndFeesRate)
                handler.number_value((long)storeHotelTaxesAndFeesRate);
            else
                handler.number_value(storeHotelTaxesAndFeesRate);
          }
        if (flagHasHotelMandatoryTaxesAndFeesRate)
          {
            handler.start_pair("HotelMandatoryTaxesAndFeesRate");
            if (textStoreHotelMandatoryTaxesAndFeesRate != "")
                handler.number_value(textStoreHotelMandatoryTaxesAndFeesRate);
            else if (((double)(long)storeHotelMandatoryTaxesAndFeesRate) == storeHotelMandatoryTaxesAndFeesRate)
                handler.number_value((long)storeHotelMandatoryTaxesAndFeesRate);
            else
                handler.number_value(storeHotelMandatoryTaxesAndFeesRate);
          }
        if (flagHasHotelTotalRate)
          {
            handler.start_pair("HotelTotalRate");
            if (textStoreHotelTotalRate != "")
                handler.number_value(textStoreHotelTotalRate);
            else if (((double)(long)storeHotelTotalRate) == storeHotelTotalRate)
                handler.number_value((long)storeHotelTotalRate);
            else
                handler.number_value(storeHotelTotalRate);
          }
        if (flagHasHotelNightlyTotalRate)
          {
            handler.start_pair("HotelNightlyTotalRate");
            if (textStoreHotelNightlyTotalRate != "")
                handler.number_value(textStoreHotelNightlyTotalRate);
            else if (((double)(long)storeHotelNightlyTotalRate) == storeHotelNightlyTotalRate)
                handler.number_value((long)storeHotelNightlyTotalRate);
            else
                handler.number_value(storeHotelNightlyTotalRate);
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
        return null;
      }

    public static HotelPricingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HotelPricingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelPricing", ignore_extras);
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
    public static HotelPricingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HotelPricingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HotelPricingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelPricing", ignore_extras);
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
    public static HotelPricingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HotelPricingJSON from_text(string text, bool ignore_extras)
      {
        HotelPricingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelPricing", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HotelPricingJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HotelPricingJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HotelPricingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelPricing", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorHotelRateCurrency;
        private JSONHoldingStringGenerator fieldGeneratorHotelRateCurrencySymbol;
        private JSONHoldingNumberTextGenerator fieldGeneratorHotelBaseRate;
        private JSONHoldingNumberTextGenerator fieldGeneratorHotelNightlyBaseRate;
        private JSONHoldingNumberTextGenerator fieldGeneratorHotelNightlyMinBaseRate;
        private JSONHoldingNumberTextGenerator fieldGeneratorHotelNightlyMaxBaseRate;
        private JSONHoldingBooleanGenerator fieldGeneratorHotelShowPriceRange;
        private JSONHoldingNumberTextGenerator fieldGeneratorHotelTaxesAndFeesRate;
        private JSONHoldingNumberTextGenerator fieldGeneratorHotelMandatoryTaxesAndFeesRate;
        private JSONHoldingNumberTextGenerator fieldGeneratorHotelTotalRate;
        private JSONHoldingNumberTextGenerator fieldGeneratorHotelNightlyTotalRate;

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
            HotelPricingJSON result = new HotelPricingJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(HotelPricingJSON result)
          {
            if (fieldGeneratorHotelRateCurrency.have_value)
              {
                result.setHotelRateCurrency(fieldGeneratorHotelRateCurrency.value);
                fieldGeneratorHotelRateCurrency.have_value = false;
              }
            if (fieldGeneratorHotelRateCurrencySymbol.have_value)
              {
                result.setHotelRateCurrencySymbol(fieldGeneratorHotelRateCurrencySymbol.value);
                fieldGeneratorHotelRateCurrencySymbol.have_value = false;
              }
            if (fieldGeneratorHotelBaseRate.have_value)
              {
                result.setHotelBaseRateText(fieldGeneratorHotelBaseRate.value);
                fieldGeneratorHotelBaseRate.have_value = false;
              }
            if (fieldGeneratorHotelNightlyBaseRate.have_value)
              {
                result.setHotelNightlyBaseRateText(fieldGeneratorHotelNightlyBaseRate.value);
                fieldGeneratorHotelNightlyBaseRate.have_value = false;
              }
            if (fieldGeneratorHotelNightlyMinBaseRate.have_value)
              {
                result.setHotelNightlyMinBaseRateText(fieldGeneratorHotelNightlyMinBaseRate.value);
                fieldGeneratorHotelNightlyMinBaseRate.have_value = false;
              }
            if (fieldGeneratorHotelNightlyMaxBaseRate.have_value)
              {
                result.setHotelNightlyMaxBaseRateText(fieldGeneratorHotelNightlyMaxBaseRate.value);
                fieldGeneratorHotelNightlyMaxBaseRate.have_value = false;
              }
            if (fieldGeneratorHotelShowPriceRange.have_value)
              {
                result.setHotelShowPriceRange(fieldGeneratorHotelShowPriceRange.value);
                fieldGeneratorHotelShowPriceRange.have_value = false;
              }
            if (fieldGeneratorHotelTaxesAndFeesRate.have_value)
              {
                result.setHotelTaxesAndFeesRateText(fieldGeneratorHotelTaxesAndFeesRate.value);
                fieldGeneratorHotelTaxesAndFeesRate.have_value = false;
              }
            if (fieldGeneratorHotelMandatoryTaxesAndFeesRate.have_value)
              {
                result.setHotelMandatoryTaxesAndFeesRateText(fieldGeneratorHotelMandatoryTaxesAndFeesRate.value);
                fieldGeneratorHotelMandatoryTaxesAndFeesRate.have_value = false;
              }
            if (fieldGeneratorHotelTotalRate.have_value)
              {
                result.setHotelTotalRateText(fieldGeneratorHotelTotalRate.value);
                fieldGeneratorHotelTotalRate.have_value = false;
              }
            if (fieldGeneratorHotelNightlyTotalRate.have_value)
              {
                result.setHotelNightlyTotalRateText(fieldGeneratorHotelNightlyTotalRate.value);
                fieldGeneratorHotelNightlyTotalRate.have_value = false;
              }
          }
        protected abstract void handle_result(HotelPricingJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Hotel", 0, 5, false) == 0)
              {
                switch (field_name[5])
                  {
                    case 'B':
                        if ((String.Compare(field_name, 6, "aseRate", 0, 7, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorHotelBaseRate;
                        break;
                    case 'M':
                        if ((String.Compare(field_name, 6, "andatoryTaxesAndFeesRate", 0, 24, false) == 0) && (field_name.Length == 30))
                            return fieldGeneratorHotelMandatoryTaxesAndFeesRate;
                        break;
                    case 'N':
                        if (String.Compare(field_name, 6, "ightly", 0, 6, false) == 0)
                          {
                            switch (field_name[12])
                              {
                                case 'B':
                                    if ((String.Compare(field_name, 13, "aseRate", 0, 7, false) == 0) && (field_name.Length == 20))
                                        return fieldGeneratorHotelNightlyBaseRate;
                                    break;
                                case 'M':
                                    switch (field_name[13])
                                      {
                                        case 'a':
                                            if ((String.Compare(field_name, 14, "xBaseRate", 0, 9, false) == 0) && (field_name.Length == 23))
                                                return fieldGeneratorHotelNightlyMaxBaseRate;
                                            break;
                                        case 'i':
                                            if ((String.Compare(field_name, 14, "nBaseRate", 0, 9, false) == 0) && (field_name.Length == 23))
                                                return fieldGeneratorHotelNightlyMinBaseRate;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 13, "otalRate", 0, 8, false) == 0) && (field_name.Length == 21))
                                        return fieldGeneratorHotelNightlyTotalRate;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'R':
                        if (String.Compare(field_name, 6, "ateCurrency", 0, 11, false) == 0)
                          {
                            if (field_name.Length == 17)
                              {
                                return fieldGeneratorHotelRateCurrency;
                              }
                            switch (field_name[17])
                              {
                                case 'S':
                                    if ((String.Compare(field_name, 18, "ymbol", 0, 5, false) == 0) && (field_name.Length == 23))
                                        return fieldGeneratorHotelRateCurrencySymbol;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 6, "howPriceRange", 0, 13, false) == 0) && (field_name.Length == 19))
                            return fieldGeneratorHotelShowPriceRange;
                        break;
                    case 'T':
                        switch (field_name[6])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 7, "xesAndFeesRate", 0, 14, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorHotelTaxesAndFeesRate;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 7, "talRate", 0, 7, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorHotelTotalRate;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorHotelRateCurrency = new JSONHoldingStringGenerator("field \"HotelRateCurrency\" of the HotelPricing class");
            fieldGeneratorHotelRateCurrencySymbol = new JSONHoldingStringGenerator("field \"HotelRateCurrencySymbol\" of the HotelPricing class");
            fieldGeneratorHotelBaseRate = new JSONHoldingNumberTextGenerator("field \"HotelBaseRate\" of the HotelPricing class");
            fieldGeneratorHotelNightlyBaseRate = new JSONHoldingNumberTextGenerator("field \"HotelNightlyBaseRate\" of the HotelPricing class");
            fieldGeneratorHotelNightlyMinBaseRate = new JSONHoldingNumberTextGenerator("field \"HotelNightlyMinBaseRate\" of the HotelPricing class");
            fieldGeneratorHotelNightlyMaxBaseRate = new JSONHoldingNumberTextGenerator("field \"HotelNightlyMaxBaseRate\" of the HotelPricing class");
            fieldGeneratorHotelShowPriceRange = new JSONHoldingBooleanGenerator("field \"HotelShowPriceRange\" of the HotelPricing class");
            fieldGeneratorHotelTaxesAndFeesRate = new JSONHoldingNumberTextGenerator("field \"HotelTaxesAndFeesRate\" of the HotelPricing class");
            fieldGeneratorHotelMandatoryTaxesAndFeesRate = new JSONHoldingNumberTextGenerator("field \"HotelMandatoryTaxesAndFeesRate\" of the HotelPricing class");
            fieldGeneratorHotelTotalRate = new JSONHoldingNumberTextGenerator("field \"HotelTotalRate\" of the HotelPricing class");
            fieldGeneratorHotelNightlyTotalRate = new JSONHoldingNumberTextGenerator("field \"HotelNightlyTotalRate\" of the HotelPricing class");
            set_what("the HotelPricing class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorHotelRateCurrency = new JSONHoldingStringGenerator("field \"HotelRateCurrency\" of the HotelPricing class");
            fieldGeneratorHotelRateCurrencySymbol = new JSONHoldingStringGenerator("field \"HotelRateCurrencySymbol\" of the HotelPricing class");
            fieldGeneratorHotelBaseRate = new JSONHoldingNumberTextGenerator("field \"HotelBaseRate\" of the HotelPricing class");
            fieldGeneratorHotelNightlyBaseRate = new JSONHoldingNumberTextGenerator("field \"HotelNightlyBaseRate\" of the HotelPricing class");
            fieldGeneratorHotelNightlyMinBaseRate = new JSONHoldingNumberTextGenerator("field \"HotelNightlyMinBaseRate\" of the HotelPricing class");
            fieldGeneratorHotelNightlyMaxBaseRate = new JSONHoldingNumberTextGenerator("field \"HotelNightlyMaxBaseRate\" of the HotelPricing class");
            fieldGeneratorHotelShowPriceRange = new JSONHoldingBooleanGenerator("field \"HotelShowPriceRange\" of the HotelPricing class");
            fieldGeneratorHotelTaxesAndFeesRate = new JSONHoldingNumberTextGenerator("field \"HotelTaxesAndFeesRate\" of the HotelPricing class");
            fieldGeneratorHotelMandatoryTaxesAndFeesRate = new JSONHoldingNumberTextGenerator("field \"HotelMandatoryTaxesAndFeesRate\" of the HotelPricing class");
            fieldGeneratorHotelTotalRate = new JSONHoldingNumberTextGenerator("field \"HotelTotalRate\" of the HotelPricing class");
            fieldGeneratorHotelNightlyTotalRate = new JSONHoldingNumberTextGenerator("field \"HotelNightlyTotalRate\" of the HotelPricing class");
            set_what("the HotelPricing class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorHotelRateCurrency.reset();
            fieldGeneratorHotelRateCurrencySymbol.reset();
            fieldGeneratorHotelBaseRate.reset();
            fieldGeneratorHotelNightlyBaseRate.reset();
            fieldGeneratorHotelNightlyMinBaseRate.reset();
            fieldGeneratorHotelNightlyMaxBaseRate.reset();
            fieldGeneratorHotelShowPriceRange.reset();
            fieldGeneratorHotelTaxesAndFeesRate.reset();
            fieldGeneratorHotelMandatoryTaxesAndFeesRate.reset();
            fieldGeneratorHotelTotalRate.reset();
            fieldGeneratorHotelNightlyTotalRate.reset();
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
        protected override void handle_result(HotelPricingJSON  result)
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
        public HotelPricingJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HotelPricingJSON  result)
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
    protected virtual void handle_result(List<HotelPricingJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HotelPricingJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HotelPricingJSON>();
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
    public List<HotelPricingJSON> value;
  };
  };
