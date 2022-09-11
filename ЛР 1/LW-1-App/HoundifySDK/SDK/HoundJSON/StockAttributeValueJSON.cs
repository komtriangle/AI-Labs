/* file "StockAttributeValueJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StockAttributeValueJSON : JSONBase
  {
    private bool flagHasSpoken;
    private string storeSpoken;
    private bool flagHasDisplay;
    private string storeDisplay;
    private bool flagHasTable;
    private string storeTable;
    private bool flagHasNative;
    private string storeNative;
    private bool flagHasRationalValue;
    private double storeRationalValue;
    private string textStoreRationalValue;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Spoken of StockAttributeValueJSON is not a string.");
        setSpoken(json_string.getData());
      }


    private void  fromJSONDisplay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Display of StockAttributeValueJSON is not a string.");
        setDisplay(json_string.getData());
      }


    private void  fromJSONTable(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Table of StockAttributeValueJSON is not a string.");
        setTable(json_string.getData());
      }


    private void  fromJSONNative(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Native of StockAttributeValueJSON is not a string.");
        setNative(json_string.getData());
      }


    private void  fromJSONRationalValue(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RationalValue of StockAttributeValueJSON is not a number.");
              }
          }
        setRationalValueText(the_rational_text);
      }


    public StockAttributeValueJSON()
      {
        flagHasSpoken = false;
        flagHasDisplay = false;
        flagHasTable = false;
        flagHasNative = false;
        flagHasRationalValue = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSpoken()
      {
        return flagHasSpoken;
      }

    public string  getSpoken()
      {
        Debug.Assert(flagHasSpoken);
        return storeSpoken;
      }

    public bool  hasDisplay()
      {
        return flagHasDisplay;
      }

    public string  getDisplay()
      {
        Debug.Assert(flagHasDisplay);
        return storeDisplay;
      }

    public bool  hasTable()
      {
        return flagHasTable;
      }

    public string  getTable()
      {
        Debug.Assert(flagHasTable);
        return storeTable;
      }

    public bool  hasNative()
      {
        return flagHasNative;
      }

    public string  getNative()
      {
        Debug.Assert(flagHasNative);
        return storeNative;
      }

    public bool  hasRationalValue()
      {
        return flagHasRationalValue;
      }

    public double  getRationalValue()
      {
        Debug.Assert(flagHasRationalValue);
        if (textStoreRationalValue != "")
          {
            return Double.Parse(textStoreRationalValue);
          }
        return storeRationalValue;
      }

    public string  getRationalValueAsText()
      {
        Debug.Assert(flagHasRationalValue);
        if (textStoreRationalValue == "")
          {
            return Convert.ToString(storeRationalValue);
          }
        else
          {
            return (textStoreRationalValue);
          }
      }


    public virtual int extraStockAttributeValueComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockAttributeValueComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockAttributeValueComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockAttributeValueLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSpoken(string new_value)
      {
        flagHasSpoken = true;
        storeSpoken = new_value;
      }
    public void unsetSpoken()
      {
        flagHasSpoken = false;
      }
    public void setDisplay(string new_value)
      {
        flagHasDisplay = true;
        storeDisplay = new_value;
      }
    public void unsetDisplay()
      {
        flagHasDisplay = false;
      }
    public void setTable(string new_value)
      {
        flagHasTable = true;
        storeTable = new_value;
      }
    public void unsetTable()
      {
        flagHasTable = false;
      }
    public void setNative(string new_value)
      {
        flagHasNative = true;
        storeNative = new_value;
      }
    public void unsetNative()
      {
        flagHasNative = false;
      }
    public void setRationalValue(double new_value)
      {
        flagHasRationalValue = true;
        storeRationalValue = new_value;
        textStoreRationalValue = "";
      }
    public void setRationalValueText(string new_value)
      {
        flagHasRationalValue = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field RationalValue of StockAttributeValueJSON is not a valid number.");
        textStoreRationalValue = new_value;
      }
    public void unsetRationalValue()
      {
        flagHasRationalValue = false;
      }

    public virtual void extraStockAttributeValueAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockAttributeValueSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockAttributeValueLookup(key);
        if (old_field == null)
          {
            extraStockAttributeValueAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSpoken);
        if (flagHasSpoken)
          {
            handler.start_pair("Spoken");
            handler.string_value(storeSpoken);
          }
        Debug.Assert(partial_allowed || flagHasDisplay);
        if (flagHasDisplay)
          {
            handler.start_pair("Display");
            handler.string_value(storeDisplay);
          }
        if (flagHasTable)
          {
            handler.start_pair("Table");
            handler.string_value(storeTable);
          }
        Debug.Assert(partial_allowed || flagHasNative);
        if (flagHasNative)
          {
            handler.start_pair("Native");
            handler.string_value(storeNative);
          }
        Debug.Assert(partial_allowed || flagHasRationalValue);
        if (flagHasRationalValue)
          {
            handler.start_pair("RationalValue");
            if (textStoreRationalValue != "")
                handler.number_value(textStoreRationalValue);
            else if (((double)(long)storeRationalValue) == storeRationalValue)
                handler.number_value((long)storeRationalValue);
            else
                handler.number_value(storeRationalValue);
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
        if (!(hasSpoken()))
          {
            return "When parsing the object for %what%, the \"Spoken\" field was missing.";
          }
        if (!(hasDisplay()))
          {
            return "When parsing the object for %what%, the \"Display\" field was missing.";
          }
        if (!(hasNative()))
          {
            return "When parsing the object for %what%, the \"Native\" field was missing.";
          }
        if (!(hasRationalValue()))
          {
            return "When parsing the object for %what%, the \"RationalValue\" field was missing.";
          }
        return null;
      }

    public static StockAttributeValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockAttributeValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockAttributeValue", ignore_extras);
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
    public static StockAttributeValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockAttributeValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockAttributeValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockAttributeValue", ignore_extras);
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
    public static StockAttributeValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockAttributeValueJSON from_text(string text, bool ignore_extras)
      {
        StockAttributeValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockAttributeValue", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockAttributeValueJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockAttributeValueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockAttributeValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockAttributeValue", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSpoken;
        private JSONHoldingStringGenerator fieldGeneratorDisplay;
        private JSONHoldingStringGenerator fieldGeneratorTable;
        private JSONHoldingStringGenerator fieldGeneratorNative;
        private JSONHoldingNumberTextGenerator fieldGeneratorRationalValue;
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
            StockAttributeValueJSON result = new StockAttributeValueJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockAttributeValueAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockAttributeValueJSON result)
          {
            if (fieldGeneratorSpoken.have_value)
              {
                result.setSpoken(fieldGeneratorSpoken.value);
                fieldGeneratorSpoken.have_value = false;
              }
            else if ((!(result.hasSpoken())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Spoken\" field was missing.");
              }
            if (fieldGeneratorDisplay.have_value)
              {
                result.setDisplay(fieldGeneratorDisplay.value);
                fieldGeneratorDisplay.have_value = false;
              }
            else if ((!(result.hasDisplay())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Display\" field was missing.");
              }
            if (fieldGeneratorTable.have_value)
              {
                result.setTable(fieldGeneratorTable.value);
                fieldGeneratorTable.have_value = false;
              }
            if (fieldGeneratorNative.have_value)
              {
                result.setNative(fieldGeneratorNative.value);
                fieldGeneratorNative.have_value = false;
              }
            else if ((!(result.hasNative())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Native\" field was missing.");
              }
            if (fieldGeneratorRationalValue.have_value)
              {
                result.setRationalValueText(fieldGeneratorRationalValue.value);
                fieldGeneratorRationalValue.have_value = false;
              }
            else if ((!(result.hasRationalValue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RationalValue\" field was missing.");
              }
          }
        protected abstract void handle_result(StockAttributeValueJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "isplay", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorDisplay;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ative", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorNative;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ationalValue", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorRationalValue;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "poken", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorSpoken;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "able", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTable;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSpoken = new JSONHoldingStringGenerator("field \"Spoken\" of the StockAttributeValue class");
            fieldGeneratorDisplay = new JSONHoldingStringGenerator("field \"Display\" of the StockAttributeValue class");
            fieldGeneratorTable = new JSONHoldingStringGenerator("field \"Table\" of the StockAttributeValue class");
            fieldGeneratorNative = new JSONHoldingStringGenerator("field \"Native\" of the StockAttributeValue class");
            fieldGeneratorRationalValue = new JSONHoldingNumberTextGenerator("field \"RationalValue\" of the StockAttributeValue class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockAttributeValue class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpoken = new JSONHoldingStringGenerator("field \"Spoken\" of the StockAttributeValue class");
            fieldGeneratorDisplay = new JSONHoldingStringGenerator("field \"Display\" of the StockAttributeValue class");
            fieldGeneratorTable = new JSONHoldingStringGenerator("field \"Table\" of the StockAttributeValue class");
            fieldGeneratorNative = new JSONHoldingStringGenerator("field \"Native\" of the StockAttributeValue class");
            fieldGeneratorRationalValue = new JSONHoldingNumberTextGenerator("field \"RationalValue\" of the StockAttributeValue class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockAttributeValue class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSpoken.reset();
            fieldGeneratorDisplay.reset();
            fieldGeneratorTable.reset();
            fieldGeneratorNative.reset();
            fieldGeneratorRationalValue.reset();
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
        protected override void handle_result(StockAttributeValueJSON  result)
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
        public StockAttributeValueJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockAttributeValueJSON  result)
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
    protected virtual void handle_result(List<StockAttributeValueJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockAttributeValueJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockAttributeValueJSON>();
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
    public List<StockAttributeValueJSON> value;
  };
  };
