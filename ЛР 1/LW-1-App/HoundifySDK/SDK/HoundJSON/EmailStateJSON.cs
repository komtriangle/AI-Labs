/* file "EmailStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class EmailStateJSON : JSONBase
  {
    public enum TypeValue
      {
        Value_DisambiguatingRecipientsAfterCreate,
        Value_DisambiguatingRecipientsAfterEditRecipients,
        Value_ExpectingAddRecipientsCc,
        Value_ExpectingAddRecipientsTo,
        Value_ExpectingAddRecipientsBcc,
        Value_ExpectingContinuationOfBody,
        Value_ExpectingEmailAddress,
        Value_ExpectingEmptyBodyOkYesNo,
        Value_ExpectingEmptySubjectOkYesNo,
        Value_ExpectingRemoveRecipientsCc,
        Value_ExpectingRemoveRecipientsTo,
        Value_ExpectingRemoveRecipientsBcc,
        Value_ExpectingResponseAfterEmailReady,
        Value_ExpectingSendItNowYesNo,
        Value_ExpectingStartOfBody,
        Value_ExpectingSubject,
        Value_Unknown
      };

    public static TypeValue  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'D':
                if (String.Compare(chars, 1, "isambiguatingRecipientsAfter", 0, 28, false) == 0)
                  {
                    switch (chars[29])
                      {
                        case 'C':
                            if ((String.Compare(chars, 30, "reate", 0, 5, false) == 0) && (chars.Length == 35))
                                return TypeValue.Value_DisambiguatingRecipientsAfterCreate;
                            break;
                        case 'E':
                            if ((String.Compare(chars, 30, "ditRecipients", 0, 13, false) == 0) && (chars.Length == 43))
                                return TypeValue.Value_DisambiguatingRecipientsAfterEditRecipients;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if (String.Compare(chars, 1, "xpecting", 0, 8, false) == 0)
                  {
                    switch (chars[9])
                      {
                        case 'A':
                            if (String.Compare(chars, 10, "ddRecipients", 0, 12, false) == 0)
                              {
                                switch (chars[22])
                                  {
                                    case 'B':
                                        if ((String.Compare(chars, 23, "cc", 0, 2, false) == 0) && (chars.Length == 25))
                                            return TypeValue.Value_ExpectingAddRecipientsBcc;
                                        break;
                                    case 'C':
                                        if ((String.Compare(chars, 23, "c", 0, 1, false) == 0) && (chars.Length == 24))
                                            return TypeValue.Value_ExpectingAddRecipientsCc;
                                        break;
                                    case 'T':
                                        if ((String.Compare(chars, 23, "o", 0, 1, false) == 0) && (chars.Length == 24))
                                            return TypeValue.Value_ExpectingAddRecipientsTo;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'C':
                            if ((String.Compare(chars, 10, "ontinuationOfBody", 0, 17, false) == 0) && (chars.Length == 27))
                                return TypeValue.Value_ExpectingContinuationOfBody;
                            break;
                        case 'E':
                            if (String.Compare(chars, 10, "m", 0, 1, false) == 0)
                              {
                                switch (chars[11])
                                  {
                                    case 'a':
                                        if ((String.Compare(chars, 12, "ilAddress", 0, 9, false) == 0) && (chars.Length == 21))
                                            return TypeValue.Value_ExpectingEmailAddress;
                                        break;
                                    case 'p':
                                        if (String.Compare(chars, 12, "ty", 0, 2, false) == 0)
                                          {
                                            switch (chars[14])
                                              {
                                                case 'B':
                                                    if ((String.Compare(chars, 15, "odyOkYesNo", 0, 10, false) == 0) && (chars.Length == 25))
                                                        return TypeValue.Value_ExpectingEmptyBodyOkYesNo;
                                                    break;
                                                case 'S':
                                                    if ((String.Compare(chars, 15, "ubjectOkYesNo", 0, 13, false) == 0) && (chars.Length == 28))
                                                        return TypeValue.Value_ExpectingEmptySubjectOkYesNo;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'R':
                            if (String.Compare(chars, 10, "e", 0, 1, false) == 0)
                              {
                                switch (chars[11])
                                  {
                                    case 'm':
                                        if (String.Compare(chars, 12, "oveRecipients", 0, 13, false) == 0)
                                          {
                                            switch (chars[25])
                                              {
                                                case 'B':
                                                    if ((String.Compare(chars, 26, "cc", 0, 2, false) == 0) && (chars.Length == 28))
                                                        return TypeValue.Value_ExpectingRemoveRecipientsBcc;
                                                    break;
                                                case 'C':
                                                    if ((String.Compare(chars, 26, "c", 0, 1, false) == 0) && (chars.Length == 27))
                                                        return TypeValue.Value_ExpectingRemoveRecipientsCc;
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(chars, 26, "o", 0, 1, false) == 0) && (chars.Length == 27))
                                                        return TypeValue.Value_ExpectingRemoveRecipientsTo;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 's':
                                        if ((String.Compare(chars, 12, "ponseAfterEmailReady", 0, 20, false) == 0) && (chars.Length == 32))
                                            return TypeValue.Value_ExpectingResponseAfterEmailReady;
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
                                case 'u':
                                    if ((String.Compare(chars, 11, "bject", 0, 5, false) == 0) && (chars.Length == 16))
                                        return TypeValue.Value_ExpectingSubject;
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
            case TypeValue.Value_DisambiguatingRecipientsAfterCreate:
                return "DisambiguatingRecipientsAfterCreate";
            case TypeValue.Value_DisambiguatingRecipientsAfterEditRecipients:
                return "DisambiguatingRecipientsAfterEditRecipients";
            case TypeValue.Value_ExpectingAddRecipientsCc:
                return "ExpectingAddRecipientsCc";
            case TypeValue.Value_ExpectingAddRecipientsTo:
                return "ExpectingAddRecipientsTo";
            case TypeValue.Value_ExpectingAddRecipientsBcc:
                return "ExpectingAddRecipientsBcc";
            case TypeValue.Value_ExpectingContinuationOfBody:
                return "ExpectingContinuationOfBody";
            case TypeValue.Value_ExpectingEmailAddress:
                return "ExpectingEmailAddress";
            case TypeValue.Value_ExpectingEmptyBodyOkYesNo:
                return "ExpectingEmptyBodyOkYesNo";
            case TypeValue.Value_ExpectingEmptySubjectOkYesNo:
                return "ExpectingEmptySubjectOkYesNo";
            case TypeValue.Value_ExpectingRemoveRecipientsCc:
                return "ExpectingRemoveRecipientsCc";
            case TypeValue.Value_ExpectingRemoveRecipientsTo:
                return "ExpectingRemoveRecipientsTo";
            case TypeValue.Value_ExpectingRemoveRecipientsBcc:
                return "ExpectingRemoveRecipientsBcc";
            case TypeValue.Value_ExpectingResponseAfterEmailReady:
                return "ExpectingResponseAfterEmailReady";
            case TypeValue.Value_ExpectingSendItNowYesNo:
                return "ExpectingSendItNowYesNo";
            case TypeValue.Value_ExpectingStartOfBody:
                return "ExpectingStartOfBody";
            case TypeValue.Value_ExpectingSubject:
                return "ExpectingSubject";
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
            throw new Exception("The value for field Value of EmailStateJSON is not a string.");
        TypeValue the_enum;
        switch (json_string.getData()[0])
          {
            case 'D':
                if (String.Compare(json_string.getData(), 1, "isambiguatingRecipientsAfter", 0, 28, false) == 0)
                  {
                    switch (json_string.getData()[29])
                      {
                        case 'C':
                            if ((String.Compare(json_string.getData(), 30, "reate", 0, 5, false) == 0) && (json_string.getData().Length == 35))
                                  {
                                    the_enum = TypeValue.Value_DisambiguatingRecipientsAfterCreate;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'E':
                            if ((String.Compare(json_string.getData(), 30, "ditRecipients", 0, 13, false) == 0) && (json_string.getData().Length == 43))
                                  {
                                    the_enum = TypeValue.Value_DisambiguatingRecipientsAfterEditRecipients;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if (String.Compare(json_string.getData(), 1, "xpecting", 0, 8, false) == 0)
                  {
                    switch (json_string.getData()[9])
                      {
                        case 'A':
                            if (String.Compare(json_string.getData(), 10, "ddRecipients", 0, 12, false) == 0)
                              {
                                switch (json_string.getData()[22])
                                  {
                                    case 'B':
                                        if ((String.Compare(json_string.getData(), 23, "cc", 0, 2, false) == 0) && (json_string.getData().Length == 25))
                                              {
                                                the_enum = TypeValue.Value_ExpectingAddRecipientsBcc;
                                                goto enum_is_done;
                                              }
                                        break;
                                    case 'C':
                                        if ((String.Compare(json_string.getData(), 23, "c", 0, 1, false) == 0) && (json_string.getData().Length == 24))
                                              {
                                                the_enum = TypeValue.Value_ExpectingAddRecipientsCc;
                                                goto enum_is_done;
                                              }
                                        break;
                                    case 'T':
                                        if ((String.Compare(json_string.getData(), 23, "o", 0, 1, false) == 0) && (json_string.getData().Length == 24))
                                              {
                                                the_enum = TypeValue.Value_ExpectingAddRecipientsTo;
                                                goto enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
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
                            if (String.Compare(json_string.getData(), 10, "m", 0, 1, false) == 0)
                              {
                                switch (json_string.getData()[11])
                                  {
                                    case 'a':
                                        if ((String.Compare(json_string.getData(), 12, "ilAddress", 0, 9, false) == 0) && (json_string.getData().Length == 21))
                                              {
                                                the_enum = TypeValue.Value_ExpectingEmailAddress;
                                                goto enum_is_done;
                                              }
                                        break;
                                    case 'p':
                                        if (String.Compare(json_string.getData(), 12, "ty", 0, 2, false) == 0)
                                          {
                                            switch (json_string.getData()[14])
                                              {
                                                case 'B':
                                                    if ((String.Compare(json_string.getData(), 15, "odyOkYesNo", 0, 10, false) == 0) && (json_string.getData().Length == 25))
                                                          {
                                                            the_enum = TypeValue.Value_ExpectingEmptyBodyOkYesNo;
                                                            goto enum_is_done;
                                                          }
                                                    break;
                                                case 'S':
                                                    if ((String.Compare(json_string.getData(), 15, "ubjectOkYesNo", 0, 13, false) == 0) && (json_string.getData().Length == 28))
                                                          {
                                                            the_enum = TypeValue.Value_ExpectingEmptySubjectOkYesNo;
                                                            goto enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'R':
                            if (String.Compare(json_string.getData(), 10, "e", 0, 1, false) == 0)
                              {
                                switch (json_string.getData()[11])
                                  {
                                    case 'm':
                                        if (String.Compare(json_string.getData(), 12, "oveRecipients", 0, 13, false) == 0)
                                          {
                                            switch (json_string.getData()[25])
                                              {
                                                case 'B':
                                                    if ((String.Compare(json_string.getData(), 26, "cc", 0, 2, false) == 0) && (json_string.getData().Length == 28))
                                                          {
                                                            the_enum = TypeValue.Value_ExpectingRemoveRecipientsBcc;
                                                            goto enum_is_done;
                                                          }
                                                    break;
                                                case 'C':
                                                    if ((String.Compare(json_string.getData(), 26, "c", 0, 1, false) == 0) && (json_string.getData().Length == 27))
                                                          {
                                                            the_enum = TypeValue.Value_ExpectingRemoveRecipientsCc;
                                                            goto enum_is_done;
                                                          }
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(json_string.getData(), 26, "o", 0, 1, false) == 0) && (json_string.getData().Length == 27))
                                                          {
                                                            the_enum = TypeValue.Value_ExpectingRemoveRecipientsTo;
                                                            goto enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 's':
                                        if ((String.Compare(json_string.getData(), 12, "ponseAfterEmailReady", 0, 20, false) == 0) && (json_string.getData().Length == 32))
                                              {
                                                the_enum = TypeValue.Value_ExpectingResponseAfterEmailReady;
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
                                case 'u':
                                    if ((String.Compare(json_string.getData(), 11, "bject", 0, 5, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_enum = TypeValue.Value_ExpectingSubject;
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
        throw new Exception("The value for field Value of EmailStateJSON is not one of the legal strings.");
      enum_is_done:;
        setValue(the_enum);
      }


    public EmailStateJSON()
      {
        flagHasValue = false;
      }

    public EmailStateJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public EmailStateJSON(string init_value)
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
            case TypeValue.Value_DisambiguatingRecipientsAfterCreate:
                handler.string_value("DisambiguatingRecipientsAfterCreate");
                break;
            case TypeValue.Value_DisambiguatingRecipientsAfterEditRecipients:
                handler.string_value("DisambiguatingRecipientsAfterEditRecipients");
                break;
            case TypeValue.Value_ExpectingAddRecipientsCc:
                handler.string_value("ExpectingAddRecipientsCc");
                break;
            case TypeValue.Value_ExpectingAddRecipientsTo:
                handler.string_value("ExpectingAddRecipientsTo");
                break;
            case TypeValue.Value_ExpectingAddRecipientsBcc:
                handler.string_value("ExpectingAddRecipientsBcc");
                break;
            case TypeValue.Value_ExpectingContinuationOfBody:
                handler.string_value("ExpectingContinuationOfBody");
                break;
            case TypeValue.Value_ExpectingEmailAddress:
                handler.string_value("ExpectingEmailAddress");
                break;
            case TypeValue.Value_ExpectingEmptyBodyOkYesNo:
                handler.string_value("ExpectingEmptyBodyOkYesNo");
                break;
            case TypeValue.Value_ExpectingEmptySubjectOkYesNo:
                handler.string_value("ExpectingEmptySubjectOkYesNo");
                break;
            case TypeValue.Value_ExpectingRemoveRecipientsCc:
                handler.string_value("ExpectingRemoveRecipientsCc");
                break;
            case TypeValue.Value_ExpectingRemoveRecipientsTo:
                handler.string_value("ExpectingRemoveRecipientsTo");
                break;
            case TypeValue.Value_ExpectingRemoveRecipientsBcc:
                handler.string_value("ExpectingRemoveRecipientsBcc");
                break;
            case TypeValue.Value_ExpectingResponseAfterEmailReady:
                handler.string_value("ExpectingResponseAfterEmailReady");
                break;
            case TypeValue.Value_ExpectingSendItNowYesNo:
                handler.string_value("ExpectingSendItNowYesNo");
                break;
            case TypeValue.Value_ExpectingStartOfBody:
                handler.string_value("ExpectingStartOfBody");
                break;
            case TypeValue.Value_ExpectingSubject:
                handler.string_value("ExpectingSubject");
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
            case TypeValue.Value_DisambiguatingRecipientsAfterCreate:
                handler.string_value("DisambiguatingRecipientsAfterCreate");
                break;
            case TypeValue.Value_DisambiguatingRecipientsAfterEditRecipients:
                handler.string_value("DisambiguatingRecipientsAfterEditRecipients");
                break;
            case TypeValue.Value_ExpectingAddRecipientsCc:
                handler.string_value("ExpectingAddRecipientsCc");
                break;
            case TypeValue.Value_ExpectingAddRecipientsTo:
                handler.string_value("ExpectingAddRecipientsTo");
                break;
            case TypeValue.Value_ExpectingAddRecipientsBcc:
                handler.string_value("ExpectingAddRecipientsBcc");
                break;
            case TypeValue.Value_ExpectingContinuationOfBody:
                handler.string_value("ExpectingContinuationOfBody");
                break;
            case TypeValue.Value_ExpectingEmailAddress:
                handler.string_value("ExpectingEmailAddress");
                break;
            case TypeValue.Value_ExpectingEmptyBodyOkYesNo:
                handler.string_value("ExpectingEmptyBodyOkYesNo");
                break;
            case TypeValue.Value_ExpectingEmptySubjectOkYesNo:
                handler.string_value("ExpectingEmptySubjectOkYesNo");
                break;
            case TypeValue.Value_ExpectingRemoveRecipientsCc:
                handler.string_value("ExpectingRemoveRecipientsCc");
                break;
            case TypeValue.Value_ExpectingRemoveRecipientsTo:
                handler.string_value("ExpectingRemoveRecipientsTo");
                break;
            case TypeValue.Value_ExpectingRemoveRecipientsBcc:
                handler.string_value("ExpectingRemoveRecipientsBcc");
                break;
            case TypeValue.Value_ExpectingResponseAfterEmailReady:
                handler.string_value("ExpectingResponseAfterEmailReady");
                break;
            case TypeValue.Value_ExpectingSendItNowYesNo:
                handler.string_value("ExpectingSendItNowYesNo");
                break;
            case TypeValue.Value_ExpectingStartOfBody:
                handler.string_value("ExpectingStartOfBody");
                break;
            case TypeValue.Value_ExpectingSubject:
                handler.string_value("ExpectingSubject");
                break;
            case TypeValue.Value_Unknown:
                handler.string_value("Unknown");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }

    public static EmailStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmailStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailState", ignore_extras);
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
    public static EmailStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EmailStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmailStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailState", ignore_extras);
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
    public static EmailStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EmailStateJSON from_text(string text, bool ignore_extras)
      {
        EmailStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for EmailStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static EmailStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        EmailStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailState", ignore_extras);
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
            EmailStateJSON result = new EmailStateJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(EmailStateJSON new_result);
        public Generator(bool ignore_extras) : base("Type EmailState")
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
        protected override void handle_result(EmailStateJSON  result)
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
        public EmailStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(EmailStateJSON  result)
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
    protected virtual void handle_result(List<EmailStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<EmailStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<EmailStateJSON>();
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
    public List<EmailStateJSON> value;
  };
  };
