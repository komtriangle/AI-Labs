/* file "RememberUserLocationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RememberUserLocationNuggetJSON : UserMemoryNuggetJSON
  {
    private bool flagHasIsOwned;
    private bool storeIsOwned;
    private bool flagHasWhat;
    private string storeWhat;
    private bool flagHasSpecialLocation;
    private UserMemorySpecialLocationJSON  storeSpecialLocation;
    private bool flagHasLocation;
    private MapLocationJSON  storeLocation;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraIsOwnedToJSON()
      {
        JSONValue generated_boolean_IsOwned = (storeIsOwned ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsOwned;
      }

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

    private JSONValue  extraLocationToJSON()
      {
        JSONValueHandler handler_Location = new JSONValueHandler();
        storeLocation.write_as_json(handler_Location);
        return handler_Location.result;
      }


    private void  fromJSONIsOwned(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field IsOwned of RememberUserLocationNuggetJSON is not true for false.");
              }
          }
        setIsOwned(the_bool);
      }


    private void  fromJSONWhat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field What of RememberUserLocationNuggetJSON is not a string.");
        setWhat(json_string.getData());
      }


    private void  fromJSONSpecialLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UserMemorySpecialLocationJSON convert_classy = UserMemorySpecialLocationJSON.from_json(json_value, ignore_extras, true);
        setSpecialLocation(convert_classy);
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setLocation(convert_classy);
      }


    public RememberUserLocationNuggetJSON()
      {
        flagHasIsOwned = false;
        flagHasWhat = false;
        flagHasSpecialLocation = false;
        flagHasLocation = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getUserMemoryNuggetKind()
      {
        return "RememberUserLocation";
      }

    public bool  hasIsOwned()
      {
        return flagHasIsOwned;
      }

    public bool  getIsOwned()
      {
        Debug.Assert(flagHasIsOwned);
        return storeIsOwned;
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

    public bool  hasLocation()
      {
        return flagHasLocation;
      }

    public MapLocationJSON   getLocation()
      {
        Debug.Assert(flagHasLocation);
        return storeLocation;
      }


    public virtual int extraRememberUserLocationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRememberUserLocationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRememberUserLocationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRememberUserLocationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUserMemoryNuggetComponentCount()
      {
        int result = 0;
        if (flagHasIsOwned)
            ++result;
        if (flagHasWhat)
            ++result;
        if (flagHasSpecialLocation)
            ++result;
        if (flagHasLocation)
            ++result;
        result += extraRememberUserLocationNuggetComponentCount();
        return result;
      }
    public override string extraUserMemoryNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasIsOwned)
          {
            if (remainder == 0)
                return "IsOwned";
            --remainder;
          }
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
        if (flagHasLocation)
          {
            if (remainder == 0)
                return "Location";
            --remainder;
          }
        return extraRememberUserLocationNuggetComponentKey(remainder);
      }
    public override JSONValue extraUserMemoryNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasIsOwned)
          {
            if (remainder == 0)
                return extraIsOwnedToJSON();
            --remainder;
          }
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
        if (flagHasLocation)
          {
            if (remainder == 0)
                return extraLocationToJSON();
            --remainder;
          }
        return extraRememberUserLocationNuggetComponentValue(remainder);
      }
    public override JSONValue extraUserMemoryNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'I':
                if ((String.Compare(field_name, 1, "sOwned", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasIsOwned ? extraIsOwnedToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasLocation ? extraLocationToJSON() : null);
                break;
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
        return extraRememberUserLocationNuggetLookup(field_name);
      }

    public void setIsOwned(bool new_value)
      {
        flagHasIsOwned = true;
        storeIsOwned = new_value;
      }
    public void unsetIsOwned()
      {
        flagHasIsOwned = false;
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
    public void setLocation(MapLocationJSON  new_value)
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = true;
        storeLocation = new_value;
      }
    public void unsetLocation()
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = false;
      }

    public virtual void extraRememberUserLocationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRememberUserLocationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRememberUserLocationNuggetLookup(key);
        if (old_field == null)
          {
            extraRememberUserLocationNuggetAppendPair(key, new_component);
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
            case 'I':
                if ((String.Compare(key, 1, "sOwned", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONIsOwned(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONLocation(new_component, false);
                    return;
                    }
                break;
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
        extraRememberUserLocationNuggetAppendPair(key, new_component);
      }
    public override void extraUserMemoryNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "sOwned", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONIsOwned(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONLocation(new_component, false);
                    return;
                    }
                break;
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
        extraRememberUserLocationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasIsOwned);
        if (flagHasIsOwned)
          {
            handler.start_pair("IsOwned");
            handler.boolean_value(storeIsOwned);
          }
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
        Debug.Assert(partial_allowed || flagHasLocation);
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            if (partial_allowed)
                storeLocation.write_partial_as_json(handler);
            else
                storeLocation.write_as_json(handler);
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
        if (!(hasIsOwned()))
          {
            return "When parsing the object for %what%, the \"IsOwned\" field was missing.";
          }
        if (!(hasWhat()))
          {
            return "When parsing the object for %what%, the \"What\" field was missing.";
          }
        if (!(hasLocation()))
          {
            return "When parsing the object for %what%, the \"Location\" field was missing.";
          }
        return null;
      }

    public static new RememberUserLocationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RememberUserLocationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RememberUserLocationNugget", ignore_extras);
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
    public static new RememberUserLocationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RememberUserLocationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RememberUserLocationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RememberUserLocationNugget", ignore_extras);
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
    public static new RememberUserLocationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RememberUserLocationNuggetJSON from_text(string text, bool ignore_extras)
      {
        RememberUserLocationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RememberUserLocationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RememberUserLocationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RememberUserLocationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RememberUserLocationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RememberUserLocationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UserMemoryNuggetJSON.Generator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorIsOwned;
        private JSONHoldingStringGenerator fieldGeneratorWhat;
        private UserMemorySpecialLocationJSON.HoldingGenerator fieldGeneratorSpecialLocation;
        private MapLocationJSON.HoldingGenerator fieldGeneratorLocation;
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
            if (!(getUserMemoryNuggetJSONKey().Equals("RememberUserLocation")))
                throw new Exception("The key field has a value other than `RememberUserLocation'.");
            RememberUserLocationNuggetJSON result = new RememberUserLocationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRememberUserLocationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UserMemoryNuggetJSON new_result)
          {
            handle_result((RememberUserLocationNuggetJSON )new_result);
          }
        protected void finish(RememberUserLocationNuggetJSON result)
          {
            if (fieldGeneratorIsOwned.have_value)
              {
                result.setIsOwned(fieldGeneratorIsOwned.value);
                fieldGeneratorIsOwned.have_value = false;
              }
            else if ((!(result.hasIsOwned())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsOwned\" field was missing.");
              }
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
            if (fieldGeneratorLocation.have_value)
              {
                result.setLocation(fieldGeneratorLocation.value);
                fieldGeneratorLocation.have_value = false;
              }
            else if ((!(result.hasLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Location\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RememberUserLocationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "sOwned", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorIsOwned;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
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
            fieldGeneratorIsOwned = new JSONHoldingBooleanGenerator("field \"IsOwned\" of the RememberUserLocationNugget class");
            fieldGeneratorWhat = new JSONHoldingStringGenerator("field \"What\" of the RememberUserLocationNugget class");
            fieldGeneratorSpecialLocation = new UserMemorySpecialLocationJSON.HoldingGenerator("field \"SpecialLocation\" of the RememberUserLocationNugget class", ignore_extras);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the RememberUserLocationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RememberUserLocationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorIsOwned = new JSONHoldingBooleanGenerator("field \"IsOwned\" of the RememberUserLocationNugget class");
            fieldGeneratorWhat = new JSONHoldingStringGenerator("field \"What\" of the RememberUserLocationNugget class");
            fieldGeneratorSpecialLocation = new UserMemorySpecialLocationJSON.HoldingGenerator("field \"SpecialLocation\" of the RememberUserLocationNugget class", false);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the RememberUserLocationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RememberUserLocationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorIsOwned.reset();
            fieldGeneratorWhat.reset();
            fieldGeneratorSpecialLocation.reset();
            fieldGeneratorLocation.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RememberUserLocationNuggetJSON  result)
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
        public RememberUserLocationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RememberUserLocationNuggetJSON  result)
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
    protected virtual void handle_result(List<RememberUserLocationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RememberUserLocationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RememberUserLocationNuggetJSON>();
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
    public List<RememberUserLocationNuggetJSON> value;
  };
  };
