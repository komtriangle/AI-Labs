/* file "RetailProductSearchConfigurationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RetailProductSearchConfigurationJSON : JSONBase
  {
    private bool flagHasEnableKeywordOnlySearch;
    private bool storeEnableKeywordOnlySearch;
    private bool flagHasEnableRetailProductSearch;
    private bool storeEnableRetailProductSearch;
    private bool flagHasEnableExtendedPhrasing;
    private bool storeEnableExtendedPhrasing;
    private bool flagHasShowSearchTemplateHTML;
    private bool storeShowSearchTemplateHTML;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONEnableKeywordOnlySearch(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field EnableKeywordOnlySearch of RetailProductSearchConfigurationJSON is not true for false.");
              }
          }
        setEnableKeywordOnlySearch(the_bool);
      }


    private void  fromJSONEnableRetailProductSearch(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field EnableRetailProductSearch of RetailProductSearchConfigurationJSON is not true for false.");
              }
          }
        setEnableRetailProductSearch(the_bool);
      }


    private void  fromJSONEnableExtendedPhrasing(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field EnableExtendedPhrasing of RetailProductSearchConfigurationJSON is not true for false.");
              }
          }
        setEnableExtendedPhrasing(the_bool);
      }


    private void  fromJSONShowSearchTemplateHTML(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ShowSearchTemplateHTML of RetailProductSearchConfigurationJSON is not true for false.");
              }
          }
        setShowSearchTemplateHTML(the_bool);
      }


    public RetailProductSearchConfigurationJSON()
      {
        flagHasEnableKeywordOnlySearch = false;
        flagHasEnableRetailProductSearch = false;
        flagHasEnableExtendedPhrasing = false;
        flagHasShowSearchTemplateHTML = false;
        storeEnableKeywordOnlySearch = false;
        storeEnableRetailProductSearch = false;
        storeEnableExtendedPhrasing = false;
        storeShowSearchTemplateHTML = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasEnableKeywordOnlySearch()
      {
        return flagHasEnableKeywordOnlySearch;
      }

    public bool  getEnableKeywordOnlySearch()
      {
        return storeEnableKeywordOnlySearch;
      }

    public bool  hasEnableRetailProductSearch()
      {
        return flagHasEnableRetailProductSearch;
      }

    public bool  getEnableRetailProductSearch()
      {
        return storeEnableRetailProductSearch;
      }

    public bool  hasEnableExtendedPhrasing()
      {
        return flagHasEnableExtendedPhrasing;
      }

    public bool  getEnableExtendedPhrasing()
      {
        return storeEnableExtendedPhrasing;
      }

    public bool  hasShowSearchTemplateHTML()
      {
        return flagHasShowSearchTemplateHTML;
      }

    public bool  getShowSearchTemplateHTML()
      {
        return storeShowSearchTemplateHTML;
      }


    public virtual int extraRetailProductSearchConfigurationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRetailProductSearchConfigurationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRetailProductSearchConfigurationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRetailProductSearchConfigurationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setEnableKeywordOnlySearch(bool new_value)
      {
        flagHasEnableKeywordOnlySearch = true;
        storeEnableKeywordOnlySearch = new_value;
      }
    public void unsetEnableKeywordOnlySearch()
      {
        flagHasEnableKeywordOnlySearch = false;
      }
    public void setEnableRetailProductSearch(bool new_value)
      {
        flagHasEnableRetailProductSearch = true;
        storeEnableRetailProductSearch = new_value;
      }
    public void unsetEnableRetailProductSearch()
      {
        flagHasEnableRetailProductSearch = false;
      }
    public void setEnableExtendedPhrasing(bool new_value)
      {
        flagHasEnableExtendedPhrasing = true;
        storeEnableExtendedPhrasing = new_value;
      }
    public void unsetEnableExtendedPhrasing()
      {
        flagHasEnableExtendedPhrasing = false;
      }
    public void setShowSearchTemplateHTML(bool new_value)
      {
        flagHasShowSearchTemplateHTML = true;
        storeShowSearchTemplateHTML = new_value;
      }
    public void unsetShowSearchTemplateHTML()
      {
        flagHasShowSearchTemplateHTML = false;
      }

    public virtual void extraRetailProductSearchConfigurationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRetailProductSearchConfigurationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRetailProductSearchConfigurationLookup(key);
        if (old_field == null)
          {
            extraRetailProductSearchConfigurationAppendPair(key, new_component);
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
        if (flagHasEnableKeywordOnlySearch)
          {
            handler.start_pair("EnableKeywordOnlySearch");
            handler.boolean_value(storeEnableKeywordOnlySearch);
          }
        if (flagHasEnableRetailProductSearch)
          {
            handler.start_pair("EnableRetailProductSearch");
            handler.boolean_value(storeEnableRetailProductSearch);
          }
        if (flagHasEnableExtendedPhrasing)
          {
            handler.start_pair("EnableExtendedPhrasing");
            handler.boolean_value(storeEnableExtendedPhrasing);
          }
        if (flagHasShowSearchTemplateHTML)
          {
            handler.start_pair("ShowSearchTemplateHTML");
            handler.boolean_value(storeShowSearchTemplateHTML);
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
        return null;
      }

    public static RetailProductSearchConfigurationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RetailProductSearchConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailProductSearchConfiguration", ignore_extras);
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
    public static RetailProductSearchConfigurationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RetailProductSearchConfigurationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RetailProductSearchConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailProductSearchConfiguration", ignore_extras);
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
    public static RetailProductSearchConfigurationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RetailProductSearchConfigurationJSON from_text(string text, bool ignore_extras)
      {
        RetailProductSearchConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailProductSearchConfiguration", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RetailProductSearchConfigurationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RetailProductSearchConfigurationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RetailProductSearchConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailProductSearchConfiguration", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorEnableKeywordOnlySearch;
        private JSONHoldingBooleanGenerator fieldGeneratorEnableRetailProductSearch;
        private JSONHoldingBooleanGenerator fieldGeneratorEnableExtendedPhrasing;
        private JSONHoldingBooleanGenerator fieldGeneratorShowSearchTemplateHTML;
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
            RetailProductSearchConfigurationJSON result = new RetailProductSearchConfigurationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRetailProductSearchConfigurationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RetailProductSearchConfigurationJSON result)
          {
            if (fieldGeneratorEnableKeywordOnlySearch.have_value)
              {
                result.setEnableKeywordOnlySearch(fieldGeneratorEnableKeywordOnlySearch.value);
                fieldGeneratorEnableKeywordOnlySearch.have_value = false;
              }
            if (fieldGeneratorEnableRetailProductSearch.have_value)
              {
                result.setEnableRetailProductSearch(fieldGeneratorEnableRetailProductSearch.value);
                fieldGeneratorEnableRetailProductSearch.have_value = false;
              }
            if (fieldGeneratorEnableExtendedPhrasing.have_value)
              {
                result.setEnableExtendedPhrasing(fieldGeneratorEnableExtendedPhrasing.value);
                fieldGeneratorEnableExtendedPhrasing.have_value = false;
              }
            if (fieldGeneratorShowSearchTemplateHTML.have_value)
              {
                result.setShowSearchTemplateHTML(fieldGeneratorShowSearchTemplateHTML.value);
                fieldGeneratorShowSearchTemplateHTML.have_value = false;
              }
          }
        protected abstract void handle_result(RetailProductSearchConfigurationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if (String.Compare(field_name, 1, "nable", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 7, "xtendedPhrasing", 0, 15, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorEnableExtendedPhrasing;
                                break;
                            case 'K':
                                if ((String.Compare(field_name, 7, "eywordOnlySearch", 0, 16, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorEnableKeywordOnlySearch;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 7, "etailProductSearch", 0, 18, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorEnableRetailProductSearch;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "howSearchTemplateHTML", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorShowSearchTemplateHTML;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorEnableKeywordOnlySearch = new JSONHoldingBooleanGenerator("field \"EnableKeywordOnlySearch\" of the RetailProductSearchConfiguration class");
            fieldGeneratorEnableRetailProductSearch = new JSONHoldingBooleanGenerator("field \"EnableRetailProductSearch\" of the RetailProductSearchConfiguration class");
            fieldGeneratorEnableExtendedPhrasing = new JSONHoldingBooleanGenerator("field \"EnableExtendedPhrasing\" of the RetailProductSearchConfiguration class");
            fieldGeneratorShowSearchTemplateHTML = new JSONHoldingBooleanGenerator("field \"ShowSearchTemplateHTML\" of the RetailProductSearchConfiguration class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RetailProductSearchConfiguration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorEnableKeywordOnlySearch = new JSONHoldingBooleanGenerator("field \"EnableKeywordOnlySearch\" of the RetailProductSearchConfiguration class");
            fieldGeneratorEnableRetailProductSearch = new JSONHoldingBooleanGenerator("field \"EnableRetailProductSearch\" of the RetailProductSearchConfiguration class");
            fieldGeneratorEnableExtendedPhrasing = new JSONHoldingBooleanGenerator("field \"EnableExtendedPhrasing\" of the RetailProductSearchConfiguration class");
            fieldGeneratorShowSearchTemplateHTML = new JSONHoldingBooleanGenerator("field \"ShowSearchTemplateHTML\" of the RetailProductSearchConfiguration class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RetailProductSearchConfiguration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorEnableKeywordOnlySearch.reset();
            fieldGeneratorEnableRetailProductSearch.reset();
            fieldGeneratorEnableExtendedPhrasing.reset();
            fieldGeneratorShowSearchTemplateHTML.reset();
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
        protected override void handle_result(RetailProductSearchConfigurationJSON  result)
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
        public RetailProductSearchConfigurationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RetailProductSearchConfigurationJSON  result)
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
    protected virtual void handle_result(List<RetailProductSearchConfigurationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RetailProductSearchConfigurationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RetailProductSearchConfigurationJSON>();
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
    public List<RetailProductSearchConfigurationJSON> value;
  };
  };
