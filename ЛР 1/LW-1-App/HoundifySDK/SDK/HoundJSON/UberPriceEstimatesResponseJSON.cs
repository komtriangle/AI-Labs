/* file "UberPriceEstimatesResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberPriceEstimatesResponseJSON : JSONBase
  {
    private bool flagHasprices;
    private List< UberPriceEstimateDetailsJSON  > storeprices;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONprices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field prices of UberPriceEstimatesResponseJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< UberPriceEstimateDetailsJSON  > vector_prices1 = new List< UberPriceEstimateDetailsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UberPriceEstimateDetailsJSON convert_classy = UberPriceEstimateDetailsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_prices1.Add(convert_classy);
          }
        initprices();
        for (int num1 = 0; num1 < vector_prices1.Count; ++num1)
            appendprices(vector_prices1[num1]);
        for (int num1 = 0; num1 < vector_prices1.Count; ++num1)
          {
          }
      }


    public UberPriceEstimatesResponseJSON()
      {
        flagHasprices = false;
        storeprices = new List< UberPriceEstimateDetailsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasprices()
      {
        return flagHasprices;
      }

    public int  countOfprices()
      {
        Debug.Assert(flagHasprices);
        return storeprices.Count;
      }

    public UberPriceEstimateDetailsJSON   elementOfprices(int element_num)
      {
        Debug.Assert(flagHasprices);
        return storeprices[element_num];
      }

    public List< UberPriceEstimateDetailsJSON  >  getprices()
      {
        Debug.Assert(flagHasprices);
        return storeprices;
      }


    public virtual int extraUberPriceEstimatesResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberPriceEstimatesResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberPriceEstimatesResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberPriceEstimatesResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initprices()
      {
        if (flagHasprices)
          {
            for (int num1 = 0; num1 < storeprices.Count; ++num1)
              {
              }
          }
        flagHasprices = true;
        storeprices.Clear();
      }
    public void appendprices(UberPriceEstimateDetailsJSON  to_append)
      {
        if (!flagHasprices)
          {
            flagHasprices = true;
            storeprices.Clear();
          }
        Debug.Assert(flagHasprices);
        storeprices.Add(to_append);
      }
    public void unsetprices()
      {
        if (flagHasprices)
          {
            for (int num2 = 0; num2 < storeprices.Count; ++num2)
              {
              }
          }
        flagHasprices = false;
        storeprices.Clear();
      }

    public virtual void extraUberPriceEstimatesResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberPriceEstimatesResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberPriceEstimatesResponseLookup(key);
        if (old_field == null)
          {
            extraUberPriceEstimatesResponseAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasprices);
        if (flagHasprices)
          {
            handler.start_pair("prices");
            handler.start_array();
            for (int num1 = 0; num1 < storeprices.Count; ++num1)
              {
                if (partial_allowed)
                    storeprices[num1].write_partial_as_json(handler);
                else
                    storeprices[num1].write_as_json(handler);
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
        if (!(hasprices()))
          {
            return "When parsing the object for %what%, the \"prices\" field was missing.";
          }
        return null;
      }

    public static UberPriceEstimatesResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberPriceEstimatesResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberPriceEstimatesResponse", ignore_extras);
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
    public static UberPriceEstimatesResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberPriceEstimatesResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberPriceEstimatesResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberPriceEstimatesResponse", ignore_extras);
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
    public static UberPriceEstimatesResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberPriceEstimatesResponseJSON from_text(string text, bool ignore_extras)
      {
        UberPriceEstimatesResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberPriceEstimatesResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberPriceEstimatesResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberPriceEstimatesResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberPriceEstimatesResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberPriceEstimatesResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private UberPriceEstimateDetailsJSON.HoldingArrayGenerator fieldGeneratorprices;
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
            UberPriceEstimatesResponseJSON result = new UberPriceEstimatesResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberPriceEstimatesResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberPriceEstimatesResponseJSON result)
          {
            if (fieldGeneratorprices.have_value)
              {
                result.initprices();
                int count = fieldGeneratorprices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendprices(fieldGeneratorprices.value[num]);
                  }
                fieldGeneratorprices.value.Clear();
                fieldGeneratorprices.have_value = false;
              }
            else if ((!(result.hasprices())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"prices\" field was missing.");
              }
          }
        protected abstract void handle_result(UberPriceEstimatesResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "prices", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorprices;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorprices = new UberPriceEstimateDetailsJSON.HoldingArrayGenerator("field \"prices\" of the UberPriceEstimatesResponse class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberPriceEstimatesResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorprices = new UberPriceEstimateDetailsJSON.HoldingArrayGenerator("field \"prices\" of the UberPriceEstimatesResponse class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberPriceEstimatesResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorprices.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorprices.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorprices.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UberPriceEstimatesResponseJSON  result)
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
        public UberPriceEstimatesResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberPriceEstimatesResponseJSON  result)
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
    protected virtual void handle_result(List<UberPriceEstimatesResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberPriceEstimatesResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberPriceEstimatesResponseJSON>();
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
    public List<UberPriceEstimatesResponseJSON> value;
  };
  };
