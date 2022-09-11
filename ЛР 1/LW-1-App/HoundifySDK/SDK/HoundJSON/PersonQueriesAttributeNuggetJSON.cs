/* file "PersonQueriesAttributeNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class PersonQueriesAttributeNuggetJSON : PersonQueriesNuggetJSON
  {
    private bool flagHasAttribute;
    private PersonAttributeJSON  storeAttribute;
    private bool flagHasObject;
    private PersonProfileJSON  storeObject;


    private JSONValue  extraAttributeToJSON()
      {
        JSONValueHandler handler_Attribute = new JSONValueHandler();
        storeAttribute.write_as_json(handler_Attribute);
        return handler_Attribute.result;
      }

    private JSONValue  extraObjectToJSON()
      {
        JSONValueHandler handler_Object = new JSONValueHandler();
        storeObject.write_as_json(handler_Object);
        return handler_Object.result;
      }


    private void  fromJSONAttribute(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PersonAttributeJSON convert_classy = PersonAttributeJSON.from_json(json_value, ignore_extras, true);
        setAttribute(convert_classy);
      }


    private void  fromJSONObject(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PersonProfileJSON convert_classy = PersonProfileJSON.from_json(json_value, ignore_extras, true);
        setObject(convert_classy);
      }


    public PersonQueriesAttributeNuggetJSON()
      {
        flagHasAttribute = false;
        flagHasObject = false;
      }

    public override string  getPersonQueriesNuggetKind()
      {
        return "PersonAttributeQuery";
      }

    public abstract string getResultType();
    public bool  hasAttribute()
      {
        return flagHasAttribute;
      }

    public PersonAttributeJSON   getAttribute()
      {
        Debug.Assert(flagHasAttribute);
        return storeAttribute;
      }

    public bool  hasObject()
      {
        return flagHasObject;
      }

    public PersonProfileJSON   getObject()
      {
        Debug.Assert(flagHasObject);
        return storeObject;
      }


    public abstract int extraPersonQueriesAttributeNuggetComponentCount();
    public abstract string extraPersonQueriesAttributeNuggetComponentKey(int component_num);
    public abstract JSONValue extraPersonQueriesAttributeNuggetComponentValue(int component_num);
    public abstract JSONValue extraPersonQueriesAttributeNuggetLookup(string field_name);
    public override int extraPersonQueriesNuggetComponentCount()
      {
        int result = 1;
        if (flagHasAttribute)
            ++result;
        if (flagHasObject)
            ++result;
        result += extraPersonQueriesAttributeNuggetComponentCount();
        return result;
      }
    public override string extraPersonQueriesNuggetComponentKey(int component_num)
      {
        if (component_num == 0)
            return "ResultType";
        int remainder = (component_num - 1);
        if (flagHasAttribute)
          {
            if (remainder == 0)
                return "Attribute";
            --remainder;
          }
        if (flagHasObject)
          {
            if (remainder == 0)
                return "Object";
            --remainder;
          }
        return extraPersonQueriesAttributeNuggetComponentKey(remainder);
      }
    public override JSONValue extraPersonQueriesNuggetComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getResultType());
        int remainder = (component_num - 1);
        if (flagHasAttribute)
          {
            if (remainder == 0)
                return extraAttributeToJSON();
            --remainder;
          }
        if (flagHasObject)
          {
            if (remainder == 0)
                return extraObjectToJSON();
            --remainder;
          }
        return extraPersonQueriesAttributeNuggetComponentValue(remainder);
      }
    public override JSONValue extraPersonQueriesNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "ttribute", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasAttribute ? extraAttributeToJSON() : null);
                break;
            case 'O':
                if ((String.Compare(field_name, 1, "bject", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasObject ? extraObjectToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "esultType", 0, 9, false) == 0) && (field_name.Length == 10))
                    return new JSONStringValue(getResultType());
                break;
            default:
                break;
          }
        return extraPersonQueriesAttributeNuggetLookup(field_name);
      }

    public void setAttribute(PersonAttributeJSON  new_value)
      {
        if (flagHasAttribute)
          {
          }
        flagHasAttribute = true;
        storeAttribute = new_value;
      }
    public void unsetAttribute()
      {
        if (flagHasAttribute)
          {
          }
        flagHasAttribute = false;
      }
    public void setObject(PersonProfileJSON  new_value)
      {
        if (flagHasObject)
          {
          }
        flagHasObject = true;
        storeObject = new_value;
      }
    public void unsetObject()
      {
        if (flagHasObject)
          {
          }
        flagHasObject = false;
      }

    public abstract void extraPersonQueriesAttributeNuggetAppendPair(string key, JSONValue new_component);
    public abstract void extraPersonQueriesAttributeNuggetSetField(string key, JSONValue new_component);
    public override void extraPersonQueriesNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttribute", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONAttribute(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "bject", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONObject(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esultType", 0, 9, false) == 0) && (key.Length == 10))
                    return;
                break;
            default:
                break;
          }
        extraPersonQueriesAttributeNuggetAppendPair(key, new_component);
      }
    public override void extraPersonQueriesNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttribute", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONAttribute(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "bject", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONObject(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esultType", 0, 9, false) == 0) && (key.Length == 10))
                    return;
                break;
            default:
                break;
          }
        extraPersonQueriesAttributeNuggetSetField(key, new_component);
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
        handler.pair("ResultType", getResultType());
        Debug.Assert(partial_allowed || flagHasAttribute);
        if (flagHasAttribute)
          {
            handler.start_pair("Attribute");
            if (partial_allowed)
                storeAttribute.write_partial_as_json(handler);
            else
                storeAttribute.write_as_json(handler);
          }
        if (flagHasObject)
          {
            handler.start_pair("Object");
            if (partial_allowed)
                storeObject.write_partial_as_json(handler);
            else
                storeObject.write_as_json(handler);
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
        if (!(hasAttribute()))
          {
            return "When parsing the object for %what%, the \"Attribute\" field was missing.";
          }
        return null;
      }

    public static new PersonQueriesAttributeNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonQueriesAttributeNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonQueriesAttributeNugget", ignore_extras);
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
    public static new PersonQueriesAttributeNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonQueriesAttributeNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonQueriesAttributeNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonQueriesAttributeNugget", ignore_extras);
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
    public static new PersonQueriesAttributeNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonQueriesAttributeNuggetJSON from_text(string text, bool ignore_extras)
      {
        PersonQueriesAttributeNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonQueriesAttributeNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PersonQueriesAttributeNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new PersonQueriesAttributeNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PersonQueriesAttributeNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonQueriesAttributeNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PersonQueriesNuggetJSON.Generator
      {
        private PersonAttributeJSON.HoldingGenerator fieldGeneratorAttribute;
        private PersonProfileJSON.HoldingGenerator fieldGeneratorObject;
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
                throw new Exception("The `ResultType' field is missing.");
            if (!(getPersonQueriesNuggetJSONKey().Equals("PersonAttributeQuery")))
                throw new Exception("The key field has a value other than `PersonAttributeQuery'.");
            PersonQueriesAttributeNuggetJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPersonQueriesAttributeNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getPersonQueriesAttributeNuggetJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `ResultType' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(PersonQueriesNuggetJSON new_result)
          {
            handle_result((PersonQueriesAttributeNuggetJSON )new_result);
          }
        protected void finish(PersonQueriesAttributeNuggetJSON result)
          {
            if (fieldGeneratorAttribute.have_value)
              {
                result.setAttribute(fieldGeneratorAttribute.value);
                fieldGeneratorAttribute.have_value = false;
              }
            else if ((!(result.hasAttribute())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Attribute\" field was missing.");
              }
            if (fieldGeneratorObject.have_value)
              {
                result.setObject(fieldGeneratorObject.value);
                fieldGeneratorObject.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(PersonQueriesAttributeNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttribute", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorAttribute;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "bject", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorObject;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "esultType", 0, 9, false) == 0) && (field_name.Length == 10))
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
            fieldGeneratorAttribute = new PersonAttributeJSON.HoldingGenerator("field \"Attribute\" of the PersonQueriesAttributeNugget class", ignore_extras);
            fieldGeneratorObject = new PersonProfileJSON.HoldingGenerator("field \"Object\" of the PersonQueriesAttributeNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ResultType\" of the PersonQueriesAttributeNugget class");
            set_what("the PersonQueriesAttributeNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAttribute = new PersonAttributeJSON.HoldingGenerator("field \"Attribute\" of the PersonQueriesAttributeNugget class", false);
            fieldGeneratorObject = new PersonProfileJSON.HoldingGenerator("field \"Object\" of the PersonQueriesAttributeNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ResultType\" of the PersonQueriesAttributeNugget class");
            set_what("the PersonQueriesAttributeNugget class");
          }

        public override void reset()
          {
            fieldGeneratorAttribute.reset();
            fieldGeneratorObject.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(PersonQueriesAttributeNuggetJSON  result)
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
        public PersonQueriesAttributeNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PersonQueriesAttributeNuggetJSON  result)
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
    protected virtual void handle_result(List<PersonQueriesAttributeNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PersonQueriesAttributeNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PersonQueriesAttributeNuggetJSON>();
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
    public List<PersonQueriesAttributeNuggetJSON> value;
  };
    class GenericPersonQueriesAttributeNuggetJSON : PersonQueriesAttributeNuggetJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericPersonQueriesAttributeNuggetJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getResultType()  { return key; }
        public override int extraPersonQueriesAttributeNuggetComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraPersonQueriesAttributeNuggetComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraPersonQueriesAttributeNuggetComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraPersonQueriesAttributeNuggetLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraPersonQueriesAttributeNuggetAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraPersonQueriesAttributeNuggetSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraPersonQueriesAttributeNuggetLookup(key);
            if (old_field == null)
              {
                extraPersonQueriesAttributeNuggetAppendPair(key, new_component);
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
    public static new PersonQueriesAttributeNuggetJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'A':
            if ((String.Compare(key, 1, "mount", 0, 5, false) == 0) && (key.Length == 6))
                return new PersonQueriesAmountNuggetJSON();
            break;
        case 'E':
            if ((String.Compare(key, 1, "mpty", 0, 4, false) == 0) && (key.Length == 5))
                return new PersonQueriesEmptyNuggetJSON();
            break;
        case 'L':
            if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                return new PersonQueriesLocationNuggetJSON();
            break;
        case 'P':
            if (String.Compare(key, 1, "erson", 0, 5, false) == 0)
              {
                if (key.Length == 6)
                  {
                    return new PersonQueriesPersonNuggetJSON();
                  }
                switch (key[6])
                  {
                    case 'A':
                        if ((String.Compare(key, 7, "rray", 0, 4, false) == 0) && (key.Length == 11))
                            return new PersonQueriesPersonArrayNuggetJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'S':
            if ((String.Compare(key, 1, "tring", 0, 5, false) == 0) && (key.Length == 6))
                return new PersonQueriesStringNuggetJSON();
            break;
        case 'W':
            if ((String.Compare(key, 1, "hen", 0, 3, false) == 0) && (key.Length == 4))
                return new PersonQueriesWhenNuggetJSON();
            break;
        default:
            break;
      }

        return new GenericPersonQueriesAttributeNuggetJSON(key);
      }
  };
