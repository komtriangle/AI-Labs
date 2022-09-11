/* file "ContactAndNumberJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ContactAndNumberJSON : JSONBase
  {
    private bool flagHasContact;
    private OneContactJSON  storeContact;
    private bool flagHasNumber;
    private string storeNumber;


    private void  fromJSONContact(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OneContactJSON convert_classy = OneContactJSON.from_json(json_value, ignore_extras, true);
        setContact(convert_classy);
      }


    private void  fromJSONNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Number of ContactAndNumberJSON is not a string.");
        setNumber(json_string.getData());
      }


    public ContactAndNumberJSON()
      {
        flagHasContact = false;
        flagHasNumber = false;
      }

    public bool  hasContact()
      {
        return flagHasContact;
      }

    public OneContactJSON   getContact()
      {
        Debug.Assert(flagHasContact);
        return storeContact;
      }

    public bool  hasNumber()
      {
        return flagHasNumber;
      }

    public string  getNumber()
      {
        Debug.Assert(flagHasNumber);
        return storeNumber;
      }



    public void setContact(OneContactJSON  new_value)
      {
        if (flagHasContact)
          {
          }
        flagHasContact = true;
        storeContact = new_value;
      }
    public void unsetContact()
      {
        if (flagHasContact)
          {
          }
        flagHasContact = false;
      }
    public void setNumber(string new_value)
      {
        flagHasNumber = true;
        storeNumber = new_value;
      }
    public void unsetNumber()
      {
        flagHasNumber = false;
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
        Debug.Assert(partial_allowed || flagHasContact);
        if (flagHasContact)
          {
            handler.start_pair("Contact");
            if (partial_allowed)
                storeContact.write_partial_as_json(handler);
            else
                storeContact.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasNumber);
        if (flagHasNumber)
          {
            handler.start_pair("Number");
            handler.string_value(storeNumber);
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
        if (!(hasContact()))
          {
            return "When parsing the object for %what%, the \"Contact\" field was missing.";
          }
        if (!(hasNumber()))
          {
            return "When parsing the object for %what%, the \"Number\" field was missing.";
          }
        return null;
      }

    public static ContactAndNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactAndNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactAndNumber", ignore_extras);
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
    public static ContactAndNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ContactAndNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactAndNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactAndNumber", ignore_extras);
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
    public static ContactAndNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ContactAndNumberJSON from_text(string text, bool ignore_extras)
      {
        ContactAndNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactAndNumber", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ContactAndNumberJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ContactAndNumberJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ContactAndNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactAndNumber", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private OneContactJSON.HoldingGenerator fieldGeneratorContact;
        private JSONHoldingStringGenerator fieldGeneratorNumber;

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
            ContactAndNumberJSON result = new ContactAndNumberJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(ContactAndNumberJSON result)
          {
            if (fieldGeneratorContact.have_value)
              {
                result.setContact(fieldGeneratorContact.value);
                fieldGeneratorContact.have_value = false;
              }
            else if ((!(result.hasContact())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Contact\" field was missing.");
              }
            if (fieldGeneratorNumber.have_value)
              {
                result.setNumber(fieldGeneratorNumber.value);
                fieldGeneratorNumber.have_value = false;
              }
            else if ((!(result.hasNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Number\" field was missing.");
              }
          }
        protected abstract void handle_result(ContactAndNumberJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ontact", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorContact;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umber", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorNumber;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorContact = new OneContactJSON.HoldingGenerator("field \"Contact\" of the ContactAndNumber class", ignore_extras);
            fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the ContactAndNumber class");
            set_what("the ContactAndNumber class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorContact = new OneContactJSON.HoldingGenerator("field \"Contact\" of the ContactAndNumber class", false);
            fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the ContactAndNumber class");
            set_what("the ContactAndNumber class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorContact.reset();
            fieldGeneratorNumber.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorContact.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorContact.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ContactAndNumberJSON  result)
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
        public ContactAndNumberJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ContactAndNumberJSON  result)
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
    protected virtual void handle_result(List<ContactAndNumberJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ContactAndNumberJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ContactAndNumberJSON>();
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
    public List<ContactAndNumberJSON> value;
  };
  };
