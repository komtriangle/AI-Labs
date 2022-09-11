/* file "UberProductsResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberProductsResponseJSON : JSONBase
  {
    private bool flagHasproducts;
    private List< UberProductDetailsJSON  > storeproducts;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONproducts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field products of UberProductsResponseJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< UberProductDetailsJSON  > vector_products1 = new List< UberProductDetailsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UberProductDetailsJSON convert_classy = UberProductDetailsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_products1.Add(convert_classy);
          }
        initproducts();
        for (int num1 = 0; num1 < vector_products1.Count; ++num1)
            appendproducts(vector_products1[num1]);
        for (int num1 = 0; num1 < vector_products1.Count; ++num1)
          {
          }
      }


    public UberProductsResponseJSON()
      {
        flagHasproducts = false;
        storeproducts = new List< UberProductDetailsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasproducts()
      {
        return flagHasproducts;
      }

    public int  countOfproducts()
      {
        Debug.Assert(flagHasproducts);
        return storeproducts.Count;
      }

    public UberProductDetailsJSON   elementOfproducts(int element_num)
      {
        Debug.Assert(flagHasproducts);
        return storeproducts[element_num];
      }

    public List< UberProductDetailsJSON  >  getproducts()
      {
        Debug.Assert(flagHasproducts);
        return storeproducts;
      }


    public virtual int extraUberProductsResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberProductsResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberProductsResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberProductsResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initproducts()
      {
        if (flagHasproducts)
          {
            for (int num1 = 0; num1 < storeproducts.Count; ++num1)
              {
              }
          }
        flagHasproducts = true;
        storeproducts.Clear();
      }
    public void appendproducts(UberProductDetailsJSON  to_append)
      {
        if (!flagHasproducts)
          {
            flagHasproducts = true;
            storeproducts.Clear();
          }
        Debug.Assert(flagHasproducts);
        storeproducts.Add(to_append);
      }
    public void unsetproducts()
      {
        if (flagHasproducts)
          {
            for (int num2 = 0; num2 < storeproducts.Count; ++num2)
              {
              }
          }
        flagHasproducts = false;
        storeproducts.Clear();
      }

    public virtual void extraUberProductsResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberProductsResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberProductsResponseLookup(key);
        if (old_field == null)
          {
            extraUberProductsResponseAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasproducts);
        if (flagHasproducts)
          {
            handler.start_pair("products");
            handler.start_array();
            for (int num1 = 0; num1 < storeproducts.Count; ++num1)
              {
                if (partial_allowed)
                    storeproducts[num1].write_partial_as_json(handler);
                else
                    storeproducts[num1].write_as_json(handler);
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
        if (!(hasproducts()))
          {
            return "When parsing the object for %what%, the \"products\" field was missing.";
          }
        return null;
      }

    public static UberProductsResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberProductsResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductsResponse", ignore_extras);
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
    public static UberProductsResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberProductsResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberProductsResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductsResponse", ignore_extras);
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
    public static UberProductsResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberProductsResponseJSON from_text(string text, bool ignore_extras)
      {
        UberProductsResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductsResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberProductsResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberProductsResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberProductsResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductsResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private UberProductDetailsJSON.HoldingArrayGenerator fieldGeneratorproducts;
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
            UberProductsResponseJSON result = new UberProductsResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberProductsResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberProductsResponseJSON result)
          {
            if (fieldGeneratorproducts.have_value)
              {
                result.initproducts();
                int count = fieldGeneratorproducts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendproducts(fieldGeneratorproducts.value[num]);
                  }
                fieldGeneratorproducts.value.Clear();
                fieldGeneratorproducts.have_value = false;
              }
            else if ((!(result.hasproducts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"products\" field was missing.");
              }
          }
        protected abstract void handle_result(UberProductsResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "products", 0, 8, false) == 0) && (field_name.Length == 8))
                return fieldGeneratorproducts;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorproducts = new UberProductDetailsJSON.HoldingArrayGenerator("field \"products\" of the UberProductsResponse class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberProductsResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorproducts = new UberProductDetailsJSON.HoldingArrayGenerator("field \"products\" of the UberProductsResponse class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberProductsResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorproducts.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorproducts.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorproducts.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UberProductsResponseJSON  result)
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
        public UberProductsResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberProductsResponseJSON  result)
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
    protected virtual void handle_result(List<UberProductsResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberProductsResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberProductsResponseJSON>();
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
    public List<UberProductsResponseJSON> value;
  };
  };
