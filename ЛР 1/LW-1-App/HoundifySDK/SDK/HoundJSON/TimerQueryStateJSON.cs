/* file "TimerQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TimerQueryStateJSON : JSONBase
  {
    public enum TypeTimerCommandKind
      {
        TimerCommandKind_TimerAddTimeCommand,
        TimerCommandKind_TimerDeleteCommand,
        TimerCommandKind_TimerDisplayCommand,
        TimerCommandKind_TimerNotUnderstoodCommand,
        TimerCommandKind_TimerQuitInformationNugget,
        TimerCommandKind_TimerResetCommand,
        TimerCommandKind_TimerResumeCommand,
        TimerCommandKind_TimerSetCommand,
        TimerCommandKind_TimerStartModeCommand,
        TimerCommandKind_TimerStopCommand,
        TimerCommandKind_TimerUnsetCommand
      };

    public static TypeTimerCommandKind  stringToTimerCommandKind(string chars)
      {
        if (String.Compare(chars, 0, "Timer", 0, 5, false) == 0)
          {
            switch (chars[5])
              {
                case 'A':
                    if ((String.Compare(chars, 6, "ddTimeCommand", 0, 13, false) == 0) && (chars.Length == 19))
                        return TypeTimerCommandKind.TimerCommandKind_TimerAddTimeCommand;
                    break;
                case 'D':
                    switch (chars[6])
                      {
                        case 'e':
                            if ((String.Compare(chars, 7, "leteCommand", 0, 11, false) == 0) && (chars.Length == 18))
                                return TypeTimerCommandKind.TimerCommandKind_TimerDeleteCommand;
                            break;
                        case 'i':
                            if ((String.Compare(chars, 7, "splayCommand", 0, 12, false) == 0) && (chars.Length == 19))
                                return TypeTimerCommandKind.TimerCommandKind_TimerDisplayCommand;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'N':
                    if ((String.Compare(chars, 6, "otUnderstoodCommand", 0, 19, false) == 0) && (chars.Length == 25))
                        return TypeTimerCommandKind.TimerCommandKind_TimerNotUnderstoodCommand;
                    break;
                case 'Q':
                    if ((String.Compare(chars, 6, "uitInformationNugget", 0, 20, false) == 0) && (chars.Length == 26))
                        return TypeTimerCommandKind.TimerCommandKind_TimerQuitInformationNugget;
                    break;
                case 'R':
                    if (String.Compare(chars, 6, "es", 0, 2, false) == 0)
                      {
                        switch (chars[8])
                          {
                            case 'e':
                                if ((String.Compare(chars, 9, "tCommand", 0, 8, false) == 0) && (chars.Length == 17))
                                    return TypeTimerCommandKind.TimerCommandKind_TimerResetCommand;
                                break;
                            case 'u':
                                if ((String.Compare(chars, 9, "meCommand", 0, 9, false) == 0) && (chars.Length == 18))
                                    return TypeTimerCommandKind.TimerCommandKind_TimerResumeCommand;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (chars[6])
                      {
                        case 'e':
                            if ((String.Compare(chars, 7, "tCommand", 0, 8, false) == 0) && (chars.Length == 15))
                                return TypeTimerCommandKind.TimerCommandKind_TimerSetCommand;
                            break;
                        case 't':
                            switch (chars[7])
                              {
                                case 'a':
                                    if ((String.Compare(chars, 8, "rtModeCommand", 0, 13, false) == 0) && (chars.Length == 21))
                                        return TypeTimerCommandKind.TimerCommandKind_TimerStartModeCommand;
                                    break;
                                case 'o':
                                    if ((String.Compare(chars, 8, "pCommand", 0, 8, false) == 0) && (chars.Length == 16))
                                        return TypeTimerCommandKind.TimerCommandKind_TimerStopCommand;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'U':
                    if ((String.Compare(chars, 6, "nsetCommand", 0, 11, false) == 0) && (chars.Length == 17))
                        return TypeTimerCommandKind.TimerCommandKind_TimerUnsetCommand;
                    break;
                default:
                    break;
              }
          }
        throw new Exception("The value for field `TimerCommandKind' is not one of the legal values.");
      }

    public static string  stringFromTimerCommandKind(TypeTimerCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeTimerCommandKind.TimerCommandKind_TimerAddTimeCommand:
                return "TimerAddTimeCommand";
            case TypeTimerCommandKind.TimerCommandKind_TimerDeleteCommand:
                return "TimerDeleteCommand";
            case TypeTimerCommandKind.TimerCommandKind_TimerDisplayCommand:
                return "TimerDisplayCommand";
            case TypeTimerCommandKind.TimerCommandKind_TimerNotUnderstoodCommand:
                return "TimerNotUnderstoodCommand";
            case TypeTimerCommandKind.TimerCommandKind_TimerQuitInformationNugget:
                return "TimerQuitInformationNugget";
            case TypeTimerCommandKind.TimerCommandKind_TimerResetCommand:
                return "TimerResetCommand";
            case TypeTimerCommandKind.TimerCommandKind_TimerResumeCommand:
                return "TimerResumeCommand";
            case TypeTimerCommandKind.TimerCommandKind_TimerSetCommand:
                return "TimerSetCommand";
            case TypeTimerCommandKind.TimerCommandKind_TimerStartModeCommand:
                return "TimerStartModeCommand";
            case TypeTimerCommandKind.TimerCommandKind_TimerStopCommand:
                return "TimerStopCommand";
            case TypeTimerCommandKind.TimerCommandKind_TimerUnsetCommand:
                return "TimerUnsetCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasTimerCommandKind;
    private TypeTimerCommandKind storeTimerCommandKind;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTimerCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TimerCommandKind of TimerQueryStateJSON is not a string.");
        TypeTimerCommandKind the_enum;
        if (String.Compare(json_string.getData(), 0, "Timer", 0, 5, false) == 0)
          {
            switch (json_string.getData()[5])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 6, "ddTimeCommand", 0, 13, false) == 0) && (json_string.getData().Length == 19))
                          {
                            the_enum = TypeTimerCommandKind.TimerCommandKind_TimerAddTimeCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'D':
                    switch (json_string.getData()[6])
                      {
                        case 'e':
                            if ((String.Compare(json_string.getData(), 7, "leteCommand", 0, 11, false) == 0) && (json_string.getData().Length == 18))
                                  {
                                    the_enum = TypeTimerCommandKind.TimerCommandKind_TimerDeleteCommand;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'i':
                            if ((String.Compare(json_string.getData(), 7, "splayCommand", 0, 12, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_enum = TypeTimerCommandKind.TimerCommandKind_TimerDisplayCommand;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'N':
                    if ((String.Compare(json_string.getData(), 6, "otUnderstoodCommand", 0, 19, false) == 0) && (json_string.getData().Length == 25))
                          {
                            the_enum = TypeTimerCommandKind.TimerCommandKind_TimerNotUnderstoodCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'Q':
                    if ((String.Compare(json_string.getData(), 6, "uitInformationNugget", 0, 20, false) == 0) && (json_string.getData().Length == 26))
                          {
                            the_enum = TypeTimerCommandKind.TimerCommandKind_TimerQuitInformationNugget;
                            goto enum_is_done;
                          }
                    break;
                case 'R':
                    if (String.Compare(json_string.getData(), 6, "es", 0, 2, false) == 0)
                      {
                        switch (json_string.getData()[8])
                          {
                            case 'e':
                                if ((String.Compare(json_string.getData(), 9, "tCommand", 0, 8, false) == 0) && (json_string.getData().Length == 17))
                                      {
                                        the_enum = TypeTimerCommandKind.TimerCommandKind_TimerResetCommand;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'u':
                                if ((String.Compare(json_string.getData(), 9, "meCommand", 0, 9, false) == 0) && (json_string.getData().Length == 18))
                                      {
                                        the_enum = TypeTimerCommandKind.TimerCommandKind_TimerResumeCommand;
                                        goto enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (json_string.getData()[6])
                      {
                        case 'e':
                            if ((String.Compare(json_string.getData(), 7, "tCommand", 0, 8, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_enum = TypeTimerCommandKind.TimerCommandKind_TimerSetCommand;
                                    goto enum_is_done;
                                  }
                            break;
                        case 't':
                            switch (json_string.getData()[7])
                              {
                                case 'a':
                                    if ((String.Compare(json_string.getData(), 8, "rtModeCommand", 0, 13, false) == 0) && (json_string.getData().Length == 21))
                                          {
                                            the_enum = TypeTimerCommandKind.TimerCommandKind_TimerStartModeCommand;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'o':
                                    if ((String.Compare(json_string.getData(), 8, "pCommand", 0, 8, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_enum = TypeTimerCommandKind.TimerCommandKind_TimerStopCommand;
                                            goto enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'U':
                    if ((String.Compare(json_string.getData(), 6, "nsetCommand", 0, 11, false) == 0) && (json_string.getData().Length == 17))
                          {
                            the_enum = TypeTimerCommandKind.TimerCommandKind_TimerUnsetCommand;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
          }
        throw new Exception("The value for field TimerCommandKind of TimerQueryStateJSON is not one of the legal strings.");
      enum_is_done:;
        setTimerCommandKind(the_enum);
      }


    public TimerQueryStateJSON()
      {
        flagHasTimerCommandKind = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTimerCommandKind()
      {
        return flagHasTimerCommandKind;
      }

    public TypeTimerCommandKind  getTimerCommandKind()
      {
        Debug.Assert(flagHasTimerCommandKind);
        return storeTimerCommandKind;
      }

    public string  getTimerCommandKindAsString()
      {
        return stringFromTimerCommandKind(getTimerCommandKind());
      }


    public virtual int extraTimerQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimerQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimerQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimerQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTimerCommandKind(TypeTimerCommandKind new_value)
      {
        flagHasTimerCommandKind = true;
        storeTimerCommandKind = new_value;
      }
    public void setTimerCommandKind(string chars)
      {
        setTimerCommandKind(stringToTimerCommandKind(chars));
      }
    public void unsetTimerCommandKind()
      {
        flagHasTimerCommandKind = false;
      }

    public virtual void extraTimerQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimerQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimerQueryStateLookup(key);
        if (old_field == null)
          {
            extraTimerQueryStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasTimerCommandKind);
        if (flagHasTimerCommandKind)
          {
            handler.start_pair("TimerCommandKind");
            switch (storeTimerCommandKind)
              {
                case TypeTimerCommandKind.TimerCommandKind_TimerAddTimeCommand:
                    handler.string_value("TimerAddTimeCommand");
                    break;
                case TypeTimerCommandKind.TimerCommandKind_TimerDeleteCommand:
                    handler.string_value("TimerDeleteCommand");
                    break;
                case TypeTimerCommandKind.TimerCommandKind_TimerDisplayCommand:
                    handler.string_value("TimerDisplayCommand");
                    break;
                case TypeTimerCommandKind.TimerCommandKind_TimerNotUnderstoodCommand:
                    handler.string_value("TimerNotUnderstoodCommand");
                    break;
                case TypeTimerCommandKind.TimerCommandKind_TimerQuitInformationNugget:
                    handler.string_value("TimerQuitInformationNugget");
                    break;
                case TypeTimerCommandKind.TimerCommandKind_TimerResetCommand:
                    handler.string_value("TimerResetCommand");
                    break;
                case TypeTimerCommandKind.TimerCommandKind_TimerResumeCommand:
                    handler.string_value("TimerResumeCommand");
                    break;
                case TypeTimerCommandKind.TimerCommandKind_TimerSetCommand:
                    handler.string_value("TimerSetCommand");
                    break;
                case TypeTimerCommandKind.TimerCommandKind_TimerStartModeCommand:
                    handler.string_value("TimerStartModeCommand");
                    break;
                case TypeTimerCommandKind.TimerCommandKind_TimerStopCommand:
                    handler.string_value("TimerStopCommand");
                    break;
                case TypeTimerCommandKind.TimerCommandKind_TimerUnsetCommand:
                    handler.string_value("TimerUnsetCommand");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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
        if (!(hasTimerCommandKind()))
          {
            return "When parsing the object for %what%, the \"TimerCommandKind\" field was missing.";
          }
        return null;
      }

    public static TimerQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimerQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerQueryState", ignore_extras);
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
    public static TimerQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TimerQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimerQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerQueryState", ignore_extras);
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
    public static TimerQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TimerQueryStateJSON from_text(string text, bool ignore_extras)
      {
        TimerQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimerQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TimerQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimerQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorTimerCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorTimerCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorTimerCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToTimerCommandKind(result));
              }
            protected abstract void handle_result(TypeTimerCommandKind result);
          };
    private class FieldHoldingGeneratorTimerCommandKind : FieldGeneratorTimerCommandKind
  {
    protected override void handle_result(TypeTimerCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorTimerCommandKind(String what)
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
    public TypeTimerCommandKind value;
  };
    private class FieldHoldingArrayGeneratorTimerCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorTimerCommandKind
      {
        private FieldHoldingArrayGeneratorTimerCommandKind top;

        protected override void handle_result(TypeTimerCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorTimerCommandKind init_top)
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
    protected virtual void handle_result(List<TypeTimerCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorTimerCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTimerCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorTimerCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTimerCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeTimerCommandKind> value;
  };
        private FieldHoldingGeneratorTimerCommandKind fieldGeneratorTimerCommandKind;
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
            TimerQueryStateJSON result = new TimerQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimerQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TimerQueryStateJSON result)
          {
            if (fieldGeneratorTimerCommandKind.have_value)
              {
                result.setTimerCommandKind(fieldGeneratorTimerCommandKind.value);
                fieldGeneratorTimerCommandKind.have_value = false;
              }
            else if ((!(result.hasTimerCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TimerCommandKind\" field was missing.");
              }
          }
        protected abstract void handle_result(TimerQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "TimerCommandKind", 0, 16, false) == 0) && (field_name.Length == 16))
                return fieldGeneratorTimerCommandKind;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTimerCommandKind = new FieldHoldingGeneratorTimerCommandKind("field \"TimerCommandKind\" of the TimerQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimerQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTimerCommandKind = new FieldHoldingGeneratorTimerCommandKind("field \"TimerCommandKind\" of the TimerQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimerQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTimerCommandKind.reset();
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
        protected override void handle_result(TimerQueryStateJSON  result)
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
        public TimerQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimerQueryStateJSON  result)
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
    protected virtual void handle_result(List<TimerQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimerQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimerQueryStateJSON>();
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
    public List<TimerQueryStateJSON> value;
  };
  };
