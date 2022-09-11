/* file "StoredAlwaysMatchReadCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StoredAlwaysMatchReadCommandJSON : StoredAlwaysMatchCommandJSON
  {
    private bool flagHasData;
    private ClientMatchesJSON  storeData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDataToJSON()
      {
        JSONValueHandler handler_Data = new JSONValueHandler();
        storeData.write_as_json(handler_Data);
        return handler_Data.result;
      }


    private void  fromJSONData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ClientMatchesJSON convert_classy = ClientMatchesJSON.from_json(json_value, ignore_extras, true);
        setData(convert_classy);
      }


    public StoredAlwaysMatchReadCommandJSON()
      {
        flagHasData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getStoredAlwaysMatchCommandKind()
      {
        return "Read";
      }

    public bool  hasData()
      {
        return flagHasData;
      }

    public ClientMatchesJSON   getData()
      {
        Debug.Assert(flagHasData);
        return storeData;
      }


    public virtual int extraStoredAlwaysMatchReadCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStoredAlwaysMatchReadCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStoredAlwaysMatchReadCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStoredAlwaysMatchReadCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraStoredAlwaysMatchCommandComponentCount()
      {
        int result = 0;
        if (flagHasData)
            ++result;
        result += extraStoredAlwaysMatchReadCommandComponentCount();
        return result;
      }
    public override string extraStoredAlwaysMatchCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasData)
          {
            if (remainder == 0)
                return "Data";
            --remainder;
          }
        return extraStoredAlwaysMatchReadCommandComponentKey(remainder);
      }
    public override JSONValue extraStoredAlwaysMatchCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasData)
          {
            if (remainder == 0)
                return extraDataToJSON();
            --remainder;
          }
        return extraStoredAlwaysMatchReadCommandComponentValue(remainder);
      }
    public override JSONValue extraStoredAlwaysMatchCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Data", 0, 4, false) == 0) && (field_name.Length == 4))
            return (flagHasData ? extraDataToJSON() : null);
        return extraStoredAlwaysMatchReadCommandLookup(field_name);
      }

    public void setData(ClientMatchesJSON  new_value)
      {
        if (flagHasData)
          {
          }
        flagHasData = true;
        storeData = new_value;
      }
    public void unsetData()
      {
        if (flagHasData)
          {
          }
        flagHasData = false;
      }

    public virtual void extraStoredAlwaysMatchReadCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStoredAlwaysMatchReadCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStoredAlwaysMatchReadCommandLookup(key);
        if (old_field == null)
          {
            extraStoredAlwaysMatchReadCommandAppendPair(key, new_component);
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
    public override void extraStoredAlwaysMatchCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Data", 0, 4, false) == 0) && (key.Length == 4))
            {
            fromJSONData(new_component, false);
            return;
            }
        extraStoredAlwaysMatchReadCommandAppendPair(key, new_component);
      }
    public override void extraStoredAlwaysMatchCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Data", 0, 4, false) == 0) && (key.Length == 4))
            {
            fromJSONData(new_component, false);
            return;
            }
        extraStoredAlwaysMatchReadCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasData);
        if (flagHasData)
          {
            handler.start_pair("Data");
            if (partial_allowed)
                storeData.write_partial_as_json(handler);
            else
                storeData.write_as_json(handler);
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
        if (!(hasData()))
          {
            return "When parsing the object for %what%, the \"Data\" field was missing.";
          }
        return null;
      }

    public static new StoredAlwaysMatchReadCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StoredAlwaysMatchReadCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredAlwaysMatchReadCommand", ignore_extras);
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
    public static new StoredAlwaysMatchReadCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StoredAlwaysMatchReadCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StoredAlwaysMatchReadCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredAlwaysMatchReadCommand", ignore_extras);
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
    public static new StoredAlwaysMatchReadCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StoredAlwaysMatchReadCommandJSON from_text(string text, bool ignore_extras)
      {
        StoredAlwaysMatchReadCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredAlwaysMatchReadCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StoredAlwaysMatchReadCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new StoredAlwaysMatchReadCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StoredAlwaysMatchReadCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredAlwaysMatchReadCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : StoredAlwaysMatchCommandJSON.Generator
      {
        private ClientMatchesJSON.HoldingGenerator fieldGeneratorData;
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
            if (!(getStoredAlwaysMatchCommandJSONKey().Equals("Read")))
                throw new Exception("The key field has a value other than `Read'.");
            StoredAlwaysMatchReadCommandJSON result = new StoredAlwaysMatchReadCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStoredAlwaysMatchReadCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(StoredAlwaysMatchCommandJSON new_result)
          {
            handle_result((StoredAlwaysMatchReadCommandJSON )new_result);
          }
        protected void finish(StoredAlwaysMatchReadCommandJSON result)
          {
            if (fieldGeneratorData.have_value)
              {
                result.setData(fieldGeneratorData.value);
                fieldGeneratorData.have_value = false;
              }
            else if ((!(result.hasData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Data\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(StoredAlwaysMatchReadCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Data", 0, 4, false) == 0) && (field_name.Length == 4))
                return fieldGeneratorData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorData = new ClientMatchesJSON.HoldingGenerator("field \"Data\" of the StoredAlwaysMatchReadCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StoredAlwaysMatchReadCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorData = new ClientMatchesJSON.HoldingGenerator("field \"Data\" of the StoredAlwaysMatchReadCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StoredAlwaysMatchReadCommand class");
          }

        public override void reset()
          {
            fieldGeneratorData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(StoredAlwaysMatchReadCommandJSON  result)
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
        public StoredAlwaysMatchReadCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StoredAlwaysMatchReadCommandJSON  result)
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
    protected virtual void handle_result(List<StoredAlwaysMatchReadCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StoredAlwaysMatchReadCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StoredAlwaysMatchReadCommandJSON>();
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
    public List<StoredAlwaysMatchReadCommandJSON> value;
  };
  };
