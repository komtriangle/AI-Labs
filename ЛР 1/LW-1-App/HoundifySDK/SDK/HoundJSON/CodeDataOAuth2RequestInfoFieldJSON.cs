/* file "CodeDataOAuth2RequestInfoFieldJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CodeDataOAuth2RequestInfoFieldJSON : JSONBase
  {
    private bool flagHasCode;
    private string storeCode;
    private bool flagHasRedirectURI;
    private string storeRedirectURI;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Code of CodeDataOAuth2RequestInfoFieldJSON is not a string.");
        setCode(json_string.getData());
      }


    private void  fromJSONRedirectURI(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RedirectURI of CodeDataOAuth2RequestInfoFieldJSON is not a string.");
        setRedirectURI(json_string.getData());
      }


    public CodeDataOAuth2RequestInfoFieldJSON()
      {
        flagHasCode = false;
        flagHasRedirectURI = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCode()
      {
        return flagHasCode;
      }

    public string  getCode()
      {
        Debug.Assert(flagHasCode);
        return storeCode;
      }

    public bool  hasRedirectURI()
      {
        return flagHasRedirectURI;
      }

    public string  getRedirectURI()
      {
        Debug.Assert(flagHasRedirectURI);
        return storeRedirectURI;
      }


    public virtual int extraCodeDataOAuth2RequestInfoFieldComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCodeDataOAuth2RequestInfoFieldComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCodeDataOAuth2RequestInfoFieldComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCodeDataOAuth2RequestInfoFieldLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCode(string new_value)
      {
        flagHasCode = true;
        storeCode = new_value;
      }
    public void unsetCode()
      {
        flagHasCode = false;
      }
    public void setRedirectURI(string new_value)
      {
        flagHasRedirectURI = true;
        storeRedirectURI = new_value;
      }
    public void unsetRedirectURI()
      {
        flagHasRedirectURI = false;
      }

    public virtual void extraCodeDataOAuth2RequestInfoFieldAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCodeDataOAuth2RequestInfoFieldSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCodeDataOAuth2RequestInfoFieldLookup(key);
        if (old_field == null)
          {
            extraCodeDataOAuth2RequestInfoFieldAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCode);
        if (flagHasCode)
          {
            handler.start_pair("Code");
            handler.string_value(storeCode);
          }
        Debug.Assert(partial_allowed || flagHasRedirectURI);
        if (flagHasRedirectURI)
          {
            handler.start_pair("RedirectURI");
            handler.string_value(storeRedirectURI);
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
        if (!(hasCode()))
          {
            return "When parsing the object for %what%, the \"Code\" field was missing.";
          }
        if (!(hasRedirectURI()))
          {
            return "When parsing the object for %what%, the \"RedirectURI\" field was missing.";
          }
        return null;
      }

    public static CodeDataOAuth2RequestInfoFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CodeDataOAuth2RequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CodeDataOAuth2RequestInfoField", ignore_extras);
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
    public static CodeDataOAuth2RequestInfoFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CodeDataOAuth2RequestInfoFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CodeDataOAuth2RequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CodeDataOAuth2RequestInfoField", ignore_extras);
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
    public static CodeDataOAuth2RequestInfoFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CodeDataOAuth2RequestInfoFieldJSON from_text(string text, bool ignore_extras)
      {
        CodeDataOAuth2RequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CodeDataOAuth2RequestInfoField", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CodeDataOAuth2RequestInfoFieldJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CodeDataOAuth2RequestInfoFieldJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CodeDataOAuth2RequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CodeDataOAuth2RequestInfoField", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorCode;
        private JSONHoldingStringGenerator fieldGeneratorRedirectURI;
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
            CodeDataOAuth2RequestInfoFieldJSON result = new CodeDataOAuth2RequestInfoFieldJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCodeDataOAuth2RequestInfoFieldAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CodeDataOAuth2RequestInfoFieldJSON result)
          {
            if (fieldGeneratorCode.have_value)
              {
                result.setCode(fieldGeneratorCode.value);
                fieldGeneratorCode.have_value = false;
              }
            else if ((!(result.hasCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Code\" field was missing.");
              }
            if (fieldGeneratorRedirectURI.have_value)
              {
                result.setRedirectURI(fieldGeneratorRedirectURI.value);
                fieldGeneratorRedirectURI.have_value = false;
              }
            else if ((!(result.hasRedirectURI())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RedirectURI\" field was missing.");
              }
          }
        protected abstract void handle_result(CodeDataOAuth2RequestInfoFieldJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ode", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorCode;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "edirectURI", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorRedirectURI;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCode = new JSONHoldingStringGenerator("field \"Code\" of the CodeDataOAuth2RequestInfoField class");
            fieldGeneratorRedirectURI = new JSONHoldingStringGenerator("field \"RedirectURI\" of the CodeDataOAuth2RequestInfoField class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CodeDataOAuth2RequestInfoField class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCode = new JSONHoldingStringGenerator("field \"Code\" of the CodeDataOAuth2RequestInfoField class");
            fieldGeneratorRedirectURI = new JSONHoldingStringGenerator("field \"RedirectURI\" of the CodeDataOAuth2RequestInfoField class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CodeDataOAuth2RequestInfoField class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCode.reset();
            fieldGeneratorRedirectURI.reset();
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
        protected override void handle_result(CodeDataOAuth2RequestInfoFieldJSON  result)
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
        public CodeDataOAuth2RequestInfoFieldJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CodeDataOAuth2RequestInfoFieldJSON  result)
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
    protected virtual void handle_result(List<CodeDataOAuth2RequestInfoFieldJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CodeDataOAuth2RequestInfoFieldJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CodeDataOAuth2RequestInfoFieldJSON>();
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
    public List<CodeDataOAuth2RequestInfoFieldJSON> value;
  };
  };
