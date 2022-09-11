/* file "StockConversationRequestedListingJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class StockConversationRequestedListingJSON : JSONBase
  {
    private bool flagHasListingID;
    private BigInteger storeListingID;
    private bool flagHasListingRequestType;
    private StockListingRequestTypeJSON  storeListingRequestType;
    private bool flagHasNumShares;
    private BigInteger storeNumShares;
    private bool flagHasAlternateListingID;
    private BigInteger storeAlternateListingID;
    private bool flagHasStockEntityData;
    private StockEntityDataJSON  storeStockEntityData;
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
                throw new Exception("The value for field ListingID of StockConversationRequestedListingJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ListingID of StockConversationRequestedListingJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setListingID(extracted_integer);
      }


    private void  fromJSONListingRequestType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockListingRequestTypeJSON convert_classy = StockListingRequestTypeJSON.from_json(json_value, ignore_extras, true);
        setListingRequestType(convert_classy);
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
                throw new Exception("The value for field NumShares of StockConversationRequestedListingJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumShares of StockConversationRequestedListingJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumShares(extracted_integer);
      }


    private void  fromJSONAlternateListingID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field AlternateListingID of StockConversationRequestedListingJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AlternateListingID of StockConversationRequestedListingJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAlternateListingID(extracted_integer);
      }


    private void  fromJSONStockEntityData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockEntityDataJSON convert_classy = StockEntityDataJSON.from_json(json_value, ignore_extras, true);
        setStockEntityData(convert_classy);
      }


    public StockConversationRequestedListingJSON()
      {
        flagHasListingID = false;
        flagHasListingRequestType = false;
        flagHasNumShares = false;
        flagHasAlternateListingID = false;
        flagHasStockEntityData = false;
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

    public bool  hasListingRequestType()
      {
        return flagHasListingRequestType;
      }

    public StockListingRequestTypeJSON   getListingRequestType()
      {
        Debug.Assert(flagHasListingRequestType);
        return storeListingRequestType;
      }

    public StockListingRequestTypeJSON.TypeValue  getListingRequestTypeValue()
      {
        return getListingRequestType().getValue();
      }

    public string  getListingRequestTypeAsString()
      {
        return getListingRequestType().getValueAsString();
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

    public bool  hasAlternateListingID()
      {
        return flagHasAlternateListingID;
      }

    public BigInteger  getAlternateListingID()
      {
        Debug.Assert(flagHasAlternateListingID);
        return storeAlternateListingID;
      }

    public bool  hasStockEntityData()
      {
        return flagHasStockEntityData;
      }

    public StockEntityDataJSON   getStockEntityData()
      {
        Debug.Assert(flagHasStockEntityData);
        return storeStockEntityData;
      }


    public virtual int extraStockConversationRequestedListingComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockConversationRequestedListingComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockConversationRequestedListingComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockConversationRequestedListingLookup(string field_name)
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
    public void setListingRequestType(StockListingRequestTypeJSON  new_value)
      {
        if (flagHasListingRequestType)
          {
          }
        flagHasListingRequestType = true;
        storeListingRequestType = new_value;
      }
    public void setListingRequestType(StockListingRequestTypeJSON.TypeValue new_value)
      {
        setListingRequestType(new StockListingRequestTypeJSON(new_value));
      }
    public void setListingRequestType(string chars)
      {
        StockListingRequestTypeJSON.TypeValueKnownValues known = StockListingRequestTypeJSON.stringToValue(chars);
        StockListingRequestTypeJSON.TypeValue new_value = new StockListingRequestTypeJSON.TypeValue();
        if (known == StockListingRequestTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setListingRequestType(new_value);
      }
    public void unsetListingRequestType()
      {
        if (flagHasListingRequestType)
          {
          }
        flagHasListingRequestType = false;
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
    public void setAlternateListingID(BigInteger new_value)
      {
        flagHasAlternateListingID = true;
        storeAlternateListingID = new_value;
      }
    public void unsetAlternateListingID()
      {
        flagHasAlternateListingID = false;
      }
    public void setStockEntityData(StockEntityDataJSON  new_value)
      {
        if (flagHasStockEntityData)
          {
          }
        flagHasStockEntityData = true;
        storeStockEntityData = new_value;
      }
    public void unsetStockEntityData()
      {
        if (flagHasStockEntityData)
          {
          }
        flagHasStockEntityData = false;
      }

    public virtual void extraStockConversationRequestedListingAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockConversationRequestedListingSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockConversationRequestedListingLookup(key);
        if (old_field == null)
          {
            extraStockConversationRequestedListingAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasListingRequestType);
        if (flagHasListingRequestType)
          {
            handler.start_pair("ListingRequestType");
            if (partial_allowed)
                storeListingRequestType.write_partial_as_json(handler);
            else
                storeListingRequestType.write_as_json(handler);
          }
        if (flagHasNumShares)
          {
            handler.start_pair("NumShares");
            handler.number_value(storeNumShares);
          }
        if (flagHasAlternateListingID)
          {
            handler.start_pair("AlternateListingID");
            handler.number_value(storeAlternateListingID);
          }
        if (flagHasStockEntityData)
          {
            handler.start_pair("StockEntityData");
            if (partial_allowed)
                storeStockEntityData.write_partial_as_json(handler);
            else
                storeStockEntityData.write_as_json(handler);
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
        if (!(hasListingRequestType()))
          {
            return "When parsing the object for %what%, the \"ListingRequestType\" field was missing.";
          }
        return null;
      }

    public static StockConversationRequestedListingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockConversationRequestedListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockConversationRequestedListing", ignore_extras);
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
    public static StockConversationRequestedListingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockConversationRequestedListingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockConversationRequestedListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockConversationRequestedListing", ignore_extras);
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
    public static StockConversationRequestedListingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockConversationRequestedListingJSON from_text(string text, bool ignore_extras)
      {
        StockConversationRequestedListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockConversationRequestedListing", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockConversationRequestedListingJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockConversationRequestedListingJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockConversationRequestedListingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockConversationRequestedListing", ignore_extras);
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
        private StockListingRequestTypeJSON.HoldingGenerator fieldGeneratorListingRequestType;
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
    private class FieldHoldingGeneratorAlternateListingID : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorAlternateListingID(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorAlternateListingID : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorAlternateListingID(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorAlternateListingID fieldGeneratorAlternateListingID;
        private StockEntityDataJSON.HoldingGenerator fieldGeneratorStockEntityData;
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
            StockConversationRequestedListingJSON result = new StockConversationRequestedListingJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockConversationRequestedListingAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockConversationRequestedListingJSON result)
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
            if (fieldGeneratorListingRequestType.have_value)
              {
                result.setListingRequestType(fieldGeneratorListingRequestType.value);
                fieldGeneratorListingRequestType.have_value = false;
              }
            else if ((!(result.hasListingRequestType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ListingRequestType\" field was missing.");
              }
            if (fieldGeneratorNumShares.have_value)
              {
                result.setNumShares(fieldGeneratorNumShares.value);
                fieldGeneratorNumShares.have_value = false;
              }
            if (fieldGeneratorAlternateListingID.have_value)
              {
                result.setAlternateListingID(fieldGeneratorAlternateListingID.value);
                fieldGeneratorAlternateListingID.have_value = false;
              }
            if (fieldGeneratorStockEntityData.have_value)
              {
                result.setStockEntityData(fieldGeneratorStockEntityData.value);
                fieldGeneratorStockEntityData.have_value = false;
              }
          }
        protected abstract void handle_result(StockConversationRequestedListingJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "lternateListingID", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorAlternateListingID;
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "isting", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 8, "D", 0, 1, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorListingID;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 8, "equestType", 0, 10, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorListingRequestType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umShares", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorNumShares;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tockEntityData", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorStockEntityData;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorListingID = new FieldHoldingGeneratorListingID("field \"ListingID\" of the StockConversationRequestedListing class");
            fieldGeneratorListingRequestType = new StockListingRequestTypeJSON.HoldingGenerator("field \"ListingRequestType\" of the StockConversationRequestedListing class", ignore_extras);
            fieldGeneratorNumShares = new FieldHoldingGeneratorNumShares("field \"NumShares\" of the StockConversationRequestedListing class");
            fieldGeneratorAlternateListingID = new FieldHoldingGeneratorAlternateListingID("field \"AlternateListingID\" of the StockConversationRequestedListing class");
            fieldGeneratorStockEntityData = new StockEntityDataJSON.HoldingGenerator("field \"StockEntityData\" of the StockConversationRequestedListing class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockConversationRequestedListing class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorListingID = new FieldHoldingGeneratorListingID("field \"ListingID\" of the StockConversationRequestedListing class");
            fieldGeneratorListingRequestType = new StockListingRequestTypeJSON.HoldingGenerator("field \"ListingRequestType\" of the StockConversationRequestedListing class", false);
            fieldGeneratorNumShares = new FieldHoldingGeneratorNumShares("field \"NumShares\" of the StockConversationRequestedListing class");
            fieldGeneratorAlternateListingID = new FieldHoldingGeneratorAlternateListingID("field \"AlternateListingID\" of the StockConversationRequestedListing class");
            fieldGeneratorStockEntityData = new StockEntityDataJSON.HoldingGenerator("field \"StockEntityData\" of the StockConversationRequestedListing class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockConversationRequestedListing class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorListingID.reset();
            fieldGeneratorListingRequestType.reset();
            fieldGeneratorNumShares.reset();
            fieldGeneratorAlternateListingID.reset();
            fieldGeneratorStockEntityData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorListingRequestType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStockEntityData.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorListingRequestType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStockEntityData.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StockConversationRequestedListingJSON  result)
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
        public StockConversationRequestedListingJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockConversationRequestedListingJSON  result)
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
    protected virtual void handle_result(List<StockConversationRequestedListingJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockConversationRequestedListingJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockConversationRequestedListingJSON>();
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
    public List<StockConversationRequestedListingJSON> value;
  };
  };
