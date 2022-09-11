/* file "EmailContactResultWithAddOrRemoveJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class EmailContactResultWithAddOrRemoveJSON : EmailContactResultJSON
  {
    private bool flagHasAction;
    private EmailContactResultActionJSON  storeAction;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraActionToJSON()
      {
        JSONValueHandler handler_Action = new JSONValueHandler();
        storeAction.write_as_json(handler_Action);
        return handler_Action.result;
      }


    private void  fromJSONAction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EmailContactResultActionJSON convert_classy = EmailContactResultActionJSON.from_json(json_value, ignore_extras, true);
        setAction(convert_classy);
      }


    public EmailContactResultWithAddOrRemoveJSON()
      {
        flagHasAction = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasAction()
      {
        return flagHasAction;
      }

    public EmailContactResultActionJSON   getAction()
      {
        Debug.Assert(flagHasAction);
        return storeAction;
      }

    public EmailContactResultActionJSON.TypeValue  getActionValue()
      {
        return getAction().getValue();
      }

    public string  getActionAsString()
      {
        return getAction().getValueAsString();
      }


    public virtual int extraEmailContactResultWithAddOrRemoveComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraEmailContactResultWithAddOrRemoveComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraEmailContactResultWithAddOrRemoveComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraEmailContactResultWithAddOrRemoveLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraEmailContactResultComponentCount()
      {
        int result = 0;
        if (flagHasAction)
            ++result;
        result += extraEmailContactResultWithAddOrRemoveComponentCount();
        return result;
      }
    public override string extraEmailContactResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAction)
          {
            if (remainder == 0)
                return "Action";
            --remainder;
          }
        return extraEmailContactResultWithAddOrRemoveComponentKey(remainder);
      }
    public override JSONValue extraEmailContactResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAction)
          {
            if (remainder == 0)
                return extraActionToJSON();
            --remainder;
          }
        return extraEmailContactResultWithAddOrRemoveComponentValue(remainder);
      }
    public override JSONValue extraEmailContactResultLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Action", 0, 6, false) == 0) && (field_name.Length == 6))
            return (flagHasAction ? extraActionToJSON() : null);
        return extraEmailContactResultWithAddOrRemoveLookup(field_name);
      }

    public void setAction(EmailContactResultActionJSON  new_value)
      {
        if (flagHasAction)
          {
          }
        flagHasAction = true;
        storeAction = new_value;
      }
    public void setAction(EmailContactResultActionJSON.TypeValue new_value)
      {
        setAction(new EmailContactResultActionJSON(new_value));
      }
    public void setAction(string chars)
      {
        setAction(new EmailContactResultActionJSON(chars));
      }
    public void unsetAction()
      {
        if (flagHasAction)
          {
          }
        flagHasAction = false;
      }

    public virtual void extraEmailContactResultWithAddOrRemoveAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraEmailContactResultWithAddOrRemoveSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraEmailContactResultWithAddOrRemoveLookup(key);
        if (old_field == null)
          {
            extraEmailContactResultWithAddOrRemoveAppendPair(key, new_component);
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
    public override void extraEmailContactResultAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Action", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONAction(new_component, false);
            return;
            }
        extraEmailContactResultWithAddOrRemoveAppendPair(key, new_component);
      }
    public override void extraEmailContactResultSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Action", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONAction(new_component, false);
            return;
            }
        extraEmailContactResultWithAddOrRemoveSetField(key, new_component);
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
        if (flagHasAction)
          {
            handler.start_pair("Action");
            if (partial_allowed)
                storeAction.write_partial_as_json(handler);
            else
                storeAction.write_as_json(handler);
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
        return null;
      }

    public static new EmailContactResultWithAddOrRemoveJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmailContactResultWithAddOrRemoveJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailContactResultWithAddOrRemove", ignore_extras);
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
    public static new EmailContactResultWithAddOrRemoveJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new EmailContactResultWithAddOrRemoveJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmailContactResultWithAddOrRemoveJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailContactResultWithAddOrRemove", ignore_extras);
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
    public static new EmailContactResultWithAddOrRemoveJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new EmailContactResultWithAddOrRemoveJSON from_text(string text, bool ignore_extras)
      {
        EmailContactResultWithAddOrRemoveJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailContactResultWithAddOrRemove", ignore_extras);
            JSONParse.parse_json_value(text, "Text for EmailContactResultWithAddOrRemoveJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new EmailContactResultWithAddOrRemoveJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        EmailContactResultWithAddOrRemoveJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailContactResultWithAddOrRemove", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : EmailContactResultJSON.Generator
      {
        private EmailContactResultActionJSON.HoldingGenerator fieldGeneratorAction;
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
            EmailContactResultWithAddOrRemoveJSON result = new EmailContactResultWithAddOrRemoveJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraEmailContactResultWithAddOrRemoveAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(EmailContactResultJSON new_result)
          {
            handle_result((EmailContactResultWithAddOrRemoveJSON )new_result);
          }
        protected void finish(EmailContactResultWithAddOrRemoveJSON result)
          {
            if (fieldGeneratorAction.have_value)
              {
                result.setAction(fieldGeneratorAction.value);
                fieldGeneratorAction.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(EmailContactResultWithAddOrRemoveJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Action", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorAction;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAction = new EmailContactResultActionJSON.HoldingGenerator("field \"Action\" of the EmailContactResultWithAddOrRemove class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the EmailContactResultWithAddOrRemove class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAction = new EmailContactResultActionJSON.HoldingGenerator("field \"Action\" of the EmailContactResultWithAddOrRemove class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the EmailContactResultWithAddOrRemove class");
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
        protected override void handle_result(EmailContactResultWithAddOrRemoveJSON  result)
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
        public EmailContactResultWithAddOrRemoveJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(EmailContactResultWithAddOrRemoveJSON  result)
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
    protected virtual void handle_result(List<EmailContactResultWithAddOrRemoveJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<EmailContactResultWithAddOrRemoveJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<EmailContactResultWithAddOrRemoveJSON>();
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
    public List<EmailContactResultWithAddOrRemoveJSON> value;
  };
    public static new EmailContactResultWithAddOrRemoveJSON from_ContactResultJSON_json(ContactResultJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        EmailContactResultWithAddOrRemoveJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type EmailContactResultWithAddOrRemove", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
    public static EmailContactResultWithAddOrRemoveJSON from_EmailContactResultJSON_json(EmailContactResultJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        EmailContactResultWithAddOrRemoveJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type EmailContactResultWithAddOrRemove", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
