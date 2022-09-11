/* file "NutrientJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class NutrientJSON : JSONBase
  {
    private bool flagHasID;
    private BigInteger storeID;
    private bool flagHasAmountPer100g;
    private double storeAmountPer100g;
    private string textStoreAmountPer100g;
    private bool flagHasRDIPer100g;
    private double storeRDIPer100g;
    private string textStoreRDIPer100g;
    private bool flagHasSpokenName;
    private string storeSpokenName;
    private bool flagHasWrittenName;
    private string storeWrittenName;
    private bool flagHasSpokenUnits;
    private string storeSpokenUnits;
    private bool flagHasWrittenUnits;
    private string storeWrittenUnits;
    private bool flagHasOutputUnitsUOMAuxID;
    private BigInteger storeOutputUnitsUOMAuxID;
    private bool flagHasDefaultUnitsUOMAuxID;
    private BigInteger storeDefaultUnitsUOMAuxID;
    private bool flagHasOutputUnitsUOMID;
    private string storeOutputUnitsUOMID;
    private bool flagHasDefaultUnitsUOMID;
    private string storeDefaultUnitsUOMID;


    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ID of NutrientJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ID of NutrientJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setID(extracted_integer);
      }


    private void  fromJSONAmountPer100g(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AmountPer100g of NutrientJSON is not a number.");
              }
          }
        setAmountPer100gText(the_rational_text);
      }


    private void  fromJSONRDIPer100g(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RDIPer100g of NutrientJSON is not a number.");
              }
          }
        setRDIPer100gText(the_rational_text);
      }


    private void  fromJSONSpokenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenName of NutrientJSON is not a string.");
        setSpokenName(json_string.getData());
      }


    private void  fromJSONWrittenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenName of NutrientJSON is not a string.");
        setWrittenName(json_string.getData());
      }


    private void  fromJSONSpokenUnits(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenUnits of NutrientJSON is not a string.");
        setSpokenUnits(json_string.getData());
      }


    private void  fromJSONWrittenUnits(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenUnits of NutrientJSON is not a string.");
        setWrittenUnits(json_string.getData());
      }


    private void  fromJSONOutputUnitsUOMAuxID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field OutputUnitsUOMAuxID of NutrientJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field OutputUnitsUOMAuxID of NutrientJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setOutputUnitsUOMAuxID(extracted_integer);
      }


    private void  fromJSONDefaultUnitsUOMAuxID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DefaultUnitsUOMAuxID of NutrientJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DefaultUnitsUOMAuxID of NutrientJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDefaultUnitsUOMAuxID(extracted_integer);
      }


    private void  fromJSONOutputUnitsUOMID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OutputUnitsUOMID of NutrientJSON is not a string.");
        setOutputUnitsUOMID(json_string.getData());
      }


    private void  fromJSONDefaultUnitsUOMID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DefaultUnitsUOMID of NutrientJSON is not a string.");
        setDefaultUnitsUOMID(json_string.getData());
      }


    public NutrientJSON()
      {
        flagHasID = false;
        flagHasAmountPer100g = false;
        flagHasRDIPer100g = false;
        flagHasSpokenName = false;
        flagHasWrittenName = false;
        flagHasSpokenUnits = false;
        flagHasWrittenUnits = false;
        flagHasOutputUnitsUOMAuxID = false;
        flagHasDefaultUnitsUOMAuxID = false;
        flagHasOutputUnitsUOMID = false;
        flagHasDefaultUnitsUOMID = false;
      }

    public bool  hasID()
      {
        return flagHasID;
      }

    public BigInteger  getID()
      {
        Debug.Assert(flagHasID);
        return storeID;
      }

    public bool  hasAmountPer100g()
      {
        return flagHasAmountPer100g;
      }

    public double  getAmountPer100g()
      {
        Debug.Assert(flagHasAmountPer100g);
        if (textStoreAmountPer100g != "")
          {
            return Double.Parse(textStoreAmountPer100g);
          }
        return storeAmountPer100g;
      }

    public string  getAmountPer100gAsText()
      {
        Debug.Assert(flagHasAmountPer100g);
        if (textStoreAmountPer100g == "")
          {
            return Convert.ToString(storeAmountPer100g);
          }
        else
          {
            return (textStoreAmountPer100g);
          }
      }

    public bool  hasRDIPer100g()
      {
        return flagHasRDIPer100g;
      }

    public double  getRDIPer100g()
      {
        Debug.Assert(flagHasRDIPer100g);
        if (textStoreRDIPer100g != "")
          {
            return Double.Parse(textStoreRDIPer100g);
          }
        return storeRDIPer100g;
      }

    public string  getRDIPer100gAsText()
      {
        Debug.Assert(flagHasRDIPer100g);
        if (textStoreRDIPer100g == "")
          {
            return Convert.ToString(storeRDIPer100g);
          }
        else
          {
            return (textStoreRDIPer100g);
          }
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

    public bool  hasWrittenName()
      {
        return flagHasWrittenName;
      }

    public string  getWrittenName()
      {
        Debug.Assert(flagHasWrittenName);
        return storeWrittenName;
      }

    public bool  hasSpokenUnits()
      {
        return flagHasSpokenUnits;
      }

    public string  getSpokenUnits()
      {
        Debug.Assert(flagHasSpokenUnits);
        return storeSpokenUnits;
      }

    public bool  hasWrittenUnits()
      {
        return flagHasWrittenUnits;
      }

    public string  getWrittenUnits()
      {
        Debug.Assert(flagHasWrittenUnits);
        return storeWrittenUnits;
      }

    public bool  hasOutputUnitsUOMAuxID()
      {
        return flagHasOutputUnitsUOMAuxID;
      }

    public BigInteger  getOutputUnitsUOMAuxID()
      {
        Debug.Assert(flagHasOutputUnitsUOMAuxID);
        return storeOutputUnitsUOMAuxID;
      }

    public bool  hasDefaultUnitsUOMAuxID()
      {
        return flagHasDefaultUnitsUOMAuxID;
      }

    public BigInteger  getDefaultUnitsUOMAuxID()
      {
        Debug.Assert(flagHasDefaultUnitsUOMAuxID);
        return storeDefaultUnitsUOMAuxID;
      }

    public bool  hasOutputUnitsUOMID()
      {
        return flagHasOutputUnitsUOMID;
      }

    public string  getOutputUnitsUOMID()
      {
        Debug.Assert(flagHasOutputUnitsUOMID);
        return storeOutputUnitsUOMID;
      }

    public bool  hasDefaultUnitsUOMID()
      {
        return flagHasDefaultUnitsUOMID;
      }

    public string  getDefaultUnitsUOMID()
      {
        Debug.Assert(flagHasDefaultUnitsUOMID);
        return storeDefaultUnitsUOMID;
      }



    public void setID(BigInteger new_value)
      {
        flagHasID = true;
        if (new_value < 0)
            throw new Exception("The value for field ID of NutrientJSON is less than the lower bound (0) for that field.");
        storeID = new_value;
      }
    public void unsetID()
      {
        flagHasID = false;
      }
    public void setAmountPer100g(double new_value)
      {
        flagHasAmountPer100g = true;
        if (new_value < -1)
            throw new Exception("The value for field AmountPer100g of NutrientJSON is less than the lower bound (-1) for that field.");
        storeAmountPer100g = new_value;
        textStoreAmountPer100g = "";
      }
    public void setAmountPer100gText(string new_value)
      {
        flagHasAmountPer100g = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field AmountPer100g of NutrientJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "1", "", false, "1") < 0)
            throw new Exception("The value for field AmountPer100g of NutrientJSON is less than the lower bound (-1) for that field.");
        textStoreAmountPer100g = new_value;
      }
    public void unsetAmountPer100g()
      {
        flagHasAmountPer100g = false;
      }
    public void setRDIPer100g(double new_value)
      {
        flagHasRDIPer100g = true;
        if (new_value < -1)
            throw new Exception("The value for field RDIPer100g of NutrientJSON is less than the lower bound (-1) for that field.");
        storeRDIPer100g = new_value;
        textStoreRDIPer100g = "";
      }
    public void setRDIPer100gText(string new_value)
      {
        flagHasRDIPer100g = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field RDIPer100g of NutrientJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "1", "", false, "1") < 0)
            throw new Exception("The value for field RDIPer100g of NutrientJSON is less than the lower bound (-1) for that field.");
        textStoreRDIPer100g = new_value;
      }
    public void unsetRDIPer100g()
      {
        flagHasRDIPer100g = false;
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
    public void setWrittenName(string new_value)
      {
        flagHasWrittenName = true;
        storeWrittenName = new_value;
      }
    public void unsetWrittenName()
      {
        flagHasWrittenName = false;
      }
    public void setSpokenUnits(string new_value)
      {
        flagHasSpokenUnits = true;
        storeSpokenUnits = new_value;
      }
    public void unsetSpokenUnits()
      {
        flagHasSpokenUnits = false;
      }
    public void setWrittenUnits(string new_value)
      {
        flagHasWrittenUnits = true;
        storeWrittenUnits = new_value;
      }
    public void unsetWrittenUnits()
      {
        flagHasWrittenUnits = false;
      }
    public void setOutputUnitsUOMAuxID(BigInteger new_value)
      {
        flagHasOutputUnitsUOMAuxID = true;
        if (new_value < -1)
            throw new Exception("The value for field OutputUnitsUOMAuxID of NutrientJSON is less than the lower bound (-1) for that field.");
        storeOutputUnitsUOMAuxID = new_value;
      }
    public void unsetOutputUnitsUOMAuxID()
      {
        flagHasOutputUnitsUOMAuxID = false;
      }
    public void setDefaultUnitsUOMAuxID(BigInteger new_value)
      {
        flagHasDefaultUnitsUOMAuxID = true;
        if (new_value < -1)
            throw new Exception("The value for field DefaultUnitsUOMAuxID of NutrientJSON is less than the lower bound (-1) for that field.");
        storeDefaultUnitsUOMAuxID = new_value;
      }
    public void unsetDefaultUnitsUOMAuxID()
      {
        flagHasDefaultUnitsUOMAuxID = false;
      }
    public void setOutputUnitsUOMID(string new_value)
      {
        flagHasOutputUnitsUOMID = true;
        storeOutputUnitsUOMID = new_value;
      }
    public void unsetOutputUnitsUOMID()
      {
        flagHasOutputUnitsUOMID = false;
      }
    public void setDefaultUnitsUOMID(string new_value)
      {
        flagHasDefaultUnitsUOMID = true;
        storeDefaultUnitsUOMID = new_value;
      }
    public void unsetDefaultUnitsUOMID()
      {
        flagHasDefaultUnitsUOMID = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        Debug.Assert(partial_allowed || flagHasID);
        if (flagHasID)
          {
            handler.start_pair("ID");
            handler.number_value(storeID);
          }
        Debug.Assert(partial_allowed || flagHasAmountPer100g);
        if (flagHasAmountPer100g)
          {
            handler.start_pair("AmountPer100g");
            if (textStoreAmountPer100g != "")
                handler.number_value(textStoreAmountPer100g);
            else if (((double)(long)storeAmountPer100g) == storeAmountPer100g)
                handler.number_value((long)storeAmountPer100g);
            else
                handler.number_value(storeAmountPer100g);
          }
        Debug.Assert(partial_allowed || flagHasRDIPer100g);
        if (flagHasRDIPer100g)
          {
            handler.start_pair("RDIPer100g");
            if (textStoreRDIPer100g != "")
                handler.number_value(textStoreRDIPer100g);
            else if (((double)(long)storeRDIPer100g) == storeRDIPer100g)
                handler.number_value((long)storeRDIPer100g);
            else
                handler.number_value(storeRDIPer100g);
          }
        Debug.Assert(partial_allowed || flagHasSpokenName);
        if (flagHasSpokenName)
          {
            handler.start_pair("SpokenName");
            handler.string_value(storeSpokenName);
          }
        Debug.Assert(partial_allowed || flagHasWrittenName);
        if (flagHasWrittenName)
          {
            handler.start_pair("WrittenName");
            handler.string_value(storeWrittenName);
          }
        Debug.Assert(partial_allowed || flagHasSpokenUnits);
        if (flagHasSpokenUnits)
          {
            handler.start_pair("SpokenUnits");
            handler.string_value(storeSpokenUnits);
          }
        Debug.Assert(partial_allowed || flagHasWrittenUnits);
        if (flagHasWrittenUnits)
          {
            handler.start_pair("WrittenUnits");
            handler.string_value(storeWrittenUnits);
          }
        Debug.Assert(partial_allowed || flagHasOutputUnitsUOMAuxID);
        if (flagHasOutputUnitsUOMAuxID)
          {
            handler.start_pair("OutputUnitsUOMAuxID");
            handler.number_value(storeOutputUnitsUOMAuxID);
          }
        Debug.Assert(partial_allowed || flagHasDefaultUnitsUOMAuxID);
        if (flagHasDefaultUnitsUOMAuxID)
          {
            handler.start_pair("DefaultUnitsUOMAuxID");
            handler.number_value(storeDefaultUnitsUOMAuxID);
          }
        if (flagHasOutputUnitsUOMID)
          {
            handler.start_pair("OutputUnitsUOMID");
            handler.string_value(storeOutputUnitsUOMID);
          }
        if (flagHasDefaultUnitsUOMID)
          {
            handler.start_pair("DefaultUnitsUOMID");
            handler.string_value(storeDefaultUnitsUOMID);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasID()))
          {
            return "When parsing the object for %what%, the \"ID\" field was missing.";
          }
        if (!(hasAmountPer100g()))
          {
            return "When parsing the object for %what%, the \"AmountPer100g\" field was missing.";
          }
        if (!(hasRDIPer100g()))
          {
            return "When parsing the object for %what%, the \"RDIPer100g\" field was missing.";
          }
        if (!(hasSpokenName()))
          {
            return "When parsing the object for %what%, the \"SpokenName\" field was missing.";
          }
        if (!(hasWrittenName()))
          {
            return "When parsing the object for %what%, the \"WrittenName\" field was missing.";
          }
        if (!(hasSpokenUnits()))
          {
            return "When parsing the object for %what%, the \"SpokenUnits\" field was missing.";
          }
        if (!(hasWrittenUnits()))
          {
            return "When parsing the object for %what%, the \"WrittenUnits\" field was missing.";
          }
        if (!(hasOutputUnitsUOMAuxID()))
          {
            return "When parsing the object for %what%, the \"OutputUnitsUOMAuxID\" field was missing.";
          }
        if (!(hasDefaultUnitsUOMAuxID()))
          {
            return "When parsing the object for %what%, the \"DefaultUnitsUOMAuxID\" field was missing.";
          }
        return null;
      }

    public static NutrientJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NutrientJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Nutrient", ignore_extras);
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
    public static NutrientJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NutrientJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NutrientJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Nutrient", ignore_extras);
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
    public static NutrientJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NutrientJSON from_text(string text, bool ignore_extras)
      {
        NutrientJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Nutrient", ignore_extras);
            JSONParse.parse_json_value(text, "Text for NutrientJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static NutrientJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        NutrientJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Nutrient", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorID fieldGeneratorID;
        private JSONHoldingNumberTextGenerator fieldGeneratorAmountPer100g;
        private JSONHoldingNumberTextGenerator fieldGeneratorRDIPer100g;
        private JSONHoldingStringGenerator fieldGeneratorSpokenName;
        private JSONHoldingStringGenerator fieldGeneratorWrittenName;
        private JSONHoldingStringGenerator fieldGeneratorSpokenUnits;
        private JSONHoldingStringGenerator fieldGeneratorWrittenUnits;
    private class FieldHoldingGeneratorOutputUnitsUOMAuxID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorOutputUnitsUOMAuxID(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorOutputUnitsUOMAuxID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorOutputUnitsUOMAuxID(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
        private FieldHoldingGeneratorOutputUnitsUOMAuxID fieldGeneratorOutputUnitsUOMAuxID;
    private class FieldHoldingGeneratorDefaultUnitsUOMAuxID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorDefaultUnitsUOMAuxID(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorDefaultUnitsUOMAuxID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorDefaultUnitsUOMAuxID(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
        private FieldHoldingGeneratorDefaultUnitsUOMAuxID fieldGeneratorDefaultUnitsUOMAuxID;
        private JSONHoldingStringGenerator fieldGeneratorOutputUnitsUOMID;
        private JSONHoldingStringGenerator fieldGeneratorDefaultUnitsUOMID;

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
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            NutrientJSON result = new NutrientJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(NutrientJSON result)
          {
            if (fieldGeneratorID.have_value)
              {
                result.setID(fieldGeneratorID.value);
                fieldGeneratorID.have_value = false;
              }
            else if ((!(result.hasID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ID\" field was missing.");
              }
            if (fieldGeneratorAmountPer100g.have_value)
              {
                result.setAmountPer100gText(fieldGeneratorAmountPer100g.value);
                fieldGeneratorAmountPer100g.have_value = false;
              }
            else if ((!(result.hasAmountPer100g())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AmountPer100g\" field was missing.");
              }
            if (fieldGeneratorRDIPer100g.have_value)
              {
                result.setRDIPer100gText(fieldGeneratorRDIPer100g.value);
                fieldGeneratorRDIPer100g.have_value = false;
              }
            else if ((!(result.hasRDIPer100g())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RDIPer100g\" field was missing.");
              }
            if (fieldGeneratorSpokenName.have_value)
              {
                result.setSpokenName(fieldGeneratorSpokenName.value);
                fieldGeneratorSpokenName.have_value = false;
              }
            else if ((!(result.hasSpokenName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenName\" field was missing.");
              }
            if (fieldGeneratorWrittenName.have_value)
              {
                result.setWrittenName(fieldGeneratorWrittenName.value);
                fieldGeneratorWrittenName.have_value = false;
              }
            else if ((!(result.hasWrittenName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenName\" field was missing.");
              }
            if (fieldGeneratorSpokenUnits.have_value)
              {
                result.setSpokenUnits(fieldGeneratorSpokenUnits.value);
                fieldGeneratorSpokenUnits.have_value = false;
              }
            else if ((!(result.hasSpokenUnits())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenUnits\" field was missing.");
              }
            if (fieldGeneratorWrittenUnits.have_value)
              {
                result.setWrittenUnits(fieldGeneratorWrittenUnits.value);
                fieldGeneratorWrittenUnits.have_value = false;
              }
            else if ((!(result.hasWrittenUnits())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenUnits\" field was missing.");
              }
            if (fieldGeneratorOutputUnitsUOMAuxID.have_value)
              {
                result.setOutputUnitsUOMAuxID(fieldGeneratorOutputUnitsUOMAuxID.value);
                fieldGeneratorOutputUnitsUOMAuxID.have_value = false;
              }
            else if ((!(result.hasOutputUnitsUOMAuxID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OutputUnitsUOMAuxID\" field was missing.");
              }
            if (fieldGeneratorDefaultUnitsUOMAuxID.have_value)
              {
                result.setDefaultUnitsUOMAuxID(fieldGeneratorDefaultUnitsUOMAuxID.value);
                fieldGeneratorDefaultUnitsUOMAuxID.have_value = false;
              }
            else if ((!(result.hasDefaultUnitsUOMAuxID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DefaultUnitsUOMAuxID\" field was missing.");
              }
            if (fieldGeneratorOutputUnitsUOMID.have_value)
              {
                result.setOutputUnitsUOMID(fieldGeneratorOutputUnitsUOMID.value);
                fieldGeneratorOutputUnitsUOMID.have_value = false;
              }
            if (fieldGeneratorDefaultUnitsUOMID.have_value)
              {
                result.setDefaultUnitsUOMID(fieldGeneratorDefaultUnitsUOMID.value);
                fieldGeneratorDefaultUnitsUOMID.have_value = false;
              }
          }
        protected abstract void handle_result(NutrientJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "mountPer100g", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorAmountPer100g;
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "efaultUnitsUOM", 0, 14, false) == 0)
                      {
                        switch (field_name[15])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 16, "uxID", 0, 4, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorDefaultUnitsUOMAuxID;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 16, "D", 0, 1, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorDefaultUnitsUOMID;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorID;
                    break;
                case 'O':
                    if (String.Compare(field_name, 1, "utputUnitsUOM", 0, 13, false) == 0)
                      {
                        switch (field_name[14])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 15, "uxID", 0, 4, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorOutputUnitsUOMAuxID;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 15, "D", 0, 1, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorOutputUnitsUOMID;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "DIPer100g", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorRDIPer100g;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "poken", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 7, "ame", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorSpokenName;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 7, "nits", 0, 4, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorSpokenUnits;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "ritten", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 8, "ame", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorWrittenName;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 8, "nits", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorWrittenUnits;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorID = new FieldHoldingGeneratorID("field \"ID\" of the Nutrient class");
            fieldGeneratorAmountPer100g = new JSONHoldingNumberTextGenerator("field \"AmountPer100g\" of the Nutrient class");
            fieldGeneratorRDIPer100g = new JSONHoldingNumberTextGenerator("field \"RDIPer100g\" of the Nutrient class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the Nutrient class");
            fieldGeneratorWrittenName = new JSONHoldingStringGenerator("field \"WrittenName\" of the Nutrient class");
            fieldGeneratorSpokenUnits = new JSONHoldingStringGenerator("field \"SpokenUnits\" of the Nutrient class");
            fieldGeneratorWrittenUnits = new JSONHoldingStringGenerator("field \"WrittenUnits\" of the Nutrient class");
            fieldGeneratorOutputUnitsUOMAuxID = new FieldHoldingGeneratorOutputUnitsUOMAuxID("field \"OutputUnitsUOMAuxID\" of the Nutrient class");
            fieldGeneratorDefaultUnitsUOMAuxID = new FieldHoldingGeneratorDefaultUnitsUOMAuxID("field \"DefaultUnitsUOMAuxID\" of the Nutrient class");
            fieldGeneratorOutputUnitsUOMID = new JSONHoldingStringGenerator("field \"OutputUnitsUOMID\" of the Nutrient class");
            fieldGeneratorDefaultUnitsUOMID = new JSONHoldingStringGenerator("field \"DefaultUnitsUOMID\" of the Nutrient class");
            set_what("the Nutrient class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorID = new FieldHoldingGeneratorID("field \"ID\" of the Nutrient class");
            fieldGeneratorAmountPer100g = new JSONHoldingNumberTextGenerator("field \"AmountPer100g\" of the Nutrient class");
            fieldGeneratorRDIPer100g = new JSONHoldingNumberTextGenerator("field \"RDIPer100g\" of the Nutrient class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the Nutrient class");
            fieldGeneratorWrittenName = new JSONHoldingStringGenerator("field \"WrittenName\" of the Nutrient class");
            fieldGeneratorSpokenUnits = new JSONHoldingStringGenerator("field \"SpokenUnits\" of the Nutrient class");
            fieldGeneratorWrittenUnits = new JSONHoldingStringGenerator("field \"WrittenUnits\" of the Nutrient class");
            fieldGeneratorOutputUnitsUOMAuxID = new FieldHoldingGeneratorOutputUnitsUOMAuxID("field \"OutputUnitsUOMAuxID\" of the Nutrient class");
            fieldGeneratorDefaultUnitsUOMAuxID = new FieldHoldingGeneratorDefaultUnitsUOMAuxID("field \"DefaultUnitsUOMAuxID\" of the Nutrient class");
            fieldGeneratorOutputUnitsUOMID = new JSONHoldingStringGenerator("field \"OutputUnitsUOMID\" of the Nutrient class");
            fieldGeneratorDefaultUnitsUOMID = new JSONHoldingStringGenerator("field \"DefaultUnitsUOMID\" of the Nutrient class");
            set_what("the Nutrient class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorID.reset();
            fieldGeneratorAmountPer100g.reset();
            fieldGeneratorRDIPer100g.reset();
            fieldGeneratorSpokenName.reset();
            fieldGeneratorWrittenName.reset();
            fieldGeneratorSpokenUnits.reset();
            fieldGeneratorWrittenUnits.reset();
            fieldGeneratorOutputUnitsUOMAuxID.reset();
            fieldGeneratorDefaultUnitsUOMAuxID.reset();
            fieldGeneratorOutputUnitsUOMID.reset();
            fieldGeneratorDefaultUnitsUOMID.reset();
            base.reset();
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
        protected override void handle_result(NutrientJSON  result)
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
        public NutrientJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(NutrientJSON  result)
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
    protected virtual void handle_result(List<NutrientJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<NutrientJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<NutrientJSON>();
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
    public List<NutrientJSON> value;
  };
  };
