/* file "SMSAddressFieldJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SMSAddressFieldJSON : JSONBase
  {
    private bool flagHasMissingPhoneNumbers;
    private List< string > storeMissingPhoneNumbers;
    private bool flagHasDisambiguatePhoneNumbers;
    private List< DisambiguatePhoneNumberJSON  > storeDisambiguatePhoneNumbers;
    private bool flagHasValidPhoneNumbers;
    private List< ValidPhoneNumberJSON  > storeValidPhoneNumbers;


    private void  fromJSONMissingPhoneNumbers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MissingPhoneNumbers of SMSAddressFieldJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_MissingPhoneNumbers1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field MissingPhoneNumbers of SMSAddressFieldJSON is not a string.");
            vector_MissingPhoneNumbers1.Add(json_string.getData());
          }
        initMissingPhoneNumbers();
        for (int num1 = 0; num1 < vector_MissingPhoneNumbers1.Count; ++num1)
            appendMissingPhoneNumbers(vector_MissingPhoneNumbers1[num1]);
        for (int num1 = 0; num1 < vector_MissingPhoneNumbers1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDisambiguatePhoneNumbers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DisambiguatePhoneNumbers of SMSAddressFieldJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DisambiguatePhoneNumberJSON  > vector_DisambiguatePhoneNumbers1 = new List< DisambiguatePhoneNumberJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DisambiguatePhoneNumberJSON convert_classy = DisambiguatePhoneNumberJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_DisambiguatePhoneNumbers1.Add(convert_classy);
          }
        initDisambiguatePhoneNumbers();
        for (int num2 = 0; num2 < vector_DisambiguatePhoneNumbers1.Count; ++num2)
            appendDisambiguatePhoneNumbers(vector_DisambiguatePhoneNumbers1[num2]);
        for (int num1 = 0; num1 < vector_DisambiguatePhoneNumbers1.Count; ++num1)
          {
          }
      }


    private void  fromJSONValidPhoneNumbers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ValidPhoneNumbers of SMSAddressFieldJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< ValidPhoneNumberJSON  > vector_ValidPhoneNumbers1 = new List< ValidPhoneNumberJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            ValidPhoneNumberJSON convert_classy = ValidPhoneNumberJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ValidPhoneNumbers1.Add(convert_classy);
          }
        initValidPhoneNumbers();
        for (int num3 = 0; num3 < vector_ValidPhoneNumbers1.Count; ++num3)
            appendValidPhoneNumbers(vector_ValidPhoneNumbers1[num3]);
        for (int num1 = 0; num1 < vector_ValidPhoneNumbers1.Count; ++num1)
          {
          }
      }


    public SMSAddressFieldJSON()
      {
        flagHasMissingPhoneNumbers = false;
        flagHasDisambiguatePhoneNumbers = false;
        flagHasValidPhoneNumbers = false;
        storeMissingPhoneNumbers = new List< string >();
        storeDisambiguatePhoneNumbers = new List< DisambiguatePhoneNumberJSON  >();
        storeValidPhoneNumbers = new List< ValidPhoneNumberJSON  >();
      }

    public bool  hasMissingPhoneNumbers()
      {
        return flagHasMissingPhoneNumbers;
      }

    public int  countOfMissingPhoneNumbers()
      {
        Debug.Assert(flagHasMissingPhoneNumbers);
        return storeMissingPhoneNumbers.Count;
      }

    public string  elementOfMissingPhoneNumbers(int element_num)
      {
        Debug.Assert(flagHasMissingPhoneNumbers);
        return storeMissingPhoneNumbers[element_num];
      }

    public List< string >  getMissingPhoneNumbers()
      {
        Debug.Assert(flagHasMissingPhoneNumbers);
        return storeMissingPhoneNumbers;
      }

    public bool  hasDisambiguatePhoneNumbers()
      {
        return flagHasDisambiguatePhoneNumbers;
      }

    public int  countOfDisambiguatePhoneNumbers()
      {
        Debug.Assert(flagHasDisambiguatePhoneNumbers);
        return storeDisambiguatePhoneNumbers.Count;
      }

    public DisambiguatePhoneNumberJSON   elementOfDisambiguatePhoneNumbers(int element_num)
      {
        Debug.Assert(flagHasDisambiguatePhoneNumbers);
        return storeDisambiguatePhoneNumbers[element_num];
      }

    public List< DisambiguatePhoneNumberJSON  >  getDisambiguatePhoneNumbers()
      {
        Debug.Assert(flagHasDisambiguatePhoneNumbers);
        return storeDisambiguatePhoneNumbers;
      }

    public bool  hasValidPhoneNumbers()
      {
        return flagHasValidPhoneNumbers;
      }

    public int  countOfValidPhoneNumbers()
      {
        Debug.Assert(flagHasValidPhoneNumbers);
        return storeValidPhoneNumbers.Count;
      }

    public ValidPhoneNumberJSON   elementOfValidPhoneNumbers(int element_num)
      {
        Debug.Assert(flagHasValidPhoneNumbers);
        return storeValidPhoneNumbers[element_num];
      }

    public List< ValidPhoneNumberJSON  >  getValidPhoneNumbers()
      {
        Debug.Assert(flagHasValidPhoneNumbers);
        return storeValidPhoneNumbers;
      }



    public void initMissingPhoneNumbers()
      {
        flagHasMissingPhoneNumbers = true;
        storeMissingPhoneNumbers.Clear();
      }
    public void appendMissingPhoneNumbers(string to_append)
      {
        if (!flagHasMissingPhoneNumbers)
          {
            flagHasMissingPhoneNumbers = true;
            storeMissingPhoneNumbers.Clear();
          }
        Debug.Assert(flagHasMissingPhoneNumbers);
        storeMissingPhoneNumbers.Add(to_append);
      }
    public void unsetMissingPhoneNumbers()
      {
        flagHasMissingPhoneNumbers = false;
        storeMissingPhoneNumbers.Clear();
      }
    public void initDisambiguatePhoneNumbers()
      {
        if (flagHasDisambiguatePhoneNumbers)
          {
            for (int num1 = 0; num1 < storeDisambiguatePhoneNumbers.Count; ++num1)
              {
              }
          }
        flagHasDisambiguatePhoneNumbers = true;
        storeDisambiguatePhoneNumbers.Clear();
      }
    public void appendDisambiguatePhoneNumbers(DisambiguatePhoneNumberJSON  to_append)
      {
        if (!flagHasDisambiguatePhoneNumbers)
          {
            flagHasDisambiguatePhoneNumbers = true;
            storeDisambiguatePhoneNumbers.Clear();
          }
        Debug.Assert(flagHasDisambiguatePhoneNumbers);
        storeDisambiguatePhoneNumbers.Add(to_append);
      }
    public void unsetDisambiguatePhoneNumbers()
      {
        if (flagHasDisambiguatePhoneNumbers)
          {
            for (int num2 = 0; num2 < storeDisambiguatePhoneNumbers.Count; ++num2)
              {
              }
          }
        flagHasDisambiguatePhoneNumbers = false;
        storeDisambiguatePhoneNumbers.Clear();
      }
    public void initValidPhoneNumbers()
      {
        if (flagHasValidPhoneNumbers)
          {
            for (int num3 = 0; num3 < storeValidPhoneNumbers.Count; ++num3)
              {
              }
          }
        flagHasValidPhoneNumbers = true;
        storeValidPhoneNumbers.Clear();
      }
    public void appendValidPhoneNumbers(ValidPhoneNumberJSON  to_append)
      {
        if (!flagHasValidPhoneNumbers)
          {
            flagHasValidPhoneNumbers = true;
            storeValidPhoneNumbers.Clear();
          }
        Debug.Assert(flagHasValidPhoneNumbers);
        storeValidPhoneNumbers.Add(to_append);
      }
    public void unsetValidPhoneNumbers()
      {
        if (flagHasValidPhoneNumbers)
          {
            for (int num4 = 0; num4 < storeValidPhoneNumbers.Count; ++num4)
              {
              }
          }
        flagHasValidPhoneNumbers = false;
        storeValidPhoneNumbers.Clear();
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
        if (flagHasMissingPhoneNumbers)
          {
            handler.start_pair("MissingPhoneNumbers");
            handler.start_array();
            for (int num1 = 0; num1 < storeMissingPhoneNumbers.Count; ++num1)
              {
                handler.string_value(storeMissingPhoneNumbers[num1]);
              }
            handler.finish_array();
          }
        if (flagHasDisambiguatePhoneNumbers)
          {
            handler.start_pair("DisambiguatePhoneNumbers");
            handler.start_array();
            for (int num2 = 0; num2 < storeDisambiguatePhoneNumbers.Count; ++num2)
              {
                if (partial_allowed)
                    storeDisambiguatePhoneNumbers[num2].write_partial_as_json(handler);
                else
                    storeDisambiguatePhoneNumbers[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasValidPhoneNumbers)
          {
            handler.start_pair("ValidPhoneNumbers");
            handler.start_array();
            for (int num3 = 0; num3 < storeValidPhoneNumbers.Count; ++num3)
              {
                if (partial_allowed)
                    storeValidPhoneNumbers[num3].write_partial_as_json(handler);
                else
                    storeValidPhoneNumbers[num3].write_as_json(handler);
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

    public static SMSAddressFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSAddressFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSAddressField", ignore_extras);
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
    public static SMSAddressFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSAddressFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSAddressFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSAddressField", ignore_extras);
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
    public static SMSAddressFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSAddressFieldJSON from_text(string text, bool ignore_extras)
      {
        SMSAddressFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSAddressField", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SMSAddressFieldJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SMSAddressFieldJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SMSAddressFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSAddressField", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringArrayGenerator fieldGeneratorMissingPhoneNumbers;
        private DisambiguatePhoneNumberJSON.HoldingArrayGenerator fieldGeneratorDisambiguatePhoneNumbers;
        private ValidPhoneNumberJSON.HoldingArrayGenerator fieldGeneratorValidPhoneNumbers;

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
            SMSAddressFieldJSON result = new SMSAddressFieldJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(SMSAddressFieldJSON result)
          {
            if (fieldGeneratorMissingPhoneNumbers.have_value)
              {
                result.initMissingPhoneNumbers();
                int count = fieldGeneratorMissingPhoneNumbers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMissingPhoneNumbers(fieldGeneratorMissingPhoneNumbers.value[num]);
                  }
                fieldGeneratorMissingPhoneNumbers.value.Clear();
                fieldGeneratorMissingPhoneNumbers.have_value = false;
              }
            if (fieldGeneratorDisambiguatePhoneNumbers.have_value)
              {
                result.initDisambiguatePhoneNumbers();
                int count = fieldGeneratorDisambiguatePhoneNumbers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDisambiguatePhoneNumbers(fieldGeneratorDisambiguatePhoneNumbers.value[num]);
                  }
                fieldGeneratorDisambiguatePhoneNumbers.value.Clear();
                fieldGeneratorDisambiguatePhoneNumbers.have_value = false;
              }
            if (fieldGeneratorValidPhoneNumbers.have_value)
              {
                result.initValidPhoneNumbers();
                int count = fieldGeneratorValidPhoneNumbers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendValidPhoneNumbers(fieldGeneratorValidPhoneNumbers.value[num]);
                  }
                fieldGeneratorValidPhoneNumbers.value.Clear();
                fieldGeneratorValidPhoneNumbers.have_value = false;
              }
          }
        protected abstract void handle_result(SMSAddressFieldJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "isambiguatePhoneNumbers", 0, 23, false) == 0) && (field_name.Length == 24))
                        return fieldGeneratorDisambiguatePhoneNumbers;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "issingPhoneNumbers", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorMissingPhoneNumbers;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "alidPhoneNumbers", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorValidPhoneNumbers;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorMissingPhoneNumbers = new JSONHoldingStringArrayGenerator("field \"MissingPhoneNumbers\" of the SMSAddressField class");
            fieldGeneratorDisambiguatePhoneNumbers = new DisambiguatePhoneNumberJSON.HoldingArrayGenerator("field \"DisambiguatePhoneNumbers\" of the SMSAddressField class", ignore_extras);
            fieldGeneratorValidPhoneNumbers = new ValidPhoneNumberJSON.HoldingArrayGenerator("field \"ValidPhoneNumbers\" of the SMSAddressField class", ignore_extras);
            set_what("the SMSAddressField class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorMissingPhoneNumbers = new JSONHoldingStringArrayGenerator("field \"MissingPhoneNumbers\" of the SMSAddressField class");
            fieldGeneratorDisambiguatePhoneNumbers = new DisambiguatePhoneNumberJSON.HoldingArrayGenerator("field \"DisambiguatePhoneNumbers\" of the SMSAddressField class", false);
            fieldGeneratorValidPhoneNumbers = new ValidPhoneNumberJSON.HoldingArrayGenerator("field \"ValidPhoneNumbers\" of the SMSAddressField class", false);
            set_what("the SMSAddressField class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorMissingPhoneNumbers.reset();
            fieldGeneratorDisambiguatePhoneNumbers.reset();
            fieldGeneratorValidPhoneNumbers.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDisambiguatePhoneNumbers.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorValidPhoneNumbers.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDisambiguatePhoneNumbers.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorValidPhoneNumbers.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SMSAddressFieldJSON  result)
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
        public SMSAddressFieldJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SMSAddressFieldJSON  result)
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
    protected virtual void handle_result(List<SMSAddressFieldJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SMSAddressFieldJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SMSAddressFieldJSON>();
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
    public List<SMSAddressFieldJSON> value;
  };
  };
