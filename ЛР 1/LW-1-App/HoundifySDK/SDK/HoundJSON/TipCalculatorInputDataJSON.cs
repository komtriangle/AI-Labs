/* file "TipCalculatorInputDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class TipCalculatorInputDataJSON : JSONBase
  {
    private bool flagHasNextRequest;
    private string storeNextRequest;
    private bool flagHasLastRequest;
    private string storeLastRequest;
    private bool flagHasBillAmount;
    private MoneyJSON  storeBillAmount;
    private bool flagHasBillAmountIsNew;
    private bool storeBillAmountIsNew;
    private bool flagHasTaxPercentage;
    private double storeTaxPercentage;
    private string textStoreTaxPercentage;
    private bool flagHasTaxPercentageIsNew;
    private bool storeTaxPercentageIsNew;
    private bool flagHasTaxAmount;
    private MoneyJSON  storeTaxAmount;
    private bool flagHasTaxAmountIsNew;
    private bool storeTaxAmountIsNew;
    private bool flagHasTipPercentage;
    private double storeTipPercentage;
    private string textStoreTipPercentage;
    private bool flagHasTipPercentageIsNew;
    private bool storeTipPercentageIsNew;
    private bool flagHasTipAmount;
    private MoneyJSON  storeTipAmount;
    private bool flagHasTipAmountIsNew;
    private bool storeTipAmountIsNew;
    private bool flagHasRoundingAmount;
    private MoneyJSON  storeRoundingAmount;
    private bool flagHasRoundingAmountIsNew;
    private bool storeRoundingAmountIsNew;
    private bool flagHasPartySize;
    private BigInteger storePartySize;
    private bool flagHasPartySizeIsNew;
    private bool storePartySizeIsNew;
    private bool flagHasTotalAmount;
    private MoneyJSON  storeTotalAmount;
    private bool flagHasTotalAmountIsNew;
    private bool storeTotalAmountIsNew;
    private bool flagHasAmbiguousAmount;
    private MoneyJSON  storeAmbiguousAmount;
    private bool flagHasAmbiguousAmountIsNew;
    private bool storeAmbiguousAmountIsNew;
    private bool flagHasCalculationType;
    private string storeCalculationType;
    private bool flagHasCalculationTypeIsNew;
    private bool storeCalculationTypeIsNew;
    private bool flagHasMethodType;
    private string storeMethodType;
    private bool flagHasMethodTypeIsNew;
    private bool storeMethodTypeIsNew;
    private bool flagHasDoNotKnow;
    private bool storeDoNotKnow;
    private bool flagHasWantToKnow;
    private bool storeWantToKnow;
    private bool flagHasTipCalculatorStart;
    private bool storeTipCalculatorStart;
    private bool flagHasUserConfused;
    private bool storeUserConfused;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONNextRequest(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NextRequest of TipCalculatorInputDataJSON is not a string.");
        setNextRequest(json_string.getData());
      }


    private void  fromJSONLastRequest(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LastRequest of TipCalculatorInputDataJSON is not a string.");
        setLastRequest(json_string.getData());
      }


    private void  fromJSONBillAmount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setBillAmount(convert_classy);
      }


    private void  fromJSONBillAmountIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field BillAmountIsNew of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setBillAmountIsNew(the_bool);
      }


    private void  fromJSONTaxPercentage(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TaxPercentage of TipCalculatorInputDataJSON is not a number.");
              }
          }
        setTaxPercentageText(the_rational_text);
      }


    private void  fromJSONTaxPercentageIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TaxPercentageIsNew of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setTaxPercentageIsNew(the_bool);
      }


    private void  fromJSONTaxAmount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setTaxAmount(convert_classy);
      }


    private void  fromJSONTaxAmountIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TaxAmountIsNew of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setTaxAmountIsNew(the_bool);
      }


    private void  fromJSONTipPercentage(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TipPercentage of TipCalculatorInputDataJSON is not a number.");
              }
          }
        setTipPercentageText(the_rational_text);
      }


    private void  fromJSONTipPercentageIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TipPercentageIsNew of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setTipPercentageIsNew(the_bool);
      }


    private void  fromJSONTipAmount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setTipAmount(convert_classy);
      }


    private void  fromJSONTipAmountIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TipAmountIsNew of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setTipAmountIsNew(the_bool);
      }


    private void  fromJSONRoundingAmount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setRoundingAmount(convert_classy);
      }


    private void  fromJSONRoundingAmountIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RoundingAmountIsNew of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setRoundingAmountIsNew(the_bool);
      }


    private void  fromJSONPartySize(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PartySize of TipCalculatorInputDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PartySize of TipCalculatorInputDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPartySize(extracted_integer);
      }


    private void  fromJSONPartySizeIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PartySizeIsNew of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setPartySizeIsNew(the_bool);
      }


    private void  fromJSONTotalAmount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setTotalAmount(convert_classy);
      }


    private void  fromJSONTotalAmountIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TotalAmountIsNew of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setTotalAmountIsNew(the_bool);
      }


    private void  fromJSONAmbiguousAmount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setAmbiguousAmount(convert_classy);
      }


    private void  fromJSONAmbiguousAmountIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AmbiguousAmountIsNew of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setAmbiguousAmountIsNew(the_bool);
      }


    private void  fromJSONCalculationType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CalculationType of TipCalculatorInputDataJSON is not a string.");
        setCalculationType(json_string.getData());
      }


    private void  fromJSONCalculationTypeIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CalculationTypeIsNew of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setCalculationTypeIsNew(the_bool);
      }


    private void  fromJSONMethodType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MethodType of TipCalculatorInputDataJSON is not a string.");
        setMethodType(json_string.getData());
      }


    private void  fromJSONMethodTypeIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MethodTypeIsNew of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setMethodTypeIsNew(the_bool);
      }


    private void  fromJSONDoNotKnow(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DoNotKnow of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setDoNotKnow(the_bool);
      }


    private void  fromJSONWantToKnow(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field WantToKnow of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setWantToKnow(the_bool);
      }


    private void  fromJSONTipCalculatorStart(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TipCalculatorStart of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setTipCalculatorStart(the_bool);
      }


    private void  fromJSONUserConfused(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserConfused of TipCalculatorInputDataJSON is not true for false.");
              }
          }
        setUserConfused(the_bool);
      }


    public TipCalculatorInputDataJSON()
      {
        flagHasNextRequest = false;
        flagHasLastRequest = false;
        flagHasBillAmount = false;
        flagHasBillAmountIsNew = false;
        flagHasTaxPercentage = false;
        flagHasTaxPercentageIsNew = false;
        flagHasTaxAmount = false;
        flagHasTaxAmountIsNew = false;
        flagHasTipPercentage = false;
        flagHasTipPercentageIsNew = false;
        flagHasTipAmount = false;
        flagHasTipAmountIsNew = false;
        flagHasRoundingAmount = false;
        flagHasRoundingAmountIsNew = false;
        flagHasPartySize = false;
        flagHasPartySizeIsNew = false;
        flagHasTotalAmount = false;
        flagHasTotalAmountIsNew = false;
        flagHasAmbiguousAmount = false;
        flagHasAmbiguousAmountIsNew = false;
        flagHasCalculationType = false;
        flagHasCalculationTypeIsNew = false;
        flagHasMethodType = false;
        flagHasMethodTypeIsNew = false;
        flagHasDoNotKnow = false;
        flagHasWantToKnow = false;
        flagHasTipCalculatorStart = false;
        flagHasUserConfused = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasNextRequest()
      {
        return flagHasNextRequest;
      }

    public string  getNextRequest()
      {
        Debug.Assert(flagHasNextRequest);
        return storeNextRequest;
      }

    public bool  hasLastRequest()
      {
        return flagHasLastRequest;
      }

    public string  getLastRequest()
      {
        Debug.Assert(flagHasLastRequest);
        return storeLastRequest;
      }

    public bool  hasBillAmount()
      {
        return flagHasBillAmount;
      }

    public MoneyJSON   getBillAmount()
      {
        Debug.Assert(flagHasBillAmount);
        return storeBillAmount;
      }

    public bool  hasBillAmountIsNew()
      {
        return flagHasBillAmountIsNew;
      }

    public bool  getBillAmountIsNew()
      {
        Debug.Assert(flagHasBillAmountIsNew);
        return storeBillAmountIsNew;
      }

    public bool  hasTaxPercentage()
      {
        return flagHasTaxPercentage;
      }

    public double  getTaxPercentage()
      {
        Debug.Assert(flagHasTaxPercentage);
        if (textStoreTaxPercentage != "")
          {
            return Double.Parse(textStoreTaxPercentage);
          }
        return storeTaxPercentage;
      }

    public string  getTaxPercentageAsText()
      {
        Debug.Assert(flagHasTaxPercentage);
        if (textStoreTaxPercentage == "")
          {
            return Convert.ToString(storeTaxPercentage);
          }
        else
          {
            return (textStoreTaxPercentage);
          }
      }

    public bool  hasTaxPercentageIsNew()
      {
        return flagHasTaxPercentageIsNew;
      }

    public bool  getTaxPercentageIsNew()
      {
        Debug.Assert(flagHasTaxPercentageIsNew);
        return storeTaxPercentageIsNew;
      }

    public bool  hasTaxAmount()
      {
        return flagHasTaxAmount;
      }

    public MoneyJSON   getTaxAmount()
      {
        Debug.Assert(flagHasTaxAmount);
        return storeTaxAmount;
      }

    public bool  hasTaxAmountIsNew()
      {
        return flagHasTaxAmountIsNew;
      }

    public bool  getTaxAmountIsNew()
      {
        Debug.Assert(flagHasTaxAmountIsNew);
        return storeTaxAmountIsNew;
      }

    public bool  hasTipPercentage()
      {
        return flagHasTipPercentage;
      }

    public double  getTipPercentage()
      {
        Debug.Assert(flagHasTipPercentage);
        if (textStoreTipPercentage != "")
          {
            return Double.Parse(textStoreTipPercentage);
          }
        return storeTipPercentage;
      }

    public string  getTipPercentageAsText()
      {
        Debug.Assert(flagHasTipPercentage);
        if (textStoreTipPercentage == "")
          {
            return Convert.ToString(storeTipPercentage);
          }
        else
          {
            return (textStoreTipPercentage);
          }
      }

    public bool  hasTipPercentageIsNew()
      {
        return flagHasTipPercentageIsNew;
      }

    public bool  getTipPercentageIsNew()
      {
        Debug.Assert(flagHasTipPercentageIsNew);
        return storeTipPercentageIsNew;
      }

    public bool  hasTipAmount()
      {
        return flagHasTipAmount;
      }

    public MoneyJSON   getTipAmount()
      {
        Debug.Assert(flagHasTipAmount);
        return storeTipAmount;
      }

    public bool  hasTipAmountIsNew()
      {
        return flagHasTipAmountIsNew;
      }

    public bool  getTipAmountIsNew()
      {
        Debug.Assert(flagHasTipAmountIsNew);
        return storeTipAmountIsNew;
      }

    public bool  hasRoundingAmount()
      {
        return flagHasRoundingAmount;
      }

    public MoneyJSON   getRoundingAmount()
      {
        Debug.Assert(flagHasRoundingAmount);
        return storeRoundingAmount;
      }

    public bool  hasRoundingAmountIsNew()
      {
        return flagHasRoundingAmountIsNew;
      }

    public bool  getRoundingAmountIsNew()
      {
        Debug.Assert(flagHasRoundingAmountIsNew);
        return storeRoundingAmountIsNew;
      }

    public bool  hasPartySize()
      {
        return flagHasPartySize;
      }

    public BigInteger  getPartySize()
      {
        Debug.Assert(flagHasPartySize);
        return storePartySize;
      }

    public bool  hasPartySizeIsNew()
      {
        return flagHasPartySizeIsNew;
      }

    public bool  getPartySizeIsNew()
      {
        Debug.Assert(flagHasPartySizeIsNew);
        return storePartySizeIsNew;
      }

    public bool  hasTotalAmount()
      {
        return flagHasTotalAmount;
      }

    public MoneyJSON   getTotalAmount()
      {
        Debug.Assert(flagHasTotalAmount);
        return storeTotalAmount;
      }

    public bool  hasTotalAmountIsNew()
      {
        return flagHasTotalAmountIsNew;
      }

    public bool  getTotalAmountIsNew()
      {
        Debug.Assert(flagHasTotalAmountIsNew);
        return storeTotalAmountIsNew;
      }

    public bool  hasAmbiguousAmount()
      {
        return flagHasAmbiguousAmount;
      }

    public MoneyJSON   getAmbiguousAmount()
      {
        Debug.Assert(flagHasAmbiguousAmount);
        return storeAmbiguousAmount;
      }

    public bool  hasAmbiguousAmountIsNew()
      {
        return flagHasAmbiguousAmountIsNew;
      }

    public bool  getAmbiguousAmountIsNew()
      {
        Debug.Assert(flagHasAmbiguousAmountIsNew);
        return storeAmbiguousAmountIsNew;
      }

    public bool  hasCalculationType()
      {
        return flagHasCalculationType;
      }

    public string  getCalculationType()
      {
        Debug.Assert(flagHasCalculationType);
        return storeCalculationType;
      }

    public bool  hasCalculationTypeIsNew()
      {
        return flagHasCalculationTypeIsNew;
      }

    public bool  getCalculationTypeIsNew()
      {
        Debug.Assert(flagHasCalculationTypeIsNew);
        return storeCalculationTypeIsNew;
      }

    public bool  hasMethodType()
      {
        return flagHasMethodType;
      }

    public string  getMethodType()
      {
        Debug.Assert(flagHasMethodType);
        return storeMethodType;
      }

    public bool  hasMethodTypeIsNew()
      {
        return flagHasMethodTypeIsNew;
      }

    public bool  getMethodTypeIsNew()
      {
        Debug.Assert(flagHasMethodTypeIsNew);
        return storeMethodTypeIsNew;
      }

    public bool  hasDoNotKnow()
      {
        return flagHasDoNotKnow;
      }

    public bool  getDoNotKnow()
      {
        Debug.Assert(flagHasDoNotKnow);
        return storeDoNotKnow;
      }

    public bool  hasWantToKnow()
      {
        return flagHasWantToKnow;
      }

    public bool  getWantToKnow()
      {
        Debug.Assert(flagHasWantToKnow);
        return storeWantToKnow;
      }

    public bool  hasTipCalculatorStart()
      {
        return flagHasTipCalculatorStart;
      }

    public bool  getTipCalculatorStart()
      {
        Debug.Assert(flagHasTipCalculatorStart);
        return storeTipCalculatorStart;
      }

    public bool  hasUserConfused()
      {
        return flagHasUserConfused;
      }

    public bool  getUserConfused()
      {
        Debug.Assert(flagHasUserConfused);
        return storeUserConfused;
      }


    public virtual int extraTipCalculatorInputDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTipCalculatorInputDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTipCalculatorInputDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTipCalculatorInputDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setNextRequest(string new_value)
      {
        flagHasNextRequest = true;
        storeNextRequest = new_value;
      }
    public void unsetNextRequest()
      {
        flagHasNextRequest = false;
      }
    public void setLastRequest(string new_value)
      {
        flagHasLastRequest = true;
        storeLastRequest = new_value;
      }
    public void unsetLastRequest()
      {
        flagHasLastRequest = false;
      }
    public void setBillAmount(MoneyJSON  new_value)
      {
        if (flagHasBillAmount)
          {
          }
        flagHasBillAmount = true;
        storeBillAmount = new_value;
      }
    public void unsetBillAmount()
      {
        if (flagHasBillAmount)
          {
          }
        flagHasBillAmount = false;
      }
    public void setBillAmountIsNew(bool new_value)
      {
        flagHasBillAmountIsNew = true;
        storeBillAmountIsNew = new_value;
      }
    public void unsetBillAmountIsNew()
      {
        flagHasBillAmountIsNew = false;
      }
    public void setTaxPercentage(double new_value)
      {
        flagHasTaxPercentage = true;
        if (new_value < 0)
            throw new Exception("The value for field TaxPercentage of TipCalculatorInputDataJSON is less than the lower bound (0) for that field.");
        storeTaxPercentage = new_value;
        textStoreTaxPercentage = "";
      }
    public void setTaxPercentageText(string new_value)
      {
        flagHasTaxPercentage = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TaxPercentage of TipCalculatorInputDataJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field TaxPercentage of TipCalculatorInputDataJSON is less than the lower bound (0) for that field.");
        textStoreTaxPercentage = new_value;
      }
    public void unsetTaxPercentage()
      {
        flagHasTaxPercentage = false;
      }
    public void setTaxPercentageIsNew(bool new_value)
      {
        flagHasTaxPercentageIsNew = true;
        storeTaxPercentageIsNew = new_value;
      }
    public void unsetTaxPercentageIsNew()
      {
        flagHasTaxPercentageIsNew = false;
      }
    public void setTaxAmount(MoneyJSON  new_value)
      {
        if (flagHasTaxAmount)
          {
          }
        flagHasTaxAmount = true;
        storeTaxAmount = new_value;
      }
    public void unsetTaxAmount()
      {
        if (flagHasTaxAmount)
          {
          }
        flagHasTaxAmount = false;
      }
    public void setTaxAmountIsNew(bool new_value)
      {
        flagHasTaxAmountIsNew = true;
        storeTaxAmountIsNew = new_value;
      }
    public void unsetTaxAmountIsNew()
      {
        flagHasTaxAmountIsNew = false;
      }
    public void setTipPercentage(double new_value)
      {
        flagHasTipPercentage = true;
        if (new_value < 0)
            throw new Exception("The value for field TipPercentage of TipCalculatorInputDataJSON is less than the lower bound (0) for that field.");
        storeTipPercentage = new_value;
        textStoreTipPercentage = "";
      }
    public void setTipPercentageText(string new_value)
      {
        flagHasTipPercentage = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TipPercentage of TipCalculatorInputDataJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field TipPercentage of TipCalculatorInputDataJSON is less than the lower bound (0) for that field.");
        textStoreTipPercentage = new_value;
      }
    public void unsetTipPercentage()
      {
        flagHasTipPercentage = false;
      }
    public void setTipPercentageIsNew(bool new_value)
      {
        flagHasTipPercentageIsNew = true;
        storeTipPercentageIsNew = new_value;
      }
    public void unsetTipPercentageIsNew()
      {
        flagHasTipPercentageIsNew = false;
      }
    public void setTipAmount(MoneyJSON  new_value)
      {
        if (flagHasTipAmount)
          {
          }
        flagHasTipAmount = true;
        storeTipAmount = new_value;
      }
    public void unsetTipAmount()
      {
        if (flagHasTipAmount)
          {
          }
        flagHasTipAmount = false;
      }
    public void setTipAmountIsNew(bool new_value)
      {
        flagHasTipAmountIsNew = true;
        storeTipAmountIsNew = new_value;
      }
    public void unsetTipAmountIsNew()
      {
        flagHasTipAmountIsNew = false;
      }
    public void setRoundingAmount(MoneyJSON  new_value)
      {
        if (flagHasRoundingAmount)
          {
          }
        flagHasRoundingAmount = true;
        storeRoundingAmount = new_value;
      }
    public void unsetRoundingAmount()
      {
        if (flagHasRoundingAmount)
          {
          }
        flagHasRoundingAmount = false;
      }
    public void setRoundingAmountIsNew(bool new_value)
      {
        flagHasRoundingAmountIsNew = true;
        storeRoundingAmountIsNew = new_value;
      }
    public void unsetRoundingAmountIsNew()
      {
        flagHasRoundingAmountIsNew = false;
      }
    public void setPartySize(BigInteger new_value)
      {
        flagHasPartySize = true;
        if (new_value < 1)
            throw new Exception("The value for field PartySize of TipCalculatorInputDataJSON is less than the lower bound (1) for that field.");
        storePartySize = new_value;
      }
    public void unsetPartySize()
      {
        flagHasPartySize = false;
      }
    public void setPartySizeIsNew(bool new_value)
      {
        flagHasPartySizeIsNew = true;
        storePartySizeIsNew = new_value;
      }
    public void unsetPartySizeIsNew()
      {
        flagHasPartySizeIsNew = false;
      }
    public void setTotalAmount(MoneyJSON  new_value)
      {
        if (flagHasTotalAmount)
          {
          }
        flagHasTotalAmount = true;
        storeTotalAmount = new_value;
      }
    public void unsetTotalAmount()
      {
        if (flagHasTotalAmount)
          {
          }
        flagHasTotalAmount = false;
      }
    public void setTotalAmountIsNew(bool new_value)
      {
        flagHasTotalAmountIsNew = true;
        storeTotalAmountIsNew = new_value;
      }
    public void unsetTotalAmountIsNew()
      {
        flagHasTotalAmountIsNew = false;
      }
    public void setAmbiguousAmount(MoneyJSON  new_value)
      {
        if (flagHasAmbiguousAmount)
          {
          }
        flagHasAmbiguousAmount = true;
        storeAmbiguousAmount = new_value;
      }
    public void unsetAmbiguousAmount()
      {
        if (flagHasAmbiguousAmount)
          {
          }
        flagHasAmbiguousAmount = false;
      }
    public void setAmbiguousAmountIsNew(bool new_value)
      {
        flagHasAmbiguousAmountIsNew = true;
        storeAmbiguousAmountIsNew = new_value;
      }
    public void unsetAmbiguousAmountIsNew()
      {
        flagHasAmbiguousAmountIsNew = false;
      }
    public void setCalculationType(string new_value)
      {
        flagHasCalculationType = true;
        storeCalculationType = new_value;
      }
    public void unsetCalculationType()
      {
        flagHasCalculationType = false;
      }
    public void setCalculationTypeIsNew(bool new_value)
      {
        flagHasCalculationTypeIsNew = true;
        storeCalculationTypeIsNew = new_value;
      }
    public void unsetCalculationTypeIsNew()
      {
        flagHasCalculationTypeIsNew = false;
      }
    public void setMethodType(string new_value)
      {
        flagHasMethodType = true;
        storeMethodType = new_value;
      }
    public void unsetMethodType()
      {
        flagHasMethodType = false;
      }
    public void setMethodTypeIsNew(bool new_value)
      {
        flagHasMethodTypeIsNew = true;
        storeMethodTypeIsNew = new_value;
      }
    public void unsetMethodTypeIsNew()
      {
        flagHasMethodTypeIsNew = false;
      }
    public void setDoNotKnow(bool new_value)
      {
        flagHasDoNotKnow = true;
        storeDoNotKnow = new_value;
      }
    public void unsetDoNotKnow()
      {
        flagHasDoNotKnow = false;
      }
    public void setWantToKnow(bool new_value)
      {
        flagHasWantToKnow = true;
        storeWantToKnow = new_value;
      }
    public void unsetWantToKnow()
      {
        flagHasWantToKnow = false;
      }
    public void setTipCalculatorStart(bool new_value)
      {
        flagHasTipCalculatorStart = true;
        storeTipCalculatorStart = new_value;
      }
    public void unsetTipCalculatorStart()
      {
        flagHasTipCalculatorStart = false;
      }
    public void setUserConfused(bool new_value)
      {
        flagHasUserConfused = true;
        storeUserConfused = new_value;
      }
    public void unsetUserConfused()
      {
        flagHasUserConfused = false;
      }

    public virtual void extraTipCalculatorInputDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTipCalculatorInputDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTipCalculatorInputDataLookup(key);
        if (old_field == null)
          {
            extraTipCalculatorInputDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNextRequest);
        if (flagHasNextRequest)
          {
            handler.start_pair("NextRequest");
            handler.string_value(storeNextRequest);
          }
        if (flagHasLastRequest)
          {
            handler.start_pair("LastRequest");
            handler.string_value(storeLastRequest);
          }
        if (flagHasBillAmount)
          {
            handler.start_pair("BillAmount");
            if (partial_allowed)
                storeBillAmount.write_partial_as_json(handler);
            else
                storeBillAmount.write_as_json(handler);
          }
        if (flagHasBillAmountIsNew)
          {
            handler.start_pair("BillAmountIsNew");
            handler.boolean_value(storeBillAmountIsNew);
          }
        if (flagHasTaxPercentage)
          {
            handler.start_pair("TaxPercentage");
            if (textStoreTaxPercentage != "")
                handler.number_value(textStoreTaxPercentage);
            else if (((double)(long)storeTaxPercentage) == storeTaxPercentage)
                handler.number_value((long)storeTaxPercentage);
            else
                handler.number_value(storeTaxPercentage);
          }
        if (flagHasTaxPercentageIsNew)
          {
            handler.start_pair("TaxPercentageIsNew");
            handler.boolean_value(storeTaxPercentageIsNew);
          }
        if (flagHasTaxAmount)
          {
            handler.start_pair("TaxAmount");
            if (partial_allowed)
                storeTaxAmount.write_partial_as_json(handler);
            else
                storeTaxAmount.write_as_json(handler);
          }
        if (flagHasTaxAmountIsNew)
          {
            handler.start_pair("TaxAmountIsNew");
            handler.boolean_value(storeTaxAmountIsNew);
          }
        if (flagHasTipPercentage)
          {
            handler.start_pair("TipPercentage");
            if (textStoreTipPercentage != "")
                handler.number_value(textStoreTipPercentage);
            else if (((double)(long)storeTipPercentage) == storeTipPercentage)
                handler.number_value((long)storeTipPercentage);
            else
                handler.number_value(storeTipPercentage);
          }
        if (flagHasTipPercentageIsNew)
          {
            handler.start_pair("TipPercentageIsNew");
            handler.boolean_value(storeTipPercentageIsNew);
          }
        if (flagHasTipAmount)
          {
            handler.start_pair("TipAmount");
            if (partial_allowed)
                storeTipAmount.write_partial_as_json(handler);
            else
                storeTipAmount.write_as_json(handler);
          }
        if (flagHasTipAmountIsNew)
          {
            handler.start_pair("TipAmountIsNew");
            handler.boolean_value(storeTipAmountIsNew);
          }
        if (flagHasRoundingAmount)
          {
            handler.start_pair("RoundingAmount");
            if (partial_allowed)
                storeRoundingAmount.write_partial_as_json(handler);
            else
                storeRoundingAmount.write_as_json(handler);
          }
        if (flagHasRoundingAmountIsNew)
          {
            handler.start_pair("RoundingAmountIsNew");
            handler.boolean_value(storeRoundingAmountIsNew);
          }
        if (flagHasPartySize)
          {
            handler.start_pair("PartySize");
            handler.number_value(storePartySize);
          }
        if (flagHasPartySizeIsNew)
          {
            handler.start_pair("PartySizeIsNew");
            handler.boolean_value(storePartySizeIsNew);
          }
        if (flagHasTotalAmount)
          {
            handler.start_pair("TotalAmount");
            if (partial_allowed)
                storeTotalAmount.write_partial_as_json(handler);
            else
                storeTotalAmount.write_as_json(handler);
          }
        if (flagHasTotalAmountIsNew)
          {
            handler.start_pair("TotalAmountIsNew");
            handler.boolean_value(storeTotalAmountIsNew);
          }
        if (flagHasAmbiguousAmount)
          {
            handler.start_pair("AmbiguousAmount");
            if (partial_allowed)
                storeAmbiguousAmount.write_partial_as_json(handler);
            else
                storeAmbiguousAmount.write_as_json(handler);
          }
        if (flagHasAmbiguousAmountIsNew)
          {
            handler.start_pair("AmbiguousAmountIsNew");
            handler.boolean_value(storeAmbiguousAmountIsNew);
          }
        Debug.Assert(partial_allowed || flagHasCalculationType);
        if (flagHasCalculationType)
          {
            handler.start_pair("CalculationType");
            handler.string_value(storeCalculationType);
          }
        if (flagHasCalculationTypeIsNew)
          {
            handler.start_pair("CalculationTypeIsNew");
            handler.boolean_value(storeCalculationTypeIsNew);
          }
        Debug.Assert(partial_allowed || flagHasMethodType);
        if (flagHasMethodType)
          {
            handler.start_pair("MethodType");
            handler.string_value(storeMethodType);
          }
        if (flagHasMethodTypeIsNew)
          {
            handler.start_pair("MethodTypeIsNew");
            handler.boolean_value(storeMethodTypeIsNew);
          }
        if (flagHasDoNotKnow)
          {
            handler.start_pair("DoNotKnow");
            handler.boolean_value(storeDoNotKnow);
          }
        if (flagHasWantToKnow)
          {
            handler.start_pair("WantToKnow");
            handler.boolean_value(storeWantToKnow);
          }
        if (flagHasTipCalculatorStart)
          {
            handler.start_pair("TipCalculatorStart");
            handler.boolean_value(storeTipCalculatorStart);
          }
        if (flagHasUserConfused)
          {
            handler.start_pair("UserConfused");
            handler.boolean_value(storeUserConfused);
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
        if (!(hasNextRequest()))
          {
            return "When parsing the object for %what%, the \"NextRequest\" field was missing.";
          }
        if (!(hasCalculationType()))
          {
            return "When parsing the object for %what%, the \"CalculationType\" field was missing.";
          }
        if (!(hasMethodType()))
          {
            return "When parsing the object for %what%, the \"MethodType\" field was missing.";
          }
        return null;
      }

    public static TipCalculatorInputDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TipCalculatorInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TipCalculatorInputData", ignore_extras);
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
    public static TipCalculatorInputDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TipCalculatorInputDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TipCalculatorInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TipCalculatorInputData", ignore_extras);
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
    public static TipCalculatorInputDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TipCalculatorInputDataJSON from_text(string text, bool ignore_extras)
      {
        TipCalculatorInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TipCalculatorInputData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TipCalculatorInputDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TipCalculatorInputDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TipCalculatorInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TipCalculatorInputData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorNextRequest;
        private JSONHoldingStringGenerator fieldGeneratorLastRequest;
        private MoneyJSON.HoldingGenerator fieldGeneratorBillAmount;
        private JSONHoldingBooleanGenerator fieldGeneratorBillAmountIsNew;
        private JSONHoldingNumberTextGenerator fieldGeneratorTaxPercentage;
        private JSONHoldingBooleanGenerator fieldGeneratorTaxPercentageIsNew;
        private MoneyJSON.HoldingGenerator fieldGeneratorTaxAmount;
        private JSONHoldingBooleanGenerator fieldGeneratorTaxAmountIsNew;
        private JSONHoldingNumberTextGenerator fieldGeneratorTipPercentage;
        private JSONHoldingBooleanGenerator fieldGeneratorTipPercentageIsNew;
        private MoneyJSON.HoldingGenerator fieldGeneratorTipAmount;
        private JSONHoldingBooleanGenerator fieldGeneratorTipAmountIsNew;
        private MoneyJSON.HoldingGenerator fieldGeneratorRoundingAmount;
        private JSONHoldingBooleanGenerator fieldGeneratorRoundingAmountIsNew;
    private class FieldHoldingGeneratorPartySize : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorPartySize(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorPartySize : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorPartySize(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorPartySize fieldGeneratorPartySize;
        private JSONHoldingBooleanGenerator fieldGeneratorPartySizeIsNew;
        private MoneyJSON.HoldingGenerator fieldGeneratorTotalAmount;
        private JSONHoldingBooleanGenerator fieldGeneratorTotalAmountIsNew;
        private MoneyJSON.HoldingGenerator fieldGeneratorAmbiguousAmount;
        private JSONHoldingBooleanGenerator fieldGeneratorAmbiguousAmountIsNew;
        private JSONHoldingStringGenerator fieldGeneratorCalculationType;
        private JSONHoldingBooleanGenerator fieldGeneratorCalculationTypeIsNew;
        private JSONHoldingStringGenerator fieldGeneratorMethodType;
        private JSONHoldingBooleanGenerator fieldGeneratorMethodTypeIsNew;
        private JSONHoldingBooleanGenerator fieldGeneratorDoNotKnow;
        private JSONHoldingBooleanGenerator fieldGeneratorWantToKnow;
        private JSONHoldingBooleanGenerator fieldGeneratorTipCalculatorStart;
        private JSONHoldingBooleanGenerator fieldGeneratorUserConfused;
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
            TipCalculatorInputDataJSON result = new TipCalculatorInputDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTipCalculatorInputDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TipCalculatorInputDataJSON result)
          {
            if (fieldGeneratorNextRequest.have_value)
              {
                result.setNextRequest(fieldGeneratorNextRequest.value);
                fieldGeneratorNextRequest.have_value = false;
              }
            else if ((!(result.hasNextRequest())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NextRequest\" field was missing.");
              }
            if (fieldGeneratorLastRequest.have_value)
              {
                result.setLastRequest(fieldGeneratorLastRequest.value);
                fieldGeneratorLastRequest.have_value = false;
              }
            if (fieldGeneratorBillAmount.have_value)
              {
                result.setBillAmount(fieldGeneratorBillAmount.value);
                fieldGeneratorBillAmount.have_value = false;
              }
            if (fieldGeneratorBillAmountIsNew.have_value)
              {
                result.setBillAmountIsNew(fieldGeneratorBillAmountIsNew.value);
                fieldGeneratorBillAmountIsNew.have_value = false;
              }
            if (fieldGeneratorTaxPercentage.have_value)
              {
                result.setTaxPercentageText(fieldGeneratorTaxPercentage.value);
                fieldGeneratorTaxPercentage.have_value = false;
              }
            if (fieldGeneratorTaxPercentageIsNew.have_value)
              {
                result.setTaxPercentageIsNew(fieldGeneratorTaxPercentageIsNew.value);
                fieldGeneratorTaxPercentageIsNew.have_value = false;
              }
            if (fieldGeneratorTaxAmount.have_value)
              {
                result.setTaxAmount(fieldGeneratorTaxAmount.value);
                fieldGeneratorTaxAmount.have_value = false;
              }
            if (fieldGeneratorTaxAmountIsNew.have_value)
              {
                result.setTaxAmountIsNew(fieldGeneratorTaxAmountIsNew.value);
                fieldGeneratorTaxAmountIsNew.have_value = false;
              }
            if (fieldGeneratorTipPercentage.have_value)
              {
                result.setTipPercentageText(fieldGeneratorTipPercentage.value);
                fieldGeneratorTipPercentage.have_value = false;
              }
            if (fieldGeneratorTipPercentageIsNew.have_value)
              {
                result.setTipPercentageIsNew(fieldGeneratorTipPercentageIsNew.value);
                fieldGeneratorTipPercentageIsNew.have_value = false;
              }
            if (fieldGeneratorTipAmount.have_value)
              {
                result.setTipAmount(fieldGeneratorTipAmount.value);
                fieldGeneratorTipAmount.have_value = false;
              }
            if (fieldGeneratorTipAmountIsNew.have_value)
              {
                result.setTipAmountIsNew(fieldGeneratorTipAmountIsNew.value);
                fieldGeneratorTipAmountIsNew.have_value = false;
              }
            if (fieldGeneratorRoundingAmount.have_value)
              {
                result.setRoundingAmount(fieldGeneratorRoundingAmount.value);
                fieldGeneratorRoundingAmount.have_value = false;
              }
            if (fieldGeneratorRoundingAmountIsNew.have_value)
              {
                result.setRoundingAmountIsNew(fieldGeneratorRoundingAmountIsNew.value);
                fieldGeneratorRoundingAmountIsNew.have_value = false;
              }
            if (fieldGeneratorPartySize.have_value)
              {
                result.setPartySize(fieldGeneratorPartySize.value);
                fieldGeneratorPartySize.have_value = false;
              }
            if (fieldGeneratorPartySizeIsNew.have_value)
              {
                result.setPartySizeIsNew(fieldGeneratorPartySizeIsNew.value);
                fieldGeneratorPartySizeIsNew.have_value = false;
              }
            if (fieldGeneratorTotalAmount.have_value)
              {
                result.setTotalAmount(fieldGeneratorTotalAmount.value);
                fieldGeneratorTotalAmount.have_value = false;
              }
            if (fieldGeneratorTotalAmountIsNew.have_value)
              {
                result.setTotalAmountIsNew(fieldGeneratorTotalAmountIsNew.value);
                fieldGeneratorTotalAmountIsNew.have_value = false;
              }
            if (fieldGeneratorAmbiguousAmount.have_value)
              {
                result.setAmbiguousAmount(fieldGeneratorAmbiguousAmount.value);
                fieldGeneratorAmbiguousAmount.have_value = false;
              }
            if (fieldGeneratorAmbiguousAmountIsNew.have_value)
              {
                result.setAmbiguousAmountIsNew(fieldGeneratorAmbiguousAmountIsNew.value);
                fieldGeneratorAmbiguousAmountIsNew.have_value = false;
              }
            if (fieldGeneratorCalculationType.have_value)
              {
                result.setCalculationType(fieldGeneratorCalculationType.value);
                fieldGeneratorCalculationType.have_value = false;
              }
            else if ((!(result.hasCalculationType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CalculationType\" field was missing.");
              }
            if (fieldGeneratorCalculationTypeIsNew.have_value)
              {
                result.setCalculationTypeIsNew(fieldGeneratorCalculationTypeIsNew.value);
                fieldGeneratorCalculationTypeIsNew.have_value = false;
              }
            if (fieldGeneratorMethodType.have_value)
              {
                result.setMethodType(fieldGeneratorMethodType.value);
                fieldGeneratorMethodType.have_value = false;
              }
            else if ((!(result.hasMethodType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MethodType\" field was missing.");
              }
            if (fieldGeneratorMethodTypeIsNew.have_value)
              {
                result.setMethodTypeIsNew(fieldGeneratorMethodTypeIsNew.value);
                fieldGeneratorMethodTypeIsNew.have_value = false;
              }
            if (fieldGeneratorDoNotKnow.have_value)
              {
                result.setDoNotKnow(fieldGeneratorDoNotKnow.value);
                fieldGeneratorDoNotKnow.have_value = false;
              }
            if (fieldGeneratorWantToKnow.have_value)
              {
                result.setWantToKnow(fieldGeneratorWantToKnow.value);
                fieldGeneratorWantToKnow.have_value = false;
              }
            if (fieldGeneratorTipCalculatorStart.have_value)
              {
                result.setTipCalculatorStart(fieldGeneratorTipCalculatorStart.value);
                fieldGeneratorTipCalculatorStart.have_value = false;
              }
            if (fieldGeneratorUserConfused.have_value)
              {
                result.setUserConfused(fieldGeneratorUserConfused.value);
                fieldGeneratorUserConfused.have_value = false;
              }
          }
        protected abstract void handle_result(TipCalculatorInputDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "mbiguousAmount", 0, 14, false) == 0)
                      {
                        if (field_name.Length == 15)
                          {
                            return fieldGeneratorAmbiguousAmount;
                          }
                        switch (field_name[15])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 16, "sNew", 0, 4, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorAmbiguousAmountIsNew;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'B':
                    if (String.Compare(field_name, 1, "illAmount", 0, 9, false) == 0)
                      {
                        if (field_name.Length == 10)
                          {
                            return fieldGeneratorBillAmount;
                          }
                        switch (field_name[10])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 11, "sNew", 0, 4, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorBillAmountIsNew;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'C':
                    if (String.Compare(field_name, 1, "alculationType", 0, 14, false) == 0)
                      {
                        if (field_name.Length == 15)
                          {
                            return fieldGeneratorCalculationType;
                          }
                        switch (field_name[15])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 16, "sNew", 0, 4, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorCalculationTypeIsNew;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "oNotKnow", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorDoNotKnow;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astRequest", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorLastRequest;
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "ethodType", 0, 9, false) == 0)
                      {
                        if (field_name.Length == 10)
                          {
                            return fieldGeneratorMethodType;
                          }
                        switch (field_name[10])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 11, "sNew", 0, 4, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorMethodTypeIsNew;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "extRequest", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorNextRequest;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "artySize", 0, 8, false) == 0)
                      {
                        if (field_name.Length == 9)
                          {
                            return fieldGeneratorPartySize;
                          }
                        switch (field_name[9])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 10, "sNew", 0, 4, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorPartySizeIsNew;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "oundingAmount", 0, 13, false) == 0)
                      {
                        if (field_name.Length == 14)
                          {
                            return fieldGeneratorRoundingAmount;
                          }
                        switch (field_name[14])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 15, "sNew", 0, 4, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorRoundingAmountIsNew;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "x", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'A':
                                        if (String.Compare(field_name, 4, "mount", 0, 5, false) == 0)
                                          {
                                            if (field_name.Length == 9)
                                              {
                                                return fieldGeneratorTaxAmount;
                                              }
                                            switch (field_name[9])
                                              {
                                                case 'I':
                                                    if ((String.Compare(field_name, 10, "sNew", 0, 4, false) == 0) && (field_name.Length == 14))
                                                        return fieldGeneratorTaxAmountIsNew;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'P':
                                        if (String.Compare(field_name, 4, "ercentage", 0, 9, false) == 0)
                                          {
                                            if (field_name.Length == 13)
                                              {
                                                return fieldGeneratorTaxPercentage;
                                              }
                                            switch (field_name[13])
                                              {
                                                case 'I':
                                                    if ((String.Compare(field_name, 14, "sNew", 0, 4, false) == 0) && (field_name.Length == 18))
                                                        return fieldGeneratorTaxPercentageIsNew;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if (String.Compare(field_name, 2, "p", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'A':
                                        if (String.Compare(field_name, 4, "mount", 0, 5, false) == 0)
                                          {
                                            if (field_name.Length == 9)
                                              {
                                                return fieldGeneratorTipAmount;
                                              }
                                            switch (field_name[9])
                                              {
                                                case 'I':
                                                    if ((String.Compare(field_name, 10, "sNew", 0, 4, false) == 0) && (field_name.Length == 14))
                                                        return fieldGeneratorTipAmountIsNew;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'C':
                                        if ((String.Compare(field_name, 4, "alculatorStart", 0, 14, false) == 0) && (field_name.Length == 18))
                                            return fieldGeneratorTipCalculatorStart;
                                        break;
                                    case 'P':
                                        if (String.Compare(field_name, 4, "ercentage", 0, 9, false) == 0)
                                          {
                                            if (field_name.Length == 13)
                                              {
                                                return fieldGeneratorTipPercentage;
                                              }
                                            switch (field_name[13])
                                              {
                                                case 'I':
                                                    if ((String.Compare(field_name, 14, "sNew", 0, 4, false) == 0) && (field_name.Length == 18))
                                                        return fieldGeneratorTipPercentageIsNew;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "talAmount", 0, 9, false) == 0)
                              {
                                if (field_name.Length == 11)
                                  {
                                    return fieldGeneratorTotalAmount;
                                  }
                                switch (field_name[11])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 12, "sNew", 0, 4, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorTotalAmountIsNew;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serConfused", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorUserConfused;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "antToKnow", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorWantToKnow;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorNextRequest = new JSONHoldingStringGenerator("field \"NextRequest\" of the TipCalculatorInputData class");
            fieldGeneratorLastRequest = new JSONHoldingStringGenerator("field \"LastRequest\" of the TipCalculatorInputData class");
            fieldGeneratorBillAmount = new MoneyJSON.HoldingGenerator("field \"BillAmount\" of the TipCalculatorInputData class", ignore_extras);
            fieldGeneratorBillAmountIsNew = new JSONHoldingBooleanGenerator("field \"BillAmountIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorTaxPercentage = new JSONHoldingNumberTextGenerator("field \"TaxPercentage\" of the TipCalculatorInputData class");
            fieldGeneratorTaxPercentageIsNew = new JSONHoldingBooleanGenerator("field \"TaxPercentageIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorTaxAmount = new MoneyJSON.HoldingGenerator("field \"TaxAmount\" of the TipCalculatorInputData class", ignore_extras);
            fieldGeneratorTaxAmountIsNew = new JSONHoldingBooleanGenerator("field \"TaxAmountIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorTipPercentage = new JSONHoldingNumberTextGenerator("field \"TipPercentage\" of the TipCalculatorInputData class");
            fieldGeneratorTipPercentageIsNew = new JSONHoldingBooleanGenerator("field \"TipPercentageIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorTipAmount = new MoneyJSON.HoldingGenerator("field \"TipAmount\" of the TipCalculatorInputData class", ignore_extras);
            fieldGeneratorTipAmountIsNew = new JSONHoldingBooleanGenerator("field \"TipAmountIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorRoundingAmount = new MoneyJSON.HoldingGenerator("field \"RoundingAmount\" of the TipCalculatorInputData class", ignore_extras);
            fieldGeneratorRoundingAmountIsNew = new JSONHoldingBooleanGenerator("field \"RoundingAmountIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorPartySize = new FieldHoldingGeneratorPartySize("field \"PartySize\" of the TipCalculatorInputData class");
            fieldGeneratorPartySizeIsNew = new JSONHoldingBooleanGenerator("field \"PartySizeIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorTotalAmount = new MoneyJSON.HoldingGenerator("field \"TotalAmount\" of the TipCalculatorInputData class", ignore_extras);
            fieldGeneratorTotalAmountIsNew = new JSONHoldingBooleanGenerator("field \"TotalAmountIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorAmbiguousAmount = new MoneyJSON.HoldingGenerator("field \"AmbiguousAmount\" of the TipCalculatorInputData class", ignore_extras);
            fieldGeneratorAmbiguousAmountIsNew = new JSONHoldingBooleanGenerator("field \"AmbiguousAmountIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorCalculationType = new JSONHoldingStringGenerator("field \"CalculationType\" of the TipCalculatorInputData class");
            fieldGeneratorCalculationTypeIsNew = new JSONHoldingBooleanGenerator("field \"CalculationTypeIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorMethodType = new JSONHoldingStringGenerator("field \"MethodType\" of the TipCalculatorInputData class");
            fieldGeneratorMethodTypeIsNew = new JSONHoldingBooleanGenerator("field \"MethodTypeIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorDoNotKnow = new JSONHoldingBooleanGenerator("field \"DoNotKnow\" of the TipCalculatorInputData class");
            fieldGeneratorWantToKnow = new JSONHoldingBooleanGenerator("field \"WantToKnow\" of the TipCalculatorInputData class");
            fieldGeneratorTipCalculatorStart = new JSONHoldingBooleanGenerator("field \"TipCalculatorStart\" of the TipCalculatorInputData class");
            fieldGeneratorUserConfused = new JSONHoldingBooleanGenerator("field \"UserConfused\" of the TipCalculatorInputData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TipCalculatorInputData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorNextRequest = new JSONHoldingStringGenerator("field \"NextRequest\" of the TipCalculatorInputData class");
            fieldGeneratorLastRequest = new JSONHoldingStringGenerator("field \"LastRequest\" of the TipCalculatorInputData class");
            fieldGeneratorBillAmount = new MoneyJSON.HoldingGenerator("field \"BillAmount\" of the TipCalculatorInputData class", false);
            fieldGeneratorBillAmountIsNew = new JSONHoldingBooleanGenerator("field \"BillAmountIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorTaxPercentage = new JSONHoldingNumberTextGenerator("field \"TaxPercentage\" of the TipCalculatorInputData class");
            fieldGeneratorTaxPercentageIsNew = new JSONHoldingBooleanGenerator("field \"TaxPercentageIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorTaxAmount = new MoneyJSON.HoldingGenerator("field \"TaxAmount\" of the TipCalculatorInputData class", false);
            fieldGeneratorTaxAmountIsNew = new JSONHoldingBooleanGenerator("field \"TaxAmountIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorTipPercentage = new JSONHoldingNumberTextGenerator("field \"TipPercentage\" of the TipCalculatorInputData class");
            fieldGeneratorTipPercentageIsNew = new JSONHoldingBooleanGenerator("field \"TipPercentageIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorTipAmount = new MoneyJSON.HoldingGenerator("field \"TipAmount\" of the TipCalculatorInputData class", false);
            fieldGeneratorTipAmountIsNew = new JSONHoldingBooleanGenerator("field \"TipAmountIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorRoundingAmount = new MoneyJSON.HoldingGenerator("field \"RoundingAmount\" of the TipCalculatorInputData class", false);
            fieldGeneratorRoundingAmountIsNew = new JSONHoldingBooleanGenerator("field \"RoundingAmountIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorPartySize = new FieldHoldingGeneratorPartySize("field \"PartySize\" of the TipCalculatorInputData class");
            fieldGeneratorPartySizeIsNew = new JSONHoldingBooleanGenerator("field \"PartySizeIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorTotalAmount = new MoneyJSON.HoldingGenerator("field \"TotalAmount\" of the TipCalculatorInputData class", false);
            fieldGeneratorTotalAmountIsNew = new JSONHoldingBooleanGenerator("field \"TotalAmountIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorAmbiguousAmount = new MoneyJSON.HoldingGenerator("field \"AmbiguousAmount\" of the TipCalculatorInputData class", false);
            fieldGeneratorAmbiguousAmountIsNew = new JSONHoldingBooleanGenerator("field \"AmbiguousAmountIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorCalculationType = new JSONHoldingStringGenerator("field \"CalculationType\" of the TipCalculatorInputData class");
            fieldGeneratorCalculationTypeIsNew = new JSONHoldingBooleanGenerator("field \"CalculationTypeIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorMethodType = new JSONHoldingStringGenerator("field \"MethodType\" of the TipCalculatorInputData class");
            fieldGeneratorMethodTypeIsNew = new JSONHoldingBooleanGenerator("field \"MethodTypeIsNew\" of the TipCalculatorInputData class");
            fieldGeneratorDoNotKnow = new JSONHoldingBooleanGenerator("field \"DoNotKnow\" of the TipCalculatorInputData class");
            fieldGeneratorWantToKnow = new JSONHoldingBooleanGenerator("field \"WantToKnow\" of the TipCalculatorInputData class");
            fieldGeneratorTipCalculatorStart = new JSONHoldingBooleanGenerator("field \"TipCalculatorStart\" of the TipCalculatorInputData class");
            fieldGeneratorUserConfused = new JSONHoldingBooleanGenerator("field \"UserConfused\" of the TipCalculatorInputData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TipCalculatorInputData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorNextRequest.reset();
            fieldGeneratorLastRequest.reset();
            fieldGeneratorBillAmount.reset();
            fieldGeneratorBillAmountIsNew.reset();
            fieldGeneratorTaxPercentage.reset();
            fieldGeneratorTaxPercentageIsNew.reset();
            fieldGeneratorTaxAmount.reset();
            fieldGeneratorTaxAmountIsNew.reset();
            fieldGeneratorTipPercentage.reset();
            fieldGeneratorTipPercentageIsNew.reset();
            fieldGeneratorTipAmount.reset();
            fieldGeneratorTipAmountIsNew.reset();
            fieldGeneratorRoundingAmount.reset();
            fieldGeneratorRoundingAmountIsNew.reset();
            fieldGeneratorPartySize.reset();
            fieldGeneratorPartySizeIsNew.reset();
            fieldGeneratorTotalAmount.reset();
            fieldGeneratorTotalAmountIsNew.reset();
            fieldGeneratorAmbiguousAmount.reset();
            fieldGeneratorAmbiguousAmountIsNew.reset();
            fieldGeneratorCalculationType.reset();
            fieldGeneratorCalculationTypeIsNew.reset();
            fieldGeneratorMethodType.reset();
            fieldGeneratorMethodTypeIsNew.reset();
            fieldGeneratorDoNotKnow.reset();
            fieldGeneratorWantToKnow.reset();
            fieldGeneratorTipCalculatorStart.reset();
            fieldGeneratorUserConfused.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorBillAmount.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTaxAmount.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTipAmount.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRoundingAmount.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTotalAmount.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAmbiguousAmount.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorBillAmount.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTaxAmount.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTipAmount.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRoundingAmount.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTotalAmount.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAmbiguousAmount.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TipCalculatorInputDataJSON  result)
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
        public TipCalculatorInputDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TipCalculatorInputDataJSON  result)
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
    protected virtual void handle_result(List<TipCalculatorInputDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TipCalculatorInputDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TipCalculatorInputDataJSON>();
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
    public List<TipCalculatorInputDataJSON> value;
  };
  };
