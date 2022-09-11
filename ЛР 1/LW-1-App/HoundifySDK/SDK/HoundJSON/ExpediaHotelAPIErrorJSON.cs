/* file "ExpediaHotelAPIErrorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ExpediaHotelAPIErrorJSON : CommandErrorJSON
  {
    private bool flagHasExpediaResponseJSON;
    private string storeExpediaResponseJSON;
    private bool flagHasExpediaErrorCode;
    private string storeExpediaErrorCode;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraExpediaResponseJSONToJSON()
      {
        JSONStringValue generated_string_ExpediaResponseJSON = new JSONStringValue(storeExpediaResponseJSON);
        return generated_string_ExpediaResponseJSON;
      }

    private JSONValue  extraExpediaErrorCodeToJSON()
      {
        JSONStringValue generated_string_ExpediaErrorCode = new JSONStringValue(storeExpediaErrorCode);
        return generated_string_ExpediaErrorCode;
      }


    private void  fromJSONExpediaResponseJSON(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExpediaResponseJSON of ExpediaHotelAPIErrorJSON is not a string.");
        setExpediaResponseJSON(json_string.getData());
      }


    private void  fromJSONExpediaErrorCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExpediaErrorCode of ExpediaHotelAPIErrorJSON is not a string.");
        setExpediaErrorCode(json_string.getData());
      }


    public ExpediaHotelAPIErrorJSON()
      {
        flagHasExpediaResponseJSON = false;
        flagHasExpediaErrorCode = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getErrorType()
      {
        return "ExpediaHotelAPIError";
      }

    public bool  hasExpediaResponseJSON()
      {
        return flagHasExpediaResponseJSON;
      }

    public string  getExpediaResponseJSON()
      {
        Debug.Assert(flagHasExpediaResponseJSON);
        return storeExpediaResponseJSON;
      }

    public bool  hasExpediaErrorCode()
      {
        return flagHasExpediaErrorCode;
      }

    public string  getExpediaErrorCode()
      {
        Debug.Assert(flagHasExpediaErrorCode);
        return storeExpediaErrorCode;
      }


    public virtual int extraExpediaHotelAPIErrorComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraExpediaHotelAPIErrorComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraExpediaHotelAPIErrorComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraExpediaHotelAPIErrorLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandErrorComponentCount()
      {
        int result = 0;
        if (flagHasExpediaResponseJSON)
            ++result;
        if (flagHasExpediaErrorCode)
            ++result;
        result += extraExpediaHotelAPIErrorComponentCount();
        return result;
      }
    public override string extraCommandErrorComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasExpediaResponseJSON)
          {
            if (remainder == 0)
                return "ExpediaResponseJSON";
            --remainder;
          }
        if (flagHasExpediaErrorCode)
          {
            if (remainder == 0)
                return "ExpediaErrorCode";
            --remainder;
          }
        return extraExpediaHotelAPIErrorComponentKey(remainder);
      }
    public override JSONValue extraCommandErrorComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasExpediaResponseJSON)
          {
            if (remainder == 0)
                return extraExpediaResponseJSONToJSON();
            --remainder;
          }
        if (flagHasExpediaErrorCode)
          {
            if (remainder == 0)
                return extraExpediaErrorCodeToJSON();
            --remainder;
          }
        return extraExpediaHotelAPIErrorComponentValue(remainder);
      }
    public override JSONValue extraCommandErrorLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "Expedia", 0, 7, false) == 0)
          {
            switch (field_name[7])
              {
                case 'E':
                    if ((String.Compare(field_name, 8, "rrorCode", 0, 8, false) == 0) && (field_name.Length == 16))
                        return (flagHasExpediaErrorCode ? extraExpediaErrorCodeToJSON() : null);
                    break;
                case 'R':
                    if ((String.Compare(field_name, 8, "esponseJSON", 0, 11, false) == 0) && (field_name.Length == 19))
                        return (flagHasExpediaResponseJSON ? extraExpediaResponseJSONToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraExpediaHotelAPIErrorLookup(field_name);
      }

    public void setExpediaResponseJSON(string new_value)
      {
        flagHasExpediaResponseJSON = true;
        storeExpediaResponseJSON = new_value;
      }
    public void unsetExpediaResponseJSON()
      {
        flagHasExpediaResponseJSON = false;
      }
    public void setExpediaErrorCode(string new_value)
      {
        flagHasExpediaErrorCode = true;
        storeExpediaErrorCode = new_value;
      }
    public void unsetExpediaErrorCode()
      {
        flagHasExpediaErrorCode = false;
      }

    public virtual void extraExpediaHotelAPIErrorAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraExpediaHotelAPIErrorSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraExpediaHotelAPIErrorLookup(key);
        if (old_field == null)
          {
            extraExpediaHotelAPIErrorAppendPair(key, new_component);
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
    public override void extraCommandErrorAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Expedia", 0, 7, false) == 0)
          {
            switch (key[7])
              {
                case 'E':
                    if ((String.Compare(key, 8, "rrorCode", 0, 8, false) == 0) && (key.Length == 16))
                        {
                        fromJSONExpediaErrorCode(new_component, false);
                        return;
                        }
                    break;
                case 'R':
                    if ((String.Compare(key, 8, "esponseJSON", 0, 11, false) == 0) && (key.Length == 19))
                        {
                        fromJSONExpediaResponseJSON(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraExpediaHotelAPIErrorAppendPair(key, new_component);
      }
    public override void extraCommandErrorSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Expedia", 0, 7, false) == 0)
          {
            switch (key[7])
              {
                case 'E':
                    if ((String.Compare(key, 8, "rrorCode", 0, 8, false) == 0) && (key.Length == 16))
                        {
                        fromJSONExpediaErrorCode(new_component, false);
                        return;
                        }
                    break;
                case 'R':
                    if ((String.Compare(key, 8, "esponseJSON", 0, 11, false) == 0) && (key.Length == 19))
                        {
                        fromJSONExpediaResponseJSON(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraExpediaHotelAPIErrorSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasExpediaResponseJSON);
        if (flagHasExpediaResponseJSON)
          {
            handler.start_pair("ExpediaResponseJSON");
            handler.string_value(storeExpediaResponseJSON);
          }
        if (flagHasExpediaErrorCode)
          {
            handler.start_pair("ExpediaErrorCode");
            handler.string_value(storeExpediaErrorCode);
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
        if (!(hasExpediaResponseJSON()))
          {
            return "When parsing the object for %what%, the \"ExpediaResponseJSON\" field was missing.";
          }
        return null;
      }

    public static new ExpediaHotelAPIErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ExpediaHotelAPIErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ExpediaHotelAPIError", ignore_extras);
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
    public static new ExpediaHotelAPIErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ExpediaHotelAPIErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ExpediaHotelAPIErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ExpediaHotelAPIError", ignore_extras);
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
    public static new ExpediaHotelAPIErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ExpediaHotelAPIErrorJSON from_text(string text, bool ignore_extras)
      {
        ExpediaHotelAPIErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ExpediaHotelAPIError", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ExpediaHotelAPIErrorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ExpediaHotelAPIErrorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ExpediaHotelAPIErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ExpediaHotelAPIError", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandErrorJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorExpediaResponseJSON;
        private JSONHoldingStringGenerator fieldGeneratorExpediaErrorCode;
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
            if (!(getCommandErrorJSONKey().Equals("ExpediaHotelAPIError")))
                throw new Exception("The key field has a value other than `ExpediaHotelAPIError'.");
            ExpediaHotelAPIErrorJSON result = new ExpediaHotelAPIErrorJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraExpediaHotelAPIErrorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandErrorJSON new_result)
          {
            handle_result((ExpediaHotelAPIErrorJSON )new_result);
          }
        protected void finish(ExpediaHotelAPIErrorJSON result)
          {
            if (fieldGeneratorExpediaResponseJSON.have_value)
              {
                result.setExpediaResponseJSON(fieldGeneratorExpediaResponseJSON.value);
                fieldGeneratorExpediaResponseJSON.have_value = false;
              }
            else if ((!(result.hasExpediaResponseJSON())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ExpediaResponseJSON\" field was missing.");
              }
            if (fieldGeneratorExpediaErrorCode.have_value)
              {
                result.setExpediaErrorCode(fieldGeneratorExpediaErrorCode.value);
                fieldGeneratorExpediaErrorCode.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ExpediaHotelAPIErrorJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Expedia", 0, 7, false) == 0)
              {
                switch (field_name[7])
                  {
                    case 'E':
                        if ((String.Compare(field_name, 8, "rrorCode", 0, 8, false) == 0) && (field_name.Length == 16))
                            return fieldGeneratorExpediaErrorCode;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 8, "esponseJSON", 0, 11, false) == 0) && (field_name.Length == 19))
                            return fieldGeneratorExpediaResponseJSON;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorExpediaResponseJSON = new JSONHoldingStringGenerator("field \"ExpediaResponseJSON\" of the ExpediaHotelAPIError class");
            fieldGeneratorExpediaErrorCode = new JSONHoldingStringGenerator("field \"ExpediaErrorCode\" of the ExpediaHotelAPIError class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ExpediaHotelAPIError class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorExpediaResponseJSON = new JSONHoldingStringGenerator("field \"ExpediaResponseJSON\" of the ExpediaHotelAPIError class");
            fieldGeneratorExpediaErrorCode = new JSONHoldingStringGenerator("field \"ExpediaErrorCode\" of the ExpediaHotelAPIError class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ExpediaHotelAPIError class");
          }

        public override void reset()
          {
            fieldGeneratorExpediaResponseJSON.reset();
            fieldGeneratorExpediaErrorCode.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ExpediaHotelAPIErrorJSON  result)
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
        public ExpediaHotelAPIErrorJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ExpediaHotelAPIErrorJSON  result)
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
    protected virtual void handle_result(List<ExpediaHotelAPIErrorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ExpediaHotelAPIErrorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ExpediaHotelAPIErrorJSON>();
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
    public List<ExpediaHotelAPIErrorJSON> value;
  };
  };
