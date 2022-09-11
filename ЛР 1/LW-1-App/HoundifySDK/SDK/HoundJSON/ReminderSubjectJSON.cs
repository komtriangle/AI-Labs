/* file "ReminderSubjectJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ReminderSubjectJSON : JSONBase
  {
    private bool flagHasValue;
    private string storeValue;
    private bool flagHasIsImperative;
    private bool storeIsImperative;
    private bool flagHasHasFirstOrSecondPersonPronouns;
    private bool storeHasFirstOrSecondPersonPronouns;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Value of ReminderSubjectJSON is not a string.");
        setValue(json_string.getData());
      }


    private void  fromJSONIsImperative(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field IsImperative of ReminderSubjectJSON is not true for false.");
              }
          }
        setIsImperative(the_bool);
      }


    private void  fromJSONHasFirstOrSecondPersonPronouns(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field HasFirstOrSecondPersonPronouns of ReminderSubjectJSON is not true for false.");
              }
          }
        setHasFirstOrSecondPersonPronouns(the_bool);
      }


    public ReminderSubjectJSON()
      {
        flagHasValue = false;
        flagHasIsImperative = false;
        flagHasHasFirstOrSecondPersonPronouns = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public string  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public bool  hasIsImperative()
      {
        return flagHasIsImperative;
      }

    public bool  getIsImperative()
      {
        Debug.Assert(flagHasIsImperative);
        return storeIsImperative;
      }

    public bool  hasHasFirstOrSecondPersonPronouns()
      {
        return flagHasHasFirstOrSecondPersonPronouns;
      }

    public bool  getHasFirstOrSecondPersonPronouns()
      {
        Debug.Assert(flagHasHasFirstOrSecondPersonPronouns);
        return storeHasFirstOrSecondPersonPronouns;
      }


    public virtual int extraReminderSubjectComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraReminderSubjectComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraReminderSubjectComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraReminderSubjectLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setValue(string new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }
    public void setIsImperative(bool new_value)
      {
        flagHasIsImperative = true;
        storeIsImperative = new_value;
      }
    public void unsetIsImperative()
      {
        flagHasIsImperative = false;
      }
    public void setHasFirstOrSecondPersonPronouns(bool new_value)
      {
        flagHasHasFirstOrSecondPersonPronouns = true;
        storeHasFirstOrSecondPersonPronouns = new_value;
      }
    public void unsetHasFirstOrSecondPersonPronouns()
      {
        flagHasHasFirstOrSecondPersonPronouns = false;
      }

    public virtual void extraReminderSubjectAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraReminderSubjectSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraReminderSubjectLookup(key);
        if (old_field == null)
          {
            extraReminderSubjectAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasValue);
        if (flagHasValue)
          {
            handler.start_pair("Value");
            handler.string_value(storeValue);
          }
        if (flagHasIsImperative)
          {
            handler.start_pair("IsImperative");
            handler.boolean_value(storeIsImperative);
          }
        if (flagHasHasFirstOrSecondPersonPronouns)
          {
            handler.start_pair("HasFirstOrSecondPersonPronouns");
            handler.boolean_value(storeHasFirstOrSecondPersonPronouns);
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
        if (!(hasValue()))
          {
            return "When parsing the object for %what%, the \"Value\" field was missing.";
          }
        return null;
      }

    public static ReminderSubjectJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ReminderSubjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ReminderSubject", ignore_extras);
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
    public static ReminderSubjectJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ReminderSubjectJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ReminderSubjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ReminderSubject", ignore_extras);
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
    public static ReminderSubjectJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ReminderSubjectJSON from_text(string text, bool ignore_extras)
      {
        ReminderSubjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ReminderSubject", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ReminderSubjectJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ReminderSubjectJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ReminderSubjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ReminderSubject", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorValue;
        private JSONHoldingBooleanGenerator fieldGeneratorIsImperative;
        private JSONHoldingBooleanGenerator fieldGeneratorHasFirstOrSecondPersonPronouns;
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
            ReminderSubjectJSON result = new ReminderSubjectJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraReminderSubjectAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ReminderSubjectJSON result)
          {
            if (fieldGeneratorValue.have_value)
              {
                result.setValue(fieldGeneratorValue.value);
                fieldGeneratorValue.have_value = false;
              }
            else if ((!(result.hasValue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Value\" field was missing.");
              }
            if (fieldGeneratorIsImperative.have_value)
              {
                result.setIsImperative(fieldGeneratorIsImperative.value);
                fieldGeneratorIsImperative.have_value = false;
              }
            if (fieldGeneratorHasFirstOrSecondPersonPronouns.have_value)
              {
                result.setHasFirstOrSecondPersonPronouns(fieldGeneratorHasFirstOrSecondPersonPronouns.value);
                fieldGeneratorHasFirstOrSecondPersonPronouns.have_value = false;
              }
          }
        protected abstract void handle_result(ReminderSubjectJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'H':
                    if ((String.Compare(field_name, 1, "asFirstOrSecondPersonPronouns", 0, 29, false) == 0) && (field_name.Length == 30))
                        return fieldGeneratorHasFirstOrSecondPersonPronouns;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sImperative", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorIsImperative;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorValue = new JSONHoldingStringGenerator("field \"Value\" of the ReminderSubject class");
            fieldGeneratorIsImperative = new JSONHoldingBooleanGenerator("field \"IsImperative\" of the ReminderSubject class");
            fieldGeneratorHasFirstOrSecondPersonPronouns = new JSONHoldingBooleanGenerator("field \"HasFirstOrSecondPersonPronouns\" of the ReminderSubject class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ReminderSubject class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorValue = new JSONHoldingStringGenerator("field \"Value\" of the ReminderSubject class");
            fieldGeneratorIsImperative = new JSONHoldingBooleanGenerator("field \"IsImperative\" of the ReminderSubject class");
            fieldGeneratorHasFirstOrSecondPersonPronouns = new JSONHoldingBooleanGenerator("field \"HasFirstOrSecondPersonPronouns\" of the ReminderSubject class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ReminderSubject class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorValue.reset();
            fieldGeneratorIsImperative.reset();
            fieldGeneratorHasFirstOrSecondPersonPronouns.reset();
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
        protected override void handle_result(ReminderSubjectJSON  result)
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
        public ReminderSubjectJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ReminderSubjectJSON  result)
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
    protected virtual void handle_result(List<ReminderSubjectJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ReminderSubjectJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ReminderSubjectJSON>();
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
    public List<ReminderSubjectJSON> value;
  };
  };
