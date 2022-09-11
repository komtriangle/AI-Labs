/* file "BusinessInformationUploadDataCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class BusinessInformationUploadDataCommandJSON : CommandResultJSON
  {

    public BusinessInformationUploadDataCommandJSON()
      {
      }

    public override string  getCommandKind()
      {
        return "BusinessInformationUploadData";
      }

    public abstract string getBusinessInformationUploadDataCommandKind();

    public abstract int extraBusinessInformationUploadDataCommandComponentCount();
    public abstract string extraBusinessInformationUploadDataCommandComponentKey(int component_num);
    public abstract JSONValue extraBusinessInformationUploadDataCommandComponentValue(int component_num);
    public abstract JSONValue extraBusinessInformationUploadDataCommandLookup(string field_name);
    public override int extraCommandResultComponentCount()
      {
        int result = 1;
        result += extraBusinessInformationUploadDataCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        if (component_num == 0)
            return "BusinessInformationUploadDataCommandKind";
        return extraBusinessInformationUploadDataCommandComponentKey((component_num - 1));
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getBusinessInformationUploadDataCommandKind());
        return extraBusinessInformationUploadDataCommandComponentValue((component_num - 1));
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "BusinessInformationUploadDataCommandKind", 0, 40, false) == 0) && (field_name.Length == 40))
            return new JSONStringValue(getBusinessInformationUploadDataCommandKind());
        return extraBusinessInformationUploadDataCommandLookup(field_name);
      }


    public abstract void extraBusinessInformationUploadDataCommandAppendPair(string key, JSONValue new_component);
    public abstract void extraBusinessInformationUploadDataCommandSetField(string key, JSONValue new_component);
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "BusinessInformationUploadDataCommandKind", 0, 40, false) == 0) && (key.Length == 40))
            return;
        extraBusinessInformationUploadDataCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "BusinessInformationUploadDataCommandKind", 0, 40, false) == 0) && (key.Length == 40))
            return;
        extraBusinessInformationUploadDataCommandSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        handler.pair("BusinessInformationUploadDataCommandKind", getBusinessInformationUploadDataCommandKind());
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new BusinessInformationUploadDataCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BusinessInformationUploadDataCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationUploadDataCommand", ignore_extras);
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
    public static new BusinessInformationUploadDataCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BusinessInformationUploadDataCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BusinessInformationUploadDataCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationUploadDataCommand", ignore_extras);
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
    public static new BusinessInformationUploadDataCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BusinessInformationUploadDataCommandJSON from_text(string text, bool ignore_extras)
      {
        BusinessInformationUploadDataCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationUploadDataCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BusinessInformationUploadDataCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new BusinessInformationUploadDataCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BusinessInformationUploadDataCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationUploadDataCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `BusinessInformationUploadDataCommandKind' field is missing.");
            if (!(getCommandResultJSONKey().Equals("BusinessInformationUploadData")))
                throw new Exception("The key field has a value other than `BusinessInformationUploadData'.");
            BusinessInformationUploadDataCommandJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBusinessInformationUploadDataCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getBusinessInformationUploadDataCommandJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `BusinessInformationUploadDataCommandKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((BusinessInformationUploadDataCommandJSON )new_result);
          }
        protected void finish(BusinessInformationUploadDataCommandJSON result)
          {
            base.finish(result);
          }
        protected abstract void handle_result(BusinessInformationUploadDataCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "BusinessInformationUploadDataCommandKind", 0, 40, false) == 0) && (field_name.Length == 40))
                {
                keyGenerator.reset();
                return keyGenerator;
                }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"BusinessInformationUploadDataCommandKind\" of the BusinessInformationUploadDataCommand class");
            set_what("the BusinessInformationUploadDataCommand class");
          }
        public Generator() : base(false)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"BusinessInformationUploadDataCommandKind\" of the BusinessInformationUploadDataCommand class");
            set_what("the BusinessInformationUploadDataCommand class");
          }

        public override void reset()
          {
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(BusinessInformationUploadDataCommandJSON  result)
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
        public BusinessInformationUploadDataCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BusinessInformationUploadDataCommandJSON  result)
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
    protected virtual void handle_result(List<BusinessInformationUploadDataCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BusinessInformationUploadDataCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BusinessInformationUploadDataCommandJSON>();
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
    public List<BusinessInformationUploadDataCommandJSON> value;
  };
    class GenericBusinessInformationUploadDataCommandJSON : BusinessInformationUploadDataCommandJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericBusinessInformationUploadDataCommandJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getBusinessInformationUploadDataCommandKind()  { return key; }
        public override int extraBusinessInformationUploadDataCommandComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraBusinessInformationUploadDataCommandComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraBusinessInformationUploadDataCommandComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraBusinessInformationUploadDataCommandLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraBusinessInformationUploadDataCommandAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraBusinessInformationUploadDataCommandSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraBusinessInformationUploadDataCommandLookup(key);
            if (old_field == null)
              {
                extraBusinessInformationUploadDataCommandAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static new BusinessInformationUploadDataCommandJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "Upload", 0, 6, false) == 0)
      {
        switch (key[6])
          {
            case 'F':
                if ((String.Compare(key, 7, "ailure", 0, 6, false) == 0) && (key.Length == 13))
                  {
                    JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("UploadFailureKind") ? other_field_index["UploadFailureKind"] : null));
                    if (key_value == null)
                        throw new Exception("The `UploadFailureKind' field is missing.");
                    JSONStringValue key_string_value = key_value.string_value();
                    if (key_string_value == null)
                        throw new Exception("The `UploadFailureKind' field has a non-string value.");
                    return BusinessInformationUploadDataUploadFailureCommandJSON.createForKey(key_string_value.getData(), other_field_index);
                  }
                break;
            case 'S':
                if ((String.Compare(key, 7, "uccess", 0, 6, false) == 0) && (key.Length == 13))
                    return new BusinessInformationUploadDataUploadSuccessCommandJSON();
                break;
            default:
                break;
          }
      }

        return new GenericBusinessInformationUploadDataCommandJSON(key);
      }
  };
