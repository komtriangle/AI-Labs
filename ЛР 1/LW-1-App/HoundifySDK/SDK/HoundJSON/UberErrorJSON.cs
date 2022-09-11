/* file "UberErrorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class UberErrorJSON : CommandErrorJSON
  {
    private bool flagHasErrorDetails;
    private string storeErrorDetails;


    private JSONValue  extraErrorDetailsToJSON()
      {
        JSONStringValue generated_string_ErrorDetails = new JSONStringValue(storeErrorDetails);
        return generated_string_ErrorDetails;
      }


    private void  fromJSONErrorDetails(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorDetails of UberErrorJSON is not a string.");
        setErrorDetails(json_string.getData());
      }


    public UberErrorJSON()
      {
        flagHasErrorDetails = false;
      }

    public override string  getErrorType()
      {
        return "UberError";
      }

    public abstract string getUberErrorKind();
    public bool  hasErrorDetails()
      {
        return flagHasErrorDetails;
      }

    public string  getErrorDetails()
      {
        Debug.Assert(flagHasErrorDetails);
        return storeErrorDetails;
      }


    public abstract int extraUberErrorComponentCount();
    public abstract string extraUberErrorComponentKey(int component_num);
    public abstract JSONValue extraUberErrorComponentValue(int component_num);
    public abstract JSONValue extraUberErrorLookup(string field_name);
    public override int extraCommandErrorComponentCount()
      {
        int result = 1;
        if (flagHasErrorDetails)
            ++result;
        result += extraUberErrorComponentCount();
        return result;
      }
    public override string extraCommandErrorComponentKey(int component_num)
      {
        if (component_num == 0)
            return "UberErrorKind";
        int remainder = (component_num - 1);
        if (flagHasErrorDetails)
          {
            if (remainder == 0)
                return "ErrorDetails";
            --remainder;
          }
        return extraUberErrorComponentKey(remainder);
      }
    public override JSONValue extraCommandErrorComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getUberErrorKind());
        int remainder = (component_num - 1);
        if (flagHasErrorDetails)
          {
            if (remainder == 0)
                return extraErrorDetailsToJSON();
            --remainder;
          }
        return extraUberErrorComponentValue(remainder);
      }
    public override JSONValue extraCommandErrorLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "rrorDetails", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasErrorDetails ? extraErrorDetailsToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "berErrorKind", 0, 12, false) == 0) && (field_name.Length == 13))
                    return new JSONStringValue(getUberErrorKind());
                break;
            default:
                break;
          }
        return extraUberErrorLookup(field_name);
      }

    public void setErrorDetails(string new_value)
      {
        flagHasErrorDetails = true;
        storeErrorDetails = new_value;
      }
    public void unsetErrorDetails()
      {
        flagHasErrorDetails = false;
      }

    public abstract void extraUberErrorAppendPair(string key, JSONValue new_component);
    public abstract void extraUberErrorSetField(string key, JSONValue new_component);
    public override void extraCommandErrorAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "rrorDetails", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONErrorDetails(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "berErrorKind", 0, 12, false) == 0) && (key.Length == 13))
                    return;
                break;
            default:
                break;
          }
        extraUberErrorAppendPair(key, new_component);
      }
    public override void extraCommandErrorSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "rrorDetails", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONErrorDetails(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "berErrorKind", 0, 12, false) == 0) && (key.Length == 13))
                    return;
                break;
            default:
                break;
          }
        extraUberErrorSetField(key, new_component);
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
        handler.pair("UberErrorKind", getUberErrorKind());
        if (flagHasErrorDetails)
          {
            handler.start_pair("ErrorDetails");
            handler.string_value(storeErrorDetails);
          }
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

    public static new UberErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberError", ignore_extras);
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
    public static new UberErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberError", ignore_extras);
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
    public static new UberErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberErrorJSON from_text(string text, bool ignore_extras)
      {
        UberErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberError", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberErrorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UberErrorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberError", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandErrorJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorErrorDetails;
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
                throw new Exception("The `UberErrorKind' field is missing.");
            if (!(getCommandErrorJSONKey().Equals("UberError")))
                throw new Exception("The key field has a value other than `UberError'.");
            UberErrorJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberErrorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getUberErrorJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `UberErrorKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(CommandErrorJSON new_result)
          {
            handle_result((UberErrorJSON )new_result);
          }
        protected void finish(UberErrorJSON result)
          {
            if (fieldGeneratorErrorDetails.have_value)
              {
                result.setErrorDetails(fieldGeneratorErrorDetails.value);
                fieldGeneratorErrorDetails.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(UberErrorJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "rrorDetails", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorErrorDetails;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "berErrorKind", 0, 12, false) == 0) && (field_name.Length == 13))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorErrorDetails = new JSONHoldingStringGenerator("field \"ErrorDetails\" of the UberError class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"UberErrorKind\" of the UberError class");
            set_what("the UberError class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorErrorDetails = new JSONHoldingStringGenerator("field \"ErrorDetails\" of the UberError class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"UberErrorKind\" of the UberError class");
            set_what("the UberError class");
          }

        public override void reset()
          {
            fieldGeneratorErrorDetails.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UberErrorJSON  result)
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
        public UberErrorJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberErrorJSON  result)
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
    protected virtual void handle_result(List<UberErrorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberErrorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberErrorJSON>();
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
    public List<UberErrorJSON> value;
  };
    class GenericUberErrorJSON : UberErrorJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericUberErrorJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getUberErrorKind()  { return key; }
        public override int extraUberErrorComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraUberErrorComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraUberErrorComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraUberErrorLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraUberErrorAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraUberErrorSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraUberErrorLookup(key);
            if (old_field == null)
              {
                extraUberErrorAppendPair(key, new_component);
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
    public static new UberErrorJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "Uber", 0, 4, false) == 0)
      {
        switch (key[4])
          {
            case 'A':
                if ((String.Compare(key, 5, "piError", 0, 7, false) == 0) && (key.Length == 12))
                    return new UberApiErrorJSON();
                break;
            case 'E':
                if (String.Compare(key, 5, "rror", 0, 4, false) == 0)
                  {
                    switch (key[9])
                      {
                        case 'M':
                            if ((String.Compare(key, 10, "issingCredentials", 0, 17, false) == 0) && (key.Length == 27))
                                return new UberErrorMissingCredentialsJSON();
                            break;
                        case 'U':
                            if ((String.Compare(key, 10, "nknownLocation", 0, 14, false) == 0) && (key.Length == 24))
                                return new UberErrorUnknownLocationJSON();
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

        return new GenericUberErrorJSON(key);
      }
  };
