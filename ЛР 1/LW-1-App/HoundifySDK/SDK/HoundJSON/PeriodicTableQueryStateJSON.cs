/* file "PeriodicTableQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class PeriodicTableQueryStateJSON : JSONBase
  {
    private bool flagHasElements;
    private List< BigInteger > storeElements;
    private bool flagHasQueryTypes;
    private List< BigInteger > storeQueryTypes;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONElements(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Elements of PeriodicTableQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Elements of PeriodicTableQueryStateJSON has too few elements.");
        List< BigInteger > vector_Elements1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field Elements of PeriodicTableQueryStateJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field Elements of PeriodicTableQueryStateJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_Elements1.Add(extracted_integer);
          }
        Debug.Assert(vector_Elements1.Count >= 1);
        initElements();
        for (int num1 = 0; num1 < vector_Elements1.Count; ++num1)
            appendElements(vector_Elements1[num1]);
        for (int num1 = 0; num1 < vector_Elements1.Count; ++num1)
          {
          }
      }


    private void  fromJSONQueryTypes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueryTypes of PeriodicTableQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field QueryTypes of PeriodicTableQueryStateJSON has too few elements.");
        List< BigInteger > vector_QueryTypes1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field QueryTypes of PeriodicTableQueryStateJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field QueryTypes of PeriodicTableQueryStateJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_QueryTypes1.Add(extracted_integer);
          }
        Debug.Assert(vector_QueryTypes1.Count >= 1);
        initQueryTypes();
        for (int num2 = 0; num2 < vector_QueryTypes1.Count; ++num2)
            appendQueryTypes(vector_QueryTypes1[num2]);
        for (int num1 = 0; num1 < vector_QueryTypes1.Count; ++num1)
          {
          }
      }


    public PeriodicTableQueryStateJSON()
      {
        flagHasElements = false;
        flagHasQueryTypes = false;
        storeElements = new List< BigInteger >();
        storeQueryTypes = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasElements()
      {
        return flagHasElements;
      }

    public int  countOfElements()
      {
        Debug.Assert(flagHasElements);
        return storeElements.Count;
      }

    public BigInteger  elementOfElements(int element_num)
      {
        Debug.Assert(flagHasElements);
        return storeElements[element_num];
      }

    public List< BigInteger >  getElements()
      {
        Debug.Assert(flagHasElements);
        return storeElements;
      }

    public bool  hasQueryTypes()
      {
        return flagHasQueryTypes;
      }

    public int  countOfQueryTypes()
      {
        Debug.Assert(flagHasQueryTypes);
        return storeQueryTypes.Count;
      }

    public BigInteger  elementOfQueryTypes(int element_num)
      {
        Debug.Assert(flagHasQueryTypes);
        return storeQueryTypes[element_num];
      }

    public List< BigInteger >  getQueryTypes()
      {
        Debug.Assert(flagHasQueryTypes);
        return storeQueryTypes;
      }


    public virtual int extraPeriodicTableQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPeriodicTableQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPeriodicTableQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPeriodicTableQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initElements()
      {
        flagHasElements = true;
        storeElements.Clear();
      }
    public void appendElements(BigInteger to_append)
      {
        if (!flagHasElements)
          {
            flagHasElements = true;
            storeElements.Clear();
          }
        Debug.Assert(flagHasElements);
        storeElements.Add(to_append);
      }
    public void unsetElements()
      {
        flagHasElements = false;
        storeElements.Clear();
      }
    public void initQueryTypes()
      {
        flagHasQueryTypes = true;
        storeQueryTypes.Clear();
      }
    public void appendQueryTypes(BigInteger to_append)
      {
        if (!flagHasQueryTypes)
          {
            flagHasQueryTypes = true;
            storeQueryTypes.Clear();
          }
        Debug.Assert(flagHasQueryTypes);
        storeQueryTypes.Add(to_append);
      }
    public void unsetQueryTypes()
      {
        flagHasQueryTypes = false;
        storeQueryTypes.Clear();
      }

    public virtual void extraPeriodicTableQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPeriodicTableQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPeriodicTableQueryStateLookup(key);
        if (old_field == null)
          {
            extraPeriodicTableQueryStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasElements);
        if (flagHasElements)
          {
            handler.start_pair("Elements");
            Debug.Assert(storeElements.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeElements.Count; ++num1)
              {
                handler.number_value(storeElements[num1]);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasQueryTypes);
        if (flagHasQueryTypes)
          {
            handler.start_pair("QueryTypes");
            Debug.Assert(storeQueryTypes.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeQueryTypes.Count; ++num2)
              {
                handler.number_value(storeQueryTypes[num2]);
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
        if (!(hasElements()))
          {
            return "When parsing the object for %what%, the \"Elements\" field was missing.";
          }
        if (!(hasQueryTypes()))
          {
            return "When parsing the object for %what%, the \"QueryTypes\" field was missing.";
          }
        return null;
      }

    public static PeriodicTableQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PeriodicTableQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PeriodicTableQueryState", ignore_extras);
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
    public static PeriodicTableQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PeriodicTableQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PeriodicTableQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PeriodicTableQueryState", ignore_extras);
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
    public static PeriodicTableQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PeriodicTableQueryStateJSON from_text(string text, bool ignore_extras)
      {
        PeriodicTableQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PeriodicTableQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PeriodicTableQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static PeriodicTableQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PeriodicTableQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PeriodicTableQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorElements : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorElements(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorElements : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorElements(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorElements fieldGeneratorElements;
    private class FieldHoldingGeneratorQueryTypes : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorQueryTypes(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorQueryTypes : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorQueryTypes(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorQueryTypes fieldGeneratorQueryTypes;
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
            PeriodicTableQueryStateJSON result = new PeriodicTableQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPeriodicTableQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(PeriodicTableQueryStateJSON result)
          {
            if (fieldGeneratorElements.have_value)
              {
                result.initElements();
                int count = fieldGeneratorElements.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendElements(fieldGeneratorElements.value[num]);
                  }
                fieldGeneratorElements.value.Clear();
                fieldGeneratorElements.have_value = false;
              }
            else if ((!(result.hasElements())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Elements\" field was missing.");
              }
            if (fieldGeneratorQueryTypes.have_value)
              {
                result.initQueryTypes();
                int count = fieldGeneratorQueryTypes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendQueryTypes(fieldGeneratorQueryTypes.value[num]);
                  }
                fieldGeneratorQueryTypes.value.Clear();
                fieldGeneratorQueryTypes.have_value = false;
              }
            else if ((!(result.hasQueryTypes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryTypes\" field was missing.");
              }
          }
        protected abstract void handle_result(PeriodicTableQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "lements", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorElements;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryTypes", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorQueryTypes;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorElements = new FieldHoldingArrayGeneratorElements("field \"Elements\" of the PeriodicTableQueryState class");
            fieldGeneratorQueryTypes = new FieldHoldingArrayGeneratorQueryTypes("field \"QueryTypes\" of the PeriodicTableQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the PeriodicTableQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorElements = new FieldHoldingArrayGeneratorElements("field \"Elements\" of the PeriodicTableQueryState class");
            fieldGeneratorQueryTypes = new FieldHoldingArrayGeneratorQueryTypes("field \"QueryTypes\" of the PeriodicTableQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the PeriodicTableQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorElements.reset();
            fieldGeneratorQueryTypes.reset();
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
        protected override void handle_result(PeriodicTableQueryStateJSON  result)
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
        public PeriodicTableQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PeriodicTableQueryStateJSON  result)
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
    protected virtual void handle_result(List<PeriodicTableQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PeriodicTableQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PeriodicTableQueryStateJSON>();
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
    public List<PeriodicTableQueryStateJSON> value;
  };
  };
