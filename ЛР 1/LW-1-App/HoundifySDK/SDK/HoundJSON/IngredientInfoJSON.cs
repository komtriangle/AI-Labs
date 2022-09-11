/* file "IngredientInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class IngredientInfoJSON : JSONBase
  {
    private bool flagHasIngredientID;
    private BigInteger storeIngredientID;
    private bool flagHasIsHeading;
    private bool storeIsHeading;
    private bool flagHasName;
    private string storeName;
    private bool flagHasHTMLName;
    private string storeHTMLName;
    private bool flagHasQuantity;
    private double storeQuantity;
    private string textStoreQuantity;
    private bool flagHasDisplayQuantity;
    private string storeDisplayQuantity;
    private bool flagHasUnit;
    private string storeUnit;
    private bool flagHasMetricQuantity;
    private double storeMetricQuantity;
    private string textStoreMetricQuantity;
    private bool flagHasMetricDisplayQuantity;
    private string storeMetricDisplayQuantity;
    private bool flagHasMetricUnit;
    private string storeMetricUnit;
    private bool flagHasPreparationNotes;
    private string storePreparationNotes;
    private bool flagHasDepartment;
    private string storeDepartment;
    private bool flagHasUsuallyOnHand;
    private bool storeUsuallyOnHand;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONIngredientID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field IngredientID of IngredientInfoJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field IngredientID of IngredientInfoJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setIngredientID(extracted_integer);
      }


    private void  fromJSONIsHeading(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsHeading of IngredientInfoJSON is not true for false.");
              }
          }
        setIsHeading(the_bool);
      }


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of IngredientInfoJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONHTMLName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HTMLName of IngredientInfoJSON is not a string.");
        setHTMLName(json_string.getData());
      }


    private void  fromJSONQuantity(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Quantity of IngredientInfoJSON is not a number.");
              }
          }
        setQuantityText(the_rational_text);
      }


    private void  fromJSONDisplayQuantity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayQuantity of IngredientInfoJSON is not a string.");
        setDisplayQuantity(json_string.getData());
      }


    private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Unit of IngredientInfoJSON is not a string.");
        setUnit(json_string.getData());
      }


    private void  fromJSONMetricQuantity(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MetricQuantity of IngredientInfoJSON is not a number.");
              }
          }
        setMetricQuantityText(the_rational_text);
      }


    private void  fromJSONMetricDisplayQuantity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MetricDisplayQuantity of IngredientInfoJSON is not a string.");
        setMetricDisplayQuantity(json_string.getData());
      }


    private void  fromJSONMetricUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MetricUnit of IngredientInfoJSON is not a string.");
        setMetricUnit(json_string.getData());
      }


    private void  fromJSONPreparationNotes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PreparationNotes of IngredientInfoJSON is not a string.");
        setPreparationNotes(json_string.getData());
      }


    private void  fromJSONDepartment(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Department of IngredientInfoJSON is not a string.");
        setDepartment(json_string.getData());
      }


    private void  fromJSONUsuallyOnHand(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UsuallyOnHand of IngredientInfoJSON is not true for false.");
              }
          }
        setUsuallyOnHand(the_bool);
      }


    public IngredientInfoJSON()
      {
        flagHasIngredientID = false;
        flagHasIsHeading = false;
        flagHasName = false;
        flagHasHTMLName = false;
        flagHasQuantity = false;
        flagHasDisplayQuantity = false;
        flagHasUnit = false;
        flagHasMetricQuantity = false;
        flagHasMetricDisplayQuantity = false;
        flagHasMetricUnit = false;
        flagHasPreparationNotes = false;
        flagHasDepartment = false;
        flagHasUsuallyOnHand = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasIngredientID()
      {
        return flagHasIngredientID;
      }

    public BigInteger  getIngredientID()
      {
        Debug.Assert(flagHasIngredientID);
        return storeIngredientID;
      }

    public bool  hasIsHeading()
      {
        return flagHasIsHeading;
      }

    public bool  getIsHeading()
      {
        Debug.Assert(flagHasIsHeading);
        return storeIsHeading;
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public bool  hasHTMLName()
      {
        return flagHasHTMLName;
      }

    public string  getHTMLName()
      {
        Debug.Assert(flagHasHTMLName);
        return storeHTMLName;
      }

    public bool  hasQuantity()
      {
        return flagHasQuantity;
      }

    public double  getQuantity()
      {
        Debug.Assert(flagHasQuantity);
        if (textStoreQuantity != "")
          {
            return Double.Parse(textStoreQuantity);
          }
        return storeQuantity;
      }

    public string  getQuantityAsText()
      {
        Debug.Assert(flagHasQuantity);
        if (textStoreQuantity == "")
          {
            return Convert.ToString(storeQuantity);
          }
        else
          {
            return (textStoreQuantity);
          }
      }

    public bool  hasDisplayQuantity()
      {
        return flagHasDisplayQuantity;
      }

    public string  getDisplayQuantity()
      {
        Debug.Assert(flagHasDisplayQuantity);
        return storeDisplayQuantity;
      }

    public bool  hasUnit()
      {
        return flagHasUnit;
      }

    public string  getUnit()
      {
        Debug.Assert(flagHasUnit);
        return storeUnit;
      }

    public bool  hasMetricQuantity()
      {
        return flagHasMetricQuantity;
      }

    public double  getMetricQuantity()
      {
        Debug.Assert(flagHasMetricQuantity);
        if (textStoreMetricQuantity != "")
          {
            return Double.Parse(textStoreMetricQuantity);
          }
        return storeMetricQuantity;
      }

    public string  getMetricQuantityAsText()
      {
        Debug.Assert(flagHasMetricQuantity);
        if (textStoreMetricQuantity == "")
          {
            return Convert.ToString(storeMetricQuantity);
          }
        else
          {
            return (textStoreMetricQuantity);
          }
      }

    public bool  hasMetricDisplayQuantity()
      {
        return flagHasMetricDisplayQuantity;
      }

    public string  getMetricDisplayQuantity()
      {
        Debug.Assert(flagHasMetricDisplayQuantity);
        return storeMetricDisplayQuantity;
      }

    public bool  hasMetricUnit()
      {
        return flagHasMetricUnit;
      }

    public string  getMetricUnit()
      {
        Debug.Assert(flagHasMetricUnit);
        return storeMetricUnit;
      }

    public bool  hasPreparationNotes()
      {
        return flagHasPreparationNotes;
      }

    public string  getPreparationNotes()
      {
        Debug.Assert(flagHasPreparationNotes);
        return storePreparationNotes;
      }

    public bool  hasDepartment()
      {
        return flagHasDepartment;
      }

    public string  getDepartment()
      {
        Debug.Assert(flagHasDepartment);
        return storeDepartment;
      }

    public bool  hasUsuallyOnHand()
      {
        return flagHasUsuallyOnHand;
      }

    public bool  getUsuallyOnHand()
      {
        Debug.Assert(flagHasUsuallyOnHand);
        return storeUsuallyOnHand;
      }


    public virtual int extraIngredientInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIngredientInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIngredientInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIngredientInfoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setIngredientID(BigInteger new_value)
      {
        flagHasIngredientID = true;
        if (new_value < 0)
            throw new Exception("The value for field IngredientID of IngredientInfoJSON is less than the lower bound (0) for that field.");
        storeIngredientID = new_value;
      }
    public void unsetIngredientID()
      {
        flagHasIngredientID = false;
      }
    public void setIsHeading(bool new_value)
      {
        flagHasIsHeading = true;
        storeIsHeading = new_value;
      }
    public void unsetIsHeading()
      {
        flagHasIsHeading = false;
      }
    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setHTMLName(string new_value)
      {
        flagHasHTMLName = true;
        storeHTMLName = new_value;
      }
    public void unsetHTMLName()
      {
        flagHasHTMLName = false;
      }
    public void setQuantity(double new_value)
      {
        flagHasQuantity = true;
        storeQuantity = new_value;
        textStoreQuantity = "";
      }
    public void setQuantityText(string new_value)
      {
        flagHasQuantity = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Quantity of IngredientInfoJSON is not a valid number.");
        textStoreQuantity = new_value;
      }
    public void unsetQuantity()
      {
        flagHasQuantity = false;
      }
    public void setDisplayQuantity(string new_value)
      {
        flagHasDisplayQuantity = true;
        storeDisplayQuantity = new_value;
      }
    public void unsetDisplayQuantity()
      {
        flagHasDisplayQuantity = false;
      }
    public void setUnit(string new_value)
      {
        flagHasUnit = true;
        storeUnit = new_value;
      }
    public void unsetUnit()
      {
        flagHasUnit = false;
      }
    public void setMetricQuantity(double new_value)
      {
        flagHasMetricQuantity = true;
        storeMetricQuantity = new_value;
        textStoreMetricQuantity = "";
      }
    public void setMetricQuantityText(string new_value)
      {
        flagHasMetricQuantity = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field MetricQuantity of IngredientInfoJSON is not a valid number.");
        textStoreMetricQuantity = new_value;
      }
    public void unsetMetricQuantity()
      {
        flagHasMetricQuantity = false;
      }
    public void setMetricDisplayQuantity(string new_value)
      {
        flagHasMetricDisplayQuantity = true;
        storeMetricDisplayQuantity = new_value;
      }
    public void unsetMetricDisplayQuantity()
      {
        flagHasMetricDisplayQuantity = false;
      }
    public void setMetricUnit(string new_value)
      {
        flagHasMetricUnit = true;
        storeMetricUnit = new_value;
      }
    public void unsetMetricUnit()
      {
        flagHasMetricUnit = false;
      }
    public void setPreparationNotes(string new_value)
      {
        flagHasPreparationNotes = true;
        storePreparationNotes = new_value;
      }
    public void unsetPreparationNotes()
      {
        flagHasPreparationNotes = false;
      }
    public void setDepartment(string new_value)
      {
        flagHasDepartment = true;
        storeDepartment = new_value;
      }
    public void unsetDepartment()
      {
        flagHasDepartment = false;
      }
    public void setUsuallyOnHand(bool new_value)
      {
        flagHasUsuallyOnHand = true;
        storeUsuallyOnHand = new_value;
      }
    public void unsetUsuallyOnHand()
      {
        flagHasUsuallyOnHand = false;
      }

    public virtual void extraIngredientInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIngredientInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIngredientInfoLookup(key);
        if (old_field == null)
          {
            extraIngredientInfoAppendPair(key, new_component);
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
        if (flagHasIngredientID)
          {
            handler.start_pair("IngredientID");
            handler.number_value(storeIngredientID);
          }
        if (flagHasIsHeading)
          {
            handler.start_pair("IsHeading");
            handler.boolean_value(storeIsHeading);
          }
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        if (flagHasHTMLName)
          {
            handler.start_pair("HTMLName");
            handler.string_value(storeHTMLName);
          }
        if (flagHasQuantity)
          {
            handler.start_pair("Quantity");
            if (textStoreQuantity != "")
                handler.number_value(textStoreQuantity);
            else if (((double)(long)storeQuantity) == storeQuantity)
                handler.number_value((long)storeQuantity);
            else
                handler.number_value(storeQuantity);
          }
        if (flagHasDisplayQuantity)
          {
            handler.start_pair("DisplayQuantity");
            handler.string_value(storeDisplayQuantity);
          }
        if (flagHasUnit)
          {
            handler.start_pair("Unit");
            handler.string_value(storeUnit);
          }
        if (flagHasMetricQuantity)
          {
            handler.start_pair("MetricQuantity");
            if (textStoreMetricQuantity != "")
                handler.number_value(textStoreMetricQuantity);
            else if (((double)(long)storeMetricQuantity) == storeMetricQuantity)
                handler.number_value((long)storeMetricQuantity);
            else
                handler.number_value(storeMetricQuantity);
          }
        if (flagHasMetricDisplayQuantity)
          {
            handler.start_pair("MetricDisplayQuantity");
            handler.string_value(storeMetricDisplayQuantity);
          }
        if (flagHasMetricUnit)
          {
            handler.start_pair("MetricUnit");
            handler.string_value(storeMetricUnit);
          }
        if (flagHasPreparationNotes)
          {
            handler.start_pair("PreparationNotes");
            handler.string_value(storePreparationNotes);
          }
        if (flagHasDepartment)
          {
            handler.start_pair("Department");
            handler.string_value(storeDepartment);
          }
        if (flagHasUsuallyOnHand)
          {
            handler.start_pair("UsuallyOnHand");
            handler.boolean_value(storeUsuallyOnHand);
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

    public static IngredientInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IngredientInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IngredientInfo", ignore_extras);
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
    public static IngredientInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IngredientInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IngredientInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IngredientInfo", ignore_extras);
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
    public static IngredientInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IngredientInfoJSON from_text(string text, bool ignore_extras)
      {
        IngredientInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IngredientInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IngredientInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IngredientInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IngredientInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IngredientInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorIngredientID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorIngredientID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorIngredientID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorIngredientID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorIngredientID fieldGeneratorIngredientID;
        private JSONHoldingBooleanGenerator fieldGeneratorIsHeading;
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorHTMLName;
        private JSONHoldingNumberTextGenerator fieldGeneratorQuantity;
        private JSONHoldingStringGenerator fieldGeneratorDisplayQuantity;
        private JSONHoldingStringGenerator fieldGeneratorUnit;
        private JSONHoldingNumberTextGenerator fieldGeneratorMetricQuantity;
        private JSONHoldingStringGenerator fieldGeneratorMetricDisplayQuantity;
        private JSONHoldingStringGenerator fieldGeneratorMetricUnit;
        private JSONHoldingStringGenerator fieldGeneratorPreparationNotes;
        private JSONHoldingStringGenerator fieldGeneratorDepartment;
        private JSONHoldingBooleanGenerator fieldGeneratorUsuallyOnHand;
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
            IngredientInfoJSON result = new IngredientInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIngredientInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IngredientInfoJSON result)
          {
            if (fieldGeneratorIngredientID.have_value)
              {
                result.setIngredientID(fieldGeneratorIngredientID.value);
                fieldGeneratorIngredientID.have_value = false;
              }
            if (fieldGeneratorIsHeading.have_value)
              {
                result.setIsHeading(fieldGeneratorIsHeading.value);
                fieldGeneratorIsHeading.have_value = false;
              }
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            if (fieldGeneratorHTMLName.have_value)
              {
                result.setHTMLName(fieldGeneratorHTMLName.value);
                fieldGeneratorHTMLName.have_value = false;
              }
            if (fieldGeneratorQuantity.have_value)
              {
                result.setQuantityText(fieldGeneratorQuantity.value);
                fieldGeneratorQuantity.have_value = false;
              }
            if (fieldGeneratorDisplayQuantity.have_value)
              {
                result.setDisplayQuantity(fieldGeneratorDisplayQuantity.value);
                fieldGeneratorDisplayQuantity.have_value = false;
              }
            if (fieldGeneratorUnit.have_value)
              {
                result.setUnit(fieldGeneratorUnit.value);
                fieldGeneratorUnit.have_value = false;
              }
            if (fieldGeneratorMetricQuantity.have_value)
              {
                result.setMetricQuantityText(fieldGeneratorMetricQuantity.value);
                fieldGeneratorMetricQuantity.have_value = false;
              }
            if (fieldGeneratorMetricDisplayQuantity.have_value)
              {
                result.setMetricDisplayQuantity(fieldGeneratorMetricDisplayQuantity.value);
                fieldGeneratorMetricDisplayQuantity.have_value = false;
              }
            if (fieldGeneratorMetricUnit.have_value)
              {
                result.setMetricUnit(fieldGeneratorMetricUnit.value);
                fieldGeneratorMetricUnit.have_value = false;
              }
            if (fieldGeneratorPreparationNotes.have_value)
              {
                result.setPreparationNotes(fieldGeneratorPreparationNotes.value);
                fieldGeneratorPreparationNotes.have_value = false;
              }
            if (fieldGeneratorDepartment.have_value)
              {
                result.setDepartment(fieldGeneratorDepartment.value);
                fieldGeneratorDepartment.have_value = false;
              }
            if (fieldGeneratorUsuallyOnHand.have_value)
              {
                result.setUsuallyOnHand(fieldGeneratorUsuallyOnHand.value);
                fieldGeneratorUsuallyOnHand.have_value = false;
              }
          }
        protected abstract void handle_result(IngredientInfoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "partment", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorDepartment;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "splayQuantity", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorDisplayQuantity;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "TMLName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorHTMLName;
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'n':
                            if ((String.Compare(field_name, 2, "gredientID", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorIngredientID;
                            break;
                        case 's':
                            if ((String.Compare(field_name, 2, "Heading", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorIsHeading;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "etric", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 7, "isplayQuantity", 0, 14, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorMetricDisplayQuantity;
                                break;
                            case 'Q':
                                if ((String.Compare(field_name, 7, "uantity", 0, 7, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorMetricQuantity;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 7, "nit", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorMetricUnit;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "reparationNotes", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorPreparationNotes;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "uantity", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorQuantity;
                    break;
                case 'U':
                    switch (field_name[1])
                      {
                        case 'n':
                            if ((String.Compare(field_name, 2, "it", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorUnit;
                            break;
                        case 's':
                            if ((String.Compare(field_name, 2, "uallyOnHand", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorUsuallyOnHand;
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
            fieldGeneratorIngredientID = new FieldHoldingGeneratorIngredientID("field \"IngredientID\" of the IngredientInfo class");
            fieldGeneratorIsHeading = new JSONHoldingBooleanGenerator("field \"IsHeading\" of the IngredientInfo class");
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the IngredientInfo class");
            fieldGeneratorHTMLName = new JSONHoldingStringGenerator("field \"HTMLName\" of the IngredientInfo class");
            fieldGeneratorQuantity = new JSONHoldingNumberTextGenerator("field \"Quantity\" of the IngredientInfo class");
            fieldGeneratorDisplayQuantity = new JSONHoldingStringGenerator("field \"DisplayQuantity\" of the IngredientInfo class");
            fieldGeneratorUnit = new JSONHoldingStringGenerator("field \"Unit\" of the IngredientInfo class");
            fieldGeneratorMetricQuantity = new JSONHoldingNumberTextGenerator("field \"MetricQuantity\" of the IngredientInfo class");
            fieldGeneratorMetricDisplayQuantity = new JSONHoldingStringGenerator("field \"MetricDisplayQuantity\" of the IngredientInfo class");
            fieldGeneratorMetricUnit = new JSONHoldingStringGenerator("field \"MetricUnit\" of the IngredientInfo class");
            fieldGeneratorPreparationNotes = new JSONHoldingStringGenerator("field \"PreparationNotes\" of the IngredientInfo class");
            fieldGeneratorDepartment = new JSONHoldingStringGenerator("field \"Department\" of the IngredientInfo class");
            fieldGeneratorUsuallyOnHand = new JSONHoldingBooleanGenerator("field \"UsuallyOnHand\" of the IngredientInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IngredientInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorIngredientID = new FieldHoldingGeneratorIngredientID("field \"IngredientID\" of the IngredientInfo class");
            fieldGeneratorIsHeading = new JSONHoldingBooleanGenerator("field \"IsHeading\" of the IngredientInfo class");
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the IngredientInfo class");
            fieldGeneratorHTMLName = new JSONHoldingStringGenerator("field \"HTMLName\" of the IngredientInfo class");
            fieldGeneratorQuantity = new JSONHoldingNumberTextGenerator("field \"Quantity\" of the IngredientInfo class");
            fieldGeneratorDisplayQuantity = new JSONHoldingStringGenerator("field \"DisplayQuantity\" of the IngredientInfo class");
            fieldGeneratorUnit = new JSONHoldingStringGenerator("field \"Unit\" of the IngredientInfo class");
            fieldGeneratorMetricQuantity = new JSONHoldingNumberTextGenerator("field \"MetricQuantity\" of the IngredientInfo class");
            fieldGeneratorMetricDisplayQuantity = new JSONHoldingStringGenerator("field \"MetricDisplayQuantity\" of the IngredientInfo class");
            fieldGeneratorMetricUnit = new JSONHoldingStringGenerator("field \"MetricUnit\" of the IngredientInfo class");
            fieldGeneratorPreparationNotes = new JSONHoldingStringGenerator("field \"PreparationNotes\" of the IngredientInfo class");
            fieldGeneratorDepartment = new JSONHoldingStringGenerator("field \"Department\" of the IngredientInfo class");
            fieldGeneratorUsuallyOnHand = new JSONHoldingBooleanGenerator("field \"UsuallyOnHand\" of the IngredientInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IngredientInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorIngredientID.reset();
            fieldGeneratorIsHeading.reset();
            fieldGeneratorName.reset();
            fieldGeneratorHTMLName.reset();
            fieldGeneratorQuantity.reset();
            fieldGeneratorDisplayQuantity.reset();
            fieldGeneratorUnit.reset();
            fieldGeneratorMetricQuantity.reset();
            fieldGeneratorMetricDisplayQuantity.reset();
            fieldGeneratorMetricUnit.reset();
            fieldGeneratorPreparationNotes.reset();
            fieldGeneratorDepartment.reset();
            fieldGeneratorUsuallyOnHand.reset();
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
        protected override void handle_result(IngredientInfoJSON  result)
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
        public IngredientInfoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IngredientInfoJSON  result)
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
    protected virtual void handle_result(List<IngredientInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IngredientInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IngredientInfoJSON>();
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
    public List<IngredientInfoJSON> value;
  };
  };
