/* file "SMSCreateContextFieldsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SMSCreateContextFieldsJSON : JSONBase
  {
    private bool flagHasNewRecipients;
    private SMSRecipientsJSON  storeNewRecipients;
    private bool flagHasNewBody;
    private string storeNewBody;
    private bool flagHasClearExistingSMS;
    private bool storeClearExistingSMS;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONNewRecipients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SMSRecipientsJSON convert_classy = SMSRecipientsJSON.from_json(json_value, ignore_extras, true);
        setNewRecipients(convert_classy);
      }


    private void  fromJSONNewBody(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NewBody of SMSCreateContextFieldsJSON is not a string.");
        setNewBody(json_string.getData());
      }


    private void  fromJSONClearExistingSMS(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ClearExistingSMS of SMSCreateContextFieldsJSON is not true for false.");
              }
          }
        setClearExistingSMS(the_bool);
      }


    public SMSCreateContextFieldsJSON()
      {
        flagHasNewRecipients = false;
        flagHasNewBody = false;
        flagHasClearExistingSMS = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasNewRecipients()
      {
        return flagHasNewRecipients;
      }

    public SMSRecipientsJSON   getNewRecipients()
      {
        Debug.Assert(flagHasNewRecipients);
        return storeNewRecipients;
      }

    public bool  hasNewBody()
      {
        return flagHasNewBody;
      }

    public string  getNewBody()
      {
        Debug.Assert(flagHasNewBody);
        return storeNewBody;
      }

    public bool  hasClearExistingSMS()
      {
        return flagHasClearExistingSMS;
      }

    public bool  getClearExistingSMS()
      {
        Debug.Assert(flagHasClearExistingSMS);
        return storeClearExistingSMS;
      }


    public virtual int extraSMSCreateContextFieldsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSMSCreateContextFieldsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSMSCreateContextFieldsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSMSCreateContextFieldsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setNewRecipients(SMSRecipientsJSON  new_value)
      {
        if (flagHasNewRecipients)
          {
          }
        flagHasNewRecipients = true;
        storeNewRecipients = new_value;
      }
    public void unsetNewRecipients()
      {
        if (flagHasNewRecipients)
          {
          }
        flagHasNewRecipients = false;
      }
    public void setNewBody(string new_value)
      {
        flagHasNewBody = true;
        storeNewBody = new_value;
      }
    public void unsetNewBody()
      {
        flagHasNewBody = false;
      }
    public void setClearExistingSMS(bool new_value)
      {
        flagHasClearExistingSMS = true;
        storeClearExistingSMS = new_value;
      }
    public void unsetClearExistingSMS()
      {
        flagHasClearExistingSMS = false;
      }

    public virtual void extraSMSCreateContextFieldsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSMSCreateContextFieldsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSMSCreateContextFieldsLookup(key);
        if (old_field == null)
          {
            extraSMSCreateContextFieldsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNewRecipients);
        if (flagHasNewRecipients)
          {
            handler.start_pair("NewRecipients");
            if (partial_allowed)
                storeNewRecipients.write_partial_as_json(handler);
            else
                storeNewRecipients.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasNewBody);
        if (flagHasNewBody)
          {
            handler.start_pair("NewBody");
            handler.string_value(storeNewBody);
          }
        Debug.Assert(partial_allowed || flagHasClearExistingSMS);
        if (flagHasClearExistingSMS)
          {
            handler.start_pair("ClearExistingSMS");
            handler.boolean_value(storeClearExistingSMS);
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
        if (!(hasNewRecipients()))
          {
            return "When parsing the object for %what%, the \"NewRecipients\" field was missing.";
          }
        if (!(hasNewBody()))
          {
            return "When parsing the object for %what%, the \"NewBody\" field was missing.";
          }
        if (!(hasClearExistingSMS()))
          {
            return "When parsing the object for %what%, the \"ClearExistingSMS\" field was missing.";
          }
        return null;
      }

    public static SMSCreateContextFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSCreateContextFieldsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSCreateContextFields", ignore_extras);
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
    public static SMSCreateContextFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSCreateContextFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSCreateContextFieldsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSCreateContextFields", ignore_extras);
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
    public static SMSCreateContextFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSCreateContextFieldsJSON from_text(string text, bool ignore_extras)
      {
        SMSCreateContextFieldsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSCreateContextFields", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SMSCreateContextFieldsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SMSCreateContextFieldsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SMSCreateContextFieldsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSCreateContextFields", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SMSRecipientsJSON.HoldingGenerator fieldGeneratorNewRecipients;
        private JSONHoldingStringGenerator fieldGeneratorNewBody;
        private JSONHoldingBooleanGenerator fieldGeneratorClearExistingSMS;
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
            SMSCreateContextFieldsJSON result = new SMSCreateContextFieldsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSMSCreateContextFieldsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SMSCreateContextFieldsJSON result)
          {
            if (fieldGeneratorNewRecipients.have_value)
              {
                result.setNewRecipients(fieldGeneratorNewRecipients.value);
                fieldGeneratorNewRecipients.have_value = false;
              }
            else if ((!(result.hasNewRecipients())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewRecipients\" field was missing.");
              }
            if (fieldGeneratorNewBody.have_value)
              {
                result.setNewBody(fieldGeneratorNewBody.value);
                fieldGeneratorNewBody.have_value = false;
              }
            else if ((!(result.hasNewBody())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewBody\" field was missing.");
              }
            if (fieldGeneratorClearExistingSMS.have_value)
              {
                result.setClearExistingSMS(fieldGeneratorClearExistingSMS.value);
                fieldGeneratorClearExistingSMS.have_value = false;
              }
            else if ((!(result.hasClearExistingSMS())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ClearExistingSMS\" field was missing.");
              }
          }
        protected abstract void handle_result(SMSCreateContextFieldsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "learExistingSMS", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorClearExistingSMS;
                    break;
                case 'N':
                    if (String.Compare(field_name, 1, "ew", 0, 2, false) == 0)
                      {
                        switch (field_name[3])
                          {
                            case 'B':
                                if ((String.Compare(field_name, 4, "ody", 0, 3, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorNewBody;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 4, "ecipients", 0, 9, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorNewRecipients;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorNewRecipients = new SMSRecipientsJSON.HoldingGenerator("field \"NewRecipients\" of the SMSCreateContextFields class", ignore_extras);
            fieldGeneratorNewBody = new JSONHoldingStringGenerator("field \"NewBody\" of the SMSCreateContextFields class");
            fieldGeneratorClearExistingSMS = new JSONHoldingBooleanGenerator("field \"ClearExistingSMS\" of the SMSCreateContextFields class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SMSCreateContextFields class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorNewRecipients = new SMSRecipientsJSON.HoldingGenerator("field \"NewRecipients\" of the SMSCreateContextFields class", false);
            fieldGeneratorNewBody = new JSONHoldingStringGenerator("field \"NewBody\" of the SMSCreateContextFields class");
            fieldGeneratorClearExistingSMS = new JSONHoldingBooleanGenerator("field \"ClearExistingSMS\" of the SMSCreateContextFields class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SMSCreateContextFields class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorNewRecipients.reset();
            fieldGeneratorNewBody.reset();
            fieldGeneratorClearExistingSMS.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorNewRecipients.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorNewRecipients.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SMSCreateContextFieldsJSON  result)
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
        public SMSCreateContextFieldsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SMSCreateContextFieldsJSON  result)
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
    protected virtual void handle_result(List<SMSCreateContextFieldsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SMSCreateContextFieldsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SMSCreateContextFieldsJSON>();
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
    public List<SMSCreateContextFieldsJSON> value;
  };
  };
