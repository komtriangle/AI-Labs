/* file "HomeAutomationConversationStateDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationConversationStateDataJSON : JSONBase
  {
    public enum TypeCommandKind
      {
        CommandKind_HomeAutomationControlCommand,
        CommandKind_HomeAutomationListUserDataCommand,
        CommandKind_HomeAutomationQueryCommand
      };

    public static TypeCommandKind  stringToCommandKind(string chars)
      {
        if (String.Compare(chars, 0, "HomeAutomation", 0, 14, false) == 0)
          {
            switch (chars[14])
              {
                case 'C':
                    if ((String.Compare(chars, 15, "ontrolCommand", 0, 13, false) == 0) && (chars.Length == 28))
                        return TypeCommandKind.CommandKind_HomeAutomationControlCommand;
                    break;
                case 'L':
                    if ((String.Compare(chars, 15, "istUserDataCommand", 0, 18, false) == 0) && (chars.Length == 33))
                        return TypeCommandKind.CommandKind_HomeAutomationListUserDataCommand;
                    break;
                case 'Q':
                    if ((String.Compare(chars, 15, "ueryCommand", 0, 11, false) == 0) && (chars.Length == 26))
                        return TypeCommandKind.CommandKind_HomeAutomationQueryCommand;
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
            case TypeCommandKind.CommandKind_HomeAutomationControlCommand:
                return "HomeAutomationControlCommand";
            case TypeCommandKind.CommandKind_HomeAutomationListUserDataCommand:
                return "HomeAutomationListUserDataCommand";
            case TypeCommandKind.CommandKind_HomeAutomationQueryCommand:
                return "HomeAutomationQueryCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCommandKind;
    private TypeCommandKind storeCommandKind;
    private bool flagHasCompactDeviceSpecifier;
    private HomeAutomationCompactDeviceSpecifierJSON  storeCompactDeviceSpecifier;
    private bool flagHasFilter;
    private HomeAutomationQueryHintJSON  storeFilter;
    private bool flagHasNegativeDelta;
    private bool storeNegativeDelta;
    private bool flagHasColor;
    private ColorJSON  storeColor;
    private bool flagHasTurboMode;
    private HomeAutomationTurboModeJSON  storeTurboMode;
    private bool flagHasChannel;
    private HomeAutomationTVChannelJSON  storeChannel;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandKind of HomeAutomationConversationStateDataJSON is not a string.");
        TypeCommandKind the_enum;
        if (String.Compare(json_string.getData(), 0, "HomeAutomation", 0, 14, false) == 0)
          {
            switch (json_string.getData()[14])
              {
                case 'C':
                    if ((String.Compare(json_string.getData(), 15, "ontrolCommand", 0, 13, false) == 0) && (json_string.getData().Length == 28))
                          {
                            the_enum = TypeCommandKind.CommandKind_HomeAutomationControlCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'L':
                    if ((String.Compare(json_string.getData(), 15, "istUserDataCommand", 0, 18, false) == 0) && (json_string.getData().Length == 33))
                          {
                            the_enum = TypeCommandKind.CommandKind_HomeAutomationListUserDataCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'Q':
                    if ((String.Compare(json_string.getData(), 15, "ueryCommand", 0, 11, false) == 0) && (json_string.getData().Length == 26))
                          {
                            the_enum = TypeCommandKind.CommandKind_HomeAutomationQueryCommand;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
          }
        throw new Exception("The value for field CommandKind of HomeAutomationConversationStateDataJSON is not one of the legal strings.");
      enum_is_done:;
        setCommandKind(the_enum);
      }


    private void  fromJSONCompactDeviceSpecifier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationCompactDeviceSpecifierJSON convert_classy = HomeAutomationCompactDeviceSpecifierJSON.from_json(json_value, ignore_extras, true);
        setCompactDeviceSpecifier(convert_classy);
      }


    private void  fromJSONFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationQueryHintJSON convert_classy = HomeAutomationQueryHintJSON.from_json(json_value, ignore_extras, true);
        setFilter(convert_classy);
      }


    private void  fromJSONNegativeDelta(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field NegativeDelta of HomeAutomationConversationStateDataJSON is not true for false.");
              }
          }
        setNegativeDelta(the_bool);
      }


    private void  fromJSONColor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ColorJSON convert_classy = ColorJSON.from_json(json_value, ignore_extras, true);
        setColor(convert_classy);
      }


    private void  fromJSONTurboMode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationTurboModeJSON convert_classy = HomeAutomationTurboModeJSON.from_json(json_value, ignore_extras, true);
        setTurboMode(convert_classy);
      }


    private void  fromJSONChannel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationTVChannelJSON convert_classy = HomeAutomationTVChannelJSON.from_json(json_value, ignore_extras, true);
        setChannel(convert_classy);
      }


    public HomeAutomationConversationStateDataJSON()
      {
        flagHasCommandKind = false;
        flagHasCompactDeviceSpecifier = false;
        flagHasFilter = false;
        flagHasNegativeDelta = false;
        flagHasColor = false;
        flagHasTurboMode = false;
        flagHasChannel = false;
        storeNegativeDelta = false;
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

    public bool  hasCompactDeviceSpecifier()
      {
        return flagHasCompactDeviceSpecifier;
      }

    public HomeAutomationCompactDeviceSpecifierJSON   getCompactDeviceSpecifier()
      {
        Debug.Assert(flagHasCompactDeviceSpecifier);
        return storeCompactDeviceSpecifier;
      }

    public bool  hasFilter()
      {
        return flagHasFilter;
      }

    public HomeAutomationQueryHintJSON   getFilter()
      {
        Debug.Assert(flagHasFilter);
        return storeFilter;
      }

    public bool  hasNegativeDelta()
      {
        return flagHasNegativeDelta;
      }

    public bool  getNegativeDelta()
      {
        return storeNegativeDelta;
      }

    public bool  hasColor()
      {
        return flagHasColor;
      }

    public ColorJSON   getColor()
      {
        Debug.Assert(flagHasColor);
        return storeColor;
      }

    public bool  hasTurboMode()
      {
        return flagHasTurboMode;
      }

    public HomeAutomationTurboModeJSON   getTurboMode()
      {
        Debug.Assert(flagHasTurboMode);
        return storeTurboMode;
      }

    public HomeAutomationTurboModeJSON.TypeValue  getTurboModeValue()
      {
        return getTurboMode().getValue();
      }

    public string  getTurboModeAsString()
      {
        return getTurboMode().getValueAsString();
      }

    public bool  hasChannel()
      {
        return flagHasChannel;
      }

    public HomeAutomationTVChannelJSON   getChannel()
      {
        Debug.Assert(flagHasChannel);
        return storeChannel;
      }


    public virtual int extraHomeAutomationConversationStateDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationConversationStateDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationConversationStateDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationConversationStateDataLookup(string field_name)
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
    public void setFilter(HomeAutomationQueryHintJSON  new_value)
      {
        if (flagHasFilter)
          {
          }
        flagHasFilter = true;
        storeFilter = new_value;
      }
    public void unsetFilter()
      {
        if (flagHasFilter)
          {
          }
        flagHasFilter = false;
      }
    public void setNegativeDelta(bool new_value)
      {
        flagHasNegativeDelta = true;
        storeNegativeDelta = new_value;
      }
    public void unsetNegativeDelta()
      {
        flagHasNegativeDelta = false;
      }
    public void setColor(ColorJSON  new_value)
      {
        if (flagHasColor)
          {
          }
        flagHasColor = true;
        storeColor = new_value;
      }
    public void unsetColor()
      {
        if (flagHasColor)
          {
          }
        flagHasColor = false;
      }
    public void setTurboMode(HomeAutomationTurboModeJSON  new_value)
      {
        if (flagHasTurboMode)
          {
          }
        flagHasTurboMode = true;
        storeTurboMode = new_value;
      }
    public void setTurboMode(HomeAutomationTurboModeJSON.TypeValue new_value)
      {
        setTurboMode(new HomeAutomationTurboModeJSON(new_value));
      }
    public void setTurboMode(string chars)
      {
        HomeAutomationTurboModeJSON.TypeValueKnownValues known = HomeAutomationTurboModeJSON.stringToValue(chars);
        HomeAutomationTurboModeJSON.TypeValue new_value = new HomeAutomationTurboModeJSON.TypeValue();
        if (known == HomeAutomationTurboModeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setTurboMode(new_value);
      }
    public void unsetTurboMode()
      {
        if (flagHasTurboMode)
          {
          }
        flagHasTurboMode = false;
      }
    public void setChannel(HomeAutomationTVChannelJSON  new_value)
      {
        if (flagHasChannel)
          {
          }
        flagHasChannel = true;
        storeChannel = new_value;
      }
    public void unsetChannel()
      {
        if (flagHasChannel)
          {
          }
        flagHasChannel = false;
      }

    public virtual void extraHomeAutomationConversationStateDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationConversationStateDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationConversationStateDataLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationConversationStateDataAppendPair(key, new_component);
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
            switch (storeCommandKind)
              {
                case TypeCommandKind.CommandKind_HomeAutomationControlCommand:
                    handler.string_value("HomeAutomationControlCommand");
                    break;
                case TypeCommandKind.CommandKind_HomeAutomationListUserDataCommand:
                    handler.string_value("HomeAutomationListUserDataCommand");
                    break;
                case TypeCommandKind.CommandKind_HomeAutomationQueryCommand:
                    handler.string_value("HomeAutomationQueryCommand");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasCompactDeviceSpecifier);
        if (flagHasCompactDeviceSpecifier)
          {
            handler.start_pair("CompactDeviceSpecifier");
            if (partial_allowed)
                storeCompactDeviceSpecifier.write_partial_as_json(handler);
            else
                storeCompactDeviceSpecifier.write_as_json(handler);
          }
        if (flagHasFilter)
          {
            handler.start_pair("Filter");
            if (partial_allowed)
                storeFilter.write_partial_as_json(handler);
            else
                storeFilter.write_as_json(handler);
          }
        if (flagHasNegativeDelta)
          {
            handler.start_pair("NegativeDelta");
            handler.boolean_value(storeNegativeDelta);
          }
        if (flagHasColor)
          {
            handler.start_pair("Color");
            if (partial_allowed)
                storeColor.write_partial_as_json(handler);
            else
                storeColor.write_as_json(handler);
          }
        if (flagHasTurboMode)
          {
            handler.start_pair("TurboMode");
            if (partial_allowed)
                storeTurboMode.write_partial_as_json(handler);
            else
                storeTurboMode.write_as_json(handler);
          }
        if (flagHasChannel)
          {
            handler.start_pair("Channel");
            if (partial_allowed)
                storeChannel.write_partial_as_json(handler);
            else
                storeChannel.write_as_json(handler);
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
        if (!(hasCompactDeviceSpecifier()))
          {
            return "When parsing the object for %what%, the \"CompactDeviceSpecifier\" field was missing.";
          }
        return null;
      }

    public static HomeAutomationConversationStateDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationConversationStateDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationConversationStateData", ignore_extras);
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
    public static HomeAutomationConversationStateDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationConversationStateDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationConversationStateDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationConversationStateData", ignore_extras);
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
    public static HomeAutomationConversationStateDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationConversationStateDataJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationConversationStateDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationConversationStateData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationConversationStateDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationConversationStateDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationConversationStateDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationConversationStateData", ignore_extras);
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
        private HomeAutomationCompactDeviceSpecifierJSON.HoldingGenerator fieldGeneratorCompactDeviceSpecifier;
        private HomeAutomationQueryHintJSON.HoldingGenerator fieldGeneratorFilter;
        private JSONHoldingBooleanGenerator fieldGeneratorNegativeDelta;
        private ColorJSON.HoldingGenerator fieldGeneratorColor;
        private HomeAutomationTurboModeJSON.HoldingGenerator fieldGeneratorTurboMode;
        private HomeAutomationTVChannelJSON.HoldingGenerator fieldGeneratorChannel;
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
            HomeAutomationConversationStateDataJSON result = new HomeAutomationConversationStateDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationConversationStateDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HomeAutomationConversationStateDataJSON result)
          {
            if (fieldGeneratorCommandKind.have_value)
              {
                result.setCommandKind(fieldGeneratorCommandKind.value);
                fieldGeneratorCommandKind.have_value = false;
              }
            else if ((!(result.hasCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CommandKind\" field was missing.");
              }
            if (fieldGeneratorCompactDeviceSpecifier.have_value)
              {
                result.setCompactDeviceSpecifier(fieldGeneratorCompactDeviceSpecifier.value);
                fieldGeneratorCompactDeviceSpecifier.have_value = false;
              }
            else if ((!(result.hasCompactDeviceSpecifier())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CompactDeviceSpecifier\" field was missing.");
              }
            if (fieldGeneratorFilter.have_value)
              {
                result.setFilter(fieldGeneratorFilter.value);
                fieldGeneratorFilter.have_value = false;
              }
            if (fieldGeneratorNegativeDelta.have_value)
              {
                result.setNegativeDelta(fieldGeneratorNegativeDelta.value);
                fieldGeneratorNegativeDelta.have_value = false;
              }
            if (fieldGeneratorColor.have_value)
              {
                result.setColor(fieldGeneratorColor.value);
                fieldGeneratorColor.have_value = false;
              }
            if (fieldGeneratorTurboMode.have_value)
              {
                result.setTurboMode(fieldGeneratorTurboMode.value);
                fieldGeneratorTurboMode.have_value = false;
              }
            if (fieldGeneratorChannel.have_value)
              {
                result.setChannel(fieldGeneratorChannel.value);
                fieldGeneratorChannel.have_value = false;
              }
          }
        protected abstract void handle_result(HomeAutomationConversationStateDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "annel", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorChannel;
                            break;
                        case 'o':
                            switch (field_name[2])
                              {
                                case 'l':
                                    if ((String.Compare(field_name, 3, "or", 0, 2, false) == 0) && (field_name.Length == 5))
                                        return fieldGeneratorColor;
                                    break;
                                case 'm':
                                    switch (field_name[3])
                                      {
                                        case 'm':
                                            if ((String.Compare(field_name, 4, "andKind", 0, 7, false) == 0) && (field_name.Length == 11))
                                                return fieldGeneratorCommandKind;
                                            break;
                                        case 'p':
                                            if ((String.Compare(field_name, 4, "actDeviceSpecifier", 0, 18, false) == 0) && (field_name.Length == 22))
                                                return fieldGeneratorCompactDeviceSpecifier;
                                            break;
                                        default:
                                            break;
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
                case 'F':
                    if ((String.Compare(field_name, 1, "ilter", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorFilter;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "egativeDelta", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorNegativeDelta;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "urboMode", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorTurboMode;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the HomeAutomationConversationStateData class");
            fieldGeneratorCompactDeviceSpecifier = new HomeAutomationCompactDeviceSpecifierJSON.HoldingGenerator("field \"CompactDeviceSpecifier\" of the HomeAutomationConversationStateData class", ignore_extras);
            fieldGeneratorFilter = new HomeAutomationQueryHintJSON.HoldingGenerator("field \"Filter\" of the HomeAutomationConversationStateData class", ignore_extras);
            fieldGeneratorNegativeDelta = new JSONHoldingBooleanGenerator("field \"NegativeDelta\" of the HomeAutomationConversationStateData class");
            fieldGeneratorColor = new ColorJSON.HoldingGenerator("field \"Color\" of the HomeAutomationConversationStateData class", ignore_extras);
            fieldGeneratorTurboMode = new HomeAutomationTurboModeJSON.HoldingGenerator("field \"TurboMode\" of the HomeAutomationConversationStateData class", ignore_extras);
            fieldGeneratorChannel = new HomeAutomationTVChannelJSON.HoldingGenerator("field \"Channel\" of the HomeAutomationConversationStateData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationConversationStateData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the HomeAutomationConversationStateData class");
            fieldGeneratorCompactDeviceSpecifier = new HomeAutomationCompactDeviceSpecifierJSON.HoldingGenerator("field \"CompactDeviceSpecifier\" of the HomeAutomationConversationStateData class", false);
            fieldGeneratorFilter = new HomeAutomationQueryHintJSON.HoldingGenerator("field \"Filter\" of the HomeAutomationConversationStateData class", false);
            fieldGeneratorNegativeDelta = new JSONHoldingBooleanGenerator("field \"NegativeDelta\" of the HomeAutomationConversationStateData class");
            fieldGeneratorColor = new ColorJSON.HoldingGenerator("field \"Color\" of the HomeAutomationConversationStateData class", false);
            fieldGeneratorTurboMode = new HomeAutomationTurboModeJSON.HoldingGenerator("field \"TurboMode\" of the HomeAutomationConversationStateData class", false);
            fieldGeneratorChannel = new HomeAutomationTVChannelJSON.HoldingGenerator("field \"Channel\" of the HomeAutomationConversationStateData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationConversationStateData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCommandKind.reset();
            fieldGeneratorCompactDeviceSpecifier.reset();
            fieldGeneratorFilter.reset();
            fieldGeneratorNegativeDelta.reset();
            fieldGeneratorColor.reset();
            fieldGeneratorTurboMode.reset();
            fieldGeneratorChannel.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorCompactDeviceSpecifier.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFilter.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorColor.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTurboMode.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorChannel.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorCompactDeviceSpecifier.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFilter.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorColor.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTurboMode.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorChannel.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationConversationStateDataJSON  result)
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
        public HomeAutomationConversationStateDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationConversationStateDataJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationConversationStateDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationConversationStateDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationConversationStateDataJSON>();
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
    public List<HomeAutomationConversationStateDataJSON> value;
  };
  };
