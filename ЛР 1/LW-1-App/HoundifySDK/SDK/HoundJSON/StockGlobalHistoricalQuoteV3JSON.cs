/* file "StockGlobalHistoricalQuoteV3JSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StockGlobalHistoricalQuoteV3JSON : JSONBase
  {
    public struct TypeOpen
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public double choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeClose
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public double choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeHigh
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public double choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeLow
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public double choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeLast
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public double choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeVolume
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public double choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeCumulativeAdjustmentFactor
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public double choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeCurrency
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    private bool flagHasDate;
    private string storeDate;
    private bool flagHasOpen;
    private TypeOpen storeOpen;
    private bool flagHasClose;
    private TypeClose storeClose;
    private bool flagHasHigh;
    private TypeHigh storeHigh;
    private bool flagHasLow;
    private TypeLow storeLow;
    private bool flagHasLast;
    private TypeLast storeLast;
    private bool flagHasVolume;
    private TypeVolume storeVolume;
    private bool flagHasCumulativeAdjustmentFactor;
    private TypeCumulativeAdjustmentFactor storeCumulativeAdjustmentFactor;
    private bool flagHasCurrency;
    private TypeCurrency storeCurrency;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Date of StockGlobalHistoricalQuoteV3JSON is not a string.");
        setDate(json_string.getData());
      }


    private void  fromJSONOpen(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeOpen or_result = new TypeOpen();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                or_result.u.choice0 = the_double;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Open of StockGlobalHistoricalQuoteV3JSON is not one of the allowed values.");
        setOpen(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONClose(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeClose or_result = new TypeClose();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                or_result.u.choice0 = the_double;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Close of StockGlobalHistoricalQuoteV3JSON is not one of the allowed values.");
        setClose(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONHigh(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeHigh or_result = new TypeHigh();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                or_result.u.choice0 = the_double;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field High of StockGlobalHistoricalQuoteV3JSON is not one of the allowed values.");
        setHigh(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONLow(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeLow or_result = new TypeLow();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                or_result.u.choice0 = the_double;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Low of StockGlobalHistoricalQuoteV3JSON is not one of the allowed values.");
        setLow(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONLast(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeLast or_result = new TypeLast();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                or_result.u.choice0 = the_double;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Last of StockGlobalHistoricalQuoteV3JSON is not one of the allowed values.");
        setLast(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONVolume(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeVolume or_result = new TypeVolume();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                or_result.u.choice0 = the_double;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Volume of StockGlobalHistoricalQuoteV3JSON is not one of the allowed values.");
        setVolume(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONCumulativeAdjustmentFactor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeCumulativeAdjustmentFactor or_result = new TypeCumulativeAdjustmentFactor();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                or_result.u.choice0 = the_double;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field CumulativeAdjustmentFactor of StockGlobalHistoricalQuoteV3JSON is not one of the allowed values.");
        setCumulativeAdjustmentFactor(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONCurrency(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeCurrency or_result = new TypeCurrency();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Currency of StockGlobalHistoricalQuoteV3JSON is not one of the allowed values.");
        setCurrency(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    public StockGlobalHistoricalQuoteV3JSON()
      {
        flagHasDate = false;
        flagHasOpen = false;
        flagHasClose = false;
        flagHasHigh = false;
        flagHasLow = false;
        flagHasLast = false;
        flagHasVolume = false;
        flagHasCumulativeAdjustmentFactor = false;
        flagHasCurrency = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDate()
      {
        return flagHasDate;
      }

    public string  getDate()
      {
        Debug.Assert(flagHasDate);
        return storeDate;
      }

    public bool  hasOpen()
      {
        return flagHasOpen;
      }

    public TypeOpen  getOpen()
      {
        Debug.Assert(flagHasOpen);
        return storeOpen;
      }

    public bool  hasClose()
      {
        return flagHasClose;
      }

    public TypeClose  getClose()
      {
        Debug.Assert(flagHasClose);
        return storeClose;
      }

    public bool  hasHigh()
      {
        return flagHasHigh;
      }

    public TypeHigh  getHigh()
      {
        Debug.Assert(flagHasHigh);
        return storeHigh;
      }

    public bool  hasLow()
      {
        return flagHasLow;
      }

    public TypeLow  getLow()
      {
        Debug.Assert(flagHasLow);
        return storeLow;
      }

    public bool  hasLast()
      {
        return flagHasLast;
      }

    public TypeLast  getLast()
      {
        Debug.Assert(flagHasLast);
        return storeLast;
      }

    public bool  hasVolume()
      {
        return flagHasVolume;
      }

    public TypeVolume  getVolume()
      {
        Debug.Assert(flagHasVolume);
        return storeVolume;
      }

    public bool  hasCumulativeAdjustmentFactor()
      {
        return flagHasCumulativeAdjustmentFactor;
      }

    public TypeCumulativeAdjustmentFactor  getCumulativeAdjustmentFactor()
      {
        Debug.Assert(flagHasCumulativeAdjustmentFactor);
        return storeCumulativeAdjustmentFactor;
      }

    public bool  hasCurrency()
      {
        return flagHasCurrency;
      }

    public TypeCurrency  getCurrency()
      {
        Debug.Assert(flagHasCurrency);
        return storeCurrency;
      }


    public virtual int extraStockGlobalHistoricalQuoteV3ComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockGlobalHistoricalQuoteV3ComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockGlobalHistoricalQuoteV3ComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockGlobalHistoricalQuoteV3Lookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setDate(string new_value)
      {
        flagHasDate = true;
        storeDate = new_value;
      }
    public void unsetDate()
      {
        flagHasDate = false;
      }
    public void setOpen(TypeOpen new_value)
      {
        flagHasOpen = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeOpen = new_value;
      }
    public void unsetOpen()
      {
        flagHasOpen = false;
      }
    public void setClose(TypeClose new_value)
      {
        flagHasClose = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeClose = new_value;
      }
    public void unsetClose()
      {
        flagHasClose = false;
      }
    public void setHigh(TypeHigh new_value)
      {
        flagHasHigh = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeHigh = new_value;
      }
    public void unsetHigh()
      {
        flagHasHigh = false;
      }
    public void setLow(TypeLow new_value)
      {
        flagHasLow = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeLow = new_value;
      }
    public void unsetLow()
      {
        flagHasLow = false;
      }
    public void setLast(TypeLast new_value)
      {
        flagHasLast = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeLast = new_value;
      }
    public void unsetLast()
      {
        flagHasLast = false;
      }
    public void setVolume(TypeVolume new_value)
      {
        flagHasVolume = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeVolume = new_value;
      }
    public void unsetVolume()
      {
        flagHasVolume = false;
      }
    public void setCumulativeAdjustmentFactor(TypeCumulativeAdjustmentFactor new_value)
      {
        flagHasCumulativeAdjustmentFactor = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeCumulativeAdjustmentFactor = new_value;
      }
    public void unsetCumulativeAdjustmentFactor()
      {
        flagHasCumulativeAdjustmentFactor = false;
      }
    public void setCurrency(TypeCurrency new_value)
      {
        flagHasCurrency = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeCurrency = new_value;
      }
    public void unsetCurrency()
      {
        flagHasCurrency = false;
      }

    public virtual void extraStockGlobalHistoricalQuoteV3AppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockGlobalHistoricalQuoteV3SetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockGlobalHistoricalQuoteV3Lookup(key);
        if (old_field == null)
          {
            extraStockGlobalHistoricalQuoteV3AppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDate);
        if (flagHasDate)
          {
            handler.start_pair("Date");
            handler.string_value(storeDate);
          }
        if (flagHasOpen)
          {
            handler.start_pair("Open");
            switch (storeOpen.key)
              {
                case 0:
                    if (((double)(long)storeOpen.u.choice0) == storeOpen.u.choice0)
                        handler.number_value((long)storeOpen.u.choice0);
                    else
                        handler.number_value(storeOpen.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasClose)
          {
            handler.start_pair("Close");
            switch (storeClose.key)
              {
                case 0:
                    if (((double)(long)storeClose.u.choice0) == storeClose.u.choice0)
                        handler.number_value((long)storeClose.u.choice0);
                    else
                        handler.number_value(storeClose.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasHigh)
          {
            handler.start_pair("High");
            switch (storeHigh.key)
              {
                case 0:
                    if (((double)(long)storeHigh.u.choice0) == storeHigh.u.choice0)
                        handler.number_value((long)storeHigh.u.choice0);
                    else
                        handler.number_value(storeHigh.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasLow)
          {
            handler.start_pair("Low");
            switch (storeLow.key)
              {
                case 0:
                    if (((double)(long)storeLow.u.choice0) == storeLow.u.choice0)
                        handler.number_value((long)storeLow.u.choice0);
                    else
                        handler.number_value(storeLow.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasLast)
          {
            handler.start_pair("Last");
            switch (storeLast.key)
              {
                case 0:
                    if (((double)(long)storeLast.u.choice0) == storeLast.u.choice0)
                        handler.number_value((long)storeLast.u.choice0);
                    else
                        handler.number_value(storeLast.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasVolume)
          {
            handler.start_pair("Volume");
            switch (storeVolume.key)
              {
                case 0:
                    if (((double)(long)storeVolume.u.choice0) == storeVolume.u.choice0)
                        handler.number_value((long)storeVolume.u.choice0);
                    else
                        handler.number_value(storeVolume.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasCumulativeAdjustmentFactor)
          {
            handler.start_pair("CumulativeAdjustmentFactor");
            switch (storeCumulativeAdjustmentFactor.key)
              {
                case 0:
                    if (((double)(long)storeCumulativeAdjustmentFactor.u.choice0) == storeCumulativeAdjustmentFactor.u.choice0)
                        handler.number_value((long)storeCumulativeAdjustmentFactor.u.choice0);
                    else
                        handler.number_value(storeCumulativeAdjustmentFactor.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasCurrency)
          {
            handler.start_pair("Currency");
            switch (storeCurrency.key)
              {
                case 0:
                    handler.string_value(storeCurrency.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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
        if (!(hasDate()))
          {
            return "When parsing the object for %what%, the \"Date\" field was missing.";
          }
        return null;
      }

    public static StockGlobalHistoricalQuoteV3JSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockGlobalHistoricalQuoteV3JSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockGlobalHistoricalQuoteV3", ignore_extras);
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
    public static StockGlobalHistoricalQuoteV3JSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockGlobalHistoricalQuoteV3JSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockGlobalHistoricalQuoteV3JSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockGlobalHistoricalQuoteV3", ignore_extras);
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
    public static StockGlobalHistoricalQuoteV3JSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockGlobalHistoricalQuoteV3JSON from_text(string text, bool ignore_extras)
      {
        StockGlobalHistoricalQuoteV3JSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockGlobalHistoricalQuoteV3", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockGlobalHistoricalQuoteV3JSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockGlobalHistoricalQuoteV3JSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockGlobalHistoricalQuoteV3JSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockGlobalHistoricalQuoteV3", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorDate;
    private abstract class FieldGeneratorOpen : JSONParallelGenerator
          {
            private JSONHoldingNumberTextGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeOpen result = new TypeOpen();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = Double.Parse(field0.value);
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeOpen result);
            public FieldGeneratorOpen(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"Open\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Open\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorOpen(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"Open\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Open\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderOpen
          {
            private bool have_data;
            private TypeOpen data;
            public HolderOpen()  { have_data = false; }
            public HolderOpen(TypeOpen init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderOpen(HolderOpen other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeOpen referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorOpen : FieldGeneratorOpen
          {
            protected override void handle_result(TypeOpen result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderOpen(result);
              }

            public FieldHoldingGeneratorOpen(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderOpen value;
          };
    private class FieldHoldingArrayGeneratorOpen : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorOpen
      {
        private FieldHoldingArrayGeneratorOpen top;

        protected override void handle_result(TypeOpen result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorOpen init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeOpen> result)
      {
      }

    public FieldHoldingArrayGeneratorOpen(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeOpen>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorOpen(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeOpen>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeOpen> value;
  };
        private FieldHoldingGeneratorOpen fieldGeneratorOpen;
    private abstract class FieldGeneratorClose : JSONParallelGenerator
          {
            private JSONHoldingNumberTextGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeClose result = new TypeClose();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = Double.Parse(field0.value);
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeClose result);
            public FieldGeneratorClose(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"Close\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Close\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorClose(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"Close\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Close\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderClose
          {
            private bool have_data;
            private TypeClose data;
            public HolderClose()  { have_data = false; }
            public HolderClose(TypeClose init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderClose(HolderClose other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeClose referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorClose : FieldGeneratorClose
          {
            protected override void handle_result(TypeClose result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderClose(result);
              }

            public FieldHoldingGeneratorClose(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderClose value;
          };
    private class FieldHoldingArrayGeneratorClose : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorClose
      {
        private FieldHoldingArrayGeneratorClose top;

        protected override void handle_result(TypeClose result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorClose init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeClose> result)
      {
      }

    public FieldHoldingArrayGeneratorClose(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeClose>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorClose(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeClose>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeClose> value;
  };
        private FieldHoldingGeneratorClose fieldGeneratorClose;
    private abstract class FieldGeneratorHigh : JSONParallelGenerator
          {
            private JSONHoldingNumberTextGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeHigh result = new TypeHigh();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = Double.Parse(field0.value);
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeHigh result);
            public FieldGeneratorHigh(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"High\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"High\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorHigh(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"High\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"High\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderHigh
          {
            private bool have_data;
            private TypeHigh data;
            public HolderHigh()  { have_data = false; }
            public HolderHigh(TypeHigh init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderHigh(HolderHigh other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeHigh referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorHigh : FieldGeneratorHigh
          {
            protected override void handle_result(TypeHigh result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderHigh(result);
              }

            public FieldHoldingGeneratorHigh(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderHigh value;
          };
    private class FieldHoldingArrayGeneratorHigh : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorHigh
      {
        private FieldHoldingArrayGeneratorHigh top;

        protected override void handle_result(TypeHigh result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorHigh init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeHigh> result)
      {
      }

    public FieldHoldingArrayGeneratorHigh(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeHigh>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorHigh(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeHigh>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeHigh> value;
  };
        private FieldHoldingGeneratorHigh fieldGeneratorHigh;
    private abstract class FieldGeneratorLow : JSONParallelGenerator
          {
            private JSONHoldingNumberTextGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeLow result = new TypeLow();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = Double.Parse(field0.value);
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeLow result);
            public FieldGeneratorLow(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"Low\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Low\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorLow(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"Low\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Low\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderLow
          {
            private bool have_data;
            private TypeLow data;
            public HolderLow()  { have_data = false; }
            public HolderLow(TypeLow init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderLow(HolderLow other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeLow referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorLow : FieldGeneratorLow
          {
            protected override void handle_result(TypeLow result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderLow(result);
              }

            public FieldHoldingGeneratorLow(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderLow value;
          };
    private class FieldHoldingArrayGeneratorLow : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLow
      {
        private FieldHoldingArrayGeneratorLow top;

        protected override void handle_result(TypeLow result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLow init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeLow> result)
      {
      }

    public FieldHoldingArrayGeneratorLow(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeLow>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLow(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeLow>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLow> value;
  };
        private FieldHoldingGeneratorLow fieldGeneratorLow;
    private abstract class FieldGeneratorLast : JSONParallelGenerator
          {
            private JSONHoldingNumberTextGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeLast result = new TypeLast();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = Double.Parse(field0.value);
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeLast result);
            public FieldGeneratorLast(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"Last\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Last\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorLast(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"Last\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Last\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderLast
          {
            private bool have_data;
            private TypeLast data;
            public HolderLast()  { have_data = false; }
            public HolderLast(TypeLast init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderLast(HolderLast other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeLast referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorLast : FieldGeneratorLast
          {
            protected override void handle_result(TypeLast result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderLast(result);
              }

            public FieldHoldingGeneratorLast(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderLast value;
          };
    private class FieldHoldingArrayGeneratorLast : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLast
      {
        private FieldHoldingArrayGeneratorLast top;

        protected override void handle_result(TypeLast result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLast init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeLast> result)
      {
      }

    public FieldHoldingArrayGeneratorLast(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeLast>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLast(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeLast>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLast> value;
  };
        private FieldHoldingGeneratorLast fieldGeneratorLast;
    private abstract class FieldGeneratorVolume : JSONParallelGenerator
          {
            private JSONHoldingNumberTextGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeVolume result = new TypeVolume();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = Double.Parse(field0.value);
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeVolume result);
            public FieldGeneratorVolume(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"Volume\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Volume\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorVolume(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"Volume\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Volume\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderVolume
          {
            private bool have_data;
            private TypeVolume data;
            public HolderVolume()  { have_data = false; }
            public HolderVolume(TypeVolume init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderVolume(HolderVolume other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeVolume referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorVolume : FieldGeneratorVolume
          {
            protected override void handle_result(TypeVolume result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderVolume(result);
              }

            public FieldHoldingGeneratorVolume(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderVolume value;
          };
    private class FieldHoldingArrayGeneratorVolume : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorVolume
      {
        private FieldHoldingArrayGeneratorVolume top;

        protected override void handle_result(TypeVolume result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorVolume init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeVolume> result)
      {
      }

    public FieldHoldingArrayGeneratorVolume(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeVolume>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorVolume(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeVolume>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeVolume> value;
  };
        private FieldHoldingGeneratorVolume fieldGeneratorVolume;
    private abstract class FieldGeneratorCumulativeAdjustmentFactor : JSONParallelGenerator
          {
            private JSONHoldingNumberTextGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeCumulativeAdjustmentFactor result = new TypeCumulativeAdjustmentFactor();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = Double.Parse(field0.value);
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeCumulativeAdjustmentFactor result);
            public FieldGeneratorCumulativeAdjustmentFactor(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"CumulativeAdjustmentFactor\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"CumulativeAdjustmentFactor\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorCumulativeAdjustmentFactor(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"CumulativeAdjustmentFactor\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"CumulativeAdjustmentFactor\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderCumulativeAdjustmentFactor
          {
            private bool have_data;
            private TypeCumulativeAdjustmentFactor data;
            public HolderCumulativeAdjustmentFactor()  { have_data = false; }
            public HolderCumulativeAdjustmentFactor(TypeCumulativeAdjustmentFactor init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderCumulativeAdjustmentFactor(HolderCumulativeAdjustmentFactor other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeCumulativeAdjustmentFactor referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorCumulativeAdjustmentFactor : FieldGeneratorCumulativeAdjustmentFactor
          {
            protected override void handle_result(TypeCumulativeAdjustmentFactor result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderCumulativeAdjustmentFactor(result);
              }

            public FieldHoldingGeneratorCumulativeAdjustmentFactor(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderCumulativeAdjustmentFactor value;
          };
    private class FieldHoldingArrayGeneratorCumulativeAdjustmentFactor : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCumulativeAdjustmentFactor
      {
        private FieldHoldingArrayGeneratorCumulativeAdjustmentFactor top;

        protected override void handle_result(TypeCumulativeAdjustmentFactor result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCumulativeAdjustmentFactor init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeCumulativeAdjustmentFactor> result)
      {
      }

    public FieldHoldingArrayGeneratorCumulativeAdjustmentFactor(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeCumulativeAdjustmentFactor>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCumulativeAdjustmentFactor(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeCumulativeAdjustmentFactor>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCumulativeAdjustmentFactor> value;
  };
        private FieldHoldingGeneratorCumulativeAdjustmentFactor fieldGeneratorCumulativeAdjustmentFactor;
    private abstract class FieldGeneratorCurrency : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeCurrency result = new TypeCurrency();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeCurrency result);
            public FieldGeneratorCurrency(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Currency\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Currency\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorCurrency(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Currency\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Currency\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderCurrency
          {
            private bool have_data;
            private TypeCurrency data;
            public HolderCurrency()  { have_data = false; }
            public HolderCurrency(TypeCurrency init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderCurrency(HolderCurrency other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeCurrency referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorCurrency : FieldGeneratorCurrency
          {
            protected override void handle_result(TypeCurrency result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderCurrency(result);
              }

            public FieldHoldingGeneratorCurrency(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderCurrency value;
          };
    private class FieldHoldingArrayGeneratorCurrency : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCurrency
      {
        private FieldHoldingArrayGeneratorCurrency top;

        protected override void handle_result(TypeCurrency result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCurrency init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeCurrency> result)
      {
      }

    public FieldHoldingArrayGeneratorCurrency(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeCurrency>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCurrency(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeCurrency>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCurrency> value;
  };
        private FieldHoldingGeneratorCurrency fieldGeneratorCurrency;
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
            StockGlobalHistoricalQuoteV3JSON result = new StockGlobalHistoricalQuoteV3JSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockGlobalHistoricalQuoteV3AppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockGlobalHistoricalQuoteV3JSON result)
          {
            if (fieldGeneratorDate.have_value)
              {
                result.setDate(fieldGeneratorDate.value);
                fieldGeneratorDate.have_value = false;
              }
            else if ((!(result.hasDate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Date\" field was missing.");
              }
            if (fieldGeneratorOpen.have_value)
              {
                result.setOpen(fieldGeneratorOpen.value.referenced());
                fieldGeneratorOpen.have_value = false;
              }
            if (fieldGeneratorClose.have_value)
              {
                result.setClose(fieldGeneratorClose.value.referenced());
                fieldGeneratorClose.have_value = false;
              }
            if (fieldGeneratorHigh.have_value)
              {
                result.setHigh(fieldGeneratorHigh.value.referenced());
                fieldGeneratorHigh.have_value = false;
              }
            if (fieldGeneratorLow.have_value)
              {
                result.setLow(fieldGeneratorLow.value.referenced());
                fieldGeneratorLow.have_value = false;
              }
            if (fieldGeneratorLast.have_value)
              {
                result.setLast(fieldGeneratorLast.value.referenced());
                fieldGeneratorLast.have_value = false;
              }
            if (fieldGeneratorVolume.have_value)
              {
                result.setVolume(fieldGeneratorVolume.value.referenced());
                fieldGeneratorVolume.have_value = false;
              }
            if (fieldGeneratorCumulativeAdjustmentFactor.have_value)
              {
                result.setCumulativeAdjustmentFactor(fieldGeneratorCumulativeAdjustmentFactor.value.referenced());
                fieldGeneratorCumulativeAdjustmentFactor.have_value = false;
              }
            if (fieldGeneratorCurrency.have_value)
              {
                result.setCurrency(fieldGeneratorCurrency.value.referenced());
                fieldGeneratorCurrency.have_value = false;
              }
          }
        protected abstract void handle_result(StockGlobalHistoricalQuoteV3JSON new_result);
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
                            switch (field_name[2])
                              {
                                case 'm':
                                    if ((String.Compare(field_name, 3, "ulativeAdjustmentFactor", 0, 23, false) == 0) && (field_name.Length == 26))
                                        return fieldGeneratorCumulativeAdjustmentFactor;
                                    break;
                                case 'r':
                                    if ((String.Compare(field_name, 3, "rency", 0, 5, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorCurrency;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ate", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorDate;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "igh", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorHigh;
                    break;
                case 'L':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "st", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorLast;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "w", 0, 1, false) == 0) && (field_name.Length == 3))
                                return fieldGeneratorLow;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "pen", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorOpen;
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
            fieldGeneratorDate = new JSONHoldingStringGenerator("field \"Date\" of the StockGlobalHistoricalQuoteV3 class");
            fieldGeneratorOpen = new FieldHoldingGeneratorOpen("field \"Open\" of the StockGlobalHistoricalQuoteV3 class", ignore_extras);
            fieldGeneratorClose = new FieldHoldingGeneratorClose("field \"Close\" of the StockGlobalHistoricalQuoteV3 class", ignore_extras);
            fieldGeneratorHigh = new FieldHoldingGeneratorHigh("field \"High\" of the StockGlobalHistoricalQuoteV3 class", ignore_extras);
            fieldGeneratorLow = new FieldHoldingGeneratorLow("field \"Low\" of the StockGlobalHistoricalQuoteV3 class", ignore_extras);
            fieldGeneratorLast = new FieldHoldingGeneratorLast("field \"Last\" of the StockGlobalHistoricalQuoteV3 class", ignore_extras);
            fieldGeneratorVolume = new FieldHoldingGeneratorVolume("field \"Volume\" of the StockGlobalHistoricalQuoteV3 class", ignore_extras);
            fieldGeneratorCumulativeAdjustmentFactor = new FieldHoldingGeneratorCumulativeAdjustmentFactor("field \"CumulativeAdjustmentFactor\" of the StockGlobalHistoricalQuoteV3 class", ignore_extras);
            fieldGeneratorCurrency = new FieldHoldingGeneratorCurrency("field \"Currency\" of the StockGlobalHistoricalQuoteV3 class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockGlobalHistoricalQuoteV3 class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDate = new JSONHoldingStringGenerator("field \"Date\" of the StockGlobalHistoricalQuoteV3 class");
            fieldGeneratorOpen = new FieldHoldingGeneratorOpen("field \"Open\" of the StockGlobalHistoricalQuoteV3 class", false);
            fieldGeneratorClose = new FieldHoldingGeneratorClose("field \"Close\" of the StockGlobalHistoricalQuoteV3 class", false);
            fieldGeneratorHigh = new FieldHoldingGeneratorHigh("field \"High\" of the StockGlobalHistoricalQuoteV3 class", false);
            fieldGeneratorLow = new FieldHoldingGeneratorLow("field \"Low\" of the StockGlobalHistoricalQuoteV3 class", false);
            fieldGeneratorLast = new FieldHoldingGeneratorLast("field \"Last\" of the StockGlobalHistoricalQuoteV3 class", false);
            fieldGeneratorVolume = new FieldHoldingGeneratorVolume("field \"Volume\" of the StockGlobalHistoricalQuoteV3 class", false);
            fieldGeneratorCumulativeAdjustmentFactor = new FieldHoldingGeneratorCumulativeAdjustmentFactor("field \"CumulativeAdjustmentFactor\" of the StockGlobalHistoricalQuoteV3 class", false);
            fieldGeneratorCurrency = new FieldHoldingGeneratorCurrency("field \"Currency\" of the StockGlobalHistoricalQuoteV3 class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockGlobalHistoricalQuoteV3 class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDate.reset();
            fieldGeneratorOpen.reset();
            fieldGeneratorClose.reset();
            fieldGeneratorHigh.reset();
            fieldGeneratorLow.reset();
            fieldGeneratorLast.reset();
            fieldGeneratorVolume.reset();
            fieldGeneratorCumulativeAdjustmentFactor.reset();
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
        protected override void handle_result(StockGlobalHistoricalQuoteV3JSON  result)
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
        public StockGlobalHistoricalQuoteV3JSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockGlobalHistoricalQuoteV3JSON  result)
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
    protected virtual void handle_result(List<StockGlobalHistoricalQuoteV3JSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockGlobalHistoricalQuoteV3JSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockGlobalHistoricalQuoteV3JSON>();
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
    public List<StockGlobalHistoricalQuoteV3JSON> value;
  };
  };
