/* file "SetClientTokenOAuth2CommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SetClientTokenOAuth2CommandJSON : OAuth2CommandJSON
  {
    public enum TypeStatusKnownValues
      {
        Status_set,
        Status_deleted,
        Status__none
      };
    public struct TypeStatus
      {
        public bool in_known_list;
        public string string_value;
        public TypeStatusKnownValues list_value;
      };

    public static TypeStatusKnownValues  stringToStatus(string chars)
      {
        switch (chars[0])
          {
            case 'd':
                if ((String.Compare(chars, 1, "eleted", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeStatusKnownValues.Status_deleted;
                break;
            case 's':
                if ((String.Compare(chars, 1, "et", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeStatusKnownValues.Status_set;
                break;
            default:
                break;
          }
        return TypeStatusKnownValues.Status__none;
      }

    public static string  stringFromStatus(TypeStatusKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeStatusKnownValues.Status_set:
                return "set";
            case TypeStatusKnownValues.Status_deleted:
                return "deleted";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasServiceType;
    private OAuth2ServiceTypeJSON  storeServiceType;
    private bool flagHasStatus;
    private TypeStatus storeStatus;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraServiceTypeToJSON()
      {
        JSONValueHandler handler_ServiceType = new JSONValueHandler();
        storeServiceType.write_as_json(handler_ServiceType);
        return handler_ServiceType.result;
      }

    private JSONValue  extraStatusToJSON()
      {
        JSONStringValue generated_string_Status;
        if (!(storeStatus.in_known_list))
          {
        generated_string_Status = new JSONStringValue(storeStatus.string_value);
          }
        else
          {
        switch (storeStatus.list_value)
          {
            case TypeStatusKnownValues.Status_set:
                generated_string_Status = new JSONStringValue("set");
                break;
            case TypeStatusKnownValues.Status_deleted:
                generated_string_Status = new JSONStringValue("deleted");
                break;
            default:
                Debug.Assert(false);
                generated_string_Status = null;
                break;
          }
          }
        return generated_string_Status;
      }


    private void  fromJSONServiceType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OAuth2ServiceTypeJSON convert_classy = OAuth2ServiceTypeJSON.from_json(json_value, ignore_extras, true);
        setServiceType(convert_classy);
      }


    private void  fromJSONStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Status of SetClientTokenOAuth2CommandJSON is not a string.");
        TypeStatus the_open_enum = new TypeStatus();
        switch (json_string.getData()[0])
          {
            case 'd':
                if ((String.Compare(json_string.getData(), 1, "eleted", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_deleted;
                        goto open_enum_is_done;
                      }
                break;
            case 's':
                if ((String.Compare(json_string.getData(), 1, "et", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_set;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setStatus(the_open_enum);
      }


    public SetClientTokenOAuth2CommandJSON()
      {
        flagHasServiceType = false;
        flagHasStatus = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getOAuth2CommandKind()
      {
        return "SetClientTokenOAuth2Command";
      }

    public bool  hasServiceType()
      {
        return flagHasServiceType;
      }

    public OAuth2ServiceTypeJSON   getServiceType()
      {
        Debug.Assert(flagHasServiceType);
        return storeServiceType;
      }

    public OAuth2ServiceTypeJSON.TypeValue  getServiceTypeValue()
      {
        return getServiceType().getValue();
      }

    public string  getServiceTypeAsString()
      {
        return getServiceType().getValueAsString();
      }

    public bool  hasStatus()
      {
        return flagHasStatus;
      }

    public TypeStatus  getStatus()
      {
        Debug.Assert(flagHasStatus);
        return storeStatus;
      }

    public string  getStatusAsString()
      {
        TypeStatus result = getStatus();
        if (result.in_known_list)
            return stringFromStatus(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraSetClientTokenOAuth2CommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSetClientTokenOAuth2CommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSetClientTokenOAuth2CommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSetClientTokenOAuth2CommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraOAuth2CommandComponentCount()
      {
        int result = 0;
        if (flagHasServiceType)
            ++result;
        if (flagHasStatus)
            ++result;
        result += extraSetClientTokenOAuth2CommandComponentCount();
        return result;
      }
    public override string extraOAuth2CommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasServiceType)
          {
            if (remainder == 0)
                return "ServiceType";
            --remainder;
          }
        if (flagHasStatus)
          {
            if (remainder == 0)
                return "Status";
            --remainder;
          }
        return extraSetClientTokenOAuth2CommandComponentKey(remainder);
      }
    public override JSONValue extraOAuth2CommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasServiceType)
          {
            if (remainder == 0)
                return extraServiceTypeToJSON();
            --remainder;
          }
        if (flagHasStatus)
          {
            if (remainder == 0)
                return extraStatusToJSON();
            --remainder;
          }
        return extraSetClientTokenOAuth2CommandComponentValue(remainder);
      }
    public override JSONValue extraOAuth2CommandLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "S", 0, 1, false) == 0)
          {
            switch (field_name[1])
              {
                case 'e':
                    if ((String.Compare(field_name, 2, "rviceType", 0, 9, false) == 0) && (field_name.Length == 11))
                        return (flagHasServiceType ? extraServiceTypeToJSON() : null);
                    break;
                case 't':
                    if ((String.Compare(field_name, 2, "atus", 0, 4, false) == 0) && (field_name.Length == 6))
                        return (flagHasStatus ? extraStatusToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraSetClientTokenOAuth2CommandLookup(field_name);
      }

    public void setServiceType(OAuth2ServiceTypeJSON  new_value)
      {
        if (flagHasServiceType)
          {
          }
        flagHasServiceType = true;
        storeServiceType = new_value;
      }
    public void setServiceType(OAuth2ServiceTypeJSON.TypeValue new_value)
      {
        setServiceType(new OAuth2ServiceTypeJSON(new_value));
      }
    public void setServiceType(string chars)
      {
        OAuth2ServiceTypeJSON.TypeValueKnownValues known = OAuth2ServiceTypeJSON.stringToValue(chars);
        OAuth2ServiceTypeJSON.TypeValue new_value = new OAuth2ServiceTypeJSON.TypeValue();
        if (known == OAuth2ServiceTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setServiceType(new_value);
      }
    public void unsetServiceType()
      {
        if (flagHasServiceType)
          {
          }
        flagHasServiceType = false;
      }
    public void setStatus(TypeStatus new_value)
      {
        flagHasStatus = true;
        storeStatus = new_value;
      }
    public void setStatus(string chars)
      {
        TypeStatusKnownValues known = stringToStatus(chars);
        TypeStatus new_value = new TypeStatus();
        if (known == TypeStatusKnownValues.Status__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setStatus(new_value);
      }
    public void setStatus(TypeStatusKnownValues new_value)
      {
        TypeStatus new_full_value = new TypeStatus();
        Debug.Assert(new_value != TypeStatusKnownValues.Status__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setStatus(new_full_value);
      }
    public void unsetStatus()
      {
        flagHasStatus = false;
      }

    public virtual void extraSetClientTokenOAuth2CommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSetClientTokenOAuth2CommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSetClientTokenOAuth2CommandLookup(key);
        if (old_field == null)
          {
            extraSetClientTokenOAuth2CommandAppendPair(key, new_component);
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
    public override void extraOAuth2CommandAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "S", 0, 1, false) == 0)
          {
            switch (key[1])
              {
                case 'e':
                    if ((String.Compare(key, 2, "rviceType", 0, 9, false) == 0) && (key.Length == 11))
                        {
                        fromJSONServiceType(new_component, false);
                        return;
                        }
                    break;
                case 't':
                    if ((String.Compare(key, 2, "atus", 0, 4, false) == 0) && (key.Length == 6))
                        {
                        fromJSONStatus(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraSetClientTokenOAuth2CommandAppendPair(key, new_component);
      }
    public override void extraOAuth2CommandSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "S", 0, 1, false) == 0)
          {
            switch (key[1])
              {
                case 'e':
                    if ((String.Compare(key, 2, "rviceType", 0, 9, false) == 0) && (key.Length == 11))
                        {
                        fromJSONServiceType(new_component, false);
                        return;
                        }
                    break;
                case 't':
                    if ((String.Compare(key, 2, "atus", 0, 4, false) == 0) && (key.Length == 6))
                        {
                        fromJSONStatus(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraSetClientTokenOAuth2CommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasServiceType);
        if (flagHasServiceType)
          {
            handler.start_pair("ServiceType");
            if (partial_allowed)
                storeServiceType.write_partial_as_json(handler);
            else
                storeServiceType.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStatus);
        if (flagHasStatus)
          {
            handler.start_pair("Status");
            if (storeStatus.in_known_list)
              {
                switch (storeStatus.list_value)
                  {
                    case TypeStatusKnownValues.Status_set:
                        handler.string_value("set");
                        break;
                    case TypeStatusKnownValues.Status_deleted:
                        handler.string_value("deleted");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeStatus.string_value);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasServiceType()))
          {
            return "When parsing the object for %what%, the \"ServiceType\" field was missing.";
          }
        if (!(hasStatus()))
          {
            return "When parsing the object for %what%, the \"Status\" field was missing.";
          }
        return null;
      }

    public static new SetClientTokenOAuth2CommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SetClientTokenOAuth2CommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SetClientTokenOAuth2Command", ignore_extras);
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
    public static new SetClientTokenOAuth2CommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SetClientTokenOAuth2CommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SetClientTokenOAuth2CommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SetClientTokenOAuth2Command", ignore_extras);
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
    public static new SetClientTokenOAuth2CommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SetClientTokenOAuth2CommandJSON from_text(string text, bool ignore_extras)
      {
        SetClientTokenOAuth2CommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SetClientTokenOAuth2Command", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SetClientTokenOAuth2CommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SetClientTokenOAuth2CommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SetClientTokenOAuth2CommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SetClientTokenOAuth2Command", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : OAuth2CommandJSON.Generator
      {
        private OAuth2ServiceTypeJSON.HoldingGenerator fieldGeneratorServiceType;
    private abstract class FieldGeneratorStatus : JSONStringGenerator
          {
            protected FieldGeneratorStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorStatus()
              {
              }
            protected override void handle_result(string result)
              {
                TypeStatusKnownValues known = stringToStatus(result);
                TypeStatus new_value = new TypeStatus();
                if (known == TypeStatusKnownValues.Status__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeStatus result);
          };
    private class FieldHoldingGeneratorStatus : FieldGeneratorStatus
  {
    protected override void handle_result(TypeStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorStatus(String what)
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
    public TypeStatus value;
  };
    private class FieldHoldingArrayGeneratorStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorStatus
      {
        private FieldHoldingArrayGeneratorStatus top;

        protected override void handle_result(TypeStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorStatus init_top)
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
    protected virtual void handle_result(List<TypeStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeStatus> value;
  };
        private FieldHoldingGeneratorStatus fieldGeneratorStatus;
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
            if (!(getOAuth2CommandJSONKey().Equals("SetClientTokenOAuth2Command")))
                throw new Exception("The key field has a value other than `SetClientTokenOAuth2Command'.");
            SetClientTokenOAuth2CommandJSON result = new SetClientTokenOAuth2CommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSetClientTokenOAuth2CommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(OAuth2CommandJSON new_result)
          {
            handle_result((SetClientTokenOAuth2CommandJSON )new_result);
          }
        protected void finish(SetClientTokenOAuth2CommandJSON result)
          {
            if (fieldGeneratorServiceType.have_value)
              {
                result.setServiceType(fieldGeneratorServiceType.value);
                fieldGeneratorServiceType.have_value = false;
              }
            else if ((!(result.hasServiceType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ServiceType\" field was missing.");
              }
            if (fieldGeneratorStatus.have_value)
              {
                result.setStatus(fieldGeneratorStatus.value);
                fieldGeneratorStatus.have_value = false;
              }
            else if ((!(result.hasStatus())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Status\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SetClientTokenOAuth2CommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "S", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'e':
                        if ((String.Compare(field_name, 2, "rviceType", 0, 9, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorServiceType;
                        break;
                    case 't':
                        if ((String.Compare(field_name, 2, "atus", 0, 4, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorStatus;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorServiceType = new OAuth2ServiceTypeJSON.HoldingGenerator("field \"ServiceType\" of the SetClientTokenOAuth2Command class", ignore_extras);
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the SetClientTokenOAuth2Command class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SetClientTokenOAuth2Command class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorServiceType = new OAuth2ServiceTypeJSON.HoldingGenerator("field \"ServiceType\" of the SetClientTokenOAuth2Command class", false);
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the SetClientTokenOAuth2Command class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SetClientTokenOAuth2Command class");
          }

        public override void reset()
          {
            fieldGeneratorServiceType.reset();
            fieldGeneratorStatus.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SetClientTokenOAuth2CommandJSON  result)
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
        public SetClientTokenOAuth2CommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SetClientTokenOAuth2CommandJSON  result)
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
    protected virtual void handle_result(List<SetClientTokenOAuth2CommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SetClientTokenOAuth2CommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SetClientTokenOAuth2CommandJSON>();
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
    public List<SetClientTokenOAuth2CommandJSON> value;
  };
  };
