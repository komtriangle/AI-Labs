/* file "TopicIdentificationResultsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TopicIdentificationResultsJSON : JSONBase
  {
    public class TypeValueJSON : JSONBase
      {
        private bool flagHasTopic;
        private string storeTopic;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTopic(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Topic of TypeValueJSON is not a string.");
            setTopic(json_string.getData());
          }


        public TypeValueJSON()
          {
            flagHasTopic = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasTopic()
          {
            return flagHasTopic;
          }

        public string  getTopic()
          {
            Debug.Assert(flagHasTopic);
            return storeTopic;
          }


        public virtual int extraTypeValueComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeValueComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeValueComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeValueLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setTopic(string new_value)
          {
            flagHasTopic = true;
            storeTopic = new_value;
          }
        public void unsetTopic()
          {
            flagHasTopic = false;
          }

        public virtual void extraTypeValueAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeValueSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeValueLookup(key);
            if (old_field == null)
              {
                extraTypeValueAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasTopic);
            if (flagHasTopic)
              {
                handler.start_pair("Topic");
                handler.string_value(storeTopic);
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
            if (!(hasTopic()))
              {
                return "When parsing the object for %what%, the \"Topic\" field was missing.";
              }
            return null;
          }

        public static TypeValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
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
        public static TypeValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
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
        public static TypeValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeValueJSON from_text(string text, bool ignore_extras)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeValueJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeValueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorTopic;
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
                TypeValueJSON result = new TypeValueJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeValueAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeValueJSON result)
              {
                if (fieldGeneratorTopic.have_value)
                  {
                    result.setTopic(fieldGeneratorTopic.value);
                    fieldGeneratorTopic.have_value = false;
                  }
                else if ((!(result.hasTopic())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Topic\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeValueJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Topic", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorTopic;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTopic = new JSONHoldingStringGenerator("field \"Topic\" of the TypeValue class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTopic = new JSONHoldingStringGenerator("field \"Topic\" of the TypeValue class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTopic.reset();
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
            protected override void handle_result(TypeValueJSON  result)
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
            public TypeValueJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeValueJSON  result)
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
        protected virtual void handle_result(List<TypeValueJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeValueJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeValueJSON>();
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
        public List<TypeValueJSON> value;
      };
      };
    private bool flagHasValue;
    private List< TypeValueJSON  > storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Value of TopicIdentificationResultsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeValueJSON  > vector_Value1 = new List< TypeValueJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeValueJSON convert_classy = TypeValueJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Value1.Add(convert_classy);
          }
        initValue();
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
            appendValue(vector_Value1[num1]);
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
          {
          }
      }


    public TopicIdentificationResultsJSON()
      {
        flagHasValue = false;
        storeValue = new List< TypeValueJSON  >();
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public int  countOfValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue.Count;
      }

    public TypeValueJSON   elementOfValue(int element_num)
      {
        Debug.Assert(flagHasValue);
        return storeValue[element_num];
      }

    public List< TypeValueJSON  >  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }



    public void initValue()
      {
        if (flagHasValue)
          {
            for (int num1 = 0; num1 < storeValue.Count; ++num1)
              {
              }
          }
        flagHasValue = true;
        storeValue.Clear();
      }
    public void appendValue(TypeValueJSON  to_append)
      {
        if (!flagHasValue)
          {
            flagHasValue = true;
            storeValue.Clear();
          }
        Debug.Assert(flagHasValue);
        storeValue.Add(to_append);
      }
    public void unsetValue()
      {
        if (flagHasValue)
          {
            for (int num2 = 0; num2 < storeValue.Count; ++num2)
              {
              }
          }
        flagHasValue = false;
        storeValue.Clear();
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num1 = 0; num1 < storeValue.Count; ++num1)
          {
            storeValue[num1].write_as_json(handler);
          }
        handler.finish_array();
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num2 = 0; num2 < storeValue.Count; ++num2)
          {
            storeValue[num2].write_partial_as_json(handler);
          }
        handler.finish_array();
      }

    public static TopicIdentificationResultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TopicIdentificationResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TopicIdentificationResults", ignore_extras);
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
    public static TopicIdentificationResultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TopicIdentificationResultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TopicIdentificationResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TopicIdentificationResults", ignore_extras);
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
    public static TopicIdentificationResultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TopicIdentificationResultsJSON from_text(string text, bool ignore_extras)
      {
        TopicIdentificationResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TopicIdentificationResults", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TopicIdentificationResultsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TopicIdentificationResultsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TopicIdentificationResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TopicIdentificationResults", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : TypeValueJSON.HoldingArrayGenerator
      {
        protected void finish()
          {
            Debug.Assert(have_value);
            TopicIdentificationResultsJSON result = new TopicIdentificationResultsJSON();
            result.initValue();
            int count = value.Count;
            for (int num = 0; num < count; ++num)
              {
                result.appendValue(value[num]);
              }
            handle_result(result);
          }
        protected abstract void handle_result(TopicIdentificationResultsJSON new_result);
        public Generator(bool ignore_extras) : base("Type TopicIdentificationResults", ignore_extras)
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TopicIdentificationResultsJSON  result)
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
        public TopicIdentificationResultsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TopicIdentificationResultsJSON  result)
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
    protected virtual void handle_result(List<TopicIdentificationResultsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TopicIdentificationResultsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TopicIdentificationResultsJSON>();
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
    public List<TopicIdentificationResultsJSON> value;
  };
  };
