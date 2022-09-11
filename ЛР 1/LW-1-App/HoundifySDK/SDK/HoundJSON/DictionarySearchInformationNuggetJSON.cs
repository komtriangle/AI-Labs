/* file "DictionarySearchInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DictionarySearchInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasSearchFilters;
    private List< DictionarySearchFiltersJSON  > storeSearchFilters;
    private bool flagHasDictionaryEntries;
    private List< DictionaryEntryJSON  > storeDictionaryEntries;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSearchFiltersToJSON()
      {
        JSONArrayValue generated_array_1_SearchFilters = new JSONArrayValue();
        for (int num1 = 0; num1 < storeSearchFilters.Count; ++num1)
          {
            JSONValueHandler handler_SearchFilters = new JSONValueHandler();
            storeSearchFilters[num1].write_as_json(handler_SearchFilters);
            generated_array_1_SearchFilters.appendComponent(handler_SearchFilters.result);
          }
        return generated_array_1_SearchFilters;
      }

    private JSONValue  extraDictionaryEntriesToJSON()
      {
        JSONArrayValue generated_array_2_DictionaryEntries = new JSONArrayValue();
        for (int num2 = 0; num2 < storeDictionaryEntries.Count; ++num2)
          {
            JSONValueHandler handler_DictionaryEntries = new JSONValueHandler();
            storeDictionaryEntries[num2].write_as_json(handler_DictionaryEntries);
            generated_array_2_DictionaryEntries.appendComponent(handler_DictionaryEntries.result);
          }
        return generated_array_2_DictionaryEntries;
      }


    private void  fromJSONSearchFilters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SearchFilters of DictionarySearchInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DictionarySearchFiltersJSON  > vector_SearchFilters1 = new List< DictionarySearchFiltersJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DictionarySearchFiltersJSON convert_classy = DictionarySearchFiltersJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_SearchFilters1.Add(convert_classy);
          }
        initSearchFilters();
        for (int num1 = 0; num1 < vector_SearchFilters1.Count; ++num1)
            appendSearchFilters(vector_SearchFilters1[num1]);
        for (int num1 = 0; num1 < vector_SearchFilters1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDictionaryEntries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DictionaryEntries of DictionarySearchInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DictionaryEntryJSON  > vector_DictionaryEntries1 = new List< DictionaryEntryJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DictionaryEntryJSON convert_classy = DictionaryEntryJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_DictionaryEntries1.Add(convert_classy);
          }
        initDictionaryEntries();
        for (int num2 = 0; num2 < vector_DictionaryEntries1.Count; ++num2)
            appendDictionaryEntries(vector_DictionaryEntries1[num2]);
        for (int num1 = 0; num1 < vector_DictionaryEntries1.Count; ++num1)
          {
          }
      }


    public DictionarySearchInformationNuggetJSON()
      {
        flagHasSearchFilters = false;
        flagHasDictionaryEntries = false;
        storeSearchFilters = new List< DictionarySearchFiltersJSON  >();
        storeDictionaryEntries = new List< DictionaryEntryJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "DictionarySearch";
      }

    public bool  hasSearchFilters()
      {
        return flagHasSearchFilters;
      }

    public int  countOfSearchFilters()
      {
        Debug.Assert(flagHasSearchFilters);
        return storeSearchFilters.Count;
      }

    public DictionarySearchFiltersJSON   elementOfSearchFilters(int element_num)
      {
        Debug.Assert(flagHasSearchFilters);
        return storeSearchFilters[element_num];
      }

    public List< DictionarySearchFiltersJSON  >  getSearchFilters()
      {
        Debug.Assert(flagHasSearchFilters);
        return storeSearchFilters;
      }

    public bool  hasDictionaryEntries()
      {
        return flagHasDictionaryEntries;
      }

    public int  countOfDictionaryEntries()
      {
        Debug.Assert(flagHasDictionaryEntries);
        return storeDictionaryEntries.Count;
      }

    public DictionaryEntryJSON   elementOfDictionaryEntries(int element_num)
      {
        Debug.Assert(flagHasDictionaryEntries);
        return storeDictionaryEntries[element_num];
      }

    public List< DictionaryEntryJSON  >  getDictionaryEntries()
      {
        Debug.Assert(flagHasDictionaryEntries);
        return storeDictionaryEntries;
      }


    public virtual int extraDictionarySearchInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDictionarySearchInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDictionarySearchInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDictionarySearchInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasSearchFilters)
            ++result;
        if (flagHasDictionaryEntries)
            ++result;
        result += extraDictionarySearchInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSearchFilters)
          {
            if (remainder == 0)
                return "SearchFilters";
            --remainder;
          }
        if (flagHasDictionaryEntries)
          {
            if (remainder == 0)
                return "DictionaryEntries";
            --remainder;
          }
        return extraDictionarySearchInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSearchFilters)
          {
            if (remainder == 0)
                return extraSearchFiltersToJSON();
            --remainder;
          }
        if (flagHasDictionaryEntries)
          {
            if (remainder == 0)
                return extraDictionaryEntriesToJSON();
            --remainder;
          }
        return extraDictionarySearchInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "ictionaryEntries", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasDictionaryEntries ? extraDictionaryEntriesToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "earchFilters", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasSearchFilters ? extraSearchFiltersToJSON() : null);
                break;
            default:
                break;
          }
        return extraDictionarySearchInformationNuggetLookup(field_name);
      }

    public void initSearchFilters()
      {
        if (flagHasSearchFilters)
          {
            for (int num1 = 0; num1 < storeSearchFilters.Count; ++num1)
              {
              }
          }
        flagHasSearchFilters = true;
        storeSearchFilters.Clear();
      }
    public void appendSearchFilters(DictionarySearchFiltersJSON  to_append)
      {
        if (!flagHasSearchFilters)
          {
            flagHasSearchFilters = true;
            storeSearchFilters.Clear();
          }
        Debug.Assert(flagHasSearchFilters);
        storeSearchFilters.Add(to_append);
      }
    public void unsetSearchFilters()
      {
        if (flagHasSearchFilters)
          {
            for (int num2 = 0; num2 < storeSearchFilters.Count; ++num2)
              {
              }
          }
        flagHasSearchFilters = false;
        storeSearchFilters.Clear();
      }
    public void initDictionaryEntries()
      {
        if (flagHasDictionaryEntries)
          {
            for (int num3 = 0; num3 < storeDictionaryEntries.Count; ++num3)
              {
              }
          }
        flagHasDictionaryEntries = true;
        storeDictionaryEntries.Clear();
      }
    public void appendDictionaryEntries(DictionaryEntryJSON  to_append)
      {
        if (!flagHasDictionaryEntries)
          {
            flagHasDictionaryEntries = true;
            storeDictionaryEntries.Clear();
          }
        Debug.Assert(flagHasDictionaryEntries);
        storeDictionaryEntries.Add(to_append);
      }
    public void unsetDictionaryEntries()
      {
        if (flagHasDictionaryEntries)
          {
            for (int num4 = 0; num4 < storeDictionaryEntries.Count; ++num4)
              {
              }
          }
        flagHasDictionaryEntries = false;
        storeDictionaryEntries.Clear();
      }

    public virtual void extraDictionarySearchInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDictionarySearchInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDictionarySearchInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraDictionarySearchInformationNuggetAppendPair(key, new_component);
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
            case 'D':
                if ((String.Compare(key, 1, "ictionaryEntries", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONDictionaryEntries(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "earchFilters", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONSearchFilters(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDictionarySearchInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "ictionaryEntries", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONDictionaryEntries(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "earchFilters", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONSearchFilters(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDictionarySearchInformationNuggetSetField(key, new_component);
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
        if (flagHasSearchFilters)
          {
            handler.start_pair("SearchFilters");
            handler.start_array();
            for (int num1 = 0; num1 < storeSearchFilters.Count; ++num1)
              {
                if (partial_allowed)
                    storeSearchFilters[num1].write_partial_as_json(handler);
                else
                    storeSearchFilters[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDictionaryEntries)
          {
            handler.start_pair("DictionaryEntries");
            handler.start_array();
            for (int num2 = 0; num2 < storeDictionaryEntries.Count; ++num2)
              {
                if (partial_allowed)
                    storeDictionaryEntries[num2].write_partial_as_json(handler);
                else
                    storeDictionaryEntries[num2].write_as_json(handler);
              }
            handler.finish_array();
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

    public static new DictionarySearchInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DictionarySearchInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionarySearchInformationNugget", ignore_extras);
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
    public static new DictionarySearchInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DictionarySearchInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DictionarySearchInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionarySearchInformationNugget", ignore_extras);
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
    public static new DictionarySearchInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DictionarySearchInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        DictionarySearchInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionarySearchInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DictionarySearchInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DictionarySearchInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DictionarySearchInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionarySearchInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private DictionarySearchFiltersJSON.HoldingArrayGenerator fieldGeneratorSearchFilters;
        private DictionaryEntryJSON.HoldingArrayGenerator fieldGeneratorDictionaryEntries;
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
            if (!(getInformationNuggetJSONKey().Equals("DictionarySearch")))
                throw new Exception("The key field has a value other than `DictionarySearch'.");
            DictionarySearchInformationNuggetJSON result = new DictionarySearchInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDictionarySearchInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((DictionarySearchInformationNuggetJSON )new_result);
          }
        protected void finish(DictionarySearchInformationNuggetJSON result)
          {
            if (fieldGeneratorSearchFilters.have_value)
              {
                result.initSearchFilters();
                int count = fieldGeneratorSearchFilters.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSearchFilters(fieldGeneratorSearchFilters.value[num]);
                  }
                fieldGeneratorSearchFilters.value.Clear();
                fieldGeneratorSearchFilters.have_value = false;
              }
            if (fieldGeneratorDictionaryEntries.have_value)
              {
                result.initDictionaryEntries();
                int count = fieldGeneratorDictionaryEntries.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDictionaryEntries(fieldGeneratorDictionaryEntries.value[num]);
                  }
                fieldGeneratorDictionaryEntries.value.Clear();
                fieldGeneratorDictionaryEntries.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(DictionarySearchInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ictionaryEntries", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorDictionaryEntries;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "earchFilters", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorSearchFilters;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSearchFilters = new DictionarySearchFiltersJSON.HoldingArrayGenerator("field \"SearchFilters\" of the DictionarySearchInformationNugget class", ignore_extras);
            fieldGeneratorDictionaryEntries = new DictionaryEntryJSON.HoldingArrayGenerator("field \"DictionaryEntries\" of the DictionarySearchInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DictionarySearchInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSearchFilters = new DictionarySearchFiltersJSON.HoldingArrayGenerator("field \"SearchFilters\" of the DictionarySearchInformationNugget class", false);
            fieldGeneratorDictionaryEntries = new DictionaryEntryJSON.HoldingArrayGenerator("field \"DictionaryEntries\" of the DictionarySearchInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DictionarySearchInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorSearchFilters.reset();
            fieldGeneratorDictionaryEntries.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DictionarySearchInformationNuggetJSON  result)
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
        public DictionarySearchInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DictionarySearchInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<DictionarySearchInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DictionarySearchInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DictionarySearchInformationNuggetJSON>();
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
    public List<DictionarySearchInformationNuggetJSON> value;
  };
  };
