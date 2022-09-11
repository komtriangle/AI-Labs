/* file "EmailAddressFieldJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class EmailAddressFieldJSON : JSONBase
  {
    private bool flagHasMissingEmails;
    private List< string > storeMissingEmails;
    private bool flagHasDisambiguateEmails;
    private List< DisambiguateEmailJSON  > storeDisambiguateEmails;
    private bool flagHasValidEmails;
    private List< ValidEmailJSON  > storeValidEmails;


    private void  fromJSONMissingEmails(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MissingEmails of EmailAddressFieldJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_MissingEmails1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field MissingEmails of EmailAddressFieldJSON is not a string.");
            vector_MissingEmails1.Add(json_string.getData());
          }
        initMissingEmails();
        for (int num1 = 0; num1 < vector_MissingEmails1.Count; ++num1)
            appendMissingEmails(vector_MissingEmails1[num1]);
        for (int num1 = 0; num1 < vector_MissingEmails1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDisambiguateEmails(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DisambiguateEmails of EmailAddressFieldJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DisambiguateEmailJSON  > vector_DisambiguateEmails1 = new List< DisambiguateEmailJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DisambiguateEmailJSON convert_classy = DisambiguateEmailJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_DisambiguateEmails1.Add(convert_classy);
          }
        initDisambiguateEmails();
        for (int num2 = 0; num2 < vector_DisambiguateEmails1.Count; ++num2)
            appendDisambiguateEmails(vector_DisambiguateEmails1[num2]);
        for (int num1 = 0; num1 < vector_DisambiguateEmails1.Count; ++num1)
          {
          }
      }


    private void  fromJSONValidEmails(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ValidEmails of EmailAddressFieldJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< ValidEmailJSON  > vector_ValidEmails1 = new List< ValidEmailJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            ValidEmailJSON convert_classy = ValidEmailJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ValidEmails1.Add(convert_classy);
          }
        initValidEmails();
        for (int num3 = 0; num3 < vector_ValidEmails1.Count; ++num3)
            appendValidEmails(vector_ValidEmails1[num3]);
        for (int num1 = 0; num1 < vector_ValidEmails1.Count; ++num1)
          {
          }
      }


    public EmailAddressFieldJSON()
      {
        flagHasMissingEmails = false;
        flagHasDisambiguateEmails = false;
        flagHasValidEmails = false;
        storeMissingEmails = new List< string >();
        storeDisambiguateEmails = new List< DisambiguateEmailJSON  >();
        storeValidEmails = new List< ValidEmailJSON  >();
      }

    public bool  hasMissingEmails()
      {
        return flagHasMissingEmails;
      }

    public int  countOfMissingEmails()
      {
        Debug.Assert(flagHasMissingEmails);
        return storeMissingEmails.Count;
      }

    public string  elementOfMissingEmails(int element_num)
      {
        Debug.Assert(flagHasMissingEmails);
        return storeMissingEmails[element_num];
      }

    public List< string >  getMissingEmails()
      {
        Debug.Assert(flagHasMissingEmails);
        return storeMissingEmails;
      }

    public bool  hasDisambiguateEmails()
      {
        return flagHasDisambiguateEmails;
      }

    public int  countOfDisambiguateEmails()
      {
        Debug.Assert(flagHasDisambiguateEmails);
        return storeDisambiguateEmails.Count;
      }

    public DisambiguateEmailJSON   elementOfDisambiguateEmails(int element_num)
      {
        Debug.Assert(flagHasDisambiguateEmails);
        return storeDisambiguateEmails[element_num];
      }

    public List< DisambiguateEmailJSON  >  getDisambiguateEmails()
      {
        Debug.Assert(flagHasDisambiguateEmails);
        return storeDisambiguateEmails;
      }

    public bool  hasValidEmails()
      {
        return flagHasValidEmails;
      }

    public int  countOfValidEmails()
      {
        Debug.Assert(flagHasValidEmails);
        return storeValidEmails.Count;
      }

    public ValidEmailJSON   elementOfValidEmails(int element_num)
      {
        Debug.Assert(flagHasValidEmails);
        return storeValidEmails[element_num];
      }

    public List< ValidEmailJSON  >  getValidEmails()
      {
        Debug.Assert(flagHasValidEmails);
        return storeValidEmails;
      }



    public void initMissingEmails()
      {
        flagHasMissingEmails = true;
        storeMissingEmails.Clear();
      }
    public void appendMissingEmails(string to_append)
      {
        if (!flagHasMissingEmails)
          {
            flagHasMissingEmails = true;
            storeMissingEmails.Clear();
          }
        Debug.Assert(flagHasMissingEmails);
        storeMissingEmails.Add(to_append);
      }
    public void unsetMissingEmails()
      {
        flagHasMissingEmails = false;
        storeMissingEmails.Clear();
      }
    public void initDisambiguateEmails()
      {
        if (flagHasDisambiguateEmails)
          {
            for (int num1 = 0; num1 < storeDisambiguateEmails.Count; ++num1)
              {
              }
          }
        flagHasDisambiguateEmails = true;
        storeDisambiguateEmails.Clear();
      }
    public void appendDisambiguateEmails(DisambiguateEmailJSON  to_append)
      {
        if (!flagHasDisambiguateEmails)
          {
            flagHasDisambiguateEmails = true;
            storeDisambiguateEmails.Clear();
          }
        Debug.Assert(flagHasDisambiguateEmails);
        storeDisambiguateEmails.Add(to_append);
      }
    public void unsetDisambiguateEmails()
      {
        if (flagHasDisambiguateEmails)
          {
            for (int num2 = 0; num2 < storeDisambiguateEmails.Count; ++num2)
              {
              }
          }
        flagHasDisambiguateEmails = false;
        storeDisambiguateEmails.Clear();
      }
    public void initValidEmails()
      {
        if (flagHasValidEmails)
          {
            for (int num3 = 0; num3 < storeValidEmails.Count; ++num3)
              {
              }
          }
        flagHasValidEmails = true;
        storeValidEmails.Clear();
      }
    public void appendValidEmails(ValidEmailJSON  to_append)
      {
        if (!flagHasValidEmails)
          {
            flagHasValidEmails = true;
            storeValidEmails.Clear();
          }
        Debug.Assert(flagHasValidEmails);
        storeValidEmails.Add(to_append);
      }
    public void unsetValidEmails()
      {
        if (flagHasValidEmails)
          {
            for (int num4 = 0; num4 < storeValidEmails.Count; ++num4)
              {
              }
          }
        flagHasValidEmails = false;
        storeValidEmails.Clear();
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
        if (flagHasMissingEmails)
          {
            handler.start_pair("MissingEmails");
            handler.start_array();
            for (int num1 = 0; num1 < storeMissingEmails.Count; ++num1)
              {
                handler.string_value(storeMissingEmails[num1]);
              }
            handler.finish_array();
          }
        if (flagHasDisambiguateEmails)
          {
            handler.start_pair("DisambiguateEmails");
            handler.start_array();
            for (int num2 = 0; num2 < storeDisambiguateEmails.Count; ++num2)
              {
                if (partial_allowed)
                    storeDisambiguateEmails[num2].write_partial_as_json(handler);
                else
                    storeDisambiguateEmails[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasValidEmails)
          {
            handler.start_pair("ValidEmails");
            handler.start_array();
            for (int num3 = 0; num3 < storeValidEmails.Count; ++num3)
              {
                if (partial_allowed)
                    storeValidEmails[num3].write_partial_as_json(handler);
                else
                    storeValidEmails[num3].write_as_json(handler);
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
        return null;
      }

    public static EmailAddressFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmailAddressFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailAddressField", ignore_extras);
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
    public static EmailAddressFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EmailAddressFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmailAddressFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailAddressField", ignore_extras);
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
    public static EmailAddressFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EmailAddressFieldJSON from_text(string text, bool ignore_extras)
      {
        EmailAddressFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailAddressField", ignore_extras);
            JSONParse.parse_json_value(text, "Text for EmailAddressFieldJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static EmailAddressFieldJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        EmailAddressFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailAddressField", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringArrayGenerator fieldGeneratorMissingEmails;
        private DisambiguateEmailJSON.HoldingArrayGenerator fieldGeneratorDisambiguateEmails;
        private ValidEmailJSON.HoldingArrayGenerator fieldGeneratorValidEmails;

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
            EmailAddressFieldJSON result = new EmailAddressFieldJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(EmailAddressFieldJSON result)
          {
            if (fieldGeneratorMissingEmails.have_value)
              {
                result.initMissingEmails();
                int count = fieldGeneratorMissingEmails.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMissingEmails(fieldGeneratorMissingEmails.value[num]);
                  }
                fieldGeneratorMissingEmails.value.Clear();
                fieldGeneratorMissingEmails.have_value = false;
              }
            if (fieldGeneratorDisambiguateEmails.have_value)
              {
                result.initDisambiguateEmails();
                int count = fieldGeneratorDisambiguateEmails.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDisambiguateEmails(fieldGeneratorDisambiguateEmails.value[num]);
                  }
                fieldGeneratorDisambiguateEmails.value.Clear();
                fieldGeneratorDisambiguateEmails.have_value = false;
              }
            if (fieldGeneratorValidEmails.have_value)
              {
                result.initValidEmails();
                int count = fieldGeneratorValidEmails.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendValidEmails(fieldGeneratorValidEmails.value[num]);
                  }
                fieldGeneratorValidEmails.value.Clear();
                fieldGeneratorValidEmails.have_value = false;
              }
          }
        protected abstract void handle_result(EmailAddressFieldJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "isambiguateEmails", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorDisambiguateEmails;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "issingEmails", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorMissingEmails;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "alidEmails", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorValidEmails;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorMissingEmails = new JSONHoldingStringArrayGenerator("field \"MissingEmails\" of the EmailAddressField class");
            fieldGeneratorDisambiguateEmails = new DisambiguateEmailJSON.HoldingArrayGenerator("field \"DisambiguateEmails\" of the EmailAddressField class", ignore_extras);
            fieldGeneratorValidEmails = new ValidEmailJSON.HoldingArrayGenerator("field \"ValidEmails\" of the EmailAddressField class", ignore_extras);
            set_what("the EmailAddressField class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorMissingEmails = new JSONHoldingStringArrayGenerator("field \"MissingEmails\" of the EmailAddressField class");
            fieldGeneratorDisambiguateEmails = new DisambiguateEmailJSON.HoldingArrayGenerator("field \"DisambiguateEmails\" of the EmailAddressField class", false);
            fieldGeneratorValidEmails = new ValidEmailJSON.HoldingArrayGenerator("field \"ValidEmails\" of the EmailAddressField class", false);
            set_what("the EmailAddressField class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorMissingEmails.reset();
            fieldGeneratorDisambiguateEmails.reset();
            fieldGeneratorValidEmails.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDisambiguateEmails.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorValidEmails.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDisambiguateEmails.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorValidEmails.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(EmailAddressFieldJSON  result)
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
        public EmailAddressFieldJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(EmailAddressFieldJSON  result)
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
    protected virtual void handle_result(List<EmailAddressFieldJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<EmailAddressFieldJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<EmailAddressFieldJSON>();
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
    public List<EmailAddressFieldJSON> value;
  };
  };
