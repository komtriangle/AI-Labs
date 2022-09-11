/* file "RetailUploadedCatalogDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RetailUploadedCatalogDataJSON : JSONBase
  {
    private bool flagHasBrands;
    private List< RetailUploadedAttributeDataJSON  > storeBrands;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONBrands(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Brands of RetailUploadedCatalogDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RetailUploadedAttributeDataJSON  > vector_Brands1 = new List< RetailUploadedAttributeDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RetailUploadedAttributeDataJSON convert_classy = RetailUploadedAttributeDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Brands1.Add(convert_classy);
          }
        initBrands();
        for (int num1 = 0; num1 < vector_Brands1.Count; ++num1)
            appendBrands(vector_Brands1[num1]);
        for (int num1 = 0; num1 < vector_Brands1.Count; ++num1)
          {
          }
      }


    public RetailUploadedCatalogDataJSON()
      {
        flagHasBrands = false;
        storeBrands = new List< RetailUploadedAttributeDataJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasBrands()
      {
        return flagHasBrands;
      }

    public int  countOfBrands()
      {
        Debug.Assert(flagHasBrands);
        return storeBrands.Count;
      }

    public RetailUploadedAttributeDataJSON   elementOfBrands(int element_num)
      {
        Debug.Assert(flagHasBrands);
        return storeBrands[element_num];
      }

    public List< RetailUploadedAttributeDataJSON  >  getBrands()
      {
        Debug.Assert(flagHasBrands);
        return storeBrands;
      }


    public virtual int extraRetailUploadedCatalogDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRetailUploadedCatalogDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRetailUploadedCatalogDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRetailUploadedCatalogDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initBrands()
      {
        if (flagHasBrands)
          {
            for (int num1 = 0; num1 < storeBrands.Count; ++num1)
              {
              }
          }
        flagHasBrands = true;
        storeBrands.Clear();
      }
    public void appendBrands(RetailUploadedAttributeDataJSON  to_append)
      {
        if (!flagHasBrands)
          {
            flagHasBrands = true;
            storeBrands.Clear();
          }
        Debug.Assert(flagHasBrands);
        storeBrands.Add(to_append);
      }
    public void unsetBrands()
      {
        if (flagHasBrands)
          {
            for (int num2 = 0; num2 < storeBrands.Count; ++num2)
              {
              }
          }
        flagHasBrands = false;
        storeBrands.Clear();
      }

    public virtual void extraRetailUploadedCatalogDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRetailUploadedCatalogDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRetailUploadedCatalogDataLookup(key);
        if (old_field == null)
          {
            extraRetailUploadedCatalogDataAppendPair(key, new_component);
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
        if (flagHasBrands)
          {
            handler.start_pair("Brands");
            handler.start_array();
            for (int num1 = 0; num1 < storeBrands.Count; ++num1)
              {
                if (partial_allowed)
                    storeBrands[num1].write_partial_as_json(handler);
                else
                    storeBrands[num1].write_as_json(handler);
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

    public static RetailUploadedCatalogDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RetailUploadedCatalogDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailUploadedCatalogData", ignore_extras);
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
    public static RetailUploadedCatalogDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RetailUploadedCatalogDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RetailUploadedCatalogDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailUploadedCatalogData", ignore_extras);
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
    public static RetailUploadedCatalogDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RetailUploadedCatalogDataJSON from_text(string text, bool ignore_extras)
      {
        RetailUploadedCatalogDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailUploadedCatalogData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RetailUploadedCatalogDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RetailUploadedCatalogDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RetailUploadedCatalogDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailUploadedCatalogData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private RetailUploadedAttributeDataJSON.HoldingArrayGenerator fieldGeneratorBrands;
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
            RetailUploadedCatalogDataJSON result = new RetailUploadedCatalogDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRetailUploadedCatalogDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RetailUploadedCatalogDataJSON result)
          {
            if (fieldGeneratorBrands.have_value)
              {
                result.initBrands();
                int count = fieldGeneratorBrands.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendBrands(fieldGeneratorBrands.value[num]);
                  }
                fieldGeneratorBrands.value.Clear();
                fieldGeneratorBrands.have_value = false;
              }
          }
        protected abstract void handle_result(RetailUploadedCatalogDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Brands", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorBrands;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorBrands = new RetailUploadedAttributeDataJSON.HoldingArrayGenerator("field \"Brands\" of the RetailUploadedCatalogData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RetailUploadedCatalogData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorBrands = new RetailUploadedAttributeDataJSON.HoldingArrayGenerator("field \"Brands\" of the RetailUploadedCatalogData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RetailUploadedCatalogData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorBrands.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorBrands.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorBrands.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RetailUploadedCatalogDataJSON  result)
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
        public RetailUploadedCatalogDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RetailUploadedCatalogDataJSON  result)
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
    protected virtual void handle_result(List<RetailUploadedCatalogDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RetailUploadedCatalogDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RetailUploadedCatalogDataJSON>();
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
    public List<RetailUploadedCatalogDataJSON> value;
  };
  };
