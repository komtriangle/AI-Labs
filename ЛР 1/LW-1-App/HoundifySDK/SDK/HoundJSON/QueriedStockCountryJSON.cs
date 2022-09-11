/* file "QueriedStockCountryJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class QueriedStockCountryJSON : JSONBase
  {
    private bool flagHasCountryID;
    private BigInteger storeCountryID;
    private bool flagHasSpokenName;
    private string storeSpokenName;
    private bool flagHasDisplayName;
    private string storeDisplayName;
    private bool flagHasCountryCode;
    private string storeCountryCode;
    private bool flagHasCurrencyCode;
    private string storeCurrencyCode;
    private bool flagHasDataSourceName;
    private string storeDataSourceName;
    private bool flagHasDataSourceCode;
    private string storeDataSourceCode;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCountryID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CountryID of QueriedStockCountryJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CountryID of QueriedStockCountryJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCountryID(extracted_integer);
      }


    private void  fromJSONSpokenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenName of QueriedStockCountryJSON is not a string.");
        setSpokenName(json_string.getData());
      }


    private void  fromJSONDisplayName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayName of QueriedStockCountryJSON is not a string.");
        setDisplayName(json_string.getData());
      }


    private void  fromJSONCountryCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CountryCode of QueriedStockCountryJSON is not a string.");
        setCountryCode(json_string.getData());
      }


    private void  fromJSONCurrencyCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CurrencyCode of QueriedStockCountryJSON is not a string.");
        setCurrencyCode(json_string.getData());
      }


    private void  fromJSONDataSourceName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DataSourceName of QueriedStockCountryJSON is not a string.");
        setDataSourceName(json_string.getData());
      }


    private void  fromJSONDataSourceCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DataSourceCode of QueriedStockCountryJSON is not a string.");
        setDataSourceCode(json_string.getData());
      }


    public QueriedStockCountryJSON()
      {
        flagHasCountryID = false;
        flagHasSpokenName = false;
        flagHasDisplayName = false;
        flagHasCountryCode = false;
        flagHasCurrencyCode = false;
        flagHasDataSourceName = false;
        flagHasDataSourceCode = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCountryID()
      {
        return flagHasCountryID;
      }

    public BigInteger  getCountryID()
      {
        Debug.Assert(flagHasCountryID);
        return storeCountryID;
      }

    public bool  hasSpokenName()
      {
        return flagHasSpokenName;
      }

    public string  getSpokenName()
      {
        Debug.Assert(flagHasSpokenName);
        return storeSpokenName;
      }

    public bool  hasDisplayName()
      {
        return flagHasDisplayName;
      }

    public string  getDisplayName()
      {
        Debug.Assert(flagHasDisplayName);
        return storeDisplayName;
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

    public bool  hasCurrencyCode()
      {
        return flagHasCurrencyCode;
      }

    public string  getCurrencyCode()
      {
        Debug.Assert(flagHasCurrencyCode);
        return storeCurrencyCode;
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


    public virtual int extraQueriedStockCountryComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraQueriedStockCountryComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraQueriedStockCountryComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraQueriedStockCountryLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCountryID(BigInteger new_value)
      {
        flagHasCountryID = true;
        storeCountryID = new_value;
      }
    public void unsetCountryID()
      {
        flagHasCountryID = false;
      }
    public void setSpokenName(string new_value)
      {
        flagHasSpokenName = true;
        storeSpokenName = new_value;
      }
    public void unsetSpokenName()
      {
        flagHasSpokenName = false;
      }
    public void setDisplayName(string new_value)
      {
        flagHasDisplayName = true;
        storeDisplayName = new_value;
      }
    public void unsetDisplayName()
      {
        flagHasDisplayName = false;
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
    public void setCurrencyCode(string new_value)
      {
        flagHasCurrencyCode = true;
        storeCurrencyCode = new_value;
      }
    public void unsetCurrencyCode()
      {
        flagHasCurrencyCode = false;
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

    public virtual void extraQueriedStockCountryAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraQueriedStockCountrySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraQueriedStockCountryLookup(key);
        if (old_field == null)
          {
            extraQueriedStockCountryAppendPair(key, new_component);
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
        if (flagHasCountryID)
          {
            handler.start_pair("CountryID");
            handler.number_value(storeCountryID);
          }
        if (flagHasSpokenName)
          {
            handler.start_pair("SpokenName");
            handler.string_value(storeSpokenName);
          }
        if (flagHasDisplayName)
          {
            handler.start_pair("DisplayName");
            handler.string_value(storeDisplayName);
          }
        if (flagHasCountryCode)
          {
            handler.start_pair("CountryCode");
            handler.string_value(storeCountryCode);
          }
        if (flagHasCurrencyCode)
          {
            handler.start_pair("CurrencyCode");
            handler.string_value(storeCurrencyCode);
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

    public static QueriedStockCountryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        QueriedStockCountryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockCountry", ignore_extras);
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
    public static QueriedStockCountryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static QueriedStockCountryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        QueriedStockCountryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockCountry", ignore_extras);
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
    public static QueriedStockCountryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static QueriedStockCountryJSON from_text(string text, bool ignore_extras)
      {
        QueriedStockCountryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockCountry", ignore_extras);
            JSONParse.parse_json_value(text, "Text for QueriedStockCountryJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static QueriedStockCountryJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        QueriedStockCountryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockCountry", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorCountryID : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorCountryID(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCountryID : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCountryID(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorCountryID fieldGeneratorCountryID;
        private JSONHoldingStringGenerator fieldGeneratorSpokenName;
        private JSONHoldingStringGenerator fieldGeneratorDisplayName;
        private JSONHoldingStringGenerator fieldGeneratorCountryCode;
        private JSONHoldingStringGenerator fieldGeneratorCurrencyCode;
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
            QueriedStockCountryJSON result = new QueriedStockCountryJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraQueriedStockCountryAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(QueriedStockCountryJSON result)
          {
            if (fieldGeneratorCountryID.have_value)
              {
                result.setCountryID(fieldGeneratorCountryID.value);
                fieldGeneratorCountryID.have_value = false;
              }
            if (fieldGeneratorSpokenName.have_value)
              {
                result.setSpokenName(fieldGeneratorSpokenName.value);
                fieldGeneratorSpokenName.have_value = false;
              }
            if (fieldGeneratorDisplayName.have_value)
              {
                result.setDisplayName(fieldGeneratorDisplayName.value);
                fieldGeneratorDisplayName.have_value = false;
              }
            if (fieldGeneratorCountryCode.have_value)
              {
                result.setCountryCode(fieldGeneratorCountryCode.value);
                fieldGeneratorCountryCode.have_value = false;
              }
            if (fieldGeneratorCurrencyCode.have_value)
              {
                result.setCurrencyCode(fieldGeneratorCurrencyCode.value);
                fieldGeneratorCurrencyCode.have_value = false;
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
        protected abstract void handle_result(QueriedStockCountryJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'o':
                            if (String.Compare(field_name, 2, "untry", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 8, "ode", 0, 3, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorCountryCode;
                                        break;
                                    case 'I':
                                        if ((String.Compare(field_name, 8, "D", 0, 1, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorCountryID;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rrencyCode", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorCurrencyCode;
                            break;
                        default:
                            break;
                      }
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
                            if ((String.Compare(field_name, 2, "splayName", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorDisplayName;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pokenName", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorSpokenName;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCountryID = new FieldHoldingGeneratorCountryID("field \"CountryID\" of the QueriedStockCountry class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the QueriedStockCountry class");
            fieldGeneratorDisplayName = new JSONHoldingStringGenerator("field \"DisplayName\" of the QueriedStockCountry class");
            fieldGeneratorCountryCode = new JSONHoldingStringGenerator("field \"CountryCode\" of the QueriedStockCountry class");
            fieldGeneratorCurrencyCode = new JSONHoldingStringGenerator("field \"CurrencyCode\" of the QueriedStockCountry class");
            fieldGeneratorDataSourceName = new JSONHoldingStringGenerator("field \"DataSourceName\" of the QueriedStockCountry class");
            fieldGeneratorDataSourceCode = new JSONHoldingStringGenerator("field \"DataSourceCode\" of the QueriedStockCountry class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the QueriedStockCountry class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCountryID = new FieldHoldingGeneratorCountryID("field \"CountryID\" of the QueriedStockCountry class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the QueriedStockCountry class");
            fieldGeneratorDisplayName = new JSONHoldingStringGenerator("field \"DisplayName\" of the QueriedStockCountry class");
            fieldGeneratorCountryCode = new JSONHoldingStringGenerator("field \"CountryCode\" of the QueriedStockCountry class");
            fieldGeneratorCurrencyCode = new JSONHoldingStringGenerator("field \"CurrencyCode\" of the QueriedStockCountry class");
            fieldGeneratorDataSourceName = new JSONHoldingStringGenerator("field \"DataSourceName\" of the QueriedStockCountry class");
            fieldGeneratorDataSourceCode = new JSONHoldingStringGenerator("field \"DataSourceCode\" of the QueriedStockCountry class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the QueriedStockCountry class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCountryID.reset();
            fieldGeneratorSpokenName.reset();
            fieldGeneratorDisplayName.reset();
            fieldGeneratorCountryCode.reset();
            fieldGeneratorCurrencyCode.reset();
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
        protected override void handle_result(QueriedStockCountryJSON  result)
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
        public QueriedStockCountryJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(QueriedStockCountryJSON  result)
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
    protected virtual void handle_result(List<QueriedStockCountryJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<QueriedStockCountryJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<QueriedStockCountryJSON>();
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
    public List<QueriedStockCountryJSON> value;
  };
  };
