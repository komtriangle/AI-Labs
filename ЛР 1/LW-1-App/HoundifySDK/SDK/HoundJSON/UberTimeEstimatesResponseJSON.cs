/* file "UberTimeEstimatesResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberTimeEstimatesResponseJSON : JSONBase
  {
    private bool flagHastimes;
    private List< UberTimeEstimateDetailsJSON  > storetimes;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONtimes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field times of UberTimeEstimatesResponseJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< UberTimeEstimateDetailsJSON  > vector_times1 = new List< UberTimeEstimateDetailsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UberTimeEstimateDetailsJSON convert_classy = UberTimeEstimateDetailsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_times1.Add(convert_classy);
          }
        inittimes();
        for (int num1 = 0; num1 < vector_times1.Count; ++num1)
            appendtimes(vector_times1[num1]);
        for (int num1 = 0; num1 < vector_times1.Count; ++num1)
          {
          }
      }


    public UberTimeEstimatesResponseJSON()
      {
        flagHastimes = false;
        storetimes = new List< UberTimeEstimateDetailsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hastimes()
      {
        return flagHastimes;
      }

    public int  countOftimes()
      {
        Debug.Assert(flagHastimes);
        return storetimes.Count;
      }

    public UberTimeEstimateDetailsJSON   elementOftimes(int element_num)
      {
        Debug.Assert(flagHastimes);
        return storetimes[element_num];
      }

    public List< UberTimeEstimateDetailsJSON  >  gettimes()
      {
        Debug.Assert(flagHastimes);
        return storetimes;
      }


    public virtual int extraUberTimeEstimatesResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberTimeEstimatesResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberTimeEstimatesResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberTimeEstimatesResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void inittimes()
      {
        if (flagHastimes)
          {
            for (int num1 = 0; num1 < storetimes.Count; ++num1)
              {
              }
          }
        flagHastimes = true;
        storetimes.Clear();
      }
    public void appendtimes(UberTimeEstimateDetailsJSON  to_append)
      {
        if (!flagHastimes)
          {
            flagHastimes = true;
            storetimes.Clear();
          }
        Debug.Assert(flagHastimes);
        storetimes.Add(to_append);
      }
    public void unsettimes()
      {
        if (flagHastimes)
          {
            for (int num2 = 0; num2 < storetimes.Count; ++num2)
              {
              }
          }
        flagHastimes = false;
        storetimes.Clear();
      }

    public virtual void extraUberTimeEstimatesResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberTimeEstimatesResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberTimeEstimatesResponseLookup(key);
        if (old_field == null)
          {
            extraUberTimeEstimatesResponseAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHastimes);
        if (flagHastimes)
          {
            handler.start_pair("times");
            handler.start_array();
            for (int num1 = 0; num1 < storetimes.Count; ++num1)
              {
                if (partial_allowed)
                    storetimes[num1].write_partial_as_json(handler);
                else
                    storetimes[num1].write_as_json(handler);
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
        if (!(hastimes()))
          {
            return "When parsing the object for %what%, the \"times\" field was missing.";
          }
        return null;
      }

    public static UberTimeEstimatesResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberTimeEstimatesResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberTimeEstimatesResponse", ignore_extras);
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
    public static UberTimeEstimatesResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberTimeEstimatesResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberTimeEstimatesResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberTimeEstimatesResponse", ignore_extras);
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
    public static UberTimeEstimatesResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberTimeEstimatesResponseJSON from_text(string text, bool ignore_extras)
      {
        UberTimeEstimatesResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberTimeEstimatesResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberTimeEstimatesResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberTimeEstimatesResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberTimeEstimatesResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberTimeEstimatesResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private UberTimeEstimateDetailsJSON.HoldingArrayGenerator fieldGeneratortimes;
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
            UberTimeEstimatesResponseJSON result = new UberTimeEstimatesResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberTimeEstimatesResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberTimeEstimatesResponseJSON result)
          {
            if (fieldGeneratortimes.have_value)
              {
                result.inittimes();
                int count = fieldGeneratortimes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendtimes(fieldGeneratortimes.value[num]);
                  }
                fieldGeneratortimes.value.Clear();
                fieldGeneratortimes.have_value = false;
              }
            else if ((!(result.hastimes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"times\" field was missing.");
              }
          }
        protected abstract void handle_result(UberTimeEstimatesResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "times", 0, 5, false) == 0) && (field_name.Length == 5))
                return fieldGeneratortimes;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratortimes = new UberTimeEstimateDetailsJSON.HoldingArrayGenerator("field \"times\" of the UberTimeEstimatesResponse class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberTimeEstimatesResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratortimes = new UberTimeEstimateDetailsJSON.HoldingArrayGenerator("field \"times\" of the UberTimeEstimatesResponse class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberTimeEstimatesResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratortimes.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratortimes.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratortimes.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UberTimeEstimatesResponseJSON  result)
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
        public UberTimeEstimatesResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberTimeEstimatesResponseJSON  result)
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
    protected virtual void handle_result(List<UberTimeEstimatesResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberTimeEstimatesResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberTimeEstimatesResponseJSON>();
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
    public List<UberTimeEstimatesResponseJSON> value;
  };
  };
