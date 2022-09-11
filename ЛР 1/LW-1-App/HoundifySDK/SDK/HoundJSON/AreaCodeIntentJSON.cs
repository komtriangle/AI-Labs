/* file "AreaCodeIntentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class AreaCodeIntentJSON : LocationIntentJSON
  {
    private bool flagHasPhoneAreaCode;
    private BigInteger storePhoneAreaCode;
    private bool flagHasMapLocation;
    private MapLocationJSON  storeMapLocation;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraPhoneAreaCodeToJSON()
      {
        JSONIntegerValue generated_integer_PhoneAreaCode = new JSONIntegerValue(storePhoneAreaCode);
        return generated_integer_PhoneAreaCode;
      }

    private JSONValue  extraMapLocationToJSON()
      {
        JSONValueHandler handler_MapLocation = new JSONValueHandler();
        storeMapLocation.write_as_json(handler_MapLocation);
        return handler_MapLocation.result;
      }


    private void  fromJSONPhoneAreaCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PhoneAreaCode of AreaCodeIntentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PhoneAreaCode of AreaCodeIntentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPhoneAreaCode(extracted_integer);
      }


    private void  fromJSONMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setMapLocation(convert_classy);
      }


    public AreaCodeIntentJSON()
      {
        flagHasPhoneAreaCode = false;
        flagHasMapLocation = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getLocationIntentKind()
      {
        return "AreaCode";
      }

    public bool  hasPhoneAreaCode()
      {
        return flagHasPhoneAreaCode;
      }

    public BigInteger  getPhoneAreaCode()
      {
        Debug.Assert(flagHasPhoneAreaCode);
        return storePhoneAreaCode;
      }

    public bool  hasMapLocation()
      {
        return flagHasMapLocation;
      }

    public MapLocationJSON   getMapLocation()
      {
        Debug.Assert(flagHasMapLocation);
        return storeMapLocation;
      }


    public virtual int extraAreaCodeIntentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAreaCodeIntentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAreaCodeIntentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAreaCodeIntentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraLocationIntentComponentCount()
      {
        int result = 0;
        if (flagHasPhoneAreaCode)
            ++result;
        if (flagHasMapLocation)
            ++result;
        result += extraAreaCodeIntentComponentCount();
        return result;
      }
    public override string extraLocationIntentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasPhoneAreaCode)
          {
            if (remainder == 0)
                return "PhoneAreaCode";
            --remainder;
          }
        if (flagHasMapLocation)
          {
            if (remainder == 0)
                return "MapLocation";
            --remainder;
          }
        return extraAreaCodeIntentComponentKey(remainder);
      }
    public override JSONValue extraLocationIntentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasPhoneAreaCode)
          {
            if (remainder == 0)
                return extraPhoneAreaCodeToJSON();
            --remainder;
          }
        if (flagHasMapLocation)
          {
            if (remainder == 0)
                return extraMapLocationToJSON();
            --remainder;
          }
        return extraAreaCodeIntentComponentValue(remainder);
      }
    public override JSONValue extraLocationIntentLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'M':
                if ((String.Compare(field_name, 1, "apLocation", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasMapLocation ? extraMapLocationToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "honeAreaCode", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasPhoneAreaCode ? extraPhoneAreaCodeToJSON() : null);
                break;
            default:
                break;
          }
        return extraAreaCodeIntentLookup(field_name);
      }

    public void setPhoneAreaCode(BigInteger new_value)
      {
        flagHasPhoneAreaCode = true;
        storePhoneAreaCode = new_value;
      }
    public void unsetPhoneAreaCode()
      {
        flagHasPhoneAreaCode = false;
      }
    public void setMapLocation(MapLocationJSON  new_value)
      {
        if (flagHasMapLocation)
          {
          }
        flagHasMapLocation = true;
        storeMapLocation = new_value;
      }
    public void unsetMapLocation()
      {
        if (flagHasMapLocation)
          {
          }
        flagHasMapLocation = false;
      }

    public virtual void extraAreaCodeIntentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAreaCodeIntentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAreaCodeIntentLookup(key);
        if (old_field == null)
          {
            extraAreaCodeIntentAppendPair(key, new_component);
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
    public override void extraLocationIntentAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'M':
                if ((String.Compare(key, 1, "apLocation", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONMapLocation(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "honeAreaCode", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONPhoneAreaCode(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraAreaCodeIntentAppendPair(key, new_component);
      }
    public override void extraLocationIntentSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'M':
                if ((String.Compare(key, 1, "apLocation", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONMapLocation(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "honeAreaCode", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONPhoneAreaCode(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraAreaCodeIntentSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasPhoneAreaCode);
        if (flagHasPhoneAreaCode)
          {
            handler.start_pair("PhoneAreaCode");
            handler.number_value(storePhoneAreaCode);
          }
        Debug.Assert(partial_allowed || flagHasMapLocation);
        if (flagHasMapLocation)
          {
            handler.start_pair("MapLocation");
            if (partial_allowed)
                storeMapLocation.write_partial_as_json(handler);
            else
                storeMapLocation.write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasPhoneAreaCode()))
          {
            return "When parsing the object for %what%, the \"PhoneAreaCode\" field was missing.";
          }
        if (!(hasMapLocation()))
          {
            return "When parsing the object for %what%, the \"MapLocation\" field was missing.";
          }
        return null;
      }

    public static new AreaCodeIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AreaCodeIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeIntent", ignore_extras);
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
    public static new AreaCodeIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AreaCodeIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AreaCodeIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeIntent", ignore_extras);
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
    public static new AreaCodeIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AreaCodeIntentJSON from_text(string text, bool ignore_extras)
      {
        AreaCodeIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeIntent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AreaCodeIntentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new AreaCodeIntentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AreaCodeIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeIntent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : LocationIntentJSON.Generator
      {
    private class FieldHoldingGeneratorPhoneAreaCode : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorPhoneAreaCode(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPhoneAreaCode : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPhoneAreaCode(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorPhoneAreaCode fieldGeneratorPhoneAreaCode;
        private MapLocationJSON.HoldingGenerator fieldGeneratorMapLocation;
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
            if (!(getLocationIntentJSONKey().Equals("AreaCode")))
                throw new Exception("The key field has a value other than `AreaCode'.");
            AreaCodeIntentJSON result = new AreaCodeIntentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAreaCodeIntentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(LocationIntentJSON new_result)
          {
            handle_result((AreaCodeIntentJSON )new_result);
          }
        protected void finish(AreaCodeIntentJSON result)
          {
            if (fieldGeneratorPhoneAreaCode.have_value)
              {
                result.setPhoneAreaCode(fieldGeneratorPhoneAreaCode.value);
                fieldGeneratorPhoneAreaCode.have_value = false;
              }
            else if ((!(result.hasPhoneAreaCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PhoneAreaCode\" field was missing.");
              }
            if (fieldGeneratorMapLocation.have_value)
              {
                result.setMapLocation(fieldGeneratorMapLocation.value);
                fieldGeneratorMapLocation.have_value = false;
              }
            else if ((!(result.hasMapLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MapLocation\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(AreaCodeIntentJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'M':
                    if ((String.Compare(field_name, 1, "apLocation", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMapLocation;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "honeAreaCode", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorPhoneAreaCode;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorPhoneAreaCode = new FieldHoldingGeneratorPhoneAreaCode("field \"PhoneAreaCode\" of the AreaCodeIntent class");
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the AreaCodeIntent class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AreaCodeIntent class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorPhoneAreaCode = new FieldHoldingGeneratorPhoneAreaCode("field \"PhoneAreaCode\" of the AreaCodeIntent class");
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the AreaCodeIntent class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AreaCodeIntent class");
          }

        public override void reset()
          {
            fieldGeneratorPhoneAreaCode.reset();
            fieldGeneratorMapLocation.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(AreaCodeIntentJSON  result)
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
        public AreaCodeIntentJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AreaCodeIntentJSON  result)
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
    protected virtual void handle_result(List<AreaCodeIntentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AreaCodeIntentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AreaCodeIntentJSON>();
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
    public List<AreaCodeIntentJSON> value;
  };
  };
