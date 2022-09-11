/* file "BunnAvailableDrinkInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BunnAvailableDrinkInfoJSON : JSONBase
  {
    private bool flagHasType;
    private BunnDrinkTypeJSON  storeType;
    private bool flagHasSizes;
    private List< BunnDrinkSizeJSON  > storeSizes;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BunnDrinkTypeJSON convert_classy = BunnDrinkTypeJSON.from_json(json_value, ignore_extras, true);
        setType(convert_classy);
      }


    private void  fromJSONSizes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Sizes of BunnAvailableDrinkInfoJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BunnDrinkSizeJSON  > vector_Sizes1 = new List< BunnDrinkSizeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BunnDrinkSizeJSON convert_classy = BunnDrinkSizeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Sizes1.Add(convert_classy);
          }
        initSizes();
        for (int num1 = 0; num1 < vector_Sizes1.Count; ++num1)
            appendSizes(vector_Sizes1[num1]);
        for (int num1 = 0; num1 < vector_Sizes1.Count; ++num1)
          {
          }
      }


    public BunnAvailableDrinkInfoJSON()
      {
        flagHasType = false;
        flagHasSizes = false;
        storeSizes = new List< BunnDrinkSizeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public BunnDrinkTypeJSON   getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public BunnDrinkTypeJSON.TypeValue  getTypeValue()
      {
        return getType().getValue();
      }

    public string  getTypeAsString()
      {
        return getType().getValueAsString();
      }

    public bool  hasSizes()
      {
        return flagHasSizes;
      }

    public int  countOfSizes()
      {
        Debug.Assert(flagHasSizes);
        return storeSizes.Count;
      }

    public BunnDrinkSizeJSON   elementOfSizes(int element_num)
      {
        Debug.Assert(flagHasSizes);
        return storeSizes[element_num];
      }

    public List< BunnDrinkSizeJSON  >  getSizes()
      {
        Debug.Assert(flagHasSizes);
        return storeSizes;
      }


    public virtual int extraBunnAvailableDrinkInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBunnAvailableDrinkInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBunnAvailableDrinkInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBunnAvailableDrinkInfoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setType(BunnDrinkTypeJSON  new_value)
      {
        if (flagHasType)
          {
          }
        flagHasType = true;
        storeType = new_value;
      }
    public void setType(BunnDrinkTypeJSON.TypeValue new_value)
      {
        setType(new BunnDrinkTypeJSON(new_value));
      }
    public void setType(string chars)
      {
        BunnDrinkTypeJSON.TypeValueKnownValues known = BunnDrinkTypeJSON.stringToValue(chars);
        BunnDrinkTypeJSON.TypeValue new_value = new BunnDrinkTypeJSON.TypeValue();
        if (known == BunnDrinkTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setType(new_value);
      }
    public void unsetType()
      {
        if (flagHasType)
          {
          }
        flagHasType = false;
      }
    public void initSizes()
      {
        if (flagHasSizes)
          {
            for (int num1 = 0; num1 < storeSizes.Count; ++num1)
              {
              }
          }
        flagHasSizes = true;
        storeSizes.Clear();
      }
    public void appendSizes(BunnDrinkSizeJSON  to_append)
      {
        if (!flagHasSizes)
          {
            flagHasSizes = true;
            storeSizes.Clear();
          }
        Debug.Assert(flagHasSizes);
        storeSizes.Add(to_append);
      }
    public void appendSizes(BunnDrinkSizeJSON.TypeValue new_value)
      {
        appendSizes(new BunnDrinkSizeJSON(new_value));
      }
    public void appendSizes(string chars)
      {
        BunnDrinkSizeJSON.TypeValueKnownValues known = BunnDrinkSizeJSON.stringToValue(chars);
        BunnDrinkSizeJSON.TypeValue new_value = new BunnDrinkSizeJSON.TypeValue();
        if (known == BunnDrinkSizeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendSizes(new_value);
      }
    public void unsetSizes()
      {
        if (flagHasSizes)
          {
            for (int num2 = 0; num2 < storeSizes.Count; ++num2)
              {
              }
          }
        flagHasSizes = false;
        storeSizes.Clear();
      }

    public virtual void extraBunnAvailableDrinkInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBunnAvailableDrinkInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBunnAvailableDrinkInfoLookup(key);
        if (old_field == null)
          {
            extraBunnAvailableDrinkInfoAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasType);
        if (flagHasType)
          {
            handler.start_pair("Type");
            if (partial_allowed)
                storeType.write_partial_as_json(handler);
            else
                storeType.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasSizes);
        if (flagHasSizes)
          {
            handler.start_pair("Sizes");
            handler.start_array();
            for (int num1 = 0; num1 < storeSizes.Count; ++num1)
              {
                if (partial_allowed)
                    storeSizes[num1].write_partial_as_json(handler);
                else
                    storeSizes[num1].write_as_json(handler);
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
        if (!(hasType()))
          {
            return "When parsing the object for %what%, the \"Type\" field was missing.";
          }
        if (!(hasSizes()))
          {
            return "When parsing the object for %what%, the \"Sizes\" field was missing.";
          }
        return null;
      }

    public static BunnAvailableDrinkInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BunnAvailableDrinkInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BunnAvailableDrinkInfo", ignore_extras);
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
    public static BunnAvailableDrinkInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BunnAvailableDrinkInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BunnAvailableDrinkInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BunnAvailableDrinkInfo", ignore_extras);
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
    public static BunnAvailableDrinkInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BunnAvailableDrinkInfoJSON from_text(string text, bool ignore_extras)
      {
        BunnAvailableDrinkInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BunnAvailableDrinkInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BunnAvailableDrinkInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BunnAvailableDrinkInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BunnAvailableDrinkInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BunnAvailableDrinkInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private BunnDrinkTypeJSON.HoldingGenerator fieldGeneratorType;
        private BunnDrinkSizeJSON.HoldingArrayGenerator fieldGeneratorSizes;
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
            BunnAvailableDrinkInfoJSON result = new BunnAvailableDrinkInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBunnAvailableDrinkInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BunnAvailableDrinkInfoJSON result)
          {
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
            else if ((!(result.hasType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Type\" field was missing.");
              }
            if (fieldGeneratorSizes.have_value)
              {
                result.initSizes();
                int count = fieldGeneratorSizes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSizes(fieldGeneratorSizes.value[num]);
                  }
                fieldGeneratorSizes.value.Clear();
                fieldGeneratorSizes.have_value = false;
              }
            else if ((!(result.hasSizes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Sizes\" field was missing.");
              }
          }
        protected abstract void handle_result(BunnAvailableDrinkInfoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'S':
                    if ((String.Compare(field_name, 1, "izes", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorSizes;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorType;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorType = new BunnDrinkTypeJSON.HoldingGenerator("field \"Type\" of the BunnAvailableDrinkInfo class", ignore_extras);
            fieldGeneratorSizes = new BunnDrinkSizeJSON.HoldingArrayGenerator("field \"Sizes\" of the BunnAvailableDrinkInfo class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BunnAvailableDrinkInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorType = new BunnDrinkTypeJSON.HoldingGenerator("field \"Type\" of the BunnAvailableDrinkInfo class", false);
            fieldGeneratorSizes = new BunnDrinkSizeJSON.HoldingArrayGenerator("field \"Sizes\" of the BunnAvailableDrinkInfo class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BunnAvailableDrinkInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorType.reset();
            fieldGeneratorSizes.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSizes.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSizes.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(BunnAvailableDrinkInfoJSON  result)
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
        public BunnAvailableDrinkInfoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BunnAvailableDrinkInfoJSON  result)
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
    protected virtual void handle_result(List<BunnAvailableDrinkInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BunnAvailableDrinkInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BunnAvailableDrinkInfoJSON>();
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
    public List<BunnAvailableDrinkInfoJSON> value;
  };
  };
