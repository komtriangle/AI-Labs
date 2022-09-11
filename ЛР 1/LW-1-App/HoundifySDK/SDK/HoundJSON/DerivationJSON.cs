/* file "DerivationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class DerivationJSON : JSONBase
  {
    private bool flagHasSpokenForm;
    private string storeSpokenForm;
    private bool flagHasWrittenForm;
    private string storeWrittenForm;
    private bool flagHasSpokenFormSSML;
    private string storeSpokenFormSSML;


    private void  fromJSONSpokenForm(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenForm of DerivationJSON is not a string.");
        setSpokenForm(json_string.getData());
      }


    private void  fromJSONWrittenForm(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenForm of DerivationJSON is not a string.");
        setWrittenForm(json_string.getData());
      }


    private void  fromJSONSpokenFormSSML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenFormSSML of DerivationJSON is not a string.");
        setSpokenFormSSML(json_string.getData());
      }


    public DerivationJSON()
      {
        flagHasSpokenForm = false;
        flagHasWrittenForm = false;
        flagHasSpokenFormSSML = false;
      }

    public abstract string getDerivationKind();
    public bool  hasSpokenForm()
      {
        return flagHasSpokenForm;
      }

    public string  getSpokenForm()
      {
        Debug.Assert(flagHasSpokenForm);
        return storeSpokenForm;
      }

    public bool  hasWrittenForm()
      {
        return flagHasWrittenForm;
      }

    public string  getWrittenForm()
      {
        Debug.Assert(flagHasWrittenForm);
        return storeWrittenForm;
      }

    public bool  hasSpokenFormSSML()
      {
        return flagHasSpokenFormSSML;
      }

    public string  getSpokenFormSSML()
      {
        Debug.Assert(flagHasSpokenFormSSML);
        return storeSpokenFormSSML;
      }


    public abstract int extraDerivationComponentCount();
    public abstract string extraDerivationComponentKey(int component_num);
    public abstract JSONValue extraDerivationComponentValue(int component_num);
    public abstract JSONValue extraDerivationLookup(string field_name);

    public void setSpokenForm(string new_value)
      {
        flagHasSpokenForm = true;
        storeSpokenForm = new_value;
      }
    public void unsetSpokenForm()
      {
        flagHasSpokenForm = false;
      }
    public void setWrittenForm(string new_value)
      {
        flagHasWrittenForm = true;
        storeWrittenForm = new_value;
      }
    public void unsetWrittenForm()
      {
        flagHasWrittenForm = false;
      }
    public void setSpokenFormSSML(string new_value)
      {
        flagHasSpokenFormSSML = true;
        storeSpokenFormSSML = new_value;
      }
    public void unsetSpokenFormSSML()
      {
        flagHasSpokenFormSSML = false;
      }

    public abstract void extraDerivationAppendPair(string key, JSONValue new_component);
    public abstract void extraDerivationSetField(string key, JSONValue new_component);

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
        handler.pair("DerivationKind", getDerivationKind());
        Debug.Assert(partial_allowed || flagHasSpokenForm);
        if (flagHasSpokenForm)
          {
            handler.start_pair("SpokenForm");
            handler.string_value(storeSpokenForm);
          }
        Debug.Assert(partial_allowed || flagHasWrittenForm);
        if (flagHasWrittenForm)
          {
            handler.start_pair("WrittenForm");
            handler.string_value(storeWrittenForm);
          }
        if (flagHasSpokenFormSSML)
          {
            handler.start_pair("SpokenFormSSML");
            handler.string_value(storeSpokenFormSSML);
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
        if ((!allow_unpolished) && !(hasSpokenForm()))
          {
            return "When parsing the object for %what%, the \"SpokenForm\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasWrittenForm()))
          {
            return "When parsing the object for %what%, the \"WrittenForm\" field was missing.";
          }
        return null;
      }

    public static DerivationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DerivationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Derivation", ignore_extras);
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
    public static DerivationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DerivationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DerivationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Derivation", ignore_extras);
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
    public static DerivationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DerivationJSON from_text(string text, bool ignore_extras)
      {
        DerivationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Derivation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DerivationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DerivationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DerivationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Derivation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSpokenForm;
        private JSONHoldingStringGenerator fieldGeneratorWrittenForm;
        private JSONHoldingStringGenerator fieldGeneratorSpokenFormSSML;
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
            if (!(keyGenerator.have_value))
                throw new Exception("The `DerivationKind' field is missing.");
            DerivationJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDerivationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getDerivationJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `DerivationKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(DerivationJSON result)
          {
            if (fieldGeneratorSpokenForm.have_value)
              {
                result.setSpokenForm(fieldGeneratorSpokenForm.value);
                fieldGeneratorSpokenForm.have_value = false;
              }
            else if ((!(result.hasSpokenForm())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenForm\" field was missing.");
              }
            if (fieldGeneratorWrittenForm.have_value)
              {
                result.setWrittenForm(fieldGeneratorWrittenForm.value);
                fieldGeneratorWrittenForm.have_value = false;
              }
            else if ((!(result.hasWrittenForm())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenForm\" field was missing.");
              }
            if (fieldGeneratorSpokenFormSSML.have_value)
              {
                result.setSpokenFormSSML(fieldGeneratorSpokenFormSSML.value);
                fieldGeneratorSpokenFormSSML.have_value = false;
              }
          }
        protected abstract void handle_result(DerivationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "erivationKind", 0, 13, false) == 0) && (field_name.Length == 14))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "pokenForm", 0, 9, false) == 0)
                      {
                        if (field_name.Length == 10)
                          {
                            return fieldGeneratorSpokenForm;
                          }
                        switch (field_name[10])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 11, "SML", 0, 3, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorSpokenFormSSML;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "rittenForm", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorWrittenForm;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSpokenForm = new JSONHoldingStringGenerator("field \"SpokenForm\" of the Derivation class");
            fieldGeneratorWrittenForm = new JSONHoldingStringGenerator("field \"WrittenForm\" of the Derivation class");
            fieldGeneratorSpokenFormSSML = new JSONHoldingStringGenerator("field \"SpokenFormSSML\" of the Derivation class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"DerivationKind\" of the Derivation class");
            set_what("the Derivation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpokenForm = new JSONHoldingStringGenerator("field \"SpokenForm\" of the Derivation class");
            fieldGeneratorWrittenForm = new JSONHoldingStringGenerator("field \"WrittenForm\" of the Derivation class");
            fieldGeneratorSpokenFormSSML = new JSONHoldingStringGenerator("field \"SpokenFormSSML\" of the Derivation class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"DerivationKind\" of the Derivation class");
            set_what("the Derivation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSpokenForm.reset();
            fieldGeneratorWrittenForm.reset();
            fieldGeneratorSpokenFormSSML.reset();
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
        protected override void handle_result(DerivationJSON  result)
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
        public DerivationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DerivationJSON  result)
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
    protected virtual void handle_result(List<DerivationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DerivationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DerivationJSON>();
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
    public List<DerivationJSON> value;
  };
    class GenericDerivationJSON : DerivationJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericDerivationJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getDerivationKind()  { return key; }
        public override int extraDerivationComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraDerivationComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraDerivationComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraDerivationLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraDerivationAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraDerivationSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraDerivationLookup(key);
            if (old_field == null)
              {
                extraDerivationAppendPair(key, new_component);
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
    public static DerivationJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'E':
            if (String.Compare(key, 1, "xplicit", 0, 7, false) == 0)
              {
                switch (key[8])
                  {
                    case 'P':
                        switch (key[9])
                          {
                            case 'h':
                                if ((String.Compare(key, 10, "oneNumber", 0, 9, false) == 0) && (key.Length == 19))
                                    return new ExplicitPhoneNumberDerivationJSON();
                                break;
                            case 'r':
                                if ((String.Compare(key, 10, "opertyDerivation", 0, 16, false) == 0) && (key.Length == 26))
                                    return new ExplicitPropertyDerivationJSON();
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'l':
                        if ((String.Compare(key, 9, "yNamed", 0, 6, false) == 0) && (key.Length == 15))
                            return new ExplicitlyNamedDerivationJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'I':
            if (String.Compare(key, 1, "mplicitProperty", 0, 15, false) == 0)
              {
                if (key.Length == 16)
                  {
                    return new ImplicitPropertyDerivationJSON();
                  }
                switch (key[16])
                  {
                    case 'O':
                        if ((String.Compare(key, 17, "f", 0, 1, false) == 0) && (key.Length == 18))
                            return new ImplicitPropertyOfJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        default:
            break;
      }

        return new GenericDerivationJSON(key);
      }
  };
