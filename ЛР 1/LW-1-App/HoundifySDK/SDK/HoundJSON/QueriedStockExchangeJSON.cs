/* file "QueriedStockExchangeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class QueriedStockExchangeJSON : JSONBase
  {
    private bool flagHasExchangeID;
    private BigInteger storeExchangeID;
    private bool flagHasShortSpokenName;
    private string storeShortSpokenName;
    private bool flagHasShortDisplayName;
    private string storeShortDisplayName;
    private bool flagHasLongSpokenName;
    private string storeLongSpokenName;
    private bool flagHasLongDisplayName;
    private string storeLongDisplayName;
    private bool flagHasSpokenExchangeSymbol;
    private string storeSpokenExchangeSymbol;
    private bool flagHasDisplayExchangeSymbol;
    private string storeDisplayExchangeSymbol;
    private bool flagHasCountryCode;
    private string storeCountryCode;
    private bool flagHasDataSourceName;
    private string storeDataSourceName;
    private bool flagHasDataSourceCode;
    private string storeDataSourceCode;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONExchangeID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ExchangeID of QueriedStockExchangeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ExchangeID of QueriedStockExchangeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setExchangeID(extracted_integer);
      }


    private void  fromJSONShortSpokenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ShortSpokenName of QueriedStockExchangeJSON is not a string.");
        setShortSpokenName(json_string.getData());
      }


    private void  fromJSONShortDisplayName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ShortDisplayName of QueriedStockExchangeJSON is not a string.");
        setShortDisplayName(json_string.getData());
      }


    private void  fromJSONLongSpokenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LongSpokenName of QueriedStockExchangeJSON is not a string.");
        setLongSpokenName(json_string.getData());
      }


    private void  fromJSONLongDisplayName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LongDisplayName of QueriedStockExchangeJSON is not a string.");
        setLongDisplayName(json_string.getData());
      }


    private void  fromJSONSpokenExchangeSymbol(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenExchangeSymbol of QueriedStockExchangeJSON is not a string.");
        setSpokenExchangeSymbol(json_string.getData());
      }


    private void  fromJSONDisplayExchangeSymbol(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayExchangeSymbol of QueriedStockExchangeJSON is not a string.");
        setDisplayExchangeSymbol(json_string.getData());
      }


    private void  fromJSONCountryCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CountryCode of QueriedStockExchangeJSON is not a string.");
        setCountryCode(json_string.getData());
      }


    private void  fromJSONDataSourceName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DataSourceName of QueriedStockExchangeJSON is not a string.");
        setDataSourceName(json_string.getData());
      }


    private void  fromJSONDataSourceCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DataSourceCode of QueriedStockExchangeJSON is not a string.");
        setDataSourceCode(json_string.getData());
      }


    public QueriedStockExchangeJSON()
      {
        flagHasExchangeID = false;
        flagHasShortSpokenName = false;
        flagHasShortDisplayName = false;
        flagHasLongSpokenName = false;
        flagHasLongDisplayName = false;
        flagHasSpokenExchangeSymbol = false;
        flagHasDisplayExchangeSymbol = false;
        flagHasCountryCode = false;
        flagHasDataSourceName = false;
        flagHasDataSourceCode = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasExchangeID()
      {
        return flagHasExchangeID;
      }

    public BigInteger  getExchangeID()
      {
        Debug.Assert(flagHasExchangeID);
        return storeExchangeID;
      }

    public bool  hasShortSpokenName()
      {
        return flagHasShortSpokenName;
      }

    public string  getShortSpokenName()
      {
        Debug.Assert(flagHasShortSpokenName);
        return storeShortSpokenName;
      }

    public bool  hasShortDisplayName()
      {
        return flagHasShortDisplayName;
      }

    public string  getShortDisplayName()
      {
        Debug.Assert(flagHasShortDisplayName);
        return storeShortDisplayName;
      }

    public bool  hasLongSpokenName()
      {
        return flagHasLongSpokenName;
      }

    public string  getLongSpokenName()
      {
        Debug.Assert(flagHasLongSpokenName);
        return storeLongSpokenName;
      }

    public bool  hasLongDisplayName()
      {
        return flagHasLongDisplayName;
      }

    public string  getLongDisplayName()
      {
        Debug.Assert(flagHasLongDisplayName);
        return storeLongDisplayName;
      }

    public bool  hasSpokenExchangeSymbol()
      {
        return flagHasSpokenExchangeSymbol;
      }

    public string  getSpokenExchangeSymbol()
      {
        Debug.Assert(flagHasSpokenExchangeSymbol);
        return storeSpokenExchangeSymbol;
      }

    public bool  hasDisplayExchangeSymbol()
      {
        return flagHasDisplayExchangeSymbol;
      }

    public string  getDisplayExchangeSymbol()
      {
        Debug.Assert(flagHasDisplayExchangeSymbol);
        return storeDisplayExchangeSymbol;
      }

    public bool  hasCountryCode()
      {
        return flagHasCountryCode;
      }

    public string  getCountryCode()
      {
        Debug.Assert(flagHasCountryCode);
        return storeCountryCode;
      }

    public bool  hasDataSourceName()
      {
        return flagHasDataSourceName;
      }

    public string  getDataSourceName()
      {
        Debug.Assert(flagHasDataSourceName);
        return storeDataSourceName;
      }

    public bool  hasDataSourceCode()
      {
        return flagHasDataSourceCode;
      }

    public string  getDataSourceCode()
      {
        Debug.Assert(flagHasDataSourceCode);
        return storeDataSourceCode;
      }


    public virtual int extraQueriedStockExchangeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraQueriedStockExchangeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraQueriedStockExchangeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraQueriedStockExchangeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setExchangeID(BigInteger new_value)
      {
        flagHasExchangeID = true;
        storeExchangeID = new_value;
      }
    public void unsetExchangeID()
      {
        flagHasExchangeID = false;
      }
    public void setShortSpokenName(string new_value)
      {
        flagHasShortSpokenName = true;
        storeShortSpokenName = new_value;
      }
    public void unsetShortSpokenName()
      {
        flagHasShortSpokenName = false;
      }
    public void setShortDisplayName(string new_value)
      {
        flagHasShortDisplayName = true;
        storeShortDisplayName = new_value;
      }
    public void unsetShortDisplayName()
      {
        flagHasShortDisplayName = false;
      }
    public void setLongSpokenName(string new_value)
      {
        flagHasLongSpokenName = true;
        storeLongSpokenName = new_value;
      }
    public void unsetLongSpokenName()
      {
        flagHasLongSpokenName = false;
      }
    public void setLongDisplayName(string new_value)
      {
        flagHasLongDisplayName = true;
        storeLongDisplayName = new_value;
      }
    public void unsetLongDisplayName()
      {
        flagHasLongDisplayName = false;
      }
    public void setSpokenExchangeSymbol(string new_value)
      {
        flagHasSpokenExchangeSymbol = true;
        storeSpokenExchangeSymbol = new_value;
      }
    public void unsetSpokenExchangeSymbol()
      {
        flagHasSpokenExchangeSymbol = false;
      }
    public void setDisplayExchangeSymbol(string new_value)
      {
        flagHasDisplayExchangeSymbol = true;
        storeDisplayExchangeSymbol = new_value;
      }
    public void unsetDisplayExchangeSymbol()
      {
        flagHasDisplayExchangeSymbol = false;
      }
    public void setCountryCode(string new_value)
      {
        flagHasCountryCode = true;
        storeCountryCode = new_value;
      }
    public void unsetCountryCode()
      {
        flagHasCountryCode = false;
      }
    public void setDataSourceName(string new_value)
      {
        flagHasDataSourceName = true;
        storeDataSourceName = new_value;
      }
    public void unsetDataSourceName()
      {
        flagHasDataSourceName = false;
      }
    public void setDataSourceCode(string new_value)
      {
        flagHasDataSourceCode = true;
        storeDataSourceCode = new_value;
      }
    public void unsetDataSourceCode()
      {
        flagHasDataSourceCode = false;
      }

    public virtual void extraQueriedStockExchangeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraQueriedStockExchangeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraQueriedStockExchangeLookup(key);
        if (old_field == null)
          {
            extraQueriedStockExchangeAppendPair(key, new_component);
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
        if (flagHasExchangeID)
          {
            handler.start_pair("ExchangeID");
            handler.number_value(storeExchangeID);
          }
        if (flagHasShortSpokenName)
          {
            handler.start_pair("ShortSpokenName");
            handler.string_value(storeShortSpokenName);
          }
        if (flagHasShortDisplayName)
          {
            handler.start_pair("ShortDisplayName");
            handler.string_value(storeShortDisplayName);
          }
        if (flagHasLongSpokenName)
          {
            handler.start_pair("LongSpokenName");
            handler.string_value(storeLongSpokenName);
          }
        if (flagHasLongDisplayName)
          {
            handler.start_pair("LongDisplayName");
            handler.string_value(storeLongDisplayName);
          }
        if (flagHasSpokenExchangeSymbol)
          {
            handler.start_pair("SpokenExchangeSymbol");
            handler.string_value(storeSpokenExchangeSymbol);
          }
        if (flagHasDisplayExchangeSymbol)
          {
            handler.start_pair("DisplayExchangeSymbol");
            handler.string_value(storeDisplayExchangeSymbol);
          }
        if (flagHasCountryCode)
          {
            handler.start_pair("CountryCode");
            handler.string_value(storeCountryCode);
          }
        if (flagHasDataSourceName)
          {
            handler.start_pair("DataSourceName");
            handler.string_value(storeDataSourceName);
          }
        if (flagHasDataSourceCode)
          {
            handler.start_pair("DataSourceCode");
            handler.string_value(storeDataSourceCode);
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

    public static QueriedStockExchangeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        QueriedStockExchangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockExchange", ignore_extras);
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
    public static QueriedStockExchangeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static QueriedStockExchangeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        QueriedStockExchangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockExchange", ignore_extras);
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
    public static QueriedStockExchangeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static QueriedStockExchangeJSON from_text(string text, bool ignore_extras)
      {
        QueriedStockExchangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockExchange", ignore_extras);
            JSONParse.parse_json_value(text, "Text for QueriedStockExchangeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static QueriedStockExchangeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        QueriedStockExchangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockExchange", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorExchangeID : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorExchangeID(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorExchangeID : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorExchangeID(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorExchangeID fieldGeneratorExchangeID;
        private JSONHoldingStringGenerator fieldGeneratorShortSpokenName;
        private JSONHoldingStringGenerator fieldGeneratorShortDisplayName;
        private JSONHoldingStringGenerator fieldGeneratorLongSpokenName;
        private JSONHoldingStringGenerator fieldGeneratorLongDisplayName;
        private JSONHoldingStringGenerator fieldGeneratorSpokenExchangeSymbol;
        private JSONHoldingStringGenerator fieldGeneratorDisplayExchangeSymbol;
        private JSONHoldingStringGenerator fieldGeneratorCountryCode;
        private JSONHoldingStringGenerator fieldGeneratorDataSourceName;
        private JSONHoldingStringGenerator fieldGeneratorDataSourceCode;
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
            QueriedStockExchangeJSON result = new QueriedStockExchangeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraQueriedStockExchangeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(QueriedStockExchangeJSON result)
          {
            if (fieldGeneratorExchangeID.have_value)
              {
                result.setExchangeID(fieldGeneratorExchangeID.value);
                fieldGeneratorExchangeID.have_value = false;
              }
            if (fieldGeneratorShortSpokenName.have_value)
              {
                result.setShortSpokenName(fieldGeneratorShortSpokenName.value);
                fieldGeneratorShortSpokenName.have_value = false;
              }
            if (fieldGeneratorShortDisplayName.have_value)
              {
                result.setShortDisplayName(fieldGeneratorShortDisplayName.value);
                fieldGeneratorShortDisplayName.have_value = false;
              }
            if (fieldGeneratorLongSpokenName.have_value)
              {
                result.setLongSpokenName(fieldGeneratorLongSpokenName.value);
                fieldGeneratorLongSpokenName.have_value = false;
              }
            if (fieldGeneratorLongDisplayName.have_value)
              {
                result.setLongDisplayName(fieldGeneratorLongDisplayName.value);
                fieldGeneratorLongDisplayName.have_value = false;
              }
            if (fieldGeneratorSpokenExchangeSymbol.have_value)
              {
                result.setSpokenExchangeSymbol(fieldGeneratorSpokenExchangeSymbol.value);
                fieldGeneratorSpokenExchangeSymbol.have_value = false;
              }
            if (fieldGeneratorDisplayExchangeSymbol.have_value)
              {
                result.setDisplayExchangeSymbol(fieldGeneratorDisplayExchangeSymbol.value);
                fieldGeneratorDisplayExchangeSymbol.have_value = false;
              }
            if (fieldGeneratorCountryCode.have_value)
              {
                result.setCountryCode(fieldGeneratorCountryCode.value);
                fieldGeneratorCountryCode.have_value = false;
              }
            if (fieldGeneratorDataSourceName.have_value)
              {
                result.setDataSourceName(fieldGeneratorDataSourceName.value);
                fieldGeneratorDataSourceName.have_value = false;
              }
            if (fieldGeneratorDataSourceCode.have_value)
              {
                result.setDataSourceCode(fieldGeneratorDataSourceCode.value);
                fieldGeneratorDataSourceCode.have_value = false;
              }
          }
        protected abstract void handle_result(QueriedStockExchangeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ountryCode", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCountryCode;
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "taSource", 0, 8, false) == 0)
                              {
                                switch (field_name[10])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 11, "ode", 0, 3, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorDataSourceCode;
                                        break;
                                    case 'N':
                                        if ((String.Compare(field_name, 11, "ame", 0, 3, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorDataSourceName;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "splayExchangeSymbol", 0, 19, false) == 0) && (field_name.Length == 21))
                                return fieldGeneratorDisplayExchangeSymbol;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "xchangeID", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorExchangeID;
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "ong", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 5, "isplayName", 0, 10, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorLongDisplayName;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 5, "pokenName", 0, 9, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorLongSpokenName;
                                break;
                            default:
                                break;
                          }
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
                                    case 'D':
                                        if ((String.Compare(field_name, 6, "isplayName", 0, 10, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorShortDisplayName;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 6, "pokenName", 0, 9, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorShortSpokenName;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenExchangeSymbol", 0, 18, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorSpokenExchangeSymbol;
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
            fieldGeneratorExchangeID = new FieldHoldingGeneratorExchangeID("field \"ExchangeID\" of the QueriedStockExchange class");
            fieldGeneratorShortSpokenName = new JSONHoldingStringGenerator("field \"ShortSpokenName\" of the QueriedStockExchange class");
            fieldGeneratorShortDisplayName = new JSONHoldingStringGenerator("field \"ShortDisplayName\" of the QueriedStockExchange class");
            fieldGeneratorLongSpokenName = new JSONHoldingStringGenerator("field \"LongSpokenName\" of the QueriedStockExchange class");
            fieldGeneratorLongDisplayName = new JSONHoldingStringGenerator("field \"LongDisplayName\" of the QueriedStockExchange class");
            fieldGeneratorSpokenExchangeSymbol = new JSONHoldingStringGenerator("field \"SpokenExchangeSymbol\" of the QueriedStockExchange class");
            fieldGeneratorDisplayExchangeSymbol = new JSONHoldingStringGenerator("field \"DisplayExchangeSymbol\" of the QueriedStockExchange class");
            fieldGeneratorCountryCode = new JSONHoldingStringGenerator("field \"CountryCode\" of the QueriedStockExchange class");
            fieldGeneratorDataSourceName = new JSONHoldingStringGenerator("field \"DataSourceName\" of the QueriedStockExchange class");
            fieldGeneratorDataSourceCode = new JSONHoldingStringGenerator("field \"DataSourceCode\" of the QueriedStockExchange class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the QueriedStockExchange class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorExchangeID = new FieldHoldingGeneratorExchangeID("field \"ExchangeID\" of the QueriedStockExchange class");
            fieldGeneratorShortSpokenName = new JSONHoldingStringGenerator("field \"ShortSpokenName\" of the QueriedStockExchange class");
            fieldGeneratorShortDisplayName = new JSONHoldingStringGenerator("field \"ShortDisplayName\" of the QueriedStockExchange class");
            fieldGeneratorLongSpokenName = new JSONHoldingStringGenerator("field \"LongSpokenName\" of the QueriedStockExchange class");
            fieldGeneratorLongDisplayName = new JSONHoldingStringGenerator("field \"LongDisplayName\" of the QueriedStockExchange class");
            fieldGeneratorSpokenExchangeSymbol = new JSONHoldingStringGenerator("field \"SpokenExchangeSymbol\" of the QueriedStockExchange class");
            fieldGeneratorDisplayExchangeSymbol = new JSONHoldingStringGenerator("field \"DisplayExchangeSymbol\" of the QueriedStockExchange class");
            fieldGeneratorCountryCode = new JSONHoldingStringGenerator("field \"CountryCode\" of the QueriedStockExchange class");
            fieldGeneratorDataSourceName = new JSONHoldingStringGenerator("field \"DataSourceName\" of the QueriedStockExchange class");
            fieldGeneratorDataSourceCode = new JSONHoldingStringGenerator("field \"DataSourceCode\" of the QueriedStockExchange class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the QueriedStockExchange class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorExchangeID.reset();
            fieldGeneratorShortSpokenName.reset();
            fieldGeneratorShortDisplayName.reset();
            fieldGeneratorLongSpokenName.reset();
            fieldGeneratorLongDisplayName.reset();
            fieldGeneratorSpokenExchangeSymbol.reset();
            fieldGeneratorDisplayExchangeSymbol.reset();
            fieldGeneratorCountryCode.reset();
            fieldGeneratorDataSourceName.reset();
            fieldGeneratorDataSourceCode.reset();
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
        protected override void handle_result(QueriedStockExchangeJSON  result)
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
        public QueriedStockExchangeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(QueriedStockExchangeJSON  result)
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
    protected virtual void handle_result(List<QueriedStockExchangeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<QueriedStockExchangeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<QueriedStockExchangeJSON>();
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
    public List<QueriedStockExchangeJSON> value;
  };
  };
