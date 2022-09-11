/* file "ThirdPartyCalendarErrorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class ThirdPartyCalendarErrorJSON : CalendarErrorJSON
  {
    private bool flagHasService;
    private ThirdPartyCalendarServiceJSON  storeService;


    private JSONValue  extraServiceToJSON()
      {
        JSONValueHandler handler_Service = new JSONValueHandler();
        storeService.write_as_json(handler_Service);
        return handler_Service.result;
      }


    private void  fromJSONService(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ThirdPartyCalendarServiceJSON convert_classy = ThirdPartyCalendarServiceJSON.from_json(json_value, ignore_extras, true);
        setService(convert_classy);
      }


    public ThirdPartyCalendarErrorJSON()
      {
        flagHasService = false;
      }

    public override string  getCalendarErrorKind()
      {
        return "ThirdPartyCalendarError";
      }

    public abstract string getThirdPartyCalendarErrorKind();
    public bool  hasService()
      {
        return flagHasService;
      }

    public ThirdPartyCalendarServiceJSON   getService()
      {
        Debug.Assert(flagHasService);
        return storeService;
      }

    public ThirdPartyCalendarServiceJSON.TypeValue  getServiceValue()
      {
        return getService().getValue();
      }

    public string  getServiceAsString()
      {
        return getService().getValueAsString();
      }


    public abstract int extraThirdPartyCalendarErrorComponentCount();
    public abstract string extraThirdPartyCalendarErrorComponentKey(int component_num);
    public abstract JSONValue extraThirdPartyCalendarErrorComponentValue(int component_num);
    public abstract JSONValue extraThirdPartyCalendarErrorLookup(string field_name);
    public override int extraCalendarErrorComponentCount()
      {
        int result = 1;
        if (flagHasService)
            ++result;
        result += extraThirdPartyCalendarErrorComponentCount();
        return result;
      }
    public override string extraCalendarErrorComponentKey(int component_num)
      {
        if (component_num == 0)
            return "ThirdPartyCalendarErrorKind";
        int remainder = (component_num - 1);
        if (flagHasService)
          {
            if (remainder == 0)
                return "Service";
            --remainder;
          }
        return extraThirdPartyCalendarErrorComponentKey(remainder);
      }
    public override JSONValue extraCalendarErrorComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getThirdPartyCalendarErrorKind());
        int remainder = (component_num - 1);
        if (flagHasService)
          {
            if (remainder == 0)
                return extraServiceToJSON();
            --remainder;
          }
        return extraThirdPartyCalendarErrorComponentValue(remainder);
      }
    public override JSONValue extraCalendarErrorLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'S':
                if ((String.Compare(field_name, 1, "ervice", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasService ? extraServiceToJSON() : null);
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "hirdPartyCalendarErrorKind", 0, 26, false) == 0) && (field_name.Length == 27))
                    return new JSONStringValue(getThirdPartyCalendarErrorKind());
                break;
            default:
                break;
          }
        return extraThirdPartyCalendarErrorLookup(field_name);
      }

    public void setService(ThirdPartyCalendarServiceJSON  new_value)
      {
        if (flagHasService)
          {
          }
        flagHasService = true;
        storeService = new_value;
      }
    public void setService(ThirdPartyCalendarServiceJSON.TypeValue new_value)
      {
        setService(new ThirdPartyCalendarServiceJSON(new_value));
      }
    public void setService(string chars)
      {
        setService(new ThirdPartyCalendarServiceJSON(chars));
      }
    public void unsetService()
      {
        if (flagHasService)
          {
          }
        flagHasService = false;
      }

    public abstract void extraThirdPartyCalendarErrorAppendPair(string key, JSONValue new_component);
    public abstract void extraThirdPartyCalendarErrorSetField(string key, JSONValue new_component);
    public override void extraCalendarErrorAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'S':
                if ((String.Compare(key, 1, "ervice", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONService(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "hirdPartyCalendarErrorKind", 0, 26, false) == 0) && (key.Length == 27))
                    return;
                break;
            default:
                break;
          }
        extraThirdPartyCalendarErrorAppendPair(key, new_component);
      }
    public override void extraCalendarErrorSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'S':
                if ((String.Compare(key, 1, "ervice", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONService(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "hirdPartyCalendarErrorKind", 0, 26, false) == 0) && (key.Length == 27))
                    return;
                break;
            default:
                break;
          }
        extraThirdPartyCalendarErrorSetField(key, new_component);
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
        handler.pair("ThirdPartyCalendarErrorKind", getThirdPartyCalendarErrorKind());
        Debug.Assert(partial_allowed || flagHasService);
        if (flagHasService)
          {
            handler.start_pair("Service");
            if (partial_allowed)
                storeService.write_partial_as_json(handler);
            else
                storeService.write_as_json(handler);
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
        if (!(hasService()))
          {
            return "When parsing the object for %what%, the \"Service\" field was missing.";
          }
        return null;
      }

    public static new ThirdPartyCalendarErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarError", ignore_extras);
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
    public static new ThirdPartyCalendarErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarError", ignore_extras);
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
    public static new ThirdPartyCalendarErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarErrorJSON from_text(string text, bool ignore_extras)
      {
        ThirdPartyCalendarErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarError", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ThirdPartyCalendarErrorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ThirdPartyCalendarErrorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ThirdPartyCalendarErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarError", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CalendarErrorJSON.Generator
      {
        private ThirdPartyCalendarServiceJSON.HoldingGenerator fieldGeneratorService;
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
                throw new Exception("The `ThirdPartyCalendarErrorKind' field is missing.");
            if (!(getCalendarErrorJSONKey().Equals("ThirdPartyCalendarError")))
                throw new Exception("The key field has a value other than `ThirdPartyCalendarError'.");
            ThirdPartyCalendarErrorJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraThirdPartyCalendarErrorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getThirdPartyCalendarErrorJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `ThirdPartyCalendarErrorKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(CalendarErrorJSON new_result)
          {
            handle_result((ThirdPartyCalendarErrorJSON )new_result);
          }
        protected void finish(ThirdPartyCalendarErrorJSON result)
          {
            if (fieldGeneratorService.have_value)
              {
                result.setService(fieldGeneratorService.value);
                fieldGeneratorService.have_value = false;
              }
            else if ((!(result.hasService())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Service\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ThirdPartyCalendarErrorJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'S':
                    if ((String.Compare(field_name, 1, "ervice", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorService;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "hirdPartyCalendarErrorKind", 0, 26, false) == 0) && (field_name.Length == 27))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorService = new ThirdPartyCalendarServiceJSON.HoldingGenerator("field \"Service\" of the ThirdPartyCalendarError class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ThirdPartyCalendarErrorKind\" of the ThirdPartyCalendarError class");
            set_what("the ThirdPartyCalendarError class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorService = new ThirdPartyCalendarServiceJSON.HoldingGenerator("field \"Service\" of the ThirdPartyCalendarError class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ThirdPartyCalendarErrorKind\" of the ThirdPartyCalendarError class");
            set_what("the ThirdPartyCalendarError class");
          }

        public override void reset()
          {
            fieldGeneratorService.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ThirdPartyCalendarErrorJSON  result)
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
        public ThirdPartyCalendarErrorJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ThirdPartyCalendarErrorJSON  result)
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
    protected virtual void handle_result(List<ThirdPartyCalendarErrorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ThirdPartyCalendarErrorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ThirdPartyCalendarErrorJSON>();
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
    public List<ThirdPartyCalendarErrorJSON> value;
  };
    class GenericThirdPartyCalendarErrorJSON : ThirdPartyCalendarErrorJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericThirdPartyCalendarErrorJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getThirdPartyCalendarErrorKind()  { return key; }
        public override int extraThirdPartyCalendarErrorComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraThirdPartyCalendarErrorComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraThirdPartyCalendarErrorComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraThirdPartyCalendarErrorLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraThirdPartyCalendarErrorAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraThirdPartyCalendarErrorSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraThirdPartyCalendarErrorLookup(key);
            if (old_field == null)
              {
                extraThirdPartyCalendarErrorAppendPair(key, new_component);
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
    public static new ThirdPartyCalendarErrorJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'C':
            if (String.Compare(key, 1, "alendar", 0, 7, false) == 0)
              {
                switch (key[8])
                  {
                    case 'N':
                        if (String.Compare(key, 9, "o", 0, 1, false) == 0)
                          {
                            switch (key[10])
                              {
                                case 'C':
                                    if ((String.Compare(key, 11, "onvenientTimeFoundError", 0, 23, false) == 0) && (key.Length == 34))
                                        return new CalendarNoConvenientTimeFoundErrorJSON();
                                    break;
                                case 'R':
                                    if ((String.Compare(key, 11, "oomFoundError", 0, 13, false) == 0) && (key.Length == 24))
                                        return new CalendarNoRoomFoundErrorJSON();
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'R':
                        if ((String.Compare(key, 9, "efreshMeetingRoomsError", 0, 23, false) == 0) && (key.Length == 32))
                            return new CalendarRefreshMeetingRoomsErrorJSON();
                        break;
                    case 'U':
                        switch (key[9])
                          {
                            case 'n':
                                switch (key[10])
                                  {
                                    case 'h':
                                        if ((String.Compare(key, 11, "andledError", 0, 11, false) == 0) && (key.Length == 22))
                                            return new CalendarUnhandledErrorJSON();
                                        break;
                                    case 's':
                                        if ((String.Compare(key, 11, "upportedFeatureError", 0, 20, false) == 0) && (key.Length == 31))
                                            return new CalendarUnsupportedFeatureErrorJSON();
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 's':
                                if ((String.Compare(key, 10, "erNotConnectedToAPIError", 0, 24, false) == 0) && (key.Length == 34))
                                    return new CalendarUserNotConnectedToAPIErrorJSON();
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'U':
            switch (key[1])
              {
                case 'n':
                    switch (key[2])
                      {
                        case 'h':
                            if ((String.Compare(key, 3, "andledThirdPartyCalendarError", 0, 29, false) == 0) && (key.Length == 32))
                                return new UnhandledThirdPartyCalendarErrorJSON();
                            break;
                        case 's':
                            if ((String.Compare(key, 3, "upportedFeatureCalendarError", 0, 28, false) == 0) && (key.Length == 31))
                                return new UnsupportedFeatureCalendarErrorJSON();
                            break;
                        default:
                            break;
                      }
                    break;
                case 's':
                    if ((String.Compare(key, 2, "erIsNotConnectedToThirdPartyCalendarError", 0, 41, false) == 0) && (key.Length == 43))
                        return new UserNotConnectedToThirdPartyAPICalendarErrorJSON();
                    break;
                default:
                    break;
              }
            break;
        default:
            break;
      }

        return new GenericThirdPartyCalendarErrorJSON(key);
      }
  };
