/* file "MeasuredAmountJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MeasuredAmountJSON : JSONBase
  {
    private bool flagHasUnit;
    private UnitOfMeasureJSON  storeUnit;
    private bool flagHasSingularName;
    private string storeSingularName;
    private bool flagHasPluralName;
    private string storePluralName;
    private bool flagHasAbbreviatedName;
    private string storeAbbreviatedName;
    private bool flagHasReferenceUnitsPerUnit;
    private double storeReferenceUnitsPerUnit;
    private string textStoreReferenceUnitsPerUnit;
    private bool flagHasUnitsPerReferenceUnit;
    private double storeUnitsPerReferenceUnit;
    private string textStoreUnitsPerReferenceUnit;
    private bool flagHasValue;
    private double storeValue;
    private string textStoreValue;


    private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UnitOfMeasureJSON convert_classy = UnitOfMeasureJSON.from_json(json_value, ignore_extras, true);
        setUnit(convert_classy);
      }


    private void  fromJSONSingularName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SingularName of MeasuredAmountJSON is not a string.");
        setSingularName(json_string.getData());
      }


    private void  fromJSONPluralName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PluralName of MeasuredAmountJSON is not a string.");
        setPluralName(json_string.getData());
      }


    private void  fromJSONAbbreviatedName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AbbreviatedName of MeasuredAmountJSON is not a string.");
        setAbbreviatedName(json_string.getData());
      }


    private void  fromJSONReferenceUnitsPerUnit(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ReferenceUnitsPerUnit of MeasuredAmountJSON is not a number.");
              }
          }
        setReferenceUnitsPerUnitText(the_rational_text);
      }


    private void  fromJSONUnitsPerReferenceUnit(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UnitsPerReferenceUnit of MeasuredAmountJSON is not a number.");
              }
          }
        setUnitsPerReferenceUnitText(the_rational_text);
      }


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Value of MeasuredAmountJSON is not a number.");
              }
          }
        setValueText(the_rational_text);
      }


    public MeasuredAmountJSON()
      {
        flagHasUnit = false;
        flagHasSingularName = false;
        flagHasPluralName = false;
        flagHasAbbreviatedName = false;
        flagHasReferenceUnitsPerUnit = false;
        flagHasUnitsPerReferenceUnit = false;
        flagHasValue = false;
      }

    public bool  hasUnit()
      {
        return flagHasUnit;
      }

    public UnitOfMeasureJSON   getUnit()
      {
        Debug.Assert(flagHasUnit);
        return storeUnit;
      }

    public UnitOfMeasureJSON.TypeValue  getUnitValue()
      {
        return getUnit().getValue();
      }

    public string  getUnitAsString()
      {
        return getUnit().getValueAsString();
      }

    public bool  hasSingularName()
      {
        return flagHasSingularName;
      }

    public string  getSingularName()
      {
        Debug.Assert(flagHasSingularName);
        return storeSingularName;
      }

    public bool  hasPluralName()
      {
        return flagHasPluralName;
      }

    public string  getPluralName()
      {
        Debug.Assert(flagHasPluralName);
        return storePluralName;
      }

    public bool  hasAbbreviatedName()
      {
        return flagHasAbbreviatedName;
      }

    public string  getAbbreviatedName()
      {
        Debug.Assert(flagHasAbbreviatedName);
        return storeAbbreviatedName;
      }

    public bool  hasReferenceUnitsPerUnit()
      {
        return flagHasReferenceUnitsPerUnit;
      }

    public double  getReferenceUnitsPerUnit()
      {
        Debug.Assert(flagHasReferenceUnitsPerUnit);
        if (textStoreReferenceUnitsPerUnit != "")
          {
            return Double.Parse(textStoreReferenceUnitsPerUnit);
          }
        return storeReferenceUnitsPerUnit;
      }

    public string  getReferenceUnitsPerUnitAsText()
      {
        Debug.Assert(flagHasReferenceUnitsPerUnit);
        if (textStoreReferenceUnitsPerUnit == "")
          {
            return Convert.ToString(storeReferenceUnitsPerUnit);
          }
        else
          {
            return (textStoreReferenceUnitsPerUnit);
          }
      }

    public bool  hasUnitsPerReferenceUnit()
      {
        return flagHasUnitsPerReferenceUnit;
      }

    public double  getUnitsPerReferenceUnit()
      {
        Debug.Assert(flagHasUnitsPerReferenceUnit);
        if (textStoreUnitsPerReferenceUnit != "")
          {
            return Double.Parse(textStoreUnitsPerReferenceUnit);
          }
        return storeUnitsPerReferenceUnit;
      }

    public string  getUnitsPerReferenceUnitAsText()
      {
        Debug.Assert(flagHasUnitsPerReferenceUnit);
        if (textStoreUnitsPerReferenceUnit == "")
          {
            return Convert.ToString(storeUnitsPerReferenceUnit);
          }
        else
          {
            return (textStoreUnitsPerReferenceUnit);
          }
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public double  getValue()
      {
        Debug.Assert(flagHasValue);
        if (textStoreValue != "")
          {
            return Double.Parse(textStoreValue);
          }
        return storeValue;
      }

    public string  getValueAsText()
      {
        Debug.Assert(flagHasValue);
        if (textStoreValue == "")
          {
            return Convert.ToString(storeValue);
          }
        else
          {
            return (textStoreValue);
          }
      }



    public void setUnit(UnitOfMeasureJSON  new_value)
      {
        if (flagHasUnit)
          {
          }
        flagHasUnit = true;
        storeUnit = new_value;
      }
    public void setUnit(UnitOfMeasureJSON.TypeValue new_value)
      {
        setUnit(new UnitOfMeasureJSON(new_value));
      }
    public void setUnit(string chars)
      {
        UnitOfMeasureJSON.TypeValueKnownValues known = UnitOfMeasureJSON.stringToValue(chars);
        UnitOfMeasureJSON.TypeValue new_value = new UnitOfMeasureJSON.TypeValue();
        if (known == UnitOfMeasureJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setUnit(new_value);
      }
    public void unsetUnit()
      {
        if (flagHasUnit)
          {
          }
        flagHasUnit = false;
      }
    public void setSingularName(string new_value)
      {
        flagHasSingularName = true;
        storeSingularName = new_value;
      }
    public void unsetSingularName()
      {
        flagHasSingularName = false;
      }
    public void setPluralName(string new_value)
      {
        flagHasPluralName = true;
        storePluralName = new_value;
      }
    public void unsetPluralName()
      {
        flagHasPluralName = false;
      }
    public void setAbbreviatedName(string new_value)
      {
        flagHasAbbreviatedName = true;
        storeAbbreviatedName = new_value;
      }
    public void unsetAbbreviatedName()
      {
        flagHasAbbreviatedName = false;
      }
    public void setReferenceUnitsPerUnit(double new_value)
      {
        flagHasReferenceUnitsPerUnit = true;
        if (new_value < 0)
            throw new Exception("The value for field ReferenceUnitsPerUnit of MeasuredAmountJSON is less than the lower bound (0) for that field.");
        storeReferenceUnitsPerUnit = new_value;
        textStoreReferenceUnitsPerUnit = "";
      }
    public void setReferenceUnitsPerUnitText(string new_value)
      {
        flagHasReferenceUnitsPerUnit = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field ReferenceUnitsPerUnit of MeasuredAmountJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field ReferenceUnitsPerUnit of MeasuredAmountJSON is less than the lower bound (0) for that field.");
        textStoreReferenceUnitsPerUnit = new_value;
      }
    public void unsetReferenceUnitsPerUnit()
      {
        flagHasReferenceUnitsPerUnit = false;
      }
    public void setUnitsPerReferenceUnit(double new_value)
      {
        flagHasUnitsPerReferenceUnit = true;
        if (new_value < 0)
            throw new Exception("The value for field UnitsPerReferenceUnit of MeasuredAmountJSON is less than the lower bound (0) for that field.");
        storeUnitsPerReferenceUnit = new_value;
        textStoreUnitsPerReferenceUnit = "";
      }
    public void setUnitsPerReferenceUnitText(string new_value)
      {
        flagHasUnitsPerReferenceUnit = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field UnitsPerReferenceUnit of MeasuredAmountJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field UnitsPerReferenceUnit of MeasuredAmountJSON is less than the lower bound (0) for that field.");
        textStoreUnitsPerReferenceUnit = new_value;
      }
    public void unsetUnitsPerReferenceUnit()
      {
        flagHasUnitsPerReferenceUnit = false;
      }
    public void setValue(double new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
        textStoreValue = "";
      }
    public void setValueText(string new_value)
      {
        flagHasValue = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Value of MeasuredAmountJSON is not a valid number.");
        textStoreValue = new_value;
      }
    public void unsetValue()
      {
        flagHasValue = false;
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
        Debug.Assert(partial_allowed || flagHasUnit);
        if (flagHasUnit)
          {
            handler.start_pair("Unit");
            if (partial_allowed)
                storeUnit.write_partial_as_json(handler);
            else
                storeUnit.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasSingularName);
        if (flagHasSingularName)
          {
            handler.start_pair("SingularName");
            handler.string_value(storeSingularName);
          }
        Debug.Assert(partial_allowed || flagHasPluralName);
        if (flagHasPluralName)
          {
            handler.start_pair("PluralName");
            handler.string_value(storePluralName);
          }
        if (flagHasAbbreviatedName)
          {
            handler.start_pair("AbbreviatedName");
            handler.string_value(storeAbbreviatedName);
          }
        Debug.Assert(partial_allowed || flagHasReferenceUnitsPerUnit);
        if (flagHasReferenceUnitsPerUnit)
          {
            handler.start_pair("ReferenceUnitsPerUnit");
            if (textStoreReferenceUnitsPerUnit != "")
                handler.number_value(textStoreReferenceUnitsPerUnit);
            else if (((double)(long)storeReferenceUnitsPerUnit) == storeReferenceUnitsPerUnit)
                handler.number_value((long)storeReferenceUnitsPerUnit);
            else
                handler.number_value(storeReferenceUnitsPerUnit);
          }
        Debug.Assert(partial_allowed || flagHasUnitsPerReferenceUnit);
        if (flagHasUnitsPerReferenceUnit)
          {
            handler.start_pair("UnitsPerReferenceUnit");
            if (textStoreUnitsPerReferenceUnit != "")
                handler.number_value(textStoreUnitsPerReferenceUnit);
            else if (((double)(long)storeUnitsPerReferenceUnit) == storeUnitsPerReferenceUnit)
                handler.number_value((long)storeUnitsPerReferenceUnit);
            else
                handler.number_value(storeUnitsPerReferenceUnit);
          }
        Debug.Assert(partial_allowed || flagHasValue);
        if (flagHasValue)
          {
            handler.start_pair("Value");
            if (textStoreValue != "")
                handler.number_value(textStoreValue);
            else if (((double)(long)storeValue) == storeValue)
                handler.number_value((long)storeValue);
            else
                handler.number_value(storeValue);
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
        if (!(hasUnit()))
          {
            return "When parsing the object for %what%, the \"Unit\" field was missing.";
          }
        if (!(hasSingularName()))
          {
            return "When parsing the object for %what%, the \"SingularName\" field was missing.";
          }
        if (!(hasPluralName()))
          {
            return "When parsing the object for %what%, the \"PluralName\" field was missing.";
          }
        if (!(hasReferenceUnitsPerUnit()))
          {
            return "When parsing the object for %what%, the \"ReferenceUnitsPerUnit\" field was missing.";
          }
        if (!(hasUnitsPerReferenceUnit()))
          {
            return "When parsing the object for %what%, the \"UnitsPerReferenceUnit\" field was missing.";
          }
        if (!(hasValue()))
          {
            return "When parsing the object for %what%, the \"Value\" field was missing.";
          }
        return null;
      }

    public static MeasuredAmountJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MeasuredAmountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MeasuredAmount", ignore_extras);
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
    public static MeasuredAmountJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MeasuredAmountJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MeasuredAmountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MeasuredAmount", ignore_extras);
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
    public static MeasuredAmountJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MeasuredAmountJSON from_text(string text, bool ignore_extras)
      {
        MeasuredAmountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MeasuredAmount", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MeasuredAmountJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MeasuredAmountJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MeasuredAmountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MeasuredAmount", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private UnitOfMeasureJSON.HoldingGenerator fieldGeneratorUnit;
        private JSONHoldingStringGenerator fieldGeneratorSingularName;
        private JSONHoldingStringGenerator fieldGeneratorPluralName;
        private JSONHoldingStringGenerator fieldGeneratorAbbreviatedName;
        private JSONHoldingNumberTextGenerator fieldGeneratorReferenceUnitsPerUnit;
        private JSONHoldingNumberTextGenerator fieldGeneratorUnitsPerReferenceUnit;
        private JSONHoldingNumberTextGenerator fieldGeneratorValue;

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
            MeasuredAmountJSON result = new MeasuredAmountJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MeasuredAmountJSON result)
          {
            if (fieldGeneratorUnit.have_value)
              {
                result.setUnit(fieldGeneratorUnit.value);
                fieldGeneratorUnit.have_value = false;
              }
            else if ((!(result.hasUnit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Unit\" field was missing.");
              }
            if (fieldGeneratorSingularName.have_value)
              {
                result.setSingularName(fieldGeneratorSingularName.value);
                fieldGeneratorSingularName.have_value = false;
              }
            else if ((!(result.hasSingularName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SingularName\" field was missing.");
              }
            if (fieldGeneratorPluralName.have_value)
              {
                result.setPluralName(fieldGeneratorPluralName.value);
                fieldGeneratorPluralName.have_value = false;
              }
            else if ((!(result.hasPluralName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PluralName\" field was missing.");
              }
            if (fieldGeneratorAbbreviatedName.have_value)
              {
                result.setAbbreviatedName(fieldGeneratorAbbreviatedName.value);
                fieldGeneratorAbbreviatedName.have_value = false;
              }
            if (fieldGeneratorReferenceUnitsPerUnit.have_value)
              {
                result.setReferenceUnitsPerUnitText(fieldGeneratorReferenceUnitsPerUnit.value);
                fieldGeneratorReferenceUnitsPerUnit.have_value = false;
              }
            else if ((!(result.hasReferenceUnitsPerUnit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ReferenceUnitsPerUnit\" field was missing.");
              }
            if (fieldGeneratorUnitsPerReferenceUnit.have_value)
              {
                result.setUnitsPerReferenceUnitText(fieldGeneratorUnitsPerReferenceUnit.value);
                fieldGeneratorUnitsPerReferenceUnit.have_value = false;
              }
            else if ((!(result.hasUnitsPerReferenceUnit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UnitsPerReferenceUnit\" field was missing.");
              }
            if (fieldGeneratorValue.have_value)
              {
                result.setValueText(fieldGeneratorValue.value);
                fieldGeneratorValue.have_value = false;
              }
            else if ((!(result.hasValue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Value\" field was missing.");
              }
          }
        protected abstract void handle_result(MeasuredAmountJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "bbreviatedName", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorAbbreviatedName;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "luralName", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorPluralName;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "eferenceUnitsPerUnit", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorReferenceUnitsPerUnit;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ingularName", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorSingularName;
                    break;
                case 'U':
                    if (String.Compare(field_name, 1, "nit", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorUnit;
                          }
                        switch (field_name[4])
                          {
                            case 's':
                                if ((String.Compare(field_name, 5, "PerReferenceUnit", 0, 16, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorUnitsPerReferenceUnit;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorUnit = new UnitOfMeasureJSON.HoldingGenerator("field \"Unit\" of the MeasuredAmount class", ignore_extras);
            fieldGeneratorSingularName = new JSONHoldingStringGenerator("field \"SingularName\" of the MeasuredAmount class");
            fieldGeneratorPluralName = new JSONHoldingStringGenerator("field \"PluralName\" of the MeasuredAmount class");
            fieldGeneratorAbbreviatedName = new JSONHoldingStringGenerator("field \"AbbreviatedName\" of the MeasuredAmount class");
            fieldGeneratorReferenceUnitsPerUnit = new JSONHoldingNumberTextGenerator("field \"ReferenceUnitsPerUnit\" of the MeasuredAmount class");
            fieldGeneratorUnitsPerReferenceUnit = new JSONHoldingNumberTextGenerator("field \"UnitsPerReferenceUnit\" of the MeasuredAmount class");
            fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the MeasuredAmount class");
            set_what("the MeasuredAmount class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorUnit = new UnitOfMeasureJSON.HoldingGenerator("field \"Unit\" of the MeasuredAmount class", false);
            fieldGeneratorSingularName = new JSONHoldingStringGenerator("field \"SingularName\" of the MeasuredAmount class");
            fieldGeneratorPluralName = new JSONHoldingStringGenerator("field \"PluralName\" of the MeasuredAmount class");
            fieldGeneratorAbbreviatedName = new JSONHoldingStringGenerator("field \"AbbreviatedName\" of the MeasuredAmount class");
            fieldGeneratorReferenceUnitsPerUnit = new JSONHoldingNumberTextGenerator("field \"ReferenceUnitsPerUnit\" of the MeasuredAmount class");
            fieldGeneratorUnitsPerReferenceUnit = new JSONHoldingNumberTextGenerator("field \"UnitsPerReferenceUnit\" of the MeasuredAmount class");
            fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the MeasuredAmount class");
            set_what("the MeasuredAmount class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorUnit.reset();
            fieldGeneratorSingularName.reset();
            fieldGeneratorPluralName.reset();
            fieldGeneratorAbbreviatedName.reset();
            fieldGeneratorReferenceUnitsPerUnit.reset();
            fieldGeneratorUnitsPerReferenceUnit.reset();
            fieldGeneratorValue.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorUnit.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorUnit.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MeasuredAmountJSON  result)
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
        public MeasuredAmountJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MeasuredAmountJSON  result)
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
    protected virtual void handle_result(List<MeasuredAmountJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MeasuredAmountJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MeasuredAmountJSON>();
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
    public List<MeasuredAmountJSON> value;
  };
  };
