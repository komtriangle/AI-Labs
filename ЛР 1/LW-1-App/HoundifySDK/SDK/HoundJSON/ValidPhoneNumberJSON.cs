/* file "ValidPhoneNumberJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ValidPhoneNumberJSON : JSONBase
  {
    private bool flagHasContactName;
    private string storeContactName;
    private bool flagHasLabel;
    private string storeLabel;
    private bool flagHasContactID;
    private string storeContactID;
    private bool flagHasPhoneNumber;
    private string storePhoneNumber;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONContactName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ContactName of ValidPhoneNumberJSON is not a string.");
        setContactName(json_string.getData());
      }


    private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Label of ValidPhoneNumberJSON is not a string.");
        setLabel(json_string.getData());
      }


    private void  fromJSONContactID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ContactID of ValidPhoneNumberJSON is not a string.");
        setContactID(json_string.getData());
      }


    private void  fromJSONPhoneNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PhoneNumber of ValidPhoneNumberJSON is not a string.");
        setPhoneNumber(json_string.getData());
      }


    public ValidPhoneNumberJSON()
      {
        flagHasContactName = false;
        flagHasLabel = false;
        flagHasContactID = false;
        flagHasPhoneNumber = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasContactName()
      {
        return flagHasContactName;
      }

    public string  getContactName()
      {
        Debug.Assert(flagHasContactName);
        return storeContactName;
      }

    public bool  hasLabel()
      {
        return flagHasLabel;
      }

    public string  getLabel()
      {
        Debug.Assert(flagHasLabel);
        return storeLabel;
      }

    public bool  hasContactID()
      {
        return flagHasContactID;
      }

    public string  getContactID()
      {
        Debug.Assert(flagHasContactID);
        return storeContactID;
      }

    public bool  hasPhoneNumber()
      {
        return flagHasPhoneNumber;
      }

    public string  getPhoneNumber()
      {
        Debug.Assert(flagHasPhoneNumber);
        return storePhoneNumber;
      }


    public virtual int extraValidPhoneNumberComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraValidPhoneNumberComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraValidPhoneNumberComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraValidPhoneNumberLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setContactName(string new_value)
      {
        flagHasContactName = true;
        storeContactName = new_value;
      }
    public void unsetContactName()
      {
        flagHasContactName = false;
      }
    public void setLabel(string new_value)
      {
        flagHasLabel = true;
        storeLabel = new_value;
      }
    public void unsetLabel()
      {
        flagHasLabel = false;
      }
    public void setContactID(string new_value)
      {
        flagHasContactID = true;
        storeContactID = new_value;
      }
    public void unsetContactID()
      {
        flagHasContactID = false;
      }
    public void setPhoneNumber(string new_value)
      {
        flagHasPhoneNumber = true;
        storePhoneNumber = new_value;
      }
    public void unsetPhoneNumber()
      {
        flagHasPhoneNumber = false;
      }

    public virtual void extraValidPhoneNumberAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraValidPhoneNumberSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraValidPhoneNumberLookup(key);
        if (old_field == null)
          {
            extraValidPhoneNumberAppendPair(key, new_component);
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
        if (flagHasContactName)
          {
            handler.start_pair("ContactName");
            handler.string_value(storeContactName);
          }
        if (flagHasLabel)
          {
            handler.start_pair("Label");
            handler.string_value(storeLabel);
          }
        if (flagHasContactID)
          {
            handler.start_pair("ContactID");
            handler.string_value(storeContactID);
          }
        Debug.Assert(partial_allowed || flagHasPhoneNumber);
        if (flagHasPhoneNumber)
          {
            handler.start_pair("PhoneNumber");
            handler.string_value(storePhoneNumber);
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
        if (!(hasPhoneNumber()))
          {
            return "When parsing the object for %what%, the \"PhoneNumber\" field was missing.";
          }
        return null;
      }

    public static ValidPhoneNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ValidPhoneNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ValidPhoneNumber", ignore_extras);
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
    public static ValidPhoneNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ValidPhoneNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ValidPhoneNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ValidPhoneNumber", ignore_extras);
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
    public static ValidPhoneNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ValidPhoneNumberJSON from_text(string text, bool ignore_extras)
      {
        ValidPhoneNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ValidPhoneNumber", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ValidPhoneNumberJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ValidPhoneNumberJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ValidPhoneNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ValidPhoneNumber", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorContactName;
        private JSONHoldingStringGenerator fieldGeneratorLabel;
        private JSONHoldingStringGenerator fieldGeneratorContactID;
        private JSONHoldingStringGenerator fieldGeneratorPhoneNumber;
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
            ValidPhoneNumberJSON result = new ValidPhoneNumberJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraValidPhoneNumberAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ValidPhoneNumberJSON result)
          {
            if (fieldGeneratorContactName.have_value)
              {
                result.setContactName(fieldGeneratorContactName.value);
                fieldGeneratorContactName.have_value = false;
              }
            if (fieldGeneratorLabel.have_value)
              {
                result.setLabel(fieldGeneratorLabel.value);
                fieldGeneratorLabel.have_value = false;
              }
            if (fieldGeneratorContactID.have_value)
              {
                result.setContactID(fieldGeneratorContactID.value);
                fieldGeneratorContactID.have_value = false;
              }
            if (fieldGeneratorPhoneNumber.have_value)
              {
                result.setPhoneNumber(fieldGeneratorPhoneNumber.value);
                fieldGeneratorPhoneNumber.have_value = false;
              }
            else if ((!(result.hasPhoneNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PhoneNumber\" field was missing.");
              }
          }
        protected abstract void handle_result(ValidPhoneNumberJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "ontact", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 8, "D", 0, 1, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorContactID;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 8, "ame", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorContactName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorLabel;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "honeNumber", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorPhoneNumber;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorContactName = new JSONHoldingStringGenerator("field \"ContactName\" of the ValidPhoneNumber class");
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the ValidPhoneNumber class");
            fieldGeneratorContactID = new JSONHoldingStringGenerator("field \"ContactID\" of the ValidPhoneNumber class");
            fieldGeneratorPhoneNumber = new JSONHoldingStringGenerator("field \"PhoneNumber\" of the ValidPhoneNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ValidPhoneNumber class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorContactName = new JSONHoldingStringGenerator("field \"ContactName\" of the ValidPhoneNumber class");
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the ValidPhoneNumber class");
            fieldGeneratorContactID = new JSONHoldingStringGenerator("field \"ContactID\" of the ValidPhoneNumber class");
            fieldGeneratorPhoneNumber = new JSONHoldingStringGenerator("field \"PhoneNumber\" of the ValidPhoneNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ValidPhoneNumber class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorContactName.reset();
            fieldGeneratorLabel.reset();
            fieldGeneratorContactID.reset();
            fieldGeneratorPhoneNumber.reset();
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
        protected override void handle_result(ValidPhoneNumberJSON  result)
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
        public ValidPhoneNumberJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ValidPhoneNumberJSON  result)
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
    protected virtual void handle_result(List<ValidPhoneNumberJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ValidPhoneNumberJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ValidPhoneNumberJSON>();
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
    public List<ValidPhoneNumberJSON> value;
  };
  };
