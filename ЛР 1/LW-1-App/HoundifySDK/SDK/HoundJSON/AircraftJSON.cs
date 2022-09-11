/* file "AircraftJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AircraftJSON : JSONBase
  {
    private bool flagHasIATACode;
    private string storeIATACode;
    private bool flagHasICAOCode;
    private string storeICAOCode;
    private bool flagHasDescription;
    private string storeDescription;
    private bool flagHasManufacturer;
    private string storeManufacturer;
    private bool flagHasType;
    private string storeType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONIATACode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field IATACode of AircraftJSON is not a string.");
        setIATACode(json_string.getData());
      }


    private void  fromJSONICAOCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ICAOCode of AircraftJSON is not a string.");
        setICAOCode(json_string.getData());
      }


    private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Description of AircraftJSON is not a string.");
        setDescription(json_string.getData());
      }


    private void  fromJSONManufacturer(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Manufacturer of AircraftJSON is not a string.");
        setManufacturer(json_string.getData());
      }


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Type of AircraftJSON is not a string.");
        setType(json_string.getData());
      }


    public AircraftJSON()
      {
        flagHasIATACode = false;
        flagHasICAOCode = false;
        flagHasDescription = false;
        flagHasManufacturer = false;
        flagHasType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasIATACode()
      {
        return flagHasIATACode;
      }

    public string  getIATACode()
      {
        Debug.Assert(flagHasIATACode);
        return storeIATACode;
      }

    public bool  hasICAOCode()
      {
        return flagHasICAOCode;
      }

    public string  getICAOCode()
      {
        Debug.Assert(flagHasICAOCode);
        return storeICAOCode;
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

    public bool  hasManufacturer()
      {
        return flagHasManufacturer;
      }

    public string  getManufacturer()
      {
        Debug.Assert(flagHasManufacturer);
        return storeManufacturer;
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public string  getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }


    public virtual int extraAircraftComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAircraftComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAircraftComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAircraftLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setIATACode(string new_value)
      {
        flagHasIATACode = true;
        storeIATACode = new_value;
      }
    public void unsetIATACode()
      {
        flagHasIATACode = false;
      }
    public void setICAOCode(string new_value)
      {
        flagHasICAOCode = true;
        storeICAOCode = new_value;
      }
    public void unsetICAOCode()
      {
        flagHasICAOCode = false;
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
    public void setManufacturer(string new_value)
      {
        flagHasManufacturer = true;
        storeManufacturer = new_value;
      }
    public void unsetManufacturer()
      {
        flagHasManufacturer = false;
      }
    public void setType(string new_value)
      {
        flagHasType = true;
        storeType = new_value;
      }
    public void unsetType()
      {
        flagHasType = false;
      }

    public virtual void extraAircraftAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAircraftSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAircraftLookup(key);
        if (old_field == null)
          {
            extraAircraftAppendPair(key, new_component);
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
        if (flagHasIATACode)
          {
            handler.start_pair("IATACode");
            handler.string_value(storeIATACode);
          }
        if (flagHasICAOCode)
          {
            handler.start_pair("ICAOCode");
            handler.string_value(storeICAOCode);
          }
        if (flagHasDescription)
          {
            handler.start_pair("Description");
            handler.string_value(storeDescription);
          }
        if (flagHasManufacturer)
          {
            handler.start_pair("Manufacturer");
            handler.string_value(storeManufacturer);
          }
        if (flagHasType)
          {
            handler.start_pair("Type");
            handler.string_value(storeType);
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

    public static AircraftJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AircraftJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Aircraft", ignore_extras);
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
    public static AircraftJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AircraftJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AircraftJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Aircraft", ignore_extras);
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
    public static AircraftJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AircraftJSON from_text(string text, bool ignore_extras)
      {
        AircraftJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Aircraft", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AircraftJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AircraftJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AircraftJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Aircraft", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorIATACode;
        private JSONHoldingStringGenerator fieldGeneratorICAOCode;
        private JSONHoldingStringGenerator fieldGeneratorDescription;
        private JSONHoldingStringGenerator fieldGeneratorManufacturer;
        private JSONHoldingStringGenerator fieldGeneratorType;
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
            AircraftJSON result = new AircraftJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAircraftAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(AircraftJSON result)
          {
            if (fieldGeneratorIATACode.have_value)
              {
                result.setIATACode(fieldGeneratorIATACode.value);
                fieldGeneratorIATACode.have_value = false;
              }
            if (fieldGeneratorICAOCode.have_value)
              {
                result.setICAOCode(fieldGeneratorICAOCode.value);
                fieldGeneratorICAOCode.have_value = false;
              }
            if (fieldGeneratorDescription.have_value)
              {
                result.setDescription(fieldGeneratorDescription.value);
                fieldGeneratorDescription.have_value = false;
              }
            if (fieldGeneratorManufacturer.have_value)
              {
                result.setManufacturer(fieldGeneratorManufacturer.value);
                fieldGeneratorManufacturer.have_value = false;
              }
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
          }
        protected abstract void handle_result(AircraftJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDescription;
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 2, "TACode", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorIATACode;
                            break;
                        case 'C':
                            if ((String.Compare(field_name, 2, "AOCode", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorICAOCode;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "anufacturer", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorManufacturer;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorType;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorIATACode = new JSONHoldingStringGenerator("field \"IATACode\" of the Aircraft class");
            fieldGeneratorICAOCode = new JSONHoldingStringGenerator("field \"ICAOCode\" of the Aircraft class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the Aircraft class");
            fieldGeneratorManufacturer = new JSONHoldingStringGenerator("field \"Manufacturer\" of the Aircraft class");
            fieldGeneratorType = new JSONHoldingStringGenerator("field \"Type\" of the Aircraft class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the Aircraft class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorIATACode = new JSONHoldingStringGenerator("field \"IATACode\" of the Aircraft class");
            fieldGeneratorICAOCode = new JSONHoldingStringGenerator("field \"ICAOCode\" of the Aircraft class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the Aircraft class");
            fieldGeneratorManufacturer = new JSONHoldingStringGenerator("field \"Manufacturer\" of the Aircraft class");
            fieldGeneratorType = new JSONHoldingStringGenerator("field \"Type\" of the Aircraft class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the Aircraft class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorIATACode.reset();
            fieldGeneratorICAOCode.reset();
            fieldGeneratorDescription.reset();
            fieldGeneratorManufacturer.reset();
            fieldGeneratorType.reset();
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
        protected override void handle_result(AircraftJSON  result)
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
        public AircraftJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AircraftJSON  result)
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
    protected virtual void handle_result(List<AircraftJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AircraftJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AircraftJSON>();
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
    public List<AircraftJSON> value;
  };
  };
