/* file "RestaurantOrderingMenuDataMenuJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RestaurantOrderingMenuDataMenuJSON : RestaurantOrderingMenuDataEntityJSON
  {
    private bool flagHasSectionIDs;
    private List< string > storeSectionIDs;
    private bool flagHasAdditionalMenuItemIDs;
    private List< string > storeAdditionalMenuItemIDs;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSectionIDsToJSON()
      {
        JSONArrayValue generated_array_1_SectionIDs = new JSONArrayValue();
        for (int num1 = 0; num1 < storeSectionIDs.Count; ++num1)
          {
            JSONStringValue generated_string_SectionIDs = new JSONStringValue(storeSectionIDs[num1]);
            generated_array_1_SectionIDs.appendComponent(generated_string_SectionIDs);
          }
        return generated_array_1_SectionIDs;
      }

    private JSONValue  extraAdditionalMenuItemIDsToJSON()
      {
        JSONArrayValue generated_array_2_AdditionalMenuItemIDs = new JSONArrayValue();
        for (int num2 = 0; num2 < storeAdditionalMenuItemIDs.Count; ++num2)
          {
            JSONStringValue generated_string_AdditionalMenuItemIDs = new JSONStringValue(storeAdditionalMenuItemIDs[num2]);
            generated_array_2_AdditionalMenuItemIDs.appendComponent(generated_string_AdditionalMenuItemIDs);
          }
        return generated_array_2_AdditionalMenuItemIDs;
      }


    private void  fromJSONSectionIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SectionIDs of RestaurantOrderingMenuDataMenuJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_SectionIDs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field SectionIDs of RestaurantOrderingMenuDataMenuJSON is not a string.");
            vector_SectionIDs1.Add(json_string.getData());
          }
        initSectionIDs();
        for (int num1 = 0; num1 < vector_SectionIDs1.Count; ++num1)
            appendSectionIDs(vector_SectionIDs1[num1]);
        for (int num1 = 0; num1 < vector_SectionIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAdditionalMenuItemIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AdditionalMenuItemIDs of RestaurantOrderingMenuDataMenuJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_AdditionalMenuItemIDs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field AdditionalMenuItemIDs of RestaurantOrderingMenuDataMenuJSON is not a string.");
            vector_AdditionalMenuItemIDs1.Add(json_string.getData());
          }
        initAdditionalMenuItemIDs();
        for (int num2 = 0; num2 < vector_AdditionalMenuItemIDs1.Count; ++num2)
            appendAdditionalMenuItemIDs(vector_AdditionalMenuItemIDs1[num2]);
        for (int num1 = 0; num1 < vector_AdditionalMenuItemIDs1.Count; ++num1)
          {
          }
      }


    public RestaurantOrderingMenuDataMenuJSON()
      {
        flagHasSectionIDs = false;
        flagHasAdditionalMenuItemIDs = false;
        storeSectionIDs = new List< string >();
        storeAdditionalMenuItemIDs = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getEntityKind()
      {
        return "Menu";
      }

    public bool  hasSectionIDs()
      {
        return flagHasSectionIDs;
      }

    public int  countOfSectionIDs()
      {
        Debug.Assert(flagHasSectionIDs);
        return storeSectionIDs.Count;
      }

    public string  elementOfSectionIDs(int element_num)
      {
        Debug.Assert(flagHasSectionIDs);
        return storeSectionIDs[element_num];
      }

    public List< string >  getSectionIDs()
      {
        Debug.Assert(flagHasSectionIDs);
        return storeSectionIDs;
      }

    public bool  hasAdditionalMenuItemIDs()
      {
        return flagHasAdditionalMenuItemIDs;
      }

    public int  countOfAdditionalMenuItemIDs()
      {
        Debug.Assert(flagHasAdditionalMenuItemIDs);
        return storeAdditionalMenuItemIDs.Count;
      }

    public string  elementOfAdditionalMenuItemIDs(int element_num)
      {
        Debug.Assert(flagHasAdditionalMenuItemIDs);
        return storeAdditionalMenuItemIDs[element_num];
      }

    public List< string >  getAdditionalMenuItemIDs()
      {
        Debug.Assert(flagHasAdditionalMenuItemIDs);
        return storeAdditionalMenuItemIDs;
      }


    public virtual int extraRestaurantOrderingMenuDataMenuComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantOrderingMenuDataMenuComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingMenuDataMenuComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingMenuDataMenuLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRestaurantOrderingMenuDataEntityComponentCount()
      {
        int result = 0;
        if (flagHasSectionIDs)
            ++result;
        if (flagHasAdditionalMenuItemIDs)
            ++result;
        result += extraRestaurantOrderingMenuDataMenuComponentCount();
        return result;
      }
    public override string extraRestaurantOrderingMenuDataEntityComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSectionIDs)
          {
            if (remainder == 0)
                return "SectionIDs";
            --remainder;
          }
        if (flagHasAdditionalMenuItemIDs)
          {
            if (remainder == 0)
                return "AdditionalMenuItemIDs";
            --remainder;
          }
        return extraRestaurantOrderingMenuDataMenuComponentKey(remainder);
      }
    public override JSONValue extraRestaurantOrderingMenuDataEntityComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSectionIDs)
          {
            if (remainder == 0)
                return extraSectionIDsToJSON();
            --remainder;
          }
        if (flagHasAdditionalMenuItemIDs)
          {
            if (remainder == 0)
                return extraAdditionalMenuItemIDsToJSON();
            --remainder;
          }
        return extraRestaurantOrderingMenuDataMenuComponentValue(remainder);
      }
    public override JSONValue extraRestaurantOrderingMenuDataEntityLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "dditionalMenuItemIDs", 0, 20, false) == 0) && (field_name.Length == 21))
                    return (flagHasAdditionalMenuItemIDs ? extraAdditionalMenuItemIDsToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "ectionIDs", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasSectionIDs ? extraSectionIDsToJSON() : null);
                break;
            default:
                break;
          }
        return extraRestaurantOrderingMenuDataMenuLookup(field_name);
      }

    public void initSectionIDs()
      {
        flagHasSectionIDs = true;
        storeSectionIDs.Clear();
      }
    public void appendSectionIDs(string to_append)
      {
        if (!flagHasSectionIDs)
          {
            flagHasSectionIDs = true;
            storeSectionIDs.Clear();
          }
        Debug.Assert(flagHasSectionIDs);
        storeSectionIDs.Add(to_append);
      }
    public void unsetSectionIDs()
      {
        flagHasSectionIDs = false;
        storeSectionIDs.Clear();
      }
    public void initAdditionalMenuItemIDs()
      {
        flagHasAdditionalMenuItemIDs = true;
        storeAdditionalMenuItemIDs.Clear();
      }
    public void appendAdditionalMenuItemIDs(string to_append)
      {
        if (!flagHasAdditionalMenuItemIDs)
          {
            flagHasAdditionalMenuItemIDs = true;
            storeAdditionalMenuItemIDs.Clear();
          }
        Debug.Assert(flagHasAdditionalMenuItemIDs);
        storeAdditionalMenuItemIDs.Add(to_append);
      }
    public void unsetAdditionalMenuItemIDs()
      {
        flagHasAdditionalMenuItemIDs = false;
        storeAdditionalMenuItemIDs.Clear();
      }

    public virtual void extraRestaurantOrderingMenuDataMenuAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantOrderingMenuDataMenuSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantOrderingMenuDataMenuLookup(key);
        if (old_field == null)
          {
            extraRestaurantOrderingMenuDataMenuAppendPair(key, new_component);
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
    public override void extraRestaurantOrderingMenuDataEntityAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "dditionalMenuItemIDs", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONAdditionalMenuItemIDs(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "ectionIDs", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONSectionIDs(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRestaurantOrderingMenuDataMenuAppendPair(key, new_component);
      }
    public override void extraRestaurantOrderingMenuDataEntitySetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "dditionalMenuItemIDs", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONAdditionalMenuItemIDs(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "ectionIDs", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONSectionIDs(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRestaurantOrderingMenuDataMenuSetField(key, new_component);
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
        if (flagHasSectionIDs)
          {
            handler.start_pair("SectionIDs");
            handler.start_array();
            for (int num1 = 0; num1 < storeSectionIDs.Count; ++num1)
              {
                handler.string_value(storeSectionIDs[num1]);
              }
            handler.finish_array();
          }
        if (flagHasAdditionalMenuItemIDs)
          {
            handler.start_pair("AdditionalMenuItemIDs");
            handler.start_array();
            for (int num2 = 0; num2 < storeAdditionalMenuItemIDs.Count; ++num2)
              {
                handler.string_value(storeAdditionalMenuItemIDs[num2]);
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

    public static new RestaurantOrderingMenuDataMenuJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataMenuJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataMenu", ignore_extras);
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
    public static new RestaurantOrderingMenuDataMenuJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RestaurantOrderingMenuDataMenuJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataMenuJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataMenu", ignore_extras);
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
    public static new RestaurantOrderingMenuDataMenuJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RestaurantOrderingMenuDataMenuJSON from_text(string text, bool ignore_extras)
      {
        RestaurantOrderingMenuDataMenuJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataMenu", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantOrderingMenuDataMenuJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RestaurantOrderingMenuDataMenuJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantOrderingMenuDataMenuJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataMenu", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RestaurantOrderingMenuDataEntityJSON.Generator
      {
        private JSONHoldingStringArrayGenerator fieldGeneratorSectionIDs;
        private JSONHoldingStringArrayGenerator fieldGeneratorAdditionalMenuItemIDs;
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
            if (!(getRestaurantOrderingMenuDataEntityJSONKey().Equals("Menu")))
                throw new Exception("The key field has a value other than `Menu'.");
            RestaurantOrderingMenuDataMenuJSON result = new RestaurantOrderingMenuDataMenuJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantOrderingMenuDataMenuAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RestaurantOrderingMenuDataEntityJSON new_result)
          {
            handle_result((RestaurantOrderingMenuDataMenuJSON )new_result);
          }
        protected void finish(RestaurantOrderingMenuDataMenuJSON result)
          {
            if (fieldGeneratorSectionIDs.have_value)
              {
                result.initSectionIDs();
                int count = fieldGeneratorSectionIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSectionIDs(fieldGeneratorSectionIDs.value[num]);
                  }
                fieldGeneratorSectionIDs.value.Clear();
                fieldGeneratorSectionIDs.have_value = false;
              }
            if (fieldGeneratorAdditionalMenuItemIDs.have_value)
              {
                result.initAdditionalMenuItemIDs();
                int count = fieldGeneratorAdditionalMenuItemIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAdditionalMenuItemIDs(fieldGeneratorAdditionalMenuItemIDs.value[num]);
                  }
                fieldGeneratorAdditionalMenuItemIDs.value.Clear();
                fieldGeneratorAdditionalMenuItemIDs.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(RestaurantOrderingMenuDataMenuJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "dditionalMenuItemIDs", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorAdditionalMenuItemIDs;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ectionIDs", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorSectionIDs;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSectionIDs = new JSONHoldingStringArrayGenerator("field \"SectionIDs\" of the RestaurantOrderingMenuDataMenu class");
            fieldGeneratorAdditionalMenuItemIDs = new JSONHoldingStringArrayGenerator("field \"AdditionalMenuItemIDs\" of the RestaurantOrderingMenuDataMenu class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantOrderingMenuDataMenu class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSectionIDs = new JSONHoldingStringArrayGenerator("field \"SectionIDs\" of the RestaurantOrderingMenuDataMenu class");
            fieldGeneratorAdditionalMenuItemIDs = new JSONHoldingStringArrayGenerator("field \"AdditionalMenuItemIDs\" of the RestaurantOrderingMenuDataMenu class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantOrderingMenuDataMenu class");
          }

        public override void reset()
          {
            fieldGeneratorSectionIDs.reset();
            fieldGeneratorAdditionalMenuItemIDs.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RestaurantOrderingMenuDataMenuJSON  result)
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
        public RestaurantOrderingMenuDataMenuJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantOrderingMenuDataMenuJSON  result)
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
    protected virtual void handle_result(List<RestaurantOrderingMenuDataMenuJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantOrderingMenuDataMenuJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantOrderingMenuDataMenuJSON>();
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
    public List<RestaurantOrderingMenuDataMenuJSON> value;
  };
  };
