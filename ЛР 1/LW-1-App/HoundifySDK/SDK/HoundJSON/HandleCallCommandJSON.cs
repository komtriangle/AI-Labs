/* file "HandleCallCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HandleCallCommandJSON : PhoneCommandJSON
  {
    public enum TypeAction
      {
        Action_Answer,
        Action_Reject,
        Action_Ignore
      };

    public static TypeAction  stringToAction(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "nswer", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeAction.Action_Answer;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "gnore", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeAction.Action_Ignore;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "eject", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeAction.Action_Reject;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Action' is not one of the legal values.");
      }

    public static string  stringFromAction(TypeAction the_enum)
      {
        switch (the_enum)
          {
            case TypeAction.Action_Answer:
                return "Answer";
            case TypeAction.Action_Reject:
                return "Reject";
            case TypeAction.Action_Ignore:
                return "Ignore";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasAction;
    private TypeAction storeAction;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraActionToJSON()
      {
        JSONStringValue generated_string_Action;
        switch (storeAction)
          {
            case TypeAction.Action_Answer:
                generated_string_Action = new JSONStringValue("Answer");
                break;
            case TypeAction.Action_Reject:
                generated_string_Action = new JSONStringValue("Reject");
                break;
            case TypeAction.Action_Ignore:
                generated_string_Action = new JSONStringValue("Ignore");
                break;
            default:
                Debug.Assert(false);
                generated_string_Action = null;
                break;
          }
        return generated_string_Action;
      }


    private void  fromJSONAction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Action of HandleCallCommandJSON is not a string.");
        TypeAction the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "nswer", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeAction.Action_Answer;
                        goto enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "gnore", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeAction.Action_Ignore;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "eject", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeAction.Action_Reject;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Action of HandleCallCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setAction(the_enum);
      }


    public HandleCallCommandJSON()
      {
        flagHasAction = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getPhoneCommandKind()
      {
        return "HandleCall";
      }

    public bool  hasAction()
      {
        return flagHasAction;
      }

    public TypeAction  getAction()
      {
        Debug.Assert(flagHasAction);
        return storeAction;
      }

    public string  getActionAsString()
      {
        return stringFromAction(getAction());
      }


    public virtual int extraHandleCallCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHandleCallCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHandleCallCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHandleCallCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPhoneCommandComponentCount()
      {
        int result = 0;
        if (flagHasAction)
            ++result;
        result += extraHandleCallCommandComponentCount();
        return result;
      }
    public override string extraPhoneCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAction)
          {
            if (remainder == 0)
                return "Action";
            --remainder;
          }
        return extraHandleCallCommandComponentKey(remainder);
      }
    public override JSONValue extraPhoneCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAction)
          {
            if (remainder == 0)
                return extraActionToJSON();
            --remainder;
          }
        return extraHandleCallCommandComponentValue(remainder);
      }
    public override JSONValue extraPhoneCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Action", 0, 6, false) == 0) && (field_name.Length == 6))
            return (flagHasAction ? extraActionToJSON() : null);
        return extraHandleCallCommandLookup(field_name);
      }

    public void setAction(TypeAction new_value)
      {
        flagHasAction = true;
        storeAction = new_value;
      }
    public void setAction(string chars)
      {
        setAction(stringToAction(chars));
      }
    public void unsetAction()
      {
        flagHasAction = false;
      }

    public virtual void extraHandleCallCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHandleCallCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHandleCallCommandLookup(key);
        if (old_field == null)
          {
            extraHandleCallCommandAppendPair(key, new_component);
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
    public override void extraPhoneCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Action", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONAction(new_component, false);
            return;
            }
        extraHandleCallCommandAppendPair(key, new_component);
      }
    public override void extraPhoneCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Action", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONAction(new_component, false);
            return;
            }
        extraHandleCallCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAction);
        if (flagHasAction)
          {
            handler.start_pair("Action");
            switch (storeAction)
              {
                case TypeAction.Action_Answer:
                    handler.string_value("Answer");
                    break;
                case TypeAction.Action_Reject:
                    handler.string_value("Reject");
                    break;
                case TypeAction.Action_Ignore:
                    handler.string_value("Ignore");
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasAction()))
          {
            return "When parsing the object for %what%, the \"Action\" field was missing.";
          }
        return null;
      }

    public static new HandleCallCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HandleCallCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HandleCallCommand", ignore_extras);
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
    public static new HandleCallCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HandleCallCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HandleCallCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HandleCallCommand", ignore_extras);
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
    public static new HandleCallCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HandleCallCommandJSON from_text(string text, bool ignore_extras)
      {
        HandleCallCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HandleCallCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HandleCallCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HandleCallCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HandleCallCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HandleCallCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PhoneCommandJSON.Generator
      {
    private abstract class FieldGeneratorAction : JSONStringGenerator
          {
            protected FieldGeneratorAction(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorAction()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToAction(result));
              }
            protected abstract void handle_result(TypeAction result);
          };
    private class FieldHoldingGeneratorAction : FieldGeneratorAction
  {
    protected override void handle_result(TypeAction result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorAction(String what)
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
    public TypeAction value;
  };
    private class FieldHoldingArrayGeneratorAction : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorAction
      {
        private FieldHoldingArrayGeneratorAction top;

        protected override void handle_result(TypeAction result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorAction init_top)
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
    protected virtual void handle_result(List<TypeAction> result)
      {
      }

    public FieldHoldingArrayGeneratorAction(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAction>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorAction()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAction>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeAction> value;
  };
        private FieldHoldingGeneratorAction fieldGeneratorAction;
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
            if (!(getPhoneCommandJSONKey().Equals("HandleCall")))
                throw new Exception("The key field has a value other than `HandleCall'.");
            HandleCallCommandJSON result = new HandleCallCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHandleCallCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PhoneCommandJSON new_result)
          {
            handle_result((HandleCallCommandJSON )new_result);
          }
        protected void finish(HandleCallCommandJSON result)
          {
            if (fieldGeneratorAction.have_value)
              {
                result.setAction(fieldGeneratorAction.value);
                fieldGeneratorAction.have_value = false;
              }
            else if ((!(result.hasAction())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Action\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(HandleCallCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Action", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorAction;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAction = new FieldHoldingGeneratorAction("field \"Action\" of the HandleCallCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HandleCallCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAction = new FieldHoldingGeneratorAction("field \"Action\" of the HandleCallCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HandleCallCommand class");
          }

        public override void reset()
          {
            fieldGeneratorAction.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(HandleCallCommandJSON  result)
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
        public HandleCallCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HandleCallCommandJSON  result)
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
    protected virtual void handle_result(List<HandleCallCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HandleCallCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HandleCallCommandJSON>();
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
    public List<HandleCallCommandJSON> value;
  };
  };
