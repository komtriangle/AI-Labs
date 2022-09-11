/* file "PropertyJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class PropertyJSON : JSONBase
  {
    private bool flagHasSpokenLabel;
    private string storeSpokenLabel;
    private bool flagHasWrittenLabel;
    private string storeWrittenLabel;
    private bool flagHasSpokenLabelSSML;
    private string storeSpokenLabelSSML;


    private void  fromJSONSpokenLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenLabel of PropertyJSON is not a string.");
        setSpokenLabel(json_string.getData());
      }


    private void  fromJSONWrittenLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenLabel of PropertyJSON is not a string.");
        setWrittenLabel(json_string.getData());
      }


    private void  fromJSONSpokenLabelSSML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenLabelSSML of PropertyJSON is not a string.");
        setSpokenLabelSSML(json_string.getData());
      }


    public PropertyJSON()
      {
        flagHasSpokenLabel = false;
        flagHasWrittenLabel = false;
        flagHasSpokenLabelSSML = false;
      }

    public abstract string getPropertyKind();
    public bool  hasSpokenLabel()
      {
        return flagHasSpokenLabel;
      }

    public string  getSpokenLabel()
      {
        Debug.Assert(flagHasSpokenLabel);
        return storeSpokenLabel;
      }

    public bool  hasWrittenLabel()
      {
        return flagHasWrittenLabel;
      }

    public string  getWrittenLabel()
      {
        Debug.Assert(flagHasWrittenLabel);
        return storeWrittenLabel;
      }

    public bool  hasSpokenLabelSSML()
      {
        return flagHasSpokenLabelSSML;
      }

    public string  getSpokenLabelSSML()
      {
        Debug.Assert(flagHasSpokenLabelSSML);
        return storeSpokenLabelSSML;
      }


    public abstract int extraPropertyComponentCount();
    public abstract string extraPropertyComponentKey(int component_num);
    public abstract JSONValue extraPropertyComponentValue(int component_num);
    public abstract JSONValue extraPropertyLookup(string field_name);

    public void setSpokenLabel(string new_value)
      {
        flagHasSpokenLabel = true;
        storeSpokenLabel = new_value;
      }
    public void unsetSpokenLabel()
      {
        flagHasSpokenLabel = false;
      }
    public void setWrittenLabel(string new_value)
      {
        flagHasWrittenLabel = true;
        storeWrittenLabel = new_value;
      }
    public void unsetWrittenLabel()
      {
        flagHasWrittenLabel = false;
      }
    public void setSpokenLabelSSML(string new_value)
      {
        flagHasSpokenLabelSSML = true;
        storeSpokenLabelSSML = new_value;
      }
    public void unsetSpokenLabelSSML()
      {
        flagHasSpokenLabelSSML = false;
      }

    public abstract void extraPropertyAppendPair(string key, JSONValue new_component);
    public abstract void extraPropertySetField(string key, JSONValue new_component);

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
        handler.pair("PropertyKind", getPropertyKind());
        Debug.Assert(partial_allowed || flagHasSpokenLabel);
        if (flagHasSpokenLabel)
          {
            handler.start_pair("SpokenLabel");
            handler.string_value(storeSpokenLabel);
          }
        Debug.Assert(partial_allowed || flagHasWrittenLabel);
        if (flagHasWrittenLabel)
          {
            handler.start_pair("WrittenLabel");
            handler.string_value(storeWrittenLabel);
          }
        if (flagHasSpokenLabelSSML)
          {
            handler.start_pair("SpokenLabelSSML");
            handler.string_value(storeSpokenLabelSSML);
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
        if ((!allow_unpolished) && !(hasSpokenLabel()))
          {
            return "When parsing the object for %what%, the \"SpokenLabel\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasWrittenLabel()))
          {
            return "When parsing the object for %what%, the \"WrittenLabel\" field was missing.";
          }
        return null;
      }

    public static PropertyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Property", ignore_extras);
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
    public static PropertyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PropertyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Property", ignore_extras);
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
    public static PropertyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PropertyJSON from_text(string text, bool ignore_extras)
      {
        PropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Property", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PropertyJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static PropertyJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Property", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSpokenLabel;
        private JSONHoldingStringGenerator fieldGeneratorWrittenLabel;
        private JSONHoldingStringGenerator fieldGeneratorSpokenLabelSSML;
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
                throw new Exception("The `PropertyKind' field is missing.");
            PropertyJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPropertyAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getPropertyJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `PropertyKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(PropertyJSON result)
          {
            if (fieldGeneratorSpokenLabel.have_value)
              {
                result.setSpokenLabel(fieldGeneratorSpokenLabel.value);
                fieldGeneratorSpokenLabel.have_value = false;
              }
            else if ((!(result.hasSpokenLabel())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenLabel\" field was missing.");
              }
            if (fieldGeneratorWrittenLabel.have_value)
              {
                result.setWrittenLabel(fieldGeneratorWrittenLabel.value);
                fieldGeneratorWrittenLabel.have_value = false;
              }
            else if ((!(result.hasWrittenLabel())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenLabel\" field was missing.");
              }
            if (fieldGeneratorSpokenLabelSSML.have_value)
              {
                result.setSpokenLabelSSML(fieldGeneratorSpokenLabelSSML.value);
                fieldGeneratorSpokenLabelSSML.have_value = false;
              }
          }
        protected abstract void handle_result(PropertyJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'P':
                    if ((String.Compare(field_name, 1, "ropertyKind", 0, 11, false) == 0) && (field_name.Length == 12))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "pokenLabel", 0, 10, false) == 0)
                      {
                        if (field_name.Length == 11)
                          {
                            return fieldGeneratorSpokenLabel;
                          }
                        switch (field_name[11])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 12, "SML", 0, 3, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorSpokenLabelSSML;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "rittenLabel", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorWrittenLabel;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSpokenLabel = new JSONHoldingStringGenerator("field \"SpokenLabel\" of the Property class");
            fieldGeneratorWrittenLabel = new JSONHoldingStringGenerator("field \"WrittenLabel\" of the Property class");
            fieldGeneratorSpokenLabelSSML = new JSONHoldingStringGenerator("field \"SpokenLabelSSML\" of the Property class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"PropertyKind\" of the Property class");
            set_what("the Property class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpokenLabel = new JSONHoldingStringGenerator("field \"SpokenLabel\" of the Property class");
            fieldGeneratorWrittenLabel = new JSONHoldingStringGenerator("field \"WrittenLabel\" of the Property class");
            fieldGeneratorSpokenLabelSSML = new JSONHoldingStringGenerator("field \"SpokenLabelSSML\" of the Property class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"PropertyKind\" of the Property class");
            set_what("the Property class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSpokenLabel.reset();
            fieldGeneratorWrittenLabel.reset();
            fieldGeneratorSpokenLabelSSML.reset();
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
        protected override void handle_result(PropertyJSON  result)
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
        public PropertyJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PropertyJSON  result)
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
    protected virtual void handle_result(List<PropertyJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PropertyJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PropertyJSON>();
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
    public List<PropertyJSON> value;
  };
    class GenericPropertyJSON : PropertyJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericPropertyJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getPropertyKind()  { return key; }
        public override int extraPropertyComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraPropertyComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraPropertyComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraPropertyLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraPropertyAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraPropertySetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraPropertyLookup(key);
            if (old_field == null)
              {
                extraPropertyAppendPair(key, new_component);
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
    public static PropertyJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'A':
            if ((String.Compare(key, 1, "ddress", 0, 6, false) == 0) && (key.Length == 7))
                return new AddressPropertyJSON();
            break;
        case 'C':
            if ((String.Compare(key, 1, "ore", 0, 3, false) == 0) && (key.Length == 4))
                return new CoreUnitsPropertyJSON();
            break;
        case 'E':
            if ((String.Compare(key, 1, "mailAddress", 0, 11, false) == 0) && (key.Length == 12))
                return new EmailAddressPropertyJSON();
            break;
        case 'L':
            switch (key[1])
              {
                case 'a':
                    if (String.Compare(key, 2, "beled", 0, 5, false) == 0)
                      {
                        switch (key[7])
                          {
                            case 'A':
                                if ((String.Compare(key, 8, "ddress", 0, 6, false) == 0) && (key.Length == 14))
                                    return new LabeledAddressPropertyJSON();
                                break;
                            case 'E':
                                if ((String.Compare(key, 8, "mailAddress", 0, 11, false) == 0) && (key.Length == 19))
                                    return new LabeledEmailAddressPropertyJSON();
                                break;
                            case 'P':
                                if ((String.Compare(key, 8, "honeNumber", 0, 10, false) == 0) && (key.Length == 18))
                                    return new LabeledPhoneNumberPropertyJSON();
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'o':
                    if ((String.Compare(key, 2, "cation", 0, 6, false) == 0) && (key.Length == 8))
                        return new LocationPropertyJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'M':
            if ((String.Compare(key, 1, "onetary", 0, 7, false) == 0) && (key.Length == 8))
                return new MonetaryUnitsPropertyJSON();
            break;
        case 'P':
            if ((String.Compare(key, 1, "honeNumber", 0, 10, false) == 0) && (key.Length == 11))
                return new PhoneNumberPropertyJSON();
            break;
        default:
            break;
      }

        return new GenericPropertyJSON(key);
      }
  };
