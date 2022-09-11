/* file "UberApiResponsesJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberApiResponsesJSON : JSONBase
  {
    private bool flagHasProducts;
    private UberProductsResponseJSON  storeProducts;
    private bool flagHasPickups;
    private UberTimeEstimatesResponseJSON  storePickups;
    private bool flagHasPrices;
    private UberPriceEstimatesResponseJSON  storePrices;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONProducts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberProductsResponseJSON convert_classy = UberProductsResponseJSON.from_json(json_value, ignore_extras, true);
        setProducts(convert_classy);
      }


    private void  fromJSONPickups(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberTimeEstimatesResponseJSON convert_classy = UberTimeEstimatesResponseJSON.from_json(json_value, ignore_extras, true);
        setPickups(convert_classy);
      }


    private void  fromJSONPrices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberPriceEstimatesResponseJSON convert_classy = UberPriceEstimatesResponseJSON.from_json(json_value, ignore_extras, true);
        setPrices(convert_classy);
      }


    public UberApiResponsesJSON()
      {
        flagHasProducts = false;
        flagHasPickups = false;
        flagHasPrices = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasProducts()
      {
        return flagHasProducts;
      }

    public UberProductsResponseJSON   getProducts()
      {
        Debug.Assert(flagHasProducts);
        return storeProducts;
      }

    public bool  hasPickups()
      {
        return flagHasPickups;
      }

    public UberTimeEstimatesResponseJSON   getPickups()
      {
        Debug.Assert(flagHasPickups);
        return storePickups;
      }

    public bool  hasPrices()
      {
        return flagHasPrices;
      }

    public UberPriceEstimatesResponseJSON   getPrices()
      {
        Debug.Assert(flagHasPrices);
        return storePrices;
      }


    public virtual int extraUberApiResponsesComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberApiResponsesComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberApiResponsesComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberApiResponsesLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setProducts(UberProductsResponseJSON  new_value)
      {
        if (flagHasProducts)
          {
          }
        flagHasProducts = true;
        storeProducts = new_value;
      }
    public void unsetProducts()
      {
        if (flagHasProducts)
          {
          }
        flagHasProducts = false;
      }
    public void setPickups(UberTimeEstimatesResponseJSON  new_value)
      {
        if (flagHasPickups)
          {
          }
        flagHasPickups = true;
        storePickups = new_value;
      }
    public void unsetPickups()
      {
        if (flagHasPickups)
          {
          }
        flagHasPickups = false;
      }
    public void setPrices(UberPriceEstimatesResponseJSON  new_value)
      {
        if (flagHasPrices)
          {
          }
        flagHasPrices = true;
        storePrices = new_value;
      }
    public void unsetPrices()
      {
        if (flagHasPrices)
          {
          }
        flagHasPrices = false;
      }

    public virtual void extraUberApiResponsesAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberApiResponsesSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberApiResponsesLookup(key);
        if (old_field == null)
          {
            extraUberApiResponsesAppendPair(key, new_component);
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
        if (flagHasProducts)
          {
            handler.start_pair("Products");
            if (partial_allowed)
                storeProducts.write_partial_as_json(handler);
            else
                storeProducts.write_as_json(handler);
          }
        if (flagHasPickups)
          {
            handler.start_pair("Pickups");
            if (partial_allowed)
                storePickups.write_partial_as_json(handler);
            else
                storePickups.write_as_json(handler);
          }
        if (flagHasPrices)
          {
            handler.start_pair("Prices");
            if (partial_allowed)
                storePrices.write_partial_as_json(handler);
            else
                storePrices.write_as_json(handler);
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

    public static UberApiResponsesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberApiResponsesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberApiResponses", ignore_extras);
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
    public static UberApiResponsesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberApiResponsesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberApiResponsesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberApiResponses", ignore_extras);
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
    public static UberApiResponsesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberApiResponsesJSON from_text(string text, bool ignore_extras)
      {
        UberApiResponsesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberApiResponses", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberApiResponsesJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberApiResponsesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberApiResponsesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberApiResponses", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private UberProductsResponseJSON.HoldingGenerator fieldGeneratorProducts;
        private UberTimeEstimatesResponseJSON.HoldingGenerator fieldGeneratorPickups;
        private UberPriceEstimatesResponseJSON.HoldingGenerator fieldGeneratorPrices;
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
            UberApiResponsesJSON result = new UberApiResponsesJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberApiResponsesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberApiResponsesJSON result)
          {
            if (fieldGeneratorProducts.have_value)
              {
                result.setProducts(fieldGeneratorProducts.value);
                fieldGeneratorProducts.have_value = false;
              }
            if (fieldGeneratorPickups.have_value)
              {
                result.setPickups(fieldGeneratorPickups.value);
                fieldGeneratorPickups.have_value = false;
              }
            if (fieldGeneratorPrices.have_value)
              {
                result.setPrices(fieldGeneratorPrices.value);
                fieldGeneratorPrices.have_value = false;
              }
          }
        protected abstract void handle_result(UberApiResponsesJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "P", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'i':
                        if ((String.Compare(field_name, 2, "ckups", 0, 5, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorPickups;
                        break;
                    case 'r':
                        switch (field_name[2])
                          {
                            case 'i':
                                if ((String.Compare(field_name, 3, "ces", 0, 3, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorPrices;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 3, "ducts", 0, 5, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorProducts;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorProducts = new UberProductsResponseJSON.HoldingGenerator("field \"Products\" of the UberApiResponses class", ignore_extras);
            fieldGeneratorPickups = new UberTimeEstimatesResponseJSON.HoldingGenerator("field \"Pickups\" of the UberApiResponses class", ignore_extras);
            fieldGeneratorPrices = new UberPriceEstimatesResponseJSON.HoldingGenerator("field \"Prices\" of the UberApiResponses class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberApiResponses class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorProducts = new UberProductsResponseJSON.HoldingGenerator("field \"Products\" of the UberApiResponses class", false);
            fieldGeneratorPickups = new UberTimeEstimatesResponseJSON.HoldingGenerator("field \"Pickups\" of the UberApiResponses class", false);
            fieldGeneratorPrices = new UberPriceEstimatesResponseJSON.HoldingGenerator("field \"Prices\" of the UberApiResponses class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberApiResponses class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorProducts.reset();
            fieldGeneratorPickups.reset();
            fieldGeneratorPrices.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorProducts.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPickups.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPrices.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorProducts.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPickups.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPrices.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UberApiResponsesJSON  result)
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
        public UberApiResponsesJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberApiResponsesJSON  result)
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
    protected virtual void handle_result(List<UberApiResponsesJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberApiResponsesJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberApiResponsesJSON>();
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
    public List<UberApiResponsesJSON> value;
  };
  };
