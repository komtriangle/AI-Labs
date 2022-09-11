/* file "HotelJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HotelJSON : JSONBase
  {
    public enum TypeDistanceFromReferenceUnit
      {
        DistanceFromReferenceUnit_km,
        DistanceFromReferenceUnit_mi
      };

    public static TypeDistanceFromReferenceUnit  stringToDistanceFromReferenceUnit(string chars)
      {
        switch (chars[0])
          {
            case 'k':
                if ((String.Compare(chars, 1, "m", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeDistanceFromReferenceUnit.DistanceFromReferenceUnit_km;
                break;
            case 'm':
                if ((String.Compare(chars, 1, "i", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeDistanceFromReferenceUnit.DistanceFromReferenceUnit_mi;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `DistanceFromReferenceUnit' is not one of the legal values.");
      }

    public static string  stringFromDistanceFromReferenceUnit(TypeDistanceFromReferenceUnit the_enum)
      {
        switch (the_enum)
          {
            case TypeDistanceFromReferenceUnit.DistanceFromReferenceUnit_km:
                return "km";
            case TypeDistanceFromReferenceUnit.DistanceFromReferenceUnit_mi:
                return "mi";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeHotelLocationJSON : JSONBase
      {
        private bool flagHasStreetAddress;
        private string storeStreetAddress;
        private bool flagHasCity;
        private string storeCity;
        private bool flagHasProvince;
        private string storeProvince;
        private bool flagHasCountry;
        private string storeCountry;
        private bool flagHasLatitude;
        private double storeLatitude;
        private string textStoreLatitude;
        private bool flagHasLongitude;
        private double storeLongitude;
        private string textStoreLongitude;


        private void  fromJSONStreetAddress(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field StreetAddress of TypeHotelLocationJSON is not a string.");
            setStreetAddress(json_string.getData());
          }


        private void  fromJSONCity(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field City of TypeHotelLocationJSON is not a string.");
            setCity(json_string.getData());
          }


        private void  fromJSONProvince(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Province of TypeHotelLocationJSON is not a string.");
            setProvince(json_string.getData());
          }


        private void  fromJSONCountry(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Country of TypeHotelLocationJSON is not a string.");
            setCountry(json_string.getData());
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
                    throw new Exception("The value for field Latitude of TypeHotelLocationJSON is not a number.");
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
                    throw new Exception("The value for field Longitude of TypeHotelLocationJSON is not a number.");
                  }
              }
            setLongitudeText(the_rational_text);
          }


        public TypeHotelLocationJSON()
          {
            flagHasStreetAddress = false;
            flagHasCity = false;
            flagHasProvince = false;
            flagHasCountry = false;
            flagHasLatitude = false;
            flagHasLongitude = false;
          }

        public bool  hasStreetAddress()
          {
            return flagHasStreetAddress;
          }

        public string  getStreetAddress()
          {
            Debug.Assert(flagHasStreetAddress);
            return storeStreetAddress;
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

        public bool  hasProvince()
          {
            return flagHasProvince;
          }

        public string  getProvince()
          {
            Debug.Assert(flagHasProvince);
            return storeProvince;
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



        public void setStreetAddress(string new_value)
          {
            flagHasStreetAddress = true;
            storeStreetAddress = new_value;
          }
        public void unsetStreetAddress()
          {
            flagHasStreetAddress = false;
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
        public void setProvince(string new_value)
          {
            flagHasProvince = true;
            storeProvince = new_value;
          }
        public void unsetProvince()
          {
            flagHasProvince = false;
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
        public void setLatitude(double new_value)
          {
            flagHasLatitude = true;
            if (new_value < -90)
                throw new Exception("The value for field Latitude of TypeHotelLocationJSON is less than the lower bound (-90) for that field.");
            if (new_value > 90)
                throw new Exception("The value for field Latitude of TypeHotelLocationJSON is greater than the upper bound (90) for that field.");
            storeLatitude = new_value;
            textStoreLatitude = "";
          }
        public void setLatitudeText(string new_value)
          {
            flagHasLatitude = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Latitude of TypeHotelLocationJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "90", "", false, "2") < 0)
                throw new Exception("The value for field Latitude of TypeHotelLocationJSON is less than the lower bound (-90) for that field.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "90", "", false, "2") > 0)
                throw new Exception("The value for field Latitude of TypeHotelLocationJSON is greater than the upper bound (90) for that field.");
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
                throw new Exception("The value for field Longitude of TypeHotelLocationJSON is less than the lower bound (-180) for that field.");
            if (new_value > 180)
                throw new Exception("The value for field Longitude of TypeHotelLocationJSON is greater than the upper bound (180) for that field.");
            storeLongitude = new_value;
            textStoreLongitude = "";
          }
        public void setLongitudeText(string new_value)
          {
            flagHasLongitude = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Longitude of TypeHotelLocationJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "180", "", false, "3") < 0)
                throw new Exception("The value for field Longitude of TypeHotelLocationJSON is less than the lower bound (-180) for that field.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "180", "", false, "3") > 0)
                throw new Exception("The value for field Longitude of TypeHotelLocationJSON is greater than the upper bound (180) for that field.");
            textStoreLongitude = new_value;
          }
        public void unsetLongitude()
          {
            flagHasLongitude = false;
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
            if (flagHasStreetAddress)
              {
                handler.start_pair("StreetAddress");
                handler.string_value(storeStreetAddress);
              }
            if (flagHasCity)
              {
                handler.start_pair("City");
                handler.string_value(storeCity);
              }
            if (flagHasProvince)
              {
                handler.start_pair("Province");
                handler.string_value(storeProvince);
              }
            if (flagHasCountry)
              {
                handler.start_pair("Country");
                handler.string_value(storeCountry);
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
          }
        public override void write_partial_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler, true);
            handler.finish_object();
          }
        public virtual string missing_field_error(bool allow_unpolished)
          {
            return null;
          }

        public static TypeHotelLocationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHotelLocationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelLocation", ignore_extras);
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
        public static TypeHotelLocationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHotelLocationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHotelLocationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelLocation", ignore_extras);
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
        public static TypeHotelLocationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHotelLocationJSON from_text(string text, bool ignore_extras)
          {
            TypeHotelLocationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelLocation", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeHotelLocationJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeHotelLocationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeHotelLocationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelLocation", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorStreetAddress;
            private JSONHoldingStringGenerator fieldGeneratorCity;
            private JSONHoldingStringGenerator fieldGeneratorProvince;
            private JSONHoldingStringGenerator fieldGeneratorCountry;
            private JSONHoldingNumberTextGenerator fieldGeneratorLatitude;
            private JSONHoldingNumberTextGenerator fieldGeneratorLongitude;

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
                TypeHotelLocationJSON result = new TypeHotelLocationJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeHotelLocationJSON result)
              {
                if (fieldGeneratorStreetAddress.have_value)
                  {
                    result.setStreetAddress(fieldGeneratorStreetAddress.value);
                    fieldGeneratorStreetAddress.have_value = false;
                  }
                if (fieldGeneratorCity.have_value)
                  {
                    result.setCity(fieldGeneratorCity.value);
                    fieldGeneratorCity.have_value = false;
                  }
                if (fieldGeneratorProvince.have_value)
                  {
                    result.setProvince(fieldGeneratorProvince.value);
                    fieldGeneratorProvince.have_value = false;
                  }
                if (fieldGeneratorCountry.have_value)
                  {
                    result.setCountry(fieldGeneratorCountry.value);
                    fieldGeneratorCountry.have_value = false;
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
              }
            protected abstract void handle_result(TypeHotelLocationJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        switch (field_name[1])
                          {
                            case 'i':
                                if ((String.Compare(field_name, 2, "ty", 0, 2, false) == 0) && (field_name.Length == 4))
                                    return fieldGeneratorCity;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 2, "untry", 0, 5, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorCountry;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'L':
                        switch (field_name[1])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 2, "titude", 0, 6, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorLatitude;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 2, "ngitude", 0, 7, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorLongitude;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "rovince", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorProvince;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "treetAddress", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorStreetAddress;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorStreetAddress = new JSONHoldingStringGenerator("field \"StreetAddress\" of the TypeHotelLocation class");
                fieldGeneratorCity = new JSONHoldingStringGenerator("field \"City\" of the TypeHotelLocation class");
                fieldGeneratorProvince = new JSONHoldingStringGenerator("field \"Province\" of the TypeHotelLocation class");
                fieldGeneratorCountry = new JSONHoldingStringGenerator("field \"Country\" of the TypeHotelLocation class");
                fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the TypeHotelLocation class");
                fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the TypeHotelLocation class");
                set_what("the TypeHotelLocation class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorStreetAddress = new JSONHoldingStringGenerator("field \"StreetAddress\" of the TypeHotelLocation class");
                fieldGeneratorCity = new JSONHoldingStringGenerator("field \"City\" of the TypeHotelLocation class");
                fieldGeneratorProvince = new JSONHoldingStringGenerator("field \"Province\" of the TypeHotelLocation class");
                fieldGeneratorCountry = new JSONHoldingStringGenerator("field \"Country\" of the TypeHotelLocation class");
                fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the TypeHotelLocation class");
                fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the TypeHotelLocation class");
                set_what("the TypeHotelLocation class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorStreetAddress.reset();
                fieldGeneratorCity.reset();
                fieldGeneratorProvince.reset();
                fieldGeneratorCountry.reset();
                fieldGeneratorLatitude.reset();
                fieldGeneratorLongitude.reset();
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
            protected override void handle_result(TypeHotelLocationJSON  result)
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
            public TypeHotelLocationJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeHotelLocationJSON  result)
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
        protected virtual void handle_result(List<TypeHotelLocationJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeHotelLocationJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeHotelLocationJSON>();
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
        public List<TypeHotelLocationJSON> value;
      };
      };
    public class TypeHotelFeaturedOfferJSON : JSONBase
      {
        private bool flagHasPricing;
        private HotelPricingJSON  storePricing;
        private bool flagHasCheckInDate;
        private DateAndOrTimeJSON  storeCheckInDate;
        private bool flagHasLengthOfStay;
        private BigInteger storeLengthOfStay;
        private bool flagHasDetailsUrl;
        private string storeDetailsUrl;


        private void  fromJSONPricing(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            HotelPricingJSON convert_classy = HotelPricingJSON.from_json(json_value, ignore_extras, true);
            setPricing(convert_classy);
          }


        private void  fromJSONCheckInDate(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setCheckInDate(convert_classy);
          }


        private void  fromJSONLengthOfStay(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field LengthOfStay of TypeHotelFeaturedOfferJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field LengthOfStay of TypeHotelFeaturedOfferJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setLengthOfStay(extracted_integer);
          }


        private void  fromJSONDetailsUrl(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field DetailsUrl of TypeHotelFeaturedOfferJSON is not a string.");
            setDetailsUrl(json_string.getData());
          }


        public TypeHotelFeaturedOfferJSON()
          {
            flagHasPricing = false;
            flagHasCheckInDate = false;
            flagHasLengthOfStay = false;
            flagHasDetailsUrl = false;
          }

        public bool  hasPricing()
          {
            return flagHasPricing;
          }

        public HotelPricingJSON   getPricing()
          {
            Debug.Assert(flagHasPricing);
            return storePricing;
          }

        public bool  hasCheckInDate()
          {
            return flagHasCheckInDate;
          }

        public DateAndOrTimeJSON   getCheckInDate()
          {
            Debug.Assert(flagHasCheckInDate);
            return storeCheckInDate;
          }

        public bool  hasLengthOfStay()
          {
            return flagHasLengthOfStay;
          }

        public BigInteger  getLengthOfStay()
          {
            Debug.Assert(flagHasLengthOfStay);
            return storeLengthOfStay;
          }

        public bool  hasDetailsUrl()
          {
            return flagHasDetailsUrl;
          }

        public string  getDetailsUrl()
          {
            Debug.Assert(flagHasDetailsUrl);
            return storeDetailsUrl;
          }



        public void setPricing(HotelPricingJSON  new_value)
          {
            if (flagHasPricing)
              {
              }
            flagHasPricing = true;
            storePricing = new_value;
          }
        public void unsetPricing()
          {
            if (flagHasPricing)
              {
              }
            flagHasPricing = false;
          }
        public void setCheckInDate(DateAndOrTimeJSON  new_value)
          {
            if (flagHasCheckInDate)
              {
              }
            flagHasCheckInDate = true;
            storeCheckInDate = new_value;
          }
        public void unsetCheckInDate()
          {
            if (flagHasCheckInDate)
              {
              }
            flagHasCheckInDate = false;
          }
        public void setLengthOfStay(BigInteger new_value)
          {
            flagHasLengthOfStay = true;
            if (new_value < 0)
                throw new Exception("The value for field LengthOfStay of TypeHotelFeaturedOfferJSON is less than the lower bound (0) for that field.");
            storeLengthOfStay = new_value;
          }
        public void unsetLengthOfStay()
          {
            flagHasLengthOfStay = false;
          }
        public void setDetailsUrl(string new_value)
          {
            flagHasDetailsUrl = true;
            storeDetailsUrl = new_value;
          }
        public void unsetDetailsUrl()
          {
            flagHasDetailsUrl = false;
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
            if (flagHasPricing)
              {
                handler.start_pair("Pricing");
                if (partial_allowed)
                    storePricing.write_partial_as_json(handler);
                else
                    storePricing.write_as_json(handler);
              }
            if (flagHasCheckInDate)
              {
                handler.start_pair("CheckInDate");
                if (partial_allowed)
                    storeCheckInDate.write_partial_as_json(handler);
                else
                    storeCheckInDate.write_as_json(handler);
              }
            if (flagHasLengthOfStay)
              {
                handler.start_pair("LengthOfStay");
                handler.number_value(storeLengthOfStay);
              }
            if (flagHasDetailsUrl)
              {
                handler.start_pair("DetailsUrl");
                handler.string_value(storeDetailsUrl);
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
            return null;
          }

        public static TypeHotelFeaturedOfferJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHotelFeaturedOfferJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelFeaturedOffer", ignore_extras);
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
        public static TypeHotelFeaturedOfferJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHotelFeaturedOfferJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHotelFeaturedOfferJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelFeaturedOffer", ignore_extras);
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
        public static TypeHotelFeaturedOfferJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHotelFeaturedOfferJSON from_text(string text, bool ignore_extras)
          {
            TypeHotelFeaturedOfferJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelFeaturedOffer", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeHotelFeaturedOfferJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeHotelFeaturedOfferJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeHotelFeaturedOfferJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelFeaturedOffer", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private HotelPricingJSON.HoldingGenerator fieldGeneratorPricing;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorCheckInDate;
        private class FieldHoldingGeneratorLengthOfStay : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorLengthOfStay(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorLengthOfStay : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorLengthOfStay(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorLengthOfStay fieldGeneratorLengthOfStay;
            private JSONHoldingStringGenerator fieldGeneratorDetailsUrl;

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
                TypeHotelFeaturedOfferJSON result = new TypeHotelFeaturedOfferJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeHotelFeaturedOfferJSON result)
              {
                if (fieldGeneratorPricing.have_value)
                  {
                    result.setPricing(fieldGeneratorPricing.value);
                    fieldGeneratorPricing.have_value = false;
                  }
                if (fieldGeneratorCheckInDate.have_value)
                  {
                    result.setCheckInDate(fieldGeneratorCheckInDate.value);
                    fieldGeneratorCheckInDate.have_value = false;
                  }
                if (fieldGeneratorLengthOfStay.have_value)
                  {
                    result.setLengthOfStay(fieldGeneratorLengthOfStay.value);
                    fieldGeneratorLengthOfStay.have_value = false;
                  }
                if (fieldGeneratorDetailsUrl.have_value)
                  {
                    result.setDetailsUrl(fieldGeneratorDetailsUrl.value);
                    fieldGeneratorDetailsUrl.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeHotelFeaturedOfferJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "heckInDate", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorCheckInDate;
                        break;
                    case 'D':
                        if ((String.Compare(field_name, 1, "etailsUrl", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorDetailsUrl;
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 1, "engthOfStay", 0, 11, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorLengthOfStay;
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "ricing", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorPricing;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorPricing = new HotelPricingJSON.HoldingGenerator("field \"Pricing\" of the TypeHotelFeaturedOffer class", ignore_extras);
                fieldGeneratorCheckInDate = new DateAndOrTimeJSON.HoldingGenerator("field \"CheckInDate\" of the TypeHotelFeaturedOffer class", ignore_extras);
                fieldGeneratorLengthOfStay = new FieldHoldingGeneratorLengthOfStay("field \"LengthOfStay\" of the TypeHotelFeaturedOffer class");
                fieldGeneratorDetailsUrl = new JSONHoldingStringGenerator("field \"DetailsUrl\" of the TypeHotelFeaturedOffer class");
                set_what("the TypeHotelFeaturedOffer class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorPricing = new HotelPricingJSON.HoldingGenerator("field \"Pricing\" of the TypeHotelFeaturedOffer class", false);
                fieldGeneratorCheckInDate = new DateAndOrTimeJSON.HoldingGenerator("field \"CheckInDate\" of the TypeHotelFeaturedOffer class", false);
                fieldGeneratorLengthOfStay = new FieldHoldingGeneratorLengthOfStay("field \"LengthOfStay\" of the TypeHotelFeaturedOffer class");
                fieldGeneratorDetailsUrl = new JSONHoldingStringGenerator("field \"DetailsUrl\" of the TypeHotelFeaturedOffer class");
                set_what("the TypeHotelFeaturedOffer class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorPricing.reset();
                fieldGeneratorCheckInDate.reset();
                fieldGeneratorLengthOfStay.reset();
                fieldGeneratorDetailsUrl.reset();
                base.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorPricing.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorCheckInDate.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorPricing.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorCheckInDate.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeHotelFeaturedOfferJSON  result)
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
            public TypeHotelFeaturedOfferJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeHotelFeaturedOfferJSON  result)
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
        protected virtual void handle_result(List<TypeHotelFeaturedOfferJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeHotelFeaturedOfferJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeHotelFeaturedOfferJSON>();
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
        public List<TypeHotelFeaturedOfferJSON> value;
      };
      };
    public enum TypeHotelStatusCode
      {
        HotelStatusCode_Available,
        HotelStatusCode_Not_x20_available,
        HotelStatusCode_Error,
        HotelStatusCode_No_x20_available_x20_rate_x20_plan
      };

    public static TypeHotelStatusCode  stringToHotelStatusCode(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "vailable", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeHotelStatusCode.HotelStatusCode_Available;
                break;
            case 'E':
                if ((String.Compare(chars, 1, "rror", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeHotelStatusCode.HotelStatusCode_Error;
                break;
            case 'N':
                if (String.Compare(chars, 1, "o", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case ' ':
                            if ((String.Compare(chars, 3, "available rate plan", 0, 19, false) == 0) && (chars.Length == 22))
                                return TypeHotelStatusCode.HotelStatusCode_No_x20_available_x20_rate_x20_plan;
                            break;
                        case 't':
                            if ((String.Compare(chars, 3, " available", 0, 10, false) == 0) && (chars.Length == 13))
                                return TypeHotelStatusCode.HotelStatusCode_Not_x20_available;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `HotelStatusCode' is not one of the legal values.");
      }

    public static string  stringFromHotelStatusCode(TypeHotelStatusCode the_enum)
      {
        switch (the_enum)
          {
            case TypeHotelStatusCode.HotelStatusCode_Available:
                return "Available";
            case TypeHotelStatusCode.HotelStatusCode_Not_x20_available:
                return "Not available";
            case TypeHotelStatusCode.HotelStatusCode_Error:
                return "Error";
            case TypeHotelStatusCode.HotelStatusCode_No_x20_available_x20_rate_x20_plan:
                return "No available rate plan";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeHotelPromotionJSON : JSONBase
      {
        private bool flagHasPromotionDiscountCurrency;
        private string storePromotionDiscountCurrency;
        private bool flagHasPromotionDiscountCurrencySymbol;
        private string storePromotionDiscountCurrencySymbol;
        private bool flagHasPromotionDiscount;
        private double storePromotionDiscount;
        private string textStorePromotionDiscount;
        private bool flagHasPromotionDescription;
        private string storePromotionDescription;


        private void  fromJSONPromotionDiscountCurrency(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PromotionDiscountCurrency of TypeHotelPromotionJSON is not a string.");
            setPromotionDiscountCurrency(json_string.getData());
          }


        private void  fromJSONPromotionDiscountCurrencySymbol(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PromotionDiscountCurrencySymbol of TypeHotelPromotionJSON is not a string.");
            setPromotionDiscountCurrencySymbol(json_string.getData());
          }


        private void  fromJSONPromotionDiscount(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field PromotionDiscount of TypeHotelPromotionJSON is not a number.");
                  }
              }
            setPromotionDiscountText(the_rational_text);
          }


        private void  fromJSONPromotionDescription(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PromotionDescription of TypeHotelPromotionJSON is not a string.");
            setPromotionDescription(json_string.getData());
          }


        public TypeHotelPromotionJSON()
          {
            flagHasPromotionDiscountCurrency = false;
            flagHasPromotionDiscountCurrencySymbol = false;
            flagHasPromotionDiscount = false;
            flagHasPromotionDescription = false;
          }

        public bool  hasPromotionDiscountCurrency()
          {
            return flagHasPromotionDiscountCurrency;
          }

        public string  getPromotionDiscountCurrency()
          {
            Debug.Assert(flagHasPromotionDiscountCurrency);
            return storePromotionDiscountCurrency;
          }

        public bool  hasPromotionDiscountCurrencySymbol()
          {
            return flagHasPromotionDiscountCurrencySymbol;
          }

        public string  getPromotionDiscountCurrencySymbol()
          {
            Debug.Assert(flagHasPromotionDiscountCurrencySymbol);
            return storePromotionDiscountCurrencySymbol;
          }

        public bool  hasPromotionDiscount()
          {
            return flagHasPromotionDiscount;
          }

        public double  getPromotionDiscount()
          {
            Debug.Assert(flagHasPromotionDiscount);
            if (textStorePromotionDiscount != "")
              {
                return Double.Parse(textStorePromotionDiscount);
              }
            return storePromotionDiscount;
          }

        public string  getPromotionDiscountAsText()
          {
            Debug.Assert(flagHasPromotionDiscount);
            if (textStorePromotionDiscount == "")
              {
                return Convert.ToString(storePromotionDiscount);
              }
            else
              {
                return (textStorePromotionDiscount);
              }
          }

        public bool  hasPromotionDescription()
          {
            return flagHasPromotionDescription;
          }

        public string  getPromotionDescription()
          {
            Debug.Assert(flagHasPromotionDescription);
            return storePromotionDescription;
          }



        public void setPromotionDiscountCurrency(string new_value)
          {
            flagHasPromotionDiscountCurrency = true;
            storePromotionDiscountCurrency = new_value;
          }
        public void unsetPromotionDiscountCurrency()
          {
            flagHasPromotionDiscountCurrency = false;
          }
        public void setPromotionDiscountCurrencySymbol(string new_value)
          {
            flagHasPromotionDiscountCurrencySymbol = true;
            storePromotionDiscountCurrencySymbol = new_value;
          }
        public void unsetPromotionDiscountCurrencySymbol()
          {
            flagHasPromotionDiscountCurrencySymbol = false;
          }
        public void setPromotionDiscount(double new_value)
          {
            flagHasPromotionDiscount = true;
            if (new_value < 0)
                throw new Exception("The value for field PromotionDiscount of TypeHotelPromotionJSON is less than the lower bound (0) for that field.");
            storePromotionDiscount = new_value;
            textStorePromotionDiscount = "";
          }
        public void setPromotionDiscountText(string new_value)
          {
            flagHasPromotionDiscount = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field PromotionDiscount of TypeHotelPromotionJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field PromotionDiscount of TypeHotelPromotionJSON is less than the lower bound (0) for that field.");
            textStorePromotionDiscount = new_value;
          }
        public void unsetPromotionDiscount()
          {
            flagHasPromotionDiscount = false;
          }
        public void setPromotionDescription(string new_value)
          {
            flagHasPromotionDescription = true;
            storePromotionDescription = new_value;
          }
        public void unsetPromotionDescription()
          {
            flagHasPromotionDescription = false;
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
            if (flagHasPromotionDiscountCurrency)
              {
                handler.start_pair("PromotionDiscountCurrency");
                handler.string_value(storePromotionDiscountCurrency);
              }
            if (flagHasPromotionDiscountCurrencySymbol)
              {
                handler.start_pair("PromotionDiscountCurrencySymbol");
                handler.string_value(storePromotionDiscountCurrencySymbol);
              }
            if (flagHasPromotionDiscount)
              {
                handler.start_pair("PromotionDiscount");
                if (textStorePromotionDiscount != "")
                    handler.number_value(textStorePromotionDiscount);
                else if (((double)(long)storePromotionDiscount) == storePromotionDiscount)
                    handler.number_value((long)storePromotionDiscount);
                else
                    handler.number_value(storePromotionDiscount);
              }
            if (flagHasPromotionDescription)
              {
                handler.start_pair("PromotionDescription");
                handler.string_value(storePromotionDescription);
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
            return null;
          }

        public static TypeHotelPromotionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHotelPromotionJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelPromotion", ignore_extras);
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
        public static TypeHotelPromotionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHotelPromotionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHotelPromotionJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelPromotion", ignore_extras);
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
        public static TypeHotelPromotionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHotelPromotionJSON from_text(string text, bool ignore_extras)
          {
            TypeHotelPromotionJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelPromotion", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeHotelPromotionJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeHotelPromotionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeHotelPromotionJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelPromotion", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorPromotionDiscountCurrency;
            private JSONHoldingStringGenerator fieldGeneratorPromotionDiscountCurrencySymbol;
            private JSONHoldingNumberTextGenerator fieldGeneratorPromotionDiscount;
            private JSONHoldingStringGenerator fieldGeneratorPromotionDescription;

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
                TypeHotelPromotionJSON result = new TypeHotelPromotionJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeHotelPromotionJSON result)
              {
                if (fieldGeneratorPromotionDiscountCurrency.have_value)
                  {
                    result.setPromotionDiscountCurrency(fieldGeneratorPromotionDiscountCurrency.value);
                    fieldGeneratorPromotionDiscountCurrency.have_value = false;
                  }
                if (fieldGeneratorPromotionDiscountCurrencySymbol.have_value)
                  {
                    result.setPromotionDiscountCurrencySymbol(fieldGeneratorPromotionDiscountCurrencySymbol.value);
                    fieldGeneratorPromotionDiscountCurrencySymbol.have_value = false;
                  }
                if (fieldGeneratorPromotionDiscount.have_value)
                  {
                    result.setPromotionDiscountText(fieldGeneratorPromotionDiscount.value);
                    fieldGeneratorPromotionDiscount.have_value = false;
                  }
                if (fieldGeneratorPromotionDescription.have_value)
                  {
                    result.setPromotionDescription(fieldGeneratorPromotionDescription.value);
                    fieldGeneratorPromotionDescription.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeHotelPromotionJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "PromotionD", 0, 10, false) == 0)
                  {
                    switch (field_name[10])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 11, "scription", 0, 9, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorPromotionDescription;
                            break;
                        case 'i':
                            if (String.Compare(field_name, 11, "scount", 0, 6, false) == 0)
                              {
                                if (field_name.Length == 17)
                                  {
                                    return fieldGeneratorPromotionDiscount;
                                  }
                                switch (field_name[17])
                                  {
                                    case 'C':
                                        if (String.Compare(field_name, 18, "urrency", 0, 7, false) == 0)
                                          {
                                            if (field_name.Length == 25)
                                              {
                                                return fieldGeneratorPromotionDiscountCurrency;
                                              }
                                            switch (field_name[25])
                                              {
                                                case 'S':
                                                    if ((String.Compare(field_name, 26, "ymbol", 0, 5, false) == 0) && (field_name.Length == 31))
                                                        return fieldGeneratorPromotionDiscountCurrencySymbol;
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
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorPromotionDiscountCurrency = new JSONHoldingStringGenerator("field \"PromotionDiscountCurrency\" of the TypeHotelPromotion class");
                fieldGeneratorPromotionDiscountCurrencySymbol = new JSONHoldingStringGenerator("field \"PromotionDiscountCurrencySymbol\" of the TypeHotelPromotion class");
                fieldGeneratorPromotionDiscount = new JSONHoldingNumberTextGenerator("field \"PromotionDiscount\" of the TypeHotelPromotion class");
                fieldGeneratorPromotionDescription = new JSONHoldingStringGenerator("field \"PromotionDescription\" of the TypeHotelPromotion class");
                set_what("the TypeHotelPromotion class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorPromotionDiscountCurrency = new JSONHoldingStringGenerator("field \"PromotionDiscountCurrency\" of the TypeHotelPromotion class");
                fieldGeneratorPromotionDiscountCurrencySymbol = new JSONHoldingStringGenerator("field \"PromotionDiscountCurrencySymbol\" of the TypeHotelPromotion class");
                fieldGeneratorPromotionDiscount = new JSONHoldingNumberTextGenerator("field \"PromotionDiscount\" of the TypeHotelPromotion class");
                fieldGeneratorPromotionDescription = new JSONHoldingStringGenerator("field \"PromotionDescription\" of the TypeHotelPromotion class");
                set_what("the TypeHotelPromotion class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorPromotionDiscountCurrency.reset();
                fieldGeneratorPromotionDiscountCurrencySymbol.reset();
                fieldGeneratorPromotionDiscount.reset();
                fieldGeneratorPromotionDescription.reset();
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
            protected override void handle_result(TypeHotelPromotionJSON  result)
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
            public TypeHotelPromotionJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeHotelPromotionJSON  result)
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
        protected virtual void handle_result(List<TypeHotelPromotionJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeHotelPromotionJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeHotelPromotionJSON>();
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
        public List<TypeHotelPromotionJSON> value;
      };
      };
    public class TypeHotelRoomTypesJSON : JSONBase
      {
        public class TypePromotionJSON : JSONBase
          {
            private bool flagHasPromotionDiscountCurrency;
            private string storePromotionDiscountCurrency;
            private bool flagHasPromotionDiscountCurrencySymbol;
            private string storePromotionDiscountCurrencySymbol;
            private bool flagHasPromotionDiscount;
            private double storePromotionDiscount;
            private string textStorePromotionDiscount;
            private bool flagHasPromotionDescription;
            private string storePromotionDescription;


            private void  fromJSONPromotionDiscountCurrency(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field PromotionDiscountCurrency of TypePromotionJSON is not a string.");
                setPromotionDiscountCurrency(json_string.getData());
              }


            private void  fromJSONPromotionDiscountCurrencySymbol(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field PromotionDiscountCurrencySymbol of TypePromotionJSON is not a string.");
                setPromotionDiscountCurrencySymbol(json_string.getData());
              }


            private void  fromJSONPromotionDiscount(JSONValue json_value, bool ignore_extras)
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
                        throw new Exception("The value for field PromotionDiscount of TypePromotionJSON is not a number.");
                      }
                  }
                setPromotionDiscountText(the_rational_text);
              }


            private void  fromJSONPromotionDescription(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field PromotionDescription of TypePromotionJSON is not a string.");
                setPromotionDescription(json_string.getData());
              }


            public TypePromotionJSON()
              {
                flagHasPromotionDiscountCurrency = false;
                flagHasPromotionDiscountCurrencySymbol = false;
                flagHasPromotionDiscount = false;
                flagHasPromotionDescription = false;
              }

            public bool  hasPromotionDiscountCurrency()
              {
                return flagHasPromotionDiscountCurrency;
              }

            public string  getPromotionDiscountCurrency()
              {
                Debug.Assert(flagHasPromotionDiscountCurrency);
                return storePromotionDiscountCurrency;
              }

            public bool  hasPromotionDiscountCurrencySymbol()
              {
                return flagHasPromotionDiscountCurrencySymbol;
              }

            public string  getPromotionDiscountCurrencySymbol()
              {
                Debug.Assert(flagHasPromotionDiscountCurrencySymbol);
                return storePromotionDiscountCurrencySymbol;
              }

            public bool  hasPromotionDiscount()
              {
                return flagHasPromotionDiscount;
              }

            public double  getPromotionDiscount()
              {
                Debug.Assert(flagHasPromotionDiscount);
                if (textStorePromotionDiscount != "")
                  {
                    return Double.Parse(textStorePromotionDiscount);
                  }
                return storePromotionDiscount;
              }

            public string  getPromotionDiscountAsText()
              {
                Debug.Assert(flagHasPromotionDiscount);
                if (textStorePromotionDiscount == "")
                  {
                    return Convert.ToString(storePromotionDiscount);
                  }
                else
                  {
                    return (textStorePromotionDiscount);
                  }
              }

            public bool  hasPromotionDescription()
              {
                return flagHasPromotionDescription;
              }

            public string  getPromotionDescription()
              {
                Debug.Assert(flagHasPromotionDescription);
                return storePromotionDescription;
              }



            public void setPromotionDiscountCurrency(string new_value)
              {
                flagHasPromotionDiscountCurrency = true;
                storePromotionDiscountCurrency = new_value;
              }
            public void unsetPromotionDiscountCurrency()
              {
                flagHasPromotionDiscountCurrency = false;
              }
            public void setPromotionDiscountCurrencySymbol(string new_value)
              {
                flagHasPromotionDiscountCurrencySymbol = true;
                storePromotionDiscountCurrencySymbol = new_value;
              }
            public void unsetPromotionDiscountCurrencySymbol()
              {
                flagHasPromotionDiscountCurrencySymbol = false;
              }
            public void setPromotionDiscount(double new_value)
              {
                flagHasPromotionDiscount = true;
                if (new_value < 0)
                    throw new Exception("The value for field PromotionDiscount of TypePromotionJSON is less than the lower bound (0) for that field.");
                storePromotionDiscount = new_value;
                textStorePromotionDiscount = "";
              }
            public void setPromotionDiscountText(string new_value)
              {
                flagHasPromotionDiscount = true;
                if (!(JSONWriter.is_valid_number_format(new_value)))
                    throw new Exception("The text value for field PromotionDiscount of TypePromotionJSON is not a valid number.");
                if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                    throw new Exception("The value for field PromotionDiscount of TypePromotionJSON is less than the lower bound (0) for that field.");
                textStorePromotionDiscount = new_value;
              }
            public void unsetPromotionDiscount()
              {
                flagHasPromotionDiscount = false;
              }
            public void setPromotionDescription(string new_value)
              {
                flagHasPromotionDescription = true;
                storePromotionDescription = new_value;
              }
            public void unsetPromotionDescription()
              {
                flagHasPromotionDescription = false;
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
                if (flagHasPromotionDiscountCurrency)
                  {
                    handler.start_pair("PromotionDiscountCurrency");
                    handler.string_value(storePromotionDiscountCurrency);
                  }
                if (flagHasPromotionDiscountCurrencySymbol)
                  {
                    handler.start_pair("PromotionDiscountCurrencySymbol");
                    handler.string_value(storePromotionDiscountCurrencySymbol);
                  }
                if (flagHasPromotionDiscount)
                  {
                    handler.start_pair("PromotionDiscount");
                    if (textStorePromotionDiscount != "")
                        handler.number_value(textStorePromotionDiscount);
                    else if (((double)(long)storePromotionDiscount) == storePromotionDiscount)
                        handler.number_value((long)storePromotionDiscount);
                    else
                        handler.number_value(storePromotionDiscount);
                  }
                if (flagHasPromotionDescription)
                  {
                    handler.start_pair("PromotionDescription");
                    handler.string_value(storePromotionDescription);
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
                return null;
              }

            public static TypePromotionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypePromotionJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePromotion", ignore_extras);
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
            public static TypePromotionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypePromotionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypePromotionJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePromotion", ignore_extras);
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
            public static TypePromotionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypePromotionJSON from_text(string text, bool ignore_extras)
              {
                TypePromotionJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePromotion", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypePromotionJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypePromotionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypePromotionJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePromotion", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorPromotionDiscountCurrency;
                private JSONHoldingStringGenerator fieldGeneratorPromotionDiscountCurrencySymbol;
                private JSONHoldingNumberTextGenerator fieldGeneratorPromotionDiscount;
                private JSONHoldingStringGenerator fieldGeneratorPromotionDescription;

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
                    TypePromotionJSON result = new TypePromotionJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    handle_result(result);
                  }
                protected void finish(TypePromotionJSON result)
                  {
                    if (fieldGeneratorPromotionDiscountCurrency.have_value)
                      {
                        result.setPromotionDiscountCurrency(fieldGeneratorPromotionDiscountCurrency.value);
                        fieldGeneratorPromotionDiscountCurrency.have_value = false;
                      }
                    if (fieldGeneratorPromotionDiscountCurrencySymbol.have_value)
                      {
                        result.setPromotionDiscountCurrencySymbol(fieldGeneratorPromotionDiscountCurrencySymbol.value);
                        fieldGeneratorPromotionDiscountCurrencySymbol.have_value = false;
                      }
                    if (fieldGeneratorPromotionDiscount.have_value)
                      {
                        result.setPromotionDiscountText(fieldGeneratorPromotionDiscount.value);
                        fieldGeneratorPromotionDiscount.have_value = false;
                      }
                    if (fieldGeneratorPromotionDescription.have_value)
                      {
                        result.setPromotionDescription(fieldGeneratorPromotionDescription.value);
                        fieldGeneratorPromotionDescription.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypePromotionJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if (String.Compare(field_name, 0, "PromotionD", 0, 10, false) == 0)
                      {
                        switch (field_name[10])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 11, "scription", 0, 9, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorPromotionDescription;
                                break;
                            case 'i':
                                if (String.Compare(field_name, 11, "scount", 0, 6, false) == 0)
                                  {
                                    if (field_name.Length == 17)
                                      {
                                        return fieldGeneratorPromotionDiscount;
                                      }
                                    switch (field_name[17])
                                      {
                                        case 'C':
                                            if (String.Compare(field_name, 18, "urrency", 0, 7, false) == 0)
                                              {
                                                if (field_name.Length == 25)
                                                  {
                                                    return fieldGeneratorPromotionDiscountCurrency;
                                                  }
                                                switch (field_name[25])
                                                  {
                                                    case 'S':
                                                        if ((String.Compare(field_name, 26, "ymbol", 0, 5, false) == 0) && (field_name.Length == 31))
                                                            return fieldGeneratorPromotionDiscountCurrencySymbol;
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
                            default:
                                break;
                          }
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorPromotionDiscountCurrency = new JSONHoldingStringGenerator("field \"PromotionDiscountCurrency\" of the TypePromotion class");
                    fieldGeneratorPromotionDiscountCurrencySymbol = new JSONHoldingStringGenerator("field \"PromotionDiscountCurrencySymbol\" of the TypePromotion class");
                    fieldGeneratorPromotionDiscount = new JSONHoldingNumberTextGenerator("field \"PromotionDiscount\" of the TypePromotion class");
                    fieldGeneratorPromotionDescription = new JSONHoldingStringGenerator("field \"PromotionDescription\" of the TypePromotion class");
                    set_what("the TypePromotion class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorPromotionDiscountCurrency = new JSONHoldingStringGenerator("field \"PromotionDiscountCurrency\" of the TypePromotion class");
                    fieldGeneratorPromotionDiscountCurrencySymbol = new JSONHoldingStringGenerator("field \"PromotionDiscountCurrencySymbol\" of the TypePromotion class");
                    fieldGeneratorPromotionDiscount = new JSONHoldingNumberTextGenerator("field \"PromotionDiscount\" of the TypePromotion class");
                    fieldGeneratorPromotionDescription = new JSONHoldingStringGenerator("field \"PromotionDescription\" of the TypePromotion class");
                    set_what("the TypePromotion class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorPromotionDiscountCurrency.reset();
                    fieldGeneratorPromotionDiscountCurrencySymbol.reset();
                    fieldGeneratorPromotionDiscount.reset();
                    fieldGeneratorPromotionDescription.reset();
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
                protected override void handle_result(TypePromotionJSON  result)
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
                public TypePromotionJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypePromotionJSON  result)
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
            protected virtual void handle_result(List<TypePromotionJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypePromotionJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypePromotionJSON>();
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
            public List<TypePromotionJSON> value;
          };
          };
        public class TypeAmenitiesJSON : JSONBase
          {
            private bool flagHasID;
            private BigInteger storeID;
            private bool flagHasName;
            private string storeName;


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
                        throw new Exception("The value for field ID of TypeAmenitiesJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field ID of TypeAmenitiesJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setID(extracted_integer);
              }


            private void  fromJSONName(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Name of TypeAmenitiesJSON is not a string.");
                setName(json_string.getData());
              }


            public TypeAmenitiesJSON()
              {
                flagHasID = false;
                flagHasName = false;
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

            public bool  hasName()
              {
                return flagHasName;
              }

            public string  getName()
              {
                Debug.Assert(flagHasName);
                return storeName;
              }



            public void setID(BigInteger new_value)
              {
                flagHasID = true;
                if (new_value < 0)
                    throw new Exception("The value for field ID of TypeAmenitiesJSON is less than the lower bound (0) for that field.");
                storeID = new_value;
              }
            public void unsetID()
              {
                flagHasID = false;
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
                if (flagHasID)
                  {
                    handler.start_pair("ID");
                    handler.number_value(storeID);
                  }
                if (flagHasName)
                  {
                    handler.start_pair("Name");
                    handler.string_value(storeName);
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
                return null;
              }

            public static TypeAmenitiesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAmenitiesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAmenities", ignore_extras);
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
            public static TypeAmenitiesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAmenitiesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAmenitiesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAmenities", ignore_extras);
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
            public static TypeAmenitiesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAmenitiesJSON from_text(string text, bool ignore_extras)
              {
                TypeAmenitiesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAmenities", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeAmenitiesJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeAmenitiesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeAmenitiesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAmenities", ignore_extras);
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
                private JSONHoldingStringGenerator fieldGeneratorName;

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
                    TypeAmenitiesJSON result = new TypeAmenitiesJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    handle_result(result);
                  }
                protected void finish(TypeAmenitiesJSON result)
                  {
                    if (fieldGeneratorID.have_value)
                      {
                        result.setID(fieldGeneratorID.value);
                        fieldGeneratorID.have_value = false;
                      }
                    if (fieldGeneratorName.have_value)
                      {
                        result.setName(fieldGeneratorName.value);
                        fieldGeneratorName.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeAmenitiesJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                                return fieldGeneratorID;
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorName;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorID = new FieldHoldingGeneratorID("field \"ID\" of the TypeAmenities class");
                    fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeAmenities class");
                    set_what("the TypeAmenities class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorID = new FieldHoldingGeneratorID("field \"ID\" of the TypeAmenities class");
                    fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeAmenities class");
                    set_what("the TypeAmenities class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorID.reset();
                    fieldGeneratorName.reset();
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
                protected override void handle_result(TypeAmenitiesJSON  result)
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
                public TypeAmenitiesJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeAmenitiesJSON  result)
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
            protected virtual void handle_result(List<TypeAmenitiesJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeAmenitiesJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeAmenitiesJSON>();
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
            public List<TypeAmenitiesJSON> value;
          };
          };
        private bool flagHasDescription;
        private string storeDescription;
        private bool flagHasRemainingCount;
        private BigInteger storeRemainingCount;
        private bool flagHasPricing;
        private HotelPricingJSON  storePricing;
        private bool flagHasPromotion;
        private TypePromotionJSON  storePromotion;
        private bool flagHasRateDetailsUrl;
        private string storeRateDetailsUrl;
        private bool flagHasAmenities;
        private List< TypeAmenitiesJSON  > storeAmenities;
        private bool flagHasRefundable;
        private bool storeRefundable;
        private bool flagHasFreeCancellation;
        private bool storeFreeCancellation;
        private bool flagHasPaymentMethod;
        private string storePaymentMethod;


        private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Description of TypeHotelRoomTypesJSON is not a string.");
            setDescription(json_string.getData());
          }


        private void  fromJSONRemainingCount(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field RemainingCount of TypeHotelRoomTypesJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field RemainingCount of TypeHotelRoomTypesJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setRemainingCount(extracted_integer);
          }


        private void  fromJSONPricing(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            HotelPricingJSON convert_classy = HotelPricingJSON.from_json(json_value, ignore_extras, true);
            setPricing(convert_classy);
          }


        private void  fromJSONPromotion(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypePromotionJSON convert_classy = TypePromotionJSON.from_json(json_value, ignore_extras, true);
            setPromotion(convert_classy);
          }


        private void  fromJSONRateDetailsUrl(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field RateDetailsUrl of TypeHotelRoomTypesJSON is not a string.");
            setRateDetailsUrl(json_string.getData());
          }


        private void  fromJSONAmenities(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Amenities of TypeHotelRoomTypesJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeAmenitiesJSON  > vector_Amenities1 = new List< TypeAmenitiesJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeAmenitiesJSON convert_classy = TypeAmenitiesJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Amenities1.Add(convert_classy);
              }
            initAmenities();
            for (int num1 = 0; num1 < vector_Amenities1.Count; ++num1)
                appendAmenities(vector_Amenities1[num1]);
            for (int num1 = 0; num1 < vector_Amenities1.Count; ++num1)
              {
              }
          }


        private void  fromJSONRefundable(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Refundable of TypeHotelRoomTypesJSON is not true for false.");
                  }
              }
            setRefundable(the_bool);
          }


        private void  fromJSONFreeCancellation(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field FreeCancellation of TypeHotelRoomTypesJSON is not true for false.");
                  }
              }
            setFreeCancellation(the_bool);
          }


        private void  fromJSONPaymentMethod(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PaymentMethod of TypeHotelRoomTypesJSON is not a string.");
            setPaymentMethod(json_string.getData());
          }


        public TypeHotelRoomTypesJSON()
          {
            flagHasDescription = false;
            flagHasRemainingCount = false;
            flagHasPricing = false;
            flagHasPromotion = false;
            flagHasRateDetailsUrl = false;
            flagHasAmenities = false;
            flagHasRefundable = false;
            flagHasFreeCancellation = false;
            flagHasPaymentMethod = false;
            storeAmenities = new List< TypeAmenitiesJSON  >();
          }

        public bool  hasDescription()
          {
            return flagHasDescription;
          }

        public string  getDescription()
          {
            Debug.Assert(flagHasDescription);
            return storeDescription;
          }

        public bool  hasRemainingCount()
          {
            return flagHasRemainingCount;
          }

        public BigInteger  getRemainingCount()
          {
            Debug.Assert(flagHasRemainingCount);
            return storeRemainingCount;
          }

        public bool  hasPricing()
          {
            return flagHasPricing;
          }

        public HotelPricingJSON   getPricing()
          {
            Debug.Assert(flagHasPricing);
            return storePricing;
          }

        public bool  hasPromotion()
          {
            return flagHasPromotion;
          }

        public TypePromotionJSON   getPromotion()
          {
            Debug.Assert(flagHasPromotion);
            return storePromotion;
          }

        public bool  hasRateDetailsUrl()
          {
            return flagHasRateDetailsUrl;
          }

        public string  getRateDetailsUrl()
          {
            Debug.Assert(flagHasRateDetailsUrl);
            return storeRateDetailsUrl;
          }

        public bool  hasAmenities()
          {
            return flagHasAmenities;
          }

        public int  countOfAmenities()
          {
            Debug.Assert(flagHasAmenities);
            return storeAmenities.Count;
          }

        public TypeAmenitiesJSON   elementOfAmenities(int element_num)
          {
            Debug.Assert(flagHasAmenities);
            return storeAmenities[element_num];
          }

        public List< TypeAmenitiesJSON  >  getAmenities()
          {
            Debug.Assert(flagHasAmenities);
            return storeAmenities;
          }

        public bool  hasRefundable()
          {
            return flagHasRefundable;
          }

        public bool  getRefundable()
          {
            Debug.Assert(flagHasRefundable);
            return storeRefundable;
          }

        public bool  hasFreeCancellation()
          {
            return flagHasFreeCancellation;
          }

        public bool  getFreeCancellation()
          {
            Debug.Assert(flagHasFreeCancellation);
            return storeFreeCancellation;
          }

        public bool  hasPaymentMethod()
          {
            return flagHasPaymentMethod;
          }

        public string  getPaymentMethod()
          {
            Debug.Assert(flagHasPaymentMethod);
            return storePaymentMethod;
          }



        public void setDescription(string new_value)
          {
            flagHasDescription = true;
            storeDescription = new_value;
          }
        public void unsetDescription()
          {
            flagHasDescription = false;
          }
        public void setRemainingCount(BigInteger new_value)
          {
            flagHasRemainingCount = true;
            if (new_value < 0)
                throw new Exception("The value for field RemainingCount of TypeHotelRoomTypesJSON is less than the lower bound (0) for that field.");
            storeRemainingCount = new_value;
          }
        public void unsetRemainingCount()
          {
            flagHasRemainingCount = false;
          }
        public void setPricing(HotelPricingJSON  new_value)
          {
            if (flagHasPricing)
              {
              }
            flagHasPricing = true;
            storePricing = new_value;
          }
        public void unsetPricing()
          {
            if (flagHasPricing)
              {
              }
            flagHasPricing = false;
          }
        public void setPromotion(TypePromotionJSON  new_value)
          {
            if (flagHasPromotion)
              {
              }
            flagHasPromotion = true;
            storePromotion = new_value;
          }
        public void unsetPromotion()
          {
            if (flagHasPromotion)
              {
              }
            flagHasPromotion = false;
          }
        public void setRateDetailsUrl(string new_value)
          {
            flagHasRateDetailsUrl = true;
            storeRateDetailsUrl = new_value;
          }
        public void unsetRateDetailsUrl()
          {
            flagHasRateDetailsUrl = false;
          }
        public void initAmenities()
          {
            if (flagHasAmenities)
              {
                for (int num1 = 0; num1 < storeAmenities.Count; ++num1)
                  {
                  }
              }
            flagHasAmenities = true;
            storeAmenities.Clear();
          }
        public void appendAmenities(TypeAmenitiesJSON  to_append)
          {
            if (!flagHasAmenities)
              {
                flagHasAmenities = true;
                storeAmenities.Clear();
              }
            Debug.Assert(flagHasAmenities);
            storeAmenities.Add(to_append);
          }
        public void unsetAmenities()
          {
            if (flagHasAmenities)
              {
                for (int num2 = 0; num2 < storeAmenities.Count; ++num2)
                  {
                  }
              }
            flagHasAmenities = false;
            storeAmenities.Clear();
          }
        public void setRefundable(bool new_value)
          {
            flagHasRefundable = true;
            storeRefundable = new_value;
          }
        public void unsetRefundable()
          {
            flagHasRefundable = false;
          }
        public void setFreeCancellation(bool new_value)
          {
            flagHasFreeCancellation = true;
            storeFreeCancellation = new_value;
          }
        public void unsetFreeCancellation()
          {
            flagHasFreeCancellation = false;
          }
        public void setPaymentMethod(string new_value)
          {
            flagHasPaymentMethod = true;
            storePaymentMethod = new_value;
          }
        public void unsetPaymentMethod()
          {
            flagHasPaymentMethod = false;
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
            if (flagHasDescription)
              {
                handler.start_pair("Description");
                handler.string_value(storeDescription);
              }
            if (flagHasRemainingCount)
              {
                handler.start_pair("RemainingCount");
                handler.number_value(storeRemainingCount);
              }
            if (flagHasPricing)
              {
                handler.start_pair("Pricing");
                if (partial_allowed)
                    storePricing.write_partial_as_json(handler);
                else
                    storePricing.write_as_json(handler);
              }
            if (flagHasPromotion)
              {
                handler.start_pair("Promotion");
                if (partial_allowed)
                    storePromotion.write_partial_as_json(handler);
                else
                    storePromotion.write_as_json(handler);
              }
            if (flagHasRateDetailsUrl)
              {
                handler.start_pair("RateDetailsUrl");
                handler.string_value(storeRateDetailsUrl);
              }
            if (flagHasAmenities)
              {
                handler.start_pair("Amenities");
                handler.start_array();
                for (int num1 = 0; num1 < storeAmenities.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeAmenities[num1].write_partial_as_json(handler);
                    else
                        storeAmenities[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
            Debug.Assert(partial_allowed || flagHasRefundable);
            if (flagHasRefundable)
              {
                handler.start_pair("Refundable");
                handler.boolean_value(storeRefundable);
              }
            Debug.Assert(partial_allowed || flagHasFreeCancellation);
            if (flagHasFreeCancellation)
              {
                handler.start_pair("FreeCancellation");
                handler.boolean_value(storeFreeCancellation);
              }
            if (flagHasPaymentMethod)
              {
                handler.start_pair("PaymentMethod");
                handler.string_value(storePaymentMethod);
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
            if (!(hasRefundable()))
              {
                return "When parsing the object for %what%, the \"Refundable\" field was missing.";
              }
            if (!(hasFreeCancellation()))
              {
                return "When parsing the object for %what%, the \"FreeCancellation\" field was missing.";
              }
            return null;
          }

        public static TypeHotelRoomTypesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHotelRoomTypesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelRoomTypes", ignore_extras);
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
        public static TypeHotelRoomTypesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHotelRoomTypesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHotelRoomTypesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelRoomTypes", ignore_extras);
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
        public static TypeHotelRoomTypesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHotelRoomTypesJSON from_text(string text, bool ignore_extras)
          {
            TypeHotelRoomTypesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelRoomTypes", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeHotelRoomTypesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeHotelRoomTypesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeHotelRoomTypesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHotelRoomTypes", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorDescription;
        private class FieldHoldingGeneratorRemainingCount : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorRemainingCount(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorRemainingCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorRemainingCount(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorRemainingCount fieldGeneratorRemainingCount;
            private HotelPricingJSON.HoldingGenerator fieldGeneratorPricing;
            private TypePromotionJSON.HoldingGenerator fieldGeneratorPromotion;
            private JSONHoldingStringGenerator fieldGeneratorRateDetailsUrl;
            private TypeAmenitiesJSON.HoldingArrayGenerator fieldGeneratorAmenities;
            private JSONHoldingBooleanGenerator fieldGeneratorRefundable;
            private JSONHoldingBooleanGenerator fieldGeneratorFreeCancellation;
            private JSONHoldingStringGenerator fieldGeneratorPaymentMethod;

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
                TypeHotelRoomTypesJSON result = new TypeHotelRoomTypesJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeHotelRoomTypesJSON result)
              {
                if (fieldGeneratorDescription.have_value)
                  {
                    result.setDescription(fieldGeneratorDescription.value);
                    fieldGeneratorDescription.have_value = false;
                  }
                if (fieldGeneratorRemainingCount.have_value)
                  {
                    result.setRemainingCount(fieldGeneratorRemainingCount.value);
                    fieldGeneratorRemainingCount.have_value = false;
                  }
                if (fieldGeneratorPricing.have_value)
                  {
                    result.setPricing(fieldGeneratorPricing.value);
                    fieldGeneratorPricing.have_value = false;
                  }
                if (fieldGeneratorPromotion.have_value)
                  {
                    result.setPromotion(fieldGeneratorPromotion.value);
                    fieldGeneratorPromotion.have_value = false;
                  }
                if (fieldGeneratorRateDetailsUrl.have_value)
                  {
                    result.setRateDetailsUrl(fieldGeneratorRateDetailsUrl.value);
                    fieldGeneratorRateDetailsUrl.have_value = false;
                  }
                if (fieldGeneratorAmenities.have_value)
                  {
                    result.initAmenities();
                    int count = fieldGeneratorAmenities.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendAmenities(fieldGeneratorAmenities.value[num]);
                      }
                    fieldGeneratorAmenities.value.Clear();
                    fieldGeneratorAmenities.have_value = false;
                  }
                if (fieldGeneratorRefundable.have_value)
                  {
                    result.setRefundable(fieldGeneratorRefundable.value);
                    fieldGeneratorRefundable.have_value = false;
                  }
                else if ((!(result.hasRefundable())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Refundable\" field was missing.");
                  }
                if (fieldGeneratorFreeCancellation.have_value)
                  {
                    result.setFreeCancellation(fieldGeneratorFreeCancellation.value);
                    fieldGeneratorFreeCancellation.have_value = false;
                  }
                else if ((!(result.hasFreeCancellation())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"FreeCancellation\" field was missing.");
                  }
                if (fieldGeneratorPaymentMethod.have_value)
                  {
                    result.setPaymentMethod(fieldGeneratorPaymentMethod.value);
                    fieldGeneratorPaymentMethod.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeHotelRoomTypesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "menities", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorAmenities;
                        break;
                    case 'D':
                        if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorDescription;
                        break;
                    case 'F':
                        if ((String.Compare(field_name, 1, "reeCancellation", 0, 15, false) == 0) && (field_name.Length == 16))
                            return fieldGeneratorFreeCancellation;
                        break;
                    case 'P':
                        switch (field_name[1])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 2, "ymentMethod", 0, 11, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorPaymentMethod;
                                break;
                            case 'r':
                                switch (field_name[2])
                                  {
                                    case 'i':
                                        if ((String.Compare(field_name, 3, "cing", 0, 4, false) == 0) && (field_name.Length == 7))
                                            return fieldGeneratorPricing;
                                        break;
                                    case 'o':
                                        if ((String.Compare(field_name, 3, "motion", 0, 6, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorPromotion;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'R':
                        switch (field_name[1])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 2, "teDetailsUrl", 0, 12, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorRateDetailsUrl;
                                break;
                            case 'e':
                                switch (field_name[2])
                                  {
                                    case 'f':
                                        if ((String.Compare(field_name, 3, "undable", 0, 7, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorRefundable;
                                        break;
                                    case 'm':
                                        if ((String.Compare(field_name, 3, "ainingCount", 0, 11, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorRemainingCount;
                                        break;
                                    default:
                                        break;
                                  }
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
                fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the TypeHotelRoomTypes class");
                fieldGeneratorRemainingCount = new FieldHoldingGeneratorRemainingCount("field \"RemainingCount\" of the TypeHotelRoomTypes class");
                fieldGeneratorPricing = new HotelPricingJSON.HoldingGenerator("field \"Pricing\" of the TypeHotelRoomTypes class", ignore_extras);
                fieldGeneratorPromotion = new TypePromotionJSON.HoldingGenerator("field \"Promotion\" of the TypeHotelRoomTypes class", ignore_extras);
                fieldGeneratorRateDetailsUrl = new JSONHoldingStringGenerator("field \"RateDetailsUrl\" of the TypeHotelRoomTypes class");
                fieldGeneratorAmenities = new TypeAmenitiesJSON.HoldingArrayGenerator("field \"Amenities\" of the TypeHotelRoomTypes class", ignore_extras);
                fieldGeneratorRefundable = new JSONHoldingBooleanGenerator("field \"Refundable\" of the TypeHotelRoomTypes class");
                fieldGeneratorFreeCancellation = new JSONHoldingBooleanGenerator("field \"FreeCancellation\" of the TypeHotelRoomTypes class");
                fieldGeneratorPaymentMethod = new JSONHoldingStringGenerator("field \"PaymentMethod\" of the TypeHotelRoomTypes class");
                set_what("the TypeHotelRoomTypes class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the TypeHotelRoomTypes class");
                fieldGeneratorRemainingCount = new FieldHoldingGeneratorRemainingCount("field \"RemainingCount\" of the TypeHotelRoomTypes class");
                fieldGeneratorPricing = new HotelPricingJSON.HoldingGenerator("field \"Pricing\" of the TypeHotelRoomTypes class", false);
                fieldGeneratorPromotion = new TypePromotionJSON.HoldingGenerator("field \"Promotion\" of the TypeHotelRoomTypes class", false);
                fieldGeneratorRateDetailsUrl = new JSONHoldingStringGenerator("field \"RateDetailsUrl\" of the TypeHotelRoomTypes class");
                fieldGeneratorAmenities = new TypeAmenitiesJSON.HoldingArrayGenerator("field \"Amenities\" of the TypeHotelRoomTypes class", false);
                fieldGeneratorRefundable = new JSONHoldingBooleanGenerator("field \"Refundable\" of the TypeHotelRoomTypes class");
                fieldGeneratorFreeCancellation = new JSONHoldingBooleanGenerator("field \"FreeCancellation\" of the TypeHotelRoomTypes class");
                fieldGeneratorPaymentMethod = new JSONHoldingStringGenerator("field \"PaymentMethod\" of the TypeHotelRoomTypes class");
                set_what("the TypeHotelRoomTypes class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorDescription.reset();
                fieldGeneratorRemainingCount.reset();
                fieldGeneratorPricing.reset();
                fieldGeneratorPromotion.reset();
                fieldGeneratorRateDetailsUrl.reset();
                fieldGeneratorAmenities.reset();
                fieldGeneratorRefundable.reset();
                fieldGeneratorFreeCancellation.reset();
                fieldGeneratorPaymentMethod.reset();
                base.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorPricing.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorPromotion.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorAmenities.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorPricing.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorPromotion.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorAmenities.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeHotelRoomTypesJSON  result)
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
            public TypeHotelRoomTypesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeHotelRoomTypesJSON  result)
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
        protected virtual void handle_result(List<TypeHotelRoomTypesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeHotelRoomTypesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeHotelRoomTypesJSON>();
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
        public List<TypeHotelRoomTypesJSON> value;
      };
      };
    private bool flagHasHotelID;
    private BigInteger storeHotelID;
    private bool flagHasHotelName;
    private string storeHotelName;
    private bool flagHasDistanceFromReference;
    private double storeDistanceFromReference;
    private string textStoreDistanceFromReference;
    private bool flagHasDistanceFromReferenceUnit;
    private TypeDistanceFromReferenceUnit storeDistanceFromReferenceUnit;
    private bool flagHasHotelLocation;
    private TypeHotelLocationJSON  storeHotelLocation;
    private bool flagHasHotelDescription;
    private string storeHotelDescription;
    private bool flagHasHotelFeaturedOffer;
    private TypeHotelFeaturedOfferJSON  storeHotelFeaturedOffer;
    private bool flagHasHotelStatusCode;
    private TypeHotelStatusCode storeHotelStatusCode;
    private bool flagHasHotelStatusDescription;
    private string storeHotelStatusDescription;
    private bool flagHasHotelPricing;
    private HotelPricingJSON  storeHotelPricing;
    private bool flagHasHotelPromotion;
    private TypeHotelPromotionJSON  storeHotelPromotion;
    private bool flagHasHotelDetailsUrl;
    private string storeHotelDetailsUrl;
    private bool flagHasHotelRateDetailsUrl;
    private string storeHotelRateDetailsUrl;
    private bool flagHasHotelThumbnailUrl;
    private string storeHotelThumbnailUrl;
    private bool flagHasHotelImageUrl;
    private string storeHotelImageUrl;
    private bool flagHasHotelStarRating;
    private double storeHotelStarRating;
    private string textStoreHotelStarRating;
    private bool flagHasHotelGuestRating;
    private double storeHotelGuestRating;
    private string textStoreHotelGuestRating;
    private bool flagHasHotelGuestReviewCount;
    private BigInteger storeHotelGuestReviewCount;
    private bool flagHasHotelRoomTypes;
    private List< TypeHotelRoomTypesJSON  > storeHotelRoomTypes;
    private bool flagHasHotelAmenities;
    private List< string > storeHotelAmenities;
    private bool flagHasMatchedCriteriaInclude;
    private List< string > storeMatchedCriteriaInclude;
    private bool flagHasMatchedCriteriaExclude;
    private List< string > storeMatchedCriteriaExclude;


    private void  fromJSONHotelID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field HotelID of HotelJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field HotelID of HotelJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setHotelID(extracted_integer);
      }


    private void  fromJSONHotelName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HotelName of HotelJSON is not a string.");
        setHotelName(json_string.getData());
      }


    private void  fromJSONDistanceFromReference(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DistanceFromReference of HotelJSON is not a number.");
              }
          }
        setDistanceFromReferenceText(the_rational_text);
      }


    private void  fromJSONDistanceFromReferenceUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DistanceFromReferenceUnit of HotelJSON is not a string.");
        TypeDistanceFromReferenceUnit the_enum;
        switch (json_string.getData()[0])
          {
            case 'k':
                if ((String.Compare(json_string.getData(), 1, "m", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = TypeDistanceFromReferenceUnit.DistanceFromReferenceUnit_km;
                        goto enum_is_done;
                      }
                break;
            case 'm':
                if ((String.Compare(json_string.getData(), 1, "i", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = TypeDistanceFromReferenceUnit.DistanceFromReferenceUnit_mi;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field DistanceFromReferenceUnit of HotelJSON is not one of the legal strings.");
      enum_is_done:;
        setDistanceFromReferenceUnit(the_enum);
      }


    private void  fromJSONHotelLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeHotelLocationJSON convert_classy = TypeHotelLocationJSON.from_json(json_value, ignore_extras, true);
        setHotelLocation(convert_classy);
      }


    private void  fromJSONHotelDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HotelDescription of HotelJSON is not a string.");
        setHotelDescription(json_string.getData());
      }


    private void  fromJSONHotelFeaturedOffer(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeHotelFeaturedOfferJSON convert_classy = TypeHotelFeaturedOfferJSON.from_json(json_value, ignore_extras, true);
        setHotelFeaturedOffer(convert_classy);
      }


    private void  fromJSONHotelStatusCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HotelStatusCode of HotelJSON is not a string.");
        TypeHotelStatusCode the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "vailable", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeHotelStatusCode.HotelStatusCode_Available;
                        goto enum_is_done;
                      }
                break;
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "rror", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeHotelStatusCode.HotelStatusCode_Error;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if (String.Compare(json_string.getData(), 1, "o", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case ' ':
                            if ((String.Compare(json_string.getData(), 3, "available rate plan", 0, 19, false) == 0) && (json_string.getData().Length == 22))
                                  {
                                    the_enum = TypeHotelStatusCode.HotelStatusCode_No_x20_available_x20_rate_x20_plan;
                                    goto enum_is_done;
                                  }
                            break;
                        case 't':
                            if ((String.Compare(json_string.getData(), 3, " available", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_enum = TypeHotelStatusCode.HotelStatusCode_Not_x20_available;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field HotelStatusCode of HotelJSON is not one of the legal strings.");
      enum_is_done:;
        setHotelStatusCode(the_enum);
      }


    private void  fromJSONHotelStatusDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HotelStatusDescription of HotelJSON is not a string.");
        setHotelStatusDescription(json_string.getData());
      }


    private void  fromJSONHotelPricing(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HotelPricingJSON convert_classy = HotelPricingJSON.from_json(json_value, ignore_extras, true);
        setHotelPricing(convert_classy);
      }


    private void  fromJSONHotelPromotion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeHotelPromotionJSON convert_classy = TypeHotelPromotionJSON.from_json(json_value, ignore_extras, true);
        setHotelPromotion(convert_classy);
      }


    private void  fromJSONHotelDetailsUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HotelDetailsUrl of HotelJSON is not a string.");
        setHotelDetailsUrl(json_string.getData());
      }


    private void  fromJSONHotelRateDetailsUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HotelRateDetailsUrl of HotelJSON is not a string.");
        setHotelRateDetailsUrl(json_string.getData());
      }


    private void  fromJSONHotelThumbnailUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HotelThumbnailUrl of HotelJSON is not a string.");
        setHotelThumbnailUrl(json_string.getData());
      }


    private void  fromJSONHotelImageUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HotelImageUrl of HotelJSON is not a string.");
        setHotelImageUrl(json_string.getData());
      }


    private void  fromJSONHotelStarRating(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HotelStarRating of HotelJSON is not a number.");
              }
          }
        setHotelStarRatingText(the_rational_text);
      }


    private void  fromJSONHotelGuestRating(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HotelGuestRating of HotelJSON is not a number.");
              }
          }
        setHotelGuestRatingText(the_rational_text);
      }


    private void  fromJSONHotelGuestReviewCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field HotelGuestReviewCount of HotelJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field HotelGuestReviewCount of HotelJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setHotelGuestReviewCount(extracted_integer);
      }


    private void  fromJSONHotelRoomTypes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field HotelRoomTypes of HotelJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeHotelRoomTypesJSON  > vector_HotelRoomTypes1 = new List< TypeHotelRoomTypesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeHotelRoomTypesJSON convert_classy = TypeHotelRoomTypesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_HotelRoomTypes1.Add(convert_classy);
          }
        initHotelRoomTypes();
        for (int num2 = 0; num2 < vector_HotelRoomTypes1.Count; ++num2)
            appendHotelRoomTypes(vector_HotelRoomTypes1[num2]);
        for (int num1 = 0; num1 < vector_HotelRoomTypes1.Count; ++num1)
          {
          }
      }


    private void  fromJSONHotelAmenities(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field HotelAmenities of HotelJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_HotelAmenities1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field HotelAmenities of HotelJSON is not a string.");
            vector_HotelAmenities1.Add(json_string.getData());
          }
        initHotelAmenities();
        for (int num3 = 0; num3 < vector_HotelAmenities1.Count; ++num3)
            appendHotelAmenities(vector_HotelAmenities1[num3]);
        for (int num1 = 0; num1 < vector_HotelAmenities1.Count; ++num1)
          {
          }
      }


    private void  fromJSONMatchedCriteriaInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MatchedCriteriaInclude of HotelJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_MatchedCriteriaInclude1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field MatchedCriteriaInclude of HotelJSON is not a string.");
            vector_MatchedCriteriaInclude1.Add(json_string.getData());
          }
        initMatchedCriteriaInclude();
        for (int num4 = 0; num4 < vector_MatchedCriteriaInclude1.Count; ++num4)
            appendMatchedCriteriaInclude(vector_MatchedCriteriaInclude1[num4]);
        for (int num1 = 0; num1 < vector_MatchedCriteriaInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONMatchedCriteriaExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MatchedCriteriaExclude of HotelJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_MatchedCriteriaExclude1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field MatchedCriteriaExclude of HotelJSON is not a string.");
            vector_MatchedCriteriaExclude1.Add(json_string.getData());
          }
        initMatchedCriteriaExclude();
        for (int num5 = 0; num5 < vector_MatchedCriteriaExclude1.Count; ++num5)
            appendMatchedCriteriaExclude(vector_MatchedCriteriaExclude1[num5]);
        for (int num1 = 0; num1 < vector_MatchedCriteriaExclude1.Count; ++num1)
          {
          }
      }


    public HotelJSON()
      {
        flagHasHotelID = false;
        flagHasHotelName = false;
        flagHasDistanceFromReference = false;
        flagHasDistanceFromReferenceUnit = false;
        flagHasHotelLocation = false;
        flagHasHotelDescription = false;
        flagHasHotelFeaturedOffer = false;
        flagHasHotelStatusCode = false;
        flagHasHotelStatusDescription = false;
        flagHasHotelPricing = false;
        flagHasHotelPromotion = false;
        flagHasHotelDetailsUrl = false;
        flagHasHotelRateDetailsUrl = false;
        flagHasHotelThumbnailUrl = false;
        flagHasHotelImageUrl = false;
        flagHasHotelStarRating = false;
        flagHasHotelGuestRating = false;
        flagHasHotelGuestReviewCount = false;
        flagHasHotelRoomTypes = false;
        flagHasHotelAmenities = false;
        flagHasMatchedCriteriaInclude = false;
        flagHasMatchedCriteriaExclude = false;
        storeHotelRoomTypes = new List< TypeHotelRoomTypesJSON  >();
        storeHotelAmenities = new List< string >();
        storeMatchedCriteriaInclude = new List< string >();
        storeMatchedCriteriaExclude = new List< string >();
      }

    public bool  hasHotelID()
      {
        return flagHasHotelID;
      }

    public BigInteger  getHotelID()
      {
        Debug.Assert(flagHasHotelID);
        return storeHotelID;
      }

    public bool  hasHotelName()
      {
        return flagHasHotelName;
      }

    public string  getHotelName()
      {
        Debug.Assert(flagHasHotelName);
        return storeHotelName;
      }

    public bool  hasDistanceFromReference()
      {
        return flagHasDistanceFromReference;
      }

    public double  getDistanceFromReference()
      {
        Debug.Assert(flagHasDistanceFromReference);
        if (textStoreDistanceFromReference != "")
          {
            return Double.Parse(textStoreDistanceFromReference);
          }
        return storeDistanceFromReference;
      }

    public string  getDistanceFromReferenceAsText()
      {
        Debug.Assert(flagHasDistanceFromReference);
        if (textStoreDistanceFromReference == "")
          {
            return Convert.ToString(storeDistanceFromReference);
          }
        else
          {
            return (textStoreDistanceFromReference);
          }
      }

    public bool  hasDistanceFromReferenceUnit()
      {
        return flagHasDistanceFromReferenceUnit;
      }

    public TypeDistanceFromReferenceUnit  getDistanceFromReferenceUnit()
      {
        Debug.Assert(flagHasDistanceFromReferenceUnit);
        return storeDistanceFromReferenceUnit;
      }

    public string  getDistanceFromReferenceUnitAsString()
      {
        return stringFromDistanceFromReferenceUnit(getDistanceFromReferenceUnit());
      }

    public bool  hasHotelLocation()
      {
        return flagHasHotelLocation;
      }

    public TypeHotelLocationJSON   getHotelLocation()
      {
        Debug.Assert(flagHasHotelLocation);
        return storeHotelLocation;
      }

    public bool  hasHotelDescription()
      {
        return flagHasHotelDescription;
      }

    public string  getHotelDescription()
      {
        Debug.Assert(flagHasHotelDescription);
        return storeHotelDescription;
      }

    public bool  hasHotelFeaturedOffer()
      {
        return flagHasHotelFeaturedOffer;
      }

    public TypeHotelFeaturedOfferJSON   getHotelFeaturedOffer()
      {
        Debug.Assert(flagHasHotelFeaturedOffer);
        return storeHotelFeaturedOffer;
      }

    public bool  hasHotelStatusCode()
      {
        return flagHasHotelStatusCode;
      }

    public TypeHotelStatusCode  getHotelStatusCode()
      {
        Debug.Assert(flagHasHotelStatusCode);
        return storeHotelStatusCode;
      }

    public string  getHotelStatusCodeAsString()
      {
        return stringFromHotelStatusCode(getHotelStatusCode());
      }

    public bool  hasHotelStatusDescription()
      {
        return flagHasHotelStatusDescription;
      }

    public string  getHotelStatusDescription()
      {
        Debug.Assert(flagHasHotelStatusDescription);
        return storeHotelStatusDescription;
      }

    public bool  hasHotelPricing()
      {
        return flagHasHotelPricing;
      }

    public HotelPricingJSON   getHotelPricing()
      {
        Debug.Assert(flagHasHotelPricing);
        return storeHotelPricing;
      }

    public bool  hasHotelPromotion()
      {
        return flagHasHotelPromotion;
      }

    public TypeHotelPromotionJSON   getHotelPromotion()
      {
        Debug.Assert(flagHasHotelPromotion);
        return storeHotelPromotion;
      }

    public bool  hasHotelDetailsUrl()
      {
        return flagHasHotelDetailsUrl;
      }

    public string  getHotelDetailsUrl()
      {
        Debug.Assert(flagHasHotelDetailsUrl);
        return storeHotelDetailsUrl;
      }

    public bool  hasHotelRateDetailsUrl()
      {
        return flagHasHotelRateDetailsUrl;
      }

    public string  getHotelRateDetailsUrl()
      {
        Debug.Assert(flagHasHotelRateDetailsUrl);
        return storeHotelRateDetailsUrl;
      }

    public bool  hasHotelThumbnailUrl()
      {
        return flagHasHotelThumbnailUrl;
      }

    public string  getHotelThumbnailUrl()
      {
        Debug.Assert(flagHasHotelThumbnailUrl);
        return storeHotelThumbnailUrl;
      }

    public bool  hasHotelImageUrl()
      {
        return flagHasHotelImageUrl;
      }

    public string  getHotelImageUrl()
      {
        Debug.Assert(flagHasHotelImageUrl);
        return storeHotelImageUrl;
      }

    public bool  hasHotelStarRating()
      {
        return flagHasHotelStarRating;
      }

    public double  getHotelStarRating()
      {
        Debug.Assert(flagHasHotelStarRating);
        if (textStoreHotelStarRating != "")
          {
            return Double.Parse(textStoreHotelStarRating);
          }
        return storeHotelStarRating;
      }

    public string  getHotelStarRatingAsText()
      {
        Debug.Assert(flagHasHotelStarRating);
        if (textStoreHotelStarRating == "")
          {
            return Convert.ToString(storeHotelStarRating);
          }
        else
          {
            return (textStoreHotelStarRating);
          }
      }

    public bool  hasHotelGuestRating()
      {
        return flagHasHotelGuestRating;
      }

    public double  getHotelGuestRating()
      {
        Debug.Assert(flagHasHotelGuestRating);
        if (textStoreHotelGuestRating != "")
          {
            return Double.Parse(textStoreHotelGuestRating);
          }
        return storeHotelGuestRating;
      }

    public string  getHotelGuestRatingAsText()
      {
        Debug.Assert(flagHasHotelGuestRating);
        if (textStoreHotelGuestRating == "")
          {
            return Convert.ToString(storeHotelGuestRating);
          }
        else
          {
            return (textStoreHotelGuestRating);
          }
      }

    public bool  hasHotelGuestReviewCount()
      {
        return flagHasHotelGuestReviewCount;
      }

    public BigInteger  getHotelGuestReviewCount()
      {
        Debug.Assert(flagHasHotelGuestReviewCount);
        return storeHotelGuestReviewCount;
      }

    public bool  hasHotelRoomTypes()
      {
        return flagHasHotelRoomTypes;
      }

    public int  countOfHotelRoomTypes()
      {
        Debug.Assert(flagHasHotelRoomTypes);
        return storeHotelRoomTypes.Count;
      }

    public TypeHotelRoomTypesJSON   elementOfHotelRoomTypes(int element_num)
      {
        Debug.Assert(flagHasHotelRoomTypes);
        return storeHotelRoomTypes[element_num];
      }

    public List< TypeHotelRoomTypesJSON  >  getHotelRoomTypes()
      {
        Debug.Assert(flagHasHotelRoomTypes);
        return storeHotelRoomTypes;
      }

    public bool  hasHotelAmenities()
      {
        return flagHasHotelAmenities;
      }

    public int  countOfHotelAmenities()
      {
        Debug.Assert(flagHasHotelAmenities);
        return storeHotelAmenities.Count;
      }

    public string  elementOfHotelAmenities(int element_num)
      {
        Debug.Assert(flagHasHotelAmenities);
        return storeHotelAmenities[element_num];
      }

    public List< string >  getHotelAmenities()
      {
        Debug.Assert(flagHasHotelAmenities);
        return storeHotelAmenities;
      }

    public bool  hasMatchedCriteriaInclude()
      {
        return flagHasMatchedCriteriaInclude;
      }

    public int  countOfMatchedCriteriaInclude()
      {
        Debug.Assert(flagHasMatchedCriteriaInclude);
        return storeMatchedCriteriaInclude.Count;
      }

    public string  elementOfMatchedCriteriaInclude(int element_num)
      {
        Debug.Assert(flagHasMatchedCriteriaInclude);
        return storeMatchedCriteriaInclude[element_num];
      }

    public List< string >  getMatchedCriteriaInclude()
      {
        Debug.Assert(flagHasMatchedCriteriaInclude);
        return storeMatchedCriteriaInclude;
      }

    public bool  hasMatchedCriteriaExclude()
      {
        return flagHasMatchedCriteriaExclude;
      }

    public int  countOfMatchedCriteriaExclude()
      {
        Debug.Assert(flagHasMatchedCriteriaExclude);
        return storeMatchedCriteriaExclude.Count;
      }

    public string  elementOfMatchedCriteriaExclude(int element_num)
      {
        Debug.Assert(flagHasMatchedCriteriaExclude);
        return storeMatchedCriteriaExclude[element_num];
      }

    public List< string >  getMatchedCriteriaExclude()
      {
        Debug.Assert(flagHasMatchedCriteriaExclude);
        return storeMatchedCriteriaExclude;
      }



    public void setHotelID(BigInteger new_value)
      {
        flagHasHotelID = true;
        if (new_value < 1)
            throw new Exception("The value for field HotelID of HotelJSON is less than the lower bound (1) for that field.");
        storeHotelID = new_value;
      }
    public void unsetHotelID()
      {
        flagHasHotelID = false;
      }
    public void setHotelName(string new_value)
      {
        flagHasHotelName = true;
        storeHotelName = new_value;
      }
    public void unsetHotelName()
      {
        flagHasHotelName = false;
      }
    public void setDistanceFromReference(double new_value)
      {
        flagHasDistanceFromReference = true;
        storeDistanceFromReference = new_value;
        textStoreDistanceFromReference = "";
      }
    public void setDistanceFromReferenceText(string new_value)
      {
        flagHasDistanceFromReference = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field DistanceFromReference of HotelJSON is not a valid number.");
        textStoreDistanceFromReference = new_value;
      }
    public void unsetDistanceFromReference()
      {
        flagHasDistanceFromReference = false;
      }
    public void setDistanceFromReferenceUnit(TypeDistanceFromReferenceUnit new_value)
      {
        flagHasDistanceFromReferenceUnit = true;
        storeDistanceFromReferenceUnit = new_value;
      }
    public void setDistanceFromReferenceUnit(string chars)
      {
        setDistanceFromReferenceUnit(stringToDistanceFromReferenceUnit(chars));
      }
    public void unsetDistanceFromReferenceUnit()
      {
        flagHasDistanceFromReferenceUnit = false;
      }
    public void setHotelLocation(TypeHotelLocationJSON  new_value)
      {
        if (flagHasHotelLocation)
          {
          }
        flagHasHotelLocation = true;
        storeHotelLocation = new_value;
      }
    public void unsetHotelLocation()
      {
        if (flagHasHotelLocation)
          {
          }
        flagHasHotelLocation = false;
      }
    public void setHotelDescription(string new_value)
      {
        flagHasHotelDescription = true;
        storeHotelDescription = new_value;
      }
    public void unsetHotelDescription()
      {
        flagHasHotelDescription = false;
      }
    public void setHotelFeaturedOffer(TypeHotelFeaturedOfferJSON  new_value)
      {
        if (flagHasHotelFeaturedOffer)
          {
          }
        flagHasHotelFeaturedOffer = true;
        storeHotelFeaturedOffer = new_value;
      }
    public void unsetHotelFeaturedOffer()
      {
        if (flagHasHotelFeaturedOffer)
          {
          }
        flagHasHotelFeaturedOffer = false;
      }
    public void setHotelStatusCode(TypeHotelStatusCode new_value)
      {
        flagHasHotelStatusCode = true;
        storeHotelStatusCode = new_value;
      }
    public void setHotelStatusCode(string chars)
      {
        setHotelStatusCode(stringToHotelStatusCode(chars));
      }
    public void unsetHotelStatusCode()
      {
        flagHasHotelStatusCode = false;
      }
    public void setHotelStatusDescription(string new_value)
      {
        flagHasHotelStatusDescription = true;
        storeHotelStatusDescription = new_value;
      }
    public void unsetHotelStatusDescription()
      {
        flagHasHotelStatusDescription = false;
      }
    public void setHotelPricing(HotelPricingJSON  new_value)
      {
        if (flagHasHotelPricing)
          {
          }
        flagHasHotelPricing = true;
        storeHotelPricing = new_value;
      }
    public void unsetHotelPricing()
      {
        if (flagHasHotelPricing)
          {
          }
        flagHasHotelPricing = false;
      }
    public void setHotelPromotion(TypeHotelPromotionJSON  new_value)
      {
        if (flagHasHotelPromotion)
          {
          }
        flagHasHotelPromotion = true;
        storeHotelPromotion = new_value;
      }
    public void unsetHotelPromotion()
      {
        if (flagHasHotelPromotion)
          {
          }
        flagHasHotelPromotion = false;
      }
    public void setHotelDetailsUrl(string new_value)
      {
        flagHasHotelDetailsUrl = true;
        storeHotelDetailsUrl = new_value;
      }
    public void unsetHotelDetailsUrl()
      {
        flagHasHotelDetailsUrl = false;
      }
    public void setHotelRateDetailsUrl(string new_value)
      {
        flagHasHotelRateDetailsUrl = true;
        storeHotelRateDetailsUrl = new_value;
      }
    public void unsetHotelRateDetailsUrl()
      {
        flagHasHotelRateDetailsUrl = false;
      }
    public void setHotelThumbnailUrl(string new_value)
      {
        flagHasHotelThumbnailUrl = true;
        storeHotelThumbnailUrl = new_value;
      }
    public void unsetHotelThumbnailUrl()
      {
        flagHasHotelThumbnailUrl = false;
      }
    public void setHotelImageUrl(string new_value)
      {
        flagHasHotelImageUrl = true;
        storeHotelImageUrl = new_value;
      }
    public void unsetHotelImageUrl()
      {
        flagHasHotelImageUrl = false;
      }
    public void setHotelStarRating(double new_value)
      {
        flagHasHotelStarRating = true;
        if (new_value < 0)
            throw new Exception("The value for field HotelStarRating of HotelJSON is less than the lower bound (0) for that field.");
        if (new_value > 5)
            throw new Exception("The value for field HotelStarRating of HotelJSON is greater than the upper bound (5) for that field.");
        storeHotelStarRating = new_value;
        textStoreHotelStarRating = "";
      }
    public void setHotelStarRatingText(string new_value)
      {
        flagHasHotelStarRating = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HotelStarRating of HotelJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field HotelStarRating of HotelJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "5", "", false, "1") > 0)
            throw new Exception("The value for field HotelStarRating of HotelJSON is greater than the upper bound (5) for that field.");
        textStoreHotelStarRating = new_value;
      }
    public void unsetHotelStarRating()
      {
        flagHasHotelStarRating = false;
      }
    public void setHotelGuestRating(double new_value)
      {
        flagHasHotelGuestRating = true;
        if (new_value < 0)
            throw new Exception("The value for field HotelGuestRating of HotelJSON is less than the lower bound (0) for that field.");
        if (new_value > 5)
            throw new Exception("The value for field HotelGuestRating of HotelJSON is greater than the upper bound (5) for that field.");
        storeHotelGuestRating = new_value;
        textStoreHotelGuestRating = "";
      }
    public void setHotelGuestRatingText(string new_value)
      {
        flagHasHotelGuestRating = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HotelGuestRating of HotelJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field HotelGuestRating of HotelJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "5", "", false, "1") > 0)
            throw new Exception("The value for field HotelGuestRating of HotelJSON is greater than the upper bound (5) for that field.");
        textStoreHotelGuestRating = new_value;
      }
    public void unsetHotelGuestRating()
      {
        flagHasHotelGuestRating = false;
      }
    public void setHotelGuestReviewCount(BigInteger new_value)
      {
        flagHasHotelGuestReviewCount = true;
        if (new_value < 0)
            throw new Exception("The value for field HotelGuestReviewCount of HotelJSON is less than the lower bound (0) for that field.");
        storeHotelGuestReviewCount = new_value;
      }
    public void unsetHotelGuestReviewCount()
      {
        flagHasHotelGuestReviewCount = false;
      }
    public void initHotelRoomTypes()
      {
        if (flagHasHotelRoomTypes)
          {
            for (int num3 = 0; num3 < storeHotelRoomTypes.Count; ++num3)
              {
              }
          }
        flagHasHotelRoomTypes = true;
        storeHotelRoomTypes.Clear();
      }
    public void appendHotelRoomTypes(TypeHotelRoomTypesJSON  to_append)
      {
        if (!flagHasHotelRoomTypes)
          {
            flagHasHotelRoomTypes = true;
            storeHotelRoomTypes.Clear();
          }
        Debug.Assert(flagHasHotelRoomTypes);
        storeHotelRoomTypes.Add(to_append);
      }
    public void unsetHotelRoomTypes()
      {
        if (flagHasHotelRoomTypes)
          {
            for (int num4 = 0; num4 < storeHotelRoomTypes.Count; ++num4)
              {
              }
          }
        flagHasHotelRoomTypes = false;
        storeHotelRoomTypes.Clear();
      }
    public void initHotelAmenities()
      {
        flagHasHotelAmenities = true;
        storeHotelAmenities.Clear();
      }
    public void appendHotelAmenities(string to_append)
      {
        if (!flagHasHotelAmenities)
          {
            flagHasHotelAmenities = true;
            storeHotelAmenities.Clear();
          }
        Debug.Assert(flagHasHotelAmenities);
        storeHotelAmenities.Add(to_append);
      }
    public void unsetHotelAmenities()
      {
        flagHasHotelAmenities = false;
        storeHotelAmenities.Clear();
      }
    public void initMatchedCriteriaInclude()
      {
        flagHasMatchedCriteriaInclude = true;
        storeMatchedCriteriaInclude.Clear();
      }
    public void appendMatchedCriteriaInclude(string to_append)
      {
        if (!flagHasMatchedCriteriaInclude)
          {
            flagHasMatchedCriteriaInclude = true;
            storeMatchedCriteriaInclude.Clear();
          }
        Debug.Assert(flagHasMatchedCriteriaInclude);
        storeMatchedCriteriaInclude.Add(to_append);
      }
    public void unsetMatchedCriteriaInclude()
      {
        flagHasMatchedCriteriaInclude = false;
        storeMatchedCriteriaInclude.Clear();
      }
    public void initMatchedCriteriaExclude()
      {
        flagHasMatchedCriteriaExclude = true;
        storeMatchedCriteriaExclude.Clear();
      }
    public void appendMatchedCriteriaExclude(string to_append)
      {
        if (!flagHasMatchedCriteriaExclude)
          {
            flagHasMatchedCriteriaExclude = true;
            storeMatchedCriteriaExclude.Clear();
          }
        Debug.Assert(flagHasMatchedCriteriaExclude);
        storeMatchedCriteriaExclude.Add(to_append);
      }
    public void unsetMatchedCriteriaExclude()
      {
        flagHasMatchedCriteriaExclude = false;
        storeMatchedCriteriaExclude.Clear();
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
        if (flagHasHotelID)
          {
            handler.start_pair("HotelID");
            handler.number_value(storeHotelID);
          }
        if (flagHasHotelName)
          {
            handler.start_pair("HotelName");
            handler.string_value(storeHotelName);
          }
        if (flagHasDistanceFromReference)
          {
            handler.start_pair("DistanceFromReference");
            if (textStoreDistanceFromReference != "")
                handler.number_value(textStoreDistanceFromReference);
            else if (((double)(long)storeDistanceFromReference) == storeDistanceFromReference)
                handler.number_value((long)storeDistanceFromReference);
            else
                handler.number_value(storeDistanceFromReference);
          }
        if (flagHasDistanceFromReferenceUnit)
          {
            handler.start_pair("DistanceFromReferenceUnit");
            switch (storeDistanceFromReferenceUnit)
              {
                case TypeDistanceFromReferenceUnit.DistanceFromReferenceUnit_km:
                    handler.string_value("km");
                    break;
                case TypeDistanceFromReferenceUnit.DistanceFromReferenceUnit_mi:
                    handler.string_value("mi");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasHotelLocation)
          {
            handler.start_pair("HotelLocation");
            if (partial_allowed)
                storeHotelLocation.write_partial_as_json(handler);
            else
                storeHotelLocation.write_as_json(handler);
          }
        if (flagHasHotelDescription)
          {
            handler.start_pair("HotelDescription");
            handler.string_value(storeHotelDescription);
          }
        if (flagHasHotelFeaturedOffer)
          {
            handler.start_pair("HotelFeaturedOffer");
            if (partial_allowed)
                storeHotelFeaturedOffer.write_partial_as_json(handler);
            else
                storeHotelFeaturedOffer.write_as_json(handler);
          }
        if (flagHasHotelStatusCode)
          {
            handler.start_pair("HotelStatusCode");
            switch (storeHotelStatusCode)
              {
                case TypeHotelStatusCode.HotelStatusCode_Available:
                    handler.string_value("Available");
                    break;
                case TypeHotelStatusCode.HotelStatusCode_Not_x20_available:
                    handler.string_value("Not available");
                    break;
                case TypeHotelStatusCode.HotelStatusCode_Error:
                    handler.string_value("Error");
                    break;
                case TypeHotelStatusCode.HotelStatusCode_No_x20_available_x20_rate_x20_plan:
                    handler.string_value("No available rate plan");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasHotelStatusDescription)
          {
            handler.start_pair("HotelStatusDescription");
            handler.string_value(storeHotelStatusDescription);
          }
        if (flagHasHotelPricing)
          {
            handler.start_pair("HotelPricing");
            if (partial_allowed)
                storeHotelPricing.write_partial_as_json(handler);
            else
                storeHotelPricing.write_as_json(handler);
          }
        if (flagHasHotelPromotion)
          {
            handler.start_pair("HotelPromotion");
            if (partial_allowed)
                storeHotelPromotion.write_partial_as_json(handler);
            else
                storeHotelPromotion.write_as_json(handler);
          }
        if (flagHasHotelDetailsUrl)
          {
            handler.start_pair("HotelDetailsUrl");
            handler.string_value(storeHotelDetailsUrl);
          }
        if (flagHasHotelRateDetailsUrl)
          {
            handler.start_pair("HotelRateDetailsUrl");
            handler.string_value(storeHotelRateDetailsUrl);
          }
        if (flagHasHotelThumbnailUrl)
          {
            handler.start_pair("HotelThumbnailUrl");
            handler.string_value(storeHotelThumbnailUrl);
          }
        if (flagHasHotelImageUrl)
          {
            handler.start_pair("HotelImageUrl");
            handler.string_value(storeHotelImageUrl);
          }
        if (flagHasHotelStarRating)
          {
            handler.start_pair("HotelStarRating");
            if (textStoreHotelStarRating != "")
                handler.number_value(textStoreHotelStarRating);
            else if (((double)(long)storeHotelStarRating) == storeHotelStarRating)
                handler.number_value((long)storeHotelStarRating);
            else
                handler.number_value(storeHotelStarRating);
          }
        if (flagHasHotelGuestRating)
          {
            handler.start_pair("HotelGuestRating");
            if (textStoreHotelGuestRating != "")
                handler.number_value(textStoreHotelGuestRating);
            else if (((double)(long)storeHotelGuestRating) == storeHotelGuestRating)
                handler.number_value((long)storeHotelGuestRating);
            else
                handler.number_value(storeHotelGuestRating);
          }
        if (flagHasHotelGuestReviewCount)
          {
            handler.start_pair("HotelGuestReviewCount");
            handler.number_value(storeHotelGuestReviewCount);
          }
        if (flagHasHotelRoomTypes)
          {
            handler.start_pair("HotelRoomTypes");
            handler.start_array();
            for (int num1 = 0; num1 < storeHotelRoomTypes.Count; ++num1)
              {
                if (partial_allowed)
                    storeHotelRoomTypes[num1].write_partial_as_json(handler);
                else
                    storeHotelRoomTypes[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasHotelAmenities)
          {
            handler.start_pair("HotelAmenities");
            handler.start_array();
            for (int num2 = 0; num2 < storeHotelAmenities.Count; ++num2)
              {
                handler.string_value(storeHotelAmenities[num2]);
              }
            handler.finish_array();
          }
        if (flagHasMatchedCriteriaInclude)
          {
            handler.start_pair("MatchedCriteriaInclude");
            handler.start_array();
            for (int num3 = 0; num3 < storeMatchedCriteriaInclude.Count; ++num3)
              {
                handler.string_value(storeMatchedCriteriaInclude[num3]);
              }
            handler.finish_array();
          }
        if (flagHasMatchedCriteriaExclude)
          {
            handler.start_pair("MatchedCriteriaExclude");
            handler.start_array();
            for (int num4 = 0; num4 < storeMatchedCriteriaExclude.Count; ++num4)
              {
                handler.string_value(storeMatchedCriteriaExclude[num4]);
              }
            handler.finish_array();
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
        return null;
      }

    public static HotelJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HotelJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Hotel", ignore_extras);
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
    public static HotelJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HotelJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HotelJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Hotel", ignore_extras);
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
    public static HotelJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HotelJSON from_text(string text, bool ignore_extras)
      {
        HotelJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Hotel", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HotelJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HotelJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HotelJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Hotel", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorHotelID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorHotelID(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorHotelID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorHotelID(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorHotelID fieldGeneratorHotelID;
        private JSONHoldingStringGenerator fieldGeneratorHotelName;
        private JSONHoldingNumberTextGenerator fieldGeneratorDistanceFromReference;
    private abstract class FieldGeneratorDistanceFromReferenceUnit : JSONStringGenerator
          {
            protected FieldGeneratorDistanceFromReferenceUnit(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDistanceFromReferenceUnit()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToDistanceFromReferenceUnit(result));
              }
            protected abstract void handle_result(TypeDistanceFromReferenceUnit result);
          };
    private class FieldHoldingGeneratorDistanceFromReferenceUnit : FieldGeneratorDistanceFromReferenceUnit
  {
    protected override void handle_result(TypeDistanceFromReferenceUnit result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDistanceFromReferenceUnit(String what)
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
    public TypeDistanceFromReferenceUnit value;
  };
    private class FieldHoldingArrayGeneratorDistanceFromReferenceUnit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDistanceFromReferenceUnit
      {
        private FieldHoldingArrayGeneratorDistanceFromReferenceUnit top;

        protected override void handle_result(TypeDistanceFromReferenceUnit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDistanceFromReferenceUnit init_top)
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
    protected virtual void handle_result(List<TypeDistanceFromReferenceUnit> result)
      {
      }

    public FieldHoldingArrayGeneratorDistanceFromReferenceUnit(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDistanceFromReferenceUnit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDistanceFromReferenceUnit()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDistanceFromReferenceUnit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDistanceFromReferenceUnit> value;
  };
        private FieldHoldingGeneratorDistanceFromReferenceUnit fieldGeneratorDistanceFromReferenceUnit;
        private TypeHotelLocationJSON.HoldingGenerator fieldGeneratorHotelLocation;
        private JSONHoldingStringGenerator fieldGeneratorHotelDescription;
        private TypeHotelFeaturedOfferJSON.HoldingGenerator fieldGeneratorHotelFeaturedOffer;
    private abstract class FieldGeneratorHotelStatusCode : JSONStringGenerator
          {
            protected FieldGeneratorHotelStatusCode(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorHotelStatusCode()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToHotelStatusCode(result));
              }
            protected abstract void handle_result(TypeHotelStatusCode result);
          };
    private class FieldHoldingGeneratorHotelStatusCode : FieldGeneratorHotelStatusCode
  {
    protected override void handle_result(TypeHotelStatusCode result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorHotelStatusCode(String what)
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
    public TypeHotelStatusCode value;
  };
    private class FieldHoldingArrayGeneratorHotelStatusCode : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorHotelStatusCode
      {
        private FieldHoldingArrayGeneratorHotelStatusCode top;

        protected override void handle_result(TypeHotelStatusCode result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorHotelStatusCode init_top)
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
    protected virtual void handle_result(List<TypeHotelStatusCode> result)
      {
      }

    public FieldHoldingArrayGeneratorHotelStatusCode(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeHotelStatusCode>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorHotelStatusCode()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeHotelStatusCode>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeHotelStatusCode> value;
  };
        private FieldHoldingGeneratorHotelStatusCode fieldGeneratorHotelStatusCode;
        private JSONHoldingStringGenerator fieldGeneratorHotelStatusDescription;
        private HotelPricingJSON.HoldingGenerator fieldGeneratorHotelPricing;
        private TypeHotelPromotionJSON.HoldingGenerator fieldGeneratorHotelPromotion;
        private JSONHoldingStringGenerator fieldGeneratorHotelDetailsUrl;
        private JSONHoldingStringGenerator fieldGeneratorHotelRateDetailsUrl;
        private JSONHoldingStringGenerator fieldGeneratorHotelThumbnailUrl;
        private JSONHoldingStringGenerator fieldGeneratorHotelImageUrl;
        private JSONHoldingNumberTextGenerator fieldGeneratorHotelStarRating;
        private JSONHoldingNumberTextGenerator fieldGeneratorHotelGuestRating;
    private class FieldHoldingGeneratorHotelGuestReviewCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorHotelGuestReviewCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorHotelGuestReviewCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorHotelGuestReviewCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorHotelGuestReviewCount fieldGeneratorHotelGuestReviewCount;
        private TypeHotelRoomTypesJSON.HoldingArrayGenerator fieldGeneratorHotelRoomTypes;
        private JSONHoldingStringArrayGenerator fieldGeneratorHotelAmenities;
        private JSONHoldingStringArrayGenerator fieldGeneratorMatchedCriteriaInclude;
        private JSONHoldingStringArrayGenerator fieldGeneratorMatchedCriteriaExclude;

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
            HotelJSON result = new HotelJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(HotelJSON result)
          {
            if (fieldGeneratorHotelID.have_value)
              {
                result.setHotelID(fieldGeneratorHotelID.value);
                fieldGeneratorHotelID.have_value = false;
              }
            if (fieldGeneratorHotelName.have_value)
              {
                result.setHotelName(fieldGeneratorHotelName.value);
                fieldGeneratorHotelName.have_value = false;
              }
            if (fieldGeneratorDistanceFromReference.have_value)
              {
                result.setDistanceFromReferenceText(fieldGeneratorDistanceFromReference.value);
                fieldGeneratorDistanceFromReference.have_value = false;
              }
            if (fieldGeneratorDistanceFromReferenceUnit.have_value)
              {
                result.setDistanceFromReferenceUnit(fieldGeneratorDistanceFromReferenceUnit.value);
                fieldGeneratorDistanceFromReferenceUnit.have_value = false;
              }
            if (fieldGeneratorHotelLocation.have_value)
              {
                result.setHotelLocation(fieldGeneratorHotelLocation.value);
                fieldGeneratorHotelLocation.have_value = false;
              }
            if (fieldGeneratorHotelDescription.have_value)
              {
                result.setHotelDescription(fieldGeneratorHotelDescription.value);
                fieldGeneratorHotelDescription.have_value = false;
              }
            if (fieldGeneratorHotelFeaturedOffer.have_value)
              {
                result.setHotelFeaturedOffer(fieldGeneratorHotelFeaturedOffer.value);
                fieldGeneratorHotelFeaturedOffer.have_value = false;
              }
            if (fieldGeneratorHotelStatusCode.have_value)
              {
                result.setHotelStatusCode(fieldGeneratorHotelStatusCode.value);
                fieldGeneratorHotelStatusCode.have_value = false;
              }
            if (fieldGeneratorHotelStatusDescription.have_value)
              {
                result.setHotelStatusDescription(fieldGeneratorHotelStatusDescription.value);
                fieldGeneratorHotelStatusDescription.have_value = false;
              }
            if (fieldGeneratorHotelPricing.have_value)
              {
                result.setHotelPricing(fieldGeneratorHotelPricing.value);
                fieldGeneratorHotelPricing.have_value = false;
              }
            if (fieldGeneratorHotelPromotion.have_value)
              {
                result.setHotelPromotion(fieldGeneratorHotelPromotion.value);
                fieldGeneratorHotelPromotion.have_value = false;
              }
            if (fieldGeneratorHotelDetailsUrl.have_value)
              {
                result.setHotelDetailsUrl(fieldGeneratorHotelDetailsUrl.value);
                fieldGeneratorHotelDetailsUrl.have_value = false;
              }
            if (fieldGeneratorHotelRateDetailsUrl.have_value)
              {
                result.setHotelRateDetailsUrl(fieldGeneratorHotelRateDetailsUrl.value);
                fieldGeneratorHotelRateDetailsUrl.have_value = false;
              }
            if (fieldGeneratorHotelThumbnailUrl.have_value)
              {
                result.setHotelThumbnailUrl(fieldGeneratorHotelThumbnailUrl.value);
                fieldGeneratorHotelThumbnailUrl.have_value = false;
              }
            if (fieldGeneratorHotelImageUrl.have_value)
              {
                result.setHotelImageUrl(fieldGeneratorHotelImageUrl.value);
                fieldGeneratorHotelImageUrl.have_value = false;
              }
            if (fieldGeneratorHotelStarRating.have_value)
              {
                result.setHotelStarRatingText(fieldGeneratorHotelStarRating.value);
                fieldGeneratorHotelStarRating.have_value = false;
              }
            if (fieldGeneratorHotelGuestRating.have_value)
              {
                result.setHotelGuestRatingText(fieldGeneratorHotelGuestRating.value);
                fieldGeneratorHotelGuestRating.have_value = false;
              }
            if (fieldGeneratorHotelGuestReviewCount.have_value)
              {
                result.setHotelGuestReviewCount(fieldGeneratorHotelGuestReviewCount.value);
                fieldGeneratorHotelGuestReviewCount.have_value = false;
              }
            if (fieldGeneratorHotelRoomTypes.have_value)
              {
                result.initHotelRoomTypes();
                int count = fieldGeneratorHotelRoomTypes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHotelRoomTypes(fieldGeneratorHotelRoomTypes.value[num]);
                  }
                fieldGeneratorHotelRoomTypes.value.Clear();
                fieldGeneratorHotelRoomTypes.have_value = false;
              }
            if (fieldGeneratorHotelAmenities.have_value)
              {
                result.initHotelAmenities();
                int count = fieldGeneratorHotelAmenities.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHotelAmenities(fieldGeneratorHotelAmenities.value[num]);
                  }
                fieldGeneratorHotelAmenities.value.Clear();
                fieldGeneratorHotelAmenities.have_value = false;
              }
            if (fieldGeneratorMatchedCriteriaInclude.have_value)
              {
                result.initMatchedCriteriaInclude();
                int count = fieldGeneratorMatchedCriteriaInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMatchedCriteriaInclude(fieldGeneratorMatchedCriteriaInclude.value[num]);
                  }
                fieldGeneratorMatchedCriteriaInclude.value.Clear();
                fieldGeneratorMatchedCriteriaInclude.have_value = false;
              }
            if (fieldGeneratorMatchedCriteriaExclude.have_value)
              {
                result.initMatchedCriteriaExclude();
                int count = fieldGeneratorMatchedCriteriaExclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMatchedCriteriaExclude(fieldGeneratorMatchedCriteriaExclude.value[num]);
                  }
                fieldGeneratorMatchedCriteriaExclude.value.Clear();
                fieldGeneratorMatchedCriteriaExclude.have_value = false;
              }
          }
        protected abstract void handle_result(HotelJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "istanceFromReference", 0, 20, false) == 0)
                      {
                        if (field_name.Length == 21)
                          {
                            return fieldGeneratorDistanceFromReference;
                          }
                        switch (field_name[21])
                          {
                            case 'U':
                                if ((String.Compare(field_name, 22, "nit", 0, 3, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorDistanceFromReferenceUnit;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if (String.Compare(field_name, 1, "otel", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 6, "menities", 0, 8, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorHotelAmenities;
                                break;
                            case 'D':
                                if (String.Compare(field_name, 6, "e", 0, 1, false) == 0)
                                  {
                                    switch (field_name[7])
                                      {
                                        case 's':
                                            if ((String.Compare(field_name, 8, "cription", 0, 8, false) == 0) && (field_name.Length == 16))
                                                return fieldGeneratorHotelDescription;
                                            break;
                                        case 't':
                                            if ((String.Compare(field_name, 8, "ailsUrl", 0, 7, false) == 0) && (field_name.Length == 15))
                                                return fieldGeneratorHotelDetailsUrl;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'F':
                                if ((String.Compare(field_name, 6, "eaturedOffer", 0, 12, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorHotelFeaturedOffer;
                                break;
                            case 'G':
                                if (String.Compare(field_name, 6, "uestR", 0, 5, false) == 0)
                                  {
                                    switch (field_name[11])
                                      {
                                        case 'a':
                                            if ((String.Compare(field_name, 12, "ting", 0, 4, false) == 0) && (field_name.Length == 16))
                                                return fieldGeneratorHotelGuestRating;
                                            break;
                                        case 'e':
                                            if ((String.Compare(field_name, 12, "viewCount", 0, 9, false) == 0) && (field_name.Length == 21))
                                                return fieldGeneratorHotelGuestReviewCount;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'I':
                                switch (field_name[6])
                                  {
                                    case 'D':
                                        if (field_name.Length == 7)
                                            return fieldGeneratorHotelID;
                                        break;
                                    case 'm':
                                        if ((String.Compare(field_name, 7, "ageUrl", 0, 6, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorHotelImageUrl;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 6, "ocation", 0, 7, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorHotelLocation;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 6, "ame", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorHotelName;
                                break;
                            case 'P':
                                if (String.Compare(field_name, 6, "r", 0, 1, false) == 0)
                                  {
                                    switch (field_name[7])
                                      {
                                        case 'i':
                                            if ((String.Compare(field_name, 8, "cing", 0, 4, false) == 0) && (field_name.Length == 12))
                                                return fieldGeneratorHotelPricing;
                                            break;
                                        case 'o':
                                            if ((String.Compare(field_name, 8, "motion", 0, 6, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorHotelPromotion;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'R':
                                switch (field_name[6])
                                  {
                                    case 'a':
                                        if ((String.Compare(field_name, 7, "teDetailsUrl", 0, 12, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorHotelRateDetailsUrl;
                                        break;
                                    case 'o':
                                        if ((String.Compare(field_name, 7, "omTypes", 0, 7, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorHotelRoomTypes;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'S':
                                if (String.Compare(field_name, 6, "ta", 0, 2, false) == 0)
                                  {
                                    switch (field_name[8])
                                      {
                                        case 'r':
                                            if ((String.Compare(field_name, 9, "Rating", 0, 6, false) == 0) && (field_name.Length == 15))
                                                return fieldGeneratorHotelStarRating;
                                            break;
                                        case 't':
                                            if (String.Compare(field_name, 9, "us", 0, 2, false) == 0)
                                              {
                                                switch (field_name[11])
                                                  {
                                                    case 'C':
                                                        if ((String.Compare(field_name, 12, "ode", 0, 3, false) == 0) && (field_name.Length == 15))
                                                            return fieldGeneratorHotelStatusCode;
                                                        break;
                                                    case 'D':
                                                        if ((String.Compare(field_name, 12, "escription", 0, 10, false) == 0) && (field_name.Length == 22))
                                                            return fieldGeneratorHotelStatusDescription;
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
                            case 'T':
                                if ((String.Compare(field_name, 6, "humbnailUrl", 0, 11, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorHotelThumbnailUrl;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "atchedCriteria", 0, 14, false) == 0)
                      {
                        switch (field_name[15])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 16, "xclude", 0, 6, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorMatchedCriteriaExclude;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 16, "nclude", 0, 6, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorMatchedCriteriaInclude;
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
            fieldGeneratorHotelID = new FieldHoldingGeneratorHotelID("field \"HotelID\" of the Hotel class");
            fieldGeneratorHotelName = new JSONHoldingStringGenerator("field \"HotelName\" of the Hotel class");
            fieldGeneratorDistanceFromReference = new JSONHoldingNumberTextGenerator("field \"DistanceFromReference\" of the Hotel class");
            fieldGeneratorDistanceFromReferenceUnit = new FieldHoldingGeneratorDistanceFromReferenceUnit("field \"DistanceFromReferenceUnit\" of the Hotel class");
            fieldGeneratorHotelLocation = new TypeHotelLocationJSON.HoldingGenerator("field \"HotelLocation\" of the Hotel class", ignore_extras);
            fieldGeneratorHotelDescription = new JSONHoldingStringGenerator("field \"HotelDescription\" of the Hotel class");
            fieldGeneratorHotelFeaturedOffer = new TypeHotelFeaturedOfferJSON.HoldingGenerator("field \"HotelFeaturedOffer\" of the Hotel class", ignore_extras);
            fieldGeneratorHotelStatusCode = new FieldHoldingGeneratorHotelStatusCode("field \"HotelStatusCode\" of the Hotel class");
            fieldGeneratorHotelStatusDescription = new JSONHoldingStringGenerator("field \"HotelStatusDescription\" of the Hotel class");
            fieldGeneratorHotelPricing = new HotelPricingJSON.HoldingGenerator("field \"HotelPricing\" of the Hotel class", ignore_extras);
            fieldGeneratorHotelPromotion = new TypeHotelPromotionJSON.HoldingGenerator("field \"HotelPromotion\" of the Hotel class", ignore_extras);
            fieldGeneratorHotelDetailsUrl = new JSONHoldingStringGenerator("field \"HotelDetailsUrl\" of the Hotel class");
            fieldGeneratorHotelRateDetailsUrl = new JSONHoldingStringGenerator("field \"HotelRateDetailsUrl\" of the Hotel class");
            fieldGeneratorHotelThumbnailUrl = new JSONHoldingStringGenerator("field \"HotelThumbnailUrl\" of the Hotel class");
            fieldGeneratorHotelImageUrl = new JSONHoldingStringGenerator("field \"HotelImageUrl\" of the Hotel class");
            fieldGeneratorHotelStarRating = new JSONHoldingNumberTextGenerator("field \"HotelStarRating\" of the Hotel class");
            fieldGeneratorHotelGuestRating = new JSONHoldingNumberTextGenerator("field \"HotelGuestRating\" of the Hotel class");
            fieldGeneratorHotelGuestReviewCount = new FieldHoldingGeneratorHotelGuestReviewCount("field \"HotelGuestReviewCount\" of the Hotel class");
            fieldGeneratorHotelRoomTypes = new TypeHotelRoomTypesJSON.HoldingArrayGenerator("field \"HotelRoomTypes\" of the Hotel class", ignore_extras);
            fieldGeneratorHotelAmenities = new JSONHoldingStringArrayGenerator("field \"HotelAmenities\" of the Hotel class");
            fieldGeneratorMatchedCriteriaInclude = new JSONHoldingStringArrayGenerator("field \"MatchedCriteriaInclude\" of the Hotel class");
            fieldGeneratorMatchedCriteriaExclude = new JSONHoldingStringArrayGenerator("field \"MatchedCriteriaExclude\" of the Hotel class");
            set_what("the Hotel class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorHotelID = new FieldHoldingGeneratorHotelID("field \"HotelID\" of the Hotel class");
            fieldGeneratorHotelName = new JSONHoldingStringGenerator("field \"HotelName\" of the Hotel class");
            fieldGeneratorDistanceFromReference = new JSONHoldingNumberTextGenerator("field \"DistanceFromReference\" of the Hotel class");
            fieldGeneratorDistanceFromReferenceUnit = new FieldHoldingGeneratorDistanceFromReferenceUnit("field \"DistanceFromReferenceUnit\" of the Hotel class");
            fieldGeneratorHotelLocation = new TypeHotelLocationJSON.HoldingGenerator("field \"HotelLocation\" of the Hotel class", false);
            fieldGeneratorHotelDescription = new JSONHoldingStringGenerator("field \"HotelDescription\" of the Hotel class");
            fieldGeneratorHotelFeaturedOffer = new TypeHotelFeaturedOfferJSON.HoldingGenerator("field \"HotelFeaturedOffer\" of the Hotel class", false);
            fieldGeneratorHotelStatusCode = new FieldHoldingGeneratorHotelStatusCode("field \"HotelStatusCode\" of the Hotel class");
            fieldGeneratorHotelStatusDescription = new JSONHoldingStringGenerator("field \"HotelStatusDescription\" of the Hotel class");
            fieldGeneratorHotelPricing = new HotelPricingJSON.HoldingGenerator("field \"HotelPricing\" of the Hotel class", false);
            fieldGeneratorHotelPromotion = new TypeHotelPromotionJSON.HoldingGenerator("field \"HotelPromotion\" of the Hotel class", false);
            fieldGeneratorHotelDetailsUrl = new JSONHoldingStringGenerator("field \"HotelDetailsUrl\" of the Hotel class");
            fieldGeneratorHotelRateDetailsUrl = new JSONHoldingStringGenerator("field \"HotelRateDetailsUrl\" of the Hotel class");
            fieldGeneratorHotelThumbnailUrl = new JSONHoldingStringGenerator("field \"HotelThumbnailUrl\" of the Hotel class");
            fieldGeneratorHotelImageUrl = new JSONHoldingStringGenerator("field \"HotelImageUrl\" of the Hotel class");
            fieldGeneratorHotelStarRating = new JSONHoldingNumberTextGenerator("field \"HotelStarRating\" of the Hotel class");
            fieldGeneratorHotelGuestRating = new JSONHoldingNumberTextGenerator("field \"HotelGuestRating\" of the Hotel class");
            fieldGeneratorHotelGuestReviewCount = new FieldHoldingGeneratorHotelGuestReviewCount("field \"HotelGuestReviewCount\" of the Hotel class");
            fieldGeneratorHotelRoomTypes = new TypeHotelRoomTypesJSON.HoldingArrayGenerator("field \"HotelRoomTypes\" of the Hotel class", false);
            fieldGeneratorHotelAmenities = new JSONHoldingStringArrayGenerator("field \"HotelAmenities\" of the Hotel class");
            fieldGeneratorMatchedCriteriaInclude = new JSONHoldingStringArrayGenerator("field \"MatchedCriteriaInclude\" of the Hotel class");
            fieldGeneratorMatchedCriteriaExclude = new JSONHoldingStringArrayGenerator("field \"MatchedCriteriaExclude\" of the Hotel class");
            set_what("the Hotel class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorHotelID.reset();
            fieldGeneratorHotelName.reset();
            fieldGeneratorDistanceFromReference.reset();
            fieldGeneratorDistanceFromReferenceUnit.reset();
            fieldGeneratorHotelLocation.reset();
            fieldGeneratorHotelDescription.reset();
            fieldGeneratorHotelFeaturedOffer.reset();
            fieldGeneratorHotelStatusCode.reset();
            fieldGeneratorHotelStatusDescription.reset();
            fieldGeneratorHotelPricing.reset();
            fieldGeneratorHotelPromotion.reset();
            fieldGeneratorHotelDetailsUrl.reset();
            fieldGeneratorHotelRateDetailsUrl.reset();
            fieldGeneratorHotelThumbnailUrl.reset();
            fieldGeneratorHotelImageUrl.reset();
            fieldGeneratorHotelStarRating.reset();
            fieldGeneratorHotelGuestRating.reset();
            fieldGeneratorHotelGuestReviewCount.reset();
            fieldGeneratorHotelRoomTypes.reset();
            fieldGeneratorHotelAmenities.reset();
            fieldGeneratorMatchedCriteriaInclude.reset();
            fieldGeneratorMatchedCriteriaExclude.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorHotelLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHotelFeaturedOffer.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHotelPricing.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHotelPromotion.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHotelRoomTypes.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorHotelLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHotelFeaturedOffer.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHotelPricing.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHotelPromotion.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHotelRoomTypes.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HotelJSON  result)
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
        public HotelJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HotelJSON  result)
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
    protected virtual void handle_result(List<HotelJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HotelJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HotelJSON>();
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
    public List<HotelJSON> value;
  };
  };
