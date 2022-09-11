/* file "MapLocationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MapLocationJSON : JSONBase
  {
    public enum TypeType
      {
        Type_Continent,
        Type_Country,
        Type_Admin1,
        Type_Admin2,
        Type_City,
        Type_Street_x20_Address,
        Type_Airport,
        Type_Hotel,
        Type_Postal_x20_Code,
        Type_Other
      };

    public static TypeType  stringToType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'd':
                        if (String.Compare(chars, 2, "min", 0, 3, false) == 0)
                          {
                            switch (chars[5])
                              {
                                case '1':
                                    if (chars.Length == 6)
                                        return TypeType.Type_Admin1;
                                    break;
                                case '2':
                                    if (chars.Length == 6)
                                        return TypeType.Type_Admin2;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "rport", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeType.Type_Airport;
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (chars[1])
                  {
                    case 'i':
                        if ((String.Compare(chars, 2, "ty", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeType.Type_City;
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'n':
                                if ((String.Compare(chars, 3, "tinent", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeType.Type_Continent;
                                break;
                            case 'u':
                                if ((String.Compare(chars, 3, "ntry", 0, 4, false) == 0) && (chars.Length == 7))
                                    return TypeType.Type_Country;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'H':
                if ((String.Compare(chars, 1, "otel", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeType.Type_Hotel;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "ther", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeType.Type_Other;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "ostal Code", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeType.Type_Postal_x20_Code;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "treet Address", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeType.Type_Street_x20_Address;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Type' is not one of the legal values.");
      }

    public static string  stringFromType(TypeType the_enum)
      {
        switch (the_enum)
          {
            case TypeType.Type_Continent:
                return "Continent";
            case TypeType.Type_Country:
                return "Country";
            case TypeType.Type_Admin1:
                return "Admin1";
            case TypeType.Type_Admin2:
                return "Admin2";
            case TypeType.Type_City:
                return "City";
            case TypeType.Type_Street_x20_Address:
                return "Street Address";
            case TypeType.Type_Airport:
                return "Airport";
            case TypeType.Type_Hotel:
                return "Hotel";
            case TypeType.Type_Postal_x20_Code:
                return "Postal Code";
            case TypeType.Type_Other:
                return "Other";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeBoundingBoxJSON : JSONBase
      {
        private bool flagHasMinLat;
        private double storeMinLat;
        private string textStoreMinLat;
        private bool flagHasMaxLat;
        private double storeMaxLat;
        private string textStoreMaxLat;
        private bool flagHasMinLon;
        private double storeMinLon;
        private string textStoreMinLon;
        private bool flagHasMaxLon;
        private double storeMaxLon;
        private string textStoreMaxLon;


        private void  fromJSONMinLat(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field MinLat of TypeBoundingBoxJSON is not a number.");
                  }
              }
            setMinLatText(the_rational_text);
          }


        private void  fromJSONMaxLat(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field MaxLat of TypeBoundingBoxJSON is not a number.");
                  }
              }
            setMaxLatText(the_rational_text);
          }


        private void  fromJSONMinLon(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field MinLon of TypeBoundingBoxJSON is not a number.");
                  }
              }
            setMinLonText(the_rational_text);
          }


        private void  fromJSONMaxLon(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field MaxLon of TypeBoundingBoxJSON is not a number.");
                  }
              }
            setMaxLonText(the_rational_text);
          }


        public TypeBoundingBoxJSON()
          {
            flagHasMinLat = false;
            flagHasMaxLat = false;
            flagHasMinLon = false;
            flagHasMaxLon = false;
          }

        public bool  hasMinLat()
          {
            return flagHasMinLat;
          }

        public double  getMinLat()
          {
            Debug.Assert(flagHasMinLat);
            if (textStoreMinLat != "")
              {
                return Double.Parse(textStoreMinLat);
              }
            return storeMinLat;
          }

        public string  getMinLatAsText()
          {
            Debug.Assert(flagHasMinLat);
            if (textStoreMinLat == "")
              {
                return Convert.ToString(storeMinLat);
              }
            else
              {
                return (textStoreMinLat);
              }
          }

        public bool  hasMaxLat()
          {
            return flagHasMaxLat;
          }

        public double  getMaxLat()
          {
            Debug.Assert(flagHasMaxLat);
            if (textStoreMaxLat != "")
              {
                return Double.Parse(textStoreMaxLat);
              }
            return storeMaxLat;
          }

        public string  getMaxLatAsText()
          {
            Debug.Assert(flagHasMaxLat);
            if (textStoreMaxLat == "")
              {
                return Convert.ToString(storeMaxLat);
              }
            else
              {
                return (textStoreMaxLat);
              }
          }

        public bool  hasMinLon()
          {
            return flagHasMinLon;
          }

        public double  getMinLon()
          {
            Debug.Assert(flagHasMinLon);
            if (textStoreMinLon != "")
              {
                return Double.Parse(textStoreMinLon);
              }
            return storeMinLon;
          }

        public string  getMinLonAsText()
          {
            Debug.Assert(flagHasMinLon);
            if (textStoreMinLon == "")
              {
                return Convert.ToString(storeMinLon);
              }
            else
              {
                return (textStoreMinLon);
              }
          }

        public bool  hasMaxLon()
          {
            return flagHasMaxLon;
          }

        public double  getMaxLon()
          {
            Debug.Assert(flagHasMaxLon);
            if (textStoreMaxLon != "")
              {
                return Double.Parse(textStoreMaxLon);
              }
            return storeMaxLon;
          }

        public string  getMaxLonAsText()
          {
            Debug.Assert(flagHasMaxLon);
            if (textStoreMaxLon == "")
              {
                return Convert.ToString(storeMaxLon);
              }
            else
              {
                return (textStoreMaxLon);
              }
          }



        public void setMinLat(double new_value)
          {
            flagHasMinLat = true;
            if (new_value < -90)
                throw new Exception("The value for field MinLat of TypeBoundingBoxJSON is less than the lower bound (-90) for that field.");
            if (new_value > 90)
                throw new Exception("The value for field MinLat of TypeBoundingBoxJSON is greater than the upper bound (90) for that field.");
            storeMinLat = new_value;
            textStoreMinLat = "";
          }
        public void setMinLatText(string new_value)
          {
            flagHasMinLat = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field MinLat of TypeBoundingBoxJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "90", "", false, "2") < 0)
                throw new Exception("The value for field MinLat of TypeBoundingBoxJSON is less than the lower bound (-90) for that field.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "90", "", false, "2") > 0)
                throw new Exception("The value for field MinLat of TypeBoundingBoxJSON is greater than the upper bound (90) for that field.");
            textStoreMinLat = new_value;
          }
        public void unsetMinLat()
          {
            flagHasMinLat = false;
          }
        public void setMaxLat(double new_value)
          {
            flagHasMaxLat = true;
            if (new_value < -90)
                throw new Exception("The value for field MaxLat of TypeBoundingBoxJSON is less than the lower bound (-90) for that field.");
            if (new_value > 90)
                throw new Exception("The value for field MaxLat of TypeBoundingBoxJSON is greater than the upper bound (90) for that field.");
            storeMaxLat = new_value;
            textStoreMaxLat = "";
          }
        public void setMaxLatText(string new_value)
          {
            flagHasMaxLat = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field MaxLat of TypeBoundingBoxJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "90", "", false, "2") < 0)
                throw new Exception("The value for field MaxLat of TypeBoundingBoxJSON is less than the lower bound (-90) for that field.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "90", "", false, "2") > 0)
                throw new Exception("The value for field MaxLat of TypeBoundingBoxJSON is greater than the upper bound (90) for that field.");
            textStoreMaxLat = new_value;
          }
        public void unsetMaxLat()
          {
            flagHasMaxLat = false;
          }
        public void setMinLon(double new_value)
          {
            flagHasMinLon = true;
            if (new_value < -180)
                throw new Exception("The value for field MinLon of TypeBoundingBoxJSON is less than the lower bound (-180) for that field.");
            if (new_value > 180)
                throw new Exception("The value for field MinLon of TypeBoundingBoxJSON is greater than the upper bound (180) for that field.");
            storeMinLon = new_value;
            textStoreMinLon = "";
          }
        public void setMinLonText(string new_value)
          {
            flagHasMinLon = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field MinLon of TypeBoundingBoxJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "180", "", false, "3") < 0)
                throw new Exception("The value for field MinLon of TypeBoundingBoxJSON is less than the lower bound (-180) for that field.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "180", "", false, "3") > 0)
                throw new Exception("The value for field MinLon of TypeBoundingBoxJSON is greater than the upper bound (180) for that field.");
            textStoreMinLon = new_value;
          }
        public void unsetMinLon()
          {
            flagHasMinLon = false;
          }
        public void setMaxLon(double new_value)
          {
            flagHasMaxLon = true;
            if (new_value < -180)
                throw new Exception("The value for field MaxLon of TypeBoundingBoxJSON is less than the lower bound (-180) for that field.");
            if (new_value > 180)
                throw new Exception("The value for field MaxLon of TypeBoundingBoxJSON is greater than the upper bound (180) for that field.");
            storeMaxLon = new_value;
            textStoreMaxLon = "";
          }
        public void setMaxLonText(string new_value)
          {
            flagHasMaxLon = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field MaxLon of TypeBoundingBoxJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "180", "", false, "3") < 0)
                throw new Exception("The value for field MaxLon of TypeBoundingBoxJSON is less than the lower bound (-180) for that field.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "180", "", false, "3") > 0)
                throw new Exception("The value for field MaxLon of TypeBoundingBoxJSON is greater than the upper bound (180) for that field.");
            textStoreMaxLon = new_value;
          }
        public void unsetMaxLon()
          {
            flagHasMaxLon = false;
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
            Debug.Assert(partial_allowed || flagHasMinLat);
            if (flagHasMinLat)
              {
                handler.start_pair("MinLat");
                if (textStoreMinLat != "")
                    handler.number_value(textStoreMinLat);
                else if (((double)(long)storeMinLat) == storeMinLat)
                    handler.number_value((long)storeMinLat);
                else
                    handler.number_value(storeMinLat);
              }
            Debug.Assert(partial_allowed || flagHasMaxLat);
            if (flagHasMaxLat)
              {
                handler.start_pair("MaxLat");
                if (textStoreMaxLat != "")
                    handler.number_value(textStoreMaxLat);
                else if (((double)(long)storeMaxLat) == storeMaxLat)
                    handler.number_value((long)storeMaxLat);
                else
                    handler.number_value(storeMaxLat);
              }
            Debug.Assert(partial_allowed || flagHasMinLon);
            if (flagHasMinLon)
              {
                handler.start_pair("MinLon");
                if (textStoreMinLon != "")
                    handler.number_value(textStoreMinLon);
                else if (((double)(long)storeMinLon) == storeMinLon)
                    handler.number_value((long)storeMinLon);
                else
                    handler.number_value(storeMinLon);
              }
            Debug.Assert(partial_allowed || flagHasMaxLon);
            if (flagHasMaxLon)
              {
                handler.start_pair("MaxLon");
                if (textStoreMaxLon != "")
                    handler.number_value(textStoreMaxLon);
                else if (((double)(long)storeMaxLon) == storeMaxLon)
                    handler.number_value((long)storeMaxLon);
                else
                    handler.number_value(storeMaxLon);
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
            if (!(hasMinLat()))
              {
                return "When parsing the object for %what%, the \"MinLat\" field was missing.";
              }
            if (!(hasMaxLat()))
              {
                return "When parsing the object for %what%, the \"MaxLat\" field was missing.";
              }
            if (!(hasMinLon()))
              {
                return "When parsing the object for %what%, the \"MinLon\" field was missing.";
              }
            if (!(hasMaxLon()))
              {
                return "When parsing the object for %what%, the \"MaxLon\" field was missing.";
              }
            return null;
          }

        public static TypeBoundingBoxJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeBoundingBoxJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeBoundingBox", ignore_extras);
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
        public static TypeBoundingBoxJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeBoundingBoxJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeBoundingBoxJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeBoundingBox", ignore_extras);
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
        public static TypeBoundingBoxJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeBoundingBoxJSON from_text(string text, bool ignore_extras)
          {
            TypeBoundingBoxJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeBoundingBox", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeBoundingBoxJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeBoundingBoxJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeBoundingBoxJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeBoundingBox", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingNumberTextGenerator fieldGeneratorMinLat;
            private JSONHoldingNumberTextGenerator fieldGeneratorMaxLat;
            private JSONHoldingNumberTextGenerator fieldGeneratorMinLon;
            private JSONHoldingNumberTextGenerator fieldGeneratorMaxLon;

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
                TypeBoundingBoxJSON result = new TypeBoundingBoxJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeBoundingBoxJSON result)
              {
                if (fieldGeneratorMinLat.have_value)
                  {
                    result.setMinLatText(fieldGeneratorMinLat.value);
                    fieldGeneratorMinLat.have_value = false;
                  }
                else if ((!(result.hasMinLat())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"MinLat\" field was missing.");
                  }
                if (fieldGeneratorMaxLat.have_value)
                  {
                    result.setMaxLatText(fieldGeneratorMaxLat.value);
                    fieldGeneratorMaxLat.have_value = false;
                  }
                else if ((!(result.hasMaxLat())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"MaxLat\" field was missing.");
                  }
                if (fieldGeneratorMinLon.have_value)
                  {
                    result.setMinLonText(fieldGeneratorMinLon.value);
                    fieldGeneratorMinLon.have_value = false;
                  }
                else if ((!(result.hasMinLon())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"MinLon\" field was missing.");
                  }
                if (fieldGeneratorMaxLon.have_value)
                  {
                    result.setMaxLonText(fieldGeneratorMaxLon.value);
                    fieldGeneratorMaxLon.have_value = false;
                  }
                else if ((!(result.hasMaxLon())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"MaxLon\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeBoundingBoxJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "M", 0, 1, false) == 0)
                  {
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "xL", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'a':
                                        if ((String.Compare(field_name, 5, "t", 0, 1, false) == 0) && (field_name.Length == 6))
                                            return fieldGeneratorMaxLat;
                                        break;
                                    case 'o':
                                        if ((String.Compare(field_name, 5, "n", 0, 1, false) == 0) && (field_name.Length == 6))
                                            return fieldGeneratorMaxLon;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if (String.Compare(field_name, 2, "nL", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'a':
                                        if ((String.Compare(field_name, 5, "t", 0, 1, false) == 0) && (field_name.Length == 6))
                                            return fieldGeneratorMinLat;
                                        break;
                                    case 'o':
                                        if ((String.Compare(field_name, 5, "n", 0, 1, false) == 0) && (field_name.Length == 6))
                                            return fieldGeneratorMinLon;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorMinLat = new JSONHoldingNumberTextGenerator("field \"MinLat\" of the TypeBoundingBox class");
                fieldGeneratorMaxLat = new JSONHoldingNumberTextGenerator("field \"MaxLat\" of the TypeBoundingBox class");
                fieldGeneratorMinLon = new JSONHoldingNumberTextGenerator("field \"MinLon\" of the TypeBoundingBox class");
                fieldGeneratorMaxLon = new JSONHoldingNumberTextGenerator("field \"MaxLon\" of the TypeBoundingBox class");
                set_what("the TypeBoundingBox class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorMinLat = new JSONHoldingNumberTextGenerator("field \"MinLat\" of the TypeBoundingBox class");
                fieldGeneratorMaxLat = new JSONHoldingNumberTextGenerator("field \"MaxLat\" of the TypeBoundingBox class");
                fieldGeneratorMinLon = new JSONHoldingNumberTextGenerator("field \"MinLon\" of the TypeBoundingBox class");
                fieldGeneratorMaxLon = new JSONHoldingNumberTextGenerator("field \"MaxLon\" of the TypeBoundingBox class");
                set_what("the TypeBoundingBox class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorMinLat.reset();
                fieldGeneratorMaxLat.reset();
                fieldGeneratorMinLon.reset();
                fieldGeneratorMaxLon.reset();
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
            protected override void handle_result(TypeBoundingBoxJSON  result)
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
            public TypeBoundingBoxJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeBoundingBoxJSON  result)
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
        protected virtual void handle_result(List<TypeBoundingBoxJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeBoundingBoxJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeBoundingBoxJSON>();
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
        public List<TypeBoundingBoxJSON> value;
      };
      };
    public class TypeLinksJSON : JSONBase
      {
        private bool flagHasLabel;
        private string storeLabel;
        private bool flagHasURL;
        private string storeURL;


        private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Label of TypeLinksJSON is not a string.");
            setLabel(json_string.getData());
          }


        private void  fromJSONURL(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field URL of TypeLinksJSON is not a string.");
            setURL(json_string.getData());
          }


        public TypeLinksJSON()
          {
            flagHasLabel = false;
            flagHasURL = false;
          }

        public bool  hasLabel()
          {
            return flagHasLabel;
          }

        public string  getLabel()
          {
            Debug.Assert(flagHasLabel);
            return storeLabel;
          }

        public bool  hasURL()
          {
            return flagHasURL;
          }

        public string  getURL()
          {
            Debug.Assert(flagHasURL);
            return storeURL;
          }



        public void setLabel(string new_value)
          {
            flagHasLabel = true;
            storeLabel = new_value;
          }
        public void unsetLabel()
          {
            flagHasLabel = false;
          }
        public void setURL(string new_value)
          {
            flagHasURL = true;
            storeURL = new_value;
          }
        public void unsetURL()
          {
            flagHasURL = false;
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
            Debug.Assert(partial_allowed || flagHasLabel);
            if (flagHasLabel)
              {
                handler.start_pair("Label");
                handler.string_value(storeLabel);
              }
            Debug.Assert(partial_allowed || flagHasURL);
            if (flagHasURL)
              {
                handler.start_pair("URL");
                handler.string_value(storeURL);
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
            if (!(hasLabel()))
              {
                return "When parsing the object for %what%, the \"Label\" field was missing.";
              }
            if (!(hasURL()))
              {
                return "When parsing the object for %what%, the \"URL\" field was missing.";
              }
            return null;
          }

        public static TypeLinksJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLinksJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLinks", ignore_extras);
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
        public static TypeLinksJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLinksJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLinksJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLinks", ignore_extras);
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
        public static TypeLinksJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLinksJSON from_text(string text, bool ignore_extras)
          {
            TypeLinksJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLinks", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeLinksJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeLinksJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeLinksJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLinks", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorLabel;
            private JSONHoldingStringGenerator fieldGeneratorURL;

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
                TypeLinksJSON result = new TypeLinksJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeLinksJSON result)
              {
                if (fieldGeneratorLabel.have_value)
                  {
                    result.setLabel(fieldGeneratorLabel.value);
                    fieldGeneratorLabel.have_value = false;
                  }
                else if ((!(result.hasLabel())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Label\" field was missing.");
                  }
                if (fieldGeneratorURL.have_value)
                  {
                    result.setURL(fieldGeneratorURL.value);
                    fieldGeneratorURL.have_value = false;
                  }
                else if ((!(result.hasURL())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"URL\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeLinksJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorLabel;
                        break;
                    case 'U':
                        if ((String.Compare(field_name, 1, "RL", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorURL;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the TypeLinks class");
                fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the TypeLinks class");
                set_what("the TypeLinks class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the TypeLinks class");
                fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the TypeLinks class");
                set_what("the TypeLinks class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorLabel.reset();
                fieldGeneratorURL.reset();
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
            protected override void handle_result(TypeLinksJSON  result)
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
            public TypeLinksJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeLinksJSON  result)
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
        protected virtual void handle_result(List<TypeLinksJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeLinksJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeLinksJSON>();
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
        public List<TypeLinksJSON> value;
      };
      };
    public enum TypeOtherTypeKnownValues
      {
        OtherType_Island,
        OtherType_Islands,
        OtherType_Local_x20_Business,
        OtherType_Neighborhood,
        OtherType_Borough,
        OtherType__none
      };
    public struct TypeOtherType
      {
        public bool in_known_list;
        public string string_value;
        public TypeOtherTypeKnownValues list_value;
      };

    public static TypeOtherTypeKnownValues  stringToOtherType(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "orough", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeOtherTypeKnownValues.OtherType_Borough;
                break;
            case 'I':
                if (String.Compare(chars, 1, "sland", 0, 5, false) == 0)
                  {
                    if (chars.Length == 6)
                      {
                        return TypeOtherTypeKnownValues.OtherType_Island;
                      }
                    switch (chars[6])
                      {
                        case 's':
                            if (chars.Length == 7)
                                return TypeOtherTypeKnownValues.OtherType_Islands;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ocal Business", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeOtherTypeKnownValues.OtherType_Local_x20_Business;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "eighborhood", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeOtherTypeKnownValues.OtherType_Neighborhood;
                break;
            default:
                break;
          }
        return TypeOtherTypeKnownValues.OtherType__none;
      }

    public static string  stringFromOtherType(TypeOtherTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeOtherTypeKnownValues.OtherType_Island:
                return "Island";
            case TypeOtherTypeKnownValues.OtherType_Islands:
                return "Islands";
            case TypeOtherTypeKnownValues.OtherType_Local_x20_Business:
                return "Local Business";
            case TypeOtherTypeKnownValues.OtherType_Neighborhood:
                return "Neighborhood";
            case TypeOtherTypeKnownValues.OtherType_Borough:
                return "Borough";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypePronunciationsJSON : JSONBase
      {
        private bool flagHasPhoneme;
        private string storePhoneme;
        private bool flagHasPhonemeAlphabet;
        private string storePhonemeAlphabet;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONPhoneme(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Phoneme of TypePronunciationsJSON is not a string.");
            setPhoneme(json_string.getData());
          }


        private void  fromJSONPhonemeAlphabet(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PhonemeAlphabet of TypePronunciationsJSON is not a string.");
            setPhonemeAlphabet(json_string.getData());
          }


        public TypePronunciationsJSON()
          {
            flagHasPhoneme = false;
            flagHasPhonemeAlphabet = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasPhoneme()
          {
            return flagHasPhoneme;
          }

        public string  getPhoneme()
          {
            Debug.Assert(flagHasPhoneme);
            return storePhoneme;
          }

        public bool  hasPhonemeAlphabet()
          {
            return flagHasPhonemeAlphabet;
          }

        public string  getPhonemeAlphabet()
          {
            Debug.Assert(flagHasPhonemeAlphabet);
            return storePhonemeAlphabet;
          }


        public virtual int extraTypePronunciationsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePronunciationsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePronunciationsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePronunciationsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setPhoneme(string new_value)
          {
            flagHasPhoneme = true;
            storePhoneme = new_value;
          }
        public void unsetPhoneme()
          {
            flagHasPhoneme = false;
          }
        public void setPhonemeAlphabet(string new_value)
          {
            flagHasPhonemeAlphabet = true;
            storePhonemeAlphabet = new_value;
          }
        public void unsetPhonemeAlphabet()
          {
            flagHasPhonemeAlphabet = false;
          }

        public virtual void extraTypePronunciationsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePronunciationsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePronunciationsLookup(key);
            if (old_field == null)
              {
                extraTypePronunciationsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasPhoneme);
            if (flagHasPhoneme)
              {
                handler.start_pair("Phoneme");
                handler.string_value(storePhoneme);
              }
            Debug.Assert(partial_allowed || flagHasPhonemeAlphabet);
            if (flagHasPhonemeAlphabet)
              {
                handler.start_pair("PhonemeAlphabet");
                handler.string_value(storePhonemeAlphabet);
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
            if (!(hasPhoneme()))
              {
                return "When parsing the object for %what%, the \"Phoneme\" field was missing.";
              }
            if (!(hasPhonemeAlphabet()))
              {
                return "When parsing the object for %what%, the \"PhonemeAlphabet\" field was missing.";
              }
            return null;
          }

        public static TypePronunciationsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePronunciationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePronunciations", ignore_extras);
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
        public static TypePronunciationsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePronunciationsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePronunciationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePronunciations", ignore_extras);
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
        public static TypePronunciationsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePronunciationsJSON from_text(string text, bool ignore_extras)
          {
            TypePronunciationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePronunciations", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePronunciationsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePronunciationsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePronunciationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePronunciations", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorPhoneme;
            private JSONHoldingStringGenerator fieldGeneratorPhonemeAlphabet;
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
                TypePronunciationsJSON result = new TypePronunciationsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePronunciationsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePronunciationsJSON result)
              {
                if (fieldGeneratorPhoneme.have_value)
                  {
                    result.setPhoneme(fieldGeneratorPhoneme.value);
                    fieldGeneratorPhoneme.have_value = false;
                  }
                else if ((!(result.hasPhoneme())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Phoneme\" field was missing.");
                  }
                if (fieldGeneratorPhonemeAlphabet.have_value)
                  {
                    result.setPhonemeAlphabet(fieldGeneratorPhonemeAlphabet.value);
                    fieldGeneratorPhonemeAlphabet.have_value = false;
                  }
                else if ((!(result.hasPhonemeAlphabet())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"PhonemeAlphabet\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypePronunciationsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "Phoneme", 0, 7, false) == 0)
                  {
                    if (field_name.Length == 7)
                      {
                        return fieldGeneratorPhoneme;
                      }
                    switch (field_name[7])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 8, "lphabet", 0, 7, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorPhonemeAlphabet;
                            break;
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorPhoneme = new JSONHoldingStringGenerator("field \"Phoneme\" of the TypePronunciations class");
                fieldGeneratorPhonemeAlphabet = new JSONHoldingStringGenerator("field \"PhonemeAlphabet\" of the TypePronunciations class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePronunciations class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorPhoneme = new JSONHoldingStringGenerator("field \"Phoneme\" of the TypePronunciations class");
                fieldGeneratorPhonemeAlphabet = new JSONHoldingStringGenerator("field \"PhonemeAlphabet\" of the TypePronunciations class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePronunciations class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorPhoneme.reset();
                fieldGeneratorPhonemeAlphabet.reset();
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
            protected override void handle_result(TypePronunciationsJSON  result)
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
            public TypePronunciationsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePronunciationsJSON  result)
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
        protected virtual void handle_result(List<TypePronunciationsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePronunciationsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePronunciationsJSON>();
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
        public List<TypePronunciationsJSON> value;
      };
      };
    private bool flagHasIsFictional;
    private bool storeIsFictional;
    private bool flagHasIsOnEarthsSurface;
    private bool storeIsOnEarthsSurface;
    private bool flagHasType;
    private TypeType storeType;
    private bool flagHasLabel;
    private string storeLabel;
    private bool flagHasSpokenLabel;
    private string storeSpokenLabel;
    private bool flagHasAddress;
    private string storeAddress;
    private bool flagHasStreetNumber;
    private string storeStreetNumber;
    private bool flagHasStreetSecondaryNumber;
    private string storeStreetSecondaryNumber;
    private bool flagHasStreetName;
    private string storeStreetName;
    private bool flagHasCity;
    private string storeCity;
    private bool flagHasAdmin2;
    private string storeAdmin2;
    private bool flagHasAdmin1;
    private string storeAdmin1;
    private bool flagHasCountry;
    private string storeCountry;
    private bool flagHasCountryCode;
    private string storeCountryCode;
    private bool flagHasPostalCode;
    private string storePostalCode;
    private bool flagHasIATA;
    private string storeIATA;
    private bool flagHasICAO;
    private string storeICAO;
    private bool flagHasGeohash;
    private string storeGeohash;
    private bool flagHasVerified;
    private bool storeVerified;
    private bool flagHasHighConfidence;
    private bool storeHighConfidence;
    private bool flagHasCurrentLocation;
    private bool storeCurrentLocation;
    private bool flagHasLatitude;
    private double storeLatitude;
    private string textStoreLatitude;
    private bool flagHasLongitude;
    private double storeLongitude;
    private string textStoreLongitude;
    private bool flagHasCoordinatesAreApproximate;
    private bool storeCoordinatesAreApproximate;
    private bool flagHasCoordinatesAreAdjusted;
    private bool storeCoordinatesAreAdjusted;
    private bool flagHasReferenceDatum;
    private string storeReferenceDatum;
    private bool flagHasTimeZone;
    private string storeTimeZone;
    private bool flagHasRadius;
    private double storeRadius;
    private string textStoreRadius;
    private bool flagHasBoundingBox;
    private TypeBoundingBoxJSON  storeBoundingBox;
    private bool flagHasLinks;
    private List< TypeLinksJSON  > storeLinks;
    private bool flagHasTypeID;
    private BigInteger storeTypeID;
    private bool flagHasSourceID;
    private BigInteger storeSourceID;
    private bool flagHasRecordID;
    private BigInteger storeRecordID;
    private bool flagHasRecordIDString;
    private string storeRecordIDString;
    private bool flagHasSource;
    private string storeSource;
    private bool flagHasPointOfInterestName;
    private string storePointOfInterestName;
    private bool flagHasOtherType;
    private TypeOtherType storeOtherType;
    private bool flagHasPronunciations;
    private List< TypePronunciationsJSON  > storePronunciations;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONIsFictional(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsFictional of MapLocationJSON is not true for false.");
              }
          }
        setIsFictional(the_bool);
      }


    private void  fromJSONIsOnEarthsSurface(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsOnEarthsSurface of MapLocationJSON is not true for false.");
              }
          }
        setIsOnEarthsSurface(the_bool);
      }


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Type of MapLocationJSON is not a string.");
        TypeType the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'd':
                        if (String.Compare(json_string.getData(), 2, "min", 0, 3, false) == 0)
                          {
                            switch (json_string.getData()[5])
                              {
                                case '1':
                                    if (json_string.getData().Length == 6)
                                          {
                                            the_enum = TypeType.Type_Admin1;
                                            goto enum_is_done;
                                          }
                                    break;
                                case '2':
                                    if (json_string.getData().Length == 6)
                                          {
                                            the_enum = TypeType.Type_Admin2;
                                            goto enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "rport", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_enum = TypeType.Type_Airport;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "ty", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_enum = TypeType.Type_City;
                                goto enum_is_done;
                              }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'n':
                                if ((String.Compare(json_string.getData(), 3, "tinent", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_enum = TypeType.Type_Continent;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'u':
                                if ((String.Compare(json_string.getData(), 3, "ntry", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_enum = TypeType.Type_Country;
                                        goto enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "otel", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeType.Type_Hotel;
                        goto enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "ther", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeType.Type_Other;
                        goto enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "ostal Code", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeType.Type_Postal_x20_Code;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "treet Address", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_enum = TypeType.Type_Street_x20_Address;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Type of MapLocationJSON is not one of the legal strings.");
      enum_is_done:;
        setType(the_enum);
      }


    private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Label of MapLocationJSON is not a string.");
        setLabel(json_string.getData());
      }


    private void  fromJSONSpokenLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenLabel of MapLocationJSON is not a string.");
        setSpokenLabel(json_string.getData());
      }


    private void  fromJSONAddress(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Address of MapLocationJSON is not a string.");
        setAddress(json_string.getData());
      }


    private void  fromJSONStreetNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StreetNumber of MapLocationJSON is not a string.");
        setStreetNumber(json_string.getData());
      }


    private void  fromJSONStreetSecondaryNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StreetSecondaryNumber of MapLocationJSON is not a string.");
        setStreetSecondaryNumber(json_string.getData());
      }


    private void  fromJSONStreetName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StreetName of MapLocationJSON is not a string.");
        setStreetName(json_string.getData());
      }


    private void  fromJSONCity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field City of MapLocationJSON is not a string.");
        setCity(json_string.getData());
      }


    private void  fromJSONAdmin2(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Admin2 of MapLocationJSON is not a string.");
        setAdmin2(json_string.getData());
      }


    private void  fromJSONAdmin1(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Admin1 of MapLocationJSON is not a string.");
        setAdmin1(json_string.getData());
      }


    private void  fromJSONCountry(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Country of MapLocationJSON is not a string.");
        setCountry(json_string.getData());
      }


    private void  fromJSONCountryCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CountryCode of MapLocationJSON is not a string.");
        setCountryCode(json_string.getData());
      }


    private void  fromJSONPostalCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PostalCode of MapLocationJSON is not a string.");
        setPostalCode(json_string.getData());
      }


    private void  fromJSONIATA(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field IATA of MapLocationJSON is not a string.");
        setIATA(json_string.getData());
      }


    private void  fromJSONICAO(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ICAO of MapLocationJSON is not a string.");
        setICAO(json_string.getData());
      }


    private void  fromJSONGeohash(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Geohash of MapLocationJSON is not a string.");
        setGeohash(json_string.getData());
      }


    private void  fromJSONVerified(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Verified of MapLocationJSON is not true for false.");
              }
          }
        setVerified(the_bool);
      }


    private void  fromJSONHighConfidence(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HighConfidence of MapLocationJSON is not true for false.");
              }
          }
        setHighConfidence(the_bool);
      }


    private void  fromJSONCurrentLocation(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CurrentLocation of MapLocationJSON is not true for false.");
              }
          }
        setCurrentLocation(the_bool);
      }


    private void  fromJSONLatitude(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Latitude of MapLocationJSON is not a number.");
              }
          }
        setLatitudeText(the_rational_text);
      }


    private void  fromJSONLongitude(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Longitude of MapLocationJSON is not a number.");
              }
          }
        setLongitudeText(the_rational_text);
      }


    private void  fromJSONCoordinatesAreApproximate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CoordinatesAreApproximate of MapLocationJSON is not true for false.");
              }
          }
        setCoordinatesAreApproximate(the_bool);
      }


    private void  fromJSONCoordinatesAreAdjusted(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CoordinatesAreAdjusted of MapLocationJSON is not true for false.");
              }
          }
        setCoordinatesAreAdjusted(the_bool);
      }


    private void  fromJSONReferenceDatum(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ReferenceDatum of MapLocationJSON is not a string.");
        setReferenceDatum(json_string.getData());
      }


    private void  fromJSONTimeZone(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TimeZone of MapLocationJSON is not a string.");
        setTimeZone(json_string.getData());
      }


    private void  fromJSONRadius(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Radius of MapLocationJSON is not a number.");
              }
          }
        setRadiusText(the_rational_text);
      }


    private void  fromJSONBoundingBox(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeBoundingBoxJSON convert_classy = TypeBoundingBoxJSON.from_json(json_value, ignore_extras, true);
        setBoundingBox(convert_classy);
      }


    private void  fromJSONLinks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Links of MapLocationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeLinksJSON  > vector_Links1 = new List< TypeLinksJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeLinksJSON convert_classy = TypeLinksJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Links1.Add(convert_classy);
          }
        initLinks();
        for (int num1 = 0; num1 < vector_Links1.Count; ++num1)
            appendLinks(vector_Links1[num1]);
        for (int num1 = 0; num1 < vector_Links1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTypeID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TypeID of MapLocationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TypeID of MapLocationJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTypeID(extracted_integer);
      }


    private void  fromJSONSourceID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SourceID of MapLocationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SourceID of MapLocationJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSourceID(extracted_integer);
      }


    private void  fromJSONRecordID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field RecordID of MapLocationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RecordID of MapLocationJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRecordID(extracted_integer);
      }


    private void  fromJSONRecordIDString(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RecordIDString of MapLocationJSON is not a string.");
        setRecordIDString(json_string.getData());
      }


    private void  fromJSONSource(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Source of MapLocationJSON is not a string.");
        setSource(json_string.getData());
      }


    private void  fromJSONPointOfInterestName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PointOfInterestName of MapLocationJSON is not a string.");
        setPointOfInterestName(json_string.getData());
      }


    private void  fromJSONOtherType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OtherType of MapLocationJSON is not a string.");
        TypeOtherType the_open_enum = new TypeOtherType();
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "orough", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeOtherTypeKnownValues.OtherType_Borough;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if (String.Compare(json_string.getData(), 1, "sland", 0, 5, false) == 0)
                  {
                    if (json_string.getData().Length == 6)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeOtherTypeKnownValues.OtherType_Island;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[6])
                      {
                        case 's':
                            if (json_string.getData().Length == 7)
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeOtherTypeKnownValues.OtherType_Islands;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ocal Business", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeOtherTypeKnownValues.OtherType_Local_x20_Business;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "eighborhood", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeOtherTypeKnownValues.OtherType_Neighborhood;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setOtherType(the_open_enum);
      }


    private void  fromJSONPronunciations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Pronunciations of MapLocationJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Pronunciations of MapLocationJSON has too few elements.");
        List< TypePronunciationsJSON  > vector_Pronunciations1 = new List< TypePronunciationsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypePronunciationsJSON convert_classy = TypePronunciationsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Pronunciations1.Add(convert_classy);
          }
        Debug.Assert(vector_Pronunciations1.Count >= 1);
        initPronunciations();
        for (int num2 = 0; num2 < vector_Pronunciations1.Count; ++num2)
            appendPronunciations(vector_Pronunciations1[num2]);
        for (int num1 = 0; num1 < vector_Pronunciations1.Count; ++num1)
          {
          }
      }


    public MapLocationJSON()
      {
        flagHasIsFictional = false;
        flagHasIsOnEarthsSurface = false;
        flagHasType = false;
        flagHasLabel = false;
        flagHasSpokenLabel = false;
        flagHasAddress = false;
        flagHasStreetNumber = false;
        flagHasStreetSecondaryNumber = false;
        flagHasStreetName = false;
        flagHasCity = false;
        flagHasAdmin2 = false;
        flagHasAdmin1 = false;
        flagHasCountry = false;
        flagHasCountryCode = false;
        flagHasPostalCode = false;
        flagHasIATA = false;
        flagHasICAO = false;
        flagHasGeohash = false;
        flagHasVerified = false;
        flagHasHighConfidence = false;
        flagHasCurrentLocation = false;
        flagHasLatitude = false;
        flagHasLongitude = false;
        flagHasCoordinatesAreApproximate = false;
        flagHasCoordinatesAreAdjusted = false;
        flagHasReferenceDatum = false;
        flagHasTimeZone = false;
        flagHasRadius = false;
        flagHasBoundingBox = false;
        flagHasLinks = false;
        flagHasTypeID = false;
        flagHasSourceID = false;
        flagHasRecordID = false;
        flagHasRecordIDString = false;
        flagHasSource = false;
        flagHasPointOfInterestName = false;
        flagHasOtherType = false;
        flagHasPronunciations = false;
        storeIsFictional = false;
        storeIsOnEarthsSurface = true;
        storeReferenceDatum = "WGS84";
        storeLinks = new List< TypeLinksJSON  >();
        storePronunciations = new List< TypePronunciationsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasIsFictional()
      {
        return flagHasIsFictional;
      }

    public bool  getIsFictional()
      {
        return storeIsFictional;
      }

    public bool  hasIsOnEarthsSurface()
      {
        return flagHasIsOnEarthsSurface;
      }

    public bool  getIsOnEarthsSurface()
      {
        return storeIsOnEarthsSurface;
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public TypeType  getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public string  getTypeAsString()
      {
        return stringFromType(getType());
      }

    public bool  hasLabel()
      {
        return flagHasLabel;
      }

    public string  getLabel()
      {
        Debug.Assert(flagHasLabel);
        return storeLabel;
      }

    public bool  hasSpokenLabel()
      {
        return flagHasSpokenLabel;
      }

    public string  getSpokenLabel()
      {
        Debug.Assert(flagHasSpokenLabel);
        return storeSpokenLabel;
      }

    public bool  hasAddress()
      {
        return flagHasAddress;
      }

    public string  getAddress()
      {
        Debug.Assert(flagHasAddress);
        return storeAddress;
      }

    public bool  hasStreetNumber()
      {
        return flagHasStreetNumber;
      }

    public string  getStreetNumber()
      {
        Debug.Assert(flagHasStreetNumber);
        return storeStreetNumber;
      }

    public bool  hasStreetSecondaryNumber()
      {
        return flagHasStreetSecondaryNumber;
      }

    public string  getStreetSecondaryNumber()
      {
        Debug.Assert(flagHasStreetSecondaryNumber);
        return storeStreetSecondaryNumber;
      }

    public bool  hasStreetName()
      {
        return flagHasStreetName;
      }

    public string  getStreetName()
      {
        Debug.Assert(flagHasStreetName);
        return storeStreetName;
      }

    public bool  hasCity()
      {
        return flagHasCity;
      }

    public string  getCity()
      {
        Debug.Assert(flagHasCity);
        return storeCity;
      }

    public bool  hasAdmin2()
      {
        return flagHasAdmin2;
      }

    public string  getAdmin2()
      {
        Debug.Assert(flagHasAdmin2);
        return storeAdmin2;
      }

    public bool  hasAdmin1()
      {
        return flagHasAdmin1;
      }

    public string  getAdmin1()
      {
        Debug.Assert(flagHasAdmin1);
        return storeAdmin1;
      }

    public bool  hasCountry()
      {
        return flagHasCountry;
      }

    public string  getCountry()
      {
        Debug.Assert(flagHasCountry);
        return storeCountry;
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

    public bool  hasPostalCode()
      {
        return flagHasPostalCode;
      }

    public string  getPostalCode()
      {
        Debug.Assert(flagHasPostalCode);
        return storePostalCode;
      }

    public bool  hasIATA()
      {
        return flagHasIATA;
      }

    public string  getIATA()
      {
        Debug.Assert(flagHasIATA);
        return storeIATA;
      }

    public bool  hasICAO()
      {
        return flagHasICAO;
      }

    public string  getICAO()
      {
        Debug.Assert(flagHasICAO);
        return storeICAO;
      }

    public bool  hasGeohash()
      {
        return flagHasGeohash;
      }

    public string  getGeohash()
      {
        Debug.Assert(flagHasGeohash);
        return storeGeohash;
      }

    public bool  hasVerified()
      {
        return flagHasVerified;
      }

    public bool  getVerified()
      {
        Debug.Assert(flagHasVerified);
        return storeVerified;
      }

    public bool  hasHighConfidence()
      {
        return flagHasHighConfidence;
      }

    public bool  getHighConfidence()
      {
        Debug.Assert(flagHasHighConfidence);
        return storeHighConfidence;
      }

    public bool  hasCurrentLocation()
      {
        return flagHasCurrentLocation;
      }

    public bool  getCurrentLocation()
      {
        Debug.Assert(flagHasCurrentLocation);
        return storeCurrentLocation;
      }

    public bool  hasLatitude()
      {
        return flagHasLatitude;
      }

    public double  getLatitude()
      {
        Debug.Assert(flagHasLatitude);
        if (textStoreLatitude != "")
          {
            return Double.Parse(textStoreLatitude);
          }
        return storeLatitude;
      }

    public string  getLatitudeAsText()
      {
        Debug.Assert(flagHasLatitude);
        if (textStoreLatitude == "")
          {
            return Convert.ToString(storeLatitude);
          }
        else
          {
            return (textStoreLatitude);
          }
      }

    public bool  hasLongitude()
      {
        return flagHasLongitude;
      }

    public double  getLongitude()
      {
        Debug.Assert(flagHasLongitude);
        if (textStoreLongitude != "")
          {
            return Double.Parse(textStoreLongitude);
          }
        return storeLongitude;
      }

    public string  getLongitudeAsText()
      {
        Debug.Assert(flagHasLongitude);
        if (textStoreLongitude == "")
          {
            return Convert.ToString(storeLongitude);
          }
        else
          {
            return (textStoreLongitude);
          }
      }

    public bool  hasCoordinatesAreApproximate()
      {
        return flagHasCoordinatesAreApproximate;
      }

    public bool  getCoordinatesAreApproximate()
      {
        Debug.Assert(flagHasCoordinatesAreApproximate);
        return storeCoordinatesAreApproximate;
      }

    public bool  hasCoordinatesAreAdjusted()
      {
        return flagHasCoordinatesAreAdjusted;
      }

    public bool  getCoordinatesAreAdjusted()
      {
        Debug.Assert(flagHasCoordinatesAreAdjusted);
        return storeCoordinatesAreAdjusted;
      }

    public bool  hasReferenceDatum()
      {
        return flagHasReferenceDatum;
      }

    public string  getReferenceDatum()
      {
        return storeReferenceDatum;
      }

    public bool  hasTimeZone()
      {
        return flagHasTimeZone;
      }

    public string  getTimeZone()
      {
        Debug.Assert(flagHasTimeZone);
        return storeTimeZone;
      }

    public bool  hasRadius()
      {
        return flagHasRadius;
      }

    public double  getRadius()
      {
        Debug.Assert(flagHasRadius);
        if (textStoreRadius != "")
          {
            return Double.Parse(textStoreRadius);
          }
        return storeRadius;
      }

    public string  getRadiusAsText()
      {
        Debug.Assert(flagHasRadius);
        if (textStoreRadius == "")
          {
            return Convert.ToString(storeRadius);
          }
        else
          {
            return (textStoreRadius);
          }
      }

    public bool  hasBoundingBox()
      {
        return flagHasBoundingBox;
      }

    public TypeBoundingBoxJSON   getBoundingBox()
      {
        Debug.Assert(flagHasBoundingBox);
        return storeBoundingBox;
      }

    public bool  hasLinks()
      {
        return flagHasLinks;
      }

    public int  countOfLinks()
      {
        Debug.Assert(flagHasLinks);
        return storeLinks.Count;
      }

    public TypeLinksJSON   elementOfLinks(int element_num)
      {
        Debug.Assert(flagHasLinks);
        return storeLinks[element_num];
      }

    public List< TypeLinksJSON  >  getLinks()
      {
        Debug.Assert(flagHasLinks);
        return storeLinks;
      }

    public bool  hasTypeID()
      {
        return flagHasTypeID;
      }

    public BigInteger  getTypeID()
      {
        Debug.Assert(flagHasTypeID);
        return storeTypeID;
      }

    public bool  hasSourceID()
      {
        return flagHasSourceID;
      }

    public BigInteger  getSourceID()
      {
        Debug.Assert(flagHasSourceID);
        return storeSourceID;
      }

    public bool  hasRecordID()
      {
        return flagHasRecordID;
      }

    public BigInteger  getRecordID()
      {
        Debug.Assert(flagHasRecordID);
        return storeRecordID;
      }

    public bool  hasRecordIDString()
      {
        return flagHasRecordIDString;
      }

    public string  getRecordIDString()
      {
        Debug.Assert(flagHasRecordIDString);
        return storeRecordIDString;
      }

    public bool  hasSource()
      {
        return flagHasSource;
      }

    public string  getSource()
      {
        Debug.Assert(flagHasSource);
        return storeSource;
      }

    public bool  hasPointOfInterestName()
      {
        return flagHasPointOfInterestName;
      }

    public string  getPointOfInterestName()
      {
        Debug.Assert(flagHasPointOfInterestName);
        return storePointOfInterestName;
      }

    public bool  hasOtherType()
      {
        return flagHasOtherType;
      }

    public TypeOtherType  getOtherType()
      {
        Debug.Assert(flagHasOtherType);
        return storeOtherType;
      }

    public string  getOtherTypeAsString()
      {
        TypeOtherType result = getOtherType();
        if (result.in_known_list)
            return stringFromOtherType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasPronunciations()
      {
        return flagHasPronunciations;
      }

    public int  countOfPronunciations()
      {
        Debug.Assert(flagHasPronunciations);
        return storePronunciations.Count;
      }

    public TypePronunciationsJSON   elementOfPronunciations(int element_num)
      {
        Debug.Assert(flagHasPronunciations);
        return storePronunciations[element_num];
      }

    public List< TypePronunciationsJSON  >  getPronunciations()
      {
        Debug.Assert(flagHasPronunciations);
        return storePronunciations;
      }


    public virtual int extraMapLocationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMapLocationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMapLocationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMapLocationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setIsFictional(bool new_value)
      {
        flagHasIsFictional = true;
        storeIsFictional = new_value;
      }
    public void unsetIsFictional()
      {
        flagHasIsFictional = false;
      }
    public void setIsOnEarthsSurface(bool new_value)
      {
        flagHasIsOnEarthsSurface = true;
        storeIsOnEarthsSurface = new_value;
      }
    public void unsetIsOnEarthsSurface()
      {
        flagHasIsOnEarthsSurface = false;
      }
    public void setType(TypeType new_value)
      {
        flagHasType = true;
        storeType = new_value;
      }
    public void setType(string chars)
      {
        setType(stringToType(chars));
      }
    public void unsetType()
      {
        flagHasType = false;
      }
    public void setLabel(string new_value)
      {
        flagHasLabel = true;
        storeLabel = new_value;
      }
    public void unsetLabel()
      {
        flagHasLabel = false;
      }
    public void setSpokenLabel(string new_value)
      {
        flagHasSpokenLabel = true;
        storeSpokenLabel = new_value;
      }
    public void unsetSpokenLabel()
      {
        flagHasSpokenLabel = false;
      }
    public void setAddress(string new_value)
      {
        flagHasAddress = true;
        storeAddress = new_value;
      }
    public void unsetAddress()
      {
        flagHasAddress = false;
      }
    public void setStreetNumber(string new_value)
      {
        flagHasStreetNumber = true;
        storeStreetNumber = new_value;
      }
    public void unsetStreetNumber()
      {
        flagHasStreetNumber = false;
      }
    public void setStreetSecondaryNumber(string new_value)
      {
        flagHasStreetSecondaryNumber = true;
        storeStreetSecondaryNumber = new_value;
      }
    public void unsetStreetSecondaryNumber()
      {
        flagHasStreetSecondaryNumber = false;
      }
    public void setStreetName(string new_value)
      {
        flagHasStreetName = true;
        storeStreetName = new_value;
      }
    public void unsetStreetName()
      {
        flagHasStreetName = false;
      }
    public void setCity(string new_value)
      {
        flagHasCity = true;
        storeCity = new_value;
      }
    public void unsetCity()
      {
        flagHasCity = false;
      }
    public void setAdmin2(string new_value)
      {
        flagHasAdmin2 = true;
        storeAdmin2 = new_value;
      }
    public void unsetAdmin2()
      {
        flagHasAdmin2 = false;
      }
    public void setAdmin1(string new_value)
      {
        flagHasAdmin1 = true;
        storeAdmin1 = new_value;
      }
    public void unsetAdmin1()
      {
        flagHasAdmin1 = false;
      }
    public void setCountry(string new_value)
      {
        flagHasCountry = true;
        storeCountry = new_value;
      }
    public void unsetCountry()
      {
        flagHasCountry = false;
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
    public void setPostalCode(string new_value)
      {
        flagHasPostalCode = true;
        storePostalCode = new_value;
      }
    public void unsetPostalCode()
      {
        flagHasPostalCode = false;
      }
    public void setIATA(string new_value)
      {
        flagHasIATA = true;
        storeIATA = new_value;
      }
    public void unsetIATA()
      {
        flagHasIATA = false;
      }
    public void setICAO(string new_value)
      {
        flagHasICAO = true;
        storeICAO = new_value;
      }
    public void unsetICAO()
      {
        flagHasICAO = false;
      }
    public void setGeohash(string new_value)
      {
        flagHasGeohash = true;
        storeGeohash = new_value;
      }
    public void unsetGeohash()
      {
        flagHasGeohash = false;
      }
    public void setVerified(bool new_value)
      {
        flagHasVerified = true;
        storeVerified = new_value;
      }
    public void unsetVerified()
      {
        flagHasVerified = false;
      }
    public void setHighConfidence(bool new_value)
      {
        flagHasHighConfidence = true;
        storeHighConfidence = new_value;
      }
    public void unsetHighConfidence()
      {
        flagHasHighConfidence = false;
      }
    public void setCurrentLocation(bool new_value)
      {
        flagHasCurrentLocation = true;
        storeCurrentLocation = new_value;
      }
    public void unsetCurrentLocation()
      {
        flagHasCurrentLocation = false;
      }
    public void setLatitude(double new_value)
      {
        flagHasLatitude = true;
        if (new_value < -90)
            throw new Exception("The value for field Latitude of MapLocationJSON is less than the lower bound (-90) for that field.");
        if (new_value > 90)
            throw new Exception("The value for field Latitude of MapLocationJSON is greater than the upper bound (90) for that field.");
        storeLatitude = new_value;
        textStoreLatitude = "";
      }
    public void setLatitudeText(string new_value)
      {
        flagHasLatitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Latitude of MapLocationJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "90", "", false, "2") < 0)
            throw new Exception("The value for field Latitude of MapLocationJSON is less than the lower bound (-90) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "90", "", false, "2") > 0)
            throw new Exception("The value for field Latitude of MapLocationJSON is greater than the upper bound (90) for that field.");
        textStoreLatitude = new_value;
      }
    public void unsetLatitude()
      {
        flagHasLatitude = false;
      }
    public void setLongitude(double new_value)
      {
        flagHasLongitude = true;
        if (new_value < -180)
            throw new Exception("The value for field Longitude of MapLocationJSON is less than the lower bound (-180) for that field.");
        if (new_value > 180)
            throw new Exception("The value for field Longitude of MapLocationJSON is greater than the upper bound (180) for that field.");
        storeLongitude = new_value;
        textStoreLongitude = "";
      }
    public void setLongitudeText(string new_value)
      {
        flagHasLongitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Longitude of MapLocationJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "180", "", false, "3") < 0)
            throw new Exception("The value for field Longitude of MapLocationJSON is less than the lower bound (-180) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "180", "", false, "3") > 0)
            throw new Exception("The value for field Longitude of MapLocationJSON is greater than the upper bound (180) for that field.");
        textStoreLongitude = new_value;
      }
    public void unsetLongitude()
      {
        flagHasLongitude = false;
      }
    public void setCoordinatesAreApproximate(bool new_value)
      {
        flagHasCoordinatesAreApproximate = true;
        storeCoordinatesAreApproximate = new_value;
      }
    public void unsetCoordinatesAreApproximate()
      {
        flagHasCoordinatesAreApproximate = false;
      }
    public void setCoordinatesAreAdjusted(bool new_value)
      {
        flagHasCoordinatesAreAdjusted = true;
        storeCoordinatesAreAdjusted = new_value;
      }
    public void unsetCoordinatesAreAdjusted()
      {
        flagHasCoordinatesAreAdjusted = false;
      }
    public void setReferenceDatum(string new_value)
      {
        flagHasReferenceDatum = true;
        storeReferenceDatum = new_value;
      }
    public void unsetReferenceDatum()
      {
        flagHasReferenceDatum = false;
      }
    public void setTimeZone(string new_value)
      {
        flagHasTimeZone = true;
        storeTimeZone = new_value;
      }
    public void unsetTimeZone()
      {
        flagHasTimeZone = false;
      }
    public void setRadius(double new_value)
      {
        flagHasRadius = true;
        if (new_value < 0)
            throw new Exception("The value for field Radius of MapLocationJSON is less than the lower bound (0) for that field.");
        storeRadius = new_value;
        textStoreRadius = "";
      }
    public void setRadiusText(string new_value)
      {
        flagHasRadius = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Radius of MapLocationJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Radius of MapLocationJSON is less than the lower bound (0) for that field.");
        textStoreRadius = new_value;
      }
    public void unsetRadius()
      {
        flagHasRadius = false;
      }
    public void setBoundingBox(TypeBoundingBoxJSON  new_value)
      {
        if (flagHasBoundingBox)
          {
          }
        flagHasBoundingBox = true;
        storeBoundingBox = new_value;
      }
    public void unsetBoundingBox()
      {
        if (flagHasBoundingBox)
          {
          }
        flagHasBoundingBox = false;
      }
    public void initLinks()
      {
        if (flagHasLinks)
          {
            for (int num1 = 0; num1 < storeLinks.Count; ++num1)
              {
              }
          }
        flagHasLinks = true;
        storeLinks.Clear();
      }
    public void appendLinks(TypeLinksJSON  to_append)
      {
        if (!flagHasLinks)
          {
            flagHasLinks = true;
            storeLinks.Clear();
          }
        Debug.Assert(flagHasLinks);
        storeLinks.Add(to_append);
      }
    public void unsetLinks()
      {
        if (flagHasLinks)
          {
            for (int num2 = 0; num2 < storeLinks.Count; ++num2)
              {
              }
          }
        flagHasLinks = false;
        storeLinks.Clear();
      }
    public void setTypeID(BigInteger new_value)
      {
        flagHasTypeID = true;
        if (new_value < 0)
            throw new Exception("The value for field TypeID of MapLocationJSON is less than the lower bound (0) for that field.");
        storeTypeID = new_value;
      }
    public void unsetTypeID()
      {
        flagHasTypeID = false;
      }
    public void setSourceID(BigInteger new_value)
      {
        flagHasSourceID = true;
        if (new_value < 0)
            throw new Exception("The value for field SourceID of MapLocationJSON is less than the lower bound (0) for that field.");
        storeSourceID = new_value;
      }
    public void unsetSourceID()
      {
        flagHasSourceID = false;
      }
    public void setRecordID(BigInteger new_value)
      {
        flagHasRecordID = true;
        if (new_value < 0)
            throw new Exception("The value for field RecordID of MapLocationJSON is less than the lower bound (0) for that field.");
        storeRecordID = new_value;
      }
    public void unsetRecordID()
      {
        flagHasRecordID = false;
      }
    public void setRecordIDString(string new_value)
      {
        flagHasRecordIDString = true;
        storeRecordIDString = new_value;
      }
    public void unsetRecordIDString()
      {
        flagHasRecordIDString = false;
      }
    public void setSource(string new_value)
      {
        flagHasSource = true;
        storeSource = new_value;
      }
    public void unsetSource()
      {
        flagHasSource = false;
      }
    public void setPointOfInterestName(string new_value)
      {
        flagHasPointOfInterestName = true;
        storePointOfInterestName = new_value;
      }
    public void unsetPointOfInterestName()
      {
        flagHasPointOfInterestName = false;
      }
    public void setOtherType(TypeOtherType new_value)
      {
        flagHasOtherType = true;
        storeOtherType = new_value;
      }
    public void setOtherType(string chars)
      {
        TypeOtherTypeKnownValues known = stringToOtherType(chars);
        TypeOtherType new_value = new TypeOtherType();
        if (known == TypeOtherTypeKnownValues.OtherType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setOtherType(new_value);
      }
    public void setOtherType(TypeOtherTypeKnownValues new_value)
      {
        TypeOtherType new_full_value = new TypeOtherType();
        Debug.Assert(new_value != TypeOtherTypeKnownValues.OtherType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setOtherType(new_full_value);
      }
    public void unsetOtherType()
      {
        flagHasOtherType = false;
      }
    public void initPronunciations()
      {
        if (flagHasPronunciations)
          {
            for (int num3 = 0; num3 < storePronunciations.Count; ++num3)
              {
              }
          }
        flagHasPronunciations = true;
        storePronunciations.Clear();
      }
    public void appendPronunciations(TypePronunciationsJSON  to_append)
      {
        if (!flagHasPronunciations)
          {
            flagHasPronunciations = true;
            storePronunciations.Clear();
          }
        Debug.Assert(flagHasPronunciations);
        storePronunciations.Add(to_append);
      }
    public void unsetPronunciations()
      {
        if (flagHasPronunciations)
          {
            for (int num4 = 0; num4 < storePronunciations.Count; ++num4)
              {
              }
          }
        flagHasPronunciations = false;
        storePronunciations.Clear();
      }

    public virtual void extraMapLocationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMapLocationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMapLocationLookup(key);
        if (old_field == null)
          {
            extraMapLocationAppendPair(key, new_component);
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
        if (flagHasIsFictional)
          {
            handler.start_pair("IsFictional");
            handler.boolean_value(storeIsFictional);
          }
        if (flagHasIsOnEarthsSurface)
          {
            handler.start_pair("IsOnEarthsSurface");
            handler.boolean_value(storeIsOnEarthsSurface);
          }
        Debug.Assert(partial_allowed || flagHasType);
        if (flagHasType)
          {
            handler.start_pair("Type");
            switch (storeType)
              {
                case TypeType.Type_Continent:
                    handler.string_value("Continent");
                    break;
                case TypeType.Type_Country:
                    handler.string_value("Country");
                    break;
                case TypeType.Type_Admin1:
                    handler.string_value("Admin1");
                    break;
                case TypeType.Type_Admin2:
                    handler.string_value("Admin2");
                    break;
                case TypeType.Type_City:
                    handler.string_value("City");
                    break;
                case TypeType.Type_Street_x20_Address:
                    handler.string_value("Street Address");
                    break;
                case TypeType.Type_Airport:
                    handler.string_value("Airport");
                    break;
                case TypeType.Type_Hotel:
                    handler.string_value("Hotel");
                    break;
                case TypeType.Type_Postal_x20_Code:
                    handler.string_value("Postal Code");
                    break;
                case TypeType.Type_Other:
                    handler.string_value("Other");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasLabel);
        if (flagHasLabel)
          {
            handler.start_pair("Label");
            handler.string_value(storeLabel);
          }
        Debug.Assert(partial_allowed || flagHasSpokenLabel);
        if (flagHasSpokenLabel)
          {
            handler.start_pair("SpokenLabel");
            handler.string_value(storeSpokenLabel);
          }
        if (flagHasAddress)
          {
            handler.start_pair("Address");
            handler.string_value(storeAddress);
          }
        if (flagHasStreetNumber)
          {
            handler.start_pair("StreetNumber");
            handler.string_value(storeStreetNumber);
          }
        if (flagHasStreetSecondaryNumber)
          {
            handler.start_pair("StreetSecondaryNumber");
            handler.string_value(storeStreetSecondaryNumber);
          }
        if (flagHasStreetName)
          {
            handler.start_pair("StreetName");
            handler.string_value(storeStreetName);
          }
        if (flagHasCity)
          {
            handler.start_pair("City");
            handler.string_value(storeCity);
          }
        if (flagHasAdmin2)
          {
            handler.start_pair("Admin2");
            handler.string_value(storeAdmin2);
          }
        if (flagHasAdmin1)
          {
            handler.start_pair("Admin1");
            handler.string_value(storeAdmin1);
          }
        if (flagHasCountry)
          {
            handler.start_pair("Country");
            handler.string_value(storeCountry);
          }
        if (flagHasCountryCode)
          {
            handler.start_pair("CountryCode");
            handler.string_value(storeCountryCode);
          }
        if (flagHasPostalCode)
          {
            handler.start_pair("PostalCode");
            handler.string_value(storePostalCode);
          }
        if (flagHasIATA)
          {
            handler.start_pair("IATA");
            handler.string_value(storeIATA);
          }
        if (flagHasICAO)
          {
            handler.start_pair("ICAO");
            handler.string_value(storeICAO);
          }
        if (flagHasGeohash)
          {
            handler.start_pair("Geohash");
            handler.string_value(storeGeohash);
          }
        Debug.Assert(partial_allowed || flagHasVerified);
        if (flagHasVerified)
          {
            handler.start_pair("Verified");
            handler.boolean_value(storeVerified);
          }
        if (flagHasHighConfidence)
          {
            handler.start_pair("HighConfidence");
            handler.boolean_value(storeHighConfidence);
          }
        Debug.Assert(partial_allowed || flagHasCurrentLocation);
        if (flagHasCurrentLocation)
          {
            handler.start_pair("CurrentLocation");
            handler.boolean_value(storeCurrentLocation);
          }
        if (flagHasLatitude)
          {
            handler.start_pair("Latitude");
            if (textStoreLatitude != "")
                handler.number_value(textStoreLatitude);
            else if (((double)(long)storeLatitude) == storeLatitude)
                handler.number_value((long)storeLatitude);
            else
                handler.number_value(storeLatitude);
          }
        if (flagHasLongitude)
          {
            handler.start_pair("Longitude");
            if (textStoreLongitude != "")
                handler.number_value(textStoreLongitude);
            else if (((double)(long)storeLongitude) == storeLongitude)
                handler.number_value((long)storeLongitude);
            else
                handler.number_value(storeLongitude);
          }
        if (flagHasCoordinatesAreApproximate)
          {
            handler.start_pair("CoordinatesAreApproximate");
            handler.boolean_value(storeCoordinatesAreApproximate);
          }
        if (flagHasCoordinatesAreAdjusted)
          {
            handler.start_pair("CoordinatesAreAdjusted");
            handler.boolean_value(storeCoordinatesAreAdjusted);
          }
        if (flagHasReferenceDatum)
          {
            handler.start_pair("ReferenceDatum");
            handler.string_value(storeReferenceDatum);
          }
        if (flagHasTimeZone)
          {
            handler.start_pair("TimeZone");
            handler.string_value(storeTimeZone);
          }
        Debug.Assert(partial_allowed || flagHasRadius);
        if (flagHasRadius)
          {
            handler.start_pair("Radius");
            if (textStoreRadius != "")
                handler.number_value(textStoreRadius);
            else if (((double)(long)storeRadius) == storeRadius)
                handler.number_value((long)storeRadius);
            else
                handler.number_value(storeRadius);
          }
        if (flagHasBoundingBox)
          {
            handler.start_pair("BoundingBox");
            if (partial_allowed)
                storeBoundingBox.write_partial_as_json(handler);
            else
                storeBoundingBox.write_as_json(handler);
          }
        if (flagHasLinks)
          {
            handler.start_pair("Links");
            handler.start_array();
            for (int num1 = 0; num1 < storeLinks.Count; ++num1)
              {
                if (partial_allowed)
                    storeLinks[num1].write_partial_as_json(handler);
                else
                    storeLinks[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasTypeID)
          {
            handler.start_pair("TypeID");
            handler.number_value(storeTypeID);
          }
        if (flagHasSourceID)
          {
            handler.start_pair("SourceID");
            handler.number_value(storeSourceID);
          }
        if (flagHasRecordID)
          {
            handler.start_pair("RecordID");
            handler.number_value(storeRecordID);
          }
        if (flagHasRecordIDString)
          {
            handler.start_pair("RecordIDString");
            handler.string_value(storeRecordIDString);
          }
        if (flagHasSource)
          {
            handler.start_pair("Source");
            handler.string_value(storeSource);
          }
        if (flagHasPointOfInterestName)
          {
            handler.start_pair("PointOfInterestName");
            handler.string_value(storePointOfInterestName);
          }
        if (flagHasOtherType)
          {
            handler.start_pair("OtherType");
            if (storeOtherType.in_known_list)
              {
                switch (storeOtherType.list_value)
                  {
                    case TypeOtherTypeKnownValues.OtherType_Island:
                        handler.string_value("Island");
                        break;
                    case TypeOtherTypeKnownValues.OtherType_Islands:
                        handler.string_value("Islands");
                        break;
                    case TypeOtherTypeKnownValues.OtherType_Local_x20_Business:
                        handler.string_value("Local Business");
                        break;
                    case TypeOtherTypeKnownValues.OtherType_Neighborhood:
                        handler.string_value("Neighborhood");
                        break;
                    case TypeOtherTypeKnownValues.OtherType_Borough:
                        handler.string_value("Borough");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeOtherType.string_value);
              }
          }
        if (flagHasPronunciations)
          {
            handler.start_pair("Pronunciations");
            Debug.Assert(storePronunciations.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storePronunciations.Count; ++num2)
              {
                if (partial_allowed)
                    storePronunciations[num2].write_partial_as_json(handler);
                else
                    storePronunciations[num2].write_as_json(handler);
              }
            handler.finish_array();
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
        if (!(hasType()))
          {
            return "When parsing the object for %what%, the \"Type\" field was missing.";
          }
        if (!(hasLabel()))
          {
            return "When parsing the object for %what%, the \"Label\" field was missing.";
          }
        if (!(hasSpokenLabel()))
          {
            return "When parsing the object for %what%, the \"SpokenLabel\" field was missing.";
          }
        if (!(hasVerified()))
          {
            return "When parsing the object for %what%, the \"Verified\" field was missing.";
          }
        if (!(hasCurrentLocation()))
          {
            return "When parsing the object for %what%, the \"CurrentLocation\" field was missing.";
          }
        if (!(hasRadius()))
          {
            return "When parsing the object for %what%, the \"Radius\" field was missing.";
          }
        return null;
      }

    public static MapLocationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MapLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapLocation", ignore_extras);
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
    public static MapLocationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MapLocationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MapLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapLocation", ignore_extras);
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
    public static MapLocationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MapLocationJSON from_text(string text, bool ignore_extras)
      {
        MapLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapLocation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MapLocationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MapLocationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MapLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapLocation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorIsFictional;
        private JSONHoldingBooleanGenerator fieldGeneratorIsOnEarthsSurface;
    private abstract class FieldGeneratorType : JSONStringGenerator
          {
            protected FieldGeneratorType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToType(result));
              }
            protected abstract void handle_result(TypeType result);
          };
    private class FieldHoldingGeneratorType : FieldGeneratorType
  {
    protected override void handle_result(TypeType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorType(String what)
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
    public TypeType value;
  };
    private class FieldHoldingArrayGeneratorType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorType
      {
        private FieldHoldingArrayGeneratorType top;

        protected override void handle_result(TypeType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorType init_top)
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
    protected virtual void handle_result(List<TypeType> result)
      {
      }

    public FieldHoldingArrayGeneratorType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeType> value;
  };
        private FieldHoldingGeneratorType fieldGeneratorType;
        private JSONHoldingStringGenerator fieldGeneratorLabel;
        private JSONHoldingStringGenerator fieldGeneratorSpokenLabel;
        private JSONHoldingStringGenerator fieldGeneratorAddress;
        private JSONHoldingStringGenerator fieldGeneratorStreetNumber;
        private JSONHoldingStringGenerator fieldGeneratorStreetSecondaryNumber;
        private JSONHoldingStringGenerator fieldGeneratorStreetName;
        private JSONHoldingStringGenerator fieldGeneratorCity;
        private JSONHoldingStringGenerator fieldGeneratorAdmin2;
        private JSONHoldingStringGenerator fieldGeneratorAdmin1;
        private JSONHoldingStringGenerator fieldGeneratorCountry;
        private JSONHoldingStringGenerator fieldGeneratorCountryCode;
        private JSONHoldingStringGenerator fieldGeneratorPostalCode;
        private JSONHoldingStringGenerator fieldGeneratorIATA;
        private JSONHoldingStringGenerator fieldGeneratorICAO;
        private JSONHoldingStringGenerator fieldGeneratorGeohash;
        private JSONHoldingBooleanGenerator fieldGeneratorVerified;
        private JSONHoldingBooleanGenerator fieldGeneratorHighConfidence;
        private JSONHoldingBooleanGenerator fieldGeneratorCurrentLocation;
        private JSONHoldingNumberTextGenerator fieldGeneratorLatitude;
        private JSONHoldingNumberTextGenerator fieldGeneratorLongitude;
        private JSONHoldingBooleanGenerator fieldGeneratorCoordinatesAreApproximate;
        private JSONHoldingBooleanGenerator fieldGeneratorCoordinatesAreAdjusted;
        private JSONHoldingStringGenerator fieldGeneratorReferenceDatum;
        private JSONHoldingStringGenerator fieldGeneratorTimeZone;
        private JSONHoldingNumberTextGenerator fieldGeneratorRadius;
        private TypeBoundingBoxJSON.HoldingGenerator fieldGeneratorBoundingBox;
        private TypeLinksJSON.HoldingArrayGenerator fieldGeneratorLinks;
    private class FieldHoldingGeneratorTypeID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTypeID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTypeID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTypeID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTypeID fieldGeneratorTypeID;
    private class FieldHoldingGeneratorSourceID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSourceID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSourceID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSourceID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSourceID fieldGeneratorSourceID;
    private class FieldHoldingGeneratorRecordID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRecordID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRecordID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRecordID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorRecordID fieldGeneratorRecordID;
        private JSONHoldingStringGenerator fieldGeneratorRecordIDString;
        private JSONHoldingStringGenerator fieldGeneratorSource;
        private JSONHoldingStringGenerator fieldGeneratorPointOfInterestName;
    private abstract class FieldGeneratorOtherType : JSONStringGenerator
          {
            protected FieldGeneratorOtherType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorOtherType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeOtherTypeKnownValues known = stringToOtherType(result);
                TypeOtherType new_value = new TypeOtherType();
                if (known == TypeOtherTypeKnownValues.OtherType__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeOtherType result);
          };
    private class FieldHoldingGeneratorOtherType : FieldGeneratorOtherType
  {
    protected override void handle_result(TypeOtherType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorOtherType(String what)
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
    public TypeOtherType value;
  };
    private class FieldHoldingArrayGeneratorOtherType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorOtherType
      {
        private FieldHoldingArrayGeneratorOtherType top;

        protected override void handle_result(TypeOtherType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorOtherType init_top)
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
    protected virtual void handle_result(List<TypeOtherType> result)
      {
      }

    public FieldHoldingArrayGeneratorOtherType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeOtherType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorOtherType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeOtherType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeOtherType> value;
  };
        private FieldHoldingGeneratorOtherType fieldGeneratorOtherType;
        private TypePronunciationsJSON.HoldingArrayGenerator fieldGeneratorPronunciations;
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
            MapLocationJSON result = new MapLocationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMapLocationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MapLocationJSON result)
          {
            if (fieldGeneratorIsFictional.have_value)
              {
                result.setIsFictional(fieldGeneratorIsFictional.value);
                fieldGeneratorIsFictional.have_value = false;
              }
            if (fieldGeneratorIsOnEarthsSurface.have_value)
              {
                result.setIsOnEarthsSurface(fieldGeneratorIsOnEarthsSurface.value);
                fieldGeneratorIsOnEarthsSurface.have_value = false;
              }
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
            else if ((!(result.hasType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Type\" field was missing.");
              }
            if (fieldGeneratorLabel.have_value)
              {
                result.setLabel(fieldGeneratorLabel.value);
                fieldGeneratorLabel.have_value = false;
              }
            else if ((!(result.hasLabel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Label\" field was missing.");
              }
            if (fieldGeneratorSpokenLabel.have_value)
              {
                result.setSpokenLabel(fieldGeneratorSpokenLabel.value);
                fieldGeneratorSpokenLabel.have_value = false;
              }
            else if ((!(result.hasSpokenLabel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenLabel\" field was missing.");
              }
            if (fieldGeneratorAddress.have_value)
              {
                result.setAddress(fieldGeneratorAddress.value);
                fieldGeneratorAddress.have_value = false;
              }
            if (fieldGeneratorStreetNumber.have_value)
              {
                result.setStreetNumber(fieldGeneratorStreetNumber.value);
                fieldGeneratorStreetNumber.have_value = false;
              }
            if (fieldGeneratorStreetSecondaryNumber.have_value)
              {
                result.setStreetSecondaryNumber(fieldGeneratorStreetSecondaryNumber.value);
                fieldGeneratorStreetSecondaryNumber.have_value = false;
              }
            if (fieldGeneratorStreetName.have_value)
              {
                result.setStreetName(fieldGeneratorStreetName.value);
                fieldGeneratorStreetName.have_value = false;
              }
            if (fieldGeneratorCity.have_value)
              {
                result.setCity(fieldGeneratorCity.value);
                fieldGeneratorCity.have_value = false;
              }
            if (fieldGeneratorAdmin2.have_value)
              {
                result.setAdmin2(fieldGeneratorAdmin2.value);
                fieldGeneratorAdmin2.have_value = false;
              }
            if (fieldGeneratorAdmin1.have_value)
              {
                result.setAdmin1(fieldGeneratorAdmin1.value);
                fieldGeneratorAdmin1.have_value = false;
              }
            if (fieldGeneratorCountry.have_value)
              {
                result.setCountry(fieldGeneratorCountry.value);
                fieldGeneratorCountry.have_value = false;
              }
            if (fieldGeneratorCountryCode.have_value)
              {
                result.setCountryCode(fieldGeneratorCountryCode.value);
                fieldGeneratorCountryCode.have_value = false;
              }
            if (fieldGeneratorPostalCode.have_value)
              {
                result.setPostalCode(fieldGeneratorPostalCode.value);
                fieldGeneratorPostalCode.have_value = false;
              }
            if (fieldGeneratorIATA.have_value)
              {
                result.setIATA(fieldGeneratorIATA.value);
                fieldGeneratorIATA.have_value = false;
              }
            if (fieldGeneratorICAO.have_value)
              {
                result.setICAO(fieldGeneratorICAO.value);
                fieldGeneratorICAO.have_value = false;
              }
            if (fieldGeneratorGeohash.have_value)
              {
                result.setGeohash(fieldGeneratorGeohash.value);
                fieldGeneratorGeohash.have_value = false;
              }
            if (fieldGeneratorVerified.have_value)
              {
                result.setVerified(fieldGeneratorVerified.value);
                fieldGeneratorVerified.have_value = false;
              }
            else if ((!(result.hasVerified())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Verified\" field was missing.");
              }
            if (fieldGeneratorHighConfidence.have_value)
              {
                result.setHighConfidence(fieldGeneratorHighConfidence.value);
                fieldGeneratorHighConfidence.have_value = false;
              }
            if (fieldGeneratorCurrentLocation.have_value)
              {
                result.setCurrentLocation(fieldGeneratorCurrentLocation.value);
                fieldGeneratorCurrentLocation.have_value = false;
              }
            else if ((!(result.hasCurrentLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CurrentLocation\" field was missing.");
              }
            if (fieldGeneratorLatitude.have_value)
              {
                result.setLatitudeText(fieldGeneratorLatitude.value);
                fieldGeneratorLatitude.have_value = false;
              }
            if (fieldGeneratorLongitude.have_value)
              {
                result.setLongitudeText(fieldGeneratorLongitude.value);
                fieldGeneratorLongitude.have_value = false;
              }
            if (fieldGeneratorCoordinatesAreApproximate.have_value)
              {
                result.setCoordinatesAreApproximate(fieldGeneratorCoordinatesAreApproximate.value);
                fieldGeneratorCoordinatesAreApproximate.have_value = false;
              }
            if (fieldGeneratorCoordinatesAreAdjusted.have_value)
              {
                result.setCoordinatesAreAdjusted(fieldGeneratorCoordinatesAreAdjusted.value);
                fieldGeneratorCoordinatesAreAdjusted.have_value = false;
              }
            if (fieldGeneratorReferenceDatum.have_value)
              {
                result.setReferenceDatum(fieldGeneratorReferenceDatum.value);
                fieldGeneratorReferenceDatum.have_value = false;
              }
            if (fieldGeneratorTimeZone.have_value)
              {
                result.setTimeZone(fieldGeneratorTimeZone.value);
                fieldGeneratorTimeZone.have_value = false;
              }
            if (fieldGeneratorRadius.have_value)
              {
                result.setRadiusText(fieldGeneratorRadius.value);
                fieldGeneratorRadius.have_value = false;
              }
            else if ((!(result.hasRadius())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Radius\" field was missing.");
              }
            if (fieldGeneratorBoundingBox.have_value)
              {
                result.setBoundingBox(fieldGeneratorBoundingBox.value);
                fieldGeneratorBoundingBox.have_value = false;
              }
            if (fieldGeneratorLinks.have_value)
              {
                result.initLinks();
                int count = fieldGeneratorLinks.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendLinks(fieldGeneratorLinks.value[num]);
                  }
                fieldGeneratorLinks.value.Clear();
                fieldGeneratorLinks.have_value = false;
              }
            if (fieldGeneratorTypeID.have_value)
              {
                result.setTypeID(fieldGeneratorTypeID.value);
                fieldGeneratorTypeID.have_value = false;
              }
            if (fieldGeneratorSourceID.have_value)
              {
                result.setSourceID(fieldGeneratorSourceID.value);
                fieldGeneratorSourceID.have_value = false;
              }
            if (fieldGeneratorRecordID.have_value)
              {
                result.setRecordID(fieldGeneratorRecordID.value);
                fieldGeneratorRecordID.have_value = false;
              }
            if (fieldGeneratorRecordIDString.have_value)
              {
                result.setRecordIDString(fieldGeneratorRecordIDString.value);
                fieldGeneratorRecordIDString.have_value = false;
              }
            if (fieldGeneratorSource.have_value)
              {
                result.setSource(fieldGeneratorSource.value);
                fieldGeneratorSource.have_value = false;
              }
            if (fieldGeneratorPointOfInterestName.have_value)
              {
                result.setPointOfInterestName(fieldGeneratorPointOfInterestName.value);
                fieldGeneratorPointOfInterestName.have_value = false;
              }
            if (fieldGeneratorOtherType.have_value)
              {
                result.setOtherType(fieldGeneratorOtherType.value);
                fieldGeneratorOtherType.have_value = false;
              }
            if (fieldGeneratorPronunciations.have_value)
              {
                result.initPronunciations();
                int count = fieldGeneratorPronunciations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPronunciations(fieldGeneratorPronunciations.value[num]);
                  }
                fieldGeneratorPronunciations.value.Clear();
                fieldGeneratorPronunciations.have_value = false;
              }
          }
        protected abstract void handle_result(MapLocationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "d", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'd':
                                if ((String.Compare(field_name, 3, "ress", 0, 4, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorAddress;
                                break;
                            case 'm':
                                if (String.Compare(field_name, 3, "in", 0, 2, false) == 0)
                                  {
                                    switch (field_name[5])
                                      {
                                        case '1':
                                            if (field_name.Length == 6)
                                                return fieldGeneratorAdmin1;
                                            break;
                                        case '2':
                                            if (field_name.Length == 6)
                                                return fieldGeneratorAdmin2;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'B':
                    if ((String.Compare(field_name, 1, "oundingBox", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorBoundingBox;
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "ty", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorCity;
                            break;
                        case 'o':
                            switch (field_name[2])
                              {
                                case 'o':
                                    if (String.Compare(field_name, 3, "rdinatesAreA", 0, 12, false) == 0)
                                      {
                                        switch (field_name[15])
                                          {
                                            case 'd':
                                                if ((String.Compare(field_name, 16, "justed", 0, 6, false) == 0) && (field_name.Length == 22))
                                                    return fieldGeneratorCoordinatesAreAdjusted;
                                                break;
                                            case 'p':
                                                if ((String.Compare(field_name, 16, "proximate", 0, 9, false) == 0) && (field_name.Length == 25))
                                                    return fieldGeneratorCoordinatesAreApproximate;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'u':
                                    if (String.Compare(field_name, 3, "ntry", 0, 4, false) == 0)
                                      {
                                        if (field_name.Length == 7)
                                          {
                                            return fieldGeneratorCountry;
                                          }
                                        switch (field_name[7])
                                          {
                                            case 'C':
                                                if ((String.Compare(field_name, 8, "ode", 0, 3, false) == 0) && (field_name.Length == 11))
                                                    return fieldGeneratorCountryCode;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rrentLocation", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorCurrentLocation;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "eohash", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorGeohash;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "ighConfidence", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorHighConfidence;
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 2, "TA", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorIATA;
                            break;
                        case 'C':
                            if ((String.Compare(field_name, 2, "AO", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorICAO;
                            break;
                        case 's':
                            switch (field_name[2])
                              {
                                case 'F':
                                    if ((String.Compare(field_name, 3, "ictional", 0, 8, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorIsFictional;
                                    break;
                                case 'O':
                                    if ((String.Compare(field_name, 3, "nEarthsSurface", 0, 14, false) == 0) && (field_name.Length == 17))
                                        return fieldGeneratorIsOnEarthsSurface;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    switch (field_name[1])
                      {
                        case 'a':
                            switch (field_name[2])
                              {
                                case 'b':
                                    if ((String.Compare(field_name, 3, "el", 0, 2, false) == 0) && (field_name.Length == 5))
                                        return fieldGeneratorLabel;
                                    break;
                                case 't':
                                    if ((String.Compare(field_name, 3, "itude", 0, 5, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorLatitude;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "nks", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorLinks;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "ngitude", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorLongitude;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "therType", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorOtherType;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'o':
                            switch (field_name[2])
                              {
                                case 'i':
                                    if ((String.Compare(field_name, 3, "ntOfInterestName", 0, 16, false) == 0) && (field_name.Length == 19))
                                        return fieldGeneratorPointOfInterestName;
                                    break;
                                case 's':
                                    if ((String.Compare(field_name, 3, "talCode", 0, 7, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorPostalCode;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "onunciations", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorPronunciations;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'R':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "dius", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorRadius;
                            break;
                        case 'e':
                            switch (field_name[2])
                              {
                                case 'c':
                                    if (String.Compare(field_name, 3, "ordID", 0, 5, false) == 0)
                                      {
                                        if (field_name.Length == 8)
                                          {
                                            return fieldGeneratorRecordID;
                                          }
                                        switch (field_name[8])
                                          {
                                            case 'S':
                                                if ((String.Compare(field_name, 9, "tring", 0, 5, false) == 0) && (field_name.Length == 14))
                                                    return fieldGeneratorRecordIDString;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'f':
                                    if ((String.Compare(field_name, 3, "erenceDatum", 0, 11, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorReferenceDatum;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'o':
                            if (String.Compare(field_name, 2, "urce", 0, 4, false) == 0)
                              {
                                if (field_name.Length == 6)
                                  {
                                    return fieldGeneratorSource;
                                  }
                                switch (field_name[6])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 7, "D", 0, 1, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorSourceID;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenLabel", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorSpokenLabel;
                            break;
                        case 't':
                            if (String.Compare(field_name, 2, "reet", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'N':
                                        switch (field_name[7])
                                          {
                                            case 'a':
                                                if ((String.Compare(field_name, 8, "me", 0, 2, false) == 0) && (field_name.Length == 10))
                                                    return fieldGeneratorStreetName;
                                                break;
                                            case 'u':
                                                if ((String.Compare(field_name, 8, "mber", 0, 4, false) == 0) && (field_name.Length == 12))
                                                    return fieldGeneratorStreetNumber;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 7, "econdaryNumber", 0, 14, false) == 0) && (field_name.Length == 21))
                                            return fieldGeneratorStreetSecondaryNumber;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "meZone", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorTimeZone;
                            break;
                        case 'y':
                            if (String.Compare(field_name, 2, "pe", 0, 2, false) == 0)
                              {
                                if (field_name.Length == 4)
                                  {
                                    return fieldGeneratorType;
                                  }
                                switch (field_name[4])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 5, "D", 0, 1, false) == 0) && (field_name.Length == 6))
                                            return fieldGeneratorTypeID;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "erified", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorVerified;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorIsFictional = new JSONHoldingBooleanGenerator("field \"IsFictional\" of the MapLocation class");
            fieldGeneratorIsOnEarthsSurface = new JSONHoldingBooleanGenerator("field \"IsOnEarthsSurface\" of the MapLocation class");
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the MapLocation class");
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the MapLocation class");
            fieldGeneratorSpokenLabel = new JSONHoldingStringGenerator("field \"SpokenLabel\" of the MapLocation class");
            fieldGeneratorAddress = new JSONHoldingStringGenerator("field \"Address\" of the MapLocation class");
            fieldGeneratorStreetNumber = new JSONHoldingStringGenerator("field \"StreetNumber\" of the MapLocation class");
            fieldGeneratorStreetSecondaryNumber = new JSONHoldingStringGenerator("field \"StreetSecondaryNumber\" of the MapLocation class");
            fieldGeneratorStreetName = new JSONHoldingStringGenerator("field \"StreetName\" of the MapLocation class");
            fieldGeneratorCity = new JSONHoldingStringGenerator("field \"City\" of the MapLocation class");
            fieldGeneratorAdmin2 = new JSONHoldingStringGenerator("field \"Admin2\" of the MapLocation class");
            fieldGeneratorAdmin1 = new JSONHoldingStringGenerator("field \"Admin1\" of the MapLocation class");
            fieldGeneratorCountry = new JSONHoldingStringGenerator("field \"Country\" of the MapLocation class");
            fieldGeneratorCountryCode = new JSONHoldingStringGenerator("field \"CountryCode\" of the MapLocation class");
            fieldGeneratorPostalCode = new JSONHoldingStringGenerator("field \"PostalCode\" of the MapLocation class");
            fieldGeneratorIATA = new JSONHoldingStringGenerator("field \"IATA\" of the MapLocation class");
            fieldGeneratorICAO = new JSONHoldingStringGenerator("field \"ICAO\" of the MapLocation class");
            fieldGeneratorGeohash = new JSONHoldingStringGenerator("field \"Geohash\" of the MapLocation class");
            fieldGeneratorVerified = new JSONHoldingBooleanGenerator("field \"Verified\" of the MapLocation class");
            fieldGeneratorHighConfidence = new JSONHoldingBooleanGenerator("field \"HighConfidence\" of the MapLocation class");
            fieldGeneratorCurrentLocation = new JSONHoldingBooleanGenerator("field \"CurrentLocation\" of the MapLocation class");
            fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the MapLocation class");
            fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the MapLocation class");
            fieldGeneratorCoordinatesAreApproximate = new JSONHoldingBooleanGenerator("field \"CoordinatesAreApproximate\" of the MapLocation class");
            fieldGeneratorCoordinatesAreAdjusted = new JSONHoldingBooleanGenerator("field \"CoordinatesAreAdjusted\" of the MapLocation class");
            fieldGeneratorReferenceDatum = new JSONHoldingStringGenerator("field \"ReferenceDatum\" of the MapLocation class");
            fieldGeneratorTimeZone = new JSONHoldingStringGenerator("field \"TimeZone\" of the MapLocation class");
            fieldGeneratorRadius = new JSONHoldingNumberTextGenerator("field \"Radius\" of the MapLocation class");
            fieldGeneratorBoundingBox = new TypeBoundingBoxJSON.HoldingGenerator("field \"BoundingBox\" of the MapLocation class", ignore_extras);
            fieldGeneratorLinks = new TypeLinksJSON.HoldingArrayGenerator("field \"Links\" of the MapLocation class", ignore_extras);
            fieldGeneratorTypeID = new FieldHoldingGeneratorTypeID("field \"TypeID\" of the MapLocation class");
            fieldGeneratorSourceID = new FieldHoldingGeneratorSourceID("field \"SourceID\" of the MapLocation class");
            fieldGeneratorRecordID = new FieldHoldingGeneratorRecordID("field \"RecordID\" of the MapLocation class");
            fieldGeneratorRecordIDString = new JSONHoldingStringGenerator("field \"RecordIDString\" of the MapLocation class");
            fieldGeneratorSource = new JSONHoldingStringGenerator("field \"Source\" of the MapLocation class");
            fieldGeneratorPointOfInterestName = new JSONHoldingStringGenerator("field \"PointOfInterestName\" of the MapLocation class");
            fieldGeneratorOtherType = new FieldHoldingGeneratorOtherType("field \"OtherType\" of the MapLocation class");
            fieldGeneratorPronunciations = new TypePronunciationsJSON.HoldingArrayGenerator("field \"Pronunciations\" of the MapLocation class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MapLocation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorIsFictional = new JSONHoldingBooleanGenerator("field \"IsFictional\" of the MapLocation class");
            fieldGeneratorIsOnEarthsSurface = new JSONHoldingBooleanGenerator("field \"IsOnEarthsSurface\" of the MapLocation class");
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the MapLocation class");
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the MapLocation class");
            fieldGeneratorSpokenLabel = new JSONHoldingStringGenerator("field \"SpokenLabel\" of the MapLocation class");
            fieldGeneratorAddress = new JSONHoldingStringGenerator("field \"Address\" of the MapLocation class");
            fieldGeneratorStreetNumber = new JSONHoldingStringGenerator("field \"StreetNumber\" of the MapLocation class");
            fieldGeneratorStreetSecondaryNumber = new JSONHoldingStringGenerator("field \"StreetSecondaryNumber\" of the MapLocation class");
            fieldGeneratorStreetName = new JSONHoldingStringGenerator("field \"StreetName\" of the MapLocation class");
            fieldGeneratorCity = new JSONHoldingStringGenerator("field \"City\" of the MapLocation class");
            fieldGeneratorAdmin2 = new JSONHoldingStringGenerator("field \"Admin2\" of the MapLocation class");
            fieldGeneratorAdmin1 = new JSONHoldingStringGenerator("field \"Admin1\" of the MapLocation class");
            fieldGeneratorCountry = new JSONHoldingStringGenerator("field \"Country\" of the MapLocation class");
            fieldGeneratorCountryCode = new JSONHoldingStringGenerator("field \"CountryCode\" of the MapLocation class");
            fieldGeneratorPostalCode = new JSONHoldingStringGenerator("field \"PostalCode\" of the MapLocation class");
            fieldGeneratorIATA = new JSONHoldingStringGenerator("field \"IATA\" of the MapLocation class");
            fieldGeneratorICAO = new JSONHoldingStringGenerator("field \"ICAO\" of the MapLocation class");
            fieldGeneratorGeohash = new JSONHoldingStringGenerator("field \"Geohash\" of the MapLocation class");
            fieldGeneratorVerified = new JSONHoldingBooleanGenerator("field \"Verified\" of the MapLocation class");
            fieldGeneratorHighConfidence = new JSONHoldingBooleanGenerator("field \"HighConfidence\" of the MapLocation class");
            fieldGeneratorCurrentLocation = new JSONHoldingBooleanGenerator("field \"CurrentLocation\" of the MapLocation class");
            fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the MapLocation class");
            fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the MapLocation class");
            fieldGeneratorCoordinatesAreApproximate = new JSONHoldingBooleanGenerator("field \"CoordinatesAreApproximate\" of the MapLocation class");
            fieldGeneratorCoordinatesAreAdjusted = new JSONHoldingBooleanGenerator("field \"CoordinatesAreAdjusted\" of the MapLocation class");
            fieldGeneratorReferenceDatum = new JSONHoldingStringGenerator("field \"ReferenceDatum\" of the MapLocation class");
            fieldGeneratorTimeZone = new JSONHoldingStringGenerator("field \"TimeZone\" of the MapLocation class");
            fieldGeneratorRadius = new JSONHoldingNumberTextGenerator("field \"Radius\" of the MapLocation class");
            fieldGeneratorBoundingBox = new TypeBoundingBoxJSON.HoldingGenerator("field \"BoundingBox\" of the MapLocation class", false);
            fieldGeneratorLinks = new TypeLinksJSON.HoldingArrayGenerator("field \"Links\" of the MapLocation class", false);
            fieldGeneratorTypeID = new FieldHoldingGeneratorTypeID("field \"TypeID\" of the MapLocation class");
            fieldGeneratorSourceID = new FieldHoldingGeneratorSourceID("field \"SourceID\" of the MapLocation class");
            fieldGeneratorRecordID = new FieldHoldingGeneratorRecordID("field \"RecordID\" of the MapLocation class");
            fieldGeneratorRecordIDString = new JSONHoldingStringGenerator("field \"RecordIDString\" of the MapLocation class");
            fieldGeneratorSource = new JSONHoldingStringGenerator("field \"Source\" of the MapLocation class");
            fieldGeneratorPointOfInterestName = new JSONHoldingStringGenerator("field \"PointOfInterestName\" of the MapLocation class");
            fieldGeneratorOtherType = new FieldHoldingGeneratorOtherType("field \"OtherType\" of the MapLocation class");
            fieldGeneratorPronunciations = new TypePronunciationsJSON.HoldingArrayGenerator("field \"Pronunciations\" of the MapLocation class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MapLocation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorIsFictional.reset();
            fieldGeneratorIsOnEarthsSurface.reset();
            fieldGeneratorType.reset();
            fieldGeneratorLabel.reset();
            fieldGeneratorSpokenLabel.reset();
            fieldGeneratorAddress.reset();
            fieldGeneratorStreetNumber.reset();
            fieldGeneratorStreetSecondaryNumber.reset();
            fieldGeneratorStreetName.reset();
            fieldGeneratorCity.reset();
            fieldGeneratorAdmin2.reset();
            fieldGeneratorAdmin1.reset();
            fieldGeneratorCountry.reset();
            fieldGeneratorCountryCode.reset();
            fieldGeneratorPostalCode.reset();
            fieldGeneratorIATA.reset();
            fieldGeneratorICAO.reset();
            fieldGeneratorGeohash.reset();
            fieldGeneratorVerified.reset();
            fieldGeneratorHighConfidence.reset();
            fieldGeneratorCurrentLocation.reset();
            fieldGeneratorLatitude.reset();
            fieldGeneratorLongitude.reset();
            fieldGeneratorCoordinatesAreApproximate.reset();
            fieldGeneratorCoordinatesAreAdjusted.reset();
            fieldGeneratorReferenceDatum.reset();
            fieldGeneratorTimeZone.reset();
            fieldGeneratorRadius.reset();
            fieldGeneratorBoundingBox.reset();
            fieldGeneratorLinks.reset();
            fieldGeneratorTypeID.reset();
            fieldGeneratorSourceID.reset();
            fieldGeneratorRecordID.reset();
            fieldGeneratorRecordIDString.reset();
            fieldGeneratorSource.reset();
            fieldGeneratorPointOfInterestName.reset();
            fieldGeneratorOtherType.reset();
            fieldGeneratorPronunciations.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorBoundingBox.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLinks.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPronunciations.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorBoundingBox.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLinks.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPronunciations.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MapLocationJSON  result)
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
        public MapLocationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MapLocationJSON  result)
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
    protected virtual void handle_result(List<MapLocationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MapLocationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MapLocationJSON>();
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
    public List<MapLocationJSON> value;
  };
  };
