/* file "StoredPageMatchWriteCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StoredPageMatchWriteCommandJSON : StoredPageMatchCommandJSON
  {
    private bool flagHasPageName;
    private string storePageName;
    private bool flagHasPageIsGlobal;
    private bool storePageIsGlobal;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraPageNameToJSON()
      {
        JSONStringValue generated_string_PageName = new JSONStringValue(storePageName);
        return generated_string_PageName;
      }

    private JSONValue  extraPageIsGlobalToJSON()
      {
        JSONValue generated_boolean_PageIsGlobal = (storePageIsGlobal ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_PageIsGlobal;
      }


    private void  fromJSONPageName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PageName of StoredPageMatchWriteCommandJSON is not a string.");
        setPageName(json_string.getData());
      }


    private void  fromJSONPageIsGlobal(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PageIsGlobal of StoredPageMatchWriteCommandJSON is not true for false.");
              }
          }
        setPageIsGlobal(the_bool);
      }


    public StoredPageMatchWriteCommandJSON()
      {
        flagHasPageName = false;
        flagHasPageIsGlobal = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getStoredPageMatchCommandKind()
      {
        return "Write";
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

    public bool  hasPageIsGlobal()
      {
        return flagHasPageIsGlobal;
      }

    public bool  getPageIsGlobal()
      {
        Debug.Assert(flagHasPageIsGlobal);
        return storePageIsGlobal;
      }


    public virtual int extraStoredPageMatchWriteCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStoredPageMatchWriteCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStoredPageMatchWriteCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStoredPageMatchWriteCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraStoredPageMatchCommandComponentCount()
      {
        int result = 0;
        if (flagHasPageName)
            ++result;
        if (flagHasPageIsGlobal)
            ++result;
        result += extraStoredPageMatchWriteCommandComponentCount();
        return result;
      }
    public override string extraStoredPageMatchCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasPageName)
          {
            if (remainder == 0)
                return "PageName";
            --remainder;
          }
        if (flagHasPageIsGlobal)
          {
            if (remainder == 0)
                return "PageIsGlobal";
            --remainder;
          }
        return extraStoredPageMatchWriteCommandComponentKey(remainder);
      }
    public override JSONValue extraStoredPageMatchCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasPageName)
          {
            if (remainder == 0)
                return extraPageNameToJSON();
            --remainder;
          }
        if (flagHasPageIsGlobal)
          {
            if (remainder == 0)
                return extraPageIsGlobalToJSON();
            --remainder;
          }
        return extraStoredPageMatchWriteCommandComponentValue(remainder);
      }
    public override JSONValue extraStoredPageMatchCommandLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "Page", 0, 4, false) == 0)
          {
            switch (field_name[4])
              {
                case 'I':
                    if ((String.Compare(field_name, 5, "sGlobal", 0, 7, false) == 0) && (field_name.Length == 12))
                        return (flagHasPageIsGlobal ? extraPageIsGlobalToJSON() : null);
                    break;
                case 'N':
                    if ((String.Compare(field_name, 5, "ame", 0, 3, false) == 0) && (field_name.Length == 8))
                        return (flagHasPageName ? extraPageNameToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraStoredPageMatchWriteCommandLookup(field_name);
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
    public void setPageIsGlobal(bool new_value)
      {
        flagHasPageIsGlobal = true;
        storePageIsGlobal = new_value;
      }
    public void unsetPageIsGlobal()
      {
        flagHasPageIsGlobal = false;
      }

    public virtual void extraStoredPageMatchWriteCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStoredPageMatchWriteCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStoredPageMatchWriteCommandLookup(key);
        if (old_field == null)
          {
            extraStoredPageMatchWriteCommandAppendPair(key, new_component);
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
    public override void extraStoredPageMatchCommandAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Page", 0, 4, false) == 0)
          {
            switch (key[4])
              {
                case 'I':
                    if ((String.Compare(key, 5, "sGlobal", 0, 7, false) == 0) && (key.Length == 12))
                        {
                        fromJSONPageIsGlobal(new_component, false);
                        return;
                        }
                    break;
                case 'N':
                    if ((String.Compare(key, 5, "ame", 0, 3, false) == 0) && (key.Length == 8))
                        {
                        fromJSONPageName(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraStoredPageMatchWriteCommandAppendPair(key, new_component);
      }
    public override void extraStoredPageMatchCommandSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Page", 0, 4, false) == 0)
          {
            switch (key[4])
              {
                case 'I':
                    if ((String.Compare(key, 5, "sGlobal", 0, 7, false) == 0) && (key.Length == 12))
                        {
                        fromJSONPageIsGlobal(new_component, false);
                        return;
                        }
                    break;
                case 'N':
                    if ((String.Compare(key, 5, "ame", 0, 3, false) == 0) && (key.Length == 8))
                        {
                        fromJSONPageName(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraStoredPageMatchWriteCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPageName);
        if (flagHasPageName)
          {
            handler.start_pair("PageName");
            handler.string_value(storePageName);
          }
        Debug.Assert(partial_allowed || flagHasPageIsGlobal);
        if (flagHasPageIsGlobal)
          {
            handler.start_pair("PageIsGlobal");
            handler.boolean_value(storePageIsGlobal);
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
        if (!(hasPageName()))
          {
            return "When parsing the object for %what%, the \"PageName\" field was missing.";
          }
        if (!(hasPageIsGlobal()))
          {
            return "When parsing the object for %what%, the \"PageIsGlobal\" field was missing.";
          }
        return null;
      }

    public static new StoredPageMatchWriteCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StoredPageMatchWriteCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredPageMatchWriteCommand", ignore_extras);
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
    public static new StoredPageMatchWriteCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StoredPageMatchWriteCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StoredPageMatchWriteCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredPageMatchWriteCommand", ignore_extras);
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
    public static new StoredPageMatchWriteCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StoredPageMatchWriteCommandJSON from_text(string text, bool ignore_extras)
      {
        StoredPageMatchWriteCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredPageMatchWriteCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StoredPageMatchWriteCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new StoredPageMatchWriteCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StoredPageMatchWriteCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredPageMatchWriteCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : StoredPageMatchCommandJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorPageName;
        private JSONHoldingBooleanGenerator fieldGeneratorPageIsGlobal;
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
            if (!(getStoredPageMatchCommandJSONKey().Equals("Write")))
                throw new Exception("The key field has a value other than `Write'.");
            StoredPageMatchWriteCommandJSON result = new StoredPageMatchWriteCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStoredPageMatchWriteCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(StoredPageMatchCommandJSON new_result)
          {
            handle_result((StoredPageMatchWriteCommandJSON )new_result);
          }
        protected void finish(StoredPageMatchWriteCommandJSON result)
          {
            if (fieldGeneratorPageName.have_value)
              {
                result.setPageName(fieldGeneratorPageName.value);
                fieldGeneratorPageName.have_value = false;
              }
            else if ((!(result.hasPageName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PageName\" field was missing.");
              }
            if (fieldGeneratorPageIsGlobal.have_value)
              {
                result.setPageIsGlobal(fieldGeneratorPageIsGlobal.value);
                fieldGeneratorPageIsGlobal.have_value = false;
              }
            else if ((!(result.hasPageIsGlobal())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PageIsGlobal\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(StoredPageMatchWriteCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Page", 0, 4, false) == 0)
              {
                switch (field_name[4])
                  {
                    case 'I':
                        if ((String.Compare(field_name, 5, "sGlobal", 0, 7, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorPageIsGlobal;
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 5, "ame", 0, 3, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorPageName;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorPageName = new JSONHoldingStringGenerator("field \"PageName\" of the StoredPageMatchWriteCommand class");
            fieldGeneratorPageIsGlobal = new JSONHoldingBooleanGenerator("field \"PageIsGlobal\" of the StoredPageMatchWriteCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StoredPageMatchWriteCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorPageName = new JSONHoldingStringGenerator("field \"PageName\" of the StoredPageMatchWriteCommand class");
            fieldGeneratorPageIsGlobal = new JSONHoldingBooleanGenerator("field \"PageIsGlobal\" of the StoredPageMatchWriteCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StoredPageMatchWriteCommand class");
          }

        public override void reset()
          {
            fieldGeneratorPageName.reset();
            fieldGeneratorPageIsGlobal.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(StoredPageMatchWriteCommandJSON  result)
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
        public StoredPageMatchWriteCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StoredPageMatchWriteCommandJSON  result)
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
    protected virtual void handle_result(List<StoredPageMatchWriteCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StoredPageMatchWriteCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StoredPageMatchWriteCommandJSON>();
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
    public List<StoredPageMatchWriteCommandJSON> value;
  };
  };
