/* file "RestaurantOrderingMenuDataAvailabilityJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RestaurantOrderingMenuDataAvailabilityJSON : JSONBase
  {
    private bool flagHasOnlyAtStoreIDs;
    private List< string > storeOnlyAtStoreIDs;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONOnlyAtStoreIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field OnlyAtStoreIDs of RestaurantOrderingMenuDataAvailabilityJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field OnlyAtStoreIDs of RestaurantOrderingMenuDataAvailabilityJSON has too few elements.");
        List< string > vector_OnlyAtStoreIDs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field OnlyAtStoreIDs of RestaurantOrderingMenuDataAvailabilityJSON is not a string.");
            vector_OnlyAtStoreIDs1.Add(json_string.getData());
          }
        Debug.Assert(vector_OnlyAtStoreIDs1.Count >= 1);
        initOnlyAtStoreIDs();
        for (int num1 = 0; num1 < vector_OnlyAtStoreIDs1.Count; ++num1)
            appendOnlyAtStoreIDs(vector_OnlyAtStoreIDs1[num1]);
        for (int num1 = 0; num1 < vector_OnlyAtStoreIDs1.Count; ++num1)
          {
          }
      }


    public RestaurantOrderingMenuDataAvailabilityJSON()
      {
        flagHasOnlyAtStoreIDs = false;
        storeOnlyAtStoreIDs = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasOnlyAtStoreIDs()
      {
        return flagHasOnlyAtStoreIDs;
      }

    public int  countOfOnlyAtStoreIDs()
      {
        Debug.Assert(flagHasOnlyAtStoreIDs);
        return storeOnlyAtStoreIDs.Count;
      }

    public string  elementOfOnlyAtStoreIDs(int element_num)
      {
        Debug.Assert(flagHasOnlyAtStoreIDs);
        return storeOnlyAtStoreIDs[element_num];
      }

    public List< string >  getOnlyAtStoreIDs()
      {
        Debug.Assert(flagHasOnlyAtStoreIDs);
        return storeOnlyAtStoreIDs;
      }


    public virtual int extraRestaurantOrderingMenuDataAvailabilityComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantOrderingMenuDataAvailabilityComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingMenuDataAvailabilityComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingMenuDataAvailabilityLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initOnlyAtStoreIDs()
      {
        flagHasOnlyAtStoreIDs = true;
        storeOnlyAtStoreIDs.Clear();
      }
    public void appendOnlyAtStoreIDs(string to_append)
      {
        if (!flagHasOnlyAtStoreIDs)
          {
            flagHasOnlyAtStoreIDs = true;
            storeOnlyAtStoreIDs.Clear();
          }
        Debug.Assert(flagHasOnlyAtStoreIDs);
        storeOnlyAtStoreIDs.Add(to_append);
      }
    public void unsetOnlyAtStoreIDs()
      {
        flagHasOnlyAtStoreIDs = false;
        storeOnlyAtStoreIDs.Clear();
      }

    public virtual void extraRestaurantOrderingMenuDataAvailabilityAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantOrderingMenuDataAvailabilitySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantOrderingMenuDataAvailabilityLookup(key);
        if (old_field == null)
          {
            extraRestaurantOrderingMenuDataAvailabilityAppendPair(key, new_component);
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
        if (flagHasOnlyAtStoreIDs)
          {
            handler.start_pair("OnlyAtStoreIDs");
            Debug.Assert(storeOnlyAtStoreIDs.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeOnlyAtStoreIDs.Count; ++num1)
              {
                handler.string_value(storeOnlyAtStoreIDs[num1]);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static RestaurantOrderingMenuDataAvailabilityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataAvailabilityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataAvailability", ignore_extras);
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
    public static RestaurantOrderingMenuDataAvailabilityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantOrderingMenuDataAvailabilityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataAvailabilityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataAvailability", ignore_extras);
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
    public static RestaurantOrderingMenuDataAvailabilityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantOrderingMenuDataAvailabilityJSON from_text(string text, bool ignore_extras)
      {
        RestaurantOrderingMenuDataAvailabilityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataAvailability", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantOrderingMenuDataAvailabilityJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantOrderingMenuDataAvailabilityJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantOrderingMenuDataAvailabilityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataAvailability", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringArrayGenerator fieldGeneratorOnlyAtStoreIDs;
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
            RestaurantOrderingMenuDataAvailabilityJSON result = new RestaurantOrderingMenuDataAvailabilityJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantOrderingMenuDataAvailabilityAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantOrderingMenuDataAvailabilityJSON result)
          {
            if (fieldGeneratorOnlyAtStoreIDs.have_value)
              {
                result.initOnlyAtStoreIDs();
                int count = fieldGeneratorOnlyAtStoreIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOnlyAtStoreIDs(fieldGeneratorOnlyAtStoreIDs.value[num]);
                  }
                fieldGeneratorOnlyAtStoreIDs.value.Clear();
                fieldGeneratorOnlyAtStoreIDs.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantOrderingMenuDataAvailabilityJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "OnlyAtStoreIDs", 0, 14, false) == 0) && (field_name.Length == 14))
                return fieldGeneratorOnlyAtStoreIDs;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorOnlyAtStoreIDs = new JSONHoldingStringArrayGenerator("field \"OnlyAtStoreIDs\" of the RestaurantOrderingMenuDataAvailability class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantOrderingMenuDataAvailability class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorOnlyAtStoreIDs = new JSONHoldingStringArrayGenerator("field \"OnlyAtStoreIDs\" of the RestaurantOrderingMenuDataAvailability class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantOrderingMenuDataAvailability class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorOnlyAtStoreIDs.reset();
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
        protected override void handle_result(RestaurantOrderingMenuDataAvailabilityJSON  result)
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
        public RestaurantOrderingMenuDataAvailabilityJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantOrderingMenuDataAvailabilityJSON  result)
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
    protected virtual void handle_result(List<RestaurantOrderingMenuDataAvailabilityJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantOrderingMenuDataAvailabilityJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantOrderingMenuDataAvailabilityJSON>();
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
    public List<RestaurantOrderingMenuDataAvailabilityJSON> value;
  };
  };
