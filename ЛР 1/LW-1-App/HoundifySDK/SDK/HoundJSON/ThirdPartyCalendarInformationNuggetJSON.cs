/* file "ThirdPartyCalendarInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class ThirdPartyCalendarInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasThirdPartyCalendarService;
    private ThirdPartyCalendarServiceJSON  storeThirdPartyCalendarService;
    private bool flagHasActionSuccessful;
    private bool storeActionSuccessful;


    private JSONValue  extraThirdPartyCalendarServiceToJSON()
      {
        JSONValueHandler handler_ThirdPartyCalendarService = new JSONValueHandler();
        storeThirdPartyCalendarService.write_as_json(handler_ThirdPartyCalendarService);
        return handler_ThirdPartyCalendarService.result;
      }

    private JSONValue  extraActionSuccessfulToJSON()
      {
        JSONValue generated_boolean_ActionSuccessful = (storeActionSuccessful ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_ActionSuccessful;
      }


    private void  fromJSONThirdPartyCalendarService(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ThirdPartyCalendarServiceJSON convert_classy = ThirdPartyCalendarServiceJSON.from_json(json_value, ignore_extras, true);
        setThirdPartyCalendarService(convert_classy);
      }


    private void  fromJSONActionSuccessful(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ActionSuccessful of ThirdPartyCalendarInformationNuggetJSON is not true for false.");
              }
          }
        setActionSuccessful(the_bool);
      }


    public ThirdPartyCalendarInformationNuggetJSON()
      {
        flagHasThirdPartyCalendarService = false;
        flagHasActionSuccessful = false;
      }

    public override string  getNuggetKind()
      {
        return "ThirdPartyCalendarInformationNugget";
      }

    public abstract string getThirdPartyCalendarInformationNuggetType();
    public bool  hasThirdPartyCalendarService()
      {
        return flagHasThirdPartyCalendarService;
      }

    public ThirdPartyCalendarServiceJSON   getThirdPartyCalendarService()
      {
        Debug.Assert(flagHasThirdPartyCalendarService);
        return storeThirdPartyCalendarService;
      }

    public ThirdPartyCalendarServiceJSON.TypeValue  getThirdPartyCalendarServiceValue()
      {
        return getThirdPartyCalendarService().getValue();
      }

    public string  getThirdPartyCalendarServiceAsString()
      {
        return getThirdPartyCalendarService().getValueAsString();
      }

    public bool  hasActionSuccessful()
      {
        return flagHasActionSuccessful;
      }

    public bool  getActionSuccessful()
      {
        Debug.Assert(flagHasActionSuccessful);
        return storeActionSuccessful;
      }


    public abstract int extraThirdPartyCalendarInformationNuggetComponentCount();
    public abstract string extraThirdPartyCalendarInformationNuggetComponentKey(int component_num);
    public abstract JSONValue extraThirdPartyCalendarInformationNuggetComponentValue(int component_num);
    public abstract JSONValue extraThirdPartyCalendarInformationNuggetLookup(string field_name);
    public override int extraInformationNuggetComponentCount()
      {
        int result = 1;
        if (flagHasThirdPartyCalendarService)
            ++result;
        if (flagHasActionSuccessful)
            ++result;
        result += extraThirdPartyCalendarInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        if (component_num == 0)
            return "ThirdPartyCalendarInformationNuggetType";
        int remainder = (component_num - 1);
        if (flagHasThirdPartyCalendarService)
          {
            if (remainder == 0)
                return "ThirdPartyCalendarService";
            --remainder;
          }
        if (flagHasActionSuccessful)
          {
            if (remainder == 0)
                return "ActionSuccessful";
            --remainder;
          }
        return extraThirdPartyCalendarInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getThirdPartyCalendarInformationNuggetType());
        int remainder = (component_num - 1);
        if (flagHasThirdPartyCalendarService)
          {
            if (remainder == 0)
                return extraThirdPartyCalendarServiceToJSON();
            --remainder;
          }
        if (flagHasActionSuccessful)
          {
            if (remainder == 0)
                return extraActionSuccessfulToJSON();
            --remainder;
          }
        return extraThirdPartyCalendarInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "ctionSuccessful", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasActionSuccessful ? extraActionSuccessfulToJSON() : null);
                break;
            case 'T':
                if (String.Compare(field_name, 1, "hirdPartyCalendar", 0, 17, false) == 0)
                  {
                    switch (field_name[18])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 19, "nformationNuggetType", 0, 20, false) == 0) && (field_name.Length == 39))
                                return new JSONStringValue(getThirdPartyCalendarInformationNuggetType());
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 19, "ervice", 0, 6, false) == 0) && (field_name.Length == 25))
                                return (flagHasThirdPartyCalendarService ? extraThirdPartyCalendarServiceToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraThirdPartyCalendarInformationNuggetLookup(field_name);
      }

    public void setThirdPartyCalendarService(ThirdPartyCalendarServiceJSON  new_value)
      {
        if (flagHasThirdPartyCalendarService)
          {
          }
        flagHasThirdPartyCalendarService = true;
        storeThirdPartyCalendarService = new_value;
      }
    public void setThirdPartyCalendarService(ThirdPartyCalendarServiceJSON.TypeValue new_value)
      {
        setThirdPartyCalendarService(new ThirdPartyCalendarServiceJSON(new_value));
      }
    public void setThirdPartyCalendarService(string chars)
      {
        setThirdPartyCalendarService(new ThirdPartyCalendarServiceJSON(chars));
      }
    public void unsetThirdPartyCalendarService()
      {
        if (flagHasThirdPartyCalendarService)
          {
          }
        flagHasThirdPartyCalendarService = false;
      }
    public void setActionSuccessful(bool new_value)
      {
        flagHasActionSuccessful = true;
        storeActionSuccessful = new_value;
      }
    public void unsetActionSuccessful()
      {
        flagHasActionSuccessful = false;
      }

    public abstract void extraThirdPartyCalendarInformationNuggetAppendPair(string key, JSONValue new_component);
    public abstract void extraThirdPartyCalendarInformationNuggetSetField(string key, JSONValue new_component);
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ctionSuccessful", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONActionSuccessful(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if (String.Compare(key, 1, "hirdPartyCalendar", 0, 17, false) == 0)
                  {
                    switch (key[18])
                      {
                        case 'I':
                            if ((String.Compare(key, 19, "nformationNuggetType", 0, 20, false) == 0) && (key.Length == 39))
                                return;
                            break;
                        case 'S':
                            if ((String.Compare(key, 19, "ervice", 0, 6, false) == 0) && (key.Length == 25))
                                {
                                fromJSONThirdPartyCalendarService(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraThirdPartyCalendarInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ctionSuccessful", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONActionSuccessful(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if (String.Compare(key, 1, "hirdPartyCalendar", 0, 17, false) == 0)
                  {
                    switch (key[18])
                      {
                        case 'I':
                            if ((String.Compare(key, 19, "nformationNuggetType", 0, 20, false) == 0) && (key.Length == 39))
                                return;
                            break;
                        case 'S':
                            if ((String.Compare(key, 19, "ervice", 0, 6, false) == 0) && (key.Length == 25))
                                {
                                fromJSONThirdPartyCalendarService(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraThirdPartyCalendarInformationNuggetSetField(key, new_component);
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
        handler.pair("ThirdPartyCalendarInformationNuggetType", getThirdPartyCalendarInformationNuggetType());
        Debug.Assert(partial_allowed || flagHasThirdPartyCalendarService);
        if (flagHasThirdPartyCalendarService)
          {
            handler.start_pair("ThirdPartyCalendarService");
            if (partial_allowed)
                storeThirdPartyCalendarService.write_partial_as_json(handler);
            else
                storeThirdPartyCalendarService.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasActionSuccessful);
        if (flagHasActionSuccessful)
          {
            handler.start_pair("ActionSuccessful");
            handler.boolean_value(storeActionSuccessful);
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
        if (!(hasThirdPartyCalendarService()))
          {
            return "When parsing the object for %what%, the \"ThirdPartyCalendarService\" field was missing.";
          }
        if (!(hasActionSuccessful()))
          {
            return "When parsing the object for %what%, the \"ActionSuccessful\" field was missing.";
          }
        return null;
      }

    public static new ThirdPartyCalendarInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ThirdPartyCalendarInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ThirdPartyCalendarInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ThirdPartyCalendarInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ThirdPartyCalendarInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private ThirdPartyCalendarServiceJSON.HoldingGenerator fieldGeneratorThirdPartyCalendarService;
        private JSONHoldingBooleanGenerator fieldGeneratorActionSuccessful;
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
                throw new Exception("The `ThirdPartyCalendarInformationNuggetType' field is missing.");
            if (!(getInformationNuggetJSONKey().Equals("ThirdPartyCalendarInformationNugget")))
                throw new Exception("The key field has a value other than `ThirdPartyCalendarInformationNugget'.");
            ThirdPartyCalendarInformationNuggetJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraThirdPartyCalendarInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getThirdPartyCalendarInformationNuggetJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `ThirdPartyCalendarInformationNuggetType' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((ThirdPartyCalendarInformationNuggetJSON )new_result);
          }
        protected void finish(ThirdPartyCalendarInformationNuggetJSON result)
          {
            if (fieldGeneratorThirdPartyCalendarService.have_value)
              {
                result.setThirdPartyCalendarService(fieldGeneratorThirdPartyCalendarService.value);
                fieldGeneratorThirdPartyCalendarService.have_value = false;
              }
            else if ((!(result.hasThirdPartyCalendarService())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ThirdPartyCalendarService\" field was missing.");
              }
            if (fieldGeneratorActionSuccessful.have_value)
              {
                result.setActionSuccessful(fieldGeneratorActionSuccessful.value);
                fieldGeneratorActionSuccessful.have_value = false;
              }
            else if ((!(result.hasActionSuccessful())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ActionSuccessful\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ThirdPartyCalendarInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ctionSuccessful", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorActionSuccessful;
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "hirdPartyCalendar", 0, 17, false) == 0)
                      {
                        switch (field_name[18])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 19, "nformationNuggetType", 0, 20, false) == 0) && (field_name.Length == 39))
                                    {
                                    keyGenerator.reset();
                                    return keyGenerator;
                                    }
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 19, "ervice", 0, 6, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorThirdPartyCalendarService;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorThirdPartyCalendarService = new ThirdPartyCalendarServiceJSON.HoldingGenerator("field \"ThirdPartyCalendarService\" of the ThirdPartyCalendarInformationNugget class", ignore_extras);
            fieldGeneratorActionSuccessful = new JSONHoldingBooleanGenerator("field \"ActionSuccessful\" of the ThirdPartyCalendarInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ThirdPartyCalendarInformationNuggetType\" of the ThirdPartyCalendarInformationNugget class");
            set_what("the ThirdPartyCalendarInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorThirdPartyCalendarService = new ThirdPartyCalendarServiceJSON.HoldingGenerator("field \"ThirdPartyCalendarService\" of the ThirdPartyCalendarInformationNugget class", false);
            fieldGeneratorActionSuccessful = new JSONHoldingBooleanGenerator("field \"ActionSuccessful\" of the ThirdPartyCalendarInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ThirdPartyCalendarInformationNuggetType\" of the ThirdPartyCalendarInformationNugget class");
            set_what("the ThirdPartyCalendarInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorThirdPartyCalendarService.reset();
            fieldGeneratorActionSuccessful.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ThirdPartyCalendarInformationNuggetJSON  result)
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
        public ThirdPartyCalendarInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ThirdPartyCalendarInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ThirdPartyCalendarInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ThirdPartyCalendarInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ThirdPartyCalendarInformationNuggetJSON>();
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
    public List<ThirdPartyCalendarInformationNuggetJSON> value;
  };
    class GenericThirdPartyCalendarInformationNuggetJSON : ThirdPartyCalendarInformationNuggetJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericThirdPartyCalendarInformationNuggetJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getThirdPartyCalendarInformationNuggetType()  { return key; }
        public override int extraThirdPartyCalendarInformationNuggetComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraThirdPartyCalendarInformationNuggetComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraThirdPartyCalendarInformationNuggetComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraThirdPartyCalendarInformationNuggetLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraThirdPartyCalendarInformationNuggetAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraThirdPartyCalendarInformationNuggetSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraThirdPartyCalendarInformationNuggetLookup(key);
            if (old_field == null)
              {
                extraThirdPartyCalendarInformationNuggetAppendPair(key, new_component);
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
    public static new ThirdPartyCalendarInformationNuggetJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "ThirdParty", 0, 10, false) == 0)
      {
        switch (key[10])
          {
            case 'C':
                if (String.Compare(key, 11, "alendar", 0, 7, false) == 0)
                  {
                    switch (key[18])
                      {
                        case 'A':
                            switch (key[19])
                              {
                                case 'd':
                                    if (String.Compare(key, 20, "d", 0, 1, false) == 0)
                                      {
                                        switch (key[21])
                                          {
                                            case 'G':
                                                if ((String.Compare(key, 22, "uestsInformationNugget", 0, 22, false) == 0) && (key.Length == 44))
                                                    return new ThirdPartyCalendarAddGuestsInformationNuggetJSON();
                                                break;
                                            case 'L':
                                                if ((String.Compare(key, 22, "ocationInformationNugget", 0, 24, false) == 0) && (key.Length == 46))
                                                    return new ThirdPartyCalendarAddLocationInformationNuggetJSON();
                                                break;
                                            case 'R':
                                                if ((String.Compare(key, 22, "eminderInformationNugget", 0, 24, false) == 0) && (key.Length == 46))
                                                    return new ThirdPartyCalendarAddReminderInformationNuggetJSON();
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'v':
                                    if ((String.Compare(key, 20, "ailableRoomsInformationNugget", 0, 29, false) == 0) && (key.Length == 49))
                                        return new ThirdPartyCalendarAvailableRoomsInformationNuggetJSON();
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'C':
                            switch (key[19])
                              {
                                case 'a':
                                    if (String.Compare(key, 20, "ncel", 0, 4, false) == 0)
                                      {
                                        switch (key[24])
                                          {
                                            case 'C':
                                                switch (key[25])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(key, 26, "ncelEventsInformationNugget", 0, 27, false) == 0) && (key.Length == 53))
                                                            return new ThirdPartyCalendarCancelCancelEventsInformationNuggetJSON();
                                                        break;
                                                    case 'r':
                                                        if ((String.Compare(key, 26, "eateInformationNugget", 0, 21, false) == 0) && (key.Length == 47))
                                                            return new ThirdPartyCalendarCancelCreateInformationNuggetJSON();
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'E':
                                                if ((String.Compare(key, 25, "ventsInformationNugget", 0, 22, false) == 0) && (key.Length == 47))
                                                    return new ThirdPartyCalendarCancelEventsInformationNuggetJSON();
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'r':
                                    if ((String.Compare(key, 20, "eateEventInformationNugget", 0, 26, false) == 0) && (key.Length == 46))
                                        return new ThirdPartyCalendarCreateEventInformationNuggetJSON();
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'D':
                            if ((String.Compare(key, 19, "isplayEventsInformationNugget", 0, 29, false) == 0) && (key.Length == 48))
                                return new ThirdPartyCalendarDisplayEventsInformationNuggetJSON();
                            break;
                        case 'M':
                            if ((String.Compare(key, 19, "odifyEventInformationNugget", 0, 27, false) == 0) && (key.Length == 46))
                                return new ThirdPartyCalendarModifyEventInformationNuggetJSON();
                            break;
                        case 'R':
                            if ((String.Compare(key, 19, "etrieveEventsInformationNugget", 0, 30, false) == 0) && (key.Length == 49))
                                return new ThirdPartyCalendarRetrieveEventsInformationNuggetJSON();
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(key, 11, "efreshMeetingRoomsInformationNugget", 0, 35, false) == 0) && (key.Length == 46))
                    return new ThirdPartyCalendarRefreshMeetingRoomsInformationNuggetJSON();
                break;
            default:
                break;
          }
      }

        return new GenericThirdPartyCalendarInformationNuggetJSON(key);
      }
  };
