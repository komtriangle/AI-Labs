/* file "UberProductsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberProductsInformationNuggetJSON : UberInformationNuggetJSON
  {
    private bool flagHasUberProductsSpec;
    private UberProductsSpecJSON  storeUberProductsSpec;
    private bool flagHasUberProducts;
    private UberCompositeProductsJSON  storeUberProducts;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraUberProductsSpecToJSON()
      {
        JSONValueHandler handler_UberProductsSpec = new JSONValueHandler();
        storeUberProductsSpec.write_as_json(handler_UberProductsSpec);
        return handler_UberProductsSpec.result;
      }

    private JSONValue  extraUberProductsToJSON()
      {
        JSONValueHandler handler_UberProducts = new JSONValueHandler();
        storeUberProducts.write_as_json(handler_UberProducts);
        return handler_UberProducts.result;
      }


    private void  fromJSONUberProductsSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberProductsSpecJSON convert_classy = UberProductsSpecJSON.from_json(json_value, ignore_extras, true);
        setUberProductsSpec(convert_classy);
      }


    private void  fromJSONUberProducts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberCompositeProductsJSON convert_classy = UberCompositeProductsJSON.from_json(json_value, ignore_extras, true);
        setUberProducts(convert_classy);
      }


    public UberProductsInformationNuggetJSON()
      {
        flagHasUberProductsSpec = false;
        flagHasUberProducts = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getUberNuggetKind()
      {
        return "UberProducts";
      }

    public bool  hasUberProductsSpec()
      {
        return flagHasUberProductsSpec;
      }

    public UberProductsSpecJSON   getUberProductsSpec()
      {
        Debug.Assert(flagHasUberProductsSpec);
        return storeUberProductsSpec;
      }

    public bool  hasUberProducts()
      {
        return flagHasUberProducts;
      }

    public UberCompositeProductsJSON   getUberProducts()
      {
        Debug.Assert(flagHasUberProducts);
        return storeUberProducts;
      }


    public virtual int extraUberProductsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberProductsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberProductsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberProductsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUberInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasUberProductsSpec)
            ++result;
        if (flagHasUberProducts)
            ++result;
        result += extraUberProductsInformationNuggetComponentCount();
        return result;
      }
    public override string extraUberInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasUberProductsSpec)
          {
            if (remainder == 0)
                return "UberProductsSpec";
            --remainder;
          }
        if (flagHasUberProducts)
          {
            if (remainder == 0)
                return "UberProducts";
            --remainder;
          }
        return extraUberProductsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraUberInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasUberProductsSpec)
          {
            if (remainder == 0)
                return extraUberProductsSpecToJSON();
            --remainder;
          }
        if (flagHasUberProducts)
          {
            if (remainder == 0)
                return extraUberProductsToJSON();
            --remainder;
          }
        return extraUberProductsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraUberInformationNuggetLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "UberProducts", 0, 12, false) == 0)
          {
            if (field_name.Length == 12)
              {
                return (flagHasUberProducts ? extraUberProductsToJSON() : null);
              }
            switch (field_name[12])
              {
                case 'S':
                    if ((String.Compare(field_name, 13, "pec", 0, 3, false) == 0) && (field_name.Length == 16))
                        return (flagHasUberProductsSpec ? extraUberProductsSpecToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraUberProductsInformationNuggetLookup(field_name);
      }

    public void setUberProductsSpec(UberProductsSpecJSON  new_value)
      {
        if (flagHasUberProductsSpec)
          {
          }
        flagHasUberProductsSpec = true;
        storeUberProductsSpec = new_value;
      }
    public void unsetUberProductsSpec()
      {
        if (flagHasUberProductsSpec)
          {
          }
        flagHasUberProductsSpec = false;
      }
    public void setUberProducts(UberCompositeProductsJSON  new_value)
      {
        if (flagHasUberProducts)
          {
          }
        flagHasUberProducts = true;
        storeUberProducts = new_value;
      }
    public void unsetUberProducts()
      {
        if (flagHasUberProducts)
          {
          }
        flagHasUberProducts = false;
      }

    public virtual void extraUberProductsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberProductsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberProductsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraUberProductsInformationNuggetAppendPair(key, new_component);
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
    public override void extraUberInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "UberProducts", 0, 12, false) == 0)
          {
            if (key.Length == 12)
              {
                {
                fromJSONUberProducts(new_component, false);
                return;
                }
              }
            switch (key[12])
              {
                case 'S':
                    if ((String.Compare(key, 13, "pec", 0, 3, false) == 0) && (key.Length == 16))
                        {
                        fromJSONUberProductsSpec(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraUberProductsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraUberInformationNuggetSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "UberProducts", 0, 12, false) == 0)
          {
            if (key.Length == 12)
              {
                {
                fromJSONUberProducts(new_component, false);
                return;
                }
              }
            switch (key[12])
              {
                case 'S':
                    if ((String.Compare(key, 13, "pec", 0, 3, false) == 0) && (key.Length == 16))
                        {
                        fromJSONUberProductsSpec(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraUberProductsInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasUberProductsSpec);
        if (flagHasUberProductsSpec)
          {
            handler.start_pair("UberProductsSpec");
            if (partial_allowed)
                storeUberProductsSpec.write_partial_as_json(handler);
            else
                storeUberProductsSpec.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasUberProducts);
        if (flagHasUberProducts)
          {
            handler.start_pair("UberProducts");
            if (partial_allowed)
                storeUberProducts.write_partial_as_json(handler);
            else
                storeUberProducts.write_as_json(handler);
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
        if (!(hasUberProductsSpec()))
          {
            return "When parsing the object for %what%, the \"UberProductsSpec\" field was missing.";
          }
        if (!(hasUberProducts()))
          {
            return "When parsing the object for %what%, the \"UberProducts\" field was missing.";
          }
        return null;
      }

    public static new UberProductsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberProductsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductsInformationNugget", ignore_extras);
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
    public static new UberProductsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberProductsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberProductsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductsInformationNugget", ignore_extras);
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
    public static new UberProductsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberProductsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        UberProductsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberProductsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UberProductsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberProductsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UberInformationNuggetJSON.Generator
      {
        private UberProductsSpecJSON.HoldingGenerator fieldGeneratorUberProductsSpec;
        private UberCompositeProductsJSON.HoldingGenerator fieldGeneratorUberProducts;
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
            if (!(getUberInformationNuggetJSONKey().Equals("UberProducts")))
                throw new Exception("The key field has a value other than `UberProducts'.");
            UberProductsInformationNuggetJSON result = new UberProductsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberProductsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UberInformationNuggetJSON new_result)
          {
            handle_result((UberProductsInformationNuggetJSON )new_result);
          }
        protected void finish(UberProductsInformationNuggetJSON result)
          {
            if (fieldGeneratorUberProductsSpec.have_value)
              {
                result.setUberProductsSpec(fieldGeneratorUberProductsSpec.value);
                fieldGeneratorUberProductsSpec.have_value = false;
              }
            else if ((!(result.hasUberProductsSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UberProductsSpec\" field was missing.");
              }
            if (fieldGeneratorUberProducts.have_value)
              {
                result.setUberProducts(fieldGeneratorUberProducts.value);
                fieldGeneratorUberProducts.have_value = false;
              }
            else if ((!(result.hasUberProducts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UberProducts\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(UberProductsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "UberProducts", 0, 12, false) == 0)
              {
                if (field_name.Length == 12)
                  {
                    return fieldGeneratorUberProducts;
                  }
                switch (field_name[12])
                  {
                    case 'S':
                        if ((String.Compare(field_name, 13, "pec", 0, 3, false) == 0) && (field_name.Length == 16))
                            return fieldGeneratorUberProductsSpec;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorUberProductsSpec = new UberProductsSpecJSON.HoldingGenerator("field \"UberProductsSpec\" of the UberProductsInformationNugget class", ignore_extras);
            fieldGeneratorUberProducts = new UberCompositeProductsJSON.HoldingGenerator("field \"UberProducts\" of the UberProductsInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberProductsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorUberProductsSpec = new UberProductsSpecJSON.HoldingGenerator("field \"UberProductsSpec\" of the UberProductsInformationNugget class", false);
            fieldGeneratorUberProducts = new UberCompositeProductsJSON.HoldingGenerator("field \"UberProducts\" of the UberProductsInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberProductsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorUberProductsSpec.reset();
            fieldGeneratorUberProducts.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UberProductsInformationNuggetJSON  result)
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
        public UberProductsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberProductsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<UberProductsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberProductsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberProductsInformationNuggetJSON>();
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
    public List<UberProductsInformationNuggetJSON> value;
  };
  };
