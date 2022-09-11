/* file "ClientMatchInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ClientMatchInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasResult;
    private JSONValue  storeResult;
    private bool flagHasMatchedItem;
    private ClientMatchJSON  storeMatchedItem;
    private bool flagHasPageName;
    private string storePageName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraResultToJSON()
      {
        return storeResult;
      }

    private JSONValue  extraMatchedItemToJSON()
      {
        JSONValueHandler handler_MatchedItem = new JSONValueHandler();
        storeMatchedItem.write_as_json(handler_MatchedItem);
        return handler_MatchedItem.result;
      }

    private JSONValue  extraPageNameToJSON()
      {
        JSONStringValue generated_string_PageName = new JSONStringValue(storePageName);
        return generated_string_PageName;
      }


    private void  fromJSONResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        setResult(json_value);
      }


    private void  fromJSONMatchedItem(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ClientMatchJSON convert_classy = ClientMatchJSON.from_json(json_value, ignore_extras, true);
        setMatchedItem(convert_classy);
      }


    private void  fromJSONPageName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PageName of ClientMatchInformationNuggetJSON is not a string.");
        setPageName(json_string.getData());
      }


    public ClientMatchInformationNuggetJSON()
      {
        flagHasResult = false;
        flagHasMatchedItem = false;
        flagHasPageName = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "ClientMatch";
      }

    public bool  hasResult()
      {
        return flagHasResult;
      }

    public JSONValue   getResult()
      {
        Debug.Assert(flagHasResult);
        return storeResult;
      }

    public bool  hasMatchedItem()
      {
        return flagHasMatchedItem;
      }

    public ClientMatchJSON   getMatchedItem()
      {
        Debug.Assert(flagHasMatchedItem);
        return storeMatchedItem;
      }

    public bool  hasPageName()
      {
        return flagHasPageName;
      }

    public string  getPageName()
      {
        Debug.Assert(flagHasPageName);
        return storePageName;
      }


    public virtual int extraClientMatchInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraClientMatchInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraClientMatchInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraClientMatchInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasResult)
            ++result;
        if (flagHasMatchedItem)
            ++result;
        if (flagHasPageName)
            ++result;
        result += extraClientMatchInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasResult)
          {
            if (remainder == 0)
                return "Result";
            --remainder;
          }
        if (flagHasMatchedItem)
          {
            if (remainder == 0)
                return "MatchedItem";
            --remainder;
          }
        if (flagHasPageName)
          {
            if (remainder == 0)
                return "PageName";
            --remainder;
          }
        return extraClientMatchInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasResult)
          {
            if (remainder == 0)
                return extraResultToJSON();
            --remainder;
          }
        if (flagHasMatchedItem)
          {
            if (remainder == 0)
                return extraMatchedItemToJSON();
            --remainder;
          }
        if (flagHasPageName)
          {
            if (remainder == 0)
                return extraPageNameToJSON();
            --remainder;
          }
        return extraClientMatchInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'M':
                if ((String.Compare(field_name, 1, "atchedItem", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasMatchedItem ? extraMatchedItemToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "ageName", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasPageName ? extraPageNameToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "esult", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasResult ? extraResultToJSON() : null);
                break;
            default:
                break;
          }
        return extraClientMatchInformationNuggetLookup(field_name);
      }

    public void setResult(JSONValue  new_value)
      {
        if (flagHasResult)
          {
          }
        flagHasResult = true;
        storeResult = new_value;
      }
    public void unsetResult()
      {
        if (flagHasResult)
          {
          }
        flagHasResult = false;
      }
    public void setMatchedItem(ClientMatchJSON  new_value)
      {
        if (flagHasMatchedItem)
          {
          }
        flagHasMatchedItem = true;
        storeMatchedItem = new_value;
      }
    public void unsetMatchedItem()
      {
        if (flagHasMatchedItem)
          {
          }
        flagHasMatchedItem = false;
      }
    public void setPageName(string new_value)
      {
        flagHasPageName = true;
        storePageName = new_value;
      }
    public void unsetPageName()
      {
        flagHasPageName = false;
      }

    public virtual void extraClientMatchInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraClientMatchInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraClientMatchInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraClientMatchInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'M':
                if ((String.Compare(key, 1, "atchedItem", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONMatchedItem(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "ageName", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONPageName(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esult", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONResult(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraClientMatchInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'M':
                if ((String.Compare(key, 1, "atchedItem", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONMatchedItem(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "ageName", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONPageName(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esult", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONResult(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraClientMatchInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasResult);
        if (flagHasResult)
          {
            handler.start_pair("Result");
            storeResult.write(handler);
          }
        if (flagHasMatchedItem)
          {
            handler.start_pair("MatchedItem");
            if (partial_allowed)
                storeMatchedItem.write_partial_as_json(handler);
            else
                storeMatchedItem.write_as_json(handler);
          }
        if (flagHasPageName)
          {
            handler.start_pair("PageName");
            handler.string_value(storePageName);
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
        if (!(hasResult()))
          {
            return "When parsing the object for %what%, the \"Result\" field was missing.";
          }
        return null;
      }

    public static new ClientMatchInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ClientMatchInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientMatchInformationNugget", ignore_extras);
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
    public static new ClientMatchInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ClientMatchInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ClientMatchInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientMatchInformationNugget", ignore_extras);
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
    public static new ClientMatchInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ClientMatchInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ClientMatchInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientMatchInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ClientMatchInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ClientMatchInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ClientMatchInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientMatchInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private JSONHoldingValueGenerator fieldGeneratorResult;
        private ClientMatchJSON.HoldingGenerator fieldGeneratorMatchedItem;
        private JSONHoldingStringGenerator fieldGeneratorPageName;
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
            if (!(getInformationNuggetJSONKey().Equals("ClientMatch")))
                throw new Exception("The key field has a value other than `ClientMatch'.");
            ClientMatchInformationNuggetJSON result = new ClientMatchInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraClientMatchInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((ClientMatchInformationNuggetJSON )new_result);
          }
        protected void finish(ClientMatchInformationNuggetJSON result)
          {
            if (fieldGeneratorResult.have_value)
              {
                result.setResult(fieldGeneratorResult.value);
                fieldGeneratorResult.have_value = false;
              }
            else if ((!(result.hasResult())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Result\" field was missing.");
              }
            if (fieldGeneratorMatchedItem.have_value)
              {
                result.setMatchedItem(fieldGeneratorMatchedItem.value);
                fieldGeneratorMatchedItem.have_value = false;
              }
            if (fieldGeneratorPageName.have_value)
              {
                result.setPageName(fieldGeneratorPageName.value);
                fieldGeneratorPageName.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ClientMatchInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'M':
                    if ((String.Compare(field_name, 1, "atchedItem", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMatchedItem;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ageName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorPageName;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "esult", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorResult;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorResult = new JSONHoldingValueGenerator("field \"Result\" of the ClientMatchInformationNugget class");
            fieldGeneratorMatchedItem = new ClientMatchJSON.HoldingGenerator("field \"MatchedItem\" of the ClientMatchInformationNugget class", ignore_extras);
            fieldGeneratorPageName = new JSONHoldingStringGenerator("field \"PageName\" of the ClientMatchInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ClientMatchInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorResult = new JSONHoldingValueGenerator("field \"Result\" of the ClientMatchInformationNugget class");
            fieldGeneratorMatchedItem = new ClientMatchJSON.HoldingGenerator("field \"MatchedItem\" of the ClientMatchInformationNugget class", false);
            fieldGeneratorPageName = new JSONHoldingStringGenerator("field \"PageName\" of the ClientMatchInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ClientMatchInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorResult.reset();
            fieldGeneratorMatchedItem.reset();
            fieldGeneratorPageName.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ClientMatchInformationNuggetJSON  result)
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
        public ClientMatchInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ClientMatchInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ClientMatchInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ClientMatchInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ClientMatchInformationNuggetJSON>();
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
    public List<ClientMatchInformationNuggetJSON> value;
  };
  };
