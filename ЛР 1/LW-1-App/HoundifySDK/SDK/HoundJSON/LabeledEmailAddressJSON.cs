/* file "LabeledEmailAddressJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class LabeledEmailAddressJSON : JSONBase
  {
    private bool flagHasId;
    private BigInteger storeId;
    private bool flagHasLabel;
    private string storeLabel;
    private bool flagHasAddress;
    private string storeAddress;
    private bool flagHasIsSelected;
    private bool storeIsSelected;
    private bool flagHasIsDefault;
    private bool storeIsDefault;


    private void  fromJSONId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Id of LabeledEmailAddressJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Id of LabeledEmailAddressJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setId(extracted_integer);
      }


    private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Label of LabeledEmailAddressJSON is not a string.");
        setLabel(json_string.getData());
      }


    private void  fromJSONAddress(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Address of LabeledEmailAddressJSON is not a string.");
        setAddress(json_string.getData());
      }


    private void  fromJSONIsSelected(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsSelected of LabeledEmailAddressJSON is not true for false.");
              }
          }
        setIsSelected(the_bool);
      }


    private void  fromJSONIsDefault(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsDefault of LabeledEmailAddressJSON is not true for false.");
              }
          }
        setIsDefault(the_bool);
      }


    public LabeledEmailAddressJSON()
      {
        flagHasId = false;
        flagHasLabel = false;
        flagHasAddress = false;
        flagHasIsSelected = false;
        flagHasIsDefault = false;
      }

    public bool  hasId()
      {
        return flagHasId;
      }

    public BigInteger  getId()
      {
        Debug.Assert(flagHasId);
        return storeId;
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

    public bool  hasAddress()
      {
        return flagHasAddress;
      }

    public string  getAddress()
      {
        Debug.Assert(flagHasAddress);
        return storeAddress;
      }

    public bool  hasIsSelected()
      {
        return flagHasIsSelected;
      }

    public bool  getIsSelected()
      {
        Debug.Assert(flagHasIsSelected);
        return storeIsSelected;
      }

    public bool  hasIsDefault()
      {
        return flagHasIsDefault;
      }

    public bool  getIsDefault()
      {
        Debug.Assert(flagHasIsDefault);
        return storeIsDefault;
      }



    public void setId(BigInteger new_value)
      {
        flagHasId = true;
        if (new_value < -1)
            throw new Exception("The value for field Id of LabeledEmailAddressJSON is less than the lower bound (-1) for that field.");
        storeId = new_value;
      }
    public void unsetId()
      {
        flagHasId = false;
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
    public void setAddress(string new_value)
      {
        flagHasAddress = true;
        storeAddress = new_value;
      }
    public void unsetAddress()
      {
        flagHasAddress = false;
      }
    public void setIsSelected(bool new_value)
      {
        flagHasIsSelected = true;
        storeIsSelected = new_value;
      }
    public void unsetIsSelected()
      {
        flagHasIsSelected = false;
      }
    public void setIsDefault(bool new_value)
      {
        flagHasIsDefault = true;
        storeIsDefault = new_value;
      }
    public void unsetIsDefault()
      {
        flagHasIsDefault = false;
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
        if (flagHasId)
          {
            handler.start_pair("Id");
            handler.number_value(storeId);
          }
        if (flagHasLabel)
          {
            handler.start_pair("Label");
            handler.string_value(storeLabel);
          }
        Debug.Assert(partial_allowed || flagHasAddress);
        if (flagHasAddress)
          {
            handler.start_pair("Address");
            handler.string_value(storeAddress);
          }
        if (flagHasIsSelected)
          {
            handler.start_pair("IsSelected");
            handler.boolean_value(storeIsSelected);
          }
        if (flagHasIsDefault)
          {
            handler.start_pair("IsDefault");
            handler.boolean_value(storeIsDefault);
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
        if (!(hasAddress()))
          {
            return "When parsing the object for %what%, the \"Address\" field was missing.";
          }
        return null;
      }

    public static LabeledEmailAddressJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LabeledEmailAddressJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LabeledEmailAddress", ignore_extras);
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
    public static LabeledEmailAddressJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LabeledEmailAddressJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LabeledEmailAddressJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LabeledEmailAddress", ignore_extras);
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
    public static LabeledEmailAddressJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LabeledEmailAddressJSON from_text(string text, bool ignore_extras)
      {
        LabeledEmailAddressJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LabeledEmailAddress", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LabeledEmailAddressJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static LabeledEmailAddressJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LabeledEmailAddressJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LabeledEmailAddress", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorId : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorId(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorId : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorId(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
        private FieldHoldingGeneratorId fieldGeneratorId;
        private JSONHoldingStringGenerator fieldGeneratorLabel;
        private JSONHoldingStringGenerator fieldGeneratorAddress;
        private JSONHoldingBooleanGenerator fieldGeneratorIsSelected;
        private JSONHoldingBooleanGenerator fieldGeneratorIsDefault;

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
            LabeledEmailAddressJSON result = new LabeledEmailAddressJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(LabeledEmailAddressJSON result)
          {
            if (fieldGeneratorId.have_value)
              {
                result.setId(fieldGeneratorId.value);
                fieldGeneratorId.have_value = false;
              }
            if (fieldGeneratorLabel.have_value)
              {
                result.setLabel(fieldGeneratorLabel.value);
                fieldGeneratorLabel.have_value = false;
              }
            if (fieldGeneratorAddress.have_value)
              {
                result.setAddress(fieldGeneratorAddress.value);
                fieldGeneratorAddress.have_value = false;
              }
            else if ((!(result.hasAddress())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Address\" field was missing.");
              }
            if (fieldGeneratorIsSelected.have_value)
              {
                result.setIsSelected(fieldGeneratorIsSelected.value);
                fieldGeneratorIsSelected.have_value = false;
              }
            if (fieldGeneratorIsDefault.have_value)
              {
                result.setIsDefault(fieldGeneratorIsDefault.value);
                fieldGeneratorIsDefault.have_value = false;
              }
          }
        protected abstract void handle_result(LabeledEmailAddressJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ddress", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorAddress;
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'd':
                            if (field_name.Length == 2)
                                return fieldGeneratorId;
                            break;
                        case 's':
                            switch (field_name[2])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 3, "efault", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorIsDefault;
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 3, "elected", 0, 7, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorIsSelected;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
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
            fieldGeneratorId = new FieldHoldingGeneratorId("field \"Id\" of the LabeledEmailAddress class");
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the LabeledEmailAddress class");
            fieldGeneratorAddress = new JSONHoldingStringGenerator("field \"Address\" of the LabeledEmailAddress class");
            fieldGeneratorIsSelected = new JSONHoldingBooleanGenerator("field \"IsSelected\" of the LabeledEmailAddress class");
            fieldGeneratorIsDefault = new JSONHoldingBooleanGenerator("field \"IsDefault\" of the LabeledEmailAddress class");
            set_what("the LabeledEmailAddress class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorId = new FieldHoldingGeneratorId("field \"Id\" of the LabeledEmailAddress class");
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the LabeledEmailAddress class");
            fieldGeneratorAddress = new JSONHoldingStringGenerator("field \"Address\" of the LabeledEmailAddress class");
            fieldGeneratorIsSelected = new JSONHoldingBooleanGenerator("field \"IsSelected\" of the LabeledEmailAddress class");
            fieldGeneratorIsDefault = new JSONHoldingBooleanGenerator("field \"IsDefault\" of the LabeledEmailAddress class");
            set_what("the LabeledEmailAddress class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorId.reset();
            fieldGeneratorLabel.reset();
            fieldGeneratorAddress.reset();
            fieldGeneratorIsSelected.reset();
            fieldGeneratorIsDefault.reset();
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
        protected override void handle_result(LabeledEmailAddressJSON  result)
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
        public LabeledEmailAddressJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LabeledEmailAddressJSON  result)
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
    protected virtual void handle_result(List<LabeledEmailAddressJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LabeledEmailAddressJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LabeledEmailAddressJSON>();
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
    public List<LabeledEmailAddressJSON> value;
  };
  };
