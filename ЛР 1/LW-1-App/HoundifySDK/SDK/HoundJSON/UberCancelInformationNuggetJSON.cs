/* file "UberCancelInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberCancelInformationNuggetJSON : UberInformationNuggetJSON
  {
    public enum TypeStatusKnownValues
      {
        Status_success,
        Status_no_current_trip,
        Status_cancel_cash_trip_not_allowed,
        Status_failure,
        Status_unauthorized,
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
            case 'c':
                if ((String.Compare(chars, 1, "ancel_cash_trip_not_allowed", 0, 27, false) == 0) && (chars.Length == 28))
                    return TypeStatusKnownValues.Status_cancel_cash_trip_not_allowed;
                break;
            case 'f':
                if ((String.Compare(chars, 1, "ailure", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeStatusKnownValues.Status_failure;
                break;
            case 'n':
                if ((String.Compare(chars, 1, "o_current_trip", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeStatusKnownValues.Status_no_current_trip;
                break;
            case 's':
                if ((String.Compare(chars, 1, "uccess", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeStatusKnownValues.Status_success;
                break;
            case 'u':
                if ((String.Compare(chars, 1, "nauthorized", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeStatusKnownValues.Status_unauthorized;
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
            case TypeStatusKnownValues.Status_success:
                return "success";
            case TypeStatusKnownValues.Status_no_current_trip:
                return "no_current_trip";
            case TypeStatusKnownValues.Status_cancel_cash_trip_not_allowed:
                return "cancel_cash_trip_not_allowed";
            case TypeStatusKnownValues.Status_failure:
                return "failure";
            case TypeStatusKnownValues.Status_unauthorized:
                return "unauthorized";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasStatus;
    private TypeStatus storeStatus;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


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
            case TypeStatusKnownValues.Status_success:
                generated_string_Status = new JSONStringValue("success");
                break;
            case TypeStatusKnownValues.Status_no_current_trip:
                generated_string_Status = new JSONStringValue("no_current_trip");
                break;
            case TypeStatusKnownValues.Status_cancel_cash_trip_not_allowed:
                generated_string_Status = new JSONStringValue("cancel_cash_trip_not_allowed");
                break;
            case TypeStatusKnownValues.Status_failure:
                generated_string_Status = new JSONStringValue("failure");
                break;
            case TypeStatusKnownValues.Status_unauthorized:
                generated_string_Status = new JSONStringValue("unauthorized");
                break;
            default:
                Debug.Assert(false);
                generated_string_Status = null;
                break;
          }
          }
        return generated_string_Status;
      }


    private void  fromJSONStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Status of UberCancelInformationNuggetJSON is not a string.");
        TypeStatus the_open_enum = new TypeStatus();
        switch (json_string.getData()[0])
          {
            case 'c':
                if ((String.Compare(json_string.getData(), 1, "ancel_cash_trip_not_allowed", 0, 27, false) == 0) && (json_string.getData().Length == 28))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_cancel_cash_trip_not_allowed;
                        goto open_enum_is_done;
                      }
                break;
            case 'f':
                if ((String.Compare(json_string.getData(), 1, "ailure", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_failure;
                        goto open_enum_is_done;
                      }
                break;
            case 'n':
                if ((String.Compare(json_string.getData(), 1, "o_current_trip", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_no_current_trip;
                        goto open_enum_is_done;
                      }
                break;
            case 's':
                if ((String.Compare(json_string.getData(), 1, "uccess", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_success;
                        goto open_enum_is_done;
                      }
                break;
            case 'u':
                if ((String.Compare(json_string.getData(), 1, "nauthorized", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_unauthorized;
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


    public UberCancelInformationNuggetJSON()
      {
        flagHasStatus = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getUberNuggetKind()
      {
        return "UberCancel";
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


    public virtual int extraUberCancelInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberCancelInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberCancelInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberCancelInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUberInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasStatus)
            ++result;
        result += extraUberCancelInformationNuggetComponentCount();
        return result;
      }
    public override string extraUberInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasStatus)
          {
            if (remainder == 0)
                return "Status";
            --remainder;
          }
        return extraUberCancelInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraUberInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasStatus)
          {
            if (remainder == 0)
                return extraStatusToJSON();
            --remainder;
          }
        return extraUberCancelInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraUberInformationNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Status", 0, 6, false) == 0) && (field_name.Length == 6))
            return (flagHasStatus ? extraStatusToJSON() : null);
        return extraUberCancelInformationNuggetLookup(field_name);
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

    public virtual void extraUberCancelInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberCancelInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberCancelInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraUberCancelInformationNuggetAppendPair(key, new_component);
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
    public override void extraUberInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Status", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONStatus(new_component, false);
            return;
            }
        extraUberCancelInformationNuggetAppendPair(key, new_component);
      }
    public override void extraUberInformationNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Status", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONStatus(new_component, false);
            return;
            }
        extraUberCancelInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStatus);
        if (flagHasStatus)
          {
            handler.start_pair("Status");
            if (storeStatus.in_known_list)
              {
                switch (storeStatus.list_value)
                  {
                    case TypeStatusKnownValues.Status_success:
                        handler.string_value("success");
                        break;
                    case TypeStatusKnownValues.Status_no_current_trip:
                        handler.string_value("no_current_trip");
                        break;
                    case TypeStatusKnownValues.Status_cancel_cash_trip_not_allowed:
                        handler.string_value("cancel_cash_trip_not_allowed");
                        break;
                    case TypeStatusKnownValues.Status_failure:
                        handler.string_value("failure");
                        break;
                    case TypeStatusKnownValues.Status_unauthorized:
                        handler.string_value("unauthorized");
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
        if (!(hasStatus()))
          {
            return "When parsing the object for %what%, the \"Status\" field was missing.";
          }
        return null;
      }

    public static new UberCancelInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberCancelInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberCancelInformationNugget", ignore_extras);
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
    public static new UberCancelInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberCancelInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberCancelInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberCancelInformationNugget", ignore_extras);
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
    public static new UberCancelInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberCancelInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        UberCancelInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberCancelInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberCancelInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UberCancelInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberCancelInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberCancelInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UberInformationNuggetJSON.Generator
      {
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
            if (!(getUberInformationNuggetJSONKey().Equals("UberCancel")))
                throw new Exception("The key field has a value other than `UberCancel'.");
            UberCancelInformationNuggetJSON result = new UberCancelInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberCancelInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UberInformationNuggetJSON new_result)
          {
            handle_result((UberCancelInformationNuggetJSON )new_result);
          }
        protected void finish(UberCancelInformationNuggetJSON result)
          {
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
        protected abstract void handle_result(UberCancelInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Status", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorStatus;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the UberCancelInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberCancelInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the UberCancelInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberCancelInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorStatus.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UberCancelInformationNuggetJSON  result)
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
        public UberCancelInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberCancelInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<UberCancelInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberCancelInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberCancelInformationNuggetJSON>();
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
    public List<UberCancelInformationNuggetJSON> value;
  };
  };
