/* file "RestaurantOrderingMenuDataItemJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class RestaurantOrderingMenuDataItemJSON : RestaurantOrderingMenuDataEntityJSON
  {
    private bool flagHasPrice;
    private MonetaryAmountJSON  storePrice;
    private bool flagHasModifierGroupIDs;
    private List< string > storeModifierGroupIDs;


    private JSONValue  extraPriceToJSON()
      {
        JSONValueHandler handler_Price = new JSONValueHandler();
        storePrice.write_as_json(handler_Price);
        return handler_Price.result;
      }

    private JSONValue  extraModifierGroupIDsToJSON()
      {
        JSONArrayValue generated_array_1_ModifierGroupIDs = new JSONArrayValue();
        for (int num1 = 0; num1 < storeModifierGroupIDs.Count; ++num1)
          {
            JSONStringValue generated_string_ModifierGroupIDs = new JSONStringValue(storeModifierGroupIDs[num1]);
            generated_array_1_ModifierGroupIDs.appendComponent(generated_string_ModifierGroupIDs);
          }
        return generated_array_1_ModifierGroupIDs;
      }


    private void  fromJSONPrice(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MonetaryAmountJSON convert_classy = MonetaryAmountJSON.from_json(json_value, ignore_extras, true);
        setPrice(convert_classy);
      }


    private void  fromJSONModifierGroupIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ModifierGroupIDs of RestaurantOrderingMenuDataItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_ModifierGroupIDs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ModifierGroupIDs of RestaurantOrderingMenuDataItemJSON is not a string.");
            vector_ModifierGroupIDs1.Add(json_string.getData());
          }
        initModifierGroupIDs();
        for (int num1 = 0; num1 < vector_ModifierGroupIDs1.Count; ++num1)
            appendModifierGroupIDs(vector_ModifierGroupIDs1[num1]);
        for (int num1 = 0; num1 < vector_ModifierGroupIDs1.Count; ++num1)
          {
          }
      }


    public RestaurantOrderingMenuDataItemJSON()
      {
        flagHasPrice = false;
        flagHasModifierGroupIDs = false;
        storeModifierGroupIDs = new List< string >();
      }

    public override string  getEntityKind()
      {
        return "Item";
      }

    public abstract string getItemKind();
    public bool  hasPrice()
      {
        return flagHasPrice;
      }

    public MonetaryAmountJSON   getPrice()
      {
        Debug.Assert(flagHasPrice);
        return storePrice;
      }

    public bool  hasModifierGroupIDs()
      {
        return flagHasModifierGroupIDs;
      }

    public int  countOfModifierGroupIDs()
      {
        Debug.Assert(flagHasModifierGroupIDs);
        return storeModifierGroupIDs.Count;
      }

    public string  elementOfModifierGroupIDs(int element_num)
      {
        Debug.Assert(flagHasModifierGroupIDs);
        return storeModifierGroupIDs[element_num];
      }

    public List< string >  getModifierGroupIDs()
      {
        Debug.Assert(flagHasModifierGroupIDs);
        return storeModifierGroupIDs;
      }


    public abstract int extraRestaurantOrderingMenuDataItemComponentCount();
    public abstract string extraRestaurantOrderingMenuDataItemComponentKey(int component_num);
    public abstract JSONValue extraRestaurantOrderingMenuDataItemComponentValue(int component_num);
    public abstract JSONValue extraRestaurantOrderingMenuDataItemLookup(string field_name);
    public override int extraRestaurantOrderingMenuDataEntityComponentCount()
      {
        int result = 1;
        if (flagHasPrice)
            ++result;
        if (flagHasModifierGroupIDs)
            ++result;
        result += extraRestaurantOrderingMenuDataItemComponentCount();
        return result;
      }
    public override string extraRestaurantOrderingMenuDataEntityComponentKey(int component_num)
      {
        if (component_num == 0)
            return "ItemKind";
        int remainder = (component_num - 1);
        if (flagHasPrice)
          {
            if (remainder == 0)
                return "Price";
            --remainder;
          }
        if (flagHasModifierGroupIDs)
          {
            if (remainder == 0)
                return "ModifierGroupIDs";
            --remainder;
          }
        return extraRestaurantOrderingMenuDataItemComponentKey(remainder);
      }
    public override JSONValue extraRestaurantOrderingMenuDataEntityComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getItemKind());
        int remainder = (component_num - 1);
        if (flagHasPrice)
          {
            if (remainder == 0)
                return extraPriceToJSON();
            --remainder;
          }
        if (flagHasModifierGroupIDs)
          {
            if (remainder == 0)
                return extraModifierGroupIDsToJSON();
            --remainder;
          }
        return extraRestaurantOrderingMenuDataItemComponentValue(remainder);
      }
    public override JSONValue extraRestaurantOrderingMenuDataEntityLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'I':
                if ((String.Compare(field_name, 1, "temKind", 0, 7, false) == 0) && (field_name.Length == 8))
                    return new JSONStringValue(getItemKind());
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "odifierGroupIDs", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasModifierGroupIDs ? extraModifierGroupIDsToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "rice", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasPrice ? extraPriceToJSON() : null);
                break;
            default:
                break;
          }
        return extraRestaurantOrderingMenuDataItemLookup(field_name);
      }

    public void setPrice(MonetaryAmountJSON  new_value)
      {
        if (flagHasPrice)
          {
          }
        flagHasPrice = true;
        storePrice = new_value;
      }
    public void unsetPrice()
      {
        if (flagHasPrice)
          {
          }
        flagHasPrice = false;
      }
    public void initModifierGroupIDs()
      {
        flagHasModifierGroupIDs = true;
        storeModifierGroupIDs.Clear();
      }
    public void appendModifierGroupIDs(string to_append)
      {
        if (!flagHasModifierGroupIDs)
          {
            flagHasModifierGroupIDs = true;
            storeModifierGroupIDs.Clear();
          }
        Debug.Assert(flagHasModifierGroupIDs);
        storeModifierGroupIDs.Add(to_append);
      }
    public void unsetModifierGroupIDs()
      {
        flagHasModifierGroupIDs = false;
        storeModifierGroupIDs.Clear();
      }

    public abstract void extraRestaurantOrderingMenuDataItemAppendPair(string key, JSONValue new_component);
    public abstract void extraRestaurantOrderingMenuDataItemSetField(string key, JSONValue new_component);
    public override void extraRestaurantOrderingMenuDataEntityAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "temKind", 0, 7, false) == 0) && (key.Length == 8))
                    return;
                break;
            case 'M':
                if ((String.Compare(key, 1, "odifierGroupIDs", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONModifierGroupIDs(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "rice", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONPrice(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRestaurantOrderingMenuDataItemAppendPair(key, new_component);
      }
    public override void extraRestaurantOrderingMenuDataEntitySetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "temKind", 0, 7, false) == 0) && (key.Length == 8))
                    return;
                break;
            case 'M':
                if ((String.Compare(key, 1, "odifierGroupIDs", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONModifierGroupIDs(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "rice", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONPrice(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRestaurantOrderingMenuDataItemSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        handler.pair("ItemKind", getItemKind());
        if (flagHasPrice)
          {
            handler.start_pair("Price");
            if (partial_allowed)
                storePrice.write_partial_as_json(handler);
            else
                storePrice.write_as_json(handler);
          }
        if (flagHasModifierGroupIDs)
          {
            handler.start_pair("ModifierGroupIDs");
            handler.start_array();
            for (int num1 = 0; num1 < storeModifierGroupIDs.Count; ++num1)
              {
                handler.string_value(storeModifierGroupIDs[num1]);
              }
            handler.finish_array();
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new RestaurantOrderingMenuDataItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataItem", ignore_extras);
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
    public static new RestaurantOrderingMenuDataItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RestaurantOrderingMenuDataItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataItem", ignore_extras);
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
    public static new RestaurantOrderingMenuDataItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RestaurantOrderingMenuDataItemJSON from_text(string text, bool ignore_extras)
      {
        RestaurantOrderingMenuDataItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataItem", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantOrderingMenuDataItemJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RestaurantOrderingMenuDataItemJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantOrderingMenuDataItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataItem", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RestaurantOrderingMenuDataEntityJSON.Generator
      {
        private MonetaryAmountJSON.HoldingGenerator fieldGeneratorPrice;
        private JSONHoldingStringArrayGenerator fieldGeneratorModifierGroupIDs;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `ItemKind' field is missing.");
            if (!(getRestaurantOrderingMenuDataEntityJSONKey().Equals("Item")))
                throw new Exception("The key field has a value other than `Item'.");
            RestaurantOrderingMenuDataItemJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantOrderingMenuDataItemAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getRestaurantOrderingMenuDataItemJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `ItemKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(RestaurantOrderingMenuDataEntityJSON new_result)
          {
            handle_result((RestaurantOrderingMenuDataItemJSON )new_result);
          }
        protected void finish(RestaurantOrderingMenuDataItemJSON result)
          {
            if (fieldGeneratorPrice.have_value)
              {
                result.setPrice(fieldGeneratorPrice.value);
                fieldGeneratorPrice.have_value = false;
              }
            if (fieldGeneratorModifierGroupIDs.have_value)
              {
                result.initModifierGroupIDs();
                int count = fieldGeneratorModifierGroupIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendModifierGroupIDs(fieldGeneratorModifierGroupIDs.value[num]);
                  }
                fieldGeneratorModifierGroupIDs.value.Clear();
                fieldGeneratorModifierGroupIDs.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(RestaurantOrderingMenuDataItemJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "temKind", 0, 7, false) == 0) && (field_name.Length == 8))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "odifierGroupIDs", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorModifierGroupIDs;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "rice", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorPrice;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorPrice = new MonetaryAmountJSON.HoldingGenerator("field \"Price\" of the RestaurantOrderingMenuDataItem class", ignore_extras);
            fieldGeneratorModifierGroupIDs = new JSONHoldingStringArrayGenerator("field \"ModifierGroupIDs\" of the RestaurantOrderingMenuDataItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ItemKind\" of the RestaurantOrderingMenuDataItem class");
            set_what("the RestaurantOrderingMenuDataItem class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorPrice = new MonetaryAmountJSON.HoldingGenerator("field \"Price\" of the RestaurantOrderingMenuDataItem class", false);
            fieldGeneratorModifierGroupIDs = new JSONHoldingStringArrayGenerator("field \"ModifierGroupIDs\" of the RestaurantOrderingMenuDataItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ItemKind\" of the RestaurantOrderingMenuDataItem class");
            set_what("the RestaurantOrderingMenuDataItem class");
          }

        public override void reset()
          {
            fieldGeneratorPrice.reset();
            fieldGeneratorModifierGroupIDs.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RestaurantOrderingMenuDataItemJSON  result)
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
        public RestaurantOrderingMenuDataItemJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantOrderingMenuDataItemJSON  result)
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
    protected virtual void handle_result(List<RestaurantOrderingMenuDataItemJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantOrderingMenuDataItemJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantOrderingMenuDataItemJSON>();
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
    public List<RestaurantOrderingMenuDataItemJSON> value;
  };
    class GenericRestaurantOrderingMenuDataItemJSON : RestaurantOrderingMenuDataItemJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericRestaurantOrderingMenuDataItemJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getItemKind()  { return key; }
        public override int extraRestaurantOrderingMenuDataItemComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraRestaurantOrderingMenuDataItemComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraRestaurantOrderingMenuDataItemComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraRestaurantOrderingMenuDataItemLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraRestaurantOrderingMenuDataItemAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraRestaurantOrderingMenuDataItemSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraRestaurantOrderingMenuDataItemLookup(key);
            if (old_field == null)
              {
                extraRestaurantOrderingMenuDataItemAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static new RestaurantOrderingMenuDataItemJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {

        return new GenericRestaurantOrderingMenuDataItemJSON(key);
      }
  };
