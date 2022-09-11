/* file "AirlineJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AirlineJSON : JSONBase
  {
    private bool flagHasName;
    private string storeName;
    private bool flagHasSpokenName;
    private string storeSpokenName;
    private bool flagHasIATACode;
    private string storeIATACode;
    private bool flagHasICAOCode;
    private string storeICAOCode;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of AirlineJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONSpokenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenName of AirlineJSON is not a string.");
        setSpokenName(json_string.getData());
      }


    private void  fromJSONIATACode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field IATACode of AirlineJSON is not a string.");
        setIATACode(json_string.getData());
      }


    private void  fromJSONICAOCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ICAOCode of AirlineJSON is not a string.");
        setICAOCode(json_string.getData());
      }


    public AirlineJSON()
      {
        flagHasName = false;
        flagHasSpokenName = false;
        flagHasIATACode = false;
        flagHasICAOCode = false;
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

    public bool  hasSpokenName()
      {
        return flagHasSpokenName;
      }

    public string  getSpokenName()
      {
        Debug.Assert(flagHasSpokenName);
        return storeSpokenName;
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


    public virtual int extraAirlineComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAirlineComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAirlineComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAirlineLookup(string field_name)
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
    public void setSpokenName(string new_value)
      {
        flagHasSpokenName = true;
        storeSpokenName = new_value;
      }
    public void unsetSpokenName()
      {
        flagHasSpokenName = false;
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

    public virtual void extraAirlineAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAirlineSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAirlineLookup(key);
        if (old_field == null)
          {
            extraAirlineAppendPair(key, new_component);
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
        if (flagHasSpokenName)
          {
            handler.start_pair("SpokenName");
            handler.string_value(storeSpokenName);
          }
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
        return null;
      }

    public static AirlineJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AirlineJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Airline", ignore_extras);
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
    public static AirlineJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AirlineJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AirlineJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Airline", ignore_extras);
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
    public static AirlineJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AirlineJSON from_text(string text, bool ignore_extras)
      {
        AirlineJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Airline", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AirlineJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AirlineJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AirlineJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Airline", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorSpokenName;
        private JSONHoldingStringGenerator fieldGeneratorIATACode;
        private JSONHoldingStringGenerator fieldGeneratorICAOCode;
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
            AirlineJSON result = new AirlineJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAirlineAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(AirlineJSON result)
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
            if (fieldGeneratorSpokenName.have_value)
              {
                result.setSpokenName(fieldGeneratorSpokenName.value);
                fieldGeneratorSpokenName.have_value = false;
              }
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
          }
        protected abstract void handle_result(AirlineJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
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
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pokenName", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorSpokenName;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the Airline class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the Airline class");
            fieldGeneratorIATACode = new JSONHoldingStringGenerator("field \"IATACode\" of the Airline class");
            fieldGeneratorICAOCode = new JSONHoldingStringGenerator("field \"ICAOCode\" of the Airline class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the Airline class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the Airline class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the Airline class");
            fieldGeneratorIATACode = new JSONHoldingStringGenerator("field \"IATACode\" of the Airline class");
            fieldGeneratorICAOCode = new JSONHoldingStringGenerator("field \"ICAOCode\" of the Airline class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the Airline class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorSpokenName.reset();
            fieldGeneratorIATACode.reset();
            fieldGeneratorICAOCode.reset();
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
        protected override void handle_result(AirlineJSON  result)
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
        public AirlineJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AirlineJSON  result)
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
    protected virtual void handle_result(List<AirlineJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AirlineJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AirlineJSON>();
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
    public List<AirlineJSON> value;
  };
  };
