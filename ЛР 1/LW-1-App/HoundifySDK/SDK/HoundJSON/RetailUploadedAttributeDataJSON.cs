/* file "RetailUploadedAttributeDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RetailUploadedAttributeDataJSON : JSONBase
  {
    private bool flagHasExpressions;
    private List< RetailUploadedAttributeExpressionJSON  > storeExpressions;
    private bool flagHasAttribute;
    private RetailProductAttributeJSON  storeAttribute;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONExpressions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Expressions of RetailUploadedAttributeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Expressions of RetailUploadedAttributeDataJSON has too few elements.");
        List< RetailUploadedAttributeExpressionJSON  > vector_Expressions1 = new List< RetailUploadedAttributeExpressionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RetailUploadedAttributeExpressionJSON convert_classy = RetailUploadedAttributeExpressionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Expressions1.Add(convert_classy);
          }
        Debug.Assert(vector_Expressions1.Count >= 1);
        initExpressions();
        for (int num1 = 0; num1 < vector_Expressions1.Count; ++num1)
            appendExpressions(vector_Expressions1[num1]);
        for (int num1 = 0; num1 < vector_Expressions1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAttribute(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RetailProductAttributeJSON convert_classy = RetailProductAttributeJSON.from_json(json_value, ignore_extras, true);
        setAttribute(convert_classy);
      }


    public RetailUploadedAttributeDataJSON()
      {
        flagHasExpressions = false;
        flagHasAttribute = false;
        storeExpressions = new List< RetailUploadedAttributeExpressionJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasExpressions()
      {
        return flagHasExpressions;
      }

    public int  countOfExpressions()
      {
        Debug.Assert(flagHasExpressions);
        return storeExpressions.Count;
      }

    public RetailUploadedAttributeExpressionJSON   elementOfExpressions(int element_num)
      {
        Debug.Assert(flagHasExpressions);
        return storeExpressions[element_num];
      }

    public List< RetailUploadedAttributeExpressionJSON  >  getExpressions()
      {
        Debug.Assert(flagHasExpressions);
        return storeExpressions;
      }

    public bool  hasAttribute()
      {
        return flagHasAttribute;
      }

    public RetailProductAttributeJSON   getAttribute()
      {
        Debug.Assert(flagHasAttribute);
        return storeAttribute;
      }


    public virtual int extraRetailUploadedAttributeDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRetailUploadedAttributeDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRetailUploadedAttributeDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRetailUploadedAttributeDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initExpressions()
      {
        if (flagHasExpressions)
          {
            for (int num1 = 0; num1 < storeExpressions.Count; ++num1)
              {
              }
          }
        flagHasExpressions = true;
        storeExpressions.Clear();
      }
    public void appendExpressions(RetailUploadedAttributeExpressionJSON  to_append)
      {
        if (!flagHasExpressions)
          {
            flagHasExpressions = true;
            storeExpressions.Clear();
          }
        Debug.Assert(flagHasExpressions);
        storeExpressions.Add(to_append);
      }
    public void unsetExpressions()
      {
        if (flagHasExpressions)
          {
            for (int num2 = 0; num2 < storeExpressions.Count; ++num2)
              {
              }
          }
        flagHasExpressions = false;
        storeExpressions.Clear();
      }
    public void setAttribute(RetailProductAttributeJSON  new_value)
      {
        if (flagHasAttribute)
          {
          }
        flagHasAttribute = true;
        storeAttribute = new_value;
      }
    public void unsetAttribute()
      {
        if (flagHasAttribute)
          {
          }
        flagHasAttribute = false;
      }

    public virtual void extraRetailUploadedAttributeDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRetailUploadedAttributeDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRetailUploadedAttributeDataLookup(key);
        if (old_field == null)
          {
            extraRetailUploadedAttributeDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasExpressions);
        if (flagHasExpressions)
          {
            handler.start_pair("Expressions");
            Debug.Assert(storeExpressions.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeExpressions.Count; ++num1)
              {
                if (partial_allowed)
                    storeExpressions[num1].write_partial_as_json(handler);
                else
                    storeExpressions[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasAttribute);
        if (flagHasAttribute)
          {
            handler.start_pair("Attribute");
            if (partial_allowed)
                storeAttribute.write_partial_as_json(handler);
            else
                storeAttribute.write_as_json(handler);
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
        if (!(hasExpressions()))
          {
            return "When parsing the object for %what%, the \"Expressions\" field was missing.";
          }
        if (!(hasAttribute()))
          {
            return "When parsing the object for %what%, the \"Attribute\" field was missing.";
          }
        return null;
      }

    public static RetailUploadedAttributeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RetailUploadedAttributeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailUploadedAttributeData", ignore_extras);
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
    public static RetailUploadedAttributeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RetailUploadedAttributeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RetailUploadedAttributeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailUploadedAttributeData", ignore_extras);
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
    public static RetailUploadedAttributeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RetailUploadedAttributeDataJSON from_text(string text, bool ignore_extras)
      {
        RetailUploadedAttributeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailUploadedAttributeData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RetailUploadedAttributeDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RetailUploadedAttributeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RetailUploadedAttributeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RetailUploadedAttributeData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private RetailUploadedAttributeExpressionJSON.HoldingArrayGenerator fieldGeneratorExpressions;
        private RetailProductAttributeJSON.HoldingGenerator fieldGeneratorAttribute;
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
            RetailUploadedAttributeDataJSON result = new RetailUploadedAttributeDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRetailUploadedAttributeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RetailUploadedAttributeDataJSON result)
          {
            if (fieldGeneratorExpressions.have_value)
              {
                result.initExpressions();
                int count = fieldGeneratorExpressions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendExpressions(fieldGeneratorExpressions.value[num]);
                  }
                fieldGeneratorExpressions.value.Clear();
                fieldGeneratorExpressions.have_value = false;
              }
            else if ((!(result.hasExpressions())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Expressions\" field was missing.");
              }
            if (fieldGeneratorAttribute.have_value)
              {
                result.setAttribute(fieldGeneratorAttribute.value);
                fieldGeneratorAttribute.have_value = false;
              }
            else if ((!(result.hasAttribute())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Attribute\" field was missing.");
              }
          }
        protected abstract void handle_result(RetailUploadedAttributeDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttribute", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorAttribute;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "xpressions", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorExpressions;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorExpressions = new RetailUploadedAttributeExpressionJSON.HoldingArrayGenerator("field \"Expressions\" of the RetailUploadedAttributeData class", ignore_extras);
            fieldGeneratorAttribute = new RetailProductAttributeJSON.HoldingGenerator("field \"Attribute\" of the RetailUploadedAttributeData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RetailUploadedAttributeData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorExpressions = new RetailUploadedAttributeExpressionJSON.HoldingArrayGenerator("field \"Expressions\" of the RetailUploadedAttributeData class", false);
            fieldGeneratorAttribute = new RetailProductAttributeJSON.HoldingGenerator("field \"Attribute\" of the RetailUploadedAttributeData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RetailUploadedAttributeData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorExpressions.reset();
            fieldGeneratorAttribute.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorExpressions.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAttribute.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorExpressions.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAttribute.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RetailUploadedAttributeDataJSON  result)
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
        public RetailUploadedAttributeDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RetailUploadedAttributeDataJSON  result)
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
    protected virtual void handle_result(List<RetailUploadedAttributeDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RetailUploadedAttributeDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RetailUploadedAttributeDataJSON>();
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
    public List<RetailUploadedAttributeDataJSON> value;
  };
  };
