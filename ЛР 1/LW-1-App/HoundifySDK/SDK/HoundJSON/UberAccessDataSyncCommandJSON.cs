/* file "UberAccessDataSyncCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberAccessDataSyncCommandJSON : UberCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        public enum TypeStatusKnownValues
          {
            Status_synced,
            Status_failed,
            Status__none
          };
        public struct TypeStatus
          {
            public bool in_known_list;
            public string string_value;
            public TypeStatusKnownValues list_value;
          };

        public static TypeStatusKnownValues  stringToStatus(string chars)
          {
            switch (chars[0])
              {
                case 'f':
                    if ((String.Compare(chars, 1, "ailed", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeStatusKnownValues.Status_failed;
                    break;
                case 's':
                    if ((String.Compare(chars, 1, "ynced", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeStatusKnownValues.Status_synced;
                    break;
                default:
                    break;
              }
            return TypeStatusKnownValues.Status__none;
          }

        public static string  stringFromStatus(TypeStatusKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeStatusKnownValues.Status_synced:
                    return "synced";
                case TypeStatusKnownValues.Status_failed:
                    return "failed";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasStatus;
        private TypeStatus storeStatus;
        private bool flagHasDescription;
        private string storeDescription;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONStatus(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Status of TypeNativeDataJSON is not a string.");
            TypeStatus the_open_enum = new TypeStatus();
            switch (json_string.getData()[0])
              {
                case 'f':
                    if ((String.Compare(json_string.getData(), 1, "ailed", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeStatusKnownValues.Status_failed;
                            goto open_enum_is_done;
                          }
                    break;
                case 's':
                    if ((String.Compare(json_string.getData(), 1, "ynced", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeStatusKnownValues.Status_synced;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setStatus(the_open_enum);
          }


        private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Description of TypeNativeDataJSON is not a string.");
            setDescription(json_string.getData());
          }


        public TypeNativeDataJSON()
          {
            flagHasStatus = false;
            flagHasDescription = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasStatus()
          {
            return flagHasStatus;
          }

        public TypeStatus  getStatus()
          {
            Debug.Assert(flagHasStatus);
            return storeStatus;
          }

        public string  getStatusAsString()
          {
            TypeStatus result = getStatus();
            if (result.in_known_list)
                return stringFromStatus(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasDescription()
          {
            return flagHasDescription;
          }

        public string  getDescription()
          {
            Debug.Assert(flagHasDescription);
            return storeDescription;
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

        public void setStatus(TypeStatus new_value)
          {
            flagHasStatus = true;
            storeStatus = new_value;
          }
        public void setStatus(string chars)
          {
            TypeStatusKnownValues known = stringToStatus(chars);
            TypeStatus new_value = new TypeStatus();
            if (known == TypeStatusKnownValues.Status__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setStatus(new_value);
          }
        public void setStatus(TypeStatusKnownValues new_value)
          {
            TypeStatus new_full_value = new TypeStatus();
            Debug.Assert(new_value != TypeStatusKnownValues.Status__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setStatus(new_full_value);
          }
        public void unsetStatus()
          {
            flagHasStatus = false;
          }
        public void setDescription(string new_value)
          {
            flagHasDescription = true;
            storeDescription = new_value;
          }
        public void unsetDescription()
          {
            flagHasDescription = false;
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
            Debug.Assert(partial_allowed || flagHasStatus);
            if (flagHasStatus)
              {
                handler.start_pair("Status");
                if (storeStatus.in_known_list)
                  {
                    switch (storeStatus.list_value)
                      {
                        case TypeStatusKnownValues.Status_synced:
                            handler.string_value("synced");
                            break;
                        case TypeStatusKnownValues.Status_failed:
                            handler.string_value("failed");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeStatus.string_value);
                  }
              }
            if (flagHasDescription)
              {
                handler.start_pair("Description");
                handler.string_value(storeDescription);
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
            if (!(hasStatus()))
              {
                return "When parsing the object for %what%, the \"Status\" field was missing.";
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
        private abstract class FieldGeneratorStatus : JSONStringGenerator
              {
                protected FieldGeneratorStatus(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorStatus()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeStatusKnownValues known = stringToStatus(result);
                    TypeStatus new_value = new TypeStatus();
                    if (known == TypeStatusKnownValues.Status__none)
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
                protected abstract void handle_result(TypeStatus result);
              };
        private class FieldHoldingGeneratorStatus : FieldGeneratorStatus
      {
        protected override void handle_result(TypeStatus result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorStatus(String what)
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
        public TypeStatus value;
      };
        private class FieldHoldingArrayGeneratorStatus : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorStatus
          {
            private FieldHoldingArrayGeneratorStatus top;

            protected override void handle_result(TypeStatus result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorStatus init_top)
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
        protected virtual void handle_result(List<TypeStatus> result)
          {
          }

        public FieldHoldingArrayGeneratorStatus(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeStatus>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorStatus()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeStatus>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeStatus> value;
      };
            private FieldHoldingGeneratorStatus fieldGeneratorStatus;
            private JSONHoldingStringGenerator fieldGeneratorDescription;
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
                if (fieldGeneratorStatus.have_value)
                  {
                    result.setStatus(fieldGeneratorStatus.value);
                    fieldGeneratorStatus.have_value = false;
                  }
                else if ((!(result.hasStatus())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Status\" field was missing.");
                  }
                if (fieldGeneratorDescription.have_value)
                  {
                    result.setDescription(fieldGeneratorDescription.value);
                    fieldGeneratorDescription.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorDescription;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "tatus", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorStatus;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the TypeNativeData class");
                fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the TypeNativeData class");
                fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorStatus.reset();
                fieldGeneratorDescription.reset();
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


    public UberAccessDataSyncCommandJSON()
      {
        flagHasNativeData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getUberCommandKind()
      {
        return "UberAccessDataSync";
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


    public virtual int extraUberAccessDataSyncCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberAccessDataSyncCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberAccessDataSyncCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberAccessDataSyncCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUberCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        result += extraUberAccessDataSyncCommandComponentCount();
        return result;
      }
    public override string extraUberCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraUberAccessDataSyncCommandComponentKey(remainder);
      }
    public override JSONValue extraUberCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraUberAccessDataSyncCommandComponentValue(remainder);
      }
    public override JSONValue extraUberCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasNativeData ? extraNativeDataToJSON() : null);
        return extraUberAccessDataSyncCommandLookup(field_name);
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

    public virtual void extraUberAccessDataSyncCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberAccessDataSyncCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberAccessDataSyncCommandLookup(key);
        if (old_field == null)
          {
            extraUberAccessDataSyncCommandAppendPair(key, new_component);
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
    public override void extraUberCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraUberAccessDataSyncCommandAppendPair(key, new_component);
      }
    public override void extraUberCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraUberAccessDataSyncCommandSetField(key, new_component);
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

    public static new UberAccessDataSyncCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberAccessDataSyncCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberAccessDataSyncCommand", ignore_extras);
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
    public static new UberAccessDataSyncCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberAccessDataSyncCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberAccessDataSyncCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberAccessDataSyncCommand", ignore_extras);
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
    public static new UberAccessDataSyncCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberAccessDataSyncCommandJSON from_text(string text, bool ignore_extras)
      {
        UberAccessDataSyncCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberAccessDataSyncCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberAccessDataSyncCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UberAccessDataSyncCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberAccessDataSyncCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberAccessDataSyncCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UberCommandJSON.Generator
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
            if (!(getUberCommandJSONKey().Equals("UberAccessDataSync")))
                throw new Exception("The key field has a value other than `UberAccessDataSync'.");
            UberAccessDataSyncCommandJSON result = new UberAccessDataSyncCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberAccessDataSyncCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UberCommandJSON new_result)
          {
            handle_result((UberAccessDataSyncCommandJSON )new_result);
          }
        protected void finish(UberAccessDataSyncCommandJSON result)
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
        protected abstract void handle_result(UberAccessDataSyncCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorNativeData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the UberAccessDataSyncCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberAccessDataSyncCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the UberAccessDataSyncCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberAccessDataSyncCommand class");
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
        protected override void handle_result(UberAccessDataSyncCommandJSON  result)
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
        public UberAccessDataSyncCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberAccessDataSyncCommandJSON  result)
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
    protected virtual void handle_result(List<UberAccessDataSyncCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberAccessDataSyncCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberAccessDataSyncCommandJSON>();
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
    public List<UberAccessDataSyncCommandJSON> value;
  };
  };
