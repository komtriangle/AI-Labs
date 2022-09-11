/* file "HLSRadiusJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HLSRadiusJSON : JSONBase
  {
    public enum TypeUnit
      {
        Unit_miles,
        Unit_kilometers
      };

    public static TypeUnit  stringToUnit(string chars)
      {
        switch (chars[0])
          {
            case 'k':
                if ((String.Compare(chars, 1, "ilometers", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeUnit.Unit_kilometers;
                break;
            case 'm':
                if ((String.Compare(chars, 1, "iles", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeUnit.Unit_miles;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Unit' is not one of the legal values.");
      }

    public static string  stringFromUnit(TypeUnit the_enum)
      {
        switch (the_enum)
          {
            case TypeUnit.Unit_miles:
                return "miles";
            case TypeUnit.Unit_kilometers:
                return "kilometers";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasQuantity;
    private double storeQuantity;
    private string textStoreQuantity;
    private bool flagHasUnit;
    private TypeUnit storeUnit;


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
                throw new Exception("The value for field Quantity of HLSRadiusJSON is not a number.");
              }
          }
        setQuantityText(the_rational_text);
      }


    private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Unit of HLSRadiusJSON is not a string.");
        TypeUnit the_enum;
        switch (json_string.getData()[0])
          {
            case 'k':
                if ((String.Compare(json_string.getData(), 1, "ilometers", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypeUnit.Unit_kilometers;
                        goto enum_is_done;
                      }
                break;
            case 'm':
                if ((String.Compare(json_string.getData(), 1, "iles", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeUnit.Unit_miles;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Unit of HLSRadiusJSON is not one of the legal strings.");
      enum_is_done:;
        setUnit(the_enum);
      }


    public HLSRadiusJSON()
      {
        flagHasQuantity = false;
        flagHasUnit = false;
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

    public bool  hasUnit()
      {
        return flagHasUnit;
      }

    public TypeUnit  getUnit()
      {
        Debug.Assert(flagHasUnit);
        return storeUnit;
      }

    public string  getUnitAsString()
      {
        return stringFromUnit(getUnit());
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
            throw new Exception("The text value for field Quantity of HLSRadiusJSON is not a valid number.");
        textStoreQuantity = new_value;
      }
    public void unsetQuantity()
      {
        flagHasQuantity = false;
      }
    public void setUnit(TypeUnit new_value)
      {
        flagHasUnit = true;
        storeUnit = new_value;
      }
    public void setUnit(string chars)
      {
        setUnit(stringToUnit(chars));
      }
    public void unsetUnit()
      {
        flagHasUnit = false;
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
        Debug.Assert(partial_allowed || flagHasQuantity);
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
        Debug.Assert(partial_allowed || flagHasUnit);
        if (flagHasUnit)
          {
            handler.start_pair("Unit");
            switch (storeUnit)
              {
                case TypeUnit.Unit_miles:
                    handler.string_value("miles");
                    break;
                case TypeUnit.Unit_kilometers:
                    handler.string_value("kilometers");
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
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasQuantity()))
          {
            return "When parsing the object for %what%, the \"Quantity\" field was missing.";
          }
        if (!(hasUnit()))
          {
            return "When parsing the object for %what%, the \"Unit\" field was missing.";
          }
        return null;
      }

    public static HLSRadiusJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HLSRadiusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HLSRadius", ignore_extras);
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
    public static HLSRadiusJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HLSRadiusJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HLSRadiusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HLSRadius", ignore_extras);
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
    public static HLSRadiusJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HLSRadiusJSON from_text(string text, bool ignore_extras)
      {
        HLSRadiusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HLSRadius", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HLSRadiusJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HLSRadiusJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HLSRadiusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HLSRadius", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorQuantity;
    private abstract class FieldGeneratorUnit : JSONStringGenerator
          {
            protected FieldGeneratorUnit(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorUnit()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToUnit(result));
              }
            protected abstract void handle_result(TypeUnit result);
          };
    private class FieldHoldingGeneratorUnit : FieldGeneratorUnit
  {
    protected override void handle_result(TypeUnit result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorUnit(String what)
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
    public TypeUnit value;
  };
    private class FieldHoldingArrayGeneratorUnit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorUnit
      {
        private FieldHoldingArrayGeneratorUnit top;

        protected override void handle_result(TypeUnit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorUnit init_top)
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
    protected virtual void handle_result(List<TypeUnit> result)
      {
      }

    public FieldHoldingArrayGeneratorUnit(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorUnit()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeUnit> value;
  };
        private FieldHoldingGeneratorUnit fieldGeneratorUnit;

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
            HLSRadiusJSON result = new HLSRadiusJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(HLSRadiusJSON result)
          {
            if (fieldGeneratorQuantity.have_value)
              {
                result.setQuantityText(fieldGeneratorQuantity.value);
                fieldGeneratorQuantity.have_value = false;
              }
            else if ((!(result.hasQuantity())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Quantity\" field was missing.");
              }
            if (fieldGeneratorUnit.have_value)
              {
                result.setUnit(fieldGeneratorUnit.value);
                fieldGeneratorUnit.have_value = false;
              }
            else if ((!(result.hasUnit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Unit\" field was missing.");
              }
          }
        protected abstract void handle_result(HLSRadiusJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'Q':
                    if ((String.Compare(field_name, 1, "uantity", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorQuantity;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nit", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorUnit;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQuantity = new JSONHoldingNumberTextGenerator("field \"Quantity\" of the HLSRadius class");
            fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the HLSRadius class");
            set_what("the HLSRadius class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQuantity = new JSONHoldingNumberTextGenerator("field \"Quantity\" of the HLSRadius class");
            fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the HLSRadius class");
            set_what("the HLSRadius class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQuantity.reset();
            fieldGeneratorUnit.reset();
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
        protected override void handle_result(HLSRadiusJSON  result)
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
        public HLSRadiusJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HLSRadiusJSON  result)
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
    protected virtual void handle_result(List<HLSRadiusJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HLSRadiusJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HLSRadiusJSON>();
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
    public List<HLSRadiusJSON> value;
  };
  };
