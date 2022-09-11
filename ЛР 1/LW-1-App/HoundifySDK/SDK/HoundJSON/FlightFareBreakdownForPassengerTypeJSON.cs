/* file "FlightFareBreakdownForPassengerTypeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightFareBreakdownForPassengerTypeJSON : JSONBase
  {
    private bool flagHasPassengerTypeWithCount;
    private FlightPassengerTypeCountJSON  storePassengerTypeWithCount;
    private bool flagHasTotalFare;
    private double storeTotalFare;
    private string textStoreTotalFare;
    private bool flagHasBaseFare;
    private double storeBaseFare;
    private string textStoreBaseFare;
    private bool flagHasTaxesandFees;
    private double storeTaxesandFees;
    private string textStoreTaxesandFees;
    private bool flagHasFees;
    private double storeFees;
    private string textStoreFees;
    private bool flagHasDiscount;
    private double storeDiscount;
    private string textStoreDiscount;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPassengerTypeWithCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightPassengerTypeCountJSON convert_classy = FlightPassengerTypeCountJSON.from_json(json_value, ignore_extras, true);
        setPassengerTypeWithCount(convert_classy);
      }


    private void  fromJSONTotalFare(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TotalFare of FlightFareBreakdownForPassengerTypeJSON is not a number.");
              }
          }
        setTotalFareText(the_rational_text);
      }


    private void  fromJSONBaseFare(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field BaseFare of FlightFareBreakdownForPassengerTypeJSON is not a number.");
              }
          }
        setBaseFareText(the_rational_text);
      }


    private void  fromJSONTaxesandFees(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TaxesandFees of FlightFareBreakdownForPassengerTypeJSON is not a number.");
              }
          }
        setTaxesandFeesText(the_rational_text);
      }


    private void  fromJSONFees(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Fees of FlightFareBreakdownForPassengerTypeJSON is not a number.");
              }
          }
        setFeesText(the_rational_text);
      }


    private void  fromJSONDiscount(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Discount of FlightFareBreakdownForPassengerTypeJSON is not a number.");
              }
          }
        setDiscountText(the_rational_text);
      }


    public FlightFareBreakdownForPassengerTypeJSON()
      {
        flagHasPassengerTypeWithCount = false;
        flagHasTotalFare = false;
        flagHasBaseFare = false;
        flagHasTaxesandFees = false;
        flagHasFees = false;
        flagHasDiscount = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPassengerTypeWithCount()
      {
        return flagHasPassengerTypeWithCount;
      }

    public FlightPassengerTypeCountJSON   getPassengerTypeWithCount()
      {
        Debug.Assert(flagHasPassengerTypeWithCount);
        return storePassengerTypeWithCount;
      }

    public bool  hasTotalFare()
      {
        return flagHasTotalFare;
      }

    public double  getTotalFare()
      {
        Debug.Assert(flagHasTotalFare);
        if (textStoreTotalFare != "")
          {
            return Double.Parse(textStoreTotalFare);
          }
        return storeTotalFare;
      }

    public string  getTotalFareAsText()
      {
        Debug.Assert(flagHasTotalFare);
        if (textStoreTotalFare == "")
          {
            return Convert.ToString(storeTotalFare);
          }
        else
          {
            return (textStoreTotalFare);
          }
      }

    public bool  hasBaseFare()
      {
        return flagHasBaseFare;
      }

    public double  getBaseFare()
      {
        Debug.Assert(flagHasBaseFare);
        if (textStoreBaseFare != "")
          {
            return Double.Parse(textStoreBaseFare);
          }
        return storeBaseFare;
      }

    public string  getBaseFareAsText()
      {
        Debug.Assert(flagHasBaseFare);
        if (textStoreBaseFare == "")
          {
            return Convert.ToString(storeBaseFare);
          }
        else
          {
            return (textStoreBaseFare);
          }
      }

    public bool  hasTaxesandFees()
      {
        return flagHasTaxesandFees;
      }

    public double  getTaxesandFees()
      {
        Debug.Assert(flagHasTaxesandFees);
        if (textStoreTaxesandFees != "")
          {
            return Double.Parse(textStoreTaxesandFees);
          }
        return storeTaxesandFees;
      }

    public string  getTaxesandFeesAsText()
      {
        Debug.Assert(flagHasTaxesandFees);
        if (textStoreTaxesandFees == "")
          {
            return Convert.ToString(storeTaxesandFees);
          }
        else
          {
            return (textStoreTaxesandFees);
          }
      }

    public bool  hasFees()
      {
        return flagHasFees;
      }

    public double  getFees()
      {
        Debug.Assert(flagHasFees);
        if (textStoreFees != "")
          {
            return Double.Parse(textStoreFees);
          }
        return storeFees;
      }

    public string  getFeesAsText()
      {
        Debug.Assert(flagHasFees);
        if (textStoreFees == "")
          {
            return Convert.ToString(storeFees);
          }
        else
          {
            return (textStoreFees);
          }
      }

    public bool  hasDiscount()
      {
        return flagHasDiscount;
      }

    public double  getDiscount()
      {
        Debug.Assert(flagHasDiscount);
        if (textStoreDiscount != "")
          {
            return Double.Parse(textStoreDiscount);
          }
        return storeDiscount;
      }

    public string  getDiscountAsText()
      {
        Debug.Assert(flagHasDiscount);
        if (textStoreDiscount == "")
          {
            return Convert.ToString(storeDiscount);
          }
        else
          {
            return (textStoreDiscount);
          }
      }


    public virtual int extraFlightFareBreakdownForPassengerTypeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightFareBreakdownForPassengerTypeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightFareBreakdownForPassengerTypeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightFareBreakdownForPassengerTypeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPassengerTypeWithCount(FlightPassengerTypeCountJSON  new_value)
      {
        if (flagHasPassengerTypeWithCount)
          {
          }
        flagHasPassengerTypeWithCount = true;
        storePassengerTypeWithCount = new_value;
      }
    public void unsetPassengerTypeWithCount()
      {
        if (flagHasPassengerTypeWithCount)
          {
          }
        flagHasPassengerTypeWithCount = false;
      }
    public void setTotalFare(double new_value)
      {
        flagHasTotalFare = true;
        storeTotalFare = new_value;
        textStoreTotalFare = "";
      }
    public void setTotalFareText(string new_value)
      {
        flagHasTotalFare = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TotalFare of FlightFareBreakdownForPassengerTypeJSON is not a valid number.");
        textStoreTotalFare = new_value;
      }
    public void unsetTotalFare()
      {
        flagHasTotalFare = false;
      }
    public void setBaseFare(double new_value)
      {
        flagHasBaseFare = true;
        storeBaseFare = new_value;
        textStoreBaseFare = "";
      }
    public void setBaseFareText(string new_value)
      {
        flagHasBaseFare = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field BaseFare of FlightFareBreakdownForPassengerTypeJSON is not a valid number.");
        textStoreBaseFare = new_value;
      }
    public void unsetBaseFare()
      {
        flagHasBaseFare = false;
      }
    public void setTaxesandFees(double new_value)
      {
        flagHasTaxesandFees = true;
        storeTaxesandFees = new_value;
        textStoreTaxesandFees = "";
      }
    public void setTaxesandFeesText(string new_value)
      {
        flagHasTaxesandFees = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TaxesandFees of FlightFareBreakdownForPassengerTypeJSON is not a valid number.");
        textStoreTaxesandFees = new_value;
      }
    public void unsetTaxesandFees()
      {
        flagHasTaxesandFees = false;
      }
    public void setFees(double new_value)
      {
        flagHasFees = true;
        storeFees = new_value;
        textStoreFees = "";
      }
    public void setFeesText(string new_value)
      {
        flagHasFees = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Fees of FlightFareBreakdownForPassengerTypeJSON is not a valid number.");
        textStoreFees = new_value;
      }
    public void unsetFees()
      {
        flagHasFees = false;
      }
    public void setDiscount(double new_value)
      {
        flagHasDiscount = true;
        storeDiscount = new_value;
        textStoreDiscount = "";
      }
    public void setDiscountText(string new_value)
      {
        flagHasDiscount = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Discount of FlightFareBreakdownForPassengerTypeJSON is not a valid number.");
        textStoreDiscount = new_value;
      }
    public void unsetDiscount()
      {
        flagHasDiscount = false;
      }

    public virtual void extraFlightFareBreakdownForPassengerTypeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightFareBreakdownForPassengerTypeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightFareBreakdownForPassengerTypeLookup(key);
        if (old_field == null)
          {
            extraFlightFareBreakdownForPassengerTypeAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPassengerTypeWithCount);
        if (flagHasPassengerTypeWithCount)
          {
            handler.start_pair("PassengerTypeWithCount");
            if (partial_allowed)
                storePassengerTypeWithCount.write_partial_as_json(handler);
            else
                storePassengerTypeWithCount.write_as_json(handler);
          }
        if (flagHasTotalFare)
          {
            handler.start_pair("TotalFare");
            if (textStoreTotalFare != "")
                handler.number_value(textStoreTotalFare);
            else if (((double)(long)storeTotalFare) == storeTotalFare)
                handler.number_value((long)storeTotalFare);
            else
                handler.number_value(storeTotalFare);
          }
        if (flagHasBaseFare)
          {
            handler.start_pair("BaseFare");
            if (textStoreBaseFare != "")
                handler.number_value(textStoreBaseFare);
            else if (((double)(long)storeBaseFare) == storeBaseFare)
                handler.number_value((long)storeBaseFare);
            else
                handler.number_value(storeBaseFare);
          }
        if (flagHasTaxesandFees)
          {
            handler.start_pair("TaxesandFees");
            if (textStoreTaxesandFees != "")
                handler.number_value(textStoreTaxesandFees);
            else if (((double)(long)storeTaxesandFees) == storeTaxesandFees)
                handler.number_value((long)storeTaxesandFees);
            else
                handler.number_value(storeTaxesandFees);
          }
        if (flagHasFees)
          {
            handler.start_pair("Fees");
            if (textStoreFees != "")
                handler.number_value(textStoreFees);
            else if (((double)(long)storeFees) == storeFees)
                handler.number_value((long)storeFees);
            else
                handler.number_value(storeFees);
          }
        if (flagHasDiscount)
          {
            handler.start_pair("Discount");
            if (textStoreDiscount != "")
                handler.number_value(textStoreDiscount);
            else if (((double)(long)storeDiscount) == storeDiscount)
                handler.number_value((long)storeDiscount);
            else
                handler.number_value(storeDiscount);
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
        if (!(hasPassengerTypeWithCount()))
          {
            return "When parsing the object for %what%, the \"PassengerTypeWithCount\" field was missing.";
          }
        return null;
      }

    public static FlightFareBreakdownForPassengerTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightFareBreakdownForPassengerTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightFareBreakdownForPassengerType", ignore_extras);
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
    public static FlightFareBreakdownForPassengerTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightFareBreakdownForPassengerTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightFareBreakdownForPassengerTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightFareBreakdownForPassengerType", ignore_extras);
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
    public static FlightFareBreakdownForPassengerTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightFareBreakdownForPassengerTypeJSON from_text(string text, bool ignore_extras)
      {
        FlightFareBreakdownForPassengerTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightFareBreakdownForPassengerType", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightFareBreakdownForPassengerTypeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightFareBreakdownForPassengerTypeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightFareBreakdownForPassengerTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightFareBreakdownForPassengerType", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private FlightPassengerTypeCountJSON.HoldingGenerator fieldGeneratorPassengerTypeWithCount;
        private JSONHoldingNumberTextGenerator fieldGeneratorTotalFare;
        private JSONHoldingNumberTextGenerator fieldGeneratorBaseFare;
        private JSONHoldingNumberTextGenerator fieldGeneratorTaxesandFees;
        private JSONHoldingNumberTextGenerator fieldGeneratorFees;
        private JSONHoldingNumberTextGenerator fieldGeneratorDiscount;
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
            FlightFareBreakdownForPassengerTypeJSON result = new FlightFareBreakdownForPassengerTypeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightFareBreakdownForPassengerTypeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightFareBreakdownForPassengerTypeJSON result)
          {
            if (fieldGeneratorPassengerTypeWithCount.have_value)
              {
                result.setPassengerTypeWithCount(fieldGeneratorPassengerTypeWithCount.value);
                fieldGeneratorPassengerTypeWithCount.have_value = false;
              }
            else if ((!(result.hasPassengerTypeWithCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PassengerTypeWithCount\" field was missing.");
              }
            if (fieldGeneratorTotalFare.have_value)
              {
                result.setTotalFareText(fieldGeneratorTotalFare.value);
                fieldGeneratorTotalFare.have_value = false;
              }
            if (fieldGeneratorBaseFare.have_value)
              {
                result.setBaseFareText(fieldGeneratorBaseFare.value);
                fieldGeneratorBaseFare.have_value = false;
              }
            if (fieldGeneratorTaxesandFees.have_value)
              {
                result.setTaxesandFeesText(fieldGeneratorTaxesandFees.value);
                fieldGeneratorTaxesandFees.have_value = false;
              }
            if (fieldGeneratorFees.have_value)
              {
                result.setFeesText(fieldGeneratorFees.value);
                fieldGeneratorFees.have_value = false;
              }
            if (fieldGeneratorDiscount.have_value)
              {
                result.setDiscountText(fieldGeneratorDiscount.value);
                fieldGeneratorDiscount.have_value = false;
              }
          }
        protected abstract void handle_result(FlightFareBreakdownForPassengerTypeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "aseFare", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorBaseFare;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "iscount", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorDiscount;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "ees", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorFees;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "assengerTypeWithCount", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorPassengerTypeWithCount;
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "xesandFees", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorTaxesandFees;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "talFare", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorTotalFare;
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
            fieldGeneratorPassengerTypeWithCount = new FlightPassengerTypeCountJSON.HoldingGenerator("field \"PassengerTypeWithCount\" of the FlightFareBreakdownForPassengerType class", ignore_extras);
            fieldGeneratorTotalFare = new JSONHoldingNumberTextGenerator("field \"TotalFare\" of the FlightFareBreakdownForPassengerType class");
            fieldGeneratorBaseFare = new JSONHoldingNumberTextGenerator("field \"BaseFare\" of the FlightFareBreakdownForPassengerType class");
            fieldGeneratorTaxesandFees = new JSONHoldingNumberTextGenerator("field \"TaxesandFees\" of the FlightFareBreakdownForPassengerType class");
            fieldGeneratorFees = new JSONHoldingNumberTextGenerator("field \"Fees\" of the FlightFareBreakdownForPassengerType class");
            fieldGeneratorDiscount = new JSONHoldingNumberTextGenerator("field \"Discount\" of the FlightFareBreakdownForPassengerType class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightFareBreakdownForPassengerType class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPassengerTypeWithCount = new FlightPassengerTypeCountJSON.HoldingGenerator("field \"PassengerTypeWithCount\" of the FlightFareBreakdownForPassengerType class", false);
            fieldGeneratorTotalFare = new JSONHoldingNumberTextGenerator("field \"TotalFare\" of the FlightFareBreakdownForPassengerType class");
            fieldGeneratorBaseFare = new JSONHoldingNumberTextGenerator("field \"BaseFare\" of the FlightFareBreakdownForPassengerType class");
            fieldGeneratorTaxesandFees = new JSONHoldingNumberTextGenerator("field \"TaxesandFees\" of the FlightFareBreakdownForPassengerType class");
            fieldGeneratorFees = new JSONHoldingNumberTextGenerator("field \"Fees\" of the FlightFareBreakdownForPassengerType class");
            fieldGeneratorDiscount = new JSONHoldingNumberTextGenerator("field \"Discount\" of the FlightFareBreakdownForPassengerType class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightFareBreakdownForPassengerType class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPassengerTypeWithCount.reset();
            fieldGeneratorTotalFare.reset();
            fieldGeneratorBaseFare.reset();
            fieldGeneratorTaxesandFees.reset();
            fieldGeneratorFees.reset();
            fieldGeneratorDiscount.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPassengerTypeWithCount.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPassengerTypeWithCount.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightFareBreakdownForPassengerTypeJSON  result)
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
        public FlightFareBreakdownForPassengerTypeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightFareBreakdownForPassengerTypeJSON  result)
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
    protected virtual void handle_result(List<FlightFareBreakdownForPassengerTypeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightFareBreakdownForPassengerTypeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightFareBreakdownForPassengerTypeJSON>();
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
    public List<FlightFareBreakdownForPassengerTypeJSON> value;
  };
  };
