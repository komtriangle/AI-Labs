/* file "PhoneNumberDisambiguationCandidateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PhoneNumberDisambiguationCandidateJSON : JSONBase
  {
    public class TypePhoneNumbersJSON : JSONBase
      {
        private bool flagHasLabel;
        private string storeLabel;
        private bool flagHasNumber;
        private string storeNumber;


        private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Label of TypePhoneNumbersJSON is not a string.");
            setLabel(json_string.getData());
          }


        private void  fromJSONNumber(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Number of TypePhoneNumbersJSON is not a string.");
            setNumber(json_string.getData());
          }


        public TypePhoneNumbersJSON()
          {
            flagHasLabel = false;
            flagHasNumber = false;
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

        public bool  hasNumber()
          {
            return flagHasNumber;
          }

        public string  getNumber()
          {
            Debug.Assert(flagHasNumber);
            return storeNumber;
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
            Debug.Assert(partial_allowed || flagHasLabel);
            if (flagHasLabel)
              {
                handler.start_pair("Label");
                handler.string_value(storeLabel);
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
            if (!(hasLabel()))
              {
                return "When parsing the object for %what%, the \"Label\" field was missing.";
              }
            if (!(hasNumber()))
              {
                return "When parsing the object for %what%, the \"Number\" field was missing.";
              }
            return null;
          }

        public static TypePhoneNumbersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePhoneNumbersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhoneNumbers", ignore_extras);
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
        public static TypePhoneNumbersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePhoneNumbersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePhoneNumbersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhoneNumbers", ignore_extras);
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
        public static TypePhoneNumbersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePhoneNumbersJSON from_text(string text, bool ignore_extras)
          {
            TypePhoneNumbersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhoneNumbers", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePhoneNumbersJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePhoneNumbersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePhoneNumbersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhoneNumbers", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorLabel;
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
                TypePhoneNumbersJSON result = new TypePhoneNumbersJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypePhoneNumbersJSON result)
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
            protected abstract void handle_result(TypePhoneNumbersJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorLabel;
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
                fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the TypePhoneNumbers class");
                fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the TypePhoneNumbers class");
                set_what("the TypePhoneNumbers class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the TypePhoneNumbers class");
                fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the TypePhoneNumbers class");
                set_what("the TypePhoneNumbers class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorLabel.reset();
                fieldGeneratorNumber.reset();
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
            protected override void handle_result(TypePhoneNumbersJSON  result)
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
            public TypePhoneNumbersJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePhoneNumbersJSON  result)
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
        protected virtual void handle_result(List<TypePhoneNumbersJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePhoneNumbersJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePhoneNumbersJSON>();
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
        public List<TypePhoneNumbersJSON> value;
      };
      };
    private bool flagHasContactName;
    private string storeContactName;
    private bool flagHasContactID;
    private string storeContactID;
    private bool flagHasPhoneNumbers;
    private List< TypePhoneNumbersJSON  > storePhoneNumbers;


    private void  fromJSONContactName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ContactName of PhoneNumberDisambiguationCandidateJSON is not a string.");
        setContactName(json_string.getData());
      }


    private void  fromJSONContactID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ContactID of PhoneNumberDisambiguationCandidateJSON is not a string.");
        setContactID(json_string.getData());
      }


    private void  fromJSONPhoneNumbers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PhoneNumbers of PhoneNumberDisambiguationCandidateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypePhoneNumbersJSON  > vector_PhoneNumbers1 = new List< TypePhoneNumbersJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypePhoneNumbersJSON convert_classy = TypePhoneNumbersJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_PhoneNumbers1.Add(convert_classy);
          }
        initPhoneNumbers();
        for (int num1 = 0; num1 < vector_PhoneNumbers1.Count; ++num1)
            appendPhoneNumbers(vector_PhoneNumbers1[num1]);
        for (int num1 = 0; num1 < vector_PhoneNumbers1.Count; ++num1)
          {
          }
      }


    public PhoneNumberDisambiguationCandidateJSON()
      {
        flagHasContactName = false;
        flagHasContactID = false;
        flagHasPhoneNumbers = false;
        storePhoneNumbers = new List< TypePhoneNumbersJSON  >();
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

    public bool  hasPhoneNumbers()
      {
        return flagHasPhoneNumbers;
      }

    public int  countOfPhoneNumbers()
      {
        Debug.Assert(flagHasPhoneNumbers);
        return storePhoneNumbers.Count;
      }

    public TypePhoneNumbersJSON   elementOfPhoneNumbers(int element_num)
      {
        Debug.Assert(flagHasPhoneNumbers);
        return storePhoneNumbers[element_num];
      }

    public List< TypePhoneNumbersJSON  >  getPhoneNumbers()
      {
        Debug.Assert(flagHasPhoneNumbers);
        return storePhoneNumbers;
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
    public void initPhoneNumbers()
      {
        if (flagHasPhoneNumbers)
          {
            for (int num1 = 0; num1 < storePhoneNumbers.Count; ++num1)
              {
              }
          }
        flagHasPhoneNumbers = true;
        storePhoneNumbers.Clear();
      }
    public void appendPhoneNumbers(TypePhoneNumbersJSON  to_append)
      {
        if (!flagHasPhoneNumbers)
          {
            flagHasPhoneNumbers = true;
            storePhoneNumbers.Clear();
          }
        Debug.Assert(flagHasPhoneNumbers);
        storePhoneNumbers.Add(to_append);
      }
    public void unsetPhoneNumbers()
      {
        if (flagHasPhoneNumbers)
          {
            for (int num2 = 0; num2 < storePhoneNumbers.Count; ++num2)
              {
              }
          }
        flagHasPhoneNumbers = false;
        storePhoneNumbers.Clear();
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
        Debug.Assert(partial_allowed || flagHasPhoneNumbers);
        if (flagHasPhoneNumbers)
          {
            handler.start_pair("PhoneNumbers");
            handler.start_array();
            for (int num1 = 0; num1 < storePhoneNumbers.Count; ++num1)
              {
                if (partial_allowed)
                    storePhoneNumbers[num1].write_partial_as_json(handler);
                else
                    storePhoneNumbers[num1].write_as_json(handler);
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
        if (!(hasPhoneNumbers()))
          {
            return "When parsing the object for %what%, the \"PhoneNumbers\" field was missing.";
          }
        return null;
      }

    public static PhoneNumberDisambiguationCandidateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PhoneNumberDisambiguationCandidateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PhoneNumberDisambiguationCandidate", ignore_extras);
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
    public static PhoneNumberDisambiguationCandidateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PhoneNumberDisambiguationCandidateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PhoneNumberDisambiguationCandidateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PhoneNumberDisambiguationCandidate", ignore_extras);
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
    public static PhoneNumberDisambiguationCandidateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PhoneNumberDisambiguationCandidateJSON from_text(string text, bool ignore_extras)
      {
        PhoneNumberDisambiguationCandidateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PhoneNumberDisambiguationCandidate", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PhoneNumberDisambiguationCandidateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static PhoneNumberDisambiguationCandidateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PhoneNumberDisambiguationCandidateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PhoneNumberDisambiguationCandidate", ignore_extras);
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
        private TypePhoneNumbersJSON.HoldingArrayGenerator fieldGeneratorPhoneNumbers;

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
            PhoneNumberDisambiguationCandidateJSON result = new PhoneNumberDisambiguationCandidateJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(PhoneNumberDisambiguationCandidateJSON result)
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
            if (fieldGeneratorPhoneNumbers.have_value)
              {
                result.initPhoneNumbers();
                int count = fieldGeneratorPhoneNumbers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPhoneNumbers(fieldGeneratorPhoneNumbers.value[num]);
                  }
                fieldGeneratorPhoneNumbers.value.Clear();
                fieldGeneratorPhoneNumbers.have_value = false;
              }
            else if ((!(result.hasPhoneNumbers())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PhoneNumbers\" field was missing.");
              }
          }
        protected abstract void handle_result(PhoneNumberDisambiguationCandidateJSON new_result);
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
                case 'P':
                    if ((String.Compare(field_name, 1, "honeNumbers", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorPhoneNumbers;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorContactName = new JSONHoldingStringGenerator("field \"ContactName\" of the PhoneNumberDisambiguationCandidate class");
            fieldGeneratorContactID = new JSONHoldingStringGenerator("field \"ContactID\" of the PhoneNumberDisambiguationCandidate class");
            fieldGeneratorPhoneNumbers = new TypePhoneNumbersJSON.HoldingArrayGenerator("field \"PhoneNumbers\" of the PhoneNumberDisambiguationCandidate class", ignore_extras);
            set_what("the PhoneNumberDisambiguationCandidate class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorContactName = new JSONHoldingStringGenerator("field \"ContactName\" of the PhoneNumberDisambiguationCandidate class");
            fieldGeneratorContactID = new JSONHoldingStringGenerator("field \"ContactID\" of the PhoneNumberDisambiguationCandidate class");
            fieldGeneratorPhoneNumbers = new TypePhoneNumbersJSON.HoldingArrayGenerator("field \"PhoneNumbers\" of the PhoneNumberDisambiguationCandidate class", false);
            set_what("the PhoneNumberDisambiguationCandidate class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorContactName.reset();
            fieldGeneratorContactID.reset();
            fieldGeneratorPhoneNumbers.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPhoneNumbers.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPhoneNumbers.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(PhoneNumberDisambiguationCandidateJSON  result)
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
        public PhoneNumberDisambiguationCandidateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PhoneNumberDisambiguationCandidateJSON  result)
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
    protected virtual void handle_result(List<PhoneNumberDisambiguationCandidateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PhoneNumberDisambiguationCandidateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PhoneNumberDisambiguationCandidateJSON>();
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
    public List<PhoneNumberDisambiguationCandidateJSON> value;
  };
  };
