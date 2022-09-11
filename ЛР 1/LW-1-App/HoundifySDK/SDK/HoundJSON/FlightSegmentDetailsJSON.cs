/* file "FlightSegmentDetailsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightSegmentDetailsJSON : JSONBase
  {
    private bool flagHasFlightSegmentID;
    private string storeFlightSegmentID;
    private bool flagHasCabinClass;
    private CabinClassJSON  storeCabinClass;
    private bool flagHasLayoverDuration;
    private double storeLayoverDuration;
    private string textStoreLayoverDuration;
    private bool flagHasChangeToAirport;
    private FlightTravelLocationJSON  storeChangeToAirport;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFlightSegmentID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FlightSegmentID of FlightSegmentDetailsJSON is not a string.");
        setFlightSegmentID(json_string.getData());
      }


    private void  fromJSONCabinClass(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CabinClassJSON convert_classy = CabinClassJSON.from_json(json_value, ignore_extras, true);
        setCabinClass(convert_classy);
      }


    private void  fromJSONLayoverDuration(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field LayoverDuration of FlightSegmentDetailsJSON is not a number.");
              }
          }
        setLayoverDurationText(the_rational_text);
      }


    private void  fromJSONChangeToAirport(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTravelLocationJSON convert_classy = FlightTravelLocationJSON.from_json(json_value, ignore_extras, true);
        setChangeToAirport(convert_classy);
      }


    public FlightSegmentDetailsJSON()
      {
        flagHasFlightSegmentID = false;
        flagHasCabinClass = false;
        flagHasLayoverDuration = false;
        flagHasChangeToAirport = false;
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

    public bool  hasCabinClass()
      {
        return flagHasCabinClass;
      }

    public CabinClassJSON   getCabinClass()
      {
        Debug.Assert(flagHasCabinClass);
        return storeCabinClass;
      }

    public CabinClassJSON.TypeValue  getCabinClassValue()
      {
        return getCabinClass().getValue();
      }

    public string  getCabinClassAsString()
      {
        return getCabinClass().getValueAsString();
      }

    public bool  hasLayoverDuration()
      {
        return flagHasLayoverDuration;
      }

    public double  getLayoverDuration()
      {
        Debug.Assert(flagHasLayoverDuration);
        if (textStoreLayoverDuration != "")
          {
            return Double.Parse(textStoreLayoverDuration);
          }
        return storeLayoverDuration;
      }

    public string  getLayoverDurationAsText()
      {
        Debug.Assert(flagHasLayoverDuration);
        if (textStoreLayoverDuration == "")
          {
            return Convert.ToString(storeLayoverDuration);
          }
        else
          {
            return (textStoreLayoverDuration);
          }
      }

    public bool  hasChangeToAirport()
      {
        return flagHasChangeToAirport;
      }

    public FlightTravelLocationJSON   getChangeToAirport()
      {
        Debug.Assert(flagHasChangeToAirport);
        return storeChangeToAirport;
      }


    public virtual int extraFlightSegmentDetailsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightSegmentDetailsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightSegmentDetailsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightSegmentDetailsLookup(string field_name)
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
    public void setCabinClass(CabinClassJSON  new_value)
      {
        if (flagHasCabinClass)
          {
          }
        flagHasCabinClass = true;
        storeCabinClass = new_value;
      }
    public void setCabinClass(CabinClassJSON.TypeValue new_value)
      {
        setCabinClass(new CabinClassJSON(new_value));
      }
    public void setCabinClass(string chars)
      {
        CabinClassJSON.TypeValueKnownValues known = CabinClassJSON.stringToValue(chars);
        CabinClassJSON.TypeValue new_value = new CabinClassJSON.TypeValue();
        if (known == CabinClassJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setCabinClass(new_value);
      }
    public void unsetCabinClass()
      {
        if (flagHasCabinClass)
          {
          }
        flagHasCabinClass = false;
      }
    public void setLayoverDuration(double new_value)
      {
        flagHasLayoverDuration = true;
        storeLayoverDuration = new_value;
        textStoreLayoverDuration = "";
      }
    public void setLayoverDurationText(string new_value)
      {
        flagHasLayoverDuration = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field LayoverDuration of FlightSegmentDetailsJSON is not a valid number.");
        textStoreLayoverDuration = new_value;
      }
    public void unsetLayoverDuration()
      {
        flagHasLayoverDuration = false;
      }
    public void setChangeToAirport(FlightTravelLocationJSON  new_value)
      {
        if (flagHasChangeToAirport)
          {
          }
        flagHasChangeToAirport = true;
        storeChangeToAirport = new_value;
      }
    public void unsetChangeToAirport()
      {
        if (flagHasChangeToAirport)
          {
          }
        flagHasChangeToAirport = false;
      }

    public virtual void extraFlightSegmentDetailsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightSegmentDetailsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightSegmentDetailsLookup(key);
        if (old_field == null)
          {
            extraFlightSegmentDetailsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCabinClass);
        if (flagHasCabinClass)
          {
            handler.start_pair("CabinClass");
            if (partial_allowed)
                storeCabinClass.write_partial_as_json(handler);
            else
                storeCabinClass.write_as_json(handler);
          }
        if (flagHasLayoverDuration)
          {
            handler.start_pair("LayoverDuration");
            if (textStoreLayoverDuration != "")
                handler.number_value(textStoreLayoverDuration);
            else if (((double)(long)storeLayoverDuration) == storeLayoverDuration)
                handler.number_value((long)storeLayoverDuration);
            else
                handler.number_value(storeLayoverDuration);
          }
        if (flagHasChangeToAirport)
          {
            handler.start_pair("ChangeToAirport");
            if (partial_allowed)
                storeChangeToAirport.write_partial_as_json(handler);
            else
                storeChangeToAirport.write_as_json(handler);
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
        if (!(hasCabinClass()))
          {
            return "When parsing the object for %what%, the \"CabinClass\" field was missing.";
          }
        return null;
      }

    public static FlightSegmentDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSegmentDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentDetails", ignore_extras);
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
    public static FlightSegmentDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSegmentDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSegmentDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentDetails", ignore_extras);
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
    public static FlightSegmentDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSegmentDetailsJSON from_text(string text, bool ignore_extras)
      {
        FlightSegmentDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentDetails", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightSegmentDetailsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightSegmentDetailsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightSegmentDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentDetails", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorFlightSegmentID;
        private CabinClassJSON.HoldingGenerator fieldGeneratorCabinClass;
        private JSONHoldingNumberTextGenerator fieldGeneratorLayoverDuration;
        private FlightTravelLocationJSON.HoldingGenerator fieldGeneratorChangeToAirport;
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
            FlightSegmentDetailsJSON result = new FlightSegmentDetailsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightSegmentDetailsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightSegmentDetailsJSON result)
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
            if (fieldGeneratorCabinClass.have_value)
              {
                result.setCabinClass(fieldGeneratorCabinClass.value);
                fieldGeneratorCabinClass.have_value = false;
              }
            else if ((!(result.hasCabinClass())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CabinClass\" field was missing.");
              }
            if (fieldGeneratorLayoverDuration.have_value)
              {
                result.setLayoverDurationText(fieldGeneratorLayoverDuration.value);
                fieldGeneratorLayoverDuration.have_value = false;
              }
            if (fieldGeneratorChangeToAirport.have_value)
              {
                result.setChangeToAirport(fieldGeneratorChangeToAirport.value);
                fieldGeneratorChangeToAirport.have_value = false;
              }
          }
        protected abstract void handle_result(FlightSegmentDetailsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "binClass", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorCabinClass;
                            break;
                        case 'h':
                            if ((String.Compare(field_name, 2, "angeToAirport", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorChangeToAirport;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "lightSegmentID", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorFlightSegmentID;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ayoverDuration", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorLayoverDuration;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFlightSegmentID = new JSONHoldingStringGenerator("field \"FlightSegmentID\" of the FlightSegmentDetails class");
            fieldGeneratorCabinClass = new CabinClassJSON.HoldingGenerator("field \"CabinClass\" of the FlightSegmentDetails class", ignore_extras);
            fieldGeneratorLayoverDuration = new JSONHoldingNumberTextGenerator("field \"LayoverDuration\" of the FlightSegmentDetails class");
            fieldGeneratorChangeToAirport = new FlightTravelLocationJSON.HoldingGenerator("field \"ChangeToAirport\" of the FlightSegmentDetails class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightSegmentDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFlightSegmentID = new JSONHoldingStringGenerator("field \"FlightSegmentID\" of the FlightSegmentDetails class");
            fieldGeneratorCabinClass = new CabinClassJSON.HoldingGenerator("field \"CabinClass\" of the FlightSegmentDetails class", false);
            fieldGeneratorLayoverDuration = new JSONHoldingNumberTextGenerator("field \"LayoverDuration\" of the FlightSegmentDetails class");
            fieldGeneratorChangeToAirport = new FlightTravelLocationJSON.HoldingGenerator("field \"ChangeToAirport\" of the FlightSegmentDetails class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightSegmentDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFlightSegmentID.reset();
            fieldGeneratorCabinClass.reset();
            fieldGeneratorLayoverDuration.reset();
            fieldGeneratorChangeToAirport.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorCabinClass.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorChangeToAirport.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorCabinClass.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorChangeToAirport.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightSegmentDetailsJSON  result)
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
        public FlightSegmentDetailsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightSegmentDetailsJSON  result)
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
    protected virtual void handle_result(List<FlightSegmentDetailsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightSegmentDetailsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightSegmentDetailsJSON>();
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
    public List<FlightSegmentDetailsJSON> value;
  };
  };
