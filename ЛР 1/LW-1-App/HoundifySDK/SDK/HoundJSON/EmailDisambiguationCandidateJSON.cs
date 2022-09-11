/* file "EmailDisambiguationCandidateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class EmailDisambiguationCandidateJSON : JSONBase
  {
    public class TypeEmailsJSON : JSONBase
      {
        private bool flagHasLabel;
        private string storeLabel;
        private bool flagHasEmail;
        private string storeEmail;


        private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Label of TypeEmailsJSON is not a string.");
            setLabel(json_string.getData());
          }


        private void  fromJSONEmail(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Email of TypeEmailsJSON is not a string.");
            setEmail(json_string.getData());
          }


        public TypeEmailsJSON()
          {
            flagHasLabel = false;
            flagHasEmail = false;
          }

        public bool  hasLabel()
          {
            return flagHasLabel;
          }

        public string  getLabel()
          {
            Debug.Assert(flagHasLabel);
            return storeLabel;
          }

        public bool  hasEmail()
          {
            return flagHasEmail;
          }

        public string  getEmail()
          {
            Debug.Assert(flagHasEmail);
            return storeEmail;
          }



        public void setLabel(string new_value)
          {
            flagHasLabel = true;
            storeLabel = new_value;
          }
        public void unsetLabel()
          {
            flagHasLabel = false;
          }
        public void setEmail(string new_value)
          {
            flagHasEmail = true;
            storeEmail = new_value;
          }
        public void unsetEmail()
          {
            flagHasEmail = false;
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
            Debug.Assert(partial_allowed || flagHasLabel);
            if (flagHasLabel)
              {
                handler.start_pair("Label");
                handler.string_value(storeLabel);
              }
            Debug.Assert(partial_allowed || flagHasEmail);
            if (flagHasEmail)
              {
                handler.start_pair("Email");
                handler.string_value(storeEmail);
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
            if (!(hasLabel()))
              {
                return "When parsing the object for %what%, the \"Label\" field was missing.";
              }
            if (!(hasEmail()))
              {
                return "When parsing the object for %what%, the \"Email\" field was missing.";
              }
            return null;
          }

        public static TypeEmailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeEmailsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEmails", ignore_extras);
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
        public static TypeEmailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeEmailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeEmailsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEmails", ignore_extras);
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
        public static TypeEmailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeEmailsJSON from_text(string text, bool ignore_extras)
          {
            TypeEmailsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEmails", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeEmailsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeEmailsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeEmailsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEmails", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorLabel;
            private JSONHoldingStringGenerator fieldGeneratorEmail;

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
                TypeEmailsJSON result = new TypeEmailsJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeEmailsJSON result)
              {
                if (fieldGeneratorLabel.have_value)
                  {
                    result.setLabel(fieldGeneratorLabel.value);
                    fieldGeneratorLabel.have_value = false;
                  }
                else if ((!(result.hasLabel())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Label\" field was missing.");
                  }
                if (fieldGeneratorEmail.have_value)
                  {
                    result.setEmail(fieldGeneratorEmail.value);
                    fieldGeneratorEmail.have_value = false;
                  }
                else if ((!(result.hasEmail())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Email\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeEmailsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'E':
                        if ((String.Compare(field_name, 1, "mail", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorEmail;
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorLabel;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the TypeEmails class");
                fieldGeneratorEmail = new JSONHoldingStringGenerator("field \"Email\" of the TypeEmails class");
                set_what("the TypeEmails class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the TypeEmails class");
                fieldGeneratorEmail = new JSONHoldingStringGenerator("field \"Email\" of the TypeEmails class");
                set_what("the TypeEmails class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorLabel.reset();
                fieldGeneratorEmail.reset();
                base.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeEmailsJSON  result)
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
            public TypeEmailsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeEmailsJSON  result)
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
        protected virtual void handle_result(List<TypeEmailsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeEmailsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeEmailsJSON>();
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
        public List<TypeEmailsJSON> value;
      };
      };
    private bool flagHasContactName;
    private string storeContactName;
    private bool flagHasContactID;
    private string storeContactID;
    private bool flagHasEmails;
    private List< TypeEmailsJSON  > storeEmails;


    private void  fromJSONContactName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ContactName of EmailDisambiguationCandidateJSON is not a string.");
        setContactName(json_string.getData());
      }


    private void  fromJSONContactID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ContactID of EmailDisambiguationCandidateJSON is not a string.");
        setContactID(json_string.getData());
      }


    private void  fromJSONEmails(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Emails of EmailDisambiguationCandidateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeEmailsJSON  > vector_Emails1 = new List< TypeEmailsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeEmailsJSON convert_classy = TypeEmailsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Emails1.Add(convert_classy);
          }
        initEmails();
        for (int num1 = 0; num1 < vector_Emails1.Count; ++num1)
            appendEmails(vector_Emails1[num1]);
        for (int num1 = 0; num1 < vector_Emails1.Count; ++num1)
          {
          }
      }


    public EmailDisambiguationCandidateJSON()
      {
        flagHasContactName = false;
        flagHasContactID = false;
        flagHasEmails = false;
        storeEmails = new List< TypeEmailsJSON  >();
      }

    public bool  hasContactName()
      {
        return flagHasContactName;
      }

    public string  getContactName()
      {
        Debug.Assert(flagHasContactName);
        return storeContactName;
      }

    public bool  hasContactID()
      {
        return flagHasContactID;
      }

    public string  getContactID()
      {
        Debug.Assert(flagHasContactID);
        return storeContactID;
      }

    public bool  hasEmails()
      {
        return flagHasEmails;
      }

    public int  countOfEmails()
      {
        Debug.Assert(flagHasEmails);
        return storeEmails.Count;
      }

    public TypeEmailsJSON   elementOfEmails(int element_num)
      {
        Debug.Assert(flagHasEmails);
        return storeEmails[element_num];
      }

    public List< TypeEmailsJSON  >  getEmails()
      {
        Debug.Assert(flagHasEmails);
        return storeEmails;
      }



    public void setContactName(string new_value)
      {
        flagHasContactName = true;
        storeContactName = new_value;
      }
    public void unsetContactName()
      {
        flagHasContactName = false;
      }
    public void setContactID(string new_value)
      {
        flagHasContactID = true;
        storeContactID = new_value;
      }
    public void unsetContactID()
      {
        flagHasContactID = false;
      }
    public void initEmails()
      {
        if (flagHasEmails)
          {
            for (int num1 = 0; num1 < storeEmails.Count; ++num1)
              {
              }
          }
        flagHasEmails = true;
        storeEmails.Clear();
      }
    public void appendEmails(TypeEmailsJSON  to_append)
      {
        if (!flagHasEmails)
          {
            flagHasEmails = true;
            storeEmails.Clear();
          }
        Debug.Assert(flagHasEmails);
        storeEmails.Add(to_append);
      }
    public void unsetEmails()
      {
        if (flagHasEmails)
          {
            for (int num2 = 0; num2 < storeEmails.Count; ++num2)
              {
              }
          }
        flagHasEmails = false;
        storeEmails.Clear();
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
        Debug.Assert(partial_allowed || flagHasContactName);
        if (flagHasContactName)
          {
            handler.start_pair("ContactName");
            handler.string_value(storeContactName);
          }
        Debug.Assert(partial_allowed || flagHasContactID);
        if (flagHasContactID)
          {
            handler.start_pair("ContactID");
            handler.string_value(storeContactID);
          }
        Debug.Assert(partial_allowed || flagHasEmails);
        if (flagHasEmails)
          {
            handler.start_pair("Emails");
            handler.start_array();
            for (int num1 = 0; num1 < storeEmails.Count; ++num1)
              {
                if (partial_allowed)
                    storeEmails[num1].write_partial_as_json(handler);
                else
                    storeEmails[num1].write_as_json(handler);
              }
            handler.finish_array();
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
        if (!(hasContactName()))
          {
            return "When parsing the object for %what%, the \"ContactName\" field was missing.";
          }
        if (!(hasContactID()))
          {
            return "When parsing the object for %what%, the \"ContactID\" field was missing.";
          }
        if (!(hasEmails()))
          {
            return "When parsing the object for %what%, the \"Emails\" field was missing.";
          }
        return null;
      }

    public static EmailDisambiguationCandidateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmailDisambiguationCandidateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailDisambiguationCandidate", ignore_extras);
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
    public static EmailDisambiguationCandidateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EmailDisambiguationCandidateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmailDisambiguationCandidateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailDisambiguationCandidate", ignore_extras);
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
    public static EmailDisambiguationCandidateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EmailDisambiguationCandidateJSON from_text(string text, bool ignore_extras)
      {
        EmailDisambiguationCandidateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailDisambiguationCandidate", ignore_extras);
            JSONParse.parse_json_value(text, "Text for EmailDisambiguationCandidateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static EmailDisambiguationCandidateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        EmailDisambiguationCandidateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailDisambiguationCandidate", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorContactName;
        private JSONHoldingStringGenerator fieldGeneratorContactID;
        private TypeEmailsJSON.HoldingArrayGenerator fieldGeneratorEmails;

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
            EmailDisambiguationCandidateJSON result = new EmailDisambiguationCandidateJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(EmailDisambiguationCandidateJSON result)
          {
            if (fieldGeneratorContactName.have_value)
              {
                result.setContactName(fieldGeneratorContactName.value);
                fieldGeneratorContactName.have_value = false;
              }
            else if ((!(result.hasContactName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ContactName\" field was missing.");
              }
            if (fieldGeneratorContactID.have_value)
              {
                result.setContactID(fieldGeneratorContactID.value);
                fieldGeneratorContactID.have_value = false;
              }
            else if ((!(result.hasContactID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ContactID\" field was missing.");
              }
            if (fieldGeneratorEmails.have_value)
              {
                result.initEmails();
                int count = fieldGeneratorEmails.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEmails(fieldGeneratorEmails.value[num]);
                  }
                fieldGeneratorEmails.value.Clear();
                fieldGeneratorEmails.have_value = false;
              }
            else if ((!(result.hasEmails())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Emails\" field was missing.");
              }
          }
        protected abstract void handle_result(EmailDisambiguationCandidateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "ontact", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 8, "D", 0, 1, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorContactID;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 8, "ame", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorContactName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "mails", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorEmails;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorContactName = new JSONHoldingStringGenerator("field \"ContactName\" of the EmailDisambiguationCandidate class");
            fieldGeneratorContactID = new JSONHoldingStringGenerator("field \"ContactID\" of the EmailDisambiguationCandidate class");
            fieldGeneratorEmails = new TypeEmailsJSON.HoldingArrayGenerator("field \"Emails\" of the EmailDisambiguationCandidate class", ignore_extras);
            set_what("the EmailDisambiguationCandidate class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorContactName = new JSONHoldingStringGenerator("field \"ContactName\" of the EmailDisambiguationCandidate class");
            fieldGeneratorContactID = new JSONHoldingStringGenerator("field \"ContactID\" of the EmailDisambiguationCandidate class");
            fieldGeneratorEmails = new TypeEmailsJSON.HoldingArrayGenerator("field \"Emails\" of the EmailDisambiguationCandidate class", false);
            set_what("the EmailDisambiguationCandidate class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorContactName.reset();
            fieldGeneratorContactID.reset();
            fieldGeneratorEmails.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorEmails.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorEmails.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(EmailDisambiguationCandidateJSON  result)
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
        public EmailDisambiguationCandidateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(EmailDisambiguationCandidateJSON  result)
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
    protected virtual void handle_result(List<EmailDisambiguationCandidateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<EmailDisambiguationCandidateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<EmailDisambiguationCandidateJSON>();
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
    public List<EmailDisambiguationCandidateJSON> value;
  };
  };
