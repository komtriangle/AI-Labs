/* file "ColorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ColorJSON : JSONBase
  {
    private bool flagHasName;
    private string storeName;
    private bool flagHasRed;
    private byte storeRed;
    private bool flagHasGreen;
    private byte storeGreen;
    private bool flagHasBlue;
    private byte storeBlue;
    private bool flagHasHue;
    private short storeHue;
    private bool flagHasSaturation;
    private sbyte storeSaturation;
    private bool flagHasBrightnessValue;
    private sbyte storeBrightnessValue;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of ColorJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONRed(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        byte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Red of ColorJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Red of ColorJSON is not an integer.");
              }
            extracted_integer = (byte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (byte)(json_integer.getLongInt())        ;
          }
        setRed(extracted_integer);
      }


    private void  fromJSONGreen(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        byte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Green of ColorJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Green of ColorJSON is not an integer.");
              }
            extracted_integer = (byte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (byte)(json_integer.getLongInt())        ;
          }
        setGreen(extracted_integer);
      }


    private void  fromJSONBlue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        byte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Blue of ColorJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Blue of ColorJSON is not an integer.");
              }
            extracted_integer = (byte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (byte)(json_integer.getLongInt())        ;
          }
        setBlue(extracted_integer);
      }


    private void  fromJSONHue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        short extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Hue of ColorJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Hue of ColorJSON is not an integer.");
              }
            extracted_integer = (short)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (short)(json_integer.getLongInt())        ;
          }
        setHue(extracted_integer);
      }


    private void  fromJSONSaturation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Saturation of ColorJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Saturation of ColorJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setSaturation(extracted_integer);
      }


    private void  fromJSONBrightnessValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field BrightnessValue of ColorJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field BrightnessValue of ColorJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setBrightnessValue(extracted_integer);
      }


    public ColorJSON()
      {
        flagHasName = false;
        flagHasRed = false;
        flagHasGreen = false;
        flagHasBlue = false;
        flagHasHue = false;
        flagHasSaturation = false;
        flagHasBrightnessValue = false;
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

    public bool  hasRed()
      {
        return flagHasRed;
      }

    public byte  getRed()
      {
        Debug.Assert(flagHasRed);
        return storeRed;
      }

    public bool  hasGreen()
      {
        return flagHasGreen;
      }

    public byte  getGreen()
      {
        Debug.Assert(flagHasGreen);
        return storeGreen;
      }

    public bool  hasBlue()
      {
        return flagHasBlue;
      }

    public byte  getBlue()
      {
        Debug.Assert(flagHasBlue);
        return storeBlue;
      }

    public bool  hasHue()
      {
        return flagHasHue;
      }

    public short  getHue()
      {
        Debug.Assert(flagHasHue);
        return storeHue;
      }

    public bool  hasSaturation()
      {
        return flagHasSaturation;
      }

    public sbyte  getSaturation()
      {
        Debug.Assert(flagHasSaturation);
        return storeSaturation;
      }

    public bool  hasBrightnessValue()
      {
        return flagHasBrightnessValue;
      }

    public sbyte  getBrightnessValue()
      {
        Debug.Assert(flagHasBrightnessValue);
        return storeBrightnessValue;
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
    public void setRed(byte new_value)
      {
        flagHasRed = true;
        if (new_value < 0)
            throw new Exception("The value for field Red of ColorJSON is less than the lower bound (0) for that field.");
        if (new_value > 255)
            throw new Exception("The value for field Red of ColorJSON is greater than the upper bound (255) for that field.");
        storeRed = new_value;
      }
    public void unsetRed()
      {
        flagHasRed = false;
      }
    public void setGreen(byte new_value)
      {
        flagHasGreen = true;
        if (new_value < 0)
            throw new Exception("The value for field Green of ColorJSON is less than the lower bound (0) for that field.");
        if (new_value > 255)
            throw new Exception("The value for field Green of ColorJSON is greater than the upper bound (255) for that field.");
        storeGreen = new_value;
      }
    public void unsetGreen()
      {
        flagHasGreen = false;
      }
    public void setBlue(byte new_value)
      {
        flagHasBlue = true;
        if (new_value < 0)
            throw new Exception("The value for field Blue of ColorJSON is less than the lower bound (0) for that field.");
        if (new_value > 255)
            throw new Exception("The value for field Blue of ColorJSON is greater than the upper bound (255) for that field.");
        storeBlue = new_value;
      }
    public void unsetBlue()
      {
        flagHasBlue = false;
      }
    public void setHue(short new_value)
      {
        flagHasHue = true;
        if (new_value < 0)
            throw new Exception("The value for field Hue of ColorJSON is less than the lower bound (0) for that field.");
        if (new_value > 359)
            throw new Exception("The value for field Hue of ColorJSON is greater than the upper bound (359) for that field.");
        storeHue = new_value;
      }
    public void unsetHue()
      {
        flagHasHue = false;
      }
    public void setSaturation(sbyte new_value)
      {
        flagHasSaturation = true;
        if (new_value < 0)
            throw new Exception("The value for field Saturation of ColorJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field Saturation of ColorJSON is greater than the upper bound (100) for that field.");
        storeSaturation = new_value;
      }
    public void unsetSaturation()
      {
        flagHasSaturation = false;
      }
    public void setBrightnessValue(sbyte new_value)
      {
        flagHasBrightnessValue = true;
        if (new_value < 0)
            throw new Exception("The value for field BrightnessValue of ColorJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field BrightnessValue of ColorJSON is greater than the upper bound (100) for that field.");
        storeBrightnessValue = new_value;
      }
    public void unsetBrightnessValue()
      {
        flagHasBrightnessValue = false;
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
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        Debug.Assert(partial_allowed || flagHasRed);
        if (flagHasRed)
          {
            handler.start_pair("Red");
            handler.number_value(storeRed);
          }
        Debug.Assert(partial_allowed || flagHasGreen);
        if (flagHasGreen)
          {
            handler.start_pair("Green");
            handler.number_value(storeGreen);
          }
        Debug.Assert(partial_allowed || flagHasBlue);
        if (flagHasBlue)
          {
            handler.start_pair("Blue");
            handler.number_value(storeBlue);
          }
        Debug.Assert(partial_allowed || flagHasHue);
        if (flagHasHue)
          {
            handler.start_pair("Hue");
            handler.number_value(storeHue);
          }
        Debug.Assert(partial_allowed || flagHasSaturation);
        if (flagHasSaturation)
          {
            handler.start_pair("Saturation");
            handler.number_value(storeSaturation);
          }
        Debug.Assert(partial_allowed || flagHasBrightnessValue);
        if (flagHasBrightnessValue)
          {
            handler.start_pair("BrightnessValue");
            handler.number_value(storeBrightnessValue);
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
        if (!(hasRed()))
          {
            return "When parsing the object for %what%, the \"Red\" field was missing.";
          }
        if (!(hasGreen()))
          {
            return "When parsing the object for %what%, the \"Green\" field was missing.";
          }
        if (!(hasBlue()))
          {
            return "When parsing the object for %what%, the \"Blue\" field was missing.";
          }
        if (!(hasHue()))
          {
            return "When parsing the object for %what%, the \"Hue\" field was missing.";
          }
        if (!(hasSaturation()))
          {
            return "When parsing the object for %what%, the \"Saturation\" field was missing.";
          }
        if (!(hasBrightnessValue()))
          {
            return "When parsing the object for %what%, the \"BrightnessValue\" field was missing.";
          }
        return null;
      }

    public static ColorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ColorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Color", ignore_extras);
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
    public static ColorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ColorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ColorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Color", ignore_extras);
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
    public static ColorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ColorJSON from_text(string text, bool ignore_extras)
      {
        ColorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Color", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ColorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ColorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ColorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Color", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
    private class FieldHoldingGeneratorRed : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorRed(String what) : base(what, 0, 255)
              {
              }
          };
    private class FieldHoldingArrayGeneratorRed : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorRed(String what) : base(what, 0, 255)
              {
              }
          };
        private FieldHoldingGeneratorRed fieldGeneratorRed;
    private class FieldHoldingGeneratorGreen : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorGreen(String what) : base(what, 0, 255)
              {
              }
          };
    private class FieldHoldingArrayGeneratorGreen : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorGreen(String what) : base(what, 0, 255)
              {
              }
          };
        private FieldHoldingGeneratorGreen fieldGeneratorGreen;
    private class FieldHoldingGeneratorBlue : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorBlue(String what) : base(what, 0, 255)
              {
              }
          };
    private class FieldHoldingArrayGeneratorBlue : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorBlue(String what) : base(what, 0, 255)
              {
              }
          };
        private FieldHoldingGeneratorBlue fieldGeneratorBlue;
    private class FieldHoldingGeneratorHue : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorHue(String what) : base(what, 0, 359)
              {
              }
          };
    private class FieldHoldingArrayGeneratorHue : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorHue(String what) : base(what, 0, 359)
              {
              }
          };
        private FieldHoldingGeneratorHue fieldGeneratorHue;
    private class FieldHoldingGeneratorSaturation : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorSaturation(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorSaturation : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorSaturation(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorSaturation fieldGeneratorSaturation;
    private class FieldHoldingGeneratorBrightnessValue : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorBrightnessValue(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorBrightnessValue : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorBrightnessValue(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorBrightnessValue fieldGeneratorBrightnessValue;

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
            ColorJSON result = new ColorJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(ColorJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            if (fieldGeneratorRed.have_value)
              {
                result.setRed((byte)(fieldGeneratorRed.value));
                fieldGeneratorRed.have_value = false;
              }
            else if ((!(result.hasRed())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Red\" field was missing.");
              }
            if (fieldGeneratorGreen.have_value)
              {
                result.setGreen((byte)(fieldGeneratorGreen.value));
                fieldGeneratorGreen.have_value = false;
              }
            else if ((!(result.hasGreen())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Green\" field was missing.");
              }
            if (fieldGeneratorBlue.have_value)
              {
                result.setBlue((byte)(fieldGeneratorBlue.value));
                fieldGeneratorBlue.have_value = false;
              }
            else if ((!(result.hasBlue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Blue\" field was missing.");
              }
            if (fieldGeneratorHue.have_value)
              {
                result.setHue((short)(fieldGeneratorHue.value));
                fieldGeneratorHue.have_value = false;
              }
            else if ((!(result.hasHue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Hue\" field was missing.");
              }
            if (fieldGeneratorSaturation.have_value)
              {
                result.setSaturation((sbyte)(fieldGeneratorSaturation.value));
                fieldGeneratorSaturation.have_value = false;
              }
            else if ((!(result.hasSaturation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Saturation\" field was missing.");
              }
            if (fieldGeneratorBrightnessValue.have_value)
              {
                result.setBrightnessValue((sbyte)(fieldGeneratorBrightnessValue.value));
                fieldGeneratorBrightnessValue.have_value = false;
              }
            else if ((!(result.hasBrightnessValue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"BrightnessValue\" field was missing.");
              }
          }
        protected abstract void handle_result(ColorJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "ue", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorBlue;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "ightnessValue", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorBrightnessValue;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "reen", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorGreen;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "ue", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorHue;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ed", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorRed;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "aturation", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorSaturation;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the Color class");
            fieldGeneratorRed = new FieldHoldingGeneratorRed("field \"Red\" of the Color class");
            fieldGeneratorGreen = new FieldHoldingGeneratorGreen("field \"Green\" of the Color class");
            fieldGeneratorBlue = new FieldHoldingGeneratorBlue("field \"Blue\" of the Color class");
            fieldGeneratorHue = new FieldHoldingGeneratorHue("field \"Hue\" of the Color class");
            fieldGeneratorSaturation = new FieldHoldingGeneratorSaturation("field \"Saturation\" of the Color class");
            fieldGeneratorBrightnessValue = new FieldHoldingGeneratorBrightnessValue("field \"BrightnessValue\" of the Color class");
            set_what("the Color class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the Color class");
            fieldGeneratorRed = new FieldHoldingGeneratorRed("field \"Red\" of the Color class");
            fieldGeneratorGreen = new FieldHoldingGeneratorGreen("field \"Green\" of the Color class");
            fieldGeneratorBlue = new FieldHoldingGeneratorBlue("field \"Blue\" of the Color class");
            fieldGeneratorHue = new FieldHoldingGeneratorHue("field \"Hue\" of the Color class");
            fieldGeneratorSaturation = new FieldHoldingGeneratorSaturation("field \"Saturation\" of the Color class");
            fieldGeneratorBrightnessValue = new FieldHoldingGeneratorBrightnessValue("field \"BrightnessValue\" of the Color class");
            set_what("the Color class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorRed.reset();
            fieldGeneratorGreen.reset();
            fieldGeneratorBlue.reset();
            fieldGeneratorHue.reset();
            fieldGeneratorSaturation.reset();
            fieldGeneratorBrightnessValue.reset();
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
        protected override void handle_result(ColorJSON  result)
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
        public ColorJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ColorJSON  result)
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
    protected virtual void handle_result(List<ColorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ColorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ColorJSON>();
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
    public List<ColorJSON> value;
  };
  };
