/* file "SMSStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SMSStateJSON : JSONBase
  {
    public enum TypeValue
      {
        Value_ExpectingAddRecipientsTo,
        Value_ExpectingContinuationOfBody,
        Value_ExpectingEmptyBodyOkYesNo,
        Value_ExpectingPhoneNumber,
        Value_ExpectingRemoveRecipientsTo,
        Value_ExpectingStartOfBody,
        Value_ExpectingSendItNowYesNo,
        Value_ExpectingResponseAfterSMSReady,
        Value_Sent,
        Value_Unknown
      };

    public static TypeValue  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if (String.Compare(chars, 1, "xpecting", 0, 8, false) == 0)
                  {
                    switch (chars[9])
                      {
                        case 'A':
                            if ((String.Compare(chars, 10, "ddRecipientsTo", 0, 14, false) == 0) && (chars.Length == 24))
                                return TypeValue.Value_ExpectingAddRecipientsTo;
                            break;
                        case 'C':
                            if ((String.Compare(chars, 10, "ontinuationOfBody", 0, 17, false) == 0) && (chars.Length == 27))
                                return TypeValue.Value_ExpectingContinuationOfBody;
                            break;
                        case 'E':
                            if ((String.Compare(chars, 10, "mptyBodyOkYesNo", 0, 15, false) == 0) && (chars.Length == 25))
                                return TypeValue.Value_ExpectingEmptyBodyOkYesNo;
                            break;
                        case 'P':
                            if ((String.Compare(chars, 10, "honeNumber", 0, 10, false) == 0) && (chars.Length == 20))
                                return TypeValue.Value_ExpectingPhoneNumber;
                            break;
                        case 'R':
                            if (String.Compare(chars, 10, "e", 0, 1, false) == 0)
                              {
                                switch (chars[11])
                                  {
                                    case 'm':
                                        if ((String.Compare(chars, 12, "oveRecipientsTo", 0, 15, false) == 0) && (chars.Length == 27))
                                            return TypeValue.Value_ExpectingRemoveRecipientsTo;
                                        break;
                                    case 's':
                                        if ((String.Compare(chars, 12, "ponseAfterSMSReady", 0, 18, false) == 0) && (chars.Length == 30))
                                            return TypeValue.Value_ExpectingResponseAfterSMSReady;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            switch (chars[10])
                              {
                                case 'e':
                                    if ((String.Compare(chars, 11, "ndItNowYesNo", 0, 12, false) == 0) && (chars.Length == 23))
                                        return TypeValue.Value_ExpectingSendItNowYesNo;
                                    break;
                                case 't':
                                    if ((String.Compare(chars, 11, "artOfBody", 0, 9, false) == 0) && (chars.Length == 20))
                                        return TypeValue.Value_ExpectingStartOfBody;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(chars, 1, "ent", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeValue.Value_Sent;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeValue.Value_Unknown;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Value' is not one of the legal values.");
      }

    public static string  stringFromValue(TypeValue the_enum)
      {
        switch (the_enum)
          {
            case TypeValue.Value_ExpectingAddRecipientsTo:
                return "ExpectingAddRecipientsTo";
            case TypeValue.Value_ExpectingContinuationOfBody:
                return "ExpectingContinuationOfBody";
            case TypeValue.Value_ExpectingEmptyBodyOkYesNo:
                return "ExpectingEmptyBodyOkYesNo";
            case TypeValue.Value_ExpectingPhoneNumber:
                return "ExpectingPhoneNumber";
            case TypeValue.Value_ExpectingRemoveRecipientsTo:
                return "ExpectingRemoveRecipientsTo";
            case TypeValue.Value_ExpectingStartOfBody:
                return "ExpectingStartOfBody";
            case TypeValue.Value_ExpectingSendItNowYesNo:
                return "ExpectingSendItNowYesNo";
            case TypeValue.Value_ExpectingResponseAfterSMSReady:
                return "ExpectingResponseAfterSMSReady";
            case TypeValue.Value_Sent:
                return "Sent";
            case TypeValue.Value_Unknown:
                return "Unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValue;
    private TypeValue storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Value of SMSStateJSON is not a string.");
        TypeValue the_enum;
        switch (json_string.getData()[0])
          {
            case 'E':
                if (String.Compare(json_string.getData(), 1, "xpecting", 0, 8, false) == 0)
                  {
                    switch (json_string.getData()[9])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 10, "ddRecipientsTo", 0, 14, false) == 0) && (json_string.getData().Length == 24))
                                  {
                                    the_enum = TypeValue.Value_ExpectingAddRecipientsTo;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'C':
                            if ((String.Compare(json_string.getData(), 10, "ontinuationOfBody", 0, 17, false) == 0) && (json_string.getData().Length == 27))
                                  {
                                    the_enum = TypeValue.Value_ExpectingContinuationOfBody;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'E':
                            if ((String.Compare(json_string.getData(), 10, "mptyBodyOkYesNo", 0, 15, false) == 0) && (json_string.getData().Length == 25))
                                  {
                                    the_enum = TypeValue.Value_ExpectingEmptyBodyOkYesNo;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'P':
                            if ((String.Compare(json_string.getData(), 10, "honeNumber", 0, 10, false) == 0) && (json_string.getData().Length == 20))
                                  {
                                    the_enum = TypeValue.Value_ExpectingPhoneNumber;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'R':
                            if (String.Compare(json_string.getData(), 10, "e", 0, 1, false) == 0)
                              {
                                switch (json_string.getData()[11])
                                  {
                                    case 'm':
                                        if ((String.Compare(json_string.getData(), 12, "oveRecipientsTo", 0, 15, false) == 0) && (json_string.getData().Length == 27))
                                              {
                                                the_enum = TypeValue.Value_ExpectingRemoveRecipientsTo;
                                                goto enum_is_done;
                                              }
                                        break;
                                    case 's':
                                        if ((String.Compare(json_string.getData(), 12, "ponseAfterSMSReady", 0, 18, false) == 0) && (json_string.getData().Length == 30))
                                              {
                                                the_enum = TypeValue.Value_ExpectingResponseAfterSMSReady;
                                                goto enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            switch (json_string.getData()[10])
                              {
                                case 'e':
                                    if ((String.Compare(json_string.getData(), 11, "ndItNowYesNo", 0, 12, false) == 0) && (json_string.getData().Length == 23))
                                          {
                                            the_enum = TypeValue.Value_ExpectingSendItNowYesNo;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 't':
                                    if ((String.Compare(json_string.getData(), 11, "artOfBody", 0, 9, false) == 0) && (json_string.getData().Length == 20))
                                          {
                                            the_enum = TypeValue.Value_ExpectingStartOfBody;
                                            goto enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "ent", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeValue.Value_Sent;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeValue.Value_Unknown;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Value of SMSStateJSON is not one of the legal strings.");
      enum_is_done:;
        setValue(the_enum);
      }


    public SMSStateJSON()
      {
        flagHasValue = false;
      }

    public SMSStateJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public SMSStateJSON(string init_value)
      {
        flagHasValue = true;
        storeValue = stringToValue(init_value);
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public TypeValue  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public string  getValueAsString()
      {
        return stringFromValue(getValue());
      }



    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void setValue(string chars)
      {
        setValue(stringToValue(chars));
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        switch (storeValue)
          {
            case TypeValue.Value_ExpectingAddRecipientsTo:
                handler.string_value("ExpectingAddRecipientsTo");
                break;
            case TypeValue.Value_ExpectingContinuationOfBody:
                handler.string_value("ExpectingContinuationOfBody");
                break;
            case TypeValue.Value_ExpectingEmptyBodyOkYesNo:
                handler.string_value("ExpectingEmptyBodyOkYesNo");
                break;
            case TypeValue.Value_ExpectingPhoneNumber:
                handler.string_value("ExpectingPhoneNumber");
                break;
            case TypeValue.Value_ExpectingRemoveRecipientsTo:
                handler.string_value("ExpectingRemoveRecipientsTo");
                break;
            case TypeValue.Value_ExpectingStartOfBody:
                handler.string_value("ExpectingStartOfBody");
                break;
            case TypeValue.Value_ExpectingSendItNowYesNo:
                handler.string_value("ExpectingSendItNowYesNo");
                break;
            case TypeValue.Value_ExpectingResponseAfterSMSReady:
                handler.string_value("ExpectingResponseAfterSMSReady");
                break;
            case TypeValue.Value_Sent:
                handler.string_value("Sent");
                break;
            case TypeValue.Value_Unknown:
                handler.string_value("Unknown");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        switch (storeValue)
          {
            case TypeValue.Value_ExpectingAddRecipientsTo:
                handler.string_value("ExpectingAddRecipientsTo");
                break;
            case TypeValue.Value_ExpectingContinuationOfBody:
                handler.string_value("ExpectingContinuationOfBody");
                break;
            case TypeValue.Value_ExpectingEmptyBodyOkYesNo:
                handler.string_value("ExpectingEmptyBodyOkYesNo");
                break;
            case TypeValue.Value_ExpectingPhoneNumber:
                handler.string_value("ExpectingPhoneNumber");
                break;
            case TypeValue.Value_ExpectingRemoveRecipientsTo:
                handler.string_value("ExpectingRemoveRecipientsTo");
                break;
            case TypeValue.Value_ExpectingStartOfBody:
                handler.string_value("ExpectingStartOfBody");
                break;
            case TypeValue.Value_ExpectingSendItNowYesNo:
                handler.string_value("ExpectingSendItNowYesNo");
                break;
            case TypeValue.Value_ExpectingResponseAfterSMSReady:
                handler.string_value("ExpectingResponseAfterSMSReady");
                break;
            case TypeValue.Value_Sent:
                handler.string_value("Sent");
                break;
            case TypeValue.Value_Unknown:
                handler.string_value("Unknown");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }

    public static SMSStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSState", ignore_extras);
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
    public static SMSStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSState", ignore_extras);
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
    public static SMSStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSStateJSON from_text(string text, bool ignore_extras)
      {
        SMSStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SMSStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SMSStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SMSStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class FieldGeneratorValue : JSONStringGenerator
      {
        protected FieldGeneratorValue(string what)
          {
            set_what(what);
          }
        protected FieldGeneratorValue()
          {
          }
        protected override void handle_result(string result)
          {
            handle_result(stringToValue(result));
          }
        protected abstract void handle_result(TypeValue result);
      };
    public class FieldHoldingGeneratorValue : FieldGeneratorValue
  {
    protected override void handle_result(TypeValue result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorValue(String what)
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
    public TypeValue value;
  };
    public class FieldHoldingArrayGeneratorValue : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorValue
      {
        private FieldHoldingArrayGeneratorValue top;

        protected override void handle_result(TypeValue result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorValue init_top)
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
    protected virtual void handle_result(List<TypeValue> result)
      {
      }

    public FieldHoldingArrayGeneratorValue(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValue()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeValue> value;
  };
    public abstract class Generator : FieldGeneratorValue
      {
        protected override void handle_result(TypeValue new_value)
          {
            SMSStateJSON result = new SMSStateJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SMSStateJSON new_result);
        public Generator(bool ignore_extras) : base("Type SMSState")
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SMSStateJSON  result)
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
        public SMSStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SMSStateJSON  result)
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
    protected virtual void handle_result(List<SMSStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SMSStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SMSStateJSON>();
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
    public List<SMSStateJSON> value;
  };
  };
