/* file "UberRequestsAbortCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberRequestsAbortCommandJSON : UberRequestsCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        public enum TypeReasonKnownValues
          {
            Reason_user_cancelled,
            Reason_no_uber_product,
            Reason_uber_api_error,
            Reason_client_error,
            Reason_ongoing_request,
            Reason_same_pickup_dropoff,
            Reason__none
          };
        public struct TypeReason
          {
            public bool in_known_list;
            public string string_value;
            public TypeReasonKnownValues list_value;
          };

        public static TypeReasonKnownValues  stringToReason(string chars)
          {
            switch (chars[0])
              {
                case 'c':
                    if ((String.Compare(chars, 1, "lient_error", 0, 11, false) == 0) && (chars.Length == 12))
                        return TypeReasonKnownValues.Reason_client_error;
                    break;
                case 'n':
                    if ((String.Compare(chars, 1, "o_uber_product", 0, 14, false) == 0) && (chars.Length == 15))
                        return TypeReasonKnownValues.Reason_no_uber_product;
                    break;
                case 'o':
                    if ((String.Compare(chars, 1, "ngoing_request", 0, 14, false) == 0) && (chars.Length == 15))
                        return TypeReasonKnownValues.Reason_ongoing_request;
                    break;
                case 's':
                    if ((String.Compare(chars, 1, "ame_pickup_dropoff", 0, 18, false) == 0) && (chars.Length == 19))
                        return TypeReasonKnownValues.Reason_same_pickup_dropoff;
                    break;
                case 'u':
                    switch (chars[1])
                      {
                        case 'b':
                            if ((String.Compare(chars, 2, "er_api_error", 0, 12, false) == 0) && (chars.Length == 14))
                                return TypeReasonKnownValues.Reason_uber_api_error;
                            break;
                        case 's':
                            if ((String.Compare(chars, 2, "er_cancelled", 0, 12, false) == 0) && (chars.Length == 14))
                                return TypeReasonKnownValues.Reason_user_cancelled;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return TypeReasonKnownValues.Reason__none;
          }

        public static string  stringFromReason(TypeReasonKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeReasonKnownValues.Reason_user_cancelled:
                    return "user_cancelled";
                case TypeReasonKnownValues.Reason_no_uber_product:
                    return "no_uber_product";
                case TypeReasonKnownValues.Reason_uber_api_error:
                    return "uber_api_error";
                case TypeReasonKnownValues.Reason_client_error:
                    return "client_error";
                case TypeReasonKnownValues.Reason_ongoing_request:
                    return "ongoing_request";
                case TypeReasonKnownValues.Reason_same_pickup_dropoff:
                    return "same_pickup_dropoff";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasReason;
        private TypeReason storeReason;
        private bool flagHasErrorMessage;
        private string storeErrorMessage;
        private bool flagHasUberRequestsSpec;
        private UberRequestsSpecJSON  storeUberRequestsSpec;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONReason(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Reason of TypeNativeDataJSON is not a string.");
            TypeReason the_open_enum = new TypeReason();
            switch (json_string.getData()[0])
              {
                case 'c':
                    if ((String.Compare(json_string.getData(), 1, "lient_error", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeReasonKnownValues.Reason_client_error;
                            goto open_enum_is_done;
                          }
                    break;
                case 'n':
                    if ((String.Compare(json_string.getData(), 1, "o_uber_product", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeReasonKnownValues.Reason_no_uber_product;
                            goto open_enum_is_done;
                          }
                    break;
                case 'o':
                    if ((String.Compare(json_string.getData(), 1, "ngoing_request", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeReasonKnownValues.Reason_ongoing_request;
                            goto open_enum_is_done;
                          }
                    break;
                case 's':
                    if ((String.Compare(json_string.getData(), 1, "ame_pickup_dropoff", 0, 18, false) == 0) && (json_string.getData().Length == 19))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeReasonKnownValues.Reason_same_pickup_dropoff;
                            goto open_enum_is_done;
                          }
                    break;
                case 'u':
                    switch (json_string.getData()[1])
                      {
                        case 'b':
                            if ((String.Compare(json_string.getData(), 2, "er_api_error", 0, 12, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeReasonKnownValues.Reason_uber_api_error;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 's':
                            if ((String.Compare(json_string.getData(), 2, "er_cancelled", 0, 12, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeReasonKnownValues.Reason_user_cancelled;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setReason(the_open_enum);
          }


        private void  fromJSONErrorMessage(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ErrorMessage of TypeNativeDataJSON is not a string.");
            setErrorMessage(json_string.getData());
          }


        private void  fromJSONUberRequestsSpec(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UberRequestsSpecJSON convert_classy = UberRequestsSpecJSON.from_json(json_value, ignore_extras, true);
            setUberRequestsSpec(convert_classy);
          }


        public TypeNativeDataJSON()
          {
            flagHasReason = false;
            flagHasErrorMessage = false;
            flagHasUberRequestsSpec = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasReason()
          {
            return flagHasReason;
          }

        public TypeReason  getReason()
          {
            Debug.Assert(flagHasReason);
            return storeReason;
          }

        public string  getReasonAsString()
          {
            TypeReason result = getReason();
            if (result.in_known_list)
                return stringFromReason(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasErrorMessage()
          {
            return flagHasErrorMessage;
          }

        public string  getErrorMessage()
          {
            Debug.Assert(flagHasErrorMessage);
            return storeErrorMessage;
          }

        public bool  hasUberRequestsSpec()
          {
            return flagHasUberRequestsSpec;
          }

        public UberRequestsSpecJSON   getUberRequestsSpec()
          {
            Debug.Assert(flagHasUberRequestsSpec);
            return storeUberRequestsSpec;
          }


        public virtual int extraTypeNativeDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNativeDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNativeDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNativeDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setReason(TypeReason new_value)
          {
            flagHasReason = true;
            storeReason = new_value;
          }
        public void setReason(string chars)
          {
            TypeReasonKnownValues known = stringToReason(chars);
            TypeReason new_value = new TypeReason();
            if (known == TypeReasonKnownValues.Reason__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setReason(new_value);
          }
        public void setReason(TypeReasonKnownValues new_value)
          {
            TypeReason new_full_value = new TypeReason();
            Debug.Assert(new_value != TypeReasonKnownValues.Reason__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setReason(new_full_value);
          }
        public void unsetReason()
          {
            flagHasReason = false;
          }
        public void setErrorMessage(string new_value)
          {
            flagHasErrorMessage = true;
            storeErrorMessage = new_value;
          }
        public void unsetErrorMessage()
          {
            flagHasErrorMessage = false;
          }
        public void setUberRequestsSpec(UberRequestsSpecJSON  new_value)
          {
            if (flagHasUberRequestsSpec)
              {
              }
            flagHasUberRequestsSpec = true;
            storeUberRequestsSpec = new_value;
          }
        public void unsetUberRequestsSpec()
          {
            if (flagHasUberRequestsSpec)
              {
              }
            flagHasUberRequestsSpec = false;
          }

        public virtual void extraTypeNativeDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNativeDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNativeDataLookup(key);
            if (old_field == null)
              {
                extraTypeNativeDataAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasReason);
            if (flagHasReason)
              {
                handler.start_pair("Reason");
                if (storeReason.in_known_list)
                  {
                    switch (storeReason.list_value)
                      {
                        case TypeReasonKnownValues.Reason_user_cancelled:
                            handler.string_value("user_cancelled");
                            break;
                        case TypeReasonKnownValues.Reason_no_uber_product:
                            handler.string_value("no_uber_product");
                            break;
                        case TypeReasonKnownValues.Reason_uber_api_error:
                            handler.string_value("uber_api_error");
                            break;
                        case TypeReasonKnownValues.Reason_client_error:
                            handler.string_value("client_error");
                            break;
                        case TypeReasonKnownValues.Reason_ongoing_request:
                            handler.string_value("ongoing_request");
                            break;
                        case TypeReasonKnownValues.Reason_same_pickup_dropoff:
                            handler.string_value("same_pickup_dropoff");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeReason.string_value);
                  }
              }
            if (flagHasErrorMessage)
              {
                handler.start_pair("ErrorMessage");
                handler.string_value(storeErrorMessage);
              }
            Debug.Assert(partial_allowed || flagHasUberRequestsSpec);
            if (flagHasUberRequestsSpec)
              {
                handler.start_pair("UberRequestsSpec");
                if (partial_allowed)
                    storeUberRequestsSpec.write_partial_as_json(handler);
                else
                    storeUberRequestsSpec.write_as_json(handler);
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
            if (!(hasReason()))
              {
                return "When parsing the object for %what%, the \"Reason\" field was missing.";
              }
            if (!(hasUberRequestsSpec()))
              {
                return "When parsing the object for %what%, the \"UberRequestsSpec\" field was missing.";
              }
            return null;
          }

        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_text(string text, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNativeDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private abstract class FieldGeneratorReason : JSONStringGenerator
              {
                protected FieldGeneratorReason(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorReason()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeReasonKnownValues known = stringToReason(result);
                    TypeReason new_value = new TypeReason();
                    if (known == TypeReasonKnownValues.Reason__none)
                      {
                        new_value.in_known_list = false;
                        new_value.string_value = result;
                      }
                    else
                      {
                        new_value.in_known_list = true;
                        new_value.list_value = known;
                      }
                    handle_result(new_value);
                  }
                protected abstract void handle_result(TypeReason result);
              };
        private class FieldHoldingGeneratorReason : FieldGeneratorReason
      {
        protected override void handle_result(TypeReason result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorReason(String what)
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
        public TypeReason value;
      };
        private class FieldHoldingArrayGeneratorReason : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorReason
          {
            private FieldHoldingArrayGeneratorReason top;

            protected override void handle_result(TypeReason result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorReason init_top)
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
        protected virtual void handle_result(List<TypeReason> result)
          {
          }

        public FieldHoldingArrayGeneratorReason(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeReason>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorReason()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeReason>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeReason> value;
      };
            private FieldHoldingGeneratorReason fieldGeneratorReason;
            private JSONHoldingStringGenerator fieldGeneratorErrorMessage;
            private UberRequestsSpecJSON.HoldingGenerator fieldGeneratorUberRequestsSpec;
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
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
                if (fieldGeneratorReason.have_value)
                  {
                    result.setReason(fieldGeneratorReason.value);
                    fieldGeneratorReason.have_value = false;
                  }
                else if ((!(result.hasReason())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Reason\" field was missing.");
                  }
                if (fieldGeneratorErrorMessage.have_value)
                  {
                    result.setErrorMessage(fieldGeneratorErrorMessage.value);
                    fieldGeneratorErrorMessage.have_value = false;
                  }
                if (fieldGeneratorUberRequestsSpec.have_value)
                  {
                    result.setUberRequestsSpec(fieldGeneratorUberRequestsSpec.value);
                    fieldGeneratorUberRequestsSpec.have_value = false;
                  }
                else if ((!(result.hasUberRequestsSpec())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"UberRequestsSpec\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'E':
                        if ((String.Compare(field_name, 1, "rrorMessage", 0, 11, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorErrorMessage;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "eason", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorReason;
                        break;
                    case 'U':
                        if ((String.Compare(field_name, 1, "berRequestsSpec", 0, 15, false) == 0) && (field_name.Length == 16))
                            return fieldGeneratorUberRequestsSpec;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorReason = new FieldHoldingGeneratorReason("field \"Reason\" of the TypeNativeData class");
                fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the TypeNativeData class");
                fieldGeneratorUberRequestsSpec = new UberRequestsSpecJSON.HoldingGenerator("field \"UberRequestsSpec\" of the TypeNativeData class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorReason = new FieldHoldingGeneratorReason("field \"Reason\" of the TypeNativeData class");
                fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the TypeNativeData class");
                fieldGeneratorUberRequestsSpec = new UberRequestsSpecJSON.HoldingGenerator("field \"UberRequestsSpec\" of the TypeNativeData class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorReason.reset();
                fieldGeneratorErrorMessage.reset();
                fieldGeneratorUberRequestsSpec.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorUberRequestsSpec.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorUberRequestsSpec.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeNativeDataJSON  result)
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
            public TypeNativeDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNativeDataJSON  result)
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
        protected virtual void handle_result(List<TypeNativeDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNativeDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNativeDataJSON>();
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
        public List<TypeNativeDataJSON> value;
      };
      };
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public UberRequestsAbortCommandJSON()
      {
        flagHasNativeData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getUberRequestsCommandKind()
      {
        return "UberRequestsAbort";
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public TypeNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }


    public virtual int extraUberRequestsAbortCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberRequestsAbortCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberRequestsAbortCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberRequestsAbortCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUberRequestsCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        result += extraUberRequestsAbortCommandComponentCount();
        return result;
      }
    public override string extraUberRequestsCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraUberRequestsAbortCommandComponentKey(remainder);
      }
    public override JSONValue extraUberRequestsCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraUberRequestsAbortCommandComponentValue(remainder);
      }
    public override JSONValue extraUberRequestsCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasNativeData ? extraNativeDataToJSON() : null);
        return extraUberRequestsAbortCommandLookup(field_name);
      }

    public void setNativeData(TypeNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }

    public virtual void extraUberRequestsAbortCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberRequestsAbortCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberRequestsAbortCommandLookup(key);
        if (old_field == null)
          {
            extraUberRequestsAbortCommandAppendPair(key, new_component);
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
    public override void extraUberRequestsCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraUberRequestsAbortCommandAppendPair(key, new_component);
      }
    public override void extraUberRequestsCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraUberRequestsAbortCommandSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasNativeData);
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new UberRequestsAbortCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestsAbortCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsAbortCommand", ignore_extras);
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
    public static new UberRequestsAbortCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberRequestsAbortCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestsAbortCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsAbortCommand", ignore_extras);
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
    public static new UberRequestsAbortCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberRequestsAbortCommandJSON from_text(string text, bool ignore_extras)
      {
        UberRequestsAbortCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsAbortCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberRequestsAbortCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UberRequestsAbortCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberRequestsAbortCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsAbortCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UberRequestsCommandJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
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
            if (!(getUberRequestsCommandJSONKey().Equals("UberRequestsAbort")))
                throw new Exception("The key field has a value other than `UberRequestsAbort'.");
            UberRequestsAbortCommandJSON result = new UberRequestsAbortCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberRequestsAbortCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UberRequestsCommandJSON new_result)
          {
            handle_result((UberRequestsAbortCommandJSON )new_result);
          }
        protected void finish(UberRequestsAbortCommandJSON result)
          {
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(UberRequestsAbortCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorNativeData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the UberRequestsAbortCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberRequestsAbortCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the UberRequestsAbortCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberRequestsAbortCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UberRequestsAbortCommandJSON  result)
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
        public UberRequestsAbortCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberRequestsAbortCommandJSON  result)
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
    protected virtual void handle_result(List<UberRequestsAbortCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberRequestsAbortCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberRequestsAbortCommandJSON>();
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
    public List<UberRequestsAbortCommandJSON> value;
  };
  };
