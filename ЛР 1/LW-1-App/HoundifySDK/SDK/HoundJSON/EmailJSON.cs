/* file "EmailJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class EmailJSON : JSONBase
  {
    private bool flagHasTo;
    private EmailAddressFieldJSON  storeTo;
    private bool flagHasCc;
    private EmailAddressFieldJSON  storeCc;
    private bool flagHasBcc;
    private EmailAddressFieldJSON  storeBcc;
    private bool flagHasRecipients;
    private List< EmailContactResultJSON  > storeRecipients;
    private bool flagHasSpokenSubject;
    private string storeSpokenSubject;
    private bool flagHasSpokenBody;
    private string storeSpokenBody;
    private bool flagHasSubject;
    private string storeSubject;
    private bool flagHasBody;
    private string storeBody;


    private void  fromJSONTo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EmailAddressFieldJSON convert_classy = EmailAddressFieldJSON.from_json(json_value, ignore_extras, true);
        setTo(convert_classy);
      }


    private void  fromJSONCc(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EmailAddressFieldJSON convert_classy = EmailAddressFieldJSON.from_json(json_value, ignore_extras, true);
        setCc(convert_classy);
      }


    private void  fromJSONBcc(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EmailAddressFieldJSON convert_classy = EmailAddressFieldJSON.from_json(json_value, ignore_extras, true);
        setBcc(convert_classy);
      }


    private void  fromJSONRecipients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Recipients of EmailJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< EmailContactResultJSON  > vector_Recipients1 = new List< EmailContactResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            EmailContactResultJSON convert_classy = EmailContactResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Recipients1.Add(convert_classy);
          }
        initRecipients();
        for (int num1 = 0; num1 < vector_Recipients1.Count; ++num1)
            appendRecipients(vector_Recipients1[num1]);
        for (int num1 = 0; num1 < vector_Recipients1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpokenSubject(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenSubject of EmailJSON is not a string.");
        setSpokenSubject(json_string.getData());
      }


    private void  fromJSONSpokenBody(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenBody of EmailJSON is not a string.");
        setSpokenBody(json_string.getData());
      }


    private void  fromJSONSubject(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Subject of EmailJSON is not a string.");
        setSubject(json_string.getData());
      }


    private void  fromJSONBody(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Body of EmailJSON is not a string.");
        setBody(json_string.getData());
      }


    public EmailJSON()
      {
        flagHasTo = false;
        flagHasCc = false;
        flagHasBcc = false;
        flagHasRecipients = false;
        flagHasSpokenSubject = false;
        flagHasSpokenBody = false;
        flagHasSubject = false;
        flagHasBody = false;
        storeRecipients = new List< EmailContactResultJSON  >();
      }

    public bool  hasTo()
      {
        return flagHasTo;
      }

    public EmailAddressFieldJSON   getTo()
      {
        Debug.Assert(flagHasTo);
        return storeTo;
      }

    public bool  hasCc()
      {
        return flagHasCc;
      }

    public EmailAddressFieldJSON   getCc()
      {
        Debug.Assert(flagHasCc);
        return storeCc;
      }

    public bool  hasBcc()
      {
        return flagHasBcc;
      }

    public EmailAddressFieldJSON   getBcc()
      {
        Debug.Assert(flagHasBcc);
        return storeBcc;
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

    public EmailContactResultJSON   elementOfRecipients(int element_num)
      {
        Debug.Assert(flagHasRecipients);
        return storeRecipients[element_num];
      }

    public List< EmailContactResultJSON  >  getRecipients()
      {
        Debug.Assert(flagHasRecipients);
        return storeRecipients;
      }

    public bool  hasSpokenSubject()
      {
        return flagHasSpokenSubject;
      }

    public string  getSpokenSubject()
      {
        Debug.Assert(flagHasSpokenSubject);
        return storeSpokenSubject;
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

    public bool  hasSubject()
      {
        return flagHasSubject;
      }

    public string  getSubject()
      {
        Debug.Assert(flagHasSubject);
        return storeSubject;
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



    public void setTo(EmailAddressFieldJSON  new_value)
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
    public void setCc(EmailAddressFieldJSON  new_value)
      {
        if (flagHasCc)
          {
          }
        flagHasCc = true;
        storeCc = new_value;
      }
    public void unsetCc()
      {
        if (flagHasCc)
          {
          }
        flagHasCc = false;
      }
    public void setBcc(EmailAddressFieldJSON  new_value)
      {
        if (flagHasBcc)
          {
          }
        flagHasBcc = true;
        storeBcc = new_value;
      }
    public void unsetBcc()
      {
        if (flagHasBcc)
          {
          }
        flagHasBcc = false;
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
    public void appendRecipients(EmailContactResultJSON  to_append)
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
    public void setSpokenSubject(string new_value)
      {
        flagHasSpokenSubject = true;
        storeSpokenSubject = new_value;
      }
    public void unsetSpokenSubject()
      {
        flagHasSpokenSubject = false;
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
    public void setSubject(string new_value)
      {
        flagHasSubject = true;
        storeSubject = new_value;
      }
    public void unsetSubject()
      {
        flagHasSubject = false;
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


    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        if (flagHasTo)
          {
            handler.start_pair("To");
            if (partial_allowed)
                storeTo.write_partial_as_json(handler);
            else
                storeTo.write_as_json(handler);
          }
        if (flagHasCc)
          {
            handler.start_pair("Cc");
            if (partial_allowed)
                storeCc.write_partial_as_json(handler);
            else
                storeCc.write_as_json(handler);
          }
        if (flagHasBcc)
          {
            handler.start_pair("Bcc");
            if (partial_allowed)
                storeBcc.write_partial_as_json(handler);
            else
                storeBcc.write_as_json(handler);
          }
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
        if (flagHasSpokenSubject)
          {
            handler.start_pair("SpokenSubject");
            handler.string_value(storeSpokenSubject);
          }
        if (flagHasSpokenBody)
          {
            handler.start_pair("SpokenBody");
            handler.string_value(storeSpokenBody);
          }
        Debug.Assert(partial_allowed || flagHasSubject);
        if (flagHasSubject)
          {
            handler.start_pair("Subject");
            handler.string_value(storeSubject);
          }
        Debug.Assert(partial_allowed || flagHasBody);
        if (flagHasBody)
          {
            handler.start_pair("Body");
            handler.string_value(storeBody);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasSubject()))
          {
            return "When parsing the object for %what%, the \"Subject\" field was missing.";
          }
        if (!(hasBody()))
          {
            return "When parsing the object for %what%, the \"Body\" field was missing.";
          }
        return null;
      }

    public static EmailJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmailJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Email", ignore_extras);
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
    public static EmailJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EmailJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmailJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Email", ignore_extras);
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
    public static EmailJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EmailJSON from_text(string text, bool ignore_extras)
      {
        EmailJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Email", ignore_extras);
            JSONParse.parse_json_value(text, "Text for EmailJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static EmailJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        EmailJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Email", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private EmailAddressFieldJSON.HoldingGenerator fieldGeneratorTo;
        private EmailAddressFieldJSON.HoldingGenerator fieldGeneratorCc;
        private EmailAddressFieldJSON.HoldingGenerator fieldGeneratorBcc;
        private EmailContactResultJSON.HoldingArrayGenerator fieldGeneratorRecipients;
        private JSONHoldingStringGenerator fieldGeneratorSpokenSubject;
        private JSONHoldingStringGenerator fieldGeneratorSpokenBody;
        private JSONHoldingStringGenerator fieldGeneratorSubject;
        private JSONHoldingStringGenerator fieldGeneratorBody;

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
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            EmailJSON result = new EmailJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(EmailJSON result)
          {
            if (fieldGeneratorTo.have_value)
              {
                result.setTo(fieldGeneratorTo.value);
                fieldGeneratorTo.have_value = false;
              }
            if (fieldGeneratorCc.have_value)
              {
                result.setCc(fieldGeneratorCc.value);
                fieldGeneratorCc.have_value = false;
              }
            if (fieldGeneratorBcc.have_value)
              {
                result.setBcc(fieldGeneratorBcc.value);
                fieldGeneratorBcc.have_value = false;
              }
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
            if (fieldGeneratorSpokenSubject.have_value)
              {
                result.setSpokenSubject(fieldGeneratorSpokenSubject.value);
                fieldGeneratorSpokenSubject.have_value = false;
              }
            if (fieldGeneratorSpokenBody.have_value)
              {
                result.setSpokenBody(fieldGeneratorSpokenBody.value);
                fieldGeneratorSpokenBody.have_value = false;
              }
            if (fieldGeneratorSubject.have_value)
              {
                result.setSubject(fieldGeneratorSubject.value);
                fieldGeneratorSubject.have_value = false;
              }
            else if ((!(result.hasSubject())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Subject\" field was missing.");
              }
            if (fieldGeneratorBody.have_value)
              {
                result.setBody(fieldGeneratorBody.value);
                fieldGeneratorBody.have_value = false;
              }
            else if ((!(result.hasBody())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Body\" field was missing.");
              }
          }
        protected abstract void handle_result(EmailJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    switch (field_name[1])
                      {
                        case 'c':
                            if ((String.Compare(field_name, 2, "c", 0, 1, false) == 0) && (field_name.Length == 3))
                                return fieldGeneratorBcc;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "dy", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorBody;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "c", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorCc;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ecipients", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorRecipients;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'p':
                            if (String.Compare(field_name, 2, "oken", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'B':
                                        if ((String.Compare(field_name, 7, "ody", 0, 3, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorSpokenBody;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 7, "ubject", 0, 6, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorSpokenSubject;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "bject", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorSubject;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "o", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorTo;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTo = new EmailAddressFieldJSON.HoldingGenerator("field \"To\" of the Email class", ignore_extras);
            fieldGeneratorCc = new EmailAddressFieldJSON.HoldingGenerator("field \"Cc\" of the Email class", ignore_extras);
            fieldGeneratorBcc = new EmailAddressFieldJSON.HoldingGenerator("field \"Bcc\" of the Email class", ignore_extras);
            fieldGeneratorRecipients = new EmailContactResultJSON.HoldingArrayGenerator("field \"Recipients\" of the Email class", ignore_extras);
            fieldGeneratorSpokenSubject = new JSONHoldingStringGenerator("field \"SpokenSubject\" of the Email class");
            fieldGeneratorSpokenBody = new JSONHoldingStringGenerator("field \"SpokenBody\" of the Email class");
            fieldGeneratorSubject = new JSONHoldingStringGenerator("field \"Subject\" of the Email class");
            fieldGeneratorBody = new JSONHoldingStringGenerator("field \"Body\" of the Email class");
            set_what("the Email class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTo = new EmailAddressFieldJSON.HoldingGenerator("field \"To\" of the Email class", false);
            fieldGeneratorCc = new EmailAddressFieldJSON.HoldingGenerator("field \"Cc\" of the Email class", false);
            fieldGeneratorBcc = new EmailAddressFieldJSON.HoldingGenerator("field \"Bcc\" of the Email class", false);
            fieldGeneratorRecipients = new EmailContactResultJSON.HoldingArrayGenerator("field \"Recipients\" of the Email class", false);
            fieldGeneratorSpokenSubject = new JSONHoldingStringGenerator("field \"SpokenSubject\" of the Email class");
            fieldGeneratorSpokenBody = new JSONHoldingStringGenerator("field \"SpokenBody\" of the Email class");
            fieldGeneratorSubject = new JSONHoldingStringGenerator("field \"Subject\" of the Email class");
            fieldGeneratorBody = new JSONHoldingStringGenerator("field \"Body\" of the Email class");
            set_what("the Email class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTo.reset();
            fieldGeneratorCc.reset();
            fieldGeneratorBcc.reset();
            fieldGeneratorRecipients.reset();
            fieldGeneratorSpokenSubject.reset();
            fieldGeneratorSpokenBody.reset();
            fieldGeneratorSubject.reset();
            fieldGeneratorBody.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTo.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCc.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorBcc.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRecipients.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTo.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCc.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorBcc.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRecipients.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(EmailJSON  result)
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
        public EmailJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(EmailJSON  result)
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
    protected virtual void handle_result(List<EmailJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<EmailJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<EmailJSON>();
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
    public List<EmailJSON> value;
  };
  };
