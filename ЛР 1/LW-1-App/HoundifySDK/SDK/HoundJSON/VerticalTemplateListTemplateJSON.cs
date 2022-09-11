/* file "VerticalTemplateListTemplateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class VerticalTemplateListTemplateJSON : TemplateJSON
  {
    public class TypeItemsJSON : JSONBase
      {
        private bool flagHasDividerBelow;
        private bool storeDividerBelow;
        private bool flagHasTemplateName;
        private string storeTemplateName;
        private bool flagHasTemplateData;
        private TemplateJSON  storeTemplateData;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONDividerBelow(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field DividerBelow of TypeItemsJSON is not true for false.");
                  }
              }
            setDividerBelow(the_bool);
          }


        private void  fromJSONTemplateName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field TemplateName of TypeItemsJSON is not a string.");
            setTemplateName(json_string.getData());
          }


        private void  fromJSONTemplateData(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TemplateJSON convert_classy = TemplateJSON.from_json(json_value, ignore_extras, true);
            setTemplateData(convert_classy);
          }


        public TypeItemsJSON()
          {
            flagHasDividerBelow = false;
            flagHasTemplateName = false;
            flagHasTemplateData = false;
            storeDividerBelow = true;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasDividerBelow()
          {
            return flagHasDividerBelow;
          }

        public bool  getDividerBelow()
          {
            return storeDividerBelow;
          }

        public bool  hasTemplateName()
          {
            return flagHasTemplateName;
          }

        public string  getTemplateName()
          {
            Debug.Assert(flagHasTemplateName);
            return storeTemplateName;
          }

        public bool  hasTemplateData()
          {
            return flagHasTemplateData;
          }

        public TemplateJSON   getTemplateData()
          {
            Debug.Assert(flagHasTemplateData);
            return storeTemplateData;
          }


        public virtual int extraTypeItemsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeItemsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeItemsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeItemsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setDividerBelow(bool new_value)
          {
            flagHasDividerBelow = true;
            storeDividerBelow = new_value;
          }
        public void unsetDividerBelow()
          {
            flagHasDividerBelow = false;
          }
        public void setTemplateName(string new_value)
          {
            flagHasTemplateName = true;
            storeTemplateName = new_value;
          }
        public void unsetTemplateName()
          {
            flagHasTemplateName = false;
          }
        public void setTemplateData(TemplateJSON  new_value)
          {
            if (flagHasTemplateData)
              {
              }
            flagHasTemplateData = true;
            storeTemplateData = new_value;
          }
        public void unsetTemplateData()
          {
            if (flagHasTemplateData)
              {
              }
            flagHasTemplateData = false;
          }

        public virtual void extraTypeItemsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeItemsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeItemsLookup(key);
            if (old_field == null)
              {
                extraTypeItemsAppendPair(key, new_component);
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
            if (flagHasDividerBelow)
              {
                handler.start_pair("DividerBelow");
                handler.boolean_value(storeDividerBelow);
              }
            Debug.Assert(partial_allowed || flagHasTemplateName);
            if (flagHasTemplateName)
              {
                handler.start_pair("TemplateName");
                handler.string_value(storeTemplateName);
              }
            Debug.Assert(partial_allowed || flagHasTemplateData);
            if (flagHasTemplateData)
              {
                handler.start_pair("TemplateData");
                if (partial_allowed)
                    storeTemplateData.write_partial_as_json(handler);
                else
                    storeTemplateData.write_as_json(handler);
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
            if (!(hasTemplateName()))
              {
                return "When parsing the object for %what%, the \"TemplateName\" field was missing.";
              }
            if (!(hasTemplateData()))
              {
                return "When parsing the object for %what%, the \"TemplateData\" field was missing.";
              }
            return null;
          }

        public static TypeItemsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeItemsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeItems", ignore_extras);
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
        public static TypeItemsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeItemsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeItemsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeItems", ignore_extras);
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
        public static TypeItemsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeItemsJSON from_text(string text, bool ignore_extras)
          {
            TypeItemsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeItems", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeItemsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeItemsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeItemsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeItems", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingBooleanGenerator fieldGeneratorDividerBelow;
            private JSONHoldingStringGenerator fieldGeneratorTemplateName;
            private TemplateJSON.HoldingGenerator fieldGeneratorTemplateData;
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
                TypeItemsJSON result = new TypeItemsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeItemsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeItemsJSON result)
              {
                if (fieldGeneratorDividerBelow.have_value)
                  {
                    result.setDividerBelow(fieldGeneratorDividerBelow.value);
                    fieldGeneratorDividerBelow.have_value = false;
                  }
                if (fieldGeneratorTemplateName.have_value)
                  {
                    result.setTemplateName(fieldGeneratorTemplateName.value);
                    fieldGeneratorTemplateName.have_value = false;
                  }
                else if ((!(result.hasTemplateName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"TemplateName\" field was missing.");
                  }
                if (fieldGeneratorTemplateData.have_value)
                  {
                    result.setTemplateData(fieldGeneratorTemplateData.value);
                    fieldGeneratorTemplateData.have_value = false;
                  }
                else if ((!(result.hasTemplateData())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"TemplateData\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeItemsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "ividerBelow", 0, 11, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorDividerBelow;
                        break;
                    case 'T':
                        if (String.Compare(field_name, 1, "emplate", 0, 7, false) == 0)
                          {
                            switch (field_name[8])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 9, "ata", 0, 3, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorTemplateData;
                                    break;
                                case 'N':
                                    if ((String.Compare(field_name, 9, "ame", 0, 3, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorTemplateName;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorDividerBelow = new JSONHoldingBooleanGenerator("field \"DividerBelow\" of the TypeItems class");
                fieldGeneratorTemplateName = new JSONHoldingStringGenerator("field \"TemplateName\" of the TypeItems class");
                fieldGeneratorTemplateData = new TemplateJSON.HoldingGenerator("field \"TemplateData\" of the TypeItems class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeItems class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorDividerBelow = new JSONHoldingBooleanGenerator("field \"DividerBelow\" of the TypeItems class");
                fieldGeneratorTemplateName = new JSONHoldingStringGenerator("field \"TemplateName\" of the TypeItems class");
                fieldGeneratorTemplateData = new TemplateJSON.HoldingGenerator("field \"TemplateData\" of the TypeItems class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeItems class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorDividerBelow.reset();
                fieldGeneratorTemplateName.reset();
                fieldGeneratorTemplateData.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorTemplateData.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorTemplateData.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeItemsJSON  result)
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
            public TypeItemsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeItemsJSON  result)
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
        protected virtual void handle_result(List<TypeItemsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeItemsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeItemsJSON>();
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
        public List<TypeItemsJSON> value;
      };
      };
    private bool flagHasItems;
    private List< TypeItemsJSON  > storeItems;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraItemsToJSON()
      {
        JSONArrayValue generated_array_1_Items = new JSONArrayValue();
        for (int num1 = 0; num1 < storeItems.Count; ++num1)
          {
            JSONValueHandler handler_Items = new JSONValueHandler();
            storeItems[num1].write_as_json(handler_Items);
            generated_array_1_Items.appendComponent(handler_Items.result);
          }
        return generated_array_1_Items;
      }


    private void  fromJSONItems(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Items of VerticalTemplateListTemplateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Items of VerticalTemplateListTemplateJSON has too few elements.");
        List< TypeItemsJSON  > vector_Items1 = new List< TypeItemsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeItemsJSON convert_classy = TypeItemsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Items1.Add(convert_classy);
          }
        Debug.Assert(vector_Items1.Count >= 1);
        initItems();
        for (int num1 = 0; num1 < vector_Items1.Count; ++num1)
            appendItems(vector_Items1[num1]);
        for (int num1 = 0; num1 < vector_Items1.Count; ++num1)
          {
          }
      }


    public VerticalTemplateListTemplateJSON()
      {
        flagHasItems = false;
        storeItems = new List< TypeItemsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTemplateName()
      {
        return "VerticalTemplateList";
      }

    public bool  hasItems()
      {
        return flagHasItems;
      }

    public int  countOfItems()
      {
        Debug.Assert(flagHasItems);
        return storeItems.Count;
      }

    public TypeItemsJSON   elementOfItems(int element_num)
      {
        Debug.Assert(flagHasItems);
        return storeItems[element_num];
      }

    public List< TypeItemsJSON  >  getItems()
      {
        Debug.Assert(flagHasItems);
        return storeItems;
      }


    public virtual int extraVerticalTemplateListTemplateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraVerticalTemplateListTemplateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraVerticalTemplateListTemplateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraVerticalTemplateListTemplateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTemplateComponentCount()
      {
        int result = 0;
        if (flagHasItems)
            ++result;
        result += extraVerticalTemplateListTemplateComponentCount();
        return result;
      }
    public override string extraTemplateComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasItems)
          {
            if (remainder == 0)
                return "Items";
            --remainder;
          }
        return extraVerticalTemplateListTemplateComponentKey(remainder);
      }
    public override JSONValue extraTemplateComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasItems)
          {
            if (remainder == 0)
                return extraItemsToJSON();
            --remainder;
          }
        return extraVerticalTemplateListTemplateComponentValue(remainder);
      }
    public override JSONValue extraTemplateLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Items", 0, 5, false) == 0) && (field_name.Length == 5))
            return (flagHasItems ? extraItemsToJSON() : null);
        return extraVerticalTemplateListTemplateLookup(field_name);
      }

    public void initItems()
      {
        if (flagHasItems)
          {
            for (int num1 = 0; num1 < storeItems.Count; ++num1)
              {
              }
          }
        flagHasItems = true;
        storeItems.Clear();
      }
    public void appendItems(TypeItemsJSON  to_append)
      {
        if (!flagHasItems)
          {
            flagHasItems = true;
            storeItems.Clear();
          }
        Debug.Assert(flagHasItems);
        storeItems.Add(to_append);
      }
    public void unsetItems()
      {
        if (flagHasItems)
          {
            for (int num2 = 0; num2 < storeItems.Count; ++num2)
              {
              }
          }
        flagHasItems = false;
        storeItems.Clear();
      }

    public virtual void extraVerticalTemplateListTemplateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraVerticalTemplateListTemplateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraVerticalTemplateListTemplateLookup(key);
        if (old_field == null)
          {
            extraVerticalTemplateListTemplateAppendPair(key, new_component);
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
    public override void extraTemplateAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Items", 0, 5, false) == 0) && (key.Length == 5))
            {
            fromJSONItems(new_component, false);
            return;
            }
        extraVerticalTemplateListTemplateAppendPair(key, new_component);
      }
    public override void extraTemplateSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Items", 0, 5, false) == 0) && (key.Length == 5))
            {
            fromJSONItems(new_component, false);
            return;
            }
        extraVerticalTemplateListTemplateSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasItems);
        if (flagHasItems)
          {
            handler.start_pair("Items");
            Debug.Assert(storeItems.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeItems.Count; ++num1)
              {
                if (partial_allowed)
                    storeItems[num1].write_partial_as_json(handler);
                else
                    storeItems[num1].write_as_json(handler);
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
        if (!(hasItems()))
          {
            return "When parsing the object for %what%, the \"Items\" field was missing.";
          }
        return null;
      }

    public static new VerticalTemplateListTemplateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        VerticalTemplateListTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VerticalTemplateListTemplate", ignore_extras);
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
    public static new VerticalTemplateListTemplateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new VerticalTemplateListTemplateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        VerticalTemplateListTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VerticalTemplateListTemplate", ignore_extras);
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
    public static new VerticalTemplateListTemplateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new VerticalTemplateListTemplateJSON from_text(string text, bool ignore_extras)
      {
        VerticalTemplateListTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VerticalTemplateListTemplate", ignore_extras);
            JSONParse.parse_json_value(text, "Text for VerticalTemplateListTemplateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new VerticalTemplateListTemplateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        VerticalTemplateListTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VerticalTemplateListTemplate", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TemplateJSON.Generator
      {
        private TypeItemsJSON.HoldingArrayGenerator fieldGeneratorItems;
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
            if (!(getTemplateJSONKey().Equals("VerticalTemplateList")))
                throw new Exception("The key field has a value other than `VerticalTemplateList'.");
            VerticalTemplateListTemplateJSON result = new VerticalTemplateListTemplateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraVerticalTemplateListTemplateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TemplateJSON new_result)
          {
            handle_result((VerticalTemplateListTemplateJSON )new_result);
          }
        protected void finish(VerticalTemplateListTemplateJSON result)
          {
            if (fieldGeneratorItems.have_value)
              {
                result.initItems();
                int count = fieldGeneratorItems.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendItems(fieldGeneratorItems.value[num]);
                  }
                fieldGeneratorItems.value.Clear();
                fieldGeneratorItems.have_value = false;
              }
            else if ((!(result.hasItems())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Items\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(VerticalTemplateListTemplateJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Items", 0, 5, false) == 0) && (field_name.Length == 5))
                return fieldGeneratorItems;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorItems = new TypeItemsJSON.HoldingArrayGenerator("field \"Items\" of the VerticalTemplateListTemplate class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the VerticalTemplateListTemplate class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorItems = new TypeItemsJSON.HoldingArrayGenerator("field \"Items\" of the VerticalTemplateListTemplate class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the VerticalTemplateListTemplate class");
          }

        public override void reset()
          {
            fieldGeneratorItems.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(VerticalTemplateListTemplateJSON  result)
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
        public VerticalTemplateListTemplateJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(VerticalTemplateListTemplateJSON  result)
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
    protected virtual void handle_result(List<VerticalTemplateListTemplateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<VerticalTemplateListTemplateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<VerticalTemplateListTemplateJSON>();
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
    public List<VerticalTemplateListTemplateJSON> value;
  };
  };
