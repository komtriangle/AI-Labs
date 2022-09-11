/* file "RetailProductAttributeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class RetailProductAttributeJSON : JSONBase
  {
    private bool flagHasAttributeName;
    private string storeAttributeName;
    private bool flagHasAttributeKey;
    private string storeAttributeKey;
    private bool flagHasAttributeID;
    private RetailProductIDJSON  storeAttributeID;
    private bool flagHasAttributeValue;
    private string storeAttributeValue;
    private bool flagHasAttributeValueKey;
    private string storeAttributeValueKey;
    private bool flagHasAttributeValueID;
    private RetailProductIDJSON  storeAttributeValueID;


    private void  fromJSONAttributeName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AttributeName of RetailProductAttributeJSON is not a string.");
        setAttributeName(json_string.getData());
      }


    private void  fromJSONAttributeKey(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AttributeKey of RetailProductAttributeJSON is not a string.");
        setAttributeKey(json_string.getData());
      }


    private void  fromJSONAttributeID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RetailProductIDJSON convert_classy = RetailProductIDJSON.from_json(json_value, ignore_extras, true);
        setAttributeID(convert_classy);
      }


    private void  fromJSONAttributeValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AttributeValue of RetailProductAttributeJSON is not a string.");
        setAttributeValue(json_string.getData());
      }


    private void  fromJSONAttributeValueKey(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AttributeValueKey of RetailProductAttributeJSON is not a string.");
        setAttributeValueKey(json_string.getData());
      }


    private void  fromJSONAttributeValueID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RetailProductIDJSON convert_classy = RetailProductIDJSON.from_json(json_value, ignore_extras, true);
        setAttributeValueID(convert_classy);
      }


    public RetailProductAttributeJSON()
      {
        flagHasAttributeName = false;
        flagHasAttributeKey = false;
        flagHasAttributeID = false;
        flagHasAttributeValue = false;
        flagHasAttributeValueKey = false;
        flagHasAttributeValueID = false;
      }

    public abstract string getRetailProductAttributeType();
    public bool  hasAttributeName()
      {
        return flagHasAttributeName;
      }

    public string  getAttributeName()
      {
        Debug.Assert(flagHasAttributeName);
        return storeAttributeName;
      }

    public bool  hasAttributeKey()
      {
        return flagHasAttributeKey;
      }

    public string  getAttributeKey()
      {
        Debug.Assert(flagHasAttributeKey);
        return storeAttributeKey;
      }

    public bool  hasAttributeID()
      {
        return flagHasAttributeID;
      }

    public RetailProductIDJSON   getAttributeID()
      {
        Debug.Assert(flagHasAttributeID);
        return storeAttributeID;
      }

    public bool  hasAttributeValue()
      {
        return flagHasAttributeValue;
      }

    public string  getAttributeValue()
      {
        Debug.Assert(flagHasAttributeValue);
        return storeAttributeValue;
      }

    public bool  hasAttributeValueKey()
      {
        return flagHasAttributeValueKey;
      }

    public string  getAttributeValueKey()
      {
        Debug.Assert(flagHasAttributeValueKey);
        return storeAttributeValueKey;
      }

    public bool  hasAttributeValueID()
      {
        return flagHasAttributeValueID;
      }

    public RetailProductIDJSON   getAttributeValueID()
      {
        Debug.Assert(flagHasAttributeValueID);
        return storeAttributeValueID;
      }


    public abstract int extraRetailProductAttributeComponentCount();
    public abstract string extraRetailProductAttributeComponentKey(int component_num);
    public abstract JSONValue extraRetailProductAttributeComponentValue(int component_num);
    public abstract JSONValue extraRetailProductAttributeLookup(string field_name);

    public void setAttributeName(string new_value)
      {
        flagHasAttributeName = true;
        storeAttributeName = new_value;
      }
    public void unsetAttributeName()
      {
        flagHasAttributeName = false;
      }
    public void setAttributeKey(string new_value)
      {
        flagHasAttributeKey = true;
        storeAttributeKey = new_value;
      }
    public void unsetAttributeKey()
      {
        flagHasAttributeKey = false;
      }
    public void setAttributeID(RetailProductIDJSON  new_value)
      {
        if (flagHasAttributeID)
          {
          }
        flagHasAttributeID = true;
        storeAttributeID = new_value;
      }
    public void unsetAttributeID()
      {
        if (flagHasAttributeID)
          {
          }
        flagHasAttributeID = false;
      }
    public void setAttributeValue(string new_value)
      {
        flagHasAttributeValue = true;
        storeAttributeValue = new_value;
      }
    public void unsetAttributeValue()
      {
        flagHasAttributeValue = false;
      }
    public void setAttributeValueKey(string new_value)
      {
        flagHasAttributeValueKey = true;
        storeAttributeValueKey = new_value;
      }
    public void unsetAttributeValueKey()
      {
        flagHasAttributeValueKey = false;
      }
    public void setAttributeValueID(RetailProductIDJSON  new_value)
      {
        if (flagHasAttributeValueID)
          {
          }
        flagHasAttributeValueID = true;
        storeAttributeValueID = new_value;
      }
    public void unsetAttributeValueID()
      {
        if (flagHasAttributeValueID)
          {
          }
        flagHasAttributeValueID = false;
      }

    public abstract void extraRetailProductAttributeAppendPair(string key, JSONValue new_component);
    public abstract void extraRetailProductAttributeSetField(string key, JSONValue new_component);

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
        handler.pair("RetailProductAttributeType", getRetailProductAttributeType());
        if (flagHasAttributeName)
          {
            handler.start_pair("AttributeName");
            handler.string_value(storeAttributeName);
          }
        if (flagHasAttributeKey)
          {
            handler.start_pair("AttributeKey");
            handler.string_value(storeAttributeKey);
          }
        if (flagHasAttributeID)
          {
            handler.start_pair("AttributeID");
            if (partial_allowed)
                storeAttributeID.write_partial_as_json(handler);
            else
                storeAttributeID.write_as_json(handler);
          }
        if (flagHasAttributeValue)
          {
            handler.start_pair("AttributeValue");
            handler.string_value(storeAttributeValue);
          }
        if (flagHasAttributeValueKey)
          {
            handler.start_pair("AttributeValueKey");
            handler.string_value(storeAttributeValueKey);
          }
        if (flagHasAttributeValueID)
          {
            handler.start_pair("AttributeValueID");
            if (partial_allowed)
                storeAttributeValueID.write_partial_as_json(handler);
            else
                storeAttributeValueID.write_as_json(handler);
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
        return null;
      }

    public static RetailProductAttributeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RetailProductAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailProductAttribute", ignore_extras);
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
    public static RetailProductAttributeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RetailProductAttributeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RetailProductAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailProductAttribute", ignore_extras);
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
    public static RetailProductAttributeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RetailProductAttributeJSON from_text(string text, bool ignore_extras)
      {
        RetailProductAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailProductAttribute", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RetailProductAttributeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RetailProductAttributeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RetailProductAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailProductAttribute", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorAttributeName;
        private JSONHoldingStringGenerator fieldGeneratorAttributeKey;
        private RetailProductIDJSON.HoldingGenerator fieldGeneratorAttributeID;
        private JSONHoldingStringGenerator fieldGeneratorAttributeValue;
        private JSONHoldingStringGenerator fieldGeneratorAttributeValueKey;
        private RetailProductIDJSON.HoldingGenerator fieldGeneratorAttributeValueID;
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
                throw new Exception("The `RetailProductAttributeType' field is missing.");
            RetailProductAttributeJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRetailProductAttributeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getRetailProductAttributeJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `RetailProductAttributeType' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(RetailProductAttributeJSON result)
          {
            if (fieldGeneratorAttributeName.have_value)
              {
                result.setAttributeName(fieldGeneratorAttributeName.value);
                fieldGeneratorAttributeName.have_value = false;
              }
            if (fieldGeneratorAttributeKey.have_value)
              {
                result.setAttributeKey(fieldGeneratorAttributeKey.value);
                fieldGeneratorAttributeKey.have_value = false;
              }
            if (fieldGeneratorAttributeID.have_value)
              {
                result.setAttributeID(fieldGeneratorAttributeID.value);
                fieldGeneratorAttributeID.have_value = false;
              }
            if (fieldGeneratorAttributeValue.have_value)
              {
                result.setAttributeValue(fieldGeneratorAttributeValue.value);
                fieldGeneratorAttributeValue.have_value = false;
              }
            if (fieldGeneratorAttributeValueKey.have_value)
              {
                result.setAttributeValueKey(fieldGeneratorAttributeValueKey.value);
                fieldGeneratorAttributeValueKey.have_value = false;
              }
            if (fieldGeneratorAttributeValueID.have_value)
              {
                result.setAttributeValueID(fieldGeneratorAttributeValueID.value);
                fieldGeneratorAttributeValueID.have_value = false;
              }
          }
        protected abstract void handle_result(RetailProductAttributeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "ttribute", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 10, "D", 0, 1, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorAttributeID;
                                break;
                            case 'K':
                                if ((String.Compare(field_name, 10, "ey", 0, 2, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorAttributeKey;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 10, "ame", 0, 3, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorAttributeName;
                                break;
                            case 'V':
                                if (String.Compare(field_name, 10, "alue", 0, 4, false) == 0)
                                  {
                                    if (field_name.Length == 14)
                                      {
                                        return fieldGeneratorAttributeValue;
                                      }
                                    switch (field_name[14])
                                      {
                                        case 'I':
                                            if ((String.Compare(field_name, 15, "D", 0, 1, false) == 0) && (field_name.Length == 16))
                                                return fieldGeneratorAttributeValueID;
                                            break;
                                        case 'K':
                                            if ((String.Compare(field_name, 15, "ey", 0, 2, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratorAttributeValueKey;
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
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "etailProductAttributeType", 0, 25, false) == 0) && (field_name.Length == 26))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAttributeName = new JSONHoldingStringGenerator("field \"AttributeName\" of the RetailProductAttribute class");
            fieldGeneratorAttributeKey = new JSONHoldingStringGenerator("field \"AttributeKey\" of the RetailProductAttribute class");
            fieldGeneratorAttributeID = new RetailProductIDJSON.HoldingGenerator("field \"AttributeID\" of the RetailProductAttribute class", ignore_extras);
            fieldGeneratorAttributeValue = new JSONHoldingStringGenerator("field \"AttributeValue\" of the RetailProductAttribute class");
            fieldGeneratorAttributeValueKey = new JSONHoldingStringGenerator("field \"AttributeValueKey\" of the RetailProductAttribute class");
            fieldGeneratorAttributeValueID = new RetailProductIDJSON.HoldingGenerator("field \"AttributeValueID\" of the RetailProductAttribute class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"RetailProductAttributeType\" of the RetailProductAttribute class");
            set_what("the RetailProductAttribute class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAttributeName = new JSONHoldingStringGenerator("field \"AttributeName\" of the RetailProductAttribute class");
            fieldGeneratorAttributeKey = new JSONHoldingStringGenerator("field \"AttributeKey\" of the RetailProductAttribute class");
            fieldGeneratorAttributeID = new RetailProductIDJSON.HoldingGenerator("field \"AttributeID\" of the RetailProductAttribute class", false);
            fieldGeneratorAttributeValue = new JSONHoldingStringGenerator("field \"AttributeValue\" of the RetailProductAttribute class");
            fieldGeneratorAttributeValueKey = new JSONHoldingStringGenerator("field \"AttributeValueKey\" of the RetailProductAttribute class");
            fieldGeneratorAttributeValueID = new RetailProductIDJSON.HoldingGenerator("field \"AttributeValueID\" of the RetailProductAttribute class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"RetailProductAttributeType\" of the RetailProductAttribute class");
            set_what("the RetailProductAttribute class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorAttributeName.reset();
            fieldGeneratorAttributeKey.reset();
            fieldGeneratorAttributeID.reset();
            fieldGeneratorAttributeValue.reset();
            fieldGeneratorAttributeValueKey.reset();
            fieldGeneratorAttributeValueID.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAttributeID.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAttributeValueID.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAttributeID.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAttributeValueID.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RetailProductAttributeJSON  result)
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
        public RetailProductAttributeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RetailProductAttributeJSON  result)
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
    protected virtual void handle_result(List<RetailProductAttributeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RetailProductAttributeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RetailProductAttributeJSON>();
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
    public List<RetailProductAttributeJSON> value;
  };
    class GenericRetailProductAttributeJSON : RetailProductAttributeJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericRetailProductAttributeJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getRetailProductAttributeType()  { return key; }
        public override int extraRetailProductAttributeComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraRetailProductAttributeComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraRetailProductAttributeComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraRetailProductAttributeLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraRetailProductAttributeAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraRetailProductAttributeSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraRetailProductAttributeLookup(key);
            if (old_field == null)
              {
                extraRetailProductAttributeAppendPair(key, new_component);
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
    public static RetailProductAttributeJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {

        return new GenericRetailProductAttributeJSON(key);
      }
  };
