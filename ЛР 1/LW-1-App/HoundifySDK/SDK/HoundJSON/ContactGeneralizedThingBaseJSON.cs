/* file "ContactGeneralizedThingBaseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class ContactGeneralizedThingBaseJSON : GeneralizedThingJSON
  {

    public ContactGeneralizedThingBaseJSON()
      {
      }

    public override string  getThingKind()
      {
        return "Contact";
      }

    public abstract string getContactInformationKind();

    public abstract int extraContactGeneralizedThingBaseComponentCount();
    public abstract string extraContactGeneralizedThingBaseComponentKey(int component_num);
    public abstract JSONValue extraContactGeneralizedThingBaseComponentValue(int component_num);
    public abstract JSONValue extraContactGeneralizedThingBaseLookup(string field_name);
    public override int extraGeneralizedThingComponentCount()
      {
        int result = 1;
        result += extraContactGeneralizedThingBaseComponentCount();
        return result;
      }
    public override string extraGeneralizedThingComponentKey(int component_num)
      {
        if (component_num == 0)
            return "ContactInformationKind";
        return extraContactGeneralizedThingBaseComponentKey((component_num - 1));
      }
    public override JSONValue extraGeneralizedThingComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getContactInformationKind());
        return extraContactGeneralizedThingBaseComponentValue((component_num - 1));
      }
    public override JSONValue extraGeneralizedThingLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "ContactInformationKind", 0, 22, false) == 0) && (field_name.Length == 22))
            return new JSONStringValue(getContactInformationKind());
        return extraContactGeneralizedThingBaseLookup(field_name);
      }


    public abstract void extraContactGeneralizedThingBaseAppendPair(string key, JSONValue new_component);
    public abstract void extraContactGeneralizedThingBaseSetField(string key, JSONValue new_component);
    public override void extraGeneralizedThingAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "ContactInformationKind", 0, 22, false) == 0) && (key.Length == 22))
            return;
        extraContactGeneralizedThingBaseAppendPair(key, new_component);
      }
    public override void extraGeneralizedThingSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "ContactInformationKind", 0, 22, false) == 0) && (key.Length == 22))
            return;
        extraContactGeneralizedThingBaseSetField(key, new_component);
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
        handler.pair("ContactInformationKind", getContactInformationKind());
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

    public static new ContactGeneralizedThingBaseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactGeneralizedThingBaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactGeneralizedThingBase", ignore_extras);
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
    public static new ContactGeneralizedThingBaseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ContactGeneralizedThingBaseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactGeneralizedThingBaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactGeneralizedThingBase", ignore_extras);
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
    public static new ContactGeneralizedThingBaseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ContactGeneralizedThingBaseJSON from_text(string text, bool ignore_extras)
      {
        ContactGeneralizedThingBaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactGeneralizedThingBase", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ContactGeneralizedThingBaseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ContactGeneralizedThingBaseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ContactGeneralizedThingBaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactGeneralizedThingBase", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : GeneralizedThingJSON.Generator
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
                throw new Exception("The `ContactInformationKind' field is missing.");
            if (!(getGeneralizedThingJSONKey().Equals("Contact")))
                throw new Exception("The key field has a value other than `Contact'.");
            ContactGeneralizedThingBaseJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraContactGeneralizedThingBaseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getContactGeneralizedThingBaseJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `ContactInformationKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(GeneralizedThingJSON new_result)
          {
            handle_result((ContactGeneralizedThingBaseJSON )new_result);
          }
        protected void finish(ContactGeneralizedThingBaseJSON result)
          {
            base.finish(result);
          }
        protected abstract void handle_result(ContactGeneralizedThingBaseJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "ContactInformationKind", 0, 22, false) == 0) && (field_name.Length == 22))
                {
                keyGenerator.reset();
                return keyGenerator;
                }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ContactInformationKind\" of the ContactGeneralizedThingBase class");
            set_what("the ContactGeneralizedThingBase class");
          }
        public Generator() : base(false)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ContactInformationKind\" of the ContactGeneralizedThingBase class");
            set_what("the ContactGeneralizedThingBase class");
          }

        public override void reset()
          {
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ContactGeneralizedThingBaseJSON  result)
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
        public ContactGeneralizedThingBaseJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ContactGeneralizedThingBaseJSON  result)
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
    protected virtual void handle_result(List<ContactGeneralizedThingBaseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ContactGeneralizedThingBaseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ContactGeneralizedThingBaseJSON>();
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
    public List<ContactGeneralizedThingBaseJSON> value;
  };
    class GenericContactGeneralizedThingBaseJSON : ContactGeneralizedThingBaseJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericContactGeneralizedThingBaseJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getContactInformationKind()  { return key; }
        public override int extraContactGeneralizedThingBaseComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraContactGeneralizedThingBaseComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraContactGeneralizedThingBaseComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraContactGeneralizedThingBaseLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraContactGeneralizedThingBaseAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraContactGeneralizedThingBaseSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraContactGeneralizedThingBaseLookup(key);
            if (old_field == null)
              {
                extraContactGeneralizedThingBaseAppendPair(key, new_component);
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
    public static new ContactGeneralizedThingBaseJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'C':
            if ((String.Compare(key, 1, "ontactAccessContact", 0, 19, false) == 0) && (key.Length == 20))
                return new ContactGeneralizedThingJSON();
            break;
        case 'M':
            if ((String.Compare(key, 1, "emberContact", 0, 12, false) == 0) && (key.Length == 13))
                return new MemberContactGeneralizedThingJSON();
            break;
        default:
            break;
      }

        return new GenericContactGeneralizedThingBaseJSON(key);
      }
  };
