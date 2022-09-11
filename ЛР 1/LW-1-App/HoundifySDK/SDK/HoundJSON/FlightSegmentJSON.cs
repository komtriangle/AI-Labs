/* file "FlightSegmentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightSegmentJSON : JSONBase
  {
    private bool flagHasFlightSegmentID;
    private string storeFlightSegmentID;
    private bool flagHasDepartureAirport;
    private FlightTravelLocationJSON  storeDepartureAirport;
    private bool flagHasArrivalAirport;
    private FlightTravelLocationJSON  storeArrivalAirport;
    private bool flagHasDepartureDateTime;
    private FlightTimesJSON  storeDepartureDateTime;
    private bool flagHasArrivalDateTime;
    private FlightTimesJSON  storeArrivalDateTime;
    private bool flagHasAirlineFlightNumber;
    private AirlineFlightNumberJSON  storeAirlineFlightNumber;
    private bool flagHasOperatingCarrier;
    private AirlineJSON  storeOperatingCarrier;
    private bool flagHasFlightDuration;
    private double storeFlightDuration;
    private string textStoreFlightDuration;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFlightSegmentID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FlightSegmentID of FlightSegmentJSON is not a string.");
        setFlightSegmentID(json_string.getData());
      }


    private void  fromJSONDepartureAirport(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTravelLocationJSON convert_classy = FlightTravelLocationJSON.from_json(json_value, ignore_extras, true);
        setDepartureAirport(convert_classy);
      }


    private void  fromJSONArrivalAirport(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTravelLocationJSON convert_classy = FlightTravelLocationJSON.from_json(json_value, ignore_extras, true);
        setArrivalAirport(convert_classy);
      }


    private void  fromJSONDepartureDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setDepartureDateTime(convert_classy);
      }


    private void  fromJSONArrivalDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setArrivalDateTime(convert_classy);
      }


    private void  fromJSONAirlineFlightNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AirlineFlightNumberJSON convert_classy = AirlineFlightNumberJSON.from_json(json_value, ignore_extras, true);
        setAirlineFlightNumber(convert_classy);
      }


    private void  fromJSONOperatingCarrier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AirlineJSON convert_classy = AirlineJSON.from_json(json_value, ignore_extras, true);
        setOperatingCarrier(convert_classy);
      }


    private void  fromJSONFlightDuration(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field FlightDuration of FlightSegmentJSON is not a number.");
              }
          }
        setFlightDurationText(the_rational_text);
      }


    public FlightSegmentJSON()
      {
        flagHasFlightSegmentID = false;
        flagHasDepartureAirport = false;
        flagHasArrivalAirport = false;
        flagHasDepartureDateTime = false;
        flagHasArrivalDateTime = false;
        flagHasAirlineFlightNumber = false;
        flagHasOperatingCarrier = false;
        flagHasFlightDuration = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFlightSegmentID()
      {
        return flagHasFlightSegmentID;
      }

    public string  getFlightSegmentID()
      {
        Debug.Assert(flagHasFlightSegmentID);
        return storeFlightSegmentID;
      }

    public bool  hasDepartureAirport()
      {
        return flagHasDepartureAirport;
      }

    public FlightTravelLocationJSON   getDepartureAirport()
      {
        Debug.Assert(flagHasDepartureAirport);
        return storeDepartureAirport;
      }

    public bool  hasArrivalAirport()
      {
        return flagHasArrivalAirport;
      }

    public FlightTravelLocationJSON   getArrivalAirport()
      {
        Debug.Assert(flagHasArrivalAirport);
        return storeArrivalAirport;
      }

    public bool  hasDepartureDateTime()
      {
        return flagHasDepartureDateTime;
      }

    public FlightTimesJSON   getDepartureDateTime()
      {
        Debug.Assert(flagHasDepartureDateTime);
        return storeDepartureDateTime;
      }

    public bool  hasArrivalDateTime()
      {
        return flagHasArrivalDateTime;
      }

    public FlightTimesJSON   getArrivalDateTime()
      {
        Debug.Assert(flagHasArrivalDateTime);
        return storeArrivalDateTime;
      }

    public bool  hasAirlineFlightNumber()
      {
        return flagHasAirlineFlightNumber;
      }

    public AirlineFlightNumberJSON   getAirlineFlightNumber()
      {
        Debug.Assert(flagHasAirlineFlightNumber);
        return storeAirlineFlightNumber;
      }

    public bool  hasOperatingCarrier()
      {
        return flagHasOperatingCarrier;
      }

    public AirlineJSON   getOperatingCarrier()
      {
        Debug.Assert(flagHasOperatingCarrier);
        return storeOperatingCarrier;
      }

    public bool  hasFlightDuration()
      {
        return flagHasFlightDuration;
      }

    public double  getFlightDuration()
      {
        Debug.Assert(flagHasFlightDuration);
        if (textStoreFlightDuration != "")
          {
            return Double.Parse(textStoreFlightDuration);
          }
        return storeFlightDuration;
      }

    public string  getFlightDurationAsText()
      {
        Debug.Assert(flagHasFlightDuration);
        if (textStoreFlightDuration == "")
          {
            return Convert.ToString(storeFlightDuration);
          }
        else
          {
            return (textStoreFlightDuration);
          }
      }


    public virtual int extraFlightSegmentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightSegmentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightSegmentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightSegmentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFlightSegmentID(string new_value)
      {
        flagHasFlightSegmentID = true;
        storeFlightSegmentID = new_value;
      }
    public void unsetFlightSegmentID()
      {
        flagHasFlightSegmentID = false;
      }
    public void setDepartureAirport(FlightTravelLocationJSON  new_value)
      {
        if (flagHasDepartureAirport)
          {
          }
        flagHasDepartureAirport = true;
        storeDepartureAirport = new_value;
      }
    public void unsetDepartureAirport()
      {
        if (flagHasDepartureAirport)
          {
          }
        flagHasDepartureAirport = false;
      }
    public void setArrivalAirport(FlightTravelLocationJSON  new_value)
      {
        if (flagHasArrivalAirport)
          {
          }
        flagHasArrivalAirport = true;
        storeArrivalAirport = new_value;
      }
    public void unsetArrivalAirport()
      {
        if (flagHasArrivalAirport)
          {
          }
        flagHasArrivalAirport = false;
      }
    public void setDepartureDateTime(FlightTimesJSON  new_value)
      {
        if (flagHasDepartureDateTime)
          {
          }
        flagHasDepartureDateTime = true;
        storeDepartureDateTime = new_value;
      }
    public void unsetDepartureDateTime()
      {
        if (flagHasDepartureDateTime)
          {
          }
        flagHasDepartureDateTime = false;
      }
    public void setArrivalDateTime(FlightTimesJSON  new_value)
      {
        if (flagHasArrivalDateTime)
          {
          }
        flagHasArrivalDateTime = true;
        storeArrivalDateTime = new_value;
      }
    public void unsetArrivalDateTime()
      {
        if (flagHasArrivalDateTime)
          {
          }
        flagHasArrivalDateTime = false;
      }
    public void setAirlineFlightNumber(AirlineFlightNumberJSON  new_value)
      {
        if (flagHasAirlineFlightNumber)
          {
          }
        flagHasAirlineFlightNumber = true;
        storeAirlineFlightNumber = new_value;
      }
    public void unsetAirlineFlightNumber()
      {
        if (flagHasAirlineFlightNumber)
          {
          }
        flagHasAirlineFlightNumber = false;
      }
    public void setOperatingCarrier(AirlineJSON  new_value)
      {
        if (flagHasOperatingCarrier)
          {
          }
        flagHasOperatingCarrier = true;
        storeOperatingCarrier = new_value;
      }
    public void unsetOperatingCarrier()
      {
        if (flagHasOperatingCarrier)
          {
          }
        flagHasOperatingCarrier = false;
      }
    public void setFlightDuration(double new_value)
      {
        flagHasFlightDuration = true;
        storeFlightDuration = new_value;
        textStoreFlightDuration = "";
      }
    public void setFlightDurationText(string new_value)
      {
        flagHasFlightDuration = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field FlightDuration of FlightSegmentJSON is not a valid number.");
        textStoreFlightDuration = new_value;
      }
    public void unsetFlightDuration()
      {
        flagHasFlightDuration = false;
      }

    public virtual void extraFlightSegmentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightSegmentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightSegmentLookup(key);
        if (old_field == null)
          {
            extraFlightSegmentAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasFlightSegmentID);
        if (flagHasFlightSegmentID)
          {
            handler.start_pair("FlightSegmentID");
            handler.string_value(storeFlightSegmentID);
          }
        Debug.Assert(partial_allowed || flagHasDepartureAirport);
        if (flagHasDepartureAirport)
          {
            handler.start_pair("DepartureAirport");
            if (partial_allowed)
                storeDepartureAirport.write_partial_as_json(handler);
            else
                storeDepartureAirport.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasArrivalAirport);
        if (flagHasArrivalAirport)
          {
            handler.start_pair("ArrivalAirport");
            if (partial_allowed)
                storeArrivalAirport.write_partial_as_json(handler);
            else
                storeArrivalAirport.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDepartureDateTime);
        if (flagHasDepartureDateTime)
          {
            handler.start_pair("DepartureDateTime");
            if (partial_allowed)
                storeDepartureDateTime.write_partial_as_json(handler);
            else
                storeDepartureDateTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasArrivalDateTime);
        if (flagHasArrivalDateTime)
          {
            handler.start_pair("ArrivalDateTime");
            if (partial_allowed)
                storeArrivalDateTime.write_partial_as_json(handler);
            else
                storeArrivalDateTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasAirlineFlightNumber);
        if (flagHasAirlineFlightNumber)
          {
            handler.start_pair("AirlineFlightNumber");
            if (partial_allowed)
                storeAirlineFlightNumber.write_partial_as_json(handler);
            else
                storeAirlineFlightNumber.write_as_json(handler);
          }
        if (flagHasOperatingCarrier)
          {
            handler.start_pair("OperatingCarrier");
            if (partial_allowed)
                storeOperatingCarrier.write_partial_as_json(handler);
            else
                storeOperatingCarrier.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasFlightDuration);
        if (flagHasFlightDuration)
          {
            handler.start_pair("FlightDuration");
            if (textStoreFlightDuration != "")
                handler.number_value(textStoreFlightDuration);
            else if (((double)(long)storeFlightDuration) == storeFlightDuration)
                handler.number_value((long)storeFlightDuration);
            else
                handler.number_value(storeFlightDuration);
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
        if (!(hasFlightSegmentID()))
          {
            return "When parsing the object for %what%, the \"FlightSegmentID\" field was missing.";
          }
        if (!(hasDepartureAirport()))
          {
            return "When parsing the object for %what%, the \"DepartureAirport\" field was missing.";
          }
        if (!(hasArrivalAirport()))
          {
            return "When parsing the object for %what%, the \"ArrivalAirport\" field was missing.";
          }
        if (!(hasDepartureDateTime()))
          {
            return "When parsing the object for %what%, the \"DepartureDateTime\" field was missing.";
          }
        if (!(hasArrivalDateTime()))
          {
            return "When parsing the object for %what%, the \"ArrivalDateTime\" field was missing.";
          }
        if (!(hasAirlineFlightNumber()))
          {
            return "When parsing the object for %what%, the \"AirlineFlightNumber\" field was missing.";
          }
        if (!(hasFlightDuration()))
          {
            return "When parsing the object for %what%, the \"FlightDuration\" field was missing.";
          }
        return null;
      }

    public static FlightSegmentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSegmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegment", ignore_extras);
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
    public static FlightSegmentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSegmentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSegmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegment", ignore_extras);
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
    public static FlightSegmentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSegmentJSON from_text(string text, bool ignore_extras)
      {
        FlightSegmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegment", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightSegmentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightSegmentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightSegmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegment", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorFlightSegmentID;
        private FlightTravelLocationJSON.HoldingGenerator fieldGeneratorDepartureAirport;
        private FlightTravelLocationJSON.HoldingGenerator fieldGeneratorArrivalAirport;
        private FlightTimesJSON.HoldingGenerator fieldGeneratorDepartureDateTime;
        private FlightTimesJSON.HoldingGenerator fieldGeneratorArrivalDateTime;
        private AirlineFlightNumberJSON.HoldingGenerator fieldGeneratorAirlineFlightNumber;
        private AirlineJSON.HoldingGenerator fieldGeneratorOperatingCarrier;
        private JSONHoldingNumberTextGenerator fieldGeneratorFlightDuration;
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
            FlightSegmentJSON result = new FlightSegmentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightSegmentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightSegmentJSON result)
          {
            if (fieldGeneratorFlightSegmentID.have_value)
              {
                result.setFlightSegmentID(fieldGeneratorFlightSegmentID.value);
                fieldGeneratorFlightSegmentID.have_value = false;
              }
            else if ((!(result.hasFlightSegmentID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlightSegmentID\" field was missing.");
              }
            if (fieldGeneratorDepartureAirport.have_value)
              {
                result.setDepartureAirport(fieldGeneratorDepartureAirport.value);
                fieldGeneratorDepartureAirport.have_value = false;
              }
            else if ((!(result.hasDepartureAirport())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DepartureAirport\" field was missing.");
              }
            if (fieldGeneratorArrivalAirport.have_value)
              {
                result.setArrivalAirport(fieldGeneratorArrivalAirport.value);
                fieldGeneratorArrivalAirport.have_value = false;
              }
            else if ((!(result.hasArrivalAirport())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ArrivalAirport\" field was missing.");
              }
            if (fieldGeneratorDepartureDateTime.have_value)
              {
                result.setDepartureDateTime(fieldGeneratorDepartureDateTime.value);
                fieldGeneratorDepartureDateTime.have_value = false;
              }
            else if ((!(result.hasDepartureDateTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DepartureDateTime\" field was missing.");
              }
            if (fieldGeneratorArrivalDateTime.have_value)
              {
                result.setArrivalDateTime(fieldGeneratorArrivalDateTime.value);
                fieldGeneratorArrivalDateTime.have_value = false;
              }
            else if ((!(result.hasArrivalDateTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ArrivalDateTime\" field was missing.");
              }
            if (fieldGeneratorAirlineFlightNumber.have_value)
              {
                result.setAirlineFlightNumber(fieldGeneratorAirlineFlightNumber.value);
                fieldGeneratorAirlineFlightNumber.have_value = false;
              }
            else if ((!(result.hasAirlineFlightNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AirlineFlightNumber\" field was missing.");
              }
            if (fieldGeneratorOperatingCarrier.have_value)
              {
                result.setOperatingCarrier(fieldGeneratorOperatingCarrier.value);
                fieldGeneratorOperatingCarrier.have_value = false;
              }
            if (fieldGeneratorFlightDuration.have_value)
              {
                result.setFlightDurationText(fieldGeneratorFlightDuration.value);
                fieldGeneratorFlightDuration.have_value = false;
              }
            else if ((!(result.hasFlightDuration())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlightDuration\" field was missing.");
              }
          }
        protected abstract void handle_result(FlightSegmentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "rlineFlightNumber", 0, 17, false) == 0) && (field_name.Length == 19))
                                return fieldGeneratorAirlineFlightNumber;
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "rival", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 8, "irport", 0, 6, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorArrivalAirport;
                                        break;
                                    case 'D':
                                        if ((String.Compare(field_name, 8, "ateTime", 0, 7, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorArrivalDateTime;
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
                case 'D':
                    if (String.Compare(field_name, 1, "eparture", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 10, "irport", 0, 6, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorDepartureAirport;
                                break;
                            case 'D':
                                if ((String.Compare(field_name, 10, "ateTime", 0, 7, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorDepartureDateTime;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "light", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 7, "uration", 0, 7, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorFlightDuration;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 7, "egmentID", 0, 8, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorFlightSegmentID;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "peratingCarrier", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorOperatingCarrier;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFlightSegmentID = new JSONHoldingStringGenerator("field \"FlightSegmentID\" of the FlightSegment class");
            fieldGeneratorDepartureAirport = new FlightTravelLocationJSON.HoldingGenerator("field \"DepartureAirport\" of the FlightSegment class", ignore_extras);
            fieldGeneratorArrivalAirport = new FlightTravelLocationJSON.HoldingGenerator("field \"ArrivalAirport\" of the FlightSegment class", ignore_extras);
            fieldGeneratorDepartureDateTime = new FlightTimesJSON.HoldingGenerator("field \"DepartureDateTime\" of the FlightSegment class", ignore_extras);
            fieldGeneratorArrivalDateTime = new FlightTimesJSON.HoldingGenerator("field \"ArrivalDateTime\" of the FlightSegment class", ignore_extras);
            fieldGeneratorAirlineFlightNumber = new AirlineFlightNumberJSON.HoldingGenerator("field \"AirlineFlightNumber\" of the FlightSegment class", ignore_extras);
            fieldGeneratorOperatingCarrier = new AirlineJSON.HoldingGenerator("field \"OperatingCarrier\" of the FlightSegment class", ignore_extras);
            fieldGeneratorFlightDuration = new JSONHoldingNumberTextGenerator("field \"FlightDuration\" of the FlightSegment class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightSegment class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFlightSegmentID = new JSONHoldingStringGenerator("field \"FlightSegmentID\" of the FlightSegment class");
            fieldGeneratorDepartureAirport = new FlightTravelLocationJSON.HoldingGenerator("field \"DepartureAirport\" of the FlightSegment class", false);
            fieldGeneratorArrivalAirport = new FlightTravelLocationJSON.HoldingGenerator("field \"ArrivalAirport\" of the FlightSegment class", false);
            fieldGeneratorDepartureDateTime = new FlightTimesJSON.HoldingGenerator("field \"DepartureDateTime\" of the FlightSegment class", false);
            fieldGeneratorArrivalDateTime = new FlightTimesJSON.HoldingGenerator("field \"ArrivalDateTime\" of the FlightSegment class", false);
            fieldGeneratorAirlineFlightNumber = new AirlineFlightNumberJSON.HoldingGenerator("field \"AirlineFlightNumber\" of the FlightSegment class", false);
            fieldGeneratorOperatingCarrier = new AirlineJSON.HoldingGenerator("field \"OperatingCarrier\" of the FlightSegment class", false);
            fieldGeneratorFlightDuration = new JSONHoldingNumberTextGenerator("field \"FlightDuration\" of the FlightSegment class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightSegment class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFlightSegmentID.reset();
            fieldGeneratorDepartureAirport.reset();
            fieldGeneratorArrivalAirport.reset();
            fieldGeneratorDepartureDateTime.reset();
            fieldGeneratorArrivalDateTime.reset();
            fieldGeneratorAirlineFlightNumber.reset();
            fieldGeneratorOperatingCarrier.reset();
            fieldGeneratorFlightDuration.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDepartureAirport.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorArrivalAirport.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDepartureDateTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorArrivalDateTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAirlineFlightNumber.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOperatingCarrier.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDepartureAirport.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorArrivalAirport.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDepartureDateTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorArrivalDateTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAirlineFlightNumber.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOperatingCarrier.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightSegmentJSON  result)
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
        public FlightSegmentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightSegmentJSON  result)
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
    protected virtual void handle_result(List<FlightSegmentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightSegmentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightSegmentJSON>();
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
    public List<FlightSegmentJSON> value;
  };
  };
