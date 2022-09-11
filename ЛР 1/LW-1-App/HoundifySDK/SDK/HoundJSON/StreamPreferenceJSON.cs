/* file "StreamPreferenceJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StreamPreferenceJSON : JSONBase
  {
    private bool flagHasEncodings;
    private List< StreamEncodingEnumJSON  > storeEncodings;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONEncodings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Encodings of StreamPreferenceJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< StreamEncodingEnumJSON  > vector_Encodings1 = new List< StreamEncodingEnumJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            StreamEncodingEnumJSON convert_classy = StreamEncodingEnumJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Encodings1.Add(convert_classy);
          }
        initEncodings();
        for (int num1 = 0; num1 < vector_Encodings1.Count; ++num1)
            appendEncodings(vector_Encodings1[num1]);
        for (int num1 = 0; num1 < vector_Encodings1.Count; ++num1)
          {
          }
      }


    public StreamPreferenceJSON()
      {
        flagHasEncodings = false;
        storeEncodings = new List< StreamEncodingEnumJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasEncodings()
      {
        return flagHasEncodings;
      }

    public int  countOfEncodings()
      {
        Debug.Assert(flagHasEncodings);
        return storeEncodings.Count;
      }

    public StreamEncodingEnumJSON   elementOfEncodings(int element_num)
      {
        Debug.Assert(flagHasEncodings);
        return storeEncodings[element_num];
      }

    public List< StreamEncodingEnumJSON  >  getEncodings()
      {
        Debug.Assert(flagHasEncodings);
        return storeEncodings;
      }


    public virtual int extraStreamPreferenceComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStreamPreferenceComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStreamPreferenceComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStreamPreferenceLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initEncodings()
      {
        if (flagHasEncodings)
          {
            for (int num1 = 0; num1 < storeEncodings.Count; ++num1)
              {
              }
          }
        flagHasEncodings = true;
        storeEncodings.Clear();
      }
    public void appendEncodings(StreamEncodingEnumJSON  to_append)
      {
        if (!flagHasEncodings)
          {
            flagHasEncodings = true;
            storeEncodings.Clear();
          }
        Debug.Assert(flagHasEncodings);
        storeEncodings.Add(to_append);
      }
    public void appendEncodings(StreamEncodingEnumJSON.TypeValue new_value)
      {
        appendEncodings(new StreamEncodingEnumJSON(new_value));
      }
    public void appendEncodings(string chars)
      {
        StreamEncodingEnumJSON.TypeValueKnownValues known = StreamEncodingEnumJSON.stringToValue(chars);
        StreamEncodingEnumJSON.TypeValue new_value = new StreamEncodingEnumJSON.TypeValue();
        if (known == StreamEncodingEnumJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendEncodings(new_value);
      }
    public void unsetEncodings()
      {
        if (flagHasEncodings)
          {
            for (int num2 = 0; num2 < storeEncodings.Count; ++num2)
              {
              }
          }
        flagHasEncodings = false;
        storeEncodings.Clear();
      }

    public virtual void extraStreamPreferenceAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStreamPreferenceSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStreamPreferenceLookup(key);
        if (old_field == null)
          {
            extraStreamPreferenceAppendPair(key, new_component);
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
        if (flagHasEncodings)
          {
            handler.start_pair("Encodings");
            handler.start_array();
            for (int num1 = 0; num1 < storeEncodings.Count; ++num1)
              {
                if (partial_allowed)
                    storeEncodings[num1].write_partial_as_json(handler);
                else
                    storeEncodings[num1].write_as_json(handler);
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

    public static StreamPreferenceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StreamPreferenceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamPreference", ignore_extras);
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
    public static StreamPreferenceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StreamPreferenceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StreamPreferenceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamPreference", ignore_extras);
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
    public static StreamPreferenceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StreamPreferenceJSON from_text(string text, bool ignore_extras)
      {
        StreamPreferenceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamPreference", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StreamPreferenceJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StreamPreferenceJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StreamPreferenceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamPreference", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private StreamEncodingEnumJSON.HoldingArrayGenerator fieldGeneratorEncodings;
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
            StreamPreferenceJSON result = new StreamPreferenceJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStreamPreferenceAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StreamPreferenceJSON result)
          {
            if (fieldGeneratorEncodings.have_value)
              {
                result.initEncodings();
                int count = fieldGeneratorEncodings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEncodings(fieldGeneratorEncodings.value[num]);
                  }
                fieldGeneratorEncodings.value.Clear();
                fieldGeneratorEncodings.have_value = false;
              }
          }
        protected abstract void handle_result(StreamPreferenceJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Encodings", 0, 9, false) == 0) && (field_name.Length == 9))
                return fieldGeneratorEncodings;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorEncodings = new StreamEncodingEnumJSON.HoldingArrayGenerator("field \"Encodings\" of the StreamPreference class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StreamPreference class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorEncodings = new StreamEncodingEnumJSON.HoldingArrayGenerator("field \"Encodings\" of the StreamPreference class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StreamPreference class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorEncodings.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorEncodings.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorEncodings.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StreamPreferenceJSON  result)
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
        public StreamPreferenceJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StreamPreferenceJSON  result)
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
    protected virtual void handle_result(List<StreamPreferenceJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StreamPreferenceJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StreamPreferenceJSON>();
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
    public List<StreamPreferenceJSON> value;
  };
  };
