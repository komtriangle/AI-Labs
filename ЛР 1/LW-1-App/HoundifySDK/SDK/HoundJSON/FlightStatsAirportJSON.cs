/* file "FlightStatsAirportJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightStatsAirportJSON : JSONBase
  {
    private bool flagHasiata;
    private string storeiata;
    private bool flagHasicao;
    private string storeicao;
    private bool flagHasname;
    private string storename;
    private bool flagHasstreet1;
    private string storestreet1;
    private bool flagHasstreet2;
    private string storestreet2;
    private bool flagHascity;
    private string storecity;
    private bool flagHasstateCode;
    private string storestateCode;
    private bool flagHaspostalCode;
    private string storepostalCode;
    private bool flagHascountryCode;
    private string storecountryCode;
    private bool flagHascountryName;
    private string storecountryName;
    private bool flagHasregionName;
    private string storeregionName;
    private bool flagHastimeZoneRegionName;
    private string storetimeZoneRegionName;
    private bool flagHaslocalTime;
    private string storelocalTime;
    private bool flagHasutcOffsetHours;
    private double storeutcOffsetHours;
    private string textStoreutcOffsetHours;
    private bool flagHaslatitude;
    private double storelatitude;
    private string textStorelatitude;
    private bool flagHaslongitude;
    private double storelongitude;
    private string textStorelongitude;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONiata(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field iata of FlightStatsAirportJSON is not a string.");
        setiata(json_string.getData());
      }


    private void  fromJSONicao(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field icao of FlightStatsAirportJSON is not a string.");
        seticao(json_string.getData());
      }


    private void  fromJSONname(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field name of FlightStatsAirportJSON is not a string.");
        setname(json_string.getData());
      }


    private void  fromJSONstreet1(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field street1 of FlightStatsAirportJSON is not a string.");
        setstreet1(json_string.getData());
      }


    private void  fromJSONstreet2(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field street2 of FlightStatsAirportJSON is not a string.");
        setstreet2(json_string.getData());
      }


    private void  fromJSONcity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field city of FlightStatsAirportJSON is not a string.");
        setcity(json_string.getData());
      }


    private void  fromJSONstateCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field stateCode of FlightStatsAirportJSON is not a string.");
        setstateCode(json_string.getData());
      }


    private void  fromJSONpostalCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field postalCode of FlightStatsAirportJSON is not a string.");
        setpostalCode(json_string.getData());
      }


    private void  fromJSONcountryCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field countryCode of FlightStatsAirportJSON is not a string.");
        setcountryCode(json_string.getData());
      }


    private void  fromJSONcountryName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field countryName of FlightStatsAirportJSON is not a string.");
        setcountryName(json_string.getData());
      }


    private void  fromJSONregionName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field regionName of FlightStatsAirportJSON is not a string.");
        setregionName(json_string.getData());
      }


    private void  fromJSONtimeZoneRegionName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field timeZoneRegionName of FlightStatsAirportJSON is not a string.");
        settimeZoneRegionName(json_string.getData());
      }


    private void  fromJSONlocalTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field localTime of FlightStatsAirportJSON is not a string.");
        setlocalTime(json_string.getData());
      }


    private void  fromJSONutcOffsetHours(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field utcOffsetHours of FlightStatsAirportJSON is not a number.");
              }
          }
        setutcOffsetHoursText(the_rational_text);
      }


    private void  fromJSONlatitude(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field latitude of FlightStatsAirportJSON is not a number.");
              }
          }
        setlatitudeText(the_rational_text);
      }


    private void  fromJSONlongitude(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field longitude of FlightStatsAirportJSON is not a number.");
              }
          }
        setlongitudeText(the_rational_text);
      }


    public FlightStatsAirportJSON()
      {
        flagHasiata = false;
        flagHasicao = false;
        flagHasname = false;
        flagHasstreet1 = false;
        flagHasstreet2 = false;
        flagHascity = false;
        flagHasstateCode = false;
        flagHaspostalCode = false;
        flagHascountryCode = false;
        flagHascountryName = false;
        flagHasregionName = false;
        flagHastimeZoneRegionName = false;
        flagHaslocalTime = false;
        flagHasutcOffsetHours = false;
        flagHaslatitude = false;
        flagHaslongitude = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasiata()
      {
        return flagHasiata;
      }

    public string  getiata()
      {
        Debug.Assert(flagHasiata);
        return storeiata;
      }

    public bool  hasicao()
      {
        return flagHasicao;
      }

    public string  geticao()
      {
        Debug.Assert(flagHasicao);
        return storeicao;
      }

    public bool  hasname()
      {
        return flagHasname;
      }

    public string  getname()
      {
        Debug.Assert(flagHasname);
        return storename;
      }

    public bool  hasstreet1()
      {
        return flagHasstreet1;
      }

    public string  getstreet1()
      {
        Debug.Assert(flagHasstreet1);
        return storestreet1;
      }

    public bool  hasstreet2()
      {
        return flagHasstreet2;
      }

    public string  getstreet2()
      {
        Debug.Assert(flagHasstreet2);
        return storestreet2;
      }

    public bool  hascity()
      {
        return flagHascity;
      }

    public string  getcity()
      {
        Debug.Assert(flagHascity);
        return storecity;
      }

    public bool  hasstateCode()
      {
        return flagHasstateCode;
      }

    public string  getstateCode()
      {
        Debug.Assert(flagHasstateCode);
        return storestateCode;
      }

    public bool  haspostalCode()
      {
        return flagHaspostalCode;
      }

    public string  getpostalCode()
      {
        Debug.Assert(flagHaspostalCode);
        return storepostalCode;
      }

    public bool  hascountryCode()
      {
        return flagHascountryCode;
      }

    public string  getcountryCode()
      {
        Debug.Assert(flagHascountryCode);
        return storecountryCode;
      }

    public bool  hascountryName()
      {
        return flagHascountryName;
      }

    public string  getcountryName()
      {
        Debug.Assert(flagHascountryName);
        return storecountryName;
      }

    public bool  hasregionName()
      {
        return flagHasregionName;
      }

    public string  getregionName()
      {
        Debug.Assert(flagHasregionName);
        return storeregionName;
      }

    public bool  hastimeZoneRegionName()
      {
        return flagHastimeZoneRegionName;
      }

    public string  gettimeZoneRegionName()
      {
        Debug.Assert(flagHastimeZoneRegionName);
        return storetimeZoneRegionName;
      }

    public bool  haslocalTime()
      {
        return flagHaslocalTime;
      }

    public string  getlocalTime()
      {
        Debug.Assert(flagHaslocalTime);
        return storelocalTime;
      }

    public bool  hasutcOffsetHours()
      {
        return flagHasutcOffsetHours;
      }

    public double  getutcOffsetHours()
      {
        Debug.Assert(flagHasutcOffsetHours);
        if (textStoreutcOffsetHours != "")
          {
            return Double.Parse(textStoreutcOffsetHours);
          }
        return storeutcOffsetHours;
      }

    public string  getutcOffsetHoursAsText()
      {
        Debug.Assert(flagHasutcOffsetHours);
        if (textStoreutcOffsetHours == "")
          {
            return Convert.ToString(storeutcOffsetHours);
          }
        else
          {
            return (textStoreutcOffsetHours);
          }
      }

    public bool  haslatitude()
      {
        return flagHaslatitude;
      }

    public double  getlatitude()
      {
        Debug.Assert(flagHaslatitude);
        if (textStorelatitude != "")
          {
            return Double.Parse(textStorelatitude);
          }
        return storelatitude;
      }

    public string  getlatitudeAsText()
      {
        Debug.Assert(flagHaslatitude);
        if (textStorelatitude == "")
          {
            return Convert.ToString(storelatitude);
          }
        else
          {
            return (textStorelatitude);
          }
      }

    public bool  haslongitude()
      {
        return flagHaslongitude;
      }

    public double  getlongitude()
      {
        Debug.Assert(flagHaslongitude);
        if (textStorelongitude != "")
          {
            return Double.Parse(textStorelongitude);
          }
        return storelongitude;
      }

    public string  getlongitudeAsText()
      {
        Debug.Assert(flagHaslongitude);
        if (textStorelongitude == "")
          {
            return Convert.ToString(storelongitude);
          }
        else
          {
            return (textStorelongitude);
          }
      }


    public virtual int extraFlightStatsAirportComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatsAirportComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatsAirportComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatsAirportLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setiata(string new_value)
      {
        flagHasiata = true;
        storeiata = new_value;
      }
    public void unsetiata()
      {
        flagHasiata = false;
      }
    public void seticao(string new_value)
      {
        flagHasicao = true;
        storeicao = new_value;
      }
    public void unseticao()
      {
        flagHasicao = false;
      }
    public void setname(string new_value)
      {
        flagHasname = true;
        storename = new_value;
      }
    public void unsetname()
      {
        flagHasname = false;
      }
    public void setstreet1(string new_value)
      {
        flagHasstreet1 = true;
        storestreet1 = new_value;
      }
    public void unsetstreet1()
      {
        flagHasstreet1 = false;
      }
    public void setstreet2(string new_value)
      {
        flagHasstreet2 = true;
        storestreet2 = new_value;
      }
    public void unsetstreet2()
      {
        flagHasstreet2 = false;
      }
    public void setcity(string new_value)
      {
        flagHascity = true;
        storecity = new_value;
      }
    public void unsetcity()
      {
        flagHascity = false;
      }
    public void setstateCode(string new_value)
      {
        flagHasstateCode = true;
        storestateCode = new_value;
      }
    public void unsetstateCode()
      {
        flagHasstateCode = false;
      }
    public void setpostalCode(string new_value)
      {
        flagHaspostalCode = true;
        storepostalCode = new_value;
      }
    public void unsetpostalCode()
      {
        flagHaspostalCode = false;
      }
    public void setcountryCode(string new_value)
      {
        flagHascountryCode = true;
        storecountryCode = new_value;
      }
    public void unsetcountryCode()
      {
        flagHascountryCode = false;
      }
    public void setcountryName(string new_value)
      {
        flagHascountryName = true;
        storecountryName = new_value;
      }
    public void unsetcountryName()
      {
        flagHascountryName = false;
      }
    public void setregionName(string new_value)
      {
        flagHasregionName = true;
        storeregionName = new_value;
      }
    public void unsetregionName()
      {
        flagHasregionName = false;
      }
    public void settimeZoneRegionName(string new_value)
      {
        flagHastimeZoneRegionName = true;
        storetimeZoneRegionName = new_value;
      }
    public void unsettimeZoneRegionName()
      {
        flagHastimeZoneRegionName = false;
      }
    public void setlocalTime(string new_value)
      {
        flagHaslocalTime = true;
        storelocalTime = new_value;
      }
    public void unsetlocalTime()
      {
        flagHaslocalTime = false;
      }
    public void setutcOffsetHours(double new_value)
      {
        flagHasutcOffsetHours = true;
        storeutcOffsetHours = new_value;
        textStoreutcOffsetHours = "";
      }
    public void setutcOffsetHoursText(string new_value)
      {
        flagHasutcOffsetHours = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field utcOffsetHours of FlightStatsAirportJSON is not a valid number.");
        textStoreutcOffsetHours = new_value;
      }
    public void unsetutcOffsetHours()
      {
        flagHasutcOffsetHours = false;
      }
    public void setlatitude(double new_value)
      {
        flagHaslatitude = true;
        storelatitude = new_value;
        textStorelatitude = "";
      }
    public void setlatitudeText(string new_value)
      {
        flagHaslatitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field latitude of FlightStatsAirportJSON is not a valid number.");
        textStorelatitude = new_value;
      }
    public void unsetlatitude()
      {
        flagHaslatitude = false;
      }
    public void setlongitude(double new_value)
      {
        flagHaslongitude = true;
        storelongitude = new_value;
        textStorelongitude = "";
      }
    public void setlongitudeText(string new_value)
      {
        flagHaslongitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field longitude of FlightStatsAirportJSON is not a valid number.");
        textStorelongitude = new_value;
      }
    public void unsetlongitude()
      {
        flagHaslongitude = false;
      }

    public virtual void extraFlightStatsAirportAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatsAirportSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatsAirportLookup(key);
        if (old_field == null)
          {
            extraFlightStatsAirportAppendPair(key, new_component);
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
        if (flagHasiata)
          {
            handler.start_pair("iata");
            handler.string_value(storeiata);
          }
        if (flagHasicao)
          {
            handler.start_pair("icao");
            handler.string_value(storeicao);
          }
        if (flagHasname)
          {
            handler.start_pair("name");
            handler.string_value(storename);
          }
        if (flagHasstreet1)
          {
            handler.start_pair("street1");
            handler.string_value(storestreet1);
          }
        if (flagHasstreet2)
          {
            handler.start_pair("street2");
            handler.string_value(storestreet2);
          }
        Debug.Assert(partial_allowed || flagHascity);
        if (flagHascity)
          {
            handler.start_pair("city");
            handler.string_value(storecity);
          }
        if (flagHasstateCode)
          {
            handler.start_pair("stateCode");
            handler.string_value(storestateCode);
          }
        if (flagHaspostalCode)
          {
            handler.start_pair("postalCode");
            handler.string_value(storepostalCode);
          }
        Debug.Assert(partial_allowed || flagHascountryCode);
        if (flagHascountryCode)
          {
            handler.start_pair("countryCode");
            handler.string_value(storecountryCode);
          }
        Debug.Assert(partial_allowed || flagHascountryName);
        if (flagHascountryName)
          {
            handler.start_pair("countryName");
            handler.string_value(storecountryName);
          }
        Debug.Assert(partial_allowed || flagHasregionName);
        if (flagHasregionName)
          {
            handler.start_pair("regionName");
            handler.string_value(storeregionName);
          }
        Debug.Assert(partial_allowed || flagHastimeZoneRegionName);
        if (flagHastimeZoneRegionName)
          {
            handler.start_pair("timeZoneRegionName");
            handler.string_value(storetimeZoneRegionName);
          }
        Debug.Assert(partial_allowed || flagHaslocalTime);
        if (flagHaslocalTime)
          {
            handler.start_pair("localTime");
            handler.string_value(storelocalTime);
          }
        Debug.Assert(partial_allowed || flagHasutcOffsetHours);
        if (flagHasutcOffsetHours)
          {
            handler.start_pair("utcOffsetHours");
            if (textStoreutcOffsetHours != "")
                handler.number_value(textStoreutcOffsetHours);
            else if (((double)(long)storeutcOffsetHours) == storeutcOffsetHours)
                handler.number_value((long)storeutcOffsetHours);
            else
                handler.number_value(storeutcOffsetHours);
          }
        Debug.Assert(partial_allowed || flagHaslatitude);
        if (flagHaslatitude)
          {
            handler.start_pair("latitude");
            if (textStorelatitude != "")
                handler.number_value(textStorelatitude);
            else if (((double)(long)storelatitude) == storelatitude)
                handler.number_value((long)storelatitude);
            else
                handler.number_value(storelatitude);
          }
        Debug.Assert(partial_allowed || flagHaslongitude);
        if (flagHaslongitude)
          {
            handler.start_pair("longitude");
            if (textStorelongitude != "")
                handler.number_value(textStorelongitude);
            else if (((double)(long)storelongitude) == storelongitude)
                handler.number_value((long)storelongitude);
            else
                handler.number_value(storelongitude);
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
        if (!(hascity()))
          {
            return "When parsing the object for %what%, the \"city\" field was missing.";
          }
        if (!(hascountryCode()))
          {
            return "When parsing the object for %what%, the \"countryCode\" field was missing.";
          }
        if (!(hascountryName()))
          {
            return "When parsing the object for %what%, the \"countryName\" field was missing.";
          }
        if (!(hasregionName()))
          {
            return "When parsing the object for %what%, the \"regionName\" field was missing.";
          }
        if (!(hastimeZoneRegionName()))
          {
            return "When parsing the object for %what%, the \"timeZoneRegionName\" field was missing.";
          }
        if (!(haslocalTime()))
          {
            return "When parsing the object for %what%, the \"localTime\" field was missing.";
          }
        if (!(hasutcOffsetHours()))
          {
            return "When parsing the object for %what%, the \"utcOffsetHours\" field was missing.";
          }
        if (!(haslatitude()))
          {
            return "When parsing the object for %what%, the \"latitude\" field was missing.";
          }
        if (!(haslongitude()))
          {
            return "When parsing the object for %what%, the \"longitude\" field was missing.";
          }
        return null;
      }

    public static FlightStatsAirportJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsAirportJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsAirport", ignore_extras);
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
    public static FlightStatsAirportJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatsAirportJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsAirportJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsAirport", ignore_extras);
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
    public static FlightStatsAirportJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatsAirportJSON from_text(string text, bool ignore_extras)
      {
        FlightStatsAirportJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsAirport", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatsAirportJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightStatsAirportJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatsAirportJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsAirport", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratoriata;
        private JSONHoldingStringGenerator fieldGeneratoricao;
        private JSONHoldingStringGenerator fieldGeneratorname;
        private JSONHoldingStringGenerator fieldGeneratorstreet1;
        private JSONHoldingStringGenerator fieldGeneratorstreet2;
        private JSONHoldingStringGenerator fieldGeneratorcity;
        private JSONHoldingStringGenerator fieldGeneratorstateCode;
        private JSONHoldingStringGenerator fieldGeneratorpostalCode;
        private JSONHoldingStringGenerator fieldGeneratorcountryCode;
        private JSONHoldingStringGenerator fieldGeneratorcountryName;
        private JSONHoldingStringGenerator fieldGeneratorregionName;
        private JSONHoldingStringGenerator fieldGeneratortimeZoneRegionName;
        private JSONHoldingStringGenerator fieldGeneratorlocalTime;
        private JSONHoldingNumberTextGenerator fieldGeneratorutcOffsetHours;
        private JSONHoldingNumberTextGenerator fieldGeneratorlatitude;
        private JSONHoldingNumberTextGenerator fieldGeneratorlongitude;
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
            FlightStatsAirportJSON result = new FlightStatsAirportJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatsAirportAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightStatsAirportJSON result)
          {
            if (fieldGeneratoriata.have_value)
              {
                result.setiata(fieldGeneratoriata.value);
                fieldGeneratoriata.have_value = false;
              }
            if (fieldGeneratoricao.have_value)
              {
                result.seticao(fieldGeneratoricao.value);
                fieldGeneratoricao.have_value = false;
              }
            if (fieldGeneratorname.have_value)
              {
                result.setname(fieldGeneratorname.value);
                fieldGeneratorname.have_value = false;
              }
            if (fieldGeneratorstreet1.have_value)
              {
                result.setstreet1(fieldGeneratorstreet1.value);
                fieldGeneratorstreet1.have_value = false;
              }
            if (fieldGeneratorstreet2.have_value)
              {
                result.setstreet2(fieldGeneratorstreet2.value);
                fieldGeneratorstreet2.have_value = false;
              }
            if (fieldGeneratorcity.have_value)
              {
                result.setcity(fieldGeneratorcity.value);
                fieldGeneratorcity.have_value = false;
              }
            else if ((!(result.hascity())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"city\" field was missing.");
              }
            if (fieldGeneratorstateCode.have_value)
              {
                result.setstateCode(fieldGeneratorstateCode.value);
                fieldGeneratorstateCode.have_value = false;
              }
            if (fieldGeneratorpostalCode.have_value)
              {
                result.setpostalCode(fieldGeneratorpostalCode.value);
                fieldGeneratorpostalCode.have_value = false;
              }
            if (fieldGeneratorcountryCode.have_value)
              {
                result.setcountryCode(fieldGeneratorcountryCode.value);
                fieldGeneratorcountryCode.have_value = false;
              }
            else if ((!(result.hascountryCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"countryCode\" field was missing.");
              }
            if (fieldGeneratorcountryName.have_value)
              {
                result.setcountryName(fieldGeneratorcountryName.value);
                fieldGeneratorcountryName.have_value = false;
              }
            else if ((!(result.hascountryName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"countryName\" field was missing.");
              }
            if (fieldGeneratorregionName.have_value)
              {
                result.setregionName(fieldGeneratorregionName.value);
                fieldGeneratorregionName.have_value = false;
              }
            else if ((!(result.hasregionName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"regionName\" field was missing.");
              }
            if (fieldGeneratortimeZoneRegionName.have_value)
              {
                result.settimeZoneRegionName(fieldGeneratortimeZoneRegionName.value);
                fieldGeneratortimeZoneRegionName.have_value = false;
              }
            else if ((!(result.hastimeZoneRegionName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"timeZoneRegionName\" field was missing.");
              }
            if (fieldGeneratorlocalTime.have_value)
              {
                result.setlocalTime(fieldGeneratorlocalTime.value);
                fieldGeneratorlocalTime.have_value = false;
              }
            else if ((!(result.haslocalTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"localTime\" field was missing.");
              }
            if (fieldGeneratorutcOffsetHours.have_value)
              {
                result.setutcOffsetHoursText(fieldGeneratorutcOffsetHours.value);
                fieldGeneratorutcOffsetHours.have_value = false;
              }
            else if ((!(result.hasutcOffsetHours())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"utcOffsetHours\" field was missing.");
              }
            if (fieldGeneratorlatitude.have_value)
              {
                result.setlatitudeText(fieldGeneratorlatitude.value);
                fieldGeneratorlatitude.have_value = false;
              }
            else if ((!(result.haslatitude())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"latitude\" field was missing.");
              }
            if (fieldGeneratorlongitude.have_value)
              {
                result.setlongitudeText(fieldGeneratorlongitude.value);
                fieldGeneratorlongitude.have_value = false;
              }
            else if ((!(result.haslongitude())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"longitude\" field was missing.");
              }
          }
        protected abstract void handle_result(FlightStatsAirportJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'c':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "ty", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorcity;
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "untry", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 8, "ode", 0, 3, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorcountryCode;
                                        break;
                                    case 'N':
                                        if ((String.Compare(field_name, 8, "ame", 0, 3, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorcountryName;
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
                case 'i':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ta", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratoriata;
                            break;
                        case 'c':
                            if ((String.Compare(field_name, 2, "ao", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratoricao;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'l':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "titude", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorlatitude;
                            break;
                        case 'o':
                            switch (field_name[2])
                              {
                                case 'c':
                                    if ((String.Compare(field_name, 3, "alTime", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorlocalTime;
                                    break;
                                case 'n':
                                    if ((String.Compare(field_name, 3, "gitude", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorlongitude;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'n':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorname;
                    break;
                case 'p':
                    if ((String.Compare(field_name, 1, "ostalCode", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorpostalCode;
                    break;
                case 'r':
                    if ((String.Compare(field_name, 1, "egionName", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorregionName;
                    break;
                case 's':
                    if (String.Compare(field_name, 1, "t", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 3, "teCode", 0, 6, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorstateCode;
                                break;
                            case 'r':
                                if (String.Compare(field_name, 3, "eet", 0, 3, false) == 0)
                                  {
                                    switch (field_name[6])
                                      {
                                        case '1':
                                            if (field_name.Length == 7)
                                                return fieldGeneratorstreet1;
                                            break;
                                        case '2':
                                            if (field_name.Length == 7)
                                                return fieldGeneratorstreet2;
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
                case 't':
                    if ((String.Compare(field_name, 1, "imeZoneRegionName", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratortimeZoneRegionName;
                    break;
                case 'u':
                    if ((String.Compare(field_name, 1, "tcOffsetHours", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorutcOffsetHours;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratoriata = new JSONHoldingStringGenerator("field \"iata\" of the FlightStatsAirport class");
            fieldGeneratoricao = new JSONHoldingStringGenerator("field \"icao\" of the FlightStatsAirport class");
            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the FlightStatsAirport class");
            fieldGeneratorstreet1 = new JSONHoldingStringGenerator("field \"street1\" of the FlightStatsAirport class");
            fieldGeneratorstreet2 = new JSONHoldingStringGenerator("field \"street2\" of the FlightStatsAirport class");
            fieldGeneratorcity = new JSONHoldingStringGenerator("field \"city\" of the FlightStatsAirport class");
            fieldGeneratorstateCode = new JSONHoldingStringGenerator("field \"stateCode\" of the FlightStatsAirport class");
            fieldGeneratorpostalCode = new JSONHoldingStringGenerator("field \"postalCode\" of the FlightStatsAirport class");
            fieldGeneratorcountryCode = new JSONHoldingStringGenerator("field \"countryCode\" of the FlightStatsAirport class");
            fieldGeneratorcountryName = new JSONHoldingStringGenerator("field \"countryName\" of the FlightStatsAirport class");
            fieldGeneratorregionName = new JSONHoldingStringGenerator("field \"regionName\" of the FlightStatsAirport class");
            fieldGeneratortimeZoneRegionName = new JSONHoldingStringGenerator("field \"timeZoneRegionName\" of the FlightStatsAirport class");
            fieldGeneratorlocalTime = new JSONHoldingStringGenerator("field \"localTime\" of the FlightStatsAirport class");
            fieldGeneratorutcOffsetHours = new JSONHoldingNumberTextGenerator("field \"utcOffsetHours\" of the FlightStatsAirport class");
            fieldGeneratorlatitude = new JSONHoldingNumberTextGenerator("field \"latitude\" of the FlightStatsAirport class");
            fieldGeneratorlongitude = new JSONHoldingNumberTextGenerator("field \"longitude\" of the FlightStatsAirport class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatsAirport class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratoriata = new JSONHoldingStringGenerator("field \"iata\" of the FlightStatsAirport class");
            fieldGeneratoricao = new JSONHoldingStringGenerator("field \"icao\" of the FlightStatsAirport class");
            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the FlightStatsAirport class");
            fieldGeneratorstreet1 = new JSONHoldingStringGenerator("field \"street1\" of the FlightStatsAirport class");
            fieldGeneratorstreet2 = new JSONHoldingStringGenerator("field \"street2\" of the FlightStatsAirport class");
            fieldGeneratorcity = new JSONHoldingStringGenerator("field \"city\" of the FlightStatsAirport class");
            fieldGeneratorstateCode = new JSONHoldingStringGenerator("field \"stateCode\" of the FlightStatsAirport class");
            fieldGeneratorpostalCode = new JSONHoldingStringGenerator("field \"postalCode\" of the FlightStatsAirport class");
            fieldGeneratorcountryCode = new JSONHoldingStringGenerator("field \"countryCode\" of the FlightStatsAirport class");
            fieldGeneratorcountryName = new JSONHoldingStringGenerator("field \"countryName\" of the FlightStatsAirport class");
            fieldGeneratorregionName = new JSONHoldingStringGenerator("field \"regionName\" of the FlightStatsAirport class");
            fieldGeneratortimeZoneRegionName = new JSONHoldingStringGenerator("field \"timeZoneRegionName\" of the FlightStatsAirport class");
            fieldGeneratorlocalTime = new JSONHoldingStringGenerator("field \"localTime\" of the FlightStatsAirport class");
            fieldGeneratorutcOffsetHours = new JSONHoldingNumberTextGenerator("field \"utcOffsetHours\" of the FlightStatsAirport class");
            fieldGeneratorlatitude = new JSONHoldingNumberTextGenerator("field \"latitude\" of the FlightStatsAirport class");
            fieldGeneratorlongitude = new JSONHoldingNumberTextGenerator("field \"longitude\" of the FlightStatsAirport class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatsAirport class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratoriata.reset();
            fieldGeneratoricao.reset();
            fieldGeneratorname.reset();
            fieldGeneratorstreet1.reset();
            fieldGeneratorstreet2.reset();
            fieldGeneratorcity.reset();
            fieldGeneratorstateCode.reset();
            fieldGeneratorpostalCode.reset();
            fieldGeneratorcountryCode.reset();
            fieldGeneratorcountryName.reset();
            fieldGeneratorregionName.reset();
            fieldGeneratortimeZoneRegionName.reset();
            fieldGeneratorlocalTime.reset();
            fieldGeneratorutcOffsetHours.reset();
            fieldGeneratorlatitude.reset();
            fieldGeneratorlongitude.reset();
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
        protected override void handle_result(FlightStatsAirportJSON  result)
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
        public FlightStatsAirportJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatsAirportJSON  result)
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
    protected virtual void handle_result(List<FlightStatsAirportJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatsAirportJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatsAirportJSON>();
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
    public List<FlightStatsAirportJSON> value;
  };
  };
