/* file "MapLocationForContactsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MapLocationForContactsJSON : JSONBase
  {
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
    private bool flagHasLatitude;
    private double storeLatitude;
    private string textStoreLatitude;
    private bool flagHasLongitude;
    private double storeLongitude;
    private string textStoreLongitude;
    private bool flagHasReferenceDatum;
    private string storeReferenceDatum;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONAddress(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Address of MapLocationForContactsJSON is not a string.");
        setAddress(json_string.getData());
      }


    private void  fromJSONStreetNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StreetNumber of MapLocationForContactsJSON is not a string.");
        setStreetNumber(json_string.getData());
      }


    private void  fromJSONStreetSecondaryNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StreetSecondaryNumber of MapLocationForContactsJSON is not a string.");
        setStreetSecondaryNumber(json_string.getData());
      }


    private void  fromJSONStreetName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StreetName of MapLocationForContactsJSON is not a string.");
        setStreetName(json_string.getData());
      }


    private void  fromJSONCity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field City of MapLocationForContactsJSON is not a string.");
        setCity(json_string.getData());
      }


    private void  fromJSONAdmin2(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Admin2 of MapLocationForContactsJSON is not a string.");
        setAdmin2(json_string.getData());
      }


    private void  fromJSONAdmin1(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Admin1 of MapLocationForContactsJSON is not a string.");
        setAdmin1(json_string.getData());
      }


    private void  fromJSONCountry(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Country of MapLocationForContactsJSON is not a string.");
        setCountry(json_string.getData());
      }


    private void  fromJSONCountryCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CountryCode of MapLocationForContactsJSON is not a string.");
        setCountryCode(json_string.getData());
      }


    private void  fromJSONPostalCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PostalCode of MapLocationForContactsJSON is not a string.");
        setPostalCode(json_string.getData());
      }


    private void  fromJSONIATA(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field IATA of MapLocationForContactsJSON is not a string.");
        setIATA(json_string.getData());
      }


    private void  fromJSONICAO(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ICAO of MapLocationForContactsJSON is not a string.");
        setICAO(json_string.getData());
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
                throw new Exception("The value for field Latitude of MapLocationForContactsJSON is not a number.");
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
                throw new Exception("The value for field Longitude of MapLocationForContactsJSON is not a number.");
              }
          }
        setLongitudeText(the_rational_text);
      }


    private void  fromJSONReferenceDatum(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ReferenceDatum of MapLocationForContactsJSON is not a string.");
        setReferenceDatum(json_string.getData());
      }


    public MapLocationForContactsJSON()
      {
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
        flagHasLatitude = false;
        flagHasLongitude = false;
        flagHasReferenceDatum = false;
        storeReferenceDatum = "WGS84";
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasReferenceDatum()
      {
        return flagHasReferenceDatum;
      }

    public string  getReferenceDatum()
      {
        return storeReferenceDatum;
      }


    public virtual int extraMapLocationForContactsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMapLocationForContactsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMapLocationForContactsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMapLocationForContactsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setLatitude(double new_value)
      {
        flagHasLatitude = true;
        if (new_value < -90)
            throw new Exception("The value for field Latitude of MapLocationForContactsJSON is less than the lower bound (-90) for that field.");
        if (new_value > 90)
            throw new Exception("The value for field Latitude of MapLocationForContactsJSON is greater than the upper bound (90) for that field.");
        storeLatitude = new_value;
        textStoreLatitude = "";
      }
    public void setLatitudeText(string new_value)
      {
        flagHasLatitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Latitude of MapLocationForContactsJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "90", "", false, "2") < 0)
            throw new Exception("The value for field Latitude of MapLocationForContactsJSON is less than the lower bound (-90) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "90", "", false, "2") > 0)
            throw new Exception("The value for field Latitude of MapLocationForContactsJSON is greater than the upper bound (90) for that field.");
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
            throw new Exception("The value for field Longitude of MapLocationForContactsJSON is less than the lower bound (-180) for that field.");
        if (new_value > 180)
            throw new Exception("The value for field Longitude of MapLocationForContactsJSON is greater than the upper bound (180) for that field.");
        storeLongitude = new_value;
        textStoreLongitude = "";
      }
    public void setLongitudeText(string new_value)
      {
        flagHasLongitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Longitude of MapLocationForContactsJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "180", "", false, "3") < 0)
            throw new Exception("The value for field Longitude of MapLocationForContactsJSON is less than the lower bound (-180) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "180", "", false, "3") > 0)
            throw new Exception("The value for field Longitude of MapLocationForContactsJSON is greater than the upper bound (180) for that field.");
        textStoreLongitude = new_value;
      }
    public void unsetLongitude()
      {
        flagHasLongitude = false;
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

    public virtual void extraMapLocationForContactsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMapLocationForContactsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMapLocationForContactsLookup(key);
        if (old_field == null)
          {
            extraMapLocationForContactsAppendPair(key, new_component);
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
        if (flagHasReferenceDatum)
          {
            handler.start_pair("ReferenceDatum");
            handler.string_value(storeReferenceDatum);
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

    public static MapLocationForContactsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MapLocationForContactsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapLocationForContacts", ignore_extras);
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
    public static MapLocationForContactsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MapLocationForContactsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MapLocationForContactsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapLocationForContacts", ignore_extras);
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
    public static MapLocationForContactsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MapLocationForContactsJSON from_text(string text, bool ignore_extras)
      {
        MapLocationForContactsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapLocationForContacts", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MapLocationForContactsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MapLocationForContactsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MapLocationForContactsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapLocationForContacts", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
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
        private JSONHoldingNumberTextGenerator fieldGeneratorLatitude;
        private JSONHoldingNumberTextGenerator fieldGeneratorLongitude;
        private JSONHoldingStringGenerator fieldGeneratorReferenceDatum;
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
            MapLocationForContactsJSON result = new MapLocationForContactsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMapLocationForContactsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MapLocationForContactsJSON result)
          {
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
            if (fieldGeneratorReferenceDatum.have_value)
              {
                result.setReferenceDatum(fieldGeneratorReferenceDatum.value);
                fieldGeneratorReferenceDatum.have_value = false;
              }
          }
        protected abstract void handle_result(MapLocationForContactsJSON new_result);
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
                case 'C':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "ty", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorCity;
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "untry", 0, 5, false) == 0)
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
                    if ((String.Compare(field_name, 1, "ostalCode", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorPostalCode;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "eferenceDatum", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorReferenceDatum;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "treet", 0, 5, false) == 0)
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
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAddress = new JSONHoldingStringGenerator("field \"Address\" of the MapLocationForContacts class");
            fieldGeneratorStreetNumber = new JSONHoldingStringGenerator("field \"StreetNumber\" of the MapLocationForContacts class");
            fieldGeneratorStreetSecondaryNumber = new JSONHoldingStringGenerator("field \"StreetSecondaryNumber\" of the MapLocationForContacts class");
            fieldGeneratorStreetName = new JSONHoldingStringGenerator("field \"StreetName\" of the MapLocationForContacts class");
            fieldGeneratorCity = new JSONHoldingStringGenerator("field \"City\" of the MapLocationForContacts class");
            fieldGeneratorAdmin2 = new JSONHoldingStringGenerator("field \"Admin2\" of the MapLocationForContacts class");
            fieldGeneratorAdmin1 = new JSONHoldingStringGenerator("field \"Admin1\" of the MapLocationForContacts class");
            fieldGeneratorCountry = new JSONHoldingStringGenerator("field \"Country\" of the MapLocationForContacts class");
            fieldGeneratorCountryCode = new JSONHoldingStringGenerator("field \"CountryCode\" of the MapLocationForContacts class");
            fieldGeneratorPostalCode = new JSONHoldingStringGenerator("field \"PostalCode\" of the MapLocationForContacts class");
            fieldGeneratorIATA = new JSONHoldingStringGenerator("field \"IATA\" of the MapLocationForContacts class");
            fieldGeneratorICAO = new JSONHoldingStringGenerator("field \"ICAO\" of the MapLocationForContacts class");
            fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the MapLocationForContacts class");
            fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the MapLocationForContacts class");
            fieldGeneratorReferenceDatum = new JSONHoldingStringGenerator("field \"ReferenceDatum\" of the MapLocationForContacts class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MapLocationForContacts class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAddress = new JSONHoldingStringGenerator("field \"Address\" of the MapLocationForContacts class");
            fieldGeneratorStreetNumber = new JSONHoldingStringGenerator("field \"StreetNumber\" of the MapLocationForContacts class");
            fieldGeneratorStreetSecondaryNumber = new JSONHoldingStringGenerator("field \"StreetSecondaryNumber\" of the MapLocationForContacts class");
            fieldGeneratorStreetName = new JSONHoldingStringGenerator("field \"StreetName\" of the MapLocationForContacts class");
            fieldGeneratorCity = new JSONHoldingStringGenerator("field \"City\" of the MapLocationForContacts class");
            fieldGeneratorAdmin2 = new JSONHoldingStringGenerator("field \"Admin2\" of the MapLocationForContacts class");
            fieldGeneratorAdmin1 = new JSONHoldingStringGenerator("field \"Admin1\" of the MapLocationForContacts class");
            fieldGeneratorCountry = new JSONHoldingStringGenerator("field \"Country\" of the MapLocationForContacts class");
            fieldGeneratorCountryCode = new JSONHoldingStringGenerator("field \"CountryCode\" of the MapLocationForContacts class");
            fieldGeneratorPostalCode = new JSONHoldingStringGenerator("field \"PostalCode\" of the MapLocationForContacts class");
            fieldGeneratorIATA = new JSONHoldingStringGenerator("field \"IATA\" of the MapLocationForContacts class");
            fieldGeneratorICAO = new JSONHoldingStringGenerator("field \"ICAO\" of the MapLocationForContacts class");
            fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the MapLocationForContacts class");
            fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the MapLocationForContacts class");
            fieldGeneratorReferenceDatum = new JSONHoldingStringGenerator("field \"ReferenceDatum\" of the MapLocationForContacts class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MapLocationForContacts class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
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
            fieldGeneratorLatitude.reset();
            fieldGeneratorLongitude.reset();
            fieldGeneratorReferenceDatum.reset();
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
        protected override void handle_result(MapLocationForContactsJSON  result)
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
        public MapLocationForContactsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MapLocationForContactsJSON  result)
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
    protected virtual void handle_result(List<MapLocationForContactsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MapLocationForContactsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MapLocationForContactsJSON>();
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
    public List<MapLocationForContactsJSON> value;
  };
  };
