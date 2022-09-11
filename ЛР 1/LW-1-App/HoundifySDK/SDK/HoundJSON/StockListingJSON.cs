/* file "StockListingJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class StockListingJSON : JSONBase
  {
    private bool flagHasListingID;
    private BigInteger storeListingID;
    private bool flagHasSymbol;
    private StockAttributeValueJSON  storeSymbol;
    private bool flagHasShortName;
    private StockAttributeValueJSON  storeShortName;
    private bool flagHasShortPossessiveName;
    private StockAttributeValueJSON  storeShortPossessiveName;
    private bool flagHasMediumName;
    private StockAttributeValueJSON  storeMediumName;
    private bool flagHasLongName;
    private StockAttributeValueJSON  storeLongName;
    private bool flagHasPrice;
    private StockAttributeValueJSON  storePrice;
    private bool flagHasPriceDate;
    private DateAndOrTimeJSON  storePriceDate;
    private bool flagHasIntraDayPriceSource;
    private bool storeIntraDayPriceSource;
    private bool flagHasCurrency;
    private string storeCurrency;
    private bool flagHasIntradayPrices;
    private List< StockHistoricalQuoteJSON  > storeIntradayPrices;
    private bool flagHasDailyHistoricalPrices;
    private List< StockHistoricalQuoteJSON  > storeDailyHistoricalPrices;
    private bool flagHasPERatio;
    private StockAttributeValueJSON  storePERatio;
    private bool flagHasMarketCap;
    private StockAttributeValueJSON  storeMarketCap;
    private bool flagHasVolume;
    private StockAttributeValueJSON  storeVolume;
    private bool flagHasValueChange;
    private StockAttributeValueJSON  storeValueChange;
    private bool flagHasPercentChange;
    private StockAttributeValueJSON  storePercentChange;
    private bool flagHasPreviousCloseDate;
    private DateAndOrTimeJSON  storePreviousCloseDate;
    private bool flagHasOpen;
    private double storeOpen;
    private string textStoreOpen;
    private bool flagHasClose;
    private double storeClose;
    private string textStoreClose;
    private bool flagHasChartImageURL1D;
    private string storeChartImageURL1D;
    private bool flagHasChartImageURL5D;
    private string storeChartImageURL5D;
    private bool flagHasChartImageURL3M;
    private string storeChartImageURL3M;
    private bool flagHasChartImageURL6M;
    private string storeChartImageURL6M;
    private bool flagHasChartImageURL1Y;
    private string storeChartImageURL1Y;
    private bool flagHasExternalURL;
    private string storeExternalURL;
    private bool flagHasStockExchangeShortName;
    private StockAttributeValueJSON  storeStockExchangeShortName;
    private bool flagHasStockExchangeLongName;
    private StockAttributeValueJSON  storeStockExchangeLongName;
    private bool flagHasStockExchangeSymbol;
    private StockAttributeValueJSON  storeStockExchangeSymbol;
    private bool flagHasStockExchangeUTCOffset;
    private double storeStockExchangeUTCOffset;
    private string textStoreStockExchangeUTCOffset;
    private bool flagHasNumShares;
    private BigInteger storeNumShares;
    private bool flagHasDateRange;
    private DateTimeRangeSpecJSON  storeDateRange;
    private bool flagHasImplicitDateRange;
    private bool storeImplicitDateRange;
    private bool flagHasHigh;
    private double storeHigh;
    private string textStoreHigh;
    private bool flagHasLow;
    private double storeLow;
    private string textStoreLow;
    private bool flagHasBasePrice;
    private string storeBasePrice;
    private bool flagHasBasePriceUpper;
    private string storeBasePriceUpper;
    private bool flagHasBasePriceLower;
    private string storeBasePriceLower;
    private bool flagHasTradingValue;
    private string storeTradingValue;
    private bool flagHasVwap;
    private string storeVwap;
    private bool flagHasMarketcap;
    private string storeMarketcap;
    private bool flagHasTradingUnit;
    private string storeTradingUnit;
    private bool flagHasCalcSharesOutstanding;
    private string storeCalcSharesOutstanding;
    private bool flagHasTickSizeFlag;
    private string storeTickSizeFlag;
    private bool flagHasPrincipalMarket;
    private string storePrincipalMarket;
    private bool flagHasIndustryName;
    private string storeIndustryName;
    private bool flagHasNikkeiIndustryName;
    private string storeNikkeiIndustryName;
    private bool flagHasNikkeiFlag;
    private string storeNikkeiFlag;
    private bool flagHasTopix500Flag;
    private string storeTopix500Flag;
    private bool flagHasSs1Price;
    private string storeSs1Price;
    private bool flagHasSs1PriceOpen;
    private string storeSs1PriceOpen;
    private bool flagHasSs1PriceHigh;
    private string storeSs1PriceHigh;
    private bool flagHasSs1PriceLow;
    private string storeSs1PriceLow;
    private bool flagHasSs1PriceChg;
    private string storeSs1PriceChg;
    private bool flagHasSs1PricePchg;
    private string storeSs1PricePchg;
    private bool flagHasSs1Volume;
    private string storeSs1Volume;
    private bool flagHasSs1Vwap;
    private string storeSs1Vwap;
    private bool flagHasSs2Price;
    private string storeSs2Price;
    private bool flagHasSs2PriceOpen;
    private string storeSs2PriceOpen;
    private bool flagHasSs2PriceHigh;
    private string storeSs2PriceHigh;
    private bool flagHasSs2PriceLow;
    private string storeSs2PriceLow;
    private bool flagHasSs2PriceChg;
    private string storeSs2PriceChg;
    private bool flagHasSs2PricePchg;
    private string storeSs2PricePchg;
    private bool flagHasSs2Volume;
    private string storeSs2Volume;
    private bool flagHasSs2Vwap;
    private string storeSs2Vwap;
    private bool flagHasCorpPer;
    private string storeCorpPer;
    private bool flagHasBeta90Topix;
    private string storeBeta90Topix;
    private bool flagHasBeta180Topix;
    private string storeBeta180Topix;
    private bool flagHasBeta90Nikkei225;
    private string storeBeta90Nikkei225;
    private bool flagHasBeta180Nikkei225;
    private string storeBeta180Nikkei225;
    private bool flagHasEarningScheduledDate;
    private string storeEarningScheduledDate;
    private bool flagHasEarningFullyearDate;
    private string storeEarningFullyearDate;
    private bool flagHasDisplayDividendDate;
    private string storeDisplayDividendDate;
    private bool flagHasExDividendDate;
    private string storeExDividendDate;
    private bool flagHasCoSettleFyEnded;
    private string storeCoSettleFyEnded;
    private bool flagHasCoSettleRoe;
    private string storeCoSettleRoe;
    private bool flagHasCoSettleDps;
    private string storeCoSettleDps;
    private bool flagHasCoEstFyEnded;
    private string storeCoEstFyEnded;
    private bool flagHasCoEstDps;
    private string storeCoEstDps;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONListingID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ListingID of StockListingJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ListingID of StockListingJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setListingID(extracted_integer);
      }


    private void  fromJSONSymbol(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setSymbol(convert_classy);
      }


    private void  fromJSONShortName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setShortName(convert_classy);
      }


    private void  fromJSONShortPossessiveName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setShortPossessiveName(convert_classy);
      }


    private void  fromJSONMediumName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setMediumName(convert_classy);
      }


    private void  fromJSONLongName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setLongName(convert_classy);
      }


    private void  fromJSONPrice(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setPrice(convert_classy);
      }


    private void  fromJSONPriceDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setPriceDate(convert_classy);
      }


    private void  fromJSONIntraDayPriceSource(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IntraDayPriceSource of StockListingJSON is not true for false.");
              }
          }
        setIntraDayPriceSource(the_bool);
      }


    private void  fromJSONCurrency(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Currency of StockListingJSON is not a string.");
        setCurrency(json_string.getData());
      }


    private void  fromJSONIntradayPrices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field IntradayPrices of StockListingJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< StockHistoricalQuoteJSON  > vector_IntradayPrices1 = new List< StockHistoricalQuoteJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            StockHistoricalQuoteJSON convert_classy = StockHistoricalQuoteJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_IntradayPrices1.Add(convert_classy);
          }
        initIntradayPrices();
        for (int num1 = 0; num1 < vector_IntradayPrices1.Count; ++num1)
            appendIntradayPrices(vector_IntradayPrices1[num1]);
        for (int num1 = 0; num1 < vector_IntradayPrices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDailyHistoricalPrices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DailyHistoricalPrices of StockListingJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< StockHistoricalQuoteJSON  > vector_DailyHistoricalPrices1 = new List< StockHistoricalQuoteJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            StockHistoricalQuoteJSON convert_classy = StockHistoricalQuoteJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_DailyHistoricalPrices1.Add(convert_classy);
          }
        initDailyHistoricalPrices();
        for (int num2 = 0; num2 < vector_DailyHistoricalPrices1.Count; ++num2)
            appendDailyHistoricalPrices(vector_DailyHistoricalPrices1[num2]);
        for (int num1 = 0; num1 < vector_DailyHistoricalPrices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPERatio(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setPERatio(convert_classy);
      }


    private void  fromJSONMarketCap(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setMarketCap(convert_classy);
      }


    private void  fromJSONVolume(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setVolume(convert_classy);
      }


    private void  fromJSONValueChange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setValueChange(convert_classy);
      }


    private void  fromJSONPercentChange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setPercentChange(convert_classy);
      }


    private void  fromJSONPreviousCloseDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setPreviousCloseDate(convert_classy);
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
                throw new Exception("The value for field Open of StockListingJSON is not a number.");
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
                throw new Exception("The value for field Close of StockListingJSON is not a number.");
              }
          }
        setCloseText(the_rational_text);
      }


    private void  fromJSONChartImageURL1D(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ChartImageURL1D of StockListingJSON is not a string.");
        setChartImageURL1D(json_string.getData());
      }


    private void  fromJSONChartImageURL5D(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ChartImageURL5D of StockListingJSON is not a string.");
        setChartImageURL5D(json_string.getData());
      }


    private void  fromJSONChartImageURL3M(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ChartImageURL3M of StockListingJSON is not a string.");
        setChartImageURL3M(json_string.getData());
      }


    private void  fromJSONChartImageURL6M(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ChartImageURL6M of StockListingJSON is not a string.");
        setChartImageURL6M(json_string.getData());
      }


    private void  fromJSONChartImageURL1Y(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ChartImageURL1Y of StockListingJSON is not a string.");
        setChartImageURL1Y(json_string.getData());
      }


    private void  fromJSONExternalURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExternalURL of StockListingJSON is not a string.");
        setExternalURL(json_string.getData());
      }


    private void  fromJSONStockExchangeShortName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setStockExchangeShortName(convert_classy);
      }


    private void  fromJSONStockExchangeLongName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setStockExchangeLongName(convert_classy);
      }


    private void  fromJSONStockExchangeSymbol(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockAttributeValueJSON convert_classy = StockAttributeValueJSON.from_json(json_value, ignore_extras, true);
        setStockExchangeSymbol(convert_classy);
      }


    private void  fromJSONStockExchangeUTCOffset(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StockExchangeUTCOffset of StockListingJSON is not a number.");
              }
          }
        setStockExchangeUTCOffsetText(the_rational_text);
      }


    private void  fromJSONNumShares(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NumShares of StockListingJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumShares of StockListingJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumShares(extracted_integer);
      }


    private void  fromJSONDateRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateRange(convert_classy);
      }


    private void  fromJSONImplicitDateRange(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ImplicitDateRange of StockListingJSON is not true for false.");
              }
          }
        setImplicitDateRange(the_bool);
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
                throw new Exception("The value for field High of StockListingJSON is not a number.");
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
                throw new Exception("The value for field Low of StockListingJSON is not a number.");
              }
          }
        setLowText(the_rational_text);
      }


    private void  fromJSONBasePrice(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BasePrice of StockListingJSON is not a string.");
        setBasePrice(json_string.getData());
      }


    private void  fromJSONBasePriceUpper(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BasePriceUpper of StockListingJSON is not a string.");
        setBasePriceUpper(json_string.getData());
      }


    private void  fromJSONBasePriceLower(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BasePriceLower of StockListingJSON is not a string.");
        setBasePriceLower(json_string.getData());
      }


    private void  fromJSONTradingValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TradingValue of StockListingJSON is not a string.");
        setTradingValue(json_string.getData());
      }


    private void  fromJSONVwap(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Vwap of StockListingJSON is not a string.");
        setVwap(json_string.getData());
      }


    private void  fromJSONMarketcap(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Marketcap of StockListingJSON is not a string.");
        setMarketcap(json_string.getData());
      }


    private void  fromJSONTradingUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TradingUnit of StockListingJSON is not a string.");
        setTradingUnit(json_string.getData());
      }


    private void  fromJSONCalcSharesOutstanding(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CalcSharesOutstanding of StockListingJSON is not a string.");
        setCalcSharesOutstanding(json_string.getData());
      }


    private void  fromJSONTickSizeFlag(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TickSizeFlag of StockListingJSON is not a string.");
        setTickSizeFlag(json_string.getData());
      }


    private void  fromJSONPrincipalMarket(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PrincipalMarket of StockListingJSON is not a string.");
        setPrincipalMarket(json_string.getData());
      }


    private void  fromJSONIndustryName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field IndustryName of StockListingJSON is not a string.");
        setIndustryName(json_string.getData());
      }


    private void  fromJSONNikkeiIndustryName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NikkeiIndustryName of StockListingJSON is not a string.");
        setNikkeiIndustryName(json_string.getData());
      }


    private void  fromJSONNikkeiFlag(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NikkeiFlag of StockListingJSON is not a string.");
        setNikkeiFlag(json_string.getData());
      }


    private void  fromJSONTopix500Flag(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Topix500Flag of StockListingJSON is not a string.");
        setTopix500Flag(json_string.getData());
      }


    private void  fromJSONSs1Price(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss1Price of StockListingJSON is not a string.");
        setSs1Price(json_string.getData());
      }


    private void  fromJSONSs1PriceOpen(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss1PriceOpen of StockListingJSON is not a string.");
        setSs1PriceOpen(json_string.getData());
      }


    private void  fromJSONSs1PriceHigh(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss1PriceHigh of StockListingJSON is not a string.");
        setSs1PriceHigh(json_string.getData());
      }


    private void  fromJSONSs1PriceLow(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss1PriceLow of StockListingJSON is not a string.");
        setSs1PriceLow(json_string.getData());
      }


    private void  fromJSONSs1PriceChg(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss1PriceChg of StockListingJSON is not a string.");
        setSs1PriceChg(json_string.getData());
      }


    private void  fromJSONSs1PricePchg(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss1PricePchg of StockListingJSON is not a string.");
        setSs1PricePchg(json_string.getData());
      }


    private void  fromJSONSs1Volume(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss1Volume of StockListingJSON is not a string.");
        setSs1Volume(json_string.getData());
      }


    private void  fromJSONSs1Vwap(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss1Vwap of StockListingJSON is not a string.");
        setSs1Vwap(json_string.getData());
      }


    private void  fromJSONSs2Price(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss2Price of StockListingJSON is not a string.");
        setSs2Price(json_string.getData());
      }


    private void  fromJSONSs2PriceOpen(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss2PriceOpen of StockListingJSON is not a string.");
        setSs2PriceOpen(json_string.getData());
      }


    private void  fromJSONSs2PriceHigh(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss2PriceHigh of StockListingJSON is not a string.");
        setSs2PriceHigh(json_string.getData());
      }


    private void  fromJSONSs2PriceLow(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss2PriceLow of StockListingJSON is not a string.");
        setSs2PriceLow(json_string.getData());
      }


    private void  fromJSONSs2PriceChg(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss2PriceChg of StockListingJSON is not a string.");
        setSs2PriceChg(json_string.getData());
      }


    private void  fromJSONSs2PricePchg(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss2PricePchg of StockListingJSON is not a string.");
        setSs2PricePchg(json_string.getData());
      }


    private void  fromJSONSs2Volume(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss2Volume of StockListingJSON is not a string.");
        setSs2Volume(json_string.getData());
      }


    private void  fromJSONSs2Vwap(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Ss2Vwap of StockListingJSON is not a string.");
        setSs2Vwap(json_string.getData());
      }


    private void  fromJSONCorpPer(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CorpPer of StockListingJSON is not a string.");
        setCorpPer(json_string.getData());
      }


    private void  fromJSONBeta90Topix(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Beta90Topix of StockListingJSON is not a string.");
        setBeta90Topix(json_string.getData());
      }


    private void  fromJSONBeta180Topix(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Beta180Topix of StockListingJSON is not a string.");
        setBeta180Topix(json_string.getData());
      }


    private void  fromJSONBeta90Nikkei225(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Beta90Nikkei225 of StockListingJSON is not a string.");
        setBeta90Nikkei225(json_string.getData());
      }


    private void  fromJSONBeta180Nikkei225(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Beta180Nikkei225 of StockListingJSON is not a string.");
        setBeta180Nikkei225(json_string.getData());
      }


    private void  fromJSONEarningScheduledDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EarningScheduledDate of StockListingJSON is not a string.");
        setEarningScheduledDate(json_string.getData());
      }


    private void  fromJSONEarningFullyearDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EarningFullyearDate of StockListingJSON is not a string.");
        setEarningFullyearDate(json_string.getData());
      }


    private void  fromJSONDisplayDividendDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayDividendDate of StockListingJSON is not a string.");
        setDisplayDividendDate(json_string.getData());
      }


    private void  fromJSONExDividendDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExDividendDate of StockListingJSON is not a string.");
        setExDividendDate(json_string.getData());
      }


    private void  fromJSONCoSettleFyEnded(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CoSettleFyEnded of StockListingJSON is not a string.");
        setCoSettleFyEnded(json_string.getData());
      }


    private void  fromJSONCoSettleRoe(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CoSettleRoe of StockListingJSON is not a string.");
        setCoSettleRoe(json_string.getData());
      }


    private void  fromJSONCoSettleDps(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CoSettleDps of StockListingJSON is not a string.");
        setCoSettleDps(json_string.getData());
      }


    private void  fromJSONCoEstFyEnded(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CoEstFyEnded of StockListingJSON is not a string.");
        setCoEstFyEnded(json_string.getData());
      }


    private void  fromJSONCoEstDps(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CoEstDps of StockListingJSON is not a string.");
        setCoEstDps(json_string.getData());
      }


    public StockListingJSON()
      {
        flagHasListingID = false;
        flagHasSymbol = false;
        flagHasShortName = false;
        flagHasShortPossessiveName = false;
        flagHasMediumName = false;
        flagHasLongName = false;
        flagHasPrice = false;
        flagHasPriceDate = false;
        flagHasIntraDayPriceSource = false;
        flagHasCurrency = false;
        flagHasIntradayPrices = false;
        flagHasDailyHistoricalPrices = false;
        flagHasPERatio = false;
        flagHasMarketCap = false;
        flagHasVolume = false;
        flagHasValueChange = false;
        flagHasPercentChange = false;
        flagHasPreviousCloseDate = false;
        flagHasOpen = false;
        flagHasClose = false;
        flagHasChartImageURL1D = false;
        flagHasChartImageURL5D = false;
        flagHasChartImageURL3M = false;
        flagHasChartImageURL6M = false;
        flagHasChartImageURL1Y = false;
        flagHasExternalURL = false;
        flagHasStockExchangeShortName = false;
        flagHasStockExchangeLongName = false;
        flagHasStockExchangeSymbol = false;
        flagHasStockExchangeUTCOffset = false;
        flagHasNumShares = false;
        flagHasDateRange = false;
        flagHasImplicitDateRange = false;
        flagHasHigh = false;
        flagHasLow = false;
        flagHasBasePrice = false;
        flagHasBasePriceUpper = false;
        flagHasBasePriceLower = false;
        flagHasTradingValue = false;
        flagHasVwap = false;
        flagHasMarketcap = false;
        flagHasTradingUnit = false;
        flagHasCalcSharesOutstanding = false;
        flagHasTickSizeFlag = false;
        flagHasPrincipalMarket = false;
        flagHasIndustryName = false;
        flagHasNikkeiIndustryName = false;
        flagHasNikkeiFlag = false;
        flagHasTopix500Flag = false;
        flagHasSs1Price = false;
        flagHasSs1PriceOpen = false;
        flagHasSs1PriceHigh = false;
        flagHasSs1PriceLow = false;
        flagHasSs1PriceChg = false;
        flagHasSs1PricePchg = false;
        flagHasSs1Volume = false;
        flagHasSs1Vwap = false;
        flagHasSs2Price = false;
        flagHasSs2PriceOpen = false;
        flagHasSs2PriceHigh = false;
        flagHasSs2PriceLow = false;
        flagHasSs2PriceChg = false;
        flagHasSs2PricePchg = false;
        flagHasSs2Volume = false;
        flagHasSs2Vwap = false;
        flagHasCorpPer = false;
        flagHasBeta90Topix = false;
        flagHasBeta180Topix = false;
        flagHasBeta90Nikkei225 = false;
        flagHasBeta180Nikkei225 = false;
        flagHasEarningScheduledDate = false;
        flagHasEarningFullyearDate = false;
        flagHasDisplayDividendDate = false;
        flagHasExDividendDate = false;
        flagHasCoSettleFyEnded = false;
        flagHasCoSettleRoe = false;
        flagHasCoSettleDps = false;
        flagHasCoEstFyEnded = false;
        flagHasCoEstDps = false;
        storeIntradayPrices = new List< StockHistoricalQuoteJSON  >();
        storeDailyHistoricalPrices = new List< StockHistoricalQuoteJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasListingID()
      {
        return flagHasListingID;
      }

    public BigInteger  getListingID()
      {
        Debug.Assert(flagHasListingID);
        return storeListingID;
      }

    public bool  hasSymbol()
      {
        return flagHasSymbol;
      }

    public StockAttributeValueJSON   getSymbol()
      {
        Debug.Assert(flagHasSymbol);
        return storeSymbol;
      }

    public bool  hasShortName()
      {
        return flagHasShortName;
      }

    public StockAttributeValueJSON   getShortName()
      {
        Debug.Assert(flagHasShortName);
        return storeShortName;
      }

    public bool  hasShortPossessiveName()
      {
        return flagHasShortPossessiveName;
      }

    public StockAttributeValueJSON   getShortPossessiveName()
      {
        Debug.Assert(flagHasShortPossessiveName);
        return storeShortPossessiveName;
      }

    public bool  hasMediumName()
      {
        return flagHasMediumName;
      }

    public StockAttributeValueJSON   getMediumName()
      {
        Debug.Assert(flagHasMediumName);
        return storeMediumName;
      }

    public bool  hasLongName()
      {
        return flagHasLongName;
      }

    public StockAttributeValueJSON   getLongName()
      {
        Debug.Assert(flagHasLongName);
        return storeLongName;
      }

    public bool  hasPrice()
      {
        return flagHasPrice;
      }

    public StockAttributeValueJSON   getPrice()
      {
        Debug.Assert(flagHasPrice);
        return storePrice;
      }

    public bool  hasPriceDate()
      {
        return flagHasPriceDate;
      }

    public DateAndOrTimeJSON   getPriceDate()
      {
        Debug.Assert(flagHasPriceDate);
        return storePriceDate;
      }

    public bool  hasIntraDayPriceSource()
      {
        return flagHasIntraDayPriceSource;
      }

    public bool  getIntraDayPriceSource()
      {
        Debug.Assert(flagHasIntraDayPriceSource);
        return storeIntraDayPriceSource;
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

    public bool  hasIntradayPrices()
      {
        return flagHasIntradayPrices;
      }

    public int  countOfIntradayPrices()
      {
        Debug.Assert(flagHasIntradayPrices);
        return storeIntradayPrices.Count;
      }

    public StockHistoricalQuoteJSON   elementOfIntradayPrices(int element_num)
      {
        Debug.Assert(flagHasIntradayPrices);
        return storeIntradayPrices[element_num];
      }

    public List< StockHistoricalQuoteJSON  >  getIntradayPrices()
      {
        Debug.Assert(flagHasIntradayPrices);
        return storeIntradayPrices;
      }

    public bool  hasDailyHistoricalPrices()
      {
        return flagHasDailyHistoricalPrices;
      }

    public int  countOfDailyHistoricalPrices()
      {
        Debug.Assert(flagHasDailyHistoricalPrices);
        return storeDailyHistoricalPrices.Count;
      }

    public StockHistoricalQuoteJSON   elementOfDailyHistoricalPrices(int element_num)
      {
        Debug.Assert(flagHasDailyHistoricalPrices);
        return storeDailyHistoricalPrices[element_num];
      }

    public List< StockHistoricalQuoteJSON  >  getDailyHistoricalPrices()
      {
        Debug.Assert(flagHasDailyHistoricalPrices);
        return storeDailyHistoricalPrices;
      }

    public bool  hasPERatio()
      {
        return flagHasPERatio;
      }

    public StockAttributeValueJSON   getPERatio()
      {
        Debug.Assert(flagHasPERatio);
        return storePERatio;
      }

    public bool  hasMarketCap()
      {
        return flagHasMarketCap;
      }

    public StockAttributeValueJSON   getMarketCap()
      {
        Debug.Assert(flagHasMarketCap);
        return storeMarketCap;
      }

    public bool  hasVolume()
      {
        return flagHasVolume;
      }

    public StockAttributeValueJSON   getVolume()
      {
        Debug.Assert(flagHasVolume);
        return storeVolume;
      }

    public bool  hasValueChange()
      {
        return flagHasValueChange;
      }

    public StockAttributeValueJSON   getValueChange()
      {
        Debug.Assert(flagHasValueChange);
        return storeValueChange;
      }

    public bool  hasPercentChange()
      {
        return flagHasPercentChange;
      }

    public StockAttributeValueJSON   getPercentChange()
      {
        Debug.Assert(flagHasPercentChange);
        return storePercentChange;
      }

    public bool  hasPreviousCloseDate()
      {
        return flagHasPreviousCloseDate;
      }

    public DateAndOrTimeJSON   getPreviousCloseDate()
      {
        Debug.Assert(flagHasPreviousCloseDate);
        return storePreviousCloseDate;
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

    public bool  hasChartImageURL1D()
      {
        return flagHasChartImageURL1D;
      }

    public string  getChartImageURL1D()
      {
        Debug.Assert(flagHasChartImageURL1D);
        return storeChartImageURL1D;
      }

    public bool  hasChartImageURL5D()
      {
        return flagHasChartImageURL5D;
      }

    public string  getChartImageURL5D()
      {
        Debug.Assert(flagHasChartImageURL5D);
        return storeChartImageURL5D;
      }

    public bool  hasChartImageURL3M()
      {
        return flagHasChartImageURL3M;
      }

    public string  getChartImageURL3M()
      {
        Debug.Assert(flagHasChartImageURL3M);
        return storeChartImageURL3M;
      }

    public bool  hasChartImageURL6M()
      {
        return flagHasChartImageURL6M;
      }

    public string  getChartImageURL6M()
      {
        Debug.Assert(flagHasChartImageURL6M);
        return storeChartImageURL6M;
      }

    public bool  hasChartImageURL1Y()
      {
        return flagHasChartImageURL1Y;
      }

    public string  getChartImageURL1Y()
      {
        Debug.Assert(flagHasChartImageURL1Y);
        return storeChartImageURL1Y;
      }

    public bool  hasExternalURL()
      {
        return flagHasExternalURL;
      }

    public string  getExternalURL()
      {
        Debug.Assert(flagHasExternalURL);
        return storeExternalURL;
      }

    public bool  hasStockExchangeShortName()
      {
        return flagHasStockExchangeShortName;
      }

    public StockAttributeValueJSON   getStockExchangeShortName()
      {
        Debug.Assert(flagHasStockExchangeShortName);
        return storeStockExchangeShortName;
      }

    public bool  hasStockExchangeLongName()
      {
        return flagHasStockExchangeLongName;
      }

    public StockAttributeValueJSON   getStockExchangeLongName()
      {
        Debug.Assert(flagHasStockExchangeLongName);
        return storeStockExchangeLongName;
      }

    public bool  hasStockExchangeSymbol()
      {
        return flagHasStockExchangeSymbol;
      }

    public StockAttributeValueJSON   getStockExchangeSymbol()
      {
        Debug.Assert(flagHasStockExchangeSymbol);
        return storeStockExchangeSymbol;
      }

    public bool  hasStockExchangeUTCOffset()
      {
        return flagHasStockExchangeUTCOffset;
      }

    public double  getStockExchangeUTCOffset()
      {
        Debug.Assert(flagHasStockExchangeUTCOffset);
        if (textStoreStockExchangeUTCOffset != "")
          {
            return Double.Parse(textStoreStockExchangeUTCOffset);
          }
        return storeStockExchangeUTCOffset;
      }

    public string  getStockExchangeUTCOffsetAsText()
      {
        Debug.Assert(flagHasStockExchangeUTCOffset);
        if (textStoreStockExchangeUTCOffset == "")
          {
            return Convert.ToString(storeStockExchangeUTCOffset);
          }
        else
          {
            return (textStoreStockExchangeUTCOffset);
          }
      }

    public bool  hasNumShares()
      {
        return flagHasNumShares;
      }

    public BigInteger  getNumShares()
      {
        Debug.Assert(flagHasNumShares);
        return storeNumShares;
      }

    public bool  hasDateRange()
      {
        return flagHasDateRange;
      }

    public DateTimeRangeSpecJSON   getDateRange()
      {
        Debug.Assert(flagHasDateRange);
        return storeDateRange;
      }

    public bool  hasImplicitDateRange()
      {
        return flagHasImplicitDateRange;
      }

    public bool  getImplicitDateRange()
      {
        Debug.Assert(flagHasImplicitDateRange);
        return storeImplicitDateRange;
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

    public bool  hasBasePrice()
      {
        return flagHasBasePrice;
      }

    public string  getBasePrice()
      {
        Debug.Assert(flagHasBasePrice);
        return storeBasePrice;
      }

    public bool  hasBasePriceUpper()
      {
        return flagHasBasePriceUpper;
      }

    public string  getBasePriceUpper()
      {
        Debug.Assert(flagHasBasePriceUpper);
        return storeBasePriceUpper;
      }

    public bool  hasBasePriceLower()
      {
        return flagHasBasePriceLower;
      }

    public string  getBasePriceLower()
      {
        Debug.Assert(flagHasBasePriceLower);
        return storeBasePriceLower;
      }

    public bool  hasTradingValue()
      {
        return flagHasTradingValue;
      }

    public string  getTradingValue()
      {
        Debug.Assert(flagHasTradingValue);
        return storeTradingValue;
      }

    public bool  hasVwap()
      {
        return flagHasVwap;
      }

    public string  getVwap()
      {
        Debug.Assert(flagHasVwap);
        return storeVwap;
      }

    public bool  hasMarketcap()
      {
        return flagHasMarketcap;
      }

    public string  getMarketcap()
      {
        Debug.Assert(flagHasMarketcap);
        return storeMarketcap;
      }

    public bool  hasTradingUnit()
      {
        return flagHasTradingUnit;
      }

    public string  getTradingUnit()
      {
        Debug.Assert(flagHasTradingUnit);
        return storeTradingUnit;
      }

    public bool  hasCalcSharesOutstanding()
      {
        return flagHasCalcSharesOutstanding;
      }

    public string  getCalcSharesOutstanding()
      {
        Debug.Assert(flagHasCalcSharesOutstanding);
        return storeCalcSharesOutstanding;
      }

    public bool  hasTickSizeFlag()
      {
        return flagHasTickSizeFlag;
      }

    public string  getTickSizeFlag()
      {
        Debug.Assert(flagHasTickSizeFlag);
        return storeTickSizeFlag;
      }

    public bool  hasPrincipalMarket()
      {
        return flagHasPrincipalMarket;
      }

    public string  getPrincipalMarket()
      {
        Debug.Assert(flagHasPrincipalMarket);
        return storePrincipalMarket;
      }

    public bool  hasIndustryName()
      {
        return flagHasIndustryName;
      }

    public string  getIndustryName()
      {
        Debug.Assert(flagHasIndustryName);
        return storeIndustryName;
      }

    public bool  hasNikkeiIndustryName()
      {
        return flagHasNikkeiIndustryName;
      }

    public string  getNikkeiIndustryName()
      {
        Debug.Assert(flagHasNikkeiIndustryName);
        return storeNikkeiIndustryName;
      }

    public bool  hasNikkeiFlag()
      {
        return flagHasNikkeiFlag;
      }

    public string  getNikkeiFlag()
      {
        Debug.Assert(flagHasNikkeiFlag);
        return storeNikkeiFlag;
      }

    public bool  hasTopix500Flag()
      {
        return flagHasTopix500Flag;
      }

    public string  getTopix500Flag()
      {
        Debug.Assert(flagHasTopix500Flag);
        return storeTopix500Flag;
      }

    public bool  hasSs1Price()
      {
        return flagHasSs1Price;
      }

    public string  getSs1Price()
      {
        Debug.Assert(flagHasSs1Price);
        return storeSs1Price;
      }

    public bool  hasSs1PriceOpen()
      {
        return flagHasSs1PriceOpen;
      }

    public string  getSs1PriceOpen()
      {
        Debug.Assert(flagHasSs1PriceOpen);
        return storeSs1PriceOpen;
      }

    public bool  hasSs1PriceHigh()
      {
        return flagHasSs1PriceHigh;
      }

    public string  getSs1PriceHigh()
      {
        Debug.Assert(flagHasSs1PriceHigh);
        return storeSs1PriceHigh;
      }

    public bool  hasSs1PriceLow()
      {
        return flagHasSs1PriceLow;
      }

    public string  getSs1PriceLow()
      {
        Debug.Assert(flagHasSs1PriceLow);
        return storeSs1PriceLow;
      }

    public bool  hasSs1PriceChg()
      {
        return flagHasSs1PriceChg;
      }

    public string  getSs1PriceChg()
      {
        Debug.Assert(flagHasSs1PriceChg);
        return storeSs1PriceChg;
      }

    public bool  hasSs1PricePchg()
      {
        return flagHasSs1PricePchg;
      }

    public string  getSs1PricePchg()
      {
        Debug.Assert(flagHasSs1PricePchg);
        return storeSs1PricePchg;
      }

    public bool  hasSs1Volume()
      {
        return flagHasSs1Volume;
      }

    public string  getSs1Volume()
      {
        Debug.Assert(flagHasSs1Volume);
        return storeSs1Volume;
      }

    public bool  hasSs1Vwap()
      {
        return flagHasSs1Vwap;
      }

    public string  getSs1Vwap()
      {
        Debug.Assert(flagHasSs1Vwap);
        return storeSs1Vwap;
      }

    public bool  hasSs2Price()
      {
        return flagHasSs2Price;
      }

    public string  getSs2Price()
      {
        Debug.Assert(flagHasSs2Price);
        return storeSs2Price;
      }

    public bool  hasSs2PriceOpen()
      {
        return flagHasSs2PriceOpen;
      }

    public string  getSs2PriceOpen()
      {
        Debug.Assert(flagHasSs2PriceOpen);
        return storeSs2PriceOpen;
      }

    public bool  hasSs2PriceHigh()
      {
        return flagHasSs2PriceHigh;
      }

    public string  getSs2PriceHigh()
      {
        Debug.Assert(flagHasSs2PriceHigh);
        return storeSs2PriceHigh;
      }

    public bool  hasSs2PriceLow()
      {
        return flagHasSs2PriceLow;
      }

    public string  getSs2PriceLow()
      {
        Debug.Assert(flagHasSs2PriceLow);
        return storeSs2PriceLow;
      }

    public bool  hasSs2PriceChg()
      {
        return flagHasSs2PriceChg;
      }

    public string  getSs2PriceChg()
      {
        Debug.Assert(flagHasSs2PriceChg);
        return storeSs2PriceChg;
      }

    public bool  hasSs2PricePchg()
      {
        return flagHasSs2PricePchg;
      }

    public string  getSs2PricePchg()
      {
        Debug.Assert(flagHasSs2PricePchg);
        return storeSs2PricePchg;
      }

    public bool  hasSs2Volume()
      {
        return flagHasSs2Volume;
      }

    public string  getSs2Volume()
      {
        Debug.Assert(flagHasSs2Volume);
        return storeSs2Volume;
      }

    public bool  hasSs2Vwap()
      {
        return flagHasSs2Vwap;
      }

    public string  getSs2Vwap()
      {
        Debug.Assert(flagHasSs2Vwap);
        return storeSs2Vwap;
      }

    public bool  hasCorpPer()
      {
        return flagHasCorpPer;
      }

    public string  getCorpPer()
      {
        Debug.Assert(flagHasCorpPer);
        return storeCorpPer;
      }

    public bool  hasBeta90Topix()
      {
        return flagHasBeta90Topix;
      }

    public string  getBeta90Topix()
      {
        Debug.Assert(flagHasBeta90Topix);
        return storeBeta90Topix;
      }

    public bool  hasBeta180Topix()
      {
        return flagHasBeta180Topix;
      }

    public string  getBeta180Topix()
      {
        Debug.Assert(flagHasBeta180Topix);
        return storeBeta180Topix;
      }

    public bool  hasBeta90Nikkei225()
      {
        return flagHasBeta90Nikkei225;
      }

    public string  getBeta90Nikkei225()
      {
        Debug.Assert(flagHasBeta90Nikkei225);
        return storeBeta90Nikkei225;
      }

    public bool  hasBeta180Nikkei225()
      {
        return flagHasBeta180Nikkei225;
      }

    public string  getBeta180Nikkei225()
      {
        Debug.Assert(flagHasBeta180Nikkei225);
        return storeBeta180Nikkei225;
      }

    public bool  hasEarningScheduledDate()
      {
        return flagHasEarningScheduledDate;
      }

    public string  getEarningScheduledDate()
      {
        Debug.Assert(flagHasEarningScheduledDate);
        return storeEarningScheduledDate;
      }

    public bool  hasEarningFullyearDate()
      {
        return flagHasEarningFullyearDate;
      }

    public string  getEarningFullyearDate()
      {
        Debug.Assert(flagHasEarningFullyearDate);
        return storeEarningFullyearDate;
      }

    public bool  hasDisplayDividendDate()
      {
        return flagHasDisplayDividendDate;
      }

    public string  getDisplayDividendDate()
      {
        Debug.Assert(flagHasDisplayDividendDate);
        return storeDisplayDividendDate;
      }

    public bool  hasExDividendDate()
      {
        return flagHasExDividendDate;
      }

    public string  getExDividendDate()
      {
        Debug.Assert(flagHasExDividendDate);
        return storeExDividendDate;
      }

    public bool  hasCoSettleFyEnded()
      {
        return flagHasCoSettleFyEnded;
      }

    public string  getCoSettleFyEnded()
      {
        Debug.Assert(flagHasCoSettleFyEnded);
        return storeCoSettleFyEnded;
      }

    public bool  hasCoSettleRoe()
      {
        return flagHasCoSettleRoe;
      }

    public string  getCoSettleRoe()
      {
        Debug.Assert(flagHasCoSettleRoe);
        return storeCoSettleRoe;
      }

    public bool  hasCoSettleDps()
      {
        return flagHasCoSettleDps;
      }

    public string  getCoSettleDps()
      {
        Debug.Assert(flagHasCoSettleDps);
        return storeCoSettleDps;
      }

    public bool  hasCoEstFyEnded()
      {
        return flagHasCoEstFyEnded;
      }

    public string  getCoEstFyEnded()
      {
        Debug.Assert(flagHasCoEstFyEnded);
        return storeCoEstFyEnded;
      }

    public bool  hasCoEstDps()
      {
        return flagHasCoEstDps;
      }

    public string  getCoEstDps()
      {
        Debug.Assert(flagHasCoEstDps);
        return storeCoEstDps;
      }


    public virtual int extraStockListingComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockListingComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockListingComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockListingLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setListingID(BigInteger new_value)
      {
        flagHasListingID = true;
        storeListingID = new_value;
      }
    public void unsetListingID()
      {
        flagHasListingID = false;
      }
    public void setSymbol(StockAttributeValueJSON  new_value)
      {
        if (flagHasSymbol)
          {
          }
        flagHasSymbol = true;
        storeSymbol = new_value;
      }
    public void unsetSymbol()
      {
        if (flagHasSymbol)
          {
          }
        flagHasSymbol = false;
      }
    public void setShortName(StockAttributeValueJSON  new_value)
      {
        if (flagHasShortName)
          {
          }
        flagHasShortName = true;
        storeShortName = new_value;
      }
    public void unsetShortName()
      {
        if (flagHasShortName)
          {
          }
        flagHasShortName = false;
      }
    public void setShortPossessiveName(StockAttributeValueJSON  new_value)
      {
        if (flagHasShortPossessiveName)
          {
          }
        flagHasShortPossessiveName = true;
        storeShortPossessiveName = new_value;
      }
    public void unsetShortPossessiveName()
      {
        if (flagHasShortPossessiveName)
          {
          }
        flagHasShortPossessiveName = false;
      }
    public void setMediumName(StockAttributeValueJSON  new_value)
      {
        if (flagHasMediumName)
          {
          }
        flagHasMediumName = true;
        storeMediumName = new_value;
      }
    public void unsetMediumName()
      {
        if (flagHasMediumName)
          {
          }
        flagHasMediumName = false;
      }
    public void setLongName(StockAttributeValueJSON  new_value)
      {
        if (flagHasLongName)
          {
          }
        flagHasLongName = true;
        storeLongName = new_value;
      }
    public void unsetLongName()
      {
        if (flagHasLongName)
          {
          }
        flagHasLongName = false;
      }
    public void setPrice(StockAttributeValueJSON  new_value)
      {
        if (flagHasPrice)
          {
          }
        flagHasPrice = true;
        storePrice = new_value;
      }
    public void unsetPrice()
      {
        if (flagHasPrice)
          {
          }
        flagHasPrice = false;
      }
    public void setPriceDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasPriceDate)
          {
          }
        flagHasPriceDate = true;
        storePriceDate = new_value;
      }
    public void unsetPriceDate()
      {
        if (flagHasPriceDate)
          {
          }
        flagHasPriceDate = false;
      }
    public void setIntraDayPriceSource(bool new_value)
      {
        flagHasIntraDayPriceSource = true;
        storeIntraDayPriceSource = new_value;
      }
    public void unsetIntraDayPriceSource()
      {
        flagHasIntraDayPriceSource = false;
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
    public void initIntradayPrices()
      {
        if (flagHasIntradayPrices)
          {
            for (int num1 = 0; num1 < storeIntradayPrices.Count; ++num1)
              {
              }
          }
        flagHasIntradayPrices = true;
        storeIntradayPrices.Clear();
      }
    public void appendIntradayPrices(StockHistoricalQuoteJSON  to_append)
      {
        if (!flagHasIntradayPrices)
          {
            flagHasIntradayPrices = true;
            storeIntradayPrices.Clear();
          }
        Debug.Assert(flagHasIntradayPrices);
        storeIntradayPrices.Add(to_append);
      }
    public void unsetIntradayPrices()
      {
        if (flagHasIntradayPrices)
          {
            for (int num2 = 0; num2 < storeIntradayPrices.Count; ++num2)
              {
              }
          }
        flagHasIntradayPrices = false;
        storeIntradayPrices.Clear();
      }
    public void initDailyHistoricalPrices()
      {
        if (flagHasDailyHistoricalPrices)
          {
            for (int num3 = 0; num3 < storeDailyHistoricalPrices.Count; ++num3)
              {
              }
          }
        flagHasDailyHistoricalPrices = true;
        storeDailyHistoricalPrices.Clear();
      }
    public void appendDailyHistoricalPrices(StockHistoricalQuoteJSON  to_append)
      {
        if (!flagHasDailyHistoricalPrices)
          {
            flagHasDailyHistoricalPrices = true;
            storeDailyHistoricalPrices.Clear();
          }
        Debug.Assert(flagHasDailyHistoricalPrices);
        storeDailyHistoricalPrices.Add(to_append);
      }
    public void unsetDailyHistoricalPrices()
      {
        if (flagHasDailyHistoricalPrices)
          {
            for (int num4 = 0; num4 < storeDailyHistoricalPrices.Count; ++num4)
              {
              }
          }
        flagHasDailyHistoricalPrices = false;
        storeDailyHistoricalPrices.Clear();
      }
    public void setPERatio(StockAttributeValueJSON  new_value)
      {
        if (flagHasPERatio)
          {
          }
        flagHasPERatio = true;
        storePERatio = new_value;
      }
    public void unsetPERatio()
      {
        if (flagHasPERatio)
          {
          }
        flagHasPERatio = false;
      }
    public void setMarketCap(StockAttributeValueJSON  new_value)
      {
        if (flagHasMarketCap)
          {
          }
        flagHasMarketCap = true;
        storeMarketCap = new_value;
      }
    public void unsetMarketCap()
      {
        if (flagHasMarketCap)
          {
          }
        flagHasMarketCap = false;
      }
    public void setVolume(StockAttributeValueJSON  new_value)
      {
        if (flagHasVolume)
          {
          }
        flagHasVolume = true;
        storeVolume = new_value;
      }
    public void unsetVolume()
      {
        if (flagHasVolume)
          {
          }
        flagHasVolume = false;
      }
    public void setValueChange(StockAttributeValueJSON  new_value)
      {
        if (flagHasValueChange)
          {
          }
        flagHasValueChange = true;
        storeValueChange = new_value;
      }
    public void unsetValueChange()
      {
        if (flagHasValueChange)
          {
          }
        flagHasValueChange = false;
      }
    public void setPercentChange(StockAttributeValueJSON  new_value)
      {
        if (flagHasPercentChange)
          {
          }
        flagHasPercentChange = true;
        storePercentChange = new_value;
      }
    public void unsetPercentChange()
      {
        if (flagHasPercentChange)
          {
          }
        flagHasPercentChange = false;
      }
    public void setPreviousCloseDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasPreviousCloseDate)
          {
          }
        flagHasPreviousCloseDate = true;
        storePreviousCloseDate = new_value;
      }
    public void unsetPreviousCloseDate()
      {
        if (flagHasPreviousCloseDate)
          {
          }
        flagHasPreviousCloseDate = false;
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
            throw new Exception("The text value for field Open of StockListingJSON is not a valid number.");
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
            throw new Exception("The text value for field Close of StockListingJSON is not a valid number.");
        textStoreClose = new_value;
      }
    public void unsetClose()
      {
        flagHasClose = false;
      }
    public void setChartImageURL1D(string new_value)
      {
        flagHasChartImageURL1D = true;
        storeChartImageURL1D = new_value;
      }
    public void unsetChartImageURL1D()
      {
        flagHasChartImageURL1D = false;
      }
    public void setChartImageURL5D(string new_value)
      {
        flagHasChartImageURL5D = true;
        storeChartImageURL5D = new_value;
      }
    public void unsetChartImageURL5D()
      {
        flagHasChartImageURL5D = false;
      }
    public void setChartImageURL3M(string new_value)
      {
        flagHasChartImageURL3M = true;
        storeChartImageURL3M = new_value;
      }
    public void unsetChartImageURL3M()
      {
        flagHasChartImageURL3M = false;
      }
    public void setChartImageURL6M(string new_value)
      {
        flagHasChartImageURL6M = true;
        storeChartImageURL6M = new_value;
      }
    public void unsetChartImageURL6M()
      {
        flagHasChartImageURL6M = false;
      }
    public void setChartImageURL1Y(string new_value)
      {
        flagHasChartImageURL1Y = true;
        storeChartImageURL1Y = new_value;
      }
    public void unsetChartImageURL1Y()
      {
        flagHasChartImageURL1Y = false;
      }
    public void setExternalURL(string new_value)
      {
        flagHasExternalURL = true;
        storeExternalURL = new_value;
      }
    public void unsetExternalURL()
      {
        flagHasExternalURL = false;
      }
    public void setStockExchangeShortName(StockAttributeValueJSON  new_value)
      {
        if (flagHasStockExchangeShortName)
          {
          }
        flagHasStockExchangeShortName = true;
        storeStockExchangeShortName = new_value;
      }
    public void unsetStockExchangeShortName()
      {
        if (flagHasStockExchangeShortName)
          {
          }
        flagHasStockExchangeShortName = false;
      }
    public void setStockExchangeLongName(StockAttributeValueJSON  new_value)
      {
        if (flagHasStockExchangeLongName)
          {
          }
        flagHasStockExchangeLongName = true;
        storeStockExchangeLongName = new_value;
      }
    public void unsetStockExchangeLongName()
      {
        if (flagHasStockExchangeLongName)
          {
          }
        flagHasStockExchangeLongName = false;
      }
    public void setStockExchangeSymbol(StockAttributeValueJSON  new_value)
      {
        if (flagHasStockExchangeSymbol)
          {
          }
        flagHasStockExchangeSymbol = true;
        storeStockExchangeSymbol = new_value;
      }
    public void unsetStockExchangeSymbol()
      {
        if (flagHasStockExchangeSymbol)
          {
          }
        flagHasStockExchangeSymbol = false;
      }
    public void setStockExchangeUTCOffset(double new_value)
      {
        flagHasStockExchangeUTCOffset = true;
        storeStockExchangeUTCOffset = new_value;
        textStoreStockExchangeUTCOffset = "";
      }
    public void setStockExchangeUTCOffsetText(string new_value)
      {
        flagHasStockExchangeUTCOffset = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field StockExchangeUTCOffset of StockListingJSON is not a valid number.");
        textStoreStockExchangeUTCOffset = new_value;
      }
    public void unsetStockExchangeUTCOffset()
      {
        flagHasStockExchangeUTCOffset = false;
      }
    public void setNumShares(BigInteger new_value)
      {
        flagHasNumShares = true;
        storeNumShares = new_value;
      }
    public void unsetNumShares()
      {
        flagHasNumShares = false;
      }
    public void setDateRange(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasDateRange)
          {
          }
        flagHasDateRange = true;
        storeDateRange = new_value;
      }
    public void unsetDateRange()
      {
        if (flagHasDateRange)
          {
          }
        flagHasDateRange = false;
      }
    public void setImplicitDateRange(bool new_value)
      {
        flagHasImplicitDateRange = true;
        storeImplicitDateRange = new_value;
      }
    public void unsetImplicitDateRange()
      {
        flagHasImplicitDateRange = false;
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
            throw new Exception("The text value for field High of StockListingJSON is not a valid number.");
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
            throw new Exception("The text value for field Low of StockListingJSON is not a valid number.");
        textStoreLow = new_value;
      }
    public void unsetLow()
      {
        flagHasLow = false;
      }
    public void setBasePrice(string new_value)
      {
        flagHasBasePrice = true;
        storeBasePrice = new_value;
      }
    public void unsetBasePrice()
      {
        flagHasBasePrice = false;
      }
    public void setBasePriceUpper(string new_value)
      {
        flagHasBasePriceUpper = true;
        storeBasePriceUpper = new_value;
      }
    public void unsetBasePriceUpper()
      {
        flagHasBasePriceUpper = false;
      }
    public void setBasePriceLower(string new_value)
      {
        flagHasBasePriceLower = true;
        storeBasePriceLower = new_value;
      }
    public void unsetBasePriceLower()
      {
        flagHasBasePriceLower = false;
      }
    public void setTradingValue(string new_value)
      {
        flagHasTradingValue = true;
        storeTradingValue = new_value;
      }
    public void unsetTradingValue()
      {
        flagHasTradingValue = false;
      }
    public void setVwap(string new_value)
      {
        flagHasVwap = true;
        storeVwap = new_value;
      }
    public void unsetVwap()
      {
        flagHasVwap = false;
      }
    public void setMarketcap(string new_value)
      {
        flagHasMarketcap = true;
        storeMarketcap = new_value;
      }
    public void unsetMarketcap()
      {
        flagHasMarketcap = false;
      }
    public void setTradingUnit(string new_value)
      {
        flagHasTradingUnit = true;
        storeTradingUnit = new_value;
      }
    public void unsetTradingUnit()
      {
        flagHasTradingUnit = false;
      }
    public void setCalcSharesOutstanding(string new_value)
      {
        flagHasCalcSharesOutstanding = true;
        storeCalcSharesOutstanding = new_value;
      }
    public void unsetCalcSharesOutstanding()
      {
        flagHasCalcSharesOutstanding = false;
      }
    public void setTickSizeFlag(string new_value)
      {
        flagHasTickSizeFlag = true;
        storeTickSizeFlag = new_value;
      }
    public void unsetTickSizeFlag()
      {
        flagHasTickSizeFlag = false;
      }
    public void setPrincipalMarket(string new_value)
      {
        flagHasPrincipalMarket = true;
        storePrincipalMarket = new_value;
      }
    public void unsetPrincipalMarket()
      {
        flagHasPrincipalMarket = false;
      }
    public void setIndustryName(string new_value)
      {
        flagHasIndustryName = true;
        storeIndustryName = new_value;
      }
    public void unsetIndustryName()
      {
        flagHasIndustryName = false;
      }
    public void setNikkeiIndustryName(string new_value)
      {
        flagHasNikkeiIndustryName = true;
        storeNikkeiIndustryName = new_value;
      }
    public void unsetNikkeiIndustryName()
      {
        flagHasNikkeiIndustryName = false;
      }
    public void setNikkeiFlag(string new_value)
      {
        flagHasNikkeiFlag = true;
        storeNikkeiFlag = new_value;
      }
    public void unsetNikkeiFlag()
      {
        flagHasNikkeiFlag = false;
      }
    public void setTopix500Flag(string new_value)
      {
        flagHasTopix500Flag = true;
        storeTopix500Flag = new_value;
      }
    public void unsetTopix500Flag()
      {
        flagHasTopix500Flag = false;
      }
    public void setSs1Price(string new_value)
      {
        flagHasSs1Price = true;
        storeSs1Price = new_value;
      }
    public void unsetSs1Price()
      {
        flagHasSs1Price = false;
      }
    public void setSs1PriceOpen(string new_value)
      {
        flagHasSs1PriceOpen = true;
        storeSs1PriceOpen = new_value;
      }
    public void unsetSs1PriceOpen()
      {
        flagHasSs1PriceOpen = false;
      }
    public void setSs1PriceHigh(string new_value)
      {
        flagHasSs1PriceHigh = true;
        storeSs1PriceHigh = new_value;
      }
    public void unsetSs1PriceHigh()
      {
        flagHasSs1PriceHigh = false;
      }
    public void setSs1PriceLow(string new_value)
      {
        flagHasSs1PriceLow = true;
        storeSs1PriceLow = new_value;
      }
    public void unsetSs1PriceLow()
      {
        flagHasSs1PriceLow = false;
      }
    public void setSs1PriceChg(string new_value)
      {
        flagHasSs1PriceChg = true;
        storeSs1PriceChg = new_value;
      }
    public void unsetSs1PriceChg()
      {
        flagHasSs1PriceChg = false;
      }
    public void setSs1PricePchg(string new_value)
      {
        flagHasSs1PricePchg = true;
        storeSs1PricePchg = new_value;
      }
    public void unsetSs1PricePchg()
      {
        flagHasSs1PricePchg = false;
      }
    public void setSs1Volume(string new_value)
      {
        flagHasSs1Volume = true;
        storeSs1Volume = new_value;
      }
    public void unsetSs1Volume()
      {
        flagHasSs1Volume = false;
      }
    public void setSs1Vwap(string new_value)
      {
        flagHasSs1Vwap = true;
        storeSs1Vwap = new_value;
      }
    public void unsetSs1Vwap()
      {
        flagHasSs1Vwap = false;
      }
    public void setSs2Price(string new_value)
      {
        flagHasSs2Price = true;
        storeSs2Price = new_value;
      }
    public void unsetSs2Price()
      {
        flagHasSs2Price = false;
      }
    public void setSs2PriceOpen(string new_value)
      {
        flagHasSs2PriceOpen = true;
        storeSs2PriceOpen = new_value;
      }
    public void unsetSs2PriceOpen()
      {
        flagHasSs2PriceOpen = false;
      }
    public void setSs2PriceHigh(string new_value)
      {
        flagHasSs2PriceHigh = true;
        storeSs2PriceHigh = new_value;
      }
    public void unsetSs2PriceHigh()
      {
        flagHasSs2PriceHigh = false;
      }
    public void setSs2PriceLow(string new_value)
      {
        flagHasSs2PriceLow = true;
        storeSs2PriceLow = new_value;
      }
    public void unsetSs2PriceLow()
      {
        flagHasSs2PriceLow = false;
      }
    public void setSs2PriceChg(string new_value)
      {
        flagHasSs2PriceChg = true;
        storeSs2PriceChg = new_value;
      }
    public void unsetSs2PriceChg()
      {
        flagHasSs2PriceChg = false;
      }
    public void setSs2PricePchg(string new_value)
      {
        flagHasSs2PricePchg = true;
        storeSs2PricePchg = new_value;
      }
    public void unsetSs2PricePchg()
      {
        flagHasSs2PricePchg = false;
      }
    public void setSs2Volume(string new_value)
      {
        flagHasSs2Volume = true;
        storeSs2Volume = new_value;
      }
    public void unsetSs2Volume()
      {
        flagHasSs2Volume = false;
      }
    public void setSs2Vwap(string new_value)
      {
        flagHasSs2Vwap = true;
        storeSs2Vwap = new_value;
      }
    public void unsetSs2Vwap()
      {
        flagHasSs2Vwap = false;
      }
    public void setCorpPer(string new_value)
      {
        flagHasCorpPer = true;
        storeCorpPer = new_value;
      }
    public void unsetCorpPer()
      {
        flagHasCorpPer = false;
      }
    public void setBeta90Topix(string new_value)
      {
        flagHasBeta90Topix = true;
        storeBeta90Topix = new_value;
      }
    public void unsetBeta90Topix()
      {
        flagHasBeta90Topix = false;
      }
    public void setBeta180Topix(string new_value)
      {
        flagHasBeta180Topix = true;
        storeBeta180Topix = new_value;
      }
    public void unsetBeta180Topix()
      {
        flagHasBeta180Topix = false;
      }
    public void setBeta90Nikkei225(string new_value)
      {
        flagHasBeta90Nikkei225 = true;
        storeBeta90Nikkei225 = new_value;
      }
    public void unsetBeta90Nikkei225()
      {
        flagHasBeta90Nikkei225 = false;
      }
    public void setBeta180Nikkei225(string new_value)
      {
        flagHasBeta180Nikkei225 = true;
        storeBeta180Nikkei225 = new_value;
      }
    public void unsetBeta180Nikkei225()
      {
        flagHasBeta180Nikkei225 = false;
      }
    public void setEarningScheduledDate(string new_value)
      {
        flagHasEarningScheduledDate = true;
        storeEarningScheduledDate = new_value;
      }
    public void unsetEarningScheduledDate()
      {
        flagHasEarningScheduledDate = false;
      }
    public void setEarningFullyearDate(string new_value)
      {
        flagHasEarningFullyearDate = true;
        storeEarningFullyearDate = new_value;
      }
    public void unsetEarningFullyearDate()
      {
        flagHasEarningFullyearDate = false;
      }
    public void setDisplayDividendDate(string new_value)
      {
        flagHasDisplayDividendDate = true;
        storeDisplayDividendDate = new_value;
      }
    public void unsetDisplayDividendDate()
      {
        flagHasDisplayDividendDate = false;
      }
    public void setExDividendDate(string new_value)
      {
        flagHasExDividendDate = true;
        storeExDividendDate = new_value;
      }
    public void unsetExDividendDate()
      {
        flagHasExDividendDate = false;
      }
    public void setCoSettleFyEnded(string new_value)
      {
        flagHasCoSettleFyEnded = true;
        storeCoSettleFyEnded = new_value;
      }
    public void unsetCoSettleFyEnded()
      {
        flagHasCoSettleFyEnded = false;
      }
    public void setCoSettleRoe(string new_value)
      {
        flagHasCoSettleRoe = true;
        storeCoSettleRoe = new_value;
      }
    public void unsetCoSettleRoe()
      {
        flagHasCoSettleRoe = false;
      }
    public void setCoSettleDps(string new_value)
      {
        flagHasCoSettleDps = true;
        storeCoSettleDps = new_value;
      }
    public void unsetCoSettleDps()
      {
        flagHasCoSettleDps = false;
      }
    public void setCoEstFyEnded(string new_value)
      {
        flagHasCoEstFyEnded = true;
        storeCoEstFyEnded = new_value;
      }
    public void unsetCoEstFyEnded()
      {
        flagHasCoEstFyEnded = false;
      }
    public void setCoEstDps(string new_value)
      {
        flagHasCoEstDps = true;
        storeCoEstDps = new_value;
      }
    public void unsetCoEstDps()
      {
        flagHasCoEstDps = false;
      }

    public virtual void extraStockListingAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockListingSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockListingLookup(key);
        if (old_field == null)
          {
            extraStockListingAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasListingID);
        if (flagHasListingID)
          {
            handler.start_pair("ListingID");
            handler.number_value(storeListingID);
          }
        Debug.Assert(partial_allowed || flagHasSymbol);
        if (flagHasSymbol)
          {
            handler.start_pair("Symbol");
            if (partial_allowed)
                storeSymbol.write_partial_as_json(handler);
            else
                storeSymbol.write_as_json(handler);
          }
        if (flagHasShortName)
          {
            handler.start_pair("ShortName");
            if (partial_allowed)
                storeShortName.write_partial_as_json(handler);
            else
                storeShortName.write_as_json(handler);
          }
        if (flagHasShortPossessiveName)
          {
            handler.start_pair("ShortPossessiveName");
            if (partial_allowed)
                storeShortPossessiveName.write_partial_as_json(handler);
            else
                storeShortPossessiveName.write_as_json(handler);
          }
        if (flagHasMediumName)
          {
            handler.start_pair("MediumName");
            if (partial_allowed)
                storeMediumName.write_partial_as_json(handler);
            else
                storeMediumName.write_as_json(handler);
          }
        if (flagHasLongName)
          {
            handler.start_pair("LongName");
            if (partial_allowed)
                storeLongName.write_partial_as_json(handler);
            else
                storeLongName.write_as_json(handler);
          }
        if (flagHasPrice)
          {
            handler.start_pair("Price");
            if (partial_allowed)
                storePrice.write_partial_as_json(handler);
            else
                storePrice.write_as_json(handler);
          }
        if (flagHasPriceDate)
          {
            handler.start_pair("PriceDate");
            if (partial_allowed)
                storePriceDate.write_partial_as_json(handler);
            else
                storePriceDate.write_as_json(handler);
          }
        if (flagHasIntraDayPriceSource)
          {
            handler.start_pair("IntraDayPriceSource");
            handler.boolean_value(storeIntraDayPriceSource);
          }
        Debug.Assert(partial_allowed || flagHasCurrency);
        if (flagHasCurrency)
          {
            handler.start_pair("Currency");
            handler.string_value(storeCurrency);
          }
        if (flagHasIntradayPrices)
          {
            handler.start_pair("IntradayPrices");
            handler.start_array();
            for (int num1 = 0; num1 < storeIntradayPrices.Count; ++num1)
              {
                if (partial_allowed)
                    storeIntradayPrices[num1].write_partial_as_json(handler);
                else
                    storeIntradayPrices[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDailyHistoricalPrices)
          {
            handler.start_pair("DailyHistoricalPrices");
            handler.start_array();
            for (int num2 = 0; num2 < storeDailyHistoricalPrices.Count; ++num2)
              {
                if (partial_allowed)
                    storeDailyHistoricalPrices[num2].write_partial_as_json(handler);
                else
                    storeDailyHistoricalPrices[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasPERatio)
          {
            handler.start_pair("PERatio");
            if (partial_allowed)
                storePERatio.write_partial_as_json(handler);
            else
                storePERatio.write_as_json(handler);
          }
        if (flagHasMarketCap)
          {
            handler.start_pair("MarketCap");
            if (partial_allowed)
                storeMarketCap.write_partial_as_json(handler);
            else
                storeMarketCap.write_as_json(handler);
          }
        if (flagHasVolume)
          {
            handler.start_pair("Volume");
            if (partial_allowed)
                storeVolume.write_partial_as_json(handler);
            else
                storeVolume.write_as_json(handler);
          }
        if (flagHasValueChange)
          {
            handler.start_pair("ValueChange");
            if (partial_allowed)
                storeValueChange.write_partial_as_json(handler);
            else
                storeValueChange.write_as_json(handler);
          }
        if (flagHasPercentChange)
          {
            handler.start_pair("PercentChange");
            if (partial_allowed)
                storePercentChange.write_partial_as_json(handler);
            else
                storePercentChange.write_as_json(handler);
          }
        if (flagHasPreviousCloseDate)
          {
            handler.start_pair("PreviousCloseDate");
            if (partial_allowed)
                storePreviousCloseDate.write_partial_as_json(handler);
            else
                storePreviousCloseDate.write_as_json(handler);
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
        if (flagHasChartImageURL1D)
          {
            handler.start_pair("ChartImageURL1D");
            handler.string_value(storeChartImageURL1D);
          }
        if (flagHasChartImageURL5D)
          {
            handler.start_pair("ChartImageURL5D");
            handler.string_value(storeChartImageURL5D);
          }
        if (flagHasChartImageURL3M)
          {
            handler.start_pair("ChartImageURL3M");
            handler.string_value(storeChartImageURL3M);
          }
        if (flagHasChartImageURL6M)
          {
            handler.start_pair("ChartImageURL6M");
            handler.string_value(storeChartImageURL6M);
          }
        if (flagHasChartImageURL1Y)
          {
            handler.start_pair("ChartImageURL1Y");
            handler.string_value(storeChartImageURL1Y);
          }
        if (flagHasExternalURL)
          {
            handler.start_pair("ExternalURL");
            handler.string_value(storeExternalURL);
          }
        Debug.Assert(partial_allowed || flagHasStockExchangeShortName);
        if (flagHasStockExchangeShortName)
          {
            handler.start_pair("StockExchangeShortName");
            if (partial_allowed)
                storeStockExchangeShortName.write_partial_as_json(handler);
            else
                storeStockExchangeShortName.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStockExchangeLongName);
        if (flagHasStockExchangeLongName)
          {
            handler.start_pair("StockExchangeLongName");
            if (partial_allowed)
                storeStockExchangeLongName.write_partial_as_json(handler);
            else
                storeStockExchangeLongName.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStockExchangeSymbol);
        if (flagHasStockExchangeSymbol)
          {
            handler.start_pair("StockExchangeSymbol");
            if (partial_allowed)
                storeStockExchangeSymbol.write_partial_as_json(handler);
            else
                storeStockExchangeSymbol.write_as_json(handler);
          }
        if (flagHasStockExchangeUTCOffset)
          {
            handler.start_pair("StockExchangeUTCOffset");
            if (textStoreStockExchangeUTCOffset != "")
                handler.number_value(textStoreStockExchangeUTCOffset);
            else if (((double)(long)storeStockExchangeUTCOffset) == storeStockExchangeUTCOffset)
                handler.number_value((long)storeStockExchangeUTCOffset);
            else
                handler.number_value(storeStockExchangeUTCOffset);
          }
        if (flagHasNumShares)
          {
            handler.start_pair("NumShares");
            handler.number_value(storeNumShares);
          }
        if (flagHasDateRange)
          {
            handler.start_pair("DateRange");
            if (partial_allowed)
                storeDateRange.write_partial_as_json(handler);
            else
                storeDateRange.write_as_json(handler);
          }
        if (flagHasImplicitDateRange)
          {
            handler.start_pair("ImplicitDateRange");
            handler.boolean_value(storeImplicitDateRange);
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
        if (flagHasBasePrice)
          {
            handler.start_pair("BasePrice");
            handler.string_value(storeBasePrice);
          }
        if (flagHasBasePriceUpper)
          {
            handler.start_pair("BasePriceUpper");
            handler.string_value(storeBasePriceUpper);
          }
        if (flagHasBasePriceLower)
          {
            handler.start_pair("BasePriceLower");
            handler.string_value(storeBasePriceLower);
          }
        if (flagHasTradingValue)
          {
            handler.start_pair("TradingValue");
            handler.string_value(storeTradingValue);
          }
        if (flagHasVwap)
          {
            handler.start_pair("Vwap");
            handler.string_value(storeVwap);
          }
        if (flagHasMarketcap)
          {
            handler.start_pair("Marketcap");
            handler.string_value(storeMarketcap);
          }
        if (flagHasTradingUnit)
          {
            handler.start_pair("TradingUnit");
            handler.string_value(storeTradingUnit);
          }
        if (flagHasCalcSharesOutstanding)
          {
            handler.start_pair("CalcSharesOutstanding");
            handler.string_value(storeCalcSharesOutstanding);
          }
        if (flagHasTickSizeFlag)
          {
            handler.start_pair("TickSizeFlag");
            handler.string_value(storeTickSizeFlag);
          }
        if (flagHasPrincipalMarket)
          {
            handler.start_pair("PrincipalMarket");
            handler.string_value(storePrincipalMarket);
          }
        if (flagHasIndustryName)
          {
            handler.start_pair("IndustryName");
            handler.string_value(storeIndustryName);
          }
        if (flagHasNikkeiIndustryName)
          {
            handler.start_pair("NikkeiIndustryName");
            handler.string_value(storeNikkeiIndustryName);
          }
        if (flagHasNikkeiFlag)
          {
            handler.start_pair("NikkeiFlag");
            handler.string_value(storeNikkeiFlag);
          }
        if (flagHasTopix500Flag)
          {
            handler.start_pair("Topix500Flag");
            handler.string_value(storeTopix500Flag);
          }
        if (flagHasSs1Price)
          {
            handler.start_pair("Ss1Price");
            handler.string_value(storeSs1Price);
          }
        if (flagHasSs1PriceOpen)
          {
            handler.start_pair("Ss1PriceOpen");
            handler.string_value(storeSs1PriceOpen);
          }
        if (flagHasSs1PriceHigh)
          {
            handler.start_pair("Ss1PriceHigh");
            handler.string_value(storeSs1PriceHigh);
          }
        if (flagHasSs1PriceLow)
          {
            handler.start_pair("Ss1PriceLow");
            handler.string_value(storeSs1PriceLow);
          }
        if (flagHasSs1PriceChg)
          {
            handler.start_pair("Ss1PriceChg");
            handler.string_value(storeSs1PriceChg);
          }
        if (flagHasSs1PricePchg)
          {
            handler.start_pair("Ss1PricePchg");
            handler.string_value(storeSs1PricePchg);
          }
        if (flagHasSs1Volume)
          {
            handler.start_pair("Ss1Volume");
            handler.string_value(storeSs1Volume);
          }
        if (flagHasSs1Vwap)
          {
            handler.start_pair("Ss1Vwap");
            handler.string_value(storeSs1Vwap);
          }
        if (flagHasSs2Price)
          {
            handler.start_pair("Ss2Price");
            handler.string_value(storeSs2Price);
          }
        if (flagHasSs2PriceOpen)
          {
            handler.start_pair("Ss2PriceOpen");
            handler.string_value(storeSs2PriceOpen);
          }
        if (flagHasSs2PriceHigh)
          {
            handler.start_pair("Ss2PriceHigh");
            handler.string_value(storeSs2PriceHigh);
          }
        if (flagHasSs2PriceLow)
          {
            handler.start_pair("Ss2PriceLow");
            handler.string_value(storeSs2PriceLow);
          }
        if (flagHasSs2PriceChg)
          {
            handler.start_pair("Ss2PriceChg");
            handler.string_value(storeSs2PriceChg);
          }
        if (flagHasSs2PricePchg)
          {
            handler.start_pair("Ss2PricePchg");
            handler.string_value(storeSs2PricePchg);
          }
        if (flagHasSs2Volume)
          {
            handler.start_pair("Ss2Volume");
            handler.string_value(storeSs2Volume);
          }
        if (flagHasSs2Vwap)
          {
            handler.start_pair("Ss2Vwap");
            handler.string_value(storeSs2Vwap);
          }
        if (flagHasCorpPer)
          {
            handler.start_pair("CorpPer");
            handler.string_value(storeCorpPer);
          }
        if (flagHasBeta90Topix)
          {
            handler.start_pair("Beta90Topix");
            handler.string_value(storeBeta90Topix);
          }
        if (flagHasBeta180Topix)
          {
            handler.start_pair("Beta180Topix");
            handler.string_value(storeBeta180Topix);
          }
        if (flagHasBeta90Nikkei225)
          {
            handler.start_pair("Beta90Nikkei225");
            handler.string_value(storeBeta90Nikkei225);
          }
        if (flagHasBeta180Nikkei225)
          {
            handler.start_pair("Beta180Nikkei225");
            handler.string_value(storeBeta180Nikkei225);
          }
        if (flagHasEarningScheduledDate)
          {
            handler.start_pair("EarningScheduledDate");
            handler.string_value(storeEarningScheduledDate);
          }
        if (flagHasEarningFullyearDate)
          {
            handler.start_pair("EarningFullyearDate");
            handler.string_value(storeEarningFullyearDate);
          }
        if (flagHasDisplayDividendDate)
          {
            handler.start_pair("DisplayDividendDate");
            handler.string_value(storeDisplayDividendDate);
          }
        if (flagHasExDividendDate)
          {
            handler.start_pair("ExDividendDate");
            handler.string_value(storeExDividendDate);
          }
        if (flagHasCoSettleFyEnded)
          {
            handler.start_pair("CoSettleFyEnded");
            handler.string_value(storeCoSettleFyEnded);
          }
        if (flagHasCoSettleRoe)
          {
            handler.start_pair("CoSettleRoe");
            handler.string_value(storeCoSettleRoe);
          }
        if (flagHasCoSettleDps)
          {
            handler.start_pair("CoSettleDps");
            handler.string_value(storeCoSettleDps);
          }
        if (flagHasCoEstFyEnded)
          {
            handler.start_pair("CoEstFyEnded");
            handler.string_value(storeCoEstFyEnded);
          }
        if (flagHasCoEstDps)
          {
            handler.start_pair("CoEstDps");
            handler.string_value(storeCoEstDps);
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
        if (!(hasListingID()))
          {
            return "When parsing the object for %what%, the \"ListingID\" field was missing.";
          }
        if (!(hasSymbol()))
          {
            return "When parsing the object for %what%, the \"Symbol\" field was missing.";
          }
        if (!(hasCurrency()))
          {
            return "When parsing the object for %what%, the \"Currency\" field was missing.";
          }
        if (!(hasStockExchangeShortName()))
          {
            return "When parsing the object for %what%, the \"StockExchangeShortName\" field was missing.";
          }
        if (!(hasStockExchangeLongName()))
          {
            return "When parsing the object for %what%, the \"StockExchangeLongName\" field was missing.";
          }
        if (!(hasStockExchangeSymbol()))
          {
            return "When parsing the object for %what%, the \"StockExchangeSymbol\" field was missing.";
          }
        return null;
      }

    public static StockListingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockListing", ignore_extras);
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
    public static StockListingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockListingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockListing", ignore_extras);
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
    public static StockListingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockListingJSON from_text(string text, bool ignore_extras)
      {
        StockListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockListing", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockListingJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockListingJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockListing", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorListingID : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorListingID(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorListingID : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorListingID(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorListingID fieldGeneratorListingID;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorSymbol;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorShortName;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorShortPossessiveName;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorMediumName;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorLongName;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorPrice;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorPriceDate;
        private JSONHoldingBooleanGenerator fieldGeneratorIntraDayPriceSource;
        private JSONHoldingStringGenerator fieldGeneratorCurrency;
        private StockHistoricalQuoteJSON.HoldingArrayGenerator fieldGeneratorIntradayPrices;
        private StockHistoricalQuoteJSON.HoldingArrayGenerator fieldGeneratorDailyHistoricalPrices;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorPERatio;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorMarketCap;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorVolume;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorValueChange;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorPercentChange;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorPreviousCloseDate;
        private JSONHoldingNumberTextGenerator fieldGeneratorOpen;
        private JSONHoldingNumberTextGenerator fieldGeneratorClose;
        private JSONHoldingStringGenerator fieldGeneratorChartImageURL1D;
        private JSONHoldingStringGenerator fieldGeneratorChartImageURL5D;
        private JSONHoldingStringGenerator fieldGeneratorChartImageURL3M;
        private JSONHoldingStringGenerator fieldGeneratorChartImageURL6M;
        private JSONHoldingStringGenerator fieldGeneratorChartImageURL1Y;
        private JSONHoldingStringGenerator fieldGeneratorExternalURL;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorStockExchangeShortName;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorStockExchangeLongName;
        private StockAttributeValueJSON.HoldingGenerator fieldGeneratorStockExchangeSymbol;
        private JSONHoldingNumberTextGenerator fieldGeneratorStockExchangeUTCOffset;
    private class FieldHoldingGeneratorNumShares : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorNumShares(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumShares : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumShares(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorNumShares fieldGeneratorNumShares;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDateRange;
        private JSONHoldingBooleanGenerator fieldGeneratorImplicitDateRange;
        private JSONHoldingNumberTextGenerator fieldGeneratorHigh;
        private JSONHoldingNumberTextGenerator fieldGeneratorLow;
        private JSONHoldingStringGenerator fieldGeneratorBasePrice;
        private JSONHoldingStringGenerator fieldGeneratorBasePriceUpper;
        private JSONHoldingStringGenerator fieldGeneratorBasePriceLower;
        private JSONHoldingStringGenerator fieldGeneratorTradingValue;
        private JSONHoldingStringGenerator fieldGeneratorVwap;
        private JSONHoldingStringGenerator fieldGeneratorMarketcap;
        private JSONHoldingStringGenerator fieldGeneratorTradingUnit;
        private JSONHoldingStringGenerator fieldGeneratorCalcSharesOutstanding;
        private JSONHoldingStringGenerator fieldGeneratorTickSizeFlag;
        private JSONHoldingStringGenerator fieldGeneratorPrincipalMarket;
        private JSONHoldingStringGenerator fieldGeneratorIndustryName;
        private JSONHoldingStringGenerator fieldGeneratorNikkeiIndustryName;
        private JSONHoldingStringGenerator fieldGeneratorNikkeiFlag;
        private JSONHoldingStringGenerator fieldGeneratorTopix500Flag;
        private JSONHoldingStringGenerator fieldGeneratorSs1Price;
        private JSONHoldingStringGenerator fieldGeneratorSs1PriceOpen;
        private JSONHoldingStringGenerator fieldGeneratorSs1PriceHigh;
        private JSONHoldingStringGenerator fieldGeneratorSs1PriceLow;
        private JSONHoldingStringGenerator fieldGeneratorSs1PriceChg;
        private JSONHoldingStringGenerator fieldGeneratorSs1PricePchg;
        private JSONHoldingStringGenerator fieldGeneratorSs1Volume;
        private JSONHoldingStringGenerator fieldGeneratorSs1Vwap;
        private JSONHoldingStringGenerator fieldGeneratorSs2Price;
        private JSONHoldingStringGenerator fieldGeneratorSs2PriceOpen;
        private JSONHoldingStringGenerator fieldGeneratorSs2PriceHigh;
        private JSONHoldingStringGenerator fieldGeneratorSs2PriceLow;
        private JSONHoldingStringGenerator fieldGeneratorSs2PriceChg;
        private JSONHoldingStringGenerator fieldGeneratorSs2PricePchg;
        private JSONHoldingStringGenerator fieldGeneratorSs2Volume;
        private JSONHoldingStringGenerator fieldGeneratorSs2Vwap;
        private JSONHoldingStringGenerator fieldGeneratorCorpPer;
        private JSONHoldingStringGenerator fieldGeneratorBeta90Topix;
        private JSONHoldingStringGenerator fieldGeneratorBeta180Topix;
        private JSONHoldingStringGenerator fieldGeneratorBeta90Nikkei225;
        private JSONHoldingStringGenerator fieldGeneratorBeta180Nikkei225;
        private JSONHoldingStringGenerator fieldGeneratorEarningScheduledDate;
        private JSONHoldingStringGenerator fieldGeneratorEarningFullyearDate;
        private JSONHoldingStringGenerator fieldGeneratorDisplayDividendDate;
        private JSONHoldingStringGenerator fieldGeneratorExDividendDate;
        private JSONHoldingStringGenerator fieldGeneratorCoSettleFyEnded;
        private JSONHoldingStringGenerator fieldGeneratorCoSettleRoe;
        private JSONHoldingStringGenerator fieldGeneratorCoSettleDps;
        private JSONHoldingStringGenerator fieldGeneratorCoEstFyEnded;
        private JSONHoldingStringGenerator fieldGeneratorCoEstDps;
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
            StockListingJSON result = new StockListingJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockListingAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockListingJSON result)
          {
            if (fieldGeneratorListingID.have_value)
              {
                result.setListingID(fieldGeneratorListingID.value);
                fieldGeneratorListingID.have_value = false;
              }
            else if ((!(result.hasListingID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ListingID\" field was missing.");
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
            if (fieldGeneratorShortName.have_value)
              {
                result.setShortName(fieldGeneratorShortName.value);
                fieldGeneratorShortName.have_value = false;
              }
            if (fieldGeneratorShortPossessiveName.have_value)
              {
                result.setShortPossessiveName(fieldGeneratorShortPossessiveName.value);
                fieldGeneratorShortPossessiveName.have_value = false;
              }
            if (fieldGeneratorMediumName.have_value)
              {
                result.setMediumName(fieldGeneratorMediumName.value);
                fieldGeneratorMediumName.have_value = false;
              }
            if (fieldGeneratorLongName.have_value)
              {
                result.setLongName(fieldGeneratorLongName.value);
                fieldGeneratorLongName.have_value = false;
              }
            if (fieldGeneratorPrice.have_value)
              {
                result.setPrice(fieldGeneratorPrice.value);
                fieldGeneratorPrice.have_value = false;
              }
            if (fieldGeneratorPriceDate.have_value)
              {
                result.setPriceDate(fieldGeneratorPriceDate.value);
                fieldGeneratorPriceDate.have_value = false;
              }
            if (fieldGeneratorIntraDayPriceSource.have_value)
              {
                result.setIntraDayPriceSource(fieldGeneratorIntraDayPriceSource.value);
                fieldGeneratorIntraDayPriceSource.have_value = false;
              }
            if (fieldGeneratorCurrency.have_value)
              {
                result.setCurrency(fieldGeneratorCurrency.value);
                fieldGeneratorCurrency.have_value = false;
              }
            else if ((!(result.hasCurrency())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Currency\" field was missing.");
              }
            if (fieldGeneratorIntradayPrices.have_value)
              {
                result.initIntradayPrices();
                int count = fieldGeneratorIntradayPrices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendIntradayPrices(fieldGeneratorIntradayPrices.value[num]);
                  }
                fieldGeneratorIntradayPrices.value.Clear();
                fieldGeneratorIntradayPrices.have_value = false;
              }
            if (fieldGeneratorDailyHistoricalPrices.have_value)
              {
                result.initDailyHistoricalPrices();
                int count = fieldGeneratorDailyHistoricalPrices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDailyHistoricalPrices(fieldGeneratorDailyHistoricalPrices.value[num]);
                  }
                fieldGeneratorDailyHistoricalPrices.value.Clear();
                fieldGeneratorDailyHistoricalPrices.have_value = false;
              }
            if (fieldGeneratorPERatio.have_value)
              {
                result.setPERatio(fieldGeneratorPERatio.value);
                fieldGeneratorPERatio.have_value = false;
              }
            if (fieldGeneratorMarketCap.have_value)
              {
                result.setMarketCap(fieldGeneratorMarketCap.value);
                fieldGeneratorMarketCap.have_value = false;
              }
            if (fieldGeneratorVolume.have_value)
              {
                result.setVolume(fieldGeneratorVolume.value);
                fieldGeneratorVolume.have_value = false;
              }
            if (fieldGeneratorValueChange.have_value)
              {
                result.setValueChange(fieldGeneratorValueChange.value);
                fieldGeneratorValueChange.have_value = false;
              }
            if (fieldGeneratorPercentChange.have_value)
              {
                result.setPercentChange(fieldGeneratorPercentChange.value);
                fieldGeneratorPercentChange.have_value = false;
              }
            if (fieldGeneratorPreviousCloseDate.have_value)
              {
                result.setPreviousCloseDate(fieldGeneratorPreviousCloseDate.value);
                fieldGeneratorPreviousCloseDate.have_value = false;
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
            if (fieldGeneratorChartImageURL1D.have_value)
              {
                result.setChartImageURL1D(fieldGeneratorChartImageURL1D.value);
                fieldGeneratorChartImageURL1D.have_value = false;
              }
            if (fieldGeneratorChartImageURL5D.have_value)
              {
                result.setChartImageURL5D(fieldGeneratorChartImageURL5D.value);
                fieldGeneratorChartImageURL5D.have_value = false;
              }
            if (fieldGeneratorChartImageURL3M.have_value)
              {
                result.setChartImageURL3M(fieldGeneratorChartImageURL3M.value);
                fieldGeneratorChartImageURL3M.have_value = false;
              }
            if (fieldGeneratorChartImageURL6M.have_value)
              {
                result.setChartImageURL6M(fieldGeneratorChartImageURL6M.value);
                fieldGeneratorChartImageURL6M.have_value = false;
              }
            if (fieldGeneratorChartImageURL1Y.have_value)
              {
                result.setChartImageURL1Y(fieldGeneratorChartImageURL1Y.value);
                fieldGeneratorChartImageURL1Y.have_value = false;
              }
            if (fieldGeneratorExternalURL.have_value)
              {
                result.setExternalURL(fieldGeneratorExternalURL.value);
                fieldGeneratorExternalURL.have_value = false;
              }
            if (fieldGeneratorStockExchangeShortName.have_value)
              {
                result.setStockExchangeShortName(fieldGeneratorStockExchangeShortName.value);
                fieldGeneratorStockExchangeShortName.have_value = false;
              }
            else if ((!(result.hasStockExchangeShortName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StockExchangeShortName\" field was missing.");
              }
            if (fieldGeneratorStockExchangeLongName.have_value)
              {
                result.setStockExchangeLongName(fieldGeneratorStockExchangeLongName.value);
                fieldGeneratorStockExchangeLongName.have_value = false;
              }
            else if ((!(result.hasStockExchangeLongName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StockExchangeLongName\" field was missing.");
              }
            if (fieldGeneratorStockExchangeSymbol.have_value)
              {
                result.setStockExchangeSymbol(fieldGeneratorStockExchangeSymbol.value);
                fieldGeneratorStockExchangeSymbol.have_value = false;
              }
            else if ((!(result.hasStockExchangeSymbol())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StockExchangeSymbol\" field was missing.");
              }
            if (fieldGeneratorStockExchangeUTCOffset.have_value)
              {
                result.setStockExchangeUTCOffsetText(fieldGeneratorStockExchangeUTCOffset.value);
                fieldGeneratorStockExchangeUTCOffset.have_value = false;
              }
            if (fieldGeneratorNumShares.have_value)
              {
                result.setNumShares(fieldGeneratorNumShares.value);
                fieldGeneratorNumShares.have_value = false;
              }
            if (fieldGeneratorDateRange.have_value)
              {
                result.setDateRange(fieldGeneratorDateRange.value);
                fieldGeneratorDateRange.have_value = false;
              }
            if (fieldGeneratorImplicitDateRange.have_value)
              {
                result.setImplicitDateRange(fieldGeneratorImplicitDateRange.value);
                fieldGeneratorImplicitDateRange.have_value = false;
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
            if (fieldGeneratorBasePrice.have_value)
              {
                result.setBasePrice(fieldGeneratorBasePrice.value);
                fieldGeneratorBasePrice.have_value = false;
              }
            if (fieldGeneratorBasePriceUpper.have_value)
              {
                result.setBasePriceUpper(fieldGeneratorBasePriceUpper.value);
                fieldGeneratorBasePriceUpper.have_value = false;
              }
            if (fieldGeneratorBasePriceLower.have_value)
              {
                result.setBasePriceLower(fieldGeneratorBasePriceLower.value);
                fieldGeneratorBasePriceLower.have_value = false;
              }
            if (fieldGeneratorTradingValue.have_value)
              {
                result.setTradingValue(fieldGeneratorTradingValue.value);
                fieldGeneratorTradingValue.have_value = false;
              }
            if (fieldGeneratorVwap.have_value)
              {
                result.setVwap(fieldGeneratorVwap.value);
                fieldGeneratorVwap.have_value = false;
              }
            if (fieldGeneratorMarketcap.have_value)
              {
                result.setMarketcap(fieldGeneratorMarketcap.value);
                fieldGeneratorMarketcap.have_value = false;
              }
            if (fieldGeneratorTradingUnit.have_value)
              {
                result.setTradingUnit(fieldGeneratorTradingUnit.value);
                fieldGeneratorTradingUnit.have_value = false;
              }
            if (fieldGeneratorCalcSharesOutstanding.have_value)
              {
                result.setCalcSharesOutstanding(fieldGeneratorCalcSharesOutstanding.value);
                fieldGeneratorCalcSharesOutstanding.have_value = false;
              }
            if (fieldGeneratorTickSizeFlag.have_value)
              {
                result.setTickSizeFlag(fieldGeneratorTickSizeFlag.value);
                fieldGeneratorTickSizeFlag.have_value = false;
              }
            if (fieldGeneratorPrincipalMarket.have_value)
              {
                result.setPrincipalMarket(fieldGeneratorPrincipalMarket.value);
                fieldGeneratorPrincipalMarket.have_value = false;
              }
            if (fieldGeneratorIndustryName.have_value)
              {
                result.setIndustryName(fieldGeneratorIndustryName.value);
                fieldGeneratorIndustryName.have_value = false;
              }
            if (fieldGeneratorNikkeiIndustryName.have_value)
              {
                result.setNikkeiIndustryName(fieldGeneratorNikkeiIndustryName.value);
                fieldGeneratorNikkeiIndustryName.have_value = false;
              }
            if (fieldGeneratorNikkeiFlag.have_value)
              {
                result.setNikkeiFlag(fieldGeneratorNikkeiFlag.value);
                fieldGeneratorNikkeiFlag.have_value = false;
              }
            if (fieldGeneratorTopix500Flag.have_value)
              {
                result.setTopix500Flag(fieldGeneratorTopix500Flag.value);
                fieldGeneratorTopix500Flag.have_value = false;
              }
            if (fieldGeneratorSs1Price.have_value)
              {
                result.setSs1Price(fieldGeneratorSs1Price.value);
                fieldGeneratorSs1Price.have_value = false;
              }
            if (fieldGeneratorSs1PriceOpen.have_value)
              {
                result.setSs1PriceOpen(fieldGeneratorSs1PriceOpen.value);
                fieldGeneratorSs1PriceOpen.have_value = false;
              }
            if (fieldGeneratorSs1PriceHigh.have_value)
              {
                result.setSs1PriceHigh(fieldGeneratorSs1PriceHigh.value);
                fieldGeneratorSs1PriceHigh.have_value = false;
              }
            if (fieldGeneratorSs1PriceLow.have_value)
              {
                result.setSs1PriceLow(fieldGeneratorSs1PriceLow.value);
                fieldGeneratorSs1PriceLow.have_value = false;
              }
            if (fieldGeneratorSs1PriceChg.have_value)
              {
                result.setSs1PriceChg(fieldGeneratorSs1PriceChg.value);
                fieldGeneratorSs1PriceChg.have_value = false;
              }
            if (fieldGeneratorSs1PricePchg.have_value)
              {
                result.setSs1PricePchg(fieldGeneratorSs1PricePchg.value);
                fieldGeneratorSs1PricePchg.have_value = false;
              }
            if (fieldGeneratorSs1Volume.have_value)
              {
                result.setSs1Volume(fieldGeneratorSs1Volume.value);
                fieldGeneratorSs1Volume.have_value = false;
              }
            if (fieldGeneratorSs1Vwap.have_value)
              {
                result.setSs1Vwap(fieldGeneratorSs1Vwap.value);
                fieldGeneratorSs1Vwap.have_value = false;
              }
            if (fieldGeneratorSs2Price.have_value)
              {
                result.setSs2Price(fieldGeneratorSs2Price.value);
                fieldGeneratorSs2Price.have_value = false;
              }
            if (fieldGeneratorSs2PriceOpen.have_value)
              {
                result.setSs2PriceOpen(fieldGeneratorSs2PriceOpen.value);
                fieldGeneratorSs2PriceOpen.have_value = false;
              }
            if (fieldGeneratorSs2PriceHigh.have_value)
              {
                result.setSs2PriceHigh(fieldGeneratorSs2PriceHigh.value);
                fieldGeneratorSs2PriceHigh.have_value = false;
              }
            if (fieldGeneratorSs2PriceLow.have_value)
              {
                result.setSs2PriceLow(fieldGeneratorSs2PriceLow.value);
                fieldGeneratorSs2PriceLow.have_value = false;
              }
            if (fieldGeneratorSs2PriceChg.have_value)
              {
                result.setSs2PriceChg(fieldGeneratorSs2PriceChg.value);
                fieldGeneratorSs2PriceChg.have_value = false;
              }
            if (fieldGeneratorSs2PricePchg.have_value)
              {
                result.setSs2PricePchg(fieldGeneratorSs2PricePchg.value);
                fieldGeneratorSs2PricePchg.have_value = false;
              }
            if (fieldGeneratorSs2Volume.have_value)
              {
                result.setSs2Volume(fieldGeneratorSs2Volume.value);
                fieldGeneratorSs2Volume.have_value = false;
              }
            if (fieldGeneratorSs2Vwap.have_value)
              {
                result.setSs2Vwap(fieldGeneratorSs2Vwap.value);
                fieldGeneratorSs2Vwap.have_value = false;
              }
            if (fieldGeneratorCorpPer.have_value)
              {
                result.setCorpPer(fieldGeneratorCorpPer.value);
                fieldGeneratorCorpPer.have_value = false;
              }
            if (fieldGeneratorBeta90Topix.have_value)
              {
                result.setBeta90Topix(fieldGeneratorBeta90Topix.value);
                fieldGeneratorBeta90Topix.have_value = false;
              }
            if (fieldGeneratorBeta180Topix.have_value)
              {
                result.setBeta180Topix(fieldGeneratorBeta180Topix.value);
                fieldGeneratorBeta180Topix.have_value = false;
              }
            if (fieldGeneratorBeta90Nikkei225.have_value)
              {
                result.setBeta90Nikkei225(fieldGeneratorBeta90Nikkei225.value);
                fieldGeneratorBeta90Nikkei225.have_value = false;
              }
            if (fieldGeneratorBeta180Nikkei225.have_value)
              {
                result.setBeta180Nikkei225(fieldGeneratorBeta180Nikkei225.value);
                fieldGeneratorBeta180Nikkei225.have_value = false;
              }
            if (fieldGeneratorEarningScheduledDate.have_value)
              {
                result.setEarningScheduledDate(fieldGeneratorEarningScheduledDate.value);
                fieldGeneratorEarningScheduledDate.have_value = false;
              }
            if (fieldGeneratorEarningFullyearDate.have_value)
              {
                result.setEarningFullyearDate(fieldGeneratorEarningFullyearDate.value);
                fieldGeneratorEarningFullyearDate.have_value = false;
              }
            if (fieldGeneratorDisplayDividendDate.have_value)
              {
                result.setDisplayDividendDate(fieldGeneratorDisplayDividendDate.value);
                fieldGeneratorDisplayDividendDate.have_value = false;
              }
            if (fieldGeneratorExDividendDate.have_value)
              {
                result.setExDividendDate(fieldGeneratorExDividendDate.value);
                fieldGeneratorExDividendDate.have_value = false;
              }
            if (fieldGeneratorCoSettleFyEnded.have_value)
              {
                result.setCoSettleFyEnded(fieldGeneratorCoSettleFyEnded.value);
                fieldGeneratorCoSettleFyEnded.have_value = false;
              }
            if (fieldGeneratorCoSettleRoe.have_value)
              {
                result.setCoSettleRoe(fieldGeneratorCoSettleRoe.value);
                fieldGeneratorCoSettleRoe.have_value = false;
              }
            if (fieldGeneratorCoSettleDps.have_value)
              {
                result.setCoSettleDps(fieldGeneratorCoSettleDps.value);
                fieldGeneratorCoSettleDps.have_value = false;
              }
            if (fieldGeneratorCoEstFyEnded.have_value)
              {
                result.setCoEstFyEnded(fieldGeneratorCoEstFyEnded.value);
                fieldGeneratorCoEstFyEnded.have_value = false;
              }
            if (fieldGeneratorCoEstDps.have_value)
              {
                result.setCoEstDps(fieldGeneratorCoEstDps.value);
                fieldGeneratorCoEstDps.have_value = false;
              }
          }
        protected abstract void handle_result(StockListingJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "sePrice", 0, 7, false) == 0)
                              {
                                if (field_name.Length == 9)
                                  {
                                    return fieldGeneratorBasePrice;
                                  }
                                switch (field_name[9])
                                  {
                                    case 'L':
                                        if ((String.Compare(field_name, 10, "ower", 0, 4, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorBasePriceLower;
                                        break;
                                    case 'U':
                                        if ((String.Compare(field_name, 10, "pper", 0, 4, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorBasePriceUpper;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'e':
                            if (String.Compare(field_name, 2, "ta", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case '1':
                                        if (String.Compare(field_name, 5, "80", 0, 2, false) == 0)
                                          {
                                            switch (field_name[7])
                                              {
                                                case 'N':
                                                    if ((String.Compare(field_name, 8, "ikkei225", 0, 8, false) == 0) && (field_name.Length == 16))
                                                        return fieldGeneratorBeta180Nikkei225;
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(field_name, 8, "opix", 0, 4, false) == 0) && (field_name.Length == 12))
                                                        return fieldGeneratorBeta180Topix;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case '9':
                                        if (String.Compare(field_name, 5, "0", 0, 1, false) == 0)
                                          {
                                            switch (field_name[6])
                                              {
                                                case 'N':
                                                    if ((String.Compare(field_name, 7, "ikkei225", 0, 8, false) == 0) && (field_name.Length == 15))
                                                        return fieldGeneratorBeta90Nikkei225;
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(field_name, 7, "opix", 0, 4, false) == 0) && (field_name.Length == 11))
                                                        return fieldGeneratorBeta90Topix;
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
                        default:
                            break;
                      }
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "lcSharesOutstanding", 0, 19, false) == 0) && (field_name.Length == 21))
                                return fieldGeneratorCalcSharesOutstanding;
                            break;
                        case 'h':
                            if (String.Compare(field_name, 2, "artImageURL", 0, 11, false) == 0)
                              {
                                switch (field_name[13])
                                  {
                                    case '1':
                                        switch (field_name[14])
                                          {
                                            case 'D':
                                                if (field_name.Length == 15)
                                                    return fieldGeneratorChartImageURL1D;
                                                break;
                                            case 'Y':
                                                if (field_name.Length == 15)
                                                    return fieldGeneratorChartImageURL1Y;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case '3':
                                        if ((String.Compare(field_name, 14, "M", 0, 1, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorChartImageURL3M;
                                        break;
                                    case '5':
                                        if ((String.Compare(field_name, 14, "D", 0, 1, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorChartImageURL5D;
                                        break;
                                    case '6':
                                        if ((String.Compare(field_name, 14, "M", 0, 1, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorChartImageURL6M;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'l':
                            if ((String.Compare(field_name, 2, "ose", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorClose;
                            break;
                        case 'o':
                            switch (field_name[2])
                              {
                                case 'E':
                                    if (String.Compare(field_name, 3, "st", 0, 2, false) == 0)
                                      {
                                        switch (field_name[5])
                                          {
                                            case 'D':
                                                if ((String.Compare(field_name, 6, "ps", 0, 2, false) == 0) && (field_name.Length == 8))
                                                    return fieldGeneratorCoEstDps;
                                                break;
                                            case 'F':
                                                if ((String.Compare(field_name, 6, "yEnded", 0, 6, false) == 0) && (field_name.Length == 12))
                                                    return fieldGeneratorCoEstFyEnded;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'S':
                                    if (String.Compare(field_name, 3, "ettle", 0, 5, false) == 0)
                                      {
                                        switch (field_name[8])
                                          {
                                            case 'D':
                                                if ((String.Compare(field_name, 9, "ps", 0, 2, false) == 0) && (field_name.Length == 11))
                                                    return fieldGeneratorCoSettleDps;
                                                break;
                                            case 'F':
                                                if ((String.Compare(field_name, 9, "yEnded", 0, 6, false) == 0) && (field_name.Length == 15))
                                                    return fieldGeneratorCoSettleFyEnded;
                                                break;
                                            case 'R':
                                                if ((String.Compare(field_name, 9, "oe", 0, 2, false) == 0) && (field_name.Length == 11))
                                                    return fieldGeneratorCoSettleRoe;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'r':
                                    if ((String.Compare(field_name, 3, "pPer", 0, 4, false) == 0) && (field_name.Length == 7))
                                        return fieldGeneratorCorpPer;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rrency", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorCurrency;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'a':
                            switch (field_name[2])
                              {
                                case 'i':
                                    if ((String.Compare(field_name, 3, "lyHistoricalPrices", 0, 18, false) == 0) && (field_name.Length == 21))
                                        return fieldGeneratorDailyHistoricalPrices;
                                    break;
                                case 't':
                                    if ((String.Compare(field_name, 3, "eRange", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorDateRange;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "splayDividendDate", 0, 17, false) == 0) && (field_name.Length == 19))
                                return fieldGeneratorDisplayDividendDate;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "rning", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'F':
                                        if ((String.Compare(field_name, 8, "ullyearDate", 0, 11, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorEarningFullyearDate;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 8, "cheduledDate", 0, 12, false) == 0) && (field_name.Length == 20))
                                            return fieldGeneratorEarningScheduledDate;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'x':
                            switch (field_name[2])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 3, "ividendDate", 0, 11, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorExDividendDate;
                                    break;
                                case 't':
                                    if ((String.Compare(field_name, 3, "ernalURL", 0, 8, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorExternalURL;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "igh", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorHigh;
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'm':
                            if ((String.Compare(field_name, 2, "plicitDateRange", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorImplicitDateRange;
                            break;
                        case 'n':
                            switch (field_name[2])
                              {
                                case 'd':
                                    if ((String.Compare(field_name, 3, "ustryName", 0, 9, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorIndustryName;
                                    break;
                                case 't':
                                    if (String.Compare(field_name, 3, "ra", 0, 2, false) == 0)
                                      {
                                        switch (field_name[5])
                                          {
                                            case 'D':
                                                if ((String.Compare(field_name, 6, "ayPriceSource", 0, 13, false) == 0) && (field_name.Length == 19))
                                                    return fieldGeneratorIntraDayPriceSource;
                                                break;
                                            case 'd':
                                                if ((String.Compare(field_name, 6, "ayPrices", 0, 8, false) == 0) && (field_name.Length == 14))
                                                    return fieldGeneratorIntradayPrices;
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
                        default:
                            break;
                      }
                    break;
                case 'L':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "stingID", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorListingID;
                            break;
                        case 'o':
                            switch (field_name[2])
                              {
                                case 'n':
                                    if ((String.Compare(field_name, 3, "gName", 0, 5, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorLongName;
                                    break;
                                case 'w':
                                    if (field_name.Length == 3)
                                        return fieldGeneratorLow;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "rket", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 7, "ap", 0, 2, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorMarketCap;
                                        break;
                                    case 'c':
                                        if ((String.Compare(field_name, 7, "ap", 0, 2, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorMarketcap;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "diumName", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorMediumName;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'N':
                    switch (field_name[1])
                      {
                        case 'i':
                            if (String.Compare(field_name, 2, "kkei", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'F':
                                        if ((String.Compare(field_name, 7, "lag", 0, 3, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorNikkeiFlag;
                                        break;
                                    case 'I':
                                        if ((String.Compare(field_name, 7, "ndustryName", 0, 11, false) == 0) && (field_name.Length == 18))
                                            return fieldGeneratorNikkeiIndustryName;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "mShares", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorNumShares;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "pen", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorOpen;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'E':
                            if ((String.Compare(field_name, 2, "Ratio", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorPERatio;
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "rcentChange", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorPercentChange;
                            break;
                        case 'r':
                            switch (field_name[2])
                              {
                                case 'e':
                                    if ((String.Compare(field_name, 3, "viousCloseDate", 0, 14, false) == 0) && (field_name.Length == 17))
                                        return fieldGeneratorPreviousCloseDate;
                                    break;
                                case 'i':
                                    switch (field_name[3])
                                      {
                                        case 'c':
                                            if (String.Compare(field_name, 4, "e", 0, 1, false) == 0)
                                              {
                                                if (field_name.Length == 5)
                                                  {
                                                    return fieldGeneratorPrice;
                                                  }
                                                switch (field_name[5])
                                                  {
                                                    case 'D':
                                                        if ((String.Compare(field_name, 6, "ate", 0, 3, false) == 0) && (field_name.Length == 9))
                                                            return fieldGeneratorPriceDate;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'n':
                                            if ((String.Compare(field_name, 4, "cipalMarket", 0, 11, false) == 0) && (field_name.Length == 15))
                                                return fieldGeneratorPrincipalMarket;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'h':
                            if (String.Compare(field_name, 2, "ort", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'N':
                                        if ((String.Compare(field_name, 6, "ame", 0, 3, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorShortName;
                                        break;
                                    case 'P':
                                        if ((String.Compare(field_name, 6, "ossessiveName", 0, 13, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorShortPossessiveName;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            switch (field_name[2])
                              {
                                case '1':
                                    switch (field_name[3])
                                      {
                                        case 'P':
                                            if (String.Compare(field_name, 4, "rice", 0, 4, false) == 0)
                                              {
                                                if (field_name.Length == 8)
                                                  {
                                                    return fieldGeneratorSs1Price;
                                                  }
                                                switch (field_name[8])
                                                  {
                                                    case 'C':
                                                        if ((String.Compare(field_name, 9, "hg", 0, 2, false) == 0) && (field_name.Length == 11))
                                                            return fieldGeneratorSs1PriceChg;
                                                        break;
                                                    case 'H':
                                                        if ((String.Compare(field_name, 9, "igh", 0, 3, false) == 0) && (field_name.Length == 12))
                                                            return fieldGeneratorSs1PriceHigh;
                                                        break;
                                                    case 'L':
                                                        if ((String.Compare(field_name, 9, "ow", 0, 2, false) == 0) && (field_name.Length == 11))
                                                            return fieldGeneratorSs1PriceLow;
                                                        break;
                                                    case 'O':
                                                        if ((String.Compare(field_name, 9, "pen", 0, 3, false) == 0) && (field_name.Length == 12))
                                                            return fieldGeneratorSs1PriceOpen;
                                                        break;
                                                    case 'P':
                                                        if ((String.Compare(field_name, 9, "chg", 0, 3, false) == 0) && (field_name.Length == 12))
                                                            return fieldGeneratorSs1PricePchg;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'V':
                                            switch (field_name[4])
                                              {
                                                case 'o':
                                                    if ((String.Compare(field_name, 5, "lume", 0, 4, false) == 0) && (field_name.Length == 9))
                                                        return fieldGeneratorSs1Volume;
                                                    break;
                                                case 'w':
                                                    if ((String.Compare(field_name, 5, "ap", 0, 2, false) == 0) && (field_name.Length == 7))
                                                        return fieldGeneratorSs1Vwap;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case '2':
                                    switch (field_name[3])
                                      {
                                        case 'P':
                                            if (String.Compare(field_name, 4, "rice", 0, 4, false) == 0)
                                              {
                                                if (field_name.Length == 8)
                                                  {
                                                    return fieldGeneratorSs2Price;
                                                  }
                                                switch (field_name[8])
                                                  {
                                                    case 'C':
                                                        if ((String.Compare(field_name, 9, "hg", 0, 2, false) == 0) && (field_name.Length == 11))
                                                            return fieldGeneratorSs2PriceChg;
                                                        break;
                                                    case 'H':
                                                        if ((String.Compare(field_name, 9, "igh", 0, 3, false) == 0) && (field_name.Length == 12))
                                                            return fieldGeneratorSs2PriceHigh;
                                                        break;
                                                    case 'L':
                                                        if ((String.Compare(field_name, 9, "ow", 0, 2, false) == 0) && (field_name.Length == 11))
                                                            return fieldGeneratorSs2PriceLow;
                                                        break;
                                                    case 'O':
                                                        if ((String.Compare(field_name, 9, "pen", 0, 3, false) == 0) && (field_name.Length == 12))
                                                            return fieldGeneratorSs2PriceOpen;
                                                        break;
                                                    case 'P':
                                                        if ((String.Compare(field_name, 9, "chg", 0, 3, false) == 0) && (field_name.Length == 12))
                                                            return fieldGeneratorSs2PricePchg;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'V':
                                            switch (field_name[4])
                                              {
                                                case 'o':
                                                    if ((String.Compare(field_name, 5, "lume", 0, 4, false) == 0) && (field_name.Length == 9))
                                                        return fieldGeneratorSs2Volume;
                                                    break;
                                                case 'w':
                                                    if ((String.Compare(field_name, 5, "ap", 0, 2, false) == 0) && (field_name.Length == 7))
                                                        return fieldGeneratorSs2Vwap;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 't':
                            if (String.Compare(field_name, 2, "ockExchange", 0, 11, false) == 0)
                              {
                                switch (field_name[13])
                                  {
                                    case 'L':
                                        if ((String.Compare(field_name, 14, "ongName", 0, 7, false) == 0) && (field_name.Length == 21))
                                            return fieldGeneratorStockExchangeLongName;
                                        break;
                                    case 'S':
                                        switch (field_name[14])
                                          {
                                            case 'h':
                                                if ((String.Compare(field_name, 15, "ortName", 0, 7, false) == 0) && (field_name.Length == 22))
                                                    return fieldGeneratorStockExchangeShortName;
                                                break;
                                            case 'y':
                                                if ((String.Compare(field_name, 15, "mbol", 0, 4, false) == 0) && (field_name.Length == 19))
                                                    return fieldGeneratorStockExchangeSymbol;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'U':
                                        if ((String.Compare(field_name, 14, "TCOffset", 0, 8, false) == 0) && (field_name.Length == 22))
                                            return fieldGeneratorStockExchangeUTCOffset;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'y':
                            if ((String.Compare(field_name, 2, "mbol", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorSymbol;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "ckSizeFlag", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorTickSizeFlag;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "pix500Flag", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorTopix500Flag;
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "ading", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'U':
                                        if ((String.Compare(field_name, 8, "nit", 0, 3, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorTradingUnit;
                                        break;
                                    case 'V':
                                        if ((String.Compare(field_name, 8, "alue", 0, 4, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorTradingValue;
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
                case 'V':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "lueChange", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorValueChange;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "lume", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorVolume;
                            break;
                        case 'w':
                            if ((String.Compare(field_name, 2, "ap", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorVwap;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorListingID = new FieldHoldingGeneratorListingID("field \"ListingID\" of the StockListing class");
            fieldGeneratorSymbol = new StockAttributeValueJSON.HoldingGenerator("field \"Symbol\" of the StockListing class", ignore_extras);
            fieldGeneratorShortName = new StockAttributeValueJSON.HoldingGenerator("field \"ShortName\" of the StockListing class", ignore_extras);
            fieldGeneratorShortPossessiveName = new StockAttributeValueJSON.HoldingGenerator("field \"ShortPossessiveName\" of the StockListing class", ignore_extras);
            fieldGeneratorMediumName = new StockAttributeValueJSON.HoldingGenerator("field \"MediumName\" of the StockListing class", ignore_extras);
            fieldGeneratorLongName = new StockAttributeValueJSON.HoldingGenerator("field \"LongName\" of the StockListing class", ignore_extras);
            fieldGeneratorPrice = new StockAttributeValueJSON.HoldingGenerator("field \"Price\" of the StockListing class", ignore_extras);
            fieldGeneratorPriceDate = new DateAndOrTimeJSON.HoldingGenerator("field \"PriceDate\" of the StockListing class", ignore_extras);
            fieldGeneratorIntraDayPriceSource = new JSONHoldingBooleanGenerator("field \"IntraDayPriceSource\" of the StockListing class");
            fieldGeneratorCurrency = new JSONHoldingStringGenerator("field \"Currency\" of the StockListing class");
            fieldGeneratorIntradayPrices = new StockHistoricalQuoteJSON.HoldingArrayGenerator("field \"IntradayPrices\" of the StockListing class", ignore_extras);
            fieldGeneratorDailyHistoricalPrices = new StockHistoricalQuoteJSON.HoldingArrayGenerator("field \"DailyHistoricalPrices\" of the StockListing class", ignore_extras);
            fieldGeneratorPERatio = new StockAttributeValueJSON.HoldingGenerator("field \"PERatio\" of the StockListing class", ignore_extras);
            fieldGeneratorMarketCap = new StockAttributeValueJSON.HoldingGenerator("field \"MarketCap\" of the StockListing class", ignore_extras);
            fieldGeneratorVolume = new StockAttributeValueJSON.HoldingGenerator("field \"Volume\" of the StockListing class", ignore_extras);
            fieldGeneratorValueChange = new StockAttributeValueJSON.HoldingGenerator("field \"ValueChange\" of the StockListing class", ignore_extras);
            fieldGeneratorPercentChange = new StockAttributeValueJSON.HoldingGenerator("field \"PercentChange\" of the StockListing class", ignore_extras);
            fieldGeneratorPreviousCloseDate = new DateAndOrTimeJSON.HoldingGenerator("field \"PreviousCloseDate\" of the StockListing class", ignore_extras);
            fieldGeneratorOpen = new JSONHoldingNumberTextGenerator("field \"Open\" of the StockListing class");
            fieldGeneratorClose = new JSONHoldingNumberTextGenerator("field \"Close\" of the StockListing class");
            fieldGeneratorChartImageURL1D = new JSONHoldingStringGenerator("field \"ChartImageURL1D\" of the StockListing class");
            fieldGeneratorChartImageURL5D = new JSONHoldingStringGenerator("field \"ChartImageURL5D\" of the StockListing class");
            fieldGeneratorChartImageURL3M = new JSONHoldingStringGenerator("field \"ChartImageURL3M\" of the StockListing class");
            fieldGeneratorChartImageURL6M = new JSONHoldingStringGenerator("field \"ChartImageURL6M\" of the StockListing class");
            fieldGeneratorChartImageURL1Y = new JSONHoldingStringGenerator("field \"ChartImageURL1Y\" of the StockListing class");
            fieldGeneratorExternalURL = new JSONHoldingStringGenerator("field \"ExternalURL\" of the StockListing class");
            fieldGeneratorStockExchangeShortName = new StockAttributeValueJSON.HoldingGenerator("field \"StockExchangeShortName\" of the StockListing class", ignore_extras);
            fieldGeneratorStockExchangeLongName = new StockAttributeValueJSON.HoldingGenerator("field \"StockExchangeLongName\" of the StockListing class", ignore_extras);
            fieldGeneratorStockExchangeSymbol = new StockAttributeValueJSON.HoldingGenerator("field \"StockExchangeSymbol\" of the StockListing class", ignore_extras);
            fieldGeneratorStockExchangeUTCOffset = new JSONHoldingNumberTextGenerator("field \"StockExchangeUTCOffset\" of the StockListing class");
            fieldGeneratorNumShares = new FieldHoldingGeneratorNumShares("field \"NumShares\" of the StockListing class");
            fieldGeneratorDateRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateRange\" of the StockListing class", ignore_extras);
            fieldGeneratorImplicitDateRange = new JSONHoldingBooleanGenerator("field \"ImplicitDateRange\" of the StockListing class");
            fieldGeneratorHigh = new JSONHoldingNumberTextGenerator("field \"High\" of the StockListing class");
            fieldGeneratorLow = new JSONHoldingNumberTextGenerator("field \"Low\" of the StockListing class");
            fieldGeneratorBasePrice = new JSONHoldingStringGenerator("field \"BasePrice\" of the StockListing class");
            fieldGeneratorBasePriceUpper = new JSONHoldingStringGenerator("field \"BasePriceUpper\" of the StockListing class");
            fieldGeneratorBasePriceLower = new JSONHoldingStringGenerator("field \"BasePriceLower\" of the StockListing class");
            fieldGeneratorTradingValue = new JSONHoldingStringGenerator("field \"TradingValue\" of the StockListing class");
            fieldGeneratorVwap = new JSONHoldingStringGenerator("field \"Vwap\" of the StockListing class");
            fieldGeneratorMarketcap = new JSONHoldingStringGenerator("field \"Marketcap\" of the StockListing class");
            fieldGeneratorTradingUnit = new JSONHoldingStringGenerator("field \"TradingUnit\" of the StockListing class");
            fieldGeneratorCalcSharesOutstanding = new JSONHoldingStringGenerator("field \"CalcSharesOutstanding\" of the StockListing class");
            fieldGeneratorTickSizeFlag = new JSONHoldingStringGenerator("field \"TickSizeFlag\" of the StockListing class");
            fieldGeneratorPrincipalMarket = new JSONHoldingStringGenerator("field \"PrincipalMarket\" of the StockListing class");
            fieldGeneratorIndustryName = new JSONHoldingStringGenerator("field \"IndustryName\" of the StockListing class");
            fieldGeneratorNikkeiIndustryName = new JSONHoldingStringGenerator("field \"NikkeiIndustryName\" of the StockListing class");
            fieldGeneratorNikkeiFlag = new JSONHoldingStringGenerator("field \"NikkeiFlag\" of the StockListing class");
            fieldGeneratorTopix500Flag = new JSONHoldingStringGenerator("field \"Topix500Flag\" of the StockListing class");
            fieldGeneratorSs1Price = new JSONHoldingStringGenerator("field \"Ss1Price\" of the StockListing class");
            fieldGeneratorSs1PriceOpen = new JSONHoldingStringGenerator("field \"Ss1PriceOpen\" of the StockListing class");
            fieldGeneratorSs1PriceHigh = new JSONHoldingStringGenerator("field \"Ss1PriceHigh\" of the StockListing class");
            fieldGeneratorSs1PriceLow = new JSONHoldingStringGenerator("field \"Ss1PriceLow\" of the StockListing class");
            fieldGeneratorSs1PriceChg = new JSONHoldingStringGenerator("field \"Ss1PriceChg\" of the StockListing class");
            fieldGeneratorSs1PricePchg = new JSONHoldingStringGenerator("field \"Ss1PricePchg\" of the StockListing class");
            fieldGeneratorSs1Volume = new JSONHoldingStringGenerator("field \"Ss1Volume\" of the StockListing class");
            fieldGeneratorSs1Vwap = new JSONHoldingStringGenerator("field \"Ss1Vwap\" of the StockListing class");
            fieldGeneratorSs2Price = new JSONHoldingStringGenerator("field \"Ss2Price\" of the StockListing class");
            fieldGeneratorSs2PriceOpen = new JSONHoldingStringGenerator("field \"Ss2PriceOpen\" of the StockListing class");
            fieldGeneratorSs2PriceHigh = new JSONHoldingStringGenerator("field \"Ss2PriceHigh\" of the StockListing class");
            fieldGeneratorSs2PriceLow = new JSONHoldingStringGenerator("field \"Ss2PriceLow\" of the StockListing class");
            fieldGeneratorSs2PriceChg = new JSONHoldingStringGenerator("field \"Ss2PriceChg\" of the StockListing class");
            fieldGeneratorSs2PricePchg = new JSONHoldingStringGenerator("field \"Ss2PricePchg\" of the StockListing class");
            fieldGeneratorSs2Volume = new JSONHoldingStringGenerator("field \"Ss2Volume\" of the StockListing class");
            fieldGeneratorSs2Vwap = new JSONHoldingStringGenerator("field \"Ss2Vwap\" of the StockListing class");
            fieldGeneratorCorpPer = new JSONHoldingStringGenerator("field \"CorpPer\" of the StockListing class");
            fieldGeneratorBeta90Topix = new JSONHoldingStringGenerator("field \"Beta90Topix\" of the StockListing class");
            fieldGeneratorBeta180Topix = new JSONHoldingStringGenerator("field \"Beta180Topix\" of the StockListing class");
            fieldGeneratorBeta90Nikkei225 = new JSONHoldingStringGenerator("field \"Beta90Nikkei225\" of the StockListing class");
            fieldGeneratorBeta180Nikkei225 = new JSONHoldingStringGenerator("field \"Beta180Nikkei225\" of the StockListing class");
            fieldGeneratorEarningScheduledDate = new JSONHoldingStringGenerator("field \"EarningScheduledDate\" of the StockListing class");
            fieldGeneratorEarningFullyearDate = new JSONHoldingStringGenerator("field \"EarningFullyearDate\" of the StockListing class");
            fieldGeneratorDisplayDividendDate = new JSONHoldingStringGenerator("field \"DisplayDividendDate\" of the StockListing class");
            fieldGeneratorExDividendDate = new JSONHoldingStringGenerator("field \"ExDividendDate\" of the StockListing class");
            fieldGeneratorCoSettleFyEnded = new JSONHoldingStringGenerator("field \"CoSettleFyEnded\" of the StockListing class");
            fieldGeneratorCoSettleRoe = new JSONHoldingStringGenerator("field \"CoSettleRoe\" of the StockListing class");
            fieldGeneratorCoSettleDps = new JSONHoldingStringGenerator("field \"CoSettleDps\" of the StockListing class");
            fieldGeneratorCoEstFyEnded = new JSONHoldingStringGenerator("field \"CoEstFyEnded\" of the StockListing class");
            fieldGeneratorCoEstDps = new JSONHoldingStringGenerator("field \"CoEstDps\" of the StockListing class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockListing class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorListingID = new FieldHoldingGeneratorListingID("field \"ListingID\" of the StockListing class");
            fieldGeneratorSymbol = new StockAttributeValueJSON.HoldingGenerator("field \"Symbol\" of the StockListing class", false);
            fieldGeneratorShortName = new StockAttributeValueJSON.HoldingGenerator("field \"ShortName\" of the StockListing class", false);
            fieldGeneratorShortPossessiveName = new StockAttributeValueJSON.HoldingGenerator("field \"ShortPossessiveName\" of the StockListing class", false);
            fieldGeneratorMediumName = new StockAttributeValueJSON.HoldingGenerator("field \"MediumName\" of the StockListing class", false);
            fieldGeneratorLongName = new StockAttributeValueJSON.HoldingGenerator("field \"LongName\" of the StockListing class", false);
            fieldGeneratorPrice = new StockAttributeValueJSON.HoldingGenerator("field \"Price\" of the StockListing class", false);
            fieldGeneratorPriceDate = new DateAndOrTimeJSON.HoldingGenerator("field \"PriceDate\" of the StockListing class", false);
            fieldGeneratorIntraDayPriceSource = new JSONHoldingBooleanGenerator("field \"IntraDayPriceSource\" of the StockListing class");
            fieldGeneratorCurrency = new JSONHoldingStringGenerator("field \"Currency\" of the StockListing class");
            fieldGeneratorIntradayPrices = new StockHistoricalQuoteJSON.HoldingArrayGenerator("field \"IntradayPrices\" of the StockListing class", false);
            fieldGeneratorDailyHistoricalPrices = new StockHistoricalQuoteJSON.HoldingArrayGenerator("field \"DailyHistoricalPrices\" of the StockListing class", false);
            fieldGeneratorPERatio = new StockAttributeValueJSON.HoldingGenerator("field \"PERatio\" of the StockListing class", false);
            fieldGeneratorMarketCap = new StockAttributeValueJSON.HoldingGenerator("field \"MarketCap\" of the StockListing class", false);
            fieldGeneratorVolume = new StockAttributeValueJSON.HoldingGenerator("field \"Volume\" of the StockListing class", false);
            fieldGeneratorValueChange = new StockAttributeValueJSON.HoldingGenerator("field \"ValueChange\" of the StockListing class", false);
            fieldGeneratorPercentChange = new StockAttributeValueJSON.HoldingGenerator("field \"PercentChange\" of the StockListing class", false);
            fieldGeneratorPreviousCloseDate = new DateAndOrTimeJSON.HoldingGenerator("field \"PreviousCloseDate\" of the StockListing class", false);
            fieldGeneratorOpen = new JSONHoldingNumberTextGenerator("field \"Open\" of the StockListing class");
            fieldGeneratorClose = new JSONHoldingNumberTextGenerator("field \"Close\" of the StockListing class");
            fieldGeneratorChartImageURL1D = new JSONHoldingStringGenerator("field \"ChartImageURL1D\" of the StockListing class");
            fieldGeneratorChartImageURL5D = new JSONHoldingStringGenerator("field \"ChartImageURL5D\" of the StockListing class");
            fieldGeneratorChartImageURL3M = new JSONHoldingStringGenerator("field \"ChartImageURL3M\" of the StockListing class");
            fieldGeneratorChartImageURL6M = new JSONHoldingStringGenerator("field \"ChartImageURL6M\" of the StockListing class");
            fieldGeneratorChartImageURL1Y = new JSONHoldingStringGenerator("field \"ChartImageURL1Y\" of the StockListing class");
            fieldGeneratorExternalURL = new JSONHoldingStringGenerator("field \"ExternalURL\" of the StockListing class");
            fieldGeneratorStockExchangeShortName = new StockAttributeValueJSON.HoldingGenerator("field \"StockExchangeShortName\" of the StockListing class", false);
            fieldGeneratorStockExchangeLongName = new StockAttributeValueJSON.HoldingGenerator("field \"StockExchangeLongName\" of the StockListing class", false);
            fieldGeneratorStockExchangeSymbol = new StockAttributeValueJSON.HoldingGenerator("field \"StockExchangeSymbol\" of the StockListing class", false);
            fieldGeneratorStockExchangeUTCOffset = new JSONHoldingNumberTextGenerator("field \"StockExchangeUTCOffset\" of the StockListing class");
            fieldGeneratorNumShares = new FieldHoldingGeneratorNumShares("field \"NumShares\" of the StockListing class");
            fieldGeneratorDateRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateRange\" of the StockListing class", false);
            fieldGeneratorImplicitDateRange = new JSONHoldingBooleanGenerator("field \"ImplicitDateRange\" of the StockListing class");
            fieldGeneratorHigh = new JSONHoldingNumberTextGenerator("field \"High\" of the StockListing class");
            fieldGeneratorLow = new JSONHoldingNumberTextGenerator("field \"Low\" of the StockListing class");
            fieldGeneratorBasePrice = new JSONHoldingStringGenerator("field \"BasePrice\" of the StockListing class");
            fieldGeneratorBasePriceUpper = new JSONHoldingStringGenerator("field \"BasePriceUpper\" of the StockListing class");
            fieldGeneratorBasePriceLower = new JSONHoldingStringGenerator("field \"BasePriceLower\" of the StockListing class");
            fieldGeneratorTradingValue = new JSONHoldingStringGenerator("field \"TradingValue\" of the StockListing class");
            fieldGeneratorVwap = new JSONHoldingStringGenerator("field \"Vwap\" of the StockListing class");
            fieldGeneratorMarketcap = new JSONHoldingStringGenerator("field \"Marketcap\" of the StockListing class");
            fieldGeneratorTradingUnit = new JSONHoldingStringGenerator("field \"TradingUnit\" of the StockListing class");
            fieldGeneratorCalcSharesOutstanding = new JSONHoldingStringGenerator("field \"CalcSharesOutstanding\" of the StockListing class");
            fieldGeneratorTickSizeFlag = new JSONHoldingStringGenerator("field \"TickSizeFlag\" of the StockListing class");
            fieldGeneratorPrincipalMarket = new JSONHoldingStringGenerator("field \"PrincipalMarket\" of the StockListing class");
            fieldGeneratorIndustryName = new JSONHoldingStringGenerator("field \"IndustryName\" of the StockListing class");
            fieldGeneratorNikkeiIndustryName = new JSONHoldingStringGenerator("field \"NikkeiIndustryName\" of the StockListing class");
            fieldGeneratorNikkeiFlag = new JSONHoldingStringGenerator("field \"NikkeiFlag\" of the StockListing class");
            fieldGeneratorTopix500Flag = new JSONHoldingStringGenerator("field \"Topix500Flag\" of the StockListing class");
            fieldGeneratorSs1Price = new JSONHoldingStringGenerator("field \"Ss1Price\" of the StockListing class");
            fieldGeneratorSs1PriceOpen = new JSONHoldingStringGenerator("field \"Ss1PriceOpen\" of the StockListing class");
            fieldGeneratorSs1PriceHigh = new JSONHoldingStringGenerator("field \"Ss1PriceHigh\" of the StockListing class");
            fieldGeneratorSs1PriceLow = new JSONHoldingStringGenerator("field \"Ss1PriceLow\" of the StockListing class");
            fieldGeneratorSs1PriceChg = new JSONHoldingStringGenerator("field \"Ss1PriceChg\" of the StockListing class");
            fieldGeneratorSs1PricePchg = new JSONHoldingStringGenerator("field \"Ss1PricePchg\" of the StockListing class");
            fieldGeneratorSs1Volume = new JSONHoldingStringGenerator("field \"Ss1Volume\" of the StockListing class");
            fieldGeneratorSs1Vwap = new JSONHoldingStringGenerator("field \"Ss1Vwap\" of the StockListing class");
            fieldGeneratorSs2Price = new JSONHoldingStringGenerator("field \"Ss2Price\" of the StockListing class");
            fieldGeneratorSs2PriceOpen = new JSONHoldingStringGenerator("field \"Ss2PriceOpen\" of the StockListing class");
            fieldGeneratorSs2PriceHigh = new JSONHoldingStringGenerator("field \"Ss2PriceHigh\" of the StockListing class");
            fieldGeneratorSs2PriceLow = new JSONHoldingStringGenerator("field \"Ss2PriceLow\" of the StockListing class");
            fieldGeneratorSs2PriceChg = new JSONHoldingStringGenerator("field \"Ss2PriceChg\" of the StockListing class");
            fieldGeneratorSs2PricePchg = new JSONHoldingStringGenerator("field \"Ss2PricePchg\" of the StockListing class");
            fieldGeneratorSs2Volume = new JSONHoldingStringGenerator("field \"Ss2Volume\" of the StockListing class");
            fieldGeneratorSs2Vwap = new JSONHoldingStringGenerator("field \"Ss2Vwap\" of the StockListing class");
            fieldGeneratorCorpPer = new JSONHoldingStringGenerator("field \"CorpPer\" of the StockListing class");
            fieldGeneratorBeta90Topix = new JSONHoldingStringGenerator("field \"Beta90Topix\" of the StockListing class");
            fieldGeneratorBeta180Topix = new JSONHoldingStringGenerator("field \"Beta180Topix\" of the StockListing class");
            fieldGeneratorBeta90Nikkei225 = new JSONHoldingStringGenerator("field \"Beta90Nikkei225\" of the StockListing class");
            fieldGeneratorBeta180Nikkei225 = new JSONHoldingStringGenerator("field \"Beta180Nikkei225\" of the StockListing class");
            fieldGeneratorEarningScheduledDate = new JSONHoldingStringGenerator("field \"EarningScheduledDate\" of the StockListing class");
            fieldGeneratorEarningFullyearDate = new JSONHoldingStringGenerator("field \"EarningFullyearDate\" of the StockListing class");
            fieldGeneratorDisplayDividendDate = new JSONHoldingStringGenerator("field \"DisplayDividendDate\" of the StockListing class");
            fieldGeneratorExDividendDate = new JSONHoldingStringGenerator("field \"ExDividendDate\" of the StockListing class");
            fieldGeneratorCoSettleFyEnded = new JSONHoldingStringGenerator("field \"CoSettleFyEnded\" of the StockListing class");
            fieldGeneratorCoSettleRoe = new JSONHoldingStringGenerator("field \"CoSettleRoe\" of the StockListing class");
            fieldGeneratorCoSettleDps = new JSONHoldingStringGenerator("field \"CoSettleDps\" of the StockListing class");
            fieldGeneratorCoEstFyEnded = new JSONHoldingStringGenerator("field \"CoEstFyEnded\" of the StockListing class");
            fieldGeneratorCoEstDps = new JSONHoldingStringGenerator("field \"CoEstDps\" of the StockListing class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockListing class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorListingID.reset();
            fieldGeneratorSymbol.reset();
            fieldGeneratorShortName.reset();
            fieldGeneratorShortPossessiveName.reset();
            fieldGeneratorMediumName.reset();
            fieldGeneratorLongName.reset();
            fieldGeneratorPrice.reset();
            fieldGeneratorPriceDate.reset();
            fieldGeneratorIntraDayPriceSource.reset();
            fieldGeneratorCurrency.reset();
            fieldGeneratorIntradayPrices.reset();
            fieldGeneratorDailyHistoricalPrices.reset();
            fieldGeneratorPERatio.reset();
            fieldGeneratorMarketCap.reset();
            fieldGeneratorVolume.reset();
            fieldGeneratorValueChange.reset();
            fieldGeneratorPercentChange.reset();
            fieldGeneratorPreviousCloseDate.reset();
            fieldGeneratorOpen.reset();
            fieldGeneratorClose.reset();
            fieldGeneratorChartImageURL1D.reset();
            fieldGeneratorChartImageURL5D.reset();
            fieldGeneratorChartImageURL3M.reset();
            fieldGeneratorChartImageURL6M.reset();
            fieldGeneratorChartImageURL1Y.reset();
            fieldGeneratorExternalURL.reset();
            fieldGeneratorStockExchangeShortName.reset();
            fieldGeneratorStockExchangeLongName.reset();
            fieldGeneratorStockExchangeSymbol.reset();
            fieldGeneratorStockExchangeUTCOffset.reset();
            fieldGeneratorNumShares.reset();
            fieldGeneratorDateRange.reset();
            fieldGeneratorImplicitDateRange.reset();
            fieldGeneratorHigh.reset();
            fieldGeneratorLow.reset();
            fieldGeneratorBasePrice.reset();
            fieldGeneratorBasePriceUpper.reset();
            fieldGeneratorBasePriceLower.reset();
            fieldGeneratorTradingValue.reset();
            fieldGeneratorVwap.reset();
            fieldGeneratorMarketcap.reset();
            fieldGeneratorTradingUnit.reset();
            fieldGeneratorCalcSharesOutstanding.reset();
            fieldGeneratorTickSizeFlag.reset();
            fieldGeneratorPrincipalMarket.reset();
            fieldGeneratorIndustryName.reset();
            fieldGeneratorNikkeiIndustryName.reset();
            fieldGeneratorNikkeiFlag.reset();
            fieldGeneratorTopix500Flag.reset();
            fieldGeneratorSs1Price.reset();
            fieldGeneratorSs1PriceOpen.reset();
            fieldGeneratorSs1PriceHigh.reset();
            fieldGeneratorSs1PriceLow.reset();
            fieldGeneratorSs1PriceChg.reset();
            fieldGeneratorSs1PricePchg.reset();
            fieldGeneratorSs1Volume.reset();
            fieldGeneratorSs1Vwap.reset();
            fieldGeneratorSs2Price.reset();
            fieldGeneratorSs2PriceOpen.reset();
            fieldGeneratorSs2PriceHigh.reset();
            fieldGeneratorSs2PriceLow.reset();
            fieldGeneratorSs2PriceChg.reset();
            fieldGeneratorSs2PricePchg.reset();
            fieldGeneratorSs2Volume.reset();
            fieldGeneratorSs2Vwap.reset();
            fieldGeneratorCorpPer.reset();
            fieldGeneratorBeta90Topix.reset();
            fieldGeneratorBeta180Topix.reset();
            fieldGeneratorBeta90Nikkei225.reset();
            fieldGeneratorBeta180Nikkei225.reset();
            fieldGeneratorEarningScheduledDate.reset();
            fieldGeneratorEarningFullyearDate.reset();
            fieldGeneratorDisplayDividendDate.reset();
            fieldGeneratorExDividendDate.reset();
            fieldGeneratorCoSettleFyEnded.reset();
            fieldGeneratorCoSettleRoe.reset();
            fieldGeneratorCoSettleDps.reset();
            fieldGeneratorCoEstFyEnded.reset();
            fieldGeneratorCoEstDps.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSymbol.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorShortName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorShortPossessiveName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMediumName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLongName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPrice.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPriceDate.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorIntradayPrices.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDailyHistoricalPrices.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPERatio.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMarketCap.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorVolume.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorValueChange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPercentChange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPreviousCloseDate.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStockExchangeShortName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStockExchangeLongName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStockExchangeSymbol.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDateRange.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSymbol.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorShortName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorShortPossessiveName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMediumName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLongName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPrice.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPriceDate.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorIntradayPrices.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDailyHistoricalPrices.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPERatio.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMarketCap.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorVolume.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorValueChange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPercentChange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPreviousCloseDate.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStockExchangeShortName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStockExchangeLongName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStockExchangeSymbol.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDateRange.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StockListingJSON  result)
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
        public StockListingJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockListingJSON  result)
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
    protected virtual void handle_result(List<StockListingJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockListingJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockListingJSON>();
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
    public List<StockListingJSON> value;
  };
  };
