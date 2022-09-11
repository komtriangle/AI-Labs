/* file "SMSJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SMSJSON : JSONBase
  {
    private bool flagHasRecipients;
    private List< UnambiguousSMSRecipientJSON  > storeRecipients;
    private bool flagHasSpokenBody;
    private string storeSpokenBody;
    private bool flagHasWrittenBody;
    private string storeWrittenBody;
    private bool flagHasBody;
    private string storeBody;
    private bool flagHasTo;
    private SMSAddressFieldJSON  storeTo;
    private bool flagHasUserSpecifiedName;
    private string storeUserSpecifiedName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONRecipients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Recipients of SMSJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< UnambiguousSMSRecipientJSON  > vector_Recipients1 = new List< UnambiguousSMSRecipientJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UnambiguousSMSRecipientJSON convert_classy = UnambiguousSMSRecipientJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Recipients1.Add(convert_classy);
          }
        initRecipients();
        for (int num1 = 0; num1 < vector_Recipients1.Count; ++num1)
            appendRecipients(vector_Recipients1[num1]);
        for (int num1 = 0; num1 < vector_Recipients1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpokenBody(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenBody of SMSJSON is not a string.");
        setSpokenBody(json_string.getData());
      }


    private void  fromJSONWrittenBody(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenBody of SMSJSON is not a string.");
        setWrittenBody(json_string.getData());
      }


    private void  fromJSONBody(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Body of SMSJSON is not a string.");
        setBody(json_string.getData());
      }


    private void  fromJSONTo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SMSAddressFieldJSON convert_classy = SMSAddressFieldJSON.from_json(json_value, ignore_extras, true);
        setTo(convert_classy);
      }


    private void  fromJSONUserSpecifiedName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UserSpecifiedName of SMSJSON is not a string.");
        setUserSpecifiedName(json_string.getData());
      }


    public SMSJSON()
      {
        flagHasRecipients = false;
        flagHasSpokenBody = false;
        flagHasWrittenBody = false;
        flagHasBody = false;
        flagHasTo = false;
        flagHasUserSpecifiedName = false;
        storeRecipients = new List< UnambiguousSMSRecipientJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasRecipients()
      {
        return flagHasRecipients;
      }

    public int  countOfRecipients()
      {
        Debug.Assert(flagHasRecipients);
        return storeRecipients.Count;
      }

    public UnambiguousSMSRecipientJSON   elementOfRecipients(int element_num)
      {
        Debug.Assert(flagHasRecipients);
        return storeRecipients[element_num];
      }

    public List< UnambiguousSMSRecipientJSON  >  getRecipients()
      {
        Debug.Assert(flagHasRecipients);
        return storeRecipients;
      }

    public bool  hasSpokenBody()
      {
        return flagHasSpokenBody;
      }

    public string  getSpokenBody()
      {
        Debug.Assert(flagHasSpokenBody);
        return storeSpokenBody;
      }

    public bool  hasWrittenBody()
      {
        return flagHasWrittenBody;
      }

    public string  getWrittenBody()
      {
        Debug.Assert(flagHasWrittenBody);
        return storeWrittenBody;
      }

    public bool  hasBody()
      {
        return flagHasBody;
      }

    public string  getBody()
      {
        Debug.Assert(flagHasBody);
        return storeBody;
      }

    public bool  hasTo()
      {
        return flagHasTo;
      }

    public SMSAddressFieldJSON   getTo()
      {
        Debug.Assert(flagHasTo);
        return storeTo;
      }

    public bool  hasUserSpecifiedName()
      {
        return flagHasUserSpecifiedName;
      }

    public string  getUserSpecifiedName()
      {
        Debug.Assert(flagHasUserSpecifiedName);
        return storeUserSpecifiedName;
      }


    public virtual int extraSMSComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSMSComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSMSComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSMSLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initRecipients()
      {
        if (flagHasRecipients)
          {
            for (int num1 = 0; num1 < storeRecipients.Count; ++num1)
              {
              }
          }
        flagHasRecipients = true;
        storeRecipients.Clear();
      }
    public void appendRecipients(UnambiguousSMSRecipientJSON  to_append)
      {
        if (!flagHasRecipients)
          {
            flagHasRecipients = true;
            storeRecipients.Clear();
          }
        Debug.Assert(flagHasRecipients);
        storeRecipients.Add(to_append);
      }
    public void unsetRecipients()
      {
        if (flagHasRecipients)
          {
            for (int num2 = 0; num2 < storeRecipients.Count; ++num2)
              {
              }
          }
        flagHasRecipients = false;
        storeRecipients.Clear();
      }
    public void setSpokenBody(string new_value)
      {
        flagHasSpokenBody = true;
        storeSpokenBody = new_value;
      }
    public void unsetSpokenBody()
      {
        flagHasSpokenBody = false;
      }
    public void setWrittenBody(string new_value)
      {
        flagHasWrittenBody = true;
        storeWrittenBody = new_value;
      }
    public void unsetWrittenBody()
      {
        flagHasWrittenBody = false;
      }
    public void setBody(string new_value)
      {
        flagHasBody = true;
        storeBody = new_value;
      }
    public void unsetBody()
      {
        flagHasBody = false;
      }
    public void setTo(SMSAddressFieldJSON  new_value)
      {
        if (flagHasTo)
          {
          }
        flagHasTo = true;
        storeTo = new_value;
      }
    public void unsetTo()
      {
        if (flagHasTo)
          {
          }
        flagHasTo = false;
      }
    public void setUserSpecifiedName(string new_value)
      {
        flagHasUserSpecifiedName = true;
        storeUserSpecifiedName = new_value;
      }
    public void unsetUserSpecifiedName()
      {
        flagHasUserSpecifiedName = false;
      }

    public virtual void extraSMSAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSMSSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSMSLookup(key);
        if (old_field == null)
          {
            extraSMSAppendPair(key, new_component);
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
        if (flagHasRecipients)
          {
            handler.start_pair("Recipients");
            handler.start_array();
            for (int num1 = 0; num1 < storeRecipients.Count; ++num1)
              {
                if (partial_allowed)
                    storeRecipients[num1].write_partial_as_json(handler);
                else
                    storeRecipients[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSpokenBody)
          {
            handler.start_pair("SpokenBody");
            handler.string_value(storeSpokenBody);
          }
        if (flagHasWrittenBody)
          {
            handler.start_pair("WrittenBody");
            handler.string_value(storeWrittenBody);
          }
        if (flagHasBody)
          {
            handler.start_pair("Body");
            handler.string_value(storeBody);
          }
        if (flagHasTo)
          {
            handler.start_pair("To");
            if (partial_allowed)
                storeTo.write_partial_as_json(handler);
            else
                storeTo.write_as_json(handler);
          }
        if (flagHasUserSpecifiedName)
          {
            handler.start_pair("UserSpecifiedName");
            handler.string_value(storeUserSpecifiedName);
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

    public static SMSJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMS", ignore_extras);
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
    public static SMSJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMS", ignore_extras);
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
    public static SMSJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSJSON from_text(string text, bool ignore_extras)
      {
        SMSJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMS", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SMSJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SMSJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SMSJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMS", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private UnambiguousSMSRecipientJSON.HoldingArrayGenerator fieldGeneratorRecipients;
        private JSONHoldingStringGenerator fieldGeneratorSpokenBody;
        private JSONHoldingStringGenerator fieldGeneratorWrittenBody;
        private JSONHoldingStringGenerator fieldGeneratorBody;
        private SMSAddressFieldJSON.HoldingGenerator fieldGeneratorTo;
        private JSONHoldingStringGenerator fieldGeneratorUserSpecifiedName;
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
            SMSJSON result = new SMSJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSMSAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SMSJSON result)
          {
            if (fieldGeneratorRecipients.have_value)
              {
                result.initRecipients();
                int count = fieldGeneratorRecipients.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRecipients(fieldGeneratorRecipients.value[num]);
                  }
                fieldGeneratorRecipients.value.Clear();
                fieldGeneratorRecipients.have_value = false;
              }
            if (fieldGeneratorSpokenBody.have_value)
              {
                result.setSpokenBody(fieldGeneratorSpokenBody.value);
                fieldGeneratorSpokenBody.have_value = false;
              }
            if (fieldGeneratorWrittenBody.have_value)
              {
                result.setWrittenBody(fieldGeneratorWrittenBody.value);
                fieldGeneratorWrittenBody.have_value = false;
              }
            if (fieldGeneratorBody.have_value)
              {
                result.setBody(fieldGeneratorBody.value);
                fieldGeneratorBody.have_value = false;
              }
            if (fieldGeneratorTo.have_value)
              {
                result.setTo(fieldGeneratorTo.value);
                fieldGeneratorTo.have_value = false;
              }
            if (fieldGeneratorUserSpecifiedName.have_value)
              {
                result.setUserSpecifiedName(fieldGeneratorUserSpecifiedName.value);
                fieldGeneratorUserSpecifiedName.have_value = false;
              }
          }
        protected abstract void handle_result(SMSJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "ody", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorBody;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ecipients", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorRecipients;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pokenBody", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorSpokenBody;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "o", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorTo;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serSpecifiedName", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorUserSpecifiedName;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "rittenBody", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorWrittenBody;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorRecipients = new UnambiguousSMSRecipientJSON.HoldingArrayGenerator("field \"Recipients\" of the SMS class", ignore_extras);
            fieldGeneratorSpokenBody = new JSONHoldingStringGenerator("field \"SpokenBody\" of the SMS class");
            fieldGeneratorWrittenBody = new JSONHoldingStringGenerator("field \"WrittenBody\" of the SMS class");
            fieldGeneratorBody = new JSONHoldingStringGenerator("field \"Body\" of the SMS class");
            fieldGeneratorTo = new SMSAddressFieldJSON.HoldingGenerator("field \"To\" of the SMS class", ignore_extras);
            fieldGeneratorUserSpecifiedName = new JSONHoldingStringGenerator("field \"UserSpecifiedName\" of the SMS class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SMS class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRecipients = new UnambiguousSMSRecipientJSON.HoldingArrayGenerator("field \"Recipients\" of the SMS class", false);
            fieldGeneratorSpokenBody = new JSONHoldingStringGenerator("field \"SpokenBody\" of the SMS class");
            fieldGeneratorWrittenBody = new JSONHoldingStringGenerator("field \"WrittenBody\" of the SMS class");
            fieldGeneratorBody = new JSONHoldingStringGenerator("field \"Body\" of the SMS class");
            fieldGeneratorTo = new SMSAddressFieldJSON.HoldingGenerator("field \"To\" of the SMS class", false);
            fieldGeneratorUserSpecifiedName = new JSONHoldingStringGenerator("field \"UserSpecifiedName\" of the SMS class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SMS class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRecipients.reset();
            fieldGeneratorSpokenBody.reset();
            fieldGeneratorWrittenBody.reset();
            fieldGeneratorBody.reset();
            fieldGeneratorTo.reset();
            fieldGeneratorUserSpecifiedName.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorRecipients.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTo.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorRecipients.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTo.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SMSJSON  result)
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
        public SMSJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SMSJSON  result)
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
    protected virtual void handle_result(List<SMSJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SMSJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SMSJSON>();
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
    public List<SMSJSON> value;
  };
  };
