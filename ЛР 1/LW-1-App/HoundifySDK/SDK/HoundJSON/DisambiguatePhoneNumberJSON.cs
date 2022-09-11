/* file "DisambiguatePhoneNumberJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DisambiguatePhoneNumberJSON : JSONBase
  {
    private bool flagHasContactQueryName;
    private string storeContactQueryName;
    private bool flagHasDisambiguationCandidates;
    private List< PhoneNumberDisambiguationCandidateJSON  > storeDisambiguationCandidates;


    private void  fromJSONContactQueryName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ContactQueryName of DisambiguatePhoneNumberJSON is not a string.");
        setContactQueryName(json_string.getData());
      }


    private void  fromJSONDisambiguationCandidates(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DisambiguationCandidates of DisambiguatePhoneNumberJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< PhoneNumberDisambiguationCandidateJSON  > vector_DisambiguationCandidates1 = new List< PhoneNumberDisambiguationCandidateJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            PhoneNumberDisambiguationCandidateJSON convert_classy = PhoneNumberDisambiguationCandidateJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_DisambiguationCandidates1.Add(convert_classy);
          }
        initDisambiguationCandidates();
        for (int num1 = 0; num1 < vector_DisambiguationCandidates1.Count; ++num1)
            appendDisambiguationCandidates(vector_DisambiguationCandidates1[num1]);
        for (int num1 = 0; num1 < vector_DisambiguationCandidates1.Count; ++num1)
          {
          }
      }


    public DisambiguatePhoneNumberJSON()
      {
        flagHasContactQueryName = false;
        flagHasDisambiguationCandidates = false;
        storeDisambiguationCandidates = new List< PhoneNumberDisambiguationCandidateJSON  >();
      }

    public bool  hasContactQueryName()
      {
        return flagHasContactQueryName;
      }

    public string  getContactQueryName()
      {
        Debug.Assert(flagHasContactQueryName);
        return storeContactQueryName;
      }

    public bool  hasDisambiguationCandidates()
      {
        return flagHasDisambiguationCandidates;
      }

    public int  countOfDisambiguationCandidates()
      {
        Debug.Assert(flagHasDisambiguationCandidates);
        return storeDisambiguationCandidates.Count;
      }

    public PhoneNumberDisambiguationCandidateJSON   elementOfDisambiguationCandidates(int element_num)
      {
        Debug.Assert(flagHasDisambiguationCandidates);
        return storeDisambiguationCandidates[element_num];
      }

    public List< PhoneNumberDisambiguationCandidateJSON  >  getDisambiguationCandidates()
      {
        Debug.Assert(flagHasDisambiguationCandidates);
        return storeDisambiguationCandidates;
      }



    public void setContactQueryName(string new_value)
      {
        flagHasContactQueryName = true;
        storeContactQueryName = new_value;
      }
    public void unsetContactQueryName()
      {
        flagHasContactQueryName = false;
      }
    public void initDisambiguationCandidates()
      {
        if (flagHasDisambiguationCandidates)
          {
            for (int num1 = 0; num1 < storeDisambiguationCandidates.Count; ++num1)
              {
              }
          }
        flagHasDisambiguationCandidates = true;
        storeDisambiguationCandidates.Clear();
      }
    public void appendDisambiguationCandidates(PhoneNumberDisambiguationCandidateJSON  to_append)
      {
        if (!flagHasDisambiguationCandidates)
          {
            flagHasDisambiguationCandidates = true;
            storeDisambiguationCandidates.Clear();
          }
        Debug.Assert(flagHasDisambiguationCandidates);
        storeDisambiguationCandidates.Add(to_append);
      }
    public void unsetDisambiguationCandidates()
      {
        if (flagHasDisambiguationCandidates)
          {
            for (int num2 = 0; num2 < storeDisambiguationCandidates.Count; ++num2)
              {
              }
          }
        flagHasDisambiguationCandidates = false;
        storeDisambiguationCandidates.Clear();
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
        if (flagHasContactQueryName)
          {
            handler.start_pair("ContactQueryName");
            handler.string_value(storeContactQueryName);
          }
        Debug.Assert(partial_allowed || flagHasDisambiguationCandidates);
        if (flagHasDisambiguationCandidates)
          {
            handler.start_pair("DisambiguationCandidates");
            handler.start_array();
            for (int num1 = 0; num1 < storeDisambiguationCandidates.Count; ++num1)
              {
                if (partial_allowed)
                    storeDisambiguationCandidates[num1].write_partial_as_json(handler);
                else
                    storeDisambiguationCandidates[num1].write_as_json(handler);
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
        if (!(hasDisambiguationCandidates()))
          {
            return "When parsing the object for %what%, the \"DisambiguationCandidates\" field was missing.";
          }
        return null;
      }

    public static DisambiguatePhoneNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisambiguatePhoneNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguatePhoneNumber", ignore_extras);
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
    public static DisambiguatePhoneNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DisambiguatePhoneNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisambiguatePhoneNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguatePhoneNumber", ignore_extras);
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
    public static DisambiguatePhoneNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DisambiguatePhoneNumberJSON from_text(string text, bool ignore_extras)
      {
        DisambiguatePhoneNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguatePhoneNumber", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DisambiguatePhoneNumberJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DisambiguatePhoneNumberJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DisambiguatePhoneNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguatePhoneNumber", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorContactQueryName;
        private PhoneNumberDisambiguationCandidateJSON.HoldingArrayGenerator fieldGeneratorDisambiguationCandidates;

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
            DisambiguatePhoneNumberJSON result = new DisambiguatePhoneNumberJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(DisambiguatePhoneNumberJSON result)
          {
            if (fieldGeneratorContactQueryName.have_value)
              {
                result.setContactQueryName(fieldGeneratorContactQueryName.value);
                fieldGeneratorContactQueryName.have_value = false;
              }
            if (fieldGeneratorDisambiguationCandidates.have_value)
              {
                result.initDisambiguationCandidates();
                int count = fieldGeneratorDisambiguationCandidates.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDisambiguationCandidates(fieldGeneratorDisambiguationCandidates.value[num]);
                  }
                fieldGeneratorDisambiguationCandidates.value.Clear();
                fieldGeneratorDisambiguationCandidates.have_value = false;
              }
            else if ((!(result.hasDisambiguationCandidates())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DisambiguationCandidates\" field was missing.");
              }
          }
        protected abstract void handle_result(DisambiguatePhoneNumberJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ontactQueryName", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorContactQueryName;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "isambiguationCandidates", 0, 23, false) == 0) && (field_name.Length == 24))
                        return fieldGeneratorDisambiguationCandidates;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorContactQueryName = new JSONHoldingStringGenerator("field \"ContactQueryName\" of the DisambiguatePhoneNumber class");
            fieldGeneratorDisambiguationCandidates = new PhoneNumberDisambiguationCandidateJSON.HoldingArrayGenerator("field \"DisambiguationCandidates\" of the DisambiguatePhoneNumber class", ignore_extras);
            set_what("the DisambiguatePhoneNumber class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorContactQueryName = new JSONHoldingStringGenerator("field \"ContactQueryName\" of the DisambiguatePhoneNumber class");
            fieldGeneratorDisambiguationCandidates = new PhoneNumberDisambiguationCandidateJSON.HoldingArrayGenerator("field \"DisambiguationCandidates\" of the DisambiguatePhoneNumber class", false);
            set_what("the DisambiguatePhoneNumber class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorContactQueryName.reset();
            fieldGeneratorDisambiguationCandidates.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDisambiguationCandidates.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDisambiguationCandidates.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DisambiguatePhoneNumberJSON  result)
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
        public DisambiguatePhoneNumberJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DisambiguatePhoneNumberJSON  result)
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
    protected virtual void handle_result(List<DisambiguatePhoneNumberJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DisambiguatePhoneNumberJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DisambiguatePhoneNumberJSON>();
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
    public List<DisambiguatePhoneNumberJSON> value;
  };
  };
