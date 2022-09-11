/* file "SMSEditRecipientsContextFieldsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SMSEditRecipientsContextFieldsJSON : JSONBase
  {
    private bool flagHasAddRecipients;
    private SMSRecipientsJSON  storeAddRecipients;
    private bool flagHasRemoveRecipients;
    private SMSRecipientsJSON  storeRemoveRecipients;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONAddRecipients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SMSRecipientsJSON convert_classy = SMSRecipientsJSON.from_json(json_value, ignore_extras, true);
        setAddRecipients(convert_classy);
      }


    private void  fromJSONRemoveRecipients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SMSRecipientsJSON convert_classy = SMSRecipientsJSON.from_json(json_value, ignore_extras, true);
        setRemoveRecipients(convert_classy);
      }


    public SMSEditRecipientsContextFieldsJSON()
      {
        flagHasAddRecipients = false;
        flagHasRemoveRecipients = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasAddRecipients()
      {
        return flagHasAddRecipients;
      }

    public SMSRecipientsJSON   getAddRecipients()
      {
        Debug.Assert(flagHasAddRecipients);
        return storeAddRecipients;
      }

    public bool  hasRemoveRecipients()
      {
        return flagHasRemoveRecipients;
      }

    public SMSRecipientsJSON   getRemoveRecipients()
      {
        Debug.Assert(flagHasRemoveRecipients);
        return storeRemoveRecipients;
      }


    public virtual int extraSMSEditRecipientsContextFieldsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSMSEditRecipientsContextFieldsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSMSEditRecipientsContextFieldsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSMSEditRecipientsContextFieldsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setAddRecipients(SMSRecipientsJSON  new_value)
      {
        if (flagHasAddRecipients)
          {
          }
        flagHasAddRecipients = true;
        storeAddRecipients = new_value;
      }
    public void unsetAddRecipients()
      {
        if (flagHasAddRecipients)
          {
          }
        flagHasAddRecipients = false;
      }
    public void setRemoveRecipients(SMSRecipientsJSON  new_value)
      {
        if (flagHasRemoveRecipients)
          {
          }
        flagHasRemoveRecipients = true;
        storeRemoveRecipients = new_value;
      }
    public void unsetRemoveRecipients()
      {
        if (flagHasRemoveRecipients)
          {
          }
        flagHasRemoveRecipients = false;
      }

    public virtual void extraSMSEditRecipientsContextFieldsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSMSEditRecipientsContextFieldsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSMSEditRecipientsContextFieldsLookup(key);
        if (old_field == null)
          {
            extraSMSEditRecipientsContextFieldsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAddRecipients);
        if (flagHasAddRecipients)
          {
            handler.start_pair("AddRecipients");
            if (partial_allowed)
                storeAddRecipients.write_partial_as_json(handler);
            else
                storeAddRecipients.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasRemoveRecipients);
        if (flagHasRemoveRecipients)
          {
            handler.start_pair("RemoveRecipients");
            if (partial_allowed)
                storeRemoveRecipients.write_partial_as_json(handler);
            else
                storeRemoveRecipients.write_as_json(handler);
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
        if (!(hasAddRecipients()))
          {
            return "When parsing the object for %what%, the \"AddRecipients\" field was missing.";
          }
        if (!(hasRemoveRecipients()))
          {
            return "When parsing the object for %what%, the \"RemoveRecipients\" field was missing.";
          }
        return null;
      }

    public static SMSEditRecipientsContextFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSEditRecipientsContextFieldsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSEditRecipientsContextFields", ignore_extras);
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
    public static SMSEditRecipientsContextFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSEditRecipientsContextFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSEditRecipientsContextFieldsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSEditRecipientsContextFields", ignore_extras);
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
    public static SMSEditRecipientsContextFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSEditRecipientsContextFieldsJSON from_text(string text, bool ignore_extras)
      {
        SMSEditRecipientsContextFieldsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSEditRecipientsContextFields", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SMSEditRecipientsContextFieldsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SMSEditRecipientsContextFieldsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SMSEditRecipientsContextFieldsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSEditRecipientsContextFields", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SMSRecipientsJSON.HoldingGenerator fieldGeneratorAddRecipients;
        private SMSRecipientsJSON.HoldingGenerator fieldGeneratorRemoveRecipients;
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
            SMSEditRecipientsContextFieldsJSON result = new SMSEditRecipientsContextFieldsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSMSEditRecipientsContextFieldsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SMSEditRecipientsContextFieldsJSON result)
          {
            if (fieldGeneratorAddRecipients.have_value)
              {
                result.setAddRecipients(fieldGeneratorAddRecipients.value);
                fieldGeneratorAddRecipients.have_value = false;
              }
            else if ((!(result.hasAddRecipients())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AddRecipients\" field was missing.");
              }
            if (fieldGeneratorRemoveRecipients.have_value)
              {
                result.setRemoveRecipients(fieldGeneratorRemoveRecipients.value);
                fieldGeneratorRemoveRecipients.have_value = false;
              }
            else if ((!(result.hasRemoveRecipients())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RemoveRecipients\" field was missing.");
              }
          }
        protected abstract void handle_result(SMSEditRecipientsContextFieldsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ddRecipients", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorAddRecipients;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "emoveRecipients", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorRemoveRecipients;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAddRecipients = new SMSRecipientsJSON.HoldingGenerator("field \"AddRecipients\" of the SMSEditRecipientsContextFields class", ignore_extras);
            fieldGeneratorRemoveRecipients = new SMSRecipientsJSON.HoldingGenerator("field \"RemoveRecipients\" of the SMSEditRecipientsContextFields class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SMSEditRecipientsContextFields class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAddRecipients = new SMSRecipientsJSON.HoldingGenerator("field \"AddRecipients\" of the SMSEditRecipientsContextFields class", false);
            fieldGeneratorRemoveRecipients = new SMSRecipientsJSON.HoldingGenerator("field \"RemoveRecipients\" of the SMSEditRecipientsContextFields class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SMSEditRecipientsContextFields class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorAddRecipients.reset();
            fieldGeneratorRemoveRecipients.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAddRecipients.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRemoveRecipients.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAddRecipients.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRemoveRecipients.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SMSEditRecipientsContextFieldsJSON  result)
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
        public SMSEditRecipientsContextFieldsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SMSEditRecipientsContextFieldsJSON  result)
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
    protected virtual void handle_result(List<SMSEditRecipientsContextFieldsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SMSEditRecipientsContextFieldsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SMSEditRecipientsContextFieldsJSON>();
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
    public List<SMSEditRecipientsContextFieldsJSON> value;
  };
  };
