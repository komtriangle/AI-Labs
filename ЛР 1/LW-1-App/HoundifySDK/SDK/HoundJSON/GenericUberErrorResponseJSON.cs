/* file "GenericUberErrorResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class GenericUberErrorResponseJSON : JSONBase
  {
    private bool flagHaserrors;
    private List< GenericUberErrorJSON  > storeerrors;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONerrors(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field errors of GenericUberErrorResponseJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field errors of GenericUberErrorResponseJSON has too few elements.");
        List< GenericUberErrorJSON  > vector_errors1 = new List< GenericUberErrorJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            GenericUberErrorJSON convert_classy = GenericUberErrorJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_errors1.Add(convert_classy);
          }
        Debug.Assert(vector_errors1.Count >= 1);
        initerrors();
        for (int num1 = 0; num1 < vector_errors1.Count; ++num1)
            appenderrors(vector_errors1[num1]);
        for (int num1 = 0; num1 < vector_errors1.Count; ++num1)
          {
          }
      }


    public GenericUberErrorResponseJSON()
      {
        flagHaserrors = false;
        storeerrors = new List< GenericUberErrorJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  haserrors()
      {
        return flagHaserrors;
      }

    public int  countOferrors()
      {
        Debug.Assert(flagHaserrors);
        return storeerrors.Count;
      }

    public GenericUberErrorJSON   elementOferrors(int element_num)
      {
        Debug.Assert(flagHaserrors);
        return storeerrors[element_num];
      }

    public List< GenericUberErrorJSON  >  geterrors()
      {
        Debug.Assert(flagHaserrors);
        return storeerrors;
      }


    public virtual int extraGenericUberErrorResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGenericUberErrorResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGenericUberErrorResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGenericUberErrorResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initerrors()
      {
        if (flagHaserrors)
          {
            for (int num1 = 0; num1 < storeerrors.Count; ++num1)
              {
              }
          }
        flagHaserrors = true;
        storeerrors.Clear();
      }
    public void appenderrors(GenericUberErrorJSON  to_append)
      {
        if (!flagHaserrors)
          {
            flagHaserrors = true;
            storeerrors.Clear();
          }
        Debug.Assert(flagHaserrors);
        storeerrors.Add(to_append);
      }
    public void unseterrors()
      {
        if (flagHaserrors)
          {
            for (int num2 = 0; num2 < storeerrors.Count; ++num2)
              {
              }
          }
        flagHaserrors = false;
        storeerrors.Clear();
      }

    public virtual void extraGenericUberErrorResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGenericUberErrorResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGenericUberErrorResponseLookup(key);
        if (old_field == null)
          {
            extraGenericUberErrorResponseAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHaserrors);
        if (flagHaserrors)
          {
            handler.start_pair("errors");
            Debug.Assert(storeerrors.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeerrors.Count; ++num1)
              {
                if (partial_allowed)
                    storeerrors[num1].write_partial_as_json(handler);
                else
                    storeerrors[num1].write_as_json(handler);
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
        if (!(haserrors()))
          {
            return "When parsing the object for %what%, the \"errors\" field was missing.";
          }
        return null;
      }

    public static GenericUberErrorResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GenericUberErrorResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GenericUberErrorResponse", ignore_extras);
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
    public static GenericUberErrorResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GenericUberErrorResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GenericUberErrorResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GenericUberErrorResponse", ignore_extras);
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
    public static GenericUberErrorResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GenericUberErrorResponseJSON from_text(string text, bool ignore_extras)
      {
        GenericUberErrorResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GenericUberErrorResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GenericUberErrorResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static GenericUberErrorResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GenericUberErrorResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GenericUberErrorResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private GenericUberErrorJSON.HoldingArrayGenerator fieldGeneratorerrors;
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
            GenericUberErrorResponseJSON result = new GenericUberErrorResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGenericUberErrorResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(GenericUberErrorResponseJSON result)
          {
            if (fieldGeneratorerrors.have_value)
              {
                result.initerrors();
                int count = fieldGeneratorerrors.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appenderrors(fieldGeneratorerrors.value[num]);
                  }
                fieldGeneratorerrors.value.Clear();
                fieldGeneratorerrors.have_value = false;
              }
            else if ((!(result.haserrors())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"errors\" field was missing.");
              }
          }
        protected abstract void handle_result(GenericUberErrorResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "errors", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorerrors;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorerrors = new GenericUberErrorJSON.HoldingArrayGenerator("field \"errors\" of the GenericUberErrorResponse class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GenericUberErrorResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorerrors = new GenericUberErrorJSON.HoldingArrayGenerator("field \"errors\" of the GenericUberErrorResponse class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GenericUberErrorResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorerrors.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorerrors.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorerrors.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(GenericUberErrorResponseJSON  result)
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
        public GenericUberErrorResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GenericUberErrorResponseJSON  result)
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
    protected virtual void handle_result(List<GenericUberErrorResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GenericUberErrorResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GenericUberErrorResponseJSON>();
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
    public List<GenericUberErrorResponseJSON> value;
  };
  };
