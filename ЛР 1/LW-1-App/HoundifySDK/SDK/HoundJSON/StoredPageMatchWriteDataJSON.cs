/* file "StoredPageMatchWriteDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StoredPageMatchWriteDataJSON : JSONBase
  {
    private bool flagHasPageName;
    private string storePageName;
    private bool flagHasPageIsGlobal;
    private bool storePageIsGlobal;
    private bool flagHasPageData;
    private ClientMatchesJSON  storePageData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPageName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PageName of StoredPageMatchWriteDataJSON is not a string.");
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
                throw new Exception("The value for field PageIsGlobal of StoredPageMatchWriteDataJSON is not true for false.");
              }
          }
        setPageIsGlobal(the_bool);
      }


    private void  fromJSONPageData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ClientMatchesJSON convert_classy = ClientMatchesJSON.from_json(json_value, ignore_extras, true);
        setPageData(convert_classy);
      }


    public StoredPageMatchWriteDataJSON()
      {
        flagHasPageName = false;
        flagHasPageIsGlobal = false;
        flagHasPageData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasPageData()
      {
        return flagHasPageData;
      }

    public ClientMatchesJSON   getPageData()
      {
        Debug.Assert(flagHasPageData);
        return storePageData;
      }


    public virtual int extraStoredPageMatchWriteDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStoredPageMatchWriteDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStoredPageMatchWriteDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStoredPageMatchWriteDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setPageData(ClientMatchesJSON  new_value)
      {
        if (flagHasPageData)
          {
          }
        flagHasPageData = true;
        storePageData = new_value;
      }
    public void unsetPageData()
      {
        if (flagHasPageData)
          {
          }
        flagHasPageData = false;
      }

    public virtual void extraStoredPageMatchWriteDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStoredPageMatchWriteDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStoredPageMatchWriteDataLookup(key);
        if (old_field == null)
          {
            extraStoredPageMatchWriteDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPageData);
        if (flagHasPageData)
          {
            handler.start_pair("PageData");
            if (partial_allowed)
                storePageData.write_partial_as_json(handler);
            else
                storePageData.write_as_json(handler);
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
        if (!(hasPageName()))
          {
            return "When parsing the object for %what%, the \"PageName\" field was missing.";
          }
        if (!(hasPageIsGlobal()))
          {
            return "When parsing the object for %what%, the \"PageIsGlobal\" field was missing.";
          }
        if (!(hasPageData()))
          {
            return "When parsing the object for %what%, the \"PageData\" field was missing.";
          }
        return null;
      }

    public static StoredPageMatchWriteDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StoredPageMatchWriteDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredPageMatchWriteData", ignore_extras);
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
    public static StoredPageMatchWriteDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StoredPageMatchWriteDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StoredPageMatchWriteDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredPageMatchWriteData", ignore_extras);
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
    public static StoredPageMatchWriteDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StoredPageMatchWriteDataJSON from_text(string text, bool ignore_extras)
      {
        StoredPageMatchWriteDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredPageMatchWriteData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StoredPageMatchWriteDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StoredPageMatchWriteDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StoredPageMatchWriteDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredPageMatchWriteData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorPageName;
        private JSONHoldingBooleanGenerator fieldGeneratorPageIsGlobal;
        private ClientMatchesJSON.HoldingGenerator fieldGeneratorPageData;
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
            StoredPageMatchWriteDataJSON result = new StoredPageMatchWriteDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStoredPageMatchWriteDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StoredPageMatchWriteDataJSON result)
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
            if (fieldGeneratorPageData.have_value)
              {
                result.setPageData(fieldGeneratorPageData.value);
                fieldGeneratorPageData.have_value = false;
              }
            else if ((!(result.hasPageData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PageData\" field was missing.");
              }
          }
        protected abstract void handle_result(StoredPageMatchWriteDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Page", 0, 4, false) == 0)
              {
                switch (field_name[4])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 5, "ata", 0, 3, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorPageData;
                        break;
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
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPageName = new JSONHoldingStringGenerator("field \"PageName\" of the StoredPageMatchWriteData class");
            fieldGeneratorPageIsGlobal = new JSONHoldingBooleanGenerator("field \"PageIsGlobal\" of the StoredPageMatchWriteData class");
            fieldGeneratorPageData = new ClientMatchesJSON.HoldingGenerator("field \"PageData\" of the StoredPageMatchWriteData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StoredPageMatchWriteData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPageName = new JSONHoldingStringGenerator("field \"PageName\" of the StoredPageMatchWriteData class");
            fieldGeneratorPageIsGlobal = new JSONHoldingBooleanGenerator("field \"PageIsGlobal\" of the StoredPageMatchWriteData class");
            fieldGeneratorPageData = new ClientMatchesJSON.HoldingGenerator("field \"PageData\" of the StoredPageMatchWriteData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StoredPageMatchWriteData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPageName.reset();
            fieldGeneratorPageIsGlobal.reset();
            fieldGeneratorPageData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPageData.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPageData.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StoredPageMatchWriteDataJSON  result)
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
        public StoredPageMatchWriteDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StoredPageMatchWriteDataJSON  result)
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
    protected virtual void handle_result(List<StoredPageMatchWriteDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StoredPageMatchWriteDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StoredPageMatchWriteDataJSON>();
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
    public List<StoredPageMatchWriteDataJSON> value;
  };
  };
