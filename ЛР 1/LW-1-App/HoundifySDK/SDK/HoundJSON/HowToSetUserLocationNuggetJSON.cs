/* file "HowToSetUserLocationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HowToSetUserLocationNuggetJSON : UserMemoryNuggetJSON
  {
    private bool flagHasWhat;
    private string storeWhat;
    private bool flagHasSpecialLocation;
    private UserMemorySpecialLocationJSON  storeSpecialLocation;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraWhatToJSON()
      {
        JSONStringValue generated_string_What = new JSONStringValue(storeWhat);
        return generated_string_What;
      }

    private JSONValue  extraSpecialLocationToJSON()
      {
        JSONValueHandler handler_SpecialLocation = new JSONValueHandler();
        storeSpecialLocation.write_as_json(handler_SpecialLocation);
        return handler_SpecialLocation.result;
      }


    private void  fromJSONWhat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field What of HowToSetUserLocationNuggetJSON is not a string.");
        setWhat(json_string.getData());
      }


    private void  fromJSONSpecialLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UserMemorySpecialLocationJSON convert_classy = UserMemorySpecialLocationJSON.from_json(json_value, ignore_extras, true);
        setSpecialLocation(convert_classy);
      }


    public HowToSetUserLocationNuggetJSON()
      {
        flagHasWhat = false;
        flagHasSpecialLocation = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getUserMemoryNuggetKind()
      {
        return "HowToSetUserLocation";
      }

    public bool  hasWhat()
      {
        return flagHasWhat;
      }

    public string  getWhat()
      {
        Debug.Assert(flagHasWhat);
        return storeWhat;
      }

    public bool  hasSpecialLocation()
      {
        return flagHasSpecialLocation;
      }

    public UserMemorySpecialLocationJSON   getSpecialLocation()
      {
        Debug.Assert(flagHasSpecialLocation);
        return storeSpecialLocation;
      }

    public UserMemorySpecialLocationJSON.TypeValue  getSpecialLocationValue()
      {
        return getSpecialLocation().getValue();
      }

    public string  getSpecialLocationAsString()
      {
        return getSpecialLocation().getValueAsString();
      }


    public virtual int extraHowToSetUserLocationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHowToSetUserLocationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHowToSetUserLocationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHowToSetUserLocationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUserMemoryNuggetComponentCount()
      {
        int result = 0;
        if (flagHasWhat)
            ++result;
        if (flagHasSpecialLocation)
            ++result;
        result += extraHowToSetUserLocationNuggetComponentCount();
        return result;
      }
    public override string extraUserMemoryNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasWhat)
          {
            if (remainder == 0)
                return "What";
            --remainder;
          }
        if (flagHasSpecialLocation)
          {
            if (remainder == 0)
                return "SpecialLocation";
            --remainder;
          }
        return extraHowToSetUserLocationNuggetComponentKey(remainder);
      }
    public override JSONValue extraUserMemoryNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasWhat)
          {
            if (remainder == 0)
                return extraWhatToJSON();
            --remainder;
          }
        if (flagHasSpecialLocation)
          {
            if (remainder == 0)
                return extraSpecialLocationToJSON();
            --remainder;
          }
        return extraHowToSetUserLocationNuggetComponentValue(remainder);
      }
    public override JSONValue extraUserMemoryNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'S':
                if ((String.Compare(field_name, 1, "pecialLocation", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasSpecialLocation ? extraSpecialLocationToJSON() : null);
                break;
            case 'W':
                if ((String.Compare(field_name, 1, "hat", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasWhat ? extraWhatToJSON() : null);
                break;
            default:
                break;
          }
        return extraHowToSetUserLocationNuggetLookup(field_name);
      }

    public void setWhat(string new_value)
      {
        flagHasWhat = true;
        storeWhat = new_value;
      }
    public void unsetWhat()
      {
        flagHasWhat = false;
      }
    public void setSpecialLocation(UserMemorySpecialLocationJSON  new_value)
      {
        if (flagHasSpecialLocation)
          {
          }
        flagHasSpecialLocation = true;
        storeSpecialLocation = new_value;
      }
    public void setSpecialLocation(UserMemorySpecialLocationJSON.TypeValue new_value)
      {
        setSpecialLocation(new UserMemorySpecialLocationJSON(new_value));
      }
    public void setSpecialLocation(string chars)
      {
        UserMemorySpecialLocationJSON.TypeValueKnownValues known = UserMemorySpecialLocationJSON.stringToValue(chars);
        UserMemorySpecialLocationJSON.TypeValue new_value = new UserMemorySpecialLocationJSON.TypeValue();
        if (known == UserMemorySpecialLocationJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSpecialLocation(new_value);
      }
    public void unsetSpecialLocation()
      {
        if (flagHasSpecialLocation)
          {
          }
        flagHasSpecialLocation = false;
      }

    public virtual void extraHowToSetUserLocationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHowToSetUserLocationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHowToSetUserLocationNuggetLookup(key);
        if (old_field == null)
          {
            extraHowToSetUserLocationNuggetAppendPair(key, new_component);
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
    public override void extraUserMemoryNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'S':
                if ((String.Compare(key, 1, "pecialLocation", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONSpecialLocation(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if ((String.Compare(key, 1, "hat", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONWhat(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraHowToSetUserLocationNuggetAppendPair(key, new_component);
      }
    public override void extraUserMemoryNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'S':
                if ((String.Compare(key, 1, "pecialLocation", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONSpecialLocation(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if ((String.Compare(key, 1, "hat", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONWhat(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraHowToSetUserLocationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasWhat);
        if (flagHasWhat)
          {
            handler.start_pair("What");
            handler.string_value(storeWhat);
          }
        if (flagHasSpecialLocation)
          {
            handler.start_pair("SpecialLocation");
            if (partial_allowed)
                storeSpecialLocation.write_partial_as_json(handler);
            else
                storeSpecialLocation.write_as_json(handler);
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
        if (!(hasWhat()))
          {
            return "When parsing the object for %what%, the \"What\" field was missing.";
          }
        return null;
      }

    public static new HowToSetUserLocationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HowToSetUserLocationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HowToSetUserLocationNugget", ignore_extras);
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
    public static new HowToSetUserLocationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HowToSetUserLocationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HowToSetUserLocationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HowToSetUserLocationNugget", ignore_extras);
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
    public static new HowToSetUserLocationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HowToSetUserLocationNuggetJSON from_text(string text, bool ignore_extras)
      {
        HowToSetUserLocationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HowToSetUserLocationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HowToSetUserLocationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HowToSetUserLocationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HowToSetUserLocationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HowToSetUserLocationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UserMemoryNuggetJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorWhat;
        private UserMemorySpecialLocationJSON.HoldingGenerator fieldGeneratorSpecialLocation;
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
            if (!(getUserMemoryNuggetJSONKey().Equals("HowToSetUserLocation")))
                throw new Exception("The key field has a value other than `HowToSetUserLocation'.");
            HowToSetUserLocationNuggetJSON result = new HowToSetUserLocationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHowToSetUserLocationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UserMemoryNuggetJSON new_result)
          {
            handle_result((HowToSetUserLocationNuggetJSON )new_result);
          }
        protected void finish(HowToSetUserLocationNuggetJSON result)
          {
            if (fieldGeneratorWhat.have_value)
              {
                result.setWhat(fieldGeneratorWhat.value);
                fieldGeneratorWhat.have_value = false;
              }
            else if ((!(result.hasWhat())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"What\" field was missing.");
              }
            if (fieldGeneratorSpecialLocation.have_value)
              {
                result.setSpecialLocation(fieldGeneratorSpecialLocation.value);
                fieldGeneratorSpecialLocation.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(HowToSetUserLocationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'S':
                    if ((String.Compare(field_name, 1, "pecialLocation", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorSpecialLocation;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "hat", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorWhat;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorWhat = new JSONHoldingStringGenerator("field \"What\" of the HowToSetUserLocationNugget class");
            fieldGeneratorSpecialLocation = new UserMemorySpecialLocationJSON.HoldingGenerator("field \"SpecialLocation\" of the HowToSetUserLocationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HowToSetUserLocationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorWhat = new JSONHoldingStringGenerator("field \"What\" of the HowToSetUserLocationNugget class");
            fieldGeneratorSpecialLocation = new UserMemorySpecialLocationJSON.HoldingGenerator("field \"SpecialLocation\" of the HowToSetUserLocationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HowToSetUserLocationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorWhat.reset();
            fieldGeneratorSpecialLocation.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(HowToSetUserLocationNuggetJSON  result)
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
        public HowToSetUserLocationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HowToSetUserLocationNuggetJSON  result)
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
    protected virtual void handle_result(List<HowToSetUserLocationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HowToSetUserLocationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HowToSetUserLocationNuggetJSON>();
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
    public List<HowToSetUserLocationNuggetJSON> value;
  };
  };
