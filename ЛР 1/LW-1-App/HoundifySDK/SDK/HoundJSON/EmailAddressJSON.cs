/* file "EmailAddressJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class EmailAddressJSON : JSONBase
  {
    private bool flagHasEmailAddress;
    private string storeEmailAddress;
    private bool flagHasDerivation;
    private DerivationJSON  storeDerivation;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONEmailAddress(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EmailAddress of EmailAddressJSON is not a string.");
        setEmailAddress(json_string.getData());
      }


    private void  fromJSONDerivation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DerivationJSON convert_classy = DerivationJSON.from_json(json_value, ignore_extras, true);
        setDerivation(convert_classy);
      }


    public EmailAddressJSON()
      {
        flagHasEmailAddress = false;
        flagHasDerivation = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasEmailAddress()
      {
        return flagHasEmailAddress;
      }

    public string  getEmailAddress()
      {
        Debug.Assert(flagHasEmailAddress);
        return storeEmailAddress;
      }

    public bool  hasDerivation()
      {
        return flagHasDerivation;
      }

    public DerivationJSON   getDerivation()
      {
        Debug.Assert(flagHasDerivation);
        return storeDerivation;
      }


    public virtual int extraEmailAddressComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraEmailAddressComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraEmailAddressComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraEmailAddressLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setEmailAddress(string new_value)
      {
        flagHasEmailAddress = true;
        storeEmailAddress = new_value;
      }
    public void unsetEmailAddress()
      {
        flagHasEmailAddress = false;
      }
    public void setDerivation(DerivationJSON  new_value)
      {
        if (flagHasDerivation)
          {
          }
        flagHasDerivation = true;
        storeDerivation = new_value;
      }
    public void unsetDerivation()
      {
        if (flagHasDerivation)
          {
          }
        flagHasDerivation = false;
      }

    public virtual void extraEmailAddressAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraEmailAddressSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraEmailAddressLookup(key);
        if (old_field == null)
          {
            extraEmailAddressAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasEmailAddress);
        if (flagHasEmailAddress)
          {
            handler.start_pair("EmailAddress");
            handler.string_value(storeEmailAddress);
          }
        Debug.Assert(partial_allowed || flagHasDerivation);
        if (flagHasDerivation)
          {
            handler.start_pair("Derivation");
            if (partial_allowed)
                storeDerivation.write_partial_as_json(handler);
            else
                storeDerivation.write_as_json(handler);
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
        if (!(hasEmailAddress()))
          {
            return "When parsing the object for %what%, the \"EmailAddress\" field was missing.";
          }
        if (!(hasDerivation()))
          {
            return "When parsing the object for %what%, the \"Derivation\" field was missing.";
          }
        return null;
      }

    public static EmailAddressJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmailAddressJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailAddress", ignore_extras);
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
    public static EmailAddressJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EmailAddressJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmailAddressJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailAddress", ignore_extras);
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
    public static EmailAddressJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EmailAddressJSON from_text(string text, bool ignore_extras)
      {
        EmailAddressJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailAddress", ignore_extras);
            JSONParse.parse_json_value(text, "Text for EmailAddressJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static EmailAddressJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        EmailAddressJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailAddress", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorEmailAddress;
        private DerivationJSON.HoldingGenerator fieldGeneratorDerivation;
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
            EmailAddressJSON result = new EmailAddressJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraEmailAddressAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(EmailAddressJSON result)
          {
            if (fieldGeneratorEmailAddress.have_value)
              {
                result.setEmailAddress(fieldGeneratorEmailAddress.value);
                fieldGeneratorEmailAddress.have_value = false;
              }
            else if ((!(result.hasEmailAddress())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EmailAddress\" field was missing.");
              }
            if (fieldGeneratorDerivation.have_value)
              {
                result.setDerivation(fieldGeneratorDerivation.value);
                fieldGeneratorDerivation.have_value = false;
              }
            else if ((!(result.hasDerivation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Derivation\" field was missing.");
              }
          }
        protected abstract void handle_result(EmailAddressJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "erivation", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorDerivation;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "mailAddress", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorEmailAddress;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorEmailAddress = new JSONHoldingStringGenerator("field \"EmailAddress\" of the EmailAddress class");
            fieldGeneratorDerivation = new DerivationJSON.HoldingGenerator("field \"Derivation\" of the EmailAddress class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the EmailAddress class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorEmailAddress = new JSONHoldingStringGenerator("field \"EmailAddress\" of the EmailAddress class");
            fieldGeneratorDerivation = new DerivationJSON.HoldingGenerator("field \"Derivation\" of the EmailAddress class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the EmailAddress class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorEmailAddress.reset();
            fieldGeneratorDerivation.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDerivation.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDerivation.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(EmailAddressJSON  result)
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
        public EmailAddressJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(EmailAddressJSON  result)
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
    protected virtual void handle_result(List<EmailAddressJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<EmailAddressJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<EmailAddressJSON>();
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
    public List<EmailAddressJSON> value;
  };
  };
