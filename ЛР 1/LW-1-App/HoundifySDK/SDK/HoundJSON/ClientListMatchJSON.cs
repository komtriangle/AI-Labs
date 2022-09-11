/* file "ClientListMatchJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ClientListMatchJSON : ClientMatchJSON
  {
    private bool flagHasListExpression;
    private string storeListExpression;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraListExpressionToJSON()
      {
        JSONStringValue generated_string_ListExpression = new JSONStringValue(storeListExpression);
        return generated_string_ListExpression;
      }


    private void  fromJSONListExpression(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ListExpression of ClientListMatchJSON is not a string.");
        setListExpression(json_string.getData());
      }


    public ClientListMatchJSON()
      {
        flagHasListExpression = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasListExpression()
      {
        return flagHasListExpression;
      }

    public string  getListExpression()
      {
        Debug.Assert(flagHasListExpression);
        return storeListExpression;
      }


    public virtual int extraClientListMatchComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraClientListMatchComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraClientListMatchComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraClientListMatchLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraClientMatchComponentCount()
      {
        int result = 0;
        if (flagHasListExpression)
            ++result;
        result += extraClientListMatchComponentCount();
        return result;
      }
    public override string extraClientMatchComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasListExpression)
          {
            if (remainder == 0)
                return "ListExpression";
            --remainder;
          }
        return extraClientListMatchComponentKey(remainder);
      }
    public override JSONValue extraClientMatchComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasListExpression)
          {
            if (remainder == 0)
                return extraListExpressionToJSON();
            --remainder;
          }
        return extraClientListMatchComponentValue(remainder);
      }
    public override JSONValue extraClientMatchLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "ListExpression", 0, 14, false) == 0) && (field_name.Length == 14))
            return (flagHasListExpression ? extraListExpressionToJSON() : null);
        return extraClientListMatchLookup(field_name);
      }

    public void setListExpression(string new_value)
      {
        flagHasListExpression = true;
        storeListExpression = new_value;
      }
    public void unsetListExpression()
      {
        flagHasListExpression = false;
      }

    public virtual void extraClientListMatchAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraClientListMatchSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraClientListMatchLookup(key);
        if (old_field == null)
          {
            extraClientListMatchAppendPair(key, new_component);
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
    public override void extraClientMatchAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "ListExpression", 0, 14, false) == 0) && (key.Length == 14))
            {
            fromJSONListExpression(new_component, false);
            return;
            }
        extraClientListMatchAppendPair(key, new_component);
      }
    public override void extraClientMatchSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "ListExpression", 0, 14, false) == 0) && (key.Length == 14))
            {
            fromJSONListExpression(new_component, false);
            return;
            }
        extraClientListMatchSetField(key, new_component);
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
        if (flagHasListExpression)
          {
            handler.start_pair("ListExpression");
            handler.string_value(storeListExpression);
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
        return null;
      }

    public static new ClientListMatchJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ClientListMatchJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientListMatch", ignore_extras);
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
    public static new ClientListMatchJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ClientListMatchJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ClientListMatchJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientListMatch", ignore_extras);
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
    public static new ClientListMatchJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ClientListMatchJSON from_text(string text, bool ignore_extras)
      {
        ClientListMatchJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientListMatch", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ClientListMatchJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ClientListMatchJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ClientListMatchJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientListMatch", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ClientMatchJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorListExpression;
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
            ClientListMatchJSON result = new ClientListMatchJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraClientListMatchAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ClientMatchJSON new_result)
          {
            handle_result((ClientListMatchJSON )new_result);
          }
        protected void finish(ClientListMatchJSON result)
          {
            if (fieldGeneratorListExpression.have_value)
              {
                result.setListExpression(fieldGeneratorListExpression.value);
                fieldGeneratorListExpression.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ClientListMatchJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "ListExpression", 0, 14, false) == 0) && (field_name.Length == 14))
                return fieldGeneratorListExpression;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorListExpression = new JSONHoldingStringGenerator("field \"ListExpression\" of the ClientListMatch class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ClientListMatch class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorListExpression = new JSONHoldingStringGenerator("field \"ListExpression\" of the ClientListMatch class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ClientListMatch class");
          }

        public override void reset()
          {
            fieldGeneratorListExpression.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ClientListMatchJSON  result)
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
        public ClientListMatchJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ClientListMatchJSON  result)
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
    protected virtual void handle_result(List<ClientListMatchJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ClientListMatchJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ClientListMatchJSON>();
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
    public List<ClientListMatchJSON> value;
  };
    public static ClientListMatchJSON from_ClientMatchJSON_json(ClientMatchJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        ClientListMatchJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type ClientListMatch", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
