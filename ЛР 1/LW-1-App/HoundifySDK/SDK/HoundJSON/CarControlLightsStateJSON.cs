/* file "CarControlLightsStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarControlLightsStateJSON : JSONBase
  {
    public enum TypeCommandKind
      {
        CommandKind_CarControlLightsIntoModeCommand,
        CommandKind_CarControlLightsModeNotUnderstood
      };

    public static TypeCommandKind  stringToCommandKind(string chars)
      {
        if (String.Compare(chars, 0, "CarControlLights", 0, 16, false) == 0)
          {
            switch (chars[16])
              {
                case 'I':
                    if ((String.Compare(chars, 17, "ntoModeCommand", 0, 14, false) == 0) && (chars.Length == 31))
                        return TypeCommandKind.CommandKind_CarControlLightsIntoModeCommand;
                    break;
                case 'M':
                    if ((String.Compare(chars, 17, "odeNotUnderstood", 0, 16, false) == 0) && (chars.Length == 33))
                        return TypeCommandKind.CommandKind_CarControlLightsModeNotUnderstood;
                    break;
                default:
                    break;
              }
          }
        throw new Exception("The value for field `CommandKind' is not one of the legal values.");
      }

    public static string  stringFromCommandKind(TypeCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeCommandKind.CommandKind_CarControlLightsIntoModeCommand:
                return "CarControlLightsIntoModeCommand";
            case TypeCommandKind.CommandKind_CarControlLightsModeNotUnderstood:
                return "CarControlLightsModeNotUnderstood";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeMode
      {
        Mode_CarControlLights
      };

    public static TypeMode  stringToMode(string chars)
      {
        if ((String.Compare(chars, 0, "CarControlLights", 0, 16, false) == 0) && (chars.Length == 16))
            return TypeMode.Mode_CarControlLights;
        throw new Exception("The value for field `Mode' is not one of the legal values.");
      }

    public static string  stringFromMode(TypeMode the_enum)
      {
        switch (the_enum)
          {
            case TypeMode.Mode_CarControlLights:
                return "CarControlLights";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeProposedAction
      {
        ProposedAction_FogLightsOn,
        ProposedAction_HighBeamsOn
      };

    public static TypeProposedAction  stringToProposedAction(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if ((String.Compare(chars, 1, "ogLightsOn", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeProposedAction.ProposedAction_FogLightsOn;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "ighBeamsOn", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeProposedAction.ProposedAction_HighBeamsOn;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `ProposedAction' is not one of the legal values.");
      }

    public static string  stringFromProposedAction(TypeProposedAction the_enum)
      {
        switch (the_enum)
          {
            case TypeProposedAction.ProposedAction_FogLightsOn:
                return "FogLightsOn";
            case TypeProposedAction.ProposedAction_HighBeamsOn:
                return "HighBeamsOn";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCommandKind;
    private TypeCommandKind storeCommandKind;
    private bool flagHasMode;
    private bool flagHasProposedAction;
    private TypeProposedAction storeProposedAction;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandKind of CarControlLightsStateJSON is not a string.");
        TypeCommandKind the_enum;
        if (String.Compare(json_string.getData(), 0, "CarControlLights", 0, 16, false) == 0)
          {
            switch (json_string.getData()[16])
              {
                case 'I':
                    if ((String.Compare(json_string.getData(), 17, "ntoModeCommand", 0, 14, false) == 0) && (json_string.getData().Length == 31))
                          {
                            the_enum = TypeCommandKind.CommandKind_CarControlLightsIntoModeCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'M':
                    if ((String.Compare(json_string.getData(), 17, "odeNotUnderstood", 0, 16, false) == 0) && (json_string.getData().Length == 33))
                          {
                            the_enum = TypeCommandKind.CommandKind_CarControlLightsModeNotUnderstood;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
          }
        throw new Exception("The value for field CommandKind of CarControlLightsStateJSON is not one of the legal strings.");
      enum_is_done:;
        setCommandKind(the_enum);
      }


    private void  fromJSONMode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Mode of CarControlLightsStateJSON is not a string.");
        if (!(json_string.getData().Equals("CarControlLights")))
            throw new Exception("The value for field Mode of CarControlLightsStateJSON is not `CarControlLights'.");
        setMode();
      }


    private void  fromJSONProposedAction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ProposedAction of CarControlLightsStateJSON is not a string.");
        TypeProposedAction the_enum;
        switch (json_string.getData()[0])
          {
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "ogLightsOn", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeProposedAction.ProposedAction_FogLightsOn;
                        goto enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "ighBeamsOn", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeProposedAction.ProposedAction_HighBeamsOn;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field ProposedAction of CarControlLightsStateJSON is not one of the legal strings.");
      enum_is_done:;
        setProposedAction(the_enum);
      }


    public CarControlLightsStateJSON()
      {
        flagHasCommandKind = false;
        flagHasMode = false;
        flagHasProposedAction = false;
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
        return storeCommandKind;
      }

    public string  getCommandKindAsString()
      {
        return stringFromCommandKind(getCommandKind());
      }

    public bool  hasMode()
      {
        return flagHasMode;
      }

    public TypeMode  getMode()
      {
        Debug.Assert(flagHasMode);
        return TypeMode.Mode_CarControlLights;
      }

    public string  getModeAsString()
      {
        return stringFromMode(getMode());
      }

    public bool  hasProposedAction()
      {
        return flagHasProposedAction;
      }

    public TypeProposedAction  getProposedAction()
      {
        Debug.Assert(flagHasProposedAction);
        return storeProposedAction;
      }

    public string  getProposedActionAsString()
      {
        return stringFromProposedAction(getProposedAction());
      }


    public virtual int extraCarControlLightsStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarControlLightsStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarControlLightsStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarControlLightsStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCommandKind(TypeCommandKind new_value)
      {
        flagHasCommandKind = true;
        storeCommandKind = new_value;
      }
    public void setCommandKind(string chars)
      {
        setCommandKind(stringToCommandKind(chars));
      }
    public void unsetCommandKind()
      {
        flagHasCommandKind = false;
      }
    public void setMode()
      {
        flagHasMode = true;
      }
    public void setMode(TypeMode new_value)
      {
        setMode();
      }
    public void setMode(string chars)
      {
        setMode(stringToMode(chars));
      }
    public void unsetMode()
      {
        flagHasMode = false;
      }
    public void setProposedAction(TypeProposedAction new_value)
      {
        flagHasProposedAction = true;
        storeProposedAction = new_value;
      }
    public void setProposedAction(string chars)
      {
        setProposedAction(stringToProposedAction(chars));
      }
    public void unsetProposedAction()
      {
        flagHasProposedAction = false;
      }

    public virtual void extraCarControlLightsStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarControlLightsStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarControlLightsStateLookup(key);
        if (old_field == null)
          {
            extraCarControlLightsStateAppendPair(key, new_component);
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
        if (flagHasCommandKind)
          {
            handler.start_pair("CommandKind");
            switch (storeCommandKind)
              {
                case TypeCommandKind.CommandKind_CarControlLightsIntoModeCommand:
                    handler.string_value("CarControlLightsIntoModeCommand");
                    break;
                case TypeCommandKind.CommandKind_CarControlLightsModeNotUnderstood:
                    handler.string_value("CarControlLightsModeNotUnderstood");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasMode)
          {
            handler.start_pair("Mode");
            handler.string_value("CarControlLights");
          }
        if (flagHasProposedAction)
          {
            handler.start_pair("ProposedAction");
            switch (storeProposedAction)
              {
                case TypeProposedAction.ProposedAction_FogLightsOn:
                    handler.string_value("FogLightsOn");
                    break;
                case TypeProposedAction.ProposedAction_HighBeamsOn:
                    handler.string_value("HighBeamsOn");
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
        return null;
      }

    public static CarControlLightsStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlLightsStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlLightsState", ignore_extras);
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
    public static CarControlLightsStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarControlLightsStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlLightsStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlLightsState", ignore_extras);
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
    public static CarControlLightsStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarControlLightsStateJSON from_text(string text, bool ignore_extras)
      {
        CarControlLightsStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlLightsState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarControlLightsStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CarControlLightsStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarControlLightsStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlLightsState", ignore_extras);
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
    private abstract class FieldGeneratorMode : JSONStringGenerator
          {
            protected FieldGeneratorMode(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorMode()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToMode(result));
              }
            protected abstract void handle_result(TypeMode result);
          };
    private class FieldHoldingGeneratorMode : FieldGeneratorMode
  {
    protected override void handle_result(TypeMode result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorMode(String what)
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
    public TypeMode value;
  };
    private class FieldHoldingArrayGeneratorMode : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorMode
      {
        private FieldHoldingArrayGeneratorMode top;

        protected override void handle_result(TypeMode result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorMode init_top)
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
    protected virtual void handle_result(List<TypeMode> result)
      {
      }

    public FieldHoldingArrayGeneratorMode(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMode>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorMode()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMode>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeMode> value;
  };
        private FieldHoldingGeneratorMode fieldGeneratorMode;
    private abstract class FieldGeneratorProposedAction : JSONStringGenerator
          {
            protected FieldGeneratorProposedAction(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorProposedAction()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToProposedAction(result));
              }
            protected abstract void handle_result(TypeProposedAction result);
          };
    private class FieldHoldingGeneratorProposedAction : FieldGeneratorProposedAction
  {
    protected override void handle_result(TypeProposedAction result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorProposedAction(String what)
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
    public TypeProposedAction value;
  };
    private class FieldHoldingArrayGeneratorProposedAction : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorProposedAction
      {
        private FieldHoldingArrayGeneratorProposedAction top;

        protected override void handle_result(TypeProposedAction result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorProposedAction init_top)
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
    protected virtual void handle_result(List<TypeProposedAction> result)
      {
      }

    public FieldHoldingArrayGeneratorProposedAction(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeProposedAction>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorProposedAction()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeProposedAction>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeProposedAction> value;
  };
        private FieldHoldingGeneratorProposedAction fieldGeneratorProposedAction;
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
            CarControlLightsStateJSON result = new CarControlLightsStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarControlLightsStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CarControlLightsStateJSON result)
          {
            if (fieldGeneratorCommandKind.have_value)
              {
                result.setCommandKind(fieldGeneratorCommandKind.value);
                fieldGeneratorCommandKind.have_value = false;
              }
            if (fieldGeneratorMode.have_value)
              {
                result.setMode();
                fieldGeneratorMode.have_value = false;
              }
            if (fieldGeneratorProposedAction.have_value)
              {
                result.setProposedAction(fieldGeneratorProposedAction.value);
                fieldGeneratorProposedAction.have_value = false;
              }
          }
        protected abstract void handle_result(CarControlLightsStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ommandKind", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCommandKind;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "ode", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorMode;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "roposedAction", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorProposedAction;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the CarControlLightsState class");
            fieldGeneratorMode = new FieldHoldingGeneratorMode("field \"Mode\" of the CarControlLightsState class");
            fieldGeneratorProposedAction = new FieldHoldingGeneratorProposedAction("field \"ProposedAction\" of the CarControlLightsState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarControlLightsState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the CarControlLightsState class");
            fieldGeneratorMode = new FieldHoldingGeneratorMode("field \"Mode\" of the CarControlLightsState class");
            fieldGeneratorProposedAction = new FieldHoldingGeneratorProposedAction("field \"ProposedAction\" of the CarControlLightsState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarControlLightsState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCommandKind.reset();
            fieldGeneratorMode.reset();
            fieldGeneratorProposedAction.reset();
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
        protected override void handle_result(CarControlLightsStateJSON  result)
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
        public CarControlLightsStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarControlLightsStateJSON  result)
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
    protected virtual void handle_result(List<CarControlLightsStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarControlLightsStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarControlLightsStateJSON>();
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
    public List<CarControlLightsStateJSON> value;
  };
  };
