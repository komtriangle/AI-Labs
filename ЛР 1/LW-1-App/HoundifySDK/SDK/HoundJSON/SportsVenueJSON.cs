/* file "SportsVenueJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsVenueJSON : JSONBase
  {
    private bool flagHasName;
    private string storeName;
    private bool flagHasAddress;
    private string storeAddress;
    private bool flagHasCity;
    private string storeCity;
    private bool flagHasState;
    private string storeState;
    private bool flagHasZip;
    private string storeZip;
    private bool flagHasCountry;
    private string storeCountry;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of SportsVenueJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONAddress(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Address of SportsVenueJSON is not a string.");
        setAddress(json_string.getData());
      }


    private void  fromJSONCity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field City of SportsVenueJSON is not a string.");
        setCity(json_string.getData());
      }


    private void  fromJSONState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field State of SportsVenueJSON is not a string.");
        setState(json_string.getData());
      }


    private void  fromJSONZip(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Zip of SportsVenueJSON is not a string.");
        setZip(json_string.getData());
      }


    private void  fromJSONCountry(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Country of SportsVenueJSON is not a string.");
        setCountry(json_string.getData());
      }


    public SportsVenueJSON()
      {
        flagHasName = false;
        flagHasAddress = false;
        flagHasCity = false;
        flagHasState = false;
        flagHasZip = false;
        flagHasCountry = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasAddress()
      {
        return flagHasAddress;
      }

    public string  getAddress()
      {
        Debug.Assert(flagHasAddress);
        return storeAddress;
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

    public bool  hasState()
      {
        return flagHasState;
      }

    public string  getState()
      {
        Debug.Assert(flagHasState);
        return storeState;
      }

    public bool  hasZip()
      {
        return flagHasZip;
      }

    public string  getZip()
      {
        Debug.Assert(flagHasZip);
        return storeZip;
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


    public virtual int extraSportsVenueComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsVenueComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsVenueComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsVenueLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setAddress(string new_value)
      {
        flagHasAddress = true;
        storeAddress = new_value;
      }
    public void unsetAddress()
      {
        flagHasAddress = false;
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
    public void setState(string new_value)
      {
        flagHasState = true;
        storeState = new_value;
      }
    public void unsetState()
      {
        flagHasState = false;
      }
    public void setZip(string new_value)
      {
        flagHasZip = true;
        storeZip = new_value;
      }
    public void unsetZip()
      {
        flagHasZip = false;
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

    public virtual void extraSportsVenueAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsVenueSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsVenueLookup(key);
        if (old_field == null)
          {
            extraSportsVenueAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        if (flagHasAddress)
          {
            handler.start_pair("Address");
            handler.string_value(storeAddress);
          }
        Debug.Assert(partial_allowed || flagHasCity);
        if (flagHasCity)
          {
            handler.start_pair("City");
            handler.string_value(storeCity);
          }
        if (flagHasState)
          {
            handler.start_pair("State");
            handler.string_value(storeState);
          }
        if (flagHasZip)
          {
            handler.start_pair("Zip");
            handler.string_value(storeZip);
          }
        if (flagHasCountry)
          {
            handler.start_pair("Country");
            handler.string_value(storeCountry);
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
        if (!(hasName()))
          {
            return "When parsing the object for %what%, the \"Name\" field was missing.";
          }
        if (!(hasCity()))
          {
            return "When parsing the object for %what%, the \"City\" field was missing.";
          }
        return null;
      }

    public static SportsVenueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsVenueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsVenue", ignore_extras);
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
    public static SportsVenueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsVenueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsVenueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsVenue", ignore_extras);
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
    public static SportsVenueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsVenueJSON from_text(string text, bool ignore_extras)
      {
        SportsVenueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsVenue", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsVenueJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsVenueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsVenueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsVenue", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorAddress;
        private JSONHoldingStringGenerator fieldGeneratorCity;
        private JSONHoldingStringGenerator fieldGeneratorState;
        private JSONHoldingStringGenerator fieldGeneratorZip;
        private JSONHoldingStringGenerator fieldGeneratorCountry;
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
            SportsVenueJSON result = new SportsVenueJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsVenueAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsVenueJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            else if ((!(result.hasName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Name\" field was missing.");
              }
            if (fieldGeneratorAddress.have_value)
              {
                result.setAddress(fieldGeneratorAddress.value);
                fieldGeneratorAddress.have_value = false;
              }
            if (fieldGeneratorCity.have_value)
              {
                result.setCity(fieldGeneratorCity.value);
                fieldGeneratorCity.have_value = false;
              }
            else if ((!(result.hasCity())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"City\" field was missing.");
              }
            if (fieldGeneratorState.have_value)
              {
                result.setState(fieldGeneratorState.value);
                fieldGeneratorState.have_value = false;
              }
            if (fieldGeneratorZip.have_value)
              {
                result.setZip(fieldGeneratorZip.value);
                fieldGeneratorZip.have_value = false;
              }
            if (fieldGeneratorCountry.have_value)
              {
                result.setCountry(fieldGeneratorCountry.value);
                fieldGeneratorCountry.have_value = false;
              }
          }
        protected abstract void handle_result(SportsVenueJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ddress", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorAddress;
                    break;
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
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tate", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorState;
                    break;
                case 'Z':
                    if ((String.Compare(field_name, 1, "ip", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorZip;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the SportsVenue class");
            fieldGeneratorAddress = new JSONHoldingStringGenerator("field \"Address\" of the SportsVenue class");
            fieldGeneratorCity = new JSONHoldingStringGenerator("field \"City\" of the SportsVenue class");
            fieldGeneratorState = new JSONHoldingStringGenerator("field \"State\" of the SportsVenue class");
            fieldGeneratorZip = new JSONHoldingStringGenerator("field \"Zip\" of the SportsVenue class");
            fieldGeneratorCountry = new JSONHoldingStringGenerator("field \"Country\" of the SportsVenue class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsVenue class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the SportsVenue class");
            fieldGeneratorAddress = new JSONHoldingStringGenerator("field \"Address\" of the SportsVenue class");
            fieldGeneratorCity = new JSONHoldingStringGenerator("field \"City\" of the SportsVenue class");
            fieldGeneratorState = new JSONHoldingStringGenerator("field \"State\" of the SportsVenue class");
            fieldGeneratorZip = new JSONHoldingStringGenerator("field \"Zip\" of the SportsVenue class");
            fieldGeneratorCountry = new JSONHoldingStringGenerator("field \"Country\" of the SportsVenue class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsVenue class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorAddress.reset();
            fieldGeneratorCity.reset();
            fieldGeneratorState.reset();
            fieldGeneratorZip.reset();
            fieldGeneratorCountry.reset();
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
        protected override void handle_result(SportsVenueJSON  result)
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
        public SportsVenueJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsVenueJSON  result)
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
    protected virtual void handle_result(List<SportsVenueJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsVenueJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsVenueJSON>();
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
    public List<SportsVenueJSON> value;
  };
  };
