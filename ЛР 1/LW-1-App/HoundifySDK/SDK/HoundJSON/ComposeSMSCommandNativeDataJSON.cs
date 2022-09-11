/* file "ComposeSMSCommandNativeDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ComposeSMSCommandNativeDataJSON : JSONBase
  {
    public enum TypeFocusHint
      {
        FocusHint_To,
        FocusHint_Body
      };

    public static TypeFocusHint  stringToFocusHint(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "ody", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeFocusHint.FocusHint_Body;
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
            case TypeFocusHint.FocusHint_Body:
                return "Body";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeNewRecipientsInfoJSON : JSONBase
      {
        private bool flagHasSpokenName;
        private string storeSpokenName;
        private bool flagHasWrittenName;
        private string storeWrittenName;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONSpokenName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field SpokenName of TypeNewRecipientsInfoJSON is not a string.");
            setSpokenName(json_string.getData());
          }


        private void  fromJSONWrittenName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field WrittenName of TypeNewRecipientsInfoJSON is not a string.");
            setWrittenName(json_string.getData());
          }


        public TypeNewRecipientsInfoJSON()
          {
            flagHasSpokenName = false;
            flagHasWrittenName = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasSpokenName()
          {
            return flagHasSpokenName;
          }

        public string  getSpokenName()
          {
            Debug.Assert(flagHasSpokenName);
            return storeSpokenName;
          }

        public bool  hasWrittenName()
          {
            return flagHasWrittenName;
          }

        public string  getWrittenName()
          {
            Debug.Assert(flagHasWrittenName);
            return storeWrittenName;
          }


        public virtual int extraTypeNewRecipientsInfoComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNewRecipientsInfoComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNewRecipientsInfoComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNewRecipientsInfoLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setSpokenName(string new_value)
          {
            flagHasSpokenName = true;
            storeSpokenName = new_value;
          }
        public void unsetSpokenName()
          {
            flagHasSpokenName = false;
          }
        public void setWrittenName(string new_value)
          {
            flagHasWrittenName = true;
            storeWrittenName = new_value;
          }
        public void unsetWrittenName()
          {
            flagHasWrittenName = false;
          }

        public virtual void extraTypeNewRecipientsInfoAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNewRecipientsInfoSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNewRecipientsInfoLookup(key);
            if (old_field == null)
              {
                extraTypeNewRecipientsInfoAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals( key))
                      {
                        extraValues[num] = new_component;
                        break;
                      }
                  }
                extraIndex.Add(key, new_component);
              }
          }

        public override void write_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler);
            int extra_count = extraKeys.Count;
            Debug.Assert(extra_count == extraValues.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                handler.start_pair(extraKeys[extra_num]);
                extraValues[extra_num].write(handler);
              }
            handler.finish_object();
          }

        public virtual void write_fields_as_json(JSONHandler handler)
          {
            write_fields_as_json(handler, false);
          }

        public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
          {
            Debug.Assert(partial_allowed || flagHasSpokenName);
            if (flagHasSpokenName)
              {
                handler.start_pair("SpokenName");
                handler.string_value(storeSpokenName);
              }
            Debug.Assert(partial_allowed || flagHasWrittenName);
            if (flagHasWrittenName)
              {
                handler.start_pair("WrittenName");
                handler.string_value(storeWrittenName);
              }
          }
        public override void write_partial_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler, true);
            int extra_count = extraKeys.Count;
            Debug.Assert(extra_count == extraValues.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                handler.start_pair(extraKeys[extra_num]);
                extraValues[extra_num].write(handler);
              }
            handler.finish_object();
          }
        public virtual string missing_field_error(bool allow_unpolished)
          {
            if (!(hasSpokenName()))
              {
                return "When parsing the object for %what%, the \"SpokenName\" field was missing.";
              }
            if (!(hasWrittenName()))
              {
                return "When parsing the object for %what%, the \"WrittenName\" field was missing.";
              }
            return null;
          }

        public static TypeNewRecipientsInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNewRecipientsInfoJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNewRecipientsInfo", ignore_extras);
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
        public static TypeNewRecipientsInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNewRecipientsInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNewRecipientsInfoJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNewRecipientsInfo", ignore_extras);
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
        public static TypeNewRecipientsInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNewRecipientsInfoJSON from_text(string text, bool ignore_extras)
          {
            TypeNewRecipientsInfoJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNewRecipientsInfo", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNewRecipientsInfoJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNewRecipientsInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNewRecipientsInfoJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNewRecipientsInfo", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorSpokenName;
            private JSONHoldingStringGenerator fieldGeneratorWrittenName;
            private class UnknownFieldGenerator : JSONValueHandler
              {
                public bool ignore;
                public List<string> field_names;
                public List<JSONValue > field_values;
                public Dictionary<string, JSONValue > index;
                public UnknownFieldGenerator(bool init_ignore)
                  {
                    ignore = init_ignore;
                    field_names = new List<string>();
                    field_values = new List<JSONValue >();
                index = new Dictionary<string, JSONValue >();
                  }

                protected override void new_value(JSONValue item)
                  {
                    if (ignore)
                        return;
                    Debug.Assert(field_names.Count == (field_values.Count + 1));
                    index.Add(field_names[field_values.Count], item);
                    field_values.Add(item);
                  }
                public override void reset()
                  {
                    field_names.Clear();
                    field_values.Clear();
                index = new Dictionary<string, JSONValue >();
                  }
              };
            private UnknownFieldGenerator unknownFieldGenerator;

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
                Debug.Assert(unknownFieldGenerator.field_names.Count ==
                       unknownFieldGenerator.field_values.Count);
                if (unknownFieldGenerator.ignore)
                  {
                    Debug.Assert(unknownFieldGenerator.field_names.Count == 0);
                  }
                else
                  {
                    unknownFieldGenerator.field_names.Add(field_name);
                  }
                return unknownFieldGenerator;
              }
            protected override void finish_field(string field_name, JSONHandler field_handler)
              {
              }
            protected override void finish()
              {
                TypeNewRecipientsInfoJSON result = new TypeNewRecipientsInfoJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNewRecipientsInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNewRecipientsInfoJSON result)
              {
                if (fieldGeneratorSpokenName.have_value)
                  {
                    result.setSpokenName(fieldGeneratorSpokenName.value);
                    fieldGeneratorSpokenName.have_value = false;
                  }
                else if ((!(result.hasSpokenName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"SpokenName\" field was missing.");
                  }
                if (fieldGeneratorWrittenName.have_value)
                  {
                    result.setWrittenName(fieldGeneratorWrittenName.value);
                    fieldGeneratorWrittenName.have_value = false;
                  }
                else if ((!(result.hasWrittenName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"WrittenName\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeNewRecipientsInfoJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'S':
                        if ((String.Compare(field_name, 1, "pokenName", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorSpokenName;
                        break;
                    case 'W':
                        if ((String.Compare(field_name, 1, "rittenName", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorWrittenName;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the TypeNewRecipientsInfo class");
                fieldGeneratorWrittenName = new JSONHoldingStringGenerator("field \"WrittenName\" of the TypeNewRecipientsInfo class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNewRecipientsInfo class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the TypeNewRecipientsInfo class");
                fieldGeneratorWrittenName = new JSONHoldingStringGenerator("field \"WrittenName\" of the TypeNewRecipientsInfo class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNewRecipientsInfo class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorSpokenName.reset();
                fieldGeneratorWrittenName.reset();
                base.reset();
                unknownFieldGenerator.reset();
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
            protected override void handle_result(TypeNewRecipientsInfoJSON  result)
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
            public TypeNewRecipientsInfoJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNewRecipientsInfoJSON  result)
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
        protected virtual void handle_result(List<TypeNewRecipientsInfoJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNewRecipientsInfoJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNewRecipientsInfoJSON>();
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
        public List<TypeNewRecipientsInfoJSON> value;
      };
      };
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
        NotUnderstoodType_SMS_PHONE_NUMBER,
        NotUnderstoodType_YES_NO,
        NotUnderstoodType_UNKNOWN
      };

    public static TypeNotUnderstoodType  stringToNotUnderstoodType(string chars)
      {
        switch (chars[0])
          {
            case 'S':
                if ((String.Compare(chars, 1, "MS_PHONE_NUMBER", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeNotUnderstoodType.NotUnderstoodType_SMS_PHONE_NUMBER;
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
            case TypeNotUnderstoodType.NotUnderstoodType_SMS_PHONE_NUMBER:
                return "SMS_PHONE_NUMBER";
            case TypeNotUnderstoodType.NotUnderstoodType_YES_NO:
                return "YES_NO";
            case TypeNotUnderstoodType.NotUnderstoodType_UNKNOWN:
                return "UNKNOWN";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasSMS;
    private SMSJSON  storeSMS;
    private bool flagHasEmptyBodyOK;
    private bool storeEmptyBodyOK;
    private bool flagHasFocusHint;
    private TypeFocusHint storeFocusHint;
    private bool flagHasSendSMSNow;
    private bool storeSendSMSNow;
    private bool flagHasLastEditedTextFieldType;
    private SMSFieldTypeJSON  storeLastEditedTextFieldType;
    private bool flagHasSMSAlreadyHadRecipients;
    private bool storeSMSAlreadyHadRecipients;
    private bool flagHasNewBody;
    private string storeNewBody;
    private bool flagHasNewRecipientsInfo;
    private List< TypeNewRecipientsInfoJSON  > storeNewRecipientsInfo;
    private bool flagHasSpokenMessageFromPreviousTransaction;
    private string storeSpokenMessageFromPreviousTransaction;
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
    private bool flagHasState;
    private SMSStateJSON  storeState;
    private bool flagHasEditBodyState;
    private TypeEditBodyState storeEditBodyState;
    private bool flagHasFirstTimeAddingToBody;
    private bool storeFirstTimeAddingToBody;
    private bool flagHasRecipientsAdded;
    private List< UnambiguousSMSRecipientJSON  > storeRecipientsAdded;
    private bool flagHasRecipientsRemoved;
    private List< UnambiguousSMSRecipientJSON  > storeRecipientsRemoved;
    private bool flagHasRecipientsCouldNotAdd;
    private List< UnambiguousSMSRecipientJSON  > storeRecipientsCouldNotAdd;
    private bool flagHasRecipientsCouldNotRemove;
    private List< SMSRecipientsJSON  > storeRecipientsCouldNotRemove;
    private bool flagHasOpenEndedEditRequest;
    private bool storeOpenEndedEditRequest;
    private bool flagHasOpenEndedEditRequestAction;
    private SMSContactResultActionJSON  storeOpenEndedEditRequestAction;
    private bool flagHasRemovedAllRecipients;
    private bool storeRemovedAllRecipients;
    private bool flagHasAlreadyHadRecipients;
    private bool storeAlreadyHadRecipients;
    private bool flagHasNotUnderstoodType;
    private TypeNotUnderstoodType storeNotUnderstoodType;
    private bool flagHasNotUnderstoodWordsFound;
    private string storeNotUnderstoodWordsFound;
    private bool flagHasReadRecipients;
    private bool storeReadRecipients;
    private bool flagHasReadBody;
    private bool storeReadBody;
    private bool flagHasWordsToReplace;
    private string storeWordsToReplace;
    private bool flagHasReplacementWords;
    private string storeReplacementWords;
    private bool flagHasReplaceAll;
    private bool storeReplaceAll;
    private bool flagHasReplacementStartIndices;
    private List< BigInteger > storeReplacementStartIndices;
    private bool flagHasWordsToMatchForInsertion;
    private string storeWordsToMatchForInsertion;
    private bool flagHasInsertionWords;
    private string storeInsertionWords;
    private bool flagHasInsertBefore;
    private bool storeInsertBefore;
    private bool flagHasInsertAll;
    private bool storeInsertAll;
    private bool flagHasInsertionStartIndices;
    private List< BigInteger > storeInsertionStartIndices;
    private bool flagHasWordsToDelete;
    private string storeWordsToDelete;
    private bool flagHasDeleteAll;
    private bool storeDeleteAll;
    private bool flagHasDeletionStartIndices;
    private List< BigInteger > storeDeletionStartIndices;
    private bool flagHasSpokenErrorMessage;
    private string storeSpokenErrorMessage;
    private bool flagHasWrittenErrorMessage;
    private string storeWrittenErrorMessage;
    private bool flagHasNewRecipientsAlreadyInSMS;
    private List< SMSContactResultJSON  > storeNewRecipientsAlreadyInSMS;
    private bool flagHasNewRecipientsNotInSMS;
    private List< SMSContactResultJSON  > storeNewRecipientsNotInSMS;
    private bool flagHasOverwroteBody;
    private bool storeOverwroteBody;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSMS(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SMSJSON convert_classy = SMSJSON.from_json(json_value, ignore_extras, true);
        setSMS(convert_classy);
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
                throw new Exception("The value for field EmptyBodyOK of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setEmptyBodyOK(the_bool);
      }


    private void  fromJSONFocusHint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FocusHint of ComposeSMSCommandNativeDataJSON is not a string.");
        TypeFocusHint the_enum;
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "ody", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeFocusHint.FocusHint_Body;
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
        throw new Exception("The value for field FocusHint of ComposeSMSCommandNativeDataJSON is not one of the legal strings.");
      enum_is_done:;
        setFocusHint(the_enum);
      }


    private void  fromJSONSendSMSNow(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SendSMSNow of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setSendSMSNow(the_bool);
      }


    private void  fromJSONLastEditedTextFieldType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SMSFieldTypeJSON convert_classy = SMSFieldTypeJSON.from_json(json_value, ignore_extras, true);
        setLastEditedTextFieldType(convert_classy);
      }


    private void  fromJSONSMSAlreadyHadRecipients(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SMSAlreadyHadRecipients of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setSMSAlreadyHadRecipients(the_bool);
      }


    private void  fromJSONNewBody(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NewBody of ComposeSMSCommandNativeDataJSON is not a string.");
        setNewBody(json_string.getData());
      }


    private void  fromJSONNewRecipientsInfo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NewRecipientsInfo of ComposeSMSCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeNewRecipientsInfoJSON  > vector_NewRecipientsInfo1 = new List< TypeNewRecipientsInfoJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeNewRecipientsInfoJSON convert_classy = TypeNewRecipientsInfoJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_NewRecipientsInfo1.Add(convert_classy);
          }
        initNewRecipientsInfo();
        for (int num1 = 0; num1 < vector_NewRecipientsInfo1.Count; ++num1)
            appendNewRecipientsInfo(vector_NewRecipientsInfo1[num1]);
        for (int num1 = 0; num1 < vector_NewRecipientsInfo1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpokenMessageFromPreviousTransaction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenMessageFromPreviousTransaction of ComposeSMSCommandNativeDataJSON is not a string.");
        setSpokenMessageFromPreviousTransaction(json_string.getData());
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
                throw new Exception("The value for field AutoListen of ComposeSMSCommandNativeDataJSON is not true for false.");
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
                throw new Exception("The value for field NotUnderstoodUsedWordTo of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setNotUnderstoodUsedWordTo(the_bool);
      }


    private void  fromJSONNotUnderstoodWords(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NotUnderstoodWords of ComposeSMSCommandNativeDataJSON is not a string.");
        setNotUnderstoodWords(json_string.getData());
      }


    private void  fromJSONDeleteType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DeleteType of ComposeSMSCommandNativeDataJSON is not a string.");
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
        throw new Exception("The value for field DeleteType of ComposeSMSCommandNativeDataJSON is not one of the legal strings.");
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
                throw new Exception("The value for field NumToDelete of ComposeSMSCommandNativeDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumToDelete of ComposeSMSCommandNativeDataJSON is not an integer.");
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
                throw new Exception("The value for field NumDeleted of ComposeSMSCommandNativeDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumDeleted of ComposeSMSCommandNativeDataJSON is not an integer.");
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
                throw new Exception("The value for field DeleteFromBack of ComposeSMSCommandNativeDataJSON is not true for false.");
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
                throw new Exception("The value for field NothingToDelete of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setNothingToDelete(the_bool);
      }


    private void  fromJSONState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SMSStateJSON convert_classy = SMSStateJSON.from_json(json_value, ignore_extras, true);
        setState(convert_classy);
      }


    private void  fromJSONEditBodyState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EditBodyState of ComposeSMSCommandNativeDataJSON is not a string.");
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
        throw new Exception("The value for field EditBodyState of ComposeSMSCommandNativeDataJSON is not one of the legal strings.");
      enum_is_done:;
        setEditBodyState(the_enum);
      }


    private void  fromJSONFirstTimeAddingToBody(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field FirstTimeAddingToBody of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setFirstTimeAddingToBody(the_bool);
      }


    private void  fromJSONRecipientsAdded(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RecipientsAdded of ComposeSMSCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< UnambiguousSMSRecipientJSON  > vector_RecipientsAdded1 = new List< UnambiguousSMSRecipientJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UnambiguousSMSRecipientJSON convert_classy = UnambiguousSMSRecipientJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RecipientsAdded1.Add(convert_classy);
          }
        initRecipientsAdded();
        for (int num2 = 0; num2 < vector_RecipientsAdded1.Count; ++num2)
            appendRecipientsAdded(vector_RecipientsAdded1[num2]);
        for (int num1 = 0; num1 < vector_RecipientsAdded1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRecipientsRemoved(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RecipientsRemoved of ComposeSMSCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< UnambiguousSMSRecipientJSON  > vector_RecipientsRemoved1 = new List< UnambiguousSMSRecipientJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UnambiguousSMSRecipientJSON convert_classy = UnambiguousSMSRecipientJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RecipientsRemoved1.Add(convert_classy);
          }
        initRecipientsRemoved();
        for (int num3 = 0; num3 < vector_RecipientsRemoved1.Count; ++num3)
            appendRecipientsRemoved(vector_RecipientsRemoved1[num3]);
        for (int num1 = 0; num1 < vector_RecipientsRemoved1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRecipientsCouldNotAdd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RecipientsCouldNotAdd of ComposeSMSCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< UnambiguousSMSRecipientJSON  > vector_RecipientsCouldNotAdd1 = new List< UnambiguousSMSRecipientJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UnambiguousSMSRecipientJSON convert_classy = UnambiguousSMSRecipientJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RecipientsCouldNotAdd1.Add(convert_classy);
          }
        initRecipientsCouldNotAdd();
        for (int num4 = 0; num4 < vector_RecipientsCouldNotAdd1.Count; ++num4)
            appendRecipientsCouldNotAdd(vector_RecipientsCouldNotAdd1[num4]);
        for (int num1 = 0; num1 < vector_RecipientsCouldNotAdd1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRecipientsCouldNotRemove(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RecipientsCouldNotRemove of ComposeSMSCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SMSRecipientsJSON  > vector_RecipientsCouldNotRemove1 = new List< SMSRecipientsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SMSRecipientsJSON convert_classy = SMSRecipientsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RecipientsCouldNotRemove1.Add(convert_classy);
          }
        initRecipientsCouldNotRemove();
        for (int num5 = 0; num5 < vector_RecipientsCouldNotRemove1.Count; ++num5)
            appendRecipientsCouldNotRemove(vector_RecipientsCouldNotRemove1[num5]);
        for (int num1 = 0; num1 < vector_RecipientsCouldNotRemove1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOpenEndedEditRequest(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenEndedEditRequest of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setOpenEndedEditRequest(the_bool);
      }


    private void  fromJSONOpenEndedEditRequestAction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SMSContactResultActionJSON convert_classy = SMSContactResultActionJSON.from_json(json_value, ignore_extras, true);
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
                throw new Exception("The value for field RemovedAllRecipients of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setRemovedAllRecipients(the_bool);
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
                throw new Exception("The value for field AlreadyHadRecipients of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setAlreadyHadRecipients(the_bool);
      }


    private void  fromJSONNotUnderstoodType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NotUnderstoodType of ComposeSMSCommandNativeDataJSON is not a string.");
        TypeNotUnderstoodType the_enum;
        switch (json_string.getData()[0])
          {
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "MS_PHONE_NUMBER", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_enum = TypeNotUnderstoodType.NotUnderstoodType_SMS_PHONE_NUMBER;
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
        throw new Exception("The value for field NotUnderstoodType of ComposeSMSCommandNativeDataJSON is not one of the legal strings.");
      enum_is_done:;
        setNotUnderstoodType(the_enum);
      }


    private void  fromJSONNotUnderstoodWordsFound(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NotUnderstoodWordsFound of ComposeSMSCommandNativeDataJSON is not a string.");
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
                throw new Exception("The value for field ReadRecipients of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setReadRecipients(the_bool);
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
                throw new Exception("The value for field ReadBody of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setReadBody(the_bool);
      }


    private void  fromJSONWordsToReplace(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WordsToReplace of ComposeSMSCommandNativeDataJSON is not a string.");
        setWordsToReplace(json_string.getData());
      }


    private void  fromJSONReplacementWords(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ReplacementWords of ComposeSMSCommandNativeDataJSON is not a string.");
        setReplacementWords(json_string.getData());
      }


    private void  fromJSONReplaceAll(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ReplaceAll of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setReplaceAll(the_bool);
      }


    private void  fromJSONReplacementStartIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ReplacementStartIndices of ComposeSMSCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ReplacementStartIndices of ComposeSMSCommandNativeDataJSON has too few elements.");
        List< BigInteger > vector_ReplacementStartIndices1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field ReplacementStartIndices of ComposeSMSCommandNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field ReplacementStartIndices of ComposeSMSCommandNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_ReplacementStartIndices1.Add(extracted_integer);
          }
        Debug.Assert(vector_ReplacementStartIndices1.Count >= 1);
        initReplacementStartIndices();
        for (int num6 = 0; num6 < vector_ReplacementStartIndices1.Count; ++num6)
            appendReplacementStartIndices(vector_ReplacementStartIndices1[num6]);
        for (int num1 = 0; num1 < vector_ReplacementStartIndices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONWordsToMatchForInsertion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WordsToMatchForInsertion of ComposeSMSCommandNativeDataJSON is not a string.");
        setWordsToMatchForInsertion(json_string.getData());
      }


    private void  fromJSONInsertionWords(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field InsertionWords of ComposeSMSCommandNativeDataJSON is not a string.");
        setInsertionWords(json_string.getData());
      }


    private void  fromJSONInsertBefore(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field InsertBefore of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setInsertBefore(the_bool);
      }


    private void  fromJSONInsertAll(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field InsertAll of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setInsertAll(the_bool);
      }


    private void  fromJSONInsertionStartIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InsertionStartIndices of ComposeSMSCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field InsertionStartIndices of ComposeSMSCommandNativeDataJSON has too few elements.");
        List< BigInteger > vector_InsertionStartIndices1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field InsertionStartIndices of ComposeSMSCommandNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field InsertionStartIndices of ComposeSMSCommandNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_InsertionStartIndices1.Add(extracted_integer);
          }
        Debug.Assert(vector_InsertionStartIndices1.Count >= 1);
        initInsertionStartIndices();
        for (int num7 = 0; num7 < vector_InsertionStartIndices1.Count; ++num7)
            appendInsertionStartIndices(vector_InsertionStartIndices1[num7]);
        for (int num1 = 0; num1 < vector_InsertionStartIndices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONWordsToDelete(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WordsToDelete of ComposeSMSCommandNativeDataJSON is not a string.");
        setWordsToDelete(json_string.getData());
      }


    private void  fromJSONDeleteAll(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DeleteAll of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setDeleteAll(the_bool);
      }


    private void  fromJSONDeletionStartIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DeletionStartIndices of ComposeSMSCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field DeletionStartIndices of ComposeSMSCommandNativeDataJSON has too few elements.");
        List< BigInteger > vector_DeletionStartIndices1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field DeletionStartIndices of ComposeSMSCommandNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field DeletionStartIndices of ComposeSMSCommandNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_DeletionStartIndices1.Add(extracted_integer);
          }
        Debug.Assert(vector_DeletionStartIndices1.Count >= 1);
        initDeletionStartIndices();
        for (int num8 = 0; num8 < vector_DeletionStartIndices1.Count; ++num8)
            appendDeletionStartIndices(vector_DeletionStartIndices1[num8]);
        for (int num1 = 0; num1 < vector_DeletionStartIndices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpokenErrorMessage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenErrorMessage of ComposeSMSCommandNativeDataJSON is not a string.");
        setSpokenErrorMessage(json_string.getData());
      }


    private void  fromJSONWrittenErrorMessage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenErrorMessage of ComposeSMSCommandNativeDataJSON is not a string.");
        setWrittenErrorMessage(json_string.getData());
      }


    private void  fromJSONNewRecipientsAlreadyInSMS(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NewRecipientsAlreadyInSMS of ComposeSMSCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SMSContactResultJSON  > vector_NewRecipientsAlreadyInSMS1 = new List< SMSContactResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SMSContactResultJSON convert_classy = SMSContactResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_NewRecipientsAlreadyInSMS1.Add(convert_classy);
          }
        initNewRecipientsAlreadyInSMS();
        for (int num9 = 0; num9 < vector_NewRecipientsAlreadyInSMS1.Count; ++num9)
            appendNewRecipientsAlreadyInSMS(vector_NewRecipientsAlreadyInSMS1[num9]);
        for (int num1 = 0; num1 < vector_NewRecipientsAlreadyInSMS1.Count; ++num1)
          {
          }
      }


    private void  fromJSONNewRecipientsNotInSMS(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NewRecipientsNotInSMS of ComposeSMSCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SMSContactResultJSON  > vector_NewRecipientsNotInSMS1 = new List< SMSContactResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SMSContactResultJSON convert_classy = SMSContactResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_NewRecipientsNotInSMS1.Add(convert_classy);
          }
        initNewRecipientsNotInSMS();
        for (int num10 = 0; num10 < vector_NewRecipientsNotInSMS1.Count; ++num10)
            appendNewRecipientsNotInSMS(vector_NewRecipientsNotInSMS1[num10]);
        for (int num1 = 0; num1 < vector_NewRecipientsNotInSMS1.Count; ++num1)
          {
          }
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
                throw new Exception("The value for field OverwroteBody of ComposeSMSCommandNativeDataJSON is not true for false.");
              }
          }
        setOverwroteBody(the_bool);
      }


    public ComposeSMSCommandNativeDataJSON()
      {
        flagHasSMS = false;
        flagHasEmptyBodyOK = false;
        flagHasFocusHint = false;
        flagHasSendSMSNow = false;
        flagHasLastEditedTextFieldType = false;
        flagHasSMSAlreadyHadRecipients = false;
        flagHasNewBody = false;
        flagHasNewRecipientsInfo = false;
        flagHasSpokenMessageFromPreviousTransaction = false;
        flagHasAutoListen = false;
        flagHasNotUnderstoodUsedWordTo = false;
        flagHasNotUnderstoodWords = false;
        flagHasDeleteType = false;
        flagHasNumToDelete = false;
        flagHasNumDeleted = false;
        flagHasDeleteFromBack = false;
        flagHasNothingToDelete = false;
        flagHasState = false;
        flagHasEditBodyState = false;
        flagHasFirstTimeAddingToBody = false;
        flagHasRecipientsAdded = false;
        flagHasRecipientsRemoved = false;
        flagHasRecipientsCouldNotAdd = false;
        flagHasRecipientsCouldNotRemove = false;
        flagHasOpenEndedEditRequest = false;
        flagHasOpenEndedEditRequestAction = false;
        flagHasRemovedAllRecipients = false;
        flagHasAlreadyHadRecipients = false;
        flagHasNotUnderstoodType = false;
        flagHasNotUnderstoodWordsFound = false;
        flagHasReadRecipients = false;
        flagHasReadBody = false;
        flagHasWordsToReplace = false;
        flagHasReplacementWords = false;
        flagHasReplaceAll = false;
        flagHasReplacementStartIndices = false;
        flagHasWordsToMatchForInsertion = false;
        flagHasInsertionWords = false;
        flagHasInsertBefore = false;
        flagHasInsertAll = false;
        flagHasInsertionStartIndices = false;
        flagHasWordsToDelete = false;
        flagHasDeleteAll = false;
        flagHasDeletionStartIndices = false;
        flagHasSpokenErrorMessage = false;
        flagHasWrittenErrorMessage = false;
        flagHasNewRecipientsAlreadyInSMS = false;
        flagHasNewRecipientsNotInSMS = false;
        flagHasOverwroteBody = false;
        storeNewRecipientsInfo = new List< TypeNewRecipientsInfoJSON  >();
        storeRecipientsAdded = new List< UnambiguousSMSRecipientJSON  >();
        storeRecipientsRemoved = new List< UnambiguousSMSRecipientJSON  >();
        storeRecipientsCouldNotAdd = new List< UnambiguousSMSRecipientJSON  >();
        storeRecipientsCouldNotRemove = new List< SMSRecipientsJSON  >();
        storeReplacementStartIndices = new List< BigInteger >();
        storeInsertionStartIndices = new List< BigInteger >();
        storeDeletionStartIndices = new List< BigInteger >();
        storeNewRecipientsAlreadyInSMS = new List< SMSContactResultJSON  >();
        storeNewRecipientsNotInSMS = new List< SMSContactResultJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSMS()
      {
        return flagHasSMS;
      }

    public SMSJSON   getSMS()
      {
        Debug.Assert(flagHasSMS);
        return storeSMS;
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

    public bool  hasSendSMSNow()
      {
        return flagHasSendSMSNow;
      }

    public bool  getSendSMSNow()
      {
        Debug.Assert(flagHasSendSMSNow);
        return storeSendSMSNow;
      }

    public bool  hasLastEditedTextFieldType()
      {
        return flagHasLastEditedTextFieldType;
      }

    public SMSFieldTypeJSON   getLastEditedTextFieldType()
      {
        Debug.Assert(flagHasLastEditedTextFieldType);
        return storeLastEditedTextFieldType;
      }

    public SMSFieldTypeJSON.TypeValue  getLastEditedTextFieldTypeValue()
      {
        return getLastEditedTextFieldType().getValue();
      }

    public string  getLastEditedTextFieldTypeAsString()
      {
        return getLastEditedTextFieldType().getValueAsString();
      }

    public bool  hasSMSAlreadyHadRecipients()
      {
        return flagHasSMSAlreadyHadRecipients;
      }

    public bool  getSMSAlreadyHadRecipients()
      {
        Debug.Assert(flagHasSMSAlreadyHadRecipients);
        return storeSMSAlreadyHadRecipients;
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

    public bool  hasNewRecipientsInfo()
      {
        return flagHasNewRecipientsInfo;
      }

    public int  countOfNewRecipientsInfo()
      {
        Debug.Assert(flagHasNewRecipientsInfo);
        return storeNewRecipientsInfo.Count;
      }

    public TypeNewRecipientsInfoJSON   elementOfNewRecipientsInfo(int element_num)
      {
        Debug.Assert(flagHasNewRecipientsInfo);
        return storeNewRecipientsInfo[element_num];
      }

    public List< TypeNewRecipientsInfoJSON  >  getNewRecipientsInfo()
      {
        Debug.Assert(flagHasNewRecipientsInfo);
        return storeNewRecipientsInfo;
      }

    public bool  hasSpokenMessageFromPreviousTransaction()
      {
        return flagHasSpokenMessageFromPreviousTransaction;
      }

    public string  getSpokenMessageFromPreviousTransaction()
      {
        Debug.Assert(flagHasSpokenMessageFromPreviousTransaction);
        return storeSpokenMessageFromPreviousTransaction;
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

    public bool  hasState()
      {
        return flagHasState;
      }

    public SMSStateJSON   getState()
      {
        Debug.Assert(flagHasState);
        return storeState;
      }

    public SMSStateJSON.TypeValue  getStateValue()
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

    public bool  hasFirstTimeAddingToBody()
      {
        return flagHasFirstTimeAddingToBody;
      }

    public bool  getFirstTimeAddingToBody()
      {
        Debug.Assert(flagHasFirstTimeAddingToBody);
        return storeFirstTimeAddingToBody;
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

    public UnambiguousSMSRecipientJSON   elementOfRecipientsAdded(int element_num)
      {
        Debug.Assert(flagHasRecipientsAdded);
        return storeRecipientsAdded[element_num];
      }

    public List< UnambiguousSMSRecipientJSON  >  getRecipientsAdded()
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

    public UnambiguousSMSRecipientJSON   elementOfRecipientsRemoved(int element_num)
      {
        Debug.Assert(flagHasRecipientsRemoved);
        return storeRecipientsRemoved[element_num];
      }

    public List< UnambiguousSMSRecipientJSON  >  getRecipientsRemoved()
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

    public UnambiguousSMSRecipientJSON   elementOfRecipientsCouldNotAdd(int element_num)
      {
        Debug.Assert(flagHasRecipientsCouldNotAdd);
        return storeRecipientsCouldNotAdd[element_num];
      }

    public List< UnambiguousSMSRecipientJSON  >  getRecipientsCouldNotAdd()
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

    public SMSRecipientsJSON   elementOfRecipientsCouldNotRemove(int element_num)
      {
        Debug.Assert(flagHasRecipientsCouldNotRemove);
        return storeRecipientsCouldNotRemove[element_num];
      }

    public List< SMSRecipientsJSON  >  getRecipientsCouldNotRemove()
      {
        Debug.Assert(flagHasRecipientsCouldNotRemove);
        return storeRecipientsCouldNotRemove;
      }

    public bool  hasOpenEndedEditRequest()
      {
        return flagHasOpenEndedEditRequest;
      }

    public bool  getOpenEndedEditRequest()
      {
        Debug.Assert(flagHasOpenEndedEditRequest);
        return storeOpenEndedEditRequest;
      }

    public bool  hasOpenEndedEditRequestAction()
      {
        return flagHasOpenEndedEditRequestAction;
      }

    public SMSContactResultActionJSON   getOpenEndedEditRequestAction()
      {
        Debug.Assert(flagHasOpenEndedEditRequestAction);
        return storeOpenEndedEditRequestAction;
      }

    public SMSContactResultActionJSON.TypeValue  getOpenEndedEditRequestActionValue()
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

    public bool  hasAlreadyHadRecipients()
      {
        return flagHasAlreadyHadRecipients;
      }

    public bool  getAlreadyHadRecipients()
      {
        Debug.Assert(flagHasAlreadyHadRecipients);
        return storeAlreadyHadRecipients;
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

    public bool  hasReadBody()
      {
        return flagHasReadBody;
      }

    public bool  getReadBody()
      {
        Debug.Assert(flagHasReadBody);
        return storeReadBody;
      }

    public bool  hasWordsToReplace()
      {
        return flagHasWordsToReplace;
      }

    public string  getWordsToReplace()
      {
        Debug.Assert(flagHasWordsToReplace);
        return storeWordsToReplace;
      }

    public bool  hasReplacementWords()
      {
        return flagHasReplacementWords;
      }

    public string  getReplacementWords()
      {
        Debug.Assert(flagHasReplacementWords);
        return storeReplacementWords;
      }

    public bool  hasReplaceAll()
      {
        return flagHasReplaceAll;
      }

    public bool  getReplaceAll()
      {
        Debug.Assert(flagHasReplaceAll);
        return storeReplaceAll;
      }

    public bool  hasReplacementStartIndices()
      {
        return flagHasReplacementStartIndices;
      }

    public int  countOfReplacementStartIndices()
      {
        Debug.Assert(flagHasReplacementStartIndices);
        return storeReplacementStartIndices.Count;
      }

    public BigInteger  elementOfReplacementStartIndices(int element_num)
      {
        Debug.Assert(flagHasReplacementStartIndices);
        return storeReplacementStartIndices[element_num];
      }

    public List< BigInteger >  getReplacementStartIndices()
      {
        Debug.Assert(flagHasReplacementStartIndices);
        return storeReplacementStartIndices;
      }

    public bool  hasWordsToMatchForInsertion()
      {
        return flagHasWordsToMatchForInsertion;
      }

    public string  getWordsToMatchForInsertion()
      {
        Debug.Assert(flagHasWordsToMatchForInsertion);
        return storeWordsToMatchForInsertion;
      }

    public bool  hasInsertionWords()
      {
        return flagHasInsertionWords;
      }

    public string  getInsertionWords()
      {
        Debug.Assert(flagHasInsertionWords);
        return storeInsertionWords;
      }

    public bool  hasInsertBefore()
      {
        return flagHasInsertBefore;
      }

    public bool  getInsertBefore()
      {
        Debug.Assert(flagHasInsertBefore);
        return storeInsertBefore;
      }

    public bool  hasInsertAll()
      {
        return flagHasInsertAll;
      }

    public bool  getInsertAll()
      {
        Debug.Assert(flagHasInsertAll);
        return storeInsertAll;
      }

    public bool  hasInsertionStartIndices()
      {
        return flagHasInsertionStartIndices;
      }

    public int  countOfInsertionStartIndices()
      {
        Debug.Assert(flagHasInsertionStartIndices);
        return storeInsertionStartIndices.Count;
      }

    public BigInteger  elementOfInsertionStartIndices(int element_num)
      {
        Debug.Assert(flagHasInsertionStartIndices);
        return storeInsertionStartIndices[element_num];
      }

    public List< BigInteger >  getInsertionStartIndices()
      {
        Debug.Assert(flagHasInsertionStartIndices);
        return storeInsertionStartIndices;
      }

    public bool  hasWordsToDelete()
      {
        return flagHasWordsToDelete;
      }

    public string  getWordsToDelete()
      {
        Debug.Assert(flagHasWordsToDelete);
        return storeWordsToDelete;
      }

    public bool  hasDeleteAll()
      {
        return flagHasDeleteAll;
      }

    public bool  getDeleteAll()
      {
        Debug.Assert(flagHasDeleteAll);
        return storeDeleteAll;
      }

    public bool  hasDeletionStartIndices()
      {
        return flagHasDeletionStartIndices;
      }

    public int  countOfDeletionStartIndices()
      {
        Debug.Assert(flagHasDeletionStartIndices);
        return storeDeletionStartIndices.Count;
      }

    public BigInteger  elementOfDeletionStartIndices(int element_num)
      {
        Debug.Assert(flagHasDeletionStartIndices);
        return storeDeletionStartIndices[element_num];
      }

    public List< BigInteger >  getDeletionStartIndices()
      {
        Debug.Assert(flagHasDeletionStartIndices);
        return storeDeletionStartIndices;
      }

    public bool  hasSpokenErrorMessage()
      {
        return flagHasSpokenErrorMessage;
      }

    public string  getSpokenErrorMessage()
      {
        Debug.Assert(flagHasSpokenErrorMessage);
        return storeSpokenErrorMessage;
      }

    public bool  hasWrittenErrorMessage()
      {
        return flagHasWrittenErrorMessage;
      }

    public string  getWrittenErrorMessage()
      {
        Debug.Assert(flagHasWrittenErrorMessage);
        return storeWrittenErrorMessage;
      }

    public bool  hasNewRecipientsAlreadyInSMS()
      {
        return flagHasNewRecipientsAlreadyInSMS;
      }

    public int  countOfNewRecipientsAlreadyInSMS()
      {
        Debug.Assert(flagHasNewRecipientsAlreadyInSMS);
        return storeNewRecipientsAlreadyInSMS.Count;
      }

    public SMSContactResultJSON   elementOfNewRecipientsAlreadyInSMS(int element_num)
      {
        Debug.Assert(flagHasNewRecipientsAlreadyInSMS);
        return storeNewRecipientsAlreadyInSMS[element_num];
      }

    public List< SMSContactResultJSON  >  getNewRecipientsAlreadyInSMS()
      {
        Debug.Assert(flagHasNewRecipientsAlreadyInSMS);
        return storeNewRecipientsAlreadyInSMS;
      }

    public bool  hasNewRecipientsNotInSMS()
      {
        return flagHasNewRecipientsNotInSMS;
      }

    public int  countOfNewRecipientsNotInSMS()
      {
        Debug.Assert(flagHasNewRecipientsNotInSMS);
        return storeNewRecipientsNotInSMS.Count;
      }

    public SMSContactResultJSON   elementOfNewRecipientsNotInSMS(int element_num)
      {
        Debug.Assert(flagHasNewRecipientsNotInSMS);
        return storeNewRecipientsNotInSMS[element_num];
      }

    public List< SMSContactResultJSON  >  getNewRecipientsNotInSMS()
      {
        Debug.Assert(flagHasNewRecipientsNotInSMS);
        return storeNewRecipientsNotInSMS;
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


    public virtual int extraComposeSMSCommandNativeDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraComposeSMSCommandNativeDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraComposeSMSCommandNativeDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraComposeSMSCommandNativeDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSMS(SMSJSON  new_value)
      {
        if (flagHasSMS)
          {
          }
        flagHasSMS = true;
        storeSMS = new_value;
      }
    public void unsetSMS()
      {
        if (flagHasSMS)
          {
          }
        flagHasSMS = false;
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
    public void setSendSMSNow(bool new_value)
      {
        flagHasSendSMSNow = true;
        storeSendSMSNow = new_value;
      }
    public void unsetSendSMSNow()
      {
        flagHasSendSMSNow = false;
      }
    public void setLastEditedTextFieldType(SMSFieldTypeJSON  new_value)
      {
        if (flagHasLastEditedTextFieldType)
          {
          }
        flagHasLastEditedTextFieldType = true;
        storeLastEditedTextFieldType = new_value;
      }
    public void setLastEditedTextFieldType(SMSFieldTypeJSON.TypeValue new_value)
      {
        setLastEditedTextFieldType(new SMSFieldTypeJSON(new_value));
      }
    public void setLastEditedTextFieldType(string chars)
      {
        setLastEditedTextFieldType(new SMSFieldTypeJSON(chars));
      }
    public void unsetLastEditedTextFieldType()
      {
        if (flagHasLastEditedTextFieldType)
          {
          }
        flagHasLastEditedTextFieldType = false;
      }
    public void setSMSAlreadyHadRecipients(bool new_value)
      {
        flagHasSMSAlreadyHadRecipients = true;
        storeSMSAlreadyHadRecipients = new_value;
      }
    public void unsetSMSAlreadyHadRecipients()
      {
        flagHasSMSAlreadyHadRecipients = false;
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
    public void initNewRecipientsInfo()
      {
        if (flagHasNewRecipientsInfo)
          {
            for (int num1 = 0; num1 < storeNewRecipientsInfo.Count; ++num1)
              {
              }
          }
        flagHasNewRecipientsInfo = true;
        storeNewRecipientsInfo.Clear();
      }
    public void appendNewRecipientsInfo(TypeNewRecipientsInfoJSON  to_append)
      {
        if (!flagHasNewRecipientsInfo)
          {
            flagHasNewRecipientsInfo = true;
            storeNewRecipientsInfo.Clear();
          }
        Debug.Assert(flagHasNewRecipientsInfo);
        storeNewRecipientsInfo.Add(to_append);
      }
    public void unsetNewRecipientsInfo()
      {
        if (flagHasNewRecipientsInfo)
          {
            for (int num2 = 0; num2 < storeNewRecipientsInfo.Count; ++num2)
              {
              }
          }
        flagHasNewRecipientsInfo = false;
        storeNewRecipientsInfo.Clear();
      }
    public void setSpokenMessageFromPreviousTransaction(string new_value)
      {
        flagHasSpokenMessageFromPreviousTransaction = true;
        storeSpokenMessageFromPreviousTransaction = new_value;
      }
    public void unsetSpokenMessageFromPreviousTransaction()
      {
        flagHasSpokenMessageFromPreviousTransaction = false;
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
            throw new Exception("The value for field NumToDelete of ComposeSMSCommandNativeDataJSON is less than the lower bound (0) for that field.");
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
            throw new Exception("The value for field NumDeleted of ComposeSMSCommandNativeDataJSON is less than the lower bound (0) for that field.");
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
    public void setState(SMSStateJSON  new_value)
      {
        if (flagHasState)
          {
          }
        flagHasState = true;
        storeState = new_value;
      }
    public void setState(SMSStateJSON.TypeValue new_value)
      {
        setState(new SMSStateJSON(new_value));
      }
    public void setState(string chars)
      {
        setState(new SMSStateJSON(chars));
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
    public void setFirstTimeAddingToBody(bool new_value)
      {
        flagHasFirstTimeAddingToBody = true;
        storeFirstTimeAddingToBody = new_value;
      }
    public void unsetFirstTimeAddingToBody()
      {
        flagHasFirstTimeAddingToBody = false;
      }
    public void initRecipientsAdded()
      {
        if (flagHasRecipientsAdded)
          {
            for (int num3 = 0; num3 < storeRecipientsAdded.Count; ++num3)
              {
              }
          }
        flagHasRecipientsAdded = true;
        storeRecipientsAdded.Clear();
      }
    public void appendRecipientsAdded(UnambiguousSMSRecipientJSON  to_append)
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
            for (int num4 = 0; num4 < storeRecipientsAdded.Count; ++num4)
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
            for (int num5 = 0; num5 < storeRecipientsRemoved.Count; ++num5)
              {
              }
          }
        flagHasRecipientsRemoved = true;
        storeRecipientsRemoved.Clear();
      }
    public void appendRecipientsRemoved(UnambiguousSMSRecipientJSON  to_append)
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
            for (int num6 = 0; num6 < storeRecipientsRemoved.Count; ++num6)
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
            for (int num7 = 0; num7 < storeRecipientsCouldNotAdd.Count; ++num7)
              {
              }
          }
        flagHasRecipientsCouldNotAdd = true;
        storeRecipientsCouldNotAdd.Clear();
      }
    public void appendRecipientsCouldNotAdd(UnambiguousSMSRecipientJSON  to_append)
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
            for (int num8 = 0; num8 < storeRecipientsCouldNotAdd.Count; ++num8)
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
            for (int num9 = 0; num9 < storeRecipientsCouldNotRemove.Count; ++num9)
              {
              }
          }
        flagHasRecipientsCouldNotRemove = true;
        storeRecipientsCouldNotRemove.Clear();
      }
    public void appendRecipientsCouldNotRemove(SMSRecipientsJSON  to_append)
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
            for (int num10 = 0; num10 < storeRecipientsCouldNotRemove.Count; ++num10)
              {
              }
          }
        flagHasRecipientsCouldNotRemove = false;
        storeRecipientsCouldNotRemove.Clear();
      }
    public void setOpenEndedEditRequest(bool new_value)
      {
        flagHasOpenEndedEditRequest = true;
        storeOpenEndedEditRequest = new_value;
      }
    public void unsetOpenEndedEditRequest()
      {
        flagHasOpenEndedEditRequest = false;
      }
    public void setOpenEndedEditRequestAction(SMSContactResultActionJSON  new_value)
      {
        if (flagHasOpenEndedEditRequestAction)
          {
          }
        flagHasOpenEndedEditRequestAction = true;
        storeOpenEndedEditRequestAction = new_value;
      }
    public void setOpenEndedEditRequestAction(SMSContactResultActionJSON.TypeValue new_value)
      {
        setOpenEndedEditRequestAction(new SMSContactResultActionJSON(new_value));
      }
    public void setOpenEndedEditRequestAction(string chars)
      {
        setOpenEndedEditRequestAction(new SMSContactResultActionJSON(chars));
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
    public void setAlreadyHadRecipients(bool new_value)
      {
        flagHasAlreadyHadRecipients = true;
        storeAlreadyHadRecipients = new_value;
      }
    public void unsetAlreadyHadRecipients()
      {
        flagHasAlreadyHadRecipients = false;
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
    public void setReadBody(bool new_value)
      {
        flagHasReadBody = true;
        storeReadBody = new_value;
      }
    public void unsetReadBody()
      {
        flagHasReadBody = false;
      }
    public void setWordsToReplace(string new_value)
      {
        flagHasWordsToReplace = true;
        storeWordsToReplace = new_value;
      }
    public void unsetWordsToReplace()
      {
        flagHasWordsToReplace = false;
      }
    public void setReplacementWords(string new_value)
      {
        flagHasReplacementWords = true;
        storeReplacementWords = new_value;
      }
    public void unsetReplacementWords()
      {
        flagHasReplacementWords = false;
      }
    public void setReplaceAll(bool new_value)
      {
        flagHasReplaceAll = true;
        storeReplaceAll = new_value;
      }
    public void unsetReplaceAll()
      {
        flagHasReplaceAll = false;
      }
    public void initReplacementStartIndices()
      {
        flagHasReplacementStartIndices = true;
        storeReplacementStartIndices.Clear();
      }
    public void appendReplacementStartIndices(BigInteger to_append)
      {
        if (!flagHasReplacementStartIndices)
          {
            flagHasReplacementStartIndices = true;
            storeReplacementStartIndices.Clear();
          }
        Debug.Assert(flagHasReplacementStartIndices);
        storeReplacementStartIndices.Add(to_append);
      }
    public void unsetReplacementStartIndices()
      {
        flagHasReplacementStartIndices = false;
        storeReplacementStartIndices.Clear();
      }
    public void setWordsToMatchForInsertion(string new_value)
      {
        flagHasWordsToMatchForInsertion = true;
        storeWordsToMatchForInsertion = new_value;
      }
    public void unsetWordsToMatchForInsertion()
      {
        flagHasWordsToMatchForInsertion = false;
      }
    public void setInsertionWords(string new_value)
      {
        flagHasInsertionWords = true;
        storeInsertionWords = new_value;
      }
    public void unsetInsertionWords()
      {
        flagHasInsertionWords = false;
      }
    public void setInsertBefore(bool new_value)
      {
        flagHasInsertBefore = true;
        storeInsertBefore = new_value;
      }
    public void unsetInsertBefore()
      {
        flagHasInsertBefore = false;
      }
    public void setInsertAll(bool new_value)
      {
        flagHasInsertAll = true;
        storeInsertAll = new_value;
      }
    public void unsetInsertAll()
      {
        flagHasInsertAll = false;
      }
    public void initInsertionStartIndices()
      {
        flagHasInsertionStartIndices = true;
        storeInsertionStartIndices.Clear();
      }
    public void appendInsertionStartIndices(BigInteger to_append)
      {
        if (!flagHasInsertionStartIndices)
          {
            flagHasInsertionStartIndices = true;
            storeInsertionStartIndices.Clear();
          }
        Debug.Assert(flagHasInsertionStartIndices);
        storeInsertionStartIndices.Add(to_append);
      }
    public void unsetInsertionStartIndices()
      {
        flagHasInsertionStartIndices = false;
        storeInsertionStartIndices.Clear();
      }
    public void setWordsToDelete(string new_value)
      {
        flagHasWordsToDelete = true;
        storeWordsToDelete = new_value;
      }
    public void unsetWordsToDelete()
      {
        flagHasWordsToDelete = false;
      }
    public void setDeleteAll(bool new_value)
      {
        flagHasDeleteAll = true;
        storeDeleteAll = new_value;
      }
    public void unsetDeleteAll()
      {
        flagHasDeleteAll = false;
      }
    public void initDeletionStartIndices()
      {
        flagHasDeletionStartIndices = true;
        storeDeletionStartIndices.Clear();
      }
    public void appendDeletionStartIndices(BigInteger to_append)
      {
        if (!flagHasDeletionStartIndices)
          {
            flagHasDeletionStartIndices = true;
            storeDeletionStartIndices.Clear();
          }
        Debug.Assert(flagHasDeletionStartIndices);
        storeDeletionStartIndices.Add(to_append);
      }
    public void unsetDeletionStartIndices()
      {
        flagHasDeletionStartIndices = false;
        storeDeletionStartIndices.Clear();
      }
    public void setSpokenErrorMessage(string new_value)
      {
        flagHasSpokenErrorMessage = true;
        storeSpokenErrorMessage = new_value;
      }
    public void unsetSpokenErrorMessage()
      {
        flagHasSpokenErrorMessage = false;
      }
    public void setWrittenErrorMessage(string new_value)
      {
        flagHasWrittenErrorMessage = true;
        storeWrittenErrorMessage = new_value;
      }
    public void unsetWrittenErrorMessage()
      {
        flagHasWrittenErrorMessage = false;
      }
    public void initNewRecipientsAlreadyInSMS()
      {
        if (flagHasNewRecipientsAlreadyInSMS)
          {
            for (int num11 = 0; num11 < storeNewRecipientsAlreadyInSMS.Count; ++num11)
              {
              }
          }
        flagHasNewRecipientsAlreadyInSMS = true;
        storeNewRecipientsAlreadyInSMS.Clear();
      }
    public void appendNewRecipientsAlreadyInSMS(SMSContactResultJSON  to_append)
      {
        if (!flagHasNewRecipientsAlreadyInSMS)
          {
            flagHasNewRecipientsAlreadyInSMS = true;
            storeNewRecipientsAlreadyInSMS.Clear();
          }
        Debug.Assert(flagHasNewRecipientsAlreadyInSMS);
        storeNewRecipientsAlreadyInSMS.Add(to_append);
      }
    public void unsetNewRecipientsAlreadyInSMS()
      {
        if (flagHasNewRecipientsAlreadyInSMS)
          {
            for (int num12 = 0; num12 < storeNewRecipientsAlreadyInSMS.Count; ++num12)
              {
              }
          }
        flagHasNewRecipientsAlreadyInSMS = false;
        storeNewRecipientsAlreadyInSMS.Clear();
      }
    public void initNewRecipientsNotInSMS()
      {
        if (flagHasNewRecipientsNotInSMS)
          {
            for (int num13 = 0; num13 < storeNewRecipientsNotInSMS.Count; ++num13)
              {
              }
          }
        flagHasNewRecipientsNotInSMS = true;
        storeNewRecipientsNotInSMS.Clear();
      }
    public void appendNewRecipientsNotInSMS(SMSContactResultJSON  to_append)
      {
        if (!flagHasNewRecipientsNotInSMS)
          {
            flagHasNewRecipientsNotInSMS = true;
            storeNewRecipientsNotInSMS.Clear();
          }
        Debug.Assert(flagHasNewRecipientsNotInSMS);
        storeNewRecipientsNotInSMS.Add(to_append);
      }
    public void unsetNewRecipientsNotInSMS()
      {
        if (flagHasNewRecipientsNotInSMS)
          {
            for (int num14 = 0; num14 < storeNewRecipientsNotInSMS.Count; ++num14)
              {
              }
          }
        flagHasNewRecipientsNotInSMS = false;
        storeNewRecipientsNotInSMS.Clear();
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

    public virtual void extraComposeSMSCommandNativeDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraComposeSMSCommandNativeDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraComposeSMSCommandNativeDataLookup(key);
        if (old_field == null)
          {
            extraComposeSMSCommandNativeDataAppendPair(key, new_component);
          }
        else
          {
            int count = extraKeys.Count;
            Debug.Assert(count == extraValues.Count);
            for (int num = 0; num < count; ++num)
              {
                if (extraKeys[num].Equals( key))
                  {
                    extraValues[num] = new_component;
                    break;
                  }
              }
            extraIndex.Add(key, new_component);
          }
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        int extra_count = extraKeys.Count;
        Debug.Assert(extra_count == extraValues.Count);
        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
          {
            handler.start_pair(extraKeys[extra_num]);
            extraValues[extra_num].write(handler);
          }
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        Debug.Assert(partial_allowed || flagHasSMS);
        if (flagHasSMS)
          {
            handler.start_pair("SMS");
            if (partial_allowed)
                storeSMS.write_partial_as_json(handler);
            else
                storeSMS.write_as_json(handler);
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
                case TypeFocusHint.FocusHint_Body:
                    handler.string_value("Body");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasSendSMSNow)
          {
            handler.start_pair("SendSMSNow");
            handler.boolean_value(storeSendSMSNow);
          }
        if (flagHasLastEditedTextFieldType)
          {
            handler.start_pair("LastEditedTextFieldType");
            if (partial_allowed)
                storeLastEditedTextFieldType.write_partial_as_json(handler);
            else
                storeLastEditedTextFieldType.write_as_json(handler);
          }
        if (flagHasSMSAlreadyHadRecipients)
          {
            handler.start_pair("SMSAlreadyHadRecipients");
            handler.boolean_value(storeSMSAlreadyHadRecipients);
          }
        if (flagHasNewBody)
          {
            handler.start_pair("NewBody");
            handler.string_value(storeNewBody);
          }
        if (flagHasNewRecipientsInfo)
          {
            handler.start_pair("NewRecipientsInfo");
            handler.start_array();
            for (int num1 = 0; num1 < storeNewRecipientsInfo.Count; ++num1)
              {
                if (partial_allowed)
                    storeNewRecipientsInfo[num1].write_partial_as_json(handler);
                else
                    storeNewRecipientsInfo[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSpokenMessageFromPreviousTransaction)
          {
            handler.start_pair("SpokenMessageFromPreviousTransaction");
            handler.string_value(storeSpokenMessageFromPreviousTransaction);
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
        if (flagHasFirstTimeAddingToBody)
          {
            handler.start_pair("FirstTimeAddingToBody");
            handler.boolean_value(storeFirstTimeAddingToBody);
          }
        if (flagHasRecipientsAdded)
          {
            handler.start_pair("RecipientsAdded");
            handler.start_array();
            for (int num2 = 0; num2 < storeRecipientsAdded.Count; ++num2)
              {
                if (partial_allowed)
                    storeRecipientsAdded[num2].write_partial_as_json(handler);
                else
                    storeRecipientsAdded[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRecipientsRemoved)
          {
            handler.start_pair("RecipientsRemoved");
            handler.start_array();
            for (int num3 = 0; num3 < storeRecipientsRemoved.Count; ++num3)
              {
                if (partial_allowed)
                    storeRecipientsRemoved[num3].write_partial_as_json(handler);
                else
                    storeRecipientsRemoved[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRecipientsCouldNotAdd)
          {
            handler.start_pair("RecipientsCouldNotAdd");
            handler.start_array();
            for (int num4 = 0; num4 < storeRecipientsCouldNotAdd.Count; ++num4)
              {
                if (partial_allowed)
                    storeRecipientsCouldNotAdd[num4].write_partial_as_json(handler);
                else
                    storeRecipientsCouldNotAdd[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRecipientsCouldNotRemove)
          {
            handler.start_pair("RecipientsCouldNotRemove");
            handler.start_array();
            for (int num5 = 0; num5 < storeRecipientsCouldNotRemove.Count; ++num5)
              {
                if (partial_allowed)
                    storeRecipientsCouldNotRemove[num5].write_partial_as_json(handler);
                else
                    storeRecipientsCouldNotRemove[num5].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasOpenEndedEditRequest)
          {
            handler.start_pair("OpenEndedEditRequest");
            handler.boolean_value(storeOpenEndedEditRequest);
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
        if (flagHasAlreadyHadRecipients)
          {
            handler.start_pair("AlreadyHadRecipients");
            handler.boolean_value(storeAlreadyHadRecipients);
          }
        if (flagHasNotUnderstoodType)
          {
            handler.start_pair("NotUnderstoodType");
            switch (storeNotUnderstoodType)
              {
                case TypeNotUnderstoodType.NotUnderstoodType_SMS_PHONE_NUMBER:
                    handler.string_value("SMS_PHONE_NUMBER");
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
        if (flagHasReadBody)
          {
            handler.start_pair("ReadBody");
            handler.boolean_value(storeReadBody);
          }
        if (flagHasWordsToReplace)
          {
            handler.start_pair("WordsToReplace");
            handler.string_value(storeWordsToReplace);
          }
        if (flagHasReplacementWords)
          {
            handler.start_pair("ReplacementWords");
            handler.string_value(storeReplacementWords);
          }
        if (flagHasReplaceAll)
          {
            handler.start_pair("ReplaceAll");
            handler.boolean_value(storeReplaceAll);
          }
        if (flagHasReplacementStartIndices)
          {
            handler.start_pair("ReplacementStartIndices");
            Debug.Assert(storeReplacementStartIndices.Count >= 1);
            handler.start_array();
            for (int num6 = 0; num6 < storeReplacementStartIndices.Count; ++num6)
              {
                handler.number_value(storeReplacementStartIndices[num6]);
              }
            handler.finish_array();
          }
        if (flagHasWordsToMatchForInsertion)
          {
            handler.start_pair("WordsToMatchForInsertion");
            handler.string_value(storeWordsToMatchForInsertion);
          }
        if (flagHasInsertionWords)
          {
            handler.start_pair("InsertionWords");
            handler.string_value(storeInsertionWords);
          }
        if (flagHasInsertBefore)
          {
            handler.start_pair("InsertBefore");
            handler.boolean_value(storeInsertBefore);
          }
        if (flagHasInsertAll)
          {
            handler.start_pair("InsertAll");
            handler.boolean_value(storeInsertAll);
          }
        if (flagHasInsertionStartIndices)
          {
            handler.start_pair("InsertionStartIndices");
            Debug.Assert(storeInsertionStartIndices.Count >= 1);
            handler.start_array();
            for (int num7 = 0; num7 < storeInsertionStartIndices.Count; ++num7)
              {
                handler.number_value(storeInsertionStartIndices[num7]);
              }
            handler.finish_array();
          }
        if (flagHasWordsToDelete)
          {
            handler.start_pair("WordsToDelete");
            handler.string_value(storeWordsToDelete);
          }
        if (flagHasDeleteAll)
          {
            handler.start_pair("DeleteAll");
            handler.boolean_value(storeDeleteAll);
          }
        if (flagHasDeletionStartIndices)
          {
            handler.start_pair("DeletionStartIndices");
            Debug.Assert(storeDeletionStartIndices.Count >= 1);
            handler.start_array();
            for (int num8 = 0; num8 < storeDeletionStartIndices.Count; ++num8)
              {
                handler.number_value(storeDeletionStartIndices[num8]);
              }
            handler.finish_array();
          }
        if (flagHasSpokenErrorMessage)
          {
            handler.start_pair("SpokenErrorMessage");
            handler.string_value(storeSpokenErrorMessage);
          }
        if (flagHasWrittenErrorMessage)
          {
            handler.start_pair("WrittenErrorMessage");
            handler.string_value(storeWrittenErrorMessage);
          }
        if (flagHasNewRecipientsAlreadyInSMS)
          {
            handler.start_pair("NewRecipientsAlreadyInSMS");
            handler.start_array();
            for (int num9 = 0; num9 < storeNewRecipientsAlreadyInSMS.Count; ++num9)
              {
                if (partial_allowed)
                    storeNewRecipientsAlreadyInSMS[num9].write_partial_as_json(handler);
                else
                    storeNewRecipientsAlreadyInSMS[num9].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasNewRecipientsNotInSMS)
          {
            handler.start_pair("NewRecipientsNotInSMS");
            handler.start_array();
            for (int num10 = 0; num10 < storeNewRecipientsNotInSMS.Count; ++num10)
              {
                if (partial_allowed)
                    storeNewRecipientsNotInSMS[num10].write_partial_as_json(handler);
                else
                    storeNewRecipientsNotInSMS[num10].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasOverwroteBody)
          {
            handler.start_pair("OverwroteBody");
            handler.boolean_value(storeOverwroteBody);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        int extra_count = extraKeys.Count;
        Debug.Assert(extra_count == extraValues.Count);
        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
          {
            handler.start_pair(extraKeys[extra_num]);
            extraValues[extra_num].write(handler);
          }
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasSMS()))
          {
            return "When parsing the object for %what%, the \"SMS\" field was missing.";
          }
        if (!(hasState()))
          {
            return "When parsing the object for %what%, the \"State\" field was missing.";
          }
        return null;
      }

    public static ComposeSMSCommandNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ComposeSMSCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeSMSCommandNativeData", ignore_extras);
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
    public static ComposeSMSCommandNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ComposeSMSCommandNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ComposeSMSCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeSMSCommandNativeData", ignore_extras);
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
    public static ComposeSMSCommandNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ComposeSMSCommandNativeDataJSON from_text(string text, bool ignore_extras)
      {
        ComposeSMSCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeSMSCommandNativeData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ComposeSMSCommandNativeDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ComposeSMSCommandNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ComposeSMSCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ComposeSMSCommandNativeData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SMSJSON.HoldingGenerator fieldGeneratorSMS;
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
        private JSONHoldingBooleanGenerator fieldGeneratorSendSMSNow;
        private SMSFieldTypeJSON.HoldingGenerator fieldGeneratorLastEditedTextFieldType;
        private JSONHoldingBooleanGenerator fieldGeneratorSMSAlreadyHadRecipients;
        private JSONHoldingStringGenerator fieldGeneratorNewBody;
        private TypeNewRecipientsInfoJSON.HoldingArrayGenerator fieldGeneratorNewRecipientsInfo;
        private JSONHoldingStringGenerator fieldGeneratorSpokenMessageFromPreviousTransaction;
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
        private SMSStateJSON.HoldingGenerator fieldGeneratorState;
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
        private JSONHoldingBooleanGenerator fieldGeneratorFirstTimeAddingToBody;
        private UnambiguousSMSRecipientJSON.HoldingArrayGenerator fieldGeneratorRecipientsAdded;
        private UnambiguousSMSRecipientJSON.HoldingArrayGenerator fieldGeneratorRecipientsRemoved;
        private UnambiguousSMSRecipientJSON.HoldingArrayGenerator fieldGeneratorRecipientsCouldNotAdd;
        private SMSRecipientsJSON.HoldingArrayGenerator fieldGeneratorRecipientsCouldNotRemove;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenEndedEditRequest;
        private SMSContactResultActionJSON.HoldingGenerator fieldGeneratorOpenEndedEditRequestAction;
        private JSONHoldingBooleanGenerator fieldGeneratorRemovedAllRecipients;
        private JSONHoldingBooleanGenerator fieldGeneratorAlreadyHadRecipients;
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
        private JSONHoldingBooleanGenerator fieldGeneratorReadBody;
        private JSONHoldingStringGenerator fieldGeneratorWordsToReplace;
        private JSONHoldingStringGenerator fieldGeneratorReplacementWords;
        private JSONHoldingBooleanGenerator fieldGeneratorReplaceAll;
    private class FieldHoldingGeneratorReplacementStartIndices : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorReplacementStartIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorReplacementStartIndices : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorReplacementStartIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorReplacementStartIndices fieldGeneratorReplacementStartIndices;
        private JSONHoldingStringGenerator fieldGeneratorWordsToMatchForInsertion;
        private JSONHoldingStringGenerator fieldGeneratorInsertionWords;
        private JSONHoldingBooleanGenerator fieldGeneratorInsertBefore;
        private JSONHoldingBooleanGenerator fieldGeneratorInsertAll;
    private class FieldHoldingGeneratorInsertionStartIndices : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorInsertionStartIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorInsertionStartIndices : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorInsertionStartIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorInsertionStartIndices fieldGeneratorInsertionStartIndices;
        private JSONHoldingStringGenerator fieldGeneratorWordsToDelete;
        private JSONHoldingBooleanGenerator fieldGeneratorDeleteAll;
    private class FieldHoldingGeneratorDeletionStartIndices : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorDeletionStartIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorDeletionStartIndices : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorDeletionStartIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorDeletionStartIndices fieldGeneratorDeletionStartIndices;
        private JSONHoldingStringGenerator fieldGeneratorSpokenErrorMessage;
        private JSONHoldingStringGenerator fieldGeneratorWrittenErrorMessage;
        private SMSContactResultJSON.HoldingArrayGenerator fieldGeneratorNewRecipientsAlreadyInSMS;
        private SMSContactResultJSON.HoldingArrayGenerator fieldGeneratorNewRecipientsNotInSMS;
        private JSONHoldingBooleanGenerator fieldGeneratorOverwroteBody;
        private class UnknownFieldGenerator : JSONValueHandler
          {
            public bool ignore;
            public List<string> field_names;
            public List<JSONValue > field_values;
            public Dictionary<string, JSONValue > index;
            public UnknownFieldGenerator(bool init_ignore)
              {
                ignore = init_ignore;
                field_names = new List<string>();
                field_values = new List<JSONValue >();
            index = new Dictionary<string, JSONValue >();
              }

            protected override void new_value(JSONValue item)
              {
                if (ignore)
                    return;
                Debug.Assert(field_names.Count == (field_values.Count + 1));
                index.Add(field_names[field_values.Count], item);
                field_values.Add(item);
              }
            public override void reset()
              {
                field_names.Clear();
                field_values.Clear();
            index = new Dictionary<string, JSONValue >();
              }
          };
        private UnknownFieldGenerator unknownFieldGenerator;

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
            Debug.Assert(unknownFieldGenerator.field_names.Count ==
                   unknownFieldGenerator.field_values.Count);
            if (unknownFieldGenerator.ignore)
              {
                Debug.Assert(unknownFieldGenerator.field_names.Count == 0);
              }
            else
              {
                unknownFieldGenerator.field_names.Add(field_name);
              }
            return unknownFieldGenerator;
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            ComposeSMSCommandNativeDataJSON result = new ComposeSMSCommandNativeDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraComposeSMSCommandNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ComposeSMSCommandNativeDataJSON result)
          {
            if (fieldGeneratorSMS.have_value)
              {
                result.setSMS(fieldGeneratorSMS.value);
                fieldGeneratorSMS.have_value = false;
              }
            else if ((!(result.hasSMS())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SMS\" field was missing.");
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
            if (fieldGeneratorSendSMSNow.have_value)
              {
                result.setSendSMSNow(fieldGeneratorSendSMSNow.value);
                fieldGeneratorSendSMSNow.have_value = false;
              }
            if (fieldGeneratorLastEditedTextFieldType.have_value)
              {
                result.setLastEditedTextFieldType(fieldGeneratorLastEditedTextFieldType.value);
                fieldGeneratorLastEditedTextFieldType.have_value = false;
              }
            if (fieldGeneratorSMSAlreadyHadRecipients.have_value)
              {
                result.setSMSAlreadyHadRecipients(fieldGeneratorSMSAlreadyHadRecipients.value);
                fieldGeneratorSMSAlreadyHadRecipients.have_value = false;
              }
            if (fieldGeneratorNewBody.have_value)
              {
                result.setNewBody(fieldGeneratorNewBody.value);
                fieldGeneratorNewBody.have_value = false;
              }
            if (fieldGeneratorNewRecipientsInfo.have_value)
              {
                result.initNewRecipientsInfo();
                int count = fieldGeneratorNewRecipientsInfo.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNewRecipientsInfo(fieldGeneratorNewRecipientsInfo.value[num]);
                  }
                fieldGeneratorNewRecipientsInfo.value.Clear();
                fieldGeneratorNewRecipientsInfo.have_value = false;
              }
            if (fieldGeneratorSpokenMessageFromPreviousTransaction.have_value)
              {
                result.setSpokenMessageFromPreviousTransaction(fieldGeneratorSpokenMessageFromPreviousTransaction.value);
                fieldGeneratorSpokenMessageFromPreviousTransaction.have_value = false;
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
            if (fieldGeneratorFirstTimeAddingToBody.have_value)
              {
                result.setFirstTimeAddingToBody(fieldGeneratorFirstTimeAddingToBody.value);
                fieldGeneratorFirstTimeAddingToBody.have_value = false;
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
            if (fieldGeneratorOpenEndedEditRequest.have_value)
              {
                result.setOpenEndedEditRequest(fieldGeneratorOpenEndedEditRequest.value);
                fieldGeneratorOpenEndedEditRequest.have_value = false;
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
            if (fieldGeneratorAlreadyHadRecipients.have_value)
              {
                result.setAlreadyHadRecipients(fieldGeneratorAlreadyHadRecipients.value);
                fieldGeneratorAlreadyHadRecipients.have_value = false;
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
            if (fieldGeneratorReadBody.have_value)
              {
                result.setReadBody(fieldGeneratorReadBody.value);
                fieldGeneratorReadBody.have_value = false;
              }
            if (fieldGeneratorWordsToReplace.have_value)
              {
                result.setWordsToReplace(fieldGeneratorWordsToReplace.value);
                fieldGeneratorWordsToReplace.have_value = false;
              }
            if (fieldGeneratorReplacementWords.have_value)
              {
                result.setReplacementWords(fieldGeneratorReplacementWords.value);
                fieldGeneratorReplacementWords.have_value = false;
              }
            if (fieldGeneratorReplaceAll.have_value)
              {
                result.setReplaceAll(fieldGeneratorReplaceAll.value);
                fieldGeneratorReplaceAll.have_value = false;
              }
            if (fieldGeneratorReplacementStartIndices.have_value)
              {
                result.initReplacementStartIndices();
                int count = fieldGeneratorReplacementStartIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendReplacementStartIndices(fieldGeneratorReplacementStartIndices.value[num]);
                  }
                fieldGeneratorReplacementStartIndices.value.Clear();
                fieldGeneratorReplacementStartIndices.have_value = false;
              }
            if (fieldGeneratorWordsToMatchForInsertion.have_value)
              {
                result.setWordsToMatchForInsertion(fieldGeneratorWordsToMatchForInsertion.value);
                fieldGeneratorWordsToMatchForInsertion.have_value = false;
              }
            if (fieldGeneratorInsertionWords.have_value)
              {
                result.setInsertionWords(fieldGeneratorInsertionWords.value);
                fieldGeneratorInsertionWords.have_value = false;
              }
            if (fieldGeneratorInsertBefore.have_value)
              {
                result.setInsertBefore(fieldGeneratorInsertBefore.value);
                fieldGeneratorInsertBefore.have_value = false;
              }
            if (fieldGeneratorInsertAll.have_value)
              {
                result.setInsertAll(fieldGeneratorInsertAll.value);
                fieldGeneratorInsertAll.have_value = false;
              }
            if (fieldGeneratorInsertionStartIndices.have_value)
              {
                result.initInsertionStartIndices();
                int count = fieldGeneratorInsertionStartIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInsertionStartIndices(fieldGeneratorInsertionStartIndices.value[num]);
                  }
                fieldGeneratorInsertionStartIndices.value.Clear();
                fieldGeneratorInsertionStartIndices.have_value = false;
              }
            if (fieldGeneratorWordsToDelete.have_value)
              {
                result.setWordsToDelete(fieldGeneratorWordsToDelete.value);
                fieldGeneratorWordsToDelete.have_value = false;
              }
            if (fieldGeneratorDeleteAll.have_value)
              {
                result.setDeleteAll(fieldGeneratorDeleteAll.value);
                fieldGeneratorDeleteAll.have_value = false;
              }
            if (fieldGeneratorDeletionStartIndices.have_value)
              {
                result.initDeletionStartIndices();
                int count = fieldGeneratorDeletionStartIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDeletionStartIndices(fieldGeneratorDeletionStartIndices.value[num]);
                  }
                fieldGeneratorDeletionStartIndices.value.Clear();
                fieldGeneratorDeletionStartIndices.have_value = false;
              }
            if (fieldGeneratorSpokenErrorMessage.have_value)
              {
                result.setSpokenErrorMessage(fieldGeneratorSpokenErrorMessage.value);
                fieldGeneratorSpokenErrorMessage.have_value = false;
              }
            if (fieldGeneratorWrittenErrorMessage.have_value)
              {
                result.setWrittenErrorMessage(fieldGeneratorWrittenErrorMessage.value);
                fieldGeneratorWrittenErrorMessage.have_value = false;
              }
            if (fieldGeneratorNewRecipientsAlreadyInSMS.have_value)
              {
                result.initNewRecipientsAlreadyInSMS();
                int count = fieldGeneratorNewRecipientsAlreadyInSMS.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNewRecipientsAlreadyInSMS(fieldGeneratorNewRecipientsAlreadyInSMS.value[num]);
                  }
                fieldGeneratorNewRecipientsAlreadyInSMS.value.Clear();
                fieldGeneratorNewRecipientsAlreadyInSMS.have_value = false;
              }
            if (fieldGeneratorNewRecipientsNotInSMS.have_value)
              {
                result.initNewRecipientsNotInSMS();
                int count = fieldGeneratorNewRecipientsNotInSMS.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNewRecipientsNotInSMS(fieldGeneratorNewRecipientsNotInSMS.value[num]);
                  }
                fieldGeneratorNewRecipientsNotInSMS.value.Clear();
                fieldGeneratorNewRecipientsNotInSMS.have_value = false;
              }
            if (fieldGeneratorOverwroteBody.have_value)
              {
                result.setOverwroteBody(fieldGeneratorOverwroteBody.value);
                fieldGeneratorOverwroteBody.have_value = false;
              }
          }
        protected abstract void handle_result(ComposeSMSCommandNativeDataJSON new_result);
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
                    if (String.Compare(field_name, 1, "elet", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'e':
                                switch (field_name[6])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 7, "ll", 0, 2, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorDeleteAll;
                                        break;
                                    case 'F':
                                        if ((String.Compare(field_name, 7, "romBack", 0, 7, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorDeleteFromBack;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 7, "ype", 0, 3, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorDeleteType;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'i':
                                if ((String.Compare(field_name, 6, "onStartIndices", 0, 14, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorDeletionStartIndices;
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
                            if ((String.Compare(field_name, 2, "ptyBodyOK", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorEmptyBodyOK;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "rstTimeAddingToBody", 0, 19, false) == 0) && (field_name.Length == 21))
                                return fieldGeneratorFirstTimeAddingToBody;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "cusHint", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorFocusHint;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "nsert", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 7, "ll", 0, 2, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorInsertAll;
                                break;
                            case 'B':
                                if ((String.Compare(field_name, 7, "efore", 0, 5, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorInsertBefore;
                                break;
                            case 'i':
                                if (String.Compare(field_name, 7, "on", 0, 2, false) == 0)
                                  {
                                    switch (field_name[9])
                                      {
                                        case 'S':
                                            if ((String.Compare(field_name, 10, "tartIndices", 0, 11, false) == 0) && (field_name.Length == 21))
                                                return fieldGeneratorInsertionStartIndices;
                                            break;
                                        case 'W':
                                            if ((String.Compare(field_name, 10, "ords", 0, 4, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorInsertionWords;
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
                                                    if ((String.Compare(field_name, 14, "lreadyInSMS", 0, 11, false) == 0) && (field_name.Length == 25))
                                                        return fieldGeneratorNewRecipientsAlreadyInSMS;
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(field_name, 14, "nfo", 0, 3, false) == 0) && (field_name.Length == 17))
                                                        return fieldGeneratorNewRecipientsInfo;
                                                    break;
                                                case 'N':
                                                    if ((String.Compare(field_name, 14, "otInSMS", 0, 7, false) == 0) && (field_name.Length == 21))
                                                        return fieldGeneratorNewRecipientsNotInSMS;
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
                                if (field_name.Length == 20)
                                  {
                                    return fieldGeneratorOpenEndedEditRequest;
                                  }
                                switch (field_name[20])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 21, "ction", 0, 5, false) == 0) && (field_name.Length == 26))
                                            return fieldGeneratorOpenEndedEditRequestAction;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'v':
                            if ((String.Compare(field_name, 2, "erwroteBody", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorOverwroteBody;
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
                            case 'p':
                                if (String.Compare(field_name, 3, "lace", 0, 4, false) == 0)
                                  {
                                    switch (field_name[7])
                                      {
                                        case 'A':
                                            if ((String.Compare(field_name, 8, "ll", 0, 2, false) == 0) && (field_name.Length == 10))
                                                return fieldGeneratorReplaceAll;
                                            break;
                                        case 'm':
                                            if (String.Compare(field_name, 8, "ent", 0, 3, false) == 0)
                                              {
                                                switch (field_name[11])
                                                  {
                                                    case 'S':
                                                        if ((String.Compare(field_name, 12, "tartIndices", 0, 11, false) == 0) && (field_name.Length == 23))
                                                            return fieldGeneratorReplacementStartIndices;
                                                        break;
                                                    case 'W':
                                                        if ((String.Compare(field_name, 12, "ords", 0, 4, false) == 0) && (field_name.Length == 16))
                                                            return fieldGeneratorReplacementWords;
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
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'M':
                            if (String.Compare(field_name, 2, "S", 0, 1, false) == 0)
                              {
                                if (field_name.Length == 3)
                                  {
                                    return fieldGeneratorSMS;
                                  }
                                switch (field_name[3])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 4, "lreadyHadRecipients", 0, 19, false) == 0) && (field_name.Length == 23))
                                            return fieldGeneratorSMSAlreadyHadRecipients;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "ndSMSNow", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorSendSMSNow;
                            break;
                        case 'p':
                            if (String.Compare(field_name, 2, "oken", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'E':
                                        if ((String.Compare(field_name, 7, "rrorMessage", 0, 11, false) == 0) && (field_name.Length == 18))
                                            return fieldGeneratorSpokenErrorMessage;
                                        break;
                                    case 'M':
                                        if ((String.Compare(field_name, 7, "essageFromPreviousTransaction", 0, 29, false) == 0) && (field_name.Length == 36))
                                            return fieldGeneratorSpokenMessageFromPreviousTransaction;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "ate", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorState;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'W':
                    switch (field_name[1])
                      {
                        case 'o':
                            if (String.Compare(field_name, 2, "rdsTo", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 8, "elete", 0, 5, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorWordsToDelete;
                                        break;
                                    case 'M':
                                        if ((String.Compare(field_name, 8, "atchForInsertion", 0, 16, false) == 0) && (field_name.Length == 24))
                                            return fieldGeneratorWordsToMatchForInsertion;
                                        break;
                                    case 'R':
                                        if ((String.Compare(field_name, 8, "eplace", 0, 6, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorWordsToReplace;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "ittenErrorMessage", 0, 17, false) == 0) && (field_name.Length == 19))
                                return fieldGeneratorWrittenErrorMessage;
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
            fieldGeneratorSMS = new SMSJSON.HoldingGenerator("field \"SMS\" of the ComposeSMSCommandNativeData class", ignore_extras);
            fieldGeneratorEmptyBodyOK = new JSONHoldingBooleanGenerator("field \"EmptyBodyOK\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorFocusHint = new FieldHoldingGeneratorFocusHint("field \"FocusHint\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorSendSMSNow = new JSONHoldingBooleanGenerator("field \"SendSMSNow\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorLastEditedTextFieldType = new SMSFieldTypeJSON.HoldingGenerator("field \"LastEditedTextFieldType\" of the ComposeSMSCommandNativeData class", ignore_extras);
            fieldGeneratorSMSAlreadyHadRecipients = new JSONHoldingBooleanGenerator("field \"SMSAlreadyHadRecipients\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNewBody = new JSONHoldingStringGenerator("field \"NewBody\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNewRecipientsInfo = new TypeNewRecipientsInfoJSON.HoldingArrayGenerator("field \"NewRecipientsInfo\" of the ComposeSMSCommandNativeData class", ignore_extras);
            fieldGeneratorSpokenMessageFromPreviousTransaction = new JSONHoldingStringGenerator("field \"SpokenMessageFromPreviousTransaction\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorAutoListen = new JSONHoldingBooleanGenerator("field \"AutoListen\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNotUnderstoodUsedWordTo = new JSONHoldingBooleanGenerator("field \"NotUnderstoodUsedWordTo\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNotUnderstoodWords = new JSONHoldingStringGenerator("field \"NotUnderstoodWords\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorDeleteType = new FieldHoldingGeneratorDeleteType("field \"DeleteType\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNumToDelete = new FieldHoldingGeneratorNumToDelete("field \"NumToDelete\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNumDeleted = new FieldHoldingGeneratorNumDeleted("field \"NumDeleted\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorDeleteFromBack = new JSONHoldingBooleanGenerator("field \"DeleteFromBack\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNothingToDelete = new JSONHoldingBooleanGenerator("field \"NothingToDelete\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorState = new SMSStateJSON.HoldingGenerator("field \"State\" of the ComposeSMSCommandNativeData class", ignore_extras);
            fieldGeneratorEditBodyState = new FieldHoldingGeneratorEditBodyState("field \"EditBodyState\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorFirstTimeAddingToBody = new JSONHoldingBooleanGenerator("field \"FirstTimeAddingToBody\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorRecipientsAdded = new UnambiguousSMSRecipientJSON.HoldingArrayGenerator("field \"RecipientsAdded\" of the ComposeSMSCommandNativeData class", ignore_extras);
            fieldGeneratorRecipientsRemoved = new UnambiguousSMSRecipientJSON.HoldingArrayGenerator("field \"RecipientsRemoved\" of the ComposeSMSCommandNativeData class", ignore_extras);
            fieldGeneratorRecipientsCouldNotAdd = new UnambiguousSMSRecipientJSON.HoldingArrayGenerator("field \"RecipientsCouldNotAdd\" of the ComposeSMSCommandNativeData class", ignore_extras);
            fieldGeneratorRecipientsCouldNotRemove = new SMSRecipientsJSON.HoldingArrayGenerator("field \"RecipientsCouldNotRemove\" of the ComposeSMSCommandNativeData class", ignore_extras);
            fieldGeneratorOpenEndedEditRequest = new JSONHoldingBooleanGenerator("field \"OpenEndedEditRequest\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorOpenEndedEditRequestAction = new SMSContactResultActionJSON.HoldingGenerator("field \"OpenEndedEditRequestAction\" of the ComposeSMSCommandNativeData class", ignore_extras);
            fieldGeneratorRemovedAllRecipients = new JSONHoldingBooleanGenerator("field \"RemovedAllRecipients\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorAlreadyHadRecipients = new JSONHoldingBooleanGenerator("field \"AlreadyHadRecipients\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNotUnderstoodType = new FieldHoldingGeneratorNotUnderstoodType("field \"NotUnderstoodType\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNotUnderstoodWordsFound = new JSONHoldingStringGenerator("field \"NotUnderstoodWordsFound\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorReadRecipients = new JSONHoldingBooleanGenerator("field \"ReadRecipients\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorReadBody = new JSONHoldingBooleanGenerator("field \"ReadBody\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorWordsToReplace = new JSONHoldingStringGenerator("field \"WordsToReplace\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorReplacementWords = new JSONHoldingStringGenerator("field \"ReplacementWords\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorReplaceAll = new JSONHoldingBooleanGenerator("field \"ReplaceAll\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorReplacementStartIndices = new FieldHoldingArrayGeneratorReplacementStartIndices("field \"ReplacementStartIndices\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorWordsToMatchForInsertion = new JSONHoldingStringGenerator("field \"WordsToMatchForInsertion\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorInsertionWords = new JSONHoldingStringGenerator("field \"InsertionWords\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorInsertBefore = new JSONHoldingBooleanGenerator("field \"InsertBefore\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorInsertAll = new JSONHoldingBooleanGenerator("field \"InsertAll\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorInsertionStartIndices = new FieldHoldingArrayGeneratorInsertionStartIndices("field \"InsertionStartIndices\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorWordsToDelete = new JSONHoldingStringGenerator("field \"WordsToDelete\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorDeleteAll = new JSONHoldingBooleanGenerator("field \"DeleteAll\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorDeletionStartIndices = new FieldHoldingArrayGeneratorDeletionStartIndices("field \"DeletionStartIndices\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorSpokenErrorMessage = new JSONHoldingStringGenerator("field \"SpokenErrorMessage\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorWrittenErrorMessage = new JSONHoldingStringGenerator("field \"WrittenErrorMessage\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNewRecipientsAlreadyInSMS = new SMSContactResultJSON.HoldingArrayGenerator("field \"NewRecipientsAlreadyInSMS\" of the ComposeSMSCommandNativeData class", ignore_extras);
            fieldGeneratorNewRecipientsNotInSMS = new SMSContactResultJSON.HoldingArrayGenerator("field \"NewRecipientsNotInSMS\" of the ComposeSMSCommandNativeData class", ignore_extras);
            fieldGeneratorOverwroteBody = new JSONHoldingBooleanGenerator("field \"OverwroteBody\" of the ComposeSMSCommandNativeData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ComposeSMSCommandNativeData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSMS = new SMSJSON.HoldingGenerator("field \"SMS\" of the ComposeSMSCommandNativeData class", false);
            fieldGeneratorEmptyBodyOK = new JSONHoldingBooleanGenerator("field \"EmptyBodyOK\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorFocusHint = new FieldHoldingGeneratorFocusHint("field \"FocusHint\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorSendSMSNow = new JSONHoldingBooleanGenerator("field \"SendSMSNow\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorLastEditedTextFieldType = new SMSFieldTypeJSON.HoldingGenerator("field \"LastEditedTextFieldType\" of the ComposeSMSCommandNativeData class", false);
            fieldGeneratorSMSAlreadyHadRecipients = new JSONHoldingBooleanGenerator("field \"SMSAlreadyHadRecipients\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNewBody = new JSONHoldingStringGenerator("field \"NewBody\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNewRecipientsInfo = new TypeNewRecipientsInfoJSON.HoldingArrayGenerator("field \"NewRecipientsInfo\" of the ComposeSMSCommandNativeData class", false);
            fieldGeneratorSpokenMessageFromPreviousTransaction = new JSONHoldingStringGenerator("field \"SpokenMessageFromPreviousTransaction\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorAutoListen = new JSONHoldingBooleanGenerator("field \"AutoListen\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNotUnderstoodUsedWordTo = new JSONHoldingBooleanGenerator("field \"NotUnderstoodUsedWordTo\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNotUnderstoodWords = new JSONHoldingStringGenerator("field \"NotUnderstoodWords\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorDeleteType = new FieldHoldingGeneratorDeleteType("field \"DeleteType\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNumToDelete = new FieldHoldingGeneratorNumToDelete("field \"NumToDelete\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNumDeleted = new FieldHoldingGeneratorNumDeleted("field \"NumDeleted\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorDeleteFromBack = new JSONHoldingBooleanGenerator("field \"DeleteFromBack\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNothingToDelete = new JSONHoldingBooleanGenerator("field \"NothingToDelete\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorState = new SMSStateJSON.HoldingGenerator("field \"State\" of the ComposeSMSCommandNativeData class", false);
            fieldGeneratorEditBodyState = new FieldHoldingGeneratorEditBodyState("field \"EditBodyState\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorFirstTimeAddingToBody = new JSONHoldingBooleanGenerator("field \"FirstTimeAddingToBody\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorRecipientsAdded = new UnambiguousSMSRecipientJSON.HoldingArrayGenerator("field \"RecipientsAdded\" of the ComposeSMSCommandNativeData class", false);
            fieldGeneratorRecipientsRemoved = new UnambiguousSMSRecipientJSON.HoldingArrayGenerator("field \"RecipientsRemoved\" of the ComposeSMSCommandNativeData class", false);
            fieldGeneratorRecipientsCouldNotAdd = new UnambiguousSMSRecipientJSON.HoldingArrayGenerator("field \"RecipientsCouldNotAdd\" of the ComposeSMSCommandNativeData class", false);
            fieldGeneratorRecipientsCouldNotRemove = new SMSRecipientsJSON.HoldingArrayGenerator("field \"RecipientsCouldNotRemove\" of the ComposeSMSCommandNativeData class", false);
            fieldGeneratorOpenEndedEditRequest = new JSONHoldingBooleanGenerator("field \"OpenEndedEditRequest\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorOpenEndedEditRequestAction = new SMSContactResultActionJSON.HoldingGenerator("field \"OpenEndedEditRequestAction\" of the ComposeSMSCommandNativeData class", false);
            fieldGeneratorRemovedAllRecipients = new JSONHoldingBooleanGenerator("field \"RemovedAllRecipients\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorAlreadyHadRecipients = new JSONHoldingBooleanGenerator("field \"AlreadyHadRecipients\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNotUnderstoodType = new FieldHoldingGeneratorNotUnderstoodType("field \"NotUnderstoodType\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNotUnderstoodWordsFound = new JSONHoldingStringGenerator("field \"NotUnderstoodWordsFound\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorReadRecipients = new JSONHoldingBooleanGenerator("field \"ReadRecipients\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorReadBody = new JSONHoldingBooleanGenerator("field \"ReadBody\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorWordsToReplace = new JSONHoldingStringGenerator("field \"WordsToReplace\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorReplacementWords = new JSONHoldingStringGenerator("field \"ReplacementWords\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorReplaceAll = new JSONHoldingBooleanGenerator("field \"ReplaceAll\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorReplacementStartIndices = new FieldHoldingArrayGeneratorReplacementStartIndices("field \"ReplacementStartIndices\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorWordsToMatchForInsertion = new JSONHoldingStringGenerator("field \"WordsToMatchForInsertion\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorInsertionWords = new JSONHoldingStringGenerator("field \"InsertionWords\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorInsertBefore = new JSONHoldingBooleanGenerator("field \"InsertBefore\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorInsertAll = new JSONHoldingBooleanGenerator("field \"InsertAll\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorInsertionStartIndices = new FieldHoldingArrayGeneratorInsertionStartIndices("field \"InsertionStartIndices\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorWordsToDelete = new JSONHoldingStringGenerator("field \"WordsToDelete\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorDeleteAll = new JSONHoldingBooleanGenerator("field \"DeleteAll\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorDeletionStartIndices = new FieldHoldingArrayGeneratorDeletionStartIndices("field \"DeletionStartIndices\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorSpokenErrorMessage = new JSONHoldingStringGenerator("field \"SpokenErrorMessage\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorWrittenErrorMessage = new JSONHoldingStringGenerator("field \"WrittenErrorMessage\" of the ComposeSMSCommandNativeData class");
            fieldGeneratorNewRecipientsAlreadyInSMS = new SMSContactResultJSON.HoldingArrayGenerator("field \"NewRecipientsAlreadyInSMS\" of the ComposeSMSCommandNativeData class", false);
            fieldGeneratorNewRecipientsNotInSMS = new SMSContactResultJSON.HoldingArrayGenerator("field \"NewRecipientsNotInSMS\" of the ComposeSMSCommandNativeData class", false);
            fieldGeneratorOverwroteBody = new JSONHoldingBooleanGenerator("field \"OverwroteBody\" of the ComposeSMSCommandNativeData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ComposeSMSCommandNativeData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSMS.reset();
            fieldGeneratorEmptyBodyOK.reset();
            fieldGeneratorFocusHint.reset();
            fieldGeneratorSendSMSNow.reset();
            fieldGeneratorLastEditedTextFieldType.reset();
            fieldGeneratorSMSAlreadyHadRecipients.reset();
            fieldGeneratorNewBody.reset();
            fieldGeneratorNewRecipientsInfo.reset();
            fieldGeneratorSpokenMessageFromPreviousTransaction.reset();
            fieldGeneratorAutoListen.reset();
            fieldGeneratorNotUnderstoodUsedWordTo.reset();
            fieldGeneratorNotUnderstoodWords.reset();
            fieldGeneratorDeleteType.reset();
            fieldGeneratorNumToDelete.reset();
            fieldGeneratorNumDeleted.reset();
            fieldGeneratorDeleteFromBack.reset();
            fieldGeneratorNothingToDelete.reset();
            fieldGeneratorState.reset();
            fieldGeneratorEditBodyState.reset();
            fieldGeneratorFirstTimeAddingToBody.reset();
            fieldGeneratorRecipientsAdded.reset();
            fieldGeneratorRecipientsRemoved.reset();
            fieldGeneratorRecipientsCouldNotAdd.reset();
            fieldGeneratorRecipientsCouldNotRemove.reset();
            fieldGeneratorOpenEndedEditRequest.reset();
            fieldGeneratorOpenEndedEditRequestAction.reset();
            fieldGeneratorRemovedAllRecipients.reset();
            fieldGeneratorAlreadyHadRecipients.reset();
            fieldGeneratorNotUnderstoodType.reset();
            fieldGeneratorNotUnderstoodWordsFound.reset();
            fieldGeneratorReadRecipients.reset();
            fieldGeneratorReadBody.reset();
            fieldGeneratorWordsToReplace.reset();
            fieldGeneratorReplacementWords.reset();
            fieldGeneratorReplaceAll.reset();
            fieldGeneratorReplacementStartIndices.reset();
            fieldGeneratorWordsToMatchForInsertion.reset();
            fieldGeneratorInsertionWords.reset();
            fieldGeneratorInsertBefore.reset();
            fieldGeneratorInsertAll.reset();
            fieldGeneratorInsertionStartIndices.reset();
            fieldGeneratorWordsToDelete.reset();
            fieldGeneratorDeleteAll.reset();
            fieldGeneratorDeletionStartIndices.reset();
            fieldGeneratorSpokenErrorMessage.reset();
            fieldGeneratorWrittenErrorMessage.reset();
            fieldGeneratorNewRecipientsAlreadyInSMS.reset();
            fieldGeneratorNewRecipientsNotInSMS.reset();
            fieldGeneratorOverwroteBody.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSMS.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLastEditedTextFieldType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNewRecipientsInfo.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorState.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRecipientsAdded.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRecipientsRemoved.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRecipientsCouldNotAdd.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRecipientsCouldNotRemove.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOpenEndedEditRequestAction.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNewRecipientsAlreadyInSMS.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNewRecipientsNotInSMS.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSMS.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLastEditedTextFieldType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNewRecipientsInfo.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorState.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRecipientsAdded.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRecipientsRemoved.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRecipientsCouldNotAdd.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRecipientsCouldNotRemove.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOpenEndedEditRequestAction.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNewRecipientsAlreadyInSMS.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNewRecipientsNotInSMS.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ComposeSMSCommandNativeDataJSON  result)
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
        public ComposeSMSCommandNativeDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ComposeSMSCommandNativeDataJSON  result)
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
    protected virtual void handle_result(List<ComposeSMSCommandNativeDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ComposeSMSCommandNativeDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ComposeSMSCommandNativeDataJSON>();
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
    public List<ComposeSMSCommandNativeDataJSON> value;
  };
  };
