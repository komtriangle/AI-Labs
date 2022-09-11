/* file "ClientControlQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ClientControlQueryStateJSON : JSONBase
  {
    public enum TypeCommandKind
      {
        CommandKind_ClientControlCommand
      };

    public static TypeCommandKind  stringToCommandKind(string chars)
      {
        if ((String.Compare(chars, 0, "ClientControlCommand", 0, 20, false) == 0) && (chars.Length == 20))
            return TypeCommandKind.CommandKind_ClientControlCommand;
        throw new Exception("The value for field `CommandKind' is not one of the legal values.");
      }

    public static string  stringFromCommandKind(TypeCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeCommandKind.CommandKind_ClientControlCommand:
                return "ClientControlCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeClientControlCommandKind
      {
        ClientControlCommandKind_ClientControlGoBackCommand,
        ClientControlCommandKind_ClientControlRepeatCommand,
        ClientControlCommandKind_ClientControlClearScreenCommand,
        ClientControlCommandKind_ClientControlGoForwardCommand,
        ClientControlCommandKind_ClientControlResponseYesCommand,
        ClientControlCommandKind_ClientControlResponseNoCommand,
        ClientControlCommandKind_ClientControlQuitAppCommand,
        ClientControlCommandKind_ClientControlGoCommand
      };

    public static TypeClientControlCommandKind  stringToClientControlCommandKind(string chars)
      {
        if (String.Compare(chars, 0, "ClientControl", 0, 13, false) == 0)
          {
            switch (chars[13])
              {
                case 'C':
                    if ((String.Compare(chars, 14, "learScreenCommand", 0, 17, false) == 0) && (chars.Length == 31))
                        return TypeClientControlCommandKind.ClientControlCommandKind_ClientControlClearScreenCommand;
                    break;
                case 'G':
                    if (String.Compare(chars, 14, "o", 0, 1, false) == 0)
                      {
                        switch (chars[15])
                          {
                            case 'B':
                                if ((String.Compare(chars, 16, "ackCommand", 0, 10, false) == 0) && (chars.Length == 26))
                                    return TypeClientControlCommandKind.ClientControlCommandKind_ClientControlGoBackCommand;
                                break;
                            case 'C':
                                if ((String.Compare(chars, 16, "ommand", 0, 6, false) == 0) && (chars.Length == 22))
                                    return TypeClientControlCommandKind.ClientControlCommandKind_ClientControlGoCommand;
                                break;
                            case 'F':
                                if ((String.Compare(chars, 16, "orwardCommand", 0, 13, false) == 0) && (chars.Length == 29))
                                    return TypeClientControlCommandKind.ClientControlCommandKind_ClientControlGoForwardCommand;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'Q':
                    if ((String.Compare(chars, 14, "uitAppCommand", 0, 13, false) == 0) && (chars.Length == 27))
                        return TypeClientControlCommandKind.ClientControlCommandKind_ClientControlQuitAppCommand;
                    break;
                case 'R':
                    if (String.Compare(chars, 14, "e", 0, 1, false) == 0)
                      {
                        switch (chars[15])
                          {
                            case 'p':
                                if ((String.Compare(chars, 16, "eatCommand", 0, 10, false) == 0) && (chars.Length == 26))
                                    return TypeClientControlCommandKind.ClientControlCommandKind_ClientControlRepeatCommand;
                                break;
                            case 's':
                                if (String.Compare(chars, 16, "ponse", 0, 5, false) == 0)
                                  {
                                    switch (chars[21])
                                      {
                                        case 'N':
                                            if ((String.Compare(chars, 22, "oCommand", 0, 8, false) == 0) && (chars.Length == 30))
                                                return TypeClientControlCommandKind.ClientControlCommandKind_ClientControlResponseNoCommand;
                                            break;
                                        case 'Y':
                                            if ((String.Compare(chars, 22, "esCommand", 0, 9, false) == 0) && (chars.Length == 31))
                                                return TypeClientControlCommandKind.ClientControlCommandKind_ClientControlResponseYesCommand;
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
                default:
                    break;
              }
          }
        throw new Exception("The value for field `ClientControlCommandKind' is not one of the legal values.");
      }

    public static string  stringFromClientControlCommandKind(TypeClientControlCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlGoBackCommand:
                return "ClientControlGoBackCommand";
            case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlRepeatCommand:
                return "ClientControlRepeatCommand";
            case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlClearScreenCommand:
                return "ClientControlClearScreenCommand";
            case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlGoForwardCommand:
                return "ClientControlGoForwardCommand";
            case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlResponseYesCommand:
                return "ClientControlResponseYesCommand";
            case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlResponseNoCommand:
                return "ClientControlResponseNoCommand";
            case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlQuitAppCommand:
                return "ClientControlQuitAppCommand";
            case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlGoCommand:
                return "ClientControlGoCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCommandKind;
    private bool flagHasClientControlCommandKind;
    private TypeClientControlCommandKind storeClientControlCommandKind;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandKind of ClientControlQueryStateJSON is not a string.");
        if (!(json_string.getData().Equals("ClientControlCommand")))
            throw new Exception("The value for field CommandKind of ClientControlQueryStateJSON is not `ClientControlCommand'.");
        setCommandKind();
      }


    private void  fromJSONClientControlCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ClientControlCommandKind of ClientControlQueryStateJSON is not a string.");
        TypeClientControlCommandKind the_enum;
        if (String.Compare(json_string.getData(), 0, "ClientControl", 0, 13, false) == 0)
          {
            switch (json_string.getData()[13])
              {
                case 'C':
                    if ((String.Compare(json_string.getData(), 14, "learScreenCommand", 0, 17, false) == 0) && (json_string.getData().Length == 31))
                          {
                            the_enum = TypeClientControlCommandKind.ClientControlCommandKind_ClientControlClearScreenCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'G':
                    if (String.Compare(json_string.getData(), 14, "o", 0, 1, false) == 0)
                      {
                        switch (json_string.getData()[15])
                          {
                            case 'B':
                                if ((String.Compare(json_string.getData(), 16, "ackCommand", 0, 10, false) == 0) && (json_string.getData().Length == 26))
                                      {
                                        the_enum = TypeClientControlCommandKind.ClientControlCommandKind_ClientControlGoBackCommand;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'C':
                                if ((String.Compare(json_string.getData(), 16, "ommand", 0, 6, false) == 0) && (json_string.getData().Length == 22))
                                      {
                                        the_enum = TypeClientControlCommandKind.ClientControlCommandKind_ClientControlGoCommand;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'F':
                                if ((String.Compare(json_string.getData(), 16, "orwardCommand", 0, 13, false) == 0) && (json_string.getData().Length == 29))
                                      {
                                        the_enum = TypeClientControlCommandKind.ClientControlCommandKind_ClientControlGoForwardCommand;
                                        goto enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'Q':
                    if ((String.Compare(json_string.getData(), 14, "uitAppCommand", 0, 13, false) == 0) && (json_string.getData().Length == 27))
                          {
                            the_enum = TypeClientControlCommandKind.ClientControlCommandKind_ClientControlQuitAppCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'R':
                    if (String.Compare(json_string.getData(), 14, "e", 0, 1, false) == 0)
                      {
                        switch (json_string.getData()[15])
                          {
                            case 'p':
                                if ((String.Compare(json_string.getData(), 16, "eatCommand", 0, 10, false) == 0) && (json_string.getData().Length == 26))
                                      {
                                        the_enum = TypeClientControlCommandKind.ClientControlCommandKind_ClientControlRepeatCommand;
                                        goto enum_is_done;
                                      }
                                break;
                            case 's':
                                if (String.Compare(json_string.getData(), 16, "ponse", 0, 5, false) == 0)
                                  {
                                    switch (json_string.getData()[21])
                                      {
                                        case 'N':
                                            if ((String.Compare(json_string.getData(), 22, "oCommand", 0, 8, false) == 0) && (json_string.getData().Length == 30))
                                                  {
                                                    the_enum = TypeClientControlCommandKind.ClientControlCommandKind_ClientControlResponseNoCommand;
                                                    goto enum_is_done;
                                                  }
                                            break;
                                        case 'Y':
                                            if ((String.Compare(json_string.getData(), 22, "esCommand", 0, 9, false) == 0) && (json_string.getData().Length == 31))
                                                  {
                                                    the_enum = TypeClientControlCommandKind.ClientControlCommandKind_ClientControlResponseYesCommand;
                                                    goto enum_is_done;
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
                      }
                    break;
                default:
                    break;
              }
          }
        throw new Exception("The value for field ClientControlCommandKind of ClientControlQueryStateJSON is not one of the legal strings.");
      enum_is_done:;
        setClientControlCommandKind(the_enum);
      }


    public ClientControlQueryStateJSON()
      {
        flagHasCommandKind = false;
        flagHasClientControlCommandKind = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCommandKind()
      {
        return flagHasCommandKind;
      }

    public TypeCommandKind  getCommandKind()
      {
        Debug.Assert(flagHasCommandKind);
        return TypeCommandKind.CommandKind_ClientControlCommand;
      }

    public string  getCommandKindAsString()
      {
        return stringFromCommandKind(getCommandKind());
      }

    public bool  hasClientControlCommandKind()
      {
        return flagHasClientControlCommandKind;
      }

    public TypeClientControlCommandKind  getClientControlCommandKind()
      {
        Debug.Assert(flagHasClientControlCommandKind);
        return storeClientControlCommandKind;
      }

    public string  getClientControlCommandKindAsString()
      {
        return stringFromClientControlCommandKind(getClientControlCommandKind());
      }


    public virtual int extraClientControlQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraClientControlQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraClientControlQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraClientControlQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCommandKind()
      {
        flagHasCommandKind = true;
      }
    public void setCommandKind(TypeCommandKind new_value)
      {
        setCommandKind();
      }
    public void setCommandKind(string chars)
      {
        setCommandKind(stringToCommandKind(chars));
      }
    public void unsetCommandKind()
      {
        flagHasCommandKind = false;
      }
    public void setClientControlCommandKind(TypeClientControlCommandKind new_value)
      {
        flagHasClientControlCommandKind = true;
        storeClientControlCommandKind = new_value;
      }
    public void setClientControlCommandKind(string chars)
      {
        setClientControlCommandKind(stringToClientControlCommandKind(chars));
      }
    public void unsetClientControlCommandKind()
      {
        flagHasClientControlCommandKind = false;
      }

    public virtual void extraClientControlQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraClientControlQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraClientControlQueryStateLookup(key);
        if (old_field == null)
          {
            extraClientControlQueryStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCommandKind);
        if (flagHasCommandKind)
          {
            handler.start_pair("CommandKind");
            handler.string_value("ClientControlCommand");
          }
        Debug.Assert(partial_allowed || flagHasClientControlCommandKind);
        if (flagHasClientControlCommandKind)
          {
            handler.start_pair("ClientControlCommandKind");
            switch (storeClientControlCommandKind)
              {
                case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlGoBackCommand:
                    handler.string_value("ClientControlGoBackCommand");
                    break;
                case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlRepeatCommand:
                    handler.string_value("ClientControlRepeatCommand");
                    break;
                case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlClearScreenCommand:
                    handler.string_value("ClientControlClearScreenCommand");
                    break;
                case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlGoForwardCommand:
                    handler.string_value("ClientControlGoForwardCommand");
                    break;
                case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlResponseYesCommand:
                    handler.string_value("ClientControlResponseYesCommand");
                    break;
                case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlResponseNoCommand:
                    handler.string_value("ClientControlResponseNoCommand");
                    break;
                case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlQuitAppCommand:
                    handler.string_value("ClientControlQuitAppCommand");
                    break;
                case TypeClientControlCommandKind.ClientControlCommandKind_ClientControlGoCommand:
                    handler.string_value("ClientControlGoCommand");
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
        if (!(hasCommandKind()))
          {
            return "When parsing the object for %what%, the \"CommandKind\" field was missing.";
          }
        if (!(hasClientControlCommandKind()))
          {
            return "When parsing the object for %what%, the \"ClientControlCommandKind\" field was missing.";
          }
        return null;
      }

    public static ClientControlQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ClientControlQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientControlQueryState", ignore_extras);
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
    public static ClientControlQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ClientControlQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ClientControlQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientControlQueryState", ignore_extras);
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
    public static ClientControlQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ClientControlQueryStateJSON from_text(string text, bool ignore_extras)
      {
        ClientControlQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientControlQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ClientControlQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ClientControlQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ClientControlQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientControlQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCommandKind(result));
              }
            protected abstract void handle_result(TypeCommandKind result);
          };
    private class FieldHoldingGeneratorCommandKind : FieldGeneratorCommandKind
  {
    protected override void handle_result(TypeCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCommandKind(String what)
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
    public TypeCommandKind value;
  };
    private class FieldHoldingArrayGeneratorCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCommandKind
      {
        private FieldHoldingArrayGeneratorCommandKind top;

        protected override void handle_result(TypeCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCommandKind init_top)
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
    protected virtual void handle_result(List<TypeCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCommandKind> value;
  };
        private FieldHoldingGeneratorCommandKind fieldGeneratorCommandKind;
    private abstract class FieldGeneratorClientControlCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorClientControlCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorClientControlCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToClientControlCommandKind(result));
              }
            protected abstract void handle_result(TypeClientControlCommandKind result);
          };
    private class FieldHoldingGeneratorClientControlCommandKind : FieldGeneratorClientControlCommandKind
  {
    protected override void handle_result(TypeClientControlCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorClientControlCommandKind(String what)
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
    public TypeClientControlCommandKind value;
  };
    private class FieldHoldingArrayGeneratorClientControlCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorClientControlCommandKind
      {
        private FieldHoldingArrayGeneratorClientControlCommandKind top;

        protected override void handle_result(TypeClientControlCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorClientControlCommandKind init_top)
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
    protected virtual void handle_result(List<TypeClientControlCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorClientControlCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeClientControlCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorClientControlCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeClientControlCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeClientControlCommandKind> value;
  };
        private FieldHoldingGeneratorClientControlCommandKind fieldGeneratorClientControlCommandKind;
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
            ClientControlQueryStateJSON result = new ClientControlQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraClientControlQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ClientControlQueryStateJSON result)
          {
            if (fieldGeneratorCommandKind.have_value)
              {
                result.setCommandKind();
                fieldGeneratorCommandKind.have_value = false;
              }
            else if ((!(result.hasCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CommandKind\" field was missing.");
              }
            if (fieldGeneratorClientControlCommandKind.have_value)
              {
                result.setClientControlCommandKind(fieldGeneratorClientControlCommandKind.value);
                fieldGeneratorClientControlCommandKind.have_value = false;
              }
            else if ((!(result.hasClientControlCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ClientControlCommandKind\" field was missing.");
              }
          }
        protected abstract void handle_result(ClientControlQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "C", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'l':
                        if ((String.Compare(field_name, 2, "ientControlCommandKind", 0, 22, false) == 0) && (field_name.Length == 24))
                            return fieldGeneratorClientControlCommandKind;
                        break;
                    case 'o':
                        if ((String.Compare(field_name, 2, "mmandKind", 0, 9, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorCommandKind;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the ClientControlQueryState class");
            fieldGeneratorClientControlCommandKind = new FieldHoldingGeneratorClientControlCommandKind("field \"ClientControlCommandKind\" of the ClientControlQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ClientControlQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the ClientControlQueryState class");
            fieldGeneratorClientControlCommandKind = new FieldHoldingGeneratorClientControlCommandKind("field \"ClientControlCommandKind\" of the ClientControlQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ClientControlQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCommandKind.reset();
            fieldGeneratorClientControlCommandKind.reset();
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
        protected override void handle_result(ClientControlQueryStateJSON  result)
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
        public ClientControlQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ClientControlQueryStateJSON  result)
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
    protected virtual void handle_result(List<ClientControlQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ClientControlQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ClientControlQueryStateJSON>();
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
    public List<ClientControlQueryStateJSON> value;
  };
  };
