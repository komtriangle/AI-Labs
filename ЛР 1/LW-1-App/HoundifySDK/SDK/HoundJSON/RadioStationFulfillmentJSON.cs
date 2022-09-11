/* file "RadioStationFulfillmentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RadioStationFulfillmentJSON : JSONBase
  {
    public enum TypeTypeKnownValues
      {
        Type_Stream,
        Type_Satellite,
        Type_Terrestrial,
        Type__none
      };
    public struct TypeType
      {
        public bool in_known_list;
        public string string_value;
        public TypeTypeKnownValues list_value;
      };

    public static TypeTypeKnownValues  stringToType(string chars)
      {
        switch (chars[0])
          {
            case 'S':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "tellite", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeTypeKnownValues.Type_Satellite;
                        break;
                    case 't':
                        if ((String.Compare(chars, 2, "ream", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeTypeKnownValues.Type_Stream;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(chars, 1, "errestrial", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeTypeKnownValues.Type_Terrestrial;
                break;
            default:
                break;
          }
        return TypeTypeKnownValues.Type__none;
      }

    public static string  stringFromType(TypeTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeTypeKnownValues.Type_Stream:
                return "Stream";
            case TypeTypeKnownValues.Type_Satellite:
                return "Satellite";
            case TypeTypeKnownValues.Type_Terrestrial:
                return "Terrestrial";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasType;
    private TypeType storeType;
    private bool flagHasEncoding;
    private StreamEncodingEnumJSON  storeEncoding;
    private bool flagHasURL;
    private string storeURL;
    private bool flagHasTerrestrialTuningTarget;
    private TerrestrialTuningTargetJSON  storeTerrestrialTuningTarget;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Type of RadioStationFulfillmentJSON is not a string.");
        TypeType the_open_enum = new TypeType();
        switch (json_string.getData()[0])
          {
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "tellite", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTypeKnownValues.Type_Satellite;
                                goto open_enum_is_done;
                              }
                        break;
                    case 't':
                        if ((String.Compare(json_string.getData(), 2, "ream", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTypeKnownValues.Type_Stream;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "errestrial", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_Terrestrial;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setType(the_open_enum);
      }


    private void  fromJSONEncoding(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StreamEncodingEnumJSON convert_classy = StreamEncodingEnumJSON.from_json(json_value, ignore_extras, true);
        setEncoding(convert_classy);
      }


    private void  fromJSONURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field URL of RadioStationFulfillmentJSON is not a string.");
        setURL(json_string.getData());
      }


    private void  fromJSONTerrestrialTuningTarget(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TerrestrialTuningTargetJSON convert_classy = TerrestrialTuningTargetJSON.from_json(json_value, ignore_extras, true);
        setTerrestrialTuningTarget(convert_classy);
      }


    public RadioStationFulfillmentJSON()
      {
        flagHasType = false;
        flagHasEncoding = false;
        flagHasURL = false;
        flagHasTerrestrialTuningTarget = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public TypeType  getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public string  getTypeAsString()
      {
        TypeType result = getType();
        if (result.in_known_list)
            return stringFromType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasEncoding()
      {
        return flagHasEncoding;
      }

    public StreamEncodingEnumJSON   getEncoding()
      {
        Debug.Assert(flagHasEncoding);
        return storeEncoding;
      }

    public StreamEncodingEnumJSON.TypeValue  getEncodingValue()
      {
        return getEncoding().getValue();
      }

    public string  getEncodingAsString()
      {
        return getEncoding().getValueAsString();
      }

    public bool  hasURL()
      {
        return flagHasURL;
      }

    public string  getURL()
      {
        Debug.Assert(flagHasURL);
        return storeURL;
      }

    public bool  hasTerrestrialTuningTarget()
      {
        return flagHasTerrestrialTuningTarget;
      }

    public TerrestrialTuningTargetJSON   getTerrestrialTuningTarget()
      {
        Debug.Assert(flagHasTerrestrialTuningTarget);
        return storeTerrestrialTuningTarget;
      }


    public virtual int extraRadioStationFulfillmentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRadioStationFulfillmentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRadioStationFulfillmentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRadioStationFulfillmentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setType(TypeType new_value)
      {
        flagHasType = true;
        storeType = new_value;
      }
    public void setType(string chars)
      {
        TypeTypeKnownValues known = stringToType(chars);
        TypeType new_value = new TypeType();
        if (known == TypeTypeKnownValues.Type__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setType(new_value);
      }
    public void setType(TypeTypeKnownValues new_value)
      {
        TypeType new_full_value = new TypeType();
        Debug.Assert(new_value != TypeTypeKnownValues.Type__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setType(new_full_value);
      }
    public void unsetType()
      {
        flagHasType = false;
      }
    public void setEncoding(StreamEncodingEnumJSON  new_value)
      {
        if (flagHasEncoding)
          {
          }
        flagHasEncoding = true;
        storeEncoding = new_value;
      }
    public void setEncoding(StreamEncodingEnumJSON.TypeValue new_value)
      {
        setEncoding(new StreamEncodingEnumJSON(new_value));
      }
    public void setEncoding(string chars)
      {
        StreamEncodingEnumJSON.TypeValueKnownValues known = StreamEncodingEnumJSON.stringToValue(chars);
        StreamEncodingEnumJSON.TypeValue new_value = new StreamEncodingEnumJSON.TypeValue();
        if (known == StreamEncodingEnumJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setEncoding(new_value);
      }
    public void unsetEncoding()
      {
        if (flagHasEncoding)
          {
          }
        flagHasEncoding = false;
      }
    public void setURL(string new_value)
      {
        flagHasURL = true;
        storeURL = new_value;
      }
    public void unsetURL()
      {
        flagHasURL = false;
      }
    public void setTerrestrialTuningTarget(TerrestrialTuningTargetJSON  new_value)
      {
        if (flagHasTerrestrialTuningTarget)
          {
          }
        flagHasTerrestrialTuningTarget = true;
        storeTerrestrialTuningTarget = new_value;
      }
    public void unsetTerrestrialTuningTarget()
      {
        if (flagHasTerrestrialTuningTarget)
          {
          }
        flagHasTerrestrialTuningTarget = false;
      }

    public virtual void extraRadioStationFulfillmentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRadioStationFulfillmentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRadioStationFulfillmentLookup(key);
        if (old_field == null)
          {
            extraRadioStationFulfillmentAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasType);
        if (flagHasType)
          {
            handler.start_pair("Type");
            if (storeType.in_known_list)
              {
                switch (storeType.list_value)
                  {
                    case TypeTypeKnownValues.Type_Stream:
                        handler.string_value("Stream");
                        break;
                    case TypeTypeKnownValues.Type_Satellite:
                        handler.string_value("Satellite");
                        break;
                    case TypeTypeKnownValues.Type_Terrestrial:
                        handler.string_value("Terrestrial");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeType.string_value);
              }
          }
        if (flagHasEncoding)
          {
            handler.start_pair("Encoding");
            if (partial_allowed)
                storeEncoding.write_partial_as_json(handler);
            else
                storeEncoding.write_as_json(handler);
          }
        if (flagHasURL)
          {
            handler.start_pair("URL");
            handler.string_value(storeURL);
          }
        if (flagHasTerrestrialTuningTarget)
          {
            handler.start_pair("TerrestrialTuningTarget");
            if (partial_allowed)
                storeTerrestrialTuningTarget.write_partial_as_json(handler);
            else
                storeTerrestrialTuningTarget.write_as_json(handler);
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
        if (!(hasType()))
          {
            return "When parsing the object for %what%, the \"Type\" field was missing.";
          }
        return null;
      }

    public static RadioStationFulfillmentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioStationFulfillmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioStationFulfillment", ignore_extras);
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
    public static RadioStationFulfillmentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RadioStationFulfillmentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioStationFulfillmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioStationFulfillment", ignore_extras);
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
    public static RadioStationFulfillmentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RadioStationFulfillmentJSON from_text(string text, bool ignore_extras)
      {
        RadioStationFulfillmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioStationFulfillment", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RadioStationFulfillmentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RadioStationFulfillmentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RadioStationFulfillmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioStationFulfillment", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorType : JSONStringGenerator
          {
            protected FieldGeneratorType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeTypeKnownValues known = stringToType(result);
                TypeType new_value = new TypeType();
                if (known == TypeTypeKnownValues.Type__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeType result);
          };
    private class FieldHoldingGeneratorType : FieldGeneratorType
  {
    protected override void handle_result(TypeType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorType(String what)
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
    public TypeType value;
  };
    private class FieldHoldingArrayGeneratorType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorType
      {
        private FieldHoldingArrayGeneratorType top;

        protected override void handle_result(TypeType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorType init_top)
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
    protected virtual void handle_result(List<TypeType> result)
      {
      }

    public FieldHoldingArrayGeneratorType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeType> value;
  };
        private FieldHoldingGeneratorType fieldGeneratorType;
        private StreamEncodingEnumJSON.HoldingGenerator fieldGeneratorEncoding;
        private JSONHoldingStringGenerator fieldGeneratorURL;
        private TerrestrialTuningTargetJSON.HoldingGenerator fieldGeneratorTerrestrialTuningTarget;
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
            RadioStationFulfillmentJSON result = new RadioStationFulfillmentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRadioStationFulfillmentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RadioStationFulfillmentJSON result)
          {
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
            else if ((!(result.hasType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Type\" field was missing.");
              }
            if (fieldGeneratorEncoding.have_value)
              {
                result.setEncoding(fieldGeneratorEncoding.value);
                fieldGeneratorEncoding.have_value = false;
              }
            if (fieldGeneratorURL.have_value)
              {
                result.setURL(fieldGeneratorURL.value);
                fieldGeneratorURL.have_value = false;
              }
            if (fieldGeneratorTerrestrialTuningTarget.have_value)
              {
                result.setTerrestrialTuningTarget(fieldGeneratorTerrestrialTuningTarget.value);
                fieldGeneratorTerrestrialTuningTarget.have_value = false;
              }
          }
        protected abstract void handle_result(RadioStationFulfillmentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "ncoding", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorEncoding;
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "rrestrialTuningTarget", 0, 21, false) == 0) && (field_name.Length == 23))
                                return fieldGeneratorTerrestrialTuningTarget;
                            break;
                        case 'y':
                            if ((String.Compare(field_name, 2, "pe", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorType;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "RL", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorURL;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the RadioStationFulfillment class");
            fieldGeneratorEncoding = new StreamEncodingEnumJSON.HoldingGenerator("field \"Encoding\" of the RadioStationFulfillment class", ignore_extras);
            fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the RadioStationFulfillment class");
            fieldGeneratorTerrestrialTuningTarget = new TerrestrialTuningTargetJSON.HoldingGenerator("field \"TerrestrialTuningTarget\" of the RadioStationFulfillment class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RadioStationFulfillment class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the RadioStationFulfillment class");
            fieldGeneratorEncoding = new StreamEncodingEnumJSON.HoldingGenerator("field \"Encoding\" of the RadioStationFulfillment class", false);
            fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the RadioStationFulfillment class");
            fieldGeneratorTerrestrialTuningTarget = new TerrestrialTuningTargetJSON.HoldingGenerator("field \"TerrestrialTuningTarget\" of the RadioStationFulfillment class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RadioStationFulfillment class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorType.reset();
            fieldGeneratorEncoding.reset();
            fieldGeneratorURL.reset();
            fieldGeneratorTerrestrialTuningTarget.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorEncoding.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTerrestrialTuningTarget.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorEncoding.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTerrestrialTuningTarget.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RadioStationFulfillmentJSON  result)
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
        public RadioStationFulfillmentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RadioStationFulfillmentJSON  result)
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
    protected virtual void handle_result(List<RadioStationFulfillmentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RadioStationFulfillmentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RadioStationFulfillmentJSON>();
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
    public List<RadioStationFulfillmentJSON> value;
  };
  };
