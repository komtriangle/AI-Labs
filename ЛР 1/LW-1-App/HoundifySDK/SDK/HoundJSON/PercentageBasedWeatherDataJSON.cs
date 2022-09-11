/* file "PercentageBasedWeatherDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class PercentageBasedWeatherDataJSON : JSONBase
  {
    private bool flagHasName;
    private string storeName;
    private bool flagHasSpokenName;
    private string storeSpokenName;
    private bool flagHasWrittenName;
    private string storeWrittenName;
    private bool flagHasDescription;
    private string storeDescription;
    private bool flagHasSpokenDescription;
    private string storeSpokenDescription;
    private bool flagHasWrittenDescription;
    private string storeWrittenDescription;
    private bool flagHasPercentage;
    private sbyte storePercentage;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of PercentageBasedWeatherDataJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONSpokenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenName of PercentageBasedWeatherDataJSON is not a string.");
        setSpokenName(json_string.getData());
      }


    private void  fromJSONWrittenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenName of PercentageBasedWeatherDataJSON is not a string.");
        setWrittenName(json_string.getData());
      }


    private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Description of PercentageBasedWeatherDataJSON is not a string.");
        setDescription(json_string.getData());
      }


    private void  fromJSONSpokenDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenDescription of PercentageBasedWeatherDataJSON is not a string.");
        setSpokenDescription(json_string.getData());
      }


    private void  fromJSONWrittenDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenDescription of PercentageBasedWeatherDataJSON is not a string.");
        setWrittenDescription(json_string.getData());
      }


    private void  fromJSONPercentage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Percentage of PercentageBasedWeatherDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Percentage of PercentageBasedWeatherDataJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setPercentage(extracted_integer);
      }


    public PercentageBasedWeatherDataJSON()
      {
        flagHasName = false;
        flagHasSpokenName = false;
        flagHasWrittenName = false;
        flagHasDescription = false;
        flagHasSpokenDescription = false;
        flagHasWrittenDescription = false;
        flagHasPercentage = false;
      }

    public abstract string getKey();
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

    public bool  hasWrittenName()
      {
        return flagHasWrittenName;
      }

    public string  getWrittenName()
      {
        Debug.Assert(flagHasWrittenName);
        return storeWrittenName;
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

    public bool  hasSpokenDescription()
      {
        return flagHasSpokenDescription;
      }

    public string  getSpokenDescription()
      {
        Debug.Assert(flagHasSpokenDescription);
        return storeSpokenDescription;
      }

    public bool  hasWrittenDescription()
      {
        return flagHasWrittenDescription;
      }

    public string  getWrittenDescription()
      {
        Debug.Assert(flagHasWrittenDescription);
        return storeWrittenDescription;
      }

    public bool  hasPercentage()
      {
        return flagHasPercentage;
      }

    public sbyte  getPercentage()
      {
        Debug.Assert(flagHasPercentage);
        return storePercentage;
      }


    public abstract int extraPercentageBasedWeatherDataComponentCount();
    public abstract string extraPercentageBasedWeatherDataComponentKey(int component_num);
    public abstract JSONValue extraPercentageBasedWeatherDataComponentValue(int component_num);
    public abstract JSONValue extraPercentageBasedWeatherDataLookup(string field_name);

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
    public void setWrittenName(string new_value)
      {
        flagHasWrittenName = true;
        storeWrittenName = new_value;
      }
    public void unsetWrittenName()
      {
        flagHasWrittenName = false;
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
    public void setSpokenDescription(string new_value)
      {
        flagHasSpokenDescription = true;
        storeSpokenDescription = new_value;
      }
    public void unsetSpokenDescription()
      {
        flagHasSpokenDescription = false;
      }
    public void setWrittenDescription(string new_value)
      {
        flagHasWrittenDescription = true;
        storeWrittenDescription = new_value;
      }
    public void unsetWrittenDescription()
      {
        flagHasWrittenDescription = false;
      }
    public void setPercentage(sbyte new_value)
      {
        flagHasPercentage = true;
        if (new_value < 0)
            throw new Exception("The value for field Percentage of PercentageBasedWeatherDataJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field Percentage of PercentageBasedWeatherDataJSON is greater than the upper bound (100) for that field.");
        storePercentage = new_value;
      }
    public void unsetPercentage()
      {
        flagHasPercentage = false;
      }

    public abstract void extraPercentageBasedWeatherDataAppendPair(string key, JSONValue new_component);
    public abstract void extraPercentageBasedWeatherDataSetField(string key, JSONValue new_component);

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
        handler.pair("Key", getKey());
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
        if (flagHasWrittenName)
          {
            handler.start_pair("WrittenName");
            handler.string_value(storeWrittenName);
          }
        if (flagHasDescription)
          {
            handler.start_pair("Description");
            handler.string_value(storeDescription);
          }
        if (flagHasSpokenDescription)
          {
            handler.start_pair("SpokenDescription");
            handler.string_value(storeSpokenDescription);
          }
        if (flagHasWrittenDescription)
          {
            handler.start_pair("WrittenDescription");
            handler.string_value(storeWrittenDescription);
          }
        Debug.Assert(partial_allowed || flagHasPercentage);
        if (flagHasPercentage)
          {
            handler.start_pair("Percentage");
            handler.number_value(storePercentage);
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
        if (!(hasName()))
          {
            return "When parsing the object for %what%, the \"Name\" field was missing.";
          }
        if (!(hasPercentage()))
          {
            return "When parsing the object for %what%, the \"Percentage\" field was missing.";
          }
        return null;
      }

    public static PercentageBasedWeatherDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PercentageBasedWeatherDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PercentageBasedWeatherData", ignore_extras);
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
    public static PercentageBasedWeatherDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PercentageBasedWeatherDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PercentageBasedWeatherDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PercentageBasedWeatherData", ignore_extras);
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
    public static PercentageBasedWeatherDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PercentageBasedWeatherDataJSON from_text(string text, bool ignore_extras)
      {
        PercentageBasedWeatherDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PercentageBasedWeatherData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PercentageBasedWeatherDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static PercentageBasedWeatherDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PercentageBasedWeatherDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PercentageBasedWeatherData", ignore_extras);
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
        private JSONHoldingStringGenerator fieldGeneratorWrittenName;
        private JSONHoldingStringGenerator fieldGeneratorDescription;
        private JSONHoldingStringGenerator fieldGeneratorSpokenDescription;
        private JSONHoldingStringGenerator fieldGeneratorWrittenDescription;
    private class FieldHoldingGeneratorPercentage : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorPercentage(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPercentage : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPercentage(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorPercentage fieldGeneratorPercentage;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `Key' field is missing.");
            PercentageBasedWeatherDataJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPercentageBasedWeatherDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getPercentageBasedWeatherDataJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `Key' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(PercentageBasedWeatherDataJSON result)
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
            if (fieldGeneratorWrittenName.have_value)
              {
                result.setWrittenName(fieldGeneratorWrittenName.value);
                fieldGeneratorWrittenName.have_value = false;
              }
            if (fieldGeneratorDescription.have_value)
              {
                result.setDescription(fieldGeneratorDescription.value);
                fieldGeneratorDescription.have_value = false;
              }
            if (fieldGeneratorSpokenDescription.have_value)
              {
                result.setSpokenDescription(fieldGeneratorSpokenDescription.value);
                fieldGeneratorSpokenDescription.have_value = false;
              }
            if (fieldGeneratorWrittenDescription.have_value)
              {
                result.setWrittenDescription(fieldGeneratorWrittenDescription.value);
                fieldGeneratorWrittenDescription.have_value = false;
              }
            if (fieldGeneratorPercentage.have_value)
              {
                result.setPercentage((sbyte)(fieldGeneratorPercentage.value));
                fieldGeneratorPercentage.have_value = false;
              }
            else if ((!(result.hasPercentage())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Percentage\" field was missing.");
              }
          }
        protected abstract void handle_result(PercentageBasedWeatherDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDescription;
                    break;
                case 'K':
                    if ((String.Compare(field_name, 1, "ey", 0, 2, false) == 0) && (field_name.Length == 3))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ercentage", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorPercentage;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "poken", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 7, "escription", 0, 10, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorSpokenDescription;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 7, "ame", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorSpokenName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "ritten", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 8, "escription", 0, 10, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorWrittenDescription;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 8, "ame", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorWrittenName;
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
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the PercentageBasedWeatherData class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the PercentageBasedWeatherData class");
            fieldGeneratorWrittenName = new JSONHoldingStringGenerator("field \"WrittenName\" of the PercentageBasedWeatherData class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the PercentageBasedWeatherData class");
            fieldGeneratorSpokenDescription = new JSONHoldingStringGenerator("field \"SpokenDescription\" of the PercentageBasedWeatherData class");
            fieldGeneratorWrittenDescription = new JSONHoldingStringGenerator("field \"WrittenDescription\" of the PercentageBasedWeatherData class");
            fieldGeneratorPercentage = new FieldHoldingGeneratorPercentage("field \"Percentage\" of the PercentageBasedWeatherData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"Key\" of the PercentageBasedWeatherData class");
            set_what("the PercentageBasedWeatherData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the PercentageBasedWeatherData class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the PercentageBasedWeatherData class");
            fieldGeneratorWrittenName = new JSONHoldingStringGenerator("field \"WrittenName\" of the PercentageBasedWeatherData class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the PercentageBasedWeatherData class");
            fieldGeneratorSpokenDescription = new JSONHoldingStringGenerator("field \"SpokenDescription\" of the PercentageBasedWeatherData class");
            fieldGeneratorWrittenDescription = new JSONHoldingStringGenerator("field \"WrittenDescription\" of the PercentageBasedWeatherData class");
            fieldGeneratorPercentage = new FieldHoldingGeneratorPercentage("field \"Percentage\" of the PercentageBasedWeatherData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"Key\" of the PercentageBasedWeatherData class");
            set_what("the PercentageBasedWeatherData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorSpokenName.reset();
            fieldGeneratorWrittenName.reset();
            fieldGeneratorDescription.reset();
            fieldGeneratorSpokenDescription.reset();
            fieldGeneratorWrittenDescription.reset();
            fieldGeneratorPercentage.reset();
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
        protected override void handle_result(PercentageBasedWeatherDataJSON  result)
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
        public PercentageBasedWeatherDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PercentageBasedWeatherDataJSON  result)
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
    protected virtual void handle_result(List<PercentageBasedWeatherDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PercentageBasedWeatherDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PercentageBasedWeatherDataJSON>();
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
    public List<PercentageBasedWeatherDataJSON> value;
  };
    class GenericPercentageBasedWeatherDataJSON : PercentageBasedWeatherDataJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericPercentageBasedWeatherDataJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getKey()  { return key; }
        public override int extraPercentageBasedWeatherDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraPercentageBasedWeatherDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraPercentageBasedWeatherDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraPercentageBasedWeatherDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraPercentageBasedWeatherDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraPercentageBasedWeatherDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraPercentageBasedWeatherDataLookup(key);
            if (old_field == null)
              {
                extraPercentageBasedWeatherDataAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static PercentageBasedWeatherDataJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "chanceof", 0, 8, false) == 0)
      {
        switch (key[8])
          {
            case 's':
                if ((String.Compare(key, 9, "nowday", 0, 6, false) == 0) && (key.Length == 15))
                    return new SnowPercentageBasedWeatherDataJSON();
                break;
            case 'w':
                if ((String.Compare(key, 9, "indyday", 0, 7, false) == 0) && (key.Length == 16))
                    return new WindPercentageBasedWeatherDataJSON();
                break;
            default:
                break;
          }
      }

        return new GenericPercentageBasedWeatherDataJSON(key);
      }
  };
