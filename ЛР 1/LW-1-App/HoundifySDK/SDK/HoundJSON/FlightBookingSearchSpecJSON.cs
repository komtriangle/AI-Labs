/* file "FlightBookingSearchSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightBookingSearchSpecJSON : JSONBase
  {
    private bool flagHasCountryCode;
    private string storeCountryCode;
    private bool flagHasLanguageCode;
    private string storeLanguageCode;
    private bool flagHasFlightTravelLocationForClient;
    private FlightTravelLocationJSON  storeFlightTravelLocationForClient;
    private bool flagHasFlightBookingFilter;
    private FlightBookingFilterJSON  storeFlightBookingFilter;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCountryCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CountryCode of FlightBookingSearchSpecJSON is not a string.");
        setCountryCode(json_string.getData());
      }


    private void  fromJSONLanguageCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LanguageCode of FlightBookingSearchSpecJSON is not a string.");
        setLanguageCode(json_string.getData());
      }


    private void  fromJSONFlightTravelLocationForClient(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTravelLocationJSON convert_classy = FlightTravelLocationJSON.from_json(json_value, ignore_extras, true);
        setFlightTravelLocationForClient(convert_classy);
      }


    private void  fromJSONFlightBookingFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightBookingFilterJSON convert_classy = FlightBookingFilterJSON.from_json(json_value, ignore_extras, true);
        setFlightBookingFilter(convert_classy);
      }


    public FlightBookingSearchSpecJSON()
      {
        flagHasCountryCode = false;
        flagHasLanguageCode = false;
        flagHasFlightTravelLocationForClient = false;
        flagHasFlightBookingFilter = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasLanguageCode()
      {
        return flagHasLanguageCode;
      }

    public string  getLanguageCode()
      {
        Debug.Assert(flagHasLanguageCode);
        return storeLanguageCode;
      }

    public bool  hasFlightTravelLocationForClient()
      {
        return flagHasFlightTravelLocationForClient;
      }

    public FlightTravelLocationJSON   getFlightTravelLocationForClient()
      {
        Debug.Assert(flagHasFlightTravelLocationForClient);
        return storeFlightTravelLocationForClient;
      }

    public bool  hasFlightBookingFilter()
      {
        return flagHasFlightBookingFilter;
      }

    public FlightBookingFilterJSON   getFlightBookingFilter()
      {
        Debug.Assert(flagHasFlightBookingFilter);
        return storeFlightBookingFilter;
      }


    public virtual int extraFlightBookingSearchSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightBookingSearchSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightBookingSearchSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightBookingSearchSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setLanguageCode(string new_value)
      {
        flagHasLanguageCode = true;
        storeLanguageCode = new_value;
      }
    public void unsetLanguageCode()
      {
        flagHasLanguageCode = false;
      }
    public void setFlightTravelLocationForClient(FlightTravelLocationJSON  new_value)
      {
        if (flagHasFlightTravelLocationForClient)
          {
          }
        flagHasFlightTravelLocationForClient = true;
        storeFlightTravelLocationForClient = new_value;
      }
    public void unsetFlightTravelLocationForClient()
      {
        if (flagHasFlightTravelLocationForClient)
          {
          }
        flagHasFlightTravelLocationForClient = false;
      }
    public void setFlightBookingFilter(FlightBookingFilterJSON  new_value)
      {
        if (flagHasFlightBookingFilter)
          {
          }
        flagHasFlightBookingFilter = true;
        storeFlightBookingFilter = new_value;
      }
    public void unsetFlightBookingFilter()
      {
        if (flagHasFlightBookingFilter)
          {
          }
        flagHasFlightBookingFilter = false;
      }

    public virtual void extraFlightBookingSearchSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightBookingSearchSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightBookingSearchSpecLookup(key);
        if (old_field == null)
          {
            extraFlightBookingSearchSpecAppendPair(key, new_component);
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
        if (flagHasCountryCode)
          {
            handler.start_pair("CountryCode");
            handler.string_value(storeCountryCode);
          }
        if (flagHasLanguageCode)
          {
            handler.start_pair("LanguageCode");
            handler.string_value(storeLanguageCode);
          }
        if (flagHasFlightTravelLocationForClient)
          {
            handler.start_pair("FlightTravelLocationForClient");
            if (partial_allowed)
                storeFlightTravelLocationForClient.write_partial_as_json(handler);
            else
                storeFlightTravelLocationForClient.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasFlightBookingFilter);
        if (flagHasFlightBookingFilter)
          {
            handler.start_pair("FlightBookingFilter");
            if (partial_allowed)
                storeFlightBookingFilter.write_partial_as_json(handler);
            else
                storeFlightBookingFilter.write_as_json(handler);
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
        if (!(hasFlightBookingFilter()))
          {
            return "When parsing the object for %what%, the \"FlightBookingFilter\" field was missing.";
          }
        return null;
      }

    public static FlightBookingSearchSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightBookingSearchSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingSearchSpec", ignore_extras);
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
    public static FlightBookingSearchSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightBookingSearchSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightBookingSearchSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingSearchSpec", ignore_extras);
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
    public static FlightBookingSearchSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightBookingSearchSpecJSON from_text(string text, bool ignore_extras)
      {
        FlightBookingSearchSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingSearchSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightBookingSearchSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightBookingSearchSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightBookingSearchSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingSearchSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorCountryCode;
        private JSONHoldingStringGenerator fieldGeneratorLanguageCode;
        private FlightTravelLocationJSON.HoldingGenerator fieldGeneratorFlightTravelLocationForClient;
        private FlightBookingFilterJSON.HoldingGenerator fieldGeneratorFlightBookingFilter;
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
            FlightBookingSearchSpecJSON result = new FlightBookingSearchSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightBookingSearchSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightBookingSearchSpecJSON result)
          {
            if (fieldGeneratorCountryCode.have_value)
              {
                result.setCountryCode(fieldGeneratorCountryCode.value);
                fieldGeneratorCountryCode.have_value = false;
              }
            if (fieldGeneratorLanguageCode.have_value)
              {
                result.setLanguageCode(fieldGeneratorLanguageCode.value);
                fieldGeneratorLanguageCode.have_value = false;
              }
            if (fieldGeneratorFlightTravelLocationForClient.have_value)
              {
                result.setFlightTravelLocationForClient(fieldGeneratorFlightTravelLocationForClient.value);
                fieldGeneratorFlightTravelLocationForClient.have_value = false;
              }
            if (fieldGeneratorFlightBookingFilter.have_value)
              {
                result.setFlightBookingFilter(fieldGeneratorFlightBookingFilter.value);
                fieldGeneratorFlightBookingFilter.have_value = false;
              }
            else if ((!(result.hasFlightBookingFilter())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlightBookingFilter\" field was missing.");
              }
          }
        protected abstract void handle_result(FlightBookingSearchSpecJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ountryCode", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCountryCode;
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "light", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'B':
                                if ((String.Compare(field_name, 7, "ookingFilter", 0, 12, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorFlightBookingFilter;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 7, "ravelLocationForClient", 0, 22, false) == 0) && (field_name.Length == 29))
                                    return fieldGeneratorFlightTravelLocationForClient;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "anguageCode", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorLanguageCode;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCountryCode = new JSONHoldingStringGenerator("field \"CountryCode\" of the FlightBookingSearchSpec class");
            fieldGeneratorLanguageCode = new JSONHoldingStringGenerator("field \"LanguageCode\" of the FlightBookingSearchSpec class");
            fieldGeneratorFlightTravelLocationForClient = new FlightTravelLocationJSON.HoldingGenerator("field \"FlightTravelLocationForClient\" of the FlightBookingSearchSpec class", ignore_extras);
            fieldGeneratorFlightBookingFilter = new FlightBookingFilterJSON.HoldingGenerator("field \"FlightBookingFilter\" of the FlightBookingSearchSpec class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightBookingSearchSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCountryCode = new JSONHoldingStringGenerator("field \"CountryCode\" of the FlightBookingSearchSpec class");
            fieldGeneratorLanguageCode = new JSONHoldingStringGenerator("field \"LanguageCode\" of the FlightBookingSearchSpec class");
            fieldGeneratorFlightTravelLocationForClient = new FlightTravelLocationJSON.HoldingGenerator("field \"FlightTravelLocationForClient\" of the FlightBookingSearchSpec class", false);
            fieldGeneratorFlightBookingFilter = new FlightBookingFilterJSON.HoldingGenerator("field \"FlightBookingFilter\" of the FlightBookingSearchSpec class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightBookingSearchSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCountryCode.reset();
            fieldGeneratorLanguageCode.reset();
            fieldGeneratorFlightTravelLocationForClient.reset();
            fieldGeneratorFlightBookingFilter.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFlightTravelLocationForClient.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFlightBookingFilter.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFlightTravelLocationForClient.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFlightBookingFilter.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightBookingSearchSpecJSON  result)
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
        public FlightBookingSearchSpecJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightBookingSearchSpecJSON  result)
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
    protected virtual void handle_result(List<FlightBookingSearchSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightBookingSearchSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightBookingSearchSpecJSON>();
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
    public List<FlightBookingSearchSpecJSON> value;
  };
  };
