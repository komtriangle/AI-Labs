/* file "RestaurantOrderingMenuDataSectionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RestaurantOrderingMenuDataSectionJSON : RestaurantOrderingMenuDataEntityJSON
  {
    private bool flagHasMenuItemIDs;
    private List< string > storeMenuItemIDs;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraMenuItemIDsToJSON()
      {
        JSONArrayValue generated_array_1_MenuItemIDs = new JSONArrayValue();
        for (int num1 = 0; num1 < storeMenuItemIDs.Count; ++num1)
          {
            JSONStringValue generated_string_MenuItemIDs = new JSONStringValue(storeMenuItemIDs[num1]);
            generated_array_1_MenuItemIDs.appendComponent(generated_string_MenuItemIDs);
          }
        return generated_array_1_MenuItemIDs;
      }


    private void  fromJSONMenuItemIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MenuItemIDs of RestaurantOrderingMenuDataSectionJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_MenuItemIDs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field MenuItemIDs of RestaurantOrderingMenuDataSectionJSON is not a string.");
            vector_MenuItemIDs1.Add(json_string.getData());
          }
        initMenuItemIDs();
        for (int num1 = 0; num1 < vector_MenuItemIDs1.Count; ++num1)
            appendMenuItemIDs(vector_MenuItemIDs1[num1]);
        for (int num1 = 0; num1 < vector_MenuItemIDs1.Count; ++num1)
          {
          }
      }


    public RestaurantOrderingMenuDataSectionJSON()
      {
        flagHasMenuItemIDs = false;
        storeMenuItemIDs = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getEntityKind()
      {
        return "Section";
      }

    public bool  hasMenuItemIDs()
      {
        return flagHasMenuItemIDs;
      }

    public int  countOfMenuItemIDs()
      {
        Debug.Assert(flagHasMenuItemIDs);
        return storeMenuItemIDs.Count;
      }

    public string  elementOfMenuItemIDs(int element_num)
      {
        Debug.Assert(flagHasMenuItemIDs);
        return storeMenuItemIDs[element_num];
      }

    public List< string >  getMenuItemIDs()
      {
        Debug.Assert(flagHasMenuItemIDs);
        return storeMenuItemIDs;
      }


    public virtual int extraRestaurantOrderingMenuDataSectionComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantOrderingMenuDataSectionComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingMenuDataSectionComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingMenuDataSectionLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRestaurantOrderingMenuDataEntityComponentCount()
      {
        int result = 0;
        if (flagHasMenuItemIDs)
            ++result;
        result += extraRestaurantOrderingMenuDataSectionComponentCount();
        return result;
      }
    public override string extraRestaurantOrderingMenuDataEntityComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasMenuItemIDs)
          {
            if (remainder == 0)
                return "MenuItemIDs";
            --remainder;
          }
        return extraRestaurantOrderingMenuDataSectionComponentKey(remainder);
      }
    public override JSONValue extraRestaurantOrderingMenuDataEntityComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasMenuItemIDs)
          {
            if (remainder == 0)
                return extraMenuItemIDsToJSON();
            --remainder;
          }
        return extraRestaurantOrderingMenuDataSectionComponentValue(remainder);
      }
    public override JSONValue extraRestaurantOrderingMenuDataEntityLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "MenuItemIDs", 0, 11, false) == 0) && (field_name.Length == 11))
            return (flagHasMenuItemIDs ? extraMenuItemIDsToJSON() : null);
        return extraRestaurantOrderingMenuDataSectionLookup(field_name);
      }

    public void initMenuItemIDs()
      {
        flagHasMenuItemIDs = true;
        storeMenuItemIDs.Clear();
      }
    public void appendMenuItemIDs(string to_append)
      {
        if (!flagHasMenuItemIDs)
          {
            flagHasMenuItemIDs = true;
            storeMenuItemIDs.Clear();
          }
        Debug.Assert(flagHasMenuItemIDs);
        storeMenuItemIDs.Add(to_append);
      }
    public void unsetMenuItemIDs()
      {
        flagHasMenuItemIDs = false;
        storeMenuItemIDs.Clear();
      }

    public virtual void extraRestaurantOrderingMenuDataSectionAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantOrderingMenuDataSectionSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantOrderingMenuDataSectionLookup(key);
        if (old_field == null)
          {
            extraRestaurantOrderingMenuDataSectionAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "MenuItemIDs", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONMenuItemIDs(new_component, false);
            return;
            }
        extraRestaurantOrderingMenuDataSectionAppendPair(key, new_component);
      }
    public override void extraRestaurantOrderingMenuDataEntitySetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "MenuItemIDs", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONMenuItemIDs(new_component, false);
            return;
            }
        extraRestaurantOrderingMenuDataSectionSetField(key, new_component);
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
        if (flagHasMenuItemIDs)
          {
            handler.start_pair("MenuItemIDs");
            handler.start_array();
            for (int num1 = 0; num1 < storeMenuItemIDs.Count; ++num1)
              {
                handler.string_value(storeMenuItemIDs[num1]);
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

    public static new RestaurantOrderingMenuDataSectionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataSectionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataSection", ignore_extras);
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
    public static new RestaurantOrderingMenuDataSectionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RestaurantOrderingMenuDataSectionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataSectionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataSection", ignore_extras);
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
    public static new RestaurantOrderingMenuDataSectionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RestaurantOrderingMenuDataSectionJSON from_text(string text, bool ignore_extras)
      {
        RestaurantOrderingMenuDataSectionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataSection", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantOrderingMenuDataSectionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RestaurantOrderingMenuDataSectionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantOrderingMenuDataSectionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataSection", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RestaurantOrderingMenuDataEntityJSON.Generator
      {
        private JSONHoldingStringArrayGenerator fieldGeneratorMenuItemIDs;
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
            if (!(getRestaurantOrderingMenuDataEntityJSONKey().Equals("Section")))
                throw new Exception("The key field has a value other than `Section'.");
            RestaurantOrderingMenuDataSectionJSON result = new RestaurantOrderingMenuDataSectionJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantOrderingMenuDataSectionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RestaurantOrderingMenuDataEntityJSON new_result)
          {
            handle_result((RestaurantOrderingMenuDataSectionJSON )new_result);
          }
        protected void finish(RestaurantOrderingMenuDataSectionJSON result)
          {
            if (fieldGeneratorMenuItemIDs.have_value)
              {
                result.initMenuItemIDs();
                int count = fieldGeneratorMenuItemIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMenuItemIDs(fieldGeneratorMenuItemIDs.value[num]);
                  }
                fieldGeneratorMenuItemIDs.value.Clear();
                fieldGeneratorMenuItemIDs.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(RestaurantOrderingMenuDataSectionJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "MenuItemIDs", 0, 11, false) == 0) && (field_name.Length == 11))
                return fieldGeneratorMenuItemIDs;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorMenuItemIDs = new JSONHoldingStringArrayGenerator("field \"MenuItemIDs\" of the RestaurantOrderingMenuDataSection class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantOrderingMenuDataSection class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorMenuItemIDs = new JSONHoldingStringArrayGenerator("field \"MenuItemIDs\" of the RestaurantOrderingMenuDataSection class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantOrderingMenuDataSection class");
          }

        public override void reset()
          {
            fieldGeneratorMenuItemIDs.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RestaurantOrderingMenuDataSectionJSON  result)
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
        public RestaurantOrderingMenuDataSectionJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantOrderingMenuDataSectionJSON  result)
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
    protected virtual void handle_result(List<RestaurantOrderingMenuDataSectionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantOrderingMenuDataSectionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantOrderingMenuDataSectionJSON>();
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
    public List<RestaurantOrderingMenuDataSectionJSON> value;
  };
  };
