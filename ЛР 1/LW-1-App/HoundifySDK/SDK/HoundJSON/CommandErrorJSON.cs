/* file "CommandErrorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class CommandErrorJSON : JSONBase
  {
    private bool flagHasErrorMessage;
    private string storeErrorMessage;
    private bool flagHasExpectedCommandKind;
    private string storeExpectedCommandKind;


    private void  fromJSONErrorMessage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorMessage of CommandErrorJSON is not a string.");
        setErrorMessage(json_string.getData());
      }


    private void  fromJSONExpectedCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExpectedCommandKind of CommandErrorJSON is not a string.");
        setExpectedCommandKind(json_string.getData());
      }


    public CommandErrorJSON()
      {
        flagHasErrorMessage = false;
        flagHasExpectedCommandKind = false;
      }

    public abstract string getErrorType();
    public bool  hasErrorMessage()
      {
        return flagHasErrorMessage;
      }

    public string  getErrorMessage()
      {
        Debug.Assert(flagHasErrorMessage);
        return storeErrorMessage;
      }

    public bool  hasExpectedCommandKind()
      {
        return flagHasExpectedCommandKind;
      }

    public string  getExpectedCommandKind()
      {
        Debug.Assert(flagHasExpectedCommandKind);
        return storeExpectedCommandKind;
      }


    public abstract int extraCommandErrorComponentCount();
    public abstract string extraCommandErrorComponentKey(int component_num);
    public abstract JSONValue extraCommandErrorComponentValue(int component_num);
    public abstract JSONValue extraCommandErrorLookup(string field_name);

    public void setErrorMessage(string new_value)
      {
        flagHasErrorMessage = true;
        storeErrorMessage = new_value;
      }
    public void unsetErrorMessage()
      {
        flagHasErrorMessage = false;
      }
    public void setExpectedCommandKind(string new_value)
      {
        flagHasExpectedCommandKind = true;
        storeExpectedCommandKind = new_value;
      }
    public void unsetExpectedCommandKind()
      {
        flagHasExpectedCommandKind = false;
      }

    public abstract void extraCommandErrorAppendPair(string key, JSONValue new_component);
    public abstract void extraCommandErrorSetField(string key, JSONValue new_component);

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
        handler.pair("ErrorType", getErrorType());
        Debug.Assert(partial_allowed || flagHasErrorMessage);
        if (flagHasErrorMessage)
          {
            handler.start_pair("ErrorMessage");
            handler.string_value(storeErrorMessage);
          }
        if (flagHasExpectedCommandKind)
          {
            handler.start_pair("ExpectedCommandKind");
            handler.string_value(storeExpectedCommandKind);
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
        if (!(hasErrorMessage()))
          {
            return "When parsing the object for %what%, the \"ErrorMessage\" field was missing.";
          }
        return null;
      }

    public static CommandErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CommandErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CommandError", ignore_extras);
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
    public static CommandErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CommandErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CommandErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CommandError", ignore_extras);
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
    public static CommandErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CommandErrorJSON from_text(string text, bool ignore_extras)
      {
        CommandErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CommandError", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CommandErrorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CommandErrorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CommandErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CommandError", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorErrorMessage;
        private JSONHoldingStringGenerator fieldGeneratorExpectedCommandKind;
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
                throw new Exception("The `ErrorType' field is missing.");
            CommandErrorJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCommandErrorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getCommandErrorJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `ErrorType' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(CommandErrorJSON result)
          {
            if (fieldGeneratorErrorMessage.have_value)
              {
                result.setErrorMessage(fieldGeneratorErrorMessage.value);
                fieldGeneratorErrorMessage.have_value = false;
              }
            else if ((!(result.hasErrorMessage())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ErrorMessage\" field was missing.");
              }
            if (fieldGeneratorExpectedCommandKind.have_value)
              {
                result.setExpectedCommandKind(fieldGeneratorExpectedCommandKind.value);
                fieldGeneratorExpectedCommandKind.have_value = false;
              }
          }
        protected abstract void handle_result(CommandErrorJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "E", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'r':
                        if (String.Compare(field_name, 2, "ror", 0, 3, false) == 0)
                          {
                            switch (field_name[5])
                              {
                                case 'M':
                                    if ((String.Compare(field_name, 6, "essage", 0, 6, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorErrorMessage;
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 6, "ype", 0, 3, false) == 0) && (field_name.Length == 9))
                                        {
                                        keyGenerator.reset();
                                        return keyGenerator;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'x':
                        if ((String.Compare(field_name, 2, "pectedCommandKind", 0, 17, false) == 0) && (field_name.Length == 19))
                            return fieldGeneratorExpectedCommandKind;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the CommandError class");
            fieldGeneratorExpectedCommandKind = new JSONHoldingStringGenerator("field \"ExpectedCommandKind\" of the CommandError class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ErrorType\" of the CommandError class");
            set_what("the CommandError class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the CommandError class");
            fieldGeneratorExpectedCommandKind = new JSONHoldingStringGenerator("field \"ExpectedCommandKind\" of the CommandError class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ErrorType\" of the CommandError class");
            set_what("the CommandError class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorErrorMessage.reset();
            fieldGeneratorExpectedCommandKind.reset();
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
        protected override void handle_result(CommandErrorJSON  result)
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
        public CommandErrorJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CommandErrorJSON  result)
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
    protected virtual void handle_result(List<CommandErrorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CommandErrorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CommandErrorJSON>();
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
    public List<CommandErrorJSON> value;
  };
    class GenericCommandErrorJSON : CommandErrorJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericCommandErrorJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getErrorType()  { return key; }
        public override int extraCommandErrorComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraCommandErrorComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraCommandErrorComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraCommandErrorLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraCommandErrorAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraCommandErrorSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraCommandErrorLookup(key);
            if (old_field == null)
              {
                extraCommandErrorAppendPair(key, new_component);
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
    public static CommandErrorJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'A':
            switch (key[1])
              {
                case 'g':
                    if ((String.Compare(key, 2, "eCalculatorRequestedDateOutOfBounds", 0, 35, false) == 0) && (key.Length == 37))
                        return new AgeCalculatorRequestedDateOutOfBoundsJSON();
                    break;
                case 'm':
                    if ((String.Compare(key, 2, "ountError", 0, 9, false) == 0) && (key.Length == 11))
                        return new AmountErrorJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'B':
            if (String.Compare(key, 1, "ad", 0, 2, false) == 0)
              {
                switch (key[3])
                  {
                    case 'C':
                        if ((String.Compare(key, 4, "onversationState", 0, 16, false) == 0) && (key.Length == 20))
                            return new BadConversationStateJSON();
                        break;
                    case 'D':
                        if ((String.Compare(key, 4, "ata", 0, 3, false) == 0) && (key.Length == 7))
                            return new BadDataJSON();
                        break;
                    case 'T':
                        if ((String.Compare(key, 4, "errierExpression", 0, 16, false) == 0) && (key.Length == 20))
                            return new BadTerrierExpressionJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'C':
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "lendarError", 0, 11, false) == 0) && (key.Length == 13))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("CalendarErrorKind") ? other_field_index["CalendarErrorKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `CalendarErrorKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `CalendarErrorKind' field has a non-string value.");
                        return CalendarErrorJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'o':
                    if ((String.Compare(key, 2, "ntactSaveError", 0, 14, false) == 0) && (key.Length == 16))
                        return new ContactSaveErrorJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'D':
            if ((String.Compare(key, 1, "ateOutOfRange", 0, 13, false) == 0) && (key.Length == 14))
                return new FlightStatsDateOutOfRangeErrorJSON();
            break;
        case 'E':
            if ((String.Compare(key, 1, "xpediaHotelAPIError", 0, 19, false) == 0) && (key.Length == 20))
                return new ExpediaHotelAPIErrorJSON();
            break;
        case 'F':
            if (String.Compare(key, 1, "light", 0, 5, false) == 0)
              {
                switch (key[6])
                  {
                    case 'B':
                        if ((String.Compare(key, 7, "ookingCommandError", 0, 18, false) == 0) && (key.Length == 25))
                            return new FlightBookingCommandErrorJSON();
                        break;
                    case 'S':
                        if ((String.Compare(key, 7, "tatusCommandError", 0, 17, false) == 0) && (key.Length == 24))
                            return new FlightStatusCommandErrorJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'H':
            if ((String.Compare(key, 1, "omeAutomationCommandError", 0, 25, false) == 0) && (key.Length == 26))
                return new HomeAutomationCommandErrorJSON();
            break;
        case 'M':
            if ((String.Compare(key, 1, "issingLocation", 0, 14, false) == 0) && (key.Length == 15))
                return new MissingLocationJSON();
            break;
        case 'N':
            if (String.Compare(key, 1, "o", 0, 1, false) == 0)
              {
                switch (key[2])
                  {
                    case 'C':
                        if ((String.Compare(key, 3, "ontactInfo", 0, 10, false) == 0) && (key.Length == 13))
                            return new NoContactInfoJSON();
                        break;
                    case 'D':
                        if ((String.Compare(key, 3, "ata", 0, 3, false) == 0) && (key.Length == 6))
                            return new NoDataJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'O':
            if ((String.Compare(key, 1, "Auth2Error", 0, 10, false) == 0) && (key.Length == 11))
                return new OAuth2ErrorDataJSON();
            break;
        case 'R':
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "dioChannelError", 0, 15, false) == 0) && (key.Length == 17))
                        return new ChannelErrorCommandJSON();
                    break;
                case 'e':
                    switch (key[2])
                      {
                        case 'c':
                            if ((String.Compare(key, 3, "eptionError", 0, 11, false) == 0) && (key.Length == 14))
                                return new ReceptionErrorCommandJSON();
                            break;
                        case 'q':
                            if ((String.Compare(key, 3, "uestedDateOutOfBounds", 0, 21, false) == 0) && (key.Length == 24))
                                return new RequestedDateOutOfBoundsJSON();
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'S':
            switch (key[1])
              {
                case 'M':
                    if ((String.Compare(key, 2, "SDisambiguateError", 0, 18, false) == 0) && (key.Length == 20))
                        return new SMSDisambiguateErrorJSON();
                    break;
                case 't':
                    if ((String.Compare(key, 2, "uckInMode", 0, 9, false) == 0) && (key.Length == 11))
                        return new StuckInModeJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'U':
            switch (key[1])
              {
                case 'b':
                    if ((String.Compare(key, 2, "erError", 0, 7, false) == 0) && (key.Length == 9))
                      {
                        JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("UberErrorKind") ? other_field_index["UberErrorKind"] : null));
                        if (key_value == null)
                            throw new Exception("The `UberErrorKind' field is missing.");
                        JSONStringValue key_string_value = key_value.string_value();
                        if (key_string_value == null)
                            throw new Exception("The `UberErrorKind' field has a non-string value.");
                        return UberErrorJSON.createForKey(key_string_value.getData(), other_field_index);
                      }
                    break;
                case 'n':
                    if ((String.Compare(key, 2, "knownContactRequestKind", 0, 23, false) == 0) && (key.Length == 25))
                        return new UnknownContactRequestKindJSON();
                    break;
                case 's':
                    if ((String.Compare(key, 2, "erMemoryNotSet", 0, 14, false) == 0) && (key.Length == 16))
                        return new UserMemoryNotSetJSON();
                    break;
                default:
                    break;
              }
            break;
        default:
            break;
      }

        return new GenericCommandErrorJSON(key);
      }
  };
