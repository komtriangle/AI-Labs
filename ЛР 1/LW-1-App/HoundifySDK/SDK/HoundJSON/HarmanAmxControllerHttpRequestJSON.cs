/* file "HarmanAmxControllerHttpRequestJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HarmanAmxControllerHttpRequestJSON : JSONBase
  {
    public class TypeContentJSON : JSONBase
      {
        private bool flagHasoccurredOn;
        private BigInteger storeoccurredOn;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONoccurredOn(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field occurredOn of TypeContentJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field occurredOn of TypeContentJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setoccurredOn(extracted_integer);
          }


        public TypeContentJSON()
          {
            flagHasoccurredOn = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasoccurredOn()
          {
            return flagHasoccurredOn;
          }

        public BigInteger  getoccurredOn()
          {
            Debug.Assert(flagHasoccurredOn);
            return storeoccurredOn;
          }


        public virtual int extraTypeContentComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeContentComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeContentComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeContentLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setoccurredOn(BigInteger new_value)
          {
            flagHasoccurredOn = true;
            storeoccurredOn = new_value;
          }
        public void unsetoccurredOn()
          {
            flagHasoccurredOn = false;
          }

        public virtual void extraTypeContentAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeContentSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeContentLookup(key);
            if (old_field == null)
              {
                extraTypeContentAppendPair(key, new_component);
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
            if (flagHasoccurredOn)
              {
                handler.start_pair("occurredOn");
                handler.number_value(storeoccurredOn);
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

        public static TypeContentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeContentJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeContent", ignore_extras);
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
        public static TypeContentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeContentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeContentJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeContent", ignore_extras);
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
        public static TypeContentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeContentJSON from_text(string text, bool ignore_extras)
          {
            TypeContentJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeContent", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeContentJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeContentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeContentJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeContent", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratoroccurredOn : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratoroccurredOn(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratoroccurredOn : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratoroccurredOn(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratoroccurredOn fieldGeneratoroccurredOn;
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
                TypeContentJSON result = new TypeContentJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeContentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeContentJSON result)
              {
                if (fieldGeneratoroccurredOn.have_value)
                  {
                    result.setoccurredOn(fieldGeneratoroccurredOn.value);
                    fieldGeneratoroccurredOn.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeContentJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "occurredOn", 0, 10, false) == 0) && (field_name.Length == 10))
                    return fieldGeneratoroccurredOn;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratoroccurredOn = new FieldHoldingGeneratoroccurredOn("field \"occurredOn\" of the TypeContent class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeContent class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratoroccurredOn = new FieldHoldingGeneratoroccurredOn("field \"occurredOn\" of the TypeContent class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeContent class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratoroccurredOn.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeContentJSON  result)
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
            public TypeContentJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeContentJSON  result)
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
        protected virtual void handle_result(List<TypeContentJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeContentJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeContentJSON>();
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
        public List<TypeContentJSON> value;
      };
      };
    private bool flagHasViaHCSCloud;
    private bool storeViaHCSCloud;
    private bool flagHasHeaders;
    private List< HttpParameterJSON  > storeHeaders;
    private bool flagHasContent;
    private TypeContentJSON  storeContent;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONViaHCSCloud(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ViaHCSCloud of HarmanAmxControllerHttpRequestJSON is not true for false.");
              }
          }
        setViaHCSCloud(the_bool);
      }


    private void  fromJSONHeaders(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Headers of HarmanAmxControllerHttpRequestJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Headers of HarmanAmxControllerHttpRequestJSON has too few elements.");
        List< HttpParameterJSON  > vector_Headers1 = new List< HttpParameterJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HttpParameterJSON convert_classy = HttpParameterJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Headers1.Add(convert_classy);
          }
        Debug.Assert(vector_Headers1.Count >= 1);
        initHeaders();
        for (int num1 = 0; num1 < vector_Headers1.Count; ++num1)
            appendHeaders(vector_Headers1[num1]);
        for (int num1 = 0; num1 < vector_Headers1.Count; ++num1)
          {
          }
      }


    private void  fromJSONContent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeContentJSON convert_classy = TypeContentJSON.from_json(json_value, ignore_extras, true);
        setContent(convert_classy);
      }


    public HarmanAmxControllerHttpRequestJSON()
      {
        flagHasViaHCSCloud = false;
        flagHasHeaders = false;
        flagHasContent = false;
        storeHeaders = new List< HttpParameterJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasViaHCSCloud()
      {
        return flagHasViaHCSCloud;
      }

    public bool  getViaHCSCloud()
      {
        Debug.Assert(flagHasViaHCSCloud);
        return storeViaHCSCloud;
      }

    public bool  hasHeaders()
      {
        return flagHasHeaders;
      }

    public int  countOfHeaders()
      {
        Debug.Assert(flagHasHeaders);
        return storeHeaders.Count;
      }

    public HttpParameterJSON   elementOfHeaders(int element_num)
      {
        Debug.Assert(flagHasHeaders);
        return storeHeaders[element_num];
      }

    public List< HttpParameterJSON  >  getHeaders()
      {
        Debug.Assert(flagHasHeaders);
        return storeHeaders;
      }

    public bool  hasContent()
      {
        return flagHasContent;
      }

    public TypeContentJSON   getContent()
      {
        Debug.Assert(flagHasContent);
        return storeContent;
      }


    public virtual int extraHarmanAmxControllerHttpRequestComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHarmanAmxControllerHttpRequestComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHarmanAmxControllerHttpRequestComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHarmanAmxControllerHttpRequestLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setViaHCSCloud(bool new_value)
      {
        flagHasViaHCSCloud = true;
        storeViaHCSCloud = new_value;
      }
    public void unsetViaHCSCloud()
      {
        flagHasViaHCSCloud = false;
      }
    public void initHeaders()
      {
        if (flagHasHeaders)
          {
            for (int num1 = 0; num1 < storeHeaders.Count; ++num1)
              {
              }
          }
        flagHasHeaders = true;
        storeHeaders.Clear();
      }
    public void appendHeaders(HttpParameterJSON  to_append)
      {
        if (!flagHasHeaders)
          {
            flagHasHeaders = true;
            storeHeaders.Clear();
          }
        Debug.Assert(flagHasHeaders);
        storeHeaders.Add(to_append);
      }
    public void unsetHeaders()
      {
        if (flagHasHeaders)
          {
            for (int num2 = 0; num2 < storeHeaders.Count; ++num2)
              {
              }
          }
        flagHasHeaders = false;
        storeHeaders.Clear();
      }
    public void setContent(TypeContentJSON  new_value)
      {
        if (flagHasContent)
          {
          }
        flagHasContent = true;
        storeContent = new_value;
      }
    public void unsetContent()
      {
        if (flagHasContent)
          {
          }
        flagHasContent = false;
      }

    public virtual void extraHarmanAmxControllerHttpRequestAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHarmanAmxControllerHttpRequestSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHarmanAmxControllerHttpRequestLookup(key);
        if (old_field == null)
          {
            extraHarmanAmxControllerHttpRequestAppendPair(key, new_component);
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
        if (flagHasViaHCSCloud)
          {
            handler.start_pair("ViaHCSCloud");
            handler.boolean_value(storeViaHCSCloud);
          }
        if (flagHasHeaders)
          {
            handler.start_pair("Headers");
            Debug.Assert(storeHeaders.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeHeaders.Count; ++num1)
              {
                if (partial_allowed)
                    storeHeaders[num1].write_partial_as_json(handler);
                else
                    storeHeaders[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasContent)
          {
            handler.start_pair("Content");
            if (partial_allowed)
                storeContent.write_partial_as_json(handler);
            else
                storeContent.write_as_json(handler);
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

    public static HarmanAmxControllerHttpRequestJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanAmxControllerHttpRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanAmxControllerHttpRequest", ignore_extras);
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
    public static HarmanAmxControllerHttpRequestJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanAmxControllerHttpRequestJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanAmxControllerHttpRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanAmxControllerHttpRequest", ignore_extras);
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
    public static HarmanAmxControllerHttpRequestJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanAmxControllerHttpRequestJSON from_text(string text, bool ignore_extras)
      {
        HarmanAmxControllerHttpRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanAmxControllerHttpRequest", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HarmanAmxControllerHttpRequestJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HarmanAmxControllerHttpRequestJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HarmanAmxControllerHttpRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanAmxControllerHttpRequest", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorViaHCSCloud;
        private HttpParameterJSON.HoldingArrayGenerator fieldGeneratorHeaders;
        private TypeContentJSON.HoldingGenerator fieldGeneratorContent;
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
            HarmanAmxControllerHttpRequestJSON result = new HarmanAmxControllerHttpRequestJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHarmanAmxControllerHttpRequestAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HarmanAmxControllerHttpRequestJSON result)
          {
            if (fieldGeneratorViaHCSCloud.have_value)
              {
                result.setViaHCSCloud(fieldGeneratorViaHCSCloud.value);
                fieldGeneratorViaHCSCloud.have_value = false;
              }
            if (fieldGeneratorHeaders.have_value)
              {
                result.initHeaders();
                int count = fieldGeneratorHeaders.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHeaders(fieldGeneratorHeaders.value[num]);
                  }
                fieldGeneratorHeaders.value.Clear();
                fieldGeneratorHeaders.have_value = false;
              }
            if (fieldGeneratorContent.have_value)
              {
                result.setContent(fieldGeneratorContent.value);
                fieldGeneratorContent.have_value = false;
              }
          }
        protected abstract void handle_result(HarmanAmxControllerHttpRequestJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ontent", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorContent;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "eaders", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorHeaders;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "iaHCSCloud", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorViaHCSCloud;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorViaHCSCloud = new JSONHoldingBooleanGenerator("field \"ViaHCSCloud\" of the HarmanAmxControllerHttpRequest class");
            fieldGeneratorHeaders = new HttpParameterJSON.HoldingArrayGenerator("field \"Headers\" of the HarmanAmxControllerHttpRequest class", ignore_extras);
            fieldGeneratorContent = new TypeContentJSON.HoldingGenerator("field \"Content\" of the HarmanAmxControllerHttpRequest class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HarmanAmxControllerHttpRequest class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorViaHCSCloud = new JSONHoldingBooleanGenerator("field \"ViaHCSCloud\" of the HarmanAmxControllerHttpRequest class");
            fieldGeneratorHeaders = new HttpParameterJSON.HoldingArrayGenerator("field \"Headers\" of the HarmanAmxControllerHttpRequest class", false);
            fieldGeneratorContent = new TypeContentJSON.HoldingGenerator("field \"Content\" of the HarmanAmxControllerHttpRequest class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HarmanAmxControllerHttpRequest class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorViaHCSCloud.reset();
            fieldGeneratorHeaders.reset();
            fieldGeneratorContent.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorHeaders.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorContent.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorHeaders.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorContent.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HarmanAmxControllerHttpRequestJSON  result)
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
        public HarmanAmxControllerHttpRequestJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HarmanAmxControllerHttpRequestJSON  result)
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
    protected virtual void handle_result(List<HarmanAmxControllerHttpRequestJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HarmanAmxControllerHttpRequestJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HarmanAmxControllerHttpRequestJSON>();
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
    public List<HarmanAmxControllerHttpRequestJSON> value;
  };
  };
