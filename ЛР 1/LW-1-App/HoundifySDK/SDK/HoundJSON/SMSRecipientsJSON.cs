/* file "SMSRecipientsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SMSRecipientsJSON : JSONBase
  {
    private bool flagHasUnambiguousRecipients;
    private List< UnambiguousSMSRecipientJSON  > storeUnambiguousRecipients;
    private bool flagHasAmbiguousMatches;
    private List< WhichContactChoicesJSON  > storeAmbiguousMatches;
    private bool flagHasPersonsWithAmbiguousPhoneNumbers;
    private List< ContactNumberChoicesJSON  > storePersonsWithAmbiguousPhoneNumbers;
    private bool flagHasNoNumberMatches;
    private List< PersonGroupJSON  > storeNoNumberMatches;
    private bool flagHasContactsWithSelectedNumbers;
    private List< ContactAndNumberJSON  > storeContactsWithSelectedNumbers;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONUnambiguousRecipients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field UnambiguousRecipients of SMSRecipientsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< UnambiguousSMSRecipientJSON  > vector_UnambiguousRecipients1 = new List< UnambiguousSMSRecipientJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UnambiguousSMSRecipientJSON convert_classy = UnambiguousSMSRecipientJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_UnambiguousRecipients1.Add(convert_classy);
          }
        initUnambiguousRecipients();
        for (int num1 = 0; num1 < vector_UnambiguousRecipients1.Count; ++num1)
            appendUnambiguousRecipients(vector_UnambiguousRecipients1[num1]);
        for (int num1 = 0; num1 < vector_UnambiguousRecipients1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmbiguousMatches(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmbiguousMatches of SMSRecipientsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< WhichContactChoicesJSON  > vector_AmbiguousMatches1 = new List< WhichContactChoicesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            WhichContactChoicesJSON convert_classy = WhichContactChoicesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AmbiguousMatches1.Add(convert_classy);
          }
        initAmbiguousMatches();
        for (int num2 = 0; num2 < vector_AmbiguousMatches1.Count; ++num2)
            appendAmbiguousMatches(vector_AmbiguousMatches1[num2]);
        for (int num1 = 0; num1 < vector_AmbiguousMatches1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPersonsWithAmbiguousPhoneNumbers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PersonsWithAmbiguousPhoneNumbers of SMSRecipientsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< ContactNumberChoicesJSON  > vector_PersonsWithAmbiguousPhoneNumbers1 = new List< ContactNumberChoicesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            ContactNumberChoicesJSON convert_classy = ContactNumberChoicesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_PersonsWithAmbiguousPhoneNumbers1.Add(convert_classy);
          }
        initPersonsWithAmbiguousPhoneNumbers();
        for (int num3 = 0; num3 < vector_PersonsWithAmbiguousPhoneNumbers1.Count; ++num3)
            appendPersonsWithAmbiguousPhoneNumbers(vector_PersonsWithAmbiguousPhoneNumbers1[num3]);
        for (int num1 = 0; num1 < vector_PersonsWithAmbiguousPhoneNumbers1.Count; ++num1)
          {
          }
      }


    private void  fromJSONNoNumberMatches(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NoNumberMatches of SMSRecipientsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< PersonGroupJSON  > vector_NoNumberMatches1 = new List< PersonGroupJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            PersonGroupJSON convert_classy = PersonGroupJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_NoNumberMatches1.Add(convert_classy);
          }
        initNoNumberMatches();
        for (int num4 = 0; num4 < vector_NoNumberMatches1.Count; ++num4)
            appendNoNumberMatches(vector_NoNumberMatches1[num4]);
        for (int num1 = 0; num1 < vector_NoNumberMatches1.Count; ++num1)
          {
          }
      }


    private void  fromJSONContactsWithSelectedNumbers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ContactsWithSelectedNumbers of SMSRecipientsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< ContactAndNumberJSON  > vector_ContactsWithSelectedNumbers1 = new List< ContactAndNumberJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            ContactAndNumberJSON convert_classy = ContactAndNumberJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ContactsWithSelectedNumbers1.Add(convert_classy);
          }
        initContactsWithSelectedNumbers();
        for (int num5 = 0; num5 < vector_ContactsWithSelectedNumbers1.Count; ++num5)
            appendContactsWithSelectedNumbers(vector_ContactsWithSelectedNumbers1[num5]);
        for (int num1 = 0; num1 < vector_ContactsWithSelectedNumbers1.Count; ++num1)
          {
          }
      }


    public SMSRecipientsJSON()
      {
        flagHasUnambiguousRecipients = false;
        flagHasAmbiguousMatches = false;
        flagHasPersonsWithAmbiguousPhoneNumbers = false;
        flagHasNoNumberMatches = false;
        flagHasContactsWithSelectedNumbers = false;
        storeUnambiguousRecipients = new List< UnambiguousSMSRecipientJSON  >();
        storeAmbiguousMatches = new List< WhichContactChoicesJSON  >();
        storePersonsWithAmbiguousPhoneNumbers = new List< ContactNumberChoicesJSON  >();
        storeNoNumberMatches = new List< PersonGroupJSON  >();
        storeContactsWithSelectedNumbers = new List< ContactAndNumberJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasUnambiguousRecipients()
      {
        return flagHasUnambiguousRecipients;
      }

    public int  countOfUnambiguousRecipients()
      {
        Debug.Assert(flagHasUnambiguousRecipients);
        return storeUnambiguousRecipients.Count;
      }

    public UnambiguousSMSRecipientJSON   elementOfUnambiguousRecipients(int element_num)
      {
        Debug.Assert(flagHasUnambiguousRecipients);
        return storeUnambiguousRecipients[element_num];
      }

    public List< UnambiguousSMSRecipientJSON  >  getUnambiguousRecipients()
      {
        Debug.Assert(flagHasUnambiguousRecipients);
        return storeUnambiguousRecipients;
      }

    public bool  hasAmbiguousMatches()
      {
        return flagHasAmbiguousMatches;
      }

    public int  countOfAmbiguousMatches()
      {
        Debug.Assert(flagHasAmbiguousMatches);
        return storeAmbiguousMatches.Count;
      }

    public WhichContactChoicesJSON   elementOfAmbiguousMatches(int element_num)
      {
        Debug.Assert(flagHasAmbiguousMatches);
        return storeAmbiguousMatches[element_num];
      }

    public List< WhichContactChoicesJSON  >  getAmbiguousMatches()
      {
        Debug.Assert(flagHasAmbiguousMatches);
        return storeAmbiguousMatches;
      }

    public bool  hasPersonsWithAmbiguousPhoneNumbers()
      {
        return flagHasPersonsWithAmbiguousPhoneNumbers;
      }

    public int  countOfPersonsWithAmbiguousPhoneNumbers()
      {
        Debug.Assert(flagHasPersonsWithAmbiguousPhoneNumbers);
        return storePersonsWithAmbiguousPhoneNumbers.Count;
      }

    public ContactNumberChoicesJSON   elementOfPersonsWithAmbiguousPhoneNumbers(int element_num)
      {
        Debug.Assert(flagHasPersonsWithAmbiguousPhoneNumbers);
        return storePersonsWithAmbiguousPhoneNumbers[element_num];
      }

    public List< ContactNumberChoicesJSON  >  getPersonsWithAmbiguousPhoneNumbers()
      {
        Debug.Assert(flagHasPersonsWithAmbiguousPhoneNumbers);
        return storePersonsWithAmbiguousPhoneNumbers;
      }

    public bool  hasNoNumberMatches()
      {
        return flagHasNoNumberMatches;
      }

    public int  countOfNoNumberMatches()
      {
        Debug.Assert(flagHasNoNumberMatches);
        return storeNoNumberMatches.Count;
      }

    public PersonGroupJSON   elementOfNoNumberMatches(int element_num)
      {
        Debug.Assert(flagHasNoNumberMatches);
        return storeNoNumberMatches[element_num];
      }

    public List< PersonGroupJSON  >  getNoNumberMatches()
      {
        Debug.Assert(flagHasNoNumberMatches);
        return storeNoNumberMatches;
      }

    public bool  hasContactsWithSelectedNumbers()
      {
        return flagHasContactsWithSelectedNumbers;
      }

    public int  countOfContactsWithSelectedNumbers()
      {
        Debug.Assert(flagHasContactsWithSelectedNumbers);
        return storeContactsWithSelectedNumbers.Count;
      }

    public ContactAndNumberJSON   elementOfContactsWithSelectedNumbers(int element_num)
      {
        Debug.Assert(flagHasContactsWithSelectedNumbers);
        return storeContactsWithSelectedNumbers[element_num];
      }

    public List< ContactAndNumberJSON  >  getContactsWithSelectedNumbers()
      {
        Debug.Assert(flagHasContactsWithSelectedNumbers);
        return storeContactsWithSelectedNumbers;
      }


    public virtual int extraSMSRecipientsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSMSRecipientsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSMSRecipientsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSMSRecipientsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initUnambiguousRecipients()
      {
        if (flagHasUnambiguousRecipients)
          {
            for (int num1 = 0; num1 < storeUnambiguousRecipients.Count; ++num1)
              {
              }
          }
        flagHasUnambiguousRecipients = true;
        storeUnambiguousRecipients.Clear();
      }
    public void appendUnambiguousRecipients(UnambiguousSMSRecipientJSON  to_append)
      {
        if (!flagHasUnambiguousRecipients)
          {
            flagHasUnambiguousRecipients = true;
            storeUnambiguousRecipients.Clear();
          }
        Debug.Assert(flagHasUnambiguousRecipients);
        storeUnambiguousRecipients.Add(to_append);
      }
    public void unsetUnambiguousRecipients()
      {
        if (flagHasUnambiguousRecipients)
          {
            for (int num2 = 0; num2 < storeUnambiguousRecipients.Count; ++num2)
              {
              }
          }
        flagHasUnambiguousRecipients = false;
        storeUnambiguousRecipients.Clear();
      }
    public void initAmbiguousMatches()
      {
        if (flagHasAmbiguousMatches)
          {
            for (int num3 = 0; num3 < storeAmbiguousMatches.Count; ++num3)
              {
              }
          }
        flagHasAmbiguousMatches = true;
        storeAmbiguousMatches.Clear();
      }
    public void appendAmbiguousMatches(WhichContactChoicesJSON  to_append)
      {
        if (!flagHasAmbiguousMatches)
          {
            flagHasAmbiguousMatches = true;
            storeAmbiguousMatches.Clear();
          }
        Debug.Assert(flagHasAmbiguousMatches);
        storeAmbiguousMatches.Add(to_append);
      }
    public void unsetAmbiguousMatches()
      {
        if (flagHasAmbiguousMatches)
          {
            for (int num4 = 0; num4 < storeAmbiguousMatches.Count; ++num4)
              {
              }
          }
        flagHasAmbiguousMatches = false;
        storeAmbiguousMatches.Clear();
      }
    public void initPersonsWithAmbiguousPhoneNumbers()
      {
        if (flagHasPersonsWithAmbiguousPhoneNumbers)
          {
            for (int num5 = 0; num5 < storePersonsWithAmbiguousPhoneNumbers.Count; ++num5)
              {
              }
          }
        flagHasPersonsWithAmbiguousPhoneNumbers = true;
        storePersonsWithAmbiguousPhoneNumbers.Clear();
      }
    public void appendPersonsWithAmbiguousPhoneNumbers(ContactNumberChoicesJSON  to_append)
      {
        if (!flagHasPersonsWithAmbiguousPhoneNumbers)
          {
            flagHasPersonsWithAmbiguousPhoneNumbers = true;
            storePersonsWithAmbiguousPhoneNumbers.Clear();
          }
        Debug.Assert(flagHasPersonsWithAmbiguousPhoneNumbers);
        storePersonsWithAmbiguousPhoneNumbers.Add(to_append);
      }
    public void unsetPersonsWithAmbiguousPhoneNumbers()
      {
        if (flagHasPersonsWithAmbiguousPhoneNumbers)
          {
            for (int num6 = 0; num6 < storePersonsWithAmbiguousPhoneNumbers.Count; ++num6)
              {
              }
          }
        flagHasPersonsWithAmbiguousPhoneNumbers = false;
        storePersonsWithAmbiguousPhoneNumbers.Clear();
      }
    public void initNoNumberMatches()
      {
        if (flagHasNoNumberMatches)
          {
            for (int num7 = 0; num7 < storeNoNumberMatches.Count; ++num7)
              {
              }
          }
        flagHasNoNumberMatches = true;
        storeNoNumberMatches.Clear();
      }
    public void appendNoNumberMatches(PersonGroupJSON  to_append)
      {
        if (!flagHasNoNumberMatches)
          {
            flagHasNoNumberMatches = true;
            storeNoNumberMatches.Clear();
          }
        Debug.Assert(flagHasNoNumberMatches);
        storeNoNumberMatches.Add(to_append);
      }
    public void unsetNoNumberMatches()
      {
        if (flagHasNoNumberMatches)
          {
            for (int num8 = 0; num8 < storeNoNumberMatches.Count; ++num8)
              {
              }
          }
        flagHasNoNumberMatches = false;
        storeNoNumberMatches.Clear();
      }
    public void initContactsWithSelectedNumbers()
      {
        if (flagHasContactsWithSelectedNumbers)
          {
            for (int num9 = 0; num9 < storeContactsWithSelectedNumbers.Count; ++num9)
              {
              }
          }
        flagHasContactsWithSelectedNumbers = true;
        storeContactsWithSelectedNumbers.Clear();
      }
    public void appendContactsWithSelectedNumbers(ContactAndNumberJSON  to_append)
      {
        if (!flagHasContactsWithSelectedNumbers)
          {
            flagHasContactsWithSelectedNumbers = true;
            storeContactsWithSelectedNumbers.Clear();
          }
        Debug.Assert(flagHasContactsWithSelectedNumbers);
        storeContactsWithSelectedNumbers.Add(to_append);
      }
    public void unsetContactsWithSelectedNumbers()
      {
        if (flagHasContactsWithSelectedNumbers)
          {
            for (int num10 = 0; num10 < storeContactsWithSelectedNumbers.Count; ++num10)
              {
              }
          }
        flagHasContactsWithSelectedNumbers = false;
        storeContactsWithSelectedNumbers.Clear();
      }

    public virtual void extraSMSRecipientsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSMSRecipientsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSMSRecipientsLookup(key);
        if (old_field == null)
          {
            extraSMSRecipientsAppendPair(key, new_component);
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
        if (flagHasUnambiguousRecipients)
          {
            handler.start_pair("UnambiguousRecipients");
            handler.start_array();
            for (int num1 = 0; num1 < storeUnambiguousRecipients.Count; ++num1)
              {
                if (partial_allowed)
                    storeUnambiguousRecipients[num1].write_partial_as_json(handler);
                else
                    storeUnambiguousRecipients[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAmbiguousMatches)
          {
            handler.start_pair("AmbiguousMatches");
            handler.start_array();
            for (int num2 = 0; num2 < storeAmbiguousMatches.Count; ++num2)
              {
                if (partial_allowed)
                    storeAmbiguousMatches[num2].write_partial_as_json(handler);
                else
                    storeAmbiguousMatches[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasPersonsWithAmbiguousPhoneNumbers)
          {
            handler.start_pair("PersonsWithAmbiguousPhoneNumbers");
            handler.start_array();
            for (int num3 = 0; num3 < storePersonsWithAmbiguousPhoneNumbers.Count; ++num3)
              {
                if (partial_allowed)
                    storePersonsWithAmbiguousPhoneNumbers[num3].write_partial_as_json(handler);
                else
                    storePersonsWithAmbiguousPhoneNumbers[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasNoNumberMatches)
          {
            handler.start_pair("NoNumberMatches");
            handler.start_array();
            for (int num4 = 0; num4 < storeNoNumberMatches.Count; ++num4)
              {
                if (partial_allowed)
                    storeNoNumberMatches[num4].write_partial_as_json(handler);
                else
                    storeNoNumberMatches[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasContactsWithSelectedNumbers)
          {
            handler.start_pair("ContactsWithSelectedNumbers");
            handler.start_array();
            for (int num5 = 0; num5 < storeContactsWithSelectedNumbers.Count; ++num5)
              {
                if (partial_allowed)
                    storeContactsWithSelectedNumbers[num5].write_partial_as_json(handler);
                else
                    storeContactsWithSelectedNumbers[num5].write_as_json(handler);
              }
            handler.finish_array();
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

    public static SMSRecipientsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSRecipientsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSRecipients", ignore_extras);
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
    public static SMSRecipientsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSRecipientsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSRecipientsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSRecipients", ignore_extras);
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
    public static SMSRecipientsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSRecipientsJSON from_text(string text, bool ignore_extras)
      {
        SMSRecipientsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSRecipients", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SMSRecipientsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SMSRecipientsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SMSRecipientsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSRecipients", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private UnambiguousSMSRecipientJSON.HoldingArrayGenerator fieldGeneratorUnambiguousRecipients;
        private WhichContactChoicesJSON.HoldingArrayGenerator fieldGeneratorAmbiguousMatches;
        private ContactNumberChoicesJSON.HoldingArrayGenerator fieldGeneratorPersonsWithAmbiguousPhoneNumbers;
        private PersonGroupJSON.HoldingArrayGenerator fieldGeneratorNoNumberMatches;
        private ContactAndNumberJSON.HoldingArrayGenerator fieldGeneratorContactsWithSelectedNumbers;
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
            SMSRecipientsJSON result = new SMSRecipientsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSMSRecipientsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SMSRecipientsJSON result)
          {
            if (fieldGeneratorUnambiguousRecipients.have_value)
              {
                result.initUnambiguousRecipients();
                int count = fieldGeneratorUnambiguousRecipients.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendUnambiguousRecipients(fieldGeneratorUnambiguousRecipients.value[num]);
                  }
                fieldGeneratorUnambiguousRecipients.value.Clear();
                fieldGeneratorUnambiguousRecipients.have_value = false;
              }
            if (fieldGeneratorAmbiguousMatches.have_value)
              {
                result.initAmbiguousMatches();
                int count = fieldGeneratorAmbiguousMatches.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAmbiguousMatches(fieldGeneratorAmbiguousMatches.value[num]);
                  }
                fieldGeneratorAmbiguousMatches.value.Clear();
                fieldGeneratorAmbiguousMatches.have_value = false;
              }
            if (fieldGeneratorPersonsWithAmbiguousPhoneNumbers.have_value)
              {
                result.initPersonsWithAmbiguousPhoneNumbers();
                int count = fieldGeneratorPersonsWithAmbiguousPhoneNumbers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPersonsWithAmbiguousPhoneNumbers(fieldGeneratorPersonsWithAmbiguousPhoneNumbers.value[num]);
                  }
                fieldGeneratorPersonsWithAmbiguousPhoneNumbers.value.Clear();
                fieldGeneratorPersonsWithAmbiguousPhoneNumbers.have_value = false;
              }
            if (fieldGeneratorNoNumberMatches.have_value)
              {
                result.initNoNumberMatches();
                int count = fieldGeneratorNoNumberMatches.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNoNumberMatches(fieldGeneratorNoNumberMatches.value[num]);
                  }
                fieldGeneratorNoNumberMatches.value.Clear();
                fieldGeneratorNoNumberMatches.have_value = false;
              }
            if (fieldGeneratorContactsWithSelectedNumbers.have_value)
              {
                result.initContactsWithSelectedNumbers();
                int count = fieldGeneratorContactsWithSelectedNumbers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendContactsWithSelectedNumbers(fieldGeneratorContactsWithSelectedNumbers.value[num]);
                  }
                fieldGeneratorContactsWithSelectedNumbers.value.Clear();
                fieldGeneratorContactsWithSelectedNumbers.have_value = false;
              }
          }
        protected abstract void handle_result(SMSRecipientsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "mbiguousMatches", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorAmbiguousMatches;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "ontactsWithSelectedNumbers", 0, 26, false) == 0) && (field_name.Length == 27))
                        return fieldGeneratorContactsWithSelectedNumbers;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "oNumberMatches", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorNoNumberMatches;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ersonsWithAmbiguousPhoneNumbers", 0, 31, false) == 0) && (field_name.Length == 32))
                        return fieldGeneratorPersonsWithAmbiguousPhoneNumbers;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nambiguousRecipients", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorUnambiguousRecipients;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorUnambiguousRecipients = new UnambiguousSMSRecipientJSON.HoldingArrayGenerator("field \"UnambiguousRecipients\" of the SMSRecipients class", ignore_extras);
            fieldGeneratorAmbiguousMatches = new WhichContactChoicesJSON.HoldingArrayGenerator("field \"AmbiguousMatches\" of the SMSRecipients class", ignore_extras);
            fieldGeneratorPersonsWithAmbiguousPhoneNumbers = new ContactNumberChoicesJSON.HoldingArrayGenerator("field \"PersonsWithAmbiguousPhoneNumbers\" of the SMSRecipients class", ignore_extras);
            fieldGeneratorNoNumberMatches = new PersonGroupJSON.HoldingArrayGenerator("field \"NoNumberMatches\" of the SMSRecipients class", ignore_extras);
            fieldGeneratorContactsWithSelectedNumbers = new ContactAndNumberJSON.HoldingArrayGenerator("field \"ContactsWithSelectedNumbers\" of the SMSRecipients class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SMSRecipients class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorUnambiguousRecipients = new UnambiguousSMSRecipientJSON.HoldingArrayGenerator("field \"UnambiguousRecipients\" of the SMSRecipients class", false);
            fieldGeneratorAmbiguousMatches = new WhichContactChoicesJSON.HoldingArrayGenerator("field \"AmbiguousMatches\" of the SMSRecipients class", false);
            fieldGeneratorPersonsWithAmbiguousPhoneNumbers = new ContactNumberChoicesJSON.HoldingArrayGenerator("field \"PersonsWithAmbiguousPhoneNumbers\" of the SMSRecipients class", false);
            fieldGeneratorNoNumberMatches = new PersonGroupJSON.HoldingArrayGenerator("field \"NoNumberMatches\" of the SMSRecipients class", false);
            fieldGeneratorContactsWithSelectedNumbers = new ContactAndNumberJSON.HoldingArrayGenerator("field \"ContactsWithSelectedNumbers\" of the SMSRecipients class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SMSRecipients class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorUnambiguousRecipients.reset();
            fieldGeneratorAmbiguousMatches.reset();
            fieldGeneratorPersonsWithAmbiguousPhoneNumbers.reset();
            fieldGeneratorNoNumberMatches.reset();
            fieldGeneratorContactsWithSelectedNumbers.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorUnambiguousRecipients.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAmbiguousMatches.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPersonsWithAmbiguousPhoneNumbers.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNoNumberMatches.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorContactsWithSelectedNumbers.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorUnambiguousRecipients.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAmbiguousMatches.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPersonsWithAmbiguousPhoneNumbers.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNoNumberMatches.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorContactsWithSelectedNumbers.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SMSRecipientsJSON  result)
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
        public SMSRecipientsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SMSRecipientsJSON  result)
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
    protected virtual void handle_result(List<SMSRecipientsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SMSRecipientsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SMSRecipientsJSON>();
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
    public List<SMSRecipientsJSON> value;
  };
  };
