/* file "HomeAutomationControlCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class HomeAutomationControlCommandJSON : CommandResultJSON
  {
    private bool flagHasOperation;
    private HomeAutomationOperationJSON  storeOperation;
    private bool flagHasDeviceSpecifier;
    private HomeAutomationDeviceSpecifierJSON  storeDeviceSpecifier;
    private bool flagHasControlResult;
    private HomeAutomationActionResultJSON  storeControlResult;


    private JSONValue  extraOperationToJSON()
      {
        JSONValueHandler handler_Operation = new JSONValueHandler();
        storeOperation.write_as_json(handler_Operation);
        return handler_Operation.result;
      }

    private JSONValue  extraDeviceSpecifierToJSON()
      {
        JSONValueHandler handler_DeviceSpecifier = new JSONValueHandler();
        storeDeviceSpecifier.write_as_json(handler_DeviceSpecifier);
        return handler_DeviceSpecifier.result;
      }

    private JSONValue  extraControlResultToJSON()
      {
        JSONValueHandler handler_ControlResult = new JSONValueHandler();
        storeControlResult.write_as_json(handler_ControlResult);
        return handler_ControlResult.result;
      }


    private void  fromJSONOperation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationOperationJSON convert_classy = HomeAutomationOperationJSON.from_json(json_value, ignore_extras, true);
        setOperation(convert_classy);
      }


    private void  fromJSONDeviceSpecifier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationDeviceSpecifierJSON convert_classy = HomeAutomationDeviceSpecifierJSON.from_json(json_value, ignore_extras, true);
        setDeviceSpecifier(convert_classy);
      }


    private void  fromJSONControlResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationActionResultJSON convert_classy = HomeAutomationActionResultJSON.from_json(json_value, ignore_extras, true);
        setControlResult(convert_classy);
      }


    public HomeAutomationControlCommandJSON()
      {
        flagHasOperation = false;
        flagHasDeviceSpecifier = false;
        flagHasControlResult = false;
      }

    public override string  getCommandKind()
      {
        return "HomeAutomationControlCommand";
      }

    public abstract string getHomeAutomationControlCommandKind();
    public bool  hasOperation()
      {
        return flagHasOperation;
      }

    public HomeAutomationOperationJSON   getOperation()
      {
        Debug.Assert(flagHasOperation);
        return storeOperation;
      }

    public HomeAutomationOperationJSON.TypeValue  getOperationValue()
      {
        return getOperation().getValue();
      }

    public string  getOperationAsString()
      {
        return getOperation().getValueAsString();
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

    public bool  hasControlResult()
      {
        return flagHasControlResult;
      }

    public HomeAutomationActionResultJSON   getControlResult()
      {
        Debug.Assert(flagHasControlResult);
        return storeControlResult;
      }


    public abstract int extraHomeAutomationControlCommandComponentCount();
    public abstract string extraHomeAutomationControlCommandComponentKey(int component_num);
    public abstract JSONValue extraHomeAutomationControlCommandComponentValue(int component_num);
    public abstract JSONValue extraHomeAutomationControlCommandLookup(string field_name);
    public override int extraCommandResultComponentCount()
      {
        int result = 1;
        if (flagHasOperation)
            ++result;
        if (flagHasDeviceSpecifier)
            ++result;
        if (flagHasControlResult)
            ++result;
        result += extraHomeAutomationControlCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        if (component_num == 0)
            return "HomeAutomationControlCommandKind";
        int remainder = (component_num - 1);
        if (flagHasOperation)
          {
            if (remainder == 0)
                return "Operation";
            --remainder;
          }
        if (flagHasDeviceSpecifier)
          {
            if (remainder == 0)
                return "DeviceSpecifier";
            --remainder;
          }
        if (flagHasControlResult)
          {
            if (remainder == 0)
                return "ControlResult";
            --remainder;
          }
        return extraHomeAutomationControlCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getHomeAutomationControlCommandKind());
        int remainder = (component_num - 1);
        if (flagHasOperation)
          {
            if (remainder == 0)
                return extraOperationToJSON();
            --remainder;
          }
        if (flagHasDeviceSpecifier)
          {
            if (remainder == 0)
                return extraDeviceSpecifierToJSON();
            --remainder;
          }
        if (flagHasControlResult)
          {
            if (remainder == 0)
                return extraControlResultToJSON();
            --remainder;
          }
        return extraHomeAutomationControlCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ontrolResult", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasControlResult ? extraControlResultToJSON() : null);
                break;
            case 'D':
                if ((String.Compare(field_name, 1, "eviceSpecifier", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasDeviceSpecifier ? extraDeviceSpecifierToJSON() : null);
                break;
            case 'H':
                if ((String.Compare(field_name, 1, "omeAutomationControlCommandKind", 0, 31, false) == 0) && (field_name.Length == 32))
                    return new JSONStringValue(getHomeAutomationControlCommandKind());
                break;
            case 'O':
                if ((String.Compare(field_name, 1, "peration", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasOperation ? extraOperationToJSON() : null);
                break;
            default:
                break;
          }
        return extraHomeAutomationControlCommandLookup(field_name);
      }

    public void setOperation(HomeAutomationOperationJSON  new_value)
      {
        if (flagHasOperation)
          {
          }
        flagHasOperation = true;
        storeOperation = new_value;
      }
    public void setOperation(HomeAutomationOperationJSON.TypeValue new_value)
      {
        setOperation(new HomeAutomationOperationJSON(new_value));
      }
    public void setOperation(string chars)
      {
        HomeAutomationOperationJSON.TypeValueKnownValues known = HomeAutomationOperationJSON.stringToValue(chars);
        HomeAutomationOperationJSON.TypeValue new_value = new HomeAutomationOperationJSON.TypeValue();
        if (known == HomeAutomationOperationJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setOperation(new_value);
      }
    public void unsetOperation()
      {
        if (flagHasOperation)
          {
          }
        flagHasOperation = false;
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
    public void setControlResult(HomeAutomationActionResultJSON  new_value)
      {
        if (flagHasControlResult)
          {
          }
        flagHasControlResult = true;
        storeControlResult = new_value;
      }
    public void unsetControlResult()
      {
        if (flagHasControlResult)
          {
          }
        flagHasControlResult = false;
      }

    public abstract void extraHomeAutomationControlCommandAppendPair(string key, JSONValue new_component);
    public abstract void extraHomeAutomationControlCommandSetField(string key, JSONValue new_component);
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ontrolResult", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONControlResult(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "eviceSpecifier", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONDeviceSpecifier(new_component, false);
                    return;
                    }
                break;
            case 'H':
                if ((String.Compare(key, 1, "omeAutomationControlCommandKind", 0, 31, false) == 0) && (key.Length == 32))
                    return;
                break;
            case 'O':
                if ((String.Compare(key, 1, "peration", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONOperation(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraHomeAutomationControlCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ontrolResult", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONControlResult(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "eviceSpecifier", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONDeviceSpecifier(new_component, false);
                    return;
                    }
                break;
            case 'H':
                if ((String.Compare(key, 1, "omeAutomationControlCommandKind", 0, 31, false) == 0) && (key.Length == 32))
                    return;
                break;
            case 'O':
                if ((String.Compare(key, 1, "peration", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONOperation(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraHomeAutomationControlCommandSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        handler.pair("HomeAutomationControlCommandKind", getHomeAutomationControlCommandKind());
        Debug.Assert(partial_allowed || flagHasOperation);
        if (flagHasOperation)
          {
            handler.start_pair("Operation");
            if (partial_allowed)
                storeOperation.write_partial_as_json(handler);
            else
                storeOperation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDeviceSpecifier);
        if (flagHasDeviceSpecifier)
          {
            handler.start_pair("DeviceSpecifier");
            if (partial_allowed)
                storeDeviceSpecifier.write_partial_as_json(handler);
            else
                storeDeviceSpecifier.write_as_json(handler);
          }
        if (flagHasControlResult)
          {
            handler.start_pair("ControlResult");
            if (partial_allowed)
                storeControlResult.write_partial_as_json(handler);
            else
                storeControlResult.write_as_json(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasOperation()))
          {
            return "When parsing the object for %what%, the \"Operation\" field was missing.";
          }
        if (!(hasDeviceSpecifier()))
          {
            return "When parsing the object for %what%, the \"DeviceSpecifier\" field was missing.";
          }
        return null;
      }

    public static new HomeAutomationControlCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationControlCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationControlCommand", ignore_extras);
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
    public static new HomeAutomationControlCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationControlCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationControlCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationControlCommand", ignore_extras);
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
    public static new HomeAutomationControlCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HomeAutomationControlCommandJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationControlCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationControlCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationControlCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HomeAutomationControlCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationControlCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationControlCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private HomeAutomationOperationJSON.HoldingGenerator fieldGeneratorOperation;
        private HomeAutomationDeviceSpecifierJSON.HoldingGenerator fieldGeneratorDeviceSpecifier;
        private HomeAutomationActionResultJSON.HoldingGenerator fieldGeneratorControlResult;
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
                throw new Exception("The `HomeAutomationControlCommandKind' field is missing.");
            if (!(getCommandResultJSONKey().Equals("HomeAutomationControlCommand")))
                throw new Exception("The key field has a value other than `HomeAutomationControlCommand'.");
            HomeAutomationControlCommandJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationControlCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getHomeAutomationControlCommandJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `HomeAutomationControlCommandKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((HomeAutomationControlCommandJSON )new_result);
          }
        protected void finish(HomeAutomationControlCommandJSON result)
          {
            if (fieldGeneratorOperation.have_value)
              {
                result.setOperation(fieldGeneratorOperation.value);
                fieldGeneratorOperation.have_value = false;
              }
            else if ((!(result.hasOperation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Operation\" field was missing.");
              }
            if (fieldGeneratorDeviceSpecifier.have_value)
              {
                result.setDeviceSpecifier(fieldGeneratorDeviceSpecifier.value);
                fieldGeneratorDeviceSpecifier.have_value = false;
              }
            else if ((!(result.hasDeviceSpecifier())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DeviceSpecifier\" field was missing.");
              }
            if (fieldGeneratorControlResult.have_value)
              {
                result.setControlResult(fieldGeneratorControlResult.value);
                fieldGeneratorControlResult.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(HomeAutomationControlCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ontrolResult", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorControlResult;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "eviceSpecifier", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorDeviceSpecifier;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "omeAutomationControlCommandKind", 0, 31, false) == 0) && (field_name.Length == 32))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "peration", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorOperation;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorOperation = new HomeAutomationOperationJSON.HoldingGenerator("field \"Operation\" of the HomeAutomationControlCommand class", ignore_extras);
            fieldGeneratorDeviceSpecifier = new HomeAutomationDeviceSpecifierJSON.HoldingGenerator("field \"DeviceSpecifier\" of the HomeAutomationControlCommand class", ignore_extras);
            fieldGeneratorControlResult = new HomeAutomationActionResultJSON.HoldingGenerator("field \"ControlResult\" of the HomeAutomationControlCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"HomeAutomationControlCommandKind\" of the HomeAutomationControlCommand class");
            set_what("the HomeAutomationControlCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorOperation = new HomeAutomationOperationJSON.HoldingGenerator("field \"Operation\" of the HomeAutomationControlCommand class", false);
            fieldGeneratorDeviceSpecifier = new HomeAutomationDeviceSpecifierJSON.HoldingGenerator("field \"DeviceSpecifier\" of the HomeAutomationControlCommand class", false);
            fieldGeneratorControlResult = new HomeAutomationActionResultJSON.HoldingGenerator("field \"ControlResult\" of the HomeAutomationControlCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"HomeAutomationControlCommandKind\" of the HomeAutomationControlCommand class");
            set_what("the HomeAutomationControlCommand class");
          }

        public override void reset()
          {
            fieldGeneratorOperation.reset();
            fieldGeneratorDeviceSpecifier.reset();
            fieldGeneratorControlResult.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationControlCommandJSON  result)
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
        public HomeAutomationControlCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationControlCommandJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationControlCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationControlCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationControlCommandJSON>();
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
    public List<HomeAutomationControlCommandJSON> value;
  };
    class GenericHomeAutomationControlCommandJSON : HomeAutomationControlCommandJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericHomeAutomationControlCommandJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getHomeAutomationControlCommandKind()  { return key; }
        public override int extraHomeAutomationControlCommandComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraHomeAutomationControlCommandComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraHomeAutomationControlCommandComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraHomeAutomationControlCommandLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraHomeAutomationControlCommandAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraHomeAutomationControlCommandSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraHomeAutomationControlCommandLookup(key);
            if (old_field == null)
              {
                extraHomeAutomationControlCommandAppendPair(key, new_component);
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
    public static new HomeAutomationControlCommandJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "HomeAutomation", 0, 14, false) == 0)
      {
        switch (key[14])
          {
            case 'B':
                if ((String.Compare(key, 15, "asicControlCommand", 0, 18, false) == 0) && (key.Length == 33))
                    return new HomeAutomationBasicControlCommandJSON();
                break;
            case 'C':
                if (String.Compare(key, 15, "hangeChannel", 0, 12, false) == 0)
                  {
                    switch (key[27])
                      {
                        case 'C':
                            if ((String.Compare(key, 28, "ommand", 0, 6, false) == 0) && (key.Length == 34))
                                return new HomeAutomationChangeChannelCommandJSON();
                            break;
                        case 'D':
                            if ((String.Compare(key, 28, "eltaCommand", 0, 11, false) == 0) && (key.Length == 39))
                                return new HomeAutomationChangeChannelDeltaCommandJSON();
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if (String.Compare(key, 15, "et", 0, 2, false) == 0)
                  {
                    switch (key[17])
                      {
                        case 'B':
                            if (String.Compare(key, 18, "rightness", 0, 9, false) == 0)
                              {
                                switch (key[27])
                                  {
                                    case 'C':
                                        if ((String.Compare(key, 28, "ommand", 0, 6, false) == 0) && (key.Length == 34))
                                            return new HomeAutomationSetBrightnessCommandJSON();
                                        break;
                                    case 'D':
                                        if ((String.Compare(key, 28, "eltaCommand", 0, 11, false) == 0) && (key.Length == 39))
                                            return new HomeAutomationSetBrightnessDeltaCommandJSON();
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'C':
                            if ((String.Compare(key, 18, "olorCommand", 0, 11, false) == 0) && (key.Length == 29))
                                return new HomeAutomationSetColorCommandJSON();
                            break;
                        case 'T':
                            if (String.Compare(key, 18, "emperature", 0, 10, false) == 0)
                              {
                                switch (key[28])
                                  {
                                    case 'C':
                                        if ((String.Compare(key, 29, "ommand", 0, 6, false) == 0) && (key.Length == 35))
                                            return new HomeAutomationSetTemperatureCommandJSON();
                                        break;
                                    case 'D':
                                        if ((String.Compare(key, 29, "eltaCommand", 0, 11, false) == 0) && (key.Length == 40))
                                            return new HomeAutomationSetTemperatureDeltaCommandJSON();
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'V':
                            if (String.Compare(key, 18, "olume", 0, 5, false) == 0)
                              {
                                switch (key[23])
                                  {
                                    case 'C':
                                        if ((String.Compare(key, 24, "ommand", 0, 6, false) == 0) && (key.Length == 30))
                                            return new HomeAutomationSetVolumeCommandJSON();
                                        break;
                                    case 'D':
                                        if ((String.Compare(key, 24, "eltaCommand", 0, 11, false) == 0) && (key.Length == 35))
                                            return new HomeAutomationSetVolumeDeltaCommandJSON();
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'W':
                            if (String.Compare(key, 18, "indSpeed", 0, 8, false) == 0)
                              {
                                switch (key[26])
                                  {
                                    case 'C':
                                        if ((String.Compare(key, 27, "ommand", 0, 6, false) == 0) && (key.Length == 33))
                                            return new HomeAutomationSetWindSpeedCommandJSON();
                                        break;
                                    case 'D':
                                        if ((String.Compare(key, 27, "eltaCommand", 0, 11, false) == 0) && (key.Length == 38))
                                            return new HomeAutomationSetWindSpeedDeltaCommandJSON();
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                if ((String.Compare(key, 15, "urboControlCommand", 0, 18, false) == 0) && (key.Length == 33))
                    return new HomeAutomationTurboControlCommandJSON();
                break;
            default:
                break;
          }
      }

        return new GenericHomeAutomationControlCommandJSON(key);
      }
  };
