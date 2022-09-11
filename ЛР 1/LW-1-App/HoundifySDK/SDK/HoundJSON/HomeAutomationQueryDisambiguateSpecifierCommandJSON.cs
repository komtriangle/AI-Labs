/* file "HomeAutomationQueryDisambiguateSpecifierCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationQueryDisambiguateSpecifierCommandJSON : DisambiguateCommandJSON
  {
    private bool flagHasCompactDeviceSpecifier;
    private HomeAutomationCompactDeviceSpecifierJSON  storeCompactDeviceSpecifier;
    private bool flagHasHint;
    private HomeAutomationQueryHintJSON  storeHint;
    private bool flagHasAmbiguities;
    private HomeAutomationAmbiguityListJSON  storeAmbiguities;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCompactDeviceSpecifierToJSON()
      {
        JSONValueHandler handler_CompactDeviceSpecifier = new JSONValueHandler();
        storeCompactDeviceSpecifier.write_as_json(handler_CompactDeviceSpecifier);
        return handler_CompactDeviceSpecifier.result;
      }

    private JSONValue  extraHintToJSON()
      {
        JSONValueHandler handler_Hint = new JSONValueHandler();
        storeHint.write_as_json(handler_Hint);
        return handler_Hint.result;
      }

    private JSONValue  extraAmbiguitiesToJSON()
      {
        JSONValueHandler handler_Ambiguities = new JSONValueHandler();
        storeAmbiguities.write_as_json(handler_Ambiguities);
        return handler_Ambiguities.result;
      }


    private void  fromJSONCompactDeviceSpecifier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationCompactDeviceSpecifierJSON convert_classy = HomeAutomationCompactDeviceSpecifierJSON.from_json(json_value, ignore_extras, true);
        setCompactDeviceSpecifier(convert_classy);
      }


    private void  fromJSONHint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationQueryHintJSON convert_classy = HomeAutomationQueryHintJSON.from_json(json_value, ignore_extras, true);
        setHint(convert_classy);
      }


    private void  fromJSONAmbiguities(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationAmbiguityListJSON convert_classy = HomeAutomationAmbiguityListJSON.from_json(json_value, ignore_extras, true);
        setAmbiguities(convert_classy);
      }


    public HomeAutomationQueryDisambiguateSpecifierCommandJSON()
      {
        flagHasCompactDeviceSpecifier = false;
        flagHasHint = false;
        flagHasAmbiguities = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDisambiguateCommandKind()
      {
        return "HomeAutomationQueryDisambiguateSpecifierCommand";
      }

    public bool  hasCompactDeviceSpecifier()
      {
        return flagHasCompactDeviceSpecifier;
      }

    public HomeAutomationCompactDeviceSpecifierJSON   getCompactDeviceSpecifier()
      {
        Debug.Assert(flagHasCompactDeviceSpecifier);
        return storeCompactDeviceSpecifier;
      }

    public bool  hasHint()
      {
        return flagHasHint;
      }

    public HomeAutomationQueryHintJSON   getHint()
      {
        Debug.Assert(flagHasHint);
        return storeHint;
      }

    public bool  hasAmbiguities()
      {
        return flagHasAmbiguities;
      }

    public HomeAutomationAmbiguityListJSON   getAmbiguities()
      {
        Debug.Assert(flagHasAmbiguities);
        return storeAmbiguities;
      }


    public virtual int extraHomeAutomationQueryDisambiguateSpecifierCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationQueryDisambiguateSpecifierCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationQueryDisambiguateSpecifierCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationQueryDisambiguateSpecifierCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDisambiguateCommandComponentCount()
      {
        int result = 0;
        if (flagHasCompactDeviceSpecifier)
            ++result;
        if (flagHasHint)
            ++result;
        if (flagHasAmbiguities)
            ++result;
        result += extraHomeAutomationQueryDisambiguateSpecifierCommandComponentCount();
        return result;
      }
    public override string extraDisambiguateCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCompactDeviceSpecifier)
          {
            if (remainder == 0)
                return "CompactDeviceSpecifier";
            --remainder;
          }
        if (flagHasHint)
          {
            if (remainder == 0)
                return "Hint";
            --remainder;
          }
        if (flagHasAmbiguities)
          {
            if (remainder == 0)
                return "Ambiguities";
            --remainder;
          }
        return extraHomeAutomationQueryDisambiguateSpecifierCommandComponentKey(remainder);
      }
    public override JSONValue extraDisambiguateCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCompactDeviceSpecifier)
          {
            if (remainder == 0)
                return extraCompactDeviceSpecifierToJSON();
            --remainder;
          }
        if (flagHasHint)
          {
            if (remainder == 0)
                return extraHintToJSON();
            --remainder;
          }
        if (flagHasAmbiguities)
          {
            if (remainder == 0)
                return extraAmbiguitiesToJSON();
            --remainder;
          }
        return extraHomeAutomationQueryDisambiguateSpecifierCommandComponentValue(remainder);
      }
    public override JSONValue extraDisambiguateCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "mbiguities", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasAmbiguities ? extraAmbiguitiesToJSON() : null);
                break;
            case 'C':
                if ((String.Compare(field_name, 1, "ompactDeviceSpecifier", 0, 21, false) == 0) && (field_name.Length == 22))
                    return (flagHasCompactDeviceSpecifier ? extraCompactDeviceSpecifierToJSON() : null);
                break;
            case 'H':
                if ((String.Compare(field_name, 1, "int", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasHint ? extraHintToJSON() : null);
                break;
            default:
                break;
          }
        return extraHomeAutomationQueryDisambiguateSpecifierCommandLookup(field_name);
      }

    public void setCompactDeviceSpecifier(HomeAutomationCompactDeviceSpecifierJSON  new_value)
      {
        if (flagHasCompactDeviceSpecifier)
          {
          }
        flagHasCompactDeviceSpecifier = true;
        storeCompactDeviceSpecifier = new_value;
      }
    public void unsetCompactDeviceSpecifier()
      {
        if (flagHasCompactDeviceSpecifier)
          {
          }
        flagHasCompactDeviceSpecifier = false;
      }
    public void setHint(HomeAutomationQueryHintJSON  new_value)
      {
        if (flagHasHint)
          {
          }
        flagHasHint = true;
        storeHint = new_value;
      }
    public void unsetHint()
      {
        if (flagHasHint)
          {
          }
        flagHasHint = false;
      }
    public void setAmbiguities(HomeAutomationAmbiguityListJSON  new_value)
      {
        if (flagHasAmbiguities)
          {
          }
        flagHasAmbiguities = true;
        storeAmbiguities = new_value;
      }
    public void unsetAmbiguities()
      {
        if (flagHasAmbiguities)
          {
          }
        flagHasAmbiguities = false;
      }

    public virtual void extraHomeAutomationQueryDisambiguateSpecifierCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationQueryDisambiguateSpecifierCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationQueryDisambiguateSpecifierCommandLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationQueryDisambiguateSpecifierCommandAppendPair(key, new_component);
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
    public override void extraDisambiguateCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "mbiguities", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAmbiguities(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if ((String.Compare(key, 1, "ompactDeviceSpecifier", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONCompactDeviceSpecifier(new_component, false);
                    return;
                    }
                break;
            case 'H':
                if ((String.Compare(key, 1, "int", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONHint(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraHomeAutomationQueryDisambiguateSpecifierCommandAppendPair(key, new_component);
      }
    public override void extraDisambiguateCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "mbiguities", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAmbiguities(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if ((String.Compare(key, 1, "ompactDeviceSpecifier", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONCompactDeviceSpecifier(new_component, false);
                    return;
                    }
                break;
            case 'H':
                if ((String.Compare(key, 1, "int", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONHint(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraHomeAutomationQueryDisambiguateSpecifierCommandSetField(key, new_component);
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
        if (flagHasCompactDeviceSpecifier)
          {
            handler.start_pair("CompactDeviceSpecifier");
            if (partial_allowed)
                storeCompactDeviceSpecifier.write_partial_as_json(handler);
            else
                storeCompactDeviceSpecifier.write_as_json(handler);
          }
        if (flagHasHint)
          {
            handler.start_pair("Hint");
            if (partial_allowed)
                storeHint.write_partial_as_json(handler);
            else
                storeHint.write_as_json(handler);
          }
        if (flagHasAmbiguities)
          {
            handler.start_pair("Ambiguities");
            if (partial_allowed)
                storeAmbiguities.write_partial_as_json(handler);
            else
                storeAmbiguities.write_as_json(handler);
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
        return null;
      }

    public static new HomeAutomationQueryDisambiguateSpecifierCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationQueryDisambiguateSpecifierCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationQueryDisambiguateSpecifierCommand", ignore_extras);
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
    public static new HomeAutomationQueryDisambiguateSpecifierCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationQueryDisambiguateSpecifierCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationQueryDisambiguateSpecifierCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationQueryDisambiguateSpecifierCommand", ignore_extras);
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
    public static new HomeAutomationQueryDisambiguateSpecifierCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationQueryDisambiguateSpecifierCommandJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationQueryDisambiguateSpecifierCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationQueryDisambiguateSpecifierCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationQueryDisambiguateSpecifierCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HomeAutomationQueryDisambiguateSpecifierCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationQueryDisambiguateSpecifierCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationQueryDisambiguateSpecifierCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DisambiguateCommandJSON.Generator
      {
        private HomeAutomationCompactDeviceSpecifierJSON.HoldingGenerator fieldGeneratorCompactDeviceSpecifier;
        private HomeAutomationQueryHintJSON.HoldingGenerator fieldGeneratorHint;
        private HomeAutomationAmbiguityListJSON.HoldingGenerator fieldGeneratorAmbiguities;
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
            if (!(getDisambiguateCommandJSONKey().Equals("HomeAutomationQueryDisambiguateSpecifierCommand")))
                throw new Exception("The key field has a value other than `HomeAutomationQueryDisambiguateSpecifierCommand'.");
            HomeAutomationQueryDisambiguateSpecifierCommandJSON result = new HomeAutomationQueryDisambiguateSpecifierCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationQueryDisambiguateSpecifierCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DisambiguateCommandJSON new_result)
          {
            handle_result((HomeAutomationQueryDisambiguateSpecifierCommandJSON )new_result);
          }
        protected void finish(HomeAutomationQueryDisambiguateSpecifierCommandJSON result)
          {
            if (fieldGeneratorCompactDeviceSpecifier.have_value)
              {
                result.setCompactDeviceSpecifier(fieldGeneratorCompactDeviceSpecifier.value);
                fieldGeneratorCompactDeviceSpecifier.have_value = false;
              }
            if (fieldGeneratorHint.have_value)
              {
                result.setHint(fieldGeneratorHint.value);
                fieldGeneratorHint.have_value = false;
              }
            if (fieldGeneratorAmbiguities.have_value)
              {
                result.setAmbiguities(fieldGeneratorAmbiguities.value);
                fieldGeneratorAmbiguities.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(HomeAutomationQueryDisambiguateSpecifierCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "mbiguities", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorAmbiguities;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "ompactDeviceSpecifier", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorCompactDeviceSpecifier;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "int", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorHint;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCompactDeviceSpecifier = new HomeAutomationCompactDeviceSpecifierJSON.HoldingGenerator("field \"CompactDeviceSpecifier\" of the HomeAutomationQueryDisambiguateSpecifierCommand class", ignore_extras);
            fieldGeneratorHint = new HomeAutomationQueryHintJSON.HoldingGenerator("field \"Hint\" of the HomeAutomationQueryDisambiguateSpecifierCommand class", ignore_extras);
            fieldGeneratorAmbiguities = new HomeAutomationAmbiguityListJSON.HoldingGenerator("field \"Ambiguities\" of the HomeAutomationQueryDisambiguateSpecifierCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationQueryDisambiguateSpecifierCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCompactDeviceSpecifier = new HomeAutomationCompactDeviceSpecifierJSON.HoldingGenerator("field \"CompactDeviceSpecifier\" of the HomeAutomationQueryDisambiguateSpecifierCommand class", false);
            fieldGeneratorHint = new HomeAutomationQueryHintJSON.HoldingGenerator("field \"Hint\" of the HomeAutomationQueryDisambiguateSpecifierCommand class", false);
            fieldGeneratorAmbiguities = new HomeAutomationAmbiguityListJSON.HoldingGenerator("field \"Ambiguities\" of the HomeAutomationQueryDisambiguateSpecifierCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationQueryDisambiguateSpecifierCommand class");
          }

        public override void reset()
          {
            fieldGeneratorCompactDeviceSpecifier.reset();
            fieldGeneratorHint.reset();
            fieldGeneratorAmbiguities.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationQueryDisambiguateSpecifierCommandJSON  result)
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
        public HomeAutomationQueryDisambiguateSpecifierCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationQueryDisambiguateSpecifierCommandJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationQueryDisambiguateSpecifierCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationQueryDisambiguateSpecifierCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationQueryDisambiguateSpecifierCommandJSON>();
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
    public List<HomeAutomationQueryDisambiguateSpecifierCommandJSON> value;
  };
  };
