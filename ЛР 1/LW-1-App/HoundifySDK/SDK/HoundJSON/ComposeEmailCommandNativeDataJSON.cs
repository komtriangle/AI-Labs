/* file "ComposeEmailCommandNativeDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ComposeEmailCommandNativeDataJSON : JSONBase
  {
    public enum TypeFocusHint
      {
        FocusHint_To,
        FocusHint_Cc,
        FocusHint_Bcc,
        FocusHint_Subject,
        FocusHint_Body
      };

    public static TypeFocusHint  stringToFocusHint(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                switch (chars[1])
                  {
                    case 'c':
                        if ((String.Compare(chars, 2, "c", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeFocusHint.FocusHint_Bcc;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "dy", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeFocusHint.FocusHint_Body;
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(chars, 1, "c", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeFocusHint.FocusHint_Cc;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "ubject", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeFocusHint.FocusHint_Subject;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "o", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeFocusHint.FocusHint_To;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `FocusHint' is not one of the legal values.");
      }

    public static string  stringFromFocusHint(TypeFocusHint the_enum)
      {
        switch (the_enum)
          {
            case TypeFocusHint.FocusHint_To:
                return "To";
            case TypeFocusHint.FocusHint_Cc:
                return "Cc";
            case TypeFocusHint.FocusHint_Bcc:
                return "Bcc";
            case TypeFocusHint.FocusHint_Subject:
                return "Subject";
            case TypeFocusHint.FocusHint_Body:
                return "Body";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeDeleteType
      {
        DeleteType_WORD,
        DeleteType_SENTENCE
      };

    public static TypeDeleteType  stringToDeleteType(string chars)
      {
        switch (chars[0])
          {
            case 'S':
                if ((String.Compare(chars, 1, "ENTENCE", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeDeleteType.DeleteType_SENTENCE;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "ORD", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeDeleteType.DeleteType_WORD;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `DeleteType' is not one of the legal values.");
      }

    public static string  stringFromDeleteType(TypeDeleteType the_enum)
      {
        switch (the_enum)
          {
            case TypeDeleteType.DeleteType_WORD:
                return "WORD";
            case TypeDeleteType.DeleteType_SENTENCE:
                return "SENTENCE";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeEditBodyState
      {
        EditBodyState_APPENDED,
        EditBodyState_SET,
        EditBodyState_NO_CHANGE
      };

    public static TypeEditBodyState  stringToEditBodyState(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "PPENDED", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeEditBodyState.EditBodyState_APPENDED;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "O_CHANGE", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeEditBodyState.EditBodyState_NO_CHANGE;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "ET", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeEditBodyState.EditBodyState_SET;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `EditBodyState' is not one of the legal values.");
      }

    public static string  stringFromEditBodyState(TypeEditBodyState the_enum)
      {
        switch (the_enum)
          {
            case TypeEditBodyState.EditBodyState_APPENDED:
                return "APPENDED";
            case TypeEditBodyState.EditBodyState_SET:
                return "SET";
            case TypeEditBodyState.EditBodyState_NO_CHANGE:
                return "NO_CHANGE";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeNotUnderstoodType
      {
        NotUnderstoodType_EMAIL_ADDRESS,
        NotUnderstoodType_YES_NO,
        NotUnderstoodType_UNKNOWN
      };

    public static TypeNotUnderstoodType  stringToNotUnderstoodType(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if ((String.Compare(chars, 1, "MAIL_ADDRESS", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeNotUnderstoodType.NotUnderstoodType_EMAIL_ADDRESS;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "NKNOWN", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeNotUnderstoodType.NotUnderstoodType_UNKNOWN;
                break;
            case 'Y':
                if ((String.Compare(chars, 1, "ES_NO", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeNotUnderstoodType.NotUnderstoodType_YES_NO;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `NotUnderstoodType' is not one of the legal values.");
      }

    public static string  stringFromNotUnderstoodType(TypeNotUnderstoodType the_enum)
      {
        switch (the_enum)
          {
            case TypeNotUnderstoodType.NotUnderstoodType_EMAIL_ADDRESS:
                return "EMAIL_ADDRESS";
            case TypeNotUnderstoodType.NotUnderstoodType_YES_NO:
                return "YES_NO";
            case TypeNotUnderstoodType.NotUnderstoodType_UNKNOWN:
                return "UNKNOWN";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasEmail;
    private EmailJSON  storeEmail;
    private bool flagHasEmptySubjectOK;
    private bool storeEmptySubjectOK;
    private bool flagHasEmptyBodyOK;
    private bool storeEmptyBodyOK;
    private bool flagHasFocusHint;
    private TypeFocusHint storeFocusHint;
    private bool flagHasSendEmailNow;
    private bool storeSendEmailNow;
    private bool flagHasLastEditedTextFieldType;
    private EmailFieldTypeJSON  storeLastEditedTextFieldType;
    private bool flagHasNewRecipientsAlreadyInEmail;
    private List< EmailContactResultJSON  > storeNewRecipientsAlreadyInEmail;
    private bool flagHasNewRecipientsNotInEmail;
    private List< EmailContactResultJSON  > storeNewRecipientsNotInEmail;
    private bool flagHasEmailAlreadyHadRecipients;
    private bool storeEmailAlreadyHadRecipients;
    private bool flagHasAlreadyHadRecipients;
    private bool storeAlreadyHadRecipients;
    private bool flagHasOverwroteSubject;
    private bool storeOverwroteSubject;
    private bool flagHasOverwroteBody;
    private bool storeOverwroteBody;
    private bool flagHasNewSubject;
    private string storeNewSubject;
    private bool flagHasNewBody;
    private string storeNewBody;
    private bool flagHasAutoListen;
    private bool storeAutoListen;
    private bool flagHasNotUnderstoodUsedWordTo;
    private bool storeNotUnderstoodUsedWordTo;
    private bool flagHasNotUnderstoodWords;
    private string storeNotUnderstoodWords;
    private bool flagHasDeleteType;
    private TypeDeleteType storeDeleteType;
    private bool flagHasNumToDelete;
    private BigInteger storeNumToDelete;
    private bool flagHasNumDeleted;
    private BigInteger storeNumDeleted;
    private bool flagHasDeleteFromBack;
    private bool storeDeleteFromBack;
    private bool flagHasNothingToDelete;
    private bool storeNothingToDelete;
    private bool flagHasDeleteFieldType;
    private EmailFieldTypeJSON  storeDeleteFieldType;
    private bool flagHasState;
    private EmailStateJSON  storeState;
    private bool flagHasEditBodyState;
    private TypeEditBodyState storeEditBodyState;
    private bool flagHasRecipientsAdded;
    private List< EmailContactResultJSON  > storeRecipientsAdded;
    private bool flagHasRecipientsRemoved;
    private List< EmailContactResultJSON  > storeRecipientsRemoved;
    private bool flagHasRecipientsCouldNotAdd;
    private List< EmailContactResultJSON  > storeRecipientsCouldNotAdd;
    private bool flagHasRecipientsCouldNotRemove;
    private List< EmailContactResultJSON  > storeRecipientsCouldNotRemove;
    private bool flagHasOpenEndedEditRequestFieldType;
    private EmailContactResultFieldTypeJSON  storeOpenEndedEditRequestFieldType;
    private bool flagHasOpenEndedEditRequestAction;
    private EmailContactResultActionJSON  storeOpenEndedEditRequestAction;
    private bool flagHasRemovedAllRecipients;
    private bool storeRemovedAllRecipients;
    private bool flagHasNotUnderstoodType;
    private TypeNotUnderstoodType storeNotUnderstoodType;
    private bool flagHasNotUnderstoodWordsFound;
    private string storeNotUnderstoodWordsFound;
    private bool flagHasReadRecipients;
    private bool storeReadRecipients;
    private bool flagHasReadSubject;
    private bool storeReadSubject;
    private bool flagHasReadBody;
    private bool storeReadBody;


    private void  fromJSONEmail(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EmailJSON convert_classy = EmailJSON.from_json(json_value, ignore_extras, true);
        setEmail(convert_classy);
      }


    private void  fromJSONEmptySubjectOK(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field EmptySubjectOK of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setEmptySubjectOK(the_bool);
      }


    private void  fromJSONEmptyBodyOK(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field EmptyBodyOK of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setEmptyBodyOK(the_bool);
      }


    private void  fromJSONFocusHint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FocusHint of ComposeEmailCommandNativeDataJSON is not a string.");
        TypeFocusHint the_enum;
        switch (json_string.getData()[0])
          {
            case 'B':
                switch (json_string.getData()[1])
                  {
                    case 'c':
                        if ((String.Compare(json_string.getData(), 2, "c", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_enum = TypeFocusHint.FocusHint_Bcc;
                                goto enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "dy", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_enum = TypeFocusHint.FocusHint_Body;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "c", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = TypeFocusHint.FocusHint_Cc;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "ubject", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeFocusHint.FocusHint_Subject;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "o", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = TypeFocusHint.FocusHint_To;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field FocusHint of ComposeEmailCommandNativeDataJSON is not one of the legal strings.");
      enum_is_done:;
        setFocusHint(the_enum);
      }


    private void  fromJSONSendEmailNow(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SendEmailNow of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setSendEmailNow(the_bool);
      }


    private void  fromJSONLastEditedTextFieldType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EmailFieldTypeJSON convert_classy = EmailFieldTypeJSON.from_json(json_value, ignore_extras, true);
        setLastEditedTextFieldType(convert_classy);
      }


    private void  fromJSONNewRecipientsAlreadyInEmail(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NewRecipientsAlreadyInEmail of ComposeEmailCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< EmailContactResultJSON  > vector_NewRecipientsAlreadyInEmail1 = new List< EmailContactResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            EmailContactResultJSON convert_classy = EmailContactResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_NewRecipientsAlreadyInEmail1.Add(convert_classy);
          }
        initNewRecipientsAlreadyInEmail();
        for (int num1 = 0; num1 < vector_NewRecipientsAlreadyInEmail1.Count; ++num1)
            appendNewRecipientsAlreadyInEmail(vector_NewRecipientsAlreadyInEmail1[num1]);
        for (int num1 = 0; num1 < vector_NewRecipientsAlreadyInEmail1.Count; ++num1)
          {
          }
      }


    private void  fromJSONNewRecipientsNotInEmail(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NewRecipientsNotInEmail of ComposeEmailCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< EmailContactResultJSON  > vector_NewRecipientsNotInEmail1 = new List< EmailContactResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            EmailContactResultJSON convert_classy = EmailContactResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_NewRecipientsNotInEmail1.Add(convert_classy);
          }
        initNewRecipientsNotInEmail();
        for (int num2 = 0; num2 < vector_NewRecipientsNotInEmail1.Count; ++num2)
            appendNewRecipientsNotInEmail(vector_NewRecipientsNotInEmail1[num2]);
        for (int num1 = 0; num1 < vector_NewRecipientsNotInEmail1.Count; ++num1)
          {
          }
      }


    private void  fromJSONEmailAlreadyHadRecipients(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field EmailAlreadyHadRecipients of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setEmailAlreadyHadRecipients(the_bool);
      }


    private void  fromJSONAlreadyHadRecipients(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AlreadyHadRecipients of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setAlreadyHadRecipients(the_bool);
      }


    private void  fromJSONOverwroteSubject(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OverwroteSubject of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setOverwroteSubject(the_bool);
      }


    private void  fromJSONOverwroteBody(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OverwroteBody of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setOverwroteBody(the_bool);
      }


    private void  fromJSONNewSubject(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NewSubject of ComposeEmailCommandNativeDataJSON is not a string.");
        setNewSubject(json_string.getData());
      }


    private void  fromJSONNewBody(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NewBody of ComposeEmailCommandNativeDataJSON is not a string.");
        setNewBody(json_string.getData());
      }


    private void  fromJSONAutoListen(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AutoListen of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setAutoListen(the_bool);
      }


    private void  fromJSONNotUnderstoodUsedWordTo(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field NotUnderstoodUsedWordTo of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setNotUnderstoodUsedWordTo(the_bool);
      }


    private void  fromJSONNotUnderstoodWords(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NotUnderstoodWords of ComposeEmailCommandNativeDataJSON is not a string.");
        setNotUnderstoodWords(json_string.getData());
      }


    private void  fromJSONDeleteType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DeleteType of ComposeEmailCommandNativeDataJSON is not a string.");
        TypeDeleteType the_enum;
        switch (json_string.getData()[0])
          {
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "ENTENCE", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeDeleteType.DeleteType_SENTENCE;
                        goto enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "ORD", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeDeleteType.DeleteType_WORD;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field DeleteType of ComposeEmailCommandNativeDataJSON is not one of the legal strings.");
      enum_is_done:;
        setDeleteType(the_enum);
      }


    private void  fromJSONNumToDelete(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NumToDelete of ComposeEmailCommandNativeDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumToDelete of ComposeEmailCommandNativeDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumToDelete(extracted_integer);
      }


    private void  fromJSONNumDeleted(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NumDeleted of ComposeEmailCommandNativeDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumDeleted of ComposeEmailCommandNativeDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumDeleted(extracted_integer);
      }


    private void  fromJSONDeleteFromBack(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DeleteFromBack of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setDeleteFromBack(the_bool);
      }


    private void  fromJSONNothingToDelete(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field NothingToDelete of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setNothingToDelete(the_bool);
      }


    private void  fromJSONDeleteFieldType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EmailFieldTypeJSON convert_classy = EmailFieldTypeJSON.from_json(json_value, ignore_extras, true);
        setDeleteFieldType(convert_classy);
      }


    private void  fromJSONState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EmailStateJSON convert_classy = EmailStateJSON.from_json(json_value, ignore_extras, true);
        setState(convert_classy);
      }


    private void  fromJSONEditBodyState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EditBodyState of ComposeEmailCommandNativeDataJSON is not a string.");
        TypeEditBodyState the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "PPENDED", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeEditBodyState.EditBodyState_APPENDED;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "O_CHANGE", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeEditBodyState.EditBodyState_NO_CHANGE;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "ET", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_enum = TypeEditBodyState.EditBodyState_SET;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field EditBodyState of ComposeEmailCommandNativeDataJSON is not one of the legal strings.");
      enum_is_done:;
        setEditBodyState(the_enum);
      }


    private void  fromJSONRecipientsAdded(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RecipientsAdded of ComposeEmailCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< EmailContactResultJSON  > vector_RecipientsAdded1 = new List< EmailContactResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            EmailContactResultJSON convert_classy = EmailContactResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RecipientsAdded1.Add(convert_classy);
          }
        initRecipientsAdded();
        for (int num3 = 0; num3 < vector_RecipientsAdded1.Count; ++num3)
            appendRecipientsAdded(vector_RecipientsAdded1[num3]);
        for (int num1 = 0; num1 < vector_RecipientsAdded1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRecipientsRemoved(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RecipientsRemoved of ComposeEmailCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< EmailContactResultJSON  > vector_RecipientsRemoved1 = new List< EmailContactResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            EmailContactResultJSON convert_classy = EmailContactResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RecipientsRemoved1.Add(convert_classy);
          }
        initRecipientsRemoved();
        for (int num4 = 0; num4 < vector_RecipientsRemoved1.Count; ++num4)
            appendRecipientsRemoved(vector_RecipientsRemoved1[num4]);
        for (int num1 = 0; num1 < vector_RecipientsRemoved1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRecipientsCouldNotAdd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RecipientsCouldNotAdd of ComposeEmailCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< EmailContactResultJSON  > vector_RecipientsCouldNotAdd1 = new List< EmailContactResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            EmailContactResultJSON convert_classy = EmailContactResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RecipientsCouldNotAdd1.Add(convert_classy);
          }
        initRecipientsCouldNotAdd();
        for (int num5 = 0; num5 < vector_RecipientsCouldNotAdd1.Count; ++num5)
            appendRecipientsCouldNotAdd(vector_RecipientsCouldNotAdd1[num5]);
        for (int num1 = 0; num1 < vector_RecipientsCouldNotAdd1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRecipientsCouldNotRemove(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RecipientsCouldNotRemove of ComposeEmailCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< EmailContactResultJSON  > vector_RecipientsCouldNotRemove1 = new List< EmailContactResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            EmailContactResultJSON convert_classy = EmailContactResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RecipientsCouldNotRemove1.Add(convert_classy);
          }
        initRecipientsCouldNotRemove();
        for (int num6 = 0; num6 < vector_RecipientsCouldNotRemove1.Count; ++num6)
            appendRecipientsCouldNotRemove(vector_RecipientsCouldNotRemove1[num6]);
        for (int num1 = 0; num1 < vector_RecipientsCouldNotRemove1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOpenEndedEditRequestFieldType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EmailContactResultFieldTypeJSON convert_classy = EmailContactResultFieldTypeJSON.from_json(json_value, ignore_extras, true);
        setOpenEndedEditRequestFieldType(convert_classy);
      }


    private void  fromJSONOpenEndedEditRequestAction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EmailContactResultActionJSON convert_classy = EmailContactResultActionJSON.from_json(json_value, ignore_extras, true);
        setOpenEndedEditRequestAction(convert_classy);
      }


    private void  fromJSONRemovedAllRecipients(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RemovedAllRecipients of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setRemovedAllRecipients(the_bool);
      }


    private void  fromJSONNotUnderstoodType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NotUnderstoodType of ComposeEmailCommandNativeDataJSON is not a string.");
        TypeNotUnderstoodType the_enum;
        switch (json_string.getData()[0])
          {
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "MAIL_ADDRESS", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_enum = TypeNotUnderstoodType.NotUnderstoodType_EMAIL_ADDRESS;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "NKNOWN", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeNotUnderstoodType.NotUnderstoodType_UNKNOWN;
                        goto enum_is_done;
                      }
                break;
            case 'Y':
                if ((String.Compare(json_string.getData(), 1, "ES_NO", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeNotUnderstoodType.NotUnderstoodType_YES_NO;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field NotUnderstoodType of ComposeEmailCommandNativeDataJSON is not one of the legal strings.");
      enum_is_done:;
        setNotUnderstoodType(the_enum);
      }


    private void  fromJSONNotUnderstoodWordsFound(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NotUnderstoodWordsFound of ComposeEmailCommandNativeDataJSON is not a string.");
        setNotUnderstoodWordsFound(json_string.getData());
      }


    private void  fromJSONReadRecipients(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ReadRecipients of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setReadRecipients(the_bool);
      }


    private void  fromJSONReadSubject(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ReadSubject of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setReadSubject(the_bool);
      }


    private void  fromJSONReadBody(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ReadBody of ComposeEmailCommandNativeDataJSON is not true for false.");
              }
          }
        setReadBody(the_bool);
      }


    public ComposeEmailCommandNativeDataJSON()
      {
        flagHasEmail = false;
        flagHasEmptySubjectOK = false;
        flagHasEmptyBodyOK = false;
        flagHasFocusHint = false;
        flagHasSendEmailNow = false;
        flagHasLastEditedTextFieldType = false;
        flagHasNewRecipientsAlreadyInEmail = false;
        flagHasNewRecipientsNotInEmail = false;
        flagHasEmailAlreadyHadRecipients = false;
        flagHasAlreadyHadRecipients = false;
        flagHasOverwroteSubject = false;
        flagHasOverwroteBody = false;
        flagHasNewSubject = false;
        flagHasNewBody = false;
        flagHasAutoListen = false;
        flagHasNotUnderstoodUsedWordTo = false;
        flagHasNotUnderstoodWords = false;
        flagHasDeleteType = false;
        flagHasNumToDelete = false;
        flagHasNumDeleted = false;
        flagHasDeleteFromBack = false;
        flagHasNothingToDelete = false;
        flagHasDeleteFieldType = false;
        flagHasState = false;
        flagHasEditBodyState = false;
        flagHasRecipientsAdded = false;
        flagHasRecipientsRemoved = false;
        flagHasRecipientsCouldNotAdd = false;
        flagHasRecipientsCouldNotRemove = false;
        flagHasOpenEndedEditRequestFieldType = false;
        flagHasOpenEndedEditRequestAction = false;
        flagHasRemovedAllRecipients = false;
        flagHasNotUnderstoodType = false;
        flagHasNotUnderstoodWordsFound = false;
        flagHasReadRecipients = false;
        flagHasReadSubject = false;
        flagHasReadBody = false;
        storeNewRecipientsAlreadyInEmail = new List< EmailContactResultJSON  >();
        storeNewRecipientsNotInEmail = new List< EmailContactResultJSON  >();
        storeRecipientsAdded = new List< EmailContactResultJSON  >();
        storeRecipientsRemoved = new List< EmailContactResultJSON  >();
        storeRecipientsCouldNotAdd = new List< EmailContactResultJSON  >();
        storeRecipientsCouldNotRemove = new List< EmailContactResultJSON  >();
      }

    public bool  hasEmail()
      {
        return flagHasEmail;
      }

    public EmailJSON   getEmail()
      {
        Debug.Assert(flagHasEmail);
        return storeEmail;
      }

    public bool  hasEmptySubjectOK()
      {
        return flagHasEmptySubjectOK;
      }

    public bool  getEmptySubjectOK()
      {
        Debug.Assert(flagHasEmptySubjectOK);
        return storeEmptySubjectOK;
      }

    public bool  hasEmptyBodyOK()
      {
        return flagHasEmptyBodyOK;
      }

    public bool  getEmptyBodyOK()
      {
        Debug.Assert(flagHasEmptyBodyOK);
        return storeEmptyBodyOK;
      }

    public bool  hasFocusHint()
      {
        return flagHasFocusHint;
      }

    public TypeFocusHint  getFocusHint()
      {
        Debug.Assert(flagHasFocusHint);
        return storeFocusHint;
      }

    public string  getFocusHintAsString()
      {
        return stringFromFocusHint(getFocusHint());
      }

    public bool  hasSendEmailNow()
      {
        return flagHasSendEmailNow;
      }

    public bool  getSendEmailNow()
      {
        Debug.Assert(flagHasSendEmailNow);
        return storeSendEmailNow;
      }

    public bool  hasLastEditedTextFieldType()
      {
        return flagHasLastEditedTextFieldType;
      }

    public EmailFieldTypeJSON   getLastEditedTextFieldType()
      {
        Debug.Assert(flagHasLastEditedTextFieldType);
        return storeLastEditedTextFieldType;
      }

    public EmailFieldTypeJSON.TypeValue  getLastEditedTextFieldTypeValue()
      {
        return getLastEditedTextFieldType().getValue();
      }

    public string  getLastEditedTextFieldTypeAsString()
      {
        return getLastEditedTextFieldType().getValueAsString();
      }

    public bool  hasNewRecipientsAlreadyInEmail()
      {
        return flagHasNewRecipientsAlreadyInEmail;
      }

    public int  countOfNewRecipientsAlreadyInEmail()
      {
        Debug.Assert(flagHasNewRecipientsAlreadyInEmail);
        return storeNewRecipientsAlreadyInEmail.Count;
      }

    public EmailContactResultJSON   elementOfNewRecipientsAlreadyInEmail(int element_num)
      {
        Debug.Assert(flagHasNewRecipientsAlreadyInEmail);
        return storeNewRecipientsAlreadyInEmail[element_num];
      }

    public List< EmailContactResultJSON  >  getNewRecipientsAlreadyInEmail()
      {
        Debug.Assert(flagHasNewRecipientsAlreadyInEmail);
        return storeNewRecipientsAlreadyInEmail;
      }

    public bool  hasNewRecipientsNotInEmail()
      {
        return flagHasNewRecipientsNotInEmail;
      }

    public int  countOfNewRecipientsNotInEmail()
      {
        Debug.Assert(flagHasNewRecipientsNotInEmail);
        return storeNewRecipientsNotInEmail.Count;
      }

    public EmailContactResultJSON   elementOfNewRecipientsNotInEmail(int element_num)
      {
        Debug.Assert(flagHasNewRecipientsNotInEmail);
        return storeNewRecipientsNotInEmail[element_num];
      }

    public List< EmailContactResultJSON  >  getNewRecipientsNotInEmail()
      {
        Debug.Assert(flagHasNewRecipientsNotInEmail);
        return storeNewRecipientsNotInEmail;
      }

    public bool  hasEmailAlreadyHadRecipients()
      {
        return flagHasEmailAlreadyHadRecipients;
      }

    public bool  getEmailAlreadyHadRecipients()
      {
        Debug.Assert(flagHasEmailAlreadyHadRecipients);
        return storeEmailAlreadyHadRecipients;
      }

    public bool  hasAlreadyHadRecipients()
      {
        return flagHasAlreadyHadRecipients;
      }

    public bool  getAlreadyHadRecipients()
      {
        Debug.Assert(flagHasAlreadyHadRecipients);
        return storeAlreadyHadRecipients;
      }

    public bool  hasOverwroteSubject()
      {
        return flagHasOverwroteSubject;
      }

    public bool  getOverwroteSubject()
      {
        Debug.Assert(flagHasOverwroteSubject);
        return storeOverwroteSubject;
      }

    public bool  hasOverwroteBody()
      {
        return flagHasOverwroteBody;
      }

    public bool  getOverwroteBody()
      {
        Debug.Assert(flagHasOverwroteBody);
        return storeOverwroteBody;
      }

    public bool  hasNewSubject()
      {
        return flagHasNewSubject;
      }

    public string  getNewSubject()
      {
        Debug.Assert(flagHasNewSubject);
        return storeNewSubject;
      }

    public bool  hasNewBody()
      {
        return flagHasNewBody;
      }

    public string  getNewBody()
      {
        Debug.Assert(flagHasNewBody);
        return storeNewBody;
      }

    public bool  hasAutoListen()
      {
        return flagHasAutoListen;
      }

    public bool  getAutoListen()
      {
        Debug.Assert(flagHasAutoListen);
        return storeAutoListen;
      }

    public bool  hasNotUnderstoodUsedWordTo()
      {
        return flagHasNotUnderstoodUsedWordTo;
      }

    public bool  getNotUnderstoodUsedWordTo()
      {
        Debug.Assert(flagHasNotUnderstoodUsedWordTo);
        return storeNotUnderstoodUsedWordTo;
      }

    public bool  hasNotUnderstoodWords()
      {
        return flagHasNotUnderstoodWords;
      }

    public string  getNotUnderstoodWords()
      {
        Debug.Assert(flagHasNotUnderstoodWords);
        return storeNotUnderstoodWords;
      }

    public bool  hasDeleteType()
      {
        return flagHasDeleteType;
      }

    public TypeDeleteType  getDeleteType()
      {
        Debug.Assert(flagHasDeleteType);
        return storeDeleteType;
      }

    public string  getDeleteTypeAsString()
      {
        return stringFromDeleteType(getDeleteType());
      }

    public bool  hasNumToDelete()
      {
        return flagHasNumToDelete;
      }

    public BigInteger  getNumToDelete()
      {
        Debug.Assert(flagHasNumToDelete);
        return storeNumToDelete;
      }

    public bool  hasNumDeleted()
      {
        return flagHasNumDeleted;
      }

    public BigInteger  getNumDeleted()
      {
        Debug.Assert(flagHasNumDeleted);
        return storeNumDeleted;
      }

    public bool  hasDeleteFromBack()
      {
        return flagHasDeleteFromBack;
      }

    public bool  getDeleteFromBack()
      {
        Debug.Assert(flagHasDeleteFromBack);
        return storeDeleteFromBack;
      }

    public bool  hasNothingToDelete()
      {
        return flagHasNothingToDelete;
      }

    public bool  getNothingToDelete()
      {
        Debug.Assert(flagHasNothingToDelete);
        return storeNothingToDelete;
      }

    public bool  hasDeleteFieldType()
      {
        return flagHasDeleteFieldType;
      }

    public EmailFieldTypeJSON   getDeleteFieldType()
      {
        Debug.Assert(flagHasDeleteFieldType);
        return storeDeleteFieldType;
      }

    public EmailFieldTypeJSON.TypeValue  getDeleteFieldTypeValue()
      {
        return getDeleteFieldType().getValue();
      }

    public string  getDeleteFieldTypeAsString()
      {
        return getDeleteFieldType().getValueAsString();
      }

    public bool  hasState()
      {
        return flagHasState;
      }

    public EmailStateJSON   getState()
      {
        Debug.Assert(flagHasState);
        return storeState;
      }

    public EmailStateJSON.TypeValue  getStateValue()
      {
        return getState().getValue();
      }

    public string  getStateAsString()
      {
        return getState().getValueAsString();
      }

    public bool  hasEditBodyState()
      {
        return flagHasEditBodyState;
      }

    public TypeEditBodyState  getEditBodyState()
      {
        Debug.Assert(flagHasEditBodyState);
        return storeEditBodyState;
      }

    public string  getEditBodyStateAsString()
      {
        return stringFromEditBodyState(getEditBodyState());
      }

    public bool  hasRecipientsAdded()
      {
        return flagHasRecipientsAdded;
      }

    public int  countOfRecipientsAdded()
      {
        Debug.Assert(flagHasRecipientsAdded);
        return storeRecipientsAdded.Count;
      }

    public EmailContactResultJSON   elementOfRecipientsAdded(int element_num)
      {
        Debug.Assert(flagHasRecipientsAdded);
        return storeRecipientsAdded[element_num];
      }

    public List< EmailContactResultJSON  >  getRecipientsAdded()
      {
        Debug.Assert(flagHasRecipientsAdded);
        return storeRecipientsAdded;
      }

    public bool  hasRecipientsRemoved()
      {
        return flagHasRecipientsRemoved;
      }

    public int  countOfRecipientsRemoved()
      {
        Debug.Assert(flagHasRecipientsRemoved);
        return storeRecipientsRemoved.Count;
      }

    public EmailContactResultJSON   elementOfRecipientsRemoved(int element_num)
      {
        Debug.Assert(flagHasRecipientsRemoved);
        return storeRecipientsRemoved[element_num];
      }

    public List< EmailContactResultJSON  >  getRecipientsRemoved()
      {
        Debug.Assert(flagHasRecipientsRemoved);
        return storeRecipientsRemoved;
      }

    public bool  hasRecipientsCouldNotAdd()
      {
        return flagHasRecipientsCouldNotAdd;
      }

    public int  countOfRecipientsCouldNotAdd()
      {
        Debug.Assert(flagHasRecipientsCouldNotAdd);
        return storeRecipientsCouldNotAdd.Count;
      }

    public EmailContactResultJSON   elementOfRecipientsCouldNotAdd(int element_num)
      {
        Debug.Assert(flagHasRecipientsCouldNotAdd);
        return storeRecipientsCouldNotAdd[element_num];
      }

    public List< EmailContactResultJSON  >  getRecipientsCouldNotAdd()
      {
        Debug.Assert(flagHasRecipientsCouldNotAdd);
        return storeRecipientsCouldNotAdd;
      }

    public bool  hasRecipientsCouldNotRemove()
      {
        return flagHasRecipientsCouldNotRemove;
      }

    public int  countOfRecipientsCouldNotRemove()
      {
        Debug.Assert(flagHasRecipientsCouldNotRemove);
        return storeRecipientsCouldNotRemove.Count;
      }

    public EmailContactResultJSON   elementOfRecipientsCouldNotRemove(int element_num)
      {
        Debug.Assert(flagHasRecipientsCouldNotRemove);
        return storeRecipientsCouldNotRemove[element_num];
      }

    public List< EmailContactResultJSON  >  getRecipientsCouldNotRemove()
      {
        Debug.Assert(flagHasRecipientsCouldNotRemove);
        return storeRecipientsCouldNotRemove;
      }

    public bool  hasOpenEndedEditRequestFieldType()
      {
        return flagHasOpenEndedEditRequestFieldType;
      }

    public EmailContactResultFieldTypeJSON   getOpenEndedEditRequestFieldType()
      {
        Debug.Assert(flagHasOpenEndedEditRequestFieldType);
        return storeOpenEndedEditRequestFieldType;
      }

    public EmailContactResultFieldTypeJSON.TypeValue  getOpenEndedEditRequestFieldTypeValue()
      {
        return getOpenEndedEditRequestFieldType().getValue();
      }

    public string  getOpenEndedEditRequestFieldTypeAsString()
      {
        return getOpenEndedEditRequestFieldType().getValueAsString();
      }

    public bool  hasOpenEndedEditRequestAction()
      {
        return flagHasOpenEndedEditRequestAction;
      }

    public EmailContactResultActionJSON   getOpenEndedEditRequestAction()
      {
        Debug.Assert(flagHasOpenEndedEditRequestAction);
        return storeOpenEndedEditRequestAction;
      }

    public EmailContactResultActionJSON.TypeValue  getOpenEndedEditRequestActionValue()
      {
        return getOpenEndedEditRequestAction().getValue();
      }

    public string  getOpenEndedEditRequestActionAsString()
      {
        return getOpenEndedEditRequestAction().getValueAsString();
      }

    public bool  hasRemovedAllRecipients()
      {
        return flagHasRemovedAllRecipients;
      }

    public bool  getRemovedAllRecipients()
      {
        Debug.Assert(flagHasRemovedAllRecipients);
        return storeRemovedAllRecipients;
      }

    public bool  hasNotUnderstoodType()
      {
        return flagHasNotUnderstoodType;
      }

    public TypeNotUnderstoodType  getNotUnderstoodType()
      {
        Debug.Assert(flagHasNotUnderstoodType);
        return storeNotUnderstoodType;
      }

    public string  getNotUnderstoodTypeAsString()
      {
        return stringFromNotUnderstoodType(getNotUnderstoodType());
      }

    public bool  hasNotUnderstoodWordsFound()
      {
        return flagHasNotUnderstoodWordsFound;
      }

    public string  getNotUnderstoodWordsFound()
      {
        Debug.Assert(flagHasNotUnderstoodWordsFound);
        return storeNotUnderstoodWordsFound;
      }

    public bool  hasReadRecipients()
      {
        return flagHasReadRecipients;
      }

    public bool  getReadRecipients()
      {
        Debug.Assert(flagHasReadRecipients);
        return storeReadRecipients;
      }

    public bool  hasReadSubject()
      {
        return flagHasReadSubject;
      }

    public bool  getReadSubject()
      {
        Debug.Assert(flagHasReadSubject);
        return storeReadSubject;
      }

    public bool  hasReadBody()
      {
        return flagHasReadBody;
      }

    public bool  getReadBody()
      {
        Debug.Assert(flagHasReadBody);
        return storeReadBody;
      }



    public void setEmail(EmailJSON  new_value)
      {
        if (flagHasEmail)
          {
          }
        flagHasEmail = true;
        storeEmail = new_value;
      }
    public void unsetEmail()
      {
        if (flagHasEmail)
          {
          }
        flagHasEmail = false;
      }
    public void setEmptySubjectOK(bool new_value)
      {
        flagHasEmptySubjectOK = true;
        storeEmptySubjectOK = new_value;
      }
    public void unsetEmptySubjectOK()
      {
        flagHasEmptySubjectOK = false;
      }
    public void setEmptyBodyOK(bool new_value)
      {
        flagHasEmptyBodyOK = true;
        storeEmptyBodyOK = new_value;
      }
    public void unsetEmptyBodyOK()
      {
        flagHasEmptyBodyOK = false;
      }
    public void setFocusHint(TypeFocusHint new_value)
      {
        flagHasFocusHint = true;
        storeFocusHint = new_value;
      }
    public void setFocusHint(string chars)
      {
        setFocusHint(stringToFocusHint(chars));
      }
    public void unsetFocusHint()
      {
        flagHasFocusHint = false;
      }
    public void setSendEmailNow(bool new_value)
      {
        flagHasSendEmailNow = true;
        storeSendEmailNow = new_value;
      }
    public void unsetSendEmailNow()
      {
        flagHasSendEmailNow = false;
      }
    public void setLastEditedTextFieldType(EmailFieldTypeJSON  new_value)
      {
        if (flagHasLastEditedTextFieldType)
          {
          }
        flagHasLastEditedTextFieldType = true;
        storeLastEditedTextFieldType = new_value;
      }
    public void setLastEditedTextFieldType(EmailFieldTypeJSON.TypeValue new_value)
      {
        setLastEditedTextFieldType(new EmailFieldTypeJSON(new_value));
      }
    public void setLastEditedTextFieldType(string chars)
      {
        setLastEditedTextFieldType(new EmailFieldTypeJSON(chars));
      }
    public void unsetLastEditedTextFieldType()
      {
        if (flagHasLastEditedTextFieldType)
          {
          }
        flagHasLastEditedTextFieldType = false;
      }
    public void initNewRecipientsAlreadyInEmail()
      {
        if (flagHasNewRecipientsAlreadyInEmail)
          {
            for (int num1 = 0; num1 < storeNewRecipientsAlreadyInEmail.Count; ++num1)
              {
              }
          }
        flagHasNewRecipientsAlreadyInEmail = true;
        storeNewRecipientsAlreadyInEmail.Clear();
      }
    public void appendNewRecipientsAlreadyInEmail(EmailContactResultJSON  to_append)
      {
        if (!flagHasNewRecipientsAlreadyInEmail)
          {
            flagHasNewRecipientsAlreadyInEmail = true;
            storeNewRecipientsAlreadyInEmail.Clear();
          }
        Debug.Assert(flagHasNewRecipientsAlreadyInEmail);
        storeNewRecipientsAlreadyInEmail.Add(to_append);
      }
    public void unsetNewRecipientsAlreadyInEmail()
      {
        if (flagHasNewRecipientsAlreadyInEmail)
          {
            for (int num2 = 0; num2 < storeNewRecipientsAlreadyInEmail.Count; ++num2)
              {
              }
          }
        flagHasNewRecipientsAlreadyInEmail = false;
        storeNewRecipientsAlreadyInEmail.Clear();
      }
    public void initNewRecipientsNotInEmail()
      {
        if (flagHasNewRecipientsNotInEmail)
          {
            for (int num3 = 0; num3 < storeNewRecipientsNotInEmail.Count; ++num3)
              {
              }
          }
        flagHasNewRecipientsNotInEmail = true;
        storeNewRecipientsNotInEmail.Clear();
      }
    public void appendNewRecipientsNotInEmail(EmailContactResultJSON  to_append)
      {
        if (!flagHasNewRecipientsNotInEmail)
          {
            flagHasNewRecipientsNotInEmail = true;
            storeNewRecipientsNotInEmail.Clear();
          }
        Debug.Assert(flagHasNewRecipientsNotInEmail);
        storeNewRecipientsNotInEmail.Add(to_append);
      }
    public void unsetNewRecipientsNotInEmail()
      {
        if (flagHasNewRecipientsNotInEmail)
          {
            for (int num4 = 0; num4 < storeNewRecipientsNotInEmail.Count; ++num4)
              {
              }
          }
        flagHasNewRecipientsNotInEmail = false;
        storeNewRecipientsNotInEmail.Clear();
      }
    public void setEmailAlreadyHadRecipients(bool new_value)
      {
        flagHasEmailAlreadyHadRecipients = true;
        storeEmailAlreadyHadRecipients = new_value;
      }
    public void unsetEmailAlreadyHadRecipients()
      {
        flagHasEmailAlreadyHadRecipients = false;
      }
    public void setAlreadyHadRecipients(bool new_value)
      {
        flagHasAlreadyHadRecipients = true;
        storeAlreadyHadRecipients = new_value;
      }
    public void unsetAlreadyHadRecipients()
      {
        flagHasAlreadyHadRecipients = false;
      }
    public void setOverwroteSubject(bool new_value)
      {
        flagHasOverwroteSubject = true;
        storeOverwroteSubject = new_value;
      }
    public void unsetOverwroteSubject()
      {
        flagHasOverwroteSubject = false;
      }
    public void setOverwroteBody(bool new_value)
      {
        flagHasOverwroteBody = true;
        storeOverwroteBody = new_value;
      }
    public void unsetOverwroteBody()
      {
        flagHasOverwroteBody = false;
      }
    public void setNewSubject(string new_value)
      {
        flagHasNewSubject = true;
        storeNewSubject = new_value;
      }
    public void unsetNewSubject()
      {
        flagHasNewSubject = false;
      }
    public void setNewBody(string new_value)
      {
        flagHasNewBody = true;
        storeNewBody = new_value;
      }
    public void unsetNewBody()
      {
        flagHasNewBody = false;
      }
    public void setAutoListen(bool new_value)
      {
        flagHasAutoListen = true;
        storeAutoListen = new_value;
      }
    public void unsetAutoListen()
      {
        flagHasAutoListen = false;
      }
    public void setNotUnderstoodUsedWordTo(bool new_value)
      {
        flagHasNotUnderstoodUsedWordTo = true;
        storeNotUnderstoodUsedWordTo = new_value;
      }
    public void unsetNotUnderstoodUsedWordTo()
      {
        flagHasNotUnderstoodUsedWordTo = false;
      }
    public void setNotUnderstoodWords(string new_value)
      {
        flagHasNotUnderstoodWords = true;
        storeNotUnderstoodWords = new_value;
      }
    public void unsetNotUnderstoodWords()
      {
        flagHasNotUnderstoodWords = false;
      }
    public void setDeleteType(TypeDeleteType new_value)
      {
        flagHasDeleteType = true;
        storeDeleteType = new_value;
      }
    public void setDeleteType(string chars)
      {
        setDeleteType(stringToDeleteType(chars));
      }
    public void unsetDeleteType()
      {
        flagHasDeleteType = false;
      }
    public void setNumToDelete(BigInteger new_value)
      {
        flagHasNumToDelete = true;
        if (new_value < 0)
            throw new Exception("The value for field NumToDelete of ComposeEmailCommandNativeDataJSON is less than the lower bound (0) for that field.");
        storeNumToDelete = new_value;
      }
    public void unsetNumToDelete()
      {
        flagHasNumToDelete = false;
      }
    public void setNumDeleted(BigInteger new_value)
      {
        flagHasNumDeleted = true;
        if (new_value < 0)
            throw new Exception("The value for field NumDeleted of ComposeEmailCommandNativeDataJSON is less than the lower bound (0) for that field.");
        storeNumDeleted = new_value;
      }
    public void unsetNumDeleted()
      {
        flagHasNumDeleted = false;
      }
    public void setDeleteFromBack(bool new_value)
      {
        flagHasDeleteFromBack = true;
        storeDeleteFromBack = new_value;
      }
    public void unsetDeleteFromBack()
      {
        flagHasDeleteFromBack = false;
      }
    public void setNothingToDelete(bool new_value)
      {
        flagHasNothingToDelete = true;
        storeNothingToDelete = new_value;
      }
    public void unsetNothingToDelete()
      {
        flagHasNothingToDelete = false;
      }
    public void setDeleteFieldType(EmailFieldTypeJSON  new_value)
      {
        if (flagHasDeleteFieldType)
          {
          }
        flagHasDeleteFieldType = true;
        storeDeleteFieldType = new_value;
      }
    public void setDeleteFieldType(EmailFieldTypeJSON.TypeValue new_value)
      {
        setDeleteFieldType(new EmailFieldTypeJSON(new_value));
      }
    public void setDeleteFieldType(string chars)
      {
        setDeleteFieldType(new EmailFieldTypeJSON(chars));
      }
    public void unsetDeleteFieldType()
      {
        if (flagHasDeleteFieldType)
          {
          }
        flagHasDeleteFieldType = false;
      }
    public void setState(EmailStateJSON  new_value)
      {
        if (flagHasState)
          {
          }
        flagHasState = true;
        storeState = new_value;
      }
    public void setState(EmailStateJSON.TypeValue new_value)
      {
        setState(new EmailStateJSON(new_value));
      }
    public void setState(string chars)
      {
        setState(new EmailStateJSON(chars));
      }
    public void unsetState()
      {
        if (flagHasState)
          {
          }
        flagHasState = false;
      }
    public void setEditBodyState(TypeEditBodyState new_value)
      {
        flagHasEditBodyState = true;
        storeEditBodyState = new_value;
      }
    public void setEditBodyState(string chars)
      {
        setEditBodyState(stringToEditBodyState(chars));
      }
    public void unsetEditBodyState()
      {
        flagHasEditBodyState = false;
      }
    public void initRecipientsAdded()
      {
        if (flagHasRecipientsAdded)
          {
            for (int num5 = 0; num5 < storeRecipientsAdded.Count; ++num5)
              {
              }
          }
        flagHasRecipientsAdded = true;
        storeRecipientsAdded.Clear();
      }
    public void appendRecipientsAdded(EmailContactResultJSON  to_append)
      {
        if (!flagHasRecipientsAdded)
          {
            flagHasRecipientsAdded = true;
            storeRecipientsAdded.Clear();
          }
        Debug.Assert(flagHasRecipientsAdded);
        storeRecipientsAdded.Add(to_append);
      }
    public void unsetRecipientsAdded()
      {
        if (flagHasRecipientsAdded)
          {
            for (int num6 = 0; num6 < storeRecipientsAdded.Count; ++num6)
              {
              }
          }
        flagHasRecipientsAdded = false;
        storeRecipientsAdded.Clear();
      }
    public void initRecipientsRemoved()
      {
        if (flagHasRecipientsRemoved)
          {
            for (int num7 = 0; num7 < storeRecipientsRemoved.Count; ++num7)
              {
              }
          }
        flagHasRecipientsRemoved = true;
        storeRecipientsRemoved.Clear();
      }
    public void appendRecipientsRemoved(EmailContactResultJSON  to_append)
      {
        if (!flagHasRecipientsRemoved)
          {
            flagHasRecipientsRemoved = true;
            storeRecipientsRemoved.Clear();
          }
        Debug.Assert(flagHasRecipientsRemoved);
        storeRecipientsRemoved.Add(to_append);
      }
    public void unsetRecipientsRemoved()
      {
        if (flagHasRecipientsRemoved)
          {
            for (int num8 = 0; num8 < storeRecipientsRemoved.Count; ++num8)
              {
              }
          }
        flagHasRecipientsRemoved = false;
        storeRecipientsRemoved.Clear();
      }
    public void initRecipientsCouldNotAdd()
      {
        if (flagHasRecipientsCouldNotAdd)
          {
            for (int num9 = 0; num9 < storeRecipientsCouldNotAdd.Count; ++num9)
              {
              }
          }
        flagHasRecipientsCouldNotAdd = true;
        storeRecipientsCouldNotAdd.Clear();
      }
    public void appendRecipientsCouldNotAdd(EmailContactResultJSON  to_append)
      {
        if (!flagHasRecipientsCouldNotAdd)
          {
            flagHasRecipientsCouldNotAdd = true;
            storeRecipientsCouldNotAdd.Clear();
          }
        Debug.Assert(flagHasRecipientsCouldNotAdd);
        storeRecipientsCouldNotAdd.Add(to_append);
      }
    public void unsetRecipientsCouldNotAdd()
      {
        if (flagHasRecipientsCouldNotAdd)
          {
            for (int num10 = 0; num10 < storeRecipientsCouldNotAdd.Count; ++num10)
              {
              }
          }
        flagHasRecipientsCouldNotAdd = false;
        storeRecipientsCouldNotAdd.Clear();
      }
    public void initRecipientsCouldNotRemove()
      {
        if (flagHasRecipientsCouldNotRemove)
          {
            for (int num11 = 0; num11 < storeRecipientsCouldNotRemove.Count; ++num11)
              {
              }
          }
        flagHasRecipientsCouldNotRemove = true;
        storeRecipientsCouldNotRemove.Clear();
      }
    public void appendRecipientsCouldNotRemove(EmailContactResultJSON  to_append)
      {
        if (!flagHasRecipientsCouldNotRemove)
          {
            flagHasRecipientsCouldNotRemove = true;
            storeRecipientsCouldNotRemove.Clear();
          }
        Debug.Assert(flagHasRecipientsCouldNotRemove);
        storeRecipientsCouldNotRemove.Add(to_append);
      }
    public void unsetRecipientsCouldNotRemove()
      {
        if (flagHasRecipientsCouldNotRemove)
          {
            for (int num12 = 0; num12 < storeRecipientsCouldNotRemove.Count; ++num12)
              {
              }
          }
        flagHasRecipientsCouldNotRemove = false;
        storeRecipientsCouldNotRemove.Clear();
      }
    public void setOpenEndedEditRequestFieldType(EmailContactResultFieldTypeJSON  new_value)
      {
        if (flagHasOpenEndedEditRequestFieldType)
          {
          }
        flagHasOpenEndedEditRequestFieldType = true;
        storeOpenEndedEditRequestFieldType = new_value;
      }
    public void setOpenEndedEditRequestFieldType(EmailContactResultFieldTypeJSON.TypeValue new_value)
      {
        setOpenEndedEditRequestFieldType(new EmailContactResultFieldTypeJSON(new_value));
      }
    public void setOpenEndedEditRequestFieldType(string chars)
      {
        setOpenEndedEditRequestFieldType(new EmailContactResultFieldTypeJSON(chars));
      }
    public void unsetOpenEndedEditRequestFieldType()
      {
        if (flagHasOpenEndedEditRequestFieldType)
          {
          }
        flagHasOpenEndedEditRequestFieldType = false;
      }
    public void setOpenEndedEditRequestAction(EmailContactResultActionJSON  new_value)
      {
        if (flagHasOpenEndedEditRequestAction)
          {
          }
        flagHasOpenEndedEditRequestAction = true;
        storeOpenEndedEditRequestAction = new_value;
      }
    public void setOpenEndedEditRequestAction(EmailContactResultActionJSON.TypeValue new_value)
      {
        setOpenEndedEditRequestAction(new EmailContactResultActionJSON(new_value));
      }
    public void setOpenEndedEditRequestAction(string chars)
      {
        setOpenEndedEditRequestAction(new EmailContactResultActionJSON(chars));
      }
    public void unsetOpenEndedEditRequestAction()
      {
        if (flagHasOpenEndedEditRequestAction)
          {
          }
        flagHasOpenEndedEditRequestAction = false;
      }
    public void setRemovedAllRecipients(bool new_value)
      {
        flagHasRemovedAllRecipients = true;
        storeRemovedAllRecipients = new_value;
      }
    public void unsetRemovedAllRecipients()
      {
        flagHasRemovedAllRecipients = false;
      }
    public void setNotUnderstoodType(TypeNotUnderstoodType new_value)
      {
        flagHasNotUnderstoodType = true;
        storeNotUnderstoodType = new_value;
      }
    public void setNotUnderstoodType(string chars)
      {
        setNotUnderstoodType(stringToNotUnderstoodType(chars));
      }
    public void unsetNotUnderstoodType()
      {
        flagHasNotUnderstoodType = false;
      }
    public void setNotUnderstoodWordsFound(string new_value)
      {
        flagHasNotUnderstoodWordsFound = true;
        storeNotUnderstoodWordsFound = new_value;
      }
    public void unsetNotUnderstoodWordsFound()
      {
        flagHasNotUnderstoodWordsFound = false;
      }
    public void setReadRecipients(bool new_value)
      {
        flagHasReadRecipients = true;
        storeReadRecipients = new_value;
      }
    public void unsetReadRecipients()
      {
        flagHasReadRecipients = false;
      }
    public void setReadSubject(bool new_value)
      {
        flagHasReadSubject = true;
        storeReadSubject = new_value;
      }
    public void unsetReadSubject()
      {
        flagHasReadSubject = false;
      }
    public void setReadBody(bool new_value)
      {
        flagHasReadBody = true;
        storeReadBody = new_value;
      }
    public void unsetReadBody()
      {
        flagHasReadBody = false;
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
        Debug.Assert(partial_allowed || flagHasEmail);
        if (flagHasEmail)
          {
            handler.start_pair("Email");
            if (partial_allowed)
                storeEmail.write_partial_as_json(handler);
            else
                storeEmail.write_as_json(handler);
          }
        if (flagHasEmptySubjectOK)
          {
            handler.start_pair("EmptySubjectOK");
            handler.boolean_value(storeEmptySubjectOK);
          }
        if (flagHasEmptyBodyOK)
          {
            handler.start_pair("EmptyBodyOK");
            handler.boolean_value(storeEmptyBodyOK);
          }
        if (flagHasFocusHint)
          {
            handler.start_pair("FocusHint");
            switch (storeFocusHint)
              {
                case TypeFocusHint.FocusHint_To:
                    handler.string_value("To");
                    break;
                case TypeFocusHint.FocusHint_Cc:
                    handler.string_value("Cc");
                    break;
                case TypeFocusHint.FocusHint_Bcc:
                    handler.string_value("Bcc");
                    break;
                case TypeFocusHint.FocusHint_Subject:
                    handler.string_value("Subject");
                    break;
                case TypeFocusHint.FocusHint_Body:
                    handler.string_value("Body");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasSendEmailNow)
          {
            handler.start_pair("SendEmailNow");
            handler.boolean_value(storeSendEmailNow);
          }
        if (flagHasLastEditedTextFieldType)
          {
            handler.start_pair("LastEditedTextFieldType");
            if (partial_allowed)
                storeLastEditedTextFieldType.write_partial_as_json(handler);
            else
                storeLastEditedTextFieldType.write_as_json(handler);
          }
        if (flagHasNewRecipientsAlreadyInEmail)
          {
            handler.start_pair("NewRecipientsAlreadyInEmail");
            handler.start_array();
            for (int num1 = 0; num1 < storeNewRecipientsAlreadyInEmail.Count; ++num1)
              {
                if (partial_allowed)
                    storeNewRecipientsAlreadyInEmail[num1].write_partial_as_json(handler);
                else
                    storeNewRecipientsAlreadyInEmail[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasNewRecipientsNotInEmail)
          {
            handler.start_pair("NewRecipientsNotInEmail");
            handler.start_array();
            for (int num2 = 0; num2 < storeNewRecipientsNotInEmail.Count; ++num2)
              {
                if (partial_allowed)
                    storeNewRecipientsNotInEmail[num2].write_partial_as_json(handler);
                else
                    storeNewRecipientsNotInEmail[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasEmailAlreadyHadRecipients)
          {
            handler.start_pair("EmailAlreadyHadRecipients");
            handler.boolean_value(storeEmailAlreadyHadRecipients);
          }
        if (flagHasAlreadyHadRecipients)
          {
            handler.start_pair("AlreadyHadRecipients");
            handler.boolean_value(storeAlreadyHadRecipients);
          }
        if (flagHasOverwroteSubject)
          {
            handler.start_pair("OverwroteSubject");
            handler.boolean_value(storeOverwroteSubject);
          }
        if (flagHasOverwroteBody)
          {
            handler.start_pair("OverwroteBody");
            handler.boolean_value(storeOverwroteBody);
          }
        if (flagHasNewSubject)
          {
            handler.start_pair("NewSubject");
            handler.string_value(storeNewSubject);
          }
        if (flagHasNewBody)
          {
            handler.start_pair("NewBody");
            handler.string_value(storeNewBody);
          }
        if (flagHasAutoListen)
          {
            handler.start_pair("AutoListen");
            handler.boolean_value(storeAutoListen);
          }
        if (flagHasNotUnderstoodUsedWordTo)
          {
            handler.start_pair("NotUnderstoodUsedWordTo");
            handler.boolean_value(storeNotUnderstoodUsedWordTo);
          }
        if (flagHasNotUnderstoodWords)
          {
            handler.start_pair("NotUnderstoodWords");
            handler.string_value(storeNotUnderstoodWords);
          }
        if (flagHasDeleteType)
          {
            handler.start_pair("DeleteType");
            switch (storeDeleteType)
              {
                case TypeDeleteType.DeleteType_WORD:
                    handler.string_value("WORD");
                    break;
                case TypeDeleteType.DeleteType_SENTENCE:
                    handler.string_value("SENTENCE");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasNumToDelete)
          {
            handler.start_pair("NumToDelete");
            handler.number_value(storeNumToDelete);
          }
        if (flagHasNumDeleted)
          {
            handler.start_pair("NumDeleted");
            handler.number_value(storeNumDeleted);
          }
        if (flagHasDeleteFromBack)
          {
            handler.start_pair("DeleteFromBack");
            handler.boolean_value(storeDeleteFromBack);
          }
        if (flagHasNothingToDelete)
          {
            handler.start_pair("NothingToDelete");
            handler.boolean_value(storeNothingToDelete);
          }
        if (flagHasDeleteFieldType)
          {
            handler.start_pair("DeleteFieldType");
            if (partial_allowed)
                storeDeleteFieldType.write_partial_as_json(handler);
            else
                storeDeleteFieldType.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasState);
        if (flagHasState)
          {
            handler.start_pair("State");
            if (partial_allowed)
                storeState.write_partial_as_json(handler);
            else
                storeState.write_as_json(handler);
          }
        if (flagHasEditBodyState)
          {
            handler.start_pair("EditBodyState");
            switch (storeEditBodyState)
              {
                case TypeEditBodyState.EditBodyState_APPENDED:
                    handler.string_value("APPENDED");
                    break;
                case TypeEditBodyState.EditBodyState_SET:
                    handler.string_value("SET");
                    break;
                case TypeEditBodyState.EditBodyState_NO_CHANGE:
                    handler.string_value("NO_CHANGE");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasRecipientsAdded)
          {
            handler.start_pair("RecipientsAdded");
            handler.start_array();
            for (int num3 = 0; num3 < storeRecipientsAdded.Count; ++num3)
              {
                if (partial_allowed)
                    storeRecipientsAdded[num3].write_partial_as_json(handler);
                else
                    storeRecipientsAdded[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRecipientsRemoved)
          {
            handler.start_pair("RecipientsRemoved");
            handler.start_array();
            for (int num4 = 0; num4 < storeRecipientsRemoved.Count; ++num4)
              {
                if (partial_allowed)
                    storeRecipientsRemoved[num4].write_partial_as_json(handler);
                else
                    storeRecipientsRemoved[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRecipientsCouldNotAdd)
          {
            handler.start_pair("RecipientsCouldNotAdd");
            handler.start_array();
            for (int num5 = 0; num5 < storeRecipientsCouldNotAdd.Count; ++num5)
              {
                if (partial_allowed)
                    storeRecipientsCouldNotAdd[num5].write_partial_as_json(handler);
                else
                    storeRecipientsCouldNotAdd[num5].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRecipientsCouldNotRemove)
          {
            handler.start_pair("RecipientsCouldNotRemove");
            handler.start_array();
            for (int num6 = 0; num6 < storeRecipientsCouldNotRemove.Count; ++num6)
              {
                if (partial_allowed)
                    storeRecipientsCouldNotRemove[num6].write_partial_as_json(handler);
                else
                    storeRecipientsCouldNotRemove[num6].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasOpenEndedEditRequestFieldType)
          {
            handler.start_pair("OpenEndedEditRequestFieldType");
            if (partial_allowed)
                storeOpenEndedEditRequestFieldType.write_partial_as_json(handler);
            else
                storeOpenEndedEditRequestFieldType.write_as_json(handler);
          }
        if (flagHasOpenEndedEditRequestAction)
          {
            handler.start_pair("OpenEndedEditRequestAction");
            if (partial_allowed)
                storeOpenEndedEditRequestAction.write_partial_as_json(handler);
            else
                storeOpenEndedEditRequestAction.write_as_json(handler);
          }
        if (flagHasRemovedAllRecipients)
          {
            handler.start_pair("RemovedAllRecipients");
            handler.boolean_value(storeRemovedAllRecipients);
          }
        if (flagHasNotUnderstoodType)
          {
            handler.start_pair("NotUnderstoodType");
            switch (storeNotUnderstoodType)
              {
                case TypeNotUnderstoodType.NotUnderstoodType_EMAIL_ADDRESS:
                    handler.string_value("EMAIL_ADDRESS");
                    break;
                case TypeNotUnderstoodType.NotUnderstoodType_YES_NO:
                    handler.string_value("YES_NO");
                    break;
                case TypeNotUnderstoodType.NotUnderstoodType_UNKNOWN:
                    handler.string_value("UNKNOWN");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasNotUnderstoodWordsFound)
          {
            handler.start_pair("NotUnderstoodWordsFound");
            handler.string_value(storeNotUnderstoodWordsFound);
          }
        if (flagHasReadRecipients)
          {
            handler.start_pair("ReadRecipients");
            handler.boolean_value(storeReadRecipients);
          }
        if (flagHasReadSubject)
          {
            handler.start_pair("ReadSubject");
            handler.boolean_value(storeReadSubject);
          }
        if (flagHasReadBody)
          {
            handler.start_pair("ReadBody");
            handler.boolean_value(storeReadBody);
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
        if (!(hasEmail()))
          {
            return "When parsing the object for %what%, the \"Email\" field was missing.";
          }
        if (!(hasState()))
          {
            return "When parsing the object for %what%, the \"State\" field was missing.";
          }
        return null;
      }

    public static ComposeEmailCommandNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ComposeEmailCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeEmailCommandNativeData", ignore_extras);
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
    public static ComposeEmailCommandNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ComposeEmailCommandNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ComposeEmailCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeEmailCommandNativeData", ignore_extras);
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
    public static ComposeEmailCommandNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ComposeEmailCommandNativeDataJSON from_text(string text, bool ignore_extras)
      {
        ComposeEmailCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeEmailCommandNativeData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ComposeEmailCommandNativeDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ComposeEmailCommandNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ComposeEmailCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeEmailCommandNativeData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private EmailJSON.HoldingGenerator fieldGeneratorEmail;
        private JSONHoldingBooleanGenerator fieldGeneratorEmptySubjectOK;
        private JSONHoldingBooleanGenerator fieldGeneratorEmptyBodyOK;
    private abstract class FieldGeneratorFocusHint : JSONStringGenerator
          {
            protected FieldGeneratorFocusHint(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFocusHint()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToFocusHint(result));
              }
            protected abstract void handle_result(TypeFocusHint result);
          };
    private class FieldHoldingGeneratorFocusHint : FieldGeneratorFocusHint
  {
    protected override void handle_result(TypeFocusHint result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFocusHint(String what)
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
    public TypeFocusHint value;
  };
    private class FieldHoldingArrayGeneratorFocusHint : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFocusHint
      {
        private FieldHoldingArrayGeneratorFocusHint top;

        protected override void handle_result(TypeFocusHint result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFocusHint init_top)
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
    protected virtual void handle_result(List<TypeFocusHint> result)
      {
      }

    public FieldHoldingArrayGeneratorFocusHint(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFocusHint>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFocusHint()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFocusHint>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFocusHint> value;
  };
        private FieldHoldingGeneratorFocusHint fieldGeneratorFocusHint;
        private JSONHoldingBooleanGenerator fieldGeneratorSendEmailNow;
        private EmailFieldTypeJSON.HoldingGenerator fieldGeneratorLastEditedTextFieldType;
        private EmailContactResultJSON.HoldingArrayGenerator fieldGeneratorNewRecipientsAlreadyInEmail;
        private EmailContactResultJSON.HoldingArrayGenerator fieldGeneratorNewRecipientsNotInEmail;
        private JSONHoldingBooleanGenerator fieldGeneratorEmailAlreadyHadRecipients;
        private JSONHoldingBooleanGenerator fieldGeneratorAlreadyHadRecipients;
        private JSONHoldingBooleanGenerator fieldGeneratorOverwroteSubject;
        private JSONHoldingBooleanGenerator fieldGeneratorOverwroteBody;
        private JSONHoldingStringGenerator fieldGeneratorNewSubject;
        private JSONHoldingStringGenerator fieldGeneratorNewBody;
        private JSONHoldingBooleanGenerator fieldGeneratorAutoListen;
        private JSONHoldingBooleanGenerator fieldGeneratorNotUnderstoodUsedWordTo;
        private JSONHoldingStringGenerator fieldGeneratorNotUnderstoodWords;
    private abstract class FieldGeneratorDeleteType : JSONStringGenerator
          {
            protected FieldGeneratorDeleteType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDeleteType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToDeleteType(result));
              }
            protected abstract void handle_result(TypeDeleteType result);
          };
    private class FieldHoldingGeneratorDeleteType : FieldGeneratorDeleteType
  {
    protected override void handle_result(TypeDeleteType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDeleteType(String what)
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
    public TypeDeleteType value;
  };
    private class FieldHoldingArrayGeneratorDeleteType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDeleteType
      {
        private FieldHoldingArrayGeneratorDeleteType top;

        protected override void handle_result(TypeDeleteType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDeleteType init_top)
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
    protected virtual void handle_result(List<TypeDeleteType> result)
      {
      }

    public FieldHoldingArrayGeneratorDeleteType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDeleteType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDeleteType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDeleteType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDeleteType> value;
  };
        private FieldHoldingGeneratorDeleteType fieldGeneratorDeleteType;
    private class FieldHoldingGeneratorNumToDelete : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorNumToDelete(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumToDelete : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumToDelete(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorNumToDelete fieldGeneratorNumToDelete;
    private class FieldHoldingGeneratorNumDeleted : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorNumDeleted(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumDeleted : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumDeleted(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorNumDeleted fieldGeneratorNumDeleted;
        private JSONHoldingBooleanGenerator fieldGeneratorDeleteFromBack;
        private JSONHoldingBooleanGenerator fieldGeneratorNothingToDelete;
        private EmailFieldTypeJSON.HoldingGenerator fieldGeneratorDeleteFieldType;
        private EmailStateJSON.HoldingGenerator fieldGeneratorState;
    private abstract class FieldGeneratorEditBodyState : JSONStringGenerator
          {
            protected FieldGeneratorEditBodyState(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorEditBodyState()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToEditBodyState(result));
              }
            protected abstract void handle_result(TypeEditBodyState result);
          };
    private class FieldHoldingGeneratorEditBodyState : FieldGeneratorEditBodyState
  {
    protected override void handle_result(TypeEditBodyState result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorEditBodyState(String what)
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
    public TypeEditBodyState value;
  };
    private class FieldHoldingArrayGeneratorEditBodyState : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorEditBodyState
      {
        private FieldHoldingArrayGeneratorEditBodyState top;

        protected override void handle_result(TypeEditBodyState result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorEditBodyState init_top)
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
    protected virtual void handle_result(List<TypeEditBodyState> result)
      {
      }

    public FieldHoldingArrayGeneratorEditBodyState(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeEditBodyState>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorEditBodyState()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeEditBodyState>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeEditBodyState> value;
  };
        private FieldHoldingGeneratorEditBodyState fieldGeneratorEditBodyState;
        private EmailContactResultJSON.HoldingArrayGenerator fieldGeneratorRecipientsAdded;
        private EmailContactResultJSON.HoldingArrayGenerator fieldGeneratorRecipientsRemoved;
        private EmailContactResultJSON.HoldingArrayGenerator fieldGeneratorRecipientsCouldNotAdd;
        private EmailContactResultJSON.HoldingArrayGenerator fieldGeneratorRecipientsCouldNotRemove;
        private EmailContactResultFieldTypeJSON.HoldingGenerator fieldGeneratorOpenEndedEditRequestFieldType;
        private EmailContactResultActionJSON.HoldingGenerator fieldGeneratorOpenEndedEditRequestAction;
        private JSONHoldingBooleanGenerator fieldGeneratorRemovedAllRecipients;
    private abstract class FieldGeneratorNotUnderstoodType : JSONStringGenerator
          {
            protected FieldGeneratorNotUnderstoodType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNotUnderstoodType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToNotUnderstoodType(result));
              }
            protected abstract void handle_result(TypeNotUnderstoodType result);
          };
    private class FieldHoldingGeneratorNotUnderstoodType : FieldGeneratorNotUnderstoodType
  {
    protected override void handle_result(TypeNotUnderstoodType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNotUnderstoodType(String what)
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
    public TypeNotUnderstoodType value;
  };
    private class FieldHoldingArrayGeneratorNotUnderstoodType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNotUnderstoodType
      {
        private FieldHoldingArrayGeneratorNotUnderstoodType top;

        protected override void handle_result(TypeNotUnderstoodType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNotUnderstoodType init_top)
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
    protected virtual void handle_result(List<TypeNotUnderstoodType> result)
      {
      }

    public FieldHoldingArrayGeneratorNotUnderstoodType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNotUnderstoodType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNotUnderstoodType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNotUnderstoodType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNotUnderstoodType> value;
  };
        private FieldHoldingGeneratorNotUnderstoodType fieldGeneratorNotUnderstoodType;
        private JSONHoldingStringGenerator fieldGeneratorNotUnderstoodWordsFound;
        private JSONHoldingBooleanGenerator fieldGeneratorReadRecipients;
        private JSONHoldingBooleanGenerator fieldGeneratorReadSubject;
        private JSONHoldingBooleanGenerator fieldGeneratorReadBody;

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
            ComposeEmailCommandNativeDataJSON result = new ComposeEmailCommandNativeDataJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(ComposeEmailCommandNativeDataJSON result)
          {
            if (fieldGeneratorEmail.have_value)
              {
                result.setEmail(fieldGeneratorEmail.value);
                fieldGeneratorEmail.have_value = false;
              }
            else if ((!(result.hasEmail())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Email\" field was missing.");
              }
            if (fieldGeneratorEmptySubjectOK.have_value)
              {
                result.setEmptySubjectOK(fieldGeneratorEmptySubjectOK.value);
                fieldGeneratorEmptySubjectOK.have_value = false;
              }
            if (fieldGeneratorEmptyBodyOK.have_value)
              {
                result.setEmptyBodyOK(fieldGeneratorEmptyBodyOK.value);
                fieldGeneratorEmptyBodyOK.have_value = false;
              }
            if (fieldGeneratorFocusHint.have_value)
              {
                result.setFocusHint(fieldGeneratorFocusHint.value);
                fieldGeneratorFocusHint.have_value = false;
              }
            if (fieldGeneratorSendEmailNow.have_value)
              {
                result.setSendEmailNow(fieldGeneratorSendEmailNow.value);
                fieldGeneratorSendEmailNow.have_value = false;
              }
            if (fieldGeneratorLastEditedTextFieldType.have_value)
              {
                result.setLastEditedTextFieldType(fieldGeneratorLastEditedTextFieldType.value);
                fieldGeneratorLastEditedTextFieldType.have_value = false;
              }
            if (fieldGeneratorNewRecipientsAlreadyInEmail.have_value)
              {
                result.initNewRecipientsAlreadyInEmail();
                int count = fieldGeneratorNewRecipientsAlreadyInEmail.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNewRecipientsAlreadyInEmail(fieldGeneratorNewRecipientsAlreadyInEmail.value[num]);
                  }
                fieldGeneratorNewRecipientsAlreadyInEmail.value.Clear();
                fieldGeneratorNewRecipientsAlreadyInEmail.have_value = false;
              }
            if (fieldGeneratorNewRecipientsNotInEmail.have_value)
              {
                result.initNewRecipientsNotInEmail();
                int count = fieldGeneratorNewRecipientsNotInEmail.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNewRecipientsNotInEmail(fieldGeneratorNewRecipientsNotInEmail.value[num]);
                  }
                fieldGeneratorNewRecipientsNotInEmail.value.Clear();
                fieldGeneratorNewRecipientsNotInEmail.have_value = false;
              }
            if (fieldGeneratorEmailAlreadyHadRecipients.have_value)
              {
                result.setEmailAlreadyHadRecipients(fieldGeneratorEmailAlreadyHadRecipients.value);
                fieldGeneratorEmailAlreadyHadRecipients.have_value = false;
              }
            if (fieldGeneratorAlreadyHadRecipients.have_value)
              {
                result.setAlreadyHadRecipients(fieldGeneratorAlreadyHadRecipients.value);
                fieldGeneratorAlreadyHadRecipients.have_value = false;
              }
            if (fieldGeneratorOverwroteSubject.have_value)
              {
                result.setOverwroteSubject(fieldGeneratorOverwroteSubject.value);
                fieldGeneratorOverwroteSubject.have_value = false;
              }
            if (fieldGeneratorOverwroteBody.have_value)
              {
                result.setOverwroteBody(fieldGeneratorOverwroteBody.value);
                fieldGeneratorOverwroteBody.have_value = false;
              }
            if (fieldGeneratorNewSubject.have_value)
              {
                result.setNewSubject(fieldGeneratorNewSubject.value);
                fieldGeneratorNewSubject.have_value = false;
              }
            if (fieldGeneratorNewBody.have_value)
              {
                result.setNewBody(fieldGeneratorNewBody.value);
                fieldGeneratorNewBody.have_value = false;
              }
            if (fieldGeneratorAutoListen.have_value)
              {
                result.setAutoListen(fieldGeneratorAutoListen.value);
                fieldGeneratorAutoListen.have_value = false;
              }
            if (fieldGeneratorNotUnderstoodUsedWordTo.have_value)
              {
                result.setNotUnderstoodUsedWordTo(fieldGeneratorNotUnderstoodUsedWordTo.value);
                fieldGeneratorNotUnderstoodUsedWordTo.have_value = false;
              }
            if (fieldGeneratorNotUnderstoodWords.have_value)
              {
                result.setNotUnderstoodWords(fieldGeneratorNotUnderstoodWords.value);
                fieldGeneratorNotUnderstoodWords.have_value = false;
              }
            if (fieldGeneratorDeleteType.have_value)
              {
                result.setDeleteType(fieldGeneratorDeleteType.value);
                fieldGeneratorDeleteType.have_value = false;
              }
            if (fieldGeneratorNumToDelete.have_value)
              {
                result.setNumToDelete(fieldGeneratorNumToDelete.value);
                fieldGeneratorNumToDelete.have_value = false;
              }
            if (fieldGeneratorNumDeleted.have_value)
              {
                result.setNumDeleted(fieldGeneratorNumDeleted.value);
                fieldGeneratorNumDeleted.have_value = false;
              }
            if (fieldGeneratorDeleteFromBack.have_value)
              {
                result.setDeleteFromBack(fieldGeneratorDeleteFromBack.value);
                fieldGeneratorDeleteFromBack.have_value = false;
              }
            if (fieldGeneratorNothingToDelete.have_value)
              {
                result.setNothingToDelete(fieldGeneratorNothingToDelete.value);
                fieldGeneratorNothingToDelete.have_value = false;
              }
            if (fieldGeneratorDeleteFieldType.have_value)
              {
                result.setDeleteFieldType(fieldGeneratorDeleteFieldType.value);
                fieldGeneratorDeleteFieldType.have_value = false;
              }
            if (fieldGeneratorState.have_value)
              {
                result.setState(fieldGeneratorState.value);
                fieldGeneratorState.have_value = false;
              }
            else if ((!(result.hasState())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"State\" field was missing.");
              }
            if (fieldGeneratorEditBodyState.have_value)
              {
                result.setEditBodyState(fieldGeneratorEditBodyState.value);
                fieldGeneratorEditBodyState.have_value = false;
              }
            if (fieldGeneratorRecipientsAdded.have_value)
              {
                result.initRecipientsAdded();
                int count = fieldGeneratorRecipientsAdded.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRecipientsAdded(fieldGeneratorRecipientsAdded.value[num]);
                  }
                fieldGeneratorRecipientsAdded.value.Clear();
                fieldGeneratorRecipientsAdded.have_value = false;
              }
            if (fieldGeneratorRecipientsRemoved.have_value)
              {
                result.initRecipientsRemoved();
                int count = fieldGeneratorRecipientsRemoved.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRecipientsRemoved(fieldGeneratorRecipientsRemoved.value[num]);
                  }
                fieldGeneratorRecipientsRemoved.value.Clear();
                fieldGeneratorRecipientsRemoved.have_value = false;
              }
            if (fieldGeneratorRecipientsCouldNotAdd.have_value)
              {
                result.initRecipientsCouldNotAdd();
                int count = fieldGeneratorRecipientsCouldNotAdd.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRecipientsCouldNotAdd(fieldGeneratorRecipientsCouldNotAdd.value[num]);
                  }
                fieldGeneratorRecipientsCouldNotAdd.value.Clear();
                fieldGeneratorRecipientsCouldNotAdd.have_value = false;
              }
            if (fieldGeneratorRecipientsCouldNotRemove.have_value)
              {
                result.initRecipientsCouldNotRemove();
                int count = fieldGeneratorRecipientsCouldNotRemove.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRecipientsCouldNotRemove(fieldGeneratorRecipientsCouldNotRemove.value[num]);
                  }
                fieldGeneratorRecipientsCouldNotRemove.value.Clear();
                fieldGeneratorRecipientsCouldNotRemove.have_value = false;
              }
            if (fieldGeneratorOpenEndedEditRequestFieldType.have_value)
              {
                result.setOpenEndedEditRequestFieldType(fieldGeneratorOpenEndedEditRequestFieldType.value);
                fieldGeneratorOpenEndedEditRequestFieldType.have_value = false;
              }
            if (fieldGeneratorOpenEndedEditRequestAction.have_value)
              {
                result.setOpenEndedEditRequestAction(fieldGeneratorOpenEndedEditRequestAction.value);
                fieldGeneratorOpenEndedEditRequestAction.have_value = false;
              }
            if (fieldGeneratorRemovedAllRecipients.have_value)
              {
                result.setRemovedAllRecipients(fieldGeneratorRemovedAllRecipients.value);
                fieldGeneratorRemovedAllRecipients.have_value = false;
              }
            if (fieldGeneratorNotUnderstoodType.have_value)
              {
                result.setNotUnderstoodType(fieldGeneratorNotUnderstoodType.value);
                fieldGeneratorNotUnderstoodType.have_value = false;
              }
            if (fieldGeneratorNotUnderstoodWordsFound.have_value)
              {
                result.setNotUnderstoodWordsFound(fieldGeneratorNotUnderstoodWordsFound.value);
                fieldGeneratorNotUnderstoodWordsFound.have_value = false;
              }
            if (fieldGeneratorReadRecipients.have_value)
              {
                result.setReadRecipients(fieldGeneratorReadRecipients.value);
                fieldGeneratorReadRecipients.have_value = false;
              }
            if (fieldGeneratorReadSubject.have_value)
              {
                result.setReadSubject(fieldGeneratorReadSubject.value);
                fieldGeneratorReadSubject.have_value = false;
              }
            if (fieldGeneratorReadBody.have_value)
              {
                result.setReadBody(fieldGeneratorReadBody.value);
                fieldGeneratorReadBody.have_value = false;
              }
          }
        protected abstract void handle_result(ComposeEmailCommandNativeDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "readyHadRecipients", 0, 18, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorAlreadyHadRecipients;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "toListen", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorAutoListen;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "elete", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'F':
                                switch (field_name[7])
                                  {
                                    case 'i':
                                        if ((String.Compare(field_name, 8, "eldType", 0, 7, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorDeleteFieldType;
                                        break;
                                    case 'r':
                                        if ((String.Compare(field_name, 8, "omBack", 0, 6, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorDeleteFromBack;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 7, "ype", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorDeleteType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    switch (field_name[1])
                      {
                        case 'd':
                            if ((String.Compare(field_name, 2, "itBodyState", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorEditBodyState;
                            break;
                        case 'm':
                            switch (field_name[2])
                              {
                                case 'a':
                                    if (String.Compare(field_name, 3, "il", 0, 2, false) == 0)
                                      {
                                        if (field_name.Length == 5)
                                          {
                                            return fieldGeneratorEmail;
                                          }
                                        switch (field_name[5])
                                          {
                                            case 'A':
                                                if ((String.Compare(field_name, 6, "lreadyHadRecipients", 0, 19, false) == 0) && (field_name.Length == 25))
                                                    return fieldGeneratorEmailAlreadyHadRecipients;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'p':
                                    if (String.Compare(field_name, 3, "ty", 0, 2, false) == 0)
                                      {
                                        switch (field_name[5])
                                          {
                                            case 'B':
                                                if ((String.Compare(field_name, 6, "odyOK", 0, 5, false) == 0) && (field_name.Length == 11))
                                                    return fieldGeneratorEmptyBodyOK;
                                                break;
                                            case 'S':
                                                if ((String.Compare(field_name, 6, "ubjectOK", 0, 8, false) == 0) && (field_name.Length == 14))
                                                    return fieldGeneratorEmptySubjectOK;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "ocusHint", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorFocusHint;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astEditedTextFieldType", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorLastEditedTextFieldType;
                    break;
                case 'N':
                    switch (field_name[1])
                      {
                        case 'e':
                            if (String.Compare(field_name, 2, "w", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'B':
                                        if ((String.Compare(field_name, 4, "ody", 0, 3, false) == 0) && (field_name.Length == 7))
                                            return fieldGeneratorNewBody;
                                        break;
                                    case 'R':
                                        if (String.Compare(field_name, 4, "ecipients", 0, 9, false) == 0)
                                          {
                                            switch (field_name[13])
                                              {
                                                case 'A':
                                                    if ((String.Compare(field_name, 14, "lreadyInEmail", 0, 13, false) == 0) && (field_name.Length == 27))
                                                        return fieldGeneratorNewRecipientsAlreadyInEmail;
                                                    break;
                                                case 'N':
                                                    if ((String.Compare(field_name, 14, "otInEmail", 0, 9, false) == 0) && (field_name.Length == 23))
                                                        return fieldGeneratorNewRecipientsNotInEmail;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 4, "ubject", 0, 6, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorNewSubject;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "t", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'U':
                                        if (String.Compare(field_name, 4, "nderstood", 0, 9, false) == 0)
                                          {
                                            switch (field_name[13])
                                              {
                                                case 'T':
                                                    if ((String.Compare(field_name, 14, "ype", 0, 3, false) == 0) && (field_name.Length == 17))
                                                        return fieldGeneratorNotUnderstoodType;
                                                    break;
                                                case 'U':
                                                    if ((String.Compare(field_name, 14, "sedWordTo", 0, 9, false) == 0) && (field_name.Length == 23))
                                                        return fieldGeneratorNotUnderstoodUsedWordTo;
                                                    break;
                                                case 'W':
                                                    if (String.Compare(field_name, 14, "ords", 0, 4, false) == 0)
                                                      {
                                                        if (field_name.Length == 18)
                                                          {
                                                            return fieldGeneratorNotUnderstoodWords;
                                                          }
                                                        switch (field_name[18])
                                                          {
                                                            case 'F':
                                                                if ((String.Compare(field_name, 19, "ound", 0, 4, false) == 0) && (field_name.Length == 23))
                                                                    return fieldGeneratorNotUnderstoodWordsFound;
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
                                    case 'h':
                                        if ((String.Compare(field_name, 4, "ingToDelete", 0, 11, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorNothingToDelete;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'u':
                            if (String.Compare(field_name, 2, "m", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 4, "eleted", 0, 6, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorNumDeleted;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 4, "oDelete", 0, 7, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorNumToDelete;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'O':
                    switch (field_name[1])
                      {
                        case 'p':
                            if (String.Compare(field_name, 2, "enEndedEditRequest", 0, 18, false) == 0)
                              {
                                switch (field_name[20])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 21, "ction", 0, 5, false) == 0) && (field_name.Length == 26))
                                            return fieldGeneratorOpenEndedEditRequestAction;
                                        break;
                                    case 'F':
                                        if ((String.Compare(field_name, 21, "ieldType", 0, 8, false) == 0) && (field_name.Length == 29))
                                            return fieldGeneratorOpenEndedEditRequestFieldType;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'v':
                            if (String.Compare(field_name, 2, "erwrote", 0, 7, false) == 0)
                              {
                                switch (field_name[9])
                                  {
                                    case 'B':
                                        if ((String.Compare(field_name, 10, "ody", 0, 3, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorOverwroteBody;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 10, "ubject", 0, 6, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorOverwroteSubject;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'a':
                                if (String.Compare(field_name, 3, "d", 0, 1, false) == 0)
                                  {
                                    switch (field_name[4])
                                      {
                                        case 'B':
                                            if ((String.Compare(field_name, 5, "ody", 0, 3, false) == 0) && (field_name.Length == 8))
                                                return fieldGeneratorReadBody;
                                            break;
                                        case 'R':
                                            if ((String.Compare(field_name, 5, "ecipients", 0, 9, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorReadRecipients;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 5, "ubject", 0, 6, false) == 0) && (field_name.Length == 11))
                                                return fieldGeneratorReadSubject;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'c':
                                if (String.Compare(field_name, 3, "ipients", 0, 7, false) == 0)
                                  {
                                    switch (field_name[10])
                                      {
                                        case 'A':
                                            if ((String.Compare(field_name, 11, "dded", 0, 4, false) == 0) && (field_name.Length == 15))
                                                return fieldGeneratorRecipientsAdded;
                                            break;
                                        case 'C':
                                            if (String.Compare(field_name, 11, "ouldNot", 0, 7, false) == 0)
                                              {
                                                switch (field_name[18])
                                                  {
                                                    case 'A':
                                                        if ((String.Compare(field_name, 19, "dd", 0, 2, false) == 0) && (field_name.Length == 21))
                                                            return fieldGeneratorRecipientsCouldNotAdd;
                                                        break;
                                                    case 'R':
                                                        if ((String.Compare(field_name, 19, "emove", 0, 5, false) == 0) && (field_name.Length == 24))
                                                            return fieldGeneratorRecipientsCouldNotRemove;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'R':
                                            if ((String.Compare(field_name, 11, "emoved", 0, 6, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratorRecipientsRemoved;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'm':
                                if ((String.Compare(field_name, 3, "ovedAllRecipients", 0, 17, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorRemovedAllRecipients;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "ndEmailNow", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorSendEmailNow;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "ate", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorState;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorEmail = new EmailJSON.HoldingGenerator("field \"Email\" of the ComposeEmailCommandNativeData class", ignore_extras);
            fieldGeneratorEmptySubjectOK = new JSONHoldingBooleanGenerator("field \"EmptySubjectOK\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorEmptyBodyOK = new JSONHoldingBooleanGenerator("field \"EmptyBodyOK\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorFocusHint = new FieldHoldingGeneratorFocusHint("field \"FocusHint\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorSendEmailNow = new JSONHoldingBooleanGenerator("field \"SendEmailNow\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorLastEditedTextFieldType = new EmailFieldTypeJSON.HoldingGenerator("field \"LastEditedTextFieldType\" of the ComposeEmailCommandNativeData class", ignore_extras);
            fieldGeneratorNewRecipientsAlreadyInEmail = new EmailContactResultJSON.HoldingArrayGenerator("field \"NewRecipientsAlreadyInEmail\" of the ComposeEmailCommandNativeData class", ignore_extras);
            fieldGeneratorNewRecipientsNotInEmail = new EmailContactResultJSON.HoldingArrayGenerator("field \"NewRecipientsNotInEmail\" of the ComposeEmailCommandNativeData class", ignore_extras);
            fieldGeneratorEmailAlreadyHadRecipients = new JSONHoldingBooleanGenerator("field \"EmailAlreadyHadRecipients\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorAlreadyHadRecipients = new JSONHoldingBooleanGenerator("field \"AlreadyHadRecipients\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorOverwroteSubject = new JSONHoldingBooleanGenerator("field \"OverwroteSubject\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorOverwroteBody = new JSONHoldingBooleanGenerator("field \"OverwroteBody\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNewSubject = new JSONHoldingStringGenerator("field \"NewSubject\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNewBody = new JSONHoldingStringGenerator("field \"NewBody\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorAutoListen = new JSONHoldingBooleanGenerator("field \"AutoListen\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNotUnderstoodUsedWordTo = new JSONHoldingBooleanGenerator("field \"NotUnderstoodUsedWordTo\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNotUnderstoodWords = new JSONHoldingStringGenerator("field \"NotUnderstoodWords\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorDeleteType = new FieldHoldingGeneratorDeleteType("field \"DeleteType\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNumToDelete = new FieldHoldingGeneratorNumToDelete("field \"NumToDelete\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNumDeleted = new FieldHoldingGeneratorNumDeleted("field \"NumDeleted\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorDeleteFromBack = new JSONHoldingBooleanGenerator("field \"DeleteFromBack\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNothingToDelete = new JSONHoldingBooleanGenerator("field \"NothingToDelete\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorDeleteFieldType = new EmailFieldTypeJSON.HoldingGenerator("field \"DeleteFieldType\" of the ComposeEmailCommandNativeData class", ignore_extras);
            fieldGeneratorState = new EmailStateJSON.HoldingGenerator("field \"State\" of the ComposeEmailCommandNativeData class", ignore_extras);
            fieldGeneratorEditBodyState = new FieldHoldingGeneratorEditBodyState("field \"EditBodyState\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorRecipientsAdded = new EmailContactResultJSON.HoldingArrayGenerator("field \"RecipientsAdded\" of the ComposeEmailCommandNativeData class", ignore_extras);
            fieldGeneratorRecipientsRemoved = new EmailContactResultJSON.HoldingArrayGenerator("field \"RecipientsRemoved\" of the ComposeEmailCommandNativeData class", ignore_extras);
            fieldGeneratorRecipientsCouldNotAdd = new EmailContactResultJSON.HoldingArrayGenerator("field \"RecipientsCouldNotAdd\" of the ComposeEmailCommandNativeData class", ignore_extras);
            fieldGeneratorRecipientsCouldNotRemove = new EmailContactResultJSON.HoldingArrayGenerator("field \"RecipientsCouldNotRemove\" of the ComposeEmailCommandNativeData class", ignore_extras);
            fieldGeneratorOpenEndedEditRequestFieldType = new EmailContactResultFieldTypeJSON.HoldingGenerator("field \"OpenEndedEditRequestFieldType\" of the ComposeEmailCommandNativeData class", ignore_extras);
            fieldGeneratorOpenEndedEditRequestAction = new EmailContactResultActionJSON.HoldingGenerator("field \"OpenEndedEditRequestAction\" of the ComposeEmailCommandNativeData class", ignore_extras);
            fieldGeneratorRemovedAllRecipients = new JSONHoldingBooleanGenerator("field \"RemovedAllRecipients\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNotUnderstoodType = new FieldHoldingGeneratorNotUnderstoodType("field \"NotUnderstoodType\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNotUnderstoodWordsFound = new JSONHoldingStringGenerator("field \"NotUnderstoodWordsFound\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorReadRecipients = new JSONHoldingBooleanGenerator("field \"ReadRecipients\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorReadSubject = new JSONHoldingBooleanGenerator("field \"ReadSubject\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorReadBody = new JSONHoldingBooleanGenerator("field \"ReadBody\" of the ComposeEmailCommandNativeData class");
            set_what("the ComposeEmailCommandNativeData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorEmail = new EmailJSON.HoldingGenerator("field \"Email\" of the ComposeEmailCommandNativeData class", false);
            fieldGeneratorEmptySubjectOK = new JSONHoldingBooleanGenerator("field \"EmptySubjectOK\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorEmptyBodyOK = new JSONHoldingBooleanGenerator("field \"EmptyBodyOK\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorFocusHint = new FieldHoldingGeneratorFocusHint("field \"FocusHint\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorSendEmailNow = new JSONHoldingBooleanGenerator("field \"SendEmailNow\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorLastEditedTextFieldType = new EmailFieldTypeJSON.HoldingGenerator("field \"LastEditedTextFieldType\" of the ComposeEmailCommandNativeData class", false);
            fieldGeneratorNewRecipientsAlreadyInEmail = new EmailContactResultJSON.HoldingArrayGenerator("field \"NewRecipientsAlreadyInEmail\" of the ComposeEmailCommandNativeData class", false);
            fieldGeneratorNewRecipientsNotInEmail = new EmailContactResultJSON.HoldingArrayGenerator("field \"NewRecipientsNotInEmail\" of the ComposeEmailCommandNativeData class", false);
            fieldGeneratorEmailAlreadyHadRecipients = new JSONHoldingBooleanGenerator("field \"EmailAlreadyHadRecipients\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorAlreadyHadRecipients = new JSONHoldingBooleanGenerator("field \"AlreadyHadRecipients\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorOverwroteSubject = new JSONHoldingBooleanGenerator("field \"OverwroteSubject\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorOverwroteBody = new JSONHoldingBooleanGenerator("field \"OverwroteBody\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNewSubject = new JSONHoldingStringGenerator("field \"NewSubject\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNewBody = new JSONHoldingStringGenerator("field \"NewBody\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorAutoListen = new JSONHoldingBooleanGenerator("field \"AutoListen\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNotUnderstoodUsedWordTo = new JSONHoldingBooleanGenerator("field \"NotUnderstoodUsedWordTo\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNotUnderstoodWords = new JSONHoldingStringGenerator("field \"NotUnderstoodWords\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorDeleteType = new FieldHoldingGeneratorDeleteType("field \"DeleteType\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNumToDelete = new FieldHoldingGeneratorNumToDelete("field \"NumToDelete\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNumDeleted = new FieldHoldingGeneratorNumDeleted("field \"NumDeleted\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorDeleteFromBack = new JSONHoldingBooleanGenerator("field \"DeleteFromBack\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNothingToDelete = new JSONHoldingBooleanGenerator("field \"NothingToDelete\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorDeleteFieldType = new EmailFieldTypeJSON.HoldingGenerator("field \"DeleteFieldType\" of the ComposeEmailCommandNativeData class", false);
            fieldGeneratorState = new EmailStateJSON.HoldingGenerator("field \"State\" of the ComposeEmailCommandNativeData class", false);
            fieldGeneratorEditBodyState = new FieldHoldingGeneratorEditBodyState("field \"EditBodyState\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorRecipientsAdded = new EmailContactResultJSON.HoldingArrayGenerator("field \"RecipientsAdded\" of the ComposeEmailCommandNativeData class", false);
            fieldGeneratorRecipientsRemoved = new EmailContactResultJSON.HoldingArrayGenerator("field \"RecipientsRemoved\" of the ComposeEmailCommandNativeData class", false);
            fieldGeneratorRecipientsCouldNotAdd = new EmailContactResultJSON.HoldingArrayGenerator("field \"RecipientsCouldNotAdd\" of the ComposeEmailCommandNativeData class", false);
            fieldGeneratorRecipientsCouldNotRemove = new EmailContactResultJSON.HoldingArrayGenerator("field \"RecipientsCouldNotRemove\" of the ComposeEmailCommandNativeData class", false);
            fieldGeneratorOpenEndedEditRequestFieldType = new EmailContactResultFieldTypeJSON.HoldingGenerator("field \"OpenEndedEditRequestFieldType\" of the ComposeEmailCommandNativeData class", false);
            fieldGeneratorOpenEndedEditRequestAction = new EmailContactResultActionJSON.HoldingGenerator("field \"OpenEndedEditRequestAction\" of the ComposeEmailCommandNativeData class", false);
            fieldGeneratorRemovedAllRecipients = new JSONHoldingBooleanGenerator("field \"RemovedAllRecipients\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNotUnderstoodType = new FieldHoldingGeneratorNotUnderstoodType("field \"NotUnderstoodType\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorNotUnderstoodWordsFound = new JSONHoldingStringGenerator("field \"NotUnderstoodWordsFound\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorReadRecipients = new JSONHoldingBooleanGenerator("field \"ReadRecipients\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorReadSubject = new JSONHoldingBooleanGenerator("field \"ReadSubject\" of the ComposeEmailCommandNativeData class");
            fieldGeneratorReadBody = new JSONHoldingBooleanGenerator("field \"ReadBody\" of the ComposeEmailCommandNativeData class");
            set_what("the ComposeEmailCommandNativeData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorEmail.reset();
            fieldGeneratorEmptySubjectOK.reset();
            fieldGeneratorEmptyBodyOK.reset();
            fieldGeneratorFocusHint.reset();
            fieldGeneratorSendEmailNow.reset();
            fieldGeneratorLastEditedTextFieldType.reset();
            fieldGeneratorNewRecipientsAlreadyInEmail.reset();
            fieldGeneratorNewRecipientsNotInEmail.reset();
            fieldGeneratorEmailAlreadyHadRecipients.reset();
            fieldGeneratorAlreadyHadRecipients.reset();
            fieldGeneratorOverwroteSubject.reset();
            fieldGeneratorOverwroteBody.reset();
            fieldGeneratorNewSubject.reset();
            fieldGeneratorNewBody.reset();
            fieldGeneratorAutoListen.reset();
            fieldGeneratorNotUnderstoodUsedWordTo.reset();
            fieldGeneratorNotUnderstoodWords.reset();
            fieldGeneratorDeleteType.reset();
            fieldGeneratorNumToDelete.reset();
            fieldGeneratorNumDeleted.reset();
            fieldGeneratorDeleteFromBack.reset();
            fieldGeneratorNothingToDelete.reset();
            fieldGeneratorDeleteFieldType.reset();
            fieldGeneratorState.reset();
            fieldGeneratorEditBodyState.reset();
            fieldGeneratorRecipientsAdded.reset();
            fieldGeneratorRecipientsRemoved.reset();
            fieldGeneratorRecipientsCouldNotAdd.reset();
            fieldGeneratorRecipientsCouldNotRemove.reset();
            fieldGeneratorOpenEndedEditRequestFieldType.reset();
            fieldGeneratorOpenEndedEditRequestAction.reset();
            fieldGeneratorRemovedAllRecipients.reset();
            fieldGeneratorNotUnderstoodType.reset();
            fieldGeneratorNotUnderstoodWordsFound.reset();
            fieldGeneratorReadRecipients.reset();
            fieldGeneratorReadSubject.reset();
            fieldGeneratorReadBody.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorEmail.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLastEditedTextFieldType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNewRecipientsAlreadyInEmail.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNewRecipientsNotInEmail.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDeleteFieldType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorState.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRecipientsAdded.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRecipientsRemoved.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRecipientsCouldNotAdd.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRecipientsCouldNotRemove.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOpenEndedEditRequestFieldType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOpenEndedEditRequestAction.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorEmail.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLastEditedTextFieldType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNewRecipientsAlreadyInEmail.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNewRecipientsNotInEmail.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDeleteFieldType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorState.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRecipientsAdded.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRecipientsRemoved.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRecipientsCouldNotAdd.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRecipientsCouldNotRemove.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOpenEndedEditRequestFieldType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOpenEndedEditRequestAction.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ComposeEmailCommandNativeDataJSON  result)
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
        public ComposeEmailCommandNativeDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ComposeEmailCommandNativeDataJSON  result)
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
    protected virtual void handle_result(List<ComposeEmailCommandNativeDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ComposeEmailCommandNativeDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ComposeEmailCommandNativeDataJSON>();
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
    public List<ComposeEmailCommandNativeDataJSON> value;
  };
  };
