/* file "StockGlobalIndicesHistoricalQuoteJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StockGlobalIndicesHistoricalQuoteJSON : JSONBase
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
    public struct TypePreviousClose
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
    public struct TypePreviousCloseDate
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    public struct TypeChangeFromPreviousClose
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
    public struct TypePercentChangeFromPreviousClose
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
    private bool flagHasDate;
    private string storeDate;
    private bool flagHasUTCOffset;
    private double storeUTCOffset;
    private string textStoreUTCOffset;
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
    private bool flagHasPreviousClose;
    private TypePreviousClose storePreviousClose;
    private bool flagHasPreviousCloseDate;
    private TypePreviousCloseDate storePreviousCloseDate;
    private bool flagHasChangeFromPreviousClose;
    private TypeChangeFromPreviousClose storeChangeFromPreviousClose;
    private bool flagHasPercentChangeFromPreviousClose;
    private TypePercentChangeFromPreviousClose storePercentChangeFromPreviousClose;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Date of StockGlobalIndicesHistoricalQuoteJSON is not a string.");
        setDate(json_string.getData());
      }


    private void  fromJSONUTCOffset(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UTCOffset of StockGlobalIndicesHistoricalQuoteJSON is not a number.");
              }
          }
        setUTCOffsetText(the_rational_text);
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
            throw new Exception("The value for field Open of StockGlobalIndicesHistoricalQuoteJSON is not one of the allowed values.");
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
            throw new Exception("The value for field Close of StockGlobalIndicesHistoricalQuoteJSON is not one of the allowed values.");
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
            throw new Exception("The value for field High of StockGlobalIndicesHistoricalQuoteJSON is not one of the allowed values.");
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
            throw new Exception("The value for field Low of StockGlobalIndicesHistoricalQuoteJSON is not one of the allowed values.");
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
            throw new Exception("The value for field Last of StockGlobalIndicesHistoricalQuoteJSON is not one of the allowed values.");
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


    private void  fromJSONPreviousClose(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePreviousClose or_result = new TypePreviousClose();
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
            throw new Exception("The value for field PreviousClose of StockGlobalIndicesHistoricalQuoteJSON is not one of the allowed values.");
        setPreviousClose(or_result);
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


    private void  fromJSONPreviousCloseDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePreviousCloseDate or_result = new TypePreviousCloseDate();
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
            throw new Exception("The value for field PreviousCloseDate of StockGlobalIndicesHistoricalQuoteJSON is not one of the allowed values.");
        setPreviousCloseDate(or_result);
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


    private void  fromJSONChangeFromPreviousClose(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeChangeFromPreviousClose or_result = new TypeChangeFromPreviousClose();
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
            throw new Exception("The value for field ChangeFromPreviousClose of StockGlobalIndicesHistoricalQuoteJSON is not one of the allowed values.");
        setChangeFromPreviousClose(or_result);
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


    private void  fromJSONPercentChangeFromPreviousClose(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePercentChangeFromPreviousClose or_result = new TypePercentChangeFromPreviousClose();
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
            throw new Exception("The value for field PercentChangeFromPreviousClose of StockGlobalIndicesHistoricalQuoteJSON is not one of the allowed values.");
        setPercentChangeFromPreviousClose(or_result);
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


    public StockGlobalIndicesHistoricalQuoteJSON()
      {
        flagHasDate = false;
        flagHasUTCOffset = false;
        flagHasOpen = false;
        flagHasClose = false;
        flagHasHigh = false;
        flagHasLow = false;
        flagHasLast = false;
        flagHasPreviousClose = false;
        flagHasPreviousCloseDate = false;
        flagHasChangeFromPreviousClose = false;
        flagHasPercentChangeFromPreviousClose = false;
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

    public bool  hasUTCOffset()
      {
        return flagHasUTCOffset;
      }

    public double  getUTCOffset()
      {
        Debug.Assert(flagHasUTCOffset);
        if (textStoreUTCOffset != "")
          {
            return Double.Parse(textStoreUTCOffset);
          }
        return storeUTCOffset;
      }

    public string  getUTCOffsetAsText()
      {
        Debug.Assert(flagHasUTCOffset);
        if (textStoreUTCOffset == "")
          {
            return Convert.ToString(storeUTCOffset);
          }
        else
          {
            return (textStoreUTCOffset);
          }
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

    public bool  hasPreviousClose()
      {
        return flagHasPreviousClose;
      }

    public TypePreviousClose  getPreviousClose()
      {
        Debug.Assert(flagHasPreviousClose);
        return storePreviousClose;
      }

    public bool  hasPreviousCloseDate()
      {
        return flagHasPreviousCloseDate;
      }

    public TypePreviousCloseDate  getPreviousCloseDate()
      {
        Debug.Assert(flagHasPreviousCloseDate);
        return storePreviousCloseDate;
      }

    public bool  hasChangeFromPreviousClose()
      {
        return flagHasChangeFromPreviousClose;
      }

    public TypeChangeFromPreviousClose  getChangeFromPreviousClose()
      {
        Debug.Assert(flagHasChangeFromPreviousClose);
        return storeChangeFromPreviousClose;
      }

    public bool  hasPercentChangeFromPreviousClose()
      {
        return flagHasPercentChangeFromPreviousClose;
      }

    public TypePercentChangeFromPreviousClose  getPercentChangeFromPreviousClose()
      {
        Debug.Assert(flagHasPercentChangeFromPreviousClose);
        return storePercentChangeFromPreviousClose;
      }


    public virtual int extraStockGlobalIndicesHistoricalQuoteComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockGlobalIndicesHistoricalQuoteComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockGlobalIndicesHistoricalQuoteComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockGlobalIndicesHistoricalQuoteLookup(string field_name)
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
    public void setUTCOffset(double new_value)
      {
        flagHasUTCOffset = true;
        storeUTCOffset = new_value;
        textStoreUTCOffset = "";
      }
    public void setUTCOffsetText(string new_value)
      {
        flagHasUTCOffset = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field UTCOffset of StockGlobalIndicesHistoricalQuoteJSON is not a valid number.");
        textStoreUTCOffset = new_value;
      }
    public void unsetUTCOffset()
      {
        flagHasUTCOffset = false;
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
    public void setPreviousClose(TypePreviousClose new_value)
      {
        flagHasPreviousClose = true;
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
        storePreviousClose = new_value;
      }
    public void unsetPreviousClose()
      {
        flagHasPreviousClose = false;
      }
    public void setPreviousCloseDate(TypePreviousCloseDate new_value)
      {
        flagHasPreviousCloseDate = true;
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
        storePreviousCloseDate = new_value;
      }
    public void unsetPreviousCloseDate()
      {
        flagHasPreviousCloseDate = false;
      }
    public void setChangeFromPreviousClose(TypeChangeFromPreviousClose new_value)
      {
        flagHasChangeFromPreviousClose = true;
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
        storeChangeFromPreviousClose = new_value;
      }
    public void unsetChangeFromPreviousClose()
      {
        flagHasChangeFromPreviousClose = false;
      }
    public void setPercentChangeFromPreviousClose(TypePercentChangeFromPreviousClose new_value)
      {
        flagHasPercentChangeFromPreviousClose = true;
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
        storePercentChangeFromPreviousClose = new_value;
      }
    public void unsetPercentChangeFromPreviousClose()
      {
        flagHasPercentChangeFromPreviousClose = false;
      }

    public virtual void extraStockGlobalIndicesHistoricalQuoteAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockGlobalIndicesHistoricalQuoteSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockGlobalIndicesHistoricalQuoteLookup(key);
        if (old_field == null)
          {
            extraStockGlobalIndicesHistoricalQuoteAppendPair(key, new_component);
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
        if (flagHasUTCOffset)
          {
            handler.start_pair("UTCOffset");
            if (textStoreUTCOffset != "")
                handler.number_value(textStoreUTCOffset);
            else if (((double)(long)storeUTCOffset) == storeUTCOffset)
                handler.number_value((long)storeUTCOffset);
            else
                handler.number_value(storeUTCOffset);
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
        if (flagHasPreviousClose)
          {
            handler.start_pair("PreviousClose");
            switch (storePreviousClose.key)
              {
                case 0:
                    if (((double)(long)storePreviousClose.u.choice0) == storePreviousClose.u.choice0)
                        handler.number_value((long)storePreviousClose.u.choice0);
                    else
                        handler.number_value(storePreviousClose.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasPreviousCloseDate)
          {
            handler.start_pair("PreviousCloseDate");
            switch (storePreviousCloseDate.key)
              {
                case 0:
                    handler.string_value(storePreviousCloseDate.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasChangeFromPreviousClose)
          {
            handler.start_pair("ChangeFromPreviousClose");
            switch (storeChangeFromPreviousClose.key)
              {
                case 0:
                    if (((double)(long)storeChangeFromPreviousClose.u.choice0) == storeChangeFromPreviousClose.u.choice0)
                        handler.number_value((long)storeChangeFromPreviousClose.u.choice0);
                    else
                        handler.number_value(storeChangeFromPreviousClose.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasPercentChangeFromPreviousClose)
          {
            handler.start_pair("PercentChangeFromPreviousClose");
            switch (storePercentChangeFromPreviousClose.key)
              {
                case 0:
                    if (((double)(long)storePercentChangeFromPreviousClose.u.choice0) == storePercentChangeFromPreviousClose.u.choice0)
                        handler.number_value((long)storePercentChangeFromPreviousClose.u.choice0);
                    else
                        handler.number_value(storePercentChangeFromPreviousClose.u.choice0);
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

    public static StockGlobalIndicesHistoricalQuoteJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockGlobalIndicesHistoricalQuoteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockGlobalIndicesHistoricalQuote", ignore_extras);
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
    public static StockGlobalIndicesHistoricalQuoteJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockGlobalIndicesHistoricalQuoteJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockGlobalIndicesHistoricalQuoteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockGlobalIndicesHistoricalQuote", ignore_extras);
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
    public static StockGlobalIndicesHistoricalQuoteJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockGlobalIndicesHistoricalQuoteJSON from_text(string text, bool ignore_extras)
      {
        StockGlobalIndicesHistoricalQuoteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockGlobalIndicesHistoricalQuote", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockGlobalIndicesHistoricalQuoteJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockGlobalIndicesHistoricalQuoteJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockGlobalIndicesHistoricalQuoteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockGlobalIndicesHistoricalQuote", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorDate;
        private JSONHoldingNumberTextGenerator fieldGeneratorUTCOffset;
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
    private abstract class FieldGeneratorPreviousClose : JSONParallelGenerator
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
                TypePreviousClose result = new TypePreviousClose();
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
            protected abstract void handle_result(TypePreviousClose result);
            public FieldGeneratorPreviousClose(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"PreviousClose\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"PreviousClose\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorPreviousClose(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"PreviousClose\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"PreviousClose\"");
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
        private class HolderPreviousClose
          {
            private bool have_data;
            private TypePreviousClose data;
            public HolderPreviousClose()  { have_data = false; }
            public HolderPreviousClose(TypePreviousClose init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderPreviousClose(HolderPreviousClose other)
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
            public TypePreviousClose referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorPreviousClose : FieldGeneratorPreviousClose
          {
            protected override void handle_result(TypePreviousClose result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderPreviousClose(result);
              }

            public FieldHoldingGeneratorPreviousClose(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderPreviousClose value;
          };
    private class FieldHoldingArrayGeneratorPreviousClose : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorPreviousClose
      {
        private FieldHoldingArrayGeneratorPreviousClose top;

        protected override void handle_result(TypePreviousClose result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPreviousClose init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypePreviousClose> result)
      {
      }

    public FieldHoldingArrayGeneratorPreviousClose(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypePreviousClose>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPreviousClose(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypePreviousClose>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypePreviousClose> value;
  };
        private FieldHoldingGeneratorPreviousClose fieldGeneratorPreviousClose;
    private abstract class FieldGeneratorPreviousCloseDate : JSONParallelGenerator
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
                TypePreviousCloseDate result = new TypePreviousCloseDate();
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
            protected abstract void handle_result(TypePreviousCloseDate result);
            public FieldGeneratorPreviousCloseDate(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"PreviousCloseDate\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"PreviousCloseDate\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorPreviousCloseDate(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"PreviousCloseDate\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"PreviousCloseDate\"");
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
        private class HolderPreviousCloseDate
          {
            private bool have_data;
            private TypePreviousCloseDate data;
            public HolderPreviousCloseDate()  { have_data = false; }
            public HolderPreviousCloseDate(TypePreviousCloseDate init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderPreviousCloseDate(HolderPreviousCloseDate other)
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
            public TypePreviousCloseDate referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorPreviousCloseDate : FieldGeneratorPreviousCloseDate
          {
            protected override void handle_result(TypePreviousCloseDate result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderPreviousCloseDate(result);
              }

            public FieldHoldingGeneratorPreviousCloseDate(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderPreviousCloseDate value;
          };
    private class FieldHoldingArrayGeneratorPreviousCloseDate : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorPreviousCloseDate
      {
        private FieldHoldingArrayGeneratorPreviousCloseDate top;

        protected override void handle_result(TypePreviousCloseDate result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPreviousCloseDate init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypePreviousCloseDate> result)
      {
      }

    public FieldHoldingArrayGeneratorPreviousCloseDate(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypePreviousCloseDate>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPreviousCloseDate(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypePreviousCloseDate>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypePreviousCloseDate> value;
  };
        private FieldHoldingGeneratorPreviousCloseDate fieldGeneratorPreviousCloseDate;
    private abstract class FieldGeneratorChangeFromPreviousClose : JSONParallelGenerator
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
                TypeChangeFromPreviousClose result = new TypeChangeFromPreviousClose();
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
            protected abstract void handle_result(TypeChangeFromPreviousClose result);
            public FieldGeneratorChangeFromPreviousClose(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"ChangeFromPreviousClose\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"ChangeFromPreviousClose\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorChangeFromPreviousClose(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"ChangeFromPreviousClose\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"ChangeFromPreviousClose\"");
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
        private class HolderChangeFromPreviousClose
          {
            private bool have_data;
            private TypeChangeFromPreviousClose data;
            public HolderChangeFromPreviousClose()  { have_data = false; }
            public HolderChangeFromPreviousClose(TypeChangeFromPreviousClose init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderChangeFromPreviousClose(HolderChangeFromPreviousClose other)
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
            public TypeChangeFromPreviousClose referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorChangeFromPreviousClose : FieldGeneratorChangeFromPreviousClose
          {
            protected override void handle_result(TypeChangeFromPreviousClose result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderChangeFromPreviousClose(result);
              }

            public FieldHoldingGeneratorChangeFromPreviousClose(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderChangeFromPreviousClose value;
          };
    private class FieldHoldingArrayGeneratorChangeFromPreviousClose : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorChangeFromPreviousClose
      {
        private FieldHoldingArrayGeneratorChangeFromPreviousClose top;

        protected override void handle_result(TypeChangeFromPreviousClose result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorChangeFromPreviousClose init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeChangeFromPreviousClose> result)
      {
      }

    public FieldHoldingArrayGeneratorChangeFromPreviousClose(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeChangeFromPreviousClose>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorChangeFromPreviousClose(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeChangeFromPreviousClose>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeChangeFromPreviousClose> value;
  };
        private FieldHoldingGeneratorChangeFromPreviousClose fieldGeneratorChangeFromPreviousClose;
    private abstract class FieldGeneratorPercentChangeFromPreviousClose : JSONParallelGenerator
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
                TypePercentChangeFromPreviousClose result = new TypePercentChangeFromPreviousClose();
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
            protected abstract void handle_result(TypePercentChangeFromPreviousClose result);
            public FieldGeneratorPercentChangeFromPreviousClose(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"PercentChangeFromPreviousClose\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"PercentChangeFromPreviousClose\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorPercentChangeFromPreviousClose(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"PercentChangeFromPreviousClose\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"PercentChangeFromPreviousClose\"");
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
        private class HolderPercentChangeFromPreviousClose
          {
            private bool have_data;
            private TypePercentChangeFromPreviousClose data;
            public HolderPercentChangeFromPreviousClose()  { have_data = false; }
            public HolderPercentChangeFromPreviousClose(TypePercentChangeFromPreviousClose init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderPercentChangeFromPreviousClose(HolderPercentChangeFromPreviousClose other)
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
            public TypePercentChangeFromPreviousClose referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorPercentChangeFromPreviousClose : FieldGeneratorPercentChangeFromPreviousClose
          {
            protected override void handle_result(TypePercentChangeFromPreviousClose result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderPercentChangeFromPreviousClose(result);
              }

            public FieldHoldingGeneratorPercentChangeFromPreviousClose(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderPercentChangeFromPreviousClose value;
          };
    private class FieldHoldingArrayGeneratorPercentChangeFromPreviousClose : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorPercentChangeFromPreviousClose
      {
        private FieldHoldingArrayGeneratorPercentChangeFromPreviousClose top;

        protected override void handle_result(TypePercentChangeFromPreviousClose result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPercentChangeFromPreviousClose init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypePercentChangeFromPreviousClose> result)
      {
      }

    public FieldHoldingArrayGeneratorPercentChangeFromPreviousClose(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypePercentChangeFromPreviousClose>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPercentChangeFromPreviousClose(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypePercentChangeFromPreviousClose>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypePercentChangeFromPreviousClose> value;
  };
        private FieldHoldingGeneratorPercentChangeFromPreviousClose fieldGeneratorPercentChangeFromPreviousClose;
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
            StockGlobalIndicesHistoricalQuoteJSON result = new StockGlobalIndicesHistoricalQuoteJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockGlobalIndicesHistoricalQuoteAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockGlobalIndicesHistoricalQuoteJSON result)
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
            if (fieldGeneratorUTCOffset.have_value)
              {
                result.setUTCOffsetText(fieldGeneratorUTCOffset.value);
                fieldGeneratorUTCOffset.have_value = false;
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
            if (fieldGeneratorPreviousClose.have_value)
              {
                result.setPreviousClose(fieldGeneratorPreviousClose.value.referenced());
                fieldGeneratorPreviousClose.have_value = false;
              }
            if (fieldGeneratorPreviousCloseDate.have_value)
              {
                result.setPreviousCloseDate(fieldGeneratorPreviousCloseDate.value.referenced());
                fieldGeneratorPreviousCloseDate.have_value = false;
              }
            if (fieldGeneratorChangeFromPreviousClose.have_value)
              {
                result.setChangeFromPreviousClose(fieldGeneratorChangeFromPreviousClose.value.referenced());
                fieldGeneratorChangeFromPreviousClose.have_value = false;
              }
            if (fieldGeneratorPercentChangeFromPreviousClose.have_value)
              {
                result.setPercentChangeFromPreviousClose(fieldGeneratorPercentChangeFromPreviousClose.value.referenced());
                fieldGeneratorPercentChangeFromPreviousClose.have_value = false;
              }
          }
        protected abstract void handle_result(StockGlobalIndicesHistoricalQuoteJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "angeFromPreviousClose", 0, 21, false) == 0) && (field_name.Length == 23))
                                return fieldGeneratorChangeFromPreviousClose;
                            break;
                        case 'l':
                            if ((String.Compare(field_name, 2, "ose", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorClose;
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
                case 'P':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "rcentChangeFromPreviousClose", 0, 28, false) == 0) && (field_name.Length == 30))
                                return fieldGeneratorPercentChangeFromPreviousClose;
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "eviousClose", 0, 11, false) == 0)
                              {
                                if (field_name.Length == 13)
                                  {
                                    return fieldGeneratorPreviousClose;
                                  }
                                switch (field_name[13])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 14, "ate", 0, 3, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorPreviousCloseDate;
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
                    if ((String.Compare(field_name, 1, "TCOffset", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorUTCOffset;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDate = new JSONHoldingStringGenerator("field \"Date\" of the StockGlobalIndicesHistoricalQuote class");
            fieldGeneratorUTCOffset = new JSONHoldingNumberTextGenerator("field \"UTCOffset\" of the StockGlobalIndicesHistoricalQuote class");
            fieldGeneratorOpen = new FieldHoldingGeneratorOpen("field \"Open\" of the StockGlobalIndicesHistoricalQuote class", ignore_extras);
            fieldGeneratorClose = new FieldHoldingGeneratorClose("field \"Close\" of the StockGlobalIndicesHistoricalQuote class", ignore_extras);
            fieldGeneratorHigh = new FieldHoldingGeneratorHigh("field \"High\" of the StockGlobalIndicesHistoricalQuote class", ignore_extras);
            fieldGeneratorLow = new FieldHoldingGeneratorLow("field \"Low\" of the StockGlobalIndicesHistoricalQuote class", ignore_extras);
            fieldGeneratorLast = new FieldHoldingGeneratorLast("field \"Last\" of the StockGlobalIndicesHistoricalQuote class", ignore_extras);
            fieldGeneratorPreviousClose = new FieldHoldingGeneratorPreviousClose("field \"PreviousClose\" of the StockGlobalIndicesHistoricalQuote class", ignore_extras);
            fieldGeneratorPreviousCloseDate = new FieldHoldingGeneratorPreviousCloseDate("field \"PreviousCloseDate\" of the StockGlobalIndicesHistoricalQuote class", ignore_extras);
            fieldGeneratorChangeFromPreviousClose = new FieldHoldingGeneratorChangeFromPreviousClose("field \"ChangeFromPreviousClose\" of the StockGlobalIndicesHistoricalQuote class", ignore_extras);
            fieldGeneratorPercentChangeFromPreviousClose = new FieldHoldingGeneratorPercentChangeFromPreviousClose("field \"PercentChangeFromPreviousClose\" of the StockGlobalIndicesHistoricalQuote class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockGlobalIndicesHistoricalQuote class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDate = new JSONHoldingStringGenerator("field \"Date\" of the StockGlobalIndicesHistoricalQuote class");
            fieldGeneratorUTCOffset = new JSONHoldingNumberTextGenerator("field \"UTCOffset\" of the StockGlobalIndicesHistoricalQuote class");
            fieldGeneratorOpen = new FieldHoldingGeneratorOpen("field \"Open\" of the StockGlobalIndicesHistoricalQuote class", false);
            fieldGeneratorClose = new FieldHoldingGeneratorClose("field \"Close\" of the StockGlobalIndicesHistoricalQuote class", false);
            fieldGeneratorHigh = new FieldHoldingGeneratorHigh("field \"High\" of the StockGlobalIndicesHistoricalQuote class", false);
            fieldGeneratorLow = new FieldHoldingGeneratorLow("field \"Low\" of the StockGlobalIndicesHistoricalQuote class", false);
            fieldGeneratorLast = new FieldHoldingGeneratorLast("field \"Last\" of the StockGlobalIndicesHistoricalQuote class", false);
            fieldGeneratorPreviousClose = new FieldHoldingGeneratorPreviousClose("field \"PreviousClose\" of the StockGlobalIndicesHistoricalQuote class", false);
            fieldGeneratorPreviousCloseDate = new FieldHoldingGeneratorPreviousCloseDate("field \"PreviousCloseDate\" of the StockGlobalIndicesHistoricalQuote class", false);
            fieldGeneratorChangeFromPreviousClose = new FieldHoldingGeneratorChangeFromPreviousClose("field \"ChangeFromPreviousClose\" of the StockGlobalIndicesHistoricalQuote class", false);
            fieldGeneratorPercentChangeFromPreviousClose = new FieldHoldingGeneratorPercentChangeFromPreviousClose("field \"PercentChangeFromPreviousClose\" of the StockGlobalIndicesHistoricalQuote class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockGlobalIndicesHistoricalQuote class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDate.reset();
            fieldGeneratorUTCOffset.reset();
            fieldGeneratorOpen.reset();
            fieldGeneratorClose.reset();
            fieldGeneratorHigh.reset();
            fieldGeneratorLow.reset();
            fieldGeneratorLast.reset();
            fieldGeneratorPreviousClose.reset();
            fieldGeneratorPreviousCloseDate.reset();
            fieldGeneratorChangeFromPreviousClose.reset();
            fieldGeneratorPercentChangeFromPreviousClose.reset();
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
        protected override void handle_result(StockGlobalIndicesHistoricalQuoteJSON  result)
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
        public StockGlobalIndicesHistoricalQuoteJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockGlobalIndicesHistoricalQuoteJSON  result)
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
    protected virtual void handle_result(List<StockGlobalIndicesHistoricalQuoteJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockGlobalIndicesHistoricalQuoteJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockGlobalIndicesHistoricalQuoteJSON>();
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
    public List<StockGlobalIndicesHistoricalQuoteJSON> value;
  };
  };
