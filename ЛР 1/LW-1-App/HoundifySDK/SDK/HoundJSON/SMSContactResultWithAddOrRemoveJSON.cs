/* file "SMSContactResultWithAddOrRemoveJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SMSContactResultWithAddOrRemoveJSON : SMSContactResultJSON
  {
    private bool flagHasAction;
    private SMSContactResultActionJSON  storeAction;
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
        SMSContactResultActionJSON convert_classy = SMSContactResultActionJSON.from_json(json_value, ignore_extras, true);
        setAction(convert_classy);
      }


    public SMSContactResultWithAddOrRemoveJSON()
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

    public SMSContactResultActionJSON   getAction()
      {
        Debug.Assert(flagHasAction);
        return storeAction;
      }

    public SMSContactResultActionJSON.TypeValue  getActionValue()
      {
        return getAction().getValue();
      }

    public string  getActionAsString()
      {
        return getAction().getValueAsString();
      }


    public virtual int extraSMSContactResultWithAddOrRemoveComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSMSContactResultWithAddOrRemoveComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSMSContactResultWithAddOrRemoveComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSMSContactResultWithAddOrRemoveLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSMSContactResultComponentCount()
      {
        int result = 0;
        if (flagHasAction)
            ++result;
        result += extraSMSContactResultWithAddOrRemoveComponentCount();
        return result;
      }
    public override string extraSMSContactResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAction)
          {
            if (remainder == 0)
                return "Action";
            --remainder;
          }
        return extraSMSContactResultWithAddOrRemoveComponentKey(remainder);
      }
    public override JSONValue extraSMSContactResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAction)
          {
            if (remainder == 0)
                return extraActionToJSON();
            --remainder;
          }
        return extraSMSContactResultWithAddOrRemoveComponentValue(remainder);
      }
    public override JSONValue extraSMSContactResultLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Action", 0, 6, false) == 0) && (field_name.Length == 6))
            return (flagHasAction ? extraActionToJSON() : null);
        return extraSMSContactResultWithAddOrRemoveLookup(field_name);
      }

    public void setAction(SMSContactResultActionJSON  new_value)
      {
        if (flagHasAction)
          {
          }
        flagHasAction = true;
        storeAction = new_value;
      }
    public void setAction(SMSContactResultActionJSON.TypeValue new_value)
      {
        setAction(new SMSContactResultActionJSON(new_value));
      }
    public void setAction(string chars)
      {
        setAction(new SMSContactResultActionJSON(chars));
      }
    public void unsetAction()
      {
        if (flagHasAction)
          {
          }
        flagHasAction = false;
      }

    public virtual void extraSMSContactResultWithAddOrRemoveAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSMSContactResultWithAddOrRemoveSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSMSContactResultWithAddOrRemoveLookup(key);
        if (old_field == null)
          {
            extraSMSContactResultWithAddOrRemoveAppendPair(key, new_component);
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
    public override void extraSMSContactResultAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Action", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONAction(new_component, false);
            return;
            }
        extraSMSContactResultWithAddOrRemoveAppendPair(key, new_component);
      }
    public override void extraSMSContactResultSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Action", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONAction(new_component, false);
            return;
            }
        extraSMSContactResultWithAddOrRemoveSetField(key, new_component);
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

    public static new SMSContactResultWithAddOrRemoveJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSContactResultWithAddOrRemoveJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSContactResultWithAddOrRemove", ignore_extras);
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
    public static new SMSContactResultWithAddOrRemoveJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SMSContactResultWithAddOrRemoveJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSContactResultWithAddOrRemoveJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSContactResultWithAddOrRemove", ignore_extras);
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
    public static new SMSContactResultWithAddOrRemoveJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SMSContactResultWithAddOrRemoveJSON from_text(string text, bool ignore_extras)
      {
        SMSContactResultWithAddOrRemoveJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSContactResultWithAddOrRemove", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SMSContactResultWithAddOrRemoveJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SMSContactResultWithAddOrRemoveJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SMSContactResultWithAddOrRemoveJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSContactResultWithAddOrRemove", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SMSContactResultJSON.Generator
      {
        private SMSContactResultActionJSON.HoldingGenerator fieldGeneratorAction;
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
            SMSContactResultWithAddOrRemoveJSON result = new SMSContactResultWithAddOrRemoveJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSMSContactResultWithAddOrRemoveAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SMSContactResultJSON new_result)
          {
            handle_result((SMSContactResultWithAddOrRemoveJSON )new_result);
          }
        protected void finish(SMSContactResultWithAddOrRemoveJSON result)
          {
            if (fieldGeneratorAction.have_value)
              {
                result.setAction(fieldGeneratorAction.value);
                fieldGeneratorAction.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SMSContactResultWithAddOrRemoveJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Action", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorAction;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAction = new SMSContactResultActionJSON.HoldingGenerator("field \"Action\" of the SMSContactResultWithAddOrRemove class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SMSContactResultWithAddOrRemove class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAction = new SMSContactResultActionJSON.HoldingGenerator("field \"Action\" of the SMSContactResultWithAddOrRemove class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SMSContactResultWithAddOrRemove class");
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
        protected override void handle_result(SMSContactResultWithAddOrRemoveJSON  result)
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
        public SMSContactResultWithAddOrRemoveJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SMSContactResultWithAddOrRemoveJSON  result)
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
    protected virtual void handle_result(List<SMSContactResultWithAddOrRemoveJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SMSContactResultWithAddOrRemoveJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SMSContactResultWithAddOrRemoveJSON>();
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
    public List<SMSContactResultWithAddOrRemoveJSON> value;
  };
    public static new SMSContactResultWithAddOrRemoveJSON from_ContactResultJSON_json(ContactResultJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        SMSContactResultWithAddOrRemoveJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type SMSContactResultWithAddOrRemove", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
    public static SMSContactResultWithAddOrRemoveJSON from_SMSContactResultJSON_json(SMSContactResultJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        SMSContactResultWithAddOrRemoveJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type SMSContactResultWithAddOrRemove", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
