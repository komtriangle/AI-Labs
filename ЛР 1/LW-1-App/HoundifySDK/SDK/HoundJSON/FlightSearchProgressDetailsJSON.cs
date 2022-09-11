/* file "FlightSearchProgressDetailsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FlightSearchProgressDetailsJSON : JSONBase
  {
    private bool flagHasSearchComplete;
    private bool storeSearchComplete;
    private bool flagHasProgressUpdateCount;
    private BigInteger storeProgressUpdateCount;
    private bool flagHasWaitingForDataProviders;
    private List< FlightDataProviderJSON  > storeWaitingForDataProviders;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSearchComplete(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SearchComplete of FlightSearchProgressDetailsJSON is not true for false.");
              }
          }
        setSearchComplete(the_bool);
      }


    private void  fromJSONProgressUpdateCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ProgressUpdateCount of FlightSearchProgressDetailsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ProgressUpdateCount of FlightSearchProgressDetailsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setProgressUpdateCount(extracted_integer);
      }


    private void  fromJSONWaitingForDataProviders(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field WaitingForDataProviders of FlightSearchProgressDetailsJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field WaitingForDataProviders of FlightSearchProgressDetailsJSON has too few elements.");
        List< FlightDataProviderJSON  > vector_WaitingForDataProviders1 = new List< FlightDataProviderJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightDataProviderJSON convert_classy = FlightDataProviderJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_WaitingForDataProviders1.Add(convert_classy);
          }
        Debug.Assert(vector_WaitingForDataProviders1.Count >= 1);
        initWaitingForDataProviders();
        for (int num1 = 0; num1 < vector_WaitingForDataProviders1.Count; ++num1)
            appendWaitingForDataProviders(vector_WaitingForDataProviders1[num1]);
        for (int num1 = 0; num1 < vector_WaitingForDataProviders1.Count; ++num1)
          {
          }
      }


    public FlightSearchProgressDetailsJSON()
      {
        flagHasSearchComplete = false;
        flagHasProgressUpdateCount = false;
        flagHasWaitingForDataProviders = false;
        storeWaitingForDataProviders = new List< FlightDataProviderJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSearchComplete()
      {
        return flagHasSearchComplete;
      }

    public bool  getSearchComplete()
      {
        Debug.Assert(flagHasSearchComplete);
        return storeSearchComplete;
      }

    public bool  hasProgressUpdateCount()
      {
        return flagHasProgressUpdateCount;
      }

    public BigInteger  getProgressUpdateCount()
      {
        Debug.Assert(flagHasProgressUpdateCount);
        return storeProgressUpdateCount;
      }

    public bool  hasWaitingForDataProviders()
      {
        return flagHasWaitingForDataProviders;
      }

    public int  countOfWaitingForDataProviders()
      {
        Debug.Assert(flagHasWaitingForDataProviders);
        return storeWaitingForDataProviders.Count;
      }

    public FlightDataProviderJSON   elementOfWaitingForDataProviders(int element_num)
      {
        Debug.Assert(flagHasWaitingForDataProviders);
        return storeWaitingForDataProviders[element_num];
      }

    public List< FlightDataProviderJSON  >  getWaitingForDataProviders()
      {
        Debug.Assert(flagHasWaitingForDataProviders);
        return storeWaitingForDataProviders;
      }


    public virtual int extraFlightSearchProgressDetailsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightSearchProgressDetailsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightSearchProgressDetailsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightSearchProgressDetailsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSearchComplete(bool new_value)
      {
        flagHasSearchComplete = true;
        storeSearchComplete = new_value;
      }
    public void unsetSearchComplete()
      {
        flagHasSearchComplete = false;
      }
    public void setProgressUpdateCount(BigInteger new_value)
      {
        flagHasProgressUpdateCount = true;
        if (new_value < 1)
            throw new Exception("The value for field ProgressUpdateCount of FlightSearchProgressDetailsJSON is less than the lower bound (1) for that field.");
        storeProgressUpdateCount = new_value;
      }
    public void unsetProgressUpdateCount()
      {
        flagHasProgressUpdateCount = false;
      }
    public void initWaitingForDataProviders()
      {
        if (flagHasWaitingForDataProviders)
          {
            for (int num1 = 0; num1 < storeWaitingForDataProviders.Count; ++num1)
              {
              }
          }
        flagHasWaitingForDataProviders = true;
        storeWaitingForDataProviders.Clear();
      }
    public void appendWaitingForDataProviders(FlightDataProviderJSON  to_append)
      {
        if (!flagHasWaitingForDataProviders)
          {
            flagHasWaitingForDataProviders = true;
            storeWaitingForDataProviders.Clear();
          }
        Debug.Assert(flagHasWaitingForDataProviders);
        storeWaitingForDataProviders.Add(to_append);
      }
    public void unsetWaitingForDataProviders()
      {
        if (flagHasWaitingForDataProviders)
          {
            for (int num2 = 0; num2 < storeWaitingForDataProviders.Count; ++num2)
              {
              }
          }
        flagHasWaitingForDataProviders = false;
        storeWaitingForDataProviders.Clear();
      }

    public virtual void extraFlightSearchProgressDetailsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightSearchProgressDetailsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightSearchProgressDetailsLookup(key);
        if (old_field == null)
          {
            extraFlightSearchProgressDetailsAppendPair(key, new_component);
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
        if (flagHasSearchComplete)
          {
            handler.start_pair("SearchComplete");
            handler.boolean_value(storeSearchComplete);
          }
        if (flagHasProgressUpdateCount)
          {
            handler.start_pair("ProgressUpdateCount");
            handler.number_value(storeProgressUpdateCount);
          }
        if (flagHasWaitingForDataProviders)
          {
            handler.start_pair("WaitingForDataProviders");
            Debug.Assert(storeWaitingForDataProviders.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeWaitingForDataProviders.Count; ++num1)
              {
                if (partial_allowed)
                    storeWaitingForDataProviders[num1].write_partial_as_json(handler);
                else
                    storeWaitingForDataProviders[num1].write_as_json(handler);
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

    public static FlightSearchProgressDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSearchProgressDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSearchProgressDetails", ignore_extras);
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
    public static FlightSearchProgressDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSearchProgressDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSearchProgressDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSearchProgressDetails", ignore_extras);
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
    public static FlightSearchProgressDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSearchProgressDetailsJSON from_text(string text, bool ignore_extras)
      {
        FlightSearchProgressDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSearchProgressDetails", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightSearchProgressDetailsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightSearchProgressDetailsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightSearchProgressDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSearchProgressDetails", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorSearchComplete;
    private class FieldHoldingGeneratorProgressUpdateCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorProgressUpdateCount(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorProgressUpdateCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorProgressUpdateCount(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorProgressUpdateCount fieldGeneratorProgressUpdateCount;
        private FlightDataProviderJSON.HoldingArrayGenerator fieldGeneratorWaitingForDataProviders;
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
            FlightSearchProgressDetailsJSON result = new FlightSearchProgressDetailsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightSearchProgressDetailsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightSearchProgressDetailsJSON result)
          {
            if (fieldGeneratorSearchComplete.have_value)
              {
                result.setSearchComplete(fieldGeneratorSearchComplete.value);
                fieldGeneratorSearchComplete.have_value = false;
              }
            if (fieldGeneratorProgressUpdateCount.have_value)
              {
                result.setProgressUpdateCount(fieldGeneratorProgressUpdateCount.value);
                fieldGeneratorProgressUpdateCount.have_value = false;
              }
            if (fieldGeneratorWaitingForDataProviders.have_value)
              {
                result.initWaitingForDataProviders();
                int count = fieldGeneratorWaitingForDataProviders.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendWaitingForDataProviders(fieldGeneratorWaitingForDataProviders.value[num]);
                  }
                fieldGeneratorWaitingForDataProviders.value.Clear();
                fieldGeneratorWaitingForDataProviders.have_value = false;
              }
          }
        protected abstract void handle_result(FlightSearchProgressDetailsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'P':
                    if ((String.Compare(field_name, 1, "rogressUpdateCount", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorProgressUpdateCount;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "earchComplete", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorSearchComplete;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "aitingForDataProviders", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorWaitingForDataProviders;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSearchComplete = new JSONHoldingBooleanGenerator("field \"SearchComplete\" of the FlightSearchProgressDetails class");
            fieldGeneratorProgressUpdateCount = new FieldHoldingGeneratorProgressUpdateCount("field \"ProgressUpdateCount\" of the FlightSearchProgressDetails class");
            fieldGeneratorWaitingForDataProviders = new FlightDataProviderJSON.HoldingArrayGenerator("field \"WaitingForDataProviders\" of the FlightSearchProgressDetails class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightSearchProgressDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSearchComplete = new JSONHoldingBooleanGenerator("field \"SearchComplete\" of the FlightSearchProgressDetails class");
            fieldGeneratorProgressUpdateCount = new FieldHoldingGeneratorProgressUpdateCount("field \"ProgressUpdateCount\" of the FlightSearchProgressDetails class");
            fieldGeneratorWaitingForDataProviders = new FlightDataProviderJSON.HoldingArrayGenerator("field \"WaitingForDataProviders\" of the FlightSearchProgressDetails class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightSearchProgressDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSearchComplete.reset();
            fieldGeneratorProgressUpdateCount.reset();
            fieldGeneratorWaitingForDataProviders.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorWaitingForDataProviders.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorWaitingForDataProviders.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightSearchProgressDetailsJSON  result)
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
        public FlightSearchProgressDetailsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightSearchProgressDetailsJSON  result)
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
    protected virtual void handle_result(List<FlightSearchProgressDetailsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightSearchProgressDetailsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightSearchProgressDetailsJSON>();
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
    public List<FlightSearchProgressDetailsJSON> value;
  };
  };
