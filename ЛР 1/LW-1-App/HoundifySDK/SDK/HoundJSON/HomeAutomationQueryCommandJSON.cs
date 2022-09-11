/* file "HomeAutomationQueryCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationQueryCommandJSON : CommandResultJSON
  {
    private bool flagHasDeviceSpecifier;
    private HomeAutomationDeviceSpecifierJSON  storeDeviceSpecifier;
    private bool flagHasHint;
    private HomeAutomationQueryHintJSON  storeHint;
    private bool flagHasQueryResult;
    private HomeAutomationActionResultJSON  storeQueryResult;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDeviceSpecifierToJSON()
      {
        JSONValueHandler handler_DeviceSpecifier = new JSONValueHandler();
        storeDeviceSpecifier.write_as_json(handler_DeviceSpecifier);
        return handler_DeviceSpecifier.result;
      }

    private JSONValue  extraHintToJSON()
      {
        JSONValueHandler handler_Hint = new JSONValueHandler();
        storeHint.write_as_json(handler_Hint);
        return handler_Hint.result;
      }

    private JSONValue  extraQueryResultToJSON()
      {
        JSONValueHandler handler_QueryResult = new JSONValueHandler();
        storeQueryResult.write_as_json(handler_QueryResult);
        return handler_QueryResult.result;
      }


    private void  fromJSONDeviceSpecifier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationDeviceSpecifierJSON convert_classy = HomeAutomationDeviceSpecifierJSON.from_json(json_value, ignore_extras, true);
        setDeviceSpecifier(convert_classy);
      }


    private void  fromJSONHint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationQueryHintJSON convert_classy = HomeAutomationQueryHintJSON.from_json(json_value, ignore_extras, true);
        setHint(convert_classy);
      }


    private void  fromJSONQueryResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationActionResultJSON convert_classy = HomeAutomationActionResultJSON.from_json(json_value, ignore_extras, true);
        setQueryResult(convert_classy);
      }


    public HomeAutomationQueryCommandJSON()
      {
        flagHasDeviceSpecifier = false;
        flagHasHint = false;
        flagHasQueryResult = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandKind()
      {
        return "HomeAutomationQueryCommand";
      }

    public bool  hasDeviceSpecifier()
      {
        return flagHasDeviceSpecifier;
      }

    public HomeAutomationDeviceSpecifierJSON   getDeviceSpecifier()
      {
        Debug.Assert(flagHasDeviceSpecifier);
        return storeDeviceSpecifier;
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

    public bool  hasQueryResult()
      {
        return flagHasQueryResult;
      }

    public HomeAutomationActionResultJSON   getQueryResult()
      {
        Debug.Assert(flagHasQueryResult);
        return storeQueryResult;
      }


    public virtual int extraHomeAutomationQueryCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationQueryCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationQueryCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationQueryCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasDeviceSpecifier)
            ++result;
        if (flagHasHint)
            ++result;
        if (flagHasQueryResult)
            ++result;
        result += extraHomeAutomationQueryCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasDeviceSpecifier)
          {
            if (remainder == 0)
                return "DeviceSpecifier";
            --remainder;
          }
        if (flagHasHint)
          {
            if (remainder == 0)
                return "Hint";
            --remainder;
          }
        if (flagHasQueryResult)
          {
            if (remainder == 0)
                return "QueryResult";
            --remainder;
          }
        return extraHomeAutomationQueryCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasDeviceSpecifier)
          {
            if (remainder == 0)
                return extraDeviceSpecifierToJSON();
            --remainder;
          }
        if (flagHasHint)
          {
            if (remainder == 0)
                return extraHintToJSON();
            --remainder;
          }
        if (flagHasQueryResult)
          {
            if (remainder == 0)
                return extraQueryResultToJSON();
            --remainder;
          }
        return extraHomeAutomationQueryCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "eviceSpecifier", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasDeviceSpecifier ? extraDeviceSpecifierToJSON() : null);
                break;
            case 'H':
                if ((String.Compare(field_name, 1, "int", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasHint ? extraHintToJSON() : null);
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "ueryResult", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasQueryResult ? extraQueryResultToJSON() : null);
                break;
            default:
                break;
          }
        return extraHomeAutomationQueryCommandLookup(field_name);
      }

    public void setDeviceSpecifier(HomeAutomationDeviceSpecifierJSON  new_value)
      {
        if (flagHasDeviceSpecifier)
          {
          }
        flagHasDeviceSpecifier = true;
        storeDeviceSpecifier = new_value;
      }
    public void unsetDeviceSpecifier()
      {
        if (flagHasDeviceSpecifier)
          {
          }
        flagHasDeviceSpecifier = false;
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
    public void setQueryResult(HomeAutomationActionResultJSON  new_value)
      {
        if (flagHasQueryResult)
          {
          }
        flagHasQueryResult = true;
        storeQueryResult = new_value;
      }
    public void unsetQueryResult()
      {
        if (flagHasQueryResult)
          {
          }
        flagHasQueryResult = false;
      }

    public virtual void extraHomeAutomationQueryCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationQueryCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationQueryCommandLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationQueryCommandAppendPair(key, new_component);
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
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "eviceSpecifier", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONDeviceSpecifier(new_component, false);
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
            case 'Q':
                if ((String.Compare(key, 1, "ueryResult", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONQueryResult(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraHomeAutomationQueryCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "eviceSpecifier", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONDeviceSpecifier(new_component, false);
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
            case 'Q':
                if ((String.Compare(key, 1, "ueryResult", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONQueryResult(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraHomeAutomationQueryCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDeviceSpecifier);
        if (flagHasDeviceSpecifier)
          {
            handler.start_pair("DeviceSpecifier");
            if (partial_allowed)
                storeDeviceSpecifier.write_partial_as_json(handler);
            else
                storeDeviceSpecifier.write_as_json(handler);
          }
        if (flagHasHint)
          {
            handler.start_pair("Hint");
            if (partial_allowed)
                storeHint.write_partial_as_json(handler);
            else
                storeHint.write_as_json(handler);
          }
        if (flagHasQueryResult)
          {
            handler.start_pair("QueryResult");
            if (partial_allowed)
                storeQueryResult.write_partial_as_json(handler);
            else
                storeQueryResult.write_as_json(handler);
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
        if (!(hasDeviceSpecifier()))
          {
            return "When parsing the object for %what%, the \"DeviceSpecifier\" field was missing.";
          }
        return null;
      }

    public static new HomeAutomationQueryCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationQueryCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationQueryCommand", ignore_extras);
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
    public static new HomeAutomationQueryCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationQueryCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationQueryCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationQueryCommand", ignore_extras);
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
    public static new HomeAutomationQueryCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationQueryCommandJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationQueryCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationQueryCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationQueryCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HomeAutomationQueryCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationQueryCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationQueryCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private HomeAutomationDeviceSpecifierJSON.HoldingGenerator fieldGeneratorDeviceSpecifier;
        private HomeAutomationQueryHintJSON.HoldingGenerator fieldGeneratorHint;
        private HomeAutomationActionResultJSON.HoldingGenerator fieldGeneratorQueryResult;
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
            if (!(getCommandResultJSONKey().Equals("HomeAutomationQueryCommand")))
                throw new Exception("The key field has a value other than `HomeAutomationQueryCommand'.");
            HomeAutomationQueryCommandJSON result = new HomeAutomationQueryCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationQueryCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((HomeAutomationQueryCommandJSON )new_result);
          }
        protected void finish(HomeAutomationQueryCommandJSON result)
          {
            if (fieldGeneratorDeviceSpecifier.have_value)
              {
                result.setDeviceSpecifier(fieldGeneratorDeviceSpecifier.value);
                fieldGeneratorDeviceSpecifier.have_value = false;
              }
            else if ((!(result.hasDeviceSpecifier())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DeviceSpecifier\" field was missing.");
              }
            if (fieldGeneratorHint.have_value)
              {
                result.setHint(fieldGeneratorHint.value);
                fieldGeneratorHint.have_value = false;
              }
            if (fieldGeneratorQueryResult.have_value)
              {
                result.setQueryResult(fieldGeneratorQueryResult.value);
                fieldGeneratorQueryResult.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(HomeAutomationQueryCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "eviceSpecifier", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorDeviceSpecifier;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "int", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorHint;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryResult", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorQueryResult;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorDeviceSpecifier = new HomeAutomationDeviceSpecifierJSON.HoldingGenerator("field \"DeviceSpecifier\" of the HomeAutomationQueryCommand class", ignore_extras);
            fieldGeneratorHint = new HomeAutomationQueryHintJSON.HoldingGenerator("field \"Hint\" of the HomeAutomationQueryCommand class", ignore_extras);
            fieldGeneratorQueryResult = new HomeAutomationActionResultJSON.HoldingGenerator("field \"QueryResult\" of the HomeAutomationQueryCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationQueryCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDeviceSpecifier = new HomeAutomationDeviceSpecifierJSON.HoldingGenerator("field \"DeviceSpecifier\" of the HomeAutomationQueryCommand class", false);
            fieldGeneratorHint = new HomeAutomationQueryHintJSON.HoldingGenerator("field \"Hint\" of the HomeAutomationQueryCommand class", false);
            fieldGeneratorQueryResult = new HomeAutomationActionResultJSON.HoldingGenerator("field \"QueryResult\" of the HomeAutomationQueryCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationQueryCommand class");
          }

        public override void reset()
          {
            fieldGeneratorDeviceSpecifier.reset();
            fieldGeneratorHint.reset();
            fieldGeneratorQueryResult.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationQueryCommandJSON  result)
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
        public HomeAutomationQueryCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationQueryCommandJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationQueryCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationQueryCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationQueryCommandJSON>();
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
    public List<HomeAutomationQueryCommandJSON> value;
  };
  };
