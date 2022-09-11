/* file "AnswerOptionsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class AnswerOptionsJSON : JSONBase
  {
    private bool flagHasSuccessor;
    private BigInteger storeSuccessor;
    private bool flagHasPredicateList;
    private List< BigInteger > storePredicateList;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSuccessor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Successor of AnswerOptionsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Successor of AnswerOptionsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSuccessor(extracted_integer);
      }


    private void  fromJSONPredicateList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PredicateList of AnswerOptionsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_PredicateList1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field PredicateList of AnswerOptionsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field PredicateList of AnswerOptionsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_PredicateList1.Add(extracted_integer);
          }
        initPredicateList();
        for (int num1 = 0; num1 < vector_PredicateList1.Count; ++num1)
            appendPredicateList(vector_PredicateList1[num1]);
        for (int num1 = 0; num1 < vector_PredicateList1.Count; ++num1)
          {
          }
      }


    public AnswerOptionsJSON()
      {
        flagHasSuccessor = false;
        flagHasPredicateList = false;
        storePredicateList = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSuccessor()
      {
        return flagHasSuccessor;
      }

    public BigInteger  getSuccessor()
      {
        Debug.Assert(flagHasSuccessor);
        return storeSuccessor;
      }

    public bool  hasPredicateList()
      {
        return flagHasPredicateList;
      }

    public int  countOfPredicateList()
      {
        Debug.Assert(flagHasPredicateList);
        return storePredicateList.Count;
      }

    public BigInteger  elementOfPredicateList(int element_num)
      {
        Debug.Assert(flagHasPredicateList);
        return storePredicateList[element_num];
      }

    public List< BigInteger >  getPredicateList()
      {
        Debug.Assert(flagHasPredicateList);
        return storePredicateList;
      }


    public virtual int extraAnswerOptionsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAnswerOptionsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAnswerOptionsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAnswerOptionsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSuccessor(BigInteger new_value)
      {
        flagHasSuccessor = true;
        if (new_value < 0)
            throw new Exception("The value for field Successor of AnswerOptionsJSON is less than the lower bound (0) for that field.");
        storeSuccessor = new_value;
      }
    public void unsetSuccessor()
      {
        flagHasSuccessor = false;
      }
    public void initPredicateList()
      {
        flagHasPredicateList = true;
        storePredicateList.Clear();
      }
    public void appendPredicateList(BigInteger to_append)
      {
        if (!flagHasPredicateList)
          {
            flagHasPredicateList = true;
            storePredicateList.Clear();
          }
        Debug.Assert(flagHasPredicateList);
        storePredicateList.Add(to_append);
      }
    public void unsetPredicateList()
      {
        flagHasPredicateList = false;
        storePredicateList.Clear();
      }

    public virtual void extraAnswerOptionsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAnswerOptionsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAnswerOptionsLookup(key);
        if (old_field == null)
          {
            extraAnswerOptionsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSuccessor);
        if (flagHasSuccessor)
          {
            handler.start_pair("Successor");
            handler.number_value(storeSuccessor);
          }
        Debug.Assert(partial_allowed || flagHasPredicateList);
        if (flagHasPredicateList)
          {
            handler.start_pair("PredicateList");
            handler.start_array();
            for (int num1 = 0; num1 < storePredicateList.Count; ++num1)
              {
                handler.number_value(storePredicateList[num1]);
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
        if (!(hasSuccessor()))
          {
            return "When parsing the object for %what%, the \"Successor\" field was missing.";
          }
        if (!(hasPredicateList()))
          {
            return "When parsing the object for %what%, the \"PredicateList\" field was missing.";
          }
        return null;
      }

    public static AnswerOptionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AnswerOptionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AnswerOptions", ignore_extras);
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
    public static AnswerOptionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AnswerOptionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AnswerOptionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AnswerOptions", ignore_extras);
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
    public static AnswerOptionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AnswerOptionsJSON from_text(string text, bool ignore_extras)
      {
        AnswerOptionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AnswerOptions", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AnswerOptionsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AnswerOptionsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AnswerOptionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AnswerOptions", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorSuccessor : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSuccessor(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSuccessor : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSuccessor(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSuccessor fieldGeneratorSuccessor;
    private class FieldHoldingGeneratorPredicateList : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorPredicateList(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorPredicateList : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorPredicateList(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorPredicateList fieldGeneratorPredicateList;
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
            AnswerOptionsJSON result = new AnswerOptionsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAnswerOptionsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(AnswerOptionsJSON result)
          {
            if (fieldGeneratorSuccessor.have_value)
              {
                result.setSuccessor(fieldGeneratorSuccessor.value);
                fieldGeneratorSuccessor.have_value = false;
              }
            else if ((!(result.hasSuccessor())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Successor\" field was missing.");
              }
            if (fieldGeneratorPredicateList.have_value)
              {
                result.initPredicateList();
                int count = fieldGeneratorPredicateList.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPredicateList(fieldGeneratorPredicateList.value[num]);
                  }
                fieldGeneratorPredicateList.value.Clear();
                fieldGeneratorPredicateList.have_value = false;
              }
            else if ((!(result.hasPredicateList())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PredicateList\" field was missing.");
              }
          }
        protected abstract void handle_result(AnswerOptionsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'P':
                    if ((String.Compare(field_name, 1, "redicateList", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorPredicateList;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "uccessor", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorSuccessor;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSuccessor = new FieldHoldingGeneratorSuccessor("field \"Successor\" of the AnswerOptions class");
            fieldGeneratorPredicateList = new FieldHoldingArrayGeneratorPredicateList("field \"PredicateList\" of the AnswerOptions class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AnswerOptions class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSuccessor = new FieldHoldingGeneratorSuccessor("field \"Successor\" of the AnswerOptions class");
            fieldGeneratorPredicateList = new FieldHoldingArrayGeneratorPredicateList("field \"PredicateList\" of the AnswerOptions class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AnswerOptions class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSuccessor.reset();
            fieldGeneratorPredicateList.reset();
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
        protected override void handle_result(AnswerOptionsJSON  result)
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
        public AnswerOptionsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AnswerOptionsJSON  result)
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
    protected virtual void handle_result(List<AnswerOptionsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AnswerOptionsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AnswerOptionsJSON>();
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
    public List<AnswerOptionsJSON> value;
  };
  };
