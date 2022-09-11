/* file "SMSConversationStateContentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SMSConversationStateContentJSON : JSONBase
  {
    public enum TypeCommandKind
      {
        CommandKind_ComposeSMSCommand,
        CommandKind_DiscardSMSCommand,
        CommandKind_SendSMSCommand,
        CommandKind_ShowSMSMessagesCommand
      };

    public static TypeCommandKind  stringToCommandKind(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "omposeSMSCommand", 0, 16, false) == 0) && (chars.Length == 17))
                    return TypeCommandKind.CommandKind_ComposeSMSCommand;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "iscardSMSCommand", 0, 16, false) == 0) && (chars.Length == 17))
                    return TypeCommandKind.CommandKind_DiscardSMSCommand;
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "ndSMSCommand", 0, 12, false) == 0) && (chars.Length == 14))
                            return TypeCommandKind.CommandKind_SendSMSCommand;
                        break;
                    case 'h':
                        if ((String.Compare(chars, 2, "owSMSMessagesCommand", 0, 20, false) == 0) && (chars.Length == 22))
                            return TypeCommandKind.CommandKind_ShowSMSMessagesCommand;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `CommandKind' is not one of the legal values.");
      }

    public static string  stringFromCommandKind(TypeCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeCommandKind.CommandKind_ComposeSMSCommand:
                return "ComposeSMSCommand";
            case TypeCommandKind.CommandKind_DiscardSMSCommand:
                return "DiscardSMSCommand";
            case TypeCommandKind.CommandKind_SendSMSCommand:
                return "SendSMSCommand";
            case TypeCommandKind.CommandKind_ShowSMSMessagesCommand:
                return "ShowSMSMessagesCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeComposeSMSCommandKind
      {
        ComposeSMSCommandKind_SMSAddNonspecificRecipientsCommand,
        ComposeSMSCommandKind_SMSCreateCommand,
        ComposeSMSCommandKind_SMSCreateWithNotUnderstoodArgsCommand,
        ComposeSMSCommandKind_SMSDeleteBodyCommand,
        ComposeSMSCommandKind_SMSDeleteMessageCommand,
        ComposeSMSCommandKind_SMSDeleteSentencesCommand,
        ComposeSMSCommandKind_SMSDeleteSpecificWordsCommand,
        ComposeSMSCommandKind_SMSDeleteWordsCommand,
        ComposeSMSCommandKind_SMSDiscardCommand,
        ComposeSMSCommandKind_SMSDoNotSendCommand,
        ComposeSMSCommandKind_SMSEditBodyCommand,
        ComposeSMSCommandKind_SMSEditRecipientsCommand,
        ComposeSMSCommandKind_SMSErrorCommand,
        ComposeSMSCommandKind_SMSInsertWordsCommand,
        ComposeSMSCommandKind_SMSNotUnderstoodCommand,
        ComposeSMSCommandKind_SMSReadBackCommand,
        ComposeSMSCommandKind_SMSRemoveAllRecipientsCommand,
        ComposeSMSCommandKind_SMSRemoveNonspecificRecipientsCommand,
        ComposeSMSCommandKind_SMSRemoveRecipientsFollowupCommand,
        ComposeSMSCommandKind_SMSReplaceWordsCommand,
        ComposeSMSCommandKind_SMSSendCommand,
        ComposeSMSCommandKind_SMSWordsToDeleteNotFoundCommand,
        ComposeSMSCommandKind_SMSWordsToMatchForInsertionNotFoundCommand,
        ComposeSMSCommandKind_SMSWordsToReplaceNotFoundCommand
      };

    public static TypeComposeSMSCommandKind  stringToComposeSMSCommandKind(string chars)
      {
        if (String.Compare(chars, 0, "SMS", 0, 3, false) == 0)
          {
            switch (chars[3])
              {
                case 'A':
                    if ((String.Compare(chars, 4, "ddNonspecificRecipientsCommand", 0, 30, false) == 0) && (chars.Length == 34))
                        return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSAddNonspecificRecipientsCommand;
                    break;
                case 'C':
                    if (String.Compare(chars, 4, "reate", 0, 5, false) == 0)
                      {
                        switch (chars[9])
                          {
                            case 'C':
                                if ((String.Compare(chars, 10, "ommand", 0, 6, false) == 0) && (chars.Length == 16))
                                    return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSCreateCommand;
                                break;
                            case 'W':
                                if ((String.Compare(chars, 10, "ithNotUnderstoodArgsCommand", 0, 27, false) == 0) && (chars.Length == 37))
                                    return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSCreateWithNotUnderstoodArgsCommand;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    switch (chars[4])
                      {
                        case 'e':
                            if (String.Compare(chars, 5, "lete", 0, 4, false) == 0)
                              {
                                switch (chars[9])
                                  {
                                    case 'B':
                                        if ((String.Compare(chars, 10, "odyCommand", 0, 10, false) == 0) && (chars.Length == 20))
                                            return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteBodyCommand;
                                        break;
                                    case 'M':
                                        if ((String.Compare(chars, 10, "essageCommand", 0, 13, false) == 0) && (chars.Length == 23))
                                            return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteMessageCommand;
                                        break;
                                    case 'S':
                                        switch (chars[10])
                                          {
                                            case 'e':
                                                if ((String.Compare(chars, 11, "ntencesCommand", 0, 14, false) == 0) && (chars.Length == 25))
                                                    return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteSentencesCommand;
                                                break;
                                            case 'p':
                                                if ((String.Compare(chars, 11, "ecificWordsCommand", 0, 18, false) == 0) && (chars.Length == 29))
                                                    return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteSpecificWordsCommand;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'W':
                                        if ((String.Compare(chars, 10, "ordsCommand", 0, 11, false) == 0) && (chars.Length == 21))
                                            return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteWordsCommand;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if ((String.Compare(chars, 5, "scardCommand", 0, 12, false) == 0) && (chars.Length == 17))
                                return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDiscardCommand;
                            break;
                        case 'o':
                            if ((String.Compare(chars, 5, "NotSendCommand", 0, 14, false) == 0) && (chars.Length == 19))
                                return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDoNotSendCommand;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    switch (chars[4])
                      {
                        case 'd':
                            if (String.Compare(chars, 5, "it", 0, 2, false) == 0)
                              {
                                switch (chars[7])
                                  {
                                    case 'B':
                                        if ((String.Compare(chars, 8, "odyCommand", 0, 10, false) == 0) && (chars.Length == 18))
                                            return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSEditBodyCommand;
                                        break;
                                    case 'R':
                                        if ((String.Compare(chars, 8, "ecipientsCommand", 0, 16, false) == 0) && (chars.Length == 24))
                                            return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSEditRecipientsCommand;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if ((String.Compare(chars, 5, "rorCommand", 0, 10, false) == 0) && (chars.Length == 15))
                                return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSErrorCommand;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    if ((String.Compare(chars, 4, "nsertWordsCommand", 0, 17, false) == 0) && (chars.Length == 21))
                        return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSInsertWordsCommand;
                    break;
                case 'N':
                    if ((String.Compare(chars, 4, "otUnderstoodCommand", 0, 19, false) == 0) && (chars.Length == 23))
                        return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSNotUnderstoodCommand;
                    break;
                case 'R':
                    if (String.Compare(chars, 4, "e", 0, 1, false) == 0)
                      {
                        switch (chars[5])
                          {
                            case 'a':
                                if ((String.Compare(chars, 6, "dBackCommand", 0, 12, false) == 0) && (chars.Length == 18))
                                    return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSReadBackCommand;
                                break;
                            case 'm':
                                if (String.Compare(chars, 6, "ove", 0, 3, false) == 0)
                                  {
                                    switch (chars[9])
                                      {
                                        case 'A':
                                            if ((String.Compare(chars, 10, "llRecipientsCommand", 0, 19, false) == 0) && (chars.Length == 29))
                                                return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSRemoveAllRecipientsCommand;
                                            break;
                                        case 'N':
                                            if ((String.Compare(chars, 10, "onspecificRecipientsCommand", 0, 27, false) == 0) && (chars.Length == 37))
                                                return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSRemoveNonspecificRecipientsCommand;
                                            break;
                                        case 'R':
                                            if ((String.Compare(chars, 10, "ecipientsFollowupCommand", 0, 24, false) == 0) && (chars.Length == 34))
                                                return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSRemoveRecipientsFollowupCommand;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'p':
                                if ((String.Compare(chars, 6, "laceWordsCommand", 0, 16, false) == 0) && (chars.Length == 22))
                                    return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSReplaceWordsCommand;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(chars, 4, "endCommand", 0, 10, false) == 0) && (chars.Length == 14))
                        return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSSendCommand;
                    break;
                case 'W':
                    if (String.Compare(chars, 4, "ordsTo", 0, 6, false) == 0)
                      {
                        switch (chars[10])
                          {
                            case 'D':
                                if ((String.Compare(chars, 11, "eleteNotFoundCommand", 0, 20, false) == 0) && (chars.Length == 31))
                                    return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSWordsToDeleteNotFoundCommand;
                                break;
                            case 'M':
                                if ((String.Compare(chars, 11, "atchForInsertionNotFoundCommand", 0, 31, false) == 0) && (chars.Length == 42))
                                    return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSWordsToMatchForInsertionNotFoundCommand;
                                break;
                            case 'R':
                                if ((String.Compare(chars, 11, "eplaceNotFoundCommand", 0, 21, false) == 0) && (chars.Length == 32))
                                    return TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSWordsToReplaceNotFoundCommand;
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
        throw new Exception("The value for field `ComposeSMSCommandKind' is not one of the legal values.");
      }

    public static string  stringFromComposeSMSCommandKind(TypeComposeSMSCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSAddNonspecificRecipientsCommand:
                return "SMSAddNonspecificRecipientsCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSCreateCommand:
                return "SMSCreateCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSCreateWithNotUnderstoodArgsCommand:
                return "SMSCreateWithNotUnderstoodArgsCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteBodyCommand:
                return "SMSDeleteBodyCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteMessageCommand:
                return "SMSDeleteMessageCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteSentencesCommand:
                return "SMSDeleteSentencesCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteSpecificWordsCommand:
                return "SMSDeleteSpecificWordsCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteWordsCommand:
                return "SMSDeleteWordsCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDiscardCommand:
                return "SMSDiscardCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDoNotSendCommand:
                return "SMSDoNotSendCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSEditBodyCommand:
                return "SMSEditBodyCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSEditRecipientsCommand:
                return "SMSEditRecipientsCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSErrorCommand:
                return "SMSErrorCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSInsertWordsCommand:
                return "SMSInsertWordsCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSNotUnderstoodCommand:
                return "SMSNotUnderstoodCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSReadBackCommand:
                return "SMSReadBackCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSRemoveAllRecipientsCommand:
                return "SMSRemoveAllRecipientsCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSRemoveNonspecificRecipientsCommand:
                return "SMSRemoveNonspecificRecipientsCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSRemoveRecipientsFollowupCommand:
                return "SMSRemoveRecipientsFollowupCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSReplaceWordsCommand:
                return "SMSReplaceWordsCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSSendCommand:
                return "SMSSendCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSWordsToDeleteNotFoundCommand:
                return "SMSWordsToDeleteNotFoundCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSWordsToMatchForInsertionNotFoundCommand:
                return "SMSWordsToMatchForInsertionNotFoundCommand";
            case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSWordsToReplaceNotFoundCommand:
                return "SMSWordsToReplaceNotFoundCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypePropagatedDataJSON : JSONBase
      {
        private bool flagHasSMS;
        private SMSJSON  storeSMS;
        private bool flagHasEmptyBodyOK;
        private bool storeEmptyBodyOK;
        private bool flagHasLastEditedTextFieldType;
        private SMSFieldTypeJSON  storeLastEditedTextFieldType;
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
                    throw new Exception("The value for field EmptyBodyOK of TypePropagatedDataJSON is not true for false.");
                  }
              }
            setEmptyBodyOK(the_bool);
          }


        private void  fromJSONLastEditedTextFieldType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SMSFieldTypeJSON convert_classy = SMSFieldTypeJSON.from_json(json_value, ignore_extras, true);
            setLastEditedTextFieldType(convert_classy);
          }


        public TypePropagatedDataJSON()
          {
            flagHasSMS = false;
            flagHasEmptyBodyOK = false;
            flagHasLastEditedTextFieldType = false;
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


        public virtual int extraTypePropagatedDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePropagatedDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePropagatedDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePropagatedDataLookup(string field_name)
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

        public virtual void extraTypePropagatedDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePropagatedDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePropagatedDataLookup(key);
            if (old_field == null)
              {
                extraTypePropagatedDataAppendPair(key, new_component);
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
            if (flagHasLastEditedTextFieldType)
              {
                handler.start_pair("LastEditedTextFieldType");
                if (partial_allowed)
                    storeLastEditedTextFieldType.write_partial_as_json(handler);
                else
                    storeLastEditedTextFieldType.write_as_json(handler);
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
            return null;
          }

        public static TypePropagatedDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePropagatedDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePropagatedData", ignore_extras);
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
        public static TypePropagatedDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePropagatedDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePropagatedDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePropagatedData", ignore_extras);
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
        public static TypePropagatedDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePropagatedDataJSON from_text(string text, bool ignore_extras)
          {
            TypePropagatedDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePropagatedData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePropagatedDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePropagatedDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePropagatedDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePropagatedData", ignore_extras);
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
            private SMSFieldTypeJSON.HoldingGenerator fieldGeneratorLastEditedTextFieldType;
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
                TypePropagatedDataJSON result = new TypePropagatedDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePropagatedDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePropagatedDataJSON result)
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
                if (fieldGeneratorLastEditedTextFieldType.have_value)
                  {
                    result.setLastEditedTextFieldType(fieldGeneratorLastEditedTextFieldType.value);
                    fieldGeneratorLastEditedTextFieldType.have_value = false;
                  }
              }
            protected abstract void handle_result(TypePropagatedDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'E':
                        if ((String.Compare(field_name, 1, "mptyBodyOK", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorEmptyBodyOK;
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 1, "astEditedTextFieldType", 0, 22, false) == 0) && (field_name.Length == 23))
                            return fieldGeneratorLastEditedTextFieldType;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "MS", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorSMS;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorSMS = new SMSJSON.HoldingGenerator("field \"SMS\" of the TypePropagatedData class", ignore_extras);
                fieldGeneratorEmptyBodyOK = new JSONHoldingBooleanGenerator("field \"EmptyBodyOK\" of the TypePropagatedData class");
                fieldGeneratorLastEditedTextFieldType = new SMSFieldTypeJSON.HoldingGenerator("field \"LastEditedTextFieldType\" of the TypePropagatedData class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePropagatedData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorSMS = new SMSJSON.HoldingGenerator("field \"SMS\" of the TypePropagatedData class", false);
                fieldGeneratorEmptyBodyOK = new JSONHoldingBooleanGenerator("field \"EmptyBodyOK\" of the TypePropagatedData class");
                fieldGeneratorLastEditedTextFieldType = new SMSFieldTypeJSON.HoldingGenerator("field \"LastEditedTextFieldType\" of the TypePropagatedData class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePropagatedData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorSMS.reset();
                fieldGeneratorEmptyBodyOK.reset();
                fieldGeneratorLastEditedTextFieldType.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorSMS.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorLastEditedTextFieldType.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorSMS.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorLastEditedTextFieldType.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypePropagatedDataJSON  result)
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
            public TypePropagatedDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePropagatedDataJSON  result)
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
        protected virtual void handle_result(List<TypePropagatedDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePropagatedDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePropagatedDataJSON>();
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
        public List<TypePropagatedDataJSON> value;
      };
      };
    public enum TypeSMSDynamicResponseKind
      {
        SMSDynamicResponseKind_NoSMSAppResult,
        SMSDynamicResponseKind_ComposeSMSResult,
        SMSDynamicResponseKind_DisambiguatePhoneNumberResult,
        SMSDynamicResponseKind_SendingSMSResult,
        SMSDynamicResponseKind_SentSMSResult,
        SMSDynamicResponseKind_ExitSMSResult,
        SMSDynamicResponseKind_Succeeded,
        SMSDynamicResponseKind_Failed
      };

    public static TypeSMSDynamicResponseKind  stringToSMSDynamicResponseKind(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "omposeSMSResult", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeSMSDynamicResponseKind.SMSDynamicResponseKind_ComposeSMSResult;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "isambiguatePhoneNumberResult", 0, 28, false) == 0) && (chars.Length == 29))
                    return TypeSMSDynamicResponseKind.SMSDynamicResponseKind_DisambiguatePhoneNumberResult;
                break;
            case 'E':
                if ((String.Compare(chars, 1, "xitSMSResult", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeSMSDynamicResponseKind.SMSDynamicResponseKind_ExitSMSResult;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "ailed", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeSMSDynamicResponseKind.SMSDynamicResponseKind_Failed;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "oSMSAppResult", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeSMSDynamicResponseKind.SMSDynamicResponseKind_NoSMSAppResult;
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'e':
                        if (String.Compare(chars, 2, "n", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'd':
                                    if ((String.Compare(chars, 4, "ingSMSResult", 0, 12, false) == 0) && (chars.Length == 16))
                                        return TypeSMSDynamicResponseKind.SMSDynamicResponseKind_SendingSMSResult;
                                    break;
                                case 't':
                                    if ((String.Compare(chars, 4, "SMSResult", 0, 9, false) == 0) && (chars.Length == 13))
                                        return TypeSMSDynamicResponseKind.SMSDynamicResponseKind_SentSMSResult;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "cceeded", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeSMSDynamicResponseKind.SMSDynamicResponseKind_Succeeded;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `SMSDynamicResponseKind' is not one of the legal values.");
      }

    public static string  stringFromSMSDynamicResponseKind(TypeSMSDynamicResponseKind the_enum)
      {
        switch (the_enum)
          {
            case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_NoSMSAppResult:
                return "NoSMSAppResult";
            case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_ComposeSMSResult:
                return "ComposeSMSResult";
            case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_DisambiguatePhoneNumberResult:
                return "DisambiguatePhoneNumberResult";
            case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_SendingSMSResult:
                return "SendingSMSResult";
            case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_SentSMSResult:
                return "SentSMSResult";
            case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_ExitSMSResult:
                return "ExitSMSResult";
            case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_Succeeded:
                return "Succeeded";
            case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_Failed:
                return "Failed";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCommandKind;
    private TypeCommandKind storeCommandKind;
    private bool flagHasComposeSMSCommandKind;
    private TypeComposeSMSCommandKind storeComposeSMSCommandKind;
    private bool flagHasPropagatedData;
    private TypePropagatedDataJSON  storePropagatedData;
    private bool flagHasState;
    private SMSStateJSON  storeState;
    private bool flagHasSMSDynamicResponseKind;
    private TypeSMSDynamicResponseKind storeSMSDynamicResponseKind;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandKind of SMSConversationStateContentJSON is not a string.");
        TypeCommandKind the_enum;
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "omposeSMSCommand", 0, 16, false) == 0) && (json_string.getData().Length == 17))
                      {
                        the_enum = TypeCommandKind.CommandKind_ComposeSMSCommand;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "iscardSMSCommand", 0, 16, false) == 0) && (json_string.getData().Length == 17))
                      {
                        the_enum = TypeCommandKind.CommandKind_DiscardSMSCommand;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "ndSMSCommand", 0, 12, false) == 0) && (json_string.getData().Length == 14))
                              {
                                the_enum = TypeCommandKind.CommandKind_SendSMSCommand;
                                goto enum_is_done;
                              }
                        break;
                    case 'h':
                        if ((String.Compare(json_string.getData(), 2, "owSMSMessagesCommand", 0, 20, false) == 0) && (json_string.getData().Length == 22))
                              {
                                the_enum = TypeCommandKind.CommandKind_ShowSMSMessagesCommand;
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
        throw new Exception("The value for field CommandKind of SMSConversationStateContentJSON is not one of the legal strings.");
      enum_is_done:;
        setCommandKind(the_enum);
      }


    private void  fromJSONComposeSMSCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ComposeSMSCommandKind of SMSConversationStateContentJSON is not a string.");
        TypeComposeSMSCommandKind the_enum;
        if (String.Compare(json_string.getData(), 0, "SMS", 0, 3, false) == 0)
          {
            switch (json_string.getData()[3])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 4, "ddNonspecificRecipientsCommand", 0, 30, false) == 0) && (json_string.getData().Length == 34))
                          {
                            the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSAddNonspecificRecipientsCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'C':
                    if (String.Compare(json_string.getData(), 4, "reate", 0, 5, false) == 0)
                      {
                        switch (json_string.getData()[9])
                          {
                            case 'C':
                                if ((String.Compare(json_string.getData(), 10, "ommand", 0, 6, false) == 0) && (json_string.getData().Length == 16))
                                      {
                                        the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSCreateCommand;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'W':
                                if ((String.Compare(json_string.getData(), 10, "ithNotUnderstoodArgsCommand", 0, 27, false) == 0) && (json_string.getData().Length == 37))
                                      {
                                        the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSCreateWithNotUnderstoodArgsCommand;
                                        goto enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    switch (json_string.getData()[4])
                      {
                        case 'e':
                            if (String.Compare(json_string.getData(), 5, "lete", 0, 4, false) == 0)
                              {
                                switch (json_string.getData()[9])
                                  {
                                    case 'B':
                                        if ((String.Compare(json_string.getData(), 10, "odyCommand", 0, 10, false) == 0) && (json_string.getData().Length == 20))
                                              {
                                                the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteBodyCommand;
                                                goto enum_is_done;
                                              }
                                        break;
                                    case 'M':
                                        if ((String.Compare(json_string.getData(), 10, "essageCommand", 0, 13, false) == 0) && (json_string.getData().Length == 23))
                                              {
                                                the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteMessageCommand;
                                                goto enum_is_done;
                                              }
                                        break;
                                    case 'S':
                                        switch (json_string.getData()[10])
                                          {
                                            case 'e':
                                                if ((String.Compare(json_string.getData(), 11, "ntencesCommand", 0, 14, false) == 0) && (json_string.getData().Length == 25))
                                                      {
                                                        the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteSentencesCommand;
                                                        goto enum_is_done;
                                                      }
                                                break;
                                            case 'p':
                                                if ((String.Compare(json_string.getData(), 11, "ecificWordsCommand", 0, 18, false) == 0) && (json_string.getData().Length == 29))
                                                      {
                                                        the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteSpecificWordsCommand;
                                                        goto enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'W':
                                        if ((String.Compare(json_string.getData(), 10, "ordsCommand", 0, 11, false) == 0) && (json_string.getData().Length == 21))
                                              {
                                                the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteWordsCommand;
                                                goto enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if ((String.Compare(json_string.getData(), 5, "scardCommand", 0, 12, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDiscardCommand;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'o':
                            if ((String.Compare(json_string.getData(), 5, "NotSendCommand", 0, 14, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDoNotSendCommand;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    switch (json_string.getData()[4])
                      {
                        case 'd':
                            if (String.Compare(json_string.getData(), 5, "it", 0, 2, false) == 0)
                              {
                                switch (json_string.getData()[7])
                                  {
                                    case 'B':
                                        if ((String.Compare(json_string.getData(), 8, "odyCommand", 0, 10, false) == 0) && (json_string.getData().Length == 18))
                                              {
                                                the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSEditBodyCommand;
                                                goto enum_is_done;
                                              }
                                        break;
                                    case 'R':
                                        if ((String.Compare(json_string.getData(), 8, "ecipientsCommand", 0, 16, false) == 0) && (json_string.getData().Length == 24))
                                              {
                                                the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSEditRecipientsCommand;
                                                goto enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if ((String.Compare(json_string.getData(), 5, "rorCommand", 0, 10, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSErrorCommand;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    if ((String.Compare(json_string.getData(), 4, "nsertWordsCommand", 0, 17, false) == 0) && (json_string.getData().Length == 21))
                          {
                            the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSInsertWordsCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'N':
                    if ((String.Compare(json_string.getData(), 4, "otUnderstoodCommand", 0, 19, false) == 0) && (json_string.getData().Length == 23))
                          {
                            the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSNotUnderstoodCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'R':
                    if (String.Compare(json_string.getData(), 4, "e", 0, 1, false) == 0)
                      {
                        switch (json_string.getData()[5])
                          {
                            case 'a':
                                if ((String.Compare(json_string.getData(), 6, "dBackCommand", 0, 12, false) == 0) && (json_string.getData().Length == 18))
                                      {
                                        the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSReadBackCommand;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'm':
                                if (String.Compare(json_string.getData(), 6, "ove", 0, 3, false) == 0)
                                  {
                                    switch (json_string.getData()[9])
                                      {
                                        case 'A':
                                            if ((String.Compare(json_string.getData(), 10, "llRecipientsCommand", 0, 19, false) == 0) && (json_string.getData().Length == 29))
                                                  {
                                                    the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSRemoveAllRecipientsCommand;
                                                    goto enum_is_done;
                                                  }
                                            break;
                                        case 'N':
                                            if ((String.Compare(json_string.getData(), 10, "onspecificRecipientsCommand", 0, 27, false) == 0) && (json_string.getData().Length == 37))
                                                  {
                                                    the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSRemoveNonspecificRecipientsCommand;
                                                    goto enum_is_done;
                                                  }
                                            break;
                                        case 'R':
                                            if ((String.Compare(json_string.getData(), 10, "ecipientsFollowupCommand", 0, 24, false) == 0) && (json_string.getData().Length == 34))
                                                  {
                                                    the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSRemoveRecipientsFollowupCommand;
                                                    goto enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'p':
                                if ((String.Compare(json_string.getData(), 6, "laceWordsCommand", 0, 16, false) == 0) && (json_string.getData().Length == 22))
                                      {
                                        the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSReplaceWordsCommand;
                                        goto enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 4, "endCommand", 0, 10, false) == 0) && (json_string.getData().Length == 14))
                          {
                            the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSSendCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'W':
                    if (String.Compare(json_string.getData(), 4, "ordsTo", 0, 6, false) == 0)
                      {
                        switch (json_string.getData()[10])
                          {
                            case 'D':
                                if ((String.Compare(json_string.getData(), 11, "eleteNotFoundCommand", 0, 20, false) == 0) && (json_string.getData().Length == 31))
                                      {
                                        the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSWordsToDeleteNotFoundCommand;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'M':
                                if ((String.Compare(json_string.getData(), 11, "atchForInsertionNotFoundCommand", 0, 31, false) == 0) && (json_string.getData().Length == 42))
                                      {
                                        the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSWordsToMatchForInsertionNotFoundCommand;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'R':
                                if ((String.Compare(json_string.getData(), 11, "eplaceNotFoundCommand", 0, 21, false) == 0) && (json_string.getData().Length == 32))
                                      {
                                        the_enum = TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSWordsToReplaceNotFoundCommand;
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
        throw new Exception("The value for field ComposeSMSCommandKind of SMSConversationStateContentJSON is not one of the legal strings.");
      enum_is_done:;
        setComposeSMSCommandKind(the_enum);
      }


    private void  fromJSONPropagatedData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePropagatedDataJSON convert_classy = TypePropagatedDataJSON.from_json(json_value, ignore_extras, true);
        setPropagatedData(convert_classy);
      }


    private void  fromJSONState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SMSStateJSON convert_classy = SMSStateJSON.from_json(json_value, ignore_extras, true);
        setState(convert_classy);
      }


    private void  fromJSONSMSDynamicResponseKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SMSDynamicResponseKind of SMSConversationStateContentJSON is not a string.");
        TypeSMSDynamicResponseKind the_enum;
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "omposeSMSResult", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_enum = TypeSMSDynamicResponseKind.SMSDynamicResponseKind_ComposeSMSResult;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "isambiguatePhoneNumberResult", 0, 28, false) == 0) && (json_string.getData().Length == 29))
                      {
                        the_enum = TypeSMSDynamicResponseKind.SMSDynamicResponseKind_DisambiguatePhoneNumberResult;
                        goto enum_is_done;
                      }
                break;
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "xitSMSResult", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_enum = TypeSMSDynamicResponseKind.SMSDynamicResponseKind_ExitSMSResult;
                        goto enum_is_done;
                      }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "ailed", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeSMSDynamicResponseKind.SMSDynamicResponseKind_Failed;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "oSMSAppResult", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_enum = TypeSMSDynamicResponseKind.SMSDynamicResponseKind_NoSMSAppResult;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "n", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'd':
                                    if ((String.Compare(json_string.getData(), 4, "ingSMSResult", 0, 12, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_enum = TypeSMSDynamicResponseKind.SMSDynamicResponseKind_SendingSMSResult;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 't':
                                    if ((String.Compare(json_string.getData(), 4, "SMSResult", 0, 9, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_enum = TypeSMSDynamicResponseKind.SMSDynamicResponseKind_SentSMSResult;
                                            goto enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "cceeded", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_enum = TypeSMSDynamicResponseKind.SMSDynamicResponseKind_Succeeded;
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
        throw new Exception("The value for field SMSDynamicResponseKind of SMSConversationStateContentJSON is not one of the legal strings.");
      enum_is_done:;
        setSMSDynamicResponseKind(the_enum);
      }


    public SMSConversationStateContentJSON()
      {
        flagHasCommandKind = false;
        flagHasComposeSMSCommandKind = false;
        flagHasPropagatedData = false;
        flagHasState = false;
        flagHasSMSDynamicResponseKind = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCommandKind()
      {
        return flagHasCommandKind;
      }

    public TypeCommandKind  getCommandKind()
      {
        Debug.Assert(flagHasCommandKind);
        return storeCommandKind;
      }

    public string  getCommandKindAsString()
      {
        return stringFromCommandKind(getCommandKind());
      }

    public bool  hasComposeSMSCommandKind()
      {
        return flagHasComposeSMSCommandKind;
      }

    public TypeComposeSMSCommandKind  getComposeSMSCommandKind()
      {
        Debug.Assert(flagHasComposeSMSCommandKind);
        return storeComposeSMSCommandKind;
      }

    public string  getComposeSMSCommandKindAsString()
      {
        return stringFromComposeSMSCommandKind(getComposeSMSCommandKind());
      }

    public bool  hasPropagatedData()
      {
        return flagHasPropagatedData;
      }

    public TypePropagatedDataJSON   getPropagatedData()
      {
        Debug.Assert(flagHasPropagatedData);
        return storePropagatedData;
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

    public bool  hasSMSDynamicResponseKind()
      {
        return flagHasSMSDynamicResponseKind;
      }

    public TypeSMSDynamicResponseKind  getSMSDynamicResponseKind()
      {
        Debug.Assert(flagHasSMSDynamicResponseKind);
        return storeSMSDynamicResponseKind;
      }

    public string  getSMSDynamicResponseKindAsString()
      {
        return stringFromSMSDynamicResponseKind(getSMSDynamicResponseKind());
      }


    public virtual int extraSMSConversationStateContentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSMSConversationStateContentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSMSConversationStateContentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSMSConversationStateContentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCommandKind(TypeCommandKind new_value)
      {
        flagHasCommandKind = true;
        storeCommandKind = new_value;
      }
    public void setCommandKind(string chars)
      {
        setCommandKind(stringToCommandKind(chars));
      }
    public void unsetCommandKind()
      {
        flagHasCommandKind = false;
      }
    public void setComposeSMSCommandKind(TypeComposeSMSCommandKind new_value)
      {
        flagHasComposeSMSCommandKind = true;
        storeComposeSMSCommandKind = new_value;
      }
    public void setComposeSMSCommandKind(string chars)
      {
        setComposeSMSCommandKind(stringToComposeSMSCommandKind(chars));
      }
    public void unsetComposeSMSCommandKind()
      {
        flagHasComposeSMSCommandKind = false;
      }
    public void setPropagatedData(TypePropagatedDataJSON  new_value)
      {
        if (flagHasPropagatedData)
          {
          }
        flagHasPropagatedData = true;
        storePropagatedData = new_value;
      }
    public void unsetPropagatedData()
      {
        if (flagHasPropagatedData)
          {
          }
        flagHasPropagatedData = false;
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
    public void setSMSDynamicResponseKind(TypeSMSDynamicResponseKind new_value)
      {
        flagHasSMSDynamicResponseKind = true;
        storeSMSDynamicResponseKind = new_value;
      }
    public void setSMSDynamicResponseKind(string chars)
      {
        setSMSDynamicResponseKind(stringToSMSDynamicResponseKind(chars));
      }
    public void unsetSMSDynamicResponseKind()
      {
        flagHasSMSDynamicResponseKind = false;
      }

    public virtual void extraSMSConversationStateContentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSMSConversationStateContentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSMSConversationStateContentLookup(key);
        if (old_field == null)
          {
            extraSMSConversationStateContentAppendPair(key, new_component);
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
        if (flagHasCommandKind)
          {
            handler.start_pair("CommandKind");
            switch (storeCommandKind)
              {
                case TypeCommandKind.CommandKind_ComposeSMSCommand:
                    handler.string_value("ComposeSMSCommand");
                    break;
                case TypeCommandKind.CommandKind_DiscardSMSCommand:
                    handler.string_value("DiscardSMSCommand");
                    break;
                case TypeCommandKind.CommandKind_SendSMSCommand:
                    handler.string_value("SendSMSCommand");
                    break;
                case TypeCommandKind.CommandKind_ShowSMSMessagesCommand:
                    handler.string_value("ShowSMSMessagesCommand");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasComposeSMSCommandKind)
          {
            handler.start_pair("ComposeSMSCommandKind");
            switch (storeComposeSMSCommandKind)
              {
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSAddNonspecificRecipientsCommand:
                    handler.string_value("SMSAddNonspecificRecipientsCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSCreateCommand:
                    handler.string_value("SMSCreateCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSCreateWithNotUnderstoodArgsCommand:
                    handler.string_value("SMSCreateWithNotUnderstoodArgsCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteBodyCommand:
                    handler.string_value("SMSDeleteBodyCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteMessageCommand:
                    handler.string_value("SMSDeleteMessageCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteSentencesCommand:
                    handler.string_value("SMSDeleteSentencesCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteSpecificWordsCommand:
                    handler.string_value("SMSDeleteSpecificWordsCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDeleteWordsCommand:
                    handler.string_value("SMSDeleteWordsCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDiscardCommand:
                    handler.string_value("SMSDiscardCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSDoNotSendCommand:
                    handler.string_value("SMSDoNotSendCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSEditBodyCommand:
                    handler.string_value("SMSEditBodyCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSEditRecipientsCommand:
                    handler.string_value("SMSEditRecipientsCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSErrorCommand:
                    handler.string_value("SMSErrorCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSInsertWordsCommand:
                    handler.string_value("SMSInsertWordsCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSNotUnderstoodCommand:
                    handler.string_value("SMSNotUnderstoodCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSReadBackCommand:
                    handler.string_value("SMSReadBackCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSRemoveAllRecipientsCommand:
                    handler.string_value("SMSRemoveAllRecipientsCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSRemoveNonspecificRecipientsCommand:
                    handler.string_value("SMSRemoveNonspecificRecipientsCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSRemoveRecipientsFollowupCommand:
                    handler.string_value("SMSRemoveRecipientsFollowupCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSReplaceWordsCommand:
                    handler.string_value("SMSReplaceWordsCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSSendCommand:
                    handler.string_value("SMSSendCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSWordsToDeleteNotFoundCommand:
                    handler.string_value("SMSWordsToDeleteNotFoundCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSWordsToMatchForInsertionNotFoundCommand:
                    handler.string_value("SMSWordsToMatchForInsertionNotFoundCommand");
                    break;
                case TypeComposeSMSCommandKind.ComposeSMSCommandKind_SMSWordsToReplaceNotFoundCommand:
                    handler.string_value("SMSWordsToReplaceNotFoundCommand");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasPropagatedData)
          {
            handler.start_pair("PropagatedData");
            if (partial_allowed)
                storePropagatedData.write_partial_as_json(handler);
            else
                storePropagatedData.write_as_json(handler);
          }
        if (flagHasState)
          {
            handler.start_pair("State");
            if (partial_allowed)
                storeState.write_partial_as_json(handler);
            else
                storeState.write_as_json(handler);
          }
        if (flagHasSMSDynamicResponseKind)
          {
            handler.start_pair("SMSDynamicResponseKind");
            switch (storeSMSDynamicResponseKind)
              {
                case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_NoSMSAppResult:
                    handler.string_value("NoSMSAppResult");
                    break;
                case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_ComposeSMSResult:
                    handler.string_value("ComposeSMSResult");
                    break;
                case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_DisambiguatePhoneNumberResult:
                    handler.string_value("DisambiguatePhoneNumberResult");
                    break;
                case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_SendingSMSResult:
                    handler.string_value("SendingSMSResult");
                    break;
                case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_SentSMSResult:
                    handler.string_value("SentSMSResult");
                    break;
                case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_ExitSMSResult:
                    handler.string_value("ExitSMSResult");
                    break;
                case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_Succeeded:
                    handler.string_value("Succeeded");
                    break;
                case TypeSMSDynamicResponseKind.SMSDynamicResponseKind_Failed:
                    handler.string_value("Failed");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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
        return null;
      }

    public static SMSConversationStateContentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSConversationStateContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSConversationStateContent", ignore_extras);
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
    public static SMSConversationStateContentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSConversationStateContentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSConversationStateContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSConversationStateContent", ignore_extras);
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
    public static SMSConversationStateContentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSConversationStateContentJSON from_text(string text, bool ignore_extras)
      {
        SMSConversationStateContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSConversationStateContent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SMSConversationStateContentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SMSConversationStateContentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SMSConversationStateContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSConversationStateContent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCommandKind(result));
              }
            protected abstract void handle_result(TypeCommandKind result);
          };
    private class FieldHoldingGeneratorCommandKind : FieldGeneratorCommandKind
  {
    protected override void handle_result(TypeCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCommandKind(String what)
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
    public TypeCommandKind value;
  };
    private class FieldHoldingArrayGeneratorCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCommandKind
      {
        private FieldHoldingArrayGeneratorCommandKind top;

        protected override void handle_result(TypeCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCommandKind init_top)
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
    protected virtual void handle_result(List<TypeCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCommandKind> value;
  };
        private FieldHoldingGeneratorCommandKind fieldGeneratorCommandKind;
    private abstract class FieldGeneratorComposeSMSCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorComposeSMSCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorComposeSMSCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToComposeSMSCommandKind(result));
              }
            protected abstract void handle_result(TypeComposeSMSCommandKind result);
          };
    private class FieldHoldingGeneratorComposeSMSCommandKind : FieldGeneratorComposeSMSCommandKind
  {
    protected override void handle_result(TypeComposeSMSCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorComposeSMSCommandKind(String what)
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
    public TypeComposeSMSCommandKind value;
  };
    private class FieldHoldingArrayGeneratorComposeSMSCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorComposeSMSCommandKind
      {
        private FieldHoldingArrayGeneratorComposeSMSCommandKind top;

        protected override void handle_result(TypeComposeSMSCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorComposeSMSCommandKind init_top)
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
    protected virtual void handle_result(List<TypeComposeSMSCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorComposeSMSCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeComposeSMSCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorComposeSMSCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeComposeSMSCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeComposeSMSCommandKind> value;
  };
        private FieldHoldingGeneratorComposeSMSCommandKind fieldGeneratorComposeSMSCommandKind;
        private TypePropagatedDataJSON.HoldingGenerator fieldGeneratorPropagatedData;
        private SMSStateJSON.HoldingGenerator fieldGeneratorState;
    private abstract class FieldGeneratorSMSDynamicResponseKind : JSONStringGenerator
          {
            protected FieldGeneratorSMSDynamicResponseKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSMSDynamicResponseKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToSMSDynamicResponseKind(result));
              }
            protected abstract void handle_result(TypeSMSDynamicResponseKind result);
          };
    private class FieldHoldingGeneratorSMSDynamicResponseKind : FieldGeneratorSMSDynamicResponseKind
  {
    protected override void handle_result(TypeSMSDynamicResponseKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSMSDynamicResponseKind(String what)
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
    public TypeSMSDynamicResponseKind value;
  };
    private class FieldHoldingArrayGeneratorSMSDynamicResponseKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSMSDynamicResponseKind
      {
        private FieldHoldingArrayGeneratorSMSDynamicResponseKind top;

        protected override void handle_result(TypeSMSDynamicResponseKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSMSDynamicResponseKind init_top)
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
    protected virtual void handle_result(List<TypeSMSDynamicResponseKind> result)
      {
      }

    public FieldHoldingArrayGeneratorSMSDynamicResponseKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSMSDynamicResponseKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSMSDynamicResponseKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSMSDynamicResponseKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSMSDynamicResponseKind> value;
  };
        private FieldHoldingGeneratorSMSDynamicResponseKind fieldGeneratorSMSDynamicResponseKind;
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
            SMSConversationStateContentJSON result = new SMSConversationStateContentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSMSConversationStateContentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SMSConversationStateContentJSON result)
          {
            if (fieldGeneratorCommandKind.have_value)
              {
                result.setCommandKind(fieldGeneratorCommandKind.value);
                fieldGeneratorCommandKind.have_value = false;
              }
            if (fieldGeneratorComposeSMSCommandKind.have_value)
              {
                result.setComposeSMSCommandKind(fieldGeneratorComposeSMSCommandKind.value);
                fieldGeneratorComposeSMSCommandKind.have_value = false;
              }
            if (fieldGeneratorPropagatedData.have_value)
              {
                result.setPropagatedData(fieldGeneratorPropagatedData.value);
                fieldGeneratorPropagatedData.have_value = false;
              }
            if (fieldGeneratorState.have_value)
              {
                result.setState(fieldGeneratorState.value);
                fieldGeneratorState.have_value = false;
              }
            if (fieldGeneratorSMSDynamicResponseKind.have_value)
              {
                result.setSMSDynamicResponseKind(fieldGeneratorSMSDynamicResponseKind.value);
                fieldGeneratorSMSDynamicResponseKind.have_value = false;
              }
          }
        protected abstract void handle_result(SMSConversationStateContentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "om", 0, 2, false) == 0)
                      {
                        switch (field_name[3])
                          {
                            case 'm':
                                if ((String.Compare(field_name, 4, "andKind", 0, 7, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorCommandKind;
                                break;
                            case 'p':
                                if ((String.Compare(field_name, 4, "oseSMSCommandKind", 0, 17, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorComposeSMSCommandKind;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ropagatedData", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorPropagatedData;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'M':
                            if ((String.Compare(field_name, 2, "SDynamicResponseKind", 0, 20, false) == 0) && (field_name.Length == 22))
                                return fieldGeneratorSMSDynamicResponseKind;
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
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the SMSConversationStateContent class");
            fieldGeneratorComposeSMSCommandKind = new FieldHoldingGeneratorComposeSMSCommandKind("field \"ComposeSMSCommandKind\" of the SMSConversationStateContent class");
            fieldGeneratorPropagatedData = new TypePropagatedDataJSON.HoldingGenerator("field \"PropagatedData\" of the SMSConversationStateContent class", ignore_extras);
            fieldGeneratorState = new SMSStateJSON.HoldingGenerator("field \"State\" of the SMSConversationStateContent class", ignore_extras);
            fieldGeneratorSMSDynamicResponseKind = new FieldHoldingGeneratorSMSDynamicResponseKind("field \"SMSDynamicResponseKind\" of the SMSConversationStateContent class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SMSConversationStateContent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the SMSConversationStateContent class");
            fieldGeneratorComposeSMSCommandKind = new FieldHoldingGeneratorComposeSMSCommandKind("field \"ComposeSMSCommandKind\" of the SMSConversationStateContent class");
            fieldGeneratorPropagatedData = new TypePropagatedDataJSON.HoldingGenerator("field \"PropagatedData\" of the SMSConversationStateContent class", false);
            fieldGeneratorState = new SMSStateJSON.HoldingGenerator("field \"State\" of the SMSConversationStateContent class", false);
            fieldGeneratorSMSDynamicResponseKind = new FieldHoldingGeneratorSMSDynamicResponseKind("field \"SMSDynamicResponseKind\" of the SMSConversationStateContent class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SMSConversationStateContent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCommandKind.reset();
            fieldGeneratorComposeSMSCommandKind.reset();
            fieldGeneratorPropagatedData.reset();
            fieldGeneratorState.reset();
            fieldGeneratorSMSDynamicResponseKind.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPropagatedData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorState.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPropagatedData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorState.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SMSConversationStateContentJSON  result)
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
        public SMSConversationStateContentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SMSConversationStateContentJSON  result)
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
    protected virtual void handle_result(List<SMSConversationStateContentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SMSConversationStateContentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SMSConversationStateContentJSON>();
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
    public List<SMSConversationStateContentJSON> value;
  };
  };
